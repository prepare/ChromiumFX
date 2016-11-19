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

public class CfxClientClass : CfxClass {

    public CfxClientClass(CefStructType cefStruct, Parser.StructData sd, ApiTypeBuilder api)
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
        b.AppendLine("// managed callbacks");
        foreach(var cb in CallbackFunctions) {
            b.AppendLine("void (CEF_CALLBACK *{0})({1});", cb.Name, cb.Signature.NativeParameterList);
        }
        b.EndBlock("{0};", CfxNativeSymbol);
        b.AppendLine();

        b.BeginBlock("void CEF_CALLBACK _{0}_add_ref(struct _cef_base_t* base)", CfxName);
        b.AppendLine("int count = InterlockedIncrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.BeginIf("count == 2");
        b.AppendLine("(({0}*)base)->gc_handle = cfx_gc_handle_switch((({0}*)base)->gc_handle, count);", CfxNativeSymbol);
        b.EndBlock();
        b.EndBlock();
        b.BeginBlock("int CEF_CALLBACK _{0}_release(struct _cef_base_t* base)", CfxName);
        b.AppendLine("int count = InterlockedDecrement(&(({0}*)base)->ref_count);", CfxNativeSymbol);
        b.BeginIf("count == 1");
        b.AppendLine("(({0}*)base)->gc_handle = cfx_gc_handle_switch((({0}*)base)->gc_handle, count);", CfxNativeSymbol);
        b.BeginElseIf("!count");
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
        b.AppendLine("ptr->{0}.base.size = sizeof({1});", CefStruct.Name, OriginalSymbol);
        b.AppendLine("ptr->{0}.base.add_ref = _{1}_add_ref;", CefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.release = _{1}_release;", CefStruct.Name, CfxName);
        b.AppendLine("ptr->{0}.base.has_one_ref = _{1}_has_one_ref;", CefStruct.Name, CfxName);
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

        b.BeginClass(ClassName + " : CfxClientBase", GeneratorConfig.ClassModifiers(ClassName));
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
            foreach(var arg in sig.Arguments) {
                if(!arg.IsThisArgument)
                    arg.ArgumentType.EmitSetCallbackArgumentToDefaultStatements(b, arg.VarName);
            }
            b.AppendLine("return;");
            b.EndBlock();
            b.AppendLine("var e = new {0}({1});", cb.PublicEventArgsClassName, sig.PublicEventConstructorArguments);
            b.AppendLine("self.m_{0}?.Invoke(self, e);", cb.PublicName);
            b.AppendLine("e.m_isInvalid = true;");

            for(var i = 1; i <= sig.ManagedArguments.Count() - 1; i++) {
                sig.ManagedArguments[i].EmitPostPublicRaiseEventStatements(b);
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

        var isSimpleGetterEvent = cb.Signature.ManagedArguments.Length == 1
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

    private static Dictionary<string, CommentData> emittedHandlers = new Dictionary<string, CommentData>();

    private void EmitPublicEventArgsAndHandler(CodeBuilder b, CefCallbackFunction cb) {
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
            return;
        }
        emittedHandlers.Add(cb.EventName, cb.Comments);

        if(cb.IsBasicEvent)
            return;

        b.AppendSummaryAndRemarks(cb.Comments, false, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", cb.EventHandlerName, cb.PublicEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(cb.Comments, false, true);
        b.BeginClass(cb.PublicEventArgsClassName + " : CfxEventArgs", GeneratorConfig.ClassModifiers(cb.PublicEventArgsClassName));
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedArguments.Count() - 1; i++) {
            cb.Signature.ManagedArguments[i].EmitPublicEventArgFields(b);
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

        for(var i = 1; i <= cb.Signature.ManagedArguments.Count() - 1; i++) {
            var arg = cb.Signature.ManagedArguments[i];
            var cd = new CommentData();
            if(arg.ArgumentType.IsIn && arg.ArgumentType.IsOut) {
                cd.Lines = new string[] { string.Format("Get or set the {0} parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            } else if(arg.ArgumentType.IsIn) {
                cd.Lines = new string[] { string.Format("Get the {0} parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            } else {
                cd.Lines = new string[] { string.Format("Set the {0} out parameter for the <see cref=\"{1}.{2}\"/> callback.", arg.PublicPropertyName, ClassName, cb.PublicName) };
            }
            if(arg.ArgumentType is CefStructArrayType && arg.ArgumentType.IsIn) {
                cd.Lines = cd.Lines.Concat(new string[] { "Do not keep a reference to the elements of this array outside of this function." }).ToArray();
            }
            b.AppendSummary(cd);
            b.BeginBlock("public {0} {1}", arg.ArgumentType.PublicSymbol, arg.PublicPropertyName);
            if(arg.ArgumentType.IsIn) {
                b.BeginBlock("get");
                b.AppendLine("CheckAccess();");
                arg.EmitPublicEventArgGetterStatements(b);
                b.EndBlock();
            }
            if(arg.ArgumentType.IsOut) {
                b.BeginBlock("set");
                b.AppendLine("CheckAccess();");
                arg.EmitPublicEventArgSetterStatements(b);
                b.EndBlock();
            }
            b.EndBlock();
        }

        if(!cb.Signature.PublicReturnType.IsVoid) {
            var cd = new CommentData();
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

        if(cb.Signature.ManagedArguments.Count() > 1) {
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
        for(var i = 1; i <= cb.Signature.ManagedArguments.Count() - 1; i++) {
            var arg = cb.Signature.ManagedArguments[i];
            if(arg.ArgumentType.IsIn) {
                format.Add(string.Format("{0}={{{{{{{1}}}}}}}", arg.PublicPropertyName, formatIndex));
                vars.Add(arg.PublicPropertyName);
                formatIndex += 1;
            }
        }
        b.AppendLine("return String.Format(\"{0}\", {1});", string.Join(", ", format.ToArray()), string.Join(", ", vars.ToArray()));
        b.EndBlock();
    }

    public override void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {
        if(Category == StructCategory.ApiCallbacks) {
            b.AppendLine("using Event;");
            b.AppendLine("using Chromium.Event;");
        }

        b.AppendLine();

        EmitRemoteConstructorCalls(b, callIds);


        foreach(var cb in CallbackFunctions) {

            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {

                var sig = cb.Signature;

                b.BeginRemoteCallClass(cb.EventName, callIds, "RemoteClientCall");
                b.AppendLine();

                b.BeginBlock("internal static void EventCall(object sender, {0} e)", cb.PublicEventArgsClassName);
                b.AppendLine("var call = new {0}RemoteClientCall();", cb.EventName);
                b.AppendLine("call.sender = RemoteProxy.Wrap((CfxBase)sender);");
                b.AppendLine("call.eventArgsId = AddEventArgs(e);");
                b.AppendLine("call.RequestExecution(RemoteClient.connection);");
                b.AppendLine("RemoveEventArgs(call.eventArgsId);");
                b.EndBlock();

                b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                b.AppendLine("var sender = {0}.Wrap(new RemotePtr(connection, this.sender));", RemoteClassName);
                b.AppendLine("var e = new {0}(eventArgsId);", cb.RemoteEventArgsClassName);
                b.AppendLine("sender.raise_{0}(sender, e);", cb.PublicName);
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();

                b.BeginRemoteCallClass(cb.EventName + "Activate", callIds);
                b.AppendLine();
                b.AppendLine("internal IntPtr sender;");
                b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
                b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
                b.AppendLine();
                b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
                b.AppendLine("sender.{0} += {1}RemoteClientCall.EventCall;", cb.PublicName, cb.EventName);
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();

                b.BeginRemoteCallClass(cb.EventName + "Deactivate", callIds);
                b.AppendLine();
                b.AppendLine("internal IntPtr sender;");
                b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }");
                b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }");
                b.AppendLine();
                b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
                b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender, null);", ClassName);
                b.AppendLine("sender.{0} -= {1}RemoteClientCall.EventCall;", cb.PublicName, cb.EventName);
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();

                for(var ii = 1; ii <= sig.ManagedArguments.Length - 1; ii++) {
                    var arg = sig.ManagedArguments[ii];
                    if(arg.ArgumentType.IsOut) {
                        b.BeginRemoteCallClass(cb.EventName + "Set" + arg.PublicPropertyName, callIds);
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
                        b.AppendLine("var e = ({0})RemoteClientCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                        arg.EmitProxyEventArgSetter(b);
                        b.EndBlock();

                        b.EndBlock();
                        b.AppendLine();
                    }
                    if(arg.ArgumentType.IsIn) {
                        b.BeginRemoteCallClass(cb.EventName + "Get" + arg.PublicPropertyName, callIds);
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
                        b.AppendLine("var e = ({0})RemoteClientCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                        b.AppendLine("value = {0};", arg.ArgumentType.ProxyWrapExpression("e." + arg.PublicPropertyName));
                        b.EndBlock();

                        b.EndBlock();
                        b.AppendLine();
                    }
                }

                if(!sig.PublicReturnType.IsVoid) {
                    b.BeginRemoteCallClass(cb.EventName + "SetReturnValue", callIds);
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
                    b.AppendLine("var e = ({0})RemoteClientCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName);
                    b.AppendLine("e.SetReturnValue({0});", sig.PublicReturnType.ProxyUnwrapExpression("value"));
                    b.EndBlock();

                    b.EndBlock();
                    b.AppendLine();
                }
            }
        }
    }

    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine("using Event;");

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.ApiCallbacks);
        b.BeginClass(RemoteClassName + " : CfrClientBase", GeneratorConfig.ClassModifiers(RemoteClassName));
        b.AppendLine();
        EmitRemoteClassWrapperFunction(b);

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                b.BeginBlock("internal void raise_{0}(object sender, {1} e)", cb.PublicName, cb.RemoteEventArgsClassName);
                b.AppendLine("var handler = m_{0};", cb.PublicName);
                b.AppendLine("if(handler == null) return;");
                b.AppendLine("handler(this, e);");
                b.AppendLine("e.m_isInvalid = true;");
                b.EndBlock();
                b.AppendLine();
            }
        }


        b.AppendLine();

        b.AppendLine("private {0}(RemotePtr remotePtr) : base(remotePtr) {{}}", RemoteClassName);


        b.BeginBlock("public {0}() : base(new {1}CtorRemoteCall())", RemoteClassName, ClassName);
        b.AppendLine("RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);");
        b.EndBlock();

        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                b.AppendSummaryAndRemarks(cb.Comments, true, true);
                b.BeginBlock("public event {0} {1}", cb.RemoteEventHandlerName, CSharp.Escape(cb.PublicName));
                b.BeginBlock("add");
                b.BeginBlock("if(m_{0} == null)", cb.PublicName);
                b.AppendLine("var call = new {0}ActivateRemoteCall();", cb.EventName);
                b.AppendLine("call.sender = RemotePtr.ptr;");
                b.AppendLine("call.RequestExecution(RemotePtr.connection);");
                b.EndBlock();
                b.AppendLine("m_{0} += value;", cb.PublicName);
                b.EndBlock();
                b.BeginBlock("remove");
                b.AppendLine("m_{0} -= value;", cb.PublicName);
                b.BeginBlock("if(m_{0} == null)", cb.PublicName);
                b.AppendLine("var call = new {0}DeactivateRemoteCall();", cb.EventName);
                b.AppendLine("call.sender = RemotePtr.ptr;");
                b.AppendLine("call.RequestExecution(RemotePtr.connection);");
                b.EndBlock();
                b.EndBlock();
                b.EndBlock();
                b.AppendLine();
                b.AppendLine("{0} m_{1};", cb.RemoteEventHandlerName, cb.PublicName);
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


    public void EmitRemoteEventArgsAndHandler(CodeBuilder b, CefCallbackFunction cb) {

        if(cb.IsBasicEvent)
            return;

        b.AppendSummaryAndRemarks(cb.Comments, true, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", cb.RemoteEventHandlerName, cb.RemoteEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(cb.Comments, true, true);
        b.BeginClass(cb.RemoteEventArgsClassName + " : CfrEventArgs", GeneratorConfig.ClassModifiers(cb.RemoteEventArgsClassName));
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedArguments.Count() - 1; i++) {
            if(cb.Signature.ManagedArguments[i].ArgumentType.IsIn) {
                b.AppendLine("bool {0}Fetched;", cb.Signature.ManagedArguments[i].PublicPropertyName);
                b.AppendLine("{0} m_{1};", cb.Signature.ManagedArguments[i].ArgumentType.RemoteSymbol, cb.Signature.ManagedArguments[i].PublicPropertyName);
            }
        }
        b.AppendLine();

        if(!cb.Signature.PublicReturnType.IsVoid) {
            b.AppendLine("private bool returnValueSet;");
            b.AppendLine();
        }

        b.AppendLine("internal {0}(ulong eventArgsId) : base(eventArgsId) {{}}", cb.RemoteEventArgsClassName);
        b.AppendLine();

        for(var i = 1; i <= cb.Signature.ManagedArguments.Count() - 1; i++) {
            var arg = cb.Signature.ManagedArguments[i];
            var cd = new CommentData();
            if(arg.ArgumentType.IsIn && arg.ArgumentType.IsOut) {
                cd.Lines = new string[] { string.Format("Get or set the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            } else if(arg.ArgumentType.IsIn) {
                cd.Lines = new string[] { string.Format("Get the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            } else {
                cd.Lines = new string[] { string.Format("Set the {0} out parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, CefStruct.RemoteSymbol, cb.PublicFunctionName) };
            }
            b.AppendSummary(cd);
            b.BeginBlock("public {0} {1}", arg.ArgumentType.RemoteSymbol, arg.PublicPropertyName);
            if(arg.ArgumentType.IsIn) {
                b.BeginBlock("get");
                b.AppendLine("CheckAccess();");
                b.BeginBlock("if(!{0}Fetched)", arg.PublicPropertyName);
                b.AppendLine("{0}Fetched = true;", arg.PublicPropertyName);
                b.AppendLine("var call = new {0}Get{1}RemoteCall();", cb.EventName, arg.PublicPropertyName);
                b.AppendLine("call.eventArgsId = eventArgsId;");
                b.AppendLine("call.RequestExecution();");
                b.AppendLine("m_{0} = {1};", arg.PublicPropertyName, arg.ArgumentType.RemoteWrapExpression("call.value"));
                b.EndBlock();
                b.AppendLine("return m_{0};", arg.PublicPropertyName);
                b.EndBlock();
            }
            if(arg.ArgumentType.IsOut) {
                b.BeginBlock("set");
                b.AppendLine("CheckAccess();");
                if(arg.ArgumentType.IsIn) {
                    b.AppendLine("m_{0} = value;", arg.PublicPropertyName);
                    b.AppendLine("{0}Fetched = true;", arg.PublicPropertyName);
                }
                b.AppendLine("var call = new {0}Set{1}RemoteCall();", cb.EventName, arg.PublicPropertyName);
                b.AppendLine("call.eventArgsId = eventArgsId;");
                b.AppendLine("call.value = {0};", arg.ArgumentType.RemoteUnwrapExpression("value"));
                b.AppendLine("call.RequestExecution();");
                b.EndBlock();
            }
            b.EndBlock();
        }
        if(!cb.Signature.PublicReturnType.IsVoid) {
            var cd = new CommentData();
            cd.Lines = new string[] {
                string.Format("Set the return value for the <see cref=\"{0}.{1}\"/> render process callback.", CefStruct.RemoteClassName, cb.PublicFunctionName),
                "Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown."
            };
            b.AppendSummary(cd);
            b.BeginBlock("public void SetReturnValue({0} returnValue)", cb.Signature.PublicReturnType.RemoteSymbol);
            b.BeginIf("returnValueSet");
            b.AppendLine("throw new CfxException(\"The return value has already been set\");");
            b.EndBlock();
            b.AppendLine("var call = new {0}SetReturnValueRemoteCall();", cb.EventName);
            b.AppendLine("call.eventArgsId = eventArgsId;");
            b.AppendLine("call.value = {0};", cb.Signature.PublicReturnType.RemoteUnwrapExpression("returnValue"));
            b.AppendLine("call.RequestExecution();");
            b.AppendLine("returnValueSet = true;");
            b.EndBlock();
        }

        if(cb.Signature.ManagedArguments.Count() > 1) {
            b.AppendLine();
            EmitEventToString(b, cb);
        }
        b.EndBlock();
    }
}
