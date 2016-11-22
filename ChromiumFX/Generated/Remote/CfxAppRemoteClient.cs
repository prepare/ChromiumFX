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

namespace Chromium.Remote {
    internal static class CfxAppRemoteClient {

        static CfxAppRemoteClient() {
            on_before_command_line_processing_native = on_before_command_line_processing;
            on_register_custom_schemes_native = on_register_custom_schemes;
            get_resource_bundle_handler_native = get_resource_bundle_handler;
            get_render_process_handler_native = get_render_process_handler;
            on_before_command_line_processing_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_before_command_line_processing_native);
            on_register_custom_schemes_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_register_custom_schemes_native);
            get_resource_bundle_handler_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_resource_bundle_handler_native);
            get_render_process_handler_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_render_process_handler_native);
        }

        internal static void SetCallback(IntPtr self, int index, bool active) {
            switch(index) {
                case 0:
                    CfxApi.App.cfx_app_set_callback(self, index, active ? on_before_command_line_processing_native_ptr : IntPtr.Zero);
                    break;
                case 1:
                    CfxApi.App.cfx_app_set_callback(self, index, active ? on_register_custom_schemes_native_ptr : IntPtr.Zero);
                    break;
                case 2:
                    CfxApi.App.cfx_app_set_callback(self, index, active ? get_resource_bundle_handler_native_ptr : IntPtr.Zero);
                    break;
                case 4:
                    CfxApi.App.cfx_app_set_callback(self, index, active ? get_render_process_handler_native_ptr : IntPtr.Zero);
                    break;
            }
        }

        // on_before_command_line_processing
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_before_command_line_processing_delegate(IntPtr gcHandlePtr, IntPtr process_type_str, int process_type_length, IntPtr command_line, out int command_line_release);
        private static on_before_command_line_processing_delegate on_before_command_line_processing_native;
        private static IntPtr on_before_command_line_processing_native_ptr;

        internal static void on_before_command_line_processing(IntPtr gcHandlePtr, IntPtr process_type_str, int process_type_length, IntPtr command_line, out int command_line_release) {
            var call = new CfxOnBeforeCommandLineProcessingRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.process_type_str = process_type_str;
            call.process_type_length = process_type_length;
            call.command_line = command_line;
            call.RequestExecution();
            command_line_release = call.command_line_release;
        }

        // on_register_custom_schemes
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_register_custom_schemes_delegate(IntPtr gcHandlePtr, IntPtr registrar, out int registrar_release);
        private static on_register_custom_schemes_delegate on_register_custom_schemes_native;
        private static IntPtr on_register_custom_schemes_native_ptr;

        internal static void on_register_custom_schemes(IntPtr gcHandlePtr, IntPtr registrar, out int registrar_release) {
            var call = new CfxOnRegisterCustomSchemesRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.registrar = registrar;
            call.RequestExecution();
            registrar_release = call.registrar_release;
        }

        // get_resource_bundle_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_resource_bundle_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static get_resource_bundle_handler_delegate get_resource_bundle_handler_native;
        private static IntPtr get_resource_bundle_handler_native_ptr;

        internal static void get_resource_bundle_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var call = new CfxGetResourceBundleHandlerRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.RequestExecution();
            __retval = call.__retval;
        }

        // get_render_process_handler
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_render_process_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        private static get_render_process_handler_delegate get_render_process_handler_native;
        private static IntPtr get_render_process_handler_native_ptr;

        internal static void get_render_process_handler(IntPtr gcHandlePtr, out IntPtr __retval) {
            var call = new CfxGetRenderProcessHandlerRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.RequestExecution();
            __retval = call.__retval;
        }

    }
}
