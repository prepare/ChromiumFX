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
    using Event;

    /// <summary>
    /// Implement this structure to handle events related to browser load status. The
    /// functions of this structure will be called on the browser process UI thread
    /// or render process main thread (TID_RENDERER).
    /// </summary>
    public class CfrLoadHandler : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrLoadHandler Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrLoadHandler)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrLoadHandler(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxLoadHandlerCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_OnLoadingStateChange(object sender, CfrOnLoadingStateChangeEventArgs e) {
            var handler = m_OnLoadingStateChange;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnLoadStart(object sender, CfrOnLoadStartEventArgs e) {
            var handler = m_OnLoadStart;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnLoadEnd(object sender, CfrOnLoadEndEventArgs e) {
            var handler = m_OnLoadEnd;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnLoadError(object sender, CfrOnLoadErrorEventArgs e) {
            var handler = m_OnLoadError;
            if(handler == null) return;
            handler(this, e);
        }


        private CfrLoadHandler(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrLoadHandler(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Called when the loading state has changed. This callback will be executed
        /// twice -- once when loading is initiated either programmatically or by user
        /// action, and once when loading is terminated due to completion, cancellation
        /// of failure.
        /// </summary>
        public event CfrOnLoadingStateChangeEventHandler OnLoadingStateChange {
            add {
                if(m_OnLoadingStateChange == null) {
                    var call = new CfxOnLoadingStateChangeActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnLoadingStateChange += value;
            }
            remove {
                m_OnLoadingStateChange -= value;
                if(m_OnLoadingStateChange == null) {
                    var call = new CfxOnLoadingStateChangeDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnLoadingStateChangeEventHandler m_OnLoadingStateChange;


        /// <summary>
        /// Called when the browser begins loading a frame. The |Frame| value will
        /// never be NULL -- call the is_main() function to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This
        /// function may not be called for a particular frame if the load request for
        /// that frame fails. For notification of overall browser load status use
        /// OnLoadingStateChange instead.
        /// </summary>
        public event CfrOnLoadStartEventHandler OnLoadStart {
            add {
                if(m_OnLoadStart == null) {
                    var call = new CfxOnLoadStartActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnLoadStart += value;
            }
            remove {
                m_OnLoadStart -= value;
                if(m_OnLoadStart == null) {
                    var call = new CfxOnLoadStartDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnLoadStartEventHandler m_OnLoadStart;


        /// <summary>
        /// Called when the browser is done loading a frame. The |Frame| value will
        /// never be NULL -- call the is_main() function to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This
        /// function will always be called for all frames irrespective of whether the
        /// request completes successfully.
        /// </summary>
        public event CfrOnLoadEndEventHandler OnLoadEnd {
            add {
                if(m_OnLoadEnd == null) {
                    var call = new CfxOnLoadEndActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnLoadEnd += value;
            }
            remove {
                m_OnLoadEnd -= value;
                if(m_OnLoadEnd == null) {
                    var call = new CfxOnLoadEndDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnLoadEndEventHandler m_OnLoadEnd;


        /// <summary>
        /// Called when the resource load for a navigation fails or is canceled.
        /// |ErrorCode| is the error code number, |ErrorText| is the error text and
        /// |FailedUrl| is the URL that failed to load. See net\base\net_error_list.h
        /// for complete descriptions of the error codes.
        /// </summary>
        public event CfrOnLoadErrorEventHandler OnLoadError {
            add {
                if(m_OnLoadError == null) {
                    var call = new CfxOnLoadErrorActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnLoadError += value;
            }
            remove {
                m_OnLoadError -= value;
                if(m_OnLoadError == null) {
                    var call = new CfxOnLoadErrorDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnLoadErrorEventHandler m_OnLoadError;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }

    namespace Event {

        public delegate void CfrOnLoadingStateChangeEventHandler(object sender, CfrOnLoadingStateChangeEventArgs e);

        /// <summary>
        /// Called when the loading state has changed. This callback will be executed
        /// twice -- once when loading is initiated either programmatically or by user
        /// action, and once when loading is terminated due to completion, cancellation
        /// of failure.
        /// </summary>
        public class CfrOnLoadingStateChangeEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool IsLoadingFetched;
            bool m_IsLoading;
            bool CanGoBackFetched;
            bool m_CanGoBack;
            bool CanGoForwardFetched;
            bool m_CanGoForward;

            internal CfrOnLoadingStateChangeEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public CfrBrowser Browser {
                get {
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnLoadingStateChangeGetBrowserRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                    }
                    return m_Browser;
                }
            }
            public bool IsLoading {
                get {
                    if(!IsLoadingFetched) {
                        IsLoadingFetched = true;
                        var call = new CfxOnLoadingStateChangeGetIsLoadingRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_IsLoading = call.value;
                    }
                    return m_IsLoading;
                }
            }
            public bool CanGoBack {
                get {
                    if(!CanGoBackFetched) {
                        CanGoBackFetched = true;
                        var call = new CfxOnLoadingStateChangeGetCanGoBackRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_CanGoBack = call.value;
                    }
                    return m_CanGoBack;
                }
            }
            public bool CanGoForward {
                get {
                    if(!CanGoForwardFetched) {
                        CanGoForwardFetched = true;
                        var call = new CfxOnLoadingStateChangeGetCanGoForwardRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_CanGoForward = call.value;
                    }
                    return m_CanGoForward;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, IsLoading={{{1}}}, CanGoBack={{{2}}}, CanGoForward={{{3}}}", Browser, IsLoading, CanGoBack, CanGoForward);
            }
        }

        public delegate void CfrOnLoadStartEventHandler(object sender, CfrOnLoadStartEventArgs e);

        /// <summary>
        /// Called when the browser begins loading a frame. The |Frame| value will
        /// never be NULL -- call the is_main() function to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This
        /// function may not be called for a particular frame if the load request for
        /// that frame fails. For notification of overall browser load status use
        /// OnLoadingStateChange instead.
        /// </summary>
        public class CfrOnLoadStartEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;

            internal CfrOnLoadStartEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public CfrBrowser Browser {
                get {
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnLoadStartGetBrowserRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                    }
                    return m_Browser;
                }
            }
            public CfrFrame Frame {
                get {
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnLoadStartGetFrameRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                    }
                    return m_Frame;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}", Browser, Frame);
            }
        }

        public delegate void CfrOnLoadEndEventHandler(object sender, CfrOnLoadEndEventArgs e);

        /// <summary>
        /// Called when the browser is done loading a frame. The |Frame| value will
        /// never be NULL -- call the is_main() function to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This
        /// function will always be called for all frames irrespective of whether the
        /// request completes successfully.
        /// </summary>
        public class CfrOnLoadEndEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool HttpStatusCodeFetched;
            int m_HttpStatusCode;

            internal CfrOnLoadEndEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public CfrBrowser Browser {
                get {
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnLoadEndGetBrowserRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                    }
                    return m_Browser;
                }
            }
            public CfrFrame Frame {
                get {
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnLoadEndGetFrameRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                    }
                    return m_Frame;
                }
            }
            public int HttpStatusCode {
                get {
                    if(!HttpStatusCodeFetched) {
                        HttpStatusCodeFetched = true;
                        var call = new CfxOnLoadEndGetHttpStatusCodeRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_HttpStatusCode = call.value;
                    }
                    return m_HttpStatusCode;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, HttpStatusCode={{{2}}}", Browser, Frame, HttpStatusCode);
            }
        }

        public delegate void CfrOnLoadErrorEventHandler(object sender, CfrOnLoadErrorEventArgs e);

        /// <summary>
        /// Called when the resource load for a navigation fails or is canceled.
        /// |ErrorCode| is the error code number, |ErrorText| is the error text and
        /// |FailedUrl| is the URL that failed to load. See net\base\net_error_list.h
        /// for complete descriptions of the error codes.
        /// </summary>
        public class CfrOnLoadErrorEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool ErrorCodeFetched;
            CfxErrorCode m_ErrorCode;
            bool ErrorTextFetched;
            string m_ErrorText;
            bool FailedUrlFetched;
            string m_FailedUrl;

            internal CfrOnLoadErrorEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public CfrBrowser Browser {
                get {
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnLoadErrorGetBrowserRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                    }
                    return m_Browser;
                }
            }
            public CfrFrame Frame {
                get {
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnLoadErrorGetFrameRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                    }
                    return m_Frame;
                }
            }
            public CfxErrorCode ErrorCode {
                get {
                    if(!ErrorCodeFetched) {
                        ErrorCodeFetched = true;
                        var call = new CfxOnLoadErrorGetErrorCodeRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_ErrorCode = (CfxErrorCode)call.value;
                    }
                    return m_ErrorCode;
                }
            }
            public string ErrorText {
                get {
                    if(!ErrorTextFetched) {
                        ErrorTextFetched = true;
                        var call = new CfxOnLoadErrorGetErrorTextRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_ErrorText = call.value;
                    }
                    return m_ErrorText;
                }
            }
            public string FailedUrl {
                get {
                    if(!FailedUrlFetched) {
                        FailedUrlFetched = true;
                        var call = new CfxOnLoadErrorGetFailedUrlRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_FailedUrl = call.value;
                    }
                    return m_FailedUrl;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, ErrorCode={{{2}}}, ErrorText={{{3}}}, FailedUrl={{{4}}}", Browser, Frame, ErrorCode, ErrorText, FailedUrl);
            }
        }

    }
}
