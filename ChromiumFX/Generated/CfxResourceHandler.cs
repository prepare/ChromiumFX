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
    /// Structure used to implement a custom request handler structure. The functions
    /// of this structure will always be called on the IO thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
    /// </remarks>
    public class CfxResourceHandler : CfxBase {

        internal static CfxResourceHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_resource_handler_get_gc_handle(nativePtr);
            return (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void process_request(IntPtr gcHandlePtr, out int __retval, IntPtr request, IntPtr callback) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxProcessRequestEventArgs(request, callback);
            var eventHandler = self.m_ProcessRequest;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void get_response_headers(IntPtr gcHandlePtr, IntPtr response, out long response_length, ref IntPtr redirectUrl_str, ref int redirectUrl_length) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                response_length = default(long);
                return;
            }
            var e = new CfxGetResponseHeadersEventArgs(response, redirectUrl_str, redirectUrl_length);
            var eventHandler = self.m_GetResponseHeaders;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_response_wrapped == null) CfxApi.cfx_release(e.m_response);
            response_length = e.m_response_length;
            if(e.m_redirectUrl_changed) {
                var redirectUrl_pinned = new PinnedString(e.m_redirectUrl_wrapped);
                redirectUrl_str = redirectUrl_pinned.Obj.PinnedPtr;
                redirectUrl_length = redirectUrl_pinned.Length;
            }
        }

        internal static void read_response(IntPtr gcHandlePtr, out int __retval, IntPtr data_out, int bytes_to_read, out int bytes_read, IntPtr callback) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                bytes_read = default(int);
                return;
            }
            var e = new CfxReadResponseEventArgs(data_out, bytes_to_read, callback);
            var eventHandler = self.m_ReadResponse;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            bytes_read = e.m_bytes_read;
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void can_get_cookie(IntPtr gcHandlePtr, out int __retval, IntPtr cookie) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxCanGetCookieEventArgs(cookie);
            var eventHandler = self.m_CanGetCookie;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void can_set_cookie(IntPtr gcHandlePtr, out int __retval, IntPtr cookie) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxCanSetCookieEventArgs(cookie);
            var eventHandler = self.m_CanSetCookie;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void cancel(IntPtr gcHandlePtr) {
            var self = (CfxResourceHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxEventArgs();
            var eventHandler = self.m_Cancel;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
        }

        internal CfxResourceHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxResourceHandler() : base(CfxApi.cfx_resource_handler_ctor) {}

        /// <summary>
        /// Begin processing the request. To handle the request return true (1) and
        /// call CfxCallback.Continue() once the response header information is
        /// available (CfxCallback.Continue() can also be called from inside this
        /// function if header information is available immediately). To cancel the
        /// request return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxProcessRequestEventHandler ProcessRequest {
            add {
                if(m_ProcessRequest == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 0, 1);
                }
                m_ProcessRequest += value;
            }
            remove {
                m_ProcessRequest -= value;
                if(m_ProcessRequest == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxProcessRequestEventHandler m_ProcessRequest;

        /// <summary>
        /// Retrieve response header information. If the response length is not known
        /// set |ResponseLength| to -1 and read_response() will be called until it
        /// returns false (0). If the response length is known set |ResponseLength| to
        /// a positive value and read_response() will be called until it returns false
        /// (0) or the specified number of bytes have been read. Use the |Response|
        /// object to set the mime type, http status code and other optional header
        /// values. To redirect the request to a new URL set |RedirectUrl| to the new
        /// URL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxGetResponseHeadersEventHandler GetResponseHeaders {
            add {
                if(m_GetResponseHeaders == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 1, 1);
                }
                m_GetResponseHeaders += value;
            }
            remove {
                m_GetResponseHeaders -= value;
                if(m_GetResponseHeaders == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxGetResponseHeadersEventHandler m_GetResponseHeaders;

        /// <summary>
        /// Read response data. If data is available immediately copy up to
        /// |BytesToRead| bytes into |DataOut|, set |BytesRead| to the number of
        /// bytes copied, and return true (1). To read the data at a later time set
        /// |BytesRead| to 0, return true (1) and call CfxCallback.Continue() when the
        /// data is available. To indicate response completion return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxReadResponseEventHandler ReadResponse {
            add {
                if(m_ReadResponse == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 2, 1);
                }
                m_ReadResponse += value;
            }
            remove {
                m_ReadResponse -= value;
                if(m_ReadResponse == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxReadResponseEventHandler m_ReadResponse;

        /// <summary>
        /// Return true (1) if the specified cookie can be sent with the request or
        /// false (0) otherwise. If false (0) is returned for any cookie then no
        /// cookies will be sent with the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxCanGetCookieEventHandler CanGetCookie {
            add {
                if(m_CanGetCookie == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 3, 1);
                }
                m_CanGetCookie += value;
            }
            remove {
                m_CanGetCookie -= value;
                if(m_CanGetCookie == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxCanGetCookieEventHandler m_CanGetCookie;

        /// <summary>
        /// Return true (1) if the specified cookie returned with the response can be
        /// set or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxCanSetCookieEventHandler CanSetCookie {
            add {
                if(m_CanSetCookie == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 4, 1);
                }
                m_CanSetCookie += value;
            }
            remove {
                m_CanSetCookie -= value;
                if(m_CanSetCookie == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxCanSetCookieEventHandler m_CanSetCookie;

        /// <summary>
        /// Request processing has been canceled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public event CfxEventHandler Cancel {
            add {
                if(m_Cancel == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 5, 1);
                }
                m_Cancel += value;
            }
            remove {
                m_Cancel -= value;
                if(m_Cancel == null) {
                    CfxApi.cfx_resource_handler_activate_callback(NativePtr, 5, 0);
                }
            }
        }

        private CfxEventHandler m_Cancel;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_ProcessRequest != null) {
                m_ProcessRequest = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_GetResponseHeaders != null) {
                m_GetResponseHeaders = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_ReadResponse != null) {
                m_ReadResponse = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_CanGetCookie != null) {
                m_CanGetCookie = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_CanSetCookie != null) {
                m_CanSetCookie = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 4, 0);
            }
            if(m_Cancel != null) {
                m_Cancel = null;
                CfxApi.cfx_resource_handler_activate_callback(NativePtr, 5, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Begin processing the request. To handle the request return true (1) and
        /// call CfxCallback.Continue() once the response header information is
        /// available (CfxCallback.Continue() can also be called from inside this
        /// function if header information is available immediately). To cancel the
        /// request return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxProcessRequestEventHandler(object sender, CfxProcessRequestEventArgs e);

        /// <summary>
        /// Begin processing the request. To handle the request return true (1) and
        /// call CfxCallback.Continue() once the response header information is
        /// available (CfxCallback.Continue() can also be called from inside this
        /// function if header information is available immediately). To cancel the
        /// request return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public class CfxProcessRequestEventArgs : CfxEventArgs {

            internal IntPtr m_request;
            internal CfxRequest m_request_wrapped;
            internal IntPtr m_callback;
            internal CfxCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxProcessRequestEventArgs(IntPtr request, IntPtr callback) {
                m_request = request;
                m_callback = callback;
            }

            public CfxRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public CfxCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            /// <summary>
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
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
                return String.Format("Request={{{0}}}, Callback={{{1}}}", Request, Callback);
            }
        }

        /// <summary>
        /// Retrieve response header information. If the response length is not known
        /// set |ResponseLength| to -1 and read_response() will be called until it
        /// returns false (0). If the response length is known set |ResponseLength| to
        /// a positive value and read_response() will be called until it returns false
        /// (0) or the specified number of bytes have been read. Use the |Response|
        /// object to set the mime type, http status code and other optional header
        /// values. To redirect the request to a new URL set |RedirectUrl| to the new
        /// URL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetResponseHeadersEventHandler(object sender, CfxGetResponseHeadersEventArgs e);

        /// <summary>
        /// Retrieve response header information. If the response length is not known
        /// set |ResponseLength| to -1 and read_response() will be called until it
        /// returns false (0). If the response length is known set |ResponseLength| to
        /// a positive value and read_response() will be called until it returns false
        /// (0) or the specified number of bytes have been read. Use the |Response|
        /// object to set the mime type, http status code and other optional header
        /// values. To redirect the request to a new URL set |RedirectUrl| to the new
        /// URL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public class CfxGetResponseHeadersEventArgs : CfxEventArgs {

            internal IntPtr m_response;
            internal CfxResponse m_response_wrapped;
            internal long m_response_length;
            internal IntPtr m_redirectUrl_str;
            internal int m_redirectUrl_length;
            internal string m_redirectUrl_wrapped;
            internal bool m_redirectUrl_changed;

            internal CfxGetResponseHeadersEventArgs(IntPtr response, IntPtr redirectUrl_str, int redirectUrl_length) {
                m_response = response;
                m_redirectUrl_str = redirectUrl_str;
                m_redirectUrl_length = redirectUrl_length;
            }

            public CfxResponse Response {
                get {
                    CheckAccess();
                    if(m_response_wrapped == null) m_response_wrapped = CfxResponse.Wrap(m_response);
                    return m_response_wrapped;
                }
            }
            public long ResponseLength {
                set {
                    CheckAccess();
                    m_response_length = value;
                }
            }
            public string RedirectUrl {
                get {
                    CheckAccess();
                    if(!m_redirectUrl_changed && m_redirectUrl_wrapped == null && m_redirectUrl_str != IntPtr.Zero) {
                        m_redirectUrl_wrapped = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_redirectUrl_str, m_redirectUrl_length);
                    }
                    return m_redirectUrl_wrapped;
                }
                set {
                    CheckAccess();
                    m_redirectUrl_wrapped = value;
                    m_redirectUrl_changed = true;
                }
            }

            public override string ToString() {
                return String.Format("Response={{{0}}}, RedirectUrl={{{2}}}", Response, RedirectUrl);
            }
        }

        /// <summary>
        /// Read response data. If data is available immediately copy up to
        /// |BytesToRead| bytes into |DataOut|, set |BytesRead| to the number of
        /// bytes copied, and return true (1). To read the data at a later time set
        /// |BytesRead| to 0, return true (1) and call CfxCallback.Continue() when the
        /// data is available. To indicate response completion return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxReadResponseEventHandler(object sender, CfxReadResponseEventArgs e);

        /// <summary>
        /// Read response data. If data is available immediately copy up to
        /// |BytesToRead| bytes into |DataOut|, set |BytesRead| to the number of
        /// bytes copied, and return true (1). To read the data at a later time set
        /// |BytesRead| to 0, return true (1) and call CfxCallback.Continue() when the
        /// data is available. To indicate response completion return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public class CfxReadResponseEventArgs : CfxEventArgs {

            internal IntPtr m_data_out;
            internal int m_bytes_to_read;
            internal int m_bytes_read;
            internal IntPtr m_callback;
            internal CfxCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxReadResponseEventArgs(IntPtr data_out, int bytes_to_read, IntPtr callback) {
                m_data_out = data_out;
                m_bytes_to_read = bytes_to_read;
                m_callback = callback;
            }

            public IntPtr DataOut {
                get {
                    CheckAccess();
                    return m_data_out;
                }
            }
            public int BytesToRead {
                get {
                    CheckAccess();
                    return m_bytes_to_read;
                }
            }
            public int BytesRead {
                set {
                    CheckAccess();
                    m_bytes_read = value;
                }
            }
            public CfxCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            /// <summary>
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
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
                return String.Format("DataOut={{{0}}}, BytesToRead={{{1}}}, Callback={{{3}}}", DataOut, BytesToRead, Callback);
            }
        }

        /// <summary>
        /// Return true (1) if the specified cookie can be sent with the request or
        /// false (0) otherwise. If false (0) is returned for any cookie then no
        /// cookies will be sent with the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxCanGetCookieEventHandler(object sender, CfxCanGetCookieEventArgs e);

        /// <summary>
        /// Return true (1) if the specified cookie can be sent with the request or
        /// false (0) otherwise. If false (0) is returned for any cookie then no
        /// cookies will be sent with the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public class CfxCanGetCookieEventArgs : CfxEventArgs {

            internal IntPtr m_cookie;
            internal CfxCookie m_cookie_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxCanGetCookieEventArgs(IntPtr cookie) {
                m_cookie = cookie;
            }

            public CfxCookie Cookie {
                get {
                    CheckAccess();
                    if(m_cookie_wrapped == null) m_cookie_wrapped = CfxCookie.Wrap(m_cookie);
                    return m_cookie_wrapped;
                }
            }
            /// <summary>
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
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
                return String.Format("Cookie={{{0}}}", Cookie);
            }
        }

        /// <summary>
        /// Return true (1) if the specified cookie returned with the response can be
        /// set or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxCanSetCookieEventHandler(object sender, CfxCanSetCookieEventArgs e);

        /// <summary>
        /// Return true (1) if the specified cookie returned with the response can be
        /// set or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
        /// </remarks>
        public class CfxCanSetCookieEventArgs : CfxEventArgs {

            internal IntPtr m_cookie;
            internal CfxCookie m_cookie_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxCanSetCookieEventArgs(IntPtr cookie) {
                m_cookie = cookie;
            }

            public CfxCookie Cookie {
                get {
                    CheckAccess();
                    if(m_cookie_wrapped == null) m_cookie_wrapped = CfxCookie.Wrap(m_cookie);
                    return m_cookie_wrapped;
                }
            }
            /// <summary>
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_handler_capi.h">cef/include/capi/cef_resource_handler_capi.h</see>.
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
                return String.Format("Cookie={{{0}}}", Cookie);
            }
        }


    }
}
