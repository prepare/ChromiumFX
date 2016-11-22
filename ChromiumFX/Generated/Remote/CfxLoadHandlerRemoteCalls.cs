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

    internal class CfxLoadHandlerCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxLoadHandlerCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxLoadHandlerCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.LoadHandler.cfx_load_handler_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxLoadHandlerSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxLoadHandlerSetCallbackRemoteCall()
            : base(RemoteCallId.CfxLoadHandlerSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxLoadHandlerRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxOnLoadingStateChangeRemoteEventCall : RemoteEventCall {

        internal CfxOnLoadingStateChangeRemoteEventCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal int isLoading;
        internal int canGoBack;
        internal int canGoForward;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(isLoading);
            h.Write(canGoBack);
            h.Write(canGoForward);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out isLoading);
            h.Read(out canGoBack);
            h.Read(out canGoForward);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrLoadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnLoadingStateChangeEventArgs(this);
            self.m_OnLoadingStateChange?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnLoadStartRemoteEventCall : RemoteEventCall {

        internal CfxOnLoadStartRemoteEventCall()
            : base(RemoteCallId.CfxOnLoadStartRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal int transition_type;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(transition_type);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out transition_type);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrLoadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnLoadStartEventArgs(this);
            self.m_OnLoadStart?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnLoadEndRemoteEventCall : RemoteEventCall {

        internal CfxOnLoadEndRemoteEventCall()
            : base(RemoteCallId.CfxOnLoadEndRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal int httpStatusCode;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(httpStatusCode);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out httpStatusCode);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrLoadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnLoadEndEventArgs(this);
            self.m_OnLoadEnd?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
        }
    }

    internal class CfxOnLoadErrorRemoteEventCall : RemoteEventCall {

        internal CfxOnLoadErrorRemoteEventCall()
            : base(RemoteCallId.CfxOnLoadErrorRemoteEventCall) {}

        internal IntPtr browser;
        internal int browser_release;
        internal IntPtr frame;
        internal int frame_release;
        internal int errorCode;
        internal IntPtr errorText_str;
        internal int errorText_length;
        internal IntPtr failedUrl_str;
        internal int failedUrl_length;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(browser);
            h.Write(frame);
            h.Write(errorCode);
            h.Write(errorText_str);
            h.Write(errorText_length);
            h.Write(failedUrl_str);
            h.Write(failedUrl_length);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out browser);
            h.Read(out frame);
            h.Read(out errorCode);
            h.Read(out errorText_str);
            h.Read(out errorText_length);
            h.Read(out failedUrl_str);
            h.Read(out failedUrl_length);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(browser_release);
            h.Write(frame_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out browser_release);
            h.Read(out frame_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrLoadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrOnLoadErrorEventArgs(this);
            self.m_OnLoadError?.Invoke(self, e);
            e.m_isInvalid = true;
            browser_release = e.m_browser_wrapped == null? 1 : 0;
            frame_release = e.m_frame_wrapped == null? 1 : 0;
        }
    }

}
