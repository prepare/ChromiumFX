// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStructType : CefType {
    public int ApiIndex;

    private CfxClass m_classBuilder;

    public CefStructType(string name, CommentData comments)
        : base(name) {
    }

    public void SetMembers(Parser.StructData sd, ApiTypeBuilder api) {
        m_classBuilder = CfxClass.Create(this, sd, api);
    }

    public CfxClass ClassBuilder {
        get { return m_classBuilder; }
    }

    public string CfxNativeSymbol {
        get { return CfxName + "_t"; }
    }

    public string RemoteClassName {
        get { return "Cfr" + CSharp.ApplyStyle(Name.Substring(4)); }
    }

    public override string OriginalSymbol {
        get { return Name + "_t"; }
    }

    public override string NativeSymbol {
        get { return OriginalSymbol + "*"; }
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicSymbol {
        get { return ClassName; }
    }

    public override string ProxySymbol {
        get { return "IntPtr"; }
    }

    public override string RemoteSymbol {
        get { return RemoteClassName; }
    }

    public override void EmitNativeReturnStatements(CodeBuilder b, string functionCall, CodeBuilder postCallStatements) {
        b.AppendLine("{0} __retval_tmp = {1};", OriginalSymbol, functionCall);
        if(postCallStatements.IsNotEmpty) {
            b.AppendLine("{0} *__retval = ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol);
            b.AppendBuilder(postCallStatements);
            b.AppendLine("return __retval;");
        } else {
            b.AppendLine("return ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol);
        }
    }

    public override void EmitNativeCallbackReturnStatements(CodeBuilder b, string var) {
        b.AppendComment("TODO: possible race with managed GC?");
        base.EmitNativeCallbackReturnStatements(b, var);
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("&({0})", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return string.Format("*({0})", var);
    }

    public override string PublicReturnExpression(string var) {
        return string.Format("{0}.WrapOwned({1})", ClassName, var);
    }

    public override string ProxyReturnExpression(string var) {
        // TODO: remote object must WrapOwned the ptr
        return var;
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", ClassName, var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", ClassName, var);
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("RemoteProxy.Wrap({0})", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("({0})RemoteProxy.Unwrap({1})", ClassName, var);
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap(new RemotePtr(connection, {1}))", RemoteClassName, var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1}).ptr", RemoteClassName, var);
    }

    public override string[] ParserMatches {
        get { return new string[] { OriginalSymbol, "struct _" + OriginalSymbol }; }
    }

    public override bool IsCefStructType {
        get { return true; }
    }

    public override CefStructType AsCefStructType {
        get { return this; }
    }
}