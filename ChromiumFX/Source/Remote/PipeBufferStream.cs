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
            return new PipeBufferStream(s, true);
        }

        internal static PipeBufferStream CreateServerOutputStream(string name) {
            var s = new NamedPipeServerStream(name, PipeDirection.Out, 1);
            return new PipeBufferStream(s, false);
        }

        internal static PipeBufferStream CreateClientInputStream(string name) {
            var s = new NamedPipeClientStream(".", name, PipeDirection.In);
            return new PipeBufferStream(s, true);
        }

        internal static PipeBufferStream CreateClientOutputStream(string name) {
            var s = new NamedPipeClientStream(".", name, PipeDirection.Out);
            return new PipeBufferStream(s, false);
        }

        // for 81920, see https://referencesource.microsoft.com/#mscorlib/system/io/stream.cs,50
        internal const int bufferLength = 81920;

        internal readonly PipeStream pipe;

        private readonly byte[] pipeBuffer;
        private int pipeBufferOffset;
        private int pipeBufferCount;

        private bool isInputStream;

        private PipeBufferStream(PipeStream pipe, bool isInputStream) {
            this.pipe = pipe;
            this.isInputStream = isInputStream;
            pipeBuffer = new byte[bufferLength];
        }

        internal void Connect() {
            if(pipe is NamedPipeServerStream)
                (pipe as NamedPipeServerStream).WaitForConnection();
            else
                (pipe as NamedPipeClientStream).Connect();
        }

        public override void Write(byte[] buffer, int offset, int count) {

            Debug.Assert(!isInputStream);

            if(count > bufferLength) {
                // if the user wants to write more than bufferLength bytes,
                // using the buffer would actually split the write instead of bundling it with other writes
                // so we flush the write buffer and then write the whole buffer at once.
                if(pipeBufferCount > 0) {
                    pipe.Write(pipeBuffer, 0, pipeBufferCount);
                    pipeBufferCount = 0;
                }
                pipe.Write(buffer, offset, count);
                return;
            }

            if(count > bufferLength - pipeBufferCount) {
                // the new data doesn't fit in the write buffer,
                // so fill up and flush the buffer
                var bytes = bufferLength - pipeBufferCount;
                Array.Copy(buffer, offset, pipeBuffer, pipeBufferCount, bytes);
                Debug.Assert(pipeBufferCount + bytes == bufferLength);
                pipe.Write(pipeBuffer, 0, bufferLength);
                pipeBufferCount = 0;
                offset += bytes;
                count -= bytes;
            }

            // at this point, the remaining new data is guaranteed to fit in the write buffer
            Debug.Assert(count <= bufferLength - pipeBufferCount);

            if(count > 0) {
                Array.Copy(buffer, offset, pipeBuffer, pipeBufferCount, count);
                pipeBufferCount += count;
                if(pipeBufferCount == bufferLength) {
                    pipe.Write(pipeBuffer, 0, bufferLength);
                    pipeBufferCount = 0;
                }
            }
        }

        public override void WriteByte(byte value) {

            Debug.Assert(!isInputStream);

            pipeBuffer[pipeBufferCount] = (byte)value;
            ++pipeBufferCount;
            if(pipeBufferCount == bufferLength) {
                pipe.Write(pipeBuffer, 0, bufferLength);
                pipeBufferCount = 0;
            }
        }

        public override int Read(byte[] buffer, int offset, int count) {

            Debug.Assert(isInputStream);

            int readCount = 0;

            if(count > bufferLength) {
                // if the user wants to read more than bufferLength bytes,
                // using the buffer would actually lead to more pipe reads instead of less
                // so we flush the read buffer and then read directly from the pipe stream.

                if(pipeBufferCount > 0) {
                    readCount = pipeBufferCount;
                    Array.Copy(pipeBuffer, pipeBufferOffset, buffer, offset, readCount);
                    pipeBufferOffset = 0;
                    pipeBufferCount = 0;
                    offset += readCount;
                    count -= readCount;
                }
                return readCount + pipe.Read(buffer, offset, count);
            }

            if(pipeBufferCount == 0) {
                pipeBufferOffset = 0;
                pipeBufferCount = pipe.Read(pipeBuffer, 0, bufferLength);
                if(pipeBufferCount == 0) return 0;
            }

            readCount = count < pipeBufferCount ? count : pipeBufferCount;
            Array.Copy(pipeBuffer, pipeBufferOffset, buffer, offset, readCount);
            pipeBufferOffset += readCount;
            pipeBufferCount -= readCount;
            return readCount;
        }

        public override int ReadByte() {

            Debug.Assert(isInputStream);

            if(pipeBufferCount == 0) {
                pipeBufferOffset = 0;
                pipeBufferCount = pipe.Read(pipeBuffer, 0, bufferLength);
                if(pipeBufferCount == 0) return -1;
            }
            var retval = pipeBuffer[pipeBufferOffset];
            ++pipeBufferOffset;
            --pipeBufferCount;
            return retval;
        }

        public override void Flush() {

            Debug.Assert(!isInputStream);

            if(pipeBufferCount > 0) {
                pipe.Write(this.pipeBuffer, 0, pipeBufferCount);
                pipeBufferCount = 0;
            }
        }

        public override bool CanRead {
            get { return isInputStream; }
        }

        public override bool CanSeek {
            get { return false; }
        }

        public override bool CanWrite {
            get { return !isInputStream; }
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
