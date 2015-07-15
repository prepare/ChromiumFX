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
using System.Drawing;

using Chromium;
using Chromium.Event;
using Chromium.Remote;
using Chromium.Remote.Event;
using Chromium.WebBrowser;

namespace CfxTestApplication {
    public class Walkthrough01 {

        [STAThread]
        public static void Main() {

            //CfxRuntime.LoadLibraries(@"C:\path\to\cef\directory");
            //ChromiumWebBrowser.OnBeforeCfxInitialize += ChromiumWebBrowser_OnBeforeCfxInitialize;
            //ChromiumWebBrowser.Initialize();

            Form f = new Form();
            f.Size = new Size(800, 600);

            ChromiumWebBrowser wb = new ChromiumWebBrowser();
            wb.Dock = DockStyle.Fill;

            wb.Parent = f;

            wb.GlobalObject.AddFunction("HelloApp").Execute += HelloApp_Execute;
            wb.GlobalObject.AddFunction("DoSomething").Execute += DoSomething_Execute;


            //wb.ExecuteJavascript("var x = HelloApp();");

            var html = " <button onclick='var x = HelloApp(12345); document.getElementById(\"demo\").innerHTML =x;'>";
            html += "Trigger HelloApp(12345) callback function.</button><br><br><img src='http://localresource/image'>";
            html += "<br><p>Callback returned: <span id='demo'></span></p>";
            html += "<br><br><button onclick='DoSomething();'>Do something</button>";
            
            var bm = new System.Drawing.Bitmap(100, 100);
            using(var g = System.Drawing.Graphics.FromImage(bm)) {
                g.DrawLine(System.Drawing.Pens.Black, 0, 0, 100, 100);
            }

            wb.SetWebResource("http://localresource/text.html", new Chromium.WebBrowser.WebResource(html));
            wb.SetWebResource("http://localresource/image", new Chromium.WebBrowser.WebResource(bm));


            f.Show();
            wb.LoadUrl("http://localresource/text.html");
            Application.Run(f);

            CfxRuntime.Shutdown();


        }

        static void DoSomething_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            var f = (JSFunction)sender;
            f.Browser.VisitDom(VisitDom);
        }

        static void VisitDom(CfrDomDocument doc, CfrBrowser browser) {
            if(doc.Body.HasChildren)
                MessageBox.Show("DOM document body has children!");
        }

        static void HelloApp_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            var numberOfArguments = e.Arguments.Length;
            if(numberOfArguments > 0) {
                var firstArg = e.Arguments[0].IntValue;
                MessageBox.Show("First argument supplied: " + firstArg);
            }
            e.SetReturnValue(100);
        }

        static void ChromiumWebBrowser_OnBeforeCfxInitialize(CfxSettings settings, CfxBrowserProcessHandler processHandler, out CfxOnBeforeCommandLineProcessingEventHandler onBeforeCommandLineProcessingEventHandler) {
            throw new NotImplementedException();
        }


    }
}
