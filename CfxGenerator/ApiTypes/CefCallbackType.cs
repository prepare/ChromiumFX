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
using System.Linq;

public class CefCallbackType : ApiType, ISignatureOwner {
    public readonly Signature Signature;
    public readonly CefStructType Parent;

    public readonly CommentData Comments;

    public string PropertyName;

    private CfxCallMode m_callMode;
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

    public CefCallbackType(CefStructType parent, StructCategory category, string name, CefConfigData cefConfig, Parser.SignatureData sd, ApiTypeBuilder api, CommentData comments)
        : base(name) {
        this.Parent = parent;
        this.Comments = comments;
        this.cefConfig = cefConfig;

        if(category == StructCategory.ApiCallbacks) {
            m_callMode = CfxCallMode.Callback;
        } else {
            m_callMode = CfxCallMode.FunctionCall;
        }
        this.Signature = Signature.Create(this, sd, api);
    }

    public ApiType NativeReturnType {
        get { return Signature.ReturnType; }
    }

    public ApiType PublicReturnType {
        get { return Signature.PublicReturnType; }
    }

    public ApiType RemoteReturnType {
        get { return Signature.RemoteReturnType; }
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

    public bool IsPropertyGetter(ref bool isBoolean) {
        var retval = IsPropertyGetterPrivate(ref isBoolean);
        if(retval)
            m_callMode = CfxCallMode.PropertyGetter;
        return retval;
    }

    private bool IsPropertyGetterPrivate(ref bool isBoolean) {
        if(Signature.PublicReturnType.IsVoid)
            return false;
        if(Signature.PublicReturnType.IsStringCollectionType)
            return false;

        if(Signature.ManagedArguments.Length != 1)
            return false;

        if(Name.StartsWith("has_")) { isBoolean = true; return true; }
        if(Name.StartsWith("is_")) { isBoolean = true; return true; }
        if(Name.StartsWith("can_")) { isBoolean = true; return true; }

        if(Name.StartsWith("get_")) {
            if(Signature.PublicReturnType.Name == "cef_string_userfree_t") {
                if(Name == "get_error") {
                    return false;
                }
            }
            return true;
        }

        return false;
    }

    public bool IsPropertySetterFor(CefCallbackType getter) {
        var retval = IsPropertySetterForPrivate(getter);
        if(retval)
            m_callMode = CfxCallMode.PropertySetter;
        return retval;
    }

    public bool IsPropertySetterForPrivate(CefCallbackType getter) {
        if(!Signature.PublicReturnType.IsVoid)
            return false;
        if(!(Signature.ManagedArguments.Count() == 2))
            return false;
        if(!Signature.ManagedArguments[1].ArgumentType.Equals(getter.Signature.PublicReturnType)) {
            if(!(getter.Signature.PublicReturnType.Name == "cef_string_userfree_t" && Signature.ManagedArguments[1].ArgumentType.IsCefStringPtrTypeConst))
                return false;
        }
        if(!Name.Substring(1).Equals(getter.Name.Substring(1)))
            return false;
        return true;
    }

    public bool IsBasicEvent {
        get { return Signature.ManagedArguments.Length == 1 && Signature.PublicReturnType.IsVoid; }
    }

    public string NativeCallbackName {
        get { return string.Concat(Parent.CfxName, "_", Name); }
    }

    public string EventName {
        get {
            if(Parent.ClassBuilder.StructMembers.Length == 2) {
                return Parent.ClassName + PublicName;
            } else if(PublicName == "GetAuthCredentials") {
                return Parent.ClassName + PublicName;
            } else if(PublicName.Length < 4) {
                return Parent.ClassName + PublicName;
            } else {
                return "Cfx" + PublicName;
            }
        }
    }

    public string EventHandlerName {
        get {
            if(IsBasicEvent)
                return "CfxEventHandler";
            return EventName + "EventHandler";
        }
    }

    public string RemoteEventHandlerName {
        get { return "Cfr" + EventHandlerName.Substring(3); }
    }

    public string ProxyEventHandlerName {
        get { return RemoteEventHandlerName + "Proxy"; }
    }

    public string PublicEventArgsClassName {
        get {
            if(IsBasicEvent)
                return "CfxEventArgs";
            return EventName + "EventArgs";
        }
    }

    public string RemoteEventArgsClassName {
        get { return "Cfr" + PublicEventArgsClassName.Substring(3); }
    }

    public string ProxyEventArgsClassName {
        get { return RemoteEventArgsClassName + "Proxy"; }
    }

    public void EmitPublicFunction(CodeBuilder b) {
        if(GeneratorConfig.HasPrivateWrapper(Parent.Name + "::" + Name)) {
            b.BeginFunction(Signature.PublicSignature(PublicName), "private");
        } else {
            b.BeginFunction(Signature.PublicSignature(PublicName));
        }
        Signature.EmitPublicCall(b);
        b.EndBlock();
    }

    public void EmitPublicProperty(CodeBuilder b, CefCallbackType setter) {
        var propertyName = this.PublicName;
        if(Name.StartsWith("get_")) {
            propertyName = propertyName.Substring(3);
        }

        propertyName = CSharp.Escape(propertyName);

        b.BeginBlock("public {0} {1}", PublicReturnType.PublicSymbol, propertyName);

        b.BeginBlock("get");
        Signature.EmitPublicCall(b);
        b.EndBlock();
        if(setter != null) {
            b.BeginBlock("set", PublicReturnType.PublicSymbol);
            setter.Signature.EmitPublicCall(b);
            b.EndBlock();
        }
        b.EndBlock();
    }

    private static Dictionary<string, CommentData> emittedHandlers = new Dictionary<string, CommentData>();

    public void EmitPublicEventArgsAndHandler(CodeBuilder b, CommentData comments) {
        if(emittedHandlers.ContainsKey(EventName)) {
            var c0 = emittedHandlers[EventName];
            if(c0 != null) {
                if(c0.Lines.Length != comments.Lines.Length) {
                    System.Diagnostics.Debugger.Break();
                }
                for(var i = 0; i <= c0.Lines.Length - 1; i++) {
                    if(c0.Lines[i] != comments.Lines[i]) {
                        // two handlers use same event but with different comments
                        System.Diagnostics.Debugger.Break();
                    }
                }
            }
            return;
        }
        emittedHandlers.Add(EventName, comments);

        if(IsBasicEvent)
            return;

        b.AppendSummaryAndRemarks(comments, false, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", EventHandlerName, PublicEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(comments, false, true);
        b.BeginClass(PublicEventArgsClassName + " : CfxEventArgs", GeneratorConfig.ClassModifiers(PublicEventArgsClassName));
        b.AppendLine();

        for(var i = 1; i <= Signature.ManagedArguments.Count() - 1; i++) {
            var arg = Signature.ManagedArguments[i];
            Signature.ManagedArguments[i].EmitPublicEventArgFields(b);
        }
        b.AppendLine();

        if(!Signature.PublicReturnType.IsVoid) {
            b.AppendLine("internal {0} m_returnValue;", Signature.PublicReturnType.PublicSymbol);
            b.AppendLine("private bool returnValueSet;");
            b.AppendLine();
        }

        b.BeginBlock("internal {0}({1})", PublicEventArgsClassName, Signature.PublicEventConstructorSignature);
        Signature.EmitPublicEventCtorStatements(b);
        b.EndBlock();
        b.AppendLine();

        Signature.EmitPublicEventArgProperties(b);

        if(!Signature.PublicReturnType.IsVoid) {
            var cd = new CommentData();
            cd.Lines = new string[] {
				string.Format("Set the return value for the <see cref=\"{0}.{1}\"/> callback.", Parent.ClassName, PublicFunctionName),
				"Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown."
			};
            b.AppendSummary(cd);
            b.BeginBlock("public void SetReturnValue({0} returnValue)", Signature.PublicReturnType.PublicSymbol);
            b.AppendLine("CheckAccess();");
            b.BeginIf("returnValueSet");
            b.AppendLine("throw new CfxException(\"The return value has already been set\");");
            b.EndBlock();
            b.AppendLine("returnValueSet = true;");
            b.AppendLine("this.m_returnValue = returnValue;");
            b.EndBlock();
        }

        if(Signature.ManagedArguments.Count() > 1) {
            b.AppendLine();
            EmitEventToString(b);
        }
        b.EndBlock();
    }

    private void EmitEventToString(CodeBuilder b) {
        b.BeginBlock("public override string ToString()");
        var format = new List<string>();
        var vars = new List<string>();
        var formatIndex = 0;
        for(var i = 1; i <= Signature.ManagedArguments.Count() - 1; i++) {
            var arg = Signature.ManagedArguments[i];
            if(arg.ArgumentType.IsIn) {
                format.Add(string.Format("{0}={{{{{{{1}}}}}}}", arg.PublicPropertyName, formatIndex));
                vars.Add(arg.PublicPropertyName);
                formatIndex += 1;
            }
        }
        b.AppendLine("return String.Format(\"{0}\", {1});", string.Join(", ", format.ToArray()), string.Join(", ", vars.ToArray()));
        b.EndBlock();
    }

    public void EmitRemoteEventArgsAndHandler(CodeBuilder b, CommentData comments) {
        if(IsBasicEvent)
            return;

        b.AppendSummaryAndRemarks(comments, true, true);
        b.AppendLine("public delegate void {0}(object sender, {1} e);", RemoteEventHandlerName, RemoteEventArgsClassName);
        b.AppendLine();

        b.AppendSummaryAndRemarks(comments, true, true);
        b.BeginClass(RemoteEventArgsClassName + " : CfrEventArgs", GeneratorConfig.ClassModifiers(RemoteEventArgsClassName));
        b.AppendLine();

        for(var i = 1; i <= Signature.ManagedArguments.Count() - 1; i++) {
            if(Signature.ManagedArguments[i].ArgumentType.IsIn) {
                b.AppendLine("bool {0}Fetched;", Signature.ManagedArguments[i].PublicPropertyName);
                b.AppendLine("{0} m_{1};", Signature.ManagedArguments[i].ArgumentType.RemoteSymbol, Signature.ManagedArguments[i].PublicPropertyName);
            }
        }
        b.AppendLine();

        if(!Signature.PublicReturnType.IsVoid) {
            b.AppendLine("private bool returnValueSet;");
            b.AppendLine();
        }

        b.AppendLine("internal {0}(ulong eventArgsId) : base(eventArgsId) {{}}", RemoteEventArgsClassName);
        b.AppendLine();

        for(var i = 1; i <= Signature.ManagedArguments.Count() - 1; i++) {
            var arg = Signature.ManagedArguments[i];
            var cd = new CommentData();
            if(arg.ArgumentType.IsIn && arg.ArgumentType.IsOut) {
                cd.Lines = new string[] { string.Format("Get or set the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, Parent.RemoteSymbol, PublicFunctionName) };
            } else if(arg.ArgumentType.IsIn) {
                cd.Lines = new string[] { string.Format("Get the {0} parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, Parent.RemoteSymbol, PublicFunctionName) };
            } else {
                cd.Lines = new string[] { string.Format("Set the {0} out parameter for the <see cref=\"{1}.{2}\"/> render process callback.", arg.PublicPropertyName, Parent.RemoteSymbol, PublicFunctionName) };
            }
            b.AppendSummary(cd);
            b.BeginBlock("public {0} {1}", arg.ArgumentType.RemoteSymbol, arg.PublicPropertyName);
            if(arg.ArgumentType.IsIn) {
                b.BeginBlock("get");
                b.AppendLine("CheckAccess();");
                b.BeginBlock("if(!{0}Fetched)", arg.PublicPropertyName);
                b.AppendLine("{0}Fetched = true;", arg.PublicPropertyName);
                b.AppendLine("var call = new {0}Get{1}RenderProcessCall();", EventName, arg.PublicPropertyName);
                b.AppendLine("call.eventArgsId = eventArgsId;");
                b.AppendLine("call.Execute();");
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
                b.AppendLine("var call = new {0}Set{1}RenderProcessCall();", EventName, arg.PublicPropertyName);
                b.AppendLine("call.eventArgsId = eventArgsId;");
                b.AppendLine("call.value = {0};", arg.ArgumentType.RemoteUnwrapExpression("value"));
                b.AppendLine("call.Execute();");
                b.EndBlock();
            }
            b.EndBlock();
        }
        if(!Signature.PublicReturnType.IsVoid) {
            var cd = new CommentData();
            cd.Lines = new string[] {
				string.Format("Set the return value for the <see cref=\"{0}.{1}\"/> render process callback.", Parent.RemoteClassName, PublicFunctionName),
				"Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown."
			};
            b.AppendSummary(cd);
            b.BeginBlock("public void SetReturnValue({0} returnValue)", Signature.PublicReturnType.RemoteSymbol);
            b.BeginIf("returnValueSet");
            b.AppendLine("throw new CfxException(\"The return value has already been set\");");
            b.EndBlock();
            b.AppendLine("var call = new {0}SetReturnValueRenderProcessCall();", EventName);
            b.AppendLine("call.eventArgsId = eventArgsId;");
            b.AppendLine("call.value = {0};", Signature.PublicReturnType.RemoteUnwrapExpression("returnValue"));
            b.AppendLine("call.Execute();");
            b.AppendLine("returnValueSet = true;");
            b.EndBlock();
        }

        if(Signature.ManagedArguments.Count() > 1) {
            b.AppendLine();
            EmitEventToString(b);
        }
        b.EndBlock();
    }

    public void EmitPublicEvent(CodeBuilder b, int cbIndex, CommentData comments) {
        var callbackName = Parent.CfxName + "_" + Name;
        b.AppendSummaryAndRemarks(comments, false, true);
        b.BeginBlock("public event {0} {1}", EventHandlerName, CSharp.Escape(PublicName));
        b.BeginBlock("add");
        b.BeginBlock("lock(eventLock)");
        b.BeginBlock("if(m_{0} == null)", PublicName);
        b.BeginBlock("if({0}_{1} == null)", Parent.CfxName, Name);
        b.AppendLine("{0}_{1} = {1};", Parent.CfxName, Name);
        b.AppendLine("{0}_{1}_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate({0}_{1});", Parent.CfxName, Name);
        b.EndBlock();
        b.AppendLine("CfxApi.{0}_set_managed_callback(NativePtr, {1}, {0}_{2}_ptr);", Parent.CfxName, cbIndex, Name);
        b.EndBlock();
        b.AppendLine("m_{0} += value;", PublicName);
        b.EndBlock();
        b.EndBlock();
        b.BeginBlock("remove");
        b.BeginBlock("lock(eventLock)");
        b.AppendLine("m_{0} -= value;", PublicName);
        b.BeginBlock("if(m_{0} == null)", PublicName);
        b.AppendLine("CfxApi.{0}_set_managed_callback(NativePtr, {1}, IntPtr.Zero);", Parent.CfxName, cbIndex);
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine("private {0} m_{1};", EventHandlerName, PublicName);
    }

    public void EmitRemoteEvent(CodeBuilder b, CommentData comments) {
        b.AppendSummaryAndRemarks(comments, true, true);
        b.BeginBlock("public event {0} {1}", RemoteEventHandlerName, CSharp.Escape(PublicName));
        b.BeginBlock("add");
        b.BeginBlock("if(m_{0} == null)", PublicName);
        b.AppendLine("var call = new {0}ActivateRenderProcessCall();", EventName);
        b.AppendLine("call.sender = proxyId;");
        b.AppendLine("call.Execute();");
        b.EndBlock();
        b.AppendLine("m_{0} += value;", PublicName);
        b.EndBlock();
        b.BeginBlock("remove");
        b.AppendLine("m_{0} -= value;", PublicName);
        b.BeginBlock("if(m_{0} == null)", PublicName);
        b.AppendLine("var call = new {0}DeactivateRenderProcessCall();", EventName);
        b.AppendLine("call.sender = proxyId;");
        b.AppendLine("call.Execute();");
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine("{0} m_{1};", RemoteEventHandlerName, PublicName);
        b.AppendLine();
    }

    public void EmitRemoteRaiseEventFunction(CodeBuilder b, CommentData comments) {
        b.BeginBlock("internal void raise_{0}(object sender, {1} e)", PublicName, RemoteEventArgsClassName);
        b.AppendLine("var handler = m_{0};", PublicName);
        b.AppendLine("if(handler == null) return;");
        b.AppendLine("handler(this, e);");
        b.AppendLine("e.m_isInvalid = true;");
        b.EndBlock();
        b.AppendLine();
    }

    public override string NativeSymbol {
        get { return string.Format("{1} (CEF_CALLBACK *{0})({2})", Name, PublicReturnType, Signature); }
    }

    public override string[] ParserMatches {
        get { return new string[-1 + 1]; }
    }

    public override bool IsCefCallbackType {
        get { return true; }
    }

    public override CefCallbackType AsCefCallbackType {
        get { return this; }
    }

    public CfxCallMode CallMode {
        get { return this.m_callMode; }
    }

    public string CefName {
        get { return Parent.Name + "::" + Name; }
    }

    public string CfxApiFunctionName {
        get { return string.Concat(Parent.CfxName, "_", Name); }
    }

    public string PublicFunctionName {
        get { return PublicName; }
    }

    public string PublicPropertyName {
        get { return PropertyName; }
    }

    string ISignatureOwner.PropertyName {
        get { return PublicPropertyName; }
    }

    public string RemoteCallId {
        get {
            if(Parent.ClassBuilder.Category == StructCategory.ApiCallbacks) {
                return Parent.ClassName + RemoteCallClassName + "BrowserProcessCall";
            } else {
                return Parent.ClassName + RemoteCallClassName + "RenderProcessCall";
            }
        }
    }

    public string PublicClassName {
        get { return Parent.ClassName; }
    }

    public CommentData Comments1 {
        get { return Comments; }
    }

    CommentData ISignatureOwner.Comments {
        get { return Comments1; }
    }

    public CefConfigData CefConfig1 {
        get { return cefConfig; }
    }

    CefConfigData ISignatureOwner.CefConfig {
        get { return CefConfig1; }
    }
}