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
    /// Implement this structure to handle events related to JavaScript dialogs. The
    /// functions of this structure will be called on the UI thread.
    /// </summary>
    public class CfxJsDialogHandler : CfxBase {

        internal static CfxJsDialogHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_jsdialog_handler_get_gc_handle(nativePtr);
            return (CfxJsDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_jsdialog(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr origin_url_str, int origin_url_length, IntPtr accept_lang_str, int accept_lang_length, CfxJsDialogType dialog_type, IntPtr message_text_str, int message_text_length, IntPtr default_prompt_text_str, int default_prompt_text_length, IntPtr callback, out int suppress_message) {
            var self = (CfxJsDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                suppress_message = default(int);
                return;
            }
            var e = new CfxOnJsDialogEventArgs(browser, origin_url_str, origin_url_length, accept_lang_str, accept_lang_length, dialog_type, message_text_str, message_text_length, default_prompt_text_str, default_prompt_text_length, callback);
            var eventHandler = self.m_OnJsDialog;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            suppress_message = e.m_suppress_message;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_before_unload_dialog(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr message_text_str, int message_text_length, int is_reload, IntPtr callback) {
            var self = (CfxJsDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnBeforeUnloadDialogEventArgs(browser, message_text_str, message_text_length, is_reload, callback);
            var eventHandler = self.m_OnBeforeUnloadDialog;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_reset_dialog_state(IntPtr gcHandlePtr, IntPtr browser) {
            var self = (CfxJsDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnResetDialogStateEventArgs(browser);
            var eventHandler = self.m_OnResetDialogState;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_dialog_closed(IntPtr gcHandlePtr, IntPtr browser) {
            var self = (CfxJsDialogHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnDialogClosedEventArgs(browser);
            var eventHandler = self.m_OnDialogClosed;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal CfxJsDialogHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxJsDialogHandler() : base(CfxApi.cfx_jsdialog_handler_ctor) {}

        /// <summary>
        /// Called to run a JavaScript dialog. The |DefaultPromptText| value will be
        /// specified for prompt dialogs only. Set |SuppressMessage| to true (1) and
        /// return false (0) to suppress the message (suppressing messages is
        /// preferable to immediately executing the callback as this is used to detect
        /// presumably malicious behavior like spamming alert messages in
        /// onbeforeunload). Set |SuppressMessage| to false (0) and return false (0)
        /// to use the default implementation (the default implementation will show one
        /// modal dialog at a time and suppress any additional dialog requests until
        /// the displayed dialog is dismissed). Return true (1) if the application will
        /// use a custom dialog or if the callback has been executed immediately.
        /// Custom dialogs may be either modal or modeless. If a custom dialog is used
        /// the application must execute |Callback| once the custom dialog is
        /// dismissed.
        /// </summary>
        public event CfxOnJsDialogEventHandler OnJsDialog {
            add {
                if(m_OnJsDialog == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnJsDialog += value;
            }
            remove {
                m_OnJsDialog -= value;
                if(m_OnJsDialog == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnJsDialogEventHandler m_OnJsDialog;

        /// <summary>
        /// Called to run a dialog asking the user if they want to leave a page. Return
        /// false (0) to use the default dialog implementation. Return true (1) if the
        /// application will use a custom dialog or if the callback has been executed
        /// immediately. Custom dialogs may be either modal or modeless. If a custom
        /// dialog is used the application must execute |Callback| once the custom
        /// dialog is dismissed.
        /// </summary>
        public event CfxOnBeforeUnloadDialogEventHandler OnBeforeUnloadDialog {
            add {
                if(m_OnBeforeUnloadDialog == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnBeforeUnloadDialog += value;
            }
            remove {
                m_OnBeforeUnloadDialog -= value;
                if(m_OnBeforeUnloadDialog == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnBeforeUnloadDialogEventHandler m_OnBeforeUnloadDialog;

        /// <summary>
        /// Called to cancel any pending dialogs and reset any saved dialog state. Will
        /// be called due to events like page navigation irregardless of whether any
        /// dialogs are currently pending.
        /// </summary>
        public event CfxOnResetDialogStateEventHandler OnResetDialogState {
            add {
                if(m_OnResetDialogState == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 2, 1);
                }
                m_OnResetDialogState += value;
            }
            remove {
                m_OnResetDialogState -= value;
                if(m_OnResetDialogState == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxOnResetDialogStateEventHandler m_OnResetDialogState;

        /// <summary>
        /// Called when the default implementation dialog is closed.
        /// </summary>
        public event CfxOnDialogClosedEventHandler OnDialogClosed {
            add {
                if(m_OnDialogClosed == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 3, 1);
                }
                m_OnDialogClosed += value;
            }
            remove {
                m_OnDialogClosed -= value;
                if(m_OnDialogClosed == null) {
                    CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxOnDialogClosedEventHandler m_OnDialogClosed;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnJsDialog != null) {
                m_OnJsDialog = null;
                CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnBeforeUnloadDialog != null) {
                m_OnBeforeUnloadDialog = null;
                CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_OnResetDialogState != null) {
                m_OnResetDialogState = null;
                CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_OnDialogClosed != null) {
                m_OnDialogClosed = null;
                CfxApi.cfx_jsdialog_handler_activate_callback(NativePtr, 3, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxOnJsDialogEventHandler(object sender, CfxOnJsDialogEventArgs e);

        /// <summary>
        /// Called to run a JavaScript dialog. The |DefaultPromptText| value will be
        /// specified for prompt dialogs only. Set |SuppressMessage| to true (1) and
        /// return false (0) to suppress the message (suppressing messages is
        /// preferable to immediately executing the callback as this is used to detect
        /// presumably malicious behavior like spamming alert messages in
        /// onbeforeunload). Set |SuppressMessage| to false (0) and return false (0)
        /// to use the default implementation (the default implementation will show one
        /// modal dialog at a time and suppress any additional dialog requests until
        /// the displayed dialog is dismissed). Return true (1) if the application will
        /// use a custom dialog or if the callback has been executed immediately.
        /// Custom dialogs may be either modal or modeless. If a custom dialog is used
        /// the application must execute |Callback| once the custom dialog is
        /// dismissed.
        /// </summary>
        public class CfxOnJsDialogEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_origin_url_str;
            internal int m_origin_url_length;
            internal string m_origin_url;
            internal IntPtr m_accept_lang_str;
            internal int m_accept_lang_length;
            internal string m_accept_lang;
            internal CfxJsDialogType m_dialog_type;
            internal IntPtr m_message_text_str;
            internal int m_message_text_length;
            internal string m_message_text;
            internal IntPtr m_default_prompt_text_str;
            internal int m_default_prompt_text_length;
            internal string m_default_prompt_text;
            internal IntPtr m_callback;
            internal CfxJsDialogCallback m_callback_wrapped;
            internal int m_suppress_message;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnJsDialogEventArgs(IntPtr browser, IntPtr origin_url_str, int origin_url_length, IntPtr accept_lang_str, int accept_lang_length, CfxJsDialogType dialog_type, IntPtr message_text_str, int message_text_length, IntPtr default_prompt_text_str, int default_prompt_text_length, IntPtr callback) {
                m_browser = browser;
                m_origin_url_str = origin_url_str;
                m_origin_url_length = origin_url_length;
                m_accept_lang_str = accept_lang_str;
                m_accept_lang_length = accept_lang_length;
                m_dialog_type = dialog_type;
                m_message_text_str = message_text_str;
                m_message_text_length = message_text_length;
                m_default_prompt_text_str = default_prompt_text_str;
                m_default_prompt_text_length = default_prompt_text_length;
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
            public string AcceptLang {
                get {
                    CheckAccess();
                    if(m_accept_lang == null && m_accept_lang_str != IntPtr.Zero) m_accept_lang = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_accept_lang_str, m_accept_lang_length);
                    return m_accept_lang;
                }
            }
            public CfxJsDialogType DialogType {
                get {
                    CheckAccess();
                    return m_dialog_type;
                }
            }
            public string MessageText {
                get {
                    CheckAccess();
                    if(m_message_text == null && m_message_text_str != IntPtr.Zero) m_message_text = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_message_text_str, m_message_text_length);
                    return m_message_text;
                }
            }
            public string DefaultPromptText {
                get {
                    CheckAccess();
                    if(m_default_prompt_text == null && m_default_prompt_text_str != IntPtr.Zero) m_default_prompt_text = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_default_prompt_text_str, m_default_prompt_text_length);
                    return m_default_prompt_text;
                }
            }
            public CfxJsDialogCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxJsDialogCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            public bool SuppressMessage {
                set {
                    CheckAccess();
                    m_suppress_message = value ? 1 : 0;
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
                return String.Format("Browser={{{0}}}, OriginUrl={{{1}}}, AcceptLang={{{2}}}, DialogType={{{3}}}, MessageText={{{4}}}, DefaultPromptText={{{5}}}, Callback={{{6}}}", Browser, OriginUrl, AcceptLang, DialogType, MessageText, DefaultPromptText, Callback);
            }
        }

        public delegate void CfxOnBeforeUnloadDialogEventHandler(object sender, CfxOnBeforeUnloadDialogEventArgs e);

        /// <summary>
        /// Called to run a dialog asking the user if they want to leave a page. Return
        /// false (0) to use the default dialog implementation. Return true (1) if the
        /// application will use a custom dialog or if the callback has been executed
        /// immediately. Custom dialogs may be either modal or modeless. If a custom
        /// dialog is used the application must execute |Callback| once the custom
        /// dialog is dismissed.
        /// </summary>
        public class CfxOnBeforeUnloadDialogEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_message_text_str;
            internal int m_message_text_length;
            internal string m_message_text;
            internal int m_is_reload;
            internal IntPtr m_callback;
            internal CfxJsDialogCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnBeforeUnloadDialogEventArgs(IntPtr browser, IntPtr message_text_str, int message_text_length, int is_reload, IntPtr callback) {
                m_browser = browser;
                m_message_text_str = message_text_str;
                m_message_text_length = message_text_length;
                m_is_reload = is_reload;
                m_callback = callback;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public string MessageText {
                get {
                    CheckAccess();
                    if(m_message_text == null && m_message_text_str != IntPtr.Zero) m_message_text = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_message_text_str, m_message_text_length);
                    return m_message_text;
                }
            }
            public bool IsReload {
                get {
                    CheckAccess();
                    return 0 != m_is_reload;
                }
            }
            public CfxJsDialogCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxJsDialogCallback.Wrap(m_callback);
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
                return String.Format("Browser={{{0}}}, MessageText={{{1}}}, IsReload={{{2}}}, Callback={{{3}}}", Browser, MessageText, IsReload, Callback);
            }
        }

        public delegate void CfxOnResetDialogStateEventHandler(object sender, CfxOnResetDialogStateEventArgs e);

        /// <summary>
        /// Called to cancel any pending dialogs and reset any saved dialog state. Will
        /// be called due to events like page navigation irregardless of whether any
        /// dialogs are currently pending.
        /// </summary>
        public class CfxOnResetDialogStateEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal CfxOnResetDialogStateEventArgs(IntPtr browser) {
                m_browser = browser;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

        public delegate void CfxOnDialogClosedEventHandler(object sender, CfxOnDialogClosedEventArgs e);

        /// <summary>
        /// Called when the default implementation dialog is closed.
        /// </summary>
        public class CfxOnDialogClosedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal CfxOnDialogClosedEventArgs(IntPtr browser) {
                m_browser = browser;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

    }
}
