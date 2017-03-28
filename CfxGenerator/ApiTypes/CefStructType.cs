// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Diagnostics;

public class CefStructType : CefType {

    public int ApiIndex;


    private CfxClass m_classBuilder;

    public StructCategory Category { get; private set; }

    public CefStructType(string name, StructCategory category)
        : base(name) {
        Category = category;
    }

    public void SetMembers(Parser.CallbackStructNode s, ApiTypeBuilder api) {
        m_classBuilder = CfxClass.Create(this, s, api);
        CefBaseType = s.CefBaseType;
    }

    public void SetMembers(Parser.ValueStructNode s, ApiTypeBuilder api) {
        m_classBuilder = CfxClass.Create(this, s, api);
    }

    public CfxClass ClassBuilder {
        get { return m_classBuilder; }
    }

    public string CefBaseType { get; private set; }

    public bool IsRefCounted {
        get { return CefBaseType == "cef_base_ref_counted_t"; }
    }

    public bool IsScoped {
        get { return CefBaseType == "cef_base_scoped_t"; }
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

    public override string NativeCallbackReturnValueParameter() {
        return base.NativeCallbackReturnValueParameter() + ", gc_handle_t *__retval_handle";
    }

    public override string NativeCallbackReturnValueArgument() {
        return string.Format("&__retval, &__retval_handle");
    }

    public override string PInvokeCallbackReturnValueParameter() {
        return base.PInvokeCallbackReturnValueParameter() + ", out IntPtr __retval_handle";
    }

    public override string NativeReturnExpression(string var) {
        return string.Format("({0}*)cfx_copy_structure(&{1}, sizeof({0}))", OriginalSymbol, var);
    }

    public override void EmitSetCallbackReturnValueToDefaultStatements(CodeBuilder b) {
        base.EmitSetCallbackReturnValueToDefaultStatements(b);
        b.AppendLine("__retval_handle = default(IntPtr);");
    }

    public override void EmitSetCallbackReturnValueStatements(CodeBuilder b) {
        base.EmitSetCallbackReturnValueStatements(b);
        b.AppendLine("__retval_handle = e.m_returnValue == null ? IntPtr.Zero : System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(e.m_returnValue));");
    }

    public override void EmitNativeReturnStatements(CodeBuilder b, string functionCall, CodeBuilder postCallStatements) {
        Debug.Assert(Category == StructCategory.Values);
        b.AppendLine("{0} *__retval = malloc(sizeof({0}));", OriginalSymbol, functionCall);
        b.AppendLine("if(__retval) *__retval = {0};", functionCall);
        if(postCallStatements.IsNotEmpty) {
            b.AppendBuilder(postCallStatements);
        }
        b.AppendLine("return __retval;");
    }

    public override void EmitNativeCallbackReturnValueFields(CodeBuilder b) {
        base.EmitNativeCallbackReturnValueFields(b);
        b.AppendLine("gc_handle_t __retval_handle;");
    }

    public override void EmitNativeCallbackReturnStatements(CodeBuilder b) {
        b.AppendLine("{0} __retval_value = {{0}};", OriginalSymbol);
        b.AppendLine("if(__retval) __retval_value = *__retval;");
        b.AppendLine("if(__retval_handle) cfx_gc_handle_switch(&__retval_handle, GC_HANDLE_FREE);");
        b.AppendLine("return __retval_value;");
    }

    public override string NativeWrapExpression(string var) {
        return string.Format("&({0})", var);
    }

    public override string NativeUnwrapExpression(string var) {
        return string.Format("*({0})", var);
    }

    public override void EmitPublicCallProcessReturnValueStatements(CodeBuilder b) {
        b.AppendLine("if(__retval == IntPtr.Zero) throw new OutOfMemoryException();");
    }

    public override void EmitRemoteCallProcessReturnValueStatements(CodeBuilder b) {
        b.AppendLine("if(call.__retval == IntPtr.Zero) throw new OutOfMemoryException(\"Render process out of memory.\");");
    }

    public override string PublicReturnExpression(string var) {
        Debug.Assert(Category == StructCategory.Values);
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