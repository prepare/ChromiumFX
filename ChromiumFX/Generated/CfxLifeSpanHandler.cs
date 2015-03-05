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
    /// Implement this structure to handle events related to browser life span. The
    /// functions of this structure will be called on the UI thread unless otherwise
    /// indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
    /// </remarks>
    public class CfxLifeSpanHandler : CfxBase {

        internal static CfxLifeSpanHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_life_span_handler_get_gc_handle(nativePtr);
            return (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_before_popup(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr target_url_str, int target_url_length, IntPtr target_frame_name_str, int target_frame_name_length, IntPtr popupFeatures, IntPtr windowInfo, out IntPtr client, IntPtr settings, out int no_javascript_access) {
            var self = (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                client = default(IntPtr);
                no_javascript_access = default(int);
                return;
            }
            var e = new CfxOnBeforePopupEventArgs(browser, frame, target_url_str, target_url_length, target_frame_name_str, target_frame_name_length, popupFeatures, windowInfo, settings);
            var eventHandler = self.m_OnBeforePopup;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            client = CfxClient.Unwrap(e.m_client_wrapped);
            no_javascript_access = e.m_no_javascript_access;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_after_created(IntPtr gcHandlePtr, IntPtr browser) {
            var self = (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnAfterCreatedEventArgs(browser);
            var eventHandler = self.m_OnAfterCreated;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void run_modal(IntPtr gcHandlePtr, out int __retval, IntPtr browser) {
            var self = (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxRunModalEventArgs(browser);
            var eventHandler = self.m_RunModal;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void do_close(IntPtr gcHandlePtr, out int __retval, IntPtr browser) {
            var self = (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxDoCloseEventArgs(browser);
            var eventHandler = self.m_DoClose;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_before_close(IntPtr gcHandlePtr, IntPtr browser) {
            var self = (CfxLifeSpanHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnBeforeCloseEventArgs(browser);
            var eventHandler = self.m_OnBeforeClose;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal CfxLifeSpanHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxLifeSpanHandler() : base(CfxApi.cfx_life_span_handler_ctor) {}

        /// <summary>
        /// Called on the IO thread before a new popup window is created. The |Browser|
        /// and |Frame| parameters represent the source of the popup request. The
        /// |TargetUrl| and |TargetFrameName| values may be NULL if none were
        /// specified with the request. The |PopupFeatures| structure contains
        /// information about the requested popup window. To allow creation of the
        /// popup window optionally modify |WindowInfo|, |Client|, |Settings| and
        /// |NoJavascriptAccess| and return false (0). To cancel creation of the
        /// popup window return true (1). The |Client| and |Settings| values will
        /// default to the source browser's values. The |NoJavascriptAccess| value
        /// indicates whether the new browser window should be scriptable and in the
        /// same process as the source browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforePopupEventHandler OnBeforePopup {
            add {
                if(m_OnBeforePopup == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnBeforePopup += value;
            }
            remove {
                m_OnBeforePopup -= value;
                if(m_OnBeforePopup == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnBeforePopupEventHandler m_OnBeforePopup;

        /// <summary>
        /// Called after a new browser is created.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnAfterCreatedEventHandler OnAfterCreated {
            add {
                if(m_OnAfterCreated == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnAfterCreated += value;
            }
            remove {
                m_OnAfterCreated -= value;
                if(m_OnAfterCreated == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnAfterCreatedEventHandler m_OnAfterCreated;

        /// <summary>
        /// Called when a modal window is about to display and the modal loop should
        /// begin running. Return false (0) to use the default modal loop
        /// implementation or true (1) to use a custom implementation.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public event CfxRunModalEventHandler RunModal {
            add {
                if(m_RunModal == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 2, 1);
                }
                m_RunModal += value;
            }
            remove {
                m_RunModal -= value;
                if(m_RunModal == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxRunModalEventHandler m_RunModal;

        /// <summary>
        /// Called when a browser has recieved a request to close. This may result
        /// directly from a call to CfxBrowserHost.CloseBrowser() or indirectly
        /// if the browser is a top-level OS window created by CEF and the user
        /// attempts to close the window. This function will be called after the
        /// JavaScript 'onunload' event has been fired. It will not be called for
        /// browsers after the associated OS window has been destroyed (for those
        /// browsers it is no longer possible to cancel the close).
        /// If CEF created an OS window for the browser returning false (0) will send
        /// an OS close notification to the browser window's top-level owner (e.g.
        /// WM_CLOSE on Windows, performClose: on OS-X and "delete_event" on Linux). If
        /// no OS window exists (window rendering disabled) returning false (0) will
        /// cause the browser object to be destroyed immediately. Return true (1) if
        /// the browser is parented to another window and that other window needs to
        /// receive close notification via some non-standard technique.
        /// If an application provides its own top-level window it should handle OS
        /// close notifications by calling CfxBrowserHost.CloseBrowser(false (0))
        /// instead of immediately closing (see the example below). This gives CEF an
        /// opportunity to process the 'onbeforeunload' event and optionally cancel the
        /// close before do_close() is called.
        /// The CfxLifeSpanHandler.OnBeforeClose() function will be called
        /// immediately before the browser object is destroyed. The application should
        /// only exit after on_before_close() has been called for all existing
        /// browsers.
        /// If the browser represents a modal window and a custom modal loop
        /// implementation was provided in CfxLifeSpanHandler.RunModal() this
        /// callback should be used to restore the opener window to a usable state.
        /// By way of example consider what should happen during window close when the
        /// browser is parented to an application-provided top-level OS window. 1.
        /// User clicks the window close button which sends an OS close
        /// notification (e.g. WM_CLOSE on Windows, performClose: on OS-X and
        /// "delete_event" on Linux).
        /// 2.  Application's top-level window receives the close notification and:
        /// A. Calls CfxBrowserHost.CloseBrowser(false).
        /// B. Cancels the window close.
        /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
        /// confirmation dialog (which can be overridden via
        /// CfxJSDialogHandler.OnBeforeUnloadDialog()).
        /// 4.  User approves the close. 5.  JavaScript 'onunload' handler executes. 6.
        /// Application's do_close() handler is called. Application will:
        /// A. Set a flag to indicate that the next close attempt will be allowed.
        /// B. Return false.
        /// 7.  CEF sends an OS close notification. 8.  Application's top-level window
        /// receives the OS close notification and
        /// allows the window to close based on the flag from #6B.
        /// 9.  Browser OS window is destroyed. 10. Application's
        /// CfxLifeSpanHandler.OnBeforeClose() handler is called and
        /// the browser object is destroyed.
        /// 11. Application exits by calling cef_quit_message_loop() if no other
        /// browsers
        /// exist.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public event CfxDoCloseEventHandler DoClose {
            add {
                if(m_DoClose == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 3, 1);
                }
                m_DoClose += value;
            }
            remove {
                m_DoClose -= value;
                if(m_DoClose == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxDoCloseEventHandler m_DoClose;

        /// <summary>
        /// Called just before a browser is destroyed. Release all references to the
        /// browser object and do not attempt to execute any functions on the browser
        /// object after this callback returns. If this is a modal window and a custom
        /// modal loop implementation was provided in run_modal() this callback should
        /// be used to exit the custom modal loop. See do_close() documentation for
        /// additional usage information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforeCloseEventHandler OnBeforeClose {
            add {
                if(m_OnBeforeClose == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 4, 1);
                }
                m_OnBeforeClose += value;
            }
            remove {
                m_OnBeforeClose -= value;
                if(m_OnBeforeClose == null) {
                    CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxOnBeforeCloseEventHandler m_OnBeforeClose;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforePopup != null) {
                m_OnBeforePopup = null;
                CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnAfterCreated != null) {
                m_OnAfterCreated = null;
                CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_RunModal != null) {
                m_RunModal = null;
                CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_DoClose != null) {
                m_DoClose = null;
                CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_OnBeforeClose != null) {
                m_OnBeforeClose = null;
                CfxApi.cfx_life_span_handler_activate_callback(NativePtr, 4, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called on the IO thread before a new popup window is created. The |Browser|
        /// and |Frame| parameters represent the source of the popup request. The
        /// |TargetUrl| and |TargetFrameName| values may be NULL if none were
        /// specified with the request. The |PopupFeatures| structure contains
        /// information about the requested popup window. To allow creation of the
        /// popup window optionally modify |WindowInfo|, |Client|, |Settings| and
        /// |NoJavascriptAccess| and return false (0). To cancel creation of the
        /// popup window return true (1). The |Client| and |Settings| values will
        /// default to the source browser's values. The |NoJavascriptAccess| value
        /// indicates whether the new browser window should be scriptable and in the
        /// same process as the source browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforePopupEventHandler(object sender, CfxOnBeforePopupEventArgs e);

        /// <summary>
        /// Called on the IO thread before a new popup window is created. The |Browser|
        /// and |Frame| parameters represent the source of the popup request. The
        /// |TargetUrl| and |TargetFrameName| values may be NULL if none were
        /// specified with the request. The |PopupFeatures| structure contains
        /// information about the requested popup window. To allow creation of the
        /// popup window optionally modify |WindowInfo|, |Client|, |Settings| and
        /// |NoJavascriptAccess| and return false (0). To cancel creation of the
        /// popup window return true (1). The |Client| and |Settings| values will
        /// default to the source browser's values. The |NoJavascriptAccess| value
        /// indicates whether the new browser window should be scriptable and in the
        /// same process as the source browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnBeforePopupEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_target_url_str;
            internal int m_target_url_length;
            internal string m_target_url;
            internal IntPtr m_target_frame_name_str;
            internal int m_target_frame_name_length;
            internal string m_target_frame_name;
            internal IntPtr m_popupFeatures;
            internal CfxPopupFeatures m_popupFeatures_wrapped;
            internal IntPtr m_windowInfo;
            internal CfxWindowInfo m_windowInfo_wrapped;
            internal CfxClient m_client_wrapped;
            internal IntPtr m_settings;
            internal CfxBrowserSettings m_settings_wrapped;
            internal int m_no_javascript_access;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnBeforePopupEventArgs(IntPtr browser, IntPtr frame, IntPtr target_url_str, int target_url_length, IntPtr target_frame_name_str, int target_frame_name_length, IntPtr popupFeatures, IntPtr windowInfo, IntPtr settings) {
                m_browser = browser;
                m_frame = frame;
                m_target_url_str = target_url_str;
                m_target_url_length = target_url_length;
                m_target_frame_name_str = target_frame_name_str;
                m_target_frame_name_length = target_frame_name_length;
                m_popupFeatures = popupFeatures;
                m_windowInfo = windowInfo;
                m_settings = settings;
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
            public string TargetUrl {
                get {
                    CheckAccess();
                    if(m_target_url == null && m_target_url_str != IntPtr.Zero) m_target_url = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_target_url_str, m_target_url_length);
                    return m_target_url;
                }
            }
            public string TargetFrameName {
                get {
                    CheckAccess();
                    if(m_target_frame_name == null && m_target_frame_name_str != IntPtr.Zero) m_target_frame_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_target_frame_name_str, m_target_frame_name_length);
                    return m_target_frame_name;
                }
            }
            public CfxPopupFeatures PopupFeatures {
                get {
                    CheckAccess();
                    if(m_popupFeatures_wrapped == null) m_popupFeatures_wrapped = CfxPopupFeatures.Wrap(m_popupFeatures);
                    return m_popupFeatures_wrapped;
                }
            }
            public CfxWindowInfo WindowInfo {
                get {
                    CheckAccess();
                    if(m_windowInfo_wrapped == null) m_windowInfo_wrapped = CfxWindowInfo.Wrap(m_windowInfo);
                    return m_windowInfo_wrapped;
                }
            }
            public CfxClient Client {
                set {
                    CheckAccess();
                    m_client_wrapped = value;
                }
            }
            public CfxBrowserSettings Settings {
                get {
                    CheckAccess();
                    if(m_settings_wrapped == null) m_settings_wrapped = CfxBrowserSettings.Wrap(m_settings);
                    return m_settings_wrapped;
                }
            }
            public bool NoJavascriptAccess {
                set {
                    CheckAccess();
                    m_no_javascript_access = value ? 1 : 0;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, TargetUrl={{{2}}}, TargetFrameName={{{3}}}, PopupFeatures={{{4}}}, WindowInfo={{{5}}}, Settings={{{7}}}", Browser, Frame, TargetUrl, TargetFrameName, PopupFeatures, WindowInfo, Settings);
            }
        }

        /// <summary>
        /// Called after a new browser is created.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnAfterCreatedEventHandler(object sender, CfxOnAfterCreatedEventArgs e);

        /// <summary>
        /// Called after a new browser is created.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnAfterCreatedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal CfxOnAfterCreatedEventArgs(IntPtr browser) {
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

        /// <summary>
        /// Called when a modal window is about to display and the modal loop should
        /// begin running. Return false (0) to use the default modal loop
        /// implementation or true (1) to use a custom implementation.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxRunModalEventHandler(object sender, CfxRunModalEventArgs e);

        /// <summary>
        /// Called when a modal window is about to display and the modal loop should
        /// begin running. Return false (0) to use the default modal loop
        /// implementation or true (1) to use a custom implementation.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public class CfxRunModalEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxRunModalEventArgs(IntPtr browser) {
                m_browser = browser;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

        /// <summary>
        /// Called when a browser has recieved a request to close. This may result
        /// directly from a call to CfxBrowserHost.CloseBrowser() or indirectly
        /// if the browser is a top-level OS window created by CEF and the user
        /// attempts to close the window. This function will be called after the
        /// JavaScript 'onunload' event has been fired. It will not be called for
        /// browsers after the associated OS window has been destroyed (for those
        /// browsers it is no longer possible to cancel the close).
        /// If CEF created an OS window for the browser returning false (0) will send
        /// an OS close notification to the browser window's top-level owner (e.g.
        /// WM_CLOSE on Windows, performClose: on OS-X and "delete_event" on Linux). If
        /// no OS window exists (window rendering disabled) returning false (0) will
        /// cause the browser object to be destroyed immediately. Return true (1) if
        /// the browser is parented to another window and that other window needs to
        /// receive close notification via some non-standard technique.
        /// If an application provides its own top-level window it should handle OS
        /// close notifications by calling CfxBrowserHost.CloseBrowser(false (0))
        /// instead of immediately closing (see the example below). This gives CEF an
        /// opportunity to process the 'onbeforeunload' event and optionally cancel the
        /// close before do_close() is called.
        /// The CfxLifeSpanHandler.OnBeforeClose() function will be called
        /// immediately before the browser object is destroyed. The application should
        /// only exit after on_before_close() has been called for all existing
        /// browsers.
        /// If the browser represents a modal window and a custom modal loop
        /// implementation was provided in CfxLifeSpanHandler.RunModal() this
        /// callback should be used to restore the opener window to a usable state.
        /// By way of example consider what should happen during window close when the
        /// browser is parented to an application-provided top-level OS window. 1.
        /// User clicks the window close button which sends an OS close
        /// notification (e.g. WM_CLOSE on Windows, performClose: on OS-X and
        /// "delete_event" on Linux).
        /// 2.  Application's top-level window receives the close notification and:
        /// A. Calls CfxBrowserHost.CloseBrowser(false).
        /// B. Cancels the window close.
        /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
        /// confirmation dialog (which can be overridden via
        /// CfxJSDialogHandler.OnBeforeUnloadDialog()).
        /// 4.  User approves the close. 5.  JavaScript 'onunload' handler executes. 6.
        /// Application's do_close() handler is called. Application will:
        /// A. Set a flag to indicate that the next close attempt will be allowed.
        /// B. Return false.
        /// 7.  CEF sends an OS close notification. 8.  Application's top-level window
        /// receives the OS close notification and
        /// allows the window to close based on the flag from #6B.
        /// 9.  Browser OS window is destroyed. 10. Application's
        /// CfxLifeSpanHandler.OnBeforeClose() handler is called and
        /// the browser object is destroyed.
        /// 11. Application exits by calling cef_quit_message_loop() if no other
        /// browsers
        /// exist.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxDoCloseEventHandler(object sender, CfxDoCloseEventArgs e);

        /// <summary>
        /// Called when a browser has recieved a request to close. This may result
        /// directly from a call to CfxBrowserHost.CloseBrowser() or indirectly
        /// if the browser is a top-level OS window created by CEF and the user
        /// attempts to close the window. This function will be called after the
        /// JavaScript 'onunload' event has been fired. It will not be called for
        /// browsers after the associated OS window has been destroyed (for those
        /// browsers it is no longer possible to cancel the close).
        /// If CEF created an OS window for the browser returning false (0) will send
        /// an OS close notification to the browser window's top-level owner (e.g.
        /// WM_CLOSE on Windows, performClose: on OS-X and "delete_event" on Linux). If
        /// no OS window exists (window rendering disabled) returning false (0) will
        /// cause the browser object to be destroyed immediately. Return true (1) if
        /// the browser is parented to another window and that other window needs to
        /// receive close notification via some non-standard technique.
        /// If an application provides its own top-level window it should handle OS
        /// close notifications by calling CfxBrowserHost.CloseBrowser(false (0))
        /// instead of immediately closing (see the example below). This gives CEF an
        /// opportunity to process the 'onbeforeunload' event and optionally cancel the
        /// close before do_close() is called.
        /// The CfxLifeSpanHandler.OnBeforeClose() function will be called
        /// immediately before the browser object is destroyed. The application should
        /// only exit after on_before_close() has been called for all existing
        /// browsers.
        /// If the browser represents a modal window and a custom modal loop
        /// implementation was provided in CfxLifeSpanHandler.RunModal() this
        /// callback should be used to restore the opener window to a usable state.
        /// By way of example consider what should happen during window close when the
        /// browser is parented to an application-provided top-level OS window. 1.
        /// User clicks the window close button which sends an OS close
        /// notification (e.g. WM_CLOSE on Windows, performClose: on OS-X and
        /// "delete_event" on Linux).
        /// 2.  Application's top-level window receives the close notification and:
        /// A. Calls CfxBrowserHost.CloseBrowser(false).
        /// B. Cancels the window close.
        /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
        /// confirmation dialog (which can be overridden via
        /// CfxJSDialogHandler.OnBeforeUnloadDialog()).
        /// 4.  User approves the close. 5.  JavaScript 'onunload' handler executes. 6.
        /// Application's do_close() handler is called. Application will:
        /// A. Set a flag to indicate that the next close attempt will be allowed.
        /// B. Return false.
        /// 7.  CEF sends an OS close notification. 8.  Application's top-level window
        /// receives the OS close notification and
        /// allows the window to close based on the flag from #6B.
        /// 9.  Browser OS window is destroyed. 10. Application's
        /// CfxLifeSpanHandler.OnBeforeClose() handler is called and
        /// the browser object is destroyed.
        /// 11. Application exits by calling cef_quit_message_loop() if no other
        /// browsers
        /// exist.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public class CfxDoCloseEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxDoCloseEventArgs(IntPtr browser) {
                m_browser = browser;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

        /// <summary>
        /// Called just before a browser is destroyed. Release all references to the
        /// browser object and do not attempt to execute any functions on the browser
        /// object after this callback returns. If this is a modal window and a custom
        /// modal loop implementation was provided in run_modal() this callback should
        /// be used to exit the custom modal loop. See do_close() documentation for
        /// additional usage information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforeCloseEventHandler(object sender, CfxOnBeforeCloseEventArgs e);

        /// <summary>
        /// Called just before a browser is destroyed. Release all references to the
        /// browser object and do not attempt to execute any functions on the browser
        /// object after this callback returns. If this is a modal window and a custom
        /// modal loop implementation was provided in run_modal() this callback should
        /// be used to exit the custom modal loop. See do_close() documentation for
        /// additional usage information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_life_span_handler_capi.h">cef/include/capi/cef_life_span_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnBeforeCloseEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal CfxOnBeforeCloseEventArgs(IntPtr browser) {
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
