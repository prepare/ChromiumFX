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

        internal static CfxMenuModelDelegate Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.MenuModelDelegate.cfx_menu_model_delegate_get_gc_handle(nativePtr);
            return (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        // execute_command
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_menu_model_delegate_execute_command_delegate(IntPtr gcHandlePtr, IntPtr menu_model, int command_id, int event_flags);
        private static cfx_menu_model_delegate_execute_command_delegate cfx_menu_model_delegate_execute_command;
        private static IntPtr cfx_menu_model_delegate_execute_command_ptr;

        internal static void execute_command(IntPtr gcHandlePtr, IntPtr menu_model, int command_id, int event_flags) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.DisableCallbacks) {
                return;
            }
            var e = new CfxExecuteCommandEventArgs(menu_model, command_id, event_flags);
            var eventHandler = self.m_ExecuteCommand;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
        }

        // menu_will_show
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_menu_model_delegate_menu_will_show_delegate(IntPtr gcHandlePtr, IntPtr menu_model);
        private static cfx_menu_model_delegate_menu_will_show_delegate cfx_menu_model_delegate_menu_will_show;
        private static IntPtr cfx_menu_model_delegate_menu_will_show_ptr;

        internal static void menu_will_show(IntPtr gcHandlePtr, IntPtr menu_model) {
            var self = (CfxMenuModelDelegate)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.DisableCallbacks) {
                return;
            }
            var e = new CfxMenuWillShowEventArgs(menu_model);
            var eventHandler = self.m_MenuWillShow;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_menu_model_wrapped == null) CfxApi.cfx_release(e.m_menu_model);
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
                        if(cfx_menu_model_delegate_execute_command == null) {
                            cfx_menu_model_delegate_execute_command = execute_command;
                            cfx_menu_model_delegate_execute_command_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_menu_model_delegate_execute_command);
                        }
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 0, cfx_menu_model_delegate_execute_command_ptr);
                    }
                    m_ExecuteCommand += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_ExecuteCommand -= value;
                    if(m_ExecuteCommand == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 0, IntPtr.Zero);
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
                        if(cfx_menu_model_delegate_menu_will_show == null) {
                            cfx_menu_model_delegate_menu_will_show = menu_will_show;
                            cfx_menu_model_delegate_menu_will_show_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_menu_model_delegate_menu_will_show);
                        }
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 1, cfx_menu_model_delegate_menu_will_show_ptr);
                    }
                    m_MenuWillShow += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_MenuWillShow -= value;
                    if(m_MenuWillShow == null) {
                        CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 1, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxMenuWillShowEventHandler m_MenuWillShow;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_ExecuteCommand != null) {
                m_ExecuteCommand = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 0, IntPtr.Zero);
            }
            if(m_MenuWillShow != null) {
                m_MenuWillShow = null;
                CfxApi.MenuModelDelegate.cfx_menu_model_delegate_set_managed_callback(NativePtr, 1, IntPtr.Zero);
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

    }
}
