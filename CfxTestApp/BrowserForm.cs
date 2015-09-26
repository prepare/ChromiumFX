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
using Chromium.WebBrowser;
using System.Threading;

namespace CfxTestApplication {
    public partial class BrowserForm : Form {

        public BrowserForm() {
            InitializeComponent();

            LogWriteLine("CfxRuntime.ApiHash(0): " + CfxRuntime.ApiHash(0));
            LogWriteLine("CfxRuntime.ApiHash(1): " + CfxRuntime.ApiHash(1));
            LogWriteLine("CfxRuntime.GetCefVersion(): " + CfxRuntime.GetCefVersion());
            LogWriteLine("CfxRuntime.GetChromeVersion(): " + CfxRuntime.GetChromeVersion());
            LogWriteLine("Platform OS: {0}; Arch: {1}", CfxRuntime.PlatformOS, CfxRuntime.PlatformArch);
            LogWriteLine();

            ChromiumWebBrowser.OnRemoteContextCreated += (e) =>
                LogWriteLine("Remote context created for render process id {0} on remote thread id {1}", CfxRemoteCallContext.CurrentContext.ProcessId, CfxRemoteCallContext.CurrentContext.ThreadId);

            LoadUrlButton.Click += new EventHandler(LoadUrlButton_Click);
            UrlTextBox.KeyDown += new KeyEventHandler(UrlTextBox_KeyDown);

            JSHelloWorldButton.Click += new EventHandler(JSHelloWorldButton_Click);
            JSTestPageButton.Click += new EventHandler(TestButton_Click);
            VisitDomButton.Click += new EventHandler(VisitDomButton_Click);

            WebBrowser.GlobalObject.AddFunction("CfxHelloWorld").Execute += CfxHelloWorld_Execute;
            WebBrowser.GlobalObject.AddFunction("testDoubleCallback").Execute += TestDoubleCallback_Execute;

            WebBrowser.GlobalObject.Add("TestObject", new JsTestObject(this));

            var html = @"

                <html>
                <head><script>
                    function testlog(text) {
                        document.getElementById('testfunc_result').innerHTML += '<br>' + text;
                    }
                </script>
                <script>
                    function doubleCallback(arg1, arg2) {
                        testlog('Function doubleCallback() called. Arguments:');
                        testlog(arg1);
                        testlog(arg2);
                        return 'This text is returned from doubleCallback()';
                    }
                    function clearTestLog() {
                        document.getElementById('testfunc_result').innerHTML = '';
                    }
                </script>
                </head>
                <body>
                    <br><br><b>Local resource/javascript integration test page.</b>
                    <hr><br><br>
                    Local resource image:<br>
                    <img src='http://localresource/image'><br><br>
                    <a href='http://www.google.com/' onclick=""window.open('http://www.google.com/', 'Popup test', 'width=800,height=600,scrollbars=yes'); return false;"">open popup</a>
                    <br><br>
                    <button id='testbutton1' onclick=""document.getElementById('testfunc_result').innerHTML += '<br>' + CfxHelloWorld('this is the hello world function');"">Execute CfxHelloWorld()</button>
                    <button id='testbutton2' onclick=""
                        testlog('TestObject = ' + TestObject);
                        testlog('TestObject.testFunction = ' + TestObject.testFunction);
                        TestObject.testFunction('this is the test function');
                    "">Execute TestObject.testFunction()</button>
                    <button id='testbutton3' onclick=""
                        testlog('TestObject = ' + TestObject);
                        testlog('TestObject.anotherObject = ' + TestObject.anotherObject);
                        testlog('TestObject.anotherObject.anotherTestFunction = ' + TestObject.anotherObject.anotherTestFunction);
                        testlog(TestObject.anotherObject.anotherTestFunction('this is the other test function'));
                    "">Execute TestObject.anotherObject.anotherTestFunction()</button>
                    <button id='testbutton4' onclick=""
                        testlog('TestObject.dynamicProperty = ' + TestObject.dynamicProperty);
                        testlog('(define TestObject.dynamicProperty += 100)');
                        TestObject.dynamicProperty += 100;
                        testlog('TestObject.dynamicProperty = ' + TestObject.dynamicProperty);
                    "">Defined TestObject properties</button>
                    <button id='testbutton5' onclick=""
                        testlog('TestObject.foo = ' + TestObject.foo);
                        testlog('(define TestObject.foo = 100)');
                        TestObject.foo = 100;
                        testlog('TestObject.foo = ' + TestObject.foo);
                    "">Undefined TestObject properties</button>
                    <button id='testbutton6' onclick=""
                        testlog('Call native function testDoubleCallback(doubleCallback). Return value:');
                        testlog('Return value: ' + testDoubleCallback(doubleCallback));
                    "">Double Callback</button>
                    <br><br><div id='testfunc_result'></div>
            ";

            WebBrowser.SetWebResource("http://localresource/text.html", new Chromium.WebBrowser.WebResource(html));

            var bm = new System.Drawing.Bitmap(100, 100);
            using(var g = System.Drawing.Graphics.FromImage(bm)) {
                g.FillRectangle(System.Drawing.Brushes.Yellow, 0, 0, 99, 99);
                g.DrawRectangle(System.Drawing.Pens.Black, 0, 0, 99, 99);
                g.DrawLine(System.Drawing.Pens.Black, 0, 0, 99, 99);
            }
            WebBrowser.SetWebResource("http://localresource/image", new Chromium.WebBrowser.WebResource(bm));

            WebBrowser.DisplayHandler.OnConsoleMessage += (s, e) => LogCallback(s, e);
            WebBrowser.DisplayHandler.OnTitleChange += (s, e) => LogCallback(s, e);
            WebBrowser.DisplayHandler.OnStatusMessage += (s, e) => LogCallback(s, e);

            WebBrowser.LifeSpanHandler.OnBeforePopup += (s, e) => {
                LogCallback(s, e);
                var ff = e.PopupFeatures.AdditionalFeatures;
                if(ff != null) 
                    foreach(var f in ff) {
                        LogWriteLine("Additional popup feature: {0}", f);
                    }
            };

            WebBrowser.OnLoadingStateChange += (s, e) => {
                if(!e.IsLoading)
                    UrlTextBox.Text = WebBrowser.Url.ToString();
            };

            WebBrowser.LoadUrl("http://localresource/text.html");

        }


