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
    /// Callback structure for CfxBrowserHost.RunFileDialog. The functions of
    /// this structure will be called on the browser process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
    /// </remarks>
    public class CfxRunFileDialogCallback : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxRunFileDialogCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxRunFileDialogCallback)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxRunFileDialogCallback(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxRunFileDialogCallback(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Called asynchronously after the file dialog is dismissed. If the selection
        /// was successful |filePaths| will be a single value or a list of values
        /// depending on the dialog mode. If the selection was cancelled |filePaths|
        /// will be NULL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void Continue(CfxBrowserHost browserHost, System.Collections.Generic.List<string> filePaths) {
            PinnedString[] filePaths_handles;
            var filePaths_unwrapped = CfxStringCollections.UnwrapCfxStringList(filePaths, out filePaths_handles);
            CfxApi.cfx_run_file_dialog_callback_cont(NativePtr, CfxBrowserHost.Unwrap(browserHost), filePaths_unwrapped);
            CfxStringCollections.FreePinnedStrings(filePaths_handles);
            CfxStringCollections.CfxStringListCopyToManaged(filePaths_unwrapped, filePaths);
            CfxApi.cfx_string_list_free(filePaths_unwrapped);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
