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

    internal class CfxResourceBundleHandlerCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxResourceBundleHandlerCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxResourceBundleHandlerCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ResourceBundleHandler.cfx_resource_bundle_handler_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxResourceBundleHandlerSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxResourceBundleHandlerSetCallbackRemoteCall()
            : base(RemoteCallId.CfxResourceBundleHandlerSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxResourceBundleHandlerRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxGetLocalizedStringRemoteEventCall : RemoteEventCall {

        internal CfxGetLocalizedStringRemoteEventCall()
            : base(RemoteCallId.CfxGetLocalizedStringRemoteEventCall) {}

        internal int string_id;
        internal string @string;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(string_id);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out string_id);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(@string);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out @string);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetLocalizedStringEventArgs(this);
            self.m_GetLocalizedString?.Invoke(self, e);
            e.m_isInvalid = true;
            @string = e.m_string_wrapped;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

    internal class CfxGetDataResourceRemoteEventCall : RemoteEventCall {

        internal CfxGetDataResourceRemoteEventCall()
            : base(RemoteCallId.CfxGetDataResourceRemoteEventCall) {}

        internal int resource_id;
        internal IntPtr data;
        internal UIntPtr data_size;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(resource_id);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out resource_id);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(data);
            h.Write(data_size);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out data);
            h.Read(out data_size);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetDataResourceEventArgs(this);
            self.m_GetDataResource?.Invoke(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

    internal class CfxGetDataResourceForScaleRemoteEventCall : RemoteEventCall {

        internal CfxGetDataResourceForScaleRemoteEventCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleRemoteEventCall) {}

        internal int resource_id;
        internal int scale_factor;
        internal IntPtr data;
        internal UIntPtr data_size;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(resource_id);
            h.Write(scale_factor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out resource_id);
            h.Read(out scale_factor);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(data);
            h.Write(data_size);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out data);
            h.Read(out data_size);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetDataResourceForScaleEventArgs(this);
            self.m_GetDataResourceForScale?.Invoke(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

}
