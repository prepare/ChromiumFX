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


using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class StructMember {
    public readonly ApiType MemberType;

    public readonly string Name;

    public int ApiIndex;

    public readonly CommentData Comments;
    private readonly CefConfigData cefConfig;

    private string cppApiName {
        get {
            if(cefConfig != null) {
                return cefConfig.CppApiName;
            } else {
                return null;
            }
        }
    }

    public StructMember(CefStructType parent, StructCategory structCategory, Parser.StructMemberData smd, ApiTypeBuilder api) {

        Debug.Assert(structCategory == StructCategory.Values);
        Debug.Assert(smd.MemberType != null);

        Name = smd.Name;
        Comments = smd.Comments;
        cefConfig = smd.CefConfig;

        MemberType = api.GetApiType(smd.MemberType, false);
        if(MemberType.Name == "int" && Comments != null) {
            foreach(var c in Comments.Lines) {
                if(c.Contains("true") || c.Contains("false")) {
                    MemberType = BooleanInteger.Convert(MemberType);
                }
            }
        }
    }

    public string PublicName {
        get {
            if(cppApiName != null) {
                return cppApiName;
            } else {
                return CSharp.ApplyStyle(Name);
            }
        }
    }

    public string RemoteCallClassName {
        get { return CSharp.ApplyStyle(Name); }
    }

    public override string ToString() {
        return string.Format("{0} {1}", MemberType, Name);
    }
}

public enum StructCategory {
    Values,
    ApiCalls,
    ApiCallbacks
}

public class CfxClassBuilder {

    private readonly CefStructType cefStruct;
    public readonly CefExportFunction[] ExportFunctions;
    public readonly CefCallbackFunction[] CallbackFunctions;

    public readonly StructMember[] StructMembers;

    private readonly CommentData comments;

    private readonly List<StructProperty> m_structProperties = new List<StructProperty>();

    private readonly List<CefCallbackFunction> m_structFunctions = new List<CefCallbackFunction>();

    public readonly StructCategory Category;
    private readonly string OriginalSymbol;
    private readonly string CfxNativeSymbol;
    private readonly string CfxName;
    private readonly string ClassName;
    private readonly string ApiClassName;

    private readonly string RemoteClassName;

    private readonly bool NeedsWrapping;

    public CfxClassBuilder(CefStructType cefStruct, Parser.StructData sd, ApiTypeBuilder api) {

        this.cefStruct = cefStruct;
        this.OriginalSymbol = cefStruct.OriginalSymbol;
        this.CfxNativeSymbol = cefStruct.CfxNativeSymbol;
        this.CfxName = cefStruct.CfxName;
        this.ClassName = cefStruct.ClassName;
        ApiClassName = ClassName.Substring(3);
        this.RemoteClassName = cefStruct.RemoteClassName;

        this.comments = sd.Comments;

        if(sd.CefConfig != null) {
            switch(sd.CefConfig.Source) {
                case "client":
                    Category = StructCategory.ApiCallbacks;
                    break;

                case "library":
                    Category = StructCategory.ApiCalls;
                    break;

                default:
                    Debug.Assert(false);
                    break;
            }
        } else {
            Debug.Assert(sd.StructMembers.Count == 1 || sd.StructMembers[1].CallbackSignature == null);
            Category = StructCategory.Values;
        }

        Debug.Assert(sd.CefFunctions.Count == 0 || Category == StructCategory.ApiCalls);

        switch(Category) {
            case StructCategory.Values:
                var smlist = new List<StructMember>();
                foreach(var smd in sd.StructMembers) {
                    smlist.Add(new StructMember(cefStruct, Category, smd, api));
                }
                StructMembers = smlist.ToArray();
                NeedsWrapping = GeneratorConfig.ValueStructNeedsWrapping(cefStruct.Name);
                break;
            case StructCategory.ApiCalls:
                var flist = new List<CefExportFunction>();
                foreach(var fd in sd.CefFunctions) {
                    flist.Add(new CefExportFunction(cefStruct, fd, api));
                }
                ExportFunctions = flist.ToArray();
                goto case StructCategory.ApiCallbacks;
            case StructCategory.ApiCallbacks:
                var cblist = new List<CefCallbackFunction>();
                for(int i = 1; i < sd.StructMembers.Count; ++i) {
                    var sm = sd.StructMembers[i];
                    Debug.Assert(sm.CallbackSignature != null);
                    cblist.Add(new CefCallbackFunction(cefStruct, Category, sm.Name, sm.CefConfig, sm.CallbackSignature, api, sm.Comments));
                }
                CallbackFunctions = cblist.ToArray();
                break;
        }

        if(Category == StructCategory.ApiCalls) {
            Category = StructCategory.ApiCalls;
            foreach(var cb in CallbackFunctions) {
                var isBoolean = false;
                if(cb.IsPropertyGetter(ref isBoolean)) {
                    CefCallbackFunction setter = null;
                    foreach(var cb2 in CallbackFunctions) {
                        if(cb2.IsPropertySetterFor(cb)) {
                            setter = cb2;
                            setter.Signature.ManagedArguments[1].IsPropertySetterArgument = true;
                            break;
                        }
                    }
                    var prop = new StructProperty(cb, setter, isBoolean);
                    m_structProperties.Add(prop);
                }
            }
            foreach(var sm in CallbackFunctions) {
                if(!sm.IsProperty) {
                    m_structFunctions.Add(sm);
                }
            }
        }
    }

