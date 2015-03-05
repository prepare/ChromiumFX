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
    /// Implement this structure to handle dialog events. The functions of this
    /// structure will be called on the browser process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
    /// </remarks>
    public class CfxDialogHandler : CfxBase {

        internal static CfxDialogHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_dialog_handler_get_gc_handle(nativePtr);
            return (CfxDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_file_dialog(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxFileDialogMode mode, IntPtr title_str, int title_length, IntPtr default_file_name_str, int default_file_name_length, IntPtr accept_types, IntPtr callback) {
            var self = (CfxDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxDialogHandlerOnFileDialogEventArgs(browser, mode, title_str, title_length, default_file_name_str, default_file_name_length, accept_types, callback);
            var eventHandler = self.m_OnFileDialog;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxDialogHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDialogHandler() : base(CfxApi.cfx_dialog_handler_ctor) {}

        /// <summary>
        /// Called to run a file chooser dialog. |Mode| represents the type of dialog
        /// to display. |Title| to the title to be used for the dialog and may be NULL
        /// to show the default title ("Open" or "Save" depending on the mode).
        /// |DefaultFileName| is the default file name to select in the dialog.
        /// |AcceptTypes| is a list of valid lower-cased MIME types or file extensions
        /// specified in an input element and is used to restrict selectable files to
        /// such types. To display a custom dialog return true (1) and execute
        /// |Callback| either inline or at a later time. To display the default dialog
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
        /// </remarks>
        public event CfxDialogHandlerOnFileDialogEventHandler OnFileDialog {
            add {
                if(m_OnFileDialog == null) {
                    CfxApi.cfx_dialog_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnFileDialog += value;
            }
            remove {
                m_OnFileDialog -= value;
                if(m_OnFileDialog == null) {
                    CfxApi.cfx_dialog_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxDialogHandlerOnFileDialogEventHandler m_OnFileDialog;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnFileDialog != null) {
                m_OnFileDialog = null;
                CfxApi.cfx_dialog_handler_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called to run a file chooser dialog. |Mode| represents the type of dialog
        /// to display. |Title| to the title to be used for the dialog and may be NULL
        /// to show the default title ("Open" or "Save" depending on the mode).
        /// |DefaultFileName| is the default file name to select in the dialog.
        /// |AcceptTypes| is a list of valid lower-cased MIME types or file extensions
        /// specified in an input element and is used to restrict selectable files to
        /// such types. To display a custom dialog return true (1) and execute
        /// |Callback| either inline or at a later time. To display the default dialog
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxDialogHandlerOnFileDialogEventHandler(object sender, CfxDialogHandlerOnFileDialogEventArgs e);

        /// <summary>
        /// Called to run a file chooser dialog. |Mode| represents the type of dialog
        /// to display. |Title| to the title to be used for the dialog and may be NULL
        /// to show the default title ("Open" or "Save" depending on the mode).
        /// |DefaultFileName| is the default file name to select in the dialog.
        /// |AcceptTypes| is a list of valid lower-cased MIME types or file extensions
        /// specified in an input element and is used to restrict selectable files to
        /// such types. To display a custom dialog return true (1) and execute
        /// |Callback| either inline or at a later time. To display the default dialog
        /// return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
        /// </remarks>
        public class CfxDialogHandlerOnFileDialogEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal CfxFileDialogMode m_mode;
            internal IntPtr m_title_str;
            internal int m_title_length;
            internal string m_title;
            internal IntPtr m_default_file_name_str;
            internal int m_default_file_name_length;
            internal string m_default_file_name;
            internal IntPtr m_accept_types;
            internal IntPtr m_callback;
            internal CfxFileDialogCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxDialogHandlerOnFileDialogEventArgs(IntPtr browser, CfxFileDialogMode mode, IntPtr title_str, int title_length, IntPtr default_file_name_str, int default_file_name_length, IntPtr accept_types, IntPtr callback) {
                m_browser = browser;
                m_mode = mode;
                m_title_str = title_str;
                m_title_length = title_length;
                m_default_file_name_str = default_file_name_str;
                m_default_file_name_length = default_file_name_length;
                m_accept_types = accept_types;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxFileDialogMode Mode {
                get {
                    CheckAccess();
                    return m_mode;
                }
            }
            public string Title {
                get {
                    CheckAccess();
                    if(m_title == null && m_title_str != IntPtr.Zero) m_title = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_title_str, m_title_length);
                    return m_title;
                }
            }
            public string DefaultFileName {
                get {
                    CheckAccess();
                    if(m_default_file_name == null && m_default_file_name_str != IntPtr.Zero) m_default_file_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_default_file_name_str, m_default_file_name_length);
                    return m_default_file_name;
                }
            }
            public System.Collections.Generic.List<string> AcceptTypes {
                get {
                    CheckAccess();
                    return CfxStringCollections.WrapCfxStringList(m_accept_types);
                }
            }
            public CfxFileDialogCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxFileDialogCallback.Wrap(m_callback);
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Mode={{{1}}}, Title={{{2}}}, DefaultFileName={{{3}}}, AcceptTypes={{{4}}}, Callback={{{5}}}", Browser, Mode, Title, DefaultFileName, AcceptTypes, Callback);
            }
        }

    }
}
