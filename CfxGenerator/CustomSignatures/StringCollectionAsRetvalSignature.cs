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


public class StringCollectionAsRetvalSignature : Signature {

    public StringCollectionAsRetvalSignature(ISignatureOwner parent, Parser.SignatureData sd, ApiTypeBuilder api)
        : base(SignatureType.LibraryCall, parent, sd, api) {
    }

    public override Argument[] ManagedArguments {
        get { return new Argument[] { base.ManagedArguments[0] }; }
    }

    public override ApiType PublicReturnType {
        get { return base.ManagedArguments[1].ArgumentType; }
    }

    public override void EmitPublicCall(CodeBuilder b) {
        b.AppendLine("{0} {1} = new {0}();", base.ManagedArguments[1].ArgumentType.PublicSymbol, base.ManagedArguments[1].VarName);
        base.ManagedArguments[1].EmitPrePublicCallStatements(b);
        b.AppendLine(string.Format("CfxApi.{0}(NativePtr, {1});", Owner.CfxApiFunctionName, base.ManagedArguments[1].PublicCallArgument));
        base.ManagedArguments[1].EmitPostPublicStatements(b);
        b.AppendLine("return {0};", base.ManagedArguments[1].VarName);
    }
}