    public bool IsRefCounted {
        get { return Category != StructCategory.Values; }
    }

    public bool NeedsConstructor {
        get { return Category == StructCategory.Values || Category == StructCategory.ApiCallbacks; }
    }

    public void EmitNativeWrapper(CodeBuilder b) {
        b.AppendComment(cefStruct.Name);
        b.AppendLine();

        switch(Category) {
            case StructCategory.ApiCalls:
                EmitNativeCallStruct(b);
                break;

            case StructCategory.ApiCallbacks:
                EmitNativeCallbackStruct(b);
                break;

            case StructCategory.Values:
                EmitNativeValueStruct(b);
                break;
        }
        b.AppendLine();
    }

    private void EmitNativeCallStruct(CodeBuilder b) {
        foreach(var f in ExportFunctions) {
            f.EmitNativeFunction(b);
        }

        foreach(var cb in CallbackFunctions) {
            b.AppendLine("// {0}", cb);
            b.BeginBlock(cb.Signature.NativeFunctionHeader(CfxName + "_" + cb.Name));
            cb.Signature.EmitNativeCall(b, "self->" + cb.Name);
            b.EndBlock();
            b.AppendLine();
        }
    }

    private void EmitNativeCallbackStruct(CodeBuilder b) {
        
        b.BeginBlock("typedef struct _{0}", CfxNativeSymbol);
        b.AppendLine("{0} {1};", OriginalSymbol, cefStruct.Name);
        b.AppendLine("unsigned int ref_count;");
        b.AppendLine("gc_handle_t gc_handle;");
        b.AppendLine("// managed callbacks");
        foreach(var cb in CallbackFunctions) {
            b.AppendLine("void (CEF_CALLBACK *{0})({1});", cb.Name, cb.Signature.NativeParameterList);
        }
        b.EndBlock("{0};", CfxNativeSymbol);
        b.AppendLine();

        b.BeginBlock("void CEF_CALLBACK _{0}_add_ref(struct _cef_base_t* base)", CfxName);
        b.AppendLine("InterlockedIncrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.EndBlock();
        b.BeginBlock("int CEF_CALLBACK _{0}_release(struct _cef_base_t* base)", CfxName);
        b.AppendLine("int count = InterlockedDecrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.BeginBlock("if(!count)");
        b.AppendLine("cfx_gc_handle_free((({0}*)base)->gc_handle);", CfxNativeSymbol);
        b.AppendLine("free(base);");
        b.AppendLine("return 1;");
        b.EndBlock();
        b.AppendLine("return 0;");
        b.EndBlock();
        b.BeginBlock("int CEF_CALLBACK _{0}_has_one_ref(struct _cef_base_t* base)", CfxName);
        b.AppendLine("return (({0}*)base)->ref_count == 1 ? 1 : 0;", CfxNativeSymbol);
        b.EndBlock();
        b.AppendLine();

        b.BeginBlock("static {0}* {1}_ctor(gc_handle_t gc_handle)", CfxNativeSymbol, CfxName);
        b.AppendLine("{0}* ptr = ({0}*)calloc(1, sizeof({0}));", CfxNativeSymbol);
        b.AppendLine("if(!ptr) return 0;");
        b.AppendLine("ptr->{0}.base.size = sizeof({1});", cefStruct.Name, OriginalSymbol);
        b.AppendLine("ptr->{0}.base.add_ref = _{1}_add_ref;", cefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.release = _{1}_release;", cefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.has_one_ref = _{1}_has_one_ref;", cefStruct.Name, CfxName);
        b.AppendLine("ptr->ref_count = 1;");
        b.AppendLine("ptr->gc_handle = gc_handle;");
        b.AppendLine("return ptr;");
        b.EndBlock();
        b.AppendLine();
        b.BeginBlock("static gc_handle_t {0}_get_gc_handle({1}* self)", CfxName, CfxNativeSymbol);
        b.AppendLine("return self->gc_handle;");
        b.EndBlock();
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {

            b.AppendLine("// {0}", cb);
            b.AppendLine();

            b.BeginBlock("{0} CEF_CALLBACK {1}({2})", cb.NativeReturnType.OriginalSymbol, cb.NativeCallbackName, cb.Signature.OriginalParameterList);
            if(!cb.NativeReturnType.IsVoid) {
                b.AppendLine("{0} __retval;", cb.NativeReturnType.NativeSymbol);
            }

            foreach(var arg in cb.Signature.Arguments) {
                arg.EmitPreNativeCallbackStatements(b);
            }

            b.AppendLine("(({0}_t*)self)->{1}({2});", CfxName, cb.Name, cb.Signature.NativeArgumentList);

            foreach(var arg in cb.Signature.Arguments) {
                arg.EmitPostNativeCallbackStatements(b);
            }

            cb.NativeReturnType.EmitNativeCallbackReturnStatements(b, "__retval");

            b.EndBlock();
            b.AppendLine();

        }

        b.BeginBlock("static void {0}_set_callback({1}* self, int index, void* callback)", CfxName, OriginalSymbol);
        b.BeginBlock("switch(index)");
        var index = 0;
        foreach(var cb in CallbackFunctions) {
            b.DecreaseIndent();
            b.AppendLine("case {0}:", index);
            b.IncreaseIndent();
            b.AppendLine("(({0}_t*)self)->{1} = (void (CEF_CALLBACK *)({2}))callback;", CfxName, cb.Name, cb.Signature.NativeParameterList);
            b.AppendLine("self->{0} = callback ? {1} : 0;", cb.Name, cb.NativeCallbackName);
            b.AppendLine("break;");

            index += 1;
        }
        b.EndBlock();
        b.EndBlock();
    }

    public void EmitNativeValueStruct(CodeBuilder b) {
        
        if(cefStruct.IsCefPlatformStructType) {
            b.AppendLine("#ifdef CFX_" + cefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
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
                b.AppendComment("{0}->{1}", cefStruct.OriginalSymbol, sm.Name);
                b.BeginBlock("static void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                sm.MemberType.EmitAssignToNativeStructMember(b, sm.Name);
                b.EndBlock();
                b.BeginBlock("static void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
                sm.MemberType.EmitAssignFromNativeStructMember(b, sm.Name);
                b.EndBlock();
                b.AppendLine();
            }
        }

        if(cefStruct.IsCefPlatformStructType) {
            b.AppendLine("#else //ifdef CFX_" + cefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine("#define {0}_ctor 0", CfxName);
            b.AppendLine("#define {0}_dtor 0", CfxName);
            foreach(var sm in StructMembers) {
                if(sm.Name != "size") {
                    b.AppendLine("#define {0}_set_{1} 0", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                    b.AppendLine("#define {0}_get_{1} 0", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
                }
            }
            b.AppendLine("#endif //ifdef CFX_" + cefStruct.AsCefPlatformStructType.Platform.ToString().ToUpper());
            b.AppendLine();
        }
    }

    public void EmitApiDeclarations(CodeBuilder b) {

        b.BeginClass(ClassName.Substring(3), "internal static");
        b.AppendLine();

        b.BeginBlock("static {0} ()", ApiClassName);
        b.AppendLine("CfxApiLoader.Load{0}Api();", ClassName);
        b.EndBlock();
        b.AppendLine();

        switch(Category) {
            case StructCategory.Values:

                b.AppendComment("static {0}* {1}_ctor()", OriginalSymbol, CfxName);
                b.AppendLine("public static cfx_ctor_delegate {0}_ctor;", CfxName);
                b.AppendComment("static void {1}_dtor({0}* ptr)", OriginalSymbol, CfxName);
                b.AppendLine("public static cfx_dtor_delegate {0}_dtor;", CfxName);
                b.AppendLine();

                foreach(var sm in StructMembers) {
                    if(sm.Name != "size") {
                        b.AppendComment("static void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeCallParameter(sm.Name, false));
                        b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]");
                        b.AppendLine("public delegate void {0}_set_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeCallParameter(sm.Name));
                        b.AppendLine("public static {0}_set_{1}_delegate {0}_set_{1};", CfxName, sm.Name);
                        b.AppendComment("static void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, cefStruct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name));
                        b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]");
                        b.AppendLine("public delegate void {0}_get_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutSignature(sm.Name));
                        b.AppendLine("public static {0}_get_{1}_delegate {0}_get_{1};", CfxName, sm.Name);
                        b.AppendLine();
                    }
                }

                break;

            case StructCategory.ApiCalls:

                if(ExportFunctions.Length > 0) {
                    foreach(var f in this.ExportFunctions) {
                        f.EmitPInvokeDeclaration(b);
                    }
                    b.AppendLine();
                }

                foreach(var cb in CallbackFunctions) {
                    b.AppendComment(cb.Signature.NativeFunctionHeader(CfxName + "_" + cb.Name));
                    CodeSnippets.EmitPInvokeDelegate(b, CfxName + "_" + cb.Name, cb.Signature);
                    b.AppendLine();
                }

                break;

            case StructCategory.ApiCallbacks:

                if(Category == StructCategory.ApiCallbacks) {
                    b.AppendLine("public static cfx_ctor_with_gc_handle_delegate {0}_ctor;", CfxName);
                    b.AppendLine("public static cfx_get_gc_handle_delegate {0}_get_gc_handle;", CfxName);
                    b.AppendLine("public static cfx_set_callback_delegate {0}_set_callback;", CfxName);
                    b.AppendLine();
                }

                break;
        }

        b.EndBlock();
    }

    public void EmitPublicClass(CodeBuilder b) {
        switch(Category) {
            case StructCategory.ApiCalls:
                EmitPublicCallClass(b);
                break;

            case StructCategory.ApiCallbacks:
                EmitPublicCallbackClass(b);
                break;

            case StructCategory.Values:
                EmitPublicValueClass(b);
                break;
        }
    }

    public void EmitPublicCallClass(CodeBuilder b) {
        b.AppendSummaryAndRemarks(comments);

        b.BeginClass(ClassName + " : CfxLibraryBase", GeneratorConfig.ClassModifiers(ClassName));
        b.AppendLine();

        b.AppendLine("private static readonly WeakCache weakCache = new WeakCache();");
        b.AppendLine();
        b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static");
        b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
        b.BeginBlock("lock(weakCache)");
        b.AppendLine("var wrapper = ({0})weakCache.Get(nativePtr);", ClassName);
        b.BeginBlock("if(wrapper == null)");
        b.AppendLine("wrapper = new {0}(nativePtr);", ClassName);
        b.AppendLine("weakCache.Add(wrapper);");
        b.BeginElse();
        //release the new ref and reuse the existing ref
        b.AppendLine("CfxApi.cfx_release(nativePtr);");
        b.EndBlock();
        b.AppendLine("return wrapper;");
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();

        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);

        b.AppendLine();

        foreach(var f in ExportFunctions) {
            f.EmitPublicFunction(b);
            b.AppendLine();
        }

        foreach(var p in m_structProperties) {
            if(p.Setter != null && p.Setter.Comments != null) {
                var summary = new CommentData();
                summary.FileName = p.Getter.Comments.FileName;

                if(p.Getter.Comments.Lines.Length == 1 && p.Setter.Comments.Lines.Length == 1 && p.Getter.Comments.Lines[0].StartsWith("Get ") && p.Setter.Comments.Lines[0].StartsWith("Set ") && p.Getter.Comments.Lines[0].Substring(4).Equals(p.Setter.Comments.Lines[0].Substring(4))) {
                    summary.Lines = new string[] { "Get or set " + p.Getter.Comments.Lines[0].Substring(4) };
                } else {
                    List<string> summaryLines = new List<string>();
                    summaryLines.AddRange(p.Getter.Comments.Lines);
                    summaryLines.Add("");
                    summaryLines.AddRange(p.Setter.Comments.Lines);
                    summary.Lines = summaryLines.ToArray();
                }

                b.AppendSummaryAndRemarks(summary);
            } else {
                b.AppendSummaryAndRemarks(p.Getter.Comments);
            }
            p.Getter.EmitPublicProperty(b, p.Setter == null ? null : p.Setter);
            b.AppendLine();
        }

        foreach(var sf in m_structFunctions) {
            b.AppendSummaryAndRemarks(sf.Comments);
            sf.EmitPublicFunction(b);
            b.AppendLine();
        }

        b.BeginFunction("OnDispose", "void", "IntPtr nativePtr", "internal override");
        b.AppendLine("weakCache.Remove(nativePtr);");
        b.AppendLine("base.OnDispose(nativePtr);");
        b.EndBlock();

        b.EndBlock();
    }

    public void EmitPublicCallbackClass(CodeBuilder b) {
        b.AppendLine("using Event;");
        b.AppendLine();

        b.AppendSummaryAndRemarks(comments, false, true);

        b.BeginClass(ClassName + " : CfxClientBase", GeneratorConfig.ClassModifiers(ClassName));
        b.AppendLine();

        b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static");
        b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
        b.AppendLine("var handlePtr = CfxApi.{0}.{1}_get_gc_handle(nativePtr);", ApiClassName, CfxName);
        b.AppendLine("return ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;", ClassName);
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();

        b.AppendLine("private static object eventLock = new object();");
        b.AppendLine();

        b.BeginBlock("internal static void SetNativeCallbacks()");

        foreach(var sm in CallbackFunctions) {
            b.AppendLine("{0}_native = {0};", sm.Name);
        }
        b.AppendLine();
        foreach(var sm in CallbackFunctions) {
            b.AppendLine("{0}_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate({0}_native);", sm.Name);
        }

        b.EndBlock();
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {

            var sig = cb.Signature;

            b.AppendComment(cb.ToString());
            CodeSnippets.EmitPInvokeCallbackDelegate(b, cb.Name, cb.Signature);
            b.AppendLine("private static {0}_delegate {0}_native;", cb.Name);
            b.AppendLine("private static IntPtr {0}_native_ptr;", cb.Name);
            b.AppendLine();

            b.BeginFunction(cb.Name, "void", sig.PInvokeParameterList, "internal static");
            //b.AppendLine("var handle = System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr);")
            b.AppendLine("var self = ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;", ClassName);
            b.BeginIf("self == null || self.CallbacksDisabled");
            if(!sig.ReturnType.IsVoid) {
                b.AppendLine("__retval = default({0});", sig.ReturnType.PInvokeSymbol);
            }
            foreach(var arg in sig.Arguments) {
                if(arg.ArgumentType.IsOut && !arg.ArgumentType.IsIn) {
                    arg.ArgumentType.EmitSetPInvokeParamToDefaultStatements(b, arg.VarName);
                }
            }
            b.AppendLine("return;");
            b.EndBlock();
            b.AppendLine("var e = new {0}({1});", cb.PublicEventArgsClassName, sig.PublicEventConstructorParameterList);
            b.AppendLine("self.m_{0}?.Invoke(self, e);", cb.PublicName);
            b.AppendLine("e.m_isInvalid = true;");

            sig.EmitPostPublicEventHandlerCallStatements(b);

            b.EndBlock();
            b.AppendLine();
        }

        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);
        b.AppendLine("public {0}() : base(CfxApi.{1}.{2}_ctor) {{}}", ClassName, ApiClassName, CfxName);
        b.AppendLine();

        var cbIndex = 0;
        foreach(var cb in CallbackFunctions) {
            cb.EmitPublicEvent(b, cbIndex, cb.Comments);
            b.AppendLine();
            cbIndex += 1;
        }

        b.BeginFunction("OnDispose", "void", "IntPtr nativePtr", "internal override");
        cbIndex = 0;
        foreach(var cb in CallbackFunctions) {
            b.BeginIf("m_{0} != null", cb.PublicName);
            b.AppendLine("m_{0} = null;", cb.PublicName);
            b.AppendLine("CfxApi.{0}.{1}_set_callback(NativePtr, {2}, IntPtr.Zero);", ApiClassName, CfxName, cbIndex);
            b.EndBlock();
            cbIndex += 1;
        }
        b.AppendLine("base.OnDispose(nativePtr);");
        b.EndBlock();

        b.EndBlock();

        b.AppendLine();
        b.AppendLine();
        EmitPublicEventArgs(b);
    }

    public void EmitPublicValueClass(CodeBuilder b) {
        //asserts

        foreach(var sm in StructMembers) {
            if(sm.MemberType.IsCefStructPtrType) {
                System.Diagnostics.Debugger.Break();
            }
            if(sm.MemberType.IsCefStructType && sm.MemberType.AsCefStructType.ClassBuilder.IsRefCounted) {
                System.Diagnostics.Debugger.Break();
            }
        }

        b.AppendSummaryAndRemarks(comments);

        if(cefStruct.IsCefPlatformStructType) {
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

        if(cefStruct.IsCefPlatformStructType) {
            b.AppendLine("public {0}() : base(CfxApi.{1}.{2}_ctor, CfxApi.{1}.{2}_dtor) {{ CfxApi.CheckPlatformOS(CfxPlatformOS.{3}); }}", ClassName, ApiClassName, CfxName, cefStruct.AsCefPlatformStructType.Platform.ToString());
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

    public void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {
        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine("using Event;");
            b.AppendLine("using Chromium.Event;");
        }

        b.AppendLine();

        if(NeedsConstructor) {
            b.BeginRemoteCallClass(ClassName + "Ctor", false, callIds);
            b.AppendLine();
            b.AppendLine("internal IntPtr __retval;");
            b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }");
            b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }");
            b.AppendLine();
            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
            b.AppendLine("__retval = RemoteProxy.Wrap(new {0}());", ClassName);
            b.EndBlock();
            b.EndBlock();
            b.AppendLine();
        }

        if(Category == StructCategory.Values) {
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
        } else if(Category == StructCategory.ApiCallbacks) {
            foreach(var cb in CallbackFunctions) {

                if(!GeneratorConfig.IsBrowserProcessOnly(cefStruct.Name + "::" + cb.Name)) {

                    var sig = cb.Signature;

                    b.BeginRemoteCallClass(cb.EventName, true, callIds);
                    b.AppendLine();

                    b.BeginBlock("internal static void EventCall(object sender, {0} e)", cb.PublicEventArgsClassName);
                    b.AppendLine("var call = new {0}BrowserProcessCall();", cb.EventName);
                    b.AppendLine("call.sender = RemoteProxy.Wrap((CfxBase)sender);");
                    b.AppendLine("call.eventArgsId = AddEventArgs(e);");
                    b.AppendLine("call.RequestExecution(RemoteClient.connection);");
                    b.AppendLine("RemoveEventArgs(call.eventArgsId);");
                    b.EndBlock();

                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                    b.AppendLine("var sender = {0}.Wrap(this.sender);", RemoteClassName);
                    b.AppendLine("var e = new {0}(eventArgsId);", cb.RemoteEventArgsClassName);
                    b.AppendLine("sender.raise_{0}(sender, e);", cb.PublicName);
                    b.EndBlock();
                    b.EndBlock();
                    b.AppendLine();

                    b.BeginRemoteCallClass(cb.EventName + "Activate", false, callIds);
                    b.AppendLine();
                    b.AppendLine("internal IntPtr sender;");
                    b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
                    b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
                    b.AppendLine();
                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                    b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
                    b.AppendLine("sender.{0} += {1}BrowserProcessCall.EventCall;", cb.PublicName, cb.EventName);
                    b.EndBlock();
                    b.EndBlock();
                    b.AppendLine();

                    b.BeginRemoteCallClass(cb.EventName + "Deactivate", false, callIds);
                    b.AppendLine();
                    b.AppendLine("internal IntPtr sender;");
                    b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
                    b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
                    b.AppendLine();
                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                    b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
                    b.AppendLine("sender.{0} -= {1}BrowserProcessCall.EventCall;", cb.PublicName, cb.EventName);
                    b.EndBlock();
                    b.EndBlock();
                    b.AppendLine();

                    for(var ii = 1; ii <= sig.ManagedArguments.Length - 1; ii++) {
                        var arg = sig.ManagedArguments[ii];
                        if(arg.ArgumentType.IsOut) {
                            b.BeginRemoteCallClass(cb.EventName + "Set" + arg.PublicPropertyName, false, callIds);
                            b.AppendLine();
                            b.AppendLine("internal ulong eventArgsId;");
                            arg.ArgumentType.EmitRemoteCallFields(b, "value");
                            b.AppendLine();

                            b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
                            b.AppendLine("h.Write(eventArgsId);");
                            arg.ArgumentType.EmitRemoteWrite(b, "value");
                            b.EndBlock();

                            b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
                            b.AppendLine("h.Read(out eventArgsId);");
                            arg.ArgumentType.EmitRemoteRead(b, "value");
                            b.EndBlock();

                            b.AppendLine();
                            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                            b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                            arg.EmitProxyEventArgSetter(b);
                            b.EndBlock();

                            b.EndBlock();
                            b.AppendLine();
                        }
                        if(arg.ArgumentType.IsIn) {
                            b.BeginRemoteCallClass(cb.EventName + "Get" + arg.PublicPropertyName, false, callIds);
                            b.AppendLine();

                            b.AppendLine("internal ulong eventArgsId;");
                            arg.ArgumentType.EmitRemoteCallFields(b, "value");
                            b.AppendLine();

                            b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
                            b.AppendLine("h.Write(eventArgsId);");
                            b.EndBlock();

                            b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
                            b.AppendLine("h.Read(out eventArgsId);");
                            b.EndBlock();

                            b.BeginBlock("protected override void WriteReturn(StreamHandler h)");
                            arg.ArgumentType.EmitRemoteWrite(b, "value");
                            b.EndBlock();

                            b.BeginBlock("protected override void ReadReturn(StreamHandler h)");
                            arg.ArgumentType.EmitRemoteRead(b, "value");
                            b.EndBlock();

                            b.AppendLine();

                            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                            b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                            b.AppendLine("value = {0};", arg.ArgumentType.ProxyWrapExpression("e." + arg.PublicPropertyName));
                            b.EndBlock();

                            b.EndBlock();
                            b.AppendLine();
                        }
                    }

                    if(!sig.PublicReturnType.IsVoid) {
                        b.BeginRemoteCallClass(cb.EventName + "SetReturnValue", false, callIds);
                        b.AppendLine();
                        b.AppendLine("internal ulong eventArgsId;");
                        sig.PublicReturnType.EmitRemoteCallFields(b, "value");
                        b.AppendLine();

                        b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
                        b.AppendLine("h.Write(eventArgsId);");
                        sig.PublicReturnType.EmitRemoteWrite(b, "value");
                        b.EndBlock();

                        b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
                        b.AppendLine("h.Read(out eventArgsId);");
                        sig.PublicReturnType.EmitRemoteRead(b, "value");
                        b.EndBlock();

                        b.AppendLine();
                        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                        b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                        b.AppendLine("e.SetReturnValue({0});", sig.PublicReturnType.ProxyUnwrapExpression("value"));
                        b.EndBlock();

                        b.EndBlock();
                        b.AppendLine();
                    }
                }
            }
        } else {
            foreach(var f in ExportFunctions) {
                if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                    if(!f.PrivateWrapper) {
                        b.BeginRemoteCallClass(ClassName + f.PublicName, false, callIds);
                        f.Signature.EmitRemoteCallClassBody(b);
                        b.EndBlock();
                        b.AppendLine();
                    }
                }
            }

            foreach(var cb in CallbackFunctions) {
                if(!GeneratorConfig.IsBrowserProcessOnly(cefStruct.Name + "::" + cb.Name)) {
                    b.BeginRemoteCallClass(ClassName + cb.RemoteCallClassName, false, callIds);
                    cb.Signature.EmitRemoteCallClassBody(b);
                    b.EndBlock();
                    b.AppendLine();
                }
            }
        }
    }

    public void EmitRemoteClass(CodeBuilder b) {
        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine("using Event;");
        }

        b.AppendLine();

        b.AppendSummaryAndRemarks(comments, true, Category == StructCategory.ApiCallbacks);
        if(IsRefCounted) {
            b.BeginClass(RemoteClassName + " : CfrBase", GeneratorConfig.ClassModifiers(RemoteClassName));
        } else {
            b.BeginClass(RemoteClassName + " : CfrStructure", GeneratorConfig.ClassModifiers(RemoteClassName, "public sealed"));
        }
        b.AppendLine();

        b.BeginFunction("Wrap", RemoteClassName, "IntPtr proxyId", "internal static");
        b.AppendLine("if(proxyId == IntPtr.Zero) return null;");
        b.AppendLine("var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;");
        b.BeginBlock("lock(weakCache)");
        b.AppendLine("var cfrObj = ({0})weakCache.Get(proxyId);", RemoteClassName);
        b.BeginBlock("if(cfrObj == null)");
        b.AppendLine("cfrObj = new {0}(proxyId);", RemoteClassName);
        b.AppendLine("weakCache.Add(proxyId, cfrObj);");
        b.EndBlock();
        b.AppendLine("return cfrObj;");
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();

        if(NeedsConstructor) {
            b.BeginFunction("CreateRemote", "IntPtr", "", "internal static");
            b.AppendLine("var call = new {0}CtorRenderProcessCall();", ClassName);
            b.AppendLine("call.RequestExecution(CfxRemoteCallContext.CurrentContext.connection);");
            b.AppendLine("return call.__retval;");
            b.EndBlock();
        }

        if(Category ==  StructCategory.ApiCalls) {
            foreach(var f in ExportFunctions) {
                if(!GeneratorConfig.IsBrowserProcessOnly(f.Name) && !f.PrivateWrapper) {
                    f.EmitRemoteFunction(b);
                    b.AppendLine();
                }
            }
        }

        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine();

            foreach(var cb in CallbackFunctions) {
                if(!GeneratorConfig.IsBrowserProcessOnly(cefStruct.Name + "::" + cb.Name)) {
                    cb.EmitRemoteRaiseEventFunction(b, cb.Comments);
                }
            }
        }

        b.AppendLine();

        b.AppendLine("private {0}(IntPtr proxyId) : base(proxyId) {{}}", RemoteClassName);

        if(NeedsConstructor) {
            b.BeginBlock("public {0}() : base(CreateRemote())", RemoteClassName);
            b.AppendLine("connection.weakCache.Add(proxyId, this);");
            b.EndBlock();
        }

        b.AppendLine();

        switch(Category) {
            case StructCategory.ApiCallbacks:

                foreach(var cb in CallbackFunctions) {
                    if(!GeneratorConfig.IsBrowserProcessOnly(cefStruct.Name + "::" + cb.Name)) {
                        cb.EmitRemoteEvent(b, cb.Comments);
                        b.AppendLine();
                    }
                }

                break;

            case StructCategory.ApiCalls:

                foreach(var p in m_structProperties) {
                    if(GeneratorConfig.CreateRemoteProxy(cefStruct.Name + "::" + p.Getter.Name)) {
                        var cb = p.Getter;

                        if(p.Setter != null && p.Setter.Comments != null) {
                            List<string> summaryLines = new List<string>();
                            summaryLines.AddRange(p.Getter.Comments.Lines);
                            summaryLines.Add("");
                            summaryLines.AddRange(p.Setter.Comments.Lines);
                            var summary = new CommentData();
                            summary.Lines = summaryLines.ToArray();
                            summary.FileName = p.Getter.Comments.FileName;
                            //If RemoteClassName = "CfrRequest" AndAlso p.Getter.PublicName = "GetFlags" Then Stop
                            b.AppendSummaryAndRemarks(summary, true);
                        } else {
                            b.AppendSummaryAndRemarks(p.Getter.Comments, true);
                        }

                        b.BeginBlock("public {0} {1}", cb.RemoteReturnType.RemoteSymbol, p.PropertyName);
                        b.BeginBlock("get");
                        p.Getter.Signature.EmitRemoteCall(b);
                        b.EndBlock();
                        if(p.Setter != null) {
                            b.BeginBlock("set");
                            p.Setter.Signature.EmitRemoteCall(b);
                            b.EndBlock();
                        }
                        b.EndBlock();
                        b.AppendLine();
                    }
                }

                foreach(var cb in m_structFunctions) {
                    if(GeneratorConfig.CreateRemoteProxy(cefStruct.Name + "::" + cb.Name)) {
                        b.AppendSummaryAndRemarks(cb.Comments, true);
                        b.BeginFunction(cb.PublicName, cb.RemoteReturnType.RemoteSymbol, cb.Signature.RemoteParameterList);
                        cb.Signature.EmitRemoteCall(b);
                        b.EndBlock();
                        b.AppendLine();
                    }
                }

                break;

            case StructCategory.Values:

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

                break;
        }

        b.BeginFunction("OnDispose", "void", "IntPtr proxyId", "internal override");
        b.AppendLine("connection.weakCache.Remove(proxyId);");
        b.EndBlock();

        b.EndBlock();

        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine();
            b.BeginBlock("namespace Event");
            b.AppendLine();
            EmitRemoteEventArgs(b);
            b.EndBlock();
        }
    }

    public void EmitPublicEventArgs(CodeBuilder b) {
        b.BeginBlock("namespace Event");
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            cb.EmitPublicEventArgsAndHandler(b, cb.Comments);
            b.AppendLine();
        }

        b.EndBlock();
    }

    public void EmitRemoteEventArgs(CodeBuilder b) {
        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(cefStruct.Name + "::" + cb.Name)) {
                cb.EmitRemoteEventArgsAndHandler(b, cb.Comments);
                b.AppendLine();
            }
        }
    }
}
