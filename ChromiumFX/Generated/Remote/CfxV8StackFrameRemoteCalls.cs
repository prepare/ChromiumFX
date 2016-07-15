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

    internal class CfxV8StackFrameIsValidRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameIsValidRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.V8StackFrame.cfx_v8stack_frame_is_valid(@this);
        }
    }

    internal class CfxV8StackFrameGetScriptNameRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameGetScriptNameRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameGetScriptNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.V8StackFrame.cfx_v8stack_frame_get_script_name(@this));
        }
    }

    internal class CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.V8StackFrame.cfx_v8stack_frame_get_script_name_or_source_url(@this));
        }
    }

    internal class CfxV8StackFrameGetFunctionNameRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameGetFunctionNameRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameGetFunctionNameRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.V8StackFrame.cfx_v8stack_frame_get_function_name(@this));
        }
    }

    internal class CfxV8StackFrameGetLineNumberRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameGetLineNumberRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameGetLineNumberRenderProcessCall) {}

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
            __retval = CfxApi.V8StackFrame.cfx_v8stack_frame_get_line_number(@this);
        }
    }

    internal class CfxV8StackFrameGetColumnRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameGetColumnRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameGetColumnRenderProcessCall) {}

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
            __retval = CfxApi.V8StackFrame.cfx_v8stack_frame_get_column(@this);
        }
    }

    internal class CfxV8StackFrameIsEvalRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameIsEvalRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameIsEvalRenderProcessCall) {}

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
            __retval = 0 != CfxApi.V8StackFrame.cfx_v8stack_frame_is_eval(@this);
        }
    }

    internal class CfxV8StackFrameIsConstructorRenderProcessCall : RenderProcessCall {

        internal CfxV8StackFrameIsConstructorRenderProcessCall()
            : base(RemoteCallId.CfxV8StackFrameIsConstructorRenderProcessCall) {}

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
            __retval = 0 != CfxApi.V8StackFrame.cfx_v8stack_frame_is_constructor(@this);
        }
    }

}
