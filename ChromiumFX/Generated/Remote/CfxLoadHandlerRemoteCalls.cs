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

    internal class CfxLoadHandlerCtorRemoteCall : CtorRemoteCall {

        internal CfxLoadHandlerCtorRemoteCall()
            : base(RemoteCallId.CfxLoadHandlerCtorRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxLoadHandler());
        }
    }

    internal class CfxOnLoadingStateChangeRemoteClientCall : RemoteClientCall {

        internal CfxOnLoadingStateChangeRemoteClientCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnLoadingStateChangeEventArgs e) {
            var call = new CfxOnLoadingStateChangeRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrLoadHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnLoadingStateChangeEventArgs(eventArgsId);
            sender.raise_OnLoadingStateChange(sender, e);
        }
    }

    internal class CfxOnLoadingStateChangeActivateRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeActivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadingStateChange += CfxOnLoadingStateChangeRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadingStateChangeDeactivateRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadingStateChange -= CfxOnLoadingStateChangeRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadingStateChangeGetBrowserRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeGetBrowserRemoteCall) {}

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
            var e = (CfxOnLoadingStateChangeEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnLoadingStateChangeGetIsLoadingRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeGetIsLoadingRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeGetIsLoadingRemoteCall) {}

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
            var e = (CfxOnLoadingStateChangeEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.IsLoading;
        }
    }

    internal class CfxOnLoadingStateChangeGetCanGoBackRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeGetCanGoBackRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeGetCanGoBackRemoteCall) {}

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
            var e = (CfxOnLoadingStateChangeEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.CanGoBack;
        }
    }

    internal class CfxOnLoadingStateChangeGetCanGoForwardRemoteCall : RemoteCall {

        internal CfxOnLoadingStateChangeGetCanGoForwardRemoteCall()
            : base(RemoteCallId.CfxOnLoadingStateChangeGetCanGoForwardRemoteCall) {}

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
            var e = (CfxOnLoadingStateChangeEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.CanGoForward;
        }
    }

    internal class CfxOnLoadStartRemoteClientCall : RemoteClientCall {

        internal CfxOnLoadStartRemoteClientCall()
            : base(RemoteCallId.CfxOnLoadStartRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnLoadStartEventArgs e) {
            var call = new CfxOnLoadStartRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrLoadHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnLoadStartEventArgs(eventArgsId);
            sender.raise_OnLoadStart(sender, e);
        }
    }

    internal class CfxOnLoadStartActivateRemoteCall : RemoteCall {

        internal CfxOnLoadStartActivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadStartActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadStart += CfxOnLoadStartRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadStartDeactivateRemoteCall : RemoteCall {

        internal CfxOnLoadStartDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadStartDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadStart -= CfxOnLoadStartRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadStartGetBrowserRemoteCall : RemoteCall {

        internal CfxOnLoadStartGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnLoadStartGetBrowserRemoteCall) {}

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
            var e = (CfxOnLoadStartEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnLoadStartGetFrameRemoteCall : RemoteCall {

        internal CfxOnLoadStartGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnLoadStartGetFrameRemoteCall) {}

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
            var e = (CfxOnLoadStartEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnLoadStartGetTransitionTypeRemoteCall : RemoteCall {

        internal CfxOnLoadStartGetTransitionTypeRemoteCall()
            : base(RemoteCallId.CfxOnLoadStartGetTransitionTypeRemoteCall) {}

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
            var e = (CfxOnLoadStartEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = (int)e.TransitionType;
        }
    }

    internal class CfxOnLoadEndRemoteClientCall : RemoteClientCall {

        internal CfxOnLoadEndRemoteClientCall()
            : base(RemoteCallId.CfxOnLoadEndRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnLoadEndEventArgs e) {
            var call = new CfxOnLoadEndRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrLoadHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnLoadEndEventArgs(eventArgsId);
            sender.raise_OnLoadEnd(sender, e);
        }
    }

    internal class CfxOnLoadEndActivateRemoteCall : RemoteCall {

        internal CfxOnLoadEndActivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadEndActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadEnd += CfxOnLoadEndRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadEndDeactivateRemoteCall : RemoteCall {

        internal CfxOnLoadEndDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadEndDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadEnd -= CfxOnLoadEndRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadEndGetBrowserRemoteCall : RemoteCall {

        internal CfxOnLoadEndGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnLoadEndGetBrowserRemoteCall) {}

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
            var e = (CfxOnLoadEndEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnLoadEndGetFrameRemoteCall : RemoteCall {

        internal CfxOnLoadEndGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnLoadEndGetFrameRemoteCall) {}

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
            var e = (CfxOnLoadEndEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnLoadEndGetHttpStatusCodeRemoteCall : RemoteCall {

        internal CfxOnLoadEndGetHttpStatusCodeRemoteCall()
            : base(RemoteCallId.CfxOnLoadEndGetHttpStatusCodeRemoteCall) {}

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
            var e = (CfxOnLoadEndEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.HttpStatusCode;
        }
    }

    internal class CfxOnLoadErrorRemoteClientCall : RemoteClientCall {

        internal CfxOnLoadErrorRemoteClientCall()
            : base(RemoteCallId.CfxOnLoadErrorRemoteClientCall) {}

        internal static void EventCall(object sender, CfxOnLoadErrorEventArgs e) {
            var call = new CfxOnLoadErrorRemoteClientCall();
            call.sender = RemoteProxy.Wrap((CfxBase)sender);
            call.eventArgsId = AddEventArgs(e);
            call.RequestExecution(RemoteClient.connection);
            RemoveEventArgs(call.eventArgsId);
        }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = CfrLoadHandler.Wrap(new RemotePtr(connection, this.sender));
            var e = new CfrOnLoadErrorEventArgs(eventArgsId);
            sender.raise_OnLoadError(sender, e);
        }
    }

    internal class CfxOnLoadErrorActivateRemoteCall : RemoteCall {

        internal CfxOnLoadErrorActivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorActivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadError += CfxOnLoadErrorRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadErrorDeactivateRemoteCall : RemoteCall {

        internal CfxOnLoadErrorDeactivateRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorDeactivateRemoteCall) {}

        internal IntPtr sender;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxLoadHandler)RemoteProxy.Unwrap(this.sender, null);
            sender.OnLoadError -= CfxOnLoadErrorRemoteClientCall.EventCall;
        }
    }

    internal class CfxOnLoadErrorGetBrowserRemoteCall : RemoteCall {

        internal CfxOnLoadErrorGetBrowserRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorGetBrowserRemoteCall) {}

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
            var e = (CfxOnLoadErrorEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Browser);
        }
    }

    internal class CfxOnLoadErrorGetFrameRemoteCall : RemoteCall {

        internal CfxOnLoadErrorGetFrameRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorGetFrameRemoteCall) {}

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
            var e = (CfxOnLoadErrorEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = RemoteProxy.Wrap(e.Frame);
        }
    }

    internal class CfxOnLoadErrorGetErrorCodeRemoteCall : RemoteCall {

        internal CfxOnLoadErrorGetErrorCodeRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorGetErrorCodeRemoteCall) {}

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
            var e = (CfxOnLoadErrorEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = (int)e.ErrorCode;
        }
    }

    internal class CfxOnLoadErrorGetErrorTextRemoteCall : RemoteCall {

        internal CfxOnLoadErrorGetErrorTextRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorGetErrorTextRemoteCall) {}

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
            var e = (CfxOnLoadErrorEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.ErrorText;
        }
    }

    internal class CfxOnLoadErrorGetFailedUrlRemoteCall : RemoteCall {

        internal CfxOnLoadErrorGetFailedUrlRemoteCall()
            : base(RemoteCallId.CfxOnLoadErrorGetFailedUrlRemoteCall) {}

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
            var e = (CfxOnLoadErrorEventArgs)RemoteClientCall.GetEventArgs(eventArgsId);
            value = e.FailedUrl;
        }
    }

}
