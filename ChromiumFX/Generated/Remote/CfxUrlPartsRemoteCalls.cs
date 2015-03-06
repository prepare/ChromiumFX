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

    internal class CfxUrlPartsCtorRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsCtorRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsCtorRenderProcessCall) {}

        internal ulong __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxUrlParts());
        }
    }

    internal class CfxUrlPartsGetSpecRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetSpecRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetSpecRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Spec;
        }
    }
    internal class CfxUrlPartsSetSpecRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetSpecRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetSpecRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Spec = value;
        }
    }
    internal class CfxUrlPartsGetSchemeRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetSchemeRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetSchemeRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Scheme;
        }
    }
    internal class CfxUrlPartsSetSchemeRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetSchemeRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetSchemeRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Scheme = value;
        }
    }
    internal class CfxUrlPartsGetUserNameRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetUserNameRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetUserNameRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.UserName;
        }
    }
    internal class CfxUrlPartsSetUserNameRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetUserNameRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetUserNameRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.UserName = value;
        }
    }
    internal class CfxUrlPartsGetPasswordRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetPasswordRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetPasswordRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Password;
        }
    }
    internal class CfxUrlPartsSetPasswordRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetPasswordRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetPasswordRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Password = value;
        }
    }
    internal class CfxUrlPartsGetHostRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetHostRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetHostRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Host;
        }
    }
    internal class CfxUrlPartsSetHostRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetHostRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetHostRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Host = value;
        }
    }
    internal class CfxUrlPartsGetPortRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetPortRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetPortRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Port;
        }
    }
    internal class CfxUrlPartsSetPortRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetPortRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetPortRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Port = value;
        }
    }
    internal class CfxUrlPartsGetOriginRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetOriginRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetOriginRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Origin;
        }
    }
    internal class CfxUrlPartsSetOriginRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetOriginRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetOriginRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Origin = value;
        }
    }
    internal class CfxUrlPartsGetPathRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetPathRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetPathRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Path;
        }
    }
    internal class CfxUrlPartsSetPathRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetPathRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetPathRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Path = value;
        }
    }
    internal class CfxUrlPartsGetQueryRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsGetQueryRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsGetQueryRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            value = sender.Query;
        }
    }
    internal class CfxUrlPartsSetQueryRenderProcessCall : RenderProcessCall {

        internal CfxUrlPartsSetQueryRenderProcessCall()
            : base(RemoteCallId.CfxUrlPartsSetQueryRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxUrlParts)RemoteProxy.Unwrap(this.sender);
            sender.Query = value;
        }
    }
}
