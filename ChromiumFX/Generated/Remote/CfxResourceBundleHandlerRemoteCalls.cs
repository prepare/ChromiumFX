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

    internal class CfxResourceBundleHandlerCtorRemoteCall : RemoteCall {

        internal CfxResourceBundleHandlerCtorRemoteCall()
            : base(RemoteCallId.CfxResourceBundleHandlerCtorRemoteCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxResourceBundleHandler());
        }
    }

    internal class CfxGetLocalizedStringBrowserProcessCall : BrowserProcessCall {

        internal CfxGetLocalizedStringBrowserProcessCall()
            : base(RemoteCallId.CfxGetLocalizedStringBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxGetLocalizedStringEventArgs e) {
            var call = new CfxGetLocalizedStringBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrResourceBundleHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetLocalizedStringEventArgs(eventArgsId);
            sender.raise_GetLocalizedString(sender, e);
        }
    }

    internal class CfxGetLocalizedStringActivateRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringActivateRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetLocalizedString += CfxGetLocalizedStringBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetLocalizedStringDeactivateRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetLocalizedString -= CfxGetLocalizedStringBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetLocalizedStringGetStringIdRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringGetStringIdRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringGetStringIdRemoteCall) {}

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
            var e = (CfxGetLocalizedStringEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.StringId;
        }
    }

    internal class CfxGetLocalizedStringSetStringRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringSetStringRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringSetStringRemoteCall) {}

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
            var e = (CfxGetLocalizedStringEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.String = value;
        }
    }

    internal class CfxGetLocalizedStringGetStringRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringGetStringRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringGetStringRemoteCall) {}

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
            var e = (CfxGetLocalizedStringEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.String;
        }
    }

    internal class CfxGetLocalizedStringSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetLocalizedStringSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetLocalizedStringSetReturnValueRemoteCall) {}

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
            var e = (CfxGetLocalizedStringEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxGetDataResourceBrowserProcessCall : BrowserProcessCall {

        internal CfxGetDataResourceBrowserProcessCall()
            : base(RemoteCallId.CfxGetDataResourceBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxGetDataResourceEventArgs e) {
            var call = new CfxGetDataResourceBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrResourceBundleHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetDataResourceEventArgs(eventArgsId);
            sender.raise_GetDataResource(sender, e);
        }
    }

    internal class CfxGetDataResourceActivateRemoteCall : RemoteCall {

        internal CfxGetDataResourceActivateRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetDataResource += CfxGetDataResourceBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetDataResourceDeactivateRemoteCall : RemoteCall {

        internal CfxGetDataResourceDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetDataResource -= CfxGetDataResourceBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetDataResourceGetResourceIdRemoteCall : RemoteCall {

        internal CfxGetDataResourceGetResourceIdRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceGetResourceIdRemoteCall) {}

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
            var e = (CfxGetDataResourceEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.ResourceId;
        }
    }

    internal class CfxGetDataResourceSetDataRemoteCall : RemoteCall {

        internal CfxGetDataResourceSetDataRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceSetDataRemoteCall) {}

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
            var e = (CfxGetDataResourceEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Data = value;
        }
    }

    internal class CfxGetDataResourceSetDataSizeRemoteCall : RemoteCall {

        internal CfxGetDataResourceSetDataSizeRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceSetDataSizeRemoteCall) {}

        internal ulong eventArgsId;
        internal UIntPtr value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxGetDataResourceEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.DataSize = value;
        }
    }

    internal class CfxGetDataResourceSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetDataResourceSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceSetReturnValueRemoteCall) {}

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
            var e = (CfxGetDataResourceEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

    internal class CfxGetDataResourceForScaleBrowserProcessCall : BrowserProcessCall {

        internal CfxGetDataResourceForScaleBrowserProcessCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleBrowserProcessCall) {}

        internal static void EventCall(object sender, CfxGetDataResourceForScaleEventArgs e) {
            var call = new CfxGetDataResourceForScaleBrowserProcessCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrResourceBundleHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrGetDataResourceForScaleEventArgs(eventArgsId);
            sender.raise_GetDataResourceForScale(sender, e);
        }
    }

    internal class CfxGetDataResourceForScaleActivateRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleActivateRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetDataResourceForScale += CfxGetDataResourceForScaleBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetDataResourceForScaleDeactivateRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleDeactivateRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxResourceBundleHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.GetDataResourceForScale -= CfxGetDataResourceForScaleBrowserProcessCall.EventCall;
        }
    }

    internal class CfxGetDataResourceForScaleGetResourceIdRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleGetResourceIdRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleGetResourceIdRemoteCall) {}

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
            var e = (CfxGetDataResourceForScaleEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = e.ResourceId;
        }
    }

    internal class CfxGetDataResourceForScaleGetScaleFactorRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleGetScaleFactorRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleGetScaleFactorRemoteCall) {}

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
            var e = (CfxGetDataResourceForScaleEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            value = (int)e.ScaleFactor;
        }
    }

    internal class CfxGetDataResourceForScaleSetDataRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleSetDataRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleSetDataRemoteCall) {}

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
            var e = (CfxGetDataResourceForScaleEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.Data = value;
        }
    }

    internal class CfxGetDataResourceForScaleSetDataSizeRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleSetDataSizeRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleSetDataSizeRemoteCall) {}

        internal ulong eventArgsId;
        internal UIntPtr value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(eventArgsId);
            h.Write(value);
        }
        protected override void ReadArgs(StreamHandler h) {
            h.Read(out eventArgsId);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var e = (CfxGetDataResourceForScaleEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.DataSize = value;
        }
    }

    internal class CfxGetDataResourceForScaleSetReturnValueRemoteCall : RemoteCall {

        internal CfxGetDataResourceForScaleSetReturnValueRemoteCall()
            : base(RemoteCallId.CfxGetDataResourceForScaleSetReturnValueRemoteCall) {}

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
            var e = (CfxGetDataResourceForScaleEventArgs)BrowserProcessCall.GetEventArgs(eventArgsId);
            e.SetReturnValue(value);
        }
    }

}
