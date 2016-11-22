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
    /// Base class for all remote wrapper classes for CEF structs without refcount.
    /// </summary>
    public abstract class CfrStructure : CfrObject {

        private readonly DtorRemoteCall dtor;

        // Case 1) User created structure: 
        // allocate native on creation, free native on dispose.
        internal CfrStructure(CtorRemoteCall ctor, DtorRemoteCall dtor) {
            this.dtor = dtor;
            ctor.RequestExecution();
            SetRemotePtr(new RemotePtr(ctor.__retval));
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        // Case 2) struct pointer passed in from framework in callback function
        // wrap native pointer on creation, do not free native pointer
        internal CfrStructure(RemotePtr remotePtr) {
            SetRemotePtr(remotePtr);
        }

        internal override sealed void OnDispose(RemotePtr remotePtr) {
            if(dtor != null) {
                dtor.nativePtr = remotePtr.ptr;
                dtor.RequestExecution(remotePtr.connection);
            }
        }
    }
}
