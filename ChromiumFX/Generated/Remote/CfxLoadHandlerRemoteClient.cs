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
    internal static class CfxLoadHandlerRemoteClient {

        static CfxLoadHandlerRemoteClient() {
            on_loading_state_change_native = on_loading_state_change;
            on_load_start_native = on_load_start;
            on_load_end_native = on_load_end;
            on_load_error_native = on_load_error;
            on_loading_state_change_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_loading_state_change_native);
            on_load_start_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_load_start_native);
            on_load_end_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_load_end_native);
            on_load_error_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_load_error_native);
        }

        internal static void SetCallback(IntPtr self, int index, bool active) {
            switch(index) {
                case 0:
                    CfxApi.LoadHandler.cfx_load_handler_set_callback(self, index, active ? on_loading_state_change_native_ptr : IntPtr.Zero);
                    break;
                case 1:
                    CfxApi.LoadHandler.cfx_load_handler_set_callback(self, index, active ? on_load_start_native_ptr : IntPtr.Zero);
                    break;
                case 2:
                    CfxApi.LoadHandler.cfx_load_handler_set_callback(self, index, active ? on_load_end_native_ptr : IntPtr.Zero);
                    break;
                case 3:
                    CfxApi.LoadHandler.cfx_load_handler_set_callback(self, index, active ? on_load_error_native_ptr : IntPtr.Zero);
                    break;
            }
        }

        // on_loading_state_change
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_loading_state_change_delegate(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, int isLoading, int canGoBack, int canGoForward);
        private static on_loading_state_change_delegate on_loading_state_change_native;
        private static IntPtr on_loading_state_change_native_ptr;

        internal static void on_loading_state_change(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, int isLoading, int canGoBack, int canGoForward) {
            var call = new CfxOnLoadingStateChangeRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.browser = browser;
            call.isLoading = isLoading;
            call.canGoBack = canGoBack;
            call.canGoForward = canGoForward;
            call.RequestExecution();
            browser_release = call.browser_release;
        }

        // on_load_start
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_load_start_delegate(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int transition_type);
        private static on_load_start_delegate on_load_start_native;
        private static IntPtr on_load_start_native_ptr;

        internal static void on_load_start(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int transition_type) {
            var call = new CfxOnLoadStartRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.browser = browser;
            call.frame = frame;
            call.transition_type = transition_type;
            call.RequestExecution();
            browser_release = call.browser_release;
            frame_release = call.frame_release;
        }

        // on_load_end
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_load_end_delegate(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int httpStatusCode);
        private static on_load_end_delegate on_load_end_native;
        private static IntPtr on_load_end_native_ptr;

        internal static void on_load_end(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int httpStatusCode) {
            var call = new CfxOnLoadEndRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.browser = browser;
            call.frame = frame;
            call.httpStatusCode = httpStatusCode;
            call.RequestExecution();
            browser_release = call.browser_release;
            frame_release = call.frame_release;
        }

        // on_load_error
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_load_error_delegate(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int errorCode, IntPtr errorText_str, int errorText_length, IntPtr failedUrl_str, int failedUrl_length);
        private static on_load_error_delegate on_load_error_native;
        private static IntPtr on_load_error_native_ptr;

        internal static void on_load_error(IntPtr gcHandlePtr, IntPtr browser, out int browser_release, IntPtr frame, out int frame_release, int errorCode, IntPtr errorText_str, int errorText_length, IntPtr failedUrl_str, int failedUrl_length) {
            var call = new CfxOnLoadErrorRemoteEventCall();
            call.gcHandlePtr = gcHandlePtr;
            call.browser = browser;
            call.frame = frame;
            call.errorCode = errorCode;
            call.errorText_str = errorText_str;
            call.errorText_length = errorText_length;
            call.failedUrl_str = failedUrl_str;
            call.failedUrl_length = failedUrl_length;
            call.RequestExecution();
            browser_release = call.browser_release;
            frame_release = call.frame_release;
        }

    }
}
