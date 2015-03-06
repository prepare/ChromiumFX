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

    internal class CfxDictionaryValueCreateRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueCreateRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueCreateRenderProcessCall) {}

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
            __retval = RemoteProxy.Wrap(CfxDictionaryValue.Create());
        }
    }

    internal class CfxDictionaryValueIsValidRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsValidRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsValidRenderProcessCall) {}

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
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.IsValid;
        }
    }

    internal class CfxDictionaryValueIsOwnedRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsOwnedRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsOwnedRenderProcessCall) {}

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
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.IsOwned;
        }
    }

    internal class CfxDictionaryValueIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsReadOnlyRenderProcessCall) {}

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
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.IsReadOnly;
        }
    }

    internal class CfxDictionaryValueCopyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueCopyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueCopyRenderProcessCall) {}

        internal ulong self;
        internal bool excludeEmptyChildren;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(excludeEmptyChildren);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out excludeEmptyChildren);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.Copy(excludeEmptyChildren));
        }
    }

    internal class CfxDictionaryValueGetSizeRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetSizeRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetSizeRenderProcessCall) {}

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
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.Size;
        }
    }

    internal class CfxDictionaryValueClearRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueClearRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueClearRenderProcessCall) {}

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
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.Clear();
        }
    }

    internal class CfxDictionaryValueHasKeyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueHasKeyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueHasKeyRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.HasKey(key);
        }
    }

    internal class CfxDictionaryValueGetKeysRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetKeysRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetKeysRenderProcessCall) {}

        internal ulong self;
        internal System.Collections.Generic.List<string> keys;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(keys);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out keys);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.GetKeys(keys);
        }
    }

    internal class CfxDictionaryValueRemoveRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueRemoveRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueRemoveRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.Remove(key);
        }
    }

    internal class CfxDictionaryValueGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetTypeRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = (int)self_local.GetType(key);
        }
    }

    internal class CfxDictionaryValueGetBoolRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetBoolRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetBoolRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.GetBool(key);
        }
    }

    internal class CfxDictionaryValueGetIntRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetIntRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetIntRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.GetInt(key);
        }
    }

    internal class CfxDictionaryValueGetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetDoubleRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal double __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.GetDouble(key);
        }
    }

    internal class CfxDictionaryValueGetStringRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetStringRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetStringRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal String __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.GetString(key);
        }
    }

    internal class CfxDictionaryValueGetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetBinaryRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.GetBinary(key));
        }
    }

    internal class CfxDictionaryValueGetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetDictionaryRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.GetDictionary(key));
        }
    }

    internal class CfxDictionaryValueGetListRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetListRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetListRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = RemoteProxy.Wrap(self_local.GetList(key));
        }
    }

    internal class CfxDictionaryValueSetNullRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetNullRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetNullRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetNull(key);
        }
    }

    internal class CfxDictionaryValueSetBoolRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetBoolRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetBoolRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal int value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetBool(key, value);
        }
    }

    internal class CfxDictionaryValueSetIntRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetIntRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetIntRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal int value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetInt(key, value);
        }
    }

    internal class CfxDictionaryValueSetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetDoubleRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal double value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetDouble(key, value);
        }
    }

    internal class CfxDictionaryValueSetStringRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetStringRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetStringRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetString(key, value);
        }
    }

    internal class CfxDictionaryValueSetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetBinaryRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetBinary(key, (CfxBinaryValue)RemoteProxy.Unwrap(value));
        }
    }

    internal class CfxDictionaryValueSetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetDictionaryRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetDictionary(key, (CfxDictionaryValue)RemoteProxy.Unwrap(value));
        }
    }

    internal class CfxDictionaryValueSetListRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetListRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetListRenderProcessCall) {}

        internal ulong self;
        internal string key;
        internal ulong value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(self);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out self);
            h.Read(out key);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self_local = (CfxDictionaryValue)RemoteProxy.Unwrap(self);
            __retval = self_local.SetList(key, (CfxListValue)RemoteProxy.Unwrap(value));
        }
    }

}
