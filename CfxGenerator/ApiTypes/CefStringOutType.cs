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

    public override string PInvokeCallParameter(string var) {
        return string.Format("out IntPtr {0}_str, out int {0}_length", var);
    }

    public override string PublicCallParameter(string var) {
        return string.Format("out string {0}", var);
    }

    public override string NativeUnwrapExpression(string var) {
        throw new Exception();
    }

    public override string PublicWrapExpression(string var) {
        throw new Exception();
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("out {0}_str, out {0}_length", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("out {0}", var);
    }

    public override string PublicEventConstructorParameter(string var) {
        throw new Exception();
    }

    public override string PublicEventConstructorArgument(string var) {
        throw new Exception();
    }

    public override string PInvokeOutArgument(string var) {
        throw new Exception();
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("cef_string_t {0} = {{ 0 }};", var);
    }

    public override void EmitPostNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("*{0}_str = {0}.str; *{0}_length = (int){0}.length;", var);
    }

    public override void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
        b.AppendLine("char16* {0}_tmp_str = 0; int {0}_tmp_length = 0;", var);
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        b.BeginIf("{0}_tmp_length > 0", var);
        b.AppendLine("cef_string_set({0}_tmp_str, {0}_tmp_length, {0}, 1);", var);
        b.AppendLine("cfx_gc_handle_free((gc_handle_t){0}_tmp_str);", var);
        b.EndBlock();
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("IntPtr {0}_str;", var);
        b.AppendLine("int {0}_length;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
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

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        throw new Exception();
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal string m_{0}_wrapped;", var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        throw new Exception();
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.BeginIf("e.m_{0}_wrapped != null && e.m_{0}_wrapped.Length > 0", var);
        b.AppendLine("var {0}_pinned = new PinnedString(e.m_{0}_wrapped);", var);
        b.AppendLine("{0}_str = {0}_pinned.Obj.PinnedPtr;", var);
        b.AppendLine("{0}_length = {0}_pinned.Length;", var);
        b.BeginElse();
        b.AppendLine("{0}_str = IntPtr.Zero;", var);
        b.AppendLine("{0}_length = 0;", var);
        b.EndBlock();
    }

    public override void EmitSetPInvokeParamToDefaultStatements(CodeBuilder b, string var) {
        b.AppendLine("{0}_str = IntPtr.Zero;", var);
        b.AppendLine("{0}_length = 0;", var);
    }

}
