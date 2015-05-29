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
    /// Implement this structure to provide handler implementations. The handler
    /// instance will not be released until all objects related to the context have
    /// been destroyed.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_request_context_handler_capi.h">cef/include/capi/cef_request_context_handler_capi.h</see>.
    /// </remarks>
    public class CfxRequestContextHandler : CfxBase {

        static CfxRequestContextHandler () {
            CfxApiLoader.LoadCfxRequestContextHandlerApi();
        }

        internal static CfxRequestContextHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_request_context_handler_get_gc_handle(nativePtr);
            return (CfxRequestContextHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        // get_cookie_manager
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_request_context_handler_get_cookie_manager_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static cfx_request_context_handler_get_cookie_manager_delegate cfx_request_context_handler_get_cookie_manager;
        private static IntPtr cfx_request_context_handler_get_cookie_manager_ptr;

        internal static void get_cookie_manager(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxRequestContextHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxRequestContextHandlerGetCookieManagerEventArgs();
            var eventHandler = self.m_GetCookieManager;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxCookieManager.Unwrap(e.m_returnValue);
        }

        internal CfxRequestContextHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxRequestContextHandler() : base(CfxApi.cfx_request_context_handler_ctor) {}

        /// <summary>
        /// Called on the IO thread to retrieve the cookie manager. If this function
        /// returns NULL the default cookie manager retrievable via
        /// CfxRequestContext.GetDefaultCookieManager() will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_request_context_handler_capi.h">cef/include/capi/cef_request_context_handler_capi.h</see>.
        /// </remarks>
        public event CfxRequestContextHandlerGetCookieManagerEventHandler GetCookieManager {
            add {
                lock(eventLock) {
                    if(m_GetCookieManager == null) {
                        if(cfx_request_context_handler_get_cookie_manager == null) {
                            cfx_request_context_handler_get_cookie_manager = get_cookie_manager;
                            cfx_request_context_handler_get_cookie_manager_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_request_context_handler_get_cookie_manager);
                        }
                        CfxApi.cfx_request_context_handler_set_managed_callback(NativePtr, 0, cfx_request_context_handler_get_cookie_manager_ptr);
                    }
                    m_GetCookieManager += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetCookieManager -= value;
                    if(m_GetCookieManager == null) {
                        CfxApi.cfx_request_context_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxRequestContextHandlerGetCookieManagerEventHandler m_GetCookieManager;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_GetCookieManager != null) {
                m_GetCookieManager = null;
                CfxApi.cfx_request_context_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called on the IO thread to retrieve the cookie manager. If this function
        /// returns NULL the default cookie manager retrievable via
        /// CfxRequestContext.GetDefaultCookieManager() will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_request_context_handler_capi.h">cef/include/capi/cef_request_context_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxRequestContextHandlerGetCookieManagerEventHandler(object sender, CfxRequestContextHandlerGetCookieManagerEventArgs e);

        /// <summary>
        /// Called on the IO thread to retrieve the cookie manager. If this function
        /// returns NULL the default cookie manager retrievable via
        /// CfxRequestContext.GetDefaultCookieManager() will be used.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_request_context_handler_capi.h">cef/include/capi/cef_request_context_handler_capi.h</see>.
        /// </remarks>
        public class CfxRequestContextHandlerGetCookieManagerEventArgs : CfxEventArgs {


            internal CfxCookieManager m_returnValue;
            private bool returnValueSet;

            internal CfxRequestContextHandlerGetCookieManagerEventArgs() {
            }

            /// <summary>
            /// Set the return value for the <see cref="CfxRequestContextHandler.GetCookieManager"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfxCookieManager returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

    }
}
