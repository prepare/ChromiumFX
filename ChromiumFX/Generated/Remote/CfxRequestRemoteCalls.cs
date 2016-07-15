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

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_create();
        }
    }

    internal class CfxRequestIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxRequestIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxRequestIsReadOnlyRenderProcessCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Request.cfx_request_is_read_only(@this);
        }
    }

    internal class CfxRequestGetUrlRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetUrlRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetUrlRenderProcessCall) {}

        internal IntPtr @this;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Request.cfx_request_get_url(@this));
        }
    }

    internal class CfxRequestSetUrlRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetUrlRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetUrlRenderProcessCall) {}

        internal IntPtr @this;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var value_pinned = new PinnedString(value);
            CfxApi.Request.cfx_request_set_url(@this, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxRequestGetMethodRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetMethodRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetMethodRenderProcessCall) {}

        internal IntPtr @this;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Request.cfx_request_get_method(@this));
        }
    }

    internal class CfxRequestSetMethodRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetMethodRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetMethodRenderProcessCall) {}

        internal IntPtr @this;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var value_pinned = new PinnedString(value);
            CfxApi.Request.cfx_request_set_method(@this, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxRequestSetReferrerRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetReferrerRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetReferrerRenderProcessCall) {}

        internal IntPtr @this;
        internal string referrerUrl;
        internal int policy;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(referrerUrl);
            h.Write(policy);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out referrerUrl);
            h.Read(out policy);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var referrerUrl_pinned = new PinnedString(referrerUrl);
            CfxApi.Request.cfx_request_set_referrer(@this, referrerUrl_pinned.Obj.PinnedPtr, referrerUrl_pinned.Length, (int)policy);
            referrerUrl_pinned.Obj.Free();
        }
    }

    internal class CfxRequestGetReferrerUrlRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetReferrerUrlRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetReferrerUrlRenderProcessCall) {}

        internal IntPtr @this;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Request.cfx_request_get_referrer_url(@this));
        }
    }

    internal class CfxRequestGetReferrerPolicyRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetReferrerPolicyRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetReferrerPolicyRenderProcessCall) {}

        internal IntPtr @this;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_referrer_policy(@this);
        }
    }

    internal class CfxRequestGetPostDataRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetPostDataRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetPostDataRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_post_data(@this);
        }
    }

    internal class CfxRequestSetPostDataRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetPostDataRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetPostDataRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Request.cfx_request_set_post_data(@this, value);
        }
    }

    internal class CfxRequestGetHeaderMapRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetHeaderMapRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetHeaderMapRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string[]> __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = new System.Collections.Generic.List<string[]>();
            var list = StringFunctions.AllocCfxStringMultimap();
            CfxApi.Request.cfx_request_get_header_map(@this, list);
            StringFunctions.CfxStringMultimapCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringMultimap(list);
        }
    }

    internal class CfxRequestSetHeaderMapRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetHeaderMapRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetHeaderMapRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string[]> headerMap;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(headerMap);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out headerMap);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = StringFunctions.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.Request.cfx_request_set_header_map(@this, headerMap_unwrapped);
            StringFunctions.FreePinnedStrings(headerMap_handles);
            StringFunctions.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.Runtime.cfx_string_multimap_free(headerMap_unwrapped);
        }
    }

    internal class CfxRequestSetRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetRenderProcessCall) {}

        internal IntPtr @this;
        internal string url;
        internal string method;
        internal IntPtr postData;
        internal System.Collections.Generic.List<string[]> headerMap;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(url);
            h.Write(method);
            h.Write(postData);
            h.Write(headerMap);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out url);
            h.Read(out method);
            h.Read(out postData);
            h.Read(out headerMap);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var url_pinned = new PinnedString(url);
            var method_pinned = new PinnedString(method);
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = StringFunctions.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.Request.cfx_request_set(@this, url_pinned.Obj.PinnedPtr, url_pinned.Length, method_pinned.Obj.PinnedPtr, method_pinned.Length, postData, headerMap_unwrapped);
            url_pinned.Obj.Free();
            method_pinned.Obj.Free();
            StringFunctions.FreePinnedStrings(headerMap_handles);
            StringFunctions.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.Runtime.cfx_string_multimap_free(headerMap_unwrapped);
        }
    }

    internal class CfxRequestGetFlagsRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetFlagsRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetFlagsRenderProcessCall) {}

        internal IntPtr @this;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_flags(@this);
        }
    }

    internal class CfxRequestSetFlagsRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetFlagsRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetFlagsRenderProcessCall) {}

        internal IntPtr @this;
        internal int value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Request.cfx_request_set_flags(@this, value);
        }
    }

    internal class CfxRequestGetFirstPartyForCookiesRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetFirstPartyForCookiesRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetFirstPartyForCookiesRenderProcessCall) {}

        internal IntPtr @this;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Request.cfx_request_get_first_party_for_cookies(@this));
        }
    }

    internal class CfxRequestSetFirstPartyForCookiesRenderProcessCall : RenderProcessCall {

        internal CfxRequestSetFirstPartyForCookiesRenderProcessCall()
            : base(RemoteCallId.CfxRequestSetFirstPartyForCookiesRenderProcessCall) {}

        internal IntPtr @this;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var value_pinned = new PinnedString(value);
            CfxApi.Request.cfx_request_set_first_party_for_cookies(@this, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxRequestGetResourceTypeRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetResourceTypeRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetResourceTypeRenderProcessCall) {}

        internal IntPtr @this;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_resource_type(@this);
        }
    }

    internal class CfxRequestGetTransitionTypeRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetTransitionTypeRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetTransitionTypeRenderProcessCall) {}

        internal IntPtr @this;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_transition_type(@this);
        }
    }

    internal class CfxRequestGetIdentifierRenderProcessCall : RenderProcessCall {

        internal CfxRequestGetIdentifierRenderProcessCall()
            : base(RemoteCallId.CfxRequestGetIdentifierRenderProcessCall) {}

        internal IntPtr @this;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Request.cfx_request_get_identifier(@this);
        }
    }

}
