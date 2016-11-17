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

    internal class CfxV8AccessorCtorRemoteCall : RemoteCall {

        internal CfxV8AccessorCtorRemoteCall()
            : base(RemoteCallId.CfxV8AccessorCtorRemoteCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxV8Accessor());
        }
    }

    internal class CfxV8AccessorGetBrowserProcessCall : BrowserProcessCall {

        internal CfxV8AccessorGetBrowserProcessCall()
            : base(RemoteCallId.CfxV8AccessorGetBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxV8AccessorGetEventArgs e) {
            var call = new CfxV8AccessorGetBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Accessor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrV8AccessorGetEventArgs(eventArgsId);
            sender.raise_Get(sender, e);
        }
    }

    internal class CfxV8AccessorGetActivateRemoteCall : RemoteCall {

        internal CfxV8AccessorGetActivateRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Accessor)RemoteProxy.Unwrap(this.sender, null);
            sender.Get += CfxV8AccessorGetBrowserProcessCall.EventCall;
        }
    }

    internal class CfxV8AccessorGetDeactivateRemoteCall : RemoteCall {

        internal CfxV8AccessorGetDeactivateRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Accessor)RemoteProxy.Unwrap(this.sender, null);
            sender.Get -= CfxV8AccessorGetBrowserProcessCall.EventCall;
        }
    }

    internal class CfxV8AccessorGetGetNameRemoteCall : RemoteCall {

        internal CfxV8AccessorGetGetNameRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetGetNameRemoteCall) {}

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
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxV8AccessorGetGetObjectRemoteCall : RemoteCall {

        internal CfxV8AccessorGetGetObjectRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetGetObjectRemoteCall) {}

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
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxV8AccessorGetSetRetvalRemoteCall : RemoteCall {

        internal CfxV8AccessorGetSetRetvalRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetSetRetvalRemoteCall) {}

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
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Retval = (CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr));
        }
    }

    internal class CfxV8AccessorGetSetExceptionRemoteCall : RemoteCall {

        internal CfxV8AccessorGetSetExceptionRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetSetExceptionRemoteCall) {}

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
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxV8AccessorGetGetExceptionRemoteCall : RemoteCall {

        internal CfxV8AccessorGetGetExceptionRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetGetExceptionRemoteCall) {}

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
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxV8AccessorGetSetReturnValueRemoteCall : RemoteCall {

        internal CfxV8AccessorGetSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxV8AccessorGetSetReturnValueRemoteCall) {}

        internal ulong eventArgsId;
        internal bool value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8AccessorGetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxV8AccessorSetBrowserProcessCall : BrowserProcessCall {

        internal CfxV8AccessorSetBrowserProcessCall()
            : base(RemoteCallId.CfxV8AccessorSetBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxV8AccessorSetEventArgs e) {
            var call = new CfxV8AccessorSetBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Accessor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrV8AccessorSetEventArgs(eventArgsId);
            sender.raise_Set(sender, e);
        }
    }

    internal class CfxV8AccessorSetActivateRemoteCall : RemoteCall {

        internal CfxV8AccessorSetActivateRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Accessor)RemoteProxy.Unwrap(this.sender, null);
            sender.Set += CfxV8AccessorSetBrowserProcessCall.EventCall;
        }
    }

    internal class CfxV8AccessorSetDeactivateRemoteCall : RemoteCall {

        internal CfxV8AccessorSetDeactivateRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Accessor)RemoteProxy.Unwrap(this.sender, null);
            sender.Set -= CfxV8AccessorSetBrowserProcessCall.EventCall;
        }
    }

    internal class CfxV8AccessorSetGetNameRemoteCall : RemoteCall {

        internal CfxV8AccessorSetGetNameRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetGetNameRemoteCall) {}

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
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxV8AccessorSetGetObjectRemoteCall : RemoteCall {

        internal CfxV8AccessorSetGetObjectRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetGetObjectRemoteCall) {}

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
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxV8AccessorSetGetValueRemoteCall : RemoteCall {

        internal CfxV8AccessorSetGetValueRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetGetValueRemoteCall) {}

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
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Value);
        }
    }

    internal class CfxV8AccessorSetSetExceptionRemoteCall : RemoteCall {

        internal CfxV8AccessorSetSetExceptionRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetSetExceptionRemoteCall) {}

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
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxV8AccessorSetGetExceptionRemoteCall : RemoteCall {

        internal CfxV8AccessorSetGetExceptionRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetGetExceptionRemoteCall) {}

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
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxV8AccessorSetSetReturnValueRemoteCall : RemoteCall {

        internal CfxV8AccessorSetSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxV8AccessorSetSetReturnValueRemoteCall) {}

        internal ulong eventArgsId;
        internal bool value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxV8AccessorSetEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

}
