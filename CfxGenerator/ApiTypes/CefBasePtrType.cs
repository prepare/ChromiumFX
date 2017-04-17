// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefBaseRefCountedPtrType : ApiType {

    public CefBaseRefCountedPtrType()
        : base("struct _cef_base_ref_counted_t*") {
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicSymbol {
        get { return "CfxBaseRefCounted"; }
    }

    public override string ProxySymbol {
        get { return "IntPtr"; }
    }

    public override string RemoteSymbol {
        get { return "CfrBaseRefCounted"; }
    }

    public override string[] ParserMatches {
        get {
            return new string[] {
                Name,
                "cef_base_ref_counted_t*"
            };
        }
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        b.AppendLine("if(!CfrObject.CheckConnection({0}, connection)) throw new ArgumentException(\"Render process connection mismatch.\", \"{1}\");", CSharp.Escape(var), var);
        b.AppendLine("call.{0} = CfrBaseRefCounted.Unwrap({0}).ptr;", CSharp.Escape(var));
    }


    public override string PublicWrapExpression(string var) {
        return string.Format("CfxBaseRefCounted.Cast({0})", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("CfxBaseRefCounted.Unwrap({0})", var);
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("CfxBaseRefCounted.Unwrap({0})", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("CfxBaseRefCounted.Cast({0})", var);
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("CfrBaseRefCounted.Cast(new RemotePtr(connection, {0}))", var);
    }

    public override string ProxyReturnExpression(string var) {
        return var;
    }

    public override string ProxyCallArgument(string var) {
        return var;
    }
}