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
    /// Initialization settings. Specify NULL or 0 to get the recommended default
    /// values. Many of these and other settings can also configured using command-
    /// line switches.
    /// </summary>
    public sealed class CfxSettings : CfxStructure {

        private bool m_SingleProcess;
        private bool m_NoSandbox;
        private string m_BrowserSubprocessPath;
        private bool m_MultiThreadedMessageLoop;
        private bool m_WindowlessRenderingEnabled;
        private bool m_CommandLineArgsDisabled;
        private string m_CachePath;
        private bool m_PersistSessionCookies;
        private string m_UserAgent;
        private string m_ProductVersion;
        private string m_Locale;
        private string m_LogFile;
        private CfxLogSeverity m_LogSeverity;
        private string m_JavascriptFlags;
        private string m_ResourcesDirPath;
        private string m_LocalesDirPath;
        private bool m_PackLoadingDisabled;
        private int m_RemoteDebuggingPort;
        private int m_UncaughtExceptionStackSize;
        private bool m_ContextSafetyImplementation;
        private bool m_IgnoreCertificateErrors;
        private CfxColor m_BackgroundColor;

        public CfxSettings() : base(CfxApi.cfx_settings_ctor, CfxApi.cfx_settings_dtor) {}

        /// <summary>
        /// Set to true (1) to use a single process for the browser and renderer. This
        /// run mode is not officially supported by Chromium and is less stable than
        /// the multi-process default. Also configurable using the "single-process"
        /// command-line switch.
        /// </summary>
        public bool SingleProcess {
            get {
                return m_SingleProcess;
            }
            set {
                m_SingleProcess = value;
            }
        }

        /// <summary>
        /// Set to true (1) to disable the sandbox for sub-processes. See
        /// cef_sandbox_win.h for requirements to enable the sandbox on Windows. Also
        /// configurable using the "no-sandbox" command-line switch.
        /// </summary>
        public bool NoSandbox {
            get {
                return m_NoSandbox;
            }
            set {
                m_NoSandbox = value;
            }
        }

        /// <summary>
        /// The path to a separate executable that will be launched for sub-processes.
        /// By default the browser process executable is used. See the comments on
        /// CefExecuteProcess() for details. Also configurable using the
        /// "browser-subprocess-path" command-line switch.
        /// </summary>
        public string BrowserSubprocessPath {
            get {
                return m_BrowserSubprocessPath;
            }
            set {
                m_BrowserSubprocessPath = value;
            }
        }

        /// <summary>
        /// Set to true (1) to have the browser process message loop run in a separate
        /// thread. If false (0) than the CefDoMessageLoopWork() function must be
        /// called from your application message loop.
        /// </summary>
        public bool MultiThreadedMessageLoop {
            get {
                return m_MultiThreadedMessageLoop;
            }
            set {
                m_MultiThreadedMessageLoop = value;
            }
        }

        /// <summary>
        /// Set to true (1) to enable windowless (off-screen) rendering support. Do not
        /// enable this value if the application does not use windowless rendering as
        /// it may reduce rendering performance on some systems.
        /// </summary>
        public bool WindowlessRenderingEnabled {
            get {
                return m_WindowlessRenderingEnabled;
            }
            set {
                m_WindowlessRenderingEnabled = value;
            }
        }

        /// <summary>
        /// Set to true (1) to disable configuration of browser process features using
        /// standard CEF and Chromium command-line arguments. Configuration can still
        /// be specified using CEF data structures or via the
        /// CefApp::OnBeforeCommandLineProcessing() method.
        /// </summary>
        public bool CommandLineArgsDisabled {
            get {
                return m_CommandLineArgsDisabled;
            }
            set {
                m_CommandLineArgsDisabled = value;
            }
        }

        /// <summary>
        /// The location where cache data will be stored on disk. If empty an in-memory
        /// cache will be used for some features and a temporary disk cache for others.
        /// HTML5 databases such as localStorage will only persist across sessions if a
        /// cache path is specified.
        /// </summary>
        public string CachePath {
            get {
                return m_CachePath;
            }
            set {
                m_CachePath = value;
            }
        }

        /// <summary>
        /// To persist session cookies (cookies without an expiry date or validity
        /// interval) by default when using the global cookie manager set this value to
        /// true. Session cookies are generally intended to be transient and most Web
        /// browsers do not persist them. A |cache_path| value must also be specified to
        /// enable this feature. Also configurable using the "persist-session-cookies"
        /// command-line switch.
        /// </summary>
        public bool PersistSessionCookies {
            get {
                return m_PersistSessionCookies;
            }
            set {
                m_PersistSessionCookies = value;
            }
        }

        /// <summary>
        /// Value that will be returned as the User-Agent HTTP header. If empty the
        /// default User-Agent string will be used. Also configurable using the
        /// "user-agent" command-line switch.
        /// </summary>
        public string UserAgent {
            get {
                return m_UserAgent;
            }
            set {
                m_UserAgent = value;
            }
        }

        /// <summary>
        /// Value that will be inserted as the product portion of the default
        /// User-Agent string. If empty the Chromium product version will be used. If
        /// |userAgent| is specified this value will be ignored. Also configurable
        /// using the "product-version" command-line switch.
        /// </summary>
        public string ProductVersion {
            get {
                return m_ProductVersion;
            }
            set {
                m_ProductVersion = value;
            }
        }

        /// <summary>
        /// The locale string that will be passed to WebKit. If empty the default
        /// locale of "en-US" will be used. This value is ignored on Linux where locale
        /// is determined using environment variable parsing with the precedence order:
        /// LANGUAGE, LC_ALL, LC_MESSAGES and LANG. Also configurable using the "lang"
        /// command-line switch.
        /// </summary>
        public string Locale {
            get {
                return m_Locale;
            }
            set {
                m_Locale = value;
            }
        }

        /// <summary>
        /// The directory and file name to use for the debug log. If empty, the
        /// default name of "debug.log" will be used and the file will be written
        /// to the application directory. Also configurable using the "log-file"
        /// command-line switch.
        /// </summary>
        public string LogFile {
            get {
                return m_LogFile;
            }
            set {
                m_LogFile = value;
            }
        }

        /// <summary>
        /// The log severity. Only messages of this severity level or higher will be
        /// logged. Also configurable using the "log-severity" command-line switch with
        /// a value of "verbose", "info", "warning", "error", "error-report" or
        /// "disable".
        /// </summary>
        public CfxLogSeverity LogSeverity {
            get {
                return m_LogSeverity;
            }
            set {
                m_LogSeverity = value;
            }
        }

        /// <summary>
        /// Custom flags that will be used when initializing the V8 JavaScript engine.
        /// The consequences of using custom flags may not be well tested. Also
        /// configurable using the "js-flags" command-line switch.
        /// </summary>
        public string JavascriptFlags {
            get {
                return m_JavascriptFlags;
            }
            set {
                m_JavascriptFlags = value;
            }
        }

        /// <summary>
        /// The fully qualified path for the resources directory. If this value is
        /// empty the cef.pak and/or devtools_resources.pak files must be located in
        /// the module directory on Windows/Linux or the app bundle Resources directory
        /// on Mac OS X. Also configurable using the "resources-dir-path" command-line
        /// switch.
        /// </summary>
        public string ResourcesDirPath {
            get {
                return m_ResourcesDirPath;
            }
            set {
                m_ResourcesDirPath = value;
            }
        }

        /// <summary>
        /// The fully qualified path for the locales directory. If this value is empty
        /// the locales directory must be located in the module directory. This value
        /// is ignored on Mac OS X where pack files are always loaded from the app
        /// bundle Resources directory. Also configurable using the "locales-dir-path"
        /// command-line switch.
        /// </summary>
        public string LocalesDirPath {
            get {
                return m_LocalesDirPath;
            }
            set {
                m_LocalesDirPath = value;
            }
        }

        /// <summary>
        /// Set to true (1) to disable loading of pack files for resources and locales.
        /// A resource bundle handler must be provided for the browser and render
        /// processes via CefApp::GetResourceBundleHandler() if loading of pack files
        /// is disabled. Also configurable using the "disable-pack-loading" command-
        /// line switch.
        /// </summary>
        public bool PackLoadingDisabled {
            get {
                return m_PackLoadingDisabled;
            }
            set {
                m_PackLoadingDisabled = value;
            }
        }

        /// <summary>
        /// Set to a value between 1024 and 65535 to enable remote debugging on the
        /// specified port. For example, if 8080 is specified the remote debugging URL
        /// will be http://localhost:8080. CEF can be remotely debugged from any CEF or
        /// Chrome browser window. Also configurable using the "remote-debugging-port"
        /// command-line switch.
        /// </summary>
        public int RemoteDebuggingPort {
            get {
                return m_RemoteDebuggingPort;
            }
            set {
                m_RemoteDebuggingPort = value;
            }
        }

        /// <summary>
        /// The number of stack trace frames to capture for uncaught exceptions.
        /// Specify a positive value to enable the CefV8ContextHandler::
        /// OnUncaughtException() callback. Specify 0 (default value) and
        /// OnUncaughtException() will not be called. Also configurable using the
        /// "uncaught-exception-stack-size" command-line switch.
        /// </summary>
        public int UncaughtExceptionStackSize {
            get {
                return m_UncaughtExceptionStackSize;
            }
            set {
                m_UncaughtExceptionStackSize = value;
            }
        }

        /// <summary>
        /// By default CEF V8 references will be invalidated (the IsValid() method will
        /// return false) after the owning context has been released. This reduces the
        /// need for external record keeping and avoids crashes due to the use of V8
        /// references after the associated context has been released.
        /// CEF currently offers two context safety implementations with different
        /// performance characteristics. The default implementation (value of 0) uses a
        /// map of hash values and should provide better performance in situations with
        /// a small number contexts. The alternate implementation (value of 1) uses a
        /// hidden value attached to each context and should provide better performance
        /// in situations with a large number of contexts.
        /// If you need better performance in the creation of V8 references and you
        /// plan to manually track context lifespan you can disable context safety by
        /// specifying a value of -1.
        /// Also configurable using the "context-safety-implementation" command-line
        /// switch.
        /// </summary>
        public bool ContextSafetyImplementation {
            get {
                return m_ContextSafetyImplementation;
            }
            set {
                m_ContextSafetyImplementation = value;
            }
        }

        /// <summary>
        /// Set to true (1) to ignore errors related to invalid SSL certificates.
        /// Enabling this setting can lead to potential security vulnerabilities like
        /// "man in the middle" attacks. Applications that load content from the
        /// internet should not enable this setting. Also configurable using the
        /// "ignore-certificate-errors" command-line switch.
        /// </summary>
        public bool IgnoreCertificateErrors {
            get {
                return m_IgnoreCertificateErrors;
            }
            set {
                m_IgnoreCertificateErrors = value;
            }
        }

        /// <summary>
        /// Opaque background color used for accelerated content. By default the
        /// background color will be white. Only the RGB compontents of the specified
        /// value will be used. The alpha component must greater than 0 to enable use
        /// of the background color but will be otherwise ignored.
        /// </summary>
        public CfxColor BackgroundColor {
            get {
                return m_BackgroundColor;
            }
            set {
                m_BackgroundColor = value;
            }
        }

        protected override void CopyToNative() {
            var m_BrowserSubprocessPath_pinned = new PinnedString(m_BrowserSubprocessPath);
            var m_CachePath_pinned = new PinnedString(m_CachePath);
            var m_UserAgent_pinned = new PinnedString(m_UserAgent);
            var m_ProductVersion_pinned = new PinnedString(m_ProductVersion);
            var m_Locale_pinned = new PinnedString(m_Locale);
            var m_LogFile_pinned = new PinnedString(m_LogFile);
            var m_JavascriptFlags_pinned = new PinnedString(m_JavascriptFlags);
            var m_ResourcesDirPath_pinned = new PinnedString(m_ResourcesDirPath);
            var m_LocalesDirPath_pinned = new PinnedString(m_LocalesDirPath);
            CfxApi.cfx_settings_copy_to_native(nativePtrUnchecked, m_SingleProcess ? 1 : 0, m_NoSandbox ? 1 : 0, m_BrowserSubprocessPath_pinned.Obj.PinnedPtr, m_BrowserSubprocessPath_pinned.Length, m_MultiThreadedMessageLoop ? 1 : 0, m_WindowlessRenderingEnabled ? 1 : 0, m_CommandLineArgsDisabled ? 1 : 0, m_CachePath_pinned.Obj.PinnedPtr, m_CachePath_pinned.Length, m_PersistSessionCookies ? 1 : 0, m_UserAgent_pinned.Obj.PinnedPtr, m_UserAgent_pinned.Length, m_ProductVersion_pinned.Obj.PinnedPtr, m_ProductVersion_pinned.Length, m_Locale_pinned.Obj.PinnedPtr, m_Locale_pinned.Length, m_LogFile_pinned.Obj.PinnedPtr, m_LogFile_pinned.Length, m_LogSeverity, m_JavascriptFlags_pinned.Obj.PinnedPtr, m_JavascriptFlags_pinned.Length, m_ResourcesDirPath_pinned.Obj.PinnedPtr, m_ResourcesDirPath_pinned.Length, m_LocalesDirPath_pinned.Obj.PinnedPtr, m_LocalesDirPath_pinned.Length, m_PackLoadingDisabled ? 1 : 0, m_RemoteDebuggingPort, m_UncaughtExceptionStackSize, m_ContextSafetyImplementation ? 1 : 0, m_IgnoreCertificateErrors ? 1 : 0, CfxColor.Unwrap(m_BackgroundColor));
            m_BrowserSubprocessPath_pinned.Obj.Free();
            m_CachePath_pinned.Obj.Free();
            m_UserAgent_pinned.Obj.Free();
            m_ProductVersion_pinned.Obj.Free();
            m_Locale_pinned.Obj.Free();
            m_LogFile_pinned.Obj.Free();
            m_JavascriptFlags_pinned.Obj.Free();
            m_ResourcesDirPath_pinned.Obj.Free();
            m_LocalesDirPath_pinned.Obj.Free();
        }

    }
}
