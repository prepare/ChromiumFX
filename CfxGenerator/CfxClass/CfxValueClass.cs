// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class CfxValueClass : CfxClass {

    private bool hasSizeMember;

    public override StructCategory Category {
        get {
            return StructCategory.Values;
        }
    }

    public CfxValueClass(CefStructType cefStruct, Parser.ValueStructNode sd, ApiTypeBuilder api)
        : base(cefStruct, sd.Comments) {

        var smlist = new List<StructMember>();
        foreach(var smd in sd.StructMembers) {
            smlist.Add(new StructMember(cefStruct, Category, smd, api));
        }
        var sm0 = smlist[0];
        if(sm0.Name == "size" && sm0.MemberType.OriginalSymbol == "size_t") {
            smlist.RemoveAt(0);
            hasSizeMember = true;
        }
        StructMembers = smlist.ToArray();
    }

    public override void EmitNativeWrapper(CodeBuilder b) {

        b.AppendComment(CefStruct.Name);
        b.AppendLine();

        if(CefStruct.IsCefPlatformStructType) {
            b.AppendLine("#ifdef CFX_" + CefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine();
        }

        b.BeginBlock("static {0}* {1}_ctor()", OriginalSymbol, CfxName);
        if(hasSizeMember) {
            b.AppendLine("{0}* self = ({0}*)calloc(1, sizeof({0}));", OriginalSymbol);
            b.AppendLine("if(!self) return 0;");
            b.AppendLine("self->size = sizeof({0});", OriginalSymbol);
            b.AppendLine("return self;");
        } else {
            b.AppendLine("return ({0}*)calloc(1, sizeof({0}));", OriginalSymbol);
        }
        b.EndBlock();
        b.AppendLine();

        b.BeginBlock("static void {1}_dtor({0}* self)", OriginalSymbol, CfxName);
        foreach(var sm in StructMembers) {
            sm.MemberType.EmitNativeValueStructDtorStatements(b, sm.Name);
        }
        b.AppendLine("free(self);", OriginalSymbol);
        b.EndBlock();
        b.AppendLine();

        foreach(var sm in StructMembers) {
            b.AppendComment("{0}->{1}", CefStruct.OriginalSymbol, sm.Name);
            b.BeginBlock("static void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
            sm.MemberType.EmitAssignToNativeStructMember(b, sm.Name);
            b.EndBlock();
            b.BeginBlock("static void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
            sm.MemberType.EmitAssignFromNativeStructMember(b, sm.Name);
            b.EndBlock();
            b.AppendLine();
        }

        if(CefStruct.IsCefPlatformStructType) {
            b.AppendLine("#else //ifdef CFX_" + CefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine("#define {0}_ctor 0", CfxName);
            b.AppendLine("#define {0}_dtor 0", CfxName);
            foreach(var sm in StructMembers) {
                b.AppendLine("#define {0}_set_{1} 0", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                b.AppendLine("#define {0}_get_{1} 0", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
            }
            b.AppendLine("#endif //ifdef CFX_" + CefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine();
        }

        b.AppendLine();
    }

    protected override void EmitApiDeclarations(CodeBuilder b) {
        b.AppendComment("static {0}* {1}_ctor()", OriginalSymbol, CfxName);
        b.AppendLine("public static cfx_ctor_delegate {0}_ctor;", CfxName);
        b.AppendComment("static void {1}_dtor({0}* ptr)", OriginalSymbol, CfxName);
        b.AppendLine("public static cfx_dtor_delegate {0}_dtor;", CfxName);
        b.AppendLine();

        foreach(var sm in StructMembers) {
            b.AppendComment("static void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
            b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]");
            b.AppendLine("public delegate void {0}_set_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeCallParameter(sm.Name));
            b.AppendLine("public static {0}_set_{1}_delegate {0}_set_{1};", CfxName, sm.Name);
            b.AppendComment("static void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
            b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]");
            b.AppendLine("public delegate void {0}_get_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutSignature(sm.Name));
            b.AppendLine("public static {0}_get_{1}_delegate {0}_get_{1};", CfxName, sm.Name);
            b.AppendLine();
        }
    }

    public override void EmitPublicClass(CodeBuilder b) {

        //asserts

        foreach(var sm in StructMembers) {
            if(sm.MemberType.IsCefStructPtrType) {
                System.Diagnostics.Debugger.Break();
            }
            if(sm.MemberType.IsCefStructType && sm.MemberType.AsCefStructType.IsRefCounted) {
                System.Diagnostics.Debugger.Break();
            }
        }

        b.AppendSummaryAndRemarks(Comments);

        if(CefStruct.IsCefPlatformStructType) {
            b.BeginClass(ClassName + " : CfxStructure", GeneratorConfig.ClassModifiers(ClassName, "internal sealed"));
        } else {
            b.BeginClass(ClassName + " : CfxStructure", GeneratorConfig.ClassModifiers(ClassName, "public sealed"));
        }
        b.AppendLine();

        if(NeedsWrapFunction) {
            b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static");
            b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
            b.AppendLine("return new {0}(nativePtr);", ClassName);
            b.EndBlock();
            b.AppendLine();
            b.BeginFunction("WrapOwned", ClassName, "IntPtr nativePtr", "internal static");
            b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
            b.AppendLine("return new {0}(nativePtr, CfxApi.{1}.{2}_dtor);", ClassName, ApiClassName, CfxName);
            b.EndBlock();
            b.AppendLine();
        }

        if(CefStruct.IsCefPlatformStructType) {
            b.AppendLine("public {0}() : base(CfxApi.{1}.{2}_ctor, CfxApi.{1}.{2}_dtor) {{ CfxApi.CheckPlatformOS(CfxPlatformOS.{3}); }}", ClassName, ApiClassName, CfxName, CefStruct.AsCefPlatformStructType.Platform.ToString());
        } else {
            b.AppendLine("public {0}() : base(CfxApi.{1}.{2}_ctor, CfxApi.{1}.{2}_dtor) {{}}", ClassName, ApiClassName, CfxName);
        }

        if(NeedsWrapFunction) {
            b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);
            b.AppendLine("internal {0}(IntPtr nativePtr, CfxApi.cfx_dtor_delegate cfx_dtor) : base(nativePtr, cfx_dtor) {{}}", ClassName);
        }
        b.AppendLine();

        foreach(var sm in StructMembers) {
            b.AppendSummaryAndRemarks(sm.Comments);
            b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.PublicSymbol);
            b.BeginBlock("get");
            sm.MemberType.EmitValueStructGetterVars(b, "value");
            b.AppendLine("CfxApi.{3}.{0}_get_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutArgument("value"), ApiClassName);
            b.AppendLine("return {0};", sm.MemberType.PublicWrapExpression("value"));
            b.EndBlock();
            b.BeginBlock("set");
            sm.MemberType.EmitPublicPreCallStatements(b, "value");
            b.AppendLine("CfxApi.{3}.{0}_set_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PublicUnwrapExpression("value"), ApiClassName);
            sm.MemberType.EmitPublicPostCallStatements(b, "value");
            b.EndBlock();
            b.EndBlock();
            b.AppendLine();
        }

        b.EndBlock();
    }

    public override void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {

        b.AppendLine();

        b.BeginRemoteCallClass(ClassName, callIds, "CtorRemoteCall");
        b.AppendLine();
        b.BeginBlock("protected override void RemoteProcedure()");
        b.AppendLine("__retval = CfxApi.{0}.{1}_ctor();", ApiClassName, CfxName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        b.BeginRemoteCallClass(ClassName, callIds, "DtorRemoteCall");
        b.AppendLine();
        b.BeginBlock("protected override void RemoteProcedure()");
        b.AppendLine("CfxApi.{0}.{1}_dtor(nativePtr);", ApiClassName, CfxName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        foreach(var sm in StructMembers) {
            b.BeginRemoteCallClass(ClassName + "Get" + sm.PublicName, callIds);
            b.AppendLine("internal IntPtr sender;");
            b.AppendLine("internal {0} value;", sm.MemberType.PInvokeSymbol);
            b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
            b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
            b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(value); }");
            b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out value); }");
            b.BeginBlock("protected override void RemoteProcedure()");
            b.AppendLine("CfxApi.{0}.{1}_get_{2}(sender, out value);", ApiClassName, CfxName, sm.Name);
            b.EndBlock();
            b.EndBlock();
            b.BeginRemoteCallClass(ClassName + "Set" + sm.PublicName, callIds);
            b.AppendLine("internal IntPtr sender;");
            b.AppendLine("internal {0} value;", sm.MemberType.PInvokeSymbol);
            b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }");
            b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }");
            b.BeginBlock("protected override void RemoteProcedure()");
            b.AppendLine("CfxApi.{0}.{1}_set_{2}(sender, value);", ApiClassName, CfxName, sm.Name);
            b.EndBlock();
            b.EndBlock();
        }
    }


    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.Client);
        b.BeginClass(RemoteClassName + " : CfrStructure", GeneratorConfig.ClassModifiers(RemoteClassName, "public sealed"));
        b.AppendLine();

        if(NeedsWrapFunction) {
            b.BeginFunction("Wrap", RemoteClassName, "RemotePtr remotePtr", "internal static");
            b.AppendLine("if(remotePtr == RemotePtr.Zero) return null;");
            b.AppendLine("var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;");
            b.BeginBlock("lock(weakCache)");
            b.AppendLine("var cfrObj = ({0})weakCache.Get(remotePtr.ptr);", RemoteClassName);
            b.BeginBlock("if(cfrObj == null)");
            b.AppendLine("cfrObj = new {0}(remotePtr);", RemoteClassName);
            b.AppendLine("weakCache.Add(remotePtr.ptr, cfrObj);");
            b.EndBlock();
            b.AppendLine("return cfrObj;");
            b.EndBlock();
            b.EndBlock();
            b.AppendLine();
            b.AppendLine();
        }

        b.AppendLine("private {0}(RemotePtr remotePtr) : base(remotePtr) {{}}", RemoteClassName);
        b.AppendLine("public {0}() : base(new {1}CtorRemoteCall(), new {1}DtorRemoteCall()) {{}}", RemoteClassName, ClassName);

        foreach(var sm in StructMembers) {
            b.AppendLine();
            b.AppendLine("{0} m_{1};", sm.MemberType.RemoteSymbol, sm.PublicName);
            b.AppendLine("bool m_{0}_fetched;", sm.PublicName);
            b.AppendLine();

            b.AppendSummaryAndRemarks(sm.Comments, true);
            b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.RemoteSymbol);
            b.BeginBlock("get");
            b.BeginIf("!m_{0}_fetched", sm.PublicName);
            b.AppendLine("var call = new {0}Get{1}RemoteCall();", ClassName, sm.PublicName);
            b.AppendLine("call.sender = RemotePtr.ptr;");
            b.AppendLine("call.RequestExecution(RemotePtr.connection);");
            b.AppendLine("m_{0} = {1};", sm.PublicName, sm.MemberType.RemoteWrapExpression("call.value"));
            b.AppendLine("m_{0}_fetched = true;", sm.PublicName);
            b.EndBlock();
            b.AppendLine("return m_{0};", sm.PublicName);
            b.EndBlock();
            b.BeginBlock("set");
            b.AppendLine("var call = new {0}Set{1}RemoteCall();", ClassName, sm.PublicName);
            b.AppendLine("call.sender = RemotePtr.ptr;");
            b.AppendLine("call.value = {0};", sm.MemberType.RemoteUnwrapExpression("value"));
            b.AppendLine("call.RequestExecution(RemotePtr.connection);");
            b.AppendLine("m_{0} = value;", sm.PublicName);
            b.AppendLine("m_{0}_fetched = true;", sm.PublicName);
            b.EndBlock();
            b.EndBlock();
        }

        b.EndBlock();

    }
}
