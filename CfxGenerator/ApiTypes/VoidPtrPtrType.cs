// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class VoidPtrPtrType : ApiType {

    public VoidPtrPtrType()
        : base("void**") {
    }

    public override bool IsIn {
        get { return false; }
    }

    public override bool IsOut {
        get { return true; }
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
        b.AppendLine("call.{0} = {0}.ptr;", CSharp.Escape(var));
    }

    public override string PInvokeCallParameter(string var) {
        return "out IntPtr " + CSharp.Escape(var);
    }

    public override string PublicCallParameter(string var) {
        return "out IntPtr " + CSharp.Escape(var);
    }

    public override string PublicCallArgument(string var) {
        return "out " + CSharp.Escape(var);
    }
}