        void VisitDomButton_Click(object sender, EventArgs e) {
            var retval = WebBrowser.VisitDom(VisitDOMCallback);
            if(!retval) LogWriteLine("Remote browser not available");
        }

        void VisitDOMCallback(CfrDomDocument doc, CfrBrowser browser) {
            LogCallback(doc, browser);
            if(doc.Body.HasChildren)
                LogWriteLine("DOM: document.Body.FirstChild.ElementTagName = " + doc.Body.FirstChild.ElementTagName);
            if(doc.HasSelection) {
                LogWriteLine("DOM: document.SelectionAsText = " + doc.SelectionAsText);
            }
        }


        void JSHelloWorldButton_Click(object sender, EventArgs e) {
            WebBrowser.EvaluateJavascript("var test = 10; var result = CfxHelloWorld(test, 'foo'); document.body.innerHTML = result;", HelloWorldResult);
        }

        void HelloWorldResult(CfrV8Value retval, CfrV8Exception ex) {
            LogCallback(retval, ex);
        }

        void CfxHelloWorld_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {

            if(e.Arguments.Length > 1) {
                var r1 = e.Arguments[0].IntValue;
                var r2 = e.Arguments[1].StringValue;
                LogWriteLine("CfxHelloWorld_Execute arguments: " + r1 + ", '" + r2 + "'");
            }
            LogCallback(sender, e);
            var context = CfrV8Context.GetEnteredContext();
            e.SetReturnValue("CfxHelloWorld returns this text.");

        }

        void TestDoubleCallback_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            var doubleCallback = e.Arguments[0];
            var args = new CfrV8Value[] {
                "This is the first argument",
                123.4567
            };
            var retval = doubleCallback.ExecuteFunction(null, args);
            e.SetReturnValue(retval);
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
            LogWriteLine("WebBrowser.Browser.FrameCount = " + b.FrameCount);
            var ids = b.FrameIdentifiers;
            LogWriteLine("FrameIdentifiers: " + string.Join<long>(", ", ids));
            var names = b.GetFrameNames();
            LogWriteLine("FrameNames: " + string.Join(" | ", names));
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
            LogWriteLine(sb.ToString());
        }


        public void LogWriteLine() {
            LogWrite(Environment.NewLine);
        }

        public void LogWriteLine(string msg) {
            LogWrite(msg + Environment.NewLine);
        }

        public void LogWriteLine(string msg, params object[] parameters) {
            LogWrite(msg + Environment.NewLine, parameters);
        }

        public void LogWrite(string msg, params object[] parameters) {
            LogWrite(string.Format(msg, parameters));
        }

        public void LogWrite(string msg) {

            if(InvokeRequired) {
                Invoke((MethodInvoker)(() => { LogWrite("(*)" + msg); }));
                return;
            }

            LogTextBox.AppendText(msg);
            LogTextBox.SelectionStart = LogTextBox.TextLength - 1;
            LogTextBox.ScrollToCaret();

        }

