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
    using Event;

    internal class CfxAppCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxAppCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxAppCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.App.cfx_app_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxAppSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxAppSetCallbackRemoteCall()
            : base(RemoteCallId.CfxAppSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxAppRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxOnBeforeCommandLineProcessingRemoteEventCall : RemoteEventCall {

        internal CfxOnBeforeCommandLineProcessingRemoteEventCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingRemoteEventCall) {}

        internal IntPtr process_type_str;
        internal int process_type_length;
        internal IntPtr command_line;
        internal int command_line_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(process_type_str);
            h.Write(process_type_length);
            h.Write(command_line);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out process_type_str);
            h.Read(out process_type_length);
            h.Read(out command_line);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(command_line_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out command_line_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnBeforeCommandLineProcessingEventArgs(this);
            self.m_OnBeforeCommandLineProcessing?.Invoke(self, e);
            e.m_isInvalid = true;
            command_line_release = e.m_command_line_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnRegisterCustomSchemesRemoteEventCall : RemoteEventCall {

        internal CfxOnRegisterCustomSchemesRemoteEventCall()
            : base(RemoteCallId.CfxOnRegisterCustomSchemesRemoteEventCall) {}

        internal IntPtr registrar;
        internal int registrar_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(registrar);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out registrar);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(registrar_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out registrar_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnRegisterCustomSchemesEventArgs(this);
            self.m_OnRegisterCustomSchemes?.Invoke(self, e);
            e.m_isInvalid = true;
            registrar_release = e.m_registrar_wrapped == null? 1 : 0;
        }
    }

    internal class CfxGetResourceBundleHandlerRemoteEventCall : RemoteEventCall {

        internal CfxGetResourceBundleHandlerRemoteEventCall()
            : base(RemoteCallId.CfxGetResourceBundleHandlerRemoteEventCall) {}


        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetResourceBundleHandlerEventArgs(this);
            self.m_GetResourceBundleHandler?.Invoke(self, e);
            e.m_isInvalid = true;
            __retval = CfrObject.Unwrap(e.m_returnValue).ptr;
        }
    }

    internal class CfxGetRenderProcessHandlerRemoteEventCall : RemoteEventCall {

        internal CfxGetRenderProcessHandlerRemoteEventCall()
            : base(RemoteCallId.CfxGetRenderProcessHandlerRemoteEventCall) {}


        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetRenderProcessHandlerEventArgs(this);
            self.m_GetRenderProcessHandler?.Invoke(self, e);
            e.m_isInvalid = true;
            __retval = CfrObject.Unwrap(e.m_returnValue).ptr;
        }
    }

}
