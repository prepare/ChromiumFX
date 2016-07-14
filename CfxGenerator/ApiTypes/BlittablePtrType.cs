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


public class BlittablePtrType : ApiType {
    public readonly BlittableType BlittableType;

    public readonly string Indirection;

    public BlittablePtrType(BlittableType baseType, string indirection)
        : base(AddIndirection(baseType.Name, indirection)) {
        this.Indirection = indirection;
        this.BlittableType = baseType;
    }

    public override string OriginalSymbol {
        get { return AddIndirection(BlittableType.OriginalSymbol, Indirection); }
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string RemoteSymbol {
        get {
            return "RemotePtr";
        }
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        switch(RemoteSymbol) {
            case "RemotePtr":
                b.AppendLine("call.{0} = {0}.ptr;", CSharp.Escape(var));
                return;
            default:
                base.EmitPreRemoteCallStatements(b, var);
                return;
        }

    }

    private string[] _matches;

    public override string[] ParserMatches {
        get {
            if(_matches == null) {
                _matches = new string[BlittableType.ParserMatches.Length];
                for(var i = 0; i <= _matches.Length - 1; i++) {
                    _matches[i] = BlittableType.ParserMatches[i] + Indirection;
                }
            }
            return _matches;
        }
    }
}