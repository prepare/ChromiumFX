// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Windows.Forms;
using System.Diagnostics;

using Chromium;
using Chromium.Event;
using Chromium.Remote;
using Chromium.Remote.Event;
using Chromium.WebBrowser;
using System.Threading;
using System.Collections.Generic;
using System.Text;

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

            ChromiumWebBrowser.RemoteProcessCreated += (e) => {
                LogWriteLine("Remote render process created with process id {0}", CfxRemoteCallContext.CurrentContext.ProcessId, CfxRemoteCallContext.CurrentContext.ThreadId);
                e.RenderProcessHandler.OnRenderThreadCreated += (s, e1) => {
                    LogWriteLine("RenderProcessHandler.OnRenderThreadCreated, process id = {0}", CfxRemoteCallContext.CurrentContext.ProcessId);
                };
                e.RenderProcessHandler.OnBrowserDestroyed += (s, e1) => {
                    // this is never reached. 
                    LogWriteLine("RenderProcessHandler.OnBrowserDestroyed, process id = {0}, browser id = {1}", CfxRemoteCallContext.CurrentContext.ProcessId, e1.Browser.Identifier);
                };
                e.RenderProcessHandler.OnBrowserCreated += (s, e1) => {
                    LogWriteLine("RenderProcessHandler.OnBrowserCreated, process id = {0}, browser id = {1}", CfxRemoteCallContext.CurrentContext.ProcessId, e1.Browser.Identifier);
                };
            };

            LoadUrlButton.Click += new EventHandler(LoadUrlButton_Click);
            UrlTextBox.KeyDown += new KeyEventHandler(UrlTextBox_KeyDown);

            JSHelloWorldButton.Click += new EventHandler(JSHelloWorldButton_Click);
            JSTestPageButton.Click += new EventHandler(TestButton_Click);
            VisitDomButton.Click += new EventHandler(VisitDomButton_Click);

            WebBrowser.GlobalObject.AddFunction("CfxHelloWorld").Execute += CfxHelloWorld_Execute;
            WebBrowser.GlobalObject.AddFunction("testDoubleCallback").Execute += TestDoubleCallback_Execute;

            // related to issue #65
            WebBrowser.GlobalObject.AddFunction("ArrayTestCallback").Execute += (s, e1) => {
                var array = e1.Arguments[0];
                var v0 = array.GetValue(0);
                var v1 = array.GetValue(1);
                if(v0 != null) {
                    LogWriteLine("Array test function works: v0 = {0}, v1 = {1}", v0.IntValue, v1.IntValue);
                } else {
                    LogWriteLine("Array test function: array is broken.");
                }
            };

            // related to pull request #1
            WebBrowser.GlobalObject.AddFunction("ListKeysInDocumentObject").Execute += (s, e1) => {
                var doc = e1.Arguments[0];
                List<string> keys = new List<string>();
                if(doc.GetKeys(keys)) {
                    LogWriteLine("document has {0} keys:", keys.Count);
                    keys.ForEach(k => LogWriteLine(k));
                } else {
                    LogWriteLine("GetKeys returned false.");
                }
            };

            WebBrowser.GlobalObject.Add("TestObject", new JsTestObject(this));


            var sleepFunction = new JSFunction(JSInvokeMode.DontInvoke);
            sleepFunction.Execute += (s, e) => {
                LogWriteLine("Sleep function: sleep 5 seconds...");
                Thread.Sleep(5000);
                try {
                    var x = e.Arguments[0].IntValue;
                    LogWriteLine("Sleep function: Event args accessed sucessfully.");
                } catch(Exception ex) {
                    LogWriteLine("Sleep function: Error accessing event args:");
                    LogWriteLine(ex.ToString());
                }
            };

            WebBrowser.GlobalObject.Add("SleepFunction", sleepFunction);

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
                    <a href='http://www.google.com/' onclick=""window.open('http://www.google.com/', 'Popup test', 'width=800,height=600,scrollbars=yes'); return false;"">open popup window.open</a>
                    <a href='http://www.google.com/' target=blank>open popup target=blank</a>
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

            WebBrowser.LoadHandler.OnLoadingStateChange += (s, e) => {
                if(e.IsLoading) return;
                BeginInvoke((MethodInvoker)(() => {
                    UrlTextBox.Text = WebBrowser.Url.ToString();
                }));
            };

            WebBrowser.LoadUrl("http://localresource/text.html");

            WebBrowser.FindToolbar.Visible = true;

            WebBrowser.OnV8ContextCreated += (s, e) => {
                if(e.Frame.IsMain) {
                    CfrV8Value retval;
                    CfrV8Exception exception;
                    if(e.Context.Eval("CfxHelloWorld()", null, 0, out retval, out exception)) {
                        LogWriteLine("OnV8ContextCreated: Eval succeeded, retval is '{0}'", retval.StringValue);
                    } else {
                        LogWriteLine("OnV8ContextCreated: Eval failed, exception is '{0}'", exception.Message);
                    }
                }
            };

            WebBrowser.GlobalObject.AddFunction("SubmitAsyncTestFunction").Execute += JS_SubmitAsyncTestFunction;
            WebBrowser.GlobalObject.AddFunction("bigStringFunction").Execute += JS_bigStringFunction;

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

            var self = e.Object.GetValue("testDoubleCallback");
            var handler = self.FunctionHandler;
            LogWriteLine("testDoubleCallback is a CEF created function: {0}", handler != null);
            LogWriteLine("doubleCallback is a CEF created function: {0}", doubleCallback.FunctionHandler != null);

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

            int domCount = 0;
            int evalCount = 0;

            for(int i = 0; i < 100; ++i) {

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton1').click()");

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton2').click()");

                WebBrowser.EvaluateJavascript("document.getElementById('testbutton3').click()", (value, exception) => {
                    LogWriteLine("EVAL {0}: document.getElementById('testbutton3').click() = {1}", ++evalCount, value.StringValue);
                });

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton4').click()");

                WebBrowser.EvaluateJavascript("document.getElementById('testbutton5').click()", (value, exception) => {
                    LogWriteLine("EVAL {0}: document.getElementById('testbutton5').click() = {1}", ++evalCount, value.StringValue);
                });

                WebBrowser.ExecuteJavascript("document.getElementById('testbutton6').click()");

                WebBrowser.EvaluateJavascript("doubleCallback('foo', 123)", (value, exception) => {
                    LogWriteLine("EVAL {0}: doubleCallback('foo', 123) = {1}", ++evalCount, value.StringValue);
                });

                WebBrowser.VisitDom((doc, b) => {
                    //LogWriteLine("VisitDom {0} {1}", doc.ToString(), b.ToString());
                    var n = doc.GetElementById("testbutton6");
                    var bounds = n.ElementBounds;
                    LogWriteLine("DOM {0} - testbutton6 = {1} ({2}, {3})", ++domCount, n.AsMarkup, bounds.Width, bounds.Height);
                    // must dispose node, otherwise finalizer crash in the render process.
                    n.Dispose();
                });

                //WebBrowser.VisitDom(VisitDOMCallback);
                //for(int ii = 0; ii < 100; ++ii)
                //    VisitDomButton_Click(null, null);

                //MessageBox.Show("GC.WaitForPendingFinalizers();");
                //GC.Collect();
                //GC.WaitForPendingFinalizers();

                // give the browser some time to render and do message loop work
                //Thread.Sleep(20);

            }
        }

        private void evaluateJavascriptToolStripMenuItem_Click(object sender, EventArgs e) {
            LogWriteLine("Request evaluation for [document.body.scrollWidth, document.body.scrollHeight]");
            var retval = WebBrowser.EvaluateJavascript("[document.body.scrollWidth,document.body.scrollHeight]", (value, exception) => {
                if(value != null) {
                    var v0 = value.GetValue(0);
                    if(v0 == null) {
                        // seems to be fixed in  3.2987.3
                        MessageBox.Show("This test is broken, please refer to issue #65 in the project repo.");
                    } else {
                        LogWriteLine("Evaluation callback with value: scrollWidth={0}, scrollHeight={1}.",
                        value.GetValue(0).IntValue, value.GetValue(1).IntValue);
                    }
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

        private void executeSleepFunctionToolStripMenuItem_Click(object sender, EventArgs e) {
            WebBrowser.ExecuteJavascript("SleepFunction(0);");
        }

        private void toggleFindToolbarToolStripMenuItem_Click(object sender, EventArgs e) {
            WebBrowser.FindToolbar.Visible = !WebBrowser.FindToolbar.Visible;
        }

        private void evaluateJavascriptSynchronouslyToolStripMenuItem_Click(object sender, EventArgs e) {

            if(CfxRemoteCallContext.IsInContext && CfrRuntime.CurrentlyOn(CfxThreadId.Renderer)) {
                throw new Exception("Doing this on the render thread would deadlock.");
            }

            var waitLock = new object();
            lock(waitLock) {

                string documentAllLength = null;

                var evaluationStarted = WebBrowser.EvaluateJavascript("'document.all.length = ' + document.all.length",
                    // Don't invoke, otherwise the ui thread will deadlock!
                    JSInvokeMode.DontInvoke,
                    (v, ex) => {
                        Monitor.Enter(waitLock);
                        try {
                            documentAllLength = v.StringValue;
                        } finally {
                            Monitor.PulseAll(waitLock);
                            Monitor.Exit(waitLock);
                        }
                    }
                );

                if(evaluationStarted) {
                    var success = Monitor.Wait(waitLock, 5000);
                    if(success) {
                        LogWriteLine("Synchronous evaluation succeeded: {0}", documentAllLength);
                    } else {
                        LogWriteLine("Evaluation not finished after 5 seconds, giving up.");
                    }

                } else {
                    LogWriteLine("Failed to start evaluation.");
                }
            }
        }

        private void executeArrayTestFunctionToolStripMenuItem_Click(object sender, EventArgs e) {
            // Related to issue #65
            WebBrowser.ExecuteJavascript("ArrayTestCallback([document.body.scrollWidth, document.body.scrollHeight])");
        }

        private void listKeysInDocumentObjectToolStripMenuItem_Click(object sender, EventArgs e) {
            WebBrowser.ExecuteJavascript("ListKeysInDocumentObject(document)");
        }

        private void setBrowserInvisibleToolStripMenuItem_Click(object sender, EventArgs e) {
            setBrowserInvisibleToolStripMenuItem.Checked = !setBrowserInvisibleToolStripMenuItem.Checked;
            WebBrowser.Visible = !setBrowserInvisibleToolStripMenuItem.Checked;
        }

        private void testGCOfChromiumWebBrowserToolStripMenuItem_Click(object sender, EventArgs e) {
            // Make sure a ChromiumWebBrowser object without references outside of the 
            // ChromiumWebBrowser and ChromiumFX libraries gets garbage collected
            var weak = new WeakReference(WebBrowser);
            WebBrowser.Parent = null;
            WebBrowser = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if(weak.Target != null) {
                MessageBox.Show("WebBrowser not collected!", "GC Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MessageBox.Show("WebBrowser collected!", "GC Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Testing async use of v8 values passed in per JSFunction.

        private void asyncUseOfV8ValuesToolStripMenuItem_Click(object sender, EventArgs e) {
            WebBrowser.ExecuteJavascript(" function AsyncTestFunction(text) { alert(text); return 'The alert was shown'; } SubmitAsyncTestFunction(AsyncTestFunction); ");
        }

        private void JS_SubmitAsyncTestFunction(object sender, CfrV8HandlerExecuteEventArgs e) {
            var function = e.Arguments[0];
            LogWriteLine("JS_SubmitAsyncTestFunction: function.FunctionName = " + function.FunctionName);
            LogWriteLine("JS_SubmitAsyncTestFunction: CfrRuntime.CurrentlyOn(CfxThreadId.Renderer) = " + CfrRuntime.CurrentlyOn(CfxThreadId.Renderer));
            var ctx = CfrV8Context.GetCurrentContext();
            var t = new Thread(() => { AsyncTestFunctionCallback(function, ctx); });
            t.Start();
        }

        private void AsyncTestFunctionCallback(CfrV8Value function, CfrV8Context v8Context) {

            LogWriteLine("AsyncTestFunctionCallback: sleep 2 secs, don't browse away...");
            Thread.Sleep(2000);

            var rpcContext = function.CreateRemoteCallContext();
            rpcContext.Enter();

            // since v8 values can only be accessed from the thread on which they are created, the task
            // has to be posted for execution on the remote renderer thread (see CfxV8Value summary)

            var task = new CfrTask();
            string result = null;
            task.Execute += (s, e) => {
                v8Context.Enter();
                LogWriteLine("AsyncTestFunctionCallback -> task.Execute: function.FunctionName = " + function.FunctionName);
                var args = new CfrV8Value[] { "This is the alert text." };
                var retval = function.ExecuteFunction(null, args);
                result = retval.StringValue;
                v8Context.Exit();
                // release the waiting thread.
                lock(task) {
                    Monitor.PulseAll(task);
                }
            };

            // wait until the return value is available.
            lock(task) {
                CfrTaskRunner.GetForThread(CfxThreadId.Renderer).PostTask(task);
                Monitor.Wait(task);
            }

            rpcContext.Exit();

            LogWriteLine("AsyncTestFunctionCallback: result from callback = " + result);
            LogWriteLine("AsyncTestFunctionCallback: done.");

        }

        private void JS_bigStringFunction(object sender, CfrV8HandlerExecuteEventArgs e) {

            if(e.Arguments.Length > 0) {
                var arg = e.Arguments[0].StringValue;
                LogWriteLine("Big string received: {0}(...) ({1} chars)", arg.Substring(0, 20), arg.Length);
                return;
            }

            var rnd = new Random(DateTime.Now.Millisecond);
            var size = rnd.Next(50 * 1024 * 1024, 51 * 1024 * 1024);
            var chars = new char[size];
            var charSource = "abcdefghijklmnopqrstuvwzyz0123456789";

            for(int i = 0; i < chars.Length; ++i) {
                chars[i] = charSource[rnd.Next(0, charSource.Length)];
            }
            var str = new string(chars);
            LogWriteLine("Sending big string: {0}(...) ({1} chars)", str.Substring(0, 20), str.Length);
            e.SetReturnValue(str);
        }

        private void sendBigStringToJSToolStripMenuItem_Click(object sender, EventArgs e) {
            if(CfxRuntime.PlatformArch == CfxPlatformArch.x86) {
                if(MessageBox.Show("This test may crash the render process in 32-bit mode. Continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
            }
            WebBrowser.ExecuteJavascript("var bigString = bigStringFunction(); testlog('big string received: ' + bigString.substring(0, 20) + '(...) (' + bigString.length + ' chars)'); bigStringFunction(bigString);");
        }
    }
}
