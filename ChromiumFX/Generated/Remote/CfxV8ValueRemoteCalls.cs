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

    internal class CfxV8ValueCreateUndefinedRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateUndefinedRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateUndefinedRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_undefined();
        }
    }

    internal class CfxV8ValueCreateNullRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateNullRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateNullRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_null();
        }
    }

    internal class CfxV8ValueCreateBoolRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateBoolRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateBoolRenderProcessCall) {}

        internal bool value;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_bool(value ? 1 : 0);
        }
    }

    internal class CfxV8ValueCreateIntRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateIntRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateIntRenderProcessCall) {}

        internal int value;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_int(value);
        }
    }

    internal class CfxV8ValueCreateUintRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateUintRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateUintRenderProcessCall) {}

        internal uint value;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_uint(value);
        }
    }

    internal class CfxV8ValueCreateDoubleRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateDoubleRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateDoubleRenderProcessCall) {}

        internal double value;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out value);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_double(value);
        }
    }

    internal class CfxV8ValueCreateDateRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateDateRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateDateRenderProcessCall) {}

        internal IntPtr date;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(date);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out date);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_date(date);
        }
    }

    internal class CfxV8ValueCreateStringRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateStringRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateStringRenderProcessCall) {}

        internal string value;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
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
            __retval = CfxApi.cfx_v8value_create_string(value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueCreateObjectRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateObjectRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateObjectRenderProcessCall) {}

        internal IntPtr accessor;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(accessor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out accessor);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_object(accessor);
        }
    }

    internal class CfxV8ValueCreateArrayRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateArrayRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateArrayRenderProcessCall) {}

        internal int length;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(length);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out length);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_create_array(length);
        }
    }

    internal class CfxV8ValueCreateFunctionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueCreateFunctionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueCreateFunctionRenderProcessCall) {}

        internal string name;
        internal IntPtr handler;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(name);
            h.Write(handler);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out name);
            h.Read(out handler);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = CfxApi.cfx_v8value_create_function(name_pinned.Obj.PinnedPtr, name_pinned.Length, handler);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueIsValidRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsValidRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_valid(@this);
        }
    }

    internal class CfxV8ValueIsUndefinedRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsUndefinedRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsUndefinedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_undefined(@this);
        }
    }

    internal class CfxV8ValueIsNullRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsNullRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsNullRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_null(@this);
        }
    }

    internal class CfxV8ValueIsBoolRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsBoolRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsBoolRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_bool(@this);
        }
    }

    internal class CfxV8ValueIsIntRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsIntRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsIntRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_int(@this);
        }
    }

    internal class CfxV8ValueIsUintRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsUintRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsUintRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_uint(@this);
        }
    }

    internal class CfxV8ValueIsDoubleRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsDoubleRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsDoubleRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_double(@this);
        }
    }

    internal class CfxV8ValueIsDateRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsDateRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsDateRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_date(@this);
        }
    }

    internal class CfxV8ValueIsStringRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsStringRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsStringRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_string(@this);
        }
    }

    internal class CfxV8ValueIsObjectRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsObjectRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsObjectRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_object(@this);
        }
    }

    internal class CfxV8ValueIsArrayRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsArrayRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsArrayRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_array(@this);
        }
    }

    internal class CfxV8ValueIsFunctionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsFunctionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsFunctionRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_function(@this);
        }
    }

    internal class CfxV8ValueIsSameRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsSameRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsSameRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_same(@this, that);
        }
    }

    internal class CfxV8ValueGetBoolValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetBoolValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetBoolValueRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_get_bool_value(@this);
        }
    }

    internal class CfxV8ValueGetIntValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetIntValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetIntValueRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_int_value(@this);
        }
    }

    internal class CfxV8ValueGetUintValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetUintValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetUintValueRenderProcessCall) {}

        internal IntPtr @this;
        internal uint __retval;

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
            __retval = CfxApi.cfx_v8value_get_uint_value(@this);
        }
    }

    internal class CfxV8ValueGetDoubleValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetDoubleValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetDoubleValueRenderProcessCall) {}

        internal IntPtr @this;
        internal double __retval;

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
            __retval = CfxApi.cfx_v8value_get_double_value(@this);
        }
    }

    internal class CfxV8ValueGetDateValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetDateValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetDateValueRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_date_value(@this);
        }
    }

    internal class CfxV8ValueGetStringValueRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetStringValueRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetStringValueRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_v8value_get_string_value(@this));
        }
    }

    internal class CfxV8ValueIsUserCreatedRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueIsUserCreatedRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueIsUserCreatedRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_is_user_created(@this);
        }
    }

    internal class CfxV8ValueHasExceptionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueHasExceptionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueHasExceptionRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_has_exception(@this);
        }
    }

    internal class CfxV8ValueGetExceptionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetExceptionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetExceptionRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_exception(@this);
        }
    }

    internal class CfxV8ValueClearExceptionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueClearExceptionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueClearExceptionRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_clear_exception(@this);
        }
    }

    internal class CfxV8ValueWillRethrowExceptionsRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueWillRethrowExceptionsRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueWillRethrowExceptionsRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_will_rethrow_exceptions(@this);
        }
    }

    internal class CfxV8ValueSetRethrowExceptionsRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueSetRethrowExceptionsRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueSetRethrowExceptionsRenderProcessCall) {}

        internal IntPtr @this;
        internal bool rethrow;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(rethrow);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out rethrow);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_v8value_set_rethrow_exceptions(@this, rethrow ? 1 : 0);
        }
    }

    internal class CfxV8ValueHasValueByKeyRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueHasValueByKeyRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueHasValueByKeyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_has_value_bykey(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueHasValueByIndexRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueHasValueByIndexRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueHasValueByIndexRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_has_value_byindex(@this, index);
        }
    }

    internal class CfxV8ValueDeleteValueByKeyRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueDeleteValueByKeyRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueDeleteValueByKeyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_delete_value_bykey(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueDeleteValueByIndexRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueDeleteValueByIndexRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueDeleteValueByIndexRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_delete_value_byindex(@this, index);
        }
    }

    internal class CfxV8ValueGetValueByKeyRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetValueByKeyRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetValueByKeyRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_value_bykey(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueGetValueByIndexRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetValueByIndexRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetValueByIndexRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_value_byindex(@this, index);
        }
    }

    internal class CfxV8ValueSetValueByKeyRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueSetValueByKeyRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueSetValueByKeyRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal IntPtr value;
        internal int attribute;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(value);
            h.Write(attribute);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
            h.Read(out value);
            h.Read(out attribute);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.cfx_v8value_set_value_bykey(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, value, (int)attribute);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueSetValueByIndexRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueSetValueByIndexRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueSetValueByIndexRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_set_value_byindex(@this, index, value);
        }
    }

    internal class CfxV8ValueSetValueByAccessorRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueSetValueByAccessorRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueSetValueByAccessorRenderProcessCall) {}

        internal IntPtr @this;
        internal string key;
        internal int settings;
        internal int attribute;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(key);
            h.Write(settings);
            h.Write(attribute);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out key);
            h.Read(out settings);
            h.Read(out attribute);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var key_pinned = new PinnedString(key);
            __retval = 0 != CfxApi.cfx_v8value_set_value_byaccessor(@this, key_pinned.Obj.PinnedPtr, key_pinned.Length, (int)settings, (int)attribute);
            key_pinned.Obj.Free();
        }
    }

    internal class CfxV8ValueGetKeysRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetKeysRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetKeysRenderProcessCall) {}

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
            __retval = 0 != CfxApi.cfx_v8value_get_keys(@this, keys_unwrapped);
            StringFunctions.FreePinnedStrings(keys_handles);
            StringFunctions.CfxStringListCopyToManaged(keys_unwrapped, keys);
            CfxApi.cfx_string_list_free(keys_unwrapped);
        }
    }

    internal class CfxV8ValueSetUserDataRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueSetUserDataRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueSetUserDataRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr userData;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(userData);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out userData);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.cfx_v8value_set_user_data(@this, userData);
        }
    }

    internal class CfxV8ValueGetUserDataRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetUserDataRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetUserDataRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_user_data(@this);
        }
    }

    internal class CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_externally_allocated_memory(@this);
        }
    }

    internal class CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall) {}

        internal IntPtr @this;
        internal int changeInBytes;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(changeInBytes);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out changeInBytes);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.cfx_v8value_adjust_externally_allocated_memory(@this, changeInBytes);
        }
    }

    internal class CfxV8ValueGetArrayLengthRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetArrayLengthRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetArrayLengthRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_array_length(@this);
        }
    }

    internal class CfxV8ValueGetFunctionNameRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetFunctionNameRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetFunctionNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.cfx_v8value_get_function_name(@this));
        }
    }

    internal class CfxV8ValueGetFunctionHandlerRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueGetFunctionHandlerRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueGetFunctionHandlerRenderProcessCall) {}

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
            __retval = CfxApi.cfx_v8value_get_function_handler(@this);
        }
    }

    internal class CfxV8ValueExecuteFunctionRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueExecuteFunctionRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueExecuteFunctionRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr @object;
        internal IntPtr[] arguments;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(@object);
            h.Write(arguments);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out @object);
            h.Read(out arguments);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            PinnedObject arguments_pinned = new PinnedObject(arguments);
            var arguments_length = arguments == null ? 0 : arguments.Length;
            __retval = CfxApi.cfx_v8value_execute_function(@this, @object, arguments_length, arguments_pinned.PinnedPtr);
            arguments_pinned.Free();
        }
    }

    internal class CfxV8ValueExecuteFunctionWithContextRenderProcessCall : RenderProcessCall {

        internal CfxV8ValueExecuteFunctionWithContextRenderProcessCall()
            : base(RemoteCallId.CfxV8ValueExecuteFunctionWithContextRenderProcessCall) {}

        internal IntPtr @this;
        internal IntPtr context;
        internal IntPtr @object;
        internal IntPtr[] arguments;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(context);
            h.Write(@object);
            h.Write(arguments);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out context);
            h.Read(out @object);
            h.Read(out arguments);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            PinnedObject arguments_pinned = new PinnedObject(arguments);
            var arguments_length = arguments == null ? 0 : arguments.Length;
            __retval = CfxApi.cfx_v8value_execute_function_with_context(@this, context, @object, arguments_length, arguments_pinned.PinnedPtr);
            arguments_pinned.Free();
        }
    }

}
