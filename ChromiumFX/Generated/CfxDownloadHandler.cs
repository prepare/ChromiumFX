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
    /// Structure used to handle file downloads. The functions of this structure will
    /// called on the browser process UI thread.
    /// </summary>
    public class CfxDownloadHandler : CfxBase {

        internal static CfxDownloadHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_download_handler_get_gc_handle(nativePtr);
            return (CfxDownloadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_before_download(IntPtr gcHandlePtr, IntPtr browser, IntPtr download_item, IntPtr suggested_name_str, int suggested_name_length, IntPtr callback) {
            var self = (CfxDownloadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnBeforeDownloadEventArgs(browser, download_item, suggested_name_str, suggested_name_length, callback);
            var eventHandler = self.m_OnBeforeDownload;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_download_item_wrapped == null) {
                CfxApi.cfx_release(e.m_download_item);
            } else {
                e.m_download_item_wrapped.Dispose();
            }
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
        }

        internal static void on_download_updated(IntPtr gcHandlePtr, IntPtr browser, IntPtr download_item, IntPtr callback) {
            var self = (CfxDownloadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnDownloadUpdatedEventArgs(browser, download_item, callback);
            var eventHandler = self.m_OnDownloadUpdated;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_download_item_wrapped == null) {
                CfxApi.cfx_release(e.m_download_item);
            } else {
                e.m_download_item_wrapped.Dispose();
            }
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
        }

        internal CfxDownloadHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDownloadHandler() : base(CfxApi.cfx_download_handler_ctor) {}

        /// <summary>
        /// Called before a download begins. |SuggestedName| is the suggested name for
        /// the download file. By default the download will be canceled. Execute
        /// |Callback| either asynchronously or in this function to continue the
        /// download if desired. Do not keep a reference to |DownloadItem| outside of
        /// this function.
        /// </summary>
        public event CfxOnBeforeDownloadEventHandler OnBeforeDownload {
            add {
                if(m_OnBeforeDownload == null) {
                    CfxApi.cfx_download_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnBeforeDownload += value;
            }
            remove {
                m_OnBeforeDownload -= value;
                if(m_OnBeforeDownload == null) {
                    CfxApi.cfx_download_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnBeforeDownloadEventHandler m_OnBeforeDownload;

        /// <summary>
        /// Called when a download's status or progress information has been updated.
        /// This may be called multiple times before and after on_before_download().
        /// Execute |Callback| either asynchronously or in this function to cancel the
        /// download if desired. Do not keep a reference to |DownloadItem| outside of
        /// this function.
        /// </summary>
        public event CfxOnDownloadUpdatedEventHandler OnDownloadUpdated {
            add {
                if(m_OnDownloadUpdated == null) {
                    CfxApi.cfx_download_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnDownloadUpdated += value;
            }
            remove {
                m_OnDownloadUpdated -= value;
                if(m_OnDownloadUpdated == null) {
                    CfxApi.cfx_download_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnDownloadUpdatedEventHandler m_OnDownloadUpdated;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforeDownload != null) {
                m_OnBeforeDownload = null;
                CfxApi.cfx_download_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnDownloadUpdated != null) {
                m_OnDownloadUpdated = null;
                CfxApi.cfx_download_handler_activate_callback(NativePtr, 1, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxOnBeforeDownloadEventHandler(object sender, CfxOnBeforeDownloadEventArgs e);

        /// <summary>
        /// Called before a download begins. |SuggestedName| is the suggested name for
        /// the download file. By default the download will be canceled. Execute
        /// |Callback| either asynchronously or in this function to continue the
        /// download if desired. Do not keep a reference to |DownloadItem| outside of
        /// this function.
        /// </summary>
        public class CfxOnBeforeDownloadEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_download_item;
            internal CfxDownloadItem m_download_item_wrapped;
            internal IntPtr m_suggested_name_str;
            internal int m_suggested_name_length;
            internal string m_suggested_name;
            internal IntPtr m_callback;
            internal CfxBeforeDownloadCallback m_callback_wrapped;

            internal CfxOnBeforeDownloadEventArgs(IntPtr browser, IntPtr download_item, IntPtr suggested_name_str, int suggested_name_length, IntPtr callback) {
                m_browser = browser;
                m_download_item = download_item;
                m_suggested_name_str = suggested_name_str;
                m_suggested_name_length = suggested_name_length;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxDownloadItem DownloadItem {
                get {
                    CheckAccess();
                    if(m_download_item_wrapped == null) m_download_item_wrapped = CfxDownloadItem.Wrap(m_download_item);
                    return m_download_item_wrapped;
                }
            }
            public string SuggestedName {
                get {
                    CheckAccess();
                    if(m_suggested_name == null && m_suggested_name_str != IntPtr.Zero) m_suggested_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_suggested_name_str, m_suggested_name_length);
                    return m_suggested_name;
                }
            }
            public CfxBeforeDownloadCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxBeforeDownloadCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, DownloadItem={{{1}}}, SuggestedName={{{2}}}, Callback={{{3}}}", Browser, DownloadItem, SuggestedName, Callback);
            }
        }

        public delegate void CfxOnDownloadUpdatedEventHandler(object sender, CfxOnDownloadUpdatedEventArgs e);

        /// <summary>
        /// Called when a download's status or progress information has been updated.
        /// This may be called multiple times before and after on_before_download().
        /// Execute |Callback| either asynchronously or in this function to cancel the
        /// download if desired. Do not keep a reference to |DownloadItem| outside of
        /// this function.
        /// </summary>
        public class CfxOnDownloadUpdatedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_download_item;
            internal CfxDownloadItem m_download_item_wrapped;
            internal IntPtr m_callback;
            internal CfxDownloadItemCallback m_callback_wrapped;

            internal CfxOnDownloadUpdatedEventArgs(IntPtr browser, IntPtr download_item, IntPtr callback) {
                m_browser = browser;
                m_download_item = download_item;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxDownloadItem DownloadItem {
                get {
                    CheckAccess();
                    if(m_download_item_wrapped == null) m_download_item_wrapped = CfxDownloadItem.Wrap(m_download_item);
                    return m_download_item_wrapped;
                }
            }
            public CfxDownloadItemCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxDownloadItemCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, DownloadItem={{{1}}}, Callback={{{2}}}", Browser, DownloadItem, Callback);
            }
        }

    }
}
