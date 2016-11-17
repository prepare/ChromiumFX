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

    internal class CfxV8InterceptorCtorRemoteCall : RemoteCall {

        internal CfxV8InterceptorCtorRemoteCall()
            : base(RemoteCallId.CfxV8InterceptorCtorRemoteCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxV8Interceptor());
        }
    }

    internal class CfxGetByNameRemoteClientCall : RemoteClientCall {

        internal CfxGetByNameRemoteClientCall()
            : base(RemoteCallId.CfxGetByNameRemoteClientCall) {}

        internal static void EventCall(object sender, CfxGetByNameEventArgs e) {
            var call = new CfxGetByNameRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetByNameEventArgs(eventArgsId);
            sender.raise_GetByName(sender, e);
        }
    }

    internal class CfxGetByNameActivateRemoteCall : RemoteCall {

        internal CfxGetByNameActivateRemoteCall()
            : base(RemoteCallId.CfxGetByNameActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByName += CfxGetByNameRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetByNameDeactivateRemoteCall : RemoteCall {

        internal CfxGetByNameDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetByNameDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByName -= CfxGetByNameRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetByNameGetNameRemoteCall : RemoteCall {

        internal CfxGetByNameGetNameRemoteCall()
            : base(RemoteCallId.CfxGetByNameGetNameRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxGetByNameGetObjectRemoteCall : RemoteCall {

        internal CfxGetByNameGetObjectRemoteCall()
            : base(RemoteCallId.CfxGetByNameGetObjectRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxGetByNameSetRetvalRemoteCall : RemoteCall {

        internal CfxGetByNameSetRetvalRemoteCall()
            : base(RemoteCallId.CfxGetByNameSetRetvalRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Retval = (CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr));
        }
    }

    internal class CfxGetByNameSetExceptionRemoteCall : RemoteCall {

        internal CfxGetByNameSetExceptionRemoteCall()
            : base(RemoteCallId.CfxGetByNameSetExceptionRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxGetByNameGetExceptionRemoteCall : RemoteCall {

        internal CfxGetByNameGetExceptionRemoteCall()
            : base(RemoteCallId.CfxGetByNameGetExceptionRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxGetByNameSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetByNameSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetByNameSetReturnValueRemoteCall) {}

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
            var e = (CfxGetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxGetByIndexRemoteClientCall : RemoteClientCall {

        internal CfxGetByIndexRemoteClientCall()
            : base(RemoteCallId.CfxGetByIndexRemoteClientCall) {}

        internal static void EventCall(object sender, CfxGetByIndexEventArgs e) {
            var call = new CfxGetByIndexRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetByIndexEventArgs(eventArgsId);
            sender.raise_GetByIndex(sender, e);
        }
    }

    internal class CfxGetByIndexActivateRemoteCall : RemoteCall {

        internal CfxGetByIndexActivateRemoteCall()
            : base(RemoteCallId.CfxGetByIndexActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByIndex += CfxGetByIndexRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetByIndexDeactivateRemoteCall : RemoteCall {

        internal CfxGetByIndexDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetByIndexDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByIndex -= CfxGetByIndexRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetByIndexGetIndexRemoteCall : RemoteCall {

        internal CfxGetByIndexGetIndexRemoteCall()
            : base(RemoteCallId.CfxGetByIndexGetIndexRemoteCall) {}

        internal ulong eventArgsId;
        internal int value;

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Index;
        }
    }

    internal class CfxGetByIndexGetObjectRemoteCall : RemoteCall {

        internal CfxGetByIndexGetObjectRemoteCall()
            : base(RemoteCallId.CfxGetByIndexGetObjectRemoteCall) {}

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxGetByIndexSetRetvalRemoteCall : RemoteCall {

        internal CfxGetByIndexSetRetvalRemoteCall()
            : base(RemoteCallId.CfxGetByIndexSetRetvalRemoteCall) {}

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Retval = (CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr));
        }
    }

    internal class CfxGetByIndexSetExceptionRemoteCall : RemoteCall {

        internal CfxGetByIndexSetExceptionRemoteCall()
            : base(RemoteCallId.CfxGetByIndexSetExceptionRemoteCall) {}

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxGetByIndexGetExceptionRemoteCall : RemoteCall {

        internal CfxGetByIndexGetExceptionRemoteCall()
            : base(RemoteCallId.CfxGetByIndexGetExceptionRemoteCall) {}

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxGetByIndexSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetByIndexSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetByIndexSetReturnValueRemoteCall) {}

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
            var e = (CfxGetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxSetByNameRemoteClientCall : RemoteClientCall {

        internal CfxSetByNameRemoteClientCall()
            : base(RemoteCallId.CfxSetByNameRemoteClientCall) {}

        internal static void EventCall(object sender, CfxSetByNameEventArgs e) {
            var call = new CfxSetByNameRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrSetByNameEventArgs(eventArgsId);
            sender.raise_SetByName(sender, e);
        }
    }

    internal class CfxSetByNameActivateRemoteCall : RemoteCall {

        internal CfxSetByNameActivateRemoteCall()
            : base(RemoteCallId.CfxSetByNameActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByName += CfxSetByNameRemoteClientCall.EventCall;
        }
    }

    internal class CfxSetByNameDeactivateRemoteCall : RemoteCall {

        internal CfxSetByNameDeactivateRemoteCall()
            : base(RemoteCallId.CfxSetByNameDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByName -= CfxSetByNameRemoteClientCall.EventCall;
        }
    }

    internal class CfxSetByNameGetNameRemoteCall : RemoteCall {

        internal CfxSetByNameGetNameRemoteCall()
            : base(RemoteCallId.CfxSetByNameGetNameRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxSetByNameGetObjectRemoteCall : RemoteCall {

        internal CfxSetByNameGetObjectRemoteCall()
            : base(RemoteCallId.CfxSetByNameGetObjectRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxSetByNameGetValueRemoteCall : RemoteCall {

        internal CfxSetByNameGetValueRemoteCall()
            : base(RemoteCallId.CfxSetByNameGetValueRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Value);
        }
    }

    internal class CfxSetByNameSetExceptionRemoteCall : RemoteCall {

        internal CfxSetByNameSetExceptionRemoteCall()
            : base(RemoteCallId.CfxSetByNameSetExceptionRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxSetByNameGetExceptionRemoteCall : RemoteCall {

        internal CfxSetByNameGetExceptionRemoteCall()
            : base(RemoteCallId.CfxSetByNameGetExceptionRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxSetByNameSetReturnValueRemoteCall : RemoteCall {

        internal CfxSetByNameSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxSetByNameSetReturnValueRemoteCall) {}

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
            var e = (CfxSetByNameEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxSetByIndexRemoteClientCall : RemoteClientCall {

        internal CfxSetByIndexRemoteClientCall()
            : base(RemoteCallId.CfxSetByIndexRemoteClientCall) {}

        internal static void EventCall(object sender, CfxSetByIndexEventArgs e) {
            var call = new CfxSetByIndexRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrSetByIndexEventArgs(eventArgsId);
            sender.raise_SetByIndex(sender, e);
        }
    }

    internal class CfxSetByIndexActivateRemoteCall : RemoteCall {

        internal CfxSetByIndexActivateRemoteCall()
            : base(RemoteCallId.CfxSetByIndexActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByIndex += CfxSetByIndexRemoteClientCall.EventCall;
        }
    }

    internal class CfxSetByIndexDeactivateRemoteCall : RemoteCall {

        internal CfxSetByIndexDeactivateRemoteCall()
            : base(RemoteCallId.CfxSetByIndexDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByIndex -= CfxSetByIndexRemoteClientCall.EventCall;
        }
    }

    internal class CfxSetByIndexGetIndexRemoteCall : RemoteCall {

        internal CfxSetByIndexGetIndexRemoteCall()
            : base(RemoteCallId.CfxSetByIndexGetIndexRemoteCall) {}

        internal ulong eventArgsId;
        internal int value;

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Index;
        }
    }

    internal class CfxSetByIndexGetObjectRemoteCall : RemoteCall {

        internal CfxSetByIndexGetObjectRemoteCall()
            : base(RemoteCallId.CfxSetByIndexGetObjectRemoteCall) {}

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxSetByIndexGetValueRemoteCall : RemoteCall {

        internal CfxSetByIndexGetValueRemoteCall()
            : base(RemoteCallId.CfxSetByIndexGetValueRemoteCall) {}

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Value);
        }
    }

    internal class CfxSetByIndexSetExceptionRemoteCall : RemoteCall {

        internal CfxSetByIndexSetExceptionRemoteCall()
            : base(RemoteCallId.CfxSetByIndexSetExceptionRemoteCall) {}

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxSetByIndexGetExceptionRemoteCall : RemoteCall {

        internal CfxSetByIndexGetExceptionRemoteCall()
            : base(RemoteCallId.CfxSetByIndexGetExceptionRemoteCall) {}

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxSetByIndexSetReturnValueRemoteCall : RemoteCall {

        internal CfxSetByIndexSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxSetByIndexSetReturnValueRemoteCall) {}

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
            var e = (CfxSetByIndexEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

}
