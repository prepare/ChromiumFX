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
    /// <summary>
    /// Marshals a callback from a client in the render process to the browser process.
    /// </summary>
    abstract class RemoteClientCall : RemoteCall {

        private static readonly Dictionary<ulong, object> eventArgs = new Dictionary<ulong, object>();
        private static ulong globalEventArgId;

        internal static ulong AddEventArgs(object o) {
            lock(eventArgs) {
                ++globalEventArgId;
                eventArgs.Add(globalEventArgId, o);
                return globalEventArgId;
            }
        }

        internal static object GetEventArgs(ulong id) {
            lock(eventArgs) {
                return eventArgs[id];
            }
        }

        internal static object RemoveEventArgs(ulong id) {
            lock(eventArgs) {
                var retval = eventArgs[id];
                eventArgs.Remove(id);
                return retval;
            }
        }


        internal IntPtr sender;
        internal ulong eventArgsId;

        internal RemoteClientCall(RemoteCallId callId) : base(callId) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(sender);
            h.Write(eventArgsId);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out sender);
            h.Read(out eventArgsId);
        }

    }

    /// <summary>
    /// Marshals a callback from a client in the render process to the browser process.
    /// </summary>
    abstract class RemoteEventCall : RemoteCall {
        internal IntPtr gcHandlePtr;
        internal RemoteEventCall(RemoteCallId callId) : base(callId) { }
    }

    internal abstract class CtorRemoteCall : RemoteCall {
        internal IntPtr __retval;
        internal CtorRemoteCall(RemoteCallId callId) : base(callId) { }
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

    }

    internal abstract class CtorWithGCHandleRemoteCall : CtorRemoteCall {
        internal IntPtr gcHandlePtr;
        internal CtorWithGCHandleRemoteCall(RemoteCallId callId) : base(callId) { }
        protected override void WriteArgs(StreamHandler h) { h.Write(gcHandlePtr); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out gcHandlePtr); }
    }

    internal abstract class DtorRemoteCall : RemoteCall {
        internal IntPtr nativePtr;
        internal DtorRemoteCall(RemoteCallId callId) : base(callId) { }
        protected override void WriteArgs(StreamHandler h) { h.Write(nativePtr); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out nativePtr); }
    }

    internal abstract class SetCallbackRemoteCall : RemoteCall {
        internal IntPtr self;
        internal int index;
        internal bool active;
        internal SetCallbackRemoteCall(RemoteCallId callId) : base(callId) { }
        protected override void WriteArgs(StreamHandler h) { h.Write(self); h.Write(index); h.Write(active); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out self); h.Read(out index); h.Read(out active); }
    }
}
