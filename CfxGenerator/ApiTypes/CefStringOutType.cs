// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class CefStringOutType : CefStringPtrType {

    public override bool IsIn {
        get {
            return false;
        }
    }

    public override string NativeCallbackParameter(string var, bool isConst) {
        return string.Format("char16 **{0}_str, int *{0}_length, gc_handle_t *{0}_gc_handle", var);
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("&{0}_tmp_str, &{0}_tmp_length, &{0}_gc_handle", var);
    }

    public override string PInvokeCallParameter(string var) {
        return string.Format("out IntPtr {0}_str, out int {0}_length", var);
    }

    public override string PInvokeCallbackParameter(string var) {
        return string.Format("out IntPtr {0}_str, out int {0}_length, out IntPtr {0}_gc_handle", var);
    }

    public override string[] RemoteCallbackParameterList(string var) {
        return new string[] { "out string " + CSharp.Escape(var) };
    }

    public override string PublicCallParameter(string var) {
        return string.Format("out string {0}", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return "&" + var;
    }

    public override string PublicWrapExpression(string var) {
        throw new Exception();
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("out {0}_str, out {0}_length", var);
    }

    public override string PInvokeOutArgument(string var) {
        throw new Exception();
    }

    public override void EmitNativePreCallStatements(CodeBuilder b, string var) {
        b.AppendLine("cef_string_t {0} = {{ 0 }};", var);
    }

    public override void EmitNativePostCallStatements(CodeBuilder b, string var) {
        b.AppendLine("*{0}_str = {0}.str; *{0}_length = (int){0}.length;", var);
    }

    public override void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
        b.AppendLine("char16* {0}_tmp_str = 0; int {0}_tmp_length = 0; gc_handle_t {0}_gc_handle = 0;", var);
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        b.BeginIf("{0}_tmp_length > 0", var);
        b.AppendLine("cef_string_set({0}_tmp_str, {0}_tmp_length, {0}, 1);", var);
        b.AppendLine("cfx_gc_handle_switch(&{0}_gc_handle, GC_HANDLE_FREE);", var);
        b.EndBlock();
    }

    public override void EmitPublicPreCallStatements(CodeBuilder b, string var) {
        b.AppendLine("IntPtr {0}_str;", var);
        b.AppendLine("int {0}_length;", var);
    }

    public override void EmitPublicPostCallStatements(CodeBuilder b, string var) {
        b.BeginIf("{0}_length > 0", var);
        b.AppendLine("{0} = System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length);", var);
        b.AppendLine("// free the native string?", var);
        b.BeginElse();
        b.AppendLine("{0} = null;", var);
        b.EndBlock();
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitRemoteEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        throw new Exception();
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal string m_{0}_wrapped;", var);
    }

    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal string m_{0}_wrapped;", var);
    }

    public override void EmitPublicEventFieldInitializers(CodeBuilder b, string var) {
        throw new Exception();
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.BeginIf("e.m_{0}_wrapped != null && e.m_{0}_wrapped.Length > 0", var);
        b.AppendLine("var {0}_pinned = new PinnedString(e.m_{0}_wrapped);", var);
        b.AppendLine("{0}_str = {0}_pinned.Obj.PinnedPtr;", var);
        b.AppendLine("{0}_length = {0}_pinned.Length;", var);
        b.AppendLine("{0}_gc_handle = {0}_pinned.Obj.GCHandlePtr();", var);
        b.BeginElse();
        b.AppendLine("{0}_str = IntPtr.Zero;", var);
        b.AppendLine("{0}_length = 0;", var);
        b.AppendLine("{0}_gc_handle = IntPtr.Zero;", var);
        b.EndBlock();
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = e.m_{1}_wrapped;", CSharp.Escape(var), var);
    }

    public override void EmitPostRemoteCallbackStatements(CodeBuilder b, string var) {
        b.BeginIf("call.{0} != null && call.{0}.Length > 0", CSharp.Escape(var));
        b.AppendLine("var {0}_pinned = new PinnedString(call.{1});", var, CSharp.Escape(var));
        b.AppendLine("{0}_str = {0}_pinned.Obj.PinnedPtr;", var);
        b.AppendLine("{0}_length = {0}_pinned.Length;", var);
        b.AppendLine("{0}_gc_handle = {0}_pinned.Obj.GCHandlePtr();", var);
        b.BeginElse();
        b.AppendLine("{0}_str = IntPtr.Zero;", var);
        b.AppendLine("{0}_length = 0;", var);
        b.AppendLine("{0}_gc_handle = IntPtr.Zero;", var);
        b.EndBlock();
    }

    public override void EmitSetCallbackArgumentToDefaultStatements(CodeBuilder b, string var) {
        b.AppendLine("{0}_str = IntPtr.Zero;", var);
        b.AppendLine("{0}_length = 0;", var);
        b.AppendLine("{0}_gc_handle = IntPtr.Zero;", var);
    }

}
