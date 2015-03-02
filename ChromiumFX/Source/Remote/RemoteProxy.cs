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

namespace Chromium.Remote {
    internal class RemoteProxy {

        private static Dictionary<ulong, CfxObject> objects = new Dictionary<ulong, CfxObject>();

        private static ulong globalProxyId;

        internal static ulong Wrap(CfxObject o) {
            if(o == null) return 0;
            if(o.remoteId == 0) {
                lock(objects) {
                    if(o.remoteId == 0) {
                        ++globalProxyId;
                        objects.Add(globalProxyId, o);
                        o.remoteId = globalProxyId;
                    }
                }
            }
            return o.remoteId;
        }

        internal static CfxObject Unwrap(ulong proxyId) {
            lock(objects) {
                CfxObject o;
                objects.TryGetValue(proxyId, out o);
                return o;
            }
        }

        internal static void Release(ulong proxyId) {
            lock(objects) {
                CfxObject o;
                if(objects.TryGetValue(proxyId, out o))
                    o.remoteId = 0;
                objects.Remove(proxyId);
            }
        }
    }

    internal class ReleaseProxyRemoteCall : RenderProcessCall {
        internal ReleaseProxyRemoteCall() : base(RemoteCallId.ReleaseProxyRemoteCall, true) {}
        internal ulong proxyId;
        protected override void WriteArgs(StreamHandler h) { h.Write(proxyId); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out proxyId); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            RemoteProxy.Release(proxyId);
        }
    }

}
