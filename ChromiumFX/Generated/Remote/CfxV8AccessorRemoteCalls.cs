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

    internal class CfxV8AccessorCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxV8AccessorCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxV8AccessorCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.V8Accessor.cfx_v8accessor_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxV8AccessorSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxV8AccessorSetCallbackRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxV8AccessorRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxV8AccessorGetRemoteEventCall : RemoteEventCall {

        internal CfxV8AccessorGetRemoteEventCall()
            : base(RemoteCallId.CfxV8AccessorGetRemoteEventCall) {}

        internal IntPtr name_str;
        internal int name_length;
        internal IntPtr @object;
        internal int object_release;
        internal IntPtr retval;
        internal string exception;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(name_str);
            h.Write(name_length);
            h.Write(@object);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out name_str);
            h.Read(out name_length);
            h.Read(out @object);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(object_release);
            h.Write(retval);
            h.Write(exception);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out object_release);
            h.Read(out retval);
            h.Read(out exception);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrV8Accessor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrV8AccessorGetEventArgs(this);
            self.m_Get?.Invoke(self, e);
            e.m_isInvalid = true;
            object_release = e.m_object_wrapped == null? 1 : 0;
            retval = CfrObject.Unwrap(e.m_retval_wrapped).ptr;
            exception = e.m_exception_wrapped;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

    internal class CfxV8AccessorSetRemoteEventCall : RemoteEventCall {

        internal CfxV8AccessorSetRemoteEventCall()
            : base(RemoteCallId.CfxV8AccessorSetRemoteEventCall) {}

        internal IntPtr name_str;
        internal int name_length;
        internal IntPtr @object;
        internal int object_release;
        internal IntPtr value;
        internal int value_release;
        internal string exception;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(name_str);
            h.Write(name_length);
            h.Write(@object);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out name_str);
            h.Read(out name_length);
            h.Read(out @object);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(object_release);
            h.Write(value_release);
            h.Write(exception);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out object_release);
            h.Read(out value_release);
            h.Read(out exception);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrV8Accessor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrV8AccessorSetEventArgs(this);
            self.m_Set?.Invoke(self, e);
            e.m_isInvalid = true;
            object_release = e.m_object_wrapped == null? 1 : 0;
            value_release = e.m_value_wrapped == null? 1 : 0;
            exception = e.m_exception_wrapped;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

}
