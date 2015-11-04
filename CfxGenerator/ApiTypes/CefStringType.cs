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

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var));
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
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