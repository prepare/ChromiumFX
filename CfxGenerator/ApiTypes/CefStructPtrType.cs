// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Diagnostics;

public class CefStructPtrType : ApiType {
    public readonly CefStructType Struct;

    public readonly string Indirection;

    public CefStructPtrType(CefStructType cefStruct, string Indirection)
        : base(AddIndirection(cefStruct.Name, Indirection)) {
        this.Struct = cefStruct;
        this.Indirection = Indirection;
    }

    public override string OriginalSymbol {
        get { return AddIndirection(Struct.OriginalSymbol, Indirection); }
    }

    public override string PublicSymbol {
        get { return Struct.ClassName; }
    }

    public override string ProxySymbol {
        get { return "IntPtr"; }
    }

    public override string RemoteSymbol {
        get { return Struct.RemoteClassName; }
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("{0}.Wrap({1})", Struct.ClassName, var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}.Unwrap({1})", Struct.ClassName, CSharp.Escape(var));
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("({0})RemoteProxy.Unwrap({1}, (ptr) => new {0}(ptr))", Struct.ClassName, CSharp.Escape(var));
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("RemoteProxy.Wrap({0})", CSharp.Escape(var));
    }

    public override string ProxyReturnExpression(string var) {
        return var;
    }

    public override string ProxyCallArgument(string var) {
        return CSharp.Escape(var);
    }

    public override string PInvokeCallbackParameter(string var) {
        if(Struct.IsRefCounted)
            return base.PInvokeCallbackParameter(var) + ", out int " + var + "_release";
        else
            return base.PInvokeCallbackParameter(var);
    }

    public override string NativeCallbackParameter(string var, bool isConst) {
        if(Struct.IsRefCounted)
            return base.NativeCallbackParameter(var, isConst) + ", int *" + var + "_release";
        else
            return base.NativeCallbackParameter(var, isConst);
    }

    public override string NativeCallbackArgument(string var) {
        if(Struct.IsRefCounted)
            return base.NativeCallbackArgument(var) + ", &" + var + "_release";
        else
            return base.NativeCallbackArgument(var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("CfrObject.Unwrap({0}).ptr", CSharp.Escape(var));
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("{0}.Wrap(new RemotePtr({1}))", RemoteSymbol, var);
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self") {
            b.AppendLine("if({0}) ((cef_base_ref_counted_t*){0})->add_ref((cef_base_ref_counted_t*){0});", var);
        }
    }

    public override void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self")
            b.AppendLine("int " + var + "_release;");
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self")
            b.AppendLine("if({0}_release) {0}->base.release((cef_base_ref_counted_t*){0});", var);
    }

    public override string PublicEventConstructorParameter(string var) {
        return "IntPtr " + CSharp.Escape(var);
    }

    public override void EmitSetCallbackArgumentToDefaultStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self")
            b.AppendLine("{0}_release = 1;", var);
    }

    public override void EmitNativeCallbackReturnStatements(CodeBuilder b, string var) {
        Debug.Assert(Struct.IsRefCounted);
        b.BeginIf("__retval");
        b.AppendLine("((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);");
        b.EndBlock();
        base.EmitNativeCallbackReturnStatements(b, var);
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("if(m_{0}_wrapped == null) m_{0}_wrapped = {1};", var, PublicWrapExpression("m_" + var));
        b.AppendLine("return m_{0}_wrapped;", var);
    }

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("if(m_{0}_wrapped == null) m_{0}_wrapped = {1};", var, RemoteWrapExpression("call." + CSharp.Escape(var)));
        b.AppendLine("return m_{0}_wrapped;", var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self")
            b.AppendLine("{0}_release = e.m_{0}_wrapped == null? 1 : 0;", var);
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted && var != "self")
            b.AppendLine("{0}_release = e.m_{0}_wrapped == null? 1 : 0;", var);
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        base.EmitPublicEventArgFields(b, var);
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var);
    }

    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1}_wrapped;", RemoteSymbol, var);
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        if(var == "this")
            b.AppendLine("call.@this = RemotePtr.ptr;");
        else
            b.AppendLine("call.{0} = CfrObject.Unwrap({0}).ptr;", CSharp.Escape(var));
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override bool IsCefStructPtrType {
        get { return true; }
    }

    public override CefStructPtrType AsCefStructPtrType {
        get { return this; }
    }

    public override string[] ParserMatches {
        get { return new string[] { Struct.ParserMatches[0] + Indirection, Struct.ParserMatches[1] + Indirection }; }
    }
}