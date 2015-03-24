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
using Chromium;
using Chromium.Event;

namespace Chromium.WebBrowser {
    internal class BrowserClient : CfxClient  {

        internal ChromiumWebBrowser browser;

        internal LifeSpanHandler lifeSpanHandler;
        internal RequestHandler requestHandler;
        
        private CfxContextMenuHandler contextMenuHandler;
        private CfxLoadHandler loadHandler;
        private CfxDisplayHandler displayHandler;
        private CfxDownloadHandler downloadHandler;
        private CfxDragHandler dragHandler;
        private CfxDialogHandler dialogHandler;
        private CfxFocusHandler focusHandler;
        private CfxGeolocationHandler geolocationHandler;
        private CfxJsDialogHandler jsDialogHandler;
        private CfxKeyboardHandler keyboardHandler;

        internal BrowserClient(ChromiumWebBrowser browser) {
            this.browser = browser;
            this.lifeSpanHandler = new LifeSpanHandler(this);
            this.requestHandler = new RequestHandler(this);
            this.GetLifeSpanHandler += BrowserClient_GetLifeSpanHandler;
            this.GetRequestHandler += BrowserClient_GetRequestHandler;
        }

        internal CfxContextMenuHandler ContextMenuHandler {
            get {
                if(contextMenuHandler == null) {
                    contextMenuHandler = new CfxContextMenuHandler();
                    this.GetContextMenuHandler += BrowserClient_GetContextMenuHandler;
                }
                return contextMenuHandler;
            }
        }

        internal CfxLoadHandler LoadHandler {
            get {
                if(loadHandler == null) {
                    loadHandler = new CfxLoadHandler();
                    this.GetLoadHandler += BrowserClient_GetLoadHandler;
                }
                return loadHandler;
            }
        }

        internal CfxDisplayHandler DisplayHandler {
            get {
                if(displayHandler == null) {
                    displayHandler = new CfxDisplayHandler();
                    this.GetDisplayHandler += BrowserClient_GetDisplayHandler;
                }
                return displayHandler;
            }
        }

        internal CfxDownloadHandler DownloadHandler {
            get {
                if(downloadHandler == null) {
                    downloadHandler = new CfxDownloadHandler();
                    this.GetDownloadHandler += BrowserClient_GetDownloadHandler;
                }
                return downloadHandler;
            }
        }

        internal CfxDragHandler DragHandler {
            get {
                if(dragHandler == null) {
                    dragHandler = new CfxDragHandler();
                    this.GetDragHandler += BrowserClient_GetDragHandler;
                }
                return dragHandler;
            }
        }

        internal CfxDialogHandler DialogHandler {
            get {
                if(dialogHandler == null) {
                    dialogHandler = new CfxDialogHandler();
                    this.GetDialogHandler += BrowserClient_GetDialogHandler;
                }
                return dialogHandler;
            }
        }

        internal CfxFocusHandler FocusHandler {
            get {
                if(focusHandler == null) {
                    focusHandler = new CfxFocusHandler();
                    this.GetFocusHandler += BrowserClient_GetFocusHandler;
                }
                return focusHandler;
            }
        }

        internal CfxGeolocationHandler GeolocationHandler {
            get {
                if(geolocationHandler == null) {
                    geolocationHandler = new CfxGeolocationHandler();
                    this.GetGeolocationHandler += BrowserClient_GetGeolocationHandler;
                }
                return geolocationHandler;
            }
        }

        internal CfxJsDialogHandler JsDialogHandler {
            get {
                if(jsDialogHandler == null) {
                    jsDialogHandler = new CfxJsDialogHandler();
                    this.GetJsDialogHandler += BrowserClient_GetjsDialogHandler;
                }
                return jsDialogHandler;
            }
        }

        internal CfxKeyboardHandler KeyboardHandler {
            get {
                if(keyboardHandler == null) {
                    keyboardHandler = new CfxKeyboardHandler();
                    this.GetKeyboardHandler += BrowserClient_GetKeyboardHandler;
                }
                return keyboardHandler;
            }
        }

        private void BrowserClient_GetKeyboardHandler(object sender, CfxGetKeyboardHandlerEventArgs e) {
            e.SetReturnValue(keyboardHandler);
        }

        private void BrowserClient_GetjsDialogHandler(object sender, CfxGetJsDialogHandlerEventArgs e) {
            e.SetReturnValue(jsDialogHandler);
        }

        private void BrowserClient_GetGeolocationHandler(object sender, CfxGetGeolocationHandlerEventArgs e) {
            e.SetReturnValue(geolocationHandler);
        }

        void BrowserClient_GetFocusHandler(object sender, CfxGetFocusHandlerEventArgs e) {
            e.SetReturnValue(focusHandler);
        }

        private void BrowserClient_GetDialogHandler(object sender, CfxGetDialogHandlerEventArgs e) {
            e.SetReturnValue(dialogHandler);
        }

        void BrowserClient_GetDragHandler(object sender, CfxGetDragHandlerEventArgs e) {
            e.SetReturnValue(dragHandler);
        }

        void BrowserClient_GetDownloadHandler(object sender, CfxGetDownloadHandlerEventArgs e) {
            e.SetReturnValue(downloadHandler);
        }

        void BrowserClient_GetDisplayHandler(object sender, CfxGetDisplayHandlerEventArgs e) {
            e.SetReturnValue(displayHandler);
        }

        void BrowserClient_GetContextMenuHandler(object sender, CfxGetContextMenuHandlerEventArgs e) {
            e.SetReturnValue(contextMenuHandler);
        }

        void BrowserClient_GetLoadHandler(object sender, CfxGetLoadHandlerEventArgs e) {
            e.SetReturnValue(loadHandler);
        }

        void BrowserClient_GetLifeSpanHandler(object sender, CfxGetLifeSpanHandlerEventArgs e) {
            e.SetReturnValue(lifeSpanHandler);
        }

        void BrowserClient_GetRequestHandler(object sender, CfxGetRequestHandlerEventArgs e) {
            e.SetReturnValue(requestHandler);
        }
    }
}
