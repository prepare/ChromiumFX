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
    /// Callback structure for CfxBrowserHost.DownloadImage. The functions of
    /// this structure will be called on the browser process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
    /// </remarks>
    public class CfxDownloadImageCallback : CfxClientBase {

        internal static CfxDownloadImageCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.DownloadImageCallback.cfx_download_image_callback_get_gc_handle(nativePtr);
            return (CfxDownloadImageCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            on_download_image_finished_native = on_download_image_finished;

            on_download_image_finished_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_download_image_finished_native);
        }

        // on_download_image_finished
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_download_image_finished_delegate(IntPtr gcHandlePtr, IntPtr image_url_str, int image_url_length, int http_status_code, IntPtr image);
        private static on_download_image_finished_delegate on_download_image_finished_native;
        private static IntPtr on_download_image_finished_native_ptr;

        internal static void on_download_image_finished(IntPtr gcHandlePtr, IntPtr image_url_str, int image_url_length, int http_status_code, IntPtr image) {
            var self = (CfxDownloadImageCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxDownloadImageCallbackOnDownloadImageFinishedEventArgs(image_url_str, image_url_length, http_status_code, image);
            self.m_OnDownloadImageFinished?.Invoke(self, e);
            e.m_isInvalid = true;
            if(e.m_image_wrapped == null) CfxApi.cfx_release(e.m_image);
        }

        internal CfxDownloadImageCallback(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDownloadImageCallback() : base(CfxApi.DownloadImageCallback.cfx_download_image_callback_ctor) {}

        /// <summary>
        /// Method that will be executed when the image download has completed.
        /// |ImageUrl| is the URL that was downloaded and |HttpStatusCode| is the
        /// resulting HTTP status code. |Image| is the resulting image, possibly at
        /// multiple scale factors, or NULL if the download failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public event CfxDownloadImageCallbackOnDownloadImageFinishedEventHandler OnDownloadImageFinished {
            add {
                lock(eventLock) {
                    if(m_OnDownloadImageFinished == null) {
                        CfxApi.DownloadImageCallback.cfx_download_image_callback_set_callback(NativePtr, 0, on_download_image_finished_native_ptr);
                    }
                    m_OnDownloadImageFinished += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnDownloadImageFinished -= value;
                    if(m_OnDownloadImageFinished == null) {
                        CfxApi.DownloadImageCallback.cfx_download_image_callback_set_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxDownloadImageCallbackOnDownloadImageFinishedEventHandler m_OnDownloadImageFinished;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnDownloadImageFinished != null) {
                m_OnDownloadImageFinished = null;
                CfxApi.DownloadImageCallback.cfx_download_image_callback_set_callback(NativePtr, 0, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Method that will be executed when the image download has completed.
        /// |ImageUrl| is the URL that was downloaded and |HttpStatusCode| is the
        /// resulting HTTP status code. |Image| is the resulting image, possibly at
        /// multiple scale factors, or NULL if the download failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public delegate void CfxDownloadImageCallbackOnDownloadImageFinishedEventHandler(object sender, CfxDownloadImageCallbackOnDownloadImageFinishedEventArgs e);

        /// <summary>
        /// Method that will be executed when the image download has completed.
        /// |ImageUrl| is the URL that was downloaded and |HttpStatusCode| is the
        /// resulting HTTP status code. |Image| is the resulting image, possibly at
        /// multiple scale factors, or NULL if the download failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public class CfxDownloadImageCallbackOnDownloadImageFinishedEventArgs : CfxEventArgs {

            internal IntPtr m_image_url_str;
            internal int m_image_url_length;
            internal string m_image_url;
            internal int m_http_status_code;
            internal IntPtr m_image;
            internal CfxImage m_image_wrapped;

            internal CfxDownloadImageCallbackOnDownloadImageFinishedEventArgs(IntPtr image_url_str, int image_url_length, int http_status_code, IntPtr image) {
                m_image_url_str = image_url_str;
                m_image_url_length = image_url_length;
                m_http_status_code = http_status_code;
                m_image = image;
            }

            /// <summary>
            /// Get the ImageUrl parameter for the <see cref="CfxDownloadImageCallback.OnDownloadImageFinished"/> callback.
            /// </summary>
            public string ImageUrl {
                get {
                    CheckAccess();
                    m_image_url = StringFunctions.PtrToStringUni(m_image_url_str, m_image_url_length);
                    return m_image_url;
                }
            }
            /// <summary>
            /// Get the HttpStatusCode parameter for the <see cref="CfxDownloadImageCallback.OnDownloadImageFinished"/> callback.
            /// </summary>
            public int HttpStatusCode {
                get {
                    CheckAccess();
                    return m_http_status_code;
                }
            }
            /// <summary>
            /// Get the Image parameter for the <see cref="CfxDownloadImageCallback.OnDownloadImageFinished"/> callback.
            /// </summary>
            public CfxImage Image {
                get {
                    CheckAccess();
                    if(m_image_wrapped == null) m_image_wrapped = CfxImage.Wrap(m_image);
                    return m_image_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("ImageUrl={{{0}}}, HttpStatusCode={{{1}}}, Image={{{2}}}", ImageUrl, HttpStatusCode, Image);
            }
        }

    }
}
