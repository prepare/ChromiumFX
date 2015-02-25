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

namespace Chromium {
    /// <summary>
    /// URL component parts.
    /// </summary>
    public sealed class CfxUrlParts : CfxStructure {

        private string m_Spec;
        private string m_Scheme;
        private string m_UserName;
        private string m_Password;
        private string m_Host;
        private string m_Port;
        private string m_Origin;
        private string m_Path;
        private string m_Query;

        public CfxUrlParts() : base(CfxApi.cfx_urlparts_ctor, CfxApi.cfx_urlparts_dtor) {}

        /// <summary>
        /// The complete URL specification.
        /// </summary>
        public string Spec {
            get {
                return m_Spec;
            }
            set {
                m_Spec = value;
            }
        }

        /// <summary>
        /// Scheme component not including the colon (e.g., "http").
        /// </summary>
        public string Scheme {
            get {
                return m_Scheme;
            }
            set {
                m_Scheme = value;
            }
        }

        /// <summary>
        /// User name component.
        /// </summary>
        public string UserName {
            get {
                return m_UserName;
            }
            set {
                m_UserName = value;
            }
        }

        /// <summary>
        /// Password component.
        /// </summary>
        public string Password {
            get {
                return m_Password;
            }
            set {
                m_Password = value;
            }
        }

        /// <summary>
        /// Host component. This may be a hostname, an IPv4 address or an IPv6 literal
        /// surrounded by square brackets (e.g., "[2001:db8::1]").
        /// </summary>
        public string Host {
            get {
                return m_Host;
            }
            set {
                m_Host = value;
            }
        }

        /// <summary>
        /// Port number component.
        /// </summary>
        public string Port {
            get {
                return m_Port;
            }
            set {
                m_Port = value;
            }
        }

        /// <summary>
        /// Origin contains just the scheme, host, and port from a URL. Equivalent to
        /// clearing any username and password, replacing the path with a slash, and
        /// clearing everything after that. This value will be empty for non-standard
        /// URLs.
        /// </summary>
        public string Origin {
            get {
                return m_Origin;
            }
            set {
                m_Origin = value;
            }
        }

        /// <summary>
        /// Path component including the first slash following the host.
        /// </summary>
        public string Path {
            get {
                return m_Path;
            }
            set {
                m_Path = value;
            }
        }

        /// <summary>
        /// Query string component (i.e., everything following the '?').
        /// </summary>
        public string Query {
            get {
                return m_Query;
            }
            set {
                m_Query = value;
            }
        }

        protected override void CopyToNative() {
            var m_Spec_pinned = new PinnedString(m_Spec);
            var m_Scheme_pinned = new PinnedString(m_Scheme);
            var m_UserName_pinned = new PinnedString(m_UserName);
            var m_Password_pinned = new PinnedString(m_Password);
            var m_Host_pinned = new PinnedString(m_Host);
            var m_Port_pinned = new PinnedString(m_Port);
            var m_Origin_pinned = new PinnedString(m_Origin);
            var m_Path_pinned = new PinnedString(m_Path);
            var m_Query_pinned = new PinnedString(m_Query);
            CfxApi.cfx_urlparts_copy_to_native(nativePtrUnchecked, m_Spec_pinned.Obj.PinnedPtr, m_Spec_pinned.Length, m_Scheme_pinned.Obj.PinnedPtr, m_Scheme_pinned.Length, m_UserName_pinned.Obj.PinnedPtr, m_UserName_pinned.Length, m_Password_pinned.Obj.PinnedPtr, m_Password_pinned.Length, m_Host_pinned.Obj.PinnedPtr, m_Host_pinned.Length, m_Port_pinned.Obj.PinnedPtr, m_Port_pinned.Length, m_Origin_pinned.Obj.PinnedPtr, m_Origin_pinned.Length, m_Path_pinned.Obj.PinnedPtr, m_Path_pinned.Length, m_Query_pinned.Obj.PinnedPtr, m_Query_pinned.Length);
            m_Spec_pinned.Obj.Free();
            m_Scheme_pinned.Obj.Free();
            m_UserName_pinned.Obj.Free();
            m_Password_pinned.Obj.Free();
            m_Host_pinned.Obj.Free();
            m_Port_pinned.Obj.Free();
            m_Origin_pinned.Obj.Free();
            m_Path_pinned.Obj.Free();
            m_Query_pinned.Obj.Free();
        }

    }
}
