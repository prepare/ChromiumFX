// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using Chromium.Remote;
using Chromium.WebBrowser;

namespace CfxTestApplication {
    class JsTestObject : JSObject {

        private BrowserForm form;

        internal JsTestObject(BrowserForm form) {
            this.form = form;
            AddFunction("testFunction").Execute += TestFunction_Execute;
            AddObject("anotherObject").AddFunction("anotherTestFunction").Execute += AnotherTestFunction_Execute;

            var p = AddDynamicProperty("dynamicProperty");
            p.PropertyGet += dynamicProperty_PropertyGet;
            p.PropertySet += dynamicProperty_PropertySet;

        }


        int dynamicPropertyValue;

        void dynamicProperty_PropertySet(object sender, Chromium.Remote.Event.CfrV8AccessorSetEventArgs e) {
            form.LogWriteLine("PropertySet({0}, {1})", sender, e);
            dynamicPropertyValue = e.Value.IntValue;
        }

        void dynamicProperty_PropertyGet(object sender, Chromium.Remote.Event.CfrV8AccessorGetEventArgs e) {
            form.LogWriteLine("PropertyGet({0}, {1})", sender, e);
            e.Retval = CfrV8Value.CreateInt(dynamicPropertyValue);
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
