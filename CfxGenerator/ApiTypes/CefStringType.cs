// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStringType : SpecialType {

    public CefStringType()
        : base("cef_string_t") {
    }

    public override string PublicSymbol {
        get { return "string"; }
    }

    public override string NativeCallParameter(string var, bool isConst) {
        return string.Format("char16 *{0}_str, int {0}_length", var);
    }

    public override string NativeOutSignature(string var) {
        return string.Format("char16 **{0}_str, int *{0}_length", var);
    }

    public override string PInvokeCallParameter(string var) {
        return string.Format("IntPtr {0}_str, int {0}_length", var);
    }

    public override string PInvokeOutSignature(string var) {
        return string.Format("out IntPtr {0}_str, out int {0}_length", var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("StringFunctions.PtrToStringUni({0}_str, {0}_length)", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}_pinned.Obj.PinnedPtr, {0}_pinned.Length", var);
    }

    public override string PInvokeOutArgument(string var) {
        return string.Format("out {0}_str, out {0}_length", var);
    }

    public override void EmitPublicPreCallStatements(CodeBuilder b, string var) {
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var));
    }

    public override void EmitPublicPostCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0}_pinned.Obj.Free();", var);
    }

    public override void EmitValueStructGetterVars(CodeBuilder b, string var) {
        b.AppendLine("IntPtr {0}_str;", var);
        b.AppendLine("int {0}_length;", var);
    }

    public override void EmitAssignToNativeStructMember(CodeBuilder b, string var, string cefStruct = "self") {
        b.AppendLine("cef_string_utf16_set({0}_str, {0}_length, &({1}->{0}), 1);", var, cefStruct);
    }

    public override void EmitAssignFromNativeStructMember(CodeBuilder b, string var, string cefStruct = "self") {
        b.AppendLine("*{0}_str = {1}->{0}.str;", var, cefStruct);
        b.AppendLine("*{0}_length = (int){1}->{0}.length;", var, cefStruct);
    }

    public override void EmitNativeValueStructDtorStatements(CodeBuilder b, string var) {
        b.AppendLine("if(self->{0}.dtor) self->{0}.dtor(self->{0}.str);", var);
    }

    public override bool IsCefStringType {
        get { return true; }
    }

    public override CefStringType AsCefStringType {
        get { return this; }
    }
}