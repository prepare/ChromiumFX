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


public class CefStructPtrType : ApiType {
    public readonly CefStructType Struct;

    public readonly string Indirection;

    public CefStructPtrType(CefStructType cefStruct, string Indirection)
        : base(AddIndirection(cefStruct.Name, Indirection)) {
        this.Struct = cefStruct;
        this.Indirection = Indirection;
    }

    public override string OriginalSymbol {
        get { return AddIndirection(Struct.OriginalSymbol, Indirection); }
    }

    public override string PublicSymbol {
        get { return Struct.ClassName; }
    }

    public override string ProxySymbol {
        get { return "ulong"; }
    }

    public override string RemoteSymbol {
        get { return Struct.RemoteClassName; }
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", Struct.ClassName, var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", Struct.ClassName, CSharp.Escape(var));
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("({0})RemoteProxy.Unwrap({1})", Struct.ClassName, CSharp.Escape(var));
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("RemoteProxy.Wrap({0})", CSharp.Escape(var));
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("CfrObject.Unwrap({0})", CSharp.Escape(var));
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", RemoteSymbol, var);
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        if(Struct.ClassBuilder.IsRefCounted && var != "self") {
            b.AppendLine("if({0}) ((cef_base_t*){0})->add_ref((cef_base_t*){0});", var);
        }
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("if(m_{0}_wrapped == null) m_{0}_wrapped = {1};", var, PublicWrapExpression("m_" + var));
        b.AppendLine("return m_{0}_wrapped;", var);
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        base.EmitPublicEventArgFields(b, var);
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var);
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override bool IsCefStructPtrType {
        get { return true; }
    }

    public override CefStructPtrType AsCefStructPtrType {
        get { return this; }
    }

    public override string[] ParserMatches {
        get { return new string[] { Struct.ParserMatches[0] + Indirection, Struct.ParserMatches[1] + Indirection }; }
    }
}