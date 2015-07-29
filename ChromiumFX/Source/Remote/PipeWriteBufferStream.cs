using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace Chromium.Remote {
    /// <summary>
    /// Buffer data until Flush() or until the buffer is full in
    /// an attempt to bundle several pipe read/write operations
    /// into one.
    /// </summary>
    class PipeWriteBufferStream : Stream {

        internal const int bufferLength = 1024;

        internal readonly PipeStream pipe;
        private readonly byte[] buffer;

        private int bufferCount;

        internal PipeWriteBufferStream(PipeStream pipe) {
            this.pipe = pipe;
            buffer = new byte[bufferLength];
            bufferCount = 0;
        }

        public override void Write(byte[] buffer, int offset, int count) {
            do {
                
                var bytes = count > bufferLength - bufferCount ?
                    bufferLength - bufferCount : count;

                Array.Copy(buffer, offset, this.buffer, bufferCount, bytes);
                bufferCount += bytes;
                offset += bytes;
                count -= bytes;

                
                if(bufferCount == bufferLength) {
                    pipe.Write(this.buffer, 0, bufferCount);
                    bufferCount = 0;
                }

            } while(count > 0);
        }

        public override void WriteByte(byte value) {
            buffer[bufferCount] = (byte)value;
            ++bufferCount;
            if(bufferCount == bufferLength) {
                pipe.Write(this.buffer, 0, bufferCount);
                bufferCount = 0;
            }
        }

        public override void Flush() {
            if(bufferCount > 0) {
                pipe.Write(this.buffer, 0, bufferCount);
                bufferCount = 0;
            }
        }

        public override bool CanRead {
            get { return false; }
        }

        public override bool CanSeek {
            get { return false; }
        }

        public override bool CanWrite {
            get { return true; }
        }

        public override long Length {
            get { throw new NotSupportedException(); }
        }

        public override long Position {
            get {
                throw new NotSupportedException();
            }
            set {
                throw new NotSupportedException();
            }
        }

        public override int Read(byte[] buffer, int offset, int count) {
            throw new NotSupportedException();
        }

        public override long Seek(long offset, SeekOrigin origin) {
            throw new NotSupportedException();
        }

        public override void SetLength(long value) {
            throw new NotSupportedException();
        }
    }
}
