using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chromium.WebBrowser;
using Chromium.Remote;

namespace CfxTestApplication {
    class JsTestObject : JSObject {

        private BrowserForm form;

        internal JsTestObject(BrowserForm form) {
            this.form = form;
            AddJSFunction("testFunction").Execute += TestFunction_Execute;
            AddJSObject("anotherObject").AddJSFunction("anotherTestFunction").Execute += AnotherTestFunction_Execute;

            PropertyGet += JsTestObject_PropertyGet;
            PropertySet += JsTestObject_PropertySet;
        }

        void JsTestObject_PropertySet(object sender, Chromium.Remote.Event.CfrV8AccessorSetEventArgs e) {
            form.LogWriteLine("PropertySet({0}, {1})", sender, e);
            e.SetReturnValue(true);
        }

        void JsTestObject_PropertyGet(object sender, Chromium.Remote.Event.CfrV8AccessorGetEventArgs e) {
            form.LogWriteLine("PropertyGet({0}, {1})", sender, e);
            e.Retval = CfrV8Value.CreateString(e.RemoteRuntime, "Some property");
            e.SetReturnValue(true);
        }

        void TestFunction_Execute(object sender, Chromium.Remote.Event.CfrV8HandlerExecuteEventArgs e) {
            form.LogWriteLine("TestFunction_Execute({0}, {1})", sender, e);
        }

        void AnotherTestFunction_Execute(object sender, Chromium.Remote.Event.CfrV8HandlerExecuteEventArgs e) {
            form.LogWriteLine("AnotherTestFunction_Execute({0}, {1})", sender, e);
            e.SetReturnValue("The other test function returns this text.");
        }

    }
}
