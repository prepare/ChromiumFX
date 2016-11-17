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

    internal class CfxAppCtorRemoteCall : RemoteCall {

        internal CfxAppCtorRemoteCall()
            : base(RemoteCallId.CfxAppCtorRemoteCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxApp());
        }
    }

    internal class CfxOnBeforeCommandLineProcessingRemoteClientCall : RemoteClientCall {

        internal CfxOnBeforeCommandLineProcessingRemoteClientCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnBeforeCommandLineProcessingEventArgs e) {
            var call = new CfxOnBeforeCommandLineProcessingRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrApp.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnBeforeCommandLineProcessingEventArgs(eventArgsId);
            sender.raise_OnBeforeCommandLineProcessing(sender, e);
        }
    }

    internal class CfxOnBeforeCommandLineProcessingActivateRemoteCall : RemoteCall {

        internal CfxOnBeforeCommandLineProcessingActivateRemoteCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBeforeCommandLineProcessing += CfxOnBeforeCommandLineProcessingRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBeforeCommandLineProcessingDeactivateRemoteCall : RemoteCall {

        internal CfxOnBeforeCommandLineProcessingDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.OnBeforeCommandLineProcessing -= CfxOnBeforeCommandLineProcessingRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnBeforeCommandLineProcessingGetProcessTypeRemoteCall : RemoteCall {

        internal CfxOnBeforeCommandLineProcessingGetProcessTypeRemoteCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingGetProcessTypeRemoteCall) {}

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
            var e = (CfxOnBeforeCommandLineProcessingEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.ProcessType;
        }
    }

    internal class CfxOnBeforeCommandLineProcessingGetCommandLineRemoteCall : RemoteCall {

        internal CfxOnBeforeCommandLineProcessingGetCommandLineRemoteCall()
            : base(RemoteCallId.CfxOnBeforeCommandLineProcessingGetCommandLineRemoteCall) {}

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
            var e = (CfxOnBeforeCommandLineProcessingEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.CommandLine);
        }
    }

    internal class CfxOnRegisterCustomSchemesRemoteClientCall : RemoteClientCall {

        internal CfxOnRegisterCustomSchemesRemoteClientCall()
            : base(RemoteCallId.CfxOnRegisterCustomSchemesRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnRegisterCustomSchemesEventArgs e) {
            var call = new CfxOnRegisterCustomSchemesRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrApp.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnRegisterCustomSchemesEventArgs(eventArgsId);
            sender.raise_OnRegisterCustomSchemes(sender, e);
        }
    }

    internal class CfxOnRegisterCustomSchemesActivateRemoteCall : RemoteCall {

        internal CfxOnRegisterCustomSchemesActivateRemoteCall()
            : base(RemoteCallId.CfxOnRegisterCustomSchemesActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.OnRegisterCustomSchemes += CfxOnRegisterCustomSchemesRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnRegisterCustomSchemesDeactivateRemoteCall : RemoteCall {

        internal CfxOnRegisterCustomSchemesDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnRegisterCustomSchemesDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.OnRegisterCustomSchemes -= CfxOnRegisterCustomSchemesRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnRegisterCustomSchemesGetRegistrarRemoteCall : RemoteCall {

        internal CfxOnRegisterCustomSchemesGetRegistrarRemoteCall()
            : base(RemoteCallId.CfxOnRegisterCustomSchemesGetRegistrarRemoteCall) {}

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
            var e = (CfxOnRegisterCustomSchemesEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Registrar);
        }
    }

    internal class CfxGetResourceBundleHandlerRemoteClientCall : RemoteClientCall {

        internal CfxGetResourceBundleHandlerRemoteClientCall()
            : base(RemoteCallId.CfxGetResourceBundleHandlerRemoteClientCall) {}

        internal static void EventCall(object sender, CfxGetResourceBundleHandlerEventArgs e) {
            var call = new CfxGetResourceBundleHandlerRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrApp.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetResourceBundleHandlerEventArgs(eventArgsId);
            sender.raise_GetResourceBundleHandler(sender, e);
        }
    }

    internal class CfxGetResourceBundleHandlerActivateRemoteCall : RemoteCall {

        internal CfxGetResourceBundleHandlerActivateRemoteCall()
            : base(RemoteCallId.CfxGetResourceBundleHandlerActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.GetResourceBundleHandler += CfxGetResourceBundleHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetResourceBundleHandlerDeactivateRemoteCall : RemoteCall {

        internal CfxGetResourceBundleHandlerDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetResourceBundleHandlerDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.GetResourceBundleHandler -= CfxGetResourceBundleHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetResourceBundleHandlerSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetResourceBundleHandlerSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetResourceBundleHandlerSetReturnValueRemoteCall) {}

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
            var e = (CfxGetResourceBundleHandlerEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue((CfxResourceBundleHandler)RemoteProxy.Unwrap(value, (ptr) => new CfxResourceBundleHandler(ptr)));
        }
    }

    internal class CfxGetRenderProcessHandlerRemoteClientCall : RemoteClientCall {

        internal CfxGetRenderProcessHandlerRemoteClientCall()
            : base(RemoteCallId.CfxGetRenderProcessHandlerRemoteClientCall) {}

        internal static void EventCall(object sender, CfxGetRenderProcessHandlerEventArgs e) {
            var call = new CfxGetRenderProcessHandlerRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrApp.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetRenderProcessHandlerEventArgs(eventArgsId);
            sender.raise_GetRenderProcessHandler(sender, e);
        }
    }

    internal class CfxGetRenderProcessHandlerActivateRemoteCall : RemoteCall {

        internal CfxGetRenderProcessHandlerActivateRemoteCall()
            : base(RemoteCallId.CfxGetRenderProcessHandlerActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.GetRenderProcessHandler += CfxGetRenderProcessHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetRenderProcessHandlerDeactivateRemoteCall : RemoteCall {

        internal CfxGetRenderProcessHandlerDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetRenderProcessHandlerDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxApp)RemoteProxy.Unwrap(this.sender, null);
            sender.GetRenderProcessHandler -= CfxGetRenderProcessHandlerRemoteClientCall.EventCall;
        }
    }

    internal class CfxGetRenderProcessHandlerSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetRenderProcessHandlerSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetRenderProcessHandlerSetReturnValueRemoteCall) {}

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
            var e = (CfxGetRenderProcessHandlerEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            e.SetReturnValue((CfxRenderProcessHandler)RemoteProxy.Unwrap(value, (ptr) => new CfxRenderProcessHandler(ptr)));
        }
    }

}
