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
        /// Creates a directory and all parent directories if they don't already exist.
        /// Returns true (1) on successful creation or if the directory already exists.
        /// The directory is only readable by the current user. Calling this function on
        /// the browser process UI or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool CreateDirectory(string fullPath) {
            var call = new CfxRuntimeCreateDirectoryRemoteCall();
            call.fullPath = fullPath;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Creates a new directory. On Windows if |prefix| is provided the new directory
        /// name is in the format of "prefixyyyy". Returns true (1) on success and sets
        /// |newTempPath| to the full path of the directory that was created. The
        /// directory is only readable by the current user. Calling this function on the
        /// browser process UI or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool CreateNewTempDirectory(string prefix, string newTempPath) {
            var call = new CfxRuntimeCreateNewTempDirectoryRemoteCall();
            call.prefix = prefix;
            call.RequestExecution();
            newTempPath = call.newTempPath;
            return call.__retval;
        }

        /// <summary>
        /// Creates a directory within another directory. Extra characters will be
        /// appended to |prefix| to ensure that the new directory does not have the same
        /// name as an existing directory. Returns true (1) on success and sets |newDir|
        /// to the full path of the directory that was created. The directory is only
        /// readable by the current user. Calling this function on the browser process UI
        /// or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool CreateTempDirectoryInDirectory(string baseDir, string prefix, string newDir) {
            var call = new CfxRuntimeCreateTempDirectoryInDirectoryRemoteCall();
            call.baseDir = baseDir;
            call.prefix = prefix;
            call.RequestExecution();
            newDir = call.newDir;
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if called on the specified thread. Equivalent to using
        /// CfrTaskRunner.GetForThread(threadId).BelongsToCurrentThread().
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public static bool CurrentlyOn(CfxThreadId threadId) {
            var call = new CfxRuntimeCurrentlyOnRemoteCall();
            call.threadId = (int)threadId;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Deletes the given path whether it's a file or a directory. If |path| is a
        /// directory all contents will be deleted.  If |recursive| is true (1) any sub-
        /// directories and their contents will also be deleted (equivalent to executing
        /// "rm -rf", so use with caution). On POSIX environments if |path| is a symbolic
        /// link then only the symlink will be deleted. Returns true (1) on successful
        /// deletion or if |path| does not exist. Calling this function on the browser
        /// process UI or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool DeleteFile(string path, bool recursive) {
            var call = new CfxRuntimeDeleteFileRemoteCall();
            call.path = path;
            call.recursive = recursive;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the given path exists and is a directory. Calling this
        /// function on the browser process UI or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool DirectoryExists(string path) {
            var call = new CfxRuntimeDirectoryExistsRemoteCall();
            call.path = path;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// This is a convenience function for formatting a URL in a concise and human-
        /// friendly way to help users make security-related decisions (or in other
        /// circumstances when people need to distinguish sites, origins, or otherwise-
        /// simplified URLs from each other). Internationalized domain names (IDN) may be
        /// presented in Unicode if the conversion is considered safe. The returned value
        /// will (a) omit the path for standard schemes, excepting file and filesystem,
        /// and (b) omit the port if it is the default for the scheme. Do not use this
        /// for URLs which will be parsed or sent to other applications.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_parser_capi.h">cef/include/capi/cef_parser_capi.h</see>.
        /// </remarks>
        public static string FormatUrlForSecurityDisplay(string originUrl) {
            var call = new CfxRuntimeFormatUrlForSecurityDisplayRemoteCall();
            call.originUrl = originUrl;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Get the temporary directory provided by the system.
        /// WARNING: In general, you should use the temp directory variants below instead
        /// of this function. Those variants will ensure that the proper permissions are
        /// set so that other users on the system can't edit them while they're open
        /// (which could lead to security issues).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool GetTempDirectory(string tempDir) {
            var call = new CfxRuntimeGetTempDirectoryRemoteCall();
            call.RequestExecution();
            tempDir = call.tempDir;
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the certificate status has any error, major or minor.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_info_capi.h">cef/include/capi/cef_ssl_info_capi.h</see>.
        /// </remarks>
        public static bool IsCertStatusError(CfxCertStatus status) {
            var call = new CfxRuntimeIsCertStatusErrorRemoteCall();
            call.status = (int)status;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the certificate status represents only minor errors (e.g.
        /// failure to verify certificate revocation).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_info_capi.h">cef/include/capi/cef_ssl_info_capi.h</see>.
        /// </remarks>
        public static bool IsCertStatusMinorError(CfxCertStatus status) {
            var call = new CfxRuntimeIsCertStatusMinorErrorRemoteCall();
            call.status = (int)status;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Post a task for delayed execution on the specified thread. Equivalent to
        /// using CfrTaskRunner.GetForThread(threadId).PostDelayedTask(task,
        /// delay_ms).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public static bool PostDelayedTask(CfxThreadId threadId, CfrTask task, long delayMs) {
            var call = new CfxRuntimePostDelayedTaskRemoteCall();
            call.threadId = (int)threadId;
            call.task = CfrObject.Unwrap(task).ptr;
            call.delayMs = delayMs;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Post a task for execution on the specified thread. Equivalent to using
        /// CfrTaskRunner.GetForThread(threadId).PostTask(task).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_task_capi.h">cef/include/capi/cef_task_capi.h</see>.
        /// </remarks>
        public static bool PostTask(CfxThreadId threadId, CfrTask task) {
            var call = new CfxRuntimePostTaskRemoteCall();
            call.threadId = (int)threadId;
            call.task = CfrObject.Unwrap(task).ptr;
            call.RequestExecution();
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
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static bool RegisterExtension(string extensionName, string javascriptCode, CfrV8Handler handler) {
            var call = new CfxRuntimeRegisterExtensionRemoteCall();
            call.extensionName = extensionName;
            call.javascriptCode = javascriptCode;
            call.handler = CfrObject.Unwrap(handler).ptr;
            call.RequestExecution();
            return call.__retval;
        }

        /// <summary>
        /// Writes the contents of |srcDir| into a zip archive at |destFile|. If
        /// |includeHiddenFiles| is true (1) files starting with "." will be included.
        /// Returns true (1) on success.  Calling this function on the browser process UI
        /// or IO threads is not allowed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_file_util_capi.h">cef/include/capi/cef_file_util_capi.h</see>.
        /// </remarks>
        public static bool ZipDirectory(string srcDir, string destFile, bool includeHiddenFiles) {
            var call = new CfxRuntimeZipDirectoryRemoteCall();
            call.srcDir = srcDir;
            call.destFile = destFile;
            call.includeHiddenFiles = includeHiddenFiles;
            call.RequestExecution();
            return call.__retval;
        }

    }
}
