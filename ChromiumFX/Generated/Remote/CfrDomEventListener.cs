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
    /// Structure to implement for handling DOM events. The functions of this
    /// structure will be called on the render process main thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
    /// </remarks>
    public class CfrDomEventListener : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrDomEventListener Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrDomEventListener)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrDomEventListener(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxDomEventListenerCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_HandleEvent(object sender, CfrDomEventListenerHandleEventEventArgs e) {
            var handler = m_HandleEvent;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }


        private CfrDomEventListener(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrDomEventListener(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Called when an event is received. The event object passed to this function
        /// contains a snapshot of the DOM at the time this function is executed. DOM
        /// objects are only valid for the scope of this function. Do not keep
        /// references to or attempt to access any DOM objects outside the scope of
        /// this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public event CfrDomEventListenerHandleEventEventHandler HandleEvent {
            add {
                if(m_HandleEvent == null) {
                    var call = new CfxDomEventListenerHandleEventActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_HandleEvent += value;
            }
            remove {
                m_HandleEvent -= value;
                if(m_HandleEvent == null) {
                    var call = new CfxDomEventListenerHandleEventDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrDomEventListenerHandleEventEventHandler m_HandleEvent;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }

    namespace Event {

        /// <summary>
        /// Called when an event is received. The event object passed to this function
        /// contains a snapshot of the DOM at the time this function is executed. DOM
        /// objects are only valid for the scope of this function. Do not keep
        /// references to or attempt to access any DOM objects outside the scope of
        /// this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public delegate void CfrDomEventListenerHandleEventEventHandler(object sender, CfrDomEventListenerHandleEventEventArgs e);

        /// <summary>
        /// Called when an event is received. The event object passed to this function
        /// contains a snapshot of the DOM at the time this function is executed. DOM
        /// objects are only valid for the scope of this function. Do not keep
        /// references to or attempt to access any DOM objects outside the scope of
        /// this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public class CfrDomEventListenerHandleEventEventArgs : CfrEventArgs {

            bool EventFetched;
            CfrDomEvent m_Event;

            internal CfrDomEventListenerHandleEventEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            /// <summary>
            /// Get the Event parameter for the <see cref="CfrDomEventListener.HandleEvent"/> render process callback.
            /// </summary>
            public CfrDomEvent Event {
                get {
                    CheckAccess();
                    if(!EventFetched) {
                        EventFetched = true;
                        var call = new CfxDomEventListenerHandleEventGetEventRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Event = CfrDomEvent.Wrap(call.value, remoteRuntime);
                    }
                    return m_Event;
                }
            }

            public override string ToString() {
                return String.Format("Event={{{0}}}", Event);
            }
        }

    }
}
