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
    /// Cookie information.
    /// </summary>
    public sealed class CfxCookie : CfxStructure {

        internal static CfxCookie Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxCookie(nativePtr);
        }

        private string m_Name;
        private string m_Value;
        private string m_Domain;
        private string m_Path;
        private bool m_Secure;
        private bool m_HttpOnly;
        private CfxTime m_Creation;
        private CfxTime m_LastAccess;
        private bool m_HasExpires;
        private CfxTime m_Expires;

        public CfxCookie() : base(CfxApi.cfx_cookie_ctor, CfxApi.cfx_cookie_dtor) {}
        internal CfxCookie(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_cookie_ctor, CfxApi.cfx_cookie_dtor) {}

        /// <summary>
        /// The cookie name.
        /// </summary>
        public string Name {
            get {
                return m_Name;
            }
            set {
                m_Name = value;
            }
        }

        /// <summary>
        /// The cookie value.
        /// </summary>
        public string Value {
            get {
                return m_Value;
            }
            set {
                m_Value = value;
            }
        }

        /// <summary>
        /// If |domain| is empty a host cookie will be created instead of a domain
        /// cookie. Domain cookies are stored with a leading "." and are visible to
        /// sub-domains whereas host cookies are not.
        /// </summary>
        public string Domain {
            get {
                return m_Domain;
            }
            set {
                m_Domain = value;
            }
        }

        /// <summary>
        /// If |path| is non-empty only URLs at or below the path will get the cookie
        /// value.
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
        /// If |secure| is true the cookie will only be sent for HTTPS requests.
        /// </summary>
        public bool Secure {
            get {
                return m_Secure;
            }
            set {
                m_Secure = value;
            }
        }

        /// <summary>
        /// If |httponly| is true the cookie will only be sent for HTTP requests.
        /// </summary>
        public bool HttpOnly {
            get {
                return m_HttpOnly;
            }
            set {
                m_HttpOnly = value;
            }
        }

        /// <summary>
        /// The cookie creation date. This is automatically populated by the system on
        /// cookie creation.
        /// </summary>
        public CfxTime Creation {
            get {
                return m_Creation;
            }
            set {
                m_Creation = value;
            }
        }

        /// <summary>
        /// The cookie last access date. This is automatically populated by the system
        /// on access.
        /// </summary>
        public CfxTime LastAccess {
            get {
                return m_LastAccess;
            }
            set {
                m_LastAccess = value;
            }
        }

        /// <summary>
        /// The cookie expiration date is only valid if |has_expires| is true.
        /// </summary>
        public bool HasExpires {
            get {
                return m_HasExpires;
            }
            set {
                m_HasExpires = value;
            }
        }

        public CfxTime Expires {
            get {
                return m_Expires;
            }
            set {
                m_Expires = value;
            }
        }

        protected override void CopyToNative() {
            var m_Name_pinned = new PinnedString(m_Name);
            var m_Value_pinned = new PinnedString(m_Value);
            var m_Domain_pinned = new PinnedString(m_Domain);
            var m_Path_pinned = new PinnedString(m_Path);
            CfxApi.cfx_cookie_copy_to_native(nativePtrUnchecked, m_Name_pinned.Obj.PinnedPtr, m_Name_pinned.Length, m_Value_pinned.Obj.PinnedPtr, m_Value_pinned.Length, m_Domain_pinned.Obj.PinnedPtr, m_Domain_pinned.Length, m_Path_pinned.Obj.PinnedPtr, m_Path_pinned.Length, m_Secure ? 1 : 0, m_HttpOnly ? 1 : 0, CfxTime.Unwrap(m_Creation), CfxTime.Unwrap(m_LastAccess), m_HasExpires ? 1 : 0, CfxTime.Unwrap(m_Expires));
            m_Name_pinned.Obj.Free();
            m_Value_pinned.Obj.Free();
            m_Domain_pinned.Obj.Free();
            m_Path_pinned.Obj.Free();
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            IntPtr name_str = IntPtr.Zero; int name_length = 0;
            IntPtr value_str = IntPtr.Zero; int value_length = 0;
            IntPtr domain_str = IntPtr.Zero; int domain_length = 0;
            IntPtr path_str = IntPtr.Zero; int path_length = 0;
            int secure = default(int);
            int httponly = default(int);
            IntPtr creation = default(IntPtr);
            IntPtr last_access = default(IntPtr);
            int has_expires = default(int);
            IntPtr expires = default(IntPtr);
            CfxApi.cfx_cookie_copy_to_managed(nativePtr, out name_str, out name_length, out value_str, out value_length, out domain_str, out domain_length, out path_str, out path_length, out secure, out httponly, out creation, out last_access, out has_expires, out expires);
            m_Name = name_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(name_str, name_length) : String.Empty;;
            m_Value = value_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(value_str, value_length) : String.Empty;;
            m_Domain = domain_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(domain_str, domain_length) : String.Empty;;
            m_Path = path_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(path_str, path_length) : String.Empty;;
            m_Secure = 0 != secure;
            m_HttpOnly = 0 != httponly;
            m_Creation = CfxTime.Wrap(creation);
            m_LastAccess = CfxTime.Wrap(last_access);
            m_HasExpires = 0 != has_expires;
            m_Expires = CfxTime.Wrap(expires);
        }
    }
}
