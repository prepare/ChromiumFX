// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace Chromium.Remote {
    /// <summary>
    /// Buffer data until Flush() or until the buffer is full 
    /// and read data into a buffer in an attempt to bundle 
    /// several pipe read/write operations into one.
    /// </summary>
    class PipeBufferStream : Stream {

        internal static PipeBufferStream CreateServerInputStream(string name) {
            var s = new NamedPipeServerStream(name, PipeDirection.In, 1);
            return new PipeBufferStream(s);
        }

        internal static PipeBufferStream CreateServerOutputStream(string name) {
            var s = new NamedPipeServerStream(name, PipeDirection.Out, 1);
            return new PipeBufferStream(s);
        }

        internal static PipeBufferStream CreateClientInputStream(string name) {
            var s = new NamedPipeClientStream(".", name, PipeDirection.In);
            return new PipeBufferStream(s);
        }

        internal static PipeBufferStream CreateClientOutputStream(string name) {
            var s = new NamedPipeClientStream(".", name, PipeDirection.Out);
            return new PipeBufferStream(s);
        }


        internal const int bufferLength = 1024;

        internal readonly PipeStream pipe;

        private readonly byte[] writeBuffer;
        private int writeBufferCount;

        private readonly byte[] readBuffer;
        private int readBufferOffset;
        private int readBufferCount;

        private PipeBufferStream(PipeStream pipe) {
            this.pipe = pipe;
            writeBuffer = new byte[bufferLength];
            readBuffer = new byte[bufferLength];
        }

        internal void Connect() {
            if(pipe is NamedPipeServerStream)
                (pipe as NamedPipeServerStream).WaitForConnection();
            else
                (pipe as NamedPipeClientStream).Connect();
        }

        public override void Write(byte[] buffer, int offset, int count) {

            if(count > bufferLength) {
                // if the user wants to write more than bufferLength bytes,
                // using the buffer would actually split the write instead of bundling it with other writes
                // so we flush the write buffer and then write the whole buffer at once.
                if(writeBufferCount > 0) {
                    pipe.Write(writeBuffer, 0, writeBufferCount);
                    writeBufferCount = 0;
                }
                pipe.Write(buffer, offset, count);
                return;
            }

            if(count > bufferLength - writeBufferCount) {
                // the new data doesn't fit in the write buffer,
                // so fill up and flush the buffer
                var bytes = bufferLength - writeBufferCount;
                Array.Copy(buffer, offset, writeBuffer, writeBufferCount, bytes);
                Debug.Assert(writeBufferCount + bytes == bufferLength);
                pipe.Write(writeBuffer, 0, bufferLength);
                writeBufferCount = 0;
                offset += bytes;
                count -= bytes;
            }

            // at this point, the remaining new data is guaranteed to fit in the write buffer
            Debug.Assert(count <= bufferLength - writeBufferCount);

            if(count > 0) {
                Array.Copy(buffer, offset, writeBuffer, writeBufferCount, count);
                writeBufferCount += count;
                if(writeBufferCount == bufferLength) {
                    pipe.Write(writeBuffer, 0, bufferLength);
                    writeBufferCount = 0;
                }
            }
        }

        public override void WriteByte(byte value) {
            writeBuffer[writeBufferCount] = (byte)value;
            ++writeBufferCount;
            if(writeBufferCount == bufferLength) {
                pipe.Write(writeBuffer, 0, bufferLength);
                writeBufferCount = 0;
            }
        }

        public override int Read(byte[] buffer, int offset, int count) {

            int readCount = 0;

            if(count > bufferLength) {
                // if the user wants to read more than bufferLength bytes,
                // using the buffer would actually lead to more pipe reads instead of less
                // so we flush the read buffer and then read directly from the pipe stream.

                if(readBufferCount > 0) {
                    readCount = readBufferCount;
                    Array.Copy(readBuffer, readBufferOffset, buffer, offset, readCount);
                    readBufferOffset = 0;
                    readBufferCount = 0;
                    offset += readCount;
                    count -= readCount;
                }
                return readCount + pipe.Read(buffer, offset, count);
            }

            if(readBufferCount == 0) {
                readBufferOffset = 0;
                readBufferCount = pipe.Read(readBuffer, 0, bufferLength);
                if(readBufferCount == 0) return 0;
            }

            readCount = count < readBufferCount ? count : readBufferCount;
            Array.Copy(readBuffer, readBufferOffset, buffer, offset, readCount);
            readBufferOffset += readCount;
            readBufferCount -= readCount;
            return readCount;
        }

        public override int ReadByte() {
            if(readBufferCount == 0) {
                readBufferOffset = 0;
                readBufferCount = pipe.Read(readBuffer, 0, bufferLength);
                if(readBufferCount == 0) return -1;
            }
            var retval = readBuffer[readBufferOffset];
            ++readBufferOffset;
            --readBufferCount;
            return retval;
        }

        public override void Flush() {
            if(writeBufferCount > 0) {
                pipe.Write(this.writeBuffer, 0, writeBufferCount);
                writeBufferCount = 0;
            }
        }

        public override bool CanRead {
            get { return pipe.CanRead; }
        }

        public override bool CanSeek {
            get { return false; }
        }

        public override bool CanWrite {
            get { return pipe.CanWrite; }
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

        public override long Seek(long offset, SeekOrigin origin) {
            throw new NotSupportedException();
        }

        public override void SetLength(long value) {
            throw new NotSupportedException();
        }

        public override void Close() {
            pipe.Close();
        }
    }
}
