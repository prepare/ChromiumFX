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

    internal class CfxV8InterceptorCtorRenderProcessCall : RenderProcessCall {

        internal CfxV8InterceptorCtorRenderProcessCall()
            : base(RemoteCallId.CfxV8InterceptorCtorRenderProcessCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxV8Interceptor());
        }
    }

    internal class CfxGetByNameBrowserProcessCall : BrowserProcessCall {

        internal CfxGetByNameBrowserProcessCall()
            : base(RemoteCallId.CfxGetByNameBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxGetByNameEventArgs e) {
            var call = new CfxGetByNameBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(this.sender);
            var e = new CfrGetByNameEventArgs(eventArgsId);
            sender.raise_GetByName(sender, e);
        }
    }

    internal class CfxGetByNameActivateRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameActivateRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameActivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByName += CfxGetByNameBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetByNameDeactivateRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameDeactivateRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameDeactivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByName -= CfxGetByNameBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetByNameGetNameRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameGetNameRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameGetNameRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxGetByNameGetObjectRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameGetObjectRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameGetObjectRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxGetByNameSetRetvalRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameSetRetvalRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameSetRetvalRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Retval = (CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr));
        }
    }

    internal class CfxGetByNameSetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameSetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameSetExceptionRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxGetByNameGetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameGetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameGetExceptionRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxGetByNameSetReturnValueRenderProcessCall : RenderProcessCall {

        internal CfxGetByNameSetReturnValueRenderProcessCall()
            : base(RemoteCallId.CfxGetByNameSetReturnValueRenderProcessCall) {}

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
            var e = (CfxGetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxGetByIndexBrowserProcessCall : BrowserProcessCall {

        internal CfxGetByIndexBrowserProcessCall()
            : base(RemoteCallId.CfxGetByIndexBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxGetByIndexEventArgs e) {
            var call = new CfxGetByIndexBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(this.sender);
            var e = new CfrGetByIndexEventArgs(eventArgsId);
            sender.raise_GetByIndex(sender, e);
        }
    }

    internal class CfxGetByIndexActivateRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexActivateRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexActivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByIndex += CfxGetByIndexBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetByIndexDeactivateRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexDeactivateRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexDeactivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.GetByIndex -= CfxGetByIndexBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetByIndexGetIndexRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexGetIndexRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexGetIndexRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Index;
        }
    }

    internal class CfxGetByIndexGetObjectRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexGetObjectRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexGetObjectRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxGetByIndexSetRetvalRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexSetRetvalRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexSetRetvalRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Retval = (CfxV8Value)RemoteProxy.Unwrap(value, (ptr) => new CfxV8Value(ptr));
        }
    }

    internal class CfxGetByIndexSetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexSetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexSetExceptionRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxGetByIndexGetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexGetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexGetExceptionRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxGetByIndexSetReturnValueRenderProcessCall : RenderProcessCall {

        internal CfxGetByIndexSetReturnValueRenderProcessCall()
            : base(RemoteCallId.CfxGetByIndexSetReturnValueRenderProcessCall) {}

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
            var e = (CfxGetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxSetByNameBrowserProcessCall : BrowserProcessCall {

        internal CfxSetByNameBrowserProcessCall()
            : base(RemoteCallId.CfxSetByNameBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxSetByNameEventArgs e) {
            var call = new CfxSetByNameBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(this.sender);
            var e = new CfrSetByNameEventArgs(eventArgsId);
            sender.raise_SetByName(sender, e);
        }
    }

    internal class CfxSetByNameActivateRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameActivateRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameActivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByName += CfxSetByNameBrowserProcessCall.EventCall;
        }
    }

    internal class CfxSetByNameDeactivateRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameDeactivateRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameDeactivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByName -= CfxSetByNameBrowserProcessCall.EventCall;
        }
    }

    internal class CfxSetByNameGetNameRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameGetNameRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameGetNameRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Name;
        }
    }

    internal class CfxSetByNameGetObjectRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameGetObjectRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameGetObjectRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxSetByNameGetValueRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameGetValueRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameGetValueRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Value);
        }
    }

    internal class CfxSetByNameSetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameSetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameSetExceptionRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxSetByNameGetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameGetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameGetExceptionRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxSetByNameSetReturnValueRenderProcessCall : RenderProcessCall {

        internal CfxSetByNameSetReturnValueRenderProcessCall()
            : base(RemoteCallId.CfxSetByNameSetReturnValueRenderProcessCall) {}

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
            var e = (CfxSetByNameEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxSetByIndexBrowserProcessCall : BrowserProcessCall {

        internal CfxSetByIndexBrowserProcessCall()
            : base(RemoteCallId.CfxSetByIndexBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxSetByIndexEventArgs e) {
            var call = new CfxSetByIndexBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrV8Interceptor.Wrap(this.sender);
            var e = new CfrSetByIndexEventArgs(eventArgsId);
            sender.raise_SetByIndex(sender, e);
        }
    }

    internal class CfxSetByIndexActivateRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexActivateRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexActivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByIndex += CfxSetByIndexBrowserProcessCall.EventCall;
        }
    }

    internal class CfxSetByIndexDeactivateRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexDeactivateRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexDeactivateRenderProcessCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxV8Interceptor)RemoteProxy.Unwrap(this.sender, null);
            sender.SetByIndex -= CfxSetByIndexBrowserProcessCall.EventCall;
        }
    }

    internal class CfxSetByIndexGetIndexRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexGetIndexRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexGetIndexRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Index;
        }
    }

    internal class CfxSetByIndexGetObjectRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexGetObjectRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexGetObjectRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Object);
        }
    }

    internal class CfxSetByIndexGetValueRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexGetValueRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexGetValueRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Value);
        }
    }

    internal class CfxSetByIndexSetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexSetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexSetExceptionRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Exception = value;
        }
    }

    internal class CfxSetByIndexGetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexGetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexGetExceptionRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.Exception;
        }
    }

    internal class CfxSetByIndexSetReturnValueRenderProcessCall : RenderProcessCall {

        internal CfxSetByIndexSetReturnValueRenderProcessCall()
            : base(RemoteCallId.CfxSetByIndexSetReturnValueRenderProcessCall) {}

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
            var e = (CfxSetByIndexEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

}
