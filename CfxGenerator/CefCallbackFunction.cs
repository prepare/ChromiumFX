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

public class CefCallbackFunction  {

    public string Name { get; private set; }

    public readonly Signature Signature;
    public readonly CefStructType Parent;

    public CommentData Comments { get; private set; }

    private CfxCallMode m_callMode;
    public CefConfigData CefConfig { get; private set; }

    public bool IsProperty;

    public int ApiIndex;

    private string cppApiName {
        get {
            if(CefConfig != null) {
                return CefConfig.CppApiName;
            } else {
                return null;
            }
        }
    }

    public CefCallbackFunction(CefStructType parent, StructCategory category, string name, CefConfigData cefConfig, Parser.SignatureData sd, ApiTypeBuilder api, CommentData comments) {
        Name = name;
        this.Parent = parent;
        this.Comments = comments;
        if(cefConfig == null)
            CefConfig = new CefConfigData();
        else
            CefConfig = cefConfig;

        if(category == StructCategory.ApiCallbacks) {
            m_callMode = CfxCallMode.Callback;
            this.Signature = Signature.Create(SignatureType.ClientCallback, CefName, CefConfig, CallMode, sd, api);
        } else {
            m_callMode = CfxCallMode.FunctionCall;
            this.Signature = Signature.Create(SignatureType.LibraryCall, CefName, CefConfig, CallMode, sd, api);
        }
        
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
                if(Parent.ClassBuilder.Category == StructCategory.ApiCallbacks) {
                    // can't overload event names, so return the styled c-api name instead
                    return CSharp.ApplyStyle(Name);
                }
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

    public bool IsPropertySetterFor(CefCallbackFunction getter) {
        var retval = IsPropertySetterForPrivate(getter);
        if(retval)
            m_callMode = CfxCallMode.PropertySetter;
        return retval;
    }

    public bool IsPropertySetterForPrivate(CefCallbackFunction getter) {
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
            if(Parent.ClassBuilder.CallbackFunctions.Length == 1) {
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

    public string PublicPropertyName { get; set; }

    public string PropertyName {
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

    public override string ToString() {
        return Name;
    }
}
