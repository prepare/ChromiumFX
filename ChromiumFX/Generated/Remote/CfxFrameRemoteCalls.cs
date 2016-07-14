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

    internal class CfxFrameIsValidRenderProcessCall : RenderProcessCall {

        internal CfxFrameIsValidRenderProcessCall()
            : base(RemoteCallId.CfxFrameIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_frame_is_valid(@this);
        }
    }

    internal class CfxFrameUndoRenderProcessCall : RenderProcessCall {

        internal CfxFrameUndoRenderProcessCall()
            : base(RemoteCallId.CfxFrameUndoRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_undo(@this);
        }
    }

    internal class CfxFrameRedoRenderProcessCall : RenderProcessCall {

        internal CfxFrameRedoRenderProcessCall()
            : base(RemoteCallId.CfxFrameRedoRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_redo(@this);
        }
    }

    internal class CfxFrameCutRenderProcessCall : RenderProcessCall {

        internal CfxFrameCutRenderProcessCall()
            : base(RemoteCallId.CfxFrameCutRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_cut(@this);
        }
    }

    internal class CfxFrameCopyRenderProcessCall : RenderProcessCall {

        internal CfxFrameCopyRenderProcessCall()
            : base(RemoteCallId.CfxFrameCopyRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_copy(@this);
        }
    }

    internal class CfxFramePasteRenderProcessCall : RenderProcessCall {

        internal CfxFramePasteRenderProcessCall()
            : base(RemoteCallId.CfxFramePasteRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_paste(@this);
        }
    }

    internal class CfxFrameDelRenderProcessCall : RenderProcessCall {

        internal CfxFrameDelRenderProcessCall()
            : base(RemoteCallId.CfxFrameDelRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_del(@this);
        }
    }

    internal class CfxFrameSelectAllRenderProcessCall : RenderProcessCall {

        internal CfxFrameSelectAllRenderProcessCall()
            : base(RemoteCallId.CfxFrameSelectAllRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_select_all(@this);
        }
    }

    internal class CfxFrameGetSourceRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetSourceRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetSourceRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr visitor;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(visitor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out visitor);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_get_source(@this, visitor);
        }
    }

    internal class CfxFrameGetTextRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetTextRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetTextRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr visitor;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(visitor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out visitor);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_get_text(@this, visitor);
        }
    }

    internal class CfxFrameLoadRequestRenderProcessCall : RenderProcessCall {

        internal CfxFrameLoadRequestRenderProcessCall()
            : base(RemoteCallId.CfxFrameLoadRequestRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr request;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(request);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out request);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_load_request(@this, request);
        }
    }

    internal class CfxFrameLoadUrlRenderProcessCall : RenderProcessCall {

        internal CfxFrameLoadUrlRenderProcessCall()
            : base(RemoteCallId.CfxFrameLoadUrlRenderProcessCall) {}

        internal IntPtr @this;
        internal string url;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(url);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out url);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var url_pinned = new PinnedString(url);
            CfxApi.cfx_frame_load_url(@this, url_pinned.Obj.PinnedPtr, url_pinned.Length);
            url_pinned.Obj.Free();
        }
    }

    internal class CfxFrameLoadStringRenderProcessCall : RenderProcessCall {

        internal CfxFrameLoadStringRenderProcessCall()
            : base(RemoteCallId.CfxFrameLoadStringRenderProcessCall) {}

        internal IntPtr @this;
        internal string stringVal;
        internal string url;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(stringVal);
            h.Write(url);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out stringVal);
            h.Read(out url);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var stringVal_pinned = new PinnedString(stringVal);
            var url_pinned = new PinnedString(url);
            CfxApi.cfx_frame_load_string(@this, stringVal_pinned.Obj.PinnedPtr, stringVal_pinned.Length, url_pinned.Obj.PinnedPtr, url_pinned.Length);
            stringVal_pinned.Obj.Free();
            url_pinned.Obj.Free();
        }
    }

    internal class CfxFrameExecuteJavaScriptRenderProcessCall : RenderProcessCall {

        internal CfxFrameExecuteJavaScriptRenderProcessCall()
            : base(RemoteCallId.CfxFrameExecuteJavaScriptRenderProcessCall) {}

        internal IntPtr @this;
        internal string code;
        internal string scriptUrl;
        internal int startLine;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(code);
            h.Write(scriptUrl);
            h.Write(startLine);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out code);
            h.Read(out scriptUrl);
            h.Read(out startLine);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var code_pinned = new PinnedString(code);
            var scriptUrl_pinned = new PinnedString(scriptUrl);
            CfxApi.cfx_frame_execute_java_script(@this, code_pinned.Obj.PinnedPtr, code_pinned.Length, scriptUrl_pinned.Obj.PinnedPtr, scriptUrl_pinned.Length, startLine);
            code_pinned.Obj.Free();
            scriptUrl_pinned.Obj.Free();
        }
    }

    internal class CfxFrameIsMainRenderProcessCall : RenderProcessCall {

        internal CfxFrameIsMainRenderProcessCall()
            : base(RemoteCallId.CfxFrameIsMainRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_frame_is_main(@this);
        }
    }

    internal class CfxFrameIsFocusedRenderProcessCall : RenderProcessCall {

        internal CfxFrameIsFocusedRenderProcessCall()
            : base(RemoteCallId.CfxFrameIsFocusedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_frame_is_focused(@this);
        }
    }

    internal class CfxFrameGetNameRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetNameRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_frame_get_name(@this));
        }
    }

    internal class CfxFrameGetIdentifierRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetIdentifierRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetIdentifierRenderProcessCall) {}

        internal IntPtr @this;
        internal long __retval;

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
            __retval = CfxApi.cfx_frame_get_identifier(@this);
        }
    }

    internal class CfxFrameGetParentRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetParentRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetParentRenderProcessCall) {}

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
            __retval = CfxApi.cfx_frame_get_parent(@this);
        }
    }

    internal class CfxFrameGetUrlRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetUrlRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetUrlRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_frame_get_url(@this));
        }
    }

    internal class CfxFrameGetBrowserRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetBrowserRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetBrowserRenderProcessCall) {}

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
            __retval = CfxApi.cfx_frame_get_browser(@this);
        }
    }

    internal class CfxFrameGetV8ContextRenderProcessCall : RenderProcessCall {

        internal CfxFrameGetV8ContextRenderProcessCall()
            : base(RemoteCallId.CfxFrameGetV8ContextRenderProcessCall) {}

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
            __retval = CfxApi.cfx_frame_get_v8context(@this);
        }
    }

    internal class CfxFrameVisitDomRenderProcessCall : RenderProcessCall {

        internal CfxFrameVisitDomRenderProcessCall()
            : base(RemoteCallId.CfxFrameVisitDomRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr visitor;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(visitor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out visitor);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.cfx_frame_visit_dom(@this, visitor);
        }
    }

}
