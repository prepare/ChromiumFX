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
    /// Structure used for managing cookies. The functions of this structure may be
    /// called on any thread unless otherwise indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
    /// </remarks>
    public class CfxCookieManager : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxCookieManager Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxCookieManager)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxCookieManager(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxCookieManager(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the global cookie manager. By default data will be stored at
        /// CfxSettings.CachePath if specified or in memory otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public static CfxCookieManager GetGlobalManager() {
            return CfxCookieManager.Wrap(CfxApi.cfx_cookie_manager_get_global_manager());
        }

        /// <summary>
        /// Creates a new cookie manager. If |path| is NULL data will be stored in memory
        /// only. Otherwise, data will be stored at the specified |path|. To persist
        /// session cookies (cookies without an expiry date or validity interval) set
        /// |persistSessionCookies| to true (1). Session cookies are generally intended
        /// to be transient and most Web browsers do not persist them. Returns NULL if
        /// creation fails.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public static CfxCookieManager CreateManager(string path, bool persistSessionCookies) {
            var path_pinned = new PinnedString(path);
            var __retval = CfxApi.cfx_cookie_manager_create_manager(path_pinned.Obj.PinnedPtr, path_pinned.Length, persistSessionCookies ? 1 : 0);
            path_pinned.Obj.Free();
            return CfxCookieManager.Wrap(__retval);
        }

        /// <summary>
        /// Set the schemes supported by this manager. By default only "http" and
        /// "https" schemes are supported. Must be called before any cookies are
        /// accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public void SetSupportedSchemes(System.Collections.Generic.List<string> schemes) {
            PinnedString[] schemes_handles;
            var schemes_unwrapped = CfxStringCollections.UnwrapCfxStringList(schemes, out schemes_handles);
            CfxApi.cfx_cookie_manager_set_supported_schemes(NativePtr, schemes_unwrapped);
            CfxStringCollections.FreePinnedStrings(schemes_handles);
            CfxStringCollections.CfxStringListCopyToManaged(schemes_unwrapped, schemes);
            CfxApi.cfx_string_list_free(schemes_unwrapped);
        }

        /// <summary>
        /// Visit all cookies. The returned cookies are ordered by longest path, then
        /// by earliest creation date. Returns false (0) if cookies cannot be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool VisitAllCookies(CfxCookieVisitor visitor) {
            return 0 != CfxApi.cfx_cookie_manager_visit_all_cookies(NativePtr, CfxCookieVisitor.Unwrap(visitor));
        }

        /// <summary>
        /// Visit a subset of cookies. The results are filtered by the given url
        /// scheme, host, domain and path. If |includeHttpOnly| is true (1) HTTP-only
        /// cookies will also be included in the results. The returned cookies are
        /// ordered by longest path, then by earliest creation date. Returns false (0)
        /// if cookies cannot be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool VisitUrlCookies(string url, bool includeHttpOnly, CfxCookieVisitor visitor) {
            var url_pinned = new PinnedString(url);
            var __retval = CfxApi.cfx_cookie_manager_visit_url_cookies(NativePtr, url_pinned.Obj.PinnedPtr, url_pinned.Length, includeHttpOnly ? 1 : 0, CfxCookieVisitor.Unwrap(visitor));
            url_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Sets a cookie given a valid URL and explicit user-provided cookie
        /// attributes. This function expects each attribute to be well-formed. It will
        /// check for disallowed characters (e.g. the ';' character is disallowed
        /// within the cookie value attribute) and will return false (0) without
        /// setting the cookie if such characters are found. This function must be
        /// called on the IO thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool SetCookie(string url, CfxCookie cookie) {
            var url_pinned = new PinnedString(url);
            var __retval = CfxApi.cfx_cookie_manager_set_cookie(NativePtr, url_pinned.Obj.PinnedPtr, url_pinned.Length, CfxCookie.Unwrap(cookie));
            url_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Delete all cookies that match the specified parameters. If both |url| and
        /// values |cookieName| are specified all host and domain cookies matching
        /// both will be deleted. If only |url| is specified all host cookies (but not
        /// domain cookies) irrespective of path will be deleted. If |url| is NULL all
        /// cookies for all hosts and domains will be deleted. Returns false (0) if a
        /// non- NULL invalid URL is specified or if cookies cannot be accessed. This
        /// function must be called on the IO thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool DeleteCookies(string url, string cookieName) {
            var url_pinned = new PinnedString(url);
            var cookieName_pinned = new PinnedString(cookieName);
            var __retval = CfxApi.cfx_cookie_manager_delete_cookies(NativePtr, url_pinned.Obj.PinnedPtr, url_pinned.Length, cookieName_pinned.Obj.PinnedPtr, cookieName_pinned.Length);
            url_pinned.Obj.Free();
            cookieName_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Sets the directory path that will be used for storing cookie data. If
        /// |path| is NULL data will be stored in memory only. Otherwise, data will be
        /// stored at the specified |path|. To persist session cookies (cookies without
        /// an expiry date or validity interval) set |persistSessionCookies| to true
        /// (1). Session cookies are generally intended to be transient and most Web
        /// browsers do not persist them. Returns false (0) if cookies cannot be
        /// accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool SetStoragePath(string path, bool persistSessionCookies) {
            var path_pinned = new PinnedString(path);
            var __retval = CfxApi.cfx_cookie_manager_set_storage_path(NativePtr, path_pinned.Obj.PinnedPtr, path_pinned.Length, persistSessionCookies ? 1 : 0);
            path_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Flush the backing store (if any) to disk and execute the specified
        /// |callback| on the IO thread when done. Returns false (0) if cookies cannot
        /// be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public bool FlushStore(CfxCompletionCallback callback) {
            return 0 != CfxApi.cfx_cookie_manager_flush_store(NativePtr, CfxCompletionCallback.Unwrap(callback));
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
