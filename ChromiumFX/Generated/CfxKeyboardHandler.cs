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
    /// Implement this structure to handle events related to keyboard input. The
    /// functions of this structure will be called on the UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
    /// </remarks>
    public class CfxKeyboardHandler : CfxBase {

        internal static CfxKeyboardHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_keyboard_handler_get_gc_handle(nativePtr);
            return (CfxKeyboardHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_pre_key_event(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr @event, IntPtr os_event, out int is_keyboard_shortcut) {
            var self = (CfxKeyboardHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                is_keyboard_shortcut = default(int);
                return;
            }
            var e = new CfxOnPreKeyEventEventArgs(browser, @event, os_event);
            var eventHandler = self.m_OnPreKeyEvent;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            is_keyboard_shortcut = e.m_is_keyboard_shortcut;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_key_event(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr @event, IntPtr os_event) {
            var self = (CfxKeyboardHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnKeyEventEventArgs(browser, @event, os_event);
            var eventHandler = self.m_OnKeyEvent;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxKeyboardHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxKeyboardHandler() : base(CfxApi.cfx_keyboard_handler_ctor) {}

        /// <summary>
        /// Called before a keyboard event is sent to the renderer. |Event| contains
        /// information about the keyboard event. |OsEvent| is the operating system
        /// event message, if any. Return true (1) if the event was handled or false
        /// (0) otherwise. If the event will be handled in on_key_event() as a keyboard
        /// shortcut set |IsKeyboardShortcut| to true (1) and return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnPreKeyEventEventHandler OnPreKeyEvent {
            add {
                if(m_OnPreKeyEvent == null) {
                    CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnPreKeyEvent += value;
            }
            remove {
                m_OnPreKeyEvent -= value;
                if(m_OnPreKeyEvent == null) {
                    CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxOnPreKeyEventEventHandler m_OnPreKeyEvent;

        /// <summary>
        /// Called after the renderer and JavaScript in the page has had a chance to
        /// handle the event. |Event| contains information about the keyboard event.
        /// |OsEvent| is the operating system event message, if any. Return true (1)
        /// if the keyboard event was handled or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnKeyEventEventHandler OnKeyEvent {
            add {
                if(m_OnKeyEvent == null) {
                    CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnKeyEvent += value;
            }
            remove {
                m_OnKeyEvent -= value;
                if(m_OnKeyEvent == null) {
                    CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnKeyEventEventHandler m_OnKeyEvent;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnPreKeyEvent != null) {
                m_OnPreKeyEvent = null;
                CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnKeyEvent != null) {
                m_OnKeyEvent = null;
                CfxApi.cfx_keyboard_handler_activate_callback(NativePtr, 1, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called before a keyboard event is sent to the renderer. |Event| contains
        /// information about the keyboard event. |OsEvent| is the operating system
        /// event message, if any. Return true (1) if the event was handled or false
        /// (0) otherwise. If the event will be handled in on_key_event() as a keyboard
        /// shortcut set |IsKeyboardShortcut| to true (1) and return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnPreKeyEventEventHandler(object sender, CfxOnPreKeyEventEventArgs e);

        /// <summary>
        /// Called before a keyboard event is sent to the renderer. |Event| contains
        /// information about the keyboard event. |OsEvent| is the operating system
        /// event message, if any. Return true (1) if the event was handled or false
        /// (0) otherwise. If the event will be handled in on_key_event() as a keyboard
        /// shortcut set |IsKeyboardShortcut| to true (1) and return false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnPreKeyEventEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_event;
            internal CfxKeyEvent m_event_wrapped;
            internal IntPtr m_os_event;
            internal int m_is_keyboard_shortcut;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnPreKeyEventEventArgs(IntPtr browser, IntPtr @event, IntPtr os_event) {
                m_browser = browser;
                m_event = @event;
                m_os_event = os_event;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxKeyEvent Event {
                get {
                    CheckAccess();
                    if(m_event_wrapped == null) m_event_wrapped = CfxKeyEvent.Wrap(m_event);
                    return m_event_wrapped;
                }
            }
            public IntPtr OsEvent {
                get {
                    CheckAccess();
                    return m_os_event;
                }
            }
            public bool IsKeyboardShortcut {
                set {
                    CheckAccess();
                    m_is_keyboard_shortcut = value ? 1 : 0;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Event={{{1}}}, OsEvent={{{2}}}", Browser, Event, OsEvent);
            }
        }

        /// <summary>
        /// Called after the renderer and JavaScript in the page has had a chance to
        /// handle the event. |Event| contains information about the keyboard event.
        /// |OsEvent| is the operating system event message, if any. Return true (1)
        /// if the keyboard event was handled or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnKeyEventEventHandler(object sender, CfxOnKeyEventEventArgs e);

        /// <summary>
        /// Called after the renderer and JavaScript in the page has had a chance to
        /// handle the event. |Event| contains information about the keyboard event.
        /// |OsEvent| is the operating system event message, if any. Return true (1)
        /// if the keyboard event was handled or false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnKeyEventEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_event;
            internal CfxKeyEvent m_event_wrapped;
            internal IntPtr m_os_event;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnKeyEventEventArgs(IntPtr browser, IntPtr @event, IntPtr os_event) {
                m_browser = browser;
                m_event = @event;
                m_os_event = os_event;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxKeyEvent Event {
                get {
                    CheckAccess();
                    if(m_event_wrapped == null) m_event_wrapped = CfxKeyEvent.Wrap(m_event);
                    return m_event_wrapped;
                }
            }
            public IntPtr OsEvent {
                get {
                    CheckAccess();
                    return m_os_event;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_keyboard_handler_capi.h">cef/include/capi/cef_keyboard_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, Event={{{1}}}, OsEvent={{{2}}}", Browser, Event, OsEvent);
            }
        }

    }
}
