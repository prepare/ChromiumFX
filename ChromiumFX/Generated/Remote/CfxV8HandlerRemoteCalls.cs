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
    using Event;
    using Chromium.Event;

    internal class CfxV8HandlerCtorRemoteCall : CtorRemoteCall {

        internal CfxV8HandlerCtorRemoteCall()
            : base(RemoteCallId.CfxV8HandlerCtorRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxV8Handler());
        }
    }

    internal class CfxV8HandlerExecuteRemoteClientCall : RemoteClientCall {

        internal CfxV8HandlerExecuteRemoteClientCall()
            : base(RemoteCallId.CfxV8HandlerExecuteRemoteClientCall) {}

        internal static void EventCall(object sender, CfxV8HandlerExecuteEventArgs e) {
            var call = new CfxV8HandlerExecuteRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Handler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrV8HandlerExecuteEventArgs(eventArgsId);
            sender.raise_Execute(sender, e);
        }
    }

    internal class CfxV8HandlerExecuteActivateRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteActivateRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Handler)RemoteProxy.Unwrap(this.sender, null);
            sender.Execute += CfxV8HandlerExecuteRemoteClientCall.EventCall;
        }
    }

    internal class CfxV8HandlerExecuteDeactivateRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteDeactivateRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Handler)RemoteProxy.Unwrap(this.sender, null);
            sender.Execute -= CfxV8HandlerExecuteRemoteClientCall.EventCall;
        }
    }

    internal class CfxV8HandlerExecuteGetNameRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteGetNameRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteGetNameRemoteCall) {}

        internal ulong eventArgsId;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
        }
        protected override void WriteReturn(StreamHandler h) {
            h.Write(value);
        }
        protected override void ReadReturn(StreamHandler h) {
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8HandlerExecuteEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxV8HandlerExecuteGetObjectRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteGetObjectRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteGetObjectRemoteCall) {}

        internal ulong eventArgsId;
        internal IntPtr value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
        }
        protected override void WriteReturn(StreamHandler h) {
            h.Write(value);
        }
        protected override void ReadReturn(StreamHandler h) {
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8HandlerExecuteEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxV8HandlerExecuteGetArgumentsRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteGetArgumentsRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteGetArgumentsRemoteCall) {}

        internal ulong eventArgsId;
        internal IntPtr[] value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
        }
        protected override void WriteReturn(StreamHandler h) {
            h.Write(value);
        }
        protected override void ReadReturn(StreamHandler h) {
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8HandlerExecuteEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = CfxArray.GetProxyIds<CfxV8Value>(e.Arguments);
        }
    }

    internal class CfxV8HandlerExecuteSetExceptionRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteSetExceptionRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteSetExceptionRemoteCall) {}

        internal ulong eventArgsId;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8HandlerExecuteEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxV8HandlerExecuteSetReturnValueRemoteCall : RemoteCall {

        internal CfxV8HandlerExecuteSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxV8HandlerExecuteSetReturnValueRemoteCall) {}

        internal ulong eventArgsId;
        internal IntPtr value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8HandlerExecuteEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue((CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr)));
        }
    }

}
