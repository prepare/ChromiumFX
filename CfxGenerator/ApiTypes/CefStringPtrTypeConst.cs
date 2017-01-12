// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStringPtrTypeConst : ApiType {

    public CefStringPtrTypeConst()
        : base("cef_string_t*") {
    }

    public override string PublicSymbol {
        get { return "string"; }
    }

    public override string NativeCallParameter(string var, bool isConst) {
        return string.Format("char16 *{0}_str, int {0}_length", var);
    }

    public override string PInvokeCallParameter(string var) {
        return string.Format("IntPtr {0}_str, int {0}_length", var);
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("{0} ? {0}->str : 0, {0} ? (int){0}->length : 0", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return "&" + var;
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}_str == IntPtr.Zero ? null : System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length)", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}_pinned.Obj.PinnedPtr, {0}_pinned.Length", var);
    }

    public override string PublicEventConstructorArgument(string var) {
        return string.Format("{0}_str, {0}_length", var);
    }

    public override string PInvokeOutArgument(string var) {
        return string.Format("out {0}_str, out {0}_length", var);
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("cef_string_t {0} = {{ {0}_str, {0}_length, 0 }};", var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var));
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0}_pinned.Obj.Free();", var);
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0} = StringFunctions.PtrToStringUni(m_{0}_str, m_{0}_length);", var);
        b.AppendLine("return m_{0};", var);
    }

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.BeginBlock("if(!m_{0}_fetched)", var);
        b.AppendLine("m_{0} = call.{0}_str == IntPtr.Zero ? null : (call.{0}_length == 0 ? String.Empty : CfrRuntime.Marshal.PtrToStringUni(new RemotePtr(call.{0}_str), call.{0}_length));", var);
        b.AppendLine("m_{0}_fetched = true;", var);
        b.EndBlock();
        b.AppendLine("return m_{0};", var);
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal IntPtr m_{0}_str;", var);
        b.AppendLine("internal int m_{0}_length;", var);
        b.AppendLine("internal string m_{0};", var);
    }
    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal string m_{0};", var);
        b.AppendLine("internal bool m_{0}_fetched;", var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_str = {0}_str;", var);
        b.AppendLine("m_{0}_length = {0}_length;", var);
    }

    public override bool IsCefStringPtrTypeConst {
        get { return true; }
    }

    public override CefStringPtrTypeConst AsCefStringPtrTypeConst {
        get { return this; }
    }
}