// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class Parameter {
    public readonly ApiType ParameterType;
    public readonly string VarName;
    public readonly int Index;

    public readonly bool IsConst;

    public bool IsThisArgument;
    public bool IsPropertySetterArgument;

    public Parameter(Parser.ParameterNode ad, ApiTypeBuilder api, int index) {
        this.ParameterType = api.GetApiType(ad.ParameterType, ad.IsConst);
        this.VarName = ad.Var;
        this.Index = index;
        this.IsConst = ad.IsConst;
        this.IsThisArgument = this.VarName.Equals("self");
    }

    public Parameter(Parameter replacedParam, ApiType newType) {
        this.ParameterType = newType;
        this.VarName = replacedParam.VarName;
        this.Index = replacedParam.Index;
        this.IsConst = replacedParam.IsConst;
        this.IsThisArgument = replacedParam.IsThisArgument;
        this.IsPropertySetterArgument = replacedParam.IsPropertySetterArgument;
    }

    public bool TypeIsRefCounted {
        get { return ParameterType.IsCefStructPtrType && ParameterType.AsCefStructPtrType.Struct.IsRefCounted; }
    }

    public string PublicVarName {
        get {
            if(IsPropertySetterArgument) {
                return "value";
            } else if(IsThisArgument) {
                return "this";
            } else {
                return CSharp.ApplyStyle(VarName, true);
            }
        }
    }

    public string PublicPropertyName {
        get { return CSharp.Escape(CSharp.ApplyStyle(VarName, false)); }
    }

    public string PublicEventConstructorArgument {
        get { return ParameterType.PublicEventConstructorArgument(VarName); }
    }

    public string OriginalParameter {
        get {
            if(IsConst) {
                return string.Concat("const ", ParameterType.OriginalSymbol, " ", VarName);
            } else {
                return string.Concat(ParameterType.OriginalSymbol, " ", VarName);
            }
        }
    }

    public string NativeCallParameter {
        get { return ParameterType.NativeCallParameter(VarName, IsConst); }
    }

    public string NativeCallArgument {
        get { return ParameterType.NativeCallArgument(VarName); }
    }

    public string NativeCallbackParameter {
        get { return ParameterType.NativeCallbackParameter(VarName, IsConst); }
    }

    public string NativeCallbackArgument {
        get { return ParameterType.NativeCallbackArgument(VarName); }
    }

    public string PInvokeCallParameter {
        get { return ParameterType.PInvokeCallParameter(VarName); }
    }

    public string PInvokeCallbackParameter {
        get { return ParameterType.PInvokeCallbackParameter(VarName); }
    }

    public string PublicEventConstructorParameter {
        get { return ParameterType.PublicEventConstructorParameter(VarName); }
    }

    public string PublicCallParameter {
        get {
            if(IsThisArgument)
                return null;
            return ParameterType.PublicCallParameter(PublicVarName);
        }
    }

    public string PublicCallArgument {
        get {
            if(IsThisArgument)
                return "NativePtr";
            return ParameterType.PublicCallArgument(PublicVarName);
        }
    }

    public string ProxyCallArgument {
        get {
            return ParameterType.ProxyCallArgument(PublicVarName);
        }
    }

    public string RemoteCallParameter {
        get {
            if(IsThisArgument)
                return null;
            return ParameterType.RemoteCallParameter(PublicVarName);
        }
    }

    public void EmitPreNativeCallStatements(CodeBuilder b) {
        ParameterType.EmitPreNativeCallStatements(b, VarName);
    }

    public void EmitPostNativeCallStatements(CodeBuilder b) {
        ParameterType.EmitPostNativeCallStatements(b, VarName);
    }

    public void EmitPreNativeCallbackStatements(CodeBuilder b) {
        ParameterType.EmitPreNativeCallbackStatements(b, VarName);
    }

    public void EmitPostNativeCallbackStatements(CodeBuilder b) {
        ParameterType.EmitPostNativeCallbackStatements(b, VarName);
    }

    public void EmitPrePublicCallStatements(CodeBuilder b) {
        ParameterType.EmitPrePublicCallStatements(b, PublicVarName);
    }

    public void EmitPostPublicStatements(CodeBuilder b) {
        ParameterType.EmitPostPublicCallStatements(b, PublicVarName);
    }

    public void EmitPreProxyCallStatements(CodeBuilder b) {
        ParameterType.EmitPreProxyCallStatements(b, PublicVarName);
    }

    public void EmitPostProxyCallStatements(CodeBuilder b) {
        ParameterType.EmitPostProxyCallStatements(b, PublicVarName);
    }

    public void EmitPreRemoteCallStatements(CodeBuilder b) {
        ParameterType.EmitPreRemoteCallStatements(b, PublicVarName);
    }

    public void EmitPostRemoteCallStatements(CodeBuilder b) {
        ParameterType.EmitPostRemoteCallStatements(b, PublicVarName);
    }

    public void EmitPublicEventCtorStatements(CodeBuilder b) {
        ParameterType.EmitPublicEventCtorStatements(b, VarName);
    }

    public void EmitPublicEventArgGetterStatements(CodeBuilder b) {
        ParameterType.EmitPublicEventArgGetterStatements(b, VarName);
    }

    public void EmitPublicEventArgSetterStatements(CodeBuilder b) {
        ParameterType.EmitPublicEventArgSetterStatements(b, VarName);
    }

    public void EmitRemoteEventArgGetterStatements(CodeBuilder b) {
        ParameterType.EmitRemoteEventArgGetterStatements(b, VarName);
    }

    public void EmitRemoteEventArgSetterStatements(CodeBuilder b) {
        ParameterType.EmitRemoteEventArgSetterStatements(b, VarName);
    }

    public void EmitPublicEventArgFields(CodeBuilder b) {
        ParameterType.EmitPublicEventArgFields(b, VarName);
    }

    public void EmitRemoteEventArgFields(CodeBuilder b) {
        ParameterType.EmitRemoteEventArgFields(b, VarName);
    }

    public void EmitPostPublicRaiseEventStatements(CodeBuilder b) {
        ParameterType.EmitPostPublicRaiseEventStatements(b, VarName);
    }

    public void EmitPostRemoteRaiseEventStatements(CodeBuilder b) {
        ParameterType.EmitPostRemoteRaiseEventStatements(b, VarName);
    }

    public virtual void EmitRemoteCallFields(CodeBuilder b) {
        ParameterType.EmitRemoteCallFields(b, CSharp.Escape(PublicVarName));
    }

    public void EmitRemoteWrite(CodeBuilder b) {
        ParameterType.EmitRemoteWrite(b, CSharp.Escape(PublicVarName));
    }

    public void EmitRemoteRead(CodeBuilder b) {
        ParameterType.EmitRemoteRead(b, CSharp.Escape(PublicVarName));
    }

    public override string ToString() {
        if(IsConst) {
            return string.Format("const {0} {1}", ParameterType.OriginalSymbol, VarName);
        } else {
            return string.Format("{0} {1}", ParameterType.OriginalSymbol, VarName);
        }
    }
}