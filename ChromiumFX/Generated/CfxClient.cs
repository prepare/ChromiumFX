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

namespace Chromium {
    using Event;

    /// <summary>
    /// Implement this structure to provide handler implementations.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
    /// </remarks>
    public class CfxClient : CfxBase {

        internal static CfxClient Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_client_get_gc_handle(nativePtr);
            return (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void get_context_menu_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetContextMenuHandlerEventArgs();
            var eventHandler = self.m_GetContextMenuHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxContextMenuHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_dialog_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetDialogHandlerEventArgs();
            var eventHandler = self.m_GetDialogHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxDialogHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_display_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetDisplayHandlerEventArgs();
            var eventHandler = self.m_GetDisplayHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxDisplayHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_download_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetDownloadHandlerEventArgs();
            var eventHandler = self.m_GetDownloadHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxDownloadHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_drag_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetDragHandlerEventArgs();
            var eventHandler = self.m_GetDragHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxDragHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_focus_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetFocusHandlerEventArgs();
            var eventHandler = self.m_GetFocusHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxFocusHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_geolocation_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetGeolocationHandlerEventArgs();
            var eventHandler = self.m_GetGeolocationHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxGeolocationHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_jsdialog_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetJsDialogHandlerEventArgs();
            var eventHandler = self.m_GetJsDialogHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxJsDialogHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_keyboard_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetKeyboardHandlerEventArgs();
            var eventHandler = self.m_GetKeyboardHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxKeyboardHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_life_span_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetLifeSpanHandlerEventArgs();
            var eventHandler = self.m_GetLifeSpanHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxLifeSpanHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_load_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetLoadHandlerEventArgs();
            var eventHandler = self.m_GetLoadHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxLoadHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_render_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetRenderHandlerEventArgs();
            var eventHandler = self.m_GetRenderHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxRenderHandler.Unwrap(e.m_returnValue);
        }

        internal static void get_request_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetRequestHandlerEventArgs();
            var eventHandler = self.m_GetRequestHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxRequestHandler.Unwrap(e.m_returnValue);
        }

