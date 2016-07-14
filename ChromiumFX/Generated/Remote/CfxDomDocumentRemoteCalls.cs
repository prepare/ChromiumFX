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

    internal class CfxDomDocumentGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetTypeRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_type(@this);
        }
    }

    internal class CfxDomDocumentGetDocumentRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetDocumentRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetDocumentRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_document(@this);
        }
    }

    internal class CfxDomDocumentGetBodyRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetBodyRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetBodyRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_body(@this);
        }
    }

    internal class CfxDomDocumentGetHeadRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetHeadRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetHeadRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_head(@this);
        }
    }

    internal class CfxDomDocumentGetTitleRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetTitleRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetTitleRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_domdocument_get_title(@this));
        }
    }

    internal class CfxDomDocumentGetElementByIdRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetElementByIdRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetElementByIdRenderProcessCall) {}

        internal IntPtr @this;
        internal string id;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(id);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out id);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var id_pinned = new PinnedString(id);
            __retval = CfxApi.cfx_domdocument_get_element_by_id(@this, id_pinned.Obj.PinnedPtr, id_pinned.Length);
            id_pinned.Obj.Free();
        }
    }

    internal class CfxDomDocumentGetFocusedNodeRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetFocusedNodeRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetFocusedNodeRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_focused_node(@this);
        }
    }

    internal class CfxDomDocumentHasSelectionRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentHasSelectionRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentHasSelectionRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_domdocument_has_selection(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionStartOffsetRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetSelectionStartOffsetRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionStartOffsetRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_selection_start_offset(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionEndOffsetRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetSelectionEndOffsetRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionEndOffsetRenderProcessCall) {}

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
            __retval = CfxApi.cfx_domdocument_get_selection_end_offset(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionAsMarkupRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetSelectionAsMarkupRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionAsMarkupRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_domdocument_get_selection_as_markup(@this));
        }
    }

    internal class CfxDomDocumentGetSelectionAsTextRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetSelectionAsTextRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionAsTextRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_domdocument_get_selection_as_text(@this));
        }
    }

    internal class CfxDomDocumentGetBaseUrlRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetBaseUrlRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetBaseUrlRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_domdocument_get_base_url(@this));
        }
    }

    internal class CfxDomDocumentGetCompleteUrlRenderProcessCall : RenderProcessCall {

        internal CfxDomDocumentGetCompleteUrlRenderProcessCall()
            : base(RemoteCallId.CfxDomDocumentGetCompleteUrlRenderProcessCall) {}

        internal IntPtr @this;
        internal string partialURL;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(partialURL);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out partialURL);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var partialURL_pinned = new PinnedString(partialURL);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_domdocument_get_complete_url(@this, partialURL_pinned.Obj.PinnedPtr, partialURL_pinned.Length));
            partialURL_pinned.Obj.Free();
        }
    }

}
