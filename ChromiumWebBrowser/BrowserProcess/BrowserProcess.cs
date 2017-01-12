// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using Chromium;
using Chromium.Event;

namespace Chromium.WebBrowser {
    internal static class BrowserProcess {

        internal static CfxApp app;
        internal static CfxBrowserProcessHandler processHandler;

        internal static bool initialized;

        internal static void Initialize() {

            if(initialized)
                throw new ChromiumWebBrowserException("ChromiumWebBrowser library already initialized.");


            int retval = CfxRuntime.ExecuteProcess();
            if(retval >= 0)
                Environment.Exit(retval);


            app = new CfxApp();
            processHandler = new CfxBrowserProcessHandler();

            app.GetBrowserProcessHandler += (s, e) => e.SetReturnValue(processHandler);
            app.OnBeforeCommandLineProcessing += (s, e) => ChromiumWebBrowser.RaiseOnBeforeCommandLineProcessing(e);
            app.OnRegisterCustomSchemes += (s, e) => ChromiumWebBrowser.RaiseOnRegisterCustomSchemes(e);

            var settings = new CfxSettings();
            settings.MultiThreadedMessageLoop = true;
            settings.NoSandbox = true;

            ChromiumWebBrowser.RaiseOnBeforeCfxInitialize(settings, processHandler);

            if(!CfxRuntime.Initialize(settings, app, RenderProcess.RenderProcessMain))
                throw new ChromiumWebBrowserException("Failed to initialize CEF library.");

            initialized = true;
        }
    }
}
