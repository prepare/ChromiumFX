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
    /// Represents an IntPtr in the remote process.
    /// </summary>
    public struct RemotePtr {
        /// <summary>
        /// Two remote pointers are equal if both are null or both are of the same value on the same connection.
        /// </summary>
        public static bool operator ==(RemotePtr p1, RemotePtr p2) { return p1.ptr == p2.ptr && (p1.connection == p2.connection || p1.ptr == IntPtr.Zero); }
        public static bool operator !=(RemotePtr p1, RemotePtr p2) { return !(p1.ptr == p2.ptr); }
        public static readonly RemotePtr Zero;
        internal RemoteConnection connection;
        internal IntPtr ptr;
        internal RemotePtr(RemoteConnection connection, IntPtr ptr) {
            this.connection = connection;
            this.ptr = ptr;
        }
        internal RemotePtr(IntPtr ptr) {
            this.connection = CfxRemoteCallContext.CurrentContext.connection;
            this.ptr = ptr;
        }
        public override bool Equals(object obj) {
            return this == (RemotePtr)obj;
        }
        public override int GetHashCode() {
            return ptr.GetHashCode() ^ connection.GetHashCode();
        }
    }
}
