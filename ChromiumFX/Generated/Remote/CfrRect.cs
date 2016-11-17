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
    /// Structure representing a rectangle.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
    /// </remarks>
    public sealed class CfrRect : CfrStructure {

        internal static CfrRect Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrRect)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrRect(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static RemotePtr CreateRemote() {
            var call = new CfxRectCtorRemoteCall();
            call.RequestExecution();
            return new RemotePtr(call.__retval);
        }

        private CfrRect(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrRect() : base(CreateRemote()) {
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        int m_X;
        bool m_X_fetched;

        public int X {
            get {
                if(!m_X_fetched) {
                    var call = new CfxRectGetXRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                    m_X = call.value;
                    m_X_fetched = true;
                }
                return m_X;
            }
            set {
                var call = new CfxRectSetXRemoteCall();
                call.sender = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
                m_X = value;
                m_X_fetched = true;
            }
        }

        int m_Y;
        bool m_Y_fetched;

        public int Y {
            get {
                if(!m_Y_fetched) {
                    var call = new CfxRectGetYRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                    m_Y = call.value;
                    m_Y_fetched = true;
                }
                return m_Y;
            }
            set {
                var call = new CfxRectSetYRemoteCall();
                call.sender = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
                m_Y = value;
                m_Y_fetched = true;
            }
        }

        int m_Width;
        bool m_Width_fetched;

        public int Width {
            get {
                if(!m_Width_fetched) {
                    var call = new CfxRectGetWidthRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                    m_Width = call.value;
                    m_Width_fetched = true;
                }
                return m_Width;
            }
            set {
                var call = new CfxRectSetWidthRemoteCall();
                call.sender = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
                m_Width = value;
                m_Width_fetched = true;
            }
        }

        int m_Height;
        bool m_Height_fetched;

        public int Height {
            get {
                if(!m_Height_fetched) {
                    var call = new CfxRectGetHeightRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                    m_Height = call.value;
                    m_Height_fetched = true;
                }
                return m_Height;
            }
            set {
                var call = new CfxRectSetHeightRemoteCall();
                call.sender = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
                m_Height = value;
                m_Height_fetched = true;
            }
        }
    }
}
