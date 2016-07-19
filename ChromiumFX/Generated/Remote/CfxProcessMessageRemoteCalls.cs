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

    internal class CfxProcessMessageCreateRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageCreateRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageCreateRenderProcessCall) {}

        internal string name;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out name);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = CfxApi.ProcessMessage.cfx_process_message_create(name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxProcessMessageIsValidRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageIsValidRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.ProcessMessage.cfx_process_message_is_valid(@this);
        }
    }

    internal class CfxProcessMessageIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageIsReadOnlyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.ProcessMessage.cfx_process_message_is_read_only(@this);
        }
    }

    internal class CfxProcessMessageCopyRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageCopyRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageCopyRenderProcessCall) {}

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
            __retval = CfxApi.ProcessMessage.cfx_process_message_copy(@this);
        }
    }

    internal class CfxProcessMessageGetNameRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageGetNameRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageGetNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.ProcessMessage.cfx_process_message_get_name(@this));
        }
    }

    internal class CfxProcessMessageGetArgumentListRenderProcessCall : RenderProcessCall {

        internal CfxProcessMessageGetArgumentListRenderProcessCall()
            : base(RemoteCallId.CfxProcessMessageGetArgumentListRenderProcessCall) {}

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
            __retval = CfxApi.ProcessMessage.cfx_process_message_get_argument_list(@this);
        }
    }

}
