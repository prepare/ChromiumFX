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
    internal static class CfxResourceBundleHandlerRemoteClient {

        static CfxResourceBundleHandlerRemoteClient() {
            get_localized_string_native = get_localized_string;
            get_data_resource_native = get_data_resource;
            get_data_resource_for_scale_native = get_data_resource_for_scale;
            get_localized_string_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_localized_string_native);
            get_data_resource_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_data_resource_native);
            get_data_resource_for_scale_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_data_resource_for_scale_native);
        }

        internal static void SetCallback(IntPtr self, int index, bool active) {
            switch(index) {
                case 0:
                    CfxApi.ResourceBundleHandler.cfx_resource_bundle_handler_set_callback(self, index, active ? get_localized_string_native_ptr : IntPtr.Zero);
                    break;
                case 1:
                    CfxApi.ResourceBundleHandler.cfx_resource_bundle_handler_set_callback(self, index, active ? get_data_resource_native_ptr : IntPtr.Zero);
                    break;
                case 2:
                    CfxApi.ResourceBundleHandler.cfx_resource_bundle_handler_set_callback(self, index, active ? get_data_resource_for_scale_native_ptr : IntPtr.Zero);
                    break;
            }
        }

        // get_localized_string
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_localized_string_delegate(IntPtr gcHandlePtr, out int __retval, int string_id, out IntPtr string_str, out int string_length, out IntPtr string_gc_handle);
        private static get_localized_string_delegate get_localized_string_native;
        private static IntPtr get_localized_string_native_ptr;

        internal static void get_localized_string(IntPtr gcHandlePtr, out int __retval, int string_id, out IntPtr string_str, out int string_length, out IntPtr string_gc_handle) {
            var call = new CfxGetLocalizedStringRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.string_id = string_id;
            call.RequestExecution();
            if(call.@string != null && call.@string.Length > 0) {
                var string_pinned = new PinnedString(call.@string);
                string_str = string_pinned.Obj.PinnedPtr;
                string_length = string_pinned.Length;
                string_gc_handle = string_pinned.Obj.GCHandlePtr();
            } else {
                string_str = IntPtr.Zero;
                string_length = 0;
                string_gc_handle = IntPtr.Zero;
            }
            __retval = call.__retval;
        }

        // get_data_resource
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_data_resource_delegate(IntPtr gcHandlePtr, out int __retval, int resource_id, out IntPtr data, out UIntPtr data_size);
        private static get_data_resource_delegate get_data_resource_native;
        private static IntPtr get_data_resource_native_ptr;

        internal static void get_data_resource(IntPtr gcHandlePtr, out int __retval, int resource_id, out IntPtr data, out UIntPtr data_size) {
            var call = new CfxGetDataResourceRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.resource_id = resource_id;
            call.RequestExecution();
            data = call.data;
            data_size = call.data_size;
            __retval = call.__retval;
        }

        // get_data_resource_for_scale
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_data_resource_for_scale_delegate(IntPtr gcHandlePtr, out int __retval, int resource_id, int scale_factor, out IntPtr data, out UIntPtr data_size);
        private static get_data_resource_for_scale_delegate get_data_resource_for_scale_native;
        private static IntPtr get_data_resource_for_scale_native_ptr;

        internal static void get_data_resource_for_scale(IntPtr gcHandlePtr, out int __retval, int resource_id, int scale_factor, out IntPtr data, out UIntPtr data_size) {
            var call = new CfxGetDataResourceForScaleRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.resource_id = resource_id;
            call.scale_factor = scale_factor;
            call.RequestExecution();
            data = call.data;
            data_size = call.data_size;
            __retval = call.__retval;
        }

    }
}
