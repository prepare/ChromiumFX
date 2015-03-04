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
    /// Implement this structure to receive string values asynchronously.
    /// </summary>
    public class CfrStringVisitor : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrStringVisitor Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrStringVisitor)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrStringVisitor(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxStringVisitorCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_Visit(object sender, CfrStringVisitorVisitEventArgs e) {
            var handler = m_Visit;
            if(handler == null) return;
            handler(this, e);
        }


        private CfrStringVisitor(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrStringVisitor(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Method that will be executed.
        /// </summary>
        public event CfrStringVisitorVisitEventHandler Visit {
            add {
                if(m_Visit == null) {
                    var call = new CfxStringVisitorVisitActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_Visit += value;
            }
            remove {
                m_Visit -= value;
                if(m_Visit == null) {
                    var call = new CfxStringVisitorVisitDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrStringVisitorVisitEventHandler m_Visit;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }

    namespace Event {

        public delegate void CfrStringVisitorVisitEventHandler(object sender, CfrStringVisitorVisitEventArgs e);

        /// <summary>
        /// Method that will be executed.
        /// </summary>
        public class CfrStringVisitorVisitEventArgs : CfrEventArgs {

            bool StringFetched;
            string m_String;

            internal CfrStringVisitorVisitEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public string String {
                get {
                    if(!StringFetched) {
                        StringFetched = true;
                        var call = new CfxStringVisitorVisitGetStringRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_String = call.value;
                    }
                    return m_String;
                }
            }

            public override string ToString() {
                return String.Format("String={{{0}}}", String);
            }
        }

    }
}
