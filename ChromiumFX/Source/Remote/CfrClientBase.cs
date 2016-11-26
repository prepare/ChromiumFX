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
using System.Runtime.InteropServices;

namespace Chromium.Remote {
    /// <summary>
    /// Base class for all remote wrapper classes for CEF client structs.
    /// </summary>
    public abstract class CfrClientBase : CfrBase {

        /// <summary>
        /// Set to a strong handle whenever CEF holds a reference to the underlying
        /// remote native client struct, in order to keep this object alive if it is not
        /// explicitly referenced from managed code.
        /// </summary>
        internal GCHandle nativeReference;

        internal CfrClientBase(CtorWithGCHandleRemoteCall call) {
            System.Runtime.InteropServices.GCHandle handle =
                System.Runtime.InteropServices.GCHandle.Alloc(this, System.Runtime.InteropServices.GCHandleType.Weak);
            call.gcHandlePtr = System.Runtime.InteropServices.GCHandle.ToIntPtr(handle);
            call.RequestExecution();
            SetRemotePtr(new RemotePtr(call.__retval));
        }

        internal CfrClientBase(RemotePtr remotePtr) : base(remotePtr) { }

        /// <summary>
        /// When true, all CEF callback events are disabled for this handler. Incoming callbacks will return default values to CEF.
        /// </summary>
        public bool CallbacksDisabled { get; set; }

        internal sealed override void OnDispose(RemotePtr nativePtr) {
            CallbacksDisabled = true;
            base.OnDispose(nativePtr);
        }
    }

    internal class GCHandleRemoteCall : RemoteCall {
        internal IntPtr gc_handle;
        internal int ref_count;
        internal GCHandleRemoteCall() : base(RemoteCallId.GCHandleRemoteCall) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gc_handle);
            h.Write(ref_count);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gc_handle);
            h.Read(out ref_count);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var h = GCHandle.FromIntPtr(gc_handle);
            if(ref_count == 0) {
                // the managed wrapper released it's reference
                // and the native object is destroyed
                h.Free();

                // TODO
                // this approach leads to undesired retention.

                //} else if(ref_count == 1) {
                //    // ref count of cef client object reached 1 after decrement: 
                //    // CEF released it's last reference ->
                //    // free native reference handle
                //    var client = (CfrClientBase)h.Target;
                //    client.nativeReference.Free();
                //} else {
                //    // ref count of cef client object reached 2 after increment:
                //    // CEF obtained it's first reference ->
                //    // alloc native reference handle
                //    var client = (CfrClientBase)h.Target;
                //    client.nativeReference = GCHandle.Alloc(client, GCHandleType.Normal);
            }
        }
    }
}
