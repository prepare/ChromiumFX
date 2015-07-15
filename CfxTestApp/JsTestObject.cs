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
            e.Retval = CfrV8Value.CreateInt(e.RemoteRuntime, dynamicPropertyValue);
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
