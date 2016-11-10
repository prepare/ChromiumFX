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

    internal class CfxDomNodeGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetTypeRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_type(@this);
        }
    }

    internal class CfxDomNodeIsTextRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsTextRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsTextRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_is_text(@this);
        }
    }

    internal class CfxDomNodeIsElementRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsElementRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsElementRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_is_element(@this);
        }
    }

    internal class CfxDomNodeIsEditableRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsEditableRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsEditableRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_is_editable(@this);
        }
    }

    internal class CfxDomNodeIsFormControlElementRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsFormControlElementRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsFormControlElementRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_is_form_control_element(@this);
        }
    }

    internal class CfxDomNodeGetFormControlElementTypeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetFormControlElementTypeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetFormControlElementTypeRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_form_control_element_type(@this));
        }
    }

    internal class CfxDomNodeIsSameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsSameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsSameRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_is_same(@this, that);
        }
    }

    internal class CfxDomNodeGetNameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetNameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_name(@this));
        }
    }

    internal class CfxDomNodeGetValueRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetValueRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetValueRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_value(@this));
        }
    }

    internal class CfxDomNodeSetValueRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeSetValueRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeSetValueRenderProcessCall) {}

        internal IntPtr @this;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var value_pinned = new PinnedString(value);
            __retval = 0 != CfxApi.DomNode.cfx_domnode_set_value(@this, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxDomNodeGetAsMarkupRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetAsMarkupRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetAsMarkupRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_as_markup(@this));
        }
    }

    internal class CfxDomNodeGetDocumentRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetDocumentRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetDocumentRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_document(@this);
        }
    }

    internal class CfxDomNodeGetParentRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetParentRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetParentRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_parent(@this);
        }
    }

    internal class CfxDomNodeGetPreviousSiblingRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetPreviousSiblingRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetPreviousSiblingRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_previous_sibling(@this);
        }
    }

    internal class CfxDomNodeGetNextSiblingRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetNextSiblingRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetNextSiblingRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_next_sibling(@this);
        }
    }

    internal class CfxDomNodeHasChildrenRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasChildrenRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasChildrenRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_has_children(@this);
        }
    }

    internal class CfxDomNodeGetFirstChildRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetFirstChildRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetFirstChildRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_first_child(@this);
        }
    }

    internal class CfxDomNodeGetLastChildRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetLastChildRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetLastChildRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_last_child(@this);
        }
    }

    internal class CfxDomNodeGetElementTagNameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementTagNameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementTagNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_element_tag_name(@this));
        }
    }

    internal class CfxDomNodeHasElementAttributesRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasElementAttributesRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasElementAttributesRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DomNode.cfx_domnode_has_element_attributes(@this);
        }
    }

    internal class CfxDomNodeHasElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasElementAttributeRenderProcessCall) {}

        internal IntPtr @this;
        internal string attrName;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(attrName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out attrName);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var attrName_pinned = new PinnedString(attrName);
            __retval = 0 != CfxApi.DomNode.cfx_domnode_has_element_attribute(@this, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length);
            attrName_pinned.Obj.Free();
        }
    }

    internal class CfxDomNodeGetElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementAttributeRenderProcessCall) {}

        internal IntPtr @this;
        internal string attrName;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(attrName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out attrName);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var attrName_pinned = new PinnedString(attrName);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_element_attribute(@this, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length));
            attrName_pinned.Obj.Free();
        }
    }

    internal class CfxDomNodeGetElementAttributesRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementAttributesRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementAttributesRenderProcessCall) {}

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
            var list = StringFunctions.AllocCfxStringMap();
            CfxApi.DomNode.cfx_domnode_get_element_attributes(@this, list);
            StringFunctions.CfxStringMapCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringMap(list);
        }
    }

    internal class CfxDomNodeSetElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeSetElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeSetElementAttributeRenderProcessCall) {}

        internal IntPtr @this;
        internal string attrName;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(attrName);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out attrName);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var attrName_pinned = new PinnedString(attrName);
            var value_pinned = new PinnedString(value);
            __retval = 0 != CfxApi.DomNode.cfx_domnode_set_element_attribute(@this, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            attrName_pinned.Obj.Free();
            value_pinned.Obj.Free();
        }
    }

    internal class CfxDomNodeGetElementInnerTextRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementInnerTextRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementInnerTextRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DomNode.cfx_domnode_get_element_inner_text(@this));
        }
    }

    internal class CfxDomNodeGetElementBoundsRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementBoundsRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementBoundsRenderProcessCall) {}

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
            __retval = CfxApi.DomNode.cfx_domnode_get_element_bounds(@this);
        }
    }

}
