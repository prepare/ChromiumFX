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
using Chromium.Remote;
using Chromium.Remote.Event;

namespace Chromium.WebBrowser {

    /// <summary>
    /// Represents a javascript function in the render process to be added as 
    /// a property to a browser frame's global object or to a JSObject.
    /// </summary>
    public class JSFunction : JSProperty {

        private CfrV8Handler v8Handler;
        
        /// <summary>
        /// Javascript callback event for this function.
        /// </summary>
        public event CfrV8HandlerExecuteEventHandler Execute;

        /// <summary>
        /// If true, then the function is executed on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to the render thread.
        /// </summary>
        public bool InvokeOnBrowser { get; private set; }

        /// <summary>
        /// Creates a new javascript function to be added as a property 
        /// to a browser frame's global object or to a JSObject.
        /// </summary>
        public JSFunction()
            : base(JSPropertyType.Function) {
        }

        /// <summary>
        /// Creates a new javascript function to be added as a property 
        /// to a browser frame's global object or to a JSObject.
        /// If invokeOnBrowser is true, then the function is executed on the thread that 
        /// owns the browser's underlying window handle. Preserves affinity to the render thread.
        /// </summary>
        public JSFunction(bool invokeOnBrowser)
            : base(JSPropertyType.Function) {
            this.InvokeOnBrowser = invokeOnBrowser;
        }

        internal void SetV8Handler(CfrV8Handler handler) {
            handler.Execute += new CfrV8HandlerExecuteEventHandler(handler_Execute);
        }

        private void handler_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            var eventHandler = Execute;
            if(eventHandler != null) {
                if(InvokeOnBrowser) {
                    Browser.RenderThreadInvoke((MethodInvoker)(() => { eventHandler(this, e); }));
                } else {
                    eventHandler(this, e);
                }
            }
        }

        internal override CfrV8Value CreateV8Value(CfrRuntime remoteRuntime) {
            v8Handler = new CfrV8Handler(remoteRuntime);
            v8Handler.Execute += new CfrV8HandlerExecuteEventHandler(handler_Execute);
            return CfrV8Value.CreateFunction(remoteRuntime, Name, v8Handler);
        }
    }
}
