// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Drawing;
using System.Windows.Forms;
using Chromium;
using Chromium.Event;
using Chromium.WebBrowser;
using System.Diagnostics;

using Chromium.WebBrowser.Event;

namespace CfxTestApplication {

    public class Program {

        [STAThread]
        public static void Main() {

            var assemblyDir = System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            Environment.CurrentDirectory = System.IO.Path.Combine(assemblyDir, @"..\..\");

            if(CfxRuntime.PlatformArch== CfxPlatformArch.x64)
                CfxRuntime.LibCefDirPath = @"cef\Release64";
            else
                CfxRuntime.LibCefDirPath = @"cef\Release";

            Chromium.WebBrowser.ChromiumWebBrowser.OnBeforeCfxInitialize += ChromiumWebBrowser_OnBeforeCfxInitialize;
            ChromiumWebBrowser.OnBeforeCommandLineProcessing += ChromiumWebBrowser_OnBeforeCommandLineProcessing;
            Chromium.WebBrowser.ChromiumWebBrowser.Initialize();

            //Walkthrough01.Main();
            //return;

            Application.EnableVisualStyles();
            var f = new BrowserForm();
            f.Show();
            Application.Run(f);

            CfxRuntime.Shutdown();

        }

        static void ChromiumWebBrowser_OnBeforeCommandLineProcessing(CfxOnBeforeCommandLineProcessingEventArgs e) {
            Console.WriteLine("ChromiumWebBrowser_OnBeforeCommandLineProcessing");
            Console.WriteLine(e.CommandLine.CommandLineString);
        }

        static void ChromiumWebBrowser_OnBeforeCfxInitialize(OnBeforeCfxInitializeEventArgs e) {
            e.Settings.LocalesDirPath = System.IO.Path.GetFullPath(@"cef\Resources\locales");
            e.Settings.ResourcesDirPath = System.IO.Path.GetFullPath(@"cef\Resources");
        }
    }
}
