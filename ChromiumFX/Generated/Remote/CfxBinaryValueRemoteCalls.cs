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

    internal class CfxBinaryValueCreateRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueCreateRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueCreateRenderProcessCall) {}

        internal IntPtr data;
        internal ulong dataSize;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(data);
            h.Write(dataSize);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out data);
            h.Read(out dataSize);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.BinaryValue.cfx_binary_value_create(data, (UIntPtr)dataSize);
        }
    }

    internal class CfxBinaryValueIsValidRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueIsValidRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.BinaryValue.cfx_binary_value_is_valid(@this);
        }
    }

    internal class CfxBinaryValueIsOwnedRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueIsOwnedRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueIsOwnedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.BinaryValue.cfx_binary_value_is_owned(@this);
        }
    }

    internal class CfxBinaryValueIsSameRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueIsSameRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueIsSameRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr that;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(that);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out that);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.BinaryValue.cfx_binary_value_is_same(@this, that);
        }
    }

    internal class CfxBinaryValueIsEqualRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueIsEqualRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueIsEqualRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr that;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(that);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out that);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.BinaryValue.cfx_binary_value_is_equal(@this, that);
        }
    }

    internal class CfxBinaryValueCopyRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueCopyRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueCopyRenderProcessCall) {}

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
            __retval = CfxApi.BinaryValue.cfx_binary_value_copy(@this);
        }
    }

    internal class CfxBinaryValueGetSizeRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueGetSizeRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueGetSizeRenderProcessCall) {}

        internal IntPtr @this;
        internal ulong __retval;

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
            __retval = (ulong)CfxApi.BinaryValue.cfx_binary_value_get_size(@this);
        }
    }

    internal class CfxBinaryValueGetDataRenderProcessCall : RenderProcessCall {

        internal CfxBinaryValueGetDataRenderProcessCall()
            : base(RemoteCallId.CfxBinaryValueGetDataRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr buffer;
        internal ulong bufferSize;
        internal ulong dataOffset;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(buffer);
            h.Write(bufferSize);
            h.Write(dataOffset);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out buffer);
            h.Read(out bufferSize);
            h.Read(out dataOffset);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = (ulong)CfxApi.BinaryValue.cfx_binary_value_get_data(@this, buffer, (UIntPtr)bufferSize, (UIntPtr)dataOffset);
        }
    }

}
