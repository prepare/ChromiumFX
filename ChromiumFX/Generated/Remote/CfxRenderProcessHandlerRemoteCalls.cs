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

    internal class CfxRenderProcessHandlerCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxRenderProcessHandlerCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxRenderProcessHandlerCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.RenderProcessHandler.cfx_render_process_handler_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxRenderProcessHandlerSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxRenderProcessHandlerSetCallbackRemoteCall()
            : base(RemoteCallId.CfxRenderProcessHandlerSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxRenderProcessHandlerRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxOnRenderThreadCreatedRemoteEventCall : RemoteEventCall {

        internal CfxOnRenderThreadCreatedRemoteEventCall()
            : base(RemoteCallId.CfxOnRenderThreadCreatedRemoteEventCall) {}

        internal IntPtr extra_info;
        internal int extra_info_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(extra_info);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out extra_info);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(extra_info_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out extra_info_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnRenderThreadCreatedEventArgs(this);
            self.m_OnRenderThreadCreated?.Invoke(self, e);
            e.m_isInvalid = true;
            extra_info_release = e.m_extra_info_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnWebKitInitializedRemoteEventCall : RemoteEventCall {

        internal CfxOnWebKitInitializedRemoteEventCall()
            : base(RemoteCallId.CfxOnWebKitInitializedRemoteEventCall) {}


        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrEventArgs();
            self.m_OnWebKitInitialized?.Invoke(self, e);
            e.m_isInvalid = true;
        }
    }

    internal class CfxOnBrowserCreatedRemoteEventCall : RemoteEventCall {

        internal CfxOnBrowserCreatedRemoteEventCall()
            : base(RemoteCallId.CfxOnBrowserCreatedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnBrowserCreatedEventArgs(this);
            self.m_OnBrowserCreated?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnBrowserDestroyedRemoteEventCall : RemoteEventCall {

        internal CfxOnBrowserDestroyedRemoteEventCall()
            : base(RemoteCallId.CfxOnBrowserDestroyedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnBrowserDestroyedEventArgs(this);
            self.m_OnBrowserDestroyed?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
        }
    }

    internal class CfxGetLoadHandlerRemoteEventCall : RemoteEventCall {

        internal CfxGetLoadHandlerRemoteEventCall()
            : base(RemoteCallId.CfxGetLoadHandlerRemoteEventCall) {}


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
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrGetLoadHandlerEventArgs(this);
            self.m_GetLoadHandler?.Invoke(self, e);
            e.m_isInvalid = true;
            __retval = CfrObject.Unwrap(e.m_returnValue).ptr;
        }
    }

    internal class CfxOnBeforeNavigationRemoteEventCall : RemoteEventCall {

        internal CfxOnBeforeNavigationRemoteEventCall()
            : base(RemoteCallId.CfxOnBeforeNavigationRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal IntPtr request;
        internal int request_release;
        internal int navigation_type;
        internal int is_redirect;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(request);
            h.Write(navigation_type);
            h.Write(is_redirect);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out request);
            h.Read(out navigation_type);
            h.Read(out is_redirect);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
            h.Write(request_release);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
            h.Read(out request_release);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnBeforeNavigationEventArgs(this);
            self.m_OnBeforeNavigation?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
            request_release = e.m_request_wrapped == null? 1 : 0;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

    internal class CfxOnContextCreatedRemoteEventCall : RemoteEventCall {

        internal CfxOnContextCreatedRemoteEventCall()
            : base(RemoteCallId.CfxOnContextCreatedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal IntPtr context;
        internal int context_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(context);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out context);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
            h.Write(context_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
            h.Read(out context_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnContextCreatedEventArgs(this);
            self.m_OnContextCreated?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
            context_release = e.m_context_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnContextReleasedRemoteEventCall : RemoteEventCall {

        internal CfxOnContextReleasedRemoteEventCall()
            : base(RemoteCallId.CfxOnContextReleasedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal IntPtr context;
        internal int context_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(context);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out context);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
            h.Write(context_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
            h.Read(out context_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnContextReleasedEventArgs(this);
            self.m_OnContextReleased?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
            context_release = e.m_context_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnUncaughtExceptionRemoteEventCall : RemoteEventCall {

        internal CfxOnUncaughtExceptionRemoteEventCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal IntPtr context;
        internal int context_release;
        internal IntPtr exception;
        internal int exception_release;
        internal IntPtr stackTrace;
        internal int stackTrace_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(context);
            h.Write(exception);
            h.Write(stackTrace);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out context);
            h.Read(out exception);
            h.Read(out stackTrace);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
            h.Write(context_release);
            h.Write(exception_release);
            h.Write(stackTrace_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
            h.Read(out context_release);
            h.Read(out exception_release);
            h.Read(out stackTrace_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnUncaughtExceptionEventArgs(this);
            self.m_OnUncaughtException?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
            context_release = e.m_context_wrapped == null? 1 : 0;
            exception_release = e.m_exception_wrapped == null? 1 : 0;
            stackTrace_release = e.m_stackTrace_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnFocusedNodeChangedRemoteEventCall : RemoteEventCall {

        internal CfxOnFocusedNodeChangedRemoteEventCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal IntPtr node;
        internal int node_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(node);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out node);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
            h.Write(node_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
            h.Read(out node_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnFocusedNodeChangedEventArgs(this);
            self.m_OnFocusedNodeChanged?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
            node_release = e.m_node_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnProcessMessageReceivedRemoteEventCall : RemoteEventCall {

        internal CfxOnProcessMessageReceivedRemoteEventCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal int source_process;
        internal IntPtr message;
        internal int message_release;

        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(source_process);
            h.Write(message);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out source_process);
            h.Read(out message);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(message_release);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out message_release);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrRenderProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnProcessMessageReceivedEventArgs(this);
            self.m_OnProcessMessageReceived?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            message_release = e.m_message_wrapped == null? 1 : 0;
            __retval = e.m_returnValue ? 1 : 0;
        }
    }

}
