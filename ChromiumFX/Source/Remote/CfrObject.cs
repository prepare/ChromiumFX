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
using System.Diagnostics;

namespace Chromium.Remote {

    /// <summary>
    /// Base class for all remote wrapper classes for CEF structs.
    /// </summary>
    public abstract class CfrObject : IDisposable {

        internal static RemotePtr Unwrap(CfrObject remoteObject) {
            return remoteObject == null ? RemotePtr.Zero : remoteObject.RemotePtr;
        }

        private RemotePtr m_remotePtr;

        internal CfrObject(RemotePtr remotePtr) {
            m_remotePtr = remotePtr;
        }

        internal RemoteConnection connection {
            get {
                return RemotePtr.connection;
            }
        }

        /// <summary>
        /// Creates a remote call context for the render process this 
        /// object belongs to.
        /// </summary>
        /// <returns></returns>
        public CfxRemoteCallContext CreateRemoteCallContext() {
            return new CfxRemoteCallContext(RemotePtr.connection, 0);
        }

        /// <summary>
        /// Address of the underlying native CEF object
        /// in the render process memory space.
        /// </summary>
        public RemotePtr RemotePtr {
            get {
                if(m_remotePtr == RemotePtr.Zero) {
                    throw new ObjectDisposedException(this.GetType().Name);
                } else {
                    return m_remotePtr;
                }
            }
        }


        internal abstract void OnDispose(RemotePtr remotePtr);

        private void Release() {
            if(m_remotePtr != RemotePtr.Zero) {
                try {
                    OnDispose(m_remotePtr);
                    if(m_remotePtr.connection.connectionLostException == null) {
                        var call = new ReleaseRemotePtrRemoteCall();
                        call.remotePtr = m_remotePtr.ptr;
                        call.RequestExecution(m_remotePtr.connection);
                    }
#if DEBUG
                } catch(Exception e) {
                    Debug.Print("Exception cought in CfrObject.Release():");
                    Debug.Print(e.ToString());
#else
                } catch {
#endif
                } finally {
                    m_remotePtr = RemotePtr.Zero;
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
}
