// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    internal class CfxZipReaderCreateRemoteCall : RemoteCall {

        internal CfxZipReaderCreateRemoteCall()
            : base(RemoteCallId.CfxZipReaderCreateRemoteCall) {}

        internal IntPtr stream;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(stream);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out stream);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ZipReader.cfx_zip_reader_create(stream);
        }
    }

    internal class CfxZipReaderMoveToFirstFileRemoteCall : RemoteCall {

        internal CfxZipReaderMoveToFirstFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderMoveToFirstFileRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_move_to_first_file(@this);
        }
    }

    internal class CfxZipReaderMoveToNextFileRemoteCall : RemoteCall {

        internal CfxZipReaderMoveToNextFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderMoveToNextFileRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_move_to_next_file(@this);
        }
    }

    internal class CfxZipReaderMoveToFileRemoteCall : RemoteCall {

        internal CfxZipReaderMoveToFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderMoveToFileRemoteCall) {}

        internal IntPtr @this;
        internal string fileName;
        internal bool caseSensitive;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(fileName);
            h.Write(caseSensitive);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out fileName);
            h.Read(out caseSensitive);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var fileName_pinned = new PinnedString(fileName);
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_move_to_file(@this, fileName_pinned.Obj.PinnedPtr, fileName_pinned.Length, caseSensitive ? 1 : 0);
            fileName_pinned.Obj.Free();
        }
    }

    internal class CfxZipReaderCloseRemoteCall : RemoteCall {

        internal CfxZipReaderCloseRemoteCall()
            : base(RemoteCallId.CfxZipReaderCloseRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_close(@this);
        }
    }

    internal class CfxZipReaderGetFileNameRemoteCall : RemoteCall {

        internal CfxZipReaderGetFileNameRemoteCall()
            : base(RemoteCallId.CfxZipReaderGetFileNameRemoteCall) {}

        internal IntPtr @this;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.ZipReader.cfx_zip_reader_get_file_name(@this));
        }
    }

    internal class CfxZipReaderGetFileSizeRemoteCall : RemoteCall {

        internal CfxZipReaderGetFileSizeRemoteCall()
            : base(RemoteCallId.CfxZipReaderGetFileSizeRemoteCall) {}

        internal IntPtr @this;
        internal long __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ZipReader.cfx_zip_reader_get_file_size(@this);
        }
    }

    internal class CfxZipReaderGetFileLastModifiedRemoteCall : RemoteCall {

        internal CfxZipReaderGetFileLastModifiedRemoteCall()
            : base(RemoteCallId.CfxZipReaderGetFileLastModifiedRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ZipReader.cfx_zip_reader_get_file_last_modified(@this);
        }
    }

    internal class CfxZipReaderOpenFileRemoteCall : RemoteCall {

        internal CfxZipReaderOpenFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderOpenFileRemoteCall) {}

        internal IntPtr @this;
        internal string password;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(password);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out password);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var password_pinned = new PinnedString(password);
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_open_file(@this, password_pinned.Obj.PinnedPtr, password_pinned.Length);
            password_pinned.Obj.Free();
        }
    }

    internal class CfxZipReaderCloseFileRemoteCall : RemoteCall {

        internal CfxZipReaderCloseFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderCloseFileRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_close_file(@this);
        }
    }

    internal class CfxZipReaderReadFileRemoteCall : RemoteCall {

        internal CfxZipReaderReadFileRemoteCall()
            : base(RemoteCallId.CfxZipReaderReadFileRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr buffer;
        internal ulong bufferSize;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(buffer);
            h.Write(bufferSize);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out buffer);
            h.Read(out bufferSize);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ZipReader.cfx_zip_reader_read_file(@this, buffer, (UIntPtr)bufferSize);
        }
    }

    internal class CfxZipReaderTellRemoteCall : RemoteCall {

        internal CfxZipReaderTellRemoteCall()
            : base(RemoteCallId.CfxZipReaderTellRemoteCall) {}

        internal IntPtr @this;
        internal long __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ZipReader.cfx_zip_reader_tell(@this);
        }
    }

    internal class CfxZipReaderEofRemoteCall : RemoteCall {

        internal CfxZipReaderEofRemoteCall()
            : base(RemoteCallId.CfxZipReaderEofRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.ZipReader.cfx_zip_reader_eof(@this);
        }
    }

}
