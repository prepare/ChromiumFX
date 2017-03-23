// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStructOutType : CefStructPtrPtrType {

    public CefStructOutType(CefStructPtrType structPtr, string Indirection)
        : base(structPtr, Indirection) {
    }

    public override bool IsOut {
        get { return true; }
    }

    public override bool IsIn {
        get { return false; }
    }

    public override string PublicSymbol {
        get { return StructPtr.PublicSymbol; }
    }

    public override string ProxySymbol {
        get { return StructPtr.ProxySymbol; }
    }

    public override string RemoteSymbol {
        get { return StructPtr.RemoteSymbol; }
    }

    public override string PInvokeCallParameter(string var) {
        return "out IntPtr " + var;
    }

    public override string PublicCallParameter(string var) {
        return "out " + StructPtr.PublicCallParameter(var);
    }

    public override string ProxyCallArgument(string var) {
        return "out " + var;
    }

    public override string RemoteCallParameter(string var) {
        return "out " + StructPtr.RemoteCallParameter(var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("out {0}_ptr", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("out {0}_local", var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1}).ptr", Struct.RemoteClassName, var);
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap(new RemotePtr(connection, {1}))", Struct.RemoteClassName, var);
    }

    public override string PublicEventConstructorParameter(string var) {
        return null;
    }

    public override string PublicEventConstructorArgument(string var) {
        return null;
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted)
            b.AppendLine("if(*{0})((cef_base_ref_counted_t*)*{0})->add_ref((cef_base_ref_counted_t*)*{0});", var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("IntPtr {0}_ptr;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.PublicWrapExpression(var + "_ptr"));
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var);
    }

    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1}_wrapped;", RemoteSymbol, var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.PublicUnwrapExpression(string.Concat("e.m_", var, "_wrapped")));
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {1};", var, StructPtr.RemoteUnwrapExpression(string.Concat("e.m_", var, "_wrapped")));
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitRemoteEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0}_wrapped = value;", var);
    }

    public override void EmitPreProxyCallStatements(CodeBuilder b, string var) {
    }

    public override void EmitPostProxyCallStatements(CodeBuilder b, string var) {
    }
}