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

    internal class CfxPostDataElementCreateRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementCreateRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementCreateRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.PostDataElement.cfx_post_data_element_create();
        }
    }

    internal class CfxPostDataElementIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementIsReadOnlyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.PostDataElement.cfx_post_data_element_is_read_only(@this);
        }
    }

    internal class CfxPostDataElementSetToEmptyRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementSetToEmptyRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementSetToEmptyRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.PostDataElement.cfx_post_data_element_set_to_empty(@this);
        }
    }

    internal class CfxPostDataElementSetToFileRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementSetToFileRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementSetToFileRenderProcessCall) {}

        internal IntPtr @this;
        internal string fileName;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(fileName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out fileName);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var fileName_pinned = new PinnedString(fileName);
            CfxApi.PostDataElement.cfx_post_data_element_set_to_file(@this, fileName_pinned.Obj.PinnedPtr, fileName_pinned.Length);
            fileName_pinned.Obj.Free();
        }
    }

    internal class CfxPostDataElementSetToBytesRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementSetToBytesRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementSetToBytesRenderProcessCall) {}

        internal IntPtr @this;
        internal ulong size;
        internal IntPtr bytes;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(size);
            h.Write(bytes);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out size);
            h.Read(out bytes);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.PostDataElement.cfx_post_data_element_set_to_bytes(@this, (UIntPtr)size, bytes);
        }
    }

    internal class CfxPostDataElementGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementGetTypeRenderProcessCall) {}

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
            __retval = CfxApi.PostDataElement.cfx_post_data_element_get_type(@this);
        }
    }

    internal class CfxPostDataElementGetFileRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementGetFileRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementGetFileRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.PostDataElement.cfx_post_data_element_get_file(@this));
        }
    }

    internal class CfxPostDataElementGetBytesCountRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementGetBytesCountRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementGetBytesCountRenderProcessCall) {}

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
            __retval = (ulong)CfxApi.PostDataElement.cfx_post_data_element_get_bytes_count(@this);
        }
    }

    internal class CfxPostDataElementGetBytesRenderProcessCall : RenderProcessCall {

        internal CfxPostDataElementGetBytesRenderProcessCall()
            : base(RemoteCallId.CfxPostDataElementGetBytesRenderProcessCall) {}

        internal IntPtr @this;
        internal ulong size;
        internal IntPtr bytes;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(size);
            h.Write(bytes);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out size);
            h.Read(out bytes);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = (ulong)CfxApi.PostDataElement.cfx_post_data_element_get_bytes(@this, (UIntPtr)size, bytes);
        }
    }

}
