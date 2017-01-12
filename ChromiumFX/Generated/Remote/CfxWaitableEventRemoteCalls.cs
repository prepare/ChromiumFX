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

    internal class CfxWaitableEventCreateRemoteCall : RemoteCall {

        internal CfxWaitableEventCreateRemoteCall()
            : base(RemoteCallId.CfxWaitableEventCreateRemoteCall) {}

        internal int automaticReset;
        internal int initiallySignaled;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(automaticReset);
            h.Write(initiallySignaled);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out automaticReset);
            h.Read(out initiallySignaled);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.WaitableEvent.cfx_waitable_event_create(automaticReset, initiallySignaled);
        }
    }

    internal class CfxWaitableEventResetRemoteCall : RemoteCall {

        internal CfxWaitableEventResetRemoteCall()
            : base(RemoteCallId.CfxWaitableEventResetRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.WaitableEvent.cfx_waitable_event_reset(@this);
        }
    }

    internal class CfxWaitableEventSignalRemoteCall : RemoteCall {

        internal CfxWaitableEventSignalRemoteCall()
            : base(RemoteCallId.CfxWaitableEventSignalRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.WaitableEvent.cfx_waitable_event_signal(@this);
        }
    }

    internal class CfxWaitableEventIsSignaledRemoteCall : RemoteCall {

        internal CfxWaitableEventIsSignaledRemoteCall()
            : base(RemoteCallId.CfxWaitableEventIsSignaledRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.WaitableEvent.cfx_waitable_event_is_signaled(@this);
        }
    }

    internal class CfxWaitableEventWaitRemoteCall : RemoteCall {

        internal CfxWaitableEventWaitRemoteCall()
            : base(RemoteCallId.CfxWaitableEventWaitRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.WaitableEvent.cfx_waitable_event_wait(@this);
        }
    }

    internal class CfxWaitableEventTimedWaitRemoteCall : RemoteCall {

        internal CfxWaitableEventTimedWaitRemoteCall()
            : base(RemoteCallId.CfxWaitableEventTimedWaitRemoteCall) {}

        internal IntPtr @this;
        internal long maxMs;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(maxMs);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out maxMs);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.WaitableEvent.cfx_waitable_event_timed_wait(@this, maxMs);
        }
    }

}
