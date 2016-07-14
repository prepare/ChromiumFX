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


public class StringCollectionType : CefType {

    public StringCollectionType(string name)
        : base(name) {
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}_unwrapped", var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("StringFunctions.Wrap{0}({1})", ClassName, var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("PinnedString[] {0}_handles;", var);
        b.AppendLine("var {0}_unwrapped = StringFunctions.Unwrap{1}({0}, out {0}_handles);", var, ClassName);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("StringFunctions.FreePinnedStrings({0}_handles);", var);
        b.AppendLine("StringFunctions.{0}CopyToManaged({1}_unwrapped, {1});", ClassName, var);
        b.AppendLine("CfxApi.{0}_free({1}_unwrapped);", CfxName, var);
    }

    public override void EmitNativeValueStructDtorStatements(CodeBuilder b, string var) {
        b.BeginBlock("if(self->{0})", var);
        b.AppendLine("{0}_clear(self->{1});", Name, var);
        b.AppendLine("{0}_free(self->{1});", Name, var);
        b.EndBlock();
    }

    public override void EmitPostRemoteCallStatements(CodeBuilder b, string var) {
        b.AppendLine("StringFunctions.Copy{0}(call.{1}, {1});", ClassName, var);
    }

    public override bool IsStringCollectionType {
        get { return true; }
    }

    public override StringCollectionType AsStringCollectionType {
        get {
            return this;
        }
    }
}