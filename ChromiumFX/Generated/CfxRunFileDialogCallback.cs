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
    /// Callback structure for CfxBrowserHost.RunFileDialog. The functions of
    /// this structure will be called on the browser process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
    /// </remarks>
    public class CfxRunFileDialogCallback : CfxBase {

        internal static CfxRunFileDialogCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_run_file_dialog_callback_get_gc_handle(nativePtr);
            return (CfxRunFileDialogCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        // cont
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_run_file_dialog_callback_cont_delegate(IntPtr gcHandlePtr, IntPtr browser_host, IntPtr file_paths);
        private static cfx_run_file_dialog_callback_cont_delegate cfx_run_file_dialog_callback_cont;
        private static IntPtr cfx_run_file_dialog_callback_cont_ptr;

        internal static void cont(IntPtr gcHandlePtr, IntPtr browser_host, IntPtr file_paths) {
            var self = (CfxRunFileDialogCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxRunFileDialogCallbackContinueEventArgs(browser_host, file_paths);
            var eventHandler = self.m_Continue;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_host_wrapped == null) CfxApi.cfx_release(e.m_browser_host);
        }

        internal CfxRunFileDialogCallback(IntPtr nativePtr) : base(nativePtr) {}
        public CfxRunFileDialogCallback() : base(CfxApi.cfx_run_file_dialog_callback_ctor) {}

        /// <summary>
        /// Called asynchronously after the file dialog is dismissed. If the selection
        /// was successful |FilePaths| will be a single value or a list of values
        /// depending on the dialog mode. If the selection was cancelled |FilePaths|
        /// will be NULL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public event CfxRunFileDialogCallbackContinueEventHandler Continue {
            add {
                lock(eventLock) {
                    if(m_Continue == null) {
                        if(cfx_run_file_dialog_callback_cont == null) {
                            cfx_run_file_dialog_callback_cont = cont;
                            cfx_run_file_dialog_callback_cont_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_run_file_dialog_callback_cont);
                        }
                        CfxApi.cfx_run_file_dialog_callback_set_managed_callback(NativePtr, 0, cfx_run_file_dialog_callback_cont_ptr);
                    }
                    m_Continue += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_Continue -= value;
                    if(m_Continue == null) {
                        CfxApi.cfx_run_file_dialog_callback_set_managed_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxRunFileDialogCallbackContinueEventHandler m_Continue;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Continue != null) {
                m_Continue = null;
                CfxApi.cfx_run_file_dialog_callback_set_managed_callback(NativePtr, 0, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called asynchronously after the file dialog is dismissed. If the selection
        /// was successful |FilePaths| will be a single value or a list of values
        /// depending on the dialog mode. If the selection was cancelled |FilePaths|
        /// will be NULL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public delegate void CfxRunFileDialogCallbackContinueEventHandler(object sender, CfxRunFileDialogCallbackContinueEventArgs e);

        /// <summary>
        /// Called asynchronously after the file dialog is dismissed. If the selection
        /// was successful |FilePaths| will be a single value or a list of values
        /// depending on the dialog mode. If the selection was cancelled |FilePaths|
        /// will be NULL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public class CfxRunFileDialogCallbackContinueEventArgs : CfxEventArgs {

            internal IntPtr m_browser_host;
            internal CfxBrowserHost m_browser_host_wrapped;
            internal IntPtr m_file_paths;

            internal CfxRunFileDialogCallbackContinueEventArgs(IntPtr browser_host, IntPtr file_paths) {
                m_browser_host = browser_host;
                m_file_paths = file_paths;
            }

            public CfxBrowserHost BrowserHost {
                get {
                    CheckAccess();
                    if(m_browser_host_wrapped == null) m_browser_host_wrapped = CfxBrowserHost.Wrap(m_browser_host);
                    return m_browser_host_wrapped;
                }
            }
            public System.Collections.Generic.List<string> FilePaths {
                get {
                    CheckAccess();
                    return CfxStringCollections.WrapCfxStringList(m_file_paths);
                }
            }

            public override string ToString() {
                return String.Format("BrowserHost={{{0}}}, FilePaths={{{1}}}", BrowserHost, FilePaths);
            }
        }

    }
}
