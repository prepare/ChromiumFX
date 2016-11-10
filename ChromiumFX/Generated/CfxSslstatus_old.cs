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
    /// Structure representing the SSL information for a navigation entry.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
    /// </remarks>
    public class CfxSslStatus : CfxLibraryBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxSslStatus Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxSslStatus)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxSslStatus(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxSslStatus(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns true (1) if the status is related to a secure SSL/TLS connection.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
        /// </remarks>
        public bool IsSecureConnection {
            get {
                return 0 != CfxApi.SslStatus.cfx_sslstatus_is_secure_connection(NativePtr);
            }
        }

        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
        /// </remarks>
        public CfxCertStatus CertStatus {
            get {
                return (CfxCertStatus)CfxApi.SslStatus.cfx_sslstatus_get_cert_status(NativePtr);
            }
        }

        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
        /// </remarks>
        public CfxSslVersion Sslversion {
            get {
                return (CfxSslVersion)CfxApi.SslStatus.cfx_sslstatus_get_sslversion(NativePtr);
            }
        }

        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
        /// </remarks>
        public CfxSslContentStatus ContentStatus {
            get {
                return (CfxSslContentStatus)CfxApi.SslStatus.cfx_sslstatus_get_content_status(NativePtr);
            }
        }

        /// <summary>
        /// Returns the X.509 certificate.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_ssl_status_capi.h">cef/include/capi/cef_ssl_status_capi.h</see>.
        /// </remarks>
        public CfxX509Certificate X509Certificate {
            get {
                return CfxX509Certificate.Wrap(CfxApi.SslStatus.cfx_sslstatus_get_x509certificate(NativePtr));
            }
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
