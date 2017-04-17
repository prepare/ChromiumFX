// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;



internal class SizeTypeOut : NumericOutType {
    internal SizeTypeOut() : base(new SizeType()) {
    }

    public override string RemoteCallSymbol {
        get {
            return "ulong";
        }
    }

    public override string PublicCallArgument(string var) {
        return string.Format("out {0}_tmp", var);
    }

    public override void EmitPublicPreCallStatements(CodeBuilder b, string var) {
        b.AppendLine("UIntPtr {0}_tmp = UIntPtr.Zero;", var);
    }

    public override void EmitPublicPostCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = (ulong){0}_tmp;", var);
    }

    public override void EmitRemoteEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("call.{0} = (UIntPtr)value;", CSharp.Escape(var));
    }
}

