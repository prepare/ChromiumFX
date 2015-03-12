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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = (int)self_local.Type;
        }
    }

    internal class CfxDomNodeIsTextRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsTextRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsTextRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.IsText;
        }
    }

    internal class CfxDomNodeIsElementRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsElementRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsElementRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.IsElement;
        }
    }

    internal class CfxDomNodeIsEditableRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsEditableRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsEditableRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.IsEditable;
        }
    }

    internal class CfxDomNodeIsFormControlElementRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsFormControlElementRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsFormControlElementRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.IsFormControlElement;
        }
    }

    internal class CfxDomNodeGetFormControlElementTypeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetFormControlElementTypeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetFormControlElementTypeRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.FormControlElementType;
        }
    }

    internal class CfxDomNodeIsSameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeIsSameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeIsSameRenderProcessCall) {}

        internal ulong self;
        internal ulong that;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(that);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out that);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.IsSame((CfxDomNode)RemoteProxy.Unwrap(that));
        }
    }

    internal class CfxDomNodeGetNameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetNameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetNameRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.Name;
        }
    }

    internal class CfxDomNodeGetValueRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetValueRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetValueRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.Value;
        }
    }

    internal class CfxDomNodeSetValueRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeSetValueRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeSetValueRenderProcessCall) {}

        internal ulong self;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.SetValue(value);
        }
    }

    internal class CfxDomNodeGetAsMarkupRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetAsMarkupRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetAsMarkupRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.AsMarkup;
        }
    }

    internal class CfxDomNodeGetDocumentRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetDocumentRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetDocumentRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.Document);
        }
    }

    internal class CfxDomNodeGetParentRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetParentRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetParentRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.Parent);
        }
    }

    internal class CfxDomNodeGetPreviousSiblingRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetPreviousSiblingRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetPreviousSiblingRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.PreviousSibling);
        }
    }

    internal class CfxDomNodeGetNextSiblingRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetNextSiblingRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetNextSiblingRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.NextSibling);
        }
    }

    internal class CfxDomNodeHasChildrenRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasChildrenRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasChildrenRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.HasChildren;
        }
    }

    internal class CfxDomNodeGetFirstChildRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetFirstChildRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetFirstChildRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.FirstChild);
        }
    }

    internal class CfxDomNodeGetLastChildRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetLastChildRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetLastChildRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.LastChild);
        }
    }

    internal class CfxDomNodeGetElementTagNameRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementTagNameRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementTagNameRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.ElementTagName;
        }
    }

    internal class CfxDomNodeHasElementAttributesRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasElementAttributesRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasElementAttributesRenderProcessCall) {}

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.HasElementAttributes;
        }
    }

    internal class CfxDomNodeHasElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeHasElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeHasElementAttributeRenderProcessCall) {}

        internal ulong self;
        internal string attrName;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(attrName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out attrName);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.HasElementAttribute(attrName);
        }
    }

    internal class CfxDomNodeGetElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementAttributeRenderProcessCall) {}

        internal ulong self;
        internal string attrName;
        internal String __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(attrName);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out attrName);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.GetElementAttribute(attrName);
        }
    }

    internal class CfxDomNodeGetElementAttributesRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementAttributesRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementAttributesRenderProcessCall) {}

        internal ulong self;
        internal System.Collections.Generic.List<string[]> attrMap;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(attrMap);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out attrMap);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            self_local.GetElementAttributes(attrMap);
        }
    }

    internal class CfxDomNodeSetElementAttributeRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeSetElementAttributeRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeSetElementAttributeRenderProcessCall) {}

        internal ulong self;
        internal string attrName;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(attrName);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.SetElementAttribute(attrName, value);
        }
    }

    internal class CfxDomNodeGetElementInnerTextRenderProcessCall : RenderProcessCall {

        internal CfxDomNodeGetElementInnerTextRenderProcessCall()
            : base(RemoteCallId.CfxDomNodeGetElementInnerTextRenderProcessCall) {}

        internal ulong self;
        internal String __retval;

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
            var self_local = (CfxDomNode)RemoteProxy.Unwrap(self);
            __retval = self_local.ElementInnerText;
        }
    }

}
