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
    /// Implement this structure to handle events related to browser requests. The
    /// functions of this structure will be called on the thread indicated.
    /// </summary>
    public class CfxRequestHandler : CfxBase {

        internal static CfxRequestHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_request_handler_get_gc_handle(nativePtr);
            return (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_before_browse(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request, int is_redirect) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnBeforeBrowseEventArgs(browser, frame, request, is_redirect);
            var eventHandler = self.m_OnBeforeBrowse;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_before_resource_load(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnBeforeResourceLoadEventArgs(browser, frame, request);
            var eventHandler = self.m_OnBeforeResourceLoad;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void get_resource_handler(IntPtr gcHandlePtr, out IntPtr __retval, IntPtr browser, IntPtr frame, IntPtr request) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetResourceHandlerEventArgs(browser, frame, request);
            var eventHandler = self.m_GetResourceHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
            __retval = CfxResourceHandler.Unwrap(e.m_returnValue);
        }

        internal static void on_resource_redirect(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr old_url_str, int old_url_length, ref IntPtr new_url_str, ref int new_url_length) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnResourceRedirectEventArgs(browser, frame, old_url_str, old_url_length, new_url_str, new_url_length);
            var eventHandler = self.m_OnResourceRedirect;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_new_url_changed) {
                var new_url_pinned = new PinnedString(e.m_new_url_wrapped);
                new_url_str = new_url_pinned.Obj.PinnedPtr;
                new_url_length = new_url_pinned.Length;
            }
        }

        internal static void get_auth_credentials(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxRequestHandlerGetAuthCredentialsEventArgs(browser, frame, isProxy, host_str, host_length, port, realm_str, realm_length, scheme_str, scheme_length, callback);
            var eventHandler = self.m_GetAuthCredentials;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_quota_request(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr origin_url_str, int origin_url_length, long new_size, IntPtr callback) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnQuotaRequestEventArgs(browser, origin_url_str, origin_url_length, new_size, callback);
            var eventHandler = self.m_OnQuotaRequest;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_protocol_execution(IntPtr gcHandlePtr, IntPtr browser, IntPtr url_str, int url_length, out int allow_os_execution) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                allow_os_execution = default(int);
                return;
            }
            var e = new CfxOnProtocolExecutionEventArgs(browser, url_str, url_length);
            var eventHandler = self.m_OnProtocolExecution;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            allow_os_execution = e.m_allow_os_execution;
        }

        internal static void on_certificate_error(IntPtr gcHandlePtr, out int __retval, CfxErrorCode cert_error, IntPtr request_url_str, int request_url_length, IntPtr callback) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnCertificateErrorEventArgs(cert_error, request_url_str, request_url_length, callback);
            var eventHandler = self.m_OnCertificateError;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_before_plugin_load(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr url_str, int url_length, IntPtr policy_url_str, int policy_url_length, IntPtr info) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnBeforePluginLoadEventArgs(browser, url_str, url_length, policy_url_str, policy_url_length, info);
            var eventHandler = self.m_OnBeforePluginLoad;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_info_wrapped == null) CfxApi.cfx_release(e.m_info);
            __retval = e.m_returnValue;
        }

        internal static void on_plugin_crashed(IntPtr gcHandlePtr, IntPtr browser, IntPtr plugin_path_str, int plugin_path_length) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnPluginCrashedEventArgs(browser, plugin_path_str, plugin_path_length);
            var eventHandler = self.m_OnPluginCrashed;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_render_process_terminated(IntPtr gcHandlePtr, IntPtr browser, CfxTerminationStatus status) {
            var self = (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnRenderProcessTerminatedEventArgs(browser, status);
            var eventHandler = self.m_OnRenderProcessTerminated;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal CfxRequestHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxRequestHandler() : base(CfxApi.cfx_request_handler_ctor) {}

        /// <summary>
        /// Called on the UI thread before browser navigation. Return true (1) to
        /// cancel the navigation or false (0) to allow the navigation to proceed. The
        /// |Request| object cannot be modified in this callback.
        /// CfxLoadHandler.OnLoadingStateChange will be called twice in all cases.
        /// If the navigation is allowed CfxLoadHandler.OnLoadStart and
        /// CfxLoadHandler.OnLoadEnd will be called. If the navigation is canceled
        /// CfxLoadHandler.OnLoadError will be called with an |ErrorCode| value of
        /// ERR_ABORTED.
        /// </summary>
        public event CfxOnBeforeBrowseEventHandler OnBeforeBrowse {
            add {
                if(m_OnBeforeBrowse == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnBeforeBrowse += value;
            }
            remove {
                m_OnBeforeBrowse -= value;
                if(m_OnBeforeBrowse == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnBeforeBrowseEventHandler m_OnBeforeBrowse;

        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |Request|
        /// object may be modified. To cancel the request return true (1) otherwise
        /// return false (0).
        /// </summary>
        public event CfxOnBeforeResourceLoadEventHandler OnBeforeResourceLoad {
            add {
                if(m_OnBeforeResourceLoad == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnBeforeResourceLoad += value;
            }
            remove {
                m_OnBeforeResourceLoad -= value;
                if(m_OnBeforeResourceLoad == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnBeforeResourceLoadEventHandler m_OnBeforeResourceLoad;

        /// <summary>
        /// Called on the IO thread before a resource is loaded. To allow the resource
        /// to load normally return NULL. To specify a handler for the resource return
        /// a CfxResourceHandler object. The |Request| object should not be
        /// modified in this callback.
        /// </summary>
        public event CfxGetResourceHandlerEventHandler GetResourceHandler {
            add {
                if(m_GetResourceHandler == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 2, 1);
                }
                m_GetResourceHandler += value;
            }
            remove {
                m_GetResourceHandler -= value;
                if(m_GetResourceHandler == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxGetResourceHandlerEventHandler m_GetResourceHandler;

        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |OldUrl|
        /// parameter will contain the old URL. The |NewUrl| parameter will contain
        /// the new URL and can be changed if desired.
        /// </summary>
        public event CfxOnResourceRedirectEventHandler OnResourceRedirect {
            add {
                if(m_OnResourceRedirect == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 3, 1);
                }
                m_OnResourceRedirect += value;
            }
            remove {
                m_OnResourceRedirect -= value;
                if(m_OnResourceRedirect == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxOnResourceRedirectEventHandler m_OnResourceRedirect;

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request.
        /// </summary>
        public event CfxRequestHandlerGetAuthCredentialsEventHandler GetAuthCredentials {
            add {
                if(m_GetAuthCredentials == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 4, 1);
                }
                m_GetAuthCredentials += value;
            }
            remove {
                m_GetAuthCredentials -= value;
                if(m_GetAuthCredentials == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxRequestHandlerGetAuthCredentialsEventHandler m_GetAuthCredentials;

        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |OriginUrl| is the
        /// origin of the page making the request. |NewSize| is the requested quota
        /// size in bytes. Return true (1) and call CfxQuotaCallback.Continue() either
        /// in this function or at a later time to grant or deny the request. Return
        /// false (0) to cancel the request.
        /// </summary>
        public event CfxOnQuotaRequestEventHandler OnQuotaRequest {
            add {
                if(m_OnQuotaRequest == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 5, 1);
                }
                m_OnQuotaRequest += value;
            }
            remove {
                m_OnQuotaRequest -= value;
                if(m_OnQuotaRequest == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 5, 0);
                }
            }
        }

        private CfxOnQuotaRequestEventHandler m_OnQuotaRequest;

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an unknown
        /// protocol component. Set |AllowOsExecution| to true (1) to attempt
        /// execution via the registered OS protocol handler, if any. SECURITY WARNING:
        /// YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED ON SCHEME, HOST OR
        /// OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
        /// </summary>
        public event CfxOnProtocolExecutionEventHandler OnProtocolExecution {
            add {
                if(m_OnProtocolExecution == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 6, 1);
                }
                m_OnProtocolExecution += value;
            }
            remove {
                m_OnProtocolExecution -= value;
                if(m_OnProtocolExecution == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 6, 0);
                }
            }
        }

        private CfxOnProtocolExecutionEventHandler m_OnProtocolExecution;

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an invalid SSL
        /// certificate. Return true (1) and call
        /// CfxAllowCertificateErrorCallback:: cont() either in this function or
        /// at a later time to continue or cancel the request. Return false (0) to
        /// cancel the request immediately. If |Callback| is NULL the error cannot be
        /// recovered from and the request will be canceled automatically. If
        /// CfxSettings.IgnoreCertificateErrors is set all invalid certificates will
        /// be accepted without calling this function.
        /// </summary>
        public event CfxOnCertificateErrorEventHandler OnCertificateError {
            add {
                if(m_OnCertificateError == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 7, 1);
                }
                m_OnCertificateError += value;
            }
            remove {
                m_OnCertificateError -= value;
                if(m_OnCertificateError == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 7, 0);
                }
            }
        }

        private CfxOnCertificateErrorEventHandler m_OnCertificateError;

        /// <summary>
        /// Called on the browser process IO thread before a plugin is loaded. Return
        /// true (1) to block loading of the plugin.
        /// </summary>
        public event CfxOnBeforePluginLoadEventHandler OnBeforePluginLoad {
            add {
                if(m_OnBeforePluginLoad == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 8, 1);
                }
                m_OnBeforePluginLoad += value;
            }
            remove {
                m_OnBeforePluginLoad -= value;
                if(m_OnBeforePluginLoad == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 8, 0);
                }
            }
        }

        private CfxOnBeforePluginLoadEventHandler m_OnBeforePluginLoad;

        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |PluginPath| is the path of the plugin that crashed.
        /// </summary>
        public event CfxOnPluginCrashedEventHandler OnPluginCrashed {
            add {
                if(m_OnPluginCrashed == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 9, 1);
                }
                m_OnPluginCrashed += value;
            }
            remove {
                m_OnPluginCrashed -= value;
                if(m_OnPluginCrashed == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 9, 0);
                }
            }
        }

        private CfxOnPluginCrashedEventHandler m_OnPluginCrashed;

        /// <summary>
        /// Called on the browser process UI thread when the render process terminates
        /// unexpectedly. |Status| indicates how the process terminated.
        /// </summary>
        public event CfxOnRenderProcessTerminatedEventHandler OnRenderProcessTerminated {
            add {
                if(m_OnRenderProcessTerminated == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 10, 1);
                }
                m_OnRenderProcessTerminated += value;
            }
            remove {
                m_OnRenderProcessTerminated -= value;
                if(m_OnRenderProcessTerminated == null) {
                    CfxApi.cfx_request_handler_activate_callback(NativePtr, 10, 0);
                }
            }
        }

        private CfxOnRenderProcessTerminatedEventHandler m_OnRenderProcessTerminated;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforeBrowse != null) {
                m_OnBeforeBrowse = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnBeforeResourceLoad != null) {
                m_OnBeforeResourceLoad = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_GetResourceHandler != null) {
                m_GetResourceHandler = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_OnResourceRedirect != null) {
                m_OnResourceRedirect = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_GetAuthCredentials != null) {
                m_GetAuthCredentials = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 4, 0);
            }
            if(m_OnQuotaRequest != null) {
                m_OnQuotaRequest = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 5, 0);
            }
            if(m_OnProtocolExecution != null) {
                m_OnProtocolExecution = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 6, 0);
            }
            if(m_OnCertificateError != null) {
                m_OnCertificateError = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 7, 0);
            }
            if(m_OnBeforePluginLoad != null) {
                m_OnBeforePluginLoad = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 8, 0);
            }
            if(m_OnPluginCrashed != null) {
                m_OnPluginCrashed = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 9, 0);
            }
            if(m_OnRenderProcessTerminated != null) {
                m_OnRenderProcessTerminated = null;
                CfxApi.cfx_request_handler_activate_callback(NativePtr, 10, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxOnBeforeBrowseEventHandler(object sender, CfxOnBeforeBrowseEventArgs e);

        /// <summary>
        /// Called on the UI thread before browser navigation. Return true (1) to
        /// cancel the navigation or false (0) to allow the navigation to proceed. The
        /// |Request| object cannot be modified in this callback.
        /// CfxLoadHandler.OnLoadingStateChange will be called twice in all cases.
        /// If the navigation is allowed CfxLoadHandler.OnLoadStart and
        /// CfxLoadHandler.OnLoadEnd will be called. If the navigation is canceled
        /// CfxLoadHandler.OnLoadError will be called with an |ErrorCode| value of
        /// ERR_ABORTED.
        /// </summary>
        public class CfxOnBeforeBrowseEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_request;
            internal CfxRequest m_request_wrapped;
            internal int m_is_redirect;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnBeforeBrowseEventArgs(IntPtr browser, IntPtr frame, IntPtr request, int is_redirect) {
                m_browser = browser;
                m_frame = frame;
                m_request = request;
                m_is_redirect = is_redirect;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFrame Frame {
                get {
                    CheckAccess();
                    if(m_frame_wrapped == null) m_frame_wrapped = CfxFrame.Wrap(m_frame);
                    return m_frame_wrapped;
                }
            }
            public CfxRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public bool IsRedirect {
                get {
                    CheckAccess();
                    return 0 != m_is_redirect;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}, IsRedirect={{{3}}}", Browser, Frame, Request, IsRedirect);
            }
        }

        public delegate void CfxOnBeforeResourceLoadEventHandler(object sender, CfxOnBeforeResourceLoadEventArgs e);

        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |Request|
        /// object may be modified. To cancel the request return true (1) otherwise
        /// return false (0).
        /// </summary>
        public class CfxOnBeforeResourceLoadEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_request;
            internal CfxRequest m_request_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnBeforeResourceLoadEventArgs(IntPtr browser, IntPtr frame, IntPtr request) {
                m_browser = browser;
                m_frame = frame;
                m_request = request;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFrame Frame {
                get {
                    CheckAccess();
                    if(m_frame_wrapped == null) m_frame_wrapped = CfxFrame.Wrap(m_frame);
                    return m_frame_wrapped;
                }
            }
            public CfxRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}", Browser, Frame, Request);
            }
        }

        public delegate void CfxGetResourceHandlerEventHandler(object sender, CfxGetResourceHandlerEventArgs e);

        /// <summary>
        /// Called on the IO thread before a resource is loaded. To allow the resource
        /// to load normally return NULL. To specify a handler for the resource return
        /// a CfxResourceHandler object. The |Request| object should not be
        /// modified in this callback.
        /// </summary>
        public class CfxGetResourceHandlerEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_request;
            internal CfxRequest m_request_wrapped;

            internal CfxResourceHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetResourceHandlerEventArgs(IntPtr browser, IntPtr frame, IntPtr request) {
                m_browser = browser;
                m_frame = frame;
                m_request = request;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFrame Frame {
                get {
                    CheckAccess();
                    if(m_frame_wrapped == null) m_frame_wrapped = CfxFrame.Wrap(m_frame);
                    return m_frame_wrapped;
                }
            }
            public CfxRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public void SetReturnValue(CfxResourceHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}", Browser, Frame, Request);
            }
        }

        public delegate void CfxOnResourceRedirectEventHandler(object sender, CfxOnResourceRedirectEventArgs e);

        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |OldUrl|
        /// parameter will contain the old URL. The |NewUrl| parameter will contain
        /// the new URL and can be changed if desired.
        /// </summary>
        public class CfxOnResourceRedirectEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_old_url_str;
            internal int m_old_url_length;
            internal string m_old_url;
            internal IntPtr m_new_url_str;
            internal int m_new_url_length;
            internal string m_new_url_wrapped;
            internal bool m_new_url_changed;

            internal CfxOnResourceRedirectEventArgs(IntPtr browser, IntPtr frame, IntPtr old_url_str, int old_url_length, IntPtr new_url_str, int new_url_length) {
                m_browser = browser;
                m_frame = frame;
                m_old_url_str = old_url_str;
                m_old_url_length = old_url_length;
                m_new_url_str = new_url_str;
                m_new_url_length = new_url_length;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFrame Frame {
                get {
                    CheckAccess();
                    if(m_frame_wrapped == null) m_frame_wrapped = CfxFrame.Wrap(m_frame);
                    return m_frame_wrapped;
                }
            }
            public string OldUrl {
                get {
                    CheckAccess();
                    if(m_old_url == null && m_old_url_str != IntPtr.Zero) m_old_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_old_url_str, m_old_url_length);
                    return m_old_url;
                }
            }
            public string NewUrl {
                get {
                    CheckAccess();
                    if(!m_new_url_changed && m_new_url_wrapped == null && m_new_url_str != IntPtr.Zero) {
                        m_new_url_wrapped = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_new_url_str, m_new_url_length);
                    }
                    return m_new_url_wrapped;
                }
                set {
                    CheckAccess();
                    m_new_url_wrapped = value;
                    m_new_url_changed = true;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, OldUrl={{{2}}}, NewUrl={{{3}}}", Browser, Frame, OldUrl, NewUrl);
            }
        }

        public delegate void CfxRequestHandlerGetAuthCredentialsEventHandler(object sender, CfxRequestHandlerGetAuthCredentialsEventArgs e);

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request.
        /// </summary>
        public class CfxRequestHandlerGetAuthCredentialsEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal int m_isProxy;
            internal IntPtr m_host_str;
            internal int m_host_length;
            internal string m_host;
            internal int m_port;
            internal IntPtr m_realm_str;
            internal int m_realm_length;
            internal string m_realm;
            internal IntPtr m_scheme_str;
            internal int m_scheme_length;
            internal string m_scheme;
            internal IntPtr m_callback;
            internal CfxAuthCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxRequestHandlerGetAuthCredentialsEventArgs(IntPtr browser, IntPtr frame, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback) {
                m_browser = browser;
                m_frame = frame;
                m_isProxy = isProxy;
                m_host_str = host_str;
                m_host_length = host_length;
                m_port = port;
                m_realm_str = realm_str;
                m_realm_length = realm_length;
                m_scheme_str = scheme_str;
                m_scheme_length = scheme_length;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFrame Frame {
                get {
                    CheckAccess();
                    if(m_frame_wrapped == null) m_frame_wrapped = CfxFrame.Wrap(m_frame);
                    return m_frame_wrapped;
                }
            }
            public int IsProxy {
                get {
                    CheckAccess();
                    return m_isProxy;
                }
            }
            public string Host {
                get {
                    CheckAccess();
                    if(m_host == null && m_host_str != IntPtr.Zero) m_host = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_host_str, m_host_length);
                    return m_host;
                }
            }
            public int Port {
                get {
                    CheckAccess();
                    return m_port;
                }
            }
            public string Realm {
                get {
                    CheckAccess();
                    if(m_realm == null && m_realm_str != IntPtr.Zero) m_realm = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_realm_str, m_realm_length);
                    return m_realm;
                }
            }
            public string Scheme {
                get {
                    CheckAccess();
                    if(m_scheme == null && m_scheme_str != IntPtr.Zero) m_scheme = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_scheme_str, m_scheme_length);
                    return m_scheme;
                }
            }
            public CfxAuthCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxAuthCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, IsProxy={{{2}}}, Host={{{3}}}, Port={{{4}}}, Realm={{{5}}}, Scheme={{{6}}}, Callback={{{7}}}", Browser, Frame, IsProxy, Host, Port, Realm, Scheme, Callback);
            }
        }

        public delegate void CfxOnQuotaRequestEventHandler(object sender, CfxOnQuotaRequestEventArgs e);

        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |OriginUrl| is the
        /// origin of the page making the request. |NewSize| is the requested quota
        /// size in bytes. Return true (1) and call CfxQuotaCallback.Continue() either
        /// in this function or at a later time to grant or deny the request. Return
        /// false (0) to cancel the request.
        /// </summary>
        public class CfxOnQuotaRequestEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_origin_url_str;
            internal int m_origin_url_length;
            internal string m_origin_url;
            internal long m_new_size;
            internal IntPtr m_callback;
            internal CfxQuotaCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnQuotaRequestEventArgs(IntPtr browser, IntPtr origin_url_str, int origin_url_length, long new_size, IntPtr callback) {
                m_browser = browser;
                m_origin_url_str = origin_url_str;
                m_origin_url_length = origin_url_length;
                m_new_size = new_size;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public string OriginUrl {
                get {
                    CheckAccess();
                    if(m_origin_url == null && m_origin_url_str != IntPtr.Zero) m_origin_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_origin_url_str, m_origin_url_length);
                    return m_origin_url;
                }
            }
            public long NewSize {
                get {
                    CheckAccess();
                    return m_new_size;
                }
            }
            public CfxQuotaCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxQuotaCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, OriginUrl={{{1}}}, NewSize={{{2}}}, Callback={{{3}}}", Browser, OriginUrl, NewSize, Callback);
            }
        }

        public delegate void CfxOnProtocolExecutionEventHandler(object sender, CfxOnProtocolExecutionEventArgs e);

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an unknown
        /// protocol component. Set |AllowOsExecution| to true (1) to attempt
        /// execution via the registered OS protocol handler, if any. SECURITY WARNING:
        /// YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED ON SCHEME, HOST OR
        /// OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
        /// </summary>
        public class CfxOnProtocolExecutionEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_url_str;
            internal int m_url_length;
            internal string m_url;
            internal int m_allow_os_execution;

            internal CfxOnProtocolExecutionEventArgs(IntPtr browser, IntPtr url_str, int url_length) {
                m_browser = browser;
                m_url_str = url_str;
                m_url_length = url_length;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public string Url {
                get {
                    CheckAccess();
                    if(m_url == null && m_url_str != IntPtr.Zero) m_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_url_str, m_url_length);
                    return m_url;
                }
            }
            public bool AllowOsExecution {
                set {
                    CheckAccess();
                    m_allow_os_execution = value ? 1 : 0;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Url={{{1}}}", Browser, Url);
            }
        }

        public delegate void CfxOnCertificateErrorEventHandler(object sender, CfxOnCertificateErrorEventArgs e);

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an invalid SSL
        /// certificate. Return true (1) and call
        /// CfxAllowCertificateErrorCallback:: cont() either in this function or
        /// at a later time to continue or cancel the request. Return false (0) to
        /// cancel the request immediately. If |Callback| is NULL the error cannot be
        /// recovered from and the request will be canceled automatically. If
        /// CfxSettings.IgnoreCertificateErrors is set all invalid certificates will
        /// be accepted without calling this function.
        /// </summary>
        public class CfxOnCertificateErrorEventArgs : CfxEventArgs {

            internal CfxErrorCode m_cert_error;
            internal IntPtr m_request_url_str;
            internal int m_request_url_length;
            internal string m_request_url;
            internal IntPtr m_callback;
            internal CfxAllowCertificateErrorCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnCertificateErrorEventArgs(CfxErrorCode cert_error, IntPtr request_url_str, int request_url_length, IntPtr callback) {
                m_cert_error = cert_error;
                m_request_url_str = request_url_str;
                m_request_url_length = request_url_length;
                m_callback = callback;
            }

            public CfxErrorCode CertError {
                get {
                    CheckAccess();
                    return m_cert_error;
                }
            }
            public string RequestUrl {
                get {
                    CheckAccess();
                    if(m_request_url == null && m_request_url_str != IntPtr.Zero) m_request_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_request_url_str, m_request_url_length);
                    return m_request_url;
                }
            }
            public CfxAllowCertificateErrorCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxAllowCertificateErrorCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("CertError={{{0}}}, RequestUrl={{{1}}}, Callback={{{2}}}", CertError, RequestUrl, Callback);
            }
        }

        public delegate void CfxOnBeforePluginLoadEventHandler(object sender, CfxOnBeforePluginLoadEventArgs e);

        /// <summary>
        /// Called on the browser process IO thread before a plugin is loaded. Return
        /// true (1) to block loading of the plugin.
        /// </summary>
        public class CfxOnBeforePluginLoadEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_url_str;
            internal int m_url_length;
            internal string m_url;
            internal IntPtr m_policy_url_str;
            internal int m_policy_url_length;
            internal string m_policy_url;
            internal IntPtr m_info;
            internal CfxWebPluginInfo m_info_wrapped;

            internal int m_returnValue;
            private bool returnValueSet;

            internal CfxOnBeforePluginLoadEventArgs(IntPtr browser, IntPtr url_str, int url_length, IntPtr policy_url_str, int policy_url_length, IntPtr info) {
                m_browser = browser;
                m_url_str = url_str;
                m_url_length = url_length;
                m_policy_url_str = policy_url_str;
                m_policy_url_length = policy_url_length;
                m_info = info;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public string Url {
                get {
                    CheckAccess();
                    if(m_url == null && m_url_str != IntPtr.Zero) m_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_url_str, m_url_length);
                    return m_url;
                }
            }
            public string PolicyUrl {
                get {
                    CheckAccess();
                    if(m_policy_url == null && m_policy_url_str != IntPtr.Zero) m_policy_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_policy_url_str, m_policy_url_length);
                    return m_policy_url;
                }
            }
            public CfxWebPluginInfo Info {
                get {
                    CheckAccess();
                    if(m_info_wrapped == null) m_info_wrapped = CfxWebPluginInfo.Wrap(m_info);
                    return m_info_wrapped;
                }
            }
            public void SetReturnValue(int returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Url={{{1}}}, PolicyUrl={{{2}}}, Info={{{3}}}", Browser, Url, PolicyUrl, Info);
            }
        }

        public delegate void CfxOnPluginCrashedEventHandler(object sender, CfxOnPluginCrashedEventArgs e);

        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |PluginPath| is the path of the plugin that crashed.
        /// </summary>
        public class CfxOnPluginCrashedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_plugin_path_str;
            internal int m_plugin_path_length;
            internal string m_plugin_path;

            internal CfxOnPluginCrashedEventArgs(IntPtr browser, IntPtr plugin_path_str, int plugin_path_length) {
                m_browser = browser;
                m_plugin_path_str = plugin_path_str;
                m_plugin_path_length = plugin_path_length;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public string PluginPath {
                get {
                    CheckAccess();
                    if(m_plugin_path == null && m_plugin_path_str != IntPtr.Zero) m_plugin_path = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_plugin_path_str, m_plugin_path_length);
                    return m_plugin_path;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, PluginPath={{{1}}}", Browser, PluginPath);
            }
        }

        public delegate void CfxOnRenderProcessTerminatedEventHandler(object sender, CfxOnRenderProcessTerminatedEventArgs e);

        /// <summary>
        /// Called on the browser process UI thread when the render process terminates
        /// unexpectedly. |Status| indicates how the process terminated.
        /// </summary>
        public class CfxOnRenderProcessTerminatedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal CfxTerminationStatus m_status;

            internal CfxOnRenderProcessTerminatedEventArgs(IntPtr browser, CfxTerminationStatus status) {
                m_browser = browser;
                m_status = status;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxTerminationStatus Status {
                get {
                    CheckAccess();
                    return m_status;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Status={{{1}}}", Browser, Status);
            }
        }

    }
}
