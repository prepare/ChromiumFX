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

public class CfxClientClass : CfxClass {

    public CfxClientClass(CefStructType cefStruct, Parser.StructNode sd, ApiTypeBuilder api)
        : base(cefStruct, sd, api) {
        GetCallbackFunctions(sd, api);
    }

    public override void EmitNativeWrapper(CodeBuilder b) {

        b.AppendComment(CefStruct.Name);
        b.AppendLine();

        b.BeginBlock("typedef struct _{0}", CfxNativeSymbol);
        b.AppendLine("{0} {1};", OriginalSymbol, CefStruct.Name);
        b.AppendLine("unsigned int ref_count;");
        b.AppendLine("gc_handle_t gc_handle;");
        b.AppendLine("int wrapper_kind;");
        b.AppendLine("// managed callbacks");
        foreach(var cb in CallbackFunctions) {
            b.AppendLine("void (CEF_CALLBACK *{0})({1});", cb.Name, cb.Signature.NativeParameterList);
        }
        b.EndBlock("{0};", CfxNativeSymbol);
        b.AppendLine();

        b.BeginBlock("void CEF_CALLBACK _{0}_add_ref(struct _cef_base_ref_counted_t* base)", CfxName);
        b.AppendLine("InterlockedIncrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.EndBlock();
        b.BeginBlock("int CEF_CALLBACK _{0}_release(struct _cef_base_ref_counted_t* base)", CfxName);
        b.AppendLine("int count = InterlockedDecrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.BeginIf("count == 0");
        b.BeginIf("(({0}*)base)->wrapper_kind == 0", CfxNativeSymbol);
        b.AppendLine("cfx_gc_handle_free((({0}*)base)->gc_handle);", CfxNativeSymbol);
        b.BeginElse();
        b.AppendLine("cfx_gc_handle_free_remote((({0}*)base)->gc_handle);", CfxNativeSymbol);
        b.EndBlock();
        b.AppendLine("free(base);");
        b.AppendLine("return 1;");
        b.EndBlock();
        b.AppendLine("return 0;");
        b.EndBlock();
        b.BeginBlock("int CEF_CALLBACK _{0}_has_one_ref(struct _cef_base_ref_counted_t* base)", CfxName);
        b.AppendLine("return (({0}*)base)->ref_count == 1 ? 1 : 0;", CfxNativeSymbol);
        b.EndBlock();
        b.AppendLine();

        b.BeginBlock("static {0}* {1}_ctor(gc_handle_t gc_handle, int wrapper_kind)", CfxNativeSymbol, CfxName);
        b.AppendLine("{0}* ptr = ({0}*)calloc(1, sizeof({0}));", CfxNativeSymbol);
        b.AppendLine("if(!ptr) return 0;");
        b.AppendLine("ptr->{0}.base.size = sizeof({1});", CefStruct.Name, OriginalSymbol);
        b.AppendLine("ptr->{0}.base.add_ref = _{1}_add_ref;", CefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.release = _{1}_release;", CefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.has_one_ref = _{1}_has_one_ref;", CefStruct.Name, CfxName);
        b.AppendLine("ptr->ref_count = 1;");
        b.AppendLine("ptr->gc_handle = gc_handle;");
        b.AppendLine("ptr->wrapper_kind = wrapper_kind;");
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

            foreach(var arg in cb.Signature.Parameters) {
                arg.EmitPreNativeCallbackStatements(b);
            }

            b.AppendLine("(({0}_t*)self)->{1}({2});", CfxName, cb.Name, cb.Signature.NativeArgumentList);

            foreach(var arg in cb.Signature.Parameters) {
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
            cb.ClientCallbackIndex = index;
            index += 1;
        }
        b.EndBlock();
        b.EndBlock();

        b.AppendLine();
    }

    protected override void EmitApiDeclarations(CodeBuilder b) {
        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine("public static cfx_ctor_with_gc_handle_delegate {0}_ctor;", CfxName);
            b.AppendLine("public static cfx_get_gc_handle_delegate {0}_get_gc_handle;", CfxName);
            b.AppendLine("public static cfx_set_callback_delegate {0}_set_callback;", CfxName);
            b.AppendLine();
        }
    }

    public override void EmitPublicClass(CodeBuilder b) {

        b.AppendLine("using Event;");
        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, false, true);

        b.BeginClass(ClassName + " : CfxBaseClient", GeneratorConfig.ClassModifiers(ClassName));
        b.AppendLine();

        if(NeedsWrapFunction) {
            b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static");
            b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
            b.AppendLine("var handlePtr = CfxApi.{0}.{1}_get_gc_handle(nativePtr);", ApiClassName, CfxName);
            b.AppendLine("return ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;", ClassName);
            b.EndBlock();
            b.AppendLine();
            b.AppendLine();
        }

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
            foreach(var arg in sig.Parameters) {
                if(!arg.IsThisArgument)
                    arg.ParameterType.EmitSetCallbackArgumentToDefaultStatements(b, arg.VarName);
            }
            b.AppendLine("return;");
            b.EndBlock();
            b.AppendLine("var e = new {0}({1});", cb.PublicEventArgsClassName, sig.PublicEventConstructorArguments);
            b.AppendLine("self.m_{0}?.Invoke(self, e);", cb.PublicName);
            b.AppendLine("e.m_isInvalid = true;");

            for(var i = 1; i <= sig.ManagedParameters.Count() - 1; i++) {
                sig.ManagedParameters[i].EmitPostPublicRaiseEventStatements(b);
            }

            sig.EmitPostPublicEventHandlerReturnValueStatements(b);

            b.EndBlock();
            b.AppendLine();
        }

        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);
        b.AppendLine("public {0}() : base(CfxApi.{1}.{2}_ctor) {{}}", ClassName, ApiClassName, CfxName);
        b.AppendLine();

        var cbIndex = 0;
        foreach(var cb in CallbackFunctions) {
            EmitPublicEvent(b, cbIndex, cb);
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

        b.BeginBlock("namespace Event");
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            EmitPublicEventArgsAndHandler(b, cb);
            b.AppendLine();
        }

        b.EndBlock();
    }

    private void EmitPublicEvent(CodeBuilder b, int cbIndex, CefCallbackFunction cb) {

        var isSimpleGetterEvent = cb.Signature.ManagedParameters.Length == 1
            && cb.Signature.ReturnType.IsCefStructPtrType;

        b.AppendSummaryAndRemarks(cb.Comments, false, true);
        b.BeginBlock("public event {0} {1}", cb.EventHandlerName, CSharp.Escape(cb.PublicName));
        b.BeginBlock("add");
        b.BeginBlock("lock(eventLock)");
        if(isSimpleGetterEvent) {
            b.BeginBlock("if(m_{0} != null)", cb.PublicName);
            b.AppendLine("throw new CfxException(\"Can't add more than one event handler to this type of event.\");");
            b.EndBlock();
        } else {
            b.BeginBlock("if(m_{0} == null)", cb.PublicName);
        }
        b.AppendLine("CfxApi.{3}.{0}_set_callback(NativePtr, {1}, {2}_native_ptr);", CefStruct.CfxName, cbIndex, cb.Name, CefStruct.ClassName.Substring(3));
        if(!isSimpleGetterEvent) b.EndBlock();
        b.AppendLine("m_{0} += value;", cb.PublicName);
        b.EndBlock();
        b.EndBlock();
        b.BeginBlock("remove");
        b.BeginBlock("lock(eventLock)");
        b.AppendLine("m_{0} -= value;", cb.PublicName);
        b.BeginBlock("if(m_{0} == null)", cb.PublicName);
        b.AppendLine("CfxApi.{2}.{0}_set_callback(NativePtr, {1}, IntPtr.Zero);", CefStruct.CfxName, cbIndex, CefStruct.ClassName.Substring(3));
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        if(isSimpleGetterEvent) {
            b.AppendLine("/// <summary>");
            b.AppendLine("/// Retrieves the {0} provided by the event handler attached to the {1} event, if any.", cb.Signature.ReturnType.PublicSymbol, CSharp.Escape(cb.PublicName));
            b.AppendLine("/// Returns null if no event handler is attached.");
            b.AppendLine("/// </summary>");
            b.BeginBlock("public {0} Retrieve{1}()", cb.Signature.ReturnType.PublicSymbol, cb.Signature.ReturnType.PublicSymbol.Substring(3));
            b.AppendLine("var h = m_{0};", cb.PublicName);
            b.BeginIf("h != null");
            b.AppendLine("var e = new {0}();", cb.PublicEventArgsClassName);
            b.AppendLine("h(this, e);");
            b.AppendLine("return e.m_returnValue;");
            b.BeginElse();
            b.AppendLine("return null;");
            b.EndBlock();
            b.EndBlock();
            b.AppendLine();
        }

        b.AppendLine("private {0} m_{1};", cb.EventHandlerName, cb.PublicName);
    }

    
    private bool ShouldEmitEventHandler(Dictionary<string, CommentNode> emittedHandlers, CefCallbackFunction cb) {
        if(emittedHandlers.ContainsKey(cb.EventName)) {
            var c0 = emittedHandlers[cb.EventName];
            if(c0 != null) {
                if(c0.Lines.Length != cb.Comments.Lines.Length) {
                    System.Diagnostics.Debugger.Break();
                }
                for(var i = 0; i <= c0.Lines.Length - 1; i++) {
                    if(c0.Lines[i] != cb.Comments.Lines[i]) {
                        // two handlers use same event but with different cb.Comments
                        System.Diagnostics.Debugger.Break();
                    }
                }
            }
            return false;
        }
        emittedHandlers.Add(cb.EventName, cb.Comments);
        return true;
    }

    private static Dictionary<string, CommentNode> emittedPublicHandlers = new Dictionary<string, CommentNode>();

    private void EmitPublicEventArgsAndHandler(CodeBuilder b, CefCallbackFunction cb) {

        if(cb.IsBasicEvent)
            return;

        if(!ShouldEmitEventHandler(emittedPublicHandlers, cb)) return;

        b.AppendSummaryAndRemarks(cb.Comments, false, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", cb.EventHandlerName, cb.PublicEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(cb.Comments, false, true);
        b.BeginClass(cb.PublicEventArgsClassName + " : CfxEventArgs", GeneratorConfig.ClassModifiers(cb.PublicEventArgsClassName));
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedParameters.Count() - 1; i++) {
            cb.Signature.ManagedParameters[i].EmitPublicEventArgFields(b);
        }
        b.AppendLine();

        if(!cb.Signature.PublicReturnType.IsVoid) {
            b.AppendLine("internal {0} m_returnValue;", cb.Signature.PublicReturnType.PublicSymbol);
            b.AppendLine("private bool returnValueSet;");
            b.AppendLine();
        }

        b.BeginBlock("internal {0}({1})", cb.PublicEventArgsClassName, cb.Signature.PublicEventConstructorParameters);
        cb.Signature.EmitPublicEventCtorStatements(b);
        b.EndBlock();
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedParameters.Count() - 1; i++) {
            var arg = cb.Signature.ManagedParameters[i];
            var cd = new CommentNode();
            if(arg.ParameterType.IsIn && arg.ParameterType.IsOut) {
                cd.Lines = new string[] { string.Format("Get or set the {0} parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            } else if(arg.ParameterType.IsIn) {
                cd.Lines = new string[] { string.Format("Get the {0} parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            } else {
                cd.Lines = new string[] { string.Format("Set the {0} out parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            }
            if(arg.ParameterType is CefStructArrayType && arg.ParameterType.IsIn) {
                cd.Lines = cd.Lines.Concat(new string[] { "Do not keep a reference to the elements of this array outside of this function." }).ToArray();
            }
            b.AppendSummary(cd);
            b.BeginBlock("public {0} {1}", arg.ParameterType.PublicSymbol, arg.PublicPropertyName);
            if(arg.ParameterType.IsIn) {
                b.BeginBlock("get");
                b.AppendLine("CheckAccess();");
                arg.EmitPublicEventArgGetterStatements(b);
                b.EndBlock();
            }
            if(arg.ParameterType.IsOut) {
                b.BeginBlock("set");
                b.AppendLine("CheckAccess();");
                arg.EmitPublicEventArgSetterStatements(b);
                b.EndBlock();
            }
            b.EndBlock();
        }

        if(!cb.Signature.PublicReturnType.IsVoid) {
            var cd = new CommentNode();
            cd.Lines = new string[] {
                string.Format("Set the return value for the <see cref=\"{0}.{1}\"/> callback.", ClassName, cb.PublicFunctionName),
                "Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown."
            };
            b.AppendSummary(cd);
            b.BeginBlock("public void SetReturnValue({0} returnValue)", cb.Signature.PublicReturnType.PublicSymbol);
            b.AppendLine("CheckAccess();");
            b.BeginIf("returnValueSet");
            b.AppendLine("throw new CfxException(\"The return value has already been set\");");
            b.EndBlock();
            b.AppendLine("returnValueSet = true;");
            b.AppendLine("this.m_returnValue = returnValue;");
            b.EndBlock();
        }

        if(cb.Signature.ManagedParameters.Count() > 1) {
            b.AppendLine();
            EmitEventToString(b, cb);
        }
        b.EndBlock();
    }

    private void EmitEventToString(CodeBuilder b, CefCallbackFunction cb) {
        b.BeginBlock("public override string ToString()");
        var format = new List<string>();
        var vars = new List<string>();
        var formatIndex = 0;
        for(var i = 1; i <= cb.Signature.ManagedParameters.Count() - 1; i++) {
            var arg = cb.Signature.ManagedParameters[i];
            if(arg.ParameterType.IsIn) {
                format.Add(string.Format("{0}={{{{{{{1}}}}}}}", arg.PublicPropertyName, formatIndex));
                vars.Add(arg.PublicPropertyName);
                formatIndex += 1;
            }
        }
        b.AppendLine("return String.Format(\"{0}\", {1});", string.Join(", ", format.ToArray()), string.Join(", ", vars.ToArray()));
        b.EndBlock();
    }

    public override void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {

        b.AppendLine("using Event;");

        b.AppendLine();

        b.BeginRemoteCallClass(ClassName, callIds, "CtorWithGCHandleRemoteCall");
        b.AppendLine();
        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
        b.AppendLine("__retval = CfxApi.{0}.{1}_ctor(gcHandlePtr, 1);", ApiClassName, CfxName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        b.BeginRemoteCallClass(ClassName, callIds, "SetCallbackRemoteCall");
        b.AppendLine();
        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
        b.AppendLine("{0}RemoteClient.SetCallback(self, index, active);", ClassName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        foreach(var cb in RemoteCallbackFunctions) {

            var sig = cb.Signature;

            b.BeginRemoteCallClass(cb.RemoteCallName, callIds, "RemoteEventCall");
            b.AppendLine();

            var inArgumentList = new List<string>();
            var outArgumentList = new List<string>();

            foreach(var arg in sig.Parameters) {
                if(!arg.IsThisArgument) {
                    foreach(var pm in arg.ParameterType.RemoteCallbackParameterList(arg.VarName)) {
                        if(pm.StartsWith("out ")) {
                            b.AppendLine("internal {0};", pm.Substring(4));
                            outArgumentList.Add(pm.Substring(pm.LastIndexOf(' ') + 1));
                        } else {
                            b.AppendLine("internal {0};", pm);
                            inArgumentList.Add(pm.Substring(pm.LastIndexOf(' ') + 1));
                        }
                    }
                }
            }
            b.AppendLine();

            if(!sig.ReturnType.IsVoid) {
                b.AppendLine("internal {0} __retval;", sig.ReturnType.PInvokeSymbol);
                b.AppendLine();
            }

            b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
            b.AppendLine("h.Write(gcHandlePtr);");
            foreach(var pm in inArgumentList) {
                b.AppendLine("h.Write({0});", pm);
            }
            b.EndBlock();
            b.AppendLine();
            b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
            b.AppendLine("h.Read(out gcHandlePtr);");
            foreach(var pm in inArgumentList) {
                b.AppendLine("h.Read(out {0});", pm);
            }
            b.EndBlock();
            b.AppendLine();
            b.BeginBlock("protected override void WriteReturn(StreamHandler h)");
            foreach(var pm in outArgumentList) {
                b.AppendLine("h.Write({0});", pm);
            }
            if(!sig.ReturnType.IsVoid) {
                b.AppendLine("h.Write(__retval);");
            }
            b.EndBlock();
            b.AppendLine();
            b.BeginBlock("protected override void ReadReturn(StreamHandler h)");
            foreach(var pm in outArgumentList) {
                b.AppendLine("h.Read(out {0});", pm);
            }
            if(!sig.ReturnType.IsVoid) {
                b.AppendLine("h.Read(out __retval);");
            }
            b.EndBlock();
            b.AppendLine();
            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");

            b.AppendLine("var self = ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;", RemoteClassName);
            b.BeginIf("self == null || self.CallbacksDisabled");
            b.AppendLine("return;");
            b.EndBlock();
            if(cb.IsBasicEvent)
                b.AppendLine("var e = new CfrEventArgs();");
            else
                b.AppendLine("var e = new {0}(this);", cb.RemoteEventArgsClassName);
            b.AppendLine("self.m_{0}?.Invoke(self, e);", cb.PublicName);
            b.AppendLine("e.m_isInvalid = true;");

            for(var i = 1; i <= sig.ManagedParameters.Count() - 1; i++) {
                sig.ManagedParameters[i].EmitPostRemoteRaiseEventStatements(b);
            }

            sig.EmitPostRemoteEventHandlerReturnValueStatements(b);

            b.EndBlock();
            b.EndBlock();
            b.AppendLine();
        }

    }

    public void EmitRemoteClient(CodeBuilder b) {
        b.BeginClass(ClassName + "RemoteClient", "internal static");
        b.AppendLine();

        b.BeginBlock("static {0}RemoteClient()", ClassName);

        foreach(var sm in RemoteCallbackFunctions) {
            b.AppendLine("{0}_native = {0};", sm.Name);
        }
        foreach(var sm in RemoteCallbackFunctions) {
            b.AppendLine("{0}_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate({0}_native);", sm.Name);
        }

        b.EndBlock();
        b.AppendLine();

        b.BeginBlock("internal static void SetCallback(IntPtr self, int index, bool active)");
        b.BeginBlock("switch(index)");
        foreach(var cb in RemoteCallbackFunctions) {
            b.AppendLine("case {0}:", cb.ClientCallbackIndex);
            b.IncreaseIndent();
            b.AppendLine("CfxApi.{0}.{1}_set_callback(self, index, active ? {2}_native_ptr : IntPtr.Zero);", ApiClassName, CfxName, cb.Name);
            b.AppendLine("break;");
            b.DecreaseIndent();
        }
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();

        foreach(var cb in RemoteCallbackFunctions) {

            var sig = cb.Signature;

            b.AppendComment(cb.ToString());
            CodeSnippets.EmitPInvokeCallbackDelegate(b, cb.Name, cb.Signature);
            b.AppendLine("private static {0}_delegate {0}_native;", cb.Name);
            b.AppendLine("private static IntPtr {0}_native_ptr;", cb.Name);
            b.AppendLine();

            var inArgumentList = new List<string>();

            foreach(var arg in sig.Parameters) {
                if(!arg.IsThisArgument) {
                    foreach(var pm in arg.ParameterType.RemoteCallbackParameterList(arg.VarName)) {
                        if(!pm.StartsWith("out ")) {
                            inArgumentList.Add(pm.Substring(pm.LastIndexOf(' ') + 1));
                        }
                    }
                }
            }

            b.BeginFunction(cb.Name, "void", sig.PInvokeParameterList, "internal static");
            b.AppendLine("var call = new {0}RemoteEventCall();", cb.RemoteCallName);
            b.AppendLine("call.gcHandlePtr = gcHandlePtr;");
            foreach(var pm in inArgumentList) {
                b.AppendLine("call.{0} = {0};", pm);
            }
            b.AppendLine("call.RequestExecution();");
            foreach(var arg in sig.Parameters) {
                if(!arg.IsThisArgument)
                    arg.ParameterType.EmitPostRemoteCallbackStatements(b, arg.VarName);
            }
            if(!sig.ReturnType.IsVoid) {
                b.AppendLine("__retval = call.__retval;");
            }

            //sig.EmitPostPublicEventHandlerCallStatements(b);

            b.EndBlock();
            b.AppendLine();
        }


        b.EndBlock();
    }

    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine("using Event;");

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.ApiCallbacks);
        b.BeginClass(RemoteClassName + " : CfrClientBase", GeneratorConfig.ClassModifiers(RemoteClassName));
        b.AppendLine();

        EmitRemoteClassWrapperFunction(b);
        b.AppendLine();

        b.AppendLine("private {0}(RemotePtr remotePtr) : base(remotePtr) {{}}", RemoteClassName);


        b.BeginBlock("public {0}() : base(new {1}CtorWithGCHandleRemoteCall())", RemoteClassName, ClassName);
        b.AppendLine("RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);");
        b.EndBlock();

        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                b.AppendSummaryAndRemarks(cb.Comments, true, true);
                b.BeginBlock("public event {0} {1}", cb.RemoteEventHandlerName, CSharp.Escape(cb.PublicName));
                b.BeginBlock("add");
                b.BeginBlock("if(m_{0} == null)", cb.PublicName);
                b.AppendLine("var call = new {0}SetCallbackRemoteCall();", ClassName);
                b.AppendLine("call.self = RemotePtr.ptr;");
                b.AppendLine("call.index = {0};", cb.ClientCallbackIndex);
                b.AppendLine("call.active = true;");
                b.AppendLine("call.RequestExecution(RemotePtr.connection);");
                b.EndBlock();
                b.AppendLine("m_{0} += value;", cb.PublicName);
                b.EndBlock();
                b.BeginBlock("remove");
                b.AppendLine("m_{0} -= value;", cb.PublicName);
                b.BeginBlock("if(m_{0} == null)", cb.PublicName);
                b.AppendLine("var call = new {0}SetCallbackRemoteCall();", ClassName);
                b.AppendLine("call.self = RemotePtr.ptr;");
                b.AppendLine("call.index = {0};", cb.ClientCallbackIndex);
                b.AppendLine("call.active = false;");
                b.AppendLine("call.RequestExecution(RemotePtr.connection);");
                b.EndBlock();
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();
                b.AppendLine("internal {0} m_{1};", cb.RemoteEventHandlerName, cb.PublicName);
                b.AppendLine();
                b.AppendLine();
            }
        }

        b.EndBlock();

        b.AppendLine();
        b.BeginBlock("namespace Event");
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                EmitRemoteEventArgsAndHandler(b, cb);
                b.AppendLine();
            }
        }

        b.EndBlock();
    }

    private static Dictionary<string, CommentNode> emittedRemoteHandlers = new Dictionary<string, CommentNode>();

    public void EmitRemoteEventArgsAndHandler(CodeBuilder b, CefCallbackFunction cb) {

        if(cb.IsBasicEvent)
            return;

        if(!ShouldEmitEventHandler(emittedRemoteHandlers, cb)) return;

        b.AppendSummaryAndRemarks(cb.Comments, true, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", cb.RemoteEventHandlerName, cb.RemoteEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(cb.Comments, true, true);
        b.BeginClass(cb.RemoteEventArgsClassName + " : CfrEventArgs", GeneratorConfig.ClassModifiers(cb.RemoteEventArgsClassName));
        b.AppendLine();

        b.AppendLine("private {0}RemoteEventCall call;", cb.RemoteCallName);
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedParameters.Count() - 1; i++) {
            cb.Signature.ManagedParameters[i].EmitRemoteEventArgFields(b);
        }
        b.AppendLine();

        if(!cb.Signature.PublicReturnType.IsVoid) {
            b.AppendLine("internal {0} m_returnValue;", cb.Signature.PublicReturnType.RemoteSymbol);
            b.AppendLine("private bool returnValueSet;");
            b.AppendLine();
        }

        b.AppendLine("internal {0}({1}RemoteEventCall call) {{ this.call = call; }}", cb.RemoteEventArgsClassName, cb.RemoteCallName);
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedParameters.Count() - 1; i++) {
            var arg = cb.Signature.ManagedParameters[i];
            var cd = new CommentNode();
            if(arg.ParameterType.IsIn && arg.ParameterType.IsOut) {
                cd.Lines = new string[] { string.Format("Get or set the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            } else if(arg.ParameterType.IsIn) {
                cd.Lines = new string[] { string.Format("Get the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            } else {
                cd.Lines = new string[] { string.Format("Set the {0} out parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            }
            if(arg.ParameterType is CefStructArrayType && arg.ParameterType.IsIn) {
                cd.Lines = cd.Lines.Concat(new string[] { "Do not keep a reference to the elements of this array outside of this function." }).ToArray();
            }
            b.AppendSummary(cd);
            b.BeginBlock("public {0} {1}", arg.ParameterType.RemoteSymbol, arg.PublicPropertyName);
            if(arg.ParameterType.IsIn) {
                b.BeginBlock("get");
                b.AppendLine("CheckAccess();");
                arg.EmitRemoteEventArgGetterStatements(b);
                b.EndBlock();
            }
            if(arg.ParameterType.IsOut) {
                b.BeginBlock("set");
                b.AppendLine("CheckAccess();");
                arg.EmitRemoteEventArgSetterStatements(b);
                b.EndBlock();
            }
            b.EndBlock();
        }
        if(!cb.Signature.PublicReturnType.IsVoid) {
            var cd = new CommentNode();
            cd.Lines = new string[] {
                string.Format("Set the return value for the <see cref=\"{0}.{1}\"/> render process callback.", CefStruct.RemoteClassName, cb.PublicFunctionName),
                "Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown."
            };
            b.AppendSummary(cd);
            b.BeginBlock("public void SetReturnValue({0} returnValue)", cb.Signature.PublicReturnType.RemoteSymbol);
            b.BeginIf("returnValueSet");
            b.AppendLine("throw new CfxException(\"The return value has already been set\");");
            b.EndBlock();
            b.AppendLine("m_returnValue = returnValue;");
            b.AppendLine("returnValueSet = true;");
            b.EndBlock();
        }

        if(cb.Signature.ManagedParameters.Count() > 1) {
            b.AppendLine();
            EmitEventToString(b, cb);
        }
        b.EndBlock();
    }
}
