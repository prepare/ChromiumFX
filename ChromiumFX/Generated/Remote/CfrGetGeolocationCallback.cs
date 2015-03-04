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
    /// Implement this structure to receive geolocation updates. The functions of
    /// this structure will be called on the browser process UI thread.
    /// </summary>
    public class CfrGetGeolocationCallback : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrGetGeolocationCallback Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrGetGeolocationCallback)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrGetGeolocationCallback(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxGetGeolocationCallbackCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_OnLocationUpdate(object sender, CfrGetGeolocationCallbackOnLocationUpdateEventArgs e) {
            var handler = m_OnLocationUpdate;
            if(handler == null) return;
            handler(this, e);
        }


        private CfrGetGeolocationCallback(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrGetGeolocationCallback(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Called with the 'best available' location information or, if the location
        /// update failed, with error information.
        /// </summary>
        public event CfrGetGeolocationCallbackOnLocationUpdateEventHandler OnLocationUpdate {
            add {
                if(m_OnLocationUpdate == null) {
                    var call = new CfxGetGeolocationCallbackOnLocationUpdateActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnLocationUpdate += value;
            }
            remove {
                m_OnLocationUpdate -= value;
                if(m_OnLocationUpdate == null) {
                    var call = new CfxGetGeolocationCallbackOnLocationUpdateDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrGetGeolocationCallbackOnLocationUpdateEventHandler m_OnLocationUpdate;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }

    namespace Event {

        public delegate void CfrGetGeolocationCallbackOnLocationUpdateEventHandler(object sender, CfrGetGeolocationCallbackOnLocationUpdateEventArgs e);

        /// <summary>
        /// Called with the 'best available' location information or, if the location
        /// update failed, with error information.
        /// </summary>
        public class CfrGetGeolocationCallbackOnLocationUpdateEventArgs : CfrEventArgs {

            bool PositionFetched;
            CfrGeoposition m_Position;

            internal CfrGetGeolocationCallbackOnLocationUpdateEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public CfrGeoposition Position {
                get {
                    if(!PositionFetched) {
                        PositionFetched = true;
                        var call = new CfxGetGeolocationCallbackOnLocationUpdateGetPositionRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_Position = CfrGeoposition.Wrap(call.value, remoteRuntime);
                    }
                    return m_Position;
                }
            }

            public override string ToString() {
                return String.Format("Position={{{0}}}", Position);
            }
        }

    }
}