        private void ShowDevToolsButton_Click(object sender, EventArgs e) {

            CfxWindowInfo windowInfo = new CfxWindowInfo();

            windowInfo.Style = WindowStyle.WS_OVERLAPPEDWINDOW | WindowStyle.WS_CLIPCHILDREN | WindowStyle.WS_CLIPSIBLINGS | WindowStyle.WS_VISIBLE;
            windowInfo.ParentWindow = IntPtr.Zero;
            windowInfo.WindowName = "Dev Tools";
            windowInfo.X = 200;
            windowInfo.Y = 200;
            windowInfo.Width = 800;
            windowInfo.Height = 600;

            WebBrowser.BrowserHost.ShowDevTools(windowInfo, new CfxClient(), new CfxBrowserSettings(), null);

        }

        private void CreditsButton_Click(object sender, EventArgs e) {
            WebBrowser.LoadUrl("about:credits");
        }

        private void BackButton_Click(object sender, EventArgs e) {
            WebBrowser.GoBack();
        }

        private void FwdButton_Click(object sender, EventArgs e) {
            WebBrowser.GoForward();
        }

        private void UrlTextBox_Click(object sender, EventArgs e) {

        }

        private void LoadGoogleButton_Click(object sender, EventArgs e) {
            WebBrowser.LoadUrl("google.com");
        }

        private void systemNetCompatibilityTestToolStripMenuItem_Click(object sender, EventArgs e) {
            HttpWebResponseCompatTest.Test();
        }

        private void printButton_Click(object sender, EventArgs e) {
            WebBrowser.BrowserHost.Print();
        }

        private void clearContextMenuModelToolStripMenuItem_Click(object sender, EventArgs e) {
            if(clearContextMenuModelToolStripMenuItem.Checked) {
                WebBrowser.ContextMenuHandler.OnBeforeContextMenu += ContextMenuHandler_OnBeforeContextMenu;
            } else {
                WebBrowser.ContextMenuHandler.OnBeforeContextMenu -= ContextMenuHandler_OnBeforeContextMenu;
            }
        }

        void ContextMenuHandler_OnBeforeContextMenu(object sender, CfxOnBeforeContextMenuEventArgs e) {
            if(e.Model.Clear()) {
                LogWriteLine("Context Menu cleared.");
            } else {
                LogWriteLine("Context Menu not cleared.");
            }
        }

        private void remoteLayerStressTestToolStripMenuItem_Click(object sender, EventArgs e) {

            if(Debugger.IsAttached) {
                var answer = MessageBox.Show("Running this function with an debugger attached might perform very badly, especially if native debugging is enabled. Continue anyway?", "Attached debugger detected", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Cancel) return;
            }

            var t = new Thread(RemoteLayerStressTest);
            t.IsBackground = true;
            t.Name = "stress test";
            t.Start();
        }

        private void RemoteLayerStressTest() {

            for(int i = 0; i < 100; ++i) {

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton1').click()");

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton2').click()");

                WebBrowser.EvaluateJavascript("document.getElementById('testbutton3').click()", (value, exception) => {
                    LogWriteLine("document.getElementById('testbutton3').click()");
                    LogWriteLine(value.StringValue);
                });

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton4').click()");

                WebBrowser.EvaluateJavascript("document.getElementById('testbutton5').click()", (value, exception) => {
                    LogWriteLine("document.getElementById('testbutton5').click()");
                    LogWriteLine(value.StringValue);
                });

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton6').click()");

                WebBrowser.EvaluateJavascript("doubleCallback('foo', 123)", (value, exception) => {
                    LogWriteLine("doubleCallback('foo', 123)");
                    LogWriteLine(value.StringValue);
                });

                WebBrowser.VisitDom((doc, b) => {
                    LogWriteLine("VisitDom {0} {1}", doc.ToString(), b.ToString());
                    LogWriteLine("testbutton6", doc.GetElementById("testbutton6").AsMarkup);
                });

                // give the browser some time to render and do message loop work
                //Thread.Sleep(20);

            }
        }

        private void evaluateJavascriptToolStripMenuItem_Click(object sender, EventArgs e) {
            LogWriteLine("Request evaluation for [document.body.scrollWidth, document.body.scrollHeight]");
            var retval = WebBrowser.EvaluateJavascript("[document.body.scrollWidth,document.body.scrollHeight]", (value, exception) =>
            {
                if(value != null) {
                    LogWriteLine("Evaluation callback with value: scrollWidth={0}, scrollHeight={1}.",
                    value.GetValue(0).IntValue, value.GetValue(1).IntValue);
                } else if(exception != null) {
                    LogWriteLine("Evaluation callback with exception: {0}.", exception.Message);
                } else {
                    LogWriteLine("Evaluation callback with value == null && exception == null.");
                }
            });
            if(!retval) {
                LogWriteLine("WebBrowser.EvaluateJavascript returned false, evaluation will not succeed.");
            }
        }
    }
}
