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

    internal class CfxStreamReaderCreateForFileRemoteCall : RemoteCall {

        internal CfxStreamReaderCreateForFileRemoteCall()
            : base(RemoteCallId.CfxStreamReaderCreateForFileRemoteCall) {}

        internal string fileName;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(fileName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out fileName);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var fileName_pinned = new PinnedString(fileName);
            __retval = CfxApi.StreamReader.cfx_stream_reader_create_for_file(fileName_pinned.Obj.PinnedPtr, fileName_pinned.Length);
            fileName_pinned.Obj.Free();
        }
    }

    internal class CfxStreamReaderCreateForDataRemoteCall : RemoteCall {

        internal CfxStreamReaderCreateForDataRemoteCall()
            : base(RemoteCallId.CfxStreamReaderCreateForDataRemoteCall) {}

        internal IntPtr data;
        internal ulong size;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(data);
            h.Write(size);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out data);
            h.Read(out size);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.StreamReader.cfx_stream_reader_create_for_data(data, (UIntPtr)size);
        }
    }

    internal class CfxStreamReaderCreateForHandlerRemoteCall : RemoteCall {

        internal CfxStreamReaderCreateForHandlerRemoteCall()
            : base(RemoteCallId.CfxStreamReaderCreateForHandlerRemoteCall) {}

        internal IntPtr handler;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(handler);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out handler);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.StreamReader.cfx_stream_reader_create_for_handler(handler);
        }
    }

    internal class CfxStreamReaderReadRemoteCall : RemoteCall {

        internal CfxStreamReaderReadRemoteCall()
            : base(RemoteCallId.CfxStreamReaderReadRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr ptr;
        internal ulong size;
        internal ulong n;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(ptr);
            h.Write(size);
            h.Write(n);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out ptr);
            h.Read(out size);
            h.Read(out n);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = (ulong)CfxApi.StreamReader.cfx_stream_reader_read(@this, ptr, (UIntPtr)size, (UIntPtr)n);
        }
    }

    internal class CfxStreamReaderSeekRemoteCall : RemoteCall {

        internal CfxStreamReaderSeekRemoteCall()
            : base(RemoteCallId.CfxStreamReaderSeekRemoteCall) {}

        internal IntPtr @this;
        internal long offset;
        internal int whence;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(offset);
            h.Write(whence);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out offset);
            h.Read(out whence);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.StreamReader.cfx_stream_reader_seek(@this, offset, whence);
        }
    }

    internal class CfxStreamReaderTellRemoteCall : RemoteCall {

        internal CfxStreamReaderTellRemoteCall()
            : base(RemoteCallId.CfxStreamReaderTellRemoteCall) {}

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
            __retval = CfxApi.StreamReader.cfx_stream_reader_tell(@this);
        }
    }

    internal class CfxStreamReaderEofRemoteCall : RemoteCall {

        internal CfxStreamReaderEofRemoteCall()
            : base(RemoteCallId.CfxStreamReaderEofRemoteCall) {}

        internal IntPtr @this;
        internal int __retval;

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
            __retval = CfxApi.StreamReader.cfx_stream_reader_eof(@this);
        }
    }

    internal class CfxStreamReaderMayBlockRemoteCall : RemoteCall {

        internal CfxStreamReaderMayBlockRemoteCall()
            : base(RemoteCallId.CfxStreamReaderMayBlockRemoteCall) {}

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
            __retval = 0 != CfxApi.StreamReader.cfx_stream_reader_may_block(@this);
        }
    }

}
