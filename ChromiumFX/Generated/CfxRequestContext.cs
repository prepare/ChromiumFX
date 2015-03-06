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
    /// A request context provides request handling for a set of related browser
    /// objects. A request context is specified when creating a new browser object
    /// via the CfxBrowserHost static factory functions. Browser objects with
    /// different request contexts will never be hosted in the same render process.
    /// Browser objects with the same request context may or may not be hosted in the
    /// same render process depending on the process model. Browser objects created
    /// indirectly via the JavaScript window.open function or targeted links will
    /// share the same render process and the same request context as the source
    /// browser. When running in single-process mode there is only a single render
    /// process (the main process) and so all browsers created in single-process mode
    /// will share the same request context. This will be the first request context
    /// passed into a CfxBrowserHost static factory function and all other
    /// request context objects will be ignored.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
    /// </remarks>
    public class CfxRequestContext : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxRequestContext Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxRequestContext)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxRequestContext(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxRequestContext(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the global context object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
        /// </remarks>
        public static CfxRequestContext GetGlobalContext() {
            return CfxRequestContext.Wrap(CfxApi.cfx_request_context_get_global_context());
        }

        /// <summary>
        /// Creates a new context object with the specified handler.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
        /// </remarks>
        public static CfxRequestContext CreateContext(CfxRequestContextHandler handler) {
            return CfxRequestContext.Wrap(CfxApi.cfx_request_context_create_context(CfxRequestContextHandler.Unwrap(handler)));
        }

        /// <summary>
        /// Returns true (1) if this object is the global context.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
        /// </remarks>
        public bool IsGlobal {
            get {
                return 0 != CfxApi.cfx_request_context_is_global(NativePtr);
            }
        }

        /// <summary>
        /// Returns the handler for this context if any.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
        /// </remarks>
        public CfxRequestContextHandler Handler {
            get {
                return CfxRequestContextHandler.Wrap(CfxApi.cfx_request_context_get_handler(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same context as |that|
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_request_context_capi.h">cef/include/capi/cef_request_context_capi.h</see>.
        /// </remarks>
        public bool IsSame(CfxRequestContext other) {
            return 0 != CfxApi.cfx_request_context_is_same(NativePtr, CfxRequestContext.Unwrap(other));
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
