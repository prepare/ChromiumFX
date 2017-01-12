// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefPlatformBasePtrType : SpecialType {

    public CefPlatformBasePtrType(string name)
        : base(name) {
    }

    public override string PublicSymbol {
        get { return "Cfx" + CSharp.ApplyStyle(Name.Substring(4, Name.Length - 7)); }
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", PublicSymbol, var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", PublicSymbol, var);
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        if(Name == "cef_main_args_t*") {
            b.AppendLine("#if defined CFX_WINDOWS");
            b.AppendLine("cef_main_args_t args_tmp = { GetModuleHandle(0) };");
            b.AppendLine("args = &args_tmp;");
            b.AppendLine("#endif");
        }
    }
}