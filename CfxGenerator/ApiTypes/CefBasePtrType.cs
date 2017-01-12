// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefBasePtrType : ApiType {

    public CefBasePtrType()
        : base("struct _cef_base_t*") {
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicSymbol {
        get { return "CfxBase"; }
    }

    public override string ProxySymbol {
        get { return "IntPtr"; }
    }

    public override string RemoteSymbol {
        get { return "RemotePtr"; }
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        b.AppendLine("call.{0} = {0}.ptr;", CSharp.Escape(var));
    }


    public override string PublicWrapExpression(string var) {
        return string.Format("CfxBase.Cast({0})", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("CfxBase.Unwrap({0})", var);
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("CfxBase.Unwrap({0})", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("CfxBase.Cast({0})", var);
    }

    public override string ProxyReturnExpression(string var) {
        return var;
    }

    public override string ProxyCallArgument(string var) {
        return var;
    }
}