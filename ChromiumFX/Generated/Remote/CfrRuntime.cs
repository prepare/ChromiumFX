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
    public partial class CfrRuntime {

        /// <summary>
        /// Add an entry to the cross-origin access whitelist.
        /// The same-origin policy restricts how scripts hosted from different origins
        /// (scheme + domain + port) can communicate. By default, scripts can only access
        /// resources with the same origin. Scripts hosted on the HTTP and HTTPS schemes
        /// (but no other schemes) can use the "Access-Control-Allow-Origin" header to
        /// allow cross-origin requests. For example, https://source.example.com can make
        /// XMLHttpRequest requests on http://target.example.com if the
        /// http://target.example.com request returns an "Access-Control-Allow-Origin:
        /// https://source.example.com" response header.
        /// Scripts in separate frames or iframes and hosted from the same protocol and
        /// domain suffix can execute cross-origin JavaScript if both pages set the
        /// document.domain value to the same domain suffix. For example,
        /// scheme://foo.example.com and scheme://bar.example.com can communicate using
        /// JavaScript if both domains set document.domain="example.com".
        /// This function is used to allow access to origins that would otherwise violate
        /// the same-origin policy. Scripts hosted underneath the fully qualified
        /// |sourceOrigin| URL (like http://www.example.com) will be allowed access to
        /// all resources hosted on the specified |targetProtocol| and |targetDomain|.
        /// If |targetDomain| is non-NULL and |allowTargetSubdomains| if false (0)
        /// only exact domain matches will be allowed. If |targetDomain| contains a top-
        /// level domain component (like "example.com") and |allowTargetSubdomains| is
        /// true (1) sub-domain matches will be allowed. If |targetDomain| is NULL and
        /// |allowTargetSubdomains| if true (1) all domains and IP addresses will be
        /// allowed.
        /// This function cannot be used to bypass the restrictions on local or display
        /// isolated schemes. See the comments on CfrRegisterCustomScheme for more
        /// information.
        /// This function may be called on any thread. Returns false (0) if
        /// |sourceOrigin| is invalid or the whitelist cannot be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_origin_whitelist_capi.h">cef/include/capi/cef_origin_whitelist_capi.h</see>.
        /// </remarks>
        public bool AddCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains) {
            var call = new CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall();
            call.sourceOrigin = sourceOrigin;
            call.targetProtocol = targetProtocol;
            call.targetDomain = targetDomain;
            call.allowTargetSubdomains = allowTargetSubdomains;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Remove all entries from the cross-origin access whitelist. Returns false (0)
        /// if the whitelist cannot be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_origin_whitelist_capi.h">cef/include/capi/cef_origin_whitelist_capi.h</see>.
        /// </remarks>
        public bool ClearCrossOriginWhitelist() {
            var call = new CfxRuntimeClearCrossOriginWhitelistRenderProcessCall();
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Creates a URL from the specified |parts|, which must contain a non-NULL spec
        /// or a non-NULL host and path (at a minimum), but not both. Returns false (0)
        /// if |parts| isn't initialized as described.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_url_capi.h">cef/include/capi/cef_url_capi.h</see>.
        /// </remarks>
        public bool CreateUrl(CfrUrlParts parts, string url) {
            var call = new CfxRuntimeCreateUrlRenderProcessCall();
            call.parts = CfrObject.Unwrap(parts);
            call.url = url;
            call.Execute(connection);
            url = call.url;
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if called on the specified thread. Equivalent to using
        /// cef_task_tRunner::GetForThread(threadId)->belongs_to_current_thread().
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public bool CurrentlyOn(CfxThreadId threadId) {
            var call = new CfxRuntimeCurrentlyOnRenderProcessCall();
            call.threadId = (int)threadId;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Get the extensions associated with the given mime type. This should be passed
        /// in lower case. There could be multiple extensions for a given mime type, like
        /// "html,htm" for "text/html", or "txt,text,html,..." for "text/*". Any existing
        /// elements in the provided vector will not be erased.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_url_capi.h">cef/include/capi/cef_url_capi.h</see>.
        /// </remarks>
        public void GetExtensionsForMimeType(string mimeType, System.Collections.Generic.List<string> extensions) {
            var call = new CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall();
            call.mimeType = mimeType;
            call.extensions = extensions;
            call.Execute(connection);
        }

        /// <summary>
        /// Request a one-time geolocation update. This function bypasses any user
        /// permission checks so should only be used by code that is allowed to access
        /// location information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_geolocation_capi.h">cef/include/capi/cef_geolocation_capi.h</see>.
        /// </remarks>
        public int GetGeolocation(CfrGetGeolocationCallback callback) {
            var call = new CfxRuntimeGetGeolocationRenderProcessCall();
            call.callback = CfrObject.Unwrap(callback);
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the mime type for the specified file extension or an NULL string if
        /// unknown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_url_capi.h">cef/include/capi/cef_url_capi.h</see>.
        /// </remarks>
        public String GetMimeType(string extension) {
            var call = new CfxRuntimeGetMimeTypeRenderProcessCall();
            call.extension = extension;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the current system trace time or, if none is defined, the current
        /// high-res time. Can be used by clients to synchronize with the time
        /// information in trace events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_trace_capi.h">cef/include/capi/cef_trace_capi.h</see>.
        /// </remarks>
        public long NowFromSystemTraceTime() {
            var call = new CfxRuntimeNowFromSystemTraceTimeRenderProcessCall();
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Parse the specified |url| into its component parts. Returns false (0) if the
        /// URL is NULL or invalid.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_url_capi.h">cef/include/capi/cef_url_capi.h</see>.
        /// </remarks>
        public bool ParseUrl(string url, CfrUrlParts parts) {
            var call = new CfxRuntimeParseUrlRenderProcessCall();
            call.url = url;
            call.parts = CfrObject.Unwrap(parts);
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Post a task for delayed execution on the specified thread. Equivalent to
        /// using cef_task_tRunner::GetForThread(threadId)->PostDelayedTask(task,
        /// delay_ms).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public int PostDelayedTask(CfxThreadId threadId, CfrTask task, long delayMs) {
            var call = new CfxRuntimePostDelayedTaskRenderProcessCall();
            call.threadId = (int)threadId;
            call.task = CfrObject.Unwrap(task);
            call.delayMs = delayMs;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Post a task for execution on the specified thread. Equivalent to using
        /// cef_task_tRunner::GetForThread(threadId)->PostTask(task).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public int PostTask(CfxThreadId threadId, CfrTask task) {
            var call = new CfxRuntimePostTaskRenderProcessCall();
            call.threadId = (int)threadId;
            call.task = CfrObject.Unwrap(task);
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Register a new V8 extension with the specified JavaScript extension code and
        /// handler. Functions implemented by the handler are prototyped using the
        /// keyword 'native'. The calling of a native function is restricted to the scope
        /// in which the prototype of the native function is defined. This function may
        /// only be called on the render process main thread.
        /// Example JavaScript extension code: &lt;pre>
        /// // create the 'example' global object if it doesn't already exist.
        /// if (!example)
        /// example = {};
        /// // create the 'example.test' global object if it doesn't already exist.
        /// if (!example.test)
        /// example.test = {};
        /// (function() {
        /// // Define the function 'example.test.myfunction'.
        /// example.test.myfunction = function() {
        /// // Call CfrV8Handler.Execute() with the function name 'MyFunction'
        /// // and no arguments.
        /// native function MyFunction();
        /// return MyFunction();
        /// };
        /// // Define the getter function for parameter 'example.test.myparam'.
        /// example.test.__defineGetter__('myparam', function() {
        /// // Call CfrV8Handler.Execute() with the function name 'GetMyParam'
        /// // and no arguments.
        /// native function GetMyParam();
        /// return GetMyParam();
        /// });
        /// // Define the setter function for parameter 'example.test.myparam'.
        /// example.test.__defineSetter__('myparam', function(b) {
        /// // Call CfrV8Handler.Execute() with the function name 'SetMyParam'
        /// // and a single argument.
        /// native function SetMyParam();
        /// if(b) SetMyParam(b);
        /// });
        /// // Extension definitions can also contain normal JavaScript variables
        /// // and functions.
        /// var myint = 0;
        /// example.test.increment = function() {
        /// myint += 1;
        /// return myint;
        /// };
        /// })();
        /// &lt;/pre> Example usage in the page: &lt;pre>
        /// // Call the function.
        /// example.test.myfunction();
        /// // Set the parameter.
        /// example.test.myparam = value;
        /// // Get the parameter.
        /// value = example.test.myparam;
        /// // Call another function.
        /// example.test.increment();
        /// &lt;/pre>
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int RegisterExtension(string extensionName, string javascriptCode, CfrV8Handler handler) {
            var call = new CfxRuntimeRegisterExtensionRenderProcessCall();
            call.extensionName = extensionName;
            call.javascriptCode = javascriptCode;
            call.handler = CfrObject.Unwrap(handler);
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Remove an entry from the cross-origin access whitelist. Returns false (0) if
        /// |sourceOrigin| is invalid or the whitelist cannot be accessed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_origin_whitelist_capi.h">cef/include/capi/cef_origin_whitelist_capi.h</see>.
        /// </remarks>
        public bool RemoveCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains) {
            var call = new CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall();
            call.sourceOrigin = sourceOrigin;
            call.targetProtocol = targetProtocol;
            call.targetDomain = targetDomain;
            call.allowTargetSubdomains = allowTargetSubdomains;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Set to true (1) before calling Windows APIs like TrackPopupMenu that enter a
        /// modal message loop. Set to false (0) after exiting the modal message loop.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_app_capi.h">cef/include/capi/cef_app_capi.h</see>.
        /// </remarks>
        public void SetOsModalLoop(int osModalLoop) {
            var call = new CfxRuntimeSetOsModalLoopRenderProcessCall();
            call.osModalLoop = osModalLoop;
            call.Execute(connection);
        }

    }
}
