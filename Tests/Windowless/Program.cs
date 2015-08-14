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


using System;
using System.Windows.Forms;
using Chromium;

namespace Windowless {
    static class Program {

        [STAThread]
        static void Main() {


            var path = System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            while(!System.IO.File.Exists(System.IO.Path.Combine(path, "Readme.md")))
                path = System.IO.Path.GetDirectoryName(path);

            CfxRuntime.LibCefDirPath = System.IO.Path.Combine(path, "cef", "Release64");
            CfxRuntime.LibCfxDirPath = System.IO.Path.Combine(path, "Build", "Release");

            var exitCode = CfxRuntime.ExecuteProcess(null);
            if(exitCode >= 0) {
                Environment.Exit(exitCode);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = new CfxSettings();
            settings.WindowlessRenderingEnabled = true;
            settings.NoSandbox = true;
            settings.SingleProcess = true;
            settings.LogSeverity = CfxLogSeverity.Disable;

            settings.ResourcesDirPath = System.IO.Path.Combine(path, "cef", "Resources");
            settings.LocalesDirPath = System.IO.Path.Combine(path, "cef", "Resources", "locales");

            if(!CfxRuntime.Initialize(settings, null))
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
