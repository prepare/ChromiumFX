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


public class CefStringPtrType : ApiType {

    public CefStringPtrType()
        : base("cef_string_t*") {
    }

    public override bool IsOut {
        get { return true; }
    }

    public override string PInvokeSymbol {
        get {
            return "IntPtr";
        }
    }

    public override string PublicSymbol {
        get { return "string"; }
    }

    public override string NativeCallParameter(string var, bool isConst) {
        return string.Format("char16 **{0}_str, int *{0}_length", var);
    }

    public override string PInvokeCallParameter(string var) {
        return string.Format("ref IntPtr {0}_str, ref int {0}_length", var);
    }

    public override string PublicCallParameter(string var) {
        return string.Format("ref string {0}", var);
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("&({0}_tmp_str), &({0}_tmp_length)", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return "&" + var;
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length)", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("ref {0}_str, ref {0}_length", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("ref {0}", var);
    }

    public override string PublicEventConstructorParameter(string var) {
        return string.Format("IntPtr {0}_str, int {0}_length", var);
    }

    public override string PublicEventConstructorArgument(string var) {
        return string.Format("{0}_str, {0}_length", var);
    }

    public override string PInvokeOutArgument(string var) {
        return string.Format("out {0}_str, out {0}_length", var);
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("cef_string_t {0} = {{ *{0}_str, *{0}_length, 0 }};", var);
    }

    public override void EmitPostNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("*{0}_str = {0}.str; *{0}_length = (int){0}.length;", var);
    }

    public override void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
        b.AppendLine("char16* {0}_tmp_str = {0}->str; int {0}_tmp_length = (int){0}->length;", var);
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        b.BeginBlock("if({0}_tmp_str != {0}->str)", var);
        b.AppendLine("if({0}->dtor) {0}->dtor({0}->str);", var);
        b.AppendLine("cef_string_set({0}_tmp_str, {0}_tmp_length, {0}, 1);", var);
        b.AppendLine("cfx_gc_handle_free((gc_handle_t){0}_tmp_str);", var);
        b.EndBlock();
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var));
        b.AppendLine("IntPtr {0}_str = {0}_pinned.Obj.PinnedPtr;", var);
        b.AppendLine("int {0}_length = {0}_pinned.Length;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.BeginIf("{0}_str != {0}_pinned.Obj.PinnedPtr", var);
        b.BeginIf("{0}_length > 0", var);
        b.AppendLine("{0} = System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length);", var);
        b.AppendLine("// free the native string?", var);
        b.BeginElse();
        b.AppendLine("{0} = null;", var);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine("{0}_pinned.Obj.Free();", var);
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.BeginIf("!m_{0}_changed && m_{0}_wrapped == null", var);
        b.AppendLine("m_{0}_wrapped = StringFunctions.PtrToStringUni(m_{0}_str, m_{0}_length);", var);
        b.EndBlock();
        b.AppendLine("return m_{0}_wrapped;", var);
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
        b.AppendLine("m_{0}_changed = true;", var);
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal IntPtr m_{0}_str;", var);
        b.AppendLine("internal int m_{0}_length;", var);
        b.AppendLine("internal string m_{0}_wrapped;", var);
        b.AppendLine("internal bool m_{0}_changed;", var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_str = {0}_str;", var);
        b.AppendLine("m_{0}_length = {0}_length;", var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.BeginIf("e.m_{0}_changed", var);
        b.AppendLine("var {0}_pinned = new PinnedString(e.m_{0}_wrapped);", var);
        b.AppendLine("{0}_str = {0}_pinned.Obj.PinnedPtr;", var);
        b.AppendLine("{0}_length = {0}_pinned.Length;", var);
        b.EndBlock();
    }

    public override void EmitProxyEventArgSetter(CodeBuilder b, string var) {
        b.AppendLine("e.{0} = value;", var);
    }

    public override bool IsCefStringPtrType {
        get { return true; }
    }

    public override CefStringPtrType AsCefStringPtrType {
        get { return this; }
    }
}