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
    /// Structure used to represent a frame in the browser window. When used in the
    /// browser process the functions of this structure may be called on any thread
    /// unless otherwise indicated in the comments. When used in the render process
    /// the functions of this structure may only be called on the main thread.
    /// </summary>
    public class CfrFrame : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrFrame Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrFrame)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrFrame(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrFrame(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// True if this object is currently attached to a valid frame.
        /// </summary>
        public bool IsValid {
            get {
                var call = new CfxFrameIsValidRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is the main (top-level) frame.
        /// </summary>
        public bool IsMain {
            get {
                var call = new CfxFrameIsMainRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is the focused frame.
        /// </summary>
        public bool IsFocused {
            get {
                var call = new CfxFrameIsFocusedRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the name for this frame. If the frame has an assigned name (for
        /// example, set via the iframe "name" attribute) then that value will be
        /// returned. Otherwise a unique name will be constructed based on the frame
        /// parent hierarchy. The main (top-level) frame will always have an NULL name
        /// value.
        /// </summary>
        public String Name {
            get {
                var call = new CfxFrameGetNameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the globally unique identifier for this frame.
        /// </summary>
        public long Identifier {
            get {
                var call = new CfxFrameGetIdentifierRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// </summary>
        public CfrFrame Parent {
            get {
                var call = new CfxFrameGetParentRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrFrame.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// </summary>
        public String Url {
            get {
                var call = new CfxFrameGetUrlRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// </summary>
        public CfrBrowser Browser {
            get {
                var call = new CfxFrameGetBrowserRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrBrowser.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Get the V8 context associated with the frame. This function can only be
        /// called from the render process.
        /// </summary>
        public CfrV8Context V8Context {
            get {
                var call = new CfxFrameGetV8ContextRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrV8Context.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Execute undo in this frame.
        /// </summary>
        public void Undo() {
            var call = new CfxFrameUndoRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute redo in this frame.
        /// </summary>
        public void Redo() {
            var call = new CfxFrameRedoRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute cut in this frame.
        /// </summary>
        public void Cut() {
            var call = new CfxFrameCutRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute copy in this frame.
        /// </summary>
        public void Copy() {
            var call = new CfxFrameCopyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute paste in this frame.
        /// </summary>
        public void Paste() {
            var call = new CfxFramePasteRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute delete in this frame.
        /// </summary>
        public void Del() {
            var call = new CfxFrameDelRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute select all in this frame.
        /// </summary>
        public void SelectAll() {
            var call = new CfxFrameSelectAllRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// </summary>
        public void GetSource(CfrStringVisitor visitor) {
            var call = new CfxFrameGetSourceRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.visitor = CfrObject.Unwrap(visitor);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// </summary>
        public void GetText(CfrStringVisitor visitor) {
            var call = new CfxFrameGetTextRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.visitor = CfrObject.Unwrap(visitor);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Load the request represented by the |request| object.
        /// </summary>
        public void LoadRequest(CfrRequest request) {
            var call = new CfxFrameLoadRequestRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.request = CfrObject.Unwrap(request);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Load the specified |url|.
        /// </summary>
        public void LoadUrl(string url) {
            var call = new CfxFrameLoadUrlRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.url = url;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Load the contents of |stringVal| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// </summary>
        public void LoadString(string stringVal, string url) {
            var call = new CfxFrameLoadStringRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.stringVal = stringVal;
            call.url = url;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Execute a string of JavaScript code in this frame. The |scriptUrl|
        /// parameter is the URL where the script in question can be found, if any. The
        /// renderer may request this URL to show the developer the source of the
        /// error.  The |startLine| parameter is the base line number to use for error
        /// reporting.
        /// </summary>
        public void ExecuteJavaScript(string code, string scriptUrl, int startLine) {
            var call = new CfxFrameExecuteJavaScriptRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.code = code;
            call.scriptUrl = scriptUrl;
            call.startLine = startLine;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Visit the DOM document. This function can only be called from the render
        /// process.
        /// </summary>
        public void VisitDom(CfrDomVisitor visitor) {
            var call = new CfxFrameVisitDomRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.visitor = CfrObject.Unwrap(visitor);
            call.Execute(remoteRuntime.connection);
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
