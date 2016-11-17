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

    internal class CfxDomDocumentGetTypeRemoteCall : RemoteCall {

        internal CfxDomDocumentGetTypeRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetTypeRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_type(@this);
        }
    }

    internal class CfxDomDocumentGetDocumentRemoteCall : RemoteCall {

        internal CfxDomDocumentGetDocumentRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetDocumentRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_document(@this);
        }
    }

    internal class CfxDomDocumentGetBodyRemoteCall : RemoteCall {

        internal CfxDomDocumentGetBodyRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetBodyRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_body(@this);
        }
    }

    internal class CfxDomDocumentGetHeadRemoteCall : RemoteCall {

        internal CfxDomDocumentGetHeadRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetHeadRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_head(@this);
        }
    }

    internal class CfxDomDocumentGetTitleRemoteCall : RemoteCall {

        internal CfxDomDocumentGetTitleRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetTitleRemoteCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomDocument.cfx_domdocument_get_title(@this));
        }
    }

    internal class CfxDomDocumentGetElementByIdRemoteCall : RemoteCall {

        internal CfxDomDocumentGetElementByIdRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetElementByIdRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_element_by_id(@this, id_pinned.Obj.PinnedPtr, id_pinned.Length);
            id_pinned.Obj.Free();
        }
    }

    internal class CfxDomDocumentGetFocusedNodeRemoteCall : RemoteCall {

        internal CfxDomDocumentGetFocusedNodeRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetFocusedNodeRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_focused_node(@this);
        }
    }

    internal class CfxDomDocumentHasSelectionRemoteCall : RemoteCall {

        internal CfxDomDocumentHasSelectionRemoteCall()
            : base(RemoteCallId.CfxDomDocumentHasSelectionRemoteCall) {}

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
            __retval = 0 != CfxApi.DomDocument.cfx_domdocument_has_selection(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionStartOffsetRemoteCall : RemoteCall {

        internal CfxDomDocumentGetSelectionStartOffsetRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionStartOffsetRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_selection_start_offset(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionEndOffsetRemoteCall : RemoteCall {

        internal CfxDomDocumentGetSelectionEndOffsetRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionEndOffsetRemoteCall) {}

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
            __retval = CfxApi.DomDocument.cfx_domdocument_get_selection_end_offset(@this);
        }
    }

    internal class CfxDomDocumentGetSelectionAsMarkupRemoteCall : RemoteCall {

        internal CfxDomDocumentGetSelectionAsMarkupRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionAsMarkupRemoteCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomDocument.cfx_domdocument_get_selection_as_markup(@this));
        }
    }

    internal class CfxDomDocumentGetSelectionAsTextRemoteCall : RemoteCall {

        internal CfxDomDocumentGetSelectionAsTextRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetSelectionAsTextRemoteCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomDocument.cfx_domdocument_get_selection_as_text(@this));
        }
    }

    internal class CfxDomDocumentGetBaseUrlRemoteCall : RemoteCall {

        internal CfxDomDocumentGetBaseUrlRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetBaseUrlRemoteCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomDocument.cfx_domdocument_get_base_url(@this));
        }
    }

    internal class CfxDomDocumentGetCompleteUrlRemoteCall : RemoteCall {

        internal CfxDomDocumentGetCompleteUrlRemoteCall()
            : base(RemoteCallId.CfxDomDocumentGetCompleteUrlRemoteCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomDocument.cfx_domdocument_get_complete_url(@this, partialURL_pinned.Obj.PinnedPtr, partialURL_pinned.Length));
            partialURL_pinned.Obj.Free();
        }
    }

}
