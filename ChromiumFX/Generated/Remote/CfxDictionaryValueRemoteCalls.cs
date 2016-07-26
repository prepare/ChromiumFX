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

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_create();
        }
    }

    internal class CfxDictionaryValueIsValidRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsValidRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_is_valid(@this);
        }
    }

    internal class CfxDictionaryValueIsOwnedRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsOwnedRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsOwnedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_is_owned(@this);
        }
    }

    internal class CfxDictionaryValueIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsReadOnlyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_is_read_only(@this);
        }
    }

    internal class CfxDictionaryValueIsSameRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsSameRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsSameRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_is_same(@this, that);
        }
    }

    internal class CfxDictionaryValueIsEqualRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueIsEqualRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueIsEqualRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_is_equal(@this, that);
        }
    }

    internal class CfxDictionaryValueCopyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueCopyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueCopyRenderProcessCall) {}

        internal IntPtr @this;
        internal bool excludeEmptyChildren;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(excludeEmptyChildren);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out excludeEmptyChildren);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_copy(@this, excludeEmptyChildren ? 1 : 0);
        }
    }

    internal class CfxDictionaryValueGetSizeRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetSizeRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetSizeRenderProcessCall) {}

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
            __retval = (ulong)CfxApi.DictionaryValue.cfx_dictionary_value_get_size(@this);
        }
    }

    internal class CfxDictionaryValueClearRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueClearRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueClearRenderProcessCall) {}

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
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_clear(@this);
        }
    }

    internal class CfxDictionaryValueHasKeyRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueHasKeyRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueHasKeyRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_has_key(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetKeysRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetKeysRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetKeysRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string> keys;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(keys);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out keys);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(keys);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out keys);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            PinnedString[] keys_handles;
            var keys_unwrapped = StringFunctions.UnwrapCfxStringList(keys, out keys_handles);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_get_keys(@this, keys_unwrapped);
            StringFunctions.FreePinnedStrings(keys_handles);
            StringFunctions.CfxStringListCopyToManaged(keys_unwrapped, keys);
            CfxApi.Runtime.cfx_string_list_free(keys_unwrapped);
        }
    }

    internal class CfxDictionaryValueRemoveRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueRemoveRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueRemoveRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_remove(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetTypeRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_type(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetValueRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetValueRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetValueRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_value(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetBoolRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetBoolRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetBoolRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_get_bool(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetIntRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetIntRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetIntRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_int(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetDoubleRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal double __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_double(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetStringRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetStringRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetStringRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.DictionaryValue.cfx_dictionary_value_get_string(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length));
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetBinaryRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_binary(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetDictionaryRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_dictionary(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueGetListRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueGetListRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueGetListRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = CfxApi.DictionaryValue.cfx_dictionary_value_get_list(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetValueRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetValueRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetValueRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_value(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetNullRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetNullRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetNullRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_null(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetBoolRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetBoolRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetBoolRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal bool value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_bool(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value ? 1 : 0);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetIntRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetIntRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetIntRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal int value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_int(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetDoubleRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal double value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_double(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetStringRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetStringRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetStringRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            var value_pinned = new PinnedString(value);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_string(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            key_pinned.Obj.Free();
            value_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetBinaryRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_binary(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetDictionaryRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_dictionary(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxDictionaryValueSetListRenderProcessCall : RenderProcessCall {

        internal CfxDictionaryValueSetListRenderProcessCall()
            : base(RemoteCallId.CfxDictionaryValueSetListRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
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
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.DictionaryValue.cfx_dictionary_value_set_list(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value);
            key_pinned.Obj.Free();
        }
    }

}
