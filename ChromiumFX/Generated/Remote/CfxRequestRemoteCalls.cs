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

    internal class CfxRequestCreateRenderProcessCall : RenderProcessCall {

        internal CfxRequestCreateRenderProcessCall()
            : base(RemoteCallId.CfxRequestCreateRenderProcessCall) {}

        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
        }

        protected override void ReadArgs(StreamHandler h) {
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(CfxRequest.Create());
        }
    }

    internal class CfxRequestIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxRequestIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxRequestIsReadOnlyRenderProcessCall) {}

        internal ulong self;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.IsReadOnly;
        }
    }

    internal class CfxRequestGetUrlRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetUrlRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetUrlRenderProcessCall) {}

        internal ulong self;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.Url;
        }
    }

    internal class CfxRequestSetUrlRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetUrlRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetUrlRenderProcessCall) {}

        internal ulong self;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.Url = value;
        }
    }

    internal class CfxRequestGetMethodRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetMethodRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetMethodRenderProcessCall) {}

        internal ulong self;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.Method;
        }
    }

    internal class CfxRequestSetMethodRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetMethodRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetMethodRenderProcessCall) {}

        internal ulong self;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.Method = value;
        }
    }

    internal class CfxRequestGetPostDataRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetPostDataRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetPostDataRenderProcessCall) {}

        internal ulong self;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.PostData);
        }
    }

    internal class CfxRequestSetPostDataRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetPostDataRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetPostDataRenderProcessCall) {}

        internal ulong self;
        internal ulong value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.PostData = (CfxPostData)RemoteProxy.Unwrap(value);
        }
    }

    internal class CfxRequestGetHeaderMapRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetHeaderMapRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetHeaderMapRenderProcessCall) {}

        internal ulong self;
        internal System.Collections.Generic.List<string[]> __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.GetHeaderMap();
        }
    }

    internal class CfxRequestSetHeaderMapRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetHeaderMapRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetHeaderMapRenderProcessCall) {}

        internal ulong self;
        internal System.Collections.Generic.List<string[]> headerMap;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(headerMap);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out headerMap);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.SetHeaderMap(headerMap);
        }
    }

    internal class CfxRequestSetRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetRenderProcessCall) {}

        internal ulong self;
        internal string url;
        internal string method;
        internal ulong postData;
        internal System.Collections.Generic.List<string[]> headerMap;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(url);
            h.Write(method);
            h.Write(postData);
            h.Write(headerMap);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out url);
            h.Read(out method);
            h.Read(out postData);
            h.Read(out headerMap);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.Set(url, method, (CfxPostData)RemoteProxy.Unwrap(postData), headerMap);
        }
    }

    internal class CfxRequestGetFlagsRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetFlagsRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetFlagsRenderProcessCall) {}

        internal ulong self;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.Flags;
        }
    }

    internal class CfxRequestSetFlagsRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetFlagsRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetFlagsRenderProcessCall) {}

        internal ulong self;
        internal int value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.Flags = value;
        }
    }

    internal class CfxRequestGetFirstPartyForCookiesRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetFirstPartyForCookiesRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetFirstPartyForCookiesRenderProcessCall) {}

        internal ulong self;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.FirstPartyForCookies;
        }
    }

    internal class CfxRequestSetFirstPartyForCookiesRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetFirstPartyForCookiesRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetFirstPartyForCookiesRenderProcessCall) {}

        internal ulong self;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            self_local.FirstPartyForCookies = value;
        }
    }

    internal class CfxRequestGetResourceTypeRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetResourceTypeRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetResourceTypeRenderProcessCall) {}

        internal ulong self;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = (int)self_local.ResourceType;
        }
    }

    internal class CfxRequestGetTransitionTypeRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetTransitionTypeRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetTransitionTypeRenderProcessCall) {}

        internal ulong self;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = (int)self_local.TransitionType;
        }
    }

    internal class CfxRequestGetIdentifierRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetIdentifierRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetIdentifierRenderProcessCall) {}

        internal ulong self;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxRequest)RemoteProxy.Unwrap(self);
            __retval = self_local.Identifier;
        }
    }

}
