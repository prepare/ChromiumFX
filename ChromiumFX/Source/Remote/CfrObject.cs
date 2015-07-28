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



using System;

namespace Chromium.Remote {

    /// <summary>
    /// Base class for all remote wrapper classes for CEF structs.
    /// </summary>
    public abstract class CfrObject : IDisposable {

        internal static ulong Unwrap(CfrObject remoteObject) {
            return remoteObject == null ? 0 : remoteObject.proxyId;
        }

        internal readonly CfxRemoteContext remoteContext;
        internal ulong m_proxyId;


        internal CfrObject(ulong proxyId) {
            this.m_proxyId = proxyId;
            this.remoteContext = CfxRemoteContext.CurrentContext;
        }
        
        internal ulong proxyId {
            get {
                if(m_proxyId == 0) {
                    throw new ObjectDisposedException(this.GetType().Name);
                } else {
                    return m_proxyId;
                }
            }
        }

        /// <summary>
        /// The remote context of the render process 
        /// this object belongs to.
        /// </summary>
        public CfxRemoteContext RemoteContext { get { return remoteContext; } }

        /// <summary>
        /// Address of the underlying native CEF object
        /// in the render process memory space.
        /// </summary>
        public RemotePtr RemotePtr {
            get {
                var call = new GetRemotePtrRemoteCall();
                call.proxyId = proxyId;
                call.Execute();
                return new RemotePtr(call.retval);
            }
        }


        internal abstract void OnDispose(ulong proxyId);

        private void Release() {
            if(m_proxyId != 0) {
                try {
                    OnDispose(m_proxyId);
                    if(remoteContext.connection.connectionLostException == null) {
                        var call = new ReleaseProxyRemoteCall();
                        call.proxyId = m_proxyId;
                        call.Execute();
                    }
                } catch {
                } finally {
                    m_proxyId = 0;
                }
            }
        }

        public void Dispose() {
            Release();
            GC.SuppressFinalize(this);
        }

        ~CfrObject() {
            Release();
        }
    }

    internal class GetRemotePtrRemoteCall : RenderProcessCall {
        internal GetRemotePtrRemoteCall() : base(RemoteCallId.GetRemotePtrRemoteCall) { }
        internal ulong proxyId;
        internal IntPtr retval;
        protected override void WriteArgs(StreamHandler h) { h.Write(proxyId); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out proxyId); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var obj = RemoteProxy.Unwrap(proxyId);
            retval = obj.NativePtr;
        }
    }
}
