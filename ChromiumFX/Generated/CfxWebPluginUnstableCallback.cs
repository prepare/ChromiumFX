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
    /// Structure to implement for receiving unstable plugin information. The
    /// functions of this structure will be called on the browser process IO thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
    /// </remarks>
    public class CfxWebPluginUnstableCallback : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxWebPluginUnstableCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxWebPluginUnstableCallback)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxWebPluginUnstableCallback(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxWebPluginUnstableCallback(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Method that will be called for the requested plugin. |unstable| will be
        /// true (1) if the plugin has reached the crash count threshold of 3 times in
        /// 120 seconds.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public void IsUnstable(string path, bool unstable) {
            var path_pinned = new PinnedString(path);
            CfxApi.cfx_web_plugin_unstable_callback_is_unstable(NativePtr, path_pinned.Obj.PinnedPtr, path_pinned.Length, unstable ? 1 : 0);
            path_pinned.Obj.Free();
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
