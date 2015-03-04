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
    /// Structure used to represent a web request. The functions of this structure
    /// may be called on any thread.
    /// </summary>
    public class CfrRequest : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrRequest Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrRequest)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrRequest(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrRequest object.
        /// </summary>
        public static CfrRequest Create(CfrRuntime remoteRuntime) {
            var call = new CfxRequestCreateRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrRequest.Wrap(call.__retval, remoteRuntime);
        }


        private CfrRequest(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        public bool IsReadOnly {
            get {
                var call = new CfxRequestIsReadOnlyRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Get the fully qualified URL.
        /// 
        /// Set the fully qualified URL.
        /// </summary>
        public String Url {
            get {
                var call = new CfxRequestGetUrlRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
            set {
                var call = new CfxRequestSetUrlRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = value;
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Get the request function type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// 
        /// Set the request function type.
        /// </summary>
        public String Method {
            get {
                var call = new CfxRequestGetMethodRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
            set {
                var call = new CfxRequestSetMethodRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = value;
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Get the post data.
        /// 
        /// Set the post data.
        /// </summary>
        public CfrPostData PostData {
            get {
                var call = new CfxRequestGetPostDataRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrPostData.Wrap(call.__retval, remoteRuntime);
            }
            set {
                var call = new CfxRequestSetPostDataRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = CfrObject.Unwrap(value);
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Get the flags used in combination with CfrUrlRequest. See
        /// CfrUrlRequestFlags for supported values.
        /// 
        /// Set the flags used in combination with CfrUrlRequest.  See
        /// CfrUrlRequestFlags for supported values.
        /// </summary>
        public int Flags {
            get {
                var call = new CfxRequestGetFlagsRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
            set {
                var call = new CfxRequestSetFlagsRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = value;
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CfrUrlRequest.
        /// 
        /// Get the URL to the first party for cookies used in combination with
        /// CfrUrlRequest.
        /// </summary>
        public String FirstPartyForCookies {
            get {
                var call = new CfxRequestGetFirstPartyForCookiesRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
            set {
                var call = new CfxRequestSetFirstPartyForCookiesRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = value;
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// </summary>
        public CfxResourceType ResourceType {
            get {
                var call = new CfxRequestGetResourceTypeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return (CfxResourceType)call.__retval;
            }
        }

        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or sub-
        /// frame navigation.
        /// </summary>
        public CfxTransitionType TransitionType {
            get {
                var call = new CfxRequestGetTransitionTypeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return (CfxTransitionType)call.__retval;
            }
        }

        /// <summary>
        /// Get the header values.
        /// </summary>
        public void GetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            var call = new CfxRequestGetHeaderMapRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.headerMap = headerMap;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Set the header values.
        /// </summary>
        public void SetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            var call = new CfxRequestSetHeaderMapRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.headerMap = headerMap;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Set all values at one time.
        /// </summary>
        public void Set(string url, string method, CfrPostData postData, System.Collections.Generic.List<string[]> headerMap) {
            var call = new CfxRequestSetRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.url = url;
            call.method = method;
            call.postData = CfrObject.Unwrap(postData);
            call.headerMap = headerMap;
            call.Execute(remoteRuntime.connection);
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
