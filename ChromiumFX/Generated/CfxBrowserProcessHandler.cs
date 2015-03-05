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
    /// Structure used to implement browser process callbacks. The functions of this
    /// structure will be called on the browser process main thread unless otherwise
    /// indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
    /// </remarks>
    public class CfxBrowserProcessHandler : CfxBase {

        internal static CfxBrowserProcessHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_browser_process_handler_get_gc_handle(nativePtr);
            return (CfxBrowserProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_context_initialized(IntPtr gcHandlePtr) {
            var self = (CfxBrowserProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxEventArgs();
            var eventHandler = self.m_OnContextInitialized;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
        }

        internal static void on_before_child_process_launch(IntPtr gcHandlePtr, IntPtr command_line) {
            var self = (CfxBrowserProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnBeforeChildProcessLaunchEventArgs(command_line);
            var eventHandler = self.m_OnBeforeChildProcessLaunch;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_command_line_wrapped == null) {
                CfxApi.cfx_release(e.m_command_line);
            } else {
                e.m_command_line_wrapped.Dispose();
            }
        }

        internal static void on_render_process_thread_created(IntPtr gcHandlePtr, IntPtr extra_info) {
            var self = (CfxBrowserProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnRenderProcessThreadCreatedEventArgs(extra_info);
            var eventHandler = self.m_OnRenderProcessThreadCreated;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_extra_info_wrapped == null) {
                CfxApi.cfx_release(e.m_extra_info);
            } else {
                e.m_extra_info_wrapped.Dispose();
            }
        }

        internal static void get_print_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxBrowserProcessHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetPrintHandlerEventArgs();
            var eventHandler = self.m_GetPrintHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxPrintHandler.Unwrap(e.m_returnValue);
        }

        internal CfxBrowserProcessHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxBrowserProcessHandler() : base(CfxApi.cfx_browser_process_handler_ctor) {}

        /// <summary>
        /// Called on the browser process UI thread immediately after the CEF context
        /// has been initialized.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public event CfxEventHandler OnContextInitialized {
            add {
                if(m_OnContextInitialized == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnContextInitialized += value;
            }
            remove {
                m_OnContextInitialized -= value;
                if(m_OnContextInitialized == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxEventHandler m_OnContextInitialized;

        /// <summary>
        /// Called before a child process is launched. Will be called on the browser
        /// process UI thread when launching a render process and on the browser
        /// process IO thread when launching a GPU or plugin process. Provides an
        /// opportunity to modify the child process command line. Do not keep a
        /// reference to |CommandLine| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforeChildProcessLaunchEventHandler OnBeforeChildProcessLaunch {
            add {
                if(m_OnBeforeChildProcessLaunch == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 1, 1);
                }
                m_OnBeforeChildProcessLaunch += value;
            }
            remove {
                m_OnBeforeChildProcessLaunch -= value;
                if(m_OnBeforeChildProcessLaunch == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxOnBeforeChildProcessLaunchEventHandler m_OnBeforeChildProcessLaunch;

        /// <summary>
        /// Called on the browser process IO thread after the main thread has been
        /// created for a new render process. Provides an opportunity to specify extra
        /// information that will be passed to
        /// CfxRenderProcessHandler.OnRenderThreadCreated() in the render
        /// process. Do not keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnRenderProcessThreadCreatedEventHandler OnRenderProcessThreadCreated {
            add {
                if(m_OnRenderProcessThreadCreated == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 2, 1);
                }
                m_OnRenderProcessThreadCreated += value;
            }
            remove {
                m_OnRenderProcessThreadCreated -= value;
                if(m_OnRenderProcessThreadCreated == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxOnRenderProcessThreadCreatedEventHandler m_OnRenderProcessThreadCreated;

        /// <summary>
        /// Return the handler for printing on Linux. If a print handler is not
        /// provided then printing will not be supported on the Linux platform.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public event CfxGetPrintHandlerEventHandler GetPrintHandler {
            add {
                if(m_GetPrintHandler == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 3, 1);
                }
                m_GetPrintHandler += value;
            }
            remove {
                m_GetPrintHandler -= value;
                if(m_GetPrintHandler == null) {
                    CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxGetPrintHandlerEventHandler m_GetPrintHandler;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnContextInitialized != null) {
                m_OnContextInitialized = null;
                CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnBeforeChildProcessLaunch != null) {
                m_OnBeforeChildProcessLaunch = null;
                CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_OnRenderProcessThreadCreated != null) {
                m_OnRenderProcessThreadCreated = null;
                CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_GetPrintHandler != null) {
                m_GetPrintHandler = null;
                CfxApi.cfx_browser_process_handler_activate_callback(NativePtr, 3, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {


        /// <summary>
        /// Called before a child process is launched. Will be called on the browser
        /// process UI thread when launching a render process and on the browser
        /// process IO thread when launching a GPU or plugin process. Provides an
        /// opportunity to modify the child process command line. Do not keep a
        /// reference to |CommandLine| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforeChildProcessLaunchEventHandler(object sender, CfxOnBeforeChildProcessLaunchEventArgs e);

        /// <summary>
        /// Called before a child process is launched. Will be called on the browser
        /// process UI thread when launching a render process and on the browser
        /// process IO thread when launching a GPU or plugin process. Provides an
        /// opportunity to modify the child process command line. Do not keep a
        /// reference to |CommandLine| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnBeforeChildProcessLaunchEventArgs : CfxEventArgs {

            internal IntPtr m_command_line;
            internal CfxCommandLine m_command_line_wrapped;

            internal CfxOnBeforeChildProcessLaunchEventArgs(IntPtr command_line) {
                m_command_line = command_line;
            }

            public CfxCommandLine CommandLine {
                get {
                    CheckAccess();
                    if(m_command_line_wrapped == null) m_command_line_wrapped = CfxCommandLine.Wrap(m_command_line);
                    return m_command_line_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("CommandLine={{{0}}}", CommandLine);
            }
        }

        /// <summary>
        /// Called on the browser process IO thread after the main thread has been
        /// created for a new render process. Provides an opportunity to specify extra
        /// information that will be passed to
        /// CfxRenderProcessHandler.OnRenderThreadCreated() in the render
        /// process. Do not keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnRenderProcessThreadCreatedEventHandler(object sender, CfxOnRenderProcessThreadCreatedEventArgs e);

        /// <summary>
        /// Called on the browser process IO thread after the main thread has been
        /// created for a new render process. Provides an opportunity to specify extra
        /// information that will be passed to
        /// CfxRenderProcessHandler.OnRenderThreadCreated() in the render
        /// process. Do not keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnRenderProcessThreadCreatedEventArgs : CfxEventArgs {

            internal IntPtr m_extra_info;
            internal CfxListValue m_extra_info_wrapped;

            internal CfxOnRenderProcessThreadCreatedEventArgs(IntPtr extra_info) {
                m_extra_info = extra_info;
            }

            public CfxListValue ExtraInfo {
                get {
                    CheckAccess();
                    if(m_extra_info_wrapped == null) m_extra_info_wrapped = CfxListValue.Wrap(m_extra_info);
                    return m_extra_info_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("ExtraInfo={{{0}}}", ExtraInfo);
            }
        }

        /// <summary>
        /// Return the handler for printing on Linux. If a print handler is not
        /// provided then printing will not be supported on the Linux platform.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetPrintHandlerEventHandler(object sender, CfxGetPrintHandlerEventArgs e);

        /// <summary>
        /// Return the handler for printing on Linux. If a print handler is not
        /// provided then printing will not be supported on the Linux platform.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
        /// </remarks>
        public class CfxGetPrintHandlerEventArgs : CfxEventArgs {


            internal CfxPrintHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetPrintHandlerEventArgs() {
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_process_handler_capi.h">cef/include/capi/cef_browser_process_handler_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(CfxPrintHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

    }
}
