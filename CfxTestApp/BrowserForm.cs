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
using System.Diagnostics;

using Chromium;
using Chromium.Event;
using Chromium.Remote;
using Chromium.Remote.Event;


namespace CfxTestApplication {
    public partial class BrowserForm : Form {

        public BrowserForm() {
            InitializeComponent();

            LogMessage("CfxRuntime.ApiHash(0): " + CfxRuntime.ApiHash(0));
            LogMessage("CfxRuntime.ApiHash(1): " + CfxRuntime.ApiHash(1));
            LogMessage("CfxRuntime.GetCefVersion(): " + CfxRuntime.GetCefVersion());
            LogMessage("CfxRuntime.GetChromeVersion(): " + CfxRuntime.GetChromeVersion());
            LogMessage("");

            LoadUrlButton.Click += new EventHandler(LoadUrlButton_Click);
            UrlTextBox.KeyDown += new KeyEventHandler(UrlTextBox_KeyDown);

            JSHelloWorldButton.Click += new EventHandler(JSHelloWorldButton_Click);
            ResourcesTestButton.Click += new EventHandler(TestButton_Click);
            VisitDomButton.Click += new EventHandler(VisitDomButton_Click);

            WebBrowser.AddGlobalJSFunction("CfxHelloWorld").Execute += CfxHelloWorld_Execute;

            var html = "<html><body> Test ã çç<br><img src='http://localresource/image'>";
            WebBrowser.SetWebResource("http://localresource/text.html", new Chromium.WebBrowser.WebResource(html));

            var bm = new System.Drawing.Bitmap(100, 100);
            using(var g = System.Drawing.Graphics.FromImage(bm)) {
                g.DrawLine(System.Drawing.Pens.Black, 0, 0, 100, 100);
            }

            WebBrowser.SetWebResource("http://localresource/image", new Chromium.WebBrowser.WebResource(bm));
            
            WebBrowser.DisplayHandler.OnConsoleMessage += DisplayHandler_OnConsoleMessage;
            WebBrowser.DisplayHandler.OnTitleChange += DisplayHandler_OnTitleChange;
            

        }

        void DisplayHandler_OnTitleChange(object sender, CfxOnTitleChangeEventArgs e) {
            LogCallback(sender, e);
        }

        void DisplayHandler_OnConsoleMessage(object sender, CfxOnConsoleMessageEventArgs e) {
            LogCallback(sender, e);
        }

        void VisitDomButton_Click(object sender, EventArgs e) {
            var retval = WebBrowser.VisitDom(VisitDOMCallback);
            if(!retval) LogMessage("Remote browser not available");
        }

        void VisitDOMCallback(CfrDomDocument doc, CfrBrowser browser) {
            LogCallback(doc, browser);
            if(doc.Body.HasChildren)
                LogMessage("DOM: document.Body.FirstChild.ElementTagName = " + doc.Body.FirstChild.ElementTagName);
            if(doc.HasSelection) {
                LogMessage("DOM: document.SelectionAsText = " + doc.SelectionAsText);
            }
        }


        void JSHelloWorldButton_Click(object sender, EventArgs e) {
            WebBrowser.EvaluateJavascript("var test = 10; var result = CfxHelloWorld(test, 'foo'); document.body.innerHTML = result;", HelloWorldResult);
            //WebBrowser.ExecuteJavascript("var test = 10; var result = CfxHelloWorld(test, 'foo'); document.body.innerHTML = result;");
        }

        void HelloWorldResult(CfrV8Value retval, CfrV8Exception ex) {
            LogCallback(retval, ex);
        }

        void CfxHelloWorld_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            
            var r1 = e.Arguments[0].IntValue;
            var r2 = e.Arguments[1].StringValue;

            LogMessage("CfxHelloWorld_Execute arguments: " + r1 + ", '" + r2 + "'");

            LogCallback(sender, e);
            var context = Chromium.Remote.CfrV8Context.GetEnteredContext(e.RemoteRuntime);
            e.SetReturnValue(Chromium.Remote.CfrV8Value.CreateString(e.RemoteRuntime, "CfxHelloWorld_Execute"));
            
        }

        void UrlTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Return)
                LoadUrlButton.PerformClick();
        }

        void LoadUrlButton_Click(object sender, EventArgs e) {
            WebBrowser.LoadUrl(UrlTextBox.Text);
        }

        private void TestButton_Click(object sender, EventArgs e) {
            UrlTextBox.Text = "http://localresource/text.html";
            LoadUrlButton.PerformClick();

        }

        private void CountFramesButton_Click(object sender, EventArgs e) {
            var b = WebBrowser.Browser;
            LogMessage("WebBrowser.Browser.FrameCount = " + b.FrameCount);
            var ids = b.FrameIdentifiers;
            LogMessage("FrameIdentifiers: " + string.Join<long>(", ", ids));
            var names = new System.Collections.Generic.List<string>();
            b.GetFrameNames(names);
            LogMessage("FrameNames: " + string.Join(" | ", names));
        }

        void LogCallback(params object[] parameters) {

            var callee = new StackFrame(1, false).GetMethod();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Callback: ");
            sb.Append(callee.Name);
            sb.Append("(");
            var pm = callee.GetParameters();
            for(var i = 0; i <= pm.Length - 1; i++) {
                sb.Append(pm[i].Name);
                if(parameters.Length > i) {
                    sb.Append(" = {");
                    if(parameters[i] != null) {
                        sb.Append(parameters[i].ToString());
                    } else {
                        sb.Append("null");
                    }
                    sb.Append("}");
                }
                if(i < pm.Length - 1) {
                    sb.Append(", ");
                }
            }
            sb.Append(")");
            sb.Append(Environment.NewLine);
            LogMessage(sb.ToString(), false);
        }

        public void LogMessage(string msg, bool newLineBefore = true) {

            if(InvokeRequired) {
                Invoke((MethodInvoker)(() => { LogMessage("(*)" + msg, newLineBefore); }));
                return;
            }

            if(newLineBefore) {
                LogTextBox.AppendText(Environment.NewLine);
            }

            LogTextBox.AppendText(msg);
            LogTextBox.SelectionStart = LogTextBox.TextLength - 1;
            LogTextBox.ScrollToCaret();

        }

        
    }
}
