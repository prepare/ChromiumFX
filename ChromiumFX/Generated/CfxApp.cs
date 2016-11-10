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
    /// Implement this structure to provide handler implementations. Methods will be
    /// called by the process and/or thread indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
    /// </remarks>
    public class CfxApp : CfxClientBase {

        internal static CfxApp Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.App.cfx_app_get_gc_handle(nativePtr);
            return (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            on_before_command_line_processing_native = on_before_command_line_processing;
            on_register_custom_schemes_native = on_register_custom_schemes;
            get_resource_bundle_handler_native = get_resource_bundle_handler;
            get_browser_process_handler_native = get_browser_process_handler;
            get_render_process_handler_native = get_render_process_handler;
            var setCallbacks = (CfxApi.cfx_set_ptr_5_delegate)CfxApi.GetDelegate(CfxApiLoader.FunctionIndex.cfx_app_set_managed_callbacks, typeof(CfxApi.cfx_set_ptr_5_delegate));
            setCallbacks(
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_before_command_line_processing_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_register_custom_schemes_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_resource_bundle_handler_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_browser_process_handler_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_render_process_handler_native)
            );
        }

        // on_before_command_line_processing
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_before_command_line_processing_delegate(IntPtr gcHandlePtr, IntPtr process_type_str, int process_type_length, IntPtr command_line);
        private static on_before_command_line_processing_delegate on_before_command_line_processing_native;

        internal static void on_before_command_line_processing(IntPtr gcHandlePtr, IntPtr process_type_str, int process_type_length, IntPtr command_line) {
            var self = (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxOnBeforeCommandLineProcessingEventArgs(process_type_str, process_type_length, command_line);
            var eventHandler = self.m_OnBeforeCommandLineProcessing;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_command_line_wrapped == null) CfxApi.cfx_release(e.m_command_line);
        }

        // on_register_custom_schemes
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_register_custom_schemes_delegate(IntPtr gcHandlePtr, IntPtr registrar);
        private static on_register_custom_schemes_delegate on_register_custom_schemes_native;

        internal static void on_register_custom_schemes(IntPtr gcHandlePtr, IntPtr registrar) {
            var self = (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxOnRegisterCustomSchemesEventArgs(registrar);
            var eventHandler = self.m_OnRegisterCustomSchemes;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_registrar_wrapped == null) CfxApi.cfx_release(e.m_registrar);
        }

        // get_resource_bundle_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_resource_bundle_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static get_resource_bundle_handler_delegate get_resource_bundle_handler_native;

        internal static void get_resource_bundle_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetResourceBundleHandlerEventArgs();
            var eventHandler = self.m_GetResourceBundleHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxResourceBundleHandler.Unwrap(e.m_returnValue);
        }

        // get_browser_process_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_browser_process_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static get_browser_process_handler_delegate get_browser_process_handler_native;

        internal static void get_browser_process_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetBrowserProcessHandlerEventArgs();
            var eventHandler = self.m_GetBrowserProcessHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxBrowserProcessHandler.Unwrap(e.m_returnValue);
        }

        // get_render_process_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_render_process_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static get_render_process_handler_delegate get_render_process_handler_native;

        internal static void get_render_process_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var self = (CfxApp)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(IntPtr);
                return;
            }
            var e = new CfxGetRenderProcessHandlerEventArgs();
            var eventHandler = self.m_GetRenderProcessHandler;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = CfxRenderProcessHandler.Unwrap(e.m_returnValue);
        }

        internal CfxApp(IntPtr nativePtr) : base(nativePtr) {}
        public CfxApp() : base(CfxApi.App.cfx_app_ctor) {}

        /// <summary>
        /// Provides an opportunity to view and/or modify command-line arguments before
        /// processing by CEF and Chromium. The |ProcessType| value will be NULL for
        /// the browser process. Do not keep a reference to the CfxCommandLine
        /// object passed to this function. The CfxSettings.CommandLineArgsDisabled
        /// value can be used to start with an NULL command-line object. Any values
        /// specified in CfxSettings that equate to command-line arguments will be set
        /// before this function is called. Be cautious when using this function to
        /// modify command-line arguments for non-browser processes as this may result
        /// in undefined behavior including crashes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public event CfxOnBeforeCommandLineProcessingEventHandler OnBeforeCommandLineProcessing {
            add {
                lock(eventLock) {
                    if(m_OnBeforeCommandLineProcessing == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 0, 1);
                    }
                    m_OnBeforeCommandLineProcessing += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnBeforeCommandLineProcessing -= value;
                    if(m_OnBeforeCommandLineProcessing == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 0, 0);
                    }
                }
            }
        }

        private CfxOnBeforeCommandLineProcessingEventHandler m_OnBeforeCommandLineProcessing;

        /// <summary>
        /// Provides an opportunity to register custom schemes. Do not keep a reference
        /// to the |Registrar| object. This function is called on the main thread for
        /// each process and the registered schemes should be the same across all
        /// processes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public event CfxOnRegisterCustomSchemesEventHandler OnRegisterCustomSchemes {
            add {
                lock(eventLock) {
                    if(m_OnRegisterCustomSchemes == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 1, 1);
                    }
                    m_OnRegisterCustomSchemes += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnRegisterCustomSchemes -= value;
                    if(m_OnRegisterCustomSchemes == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 1, 0);
                    }
                }
            }
        }

        private CfxOnRegisterCustomSchemesEventHandler m_OnRegisterCustomSchemes;

        /// <summary>
        /// Return the handler for resource bundle events. If
        /// CfxSettings.PackLoadingDisabled is true (1) a handler must be returned.
        /// If no handler is returned resources will be loaded from pack files. This
        /// function is called by the browser and render processes on multiple threads.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public event CfxGetResourceBundleHandlerEventHandler GetResourceBundleHandler {
            add {
                lock(eventLock) {
                    if(m_GetResourceBundleHandler != null) {
                        throw new CfxException("Can't add more than one event handler to this type of event.");
                    }
                    CfxApi.App.cfx_app_activate_callback(NativePtr, 2, 1);
                    m_GetResourceBundleHandler += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetResourceBundleHandler -= value;
                    if(m_GetResourceBundleHandler == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 2, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the CfxResourceBundleHandler provided by the event handler attached to the GetResourceBundleHandler event, if any.
        /// Returns null if no event handler is attached.
        /// </summary>
        public CfxResourceBundleHandler RetrieveResourceBundleHandler() {
            var h = m_GetResourceBundleHandler;
            if(h != null) {
                var e = new CfxGetResourceBundleHandlerEventArgs();
                h(this, e);
                return e.m_returnValue;
            } else {
                return null;
            }
        }

        private CfxGetResourceBundleHandlerEventHandler m_GetResourceBundleHandler;

        /// <summary>
        /// Return the handler for functionality specific to the browser process. This
        /// function is called on multiple threads in the browser process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public event CfxGetBrowserProcessHandlerEventHandler GetBrowserProcessHandler {
            add {
                lock(eventLock) {
                    if(m_GetBrowserProcessHandler != null) {
                        throw new CfxException("Can't add more than one event handler to this type of event.");
                    }
                    CfxApi.App.cfx_app_activate_callback(NativePtr, 3, 1);
                    m_GetBrowserProcessHandler += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetBrowserProcessHandler -= value;
                    if(m_GetBrowserProcessHandler == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 3, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the CfxBrowserProcessHandler provided by the event handler attached to the GetBrowserProcessHandler event, if any.
        /// Returns null if no event handler is attached.
        /// </summary>
        public CfxBrowserProcessHandler RetrieveBrowserProcessHandler() {
            var h = m_GetBrowserProcessHandler;
            if(h != null) {
                var e = new CfxGetBrowserProcessHandlerEventArgs();
                h(this, e);
                return e.m_returnValue;
            } else {
                return null;
            }
        }

        private CfxGetBrowserProcessHandlerEventHandler m_GetBrowserProcessHandler;

        /// <summary>
        /// Return the handler for functionality specific to the render process. This
        /// function is called on the render process main thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public event CfxGetRenderProcessHandlerEventHandler GetRenderProcessHandler {
            add {
                lock(eventLock) {
                    if(m_GetRenderProcessHandler != null) {
                        throw new CfxException("Can't add more than one event handler to this type of event.");
                    }
                    CfxApi.App.cfx_app_activate_callback(NativePtr, 4, 1);
                    m_GetRenderProcessHandler += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetRenderProcessHandler -= value;
                    if(m_GetRenderProcessHandler == null) {
                        CfxApi.App.cfx_app_activate_callback(NativePtr, 4, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the CfxRenderProcessHandler provided by the event handler attached to the GetRenderProcessHandler event, if any.
        /// Returns null if no event handler is attached.
        /// </summary>
        public CfxRenderProcessHandler RetrieveRenderProcessHandler() {
            var h = m_GetRenderProcessHandler;
            if(h != null) {
                var e = new CfxGetRenderProcessHandlerEventArgs();
                h(this, e);
                return e.m_returnValue;
            } else {
                return null;
            }
        }

        private CfxGetRenderProcessHandlerEventHandler m_GetRenderProcessHandler;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnBeforeCommandLineProcessing != null) {
                m_OnBeforeCommandLineProcessing = null;
                CfxApi.App.cfx_app_activate_callback(NativePtr, 0, 0);
            }
            if(m_OnRegisterCustomSchemes != null) {
                m_OnRegisterCustomSchemes = null;
                CfxApi.App.cfx_app_activate_callback(NativePtr, 1, 0);
            }
            if(m_GetResourceBundleHandler != null) {
                m_GetResourceBundleHandler = null;
                CfxApi.App.cfx_app_activate_callback(NativePtr, 2, 0);
            }
            if(m_GetBrowserProcessHandler != null) {
                m_GetBrowserProcessHandler = null;
                CfxApi.App.cfx_app_activate_callback(NativePtr, 3, 0);
            }
            if(m_GetRenderProcessHandler != null) {
                m_GetRenderProcessHandler = null;
                CfxApi.App.cfx_app_activate_callback(NativePtr, 4, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Provides an opportunity to view and/or modify command-line arguments before
        /// processing by CEF and Chromium. The |ProcessType| value will be NULL for
        /// the browser process. Do not keep a reference to the CfxCommandLine
        /// object passed to this function. The CfxSettings.CommandLineArgsDisabled
        /// value can be used to start with an NULL command-line object. Any values
        /// specified in CfxSettings that equate to command-line arguments will be set
        /// before this function is called. Be cautious when using this function to
        /// modify command-line arguments for non-browser processes as this may result
        /// in undefined behavior including crashes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnBeforeCommandLineProcessingEventHandler(object sender, CfxOnBeforeCommandLineProcessingEventArgs e);

        /// <summary>
        /// Provides an opportunity to view and/or modify command-line arguments before
        /// processing by CEF and Chromium. The |ProcessType| value will be NULL for
        /// the browser process. Do not keep a reference to the CfxCommandLine
        /// object passed to this function. The CfxSettings.CommandLineArgsDisabled
        /// value can be used to start with an NULL command-line object. Any values
        /// specified in CfxSettings that equate to command-line arguments will be set
        /// before this function is called. Be cautious when using this function to
        /// modify command-line arguments for non-browser processes as this may result
        /// in undefined behavior including crashes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public class CfxOnBeforeCommandLineProcessingEventArgs : CfxEventArgs {

            internal IntPtr m_process_type_str;
            internal int m_process_type_length;
            internal string m_process_type;
            internal IntPtr m_command_line;
            internal CfxCommandLine m_command_line_wrapped;

            internal CfxOnBeforeCommandLineProcessingEventArgs(IntPtr process_type_str, int process_type_length, IntPtr command_line) {
                m_process_type_str = process_type_str;
                m_process_type_length = process_type_length;
                m_command_line = command_line;
            }

            /// <summary>
            /// Get the ProcessType parameter for the <see cref="CfxApp.OnBeforeCommandLineProcessing"/> callback.
            /// </summary>
            public string ProcessType {
                get {
                    CheckAccess();
                    m_process_type = StringFunctions.PtrToStringUni(m_process_type_str, m_process_type_length);
                    return m_process_type;
                }
            }
            /// <summary>
            /// Get the CommandLine parameter for the <see cref="CfxApp.OnBeforeCommandLineProcessing"/> callback.
            /// </summary>
            public CfxCommandLine CommandLine {
                get {
                    CheckAccess();
                    if(m_command_line_wrapped == null) m_command_line_wrapped = CfxCommandLine.Wrap(m_command_line);
                    return m_command_line_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("ProcessType={{{0}}}, CommandLine={{{1}}}", ProcessType, CommandLine);
            }
        }

        /// <summary>
        /// Provides an opportunity to register custom schemes. Do not keep a reference
        /// to the |Registrar| object. This function is called on the main thread for
        /// each process and the registered schemes should be the same across all
        /// processes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnRegisterCustomSchemesEventHandler(object sender, CfxOnRegisterCustomSchemesEventArgs e);

        /// <summary>
        /// Provides an opportunity to register custom schemes. Do not keep a reference
        /// to the |Registrar| object. This function is called on the main thread for
        /// each process and the registered schemes should be the same across all
        /// processes.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public class CfxOnRegisterCustomSchemesEventArgs : CfxEventArgs {

            internal IntPtr m_registrar;
            internal CfxSchemeRegistrar m_registrar_wrapped;

            internal CfxOnRegisterCustomSchemesEventArgs(IntPtr registrar) {
                m_registrar = registrar;
            }

            /// <summary>
            /// Get the Registrar parameter for the <see cref="CfxApp.OnRegisterCustomSchemes"/> callback.
            /// </summary>
            public CfxSchemeRegistrar Registrar {
                get {
                    CheckAccess();
                    if(m_registrar_wrapped == null) m_registrar_wrapped = CfxSchemeRegistrar.Wrap(m_registrar);
                    return m_registrar_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Registrar={{{0}}}", Registrar);
            }
        }

        /// <summary>
        /// Return the handler for resource bundle events. If
        /// CfxSettings.PackLoadingDisabled is true (1) a handler must be returned.
        /// If no handler is returned resources will be loaded from pack files. This
        /// function is called by the browser and render processes on multiple threads.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetResourceBundleHandlerEventHandler(object sender, CfxGetResourceBundleHandlerEventArgs e);

        /// <summary>
        /// Return the handler for resource bundle events. If
        /// CfxSettings.PackLoadingDisabled is true (1) a handler must be returned.
        /// If no handler is returned resources will be loaded from pack files. This
        /// function is called by the browser and render processes on multiple threads.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public class CfxGetResourceBundleHandlerEventArgs : CfxEventArgs {


            internal CfxResourceBundleHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetResourceBundleHandlerEventArgs() {
            }

            /// <summary>
            /// Set the return value for the <see cref="CfxApp.GetResourceBundleHandler"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfxResourceBundleHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for functionality specific to the browser process. This
        /// function is called on multiple threads in the browser process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetBrowserProcessHandlerEventHandler(object sender, CfxGetBrowserProcessHandlerEventArgs e);

        /// <summary>
        /// Return the handler for functionality specific to the browser process. This
        /// function is called on multiple threads in the browser process.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public class CfxGetBrowserProcessHandlerEventArgs : CfxEventArgs {


            internal CfxBrowserProcessHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetBrowserProcessHandlerEventArgs() {
            }

            /// <summary>
            /// Set the return value for the <see cref="CfxApp.GetBrowserProcessHandler"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfxBrowserProcessHandler returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }

        /// <summary>
        /// Return the handler for functionality specific to the render process. This
        /// function is called on the render process main thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetRenderProcessHandlerEventHandler(object sender, CfxGetRenderProcessHandlerEventArgs e);

        /// <summary>
        /// Return the handler for functionality specific to the render process. This
        /// function is called on the render process main thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public class CfxGetRenderProcessHandlerEventArgs : CfxEventArgs {


            internal CfxRenderProcessHandler m_returnValue;
            private bool returnValueSet;

            internal CfxGetRenderProcessHandlerEventArgs() {
            }

            /// <summary>
            /// Set the return value for the <see cref="CfxApp.GetRenderProcessHandler"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfxRenderProcessHandler returnValue) {
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
