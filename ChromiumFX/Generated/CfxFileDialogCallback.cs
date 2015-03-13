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
    /// <summary>
    /// Callback structure for asynchronous continuation of file dialog requests.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
    /// </remarks>
    public class CfxFileDialogCallback : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxFileDialogCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxFileDialogCallback)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxFileDialogCallback(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxFileDialogCallback(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Continue the file selection with the specified |filePaths|. This may be a
        /// single value or a list of values depending on the dialog mode. An NULL
        /// value is treated the same as calling cancel().
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
        /// </remarks>
        public void Continue(System.Collections.Generic.List<string> filePaths) {
            PinnedString[] filePaths_handles;
            var filePaths_unwrapped = CfxStringCollections.UnwrapCfxStringList(filePaths, out filePaths_handles);
            CfxApi.cfx_file_dialog_callback_cont(NativePtr, filePaths_unwrapped);
            CfxStringCollections.FreePinnedStrings(filePaths_handles);
            CfxStringCollections.CfxStringListCopyToManaged(filePaths_unwrapped, filePaths);
            CfxApi.cfx_string_list_free(filePaths_unwrapped);
        }

        /// <summary>
        /// Cancel the file selection.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dialog_handler_capi.h">cef/include/capi/cef_dialog_handler_capi.h</see>.
        /// </remarks>
        public void Cancel() {
            CfxApi.cfx_file_dialog_callback_cancel(NativePtr);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
