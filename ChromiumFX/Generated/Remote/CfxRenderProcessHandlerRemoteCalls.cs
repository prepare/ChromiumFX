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

    internal class CfxRenderProcessHandlerCtorRemoteCall : RemoteCall {

        internal CfxRenderProcessHandlerCtorRemoteCall()
            : base(RemoteCallId.CfxRenderProcessHandlerCtorRemoteCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxRenderProcessHandler());
        }
    }

    internal class CfxOnRenderThreadCreatedRemoteClientCall : RemoteClientCall {

        internal CfxOnRenderThreadCreatedRemoteClientCall()
            : base(RemoteCallId.CfxOnRenderThreadCreatedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnRenderThreadCreatedEventArgs e) {
            var call = new CfxOnRenderThreadCreatedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnRenderThreadCreatedEventArgs(eventArgsId);
            sender.raise_OnRenderThreadCreated(sender, e);
        }
    }

    internal class CfxOnRenderThreadCreatedActivateRemoteCall : RemoteCall {

        internal CfxOnRenderThreadCreatedActivateRemoteCall()
            : base(RemoteCallId.CfxOnRenderThreadCreatedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnRenderThreadCreated += CfxOnRenderThreadCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnRenderThreadCreatedDeactivateRemoteCall : RemoteCall {

        internal CfxOnRenderThreadCreatedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnRenderThreadCreatedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnRenderThreadCreated -= CfxOnRenderThreadCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnRenderThreadCreatedGetExtraInfoRemoteCall : RemoteCall {

        internal CfxOnRenderThreadCreatedGetExtraInfoRemoteCall()
            : base(RemoteCallId.CfxOnRenderThreadCreatedGetExtraInfoRemoteCall) {}

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
            var e = (CfxOnRenderThreadCreatedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.ExtraInfo);
        }
    }

    internal class CfxOnWebKitInitializedRemoteClientCall : RemoteClientCall {

        internal CfxOnWebKitInitializedRemoteClientCall()
            : base(RemoteCallId.CfxOnWebKitInitializedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxEventArgs e) {
            var call = new CfxOnWebKitInitializedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrEventArgs(eventArgsId);
            sender.raise_OnWebKitInitialized(sender, e);
        }
    }

    internal class CfxOnWebKitInitializedActivateRemoteCall : RemoteCall {

        internal CfxOnWebKitInitializedActivateRemoteCall()
            : base(RemoteCallId.CfxOnWebKitInitializedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnWebKitInitialized += CfxOnWebKitInitializedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnWebKitInitializedDeactivateRemoteCall : RemoteCall {

        internal CfxOnWebKitInitializedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnWebKitInitializedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnWebKitInitialized -= CfxOnWebKitInitializedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBrowserCreatedRemoteClientCall : RemoteClientCall {

        internal CfxOnBrowserCreatedRemoteClientCall()
            : base(RemoteCallId.CfxOnBrowserCreatedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnBrowserCreatedEventArgs e) {
            var call = new CfxOnBrowserCreatedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnBrowserCreatedEventArgs(eventArgsId);
            sender.raise_OnBrowserCreated(sender, e);
        }
    }

    internal class CfxOnBrowserCreatedActivateRemoteCall : RemoteCall {

        internal CfxOnBrowserCreatedActivateRemoteCall()
            : base(RemoteCallId.CfxOnBrowserCreatedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBrowserCreated += CfxOnBrowserCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBrowserCreatedDeactivateRemoteCall : RemoteCall {

        internal CfxOnBrowserCreatedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnBrowserCreatedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBrowserCreated -= CfxOnBrowserCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBrowserCreatedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnBrowserCreatedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnBrowserCreatedGetBrowserRemoteCall) {}

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
            var e = (CfxOnBrowserCreatedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnBrowserDestroyedRemoteClientCall : RemoteClientCall {

        internal CfxOnBrowserDestroyedRemoteClientCall()
            : base(RemoteCallId.CfxOnBrowserDestroyedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnBrowserDestroyedEventArgs e) {
            var call = new CfxOnBrowserDestroyedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnBrowserDestroyedEventArgs(eventArgsId);
            sender.raise_OnBrowserDestroyed(sender, e);
        }
    }

    internal class CfxOnBrowserDestroyedActivateRemoteCall : RemoteCall {

        internal CfxOnBrowserDestroyedActivateRemoteCall()
            : base(RemoteCallId.CfxOnBrowserDestroyedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBrowserDestroyed += CfxOnBrowserDestroyedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBrowserDestroyedDeactivateRemoteCall : RemoteCall {

        internal CfxOnBrowserDestroyedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnBrowserDestroyedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBrowserDestroyed -= CfxOnBrowserDestroyedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBrowserDestroyedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnBrowserDestroyedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnBrowserDestroyedGetBrowserRemoteCall) {}

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
            var e = (CfxOnBrowserDestroyedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxGetLoadHandlerRemoteClientCall : RemoteClientCall {

        internal CfxGetLoadHandlerRemoteClientCall()
            : base(RemoteCallId.CfxGetLoadHandlerRemoteClientCall) {}

        internal static void EventCall(object sender, CfxGetLoadHandlerEventArgs e) {
            var call = new CfxGetLoadHandlerRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetLoadHandlerEventArgs(eventArgsId);
            sender.raise_GetLoadHandler(sender, e);
        }
    }

    internal class CfxGetLoadHandlerActivateRemoteCall : RemoteCall {

        internal CfxGetLoadHandlerActivateRemoteCall()
            : base(RemoteCallId.CfxGetLoadHandlerActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetLoadHandler += CfxGetLoadHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetLoadHandlerDeactivateRemoteCall : RemoteCall {

        internal CfxGetLoadHandlerDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetLoadHandlerDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetLoadHandler -= CfxGetLoadHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetLoadHandlerSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetLoadHandlerSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetLoadHandlerSetReturnValueRemoteCall) {}

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
            var e = (CfxGetLoadHandlerEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue((CfxLoadHandler)RemoteProxy.Unwrap(value, (ptr) => new CfxLoadHandler(ptr)));
        }
    }

    internal class CfxOnBeforeNavigationRemoteClientCall : RemoteClientCall {

        internal CfxOnBeforeNavigationRemoteClientCall()
            : base(RemoteCallId.CfxOnBeforeNavigationRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnBeforeNavigationEventArgs e) {
            var call = new CfxOnBeforeNavigationRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnBeforeNavigationEventArgs(eventArgsId);
            sender.raise_OnBeforeNavigation(sender, e);
        }
    }

    internal class CfxOnBeforeNavigationActivateRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationActivateRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBeforeNavigation += CfxOnBeforeNavigationRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBeforeNavigationDeactivateRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBeforeNavigation -= CfxOnBeforeNavigationRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBeforeNavigationGetBrowserRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationGetBrowserRemoteCall) {}

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnBeforeNavigationGetFrameRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationGetFrameRemoteCall) {}

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnBeforeNavigationGetRequestRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationGetRequestRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationGetRequestRemoteCall) {}

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Request);
        }
    }

    internal class CfxOnBeforeNavigationGetNavigationTypeRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationGetNavigationTypeRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationGetNavigationTypeRemoteCall) {}

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = (int)e.NavigationType;
        }
    }

    internal class CfxOnBeforeNavigationGetIsRedirectRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationGetIsRedirectRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationGetIsRedirectRemoteCall) {}

        internal ulong eventArgsId;
        internal bool value;

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.IsRedirect;
        }
    }

    internal class CfxOnBeforeNavigationSetReturnValueRemoteCall : RemoteCall {

        internal CfxOnBeforeNavigationSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxOnBeforeNavigationSetReturnValueRemoteCall) {}

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
            var e = (CfxOnBeforeNavigationEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxOnContextCreatedRemoteClientCall : RemoteClientCall {

        internal CfxOnContextCreatedRemoteClientCall()
            : base(RemoteCallId.CfxOnContextCreatedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnContextCreatedEventArgs e) {
            var call = new CfxOnContextCreatedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnContextCreatedEventArgs(eventArgsId);
            sender.raise_OnContextCreated(sender, e);
        }
    }

    internal class CfxOnContextCreatedActivateRemoteCall : RemoteCall {

        internal CfxOnContextCreatedActivateRemoteCall()
            : base(RemoteCallId.CfxOnContextCreatedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnContextCreated += CfxOnContextCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnContextCreatedDeactivateRemoteCall : RemoteCall {

        internal CfxOnContextCreatedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnContextCreatedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnContextCreated -= CfxOnContextCreatedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnContextCreatedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnContextCreatedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnContextCreatedGetBrowserRemoteCall) {}

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
            var e = (CfxOnContextCreatedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnContextCreatedGetFrameRemoteCall : RemoteCall {

        internal CfxOnContextCreatedGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnContextCreatedGetFrameRemoteCall) {}

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
            var e = (CfxOnContextCreatedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnContextCreatedGetContextRemoteCall : RemoteCall {

        internal CfxOnContextCreatedGetContextRemoteCall()
            : base(RemoteCallId.CfxOnContextCreatedGetContextRemoteCall) {}

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
            var e = (CfxOnContextCreatedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Context);
        }
    }

    internal class CfxOnContextReleasedRemoteClientCall : RemoteClientCall {

        internal CfxOnContextReleasedRemoteClientCall()
            : base(RemoteCallId.CfxOnContextReleasedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnContextReleasedEventArgs e) {
            var call = new CfxOnContextReleasedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnContextReleasedEventArgs(eventArgsId);
            sender.raise_OnContextReleased(sender, e);
        }
    }

    internal class CfxOnContextReleasedActivateRemoteCall : RemoteCall {

        internal CfxOnContextReleasedActivateRemoteCall()
            : base(RemoteCallId.CfxOnContextReleasedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnContextReleased += CfxOnContextReleasedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnContextReleasedDeactivateRemoteCall : RemoteCall {

        internal CfxOnContextReleasedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnContextReleasedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnContextReleased -= CfxOnContextReleasedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnContextReleasedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnContextReleasedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnContextReleasedGetBrowserRemoteCall) {}

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
            var e = (CfxOnContextReleasedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnContextReleasedGetFrameRemoteCall : RemoteCall {

        internal CfxOnContextReleasedGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnContextReleasedGetFrameRemoteCall) {}

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
            var e = (CfxOnContextReleasedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnContextReleasedGetContextRemoteCall : RemoteCall {

        internal CfxOnContextReleasedGetContextRemoteCall()
            : base(RemoteCallId.CfxOnContextReleasedGetContextRemoteCall) {}

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
            var e = (CfxOnContextReleasedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Context);
        }
    }

    internal class CfxOnUncaughtExceptionRemoteClientCall : RemoteClientCall {

        internal CfxOnUncaughtExceptionRemoteClientCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnUncaughtExceptionEventArgs e) {
            var call = new CfxOnUncaughtExceptionRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnUncaughtExceptionEventArgs(eventArgsId);
            sender.raise_OnUncaughtException(sender, e);
        }
    }

    internal class CfxOnUncaughtExceptionActivateRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionActivateRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnUncaughtException += CfxOnUncaughtExceptionRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnUncaughtExceptionDeactivateRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnUncaughtException -= CfxOnUncaughtExceptionRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnUncaughtExceptionGetBrowserRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionGetBrowserRemoteCall) {}

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
            var e = (CfxOnUncaughtExceptionEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnUncaughtExceptionGetFrameRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionGetFrameRemoteCall) {}

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
            var e = (CfxOnUncaughtExceptionEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnUncaughtExceptionGetContextRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionGetContextRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionGetContextRemoteCall) {}

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
            var e = (CfxOnUncaughtExceptionEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Context);
        }
    }

    internal class CfxOnUncaughtExceptionGetExceptionRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionGetExceptionRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionGetExceptionRemoteCall) {}

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
            var e = (CfxOnUncaughtExceptionEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Exception);
        }
    }

    internal class CfxOnUncaughtExceptionGetStackTraceRemoteCall : RemoteCall {

        internal CfxOnUncaughtExceptionGetStackTraceRemoteCall()
            : base(RemoteCallId.CfxOnUncaughtExceptionGetStackTraceRemoteCall) {}

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
            var e = (CfxOnUncaughtExceptionEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.StackTrace);
        }
    }

    internal class CfxOnFocusedNodeChangedRemoteClientCall : RemoteClientCall {

        internal CfxOnFocusedNodeChangedRemoteClientCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnFocusedNodeChangedEventArgs e) {
            var call = new CfxOnFocusedNodeChangedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnFocusedNodeChangedEventArgs(eventArgsId);
            sender.raise_OnFocusedNodeChanged(sender, e);
        }
    }

    internal class CfxOnFocusedNodeChangedActivateRemoteCall : RemoteCall {

        internal CfxOnFocusedNodeChangedActivateRemoteCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnFocusedNodeChanged += CfxOnFocusedNodeChangedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnFocusedNodeChangedDeactivateRemoteCall : RemoteCall {

        internal CfxOnFocusedNodeChangedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnFocusedNodeChanged -= CfxOnFocusedNodeChangedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnFocusedNodeChangedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnFocusedNodeChangedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedGetBrowserRemoteCall) {}

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
            var e = (CfxOnFocusedNodeChangedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnFocusedNodeChangedGetFrameRemoteCall : RemoteCall {

        internal CfxOnFocusedNodeChangedGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedGetFrameRemoteCall) {}

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
            var e = (CfxOnFocusedNodeChangedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnFocusedNodeChangedGetNodeRemoteCall : RemoteCall {

        internal CfxOnFocusedNodeChangedGetNodeRemoteCall()
            : base(RemoteCallId.CfxOnFocusedNodeChangedGetNodeRemoteCall) {}

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
            var e = (CfxOnFocusedNodeChangedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Node);
        }
    }

    internal class CfxOnProcessMessageReceivedRemoteClientCall : RemoteClientCall {

        internal CfxOnProcessMessageReceivedRemoteClientCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnProcessMessageReceivedEventArgs e) {
            var call = new CfxOnProcessMessageReceivedRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrRenderProcessHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnProcessMessageReceivedEventArgs(eventArgsId);
            sender.raise_OnProcessMessageReceived(sender, e);
        }
    }

    internal class CfxOnProcessMessageReceivedActivateRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedActivateRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnProcessMessageReceived += CfxOnProcessMessageReceivedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnProcessMessageReceivedDeactivateRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRenderProcessHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnProcessMessageReceived -= CfxOnProcessMessageReceivedRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnProcessMessageReceivedGetBrowserRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedGetBrowserRemoteCall) {}

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
            var e = (CfxOnProcessMessageReceivedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnProcessMessageReceivedGetSourceProcessRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedGetSourceProcessRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedGetSourceProcessRemoteCall) {}

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
            var e = (CfxOnProcessMessageReceivedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = (int)e.SourceProcess;
        }
    }

    internal class CfxOnProcessMessageReceivedGetMessageRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedGetMessageRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedGetMessageRemoteCall) {}

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
            var e = (CfxOnProcessMessageReceivedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Message);
        }
    }

    internal class CfxOnProcessMessageReceivedSetReturnValueRemoteCall : RemoteCall {

        internal CfxOnProcessMessageReceivedSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxOnProcessMessageReceivedSetReturnValueRemoteCall) {}

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
            var e = (CfxOnProcessMessageReceivedEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

}