        internal static void on_process_message_received(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxProcessId source_process, IntPtr message) {
            var self = (CfxClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnProcessMessageReceivedEventArgs(browser, source_process, message);
            var eventHandler = self.m_OnProcessMessageReceived;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_message_wrapped == null) {
                CfxApi.cfx_release(e.m_message);
            } else {
                e.m_message_wrapped.Dispose();
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxClient(IntPtr nativePtr) : base(nativePtr) {}
        public CfxClient() : base(CfxApi.cfx_client_ctor) {}

        /// <summary>
        /// Return the handler for context menus. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetContextMenuHandlerEventHandler GetContextMenuHandler {
            add {
                if(m_GetContextMenuHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 0, 1);
                }
                m_GetContextMenuHandler += value;
            }
            remove {
                m_GetContextMenuHandler -= value;
                if(m_GetContextMenuHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxGetContextMenuHandlerEventHandler m_GetContextMenuHandler;

        /// <summary>
        /// Return the handler for dialogs. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetDialogHandlerEventHandler GetDialogHandler {
            add {
                if(m_GetDialogHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 1, 1);
                }
                m_GetDialogHandler += value;
            }
            remove {
                m_GetDialogHandler -= value;
                if(m_GetDialogHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxGetDialogHandlerEventHandler m_GetDialogHandler;

        /// <summary>
        /// Return the handler for browser display state events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetDisplayHandlerEventHandler GetDisplayHandler {
            add {
                if(m_GetDisplayHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 2, 1);
                }
                m_GetDisplayHandler += value;
            }
            remove {
                m_GetDisplayHandler -= value;
                if(m_GetDisplayHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxGetDisplayHandlerEventHandler m_GetDisplayHandler;

        /// <summary>
        /// Return the handler for download events. If no handler is returned downloads
        /// will not be allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetDownloadHandlerEventHandler GetDownloadHandler {
            add {
                if(m_GetDownloadHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 3, 1);
                }
                m_GetDownloadHandler += value;
            }
            remove {
                m_GetDownloadHandler -= value;
                if(m_GetDownloadHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxGetDownloadHandlerEventHandler m_GetDownloadHandler;

        /// <summary>
        /// Return the handler for drag events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetDragHandlerEventHandler GetDragHandler {
            add {
                if(m_GetDragHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 4, 1);
                }
                m_GetDragHandler += value;
            }
            remove {
                m_GetDragHandler -= value;
                if(m_GetDragHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxGetDragHandlerEventHandler m_GetDragHandler;

        /// <summary>
        /// Return the handler for focus events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetFocusHandlerEventHandler GetFocusHandler {
            add {
                if(m_GetFocusHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 5, 1);
                }
                m_GetFocusHandler += value;
            }
            remove {
                m_GetFocusHandler -= value;
                if(m_GetFocusHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 5, 0);
                }
            }
        }

        private CfxGetFocusHandlerEventHandler m_GetFocusHandler;

        /// <summary>
        /// Return the handler for geolocation permissions requests. If no handler is
        /// provided geolocation access will be denied by default.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetGeolocationHandlerEventHandler GetGeolocationHandler {
            add {
                if(m_GetGeolocationHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 6, 1);
                }
                m_GetGeolocationHandler += value;
            }
            remove {
                m_GetGeolocationHandler -= value;
                if(m_GetGeolocationHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 6, 0);
                }
            }
        }

        private CfxGetGeolocationHandlerEventHandler m_GetGeolocationHandler;

        /// <summary>
        /// Return the handler for JavaScript dialogs. If no handler is provided the
        /// default implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetJsDialogHandlerEventHandler GetJsDialogHandler {
            add {
                if(m_GetJsDialogHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 7, 1);
                }
                m_GetJsDialogHandler += value;
            }
            remove {
                m_GetJsDialogHandler -= value;
                if(m_GetJsDialogHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 7, 0);
                }
            }
        }

        private CfxGetJsDialogHandlerEventHandler m_GetJsDialogHandler;

        /// <summary>
        /// Return the handler for keyboard events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetKeyboardHandlerEventHandler GetKeyboardHandler {
            add {
                if(m_GetKeyboardHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 8, 1);
                }
                m_GetKeyboardHandler += value;
            }
            remove {
                m_GetKeyboardHandler -= value;
                if(m_GetKeyboardHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 8, 0);
                }
            }
        }

        private CfxGetKeyboardHandlerEventHandler m_GetKeyboardHandler;

        /// <summary>
        /// Return the handler for browser life span events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetLifeSpanHandlerEventHandler GetLifeSpanHandler {
            add {
                if(m_GetLifeSpanHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 9, 1);
                }
                m_GetLifeSpanHandler += value;
            }
            remove {
                m_GetLifeSpanHandler -= value;
                if(m_GetLifeSpanHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 9, 0);
                }
            }
        }

        private CfxGetLifeSpanHandlerEventHandler m_GetLifeSpanHandler;

        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetLoadHandlerEventHandler GetLoadHandler {
            add {
                if(m_GetLoadHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 10, 1);
                }
                m_GetLoadHandler += value;
            }
            remove {
                m_GetLoadHandler -= value;
                if(m_GetLoadHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 10, 0);
                }
            }
        }

        private CfxGetLoadHandlerEventHandler m_GetLoadHandler;

        /// <summary>
        /// Return the handler for off-screen rendering events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetRenderHandlerEventHandler GetRenderHandler {
            add {
                if(m_GetRenderHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 11, 1);
                }
                m_GetRenderHandler += value;
            }
            remove {
                m_GetRenderHandler -= value;
                if(m_GetRenderHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 11, 0);
                }
            }
        }

        private CfxGetRenderHandlerEventHandler m_GetRenderHandler;

        /// <summary>
        /// Return the handler for browser request events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxGetRequestHandlerEventHandler GetRequestHandler {
            add {
                if(m_GetRequestHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 12, 1);
                }
                m_GetRequestHandler += value;
            }
            remove {
                m_GetRequestHandler -= value;
                if(m_GetRequestHandler == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 12, 0);
                }
            }
        }

        private CfxGetRequestHandlerEventHandler m_GetRequestHandler;

        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public event CfxOnProcessMessageReceivedEventHandler OnProcessMessageReceived {
            add {
                if(m_OnProcessMessageReceived == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 13, 1);
                }
                m_OnProcessMessageReceived += value;
            }
            remove {
                m_OnProcessMessageReceived -= value;
                if(m_OnProcessMessageReceived == null) {
                    CfxApi.cfx_client_activate_callback(NativePtr, 13, 0);
                }
            }
        }

        private CfxOnProcessMessageReceivedEventHandler m_OnProcessMessageReceived;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_GetContextMenuHandler != null) {
                m_GetContextMenuHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 0, 0);
            }
            if(m_GetDialogHandler != null) {
                m_GetDialogHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 1, 0);
            }
            if(m_GetDisplayHandler != null) {
                m_GetDisplayHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 2, 0);
            }
            if(m_GetDownloadHandler != null) {
                m_GetDownloadHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 3, 0);
            }
            if(m_GetDragHandler != null) {
                m_GetDragHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 4, 0);
            }
            if(m_GetFocusHandler != null) {
                m_GetFocusHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 5, 0);
            }
            if(m_GetGeolocationHandler != null) {
                m_GetGeolocationHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 6, 0);
            }
            if(m_GetJsDialogHandler != null) {
                m_GetJsDialogHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 7, 0);
            }
            if(m_GetKeyboardHandler != null) {
                m_GetKeyboardHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 8, 0);
            }
            if(m_GetLifeSpanHandler != null) {
                m_GetLifeSpanHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 9, 0);
            }
            if(m_GetLoadHandler != null) {
                m_GetLoadHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 10, 0);
            }
            if(m_GetRenderHandler != null) {
                m_GetRenderHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 11, 0);
            }
            if(m_GetRequestHandler != null) {
                m_GetRequestHandler = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 12, 0);
            }
            if(m_OnProcessMessageReceived != null) {
                m_OnProcessMessageReceived = null;
                CfxApi.cfx_client_activate_callback(NativePtr, 13, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Return the handler for context menus. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetContextMenuHandlerEventHandler(object sender, CfxGetContextMenuHandlerEventArgs e);

        /// <summary>
        /// Return the handler for context menus. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetContextMenuHandlerEventArgs : CfxEventArgs {


            internal CfxContextMenuHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetContextMenuHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxContextMenuHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for dialogs. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetDialogHandlerEventHandler(object sender, CfxGetDialogHandlerEventArgs e);

        /// <summary>
        /// Return the handler for dialogs. If no handler is provided the default
        /// implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetDialogHandlerEventArgs : CfxEventArgs {


            internal CfxDialogHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetDialogHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxDialogHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for browser display state events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetDisplayHandlerEventHandler(object sender, CfxGetDisplayHandlerEventArgs e);

        /// <summary>
        /// Return the handler for browser display state events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetDisplayHandlerEventArgs : CfxEventArgs {


            internal CfxDisplayHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetDisplayHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxDisplayHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for download events. If no handler is returned downloads
        /// will not be allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetDownloadHandlerEventHandler(object sender, CfxGetDownloadHandlerEventArgs e);

        /// <summary>
        /// Return the handler for download events. If no handler is returned downloads
        /// will not be allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetDownloadHandlerEventArgs : CfxEventArgs {


            internal CfxDownloadHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetDownloadHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxDownloadHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for drag events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetDragHandlerEventHandler(object sender, CfxGetDragHandlerEventArgs e);

        /// <summary>
        /// Return the handler for drag events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetDragHandlerEventArgs : CfxEventArgs {


            internal CfxDragHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetDragHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxDragHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for focus events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetFocusHandlerEventHandler(object sender, CfxGetFocusHandlerEventArgs e);

        /// <summary>
        /// Return the handler for focus events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetFocusHandlerEventArgs : CfxEventArgs {


            internal CfxFocusHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetFocusHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxFocusHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for geolocation permissions requests. If no handler is
        /// provided geolocation access will be denied by default.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetGeolocationHandlerEventHandler(object sender, CfxGetGeolocationHandlerEventArgs e);

        /// <summary>
        /// Return the handler for geolocation permissions requests. If no handler is
        /// provided geolocation access will be denied by default.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetGeolocationHandlerEventArgs : CfxEventArgs {


            internal CfxGeolocationHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetGeolocationHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxGeolocationHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for JavaScript dialogs. If no handler is provided the
        /// default implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetJsDialogHandlerEventHandler(object sender, CfxGetJsDialogHandlerEventArgs e);

        /// <summary>
        /// Return the handler for JavaScript dialogs. If no handler is provided the
        /// default implementation will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetJsDialogHandlerEventArgs : CfxEventArgs {


            internal CfxJsDialogHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetJsDialogHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxJsDialogHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for keyboard events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetKeyboardHandlerEventHandler(object sender, CfxGetKeyboardHandlerEventArgs e);

        /// <summary>
        /// Return the handler for keyboard events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetKeyboardHandlerEventArgs : CfxEventArgs {


            internal CfxKeyboardHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetKeyboardHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxKeyboardHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for browser life span events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetLifeSpanHandlerEventHandler(object sender, CfxGetLifeSpanHandlerEventArgs e);

        /// <summary>
        /// Return the handler for browser life span events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetLifeSpanHandlerEventArgs : CfxEventArgs {


            internal CfxLifeSpanHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetLifeSpanHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxLifeSpanHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetLoadHandlerEventHandler(object sender, CfxGetLoadHandlerEventArgs e);

        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetLoadHandlerEventArgs : CfxEventArgs {


            internal CfxLoadHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetLoadHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxLoadHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for off-screen rendering events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetRenderHandlerEventHandler(object sender, CfxGetRenderHandlerEventArgs e);

        /// <summary>
        /// Return the handler for off-screen rendering events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetRenderHandlerEventArgs : CfxEventArgs {


            internal CfxRenderHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetRenderHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxRenderHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for browser request events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetRequestHandlerEventHandler(object sender, CfxGetRequestHandlerEventArgs e);

        /// <summary>
        /// Return the handler for browser request events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxGetRequestHandlerEventArgs : CfxEventArgs {


            internal CfxRequestHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetRequestHandlerEventArgs() {
            }

            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxRequestHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnProcessMessageReceivedEventHandler(object sender, CfxOnProcessMessageReceivedEventArgs e);

        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
        /// </remarks>
        public class CfxOnProcessMessageReceivedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal CfxProcessId m_source_process;
            internal IntPtr m_message;
            internal CfxProcessMessage m_message_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnProcessMessageReceivedEventArgs(IntPtr browser, CfxProcessId source_process, IntPtr message) {
                m_browser = browser;
                m_source_process = source_process;
                m_message = message;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxProcessId SourceProcess {
                get {
                    CheckAccess();
                    return m_source_process;
                }
            }
            public CfxProcessMessage Message {
                get {
                    CheckAccess();
                    if(m_message_wrapped == null) m_message_wrapped = CfxProcessMessage.Wrap(m_message);
                    return m_message_wrapped;
                }
            }
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_client_capi.h">cef/include/capi/cef_client_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, SourceProcess={{{1}}}, Message={{{2}}}", Browser, SourceProcess, Message);
            }
        }

    }
}
