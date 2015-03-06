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
    /// Structure that creates CfxResourceHandler instances for handling scheme
    /// requests. The functions of this structure will always be called on the IO
    /// thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_scheme_capi.h">cef/include/capi/cef_scheme_capi.h</see>.
    /// </remarks>
    public class CfxSchemeHandlerFactory : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxSchemeHandlerFactory Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxSchemeHandlerFactory)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxSchemeHandlerFactory(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxSchemeHandlerFactory(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Return a new resource handler instance to handle the request or an NULL
        /// reference to allow default handling of the request. |browser| and |frame|
        /// will be the browser window and frame respectively that originated the
        /// request or NULL if the request did not originate from a browser window (for
        /// example, if the request came from CfxUrlRequest). The |request| object
        /// passed to this function will not contain cookie data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_scheme_capi.h">cef/include/capi/cef_scheme_capi.h</see>.
        /// </remarks>
        public CfxResourceHandler Create(CfxBrowser browser, CfxFrame frame, string schemeName, CfxRequest request) {
            var schemeName_pinned = new PinnedString(schemeName);
            var __retval = CfxApi.cfx_scheme_handler_factory_create(NativePtr, CfxBrowser.Unwrap(browser), CfxFrame.Unwrap(frame), schemeName_pinned.Obj.PinnedPtr, schemeName_pinned.Length, CfxRequest.Unwrap(request));
            schemeName_pinned.Obj.Free();
            return CfxResourceHandler.Wrap(__retval);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
