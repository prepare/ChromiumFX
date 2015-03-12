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
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
    /// </remarks>
    public class CfxRequestHandler : CfxBase {

        internal static CfxRequestHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_request_handler_get_gc_handle(nativePtr);
            return (CfxRequestHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        // on_before_browse
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_before_browse_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request, int is_redirect);
        private static cfx_request_handler_on_before_browse_delegate cfx_request_handler_on_before_browse;
        private static IntPtr cfx_request_handler_on_before_browse_ptr;

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

        // on_before_resource_load
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_before_resource_load_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request);
        private static cfx_request_handler_on_before_resource_load_delegate cfx_request_handler_on_before_resource_load;
        private static IntPtr cfx_request_handler_on_before_resource_load_ptr;

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

        // get_resource_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_get_resource_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval, IntPtr browser, IntPtr frame, IntPtr request);
        private static cfx_request_handler_get_resource_handler_delegate cfx_request_handler_get_resource_handler;
        private static IntPtr cfx_request_handler_get_resource_handler_ptr;

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

        // on_resource_redirect
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_resource_redirect_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr old_url_str, int old_url_length, ref IntPtr new_url_str, ref int new_url_length);
        private static cfx_request_handler_on_resource_redirect_delegate cfx_request_handler_on_resource_redirect;
        private static IntPtr cfx_request_handler_on_resource_redirect_ptr;

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

        // get_auth_credentials
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_get_auth_credentials_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback);
        private static cfx_request_handler_get_auth_credentials_delegate cfx_request_handler_get_auth_credentials;
        private static IntPtr cfx_request_handler_get_auth_credentials_ptr;

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

        // on_quota_request
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_quota_request_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr origin_url_str, int origin_url_length, long new_size, IntPtr callback);
        private static cfx_request_handler_on_quota_request_delegate cfx_request_handler_on_quota_request;
        private static IntPtr cfx_request_handler_on_quota_request_ptr;

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

        // on_protocol_execution
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_protocol_execution_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr url_str, int url_length, out int allow_os_execution);
        private static cfx_request_handler_on_protocol_execution_delegate cfx_request_handler_on_protocol_execution;
        private static IntPtr cfx_request_handler_on_protocol_execution_ptr;

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

        // on_certificate_error
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_certificate_error_delegate(IntPtr gcHandlePtr, out int __retval, CfxErrorCode cert_error, IntPtr request_url_str, int request_url_length, IntPtr callback);
        private static cfx_request_handler_on_certificate_error_delegate cfx_request_handler_on_certificate_error;
        private static IntPtr cfx_request_handler_on_certificate_error_ptr;

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

        // on_before_plugin_load
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_before_plugin_load_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr url_str, int url_length, IntPtr policy_url_str, int policy_url_length, IntPtr info);
        private static cfx_request_handler_on_before_plugin_load_delegate cfx_request_handler_on_before_plugin_load;
        private static IntPtr cfx_request_handler_on_before_plugin_load_ptr;

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

        // on_plugin_crashed
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_plugin_crashed_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr plugin_path_str, int plugin_path_length);
        private static cfx_request_handler_on_plugin_crashed_delegate cfx_request_handler_on_plugin_crashed;
        private static IntPtr cfx_request_handler_on_plugin_crashed_ptr;

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

        // on_render_process_terminated
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_handler_on_render_process_terminated_delegate(IntPtr gcHandlePtr, IntPtr browser, CfxTerminationStatus status);
        private static cfx_request_handler_on_render_process_terminated_delegate cfx_request_handler_on_render_process_terminated;
        private static IntPtr cfx_request_handler_on_render_process_terminated_ptr;

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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforeBrowseEventHandler OnBeforeBrowse {
            add {
                lock(eventLock) {
                    if(m_OnBeforeBrowse == null) {
                        if(cfx_request_handler_on_before_browse == null) {
                            cfx_request_handler_on_before_browse = on_before_browse;
                            cfx_request_handler_on_before_browse_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_browse);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 0, cfx_request_handler_on_before_browse_ptr);
                    }
                    m_OnBeforeBrowse += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnBeforeBrowse -= value;
                    if(m_OnBeforeBrowse == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnBeforeBrowseEventHandler m_OnBeforeBrowse;

        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |Request|
        /// object may be modified. To cancel the request return true (1) otherwise
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforeResourceLoadEventHandler OnBeforeResourceLoad {
            add {
                lock(eventLock) {
                    if(m_OnBeforeResourceLoad == null) {
                        if(cfx_request_handler_on_before_resource_load == null) {
                            cfx_request_handler_on_before_resource_load = on_before_resource_load;
                            cfx_request_handler_on_before_resource_load_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_resource_load);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 1, cfx_request_handler_on_before_resource_load_ptr);
                    }
                    m_OnBeforeResourceLoad += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnBeforeResourceLoad -= value;
                    if(m_OnBeforeResourceLoad == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 1, IntPtr.Zero);
                    }
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxGetResourceHandlerEventHandler GetResourceHandler {
            add {
                lock(eventLock) {
                    if(m_GetResourceHandler == null) {
                        if(cfx_request_handler_get_resource_handler == null) {
                            cfx_request_handler_get_resource_handler = get_resource_handler;
                            cfx_request_handler_get_resource_handler_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_get_resource_handler);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 2, cfx_request_handler_get_resource_handler_ptr);
                    }
                    m_GetResourceHandler += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetResourceHandler -= value;
                    if(m_GetResourceHandler == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 2, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxGetResourceHandlerEventHandler m_GetResourceHandler;

        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |OldUrl|
        /// parameter will contain the old URL. The |NewUrl| parameter will contain
        /// the new URL and can be changed if desired.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnResourceRedirectEventHandler OnResourceRedirect {
            add {
                lock(eventLock) {
                    if(m_OnResourceRedirect == null) {
                        if(cfx_request_handler_on_resource_redirect == null) {
                            cfx_request_handler_on_resource_redirect = on_resource_redirect;
                            cfx_request_handler_on_resource_redirect_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_resource_redirect);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 3, cfx_request_handler_on_resource_redirect_ptr);
                    }
                    m_OnResourceRedirect += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnResourceRedirect -= value;
                    if(m_OnResourceRedirect == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 3, IntPtr.Zero);
                    }
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxRequestHandlerGetAuthCredentialsEventHandler GetAuthCredentials {
            add {
                lock(eventLock) {
                    if(m_GetAuthCredentials == null) {
                        if(cfx_request_handler_get_auth_credentials == null) {
                            cfx_request_handler_get_auth_credentials = get_auth_credentials;
                            cfx_request_handler_get_auth_credentials_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_get_auth_credentials);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 4, cfx_request_handler_get_auth_credentials_ptr);
                    }
                    m_GetAuthCredentials += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetAuthCredentials -= value;
                    if(m_GetAuthCredentials == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 4, IntPtr.Zero);
                    }
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnQuotaRequestEventHandler OnQuotaRequest {
            add {
                lock(eventLock) {
                    if(m_OnQuotaRequest == null) {
                        if(cfx_request_handler_on_quota_request == null) {
                            cfx_request_handler_on_quota_request = on_quota_request;
                            cfx_request_handler_on_quota_request_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_quota_request);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 5, cfx_request_handler_on_quota_request_ptr);
                    }
                    m_OnQuotaRequest += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnQuotaRequest -= value;
                    if(m_OnQuotaRequest == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 5, IntPtr.Zero);
                    }
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnProtocolExecutionEventHandler OnProtocolExecution {
            add {
                lock(eventLock) {
                    if(m_OnProtocolExecution == null) {
                        if(cfx_request_handler_on_protocol_execution == null) {
                            cfx_request_handler_on_protocol_execution = on_protocol_execution;
                            cfx_request_handler_on_protocol_execution_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_protocol_execution);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 6, cfx_request_handler_on_protocol_execution_ptr);
                    }
                    m_OnProtocolExecution += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnProtocolExecution -= value;
                    if(m_OnProtocolExecution == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 6, IntPtr.Zero);
                    }
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnCertificateErrorEventHandler OnCertificateError {
            add {
                lock(eventLock) {
                    if(m_OnCertificateError == null) {
                        if(cfx_request_handler_on_certificate_error == null) {
                            cfx_request_handler_on_certificate_error = on_certificate_error;
                            cfx_request_handler_on_certificate_error_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_certificate_error);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 7, cfx_request_handler_on_certificate_error_ptr);
                    }
                    m_OnCertificateError += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnCertificateError -= value;
                    if(m_OnCertificateError == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 7, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnCertificateErrorEventHandler m_OnCertificateError;

        /// <summary>
        /// Called on the browser process IO thread before a plugin is loaded. Return
        /// true (1) to block loading of the plugin.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforePluginLoadEventHandler OnBeforePluginLoad {
            add {
                lock(eventLock) {
                    if(m_OnBeforePluginLoad == null) {
                        if(cfx_request_handler_on_before_plugin_load == null) {
                            cfx_request_handler_on_before_plugin_load = on_before_plugin_load;
                            cfx_request_handler_on_before_plugin_load_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_plugin_load);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 8, cfx_request_handler_on_before_plugin_load_ptr);
                    }
                    m_OnBeforePluginLoad += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnBeforePluginLoad -= value;
                    if(m_OnBeforePluginLoad == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 8, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnBeforePluginLoadEventHandler m_OnBeforePluginLoad;

        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |PluginPath| is the path of the plugin that crashed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnPluginCrashedEventHandler OnPluginCrashed {
            add {
                lock(eventLock) {
                    if(m_OnPluginCrashed == null) {
                        if(cfx_request_handler_on_plugin_crashed == null) {
                            cfx_request_handler_on_plugin_crashed = on_plugin_crashed;
                            cfx_request_handler_on_plugin_crashed_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_plugin_crashed);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 9, cfx_request_handler_on_plugin_crashed_ptr);
                    }
                    m_OnPluginCrashed += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnPluginCrashed -= value;
                    if(m_OnPluginCrashed == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 9, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnPluginCrashedEventHandler m_OnPluginCrashed;

        /// <summary>
        /// Called on the browser process UI thread when the render process terminates
        /// unexpectedly. |Status| indicates how the process terminated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnRenderProcessTerminatedEventHandler OnRenderProcessTerminated {
            add {
                lock(eventLock) {
                    if(m_OnRenderProcessTerminated == null) {
                        if(cfx_request_handler_on_render_process_terminated == null) {
                            cfx_request_handler_on_render_process_terminated = on_render_process_terminated;
                            cfx_request_handler_on_render_process_terminated_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_render_process_terminated);
                        }
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 10, cfx_request_handler_on_render_process_terminated_ptr);
                    }
                    m_OnRenderProcessTerminated += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnRenderProcessTerminated -= value;
                    if(m_OnRenderProcessTerminated == null) {
                        CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 10, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnRenderProcessTerminatedEventHandler m_OnRenderProcessTerminated;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforeBrowse != null) {
                m_OnBeforeBrowse = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
            }
            if(m_OnBeforeResourceLoad != null) {
                m_OnBeforeResourceLoad = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 1, IntPtr.Zero);
            }
            if(m_GetResourceHandler != null) {
                m_GetResourceHandler = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 2, IntPtr.Zero);
            }
            if(m_OnResourceRedirect != null) {
                m_OnResourceRedirect = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 3, IntPtr.Zero);
            }
            if(m_GetAuthCredentials != null) {
                m_GetAuthCredentials = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 4, IntPtr.Zero);
            }
            if(m_OnQuotaRequest != null) {
                m_OnQuotaRequest = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 5, IntPtr.Zero);
            }
            if(m_OnProtocolExecution != null) {
                m_OnProtocolExecution = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 6, IntPtr.Zero);
            }
            if(m_OnCertificateError != null) {
                m_OnCertificateError = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 7, IntPtr.Zero);
            }
            if(m_OnBeforePluginLoad != null) {
                m_OnBeforePluginLoad = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 8, IntPtr.Zero);
            }
            if(m_OnPluginCrashed != null) {
                m_OnPluginCrashed = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 9, IntPtr.Zero);
            }
            if(m_OnRenderProcessTerminated != null) {
                m_OnRenderProcessTerminated = null;
                CfxApi.cfx_request_handler_set_managed_callback(NativePtr, 10, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}, IsRedirect={{{3}}}", Browser, Frame, Request, IsRedirect);
            }
        }

        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |Request|
        /// object may be modified. To cancel the request return true (1) otherwise
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforeResourceLoadEventHandler(object sender, CfxOnBeforeResourceLoadEventArgs e);

        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |Request|
        /// object may be modified. To cancel the request return true (1) otherwise
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}", Browser, Frame, Request);
            }
        }

        /// <summary>
        /// Called on the IO thread before a resource is loaded. To allow the resource
        /// to load normally return NULL. To specify a handler for the resource return
        /// a CfxResourceHandler object. The |Request| object should not be
        /// modified in this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetResourceHandlerEventHandler(object sender, CfxGetResourceHandlerEventArgs e);

        /// <summary>
        /// Called on the IO thread before a resource is loaded. To allow the resource
        /// to load normally return NULL. To specify a handler for the resource return
        /// a CfxResourceHandler object. The |Request| object should not be
        /// modified in this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
            /// </remarks>
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

        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |OldUrl|
        /// parameter will contain the old URL. The |NewUrl| parameter will contain
        /// the new URL and can be changed if desired.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnResourceRedirectEventHandler(object sender, CfxOnResourceRedirectEventArgs e);

        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |OldUrl|
        /// parameter will contain the old URL. The |NewUrl| parameter will contain
        /// the new URL and can be changed if desired.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxRequestHandlerGetAuthCredentialsEventHandler(object sender, CfxRequestHandlerGetAuthCredentialsEventArgs e);

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, IsProxy={{{2}}}, Host={{{3}}}, Port={{{4}}}, Realm={{{5}}}, Scheme={{{6}}}, Callback={{{7}}}", Browser, Frame, IsProxy, Host, Port, Realm, Scheme, Callback);
            }
        }

        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |OriginUrl| is the
        /// origin of the page making the request. |NewSize| is the requested quota
        /// size in bytes. Return true (1) and call CfxQuotaCallback.Continue() either
        /// in this function or at a later time to grant or deny the request. Return
        /// false (0) to cancel the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnQuotaRequestEventHandler(object sender, CfxOnQuotaRequestEventArgs e);

        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |OriginUrl| is the
        /// origin of the page making the request. |NewSize| is the requested quota
        /// size in bytes. Return true (1) and call CfxQuotaCallback.Continue() either
        /// in this function or at a later time to grant or deny the request. Return
        /// false (0) to cancel the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, OriginUrl={{{1}}}, NewSize={{{2}}}, Callback={{{3}}}", Browser, OriginUrl, NewSize, Callback);
            }
        }

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an unknown
        /// protocol component. Set |AllowOsExecution| to true (1) to attempt
        /// execution via the registered OS protocol handler, if any. SECURITY WARNING:
        /// YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED ON SCHEME, HOST OR
        /// OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnProtocolExecutionEventHandler(object sender, CfxOnProtocolExecutionEventArgs e);

        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an unknown
        /// protocol component. Set |AllowOsExecution| to true (1) to attempt
        /// execution via the registered OS protocol handler, if any. SECURITY WARNING:
        /// YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED ON SCHEME, HOST OR
        /// OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
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
                return String.Format("CertError={{{0}}}, RequestUrl={{{1}}}, Callback={{{2}}}", CertError, RequestUrl, Callback);
            }
        }

        /// <summary>
        /// Called on the browser process IO thread before a plugin is loaded. Return
        /// true (1) to block loading of the plugin.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforePluginLoadEventHandler(object sender, CfxOnBeforePluginLoadEventArgs e);

        /// <summary>
        /// Called on the browser process IO thread before a plugin is loaded. Return
        /// true (1) to block loading of the plugin.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
            /// </remarks>
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

        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |PluginPath| is the path of the plugin that crashed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnPluginCrashedEventHandler(object sender, CfxOnPluginCrashedEventArgs e);

        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |PluginPath| is the path of the plugin that crashed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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

        /// <summary>
        /// Called on the browser process UI thread when the render process terminates
        /// unexpectedly. |Status| indicates how the process terminated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnRenderProcessTerminatedEventHandler(object sender, CfxOnRenderProcessTerminatedEventArgs e);

        /// <summary>
        /// Called on the browser process UI thread when the render process terminates
        /// unexpectedly. |Status| indicates how the process terminated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_handler_capi.h">cef/include/capi/cef_request_handler_capi.h</see>.
        /// </remarks>
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
