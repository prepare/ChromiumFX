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
    internal class CfxRuntimeCurrentlyOnRemoteCall : RemoteCall {

        internal CfxRuntimeCurrentlyOnRemoteCall()
            : base(RemoteCallId.CfxRuntimeCurrentlyOnRemoteCall) {}

        internal int threadId;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_currently_on((int)threadId);
        }
    }

    internal class CfxRuntimeFormatUrlForSecurityDisplayRemoteCall : RemoteCall {

        internal CfxRuntimeFormatUrlForSecurityDisplayRemoteCall()
            : base(RemoteCallId.CfxRuntimeFormatUrlForSecurityDisplayRemoteCall) {}

        internal string originUrl;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(originUrl);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out originUrl);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var originUrl_pinned = new PinnedString(originUrl);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Runtime.cfx_format_url_for_security_display(originUrl_pinned.Obj.PinnedPtr, originUrl_pinned.Length));
            originUrl_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeIsCertStatusErrorRemoteCall : RemoteCall {

        internal CfxRuntimeIsCertStatusErrorRemoteCall()
            : base(RemoteCallId.CfxRuntimeIsCertStatusErrorRemoteCall) {}

        internal int status;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(status);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out status);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_is_cert_status_error((int)status);
        }
    }

    internal class CfxRuntimeIsCertStatusMinorErrorRemoteCall : RemoteCall {

        internal CfxRuntimeIsCertStatusMinorErrorRemoteCall()
            : base(RemoteCallId.CfxRuntimeIsCertStatusMinorErrorRemoteCall) {}

        internal int status;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(status);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out status);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_is_cert_status_minor_error((int)status);
        }
    }

    internal class CfxRuntimePostDelayedTaskRemoteCall : RemoteCall {

        internal CfxRuntimePostDelayedTaskRemoteCall()
            : base(RemoteCallId.CfxRuntimePostDelayedTaskRemoteCall) {}

        internal int threadId;
        internal IntPtr task;
        internal long delayMs;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
            h.Write(task);
            h.Write(delayMs);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
            h.Read(out task);
            h.Read(out delayMs);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_post_delayed_task((int)threadId, task, delayMs);
        }
    }

    internal class CfxRuntimePostTaskRemoteCall : RemoteCall {

        internal CfxRuntimePostTaskRemoteCall()
            : base(RemoteCallId.CfxRuntimePostTaskRemoteCall) {}

        internal int threadId;
        internal IntPtr task;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
            h.Write(task);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
            h.Read(out task);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_post_task((int)threadId, task);
        }
    }

    internal class CfxRuntimeRegisterExtensionRemoteCall : RemoteCall {

        internal CfxRuntimeRegisterExtensionRemoteCall()
            : base(RemoteCallId.CfxRuntimeRegisterExtensionRemoteCall) {}

        internal string extensionName;
        internal string javascriptCode;
        internal IntPtr handler;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(extensionName);
            h.Write(javascriptCode);
            h.Write(handler);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out extensionName);
            h.Read(out javascriptCode);
            h.Read(out handler);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var extensionName_pinned = new PinnedString(extensionName);
            var javascriptCode_pinned = new PinnedString(javascriptCode);
            __retval = 0 != CfxApi.Runtime.cfx_register_extension(extensionName_pinned.Obj.PinnedPtr, extensionName_pinned.Length, javascriptCode_pinned.Obj.PinnedPtr, javascriptCode_pinned.Length, handler);
            extensionName_pinned.Obj.Free();
            javascriptCode_pinned.Obj.Free();
        }
    }

}
