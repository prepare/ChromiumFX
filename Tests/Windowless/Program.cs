// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Windows.Forms;
using Chromium;
using System.Diagnostics;

namespace Windowless {
    static class Program {

        [STAThread]
        static void Main() {


            var assemblyDir = System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            var projectRoot = assemblyDir;
            while(!System.IO.File.Exists(System.IO.Path.Combine(projectRoot, "Readme.md")))
                projectRoot = System.IO.Path.GetDirectoryName(projectRoot);

            CfxRuntime.LibCefDirPath = System.IO.Path.Combine(projectRoot, "cef", "Release64");
            CfxRuntime.LibCfxDirPath = System.IO.Path.Combine(projectRoot, "Build", "Release");

            var LD_LIBRARY_PATH = Environment.GetEnvironmentVariable("LD_LIBRARY_PATH");
            Debug.Print(LD_LIBRARY_PATH);

            var exitCode = CfxRuntime.ExecuteProcess(null);
            if(exitCode >= 0) {
                Environment.Exit(exitCode);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = new CfxSettings();
            settings.WindowlessRenderingEnabled = true;
            settings.NoSandbox = true;

            //settings.SingleProcess = true;
            settings.BrowserSubprocessPath = System.IO.Path.Combine(assemblyDir, "windowless");

            //settings.LogSeverity = CfxLogSeverity.Disable;

            settings.ResourcesDirPath = System.IO.Path.Combine(projectRoot, "cef", "Resources");
            settings.LocalesDirPath = System.IO.Path.Combine(projectRoot, "cef", "Resources", "locales");

            var app = new CfxApp();
            app.OnBeforeCommandLineProcessing += (s, e) => {
                // optimizations following recommendations from issue #84
                e.CommandLine.AppendSwitch("disable-gpu");
                e.CommandLine.AppendSwitch("disable-gpu-compositing");
                e.CommandLine.AppendSwitch("disable-gpu-vsync");
            };

            if(!CfxRuntime.Initialize(settings, app))
                Environment.Exit(-1);


            var f = new Form();
            f.Width = 900;
            f.Height = 600;

            var c = new BrowserControl();
            c.Dock = DockStyle.Fill;
            c.Parent = f;

            Application.Idle += Application_Idle;
            Application.Run(f);
            
            CfxRuntime.Shutdown();
        }

        static void Application_Idle(object sender, EventArgs e) {
            CfxRuntime.DoMessageLoopWork();
        }
    }
}
