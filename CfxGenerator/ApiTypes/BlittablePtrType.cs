// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

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

    public override void EmitRemotePreCallStatements(CodeBuilder b, string var) {
        switch(RemoteSymbol) {
            case "RemotePtr":
                b.AppendLine("if({0}.connection != connection) throw new ArgumentException(\"Render process connection mismatch.\", \"{1}\");", CSharp.Escape(var), var);
                b.AppendLine("call.{0} = {0}.ptr;", CSharp.Escape(var));
                return;
            default:
                base.EmitRemotePreCallStatements(b, var);
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