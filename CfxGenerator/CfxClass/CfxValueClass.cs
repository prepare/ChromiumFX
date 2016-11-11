// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class CfxValueClass : CfxClass {

    public CfxValueClass(CefStructType cefStruct, Parser.StructData sd, ApiTypeBuilder api)
        : base(cefStruct, sd, api) {

        var smlist = new List<StructMember>();
        foreach(var smd in sd.StructMembers) {
            smlist.Add(new StructMember(cefStruct, Category, smd, api));
        }
        StructMembers = smlist.ToArray();
        NeedsWrapping = GeneratorConfig.ValueStructNeedsWrapping(cefStruct.Name);
    }

    public override void EmitNativeWrapper(CodeBuilder b) {

        b.AppendComment(CefStruct.Name);
        b.AppendLine();

        if(CefStruct.IsCefPlatformStructType) {
            b.AppendLine("#ifdef CFX_" + CefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine();
        }

        b.BeginBlock("static {0}* {1}_ctor()", OriginalSymbol, CfxName);
        if(StructMembers.Length > 0 && StructMembers[0].Name == "size") {
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
            if(sm.Name != "size") {
                b.AppendComment("{0}->{1}", CefStruct.OriginalSymbol, sm.Name);
                b.BeginBlock("static void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                sm.MemberType.EmitAssignToNativeStructMember(b, sm.Name);
                b.EndBlock();
                b.BeginBlock("static void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
                sm.MemberType.EmitAssignFromNativeStructMember(b, sm.Name);
                b.EndBlock();
                b.AppendLine();
            }
        }

        if(CefStruct.IsCefPlatformStructType) {
            b.AppendLine("#else //ifdef CFX_" + CefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine("#define {0}_ctor 0", CfxName);
            b.AppendLine("#define {0}_dtor 0", CfxName);
            foreach(var sm in StructMembers) {
                if(sm.Name != "size") {
                    b.AppendLine("#define {0}_set_{1} 0", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                    b.AppendLine("#define {0}_get_{1} 0", CfxName, sm.Name, CefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
                }
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
            if(sm.Name != "size") {
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
    }

    public override void EmitPublicClass(CodeBuilder b) {

        //asserts

        foreach(var sm in StructMembers) {
            if(sm.MemberType.IsCefStructPtrType) {
                System.Diagnostics.Debugger.Break();
            }
            if(sm.MemberType.IsCefStructType && sm.MemberType.AsCefStructType.ClassBuilder.IsRefCounted) {
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

        if(NeedsWrapping) {
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

        if(NeedsWrapping) {
            b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);
            b.AppendLine("internal {0}(IntPtr nativePtr, CfxApi.cfx_dtor_delegate cfx_dtor) : base(nativePtr, cfx_dtor) {{}}", ClassName);
        }
        b.AppendLine();

        foreach(var sm in StructMembers) {
            if(sm.Name != "size") {
                b.AppendSummaryAndRemarks(sm.Comments);
                b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.PublicSymbol);
                b.BeginBlock("get");
                sm.MemberType.EmitValueStructGetterVars(b, "value");
                b.AppendLine("CfxApi.{3}.{0}_get_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutArgument("value"), ApiClassName);
                b.AppendLine("return {0};", sm.MemberType.PublicWrapExpression("value"));
                b.EndBlock();
                b.BeginBlock("set");
                sm.MemberType.EmitPrePublicCallStatements(b, "value");
                b.AppendLine("CfxApi.{3}.{0}_set_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PublicUnwrapExpression("value"), ApiClassName);
                sm.MemberType.EmitPostPublicCallStatements(b, "value");
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();
            }
        }

        b.EndBlock();
    }

    public override void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {

        b.AppendLine();

        EmitRemoteConstructorCalls(b, callIds);

        foreach(var sm in StructMembers) {
            b.BeginRemoteCallClass(ClassName + "Get" + sm.PublicName, false, callIds);
            b.AppendLine("internal IntPtr sender;");
            b.AppendLine("internal {0} value;", sm.MemberType.ProxySymbol);
            b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
            b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
            b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(value); }");
            b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out value); }");
            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
            b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
            b.AppendLine("value = {0};", sm.MemberType.ProxyWrapExpression("sender." + sm.PublicName));
            b.EndBlock();
            b.EndBlock();
            b.BeginRemoteCallClass(ClassName + "Set" + sm.PublicName, false, callIds);
            b.AppendLine("internal IntPtr sender;");
            b.AppendLine("internal {0} value;", sm.MemberType.ProxySymbol);
            b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }");
            b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }");
            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
            b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
            b.AppendLine("sender.{0} = {1};", sm.PublicName, sm.MemberType.ProxyUnwrapExpression("value"));
            b.EndBlock();
            b.EndBlock();
        }
    }


    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.ApiCallbacks);
        b.BeginClass(RemoteClassName + " : CfrStructure", GeneratorConfig.ClassModifiers(RemoteClassName, "public sealed"));
        b.AppendLine();

        EmitRemoteClassWrapperFunction(b);

        b.BeginFunction("CreateRemote", "IntPtr", "", "internal static");
        b.AppendLine("var call = new {0}CtorRenderProcessCall();", ClassName);
        b.AppendLine("call.RequestExecution(CfxRemoteCallContext.CurrentContext.connection);");
        b.AppendLine("return call.__retval;");
        b.EndBlock();

        b.AppendLine();

        b.AppendLine("private {0}(IntPtr proxyId) : base(proxyId) {{}}", RemoteClassName);

        b.BeginBlock("public {0}() : base(CreateRemote())", RemoteClassName);
        b.AppendLine("connection.weakCache.Add(proxyId, this);");
        b.EndBlock();

        b.AppendLine();


        foreach(var sm in StructMembers) {
            if(sm.Name != "size") {
                b.AppendLine("{0} m_{1};", sm.MemberType.RemoteSymbol, sm.PublicName);
                b.AppendLine("bool m_{0}_fetched;", sm.PublicName);
                b.AppendLine();

                b.AppendSummaryAndRemarks(sm.Comments, true);
                b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.RemoteSymbol);
                b.BeginBlock("get");
                b.BeginIf("!m_{0}_fetched", sm.PublicName);
                b.AppendLine("var call = new {0}Get{1}RenderProcessCall();", ClassName, sm.PublicName);
                b.AppendLine("call.sender = this.proxyId;");
                b.AppendLine("call.RequestExecution(this);");
                b.AppendLine("m_{0} = {1};", sm.PublicName, sm.MemberType.RemoteWrapExpression("call.value"));
                b.AppendLine("m_{0}_fetched = true;", sm.PublicName);
                b.EndBlock();
                b.AppendLine("return m_{0};", sm.PublicName);
                b.EndBlock();
                b.BeginBlock("set");
                b.AppendLine("var call = new {0}Set{1}RenderProcessCall();", ClassName, sm.PublicName);
                b.AppendLine("call.sender = this.proxyId;");
                b.AppendLine("call.value = {0};", sm.MemberType.RemoteUnwrapExpression("value"));
                b.AppendLine("call.RequestExecution(this);");
                b.AppendLine("m_{0} = value;", sm.PublicName);
                b.AppendLine("m_{0}_fetched = true;", sm.PublicName);
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();
            }
        }


        b.BeginFunction("OnDispose", "void", "IntPtr proxyId", "internal override");
        b.AppendLine("connection.weakCache.Remove(proxyId);");
        b.EndBlock();

        b.EndBlock();

    }
}
