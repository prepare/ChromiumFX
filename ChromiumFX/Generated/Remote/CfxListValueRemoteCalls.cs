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

    internal class CfxListValueCreateRenderProcessCall : RenderProcessCall {

        internal CfxListValueCreateRenderProcessCall()
            : base(RemoteCallId.CfxListValueCreateRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_create();
        }
    }

    internal class CfxListValueIsValidRenderProcessCall : RenderProcessCall {

        internal CfxListValueIsValidRenderProcessCall()
            : base(RemoteCallId.CfxListValueIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_is_valid(@this);
        }
    }

    internal class CfxListValueIsOwnedRenderProcessCall : RenderProcessCall {

        internal CfxListValueIsOwnedRenderProcessCall()
            : base(RemoteCallId.CfxListValueIsOwnedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_is_owned(@this);
        }
    }

    internal class CfxListValueIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxListValueIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxListValueIsReadOnlyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_is_read_only(@this);
        }
    }

    internal class CfxListValueIsSameRenderProcessCall : RenderProcessCall {

        internal CfxListValueIsSameRenderProcessCall()
            : base(RemoteCallId.CfxListValueIsSameRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_is_same(@this, that);
        }
    }

    internal class CfxListValueIsEqualRenderProcessCall : RenderProcessCall {

        internal CfxListValueIsEqualRenderProcessCall()
            : base(RemoteCallId.CfxListValueIsEqualRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_is_equal(@this, that);
        }
    }

    internal class CfxListValueCopyRenderProcessCall : RenderProcessCall {

        internal CfxListValueCopyRenderProcessCall()
            : base(RemoteCallId.CfxListValueCopyRenderProcessCall) {}

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
            __retval = CfxApi.cfx_list_value_copy(@this);
        }
    }

    internal class CfxListValueSetSizeRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetSizeRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetSizeRenderProcessCall) {}

        internal IntPtr @this;
        internal int size;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(size);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out size);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_size(@this, size);
        }
    }

    internal class CfxListValueGetSizeRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetSizeRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetSizeRenderProcessCall) {}

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
            __retval = CfxApi.cfx_list_value_get_size(@this);
        }
    }

    internal class CfxListValueClearRenderProcessCall : RenderProcessCall {

        internal CfxListValueClearRenderProcessCall()
            : base(RemoteCallId.CfxListValueClearRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_list_value_clear(@this);
        }
    }

    internal class CfxListValueRemoveRenderProcessCall : RenderProcessCall {

        internal CfxListValueRemoveRenderProcessCall()
            : base(RemoteCallId.CfxListValueRemoveRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_remove(@this, index);
        }
    }

    internal class CfxListValueGetTypeRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetTypeRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetTypeRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_type(@this, index);
        }
    }

    internal class CfxListValueGetValueRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetValueRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetValueRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_value(@this, index);
        }
    }

    internal class CfxListValueGetBoolRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetBoolRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetBoolRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_get_bool(@this, index);
        }
    }

    internal class CfxListValueGetIntRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetIntRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetIntRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_int(@this, index);
        }
    }

    internal class CfxListValueGetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetDoubleRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal double __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_double(@this, index);
        }
    }

    internal class CfxListValueGetStringRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetStringRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetStringRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_list_value_get_string(@this, index));
        }
    }

    internal class CfxListValueGetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetBinaryRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_binary(@this, index);
        }
    }

    internal class CfxListValueGetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetDictionaryRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_dictionary(@this, index);
        }
    }

    internal class CfxListValueGetListRenderProcessCall : RenderProcessCall {

        internal CfxListValueGetListRenderProcessCall()
            : base(RemoteCallId.CfxListValueGetListRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_list_value_get_list(@this, index);
        }
    }

    internal class CfxListValueSetValueRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetValueRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetValueRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_value(@this, index, value);
        }
    }

    internal class CfxListValueSetNullRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetNullRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetNullRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_null(@this, index);
        }
    }

    internal class CfxListValueSetBoolRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetBoolRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetBoolRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal bool value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_bool(@this, index, value ? 1 : 0);
        }
    }

    internal class CfxListValueSetIntRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetIntRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetIntRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal int value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_int(@this, index, value);
        }
    }

    internal class CfxListValueSetDoubleRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetDoubleRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetDoubleRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal double value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_double(@this, index, value);
        }
    }

    internal class CfxListValueSetStringRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetStringRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetStringRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal string value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
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
            __retval = 0 != CfxApi.cfx_list_value_set_string(@this, index, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxListValueSetBinaryRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetBinaryRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetBinaryRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_binary(@this, index, value);
        }
    }

    internal class CfxListValueSetDictionaryRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetDictionaryRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetDictionaryRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_dictionary(@this, index, value);
        }
    }

    internal class CfxListValueSetListRenderProcessCall : RenderProcessCall {

        internal CfxListValueSetListRenderProcessCall()
            : base(RemoteCallId.CfxListValueSetListRenderProcessCall) {}

        internal IntPtr @this;
        internal int index;
        internal IntPtr value;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(index);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out index);
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_list_value_set_list(@this, index, value);
        }
    }

}
