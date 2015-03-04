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
    /// Structure used to represent a single element in the request post data. The
    /// functions of this structure may be called on any thread.
    /// </summary>
    public class CfrPostDataElement : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrPostDataElement Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrPostDataElement)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrPostDataElement(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrPostDataElement object.
        /// </summary>
        public static CfrPostDataElement Create(CfrRuntime remoteRuntime) {
            var call = new CfxPostDataElementCreateRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrPostDataElement.Wrap(call.__retval, remoteRuntime);
        }


        private CfrPostDataElement(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        public bool IsReadOnly {
            get {
                var call = new CfxPostDataElementIsReadOnlyRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return the type of this post data element.
        /// </summary>
        public CfxPostdataElementType Type {
            get {
                var call = new CfxPostDataElementGetTypeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return (CfxPostdataElementType)call.__retval;
            }
        }

        /// <summary>
        /// Return the file name.
        /// </summary>
        public String File {
            get {
                var call = new CfxPostDataElementGetFileRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return the number of bytes.
        /// </summary>
        public int BytesCount {
            get {
                var call = new CfxPostDataElementGetBytesCountRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Remove all contents from the post data element.
        /// </summary>
        public void SetToEmpty() {
            var call = new CfxPostDataElementSetToEmptyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// The post data element will represent a file.
        /// </summary>
        public void SetToFile(string fileName) {
            var call = new CfxPostDataElementSetToFileRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.fileName = fileName;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// The post data element will represent bytes.  The bytes passed in will be
        /// copied.
        /// </summary>
        public void SetToBytes(int size, RemotePtr bytes) {
            var call = new CfxPostDataElementSetToBytesRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.size = size;
            call.bytes = bytes.ptr;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// </summary>
        public int GetBytes(int size, RemotePtr bytes) {
            var call = new CfxPostDataElementGetBytesRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.size = size;
            call.bytes = bytes.ptr;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
