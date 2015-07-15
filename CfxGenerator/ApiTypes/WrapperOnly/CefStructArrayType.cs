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


// Array of structs, cef_struct_t *array

// inherit from CefStructPtrArrayType because the public layer is the same
public class CefStructArrayType : CefStructPtrArrayType {

    public CefStructArrayType(Argument structArg, Argument countArg)
        : base(new Argument(structArg, new CefStructPtrPtrType(structArg.ArgumentType.AsCefStructPtrType, "*")), countArg) {
    }

    public override bool IsOut {
        get { return CountArg.ArgumentType.IsOut; }
    }

    public override string PInvokeSymbol {
        get { return StructPtr.PInvokeSymbol; }
    }

    public override string NativeSymbol {
        get { return StructPtr.NativeSymbol + "*"; }
    }

    public override string PInvokeCallSignature(string var) {
        return string.Format("{0}, out int {1}_nomem", base.PInvokeCallSignature(var), var);
    }

    public override string NativeCallSignature(string var, bool isConst) {
        return string.Format("{0}, int* {1}_nomem", base.NativeCallSignature(var, isConst), var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}, out {1}_nomem", base.PublicUnwrapExpression(var), var);
    }

    public override string NativeUnwrapExpression(string var) {
        return string.Format("{0}_tmp", var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        base.EmitPrePublicCallStatements(b, var);
        b.AppendLine("int {0}_nomem;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        base.EmitPostPublicCallStatements(b, var);
        b.BeginBlock("if({0}_nomem != 0)", var);
        b.AppendLine("throw new OutOfMemoryException();");
        b.EndBlock();
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} *{1}_tmp = ({0}*)malloc({2} * sizeof({0}));", Struct.OriginalSymbol, var, CountArg.VarName);
        b.BeginBlock("if({0}_tmp)", var);
        b.BeginFor(CountArg.VarName);
        b.AppendLine("{0}_tmp[i] = *{0}[i];", var);
        b.EndBlock();
        b.AppendLine("*{0}_nomem = 0;", var);
        b.BeginElse();
        b.AppendLine("{0} = 0;", CountArg.VarName);
        b.AppendLine("*{0}_nomem = 1;", var);
        b.EndBlock();
    }

    public override void EmitPostNativeCallStatements(CodeBuilder b, string var) {
        b.AppendLine("if({0}_tmp) free({0}_tmp);", var);
    }
}