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
    /// URL component parts.
    /// </summary>
    public sealed class CfrUrlParts : CfrStructure {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrUrlParts Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrUrlParts)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrUrlParts(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxUrlPartsCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        private CfrUrlParts(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrUrlParts(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        string m_Spec;
        bool m_Spec_fetched;

        /// <summary>
        /// The complete URL specification.
        /// </summary>
        public string Spec {
            get {
                if(!m_Spec_fetched) {
                    var call = new CfxUrlPartsGetSpecRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Spec = call.value;
                    m_Spec_fetched = true;
                }
                return m_Spec;
            }
            set {
                var call = new CfxUrlPartsSetSpecRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Spec = value;
                m_Spec_fetched = true;
            }
        }

        string m_Scheme;
        bool m_Scheme_fetched;

        /// <summary>
        /// Scheme component not including the colon (e.g., "http").
        /// </summary>
        public string Scheme {
            get {
                if(!m_Scheme_fetched) {
                    var call = new CfxUrlPartsGetSchemeRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Scheme = call.value;
                    m_Scheme_fetched = true;
                }
                return m_Scheme;
            }
            set {
                var call = new CfxUrlPartsSetSchemeRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Scheme = value;
                m_Scheme_fetched = true;
            }
        }

        string m_UserName;
        bool m_UserName_fetched;

        /// <summary>
        /// User name component.
        /// </summary>
        public string UserName {
            get {
                if(!m_UserName_fetched) {
                    var call = new CfxUrlPartsGetUserNameRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_UserName = call.value;
                    m_UserName_fetched = true;
                }
                return m_UserName;
            }
            set {
                var call = new CfxUrlPartsSetUserNameRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_UserName = value;
                m_UserName_fetched = true;
            }
        }

        string m_Password;
        bool m_Password_fetched;

        /// <summary>
        /// Password component.
        /// </summary>
        public string Password {
            get {
                if(!m_Password_fetched) {
                    var call = new CfxUrlPartsGetPasswordRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Password = call.value;
                    m_Password_fetched = true;
                }
                return m_Password;
            }
            set {
                var call = new CfxUrlPartsSetPasswordRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Password = value;
                m_Password_fetched = true;
            }
        }

        string m_Host;
        bool m_Host_fetched;

        /// <summary>
        /// Host component. This may be a hostname, an IPv4 address or an IPv6 literal
        /// surrounded by square brackets (e.g., "[2001:db8::1]").
        /// </summary>
        public string Host {
            get {
                if(!m_Host_fetched) {
                    var call = new CfxUrlPartsGetHostRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Host = call.value;
                    m_Host_fetched = true;
                }
                return m_Host;
            }
            set {
                var call = new CfxUrlPartsSetHostRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Host = value;
                m_Host_fetched = true;
            }
        }

        string m_Port;
        bool m_Port_fetched;

        /// <summary>
        /// Port number component.
        /// </summary>
        public string Port {
            get {
                if(!m_Port_fetched) {
                    var call = new CfxUrlPartsGetPortRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Port = call.value;
                    m_Port_fetched = true;
                }
                return m_Port;
            }
            set {
                var call = new CfxUrlPartsSetPortRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Port = value;
                m_Port_fetched = true;
            }
        }

        string m_Origin;
        bool m_Origin_fetched;

        /// <summary>
        /// Origin contains just the scheme, host, and port from a URL. Equivalent to
        /// clearing any username and password, replacing the path with a slash, and
        /// clearing everything after that. This value will be empty for non-standard
        /// URLs.
        /// </summary>
        public string Origin {
            get {
                if(!m_Origin_fetched) {
                    var call = new CfxUrlPartsGetOriginRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Origin = call.value;
                    m_Origin_fetched = true;
                }
                return m_Origin;
            }
            set {
                var call = new CfxUrlPartsSetOriginRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Origin = value;
                m_Origin_fetched = true;
            }
        }

        string m_Path;
        bool m_Path_fetched;

        /// <summary>
        /// Path component including the first slash following the host.
        /// </summary>
        public string Path {
            get {
                if(!m_Path_fetched) {
                    var call = new CfxUrlPartsGetPathRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Path = call.value;
                    m_Path_fetched = true;
                }
                return m_Path;
            }
            set {
                var call = new CfxUrlPartsSetPathRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Path = value;
                m_Path_fetched = true;
            }
        }

        string m_Query;
        bool m_Query_fetched;

        /// <summary>
        /// Query string component (i.e., everything following the '?').
        /// </summary>
        public string Query {
            get {
                if(!m_Query_fetched) {
                    var call = new CfxUrlPartsGetQueryRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Query = call.value;
                    m_Query_fetched = true;
                }
                return m_Query;
            }
            set {
                var call = new CfxUrlPartsSetQueryRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Query = value;
                m_Query_fetched = true;
            }
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
