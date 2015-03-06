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
            
//#if DEBUG
//            CfxRuntime.LoadLibraries(@"cef\Debug");
//#else
            CfxRuntime.LoadLibraries(@"cef\Release");
//#endif


            //for(int i = 0; i < 1000000; i++) {

            //    var ps = CfxPrintSettings.Create();
            //    var pr = new CfxPageRange[] { new CfxPageRange(), new CfxPageRange(), new CfxPageRange() };

            //    pr[0].To = 3;
            //    pr[1].From = 10;
            //    pr[1].To = 11;
            //    pr[2].From = 60;
            //    pr[2].To = 65;

            //    ps.SetPageRanges(pr);

            //    pr[0].Dispose();
            //    pr[1].Dispose();
            //    pr[2].Dispose();

            //    var x = ps.PageRangesCount;

            //    var y = ps.GetPageRanges();

            //    //ps.Dispose();
            //    //GC.Collect();
            //}


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
