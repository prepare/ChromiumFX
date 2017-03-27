// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ApiType {

    protected static string AddIndirection(string typeName, string indirection) {
        if(indirection.StartsWith("*")) {
            return typeName + indirection;
        } else {
            return typeName + " " + indirection;
        }
    }

    public readonly string Name;

    public ApiType(string name) {
        this.Name = name;
    }

    public virtual bool IsOut {
        get { return false; }
    }

    public virtual bool IsIn {
        get { return true; }
    }

    public virtual string[] ParserMatches {
        get { return new string[] { OriginalSymbol }; }
    }

    public virtual string OriginalSymbol {
        get { return Name; }
    }

    public virtual string NativeSymbol {
        get { return OriginalSymbol; }
    }

    public virtual string PInvokeSymbol {
        get { return NativeSymbol; }
    }

    public virtual string PublicSymbol {
        get { return PInvokeSymbol; }
    }

    public virtual string ProxySymbol {
        get { return PublicSymbol; }
    }

    public virtual string RemoteSymbol {
        get { return ProxySymbol; }
    }

    public virtual string NativeCallParameter(string var, bool isConst) {
        if(NativeSymbol == null) {
            return null;
        }
        if(isConst) {
            return string.Concat("const ", NativeSymbol, " ", var);
        } else {
            return string.Concat(NativeSymbol, " ", var);
        }
    }

    public virtual string NativeCallArgument(string var) {
        return NativeUnwrapExpression(var);
    }

    public virtual string NativeReturnExpression(string var) {
        return NativeWrapExpression(var);
    }

    public virtual string NativeCallbackParameter(string var, bool isConst) {
        return NativeCallParameter(var, isConst);
    }

    public virtual string NativeCallbackArgument(string var) {
        return NativeWrapExpression(var);
    }

    public virtual string PInvokeCallParameter(string var) {
        if(PInvokeSymbol == null)
            return null;
        return string.Format("{0} {1}", PInvokeSymbol, CSharp.Escape(var));
    }

    public virtual string NativeOutSignature(string var) {
        if(NativeSymbol == null)
            return null;
        return string.Concat(NativeSymbol, "* ", var);
    }

    public virtual string PInvokeCallbackParameter(string var) {
        return PInvokeCallParameter(var);
    }

    public virtual string[] RemoteCallbackParameterList(string var) {
        var pp = PInvokeCallbackParameter(var).Split(',');
        for(int i = 0; i < pp.Length; ++i) {
            pp[i] = pp[i].Trim();
        }
        return pp;
    }

    public virtual string PublicEventConstructorParameter(string var) {
        return PInvokeCallbackParameter(var);
    }

    public virtual string PInvokeOutSignature(string var) {
        if(PInvokeSymbol == null)
            return null;
        return "out " + PInvokeCallParameter(var);
    }

    public virtual string PInvokeOutArgument(string var) {
        return "out " + CSharp.Escape(var);
    }

    public virtual string PublicCallParameter(string var) {
        if(PublicSymbol == null)
            return null;
        return string.Format("{0} {1}", PublicSymbol, CSharp.Escape(var));
    }

    public virtual string PublicCallArgument(string var) {
        return PublicUnwrapExpression(var);
    }

    public virtual string ProxyCallArgument(string var) {
        return PublicCallArgument(var);
    }

    public virtual string RemoteCallParameter(string var) {
        if(RemoteSymbol == null)
            return null;
        return string.Format("{0} {1}", RemoteSymbol, CSharp.Escape(var));
    }

    public virtual string NativeWrapExpression(string var) {
        return var;
    }

    public virtual string NativeUnwrapExpression(string var) {
        return var;
    }

    public virtual string PublicReturnExpression(string var) {
        return PublicWrapExpression(var);
    }

    public virtual string PublicWrapExpression(string var) {
        return CSharp.Escape(var);
    }

    public virtual string PublicUnwrapExpression(string var) {
        return CSharp.Escape(var);
    }

    public virtual string ProxyWrapExpression(string var) {
        return CSharp.Escape(var);
    }

    public virtual string ProxyUnwrapExpression(string var) {
        return CSharp.Escape(var);
    }

    public virtual string ProxyReturnExpression(string var) {
        return PublicReturnExpression(var);
    }

    public virtual string RemoteWrapExpression(string var) {
        if(RemoteSymbol == "RemotePtr") {
            return string.Format("new RemotePtr(connection, {0})", CSharp.Escape(var));
        } else {
            return CSharp.Escape(var);
        }
    }

    public virtual string RemoteUnwrapExpression(string var) {
        if(RemoteSymbol == "RemotePtr") {
            return CSharp.Escape(var) + ".ptr";
        } else {
            return CSharp.Escape(var);
        }
    }

    public virtual string PublicEventConstructorArgument(string var) {
        return CSharp.Escape(var);
    }

    public virtual void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitNativeCallbackReturnStatements(CodeBuilder b) {
        if(!IsVoid) {
            b.AppendLine("return {0};", NativeUnwrapExpression("__retval"));
        }
    }

    public virtual void EmitPreNativeCallStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitPostNativeCallStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitNativeReturnStatements(CodeBuilder b, string functionCall, CodeBuilder postCallStatements) {
        if(IsVoid) {
            b.AppendLine("{0};", NativeReturnExpression(functionCall));
            b.AppendBuilder(postCallStatements);
            return;
        }

        if(postCallStatements.IsNotEmpty) {
            b.AppendLine("{0} __ret_val_ = {1};", NativeSymbol, NativeReturnExpression(functionCall));
            b.AppendBuilder(postCallStatements);
            b.AppendLine("return __ret_val_;");
        } else {
            b.AppendLine("return {0};", NativeReturnExpression(functionCall));
        }
    }

    public virtual void EmitPrePublicCallStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitPostPublicCallStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitPreProxyCallStatements(CodeBuilder b, string var) {
        EmitPrePublicCallStatements(b, var);
    }

    public virtual void EmitPostProxyCallStatements(CodeBuilder b, string var) {
        EmitPostPublicCallStatements(b, var);
    }

    public virtual void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        b.AppendLine("call.{0} = {0};", CSharp.Escape(var));
    }

    public virtual void EmitPostRemoteCallStatements(CodeBuilder b, string var) {
        if(IsOut)
            b.AppendLine("{0} = {1};", var, RemoteWrapExpression("call." + (var == "this" ? "self" : CSharp.Escape(var))));
    }


    public virtual void EmitPostRemoteCallbackStatements(CodeBuilder b, string var) {
        var pp = RemoteCallbackParameterList(var);
        foreach(var p in pp) {
            if(p.StartsWith("out "))
                b.AppendLine("{0} = call.{0};", CSharp.Escape(p.Substring(p.LastIndexOf(' ') + 1)));
        }
    }

    /// <summary>
    /// Called if IsIn is true.
    /// </summary>
    public virtual void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        if(IsIn) {
            b.AppendLine("m_{0} = {1};", var, CSharp.Escape(var));
        }
    }

    /// <summary>
    /// Called if IsIn is true.
    /// </summary>
    public virtual void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("return {0};", PublicWrapExpression("m_" + var));
    }

    public virtual void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("return {0};", RemoteWrapExpression("call." + CSharp.Escape(var)));
    }

    /// <summary>
    /// Called if IsOut is true.
    /// </summary>
    public virtual void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0} = {1};", var, PublicUnwrapExpression("value"));
    }

    public virtual void EmitRemoteEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("call.{0} = {1};", CSharp.Escape(var), RemoteUnwrapExpression("value"));
    }

    public virtual void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} m_{1};", PInvokeSymbol, var);
    }

    public virtual void EmitRemoteEventArgFields(CodeBuilder b, string var) {
    }

    public virtual void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        if(this.IsOut) {
            b.AppendLine("{0} = e.m_{0};", var);
        }
    }

    public virtual void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
    }

    public virtual void EmitSetCallbackArgumentToDefaultStatements(CodeBuilder b, string var) {
        if(IsOut && !IsIn)
            b.AppendLine("{0} = default({1});", var, PInvokeSymbol);
    }

    public void EmitRemoteCallFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0} {1};", ProxySymbol, var);
    }

    public virtual void EmitRemoteWrite(CodeBuilder b, string var) {
        b.AppendLine("h.Write({0});", var);
    }

    public virtual void EmitRemoteRead(CodeBuilder b, string var) {
        b.AppendLine("h.Read(out {0});", var);
    }

    public virtual void EmitValueStructGetterVars(CodeBuilder b, string var) {
        b.AppendLine("{0} {1};", PInvokeSymbol, CSharp.Escape(var));
    }

    public virtual void EmitAssignToNativeStructMember(CodeBuilder b, string var, string cefStruct = "self") {
        b.AppendLine("{0}->{1} = {2};", cefStruct, var, NativeUnwrapExpression(var));
    }

    public virtual void EmitAssignFromNativeStructMember(CodeBuilder b, string var, string cefStruct = "self") {
        b.AppendLine("*{0} = {1};", var, NativeWrapExpression(string.Format("{0}->{1}", cefStruct, var)));
    }

    public virtual void EmitNativeValueStructDtorStatements(CodeBuilder b, string var) {
    }

    public bool IsVoid {
        get { return Name == "void"; }
    }

    public virtual bool IsCefStructType {
        get { return false; }
    }

    public virtual CefStructType AsCefStructType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefPlatformStructType {
        get { return false; }
    }

    public virtual CefPlatformStructType AsCefPlatformStructType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefStringType {
        get { return false; }
    }

    public virtual CefStringType AsCefStringType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefEnumType {
        get { return false; }
    }

    public virtual CefEnumType AsCefEnumType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefStructPtrType {
        get { return false; }
    }

    public virtual CefStructPtrType AsCefStructPtrType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefStructPtrPtrType {
        get { return false; }
    }

    public virtual CefStructPtrPtrType AsCefStructPtrPtrType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefStringPtrTypeConst {
        get { return false; }
    }

    public virtual CefStringPtrTypeConst AsCefStringPtrTypeConst {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsCefStringPtrType {
        get { return false; }
    }

    public virtual CefStringPtrType AsCefStringPtrType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsBlittableType {
        get { return false; }
    }

    public virtual BlittableType AsBlittableType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public virtual bool IsStringCollectionType {
        get { return false; }
    }

    public virtual StringCollectionType AsStringCollectionType {
        get {
            Debug.Assert(false);
            return null;
        }
    }

    public override string ToString() {
        return OriginalSymbol;
    }

    public override bool Equals(object obj) {
        return obj is ApiType && this.Name.Equals(((ApiType)obj).Name);
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }
}