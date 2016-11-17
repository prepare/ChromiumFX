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
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
    /// </remarks>
    public class CfrBrowser : CfrBase {

        internal static CfrBrowser Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrBrowser)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrBrowser(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrBrowser(RemotePtr remotePtr) : base(remotePtr) {}

        /// <summary>
        /// Returns true (1) if the browser can navigate backwards.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool CanGoBack {
            get {
                var call = new CfxBrowserCanGoBackRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the browser can navigate forwards.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool CanGoForward {
            get {
                var call = new CfxBrowserCanGoForwardRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the browser is currently loading.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool IsLoading {
            get {
                var call = new CfxBrowserIsLoadingRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public int Identifier {
            get {
                var call = new CfxBrowserGetIdentifierRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the window is a popup window.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool IsPopup {
            get {
                var call = new CfxBrowserIsPopupRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if a document has been loaded in the browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool HasDocument {
            get {
                var call = new CfxBrowserHasDocumentRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfrFrame MainFrame {
            get {
                var call = new CfxBrowserGetMainFrameRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return CfrFrame.Wrap(new RemotePtr(CfxRemoteCallContext.CurrentContext.connection, call.__retval));
            }
        }

        /// <summary>
        /// Returns the focused frame for the browser window.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfrFrame FocusedFrame {
            get {
                var call = new CfxBrowserGetFocusedFrameRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return CfrFrame.Wrap(new RemotePtr(CfxRemoteCallContext.CurrentContext.connection, call.__retval));
            }
        }

        /// <summary>
        /// Returns the number of frames that currently exist.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public ulong FrameCount {
            get {
                var call = new CfxBrowserGetFrameCountRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public long[] FrameIdentifiers {
            get {
                var call = new CfxBrowserGetFrameIdentifiersRenderProcessCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Navigate backwards.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void GoBack() {
            var call = new CfxBrowserGoBackRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Navigate forwards.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void GoForward() {
            var call = new CfxBrowserGoForwardRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Reload the current page.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void Reload() {
            var call = new CfxBrowserReloadRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void ReloadIgnoreCache() {
            var call = new CfxBrowserReloadIgnoreCacheRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Stop loading the page.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void StopLoad() {
            var call = new CfxBrowserStopLoadRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool IsSame(CfrBrowser that) {
            var call = new CfxBrowserIsSameRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.that = CfrObject.Unwrap(that).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the frame with the specified identifier, or NULL if not found.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfrFrame GetFrame(long identifier) {
            var call = new CfxBrowserGetFrameByIdentifierRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.identifier = identifier;
            call.RequestExecution(RemotePtr.connection);
            return CfrFrame.Wrap(new RemotePtr(CfxRemoteCallContext.CurrentContext.connection, call.__retval));
        }

        /// <summary>
        /// Returns the frame with the specified name, or NULL if not found.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfrFrame GetFrame(string name) {
            var call = new CfxBrowserGetFrameRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.RequestExecution(RemotePtr.connection);
            return CfrFrame.Wrap(new RemotePtr(CfxRemoteCallContext.CurrentContext.connection, call.__retval));
        }

        /// <summary>
        /// Returns the names of all existing frames.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public System.Collections.Generic.List<string> GetFrameNames() {
            var call = new CfxBrowserGetFrameNamesRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Send a message to the specified |targetProcess|. Returns true (1) if the
        /// message was sent successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool SendProcessMessage(CfxProcessId targetProcess, CfrProcessMessage message) {
            var call = new CfxBrowserSendProcessMessageRenderProcessCall();
            call.@this = RemotePtr.ptr;
            call.targetProcess = (int)targetProcess;
            call.message = CfrObject.Unwrap(message).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        internal override void OnDispose(RemotePtr remotePtr) {
            RemotePtr.connection.weakCache.Remove(RemotePtr.ptr);
        }
    }
}
