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
    /// Implement this structure to handle menu model events. The functions of this
    /// structure will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
    /// </remarks>
    public class CfxMenuModelDelegate : CfxClientBase {

        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            execute_command_native = execute_command;
            menu_will_show_native = menu_will_show;
            menu_closed_native = menu_closed;
            format_label_native = format_label;

            execute_command_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(execute_command_native);
            menu_will_show_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(menu_will_show_native);
            menu_closed_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(menu_closed_native);
            format_label_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(format_label_native);
        }

        // execute_command
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void execute_command_delegate(IntPtr gcHandlePtr, IntPtr menu_model, int command_id, int event_flags);
        private static execute_command_delegate execute_command_native;
        private static IntPtr execute_command_native_ptr;

        internal static void execute_command(IntPtr gcHandlePtr, IntPtr menu_model, int command_id, int event_flags) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxExecuteCommandEventArgs(menu_model, command_id, event_flags);
            self.m_ExecuteCommand?.Invoke(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
        }

        // menu_will_show
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void menu_will_show_delegate(IntPtr gcHandlePtr, IntPtr menu_model);
        private static menu_will_show_delegate menu_will_show_native;
        private static IntPtr menu_will_show_native_ptr;

        internal static void menu_will_show(IntPtr gcHandlePtr, IntPtr menu_model) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxMenuWillShowEventArgs(menu_model);
            self.m_MenuWillShow?.Invoke(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
        }

        // menu_closed
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void menu_closed_delegate(IntPtr gcHandlePtr, IntPtr menu_model);
        private static menu_closed_delegate menu_closed_native;
        private static IntPtr menu_closed_native_ptr;

        internal static void menu_closed(IntPtr gcHandlePtr, IntPtr menu_model) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxMenuClosedEventArgs(menu_model);
            self.m_MenuClosed?.Invoke(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
        }

        // format_label
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void format_label_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr menu_model, ref IntPtr label_str, ref int label_length);
        private static format_label_delegate format_label_native;
        private static IntPtr format_label_native_ptr;

        internal static void format_label(IntPtr gcHandlePtr, out int __retval, IntPtr menu_model, ref IntPtr label_str, ref int label_length) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(int);
                return;
            }
            var e = new CfxFormatLabelEventArgs(menu_model, label_str, label_length);
            self.m_FormatLabel?.Invoke(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
            if(e.m_label_changed) {
                var label_pinned = new PinnedString(e.m_label_wrapped);
                label_str = label_pinned.Obj.PinnedPtr;
                label_length = label_pinned.Length;
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxMenuModelDelegate(IntPtr nativePtr) : base(nativePtr) {}
        public CfxMenuModelDelegate() : base(CfxApi.MenuModelDelegate.cfx_menu_model_delegate_ctor) {}

        /// <summary>
        /// Perform the action associated with the specified |CommandId| and optional
        /// |EventFlags|.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public event CfxExecuteCommandEventHandler ExecuteCommand {
            add {
                lock(eventLock) {
                    if(m_ExecuteCommand == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 0, execute_command_native_ptr);
                    }
                    m_ExecuteCommand += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_ExecuteCommand -= value;
                    if(m_ExecuteCommand == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxExecuteCommandEventHandler m_ExecuteCommand;

        /// <summary>
        /// The menu is about to show.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public event CfxMenuWillShowEventHandler MenuWillShow {
            add {
                lock(eventLock) {
                    if(m_MenuWillShow == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 1, menu_will_show_native_ptr);
                    }
                    m_MenuWillShow += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_MenuWillShow -= value;
                    if(m_MenuWillShow == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 1, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxMenuWillShowEventHandler m_MenuWillShow;

        /// <summary>
        /// The menu has closed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public event CfxMenuClosedEventHandler MenuClosed {
            add {
                lock(eventLock) {
                    if(m_MenuClosed == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 2, menu_closed_native_ptr);
                    }
                    m_MenuClosed += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_MenuClosed -= value;
                    if(m_MenuClosed == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 2, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxMenuClosedEventHandler m_MenuClosed;

        /// <summary>
        /// Optionally modify a menu item label. Return true (1) if |Label| was
        /// modified.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public event CfxFormatLabelEventHandler FormatLabel {
            add {
                lock(eventLock) {
                    if(m_FormatLabel == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 3, format_label_native_ptr);
                    }
                    m_FormatLabel += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_FormatLabel -= value;
                    if(m_FormatLabel == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 3, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxFormatLabelEventHandler m_FormatLabel;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_ExecuteCommand != null) {
                m_ExecuteCommand = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 0, IntPtr.Zero);
            }
            if(m_MenuWillShow != null) {
                m_MenuWillShow = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 1, IntPtr.Zero);
            }
            if(m_MenuClosed != null) {
                m_MenuClosed = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 2, IntPtr.Zero);
            }
            if(m_FormatLabel != null) {
                m_FormatLabel = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_callback(NativePtr, 3, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Perform the action associated with the specified |CommandId| and optional
        /// |EventFlags|.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public delegate void CfxExecuteCommandEventHandler(object sender, CfxExecuteCommandEventArgs e);

        /// <summary>
        /// Perform the action associated with the specified |CommandId| and optional
        /// |EventFlags|.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public class CfxExecuteCommandEventArgs : CfxEventArgs {

            internal IntPtr m_menu_model;
            internal CfxMenuModel m_menu_model_wrapped;
            internal int m_command_id;
            internal int m_event_flags;

            internal CfxExecuteCommandEventArgs(IntPtr menu_model, int command_id, int event_flags) {
                m_menu_model = menu_model;
                m_command_id = command_id;
                m_event_flags = event_flags;
            }

            /// <summary>
            /// Get the MenuModel parameter for the <see cref="CfxMenuModelDelegate.ExecuteCommand"/> callback.
            /// </summary>
            public CfxMenuModel MenuModel {
                get {
                    CheckAccess();
                    if(m_menu_model_wrapped == null) m_menu_model_wrapped = CfxMenuModel.Wrap(m_menu_model);
                    return m_menu_model_wrapped;
                }
            }
            /// <summary>
            /// Get the CommandId parameter for the <see cref="CfxMenuModelDelegate.ExecuteCommand"/> callback.
            /// </summary>
            public int CommandId {
                get {
                    CheckAccess();
                    return m_command_id;
                }
            }
            /// <summary>
            /// Get the EventFlags parameter for the <see cref="CfxMenuModelDelegate.ExecuteCommand"/> callback.
            /// </summary>
            public CfxEventFlags EventFlags {
                get {
                    CheckAccess();
                    return (CfxEventFlags)m_event_flags;
                }
            }

            public override string ToString() {
                return String.Format("MenuModel={{{0}}}, CommandId={{{1}}}, EventFlags={{{2}}}", MenuModel, CommandId, EventFlags);
            }
        }

        /// <summary>
        /// The menu is about to show.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public delegate void CfxMenuWillShowEventHandler(object sender, CfxMenuWillShowEventArgs e);

        /// <summary>
        /// The menu is about to show.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public class CfxMenuWillShowEventArgs : CfxEventArgs {

            internal IntPtr m_menu_model;
            internal CfxMenuModel m_menu_model_wrapped;

            internal CfxMenuWillShowEventArgs(IntPtr menu_model) {
                m_menu_model = menu_model;
            }

            /// <summary>
            /// Get the MenuModel parameter for the <see cref="CfxMenuModelDelegate.MenuWillShow"/> callback.
            /// </summary>
            public CfxMenuModel MenuModel {
                get {
                    CheckAccess();
                    if(m_menu_model_wrapped == null) m_menu_model_wrapped = CfxMenuModel.Wrap(m_menu_model);
                    return m_menu_model_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("MenuModel={{{0}}}", MenuModel);
            }
        }

        /// <summary>
        /// The menu has closed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public delegate void CfxMenuClosedEventHandler(object sender, CfxMenuClosedEventArgs e);

        /// <summary>
        /// The menu has closed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public class CfxMenuClosedEventArgs : CfxEventArgs {

            internal IntPtr m_menu_model;
            internal CfxMenuModel m_menu_model_wrapped;

            internal CfxMenuClosedEventArgs(IntPtr menu_model) {
                m_menu_model = menu_model;
            }

            /// <summary>
            /// Get the MenuModel parameter for the <see cref="CfxMenuModelDelegate.MenuClosed"/> callback.
            /// </summary>
            public CfxMenuModel MenuModel {
                get {
                    CheckAccess();
                    if(m_menu_model_wrapped == null) m_menu_model_wrapped = CfxMenuModel.Wrap(m_menu_model);
                    return m_menu_model_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("MenuModel={{{0}}}", MenuModel);
            }
        }

        /// <summary>
        /// Optionally modify a menu item label. Return true (1) if |Label| was
        /// modified.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public delegate void CfxFormatLabelEventHandler(object sender, CfxFormatLabelEventArgs e);

        /// <summary>
        /// Optionally modify a menu item label. Return true (1) if |Label| was
        /// modified.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_menu_model_delegate_capi.h">cef/include/capi/cef_menu_model_delegate_capi.h</see>.
        /// </remarks>
        public class CfxFormatLabelEventArgs : CfxEventArgs {

            internal IntPtr m_menu_model;
            internal CfxMenuModel m_menu_model_wrapped;
            internal IntPtr m_label_str;
            internal int m_label_length;
            internal string m_label_wrapped;
            internal bool m_label_changed;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxFormatLabelEventArgs(IntPtr menu_model, IntPtr label_str, int label_length) {
                m_menu_model = menu_model;
                m_label_str = label_str;
                m_label_length = label_length;
            }

            /// <summary>
            /// Get the MenuModel parameter for the <see cref="CfxMenuModelDelegate.FormatLabel"/> callback.
            /// </summary>
            public CfxMenuModel MenuModel {
                get {
                    CheckAccess();
                    if(m_menu_model_wrapped == null) m_menu_model_wrapped = CfxMenuModel.Wrap(m_menu_model);
                    return m_menu_model_wrapped;
                }
            }
            /// <summary>
            /// Get or set the Label parameter for the <see cref="CfxMenuModelDelegate.FormatLabel"/> callback.
            /// </summary>
            public string Label {
                get {
                    CheckAccess();
                    if(!m_label_changed && m_label_wrapped == null) {
                        m_label_wrapped = StringFunctions.PtrToStringUni(m_label_str, m_label_length);
                    }
                    return m_label_wrapped;
                }
                set {
                    CheckAccess();
                    m_label_wrapped = value;
                    m_label_changed = true;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfxMenuModelDelegate.FormatLabel"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("MenuModel={{{0}}}, Label={{{1}}}", MenuModel, Label);
            }
        }

    }
}
