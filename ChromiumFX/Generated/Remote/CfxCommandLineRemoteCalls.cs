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

    internal class CfxCommandLineCreateRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineCreateRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineCreateRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.CommandLine.cfx_command_line_create();
        }
    }

    internal class CfxCommandLineGetGlobalRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetGlobalRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetGlobalRenderProcessCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.CommandLine.cfx_command_line_get_global();
        }
    }

    internal class CfxCommandLineIsValidRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineIsValidRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineIsValidRenderProcessCall) {}

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
            __retval = 0 != CfxApi.CommandLine.cfx_command_line_is_valid(@this);
        }
    }

    internal class CfxCommandLineIsReadOnlyRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineIsReadOnlyRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineIsReadOnlyRenderProcessCall) {}

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
            __retval = 0 != CfxApi.CommandLine.cfx_command_line_is_read_only(@this);
        }
    }

    internal class CfxCommandLineCopyRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineCopyRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineCopyRenderProcessCall) {}

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
            __retval = CfxApi.CommandLine.cfx_command_line_copy(@this);
        }
    }

    internal class CfxCommandLineInitFromArgvRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineInitFromArgvRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineInitFromArgvRenderProcessCall) {}

        internal IntPtr @this;
        internal int argc;
        internal IntPtr argv;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(argc);
            h.Write(argv);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out argc);
            h.Read(out argv);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.CommandLine.cfx_command_line_init_from_argv(@this, argc, argv);
        }
    }

    internal class CfxCommandLineInitFromStringRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineInitFromStringRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineInitFromStringRenderProcessCall) {}

        internal IntPtr @this;
        internal string commandLine;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(commandLine);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out commandLine);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var commandLine_pinned = new PinnedString(commandLine);
            CfxApi.CommandLine.cfx_command_line_init_from_string(@this, commandLine_pinned.Obj.PinnedPtr, commandLine_pinned.Length);
            commandLine_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineResetRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineResetRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineResetRenderProcessCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.CommandLine.cfx_command_line_reset(@this);
        }
    }

    internal class CfxCommandLineGetArgvRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetArgvRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetArgvRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string> __retval;

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
            __retval = new System.Collections.Generic.List<string>();
            var list = StringFunctions.AllocCfxStringList();
            CfxApi.CommandLine.cfx_command_line_get_argv(@this, list);
            StringFunctions.CfxStringListCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringList(list);
        }
    }

    internal class CfxCommandLineGetCommandLineStringRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetCommandLineStringRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetCommandLineStringRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.CommandLine.cfx_command_line_get_command_line_string(@this));
        }
    }

    internal class CfxCommandLineGetProgramRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetProgramRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetProgramRenderProcessCall) {}

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
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.CommandLine.cfx_command_line_get_program(@this));
        }
    }

    internal class CfxCommandLineSetProgramRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineSetProgramRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineSetProgramRenderProcessCall) {}

        internal IntPtr @this;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var value_pinned = new PinnedString(value);
            CfxApi.CommandLine.cfx_command_line_set_program(@this, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineHasSwitchesRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineHasSwitchesRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineHasSwitchesRenderProcessCall) {}

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
            __retval = 0 != CfxApi.CommandLine.cfx_command_line_has_switches(@this);
        }
    }

    internal class CfxCommandLineHasSwitchRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineHasSwitchRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineHasSwitchRenderProcessCall) {}

        internal IntPtr @this;
        internal string name;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = 0 != CfxApi.CommandLine.cfx_command_line_has_switch(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineGetSwitchValueRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetSwitchValueRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetSwitchValueRenderProcessCall) {}

        internal IntPtr @this;
        internal string name;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.CommandLine.cfx_command_line_get_switch_value(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length));
            name_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineGetSwitchesRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetSwitchesRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetSwitchesRenderProcessCall) {}

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
            CfxApi.CommandLine.cfx_command_line_get_switches(@this, list);
            StringFunctions.CfxStringMapCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringMap(list);
        }
    }

    internal class CfxCommandLineAppendSwitchRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineAppendSwitchRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineAppendSwitchRenderProcessCall) {}

        internal IntPtr @this;
        internal string name;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            CfxApi.CommandLine.cfx_command_line_append_switch(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineAppendSwitchWithValueRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineAppendSwitchWithValueRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineAppendSwitchWithValueRenderProcessCall) {}

        internal IntPtr @this;
        internal string name;
        internal string value;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
            h.Write(value);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
            h.Read(out value);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            var value_pinned = new PinnedString(value);
            CfxApi.CommandLine.cfx_command_line_append_switch_with_value(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            name_pinned.Obj.Free();
            value_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLineHasArgumentsRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineHasArgumentsRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineHasArgumentsRenderProcessCall) {}

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
            __retval = 0 != CfxApi.CommandLine.cfx_command_line_has_arguments(@this);
        }
    }

    internal class CfxCommandLineGetArgumentsRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineGetArgumentsRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineGetArgumentsRenderProcessCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string> __retval;

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
            __retval = new System.Collections.Generic.List<string>();
            var list = StringFunctions.AllocCfxStringList();
            CfxApi.CommandLine.cfx_command_line_get_arguments(@this, list);
            StringFunctions.CfxStringListCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringList(list);
        }
    }

    internal class CfxCommandLineAppendArgumentRenderProcessCall : RenderProcessCall {

        internal CfxCommandLineAppendArgumentRenderProcessCall()
            : base(RemoteCallId.CfxCommandLineAppendArgumentRenderProcessCall) {}

        internal IntPtr @this;
        internal string argument;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(argument);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out argument);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var argument_pinned = new PinnedString(argument);
            CfxApi.CommandLine.cfx_command_line_append_argument(@this, argument_pinned.Obj.PinnedPtr, argument_pinned.Length);
            argument_pinned.Obj.Free();
        }
    }

    internal class CfxCommandLinePrependWrapperRenderProcessCall : RenderProcessCall {

        internal CfxCommandLinePrependWrapperRenderProcessCall()
            : base(RemoteCallId.CfxCommandLinePrependWrapperRenderProcessCall) {}

        internal IntPtr @this;
        internal string wrapper;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(wrapper);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out wrapper);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var wrapper_pinned = new PinnedString(wrapper);
            CfxApi.CommandLine.cfx_command_line_prepend_wrapper(@this, wrapper_pinned.Obj.PinnedPtr, wrapper_pinned.Length);
            wrapper_pinned.Obj.Free();
        }
    }

}
