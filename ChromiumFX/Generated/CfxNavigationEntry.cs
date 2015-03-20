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
    /// Structure used to represent an entry in navigation history.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
    /// </remarks>
    public class CfxNavigationEntry : CfxBase {

        static CfxNavigationEntry () {
            CfxApi.cfx_navigation_entry_is_valid = (CfxApi.cfx_navigation_entry_is_valid_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_is_valid", typeof(CfxApi.cfx_navigation_entry_is_valid_delegate));
            CfxApi.cfx_navigation_entry_get_url = (CfxApi.cfx_navigation_entry_get_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_url", typeof(CfxApi.cfx_navigation_entry_get_url_delegate));
            CfxApi.cfx_navigation_entry_get_display_url = (CfxApi.cfx_navigation_entry_get_display_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_display_url", typeof(CfxApi.cfx_navigation_entry_get_display_url_delegate));
            CfxApi.cfx_navigation_entry_get_original_url = (CfxApi.cfx_navigation_entry_get_original_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_original_url", typeof(CfxApi.cfx_navigation_entry_get_original_url_delegate));
            CfxApi.cfx_navigation_entry_get_title = (CfxApi.cfx_navigation_entry_get_title_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_title", typeof(CfxApi.cfx_navigation_entry_get_title_delegate));
            CfxApi.cfx_navigation_entry_get_transition_type = (CfxApi.cfx_navigation_entry_get_transition_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_transition_type", typeof(CfxApi.cfx_navigation_entry_get_transition_type_delegate));
            CfxApi.cfx_navigation_entry_has_post_data = (CfxApi.cfx_navigation_entry_has_post_data_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_has_post_data", typeof(CfxApi.cfx_navigation_entry_has_post_data_delegate));
            CfxApi.cfx_navigation_entry_get_frame_name = (CfxApi.cfx_navigation_entry_get_frame_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_frame_name", typeof(CfxApi.cfx_navigation_entry_get_frame_name_delegate));
            CfxApi.cfx_navigation_entry_get_completion_time = (CfxApi.cfx_navigation_entry_get_completion_time_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_completion_time", typeof(CfxApi.cfx_navigation_entry_get_completion_time_delegate));
            CfxApi.cfx_navigation_entry_get_http_status_code = (CfxApi.cfx_navigation_entry_get_http_status_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_navigation_entry_get_http_status_code", typeof(CfxApi.cfx_navigation_entry_get_http_status_code_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxNavigationEntry Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxNavigationEntry)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxNavigationEntry(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxNavigationEntry(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_navigation_entry_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use get_display_url() to return a display-friendly version.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public string Url {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_navigation_entry_get_url(NativePtr));
            }
        }

        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public string DisplayUrl {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_navigation_entry_get_display_url(NativePtr));
            }
        }

        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public string OriginalUrl {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_navigation_entry_get_original_url(NativePtr));
            }
        }

        /// <summary>
        /// Returns the title set by the page. This value may be NULL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public string Title {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_navigation_entry_get_title(NativePtr));
            }
        }

        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public CfxTransitionType TransitionType {
            get {
                return CfxApi.cfx_navigation_entry_get_transition_type(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this navigation includes post data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public bool HasPostData {
            get {
                return 0 != CfxApi.cfx_navigation_entry_has_post_data(NativePtr);
            }
        }

        /// <summary>
        /// Returns the name of the sub-frame that navigated or an NULL value if the
        /// main frame navigated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public string FrameName {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_navigation_entry_get_frame_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public CfxTime CompletionTime {
            get {
                return CfxTime.WrapOwned(CfxApi.cfx_navigation_entry_get_completion_time(NativePtr));
            }
        }

        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_navigation_entry_capi.h">cef/include/capi/cef_navigation_entry_capi.h</see>.
        /// </remarks>
        public int HttpStatusCode {
            get {
                return CfxApi.cfx_navigation_entry_get_http_status_code(NativePtr);
            }
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
