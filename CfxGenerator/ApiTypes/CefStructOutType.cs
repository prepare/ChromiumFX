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


public class CefStructOutType : CefStructPtrPtrType {

    public CefStructOutType(CefStructPtrType structPtr, string Indirection)
        : base(structPtr, Indirection) {
    }

    public override bool IsOut {
        get { return true; }
    }

    public override bool IsIn {
        get { return false; }
    }

    public override string PublicSymbol {
        get { return StructPtr.PublicSymbol; }
    }

    public override string ProxySymbol {
        get { return StructPtr.ProxySymbol; }
    }

    public override string RemoteSymbol {
        get { return StructPtr.RemoteSymbol; }
    }

    public override string PInvokeCallParameter(string var) {
        return "out IntPtr " + var;
    }

    public override string PublicCallParameter(string var) {
        return "out " + StructPtr.PublicCallParameter(var);
    }

    public override string ProxyCallParameter(string var) {
        return "out " + StructPtr.ProxyCallParameter(var);
    }

    public override string ProxyCallArgument(string var) {
        return "out " + var;
    }

    public override string RemoteCallParameter(string var) {
        return "out " + StructPtr.RemoteCallParameter(var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("out {0}_ptr", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("out {0}_local", var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1}).ptr", Struct.RemoteClassName, var);
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap(new RemotePtr(connection, {1}))", Struct.RemoteClassName, var);
    }

    public override string PublicEventConstructorParameter(string var) {
        return null;
    }

    public override string PublicEventConstructorArgument(string var) {
        return null;
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        b.AppendLine("if(*{0})((cef_base_t*)*{0})->add_ref((cef_base_t*)*{0});", var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("IntPtr {0}_ptr;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.PublicWrapExpression(var + "_ptr"));
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var);
    }

    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1}_wrapped;", RemoteSymbol, var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.PublicUnwrapExpression(string.Concat("e.m_", var, "_wrapped")));
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.RemoteUnwrapExpression(string.Concat("e.m_", var, "_wrapped")));
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitRemoteEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitPreProxyCallStatements(CodeBuilder b, string var) {
    }

    public override void EmitPostProxyCallStatements(CodeBuilder b, string var) {
    }
}