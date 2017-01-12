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
    /// Structure used to represent a web response. The functions of this structure
    /// may be called on any thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
    /// </remarks>
    public class CfrResponse : CfrLibraryBase {

        internal static CfrResponse Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrResponse)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrResponse(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrResponse object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public static CfrResponse Create() {
            var call = new CfxResponseCreateRemoteCall();
            call.RequestExecution();
            return CfrResponse.Wrap(new RemotePtr(call.__retval));
        }


        private CfrResponse(RemotePtr remotePtr) : base(remotePtr) {}

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                var call = new CfxResponseIsReadOnlyRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// 
        /// Set the response error code. This can be used by custom scheme handlers to
        /// return errors during initial request processing.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public CfxErrorCode Error {
            get {
                var call = new CfxResponseGetErrorRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return (CfxErrorCode)call.__retval;
            }
            set {
                var call = new CfxResponseSetErrorRemoteCall();
                call.@this = RemotePtr.ptr;
                call.value = (int)value;
                call.RequestExecution(RemotePtr.connection);
            }
        }

        /// <summary>
        /// Get the response status code.
        /// 
        /// Set the response status code.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public int Status {
            get {
                var call = new CfxResponseGetStatusRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
            set {
                var call = new CfxResponseSetStatusRemoteCall();
                call.@this = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
            }
        }

        /// <summary>
        /// Get the response status text.
        /// 
        /// Set the response status text.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public string StatusText {
            get {
                var call = new CfxResponseGetStatusTextRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
            set {
                var call = new CfxResponseSetStatusTextRemoteCall();
                call.@this = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
            }
        }

        /// <summary>
        /// Get the response mime type.
        /// 
        /// Set the response mime type.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public string MimeType {
            get {
                var call = new CfxResponseGetMimeTypeRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
            set {
                var call = new CfxResponseSetMimeTypeRemoteCall();
                call.@this = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
            }
        }

        /// <summary>
        /// Get the value for the specified response header field.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public string GetHeader(string name) {
            var call = new CfxResponseGetHeaderRemoteCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Get all response header fields.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public System.Collections.Generic.List<string[]> GetHeaderMap() {
            var call = new CfxResponseGetHeaderMapRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Set all response header fields.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public void SetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            var call = new CfxResponseSetHeaderMapRemoteCall();
            call.@this = RemotePtr.ptr;
            call.headerMap = headerMap;
            call.RequestExecution(RemotePtr.connection);
        }
    }
}
