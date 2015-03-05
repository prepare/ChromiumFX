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
    /// Structure that should be implemented by the CfxUrlRequest client. The
    /// functions of this structure will be called on the same thread that created
    /// the request unless otherwise documented.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
    /// </remarks>
    public class CfxUrlRequestClient : CfxBase {

        internal static CfxUrlRequestClient Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_urlrequest_client_get_gc_handle(nativePtr);
            return (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_request_complete(IntPtr gcHandlePtr, IntPtr request) {
            var self = (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnRequestCompleteEventArgs(request);
            var eventHandler = self.m_OnRequestComplete;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
        }

        internal static void on_upload_progress(IntPtr gcHandlePtr, IntPtr request, ulong current, ulong total) {
            var self = (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnUploadProgressEventArgs(request, current, total);
            var eventHandler = self.m_OnUploadProgress;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
        }

        internal static void on_download_progress(IntPtr gcHandlePtr, IntPtr request, ulong current, ulong total) {
            var self = (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnDownloadProgressEventArgs(request, current, total);
            var eventHandler = self.m_OnDownloadProgress;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
        }

        internal static void on_download_data(IntPtr gcHandlePtr, IntPtr request, IntPtr data, int data_length) {
            var self = (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnDownloadDataEventArgs(request, data, data_length);
            var eventHandler = self.m_OnDownloadData;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_request_wrapped == null) CfxApi.cfx_release(e.m_request);
        }

        internal static void get_auth_credentials(IntPtr gcHandlePtr, out int __retval, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback) {
            var self = (CfxUrlRequestClient)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxUrlRequestClientGetAuthCredentialsEventArgs(isProxy, host_str, host_length, port, realm_str, realm_length, scheme_str, scheme_length, callback);
            var eventHandler = self.m_GetAuthCredentials;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxUrlRequestClient(IntPtr nativePtr) : base(nativePtr) {}
        public CfxUrlRequestClient() : base(CfxApi.cfx_urlrequest_client_ctor) {}

        /// <summary>
        /// Notifies the client that the request has completed. Use the
        /// CfxUrlRequest.GetRequestStatus function to determine if the request was
        /// successful or not.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public event CfxOnRequestCompleteEventHandler OnRequestComplete {
            add {
                if(m_OnRequestComplete == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 0, 1);
                }
                m_OnRequestComplete += value;
            }
            remove {
                m_OnRequestComplete -= value;
                if(m_OnRequestComplete == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnRequestCompleteEventHandler m_OnRequestComplete;

        /// <summary>
        /// Notifies the client of upload progress. |Current| denotes the number of
        /// bytes sent so far and |Total| is the total size of uploading data (or -1 if
        /// chunked upload is enabled). This function will only be called if the
        /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public event CfxOnUploadProgressEventHandler OnUploadProgress {
            add {
                if(m_OnUploadProgress == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 1, 1);
                }
                m_OnUploadProgress += value;
            }
            remove {
                m_OnUploadProgress -= value;
                if(m_OnUploadProgress == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnUploadProgressEventHandler m_OnUploadProgress;

        /// <summary>
        /// Notifies the client of download progress. |Current| denotes the number of
        /// bytes received up to the call and |Total| is the expected total size of the
        /// response (or -1 if not determined).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public event CfxOnDownloadProgressEventHandler OnDownloadProgress {
            add {
                if(m_OnDownloadProgress == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 2, 1);
                }
                m_OnDownloadProgress += value;
            }
            remove {
                m_OnDownloadProgress -= value;
                if(m_OnDownloadProgress == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxOnDownloadProgressEventHandler m_OnDownloadProgress;

        /// <summary>
        /// Called when some part of the response is read. |Data| contains the current
        /// bytes received since the last call. This function will not be called if the
        /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public event CfxOnDownloadDataEventHandler OnDownloadData {
            add {
                if(m_OnDownloadData == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 3, 1);
                }
                m_OnDownloadData += value;
            }
            remove {
                m_OnDownloadData -= value;
                if(m_OnDownloadData == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxOnDownloadDataEventHandler m_OnDownloadData;

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request. This
        /// function will only be called for requests initiated from the browser
        /// process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public event CfxUrlRequestClientGetAuthCredentialsEventHandler GetAuthCredentials {
            add {
                if(m_GetAuthCredentials == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 4, 1);
                }
                m_GetAuthCredentials += value;
            }
            remove {
                m_GetAuthCredentials -= value;
                if(m_GetAuthCredentials == null) {
                    CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxUrlRequestClientGetAuthCredentialsEventHandler m_GetAuthCredentials;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnRequestComplete != null) {
                m_OnRequestComplete = null;
                CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnUploadProgress != null) {
                m_OnUploadProgress = null;
                CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 1, 0);
            }
            if(m_OnDownloadProgress != null) {
                m_OnDownloadProgress = null;
                CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 2, 0);
            }
            if(m_OnDownloadData != null) {
                m_OnDownloadData = null;
                CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 3, 0);
            }
            if(m_GetAuthCredentials != null) {
                m_GetAuthCredentials = null;
                CfxApi.cfx_urlrequest_client_activate_callback(NativePtr, 4, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Notifies the client that the request has completed. Use the
        /// CfxUrlRequest.GetRequestStatus function to determine if the request was
        /// successful or not.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnRequestCompleteEventHandler(object sender, CfxOnRequestCompleteEventArgs e);

        /// <summary>
        /// Notifies the client that the request has completed. Use the
        /// CfxUrlRequest.GetRequestStatus function to determine if the request was
        /// successful or not.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public class CfxOnRequestCompleteEventArgs : CfxEventArgs {

            internal IntPtr m_request;
            internal CfxUrlRequest m_request_wrapped;

            internal CfxOnRequestCompleteEventArgs(IntPtr request) {
                m_request = request;
            }

            public CfxUrlRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxUrlRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Request={{{0}}}", Request);
            }
        }

        /// <summary>
        /// Notifies the client of upload progress. |Current| denotes the number of
        /// bytes sent so far and |Total| is the total size of uploading data (or -1 if
        /// chunked upload is enabled). This function will only be called if the
        /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnUploadProgressEventHandler(object sender, CfxOnUploadProgressEventArgs e);

        /// <summary>
        /// Notifies the client of upload progress. |Current| denotes the number of
        /// bytes sent so far and |Total| is the total size of uploading data (or -1 if
        /// chunked upload is enabled). This function will only be called if the
        /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public class CfxOnUploadProgressEventArgs : CfxEventArgs {

            internal IntPtr m_request;
            internal CfxUrlRequest m_request_wrapped;
            internal ulong m_current;
            internal ulong m_total;

            internal CfxOnUploadProgressEventArgs(IntPtr request, ulong current, ulong total) {
                m_request = request;
                m_current = current;
                m_total = total;
            }

            public CfxUrlRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxUrlRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public ulong Current {
                get {
                    CheckAccess();
                    return m_current;
                }
            }
            public ulong Total {
                get {
                    CheckAccess();
                    return m_total;
                }
            }

            public override string ToString() {
                return String.Format("Request={{{0}}}, Current={{{1}}}, Total={{{2}}}", Request, Current, Total);
            }
        }

        /// <summary>
        /// Notifies the client of download progress. |Current| denotes the number of
        /// bytes received up to the call and |Total| is the expected total size of the
        /// response (or -1 if not determined).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnDownloadProgressEventHandler(object sender, CfxOnDownloadProgressEventArgs e);

        /// <summary>
        /// Notifies the client of download progress. |Current| denotes the number of
        /// bytes received up to the call and |Total| is the expected total size of the
        /// response (or -1 if not determined).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public class CfxOnDownloadProgressEventArgs : CfxEventArgs {

            internal IntPtr m_request;
            internal CfxUrlRequest m_request_wrapped;
            internal ulong m_current;
            internal ulong m_total;

            internal CfxOnDownloadProgressEventArgs(IntPtr request, ulong current, ulong total) {
                m_request = request;
                m_current = current;
                m_total = total;
            }

            public CfxUrlRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxUrlRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public ulong Current {
                get {
                    CheckAccess();
                    return m_current;
                }
            }
            public ulong Total {
                get {
                    CheckAccess();
                    return m_total;
                }
            }

            public override string ToString() {
                return String.Format("Request={{{0}}}, Current={{{1}}}, Total={{{2}}}", Request, Current, Total);
            }
        }

        /// <summary>
        /// Called when some part of the response is read. |Data| contains the current
        /// bytes received since the last call. This function will not be called if the
        /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnDownloadDataEventHandler(object sender, CfxOnDownloadDataEventArgs e);

        /// <summary>
        /// Called when some part of the response is read. |Data| contains the current
        /// bytes received since the last call. This function will not be called if the
        /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public class CfxOnDownloadDataEventArgs : CfxEventArgs {

            internal IntPtr m_request;
            internal CfxUrlRequest m_request_wrapped;
            internal IntPtr m_data;
            internal int m_data_length;

            internal CfxOnDownloadDataEventArgs(IntPtr request, IntPtr data, int data_length) {
                m_request = request;
                m_data = data;
                m_data_length = data_length;
            }

            public CfxUrlRequest Request {
                get {
                    CheckAccess();
                    if(m_request_wrapped == null) m_request_wrapped = CfxUrlRequest.Wrap(m_request);
                    return m_request_wrapped;
                }
            }
            public IntPtr Data {
                get {
                    CheckAccess();
                    return m_data;
                }
            }
            public int DataLength {
                get {
                    CheckAccess();
                    return m_data_length;
                }
            }

            public override string ToString() {
                return String.Format("Request={{{0}}}, Data={{{1}}}, DataLength={{{2}}}", Request, Data, DataLength);
            }
        }

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request. This
        /// function will only be called for requests initiated from the browser
        /// process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public delegate void CfxUrlRequestClientGetAuthCredentialsEventHandler(object sender, CfxUrlRequestClientGetAuthCredentialsEventArgs e);

        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |IsProxy| indicates whether the host is a proxy server. |Host| contains the
        /// hostname and |Port| contains the port number. Return true (1) to continue
        /// the request and call CfxAuthCallback.Continue() when the authentication
        /// information is available. Return false (0) to cancel the request. This
        /// function will only be called for requests initiated from the browser
        /// process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
        /// </remarks>
        public class CfxUrlRequestClientGetAuthCredentialsEventArgs : CfxEventArgs {

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

            internal CfxUrlRequestClientGetAuthCredentialsEventArgs(int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback) {
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
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_urlrequest_capi.h">cef/include/capi/cef_urlrequest_capi.h</see>.
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
                return String.Format("IsProxy={{{0}}}, Host={{{1}}}, Port={{{2}}}, Realm={{{3}}}, Scheme={{{4}}}, Callback={{{5}}}", IsProxy, Host, Port, Realm, Scheme, Callback);
            }
        }

    }
}
