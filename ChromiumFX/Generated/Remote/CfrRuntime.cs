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
        /// |source_origin| URL (like http://www.example.com) will be allowed access to
        /// all resources hosted on the specified |target_protocol| and |target_domain|.
        /// If |target_domain| is non-NULL and |allow_target_subdomains| if false (0)
        /// only exact domain matches will be allowed. If |target_domain| contains a top-
        /// level domain component (like "example.com") and |allow_target_subdomains| is
        /// true (1) sub-domain matches will be allowed. If |target_domain| is NULL and
        /// |allow_target_subdomains| if true (1) all domains and IP addresses will be
        /// allowed.
        /// This function cannot be used to bypass the restrictions on local or display
        /// isolated schemes. See the comments on CefRegisterCustomScheme for more
        /// information.
        /// This function may be called on any thread. Returns false (0) if
        /// |source_origin| is invalid or the whitelist cannot be accessed.
        /// </summary>
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
        /// cef_task_runner_t::GetForThread(threadId)->belongs_to_current_thread().
        /// </summary>
        public bool CurrentlyOn(CfxThreadId threadId) {
            var call = new CfxRuntimeCurrentlyOnRenderProcessCall();
            call.threadId = (int)threadId;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// This function should be called from the application entry point function to
        /// execute a secondary process. It can be used to run secondary processes from
        /// the browser client executable (default behavior) or from a separate
        /// executable specified by the CefSettings.browser_subprocess_path value. If
        /// called for the browser process (identified by no "type" command-line value)
        /// it will return immediately with a value of -1. If called for a recognized
        /// secondary process it will block until the process should exit and then return
        /// the process exit code. The |application| parameter may be NULL. The
        /// |windows_sandbox_info| parameter is only used on Windows and may be NULL (see
        /// cef_sandbox_win.h for details).
        /// </summary>
        public int ExecuteProcess(CfrApp application, RemotePtr windowsSandboxInfo) {
            var call = new CfxRuntimeExecuteProcessRenderProcessCall();
            call.application = CfrObject.Unwrap(application);
            call.windowsSandboxInfo = windowsSandboxInfo.ptr;
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Request a one-time geolocation update. This function bypasses any user
        /// permission checks so should only be used by code that is allowed to access
        /// location information.
        /// </summary>
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
        public long NowFromSystemTraceTime() {
            var call = new CfxRuntimeNowFromSystemTraceTimeRenderProcessCall();
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Parse the specified |url| into its component parts. Returns false (0) if the
        /// URL is NULL or invalid.
        /// </summary>
        public bool ParseUrl(string url, CfrUrlParts parts) {
            var call = new CfxRuntimeParseUrlRenderProcessCall();
            call.url = url;
            call.parts = CfrObject.Unwrap(parts);
            call.Execute(connection);
            return call.__retval;
        }

        /// <summary>
        /// Post a task for delayed execution on the specified thread. Equivalent to
        /// using cef_task_runner_t::GetForThread(threadId)->PostDelayedTask(task,
        /// delay_ms).
        /// </summary>
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
        /// cef_task_runner_t::GetForThread(threadId)->PostTask(task).
        /// </summary>
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
        /// // Call CefV8Handler::Execute() with the function name 'MyFunction'
        /// // and no arguments.
        /// native function MyFunction();
        /// return MyFunction();
        /// };
        /// // Define the getter function for parameter 'example.test.myparam'.
        /// example.test.__defineGetter__('myparam', function() {
        /// // Call CefV8Handler::Execute() with the function name 'GetMyParam'
        /// // and no arguments.
        /// native function GetMyParam();
        /// return GetMyParam();
        /// });
        /// // Define the setter function for parameter 'example.test.myparam'.
        /// example.test.__defineSetter__('myparam', function(b) {
        /// // Call CefV8Handler::Execute() with the function name 'SetMyParam'
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
        /// |source_origin| is invalid or the whitelist cannot be accessed.
        /// </summary>
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
        public void SetOsModalLoop(int osModalLoop) {
            var call = new CfxRuntimeSetOsModalLoopRenderProcessCall();
            call.osModalLoop = osModalLoop;
            call.Execute(connection);
        }

    }
}
