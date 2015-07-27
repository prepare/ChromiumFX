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


public class CefStructType : CefType {
    public int ApiIndex;

    private CfxClassBuilder m_classBuilder;

    public CefStructType(string name, CommentData comments)
        : base(name) {
    }

    public void SetMembers(Parser.StructData sd, ApiTypeBuilder api) {
        m_classBuilder = new CfxClassBuilder(this, sd, api);
    }

    public CfxClassBuilder ClassBuilder {
        get { return m_classBuilder; }
    }

    public string CfxNativeSymbol {
        get { return CfxName + "_t"; }
    }

    public string RemoteClassName {
        get { return "Cfr" + CSharp.ApplyStyle(Name.Substring(4)); }
    }

    public override string OriginalSymbol {
        get { return Name + "_t"; }
    }

    public override string NativeSymbol {
        get { return OriginalSymbol + "*"; }
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicSymbol {
        get { return ClassName; }
    }

    public override string ProxySymbol {
        get { return "ulong"; }
    }

    public override string RemoteSymbol {
        get { return RemoteClassName; }
    }

    public override void EmitNativeReturnStatements(CodeBuilder b, string functionCall, CodeBuilder postCallStatements) {
        b.AppendLine("{0} __retval_tmp = {1};", OriginalSymbol, functionCall);
        if(postCallStatements.IsNotEmpty) {
            b.AppendLine("{0} *__retval = ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol);
            b.AppendBuilder(postCallStatements);
            b.AppendLine("return __retval;");
        } else {
            b.AppendLine("return ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol);
        }
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("&({0})", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return string.Format("*({0})", var);
    }

    public override string PublicReturnExpression(string var) {
        return string.Format("{0}.WrapOwned({1})", ClassName, var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", ClassName, var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", ClassName, var);
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("RemoteProxy.Wrap({0})", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("({0})RemoteProxy.Unwrap({1})", ClassName, var);
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", RemoteClassName, var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", RemoteClassName, var);
    }

    public override string[] ParserMatches {
        get { return new string[] { OriginalSymbol, "struct _" + OriginalSymbol }; }
    }

    public override bool IsCefStructType {
        get { return true; }
    }

    public override CefStructType AsCefStructType {
        get { return this; }
    }
}