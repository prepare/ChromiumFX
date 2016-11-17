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
using System.Collections.Generic;
using System.Diagnostics;

namespace Chromium.Remote {
    internal class RemoteProxy {

        private static Dictionary<IntPtr, CfxObject> objects = new Dictionary<IntPtr, CfxObject>();

        internal static IntPtr Wrap(CfxObject o) {
            if(o == null) return IntPtr.Zero;
            lock(objects) {
                if(!objects.ContainsKey(o.nativePtrUnchecked)) {
                    objects.Add(o.nativePtrUnchecked, o);
                }
            }
            return o.nativePtrUnchecked;
        }

        internal static CfxObject Unwrap(IntPtr remotePtr, Func<IntPtr, CfxObject> ctor) {

            if(remotePtr == IntPtr.Zero)
                return null;

            lock(objects) {
                CfxObject o;
                if(!objects.TryGetValue(remotePtr, out o)) {
                    o = ctor(remotePtr);
                    objects.Add(remotePtr, o);
                }
                return o;
            }
        }

        internal static void Release(IntPtr remotePtr) {
            lock(objects) {
                if(!objects.Remove(remotePtr)) {
                    //was not wrapped locally, release manually
                    CfxApi.cfx_release(remotePtr);
                }
            }
        }
    }

    internal class ReleaseRemotePtrRemoteCall : RenderProcessCall {
        internal ReleaseRemotePtrRemoteCall() : base(RemoteCallId.ReleaseRemotePtrRemoteCall, true) { }
        internal IntPtr remotePtr;
        protected override void WriteArgs(StreamHandler h) { h.Write(remotePtr); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out remotePtr); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            RemoteProxy.Release(remotePtr);
        }
    }

}
