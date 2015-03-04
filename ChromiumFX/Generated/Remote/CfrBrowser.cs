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

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    /// <summary>
    /// Structure used to represent a browser window. When used in the browser
    /// process the functions of this structure may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// functions of this structure may only be called on the main thread.
    /// </summary>
    public class CfrBrowser : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrBrowser Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrBrowser)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrBrowser(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrBrowser(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if the browser can navigate backwards.
        /// </summary>
        public bool CanGoBack {
            get {
                var call = new CfxBrowserCanGoBackRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the browser can navigate forwards.
        /// </summary>
        public bool CanGoForward {
            get {
                var call = new CfxBrowserCanGoForwardRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the browser is currently loading.
        /// </summary>
        public bool IsLoading {
            get {
                var call = new CfxBrowserIsLoadingRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// </summary>
        public int Identifier {
            get {
                var call = new CfxBrowserGetIdentifierRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the window is a popup window.
        /// </summary>
        public bool IsPopup {
            get {
                var call = new CfxBrowserIsPopupRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if a document has been loaded in the browser.
        /// </summary>
        public bool HasDocument {
            get {
                var call = new CfxBrowserHasDocumentRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// </summary>
        public CfrFrame MainFrame {
            get {
                var call = new CfxBrowserGetMainFrameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrFrame.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the focused frame for the browser window.
        /// </summary>
        public CfrFrame FocusedFrame {
            get {
                var call = new CfxBrowserGetFocusedFrameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrFrame.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the number of frames that currently exist.
        /// </summary>
        public int FrameCount {
            get {
                var call = new CfxBrowserGetFrameCountRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// </summary>
        public long[] FrameIdentifiers {
            get {
                var call = new CfxBrowserGetFrameIdentifiersRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Navigate backwards.
        /// </summary>
        public void GoBack() {
            var call = new CfxBrowserGoBackRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Navigate forwards.
        /// </summary>
        public void GoForward() {
            var call = new CfxBrowserGoForwardRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Reload the current page.
        /// </summary>
        public void Reload() {
            var call = new CfxBrowserReloadRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// </summary>
        public void ReloadIgnoreCache() {
            var call = new CfxBrowserReloadIgnoreCacheRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Stop loading the page.
        /// </summary>
        public void StopLoad() {
            var call = new CfxBrowserStopLoadRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        public bool IsSame(CfrBrowser that) {
            var call = new CfxBrowserIsSameRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.that = CfrObject.Unwrap(that);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the frame with the specified identifier, or NULL if not found.
        /// </summary>
        public CfrFrame GetFrameByIdentifier(long identifier) {
            var call = new CfxBrowserGetFrameByIdentifierRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.identifier = identifier;
            call.Execute(remoteRuntime.connection);
            return CfrFrame.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the frame with the specified name, or NULL if not found.
        /// </summary>
        public CfrFrame GetFrame(string name) {
            var call = new CfxBrowserGetFrameRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.name = name;
            call.Execute(remoteRuntime.connection);
            return CfrFrame.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the names of all existing frames.
        /// </summary>
        public void GetFrameNames(System.Collections.Generic.List<string> names) {
            var call = new CfxBrowserGetFrameNamesRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.names = names;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Send a message to the specified |targetProcess|. Returns true (1) if the
        /// message was sent successfully.
        /// </summary>
        public bool SendProcessMessage(CfxProcessId targetProcess, CfrProcessMessage message) {
            var call = new CfxBrowserSendProcessMessageRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.targetProcess = (int)targetProcess;
            call.message = CfrObject.Unwrap(message);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
