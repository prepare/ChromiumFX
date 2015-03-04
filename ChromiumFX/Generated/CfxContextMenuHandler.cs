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
    /// Implement this structure to handle context menu events. The functions of this
    /// structure will be called on the UI thread.
    /// </summary>
    public class CfxContextMenuHandler : CfxBase {

        internal static CfxContextMenuHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_context_menu_handler_get_gc_handle(nativePtr);
            return (CfxContextMenuHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_before_context_menu(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr parameters, IntPtr model) {
            var self = (CfxContextMenuHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnBeforeContextMenuEventArgs(browser, frame, parameters, model);
            var eventHandler = self.m_OnBeforeContextMenu;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_params_wrapped == null) {
                CfxApi.cfx_release(e.m_params);
            } else {
                e.m_params_wrapped.Dispose();
            }
            if(e.m_model_wrapped == null) CfxApi.cfx_release(e.m_model);
        }

        internal static void on_context_menu_command(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr parameters, int command_id, CfxEventFlags event_flags) {
            var self = (CfxContextMenuHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnContextMenuCommandEventArgs(browser, frame, parameters, command_id, event_flags);
            var eventHandler = self.m_OnContextMenuCommand;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
            if(e.m_params_wrapped == null) {
                CfxApi.cfx_release(e.m_params);
            } else {
                e.m_params_wrapped.Dispose();
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_context_menu_dismissed(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame) {
            var self = (CfxContextMenuHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnContextMenuDismissedEventArgs(browser, frame);
            var eventHandler = self.m_OnContextMenuDismissed;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_frame_wrapped == null) CfxApi.cfx_release(e.m_frame);
        }

        internal CfxContextMenuHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxContextMenuHandler() : base(CfxApi.cfx_context_menu_handler_ctor) {}

        /// <summary>
        /// Called before a context menu is displayed. |Params| provides information
        /// about the context menu state. |Model| initially contains the default
        /// context menu. The |Model| can be cleared to show no context menu or
        /// modified to show a custom menu. Do not keep references to |Params| or
        /// |Model| outside of this callback.
        /// </summary>
        public event CfxOnBeforeContextMenuEventHandler OnBeforeContextMenu {
            add {
                if(m_OnBeforeContextMenu == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnBeforeContextMenu += value;
            }
            remove {
                m_OnBeforeContextMenu -= value;
                if(m_OnBeforeContextMenu == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnBeforeContextMenuEventHandler m_OnBeforeContextMenu;

        /// <summary>
        /// Called to execute a command selected from the context menu. Return true (1)
        /// if the command was handled or false (0) for the default implementation. See
        /// CfxMenuId for the command ids that have default implementations. All
        /// user-defined command ids should be between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST. |Params| will have the same values as what was passed to
        /// on_before_context_menu(). Do not keep a reference to |Params| outside of
        /// this callback.
        /// </summary>
        public event CfxOnContextMenuCommandEventHandler OnContextMenuCommand {
            add {
                if(m_OnContextMenuCommand == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnContextMenuCommand += value;
            }
            remove {
                m_OnContextMenuCommand -= value;
                if(m_OnContextMenuCommand == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnContextMenuCommandEventHandler m_OnContextMenuCommand;

        /// <summary>
        /// Called when the context menu is dismissed irregardless of whether the menu
        /// was NULL or a command was selected.
        /// </summary>
        public event CfxOnContextMenuDismissedEventHandler OnContextMenuDismissed {
            add {
                if(m_OnContextMenuDismissed == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 2, 1);
                }
                m_OnContextMenuDismissed += value;
            }
            remove {
                m_OnContextMenuDismissed -= value;
                if(m_OnContextMenuDismissed == null) {
                    CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxOnContextMenuDismissedEventHandler m_OnContextMenuDismissed;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforeContextMenu != null) {
                m_OnBeforeContextMenu = null;
                CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnContextMenuCommand != null) {
                m_OnContextMenuCommand = null;
                CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_OnContextMenuDismissed != null) {
                m_OnContextMenuDismissed = null;
                CfxApi.cfx_context_menu_handler_activate_callback(NativePtr, 2, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxOnBeforeContextMenuEventHandler(object sender, CfxOnBeforeContextMenuEventArgs e);

        /// <summary>
        /// Called before a context menu is displayed. |Params| provides information
        /// about the context menu state. |Model| initially contains the default
        /// context menu. The |Model| can be cleared to show no context menu or
        /// modified to show a custom menu. Do not keep references to |Params| or
        /// |Model| outside of this callback.
        /// </summary>
        public class CfxOnBeforeContextMenuEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_params;
            internal CfxContextMenuParams m_params_wrapped;
            internal IntPtr m_model;
            internal CfxMenuModel m_model_wrapped;

            internal CfxOnBeforeContextMenuEventArgs(IntPtr browser, IntPtr frame, IntPtr parameters, IntPtr model) {
                m_browser = browser;
                m_frame = frame;
                m_params = parameters;
                m_model = model;
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
            public CfxContextMenuParams Params {
                get {
                    CheckAccess();
                    if(m_params_wrapped == null) m_params_wrapped = CfxContextMenuParams.Wrap(m_params);
                    return m_params_wrapped;
                }
            }
            public CfxMenuModel Model {
                get {
                    CheckAccess();
                    if(m_model_wrapped == null) m_model_wrapped = CfxMenuModel.Wrap(m_model);
                    return m_model_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Params={{{2}}}, Model={{{3}}}", Browser, Frame, Params, Model);
            }
        }

        public delegate void CfxOnContextMenuCommandEventHandler(object sender, CfxOnContextMenuCommandEventArgs e);

        /// <summary>
        /// Called to execute a command selected from the context menu. Return true (1)
        /// if the command was handled or false (0) for the default implementation. See
        /// CfxMenuId for the command ids that have default implementations. All
        /// user-defined command ids should be between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST. |Params| will have the same values as what was passed to
        /// on_before_context_menu(). Do not keep a reference to |Params| outside of
        /// this callback.
        /// </summary>
        public class CfxOnContextMenuCommandEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;
            internal IntPtr m_params;
            internal CfxContextMenuParams m_params_wrapped;
            internal int m_command_id;
            internal CfxEventFlags m_event_flags;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnContextMenuCommandEventArgs(IntPtr browser, IntPtr frame, IntPtr parameters, int command_id, CfxEventFlags event_flags) {
                m_browser = browser;
                m_frame = frame;
                m_params = parameters;
                m_command_id = command_id;
                m_event_flags = event_flags;
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
            public CfxContextMenuParams Params {
                get {
                    CheckAccess();
                    if(m_params_wrapped == null) m_params_wrapped = CfxContextMenuParams.Wrap(m_params);
                    return m_params_wrapped;
                }
            }
            public int CommandId {
                get {
                    CheckAccess();
                    return m_command_id;
                }
            }
            public CfxEventFlags EventFlags {
                get {
                    CheckAccess();
                    return m_event_flags;
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
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Params={{{2}}}, CommandId={{{3}}}, EventFlags={{{4}}}", Browser, Frame, Params, CommandId, EventFlags);
            }
        }

        public delegate void CfxOnContextMenuDismissedEventHandler(object sender, CfxOnContextMenuDismissedEventArgs e);

        /// <summary>
        /// Called when the context menu is dismissed irregardless of whether the menu
        /// was NULL or a command was selected.
        /// </summary>
        public class CfxOnContextMenuDismissedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_frame;
            internal CfxFrame m_frame_wrapped;

            internal CfxOnContextMenuDismissedEventArgs(IntPtr browser, IntPtr frame) {
                m_browser = browser;
                m_frame = frame;
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

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}", Browser, Frame);
            }
        }

    }
}
