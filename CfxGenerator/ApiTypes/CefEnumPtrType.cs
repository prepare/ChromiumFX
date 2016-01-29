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


public class CefEnumPtrType : CefType {
    private CefEnumType cefEnum;

    public CefEnumPtrType(CefEnumType cefEnum)
        : base(cefEnum.Name + "*") {
        this.cefEnum = cefEnum;
    }

    public override string OriginalSymbol {
        get { return cefEnum.OriginalSymbol + "*"; }
    }

    public override string PInvokeSymbol {
        get {
            return cefEnum.PInvokeSymbol;
        }
    }

    public override string PublicSymbol {
        get { return cefEnum.PublicSymbol; }
    }

    public override string PInvokeCallParameter(string var) {
        return "out " + cefEnum.PInvokeCallParameter(var);
    }

    public override string PInvokeCallbackParameter(string var) {
        return "ref " + cefEnum.PInvokeCallParameter(var);
    }

    public override string PublicCallParameter(string var) {
        return "out " + cefEnum.PublicCallParameter(var);
    }

    public override string PublicCallArgument(string var) {
        return string.Format("out {0}_tmp", var);
    }

    public override string PublicWrapExpression(string var) {
        return cefEnum.PublicWrapExpression(var);
    }

    public override string PublicUnwrapExpression(string var) {
        return cefEnum.PublicUnwrapExpression(var);
    }

    public override string PublicEventConstructorParameter(string var) {
        return PInvokeSymbol + " " + var;
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("int {0}_tmp;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = ({1}){0}_tmp;", var, cefEnum.PublicSymbol);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = e.m_{0};", var);
    }

    public override bool IsOut {
        get {
            return true;
        }
    }

}
