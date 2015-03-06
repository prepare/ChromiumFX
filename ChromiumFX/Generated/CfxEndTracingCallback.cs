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
    /// Implement this structure to receive notification when tracing has completed.
    /// The functions of this structure will be called on the browser process UI
    /// thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_trace_capi.h">cef/include/capi/cef_trace_capi.h</see>.
    /// </remarks>
    public class CfxEndTracingCallback : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxEndTracingCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxEndTracingCallback)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxEndTracingCallback(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxEndTracingCallback(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Called after all processes have sent their trace data. |tracingFile| is
        /// the path at which tracing data was written. The client is responsible for
        /// deleting |tracingFile|.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_trace_capi.h">cef/include/capi/cef_trace_capi.h</see>.
        /// </remarks>
        public void OnEndTracingComplete(string tracingFile) {
            var tracingFile_pinned = new PinnedString(tracingFile);
            CfxApi.cfx_end_tracing_callback_on_end_tracing_complete(NativePtr, tracingFile_pinned.Obj.PinnedPtr, tracingFile_pinned.Length);
            tracingFile_pinned.Obj.Free();
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
