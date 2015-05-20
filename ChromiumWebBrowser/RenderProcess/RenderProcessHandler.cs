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
using System.Collections.Generic;
using Chromium;
using Chromium.Remote;
using Chromium.Remote.Event;

namespace Chromium.WebBrowser {
    internal class RenderProcessHandler : CfrRenderProcessHandler {

        private readonly RenderProcess remoteProcess;

        internal RenderProcessHandler(RenderProcess remoteProcess) : base(remoteProcess.remoteRuntime) {
            this.remoteProcess = remoteProcess;

            this.OnContextCreated += new CfrOnContextCreatedEventHandler(RenderProcessHandler_OnContextCreated);
            this.OnBrowserCreated += new CfrOnBrowserCreatedEventHandler(RenderProcessHandler_OnBrowserCreated);
            //this.OnRenderThreadCreated += new CfrOnRenderThreadCreatedEventHandler(RenderProcessHandler_OnRenderThreadCreated);
            //this.OnUncaughtException += new CfrOnUncaughtExceptionEventHandler(RenderProcessHandler_OnUncaughtException);
        }

        void RenderProcessHandler_OnUncaughtException(object sender, CfrOnUncaughtExceptionEventArgs e) {
            var wb = ChromiumWebBrowser.GetBrowser(e.Browser.Identifier);
            if(wb != null) {
                
            }
        }

        void RenderProcessHandler_OnRenderThreadCreated(object sender, CfrOnRenderThreadCreatedEventArgs e) {
            //System.Diagnostics.Debug.Print("RenderProcessHandler_OnRenderThreadCreated");
        }

        void RenderProcessHandler_OnBrowserCreated(object sender, CfrOnBrowserCreatedEventArgs e) {
            var id = e.Browser.Identifier;
            var wb = ChromiumWebBrowser.GetBrowser(id);
            if(wb != null) {
                wb.SetRemoteBrowser(e.Browser, remoteProcess);
            }
        }

        void RenderProcessHandler_OnContextCreated(object sender, CfrOnContextCreatedEventArgs e) {
            var wb = ChromiumWebBrowser.GetBrowser(e.Browser.Identifier);
            if(wb != null) {
                if(e.Frame.IsMain) {
                    SetProperties(e.Context, wb.mainFrameJSProperties);
                } else if(wb.frameJSProperties.Count > 0) {
                    Dictionary<string, JSProperty> list;
                    if(wb.frameJSProperties.TryGetValue(e.Frame.Name, out list)) {
                        SetProperties(e.Context, list);
                    }
                }
            }
        }

        private void SetProperties(CfrV8Context context, Dictionary<string, JSProperty> list) {
            foreach(var p in list) {
                var v8Value = p.Value.GetV8Value(context.RemoteRuntime);
                context.Global.SetValue(p.Key, v8Value, CfxV8PropertyAttribute.DontDelete | CfxV8PropertyAttribute.ReadOnly);
            }
        }
    }
}
