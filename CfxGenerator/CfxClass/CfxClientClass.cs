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

        b.BeginBlock("namespace Event");
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            cb.EmitPublicEventArgsAndHandler(b, cb.Comments);
            b.AppendLine();
        }

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
    }


    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine("using Event;");

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.ApiCallbacks);
        b.BeginClass(RemoteClassName + " : CfrBase", GeneratorConfig.ClassModifiers(RemoteClassName));
        b.AppendLine();
        EmitRemoteClassWrapperFunction(b);

        b.BeginFunction("CreateRemote", "IntPtr", "", "internal static");
        b.AppendLine("var call = new {0}CtorRenderProcessCall();", ClassName);
        b.AppendLine("call.RequestExecution(CfxRemoteCallContext.CurrentContext.connection);");
        b.AppendLine("return call.__retval;");
        b.EndBlock();


        b.AppendLine();

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

        b.AppendLine("private {0}(IntPtr proxyId) : base(proxyId) {{}}", RemoteClassName);


        b.BeginBlock("public {0}() : base(CreateRemote())", RemoteClassName);
        b.AppendLine("connection.weakCache.Add(proxyId, this);");
        b.EndBlock();

        b.AppendLine();



        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                cb.EmitRemoteEvent(b, cb.Comments);
                b.AppendLine();
            }
        }



        b.BeginFunction("OnDispose", "void", "IntPtr proxyId", "internal override");
        b.AppendLine("connection.weakCache.Remove(proxyId);");
        b.EndBlock();

        b.EndBlock();

        b.AppendLine();
        b.BeginBlock("namespace Event");
        b.AppendLine();

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                cb.EmitRemoteEventArgsAndHandler(b, cb.Comments);
                b.AppendLine();
            }
        }

        b.EndBlock();
    }
}
