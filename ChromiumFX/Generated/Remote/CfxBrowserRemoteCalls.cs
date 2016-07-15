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

    internal class CfxBrowserCanGoBackRenderProcessCall : RenderProcessCall {

        internal CfxBrowserCanGoBackRenderProcessCall()
            : base(RemoteCallId.CfxBrowserCanGoBackRenderProcessCall) {}

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
            __retval = 0 != CfxApi.Browser.cfx_browser_can_go_back(@this);
        }
    }

    internal class CfxBrowserGoBackRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGoBackRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGoBackRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_go_back(@this);
        }
    }

    internal class CfxBrowserCanGoForwardRenderProcessCall : RenderProcessCall {

        internal CfxBrowserCanGoForwardRenderProcessCall()
            : base(RemoteCallId.CfxBrowserCanGoForwardRenderProcessCall) {}

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
            __retval = 0 != CfxApi.Browser.cfx_browser_can_go_forward(@this);
        }
    }

    internal class CfxBrowserGoForwardRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGoForwardRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGoForwardRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_go_forward(@this);
        }
    }

    internal class CfxBrowserIsLoadingRenderProcessCall : RenderProcessCall {

        internal CfxBrowserIsLoadingRenderProcessCall()
            : base(RemoteCallId.CfxBrowserIsLoadingRenderProcessCall) {}

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
            __retval = 0 != CfxApi.Browser.cfx_browser_is_loading(@this);
        }
    }

    internal class CfxBrowserReloadRenderProcessCall : RenderProcessCall {

        internal CfxBrowserReloadRenderProcessCall()
            : base(RemoteCallId.CfxBrowserReloadRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_reload(@this);
        }
    }

    internal class CfxBrowserReloadIgnoreCacheRenderProcessCall : RenderProcessCall {

        internal CfxBrowserReloadIgnoreCacheRenderProcessCall()
            : base(RemoteCallId.CfxBrowserReloadIgnoreCacheRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_reload_ignore_cache(@this);
        }
    }

    internal class CfxBrowserStopLoadRenderProcessCall : RenderProcessCall {

        internal CfxBrowserStopLoadRenderProcessCall()
            : base(RemoteCallId.CfxBrowserStopLoadRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_stop_load(@this);
        }
    }

    internal class CfxBrowserGetIdentifierRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetIdentifierRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetIdentifierRenderProcessCall) {}

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
            __retval = CfxApi.Browser.cfx_browser_get_identifier(@this);
        }
    }

    internal class CfxBrowserIsSameRenderProcessCall : RenderProcessCall {

        internal CfxBrowserIsSameRenderProcessCall()
            : base(RemoteCallId.CfxBrowserIsSameRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr that;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(that);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out that);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_is_same(@this, that);
        }
    }

    internal class CfxBrowserIsPopupRenderProcessCall : RenderProcessCall {

        internal CfxBrowserIsPopupRenderProcessCall()
            : base(RemoteCallId.CfxBrowserIsPopupRenderProcessCall) {}

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
            __retval = 0 != CfxApi.Browser.cfx_browser_is_popup(@this);
        }
    }

    internal class CfxBrowserHasDocumentRenderProcessCall : RenderProcessCall {

        internal CfxBrowserHasDocumentRenderProcessCall()
            : base(RemoteCallId.CfxBrowserHasDocumentRenderProcessCall) {}

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
            __retval = 0 != CfxApi.Browser.cfx_browser_has_document(@this);
        }
    }

    internal class CfxBrowserGetMainFrameRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetMainFrameRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetMainFrameRenderProcessCall) {}

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
            __retval = CfxApi.Browser.cfx_browser_get_main_frame(@this);
        }
    }

    internal class CfxBrowserGetFocusedFrameRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFocusedFrameRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFocusedFrameRenderProcessCall) {}

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
            __retval = CfxApi.Browser.cfx_browser_get_focused_frame(@this);
        }
    }

    internal class CfxBrowserGetFrameByIdentifierRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFrameByIdentifierRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFrameByIdentifierRenderProcessCall) {}

        internal IntPtr @this;
        internal long identifier;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(identifier);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out identifier);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Browser.cfx_browser_get_frame_byident(@this, identifier);
        }
    }

    internal class CfxBrowserGetFrameRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFrameRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFrameRenderProcessCall) {}

        internal IntPtr @this;
        internal string name;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = CfxApi.Browser.cfx_browser_get_frame(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxBrowserGetFrameCountRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFrameCountRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFrameCountRenderProcessCall) {}

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
            __retval = CfxApi.Browser.cfx_browser_get_frame_count(@this);
        }
    }

    internal class CfxBrowserGetFrameIdentifiersRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFrameIdentifiersRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFrameIdentifiersRenderProcessCall) {}

        internal IntPtr @this;
        internal long[] __retval;

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
            int identifiersCount = CfxApi.Browser.cfx_browser_get_frame_count(@this);
            __retval = new long[identifiersCount];
            if(identifiersCount == 0) return;
            var retval_p = new PinnedObject(__retval);
            CfxApi.Browser.cfx_browser_get_frame_identifiers(@this, identifiersCount, retval_p.PinnedPtr);
            retval_p.Free();
        }
    }

    internal class CfxBrowserGetFrameNamesRenderProcessCall : RenderProcessCall {

        internal CfxBrowserGetFrameNamesRenderProcessCall()
            : base(RemoteCallId.CfxBrowserGetFrameNamesRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string> __retval;

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
            __retval = new System.Collections.Generic.List<string>();
            var list = StringFunctions.AllocCfxStringList();
            CfxApi.Browser.cfx_browser_get_frame_names(@this, list);
            StringFunctions.CfxStringListCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringList(list);
        }
    }

    internal class CfxBrowserSendProcessMessageRenderProcessCall : RenderProcessCall {

        internal CfxBrowserSendProcessMessageRenderProcessCall()
            : base(RemoteCallId.CfxBrowserSendProcessMessageRenderProcessCall) {}

        internal IntPtr @this;
        internal int targetProcess;
        internal IntPtr message;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(targetProcess);
            h.Write(message);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out targetProcess);
            h.Read(out message);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_send_process_message(@this, (int)targetProcess, message);
        }
    }

}
