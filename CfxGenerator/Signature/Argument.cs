// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class Argument {
    public readonly ApiType ArgumentType;
    public readonly string VarName;
    public readonly int Index;

    public readonly bool IsConst;

    public bool IsThisArgument;
    public bool IsPropertySetterArgument;

    public Argument(Parser.ParameterData ad, ApiTypeBuilder api, int index) {
        this.ArgumentType = api.GetApiType(ad.ParameterType, ad.IsConst);
        this.VarName = ad.Var;
        this.Index = index;
        this.IsConst = ad.IsConst;
        this.IsThisArgument = this.VarName.Equals("self");
    }

    public Argument(Argument replacedArg, ApiType newType) {
        this.ArgumentType = newType;
        this.VarName = replacedArg.VarName;
        this.Index = replacedArg.Index;
        this.IsConst = replacedArg.IsConst;
        this.IsThisArgument = replacedArg.IsThisArgument;
        this.IsPropertySetterArgument = replacedArg.IsPropertySetterArgument;
    }

    public bool TypeIsRefCounted {
        get { return ArgumentType.IsCefStructPtrType && ArgumentType.AsCefStructPtrType.Struct.ClassBuilder.IsRefCounted; }
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
        get { return ArgumentType.PublicEventConstructorArgument(VarName); }
    }

    public string OriginalParameter {
        get {
            if(IsConst) {
                return string.Concat("const ", ArgumentType.OriginalSymbol, " ", VarName);
            } else {
                return string.Concat(ArgumentType.OriginalSymbol, " ", VarName);
            }
        }
    }

    public string NativeCallParameter {
        get { return ArgumentType.NativeCallParameter(VarName, IsConst); }
    }

    public string NativeCallArgument {
        get { return ArgumentType.NativeCallArgument(VarName); }
    }

    public string NativeCallbackParameter {
        get { return ArgumentType.NativeCallbackParameter(VarName, IsConst); }
    }

    public string NativeCallbackArgument {
        get { return ArgumentType.NativeCallbackArgument(VarName); }
    }

    public string PInvokeCallParameter {
        get { return ArgumentType.PInvokeCallParameter(VarName); }
    }

    public string PInvokeCallbackParameter {
        get { return ArgumentType.PInvokeCallbackParameter(VarName); }
    }

    public string PublicEventConstructorParameter {
        get { return ArgumentType.PublicEventConstructorParameter(VarName); }
    }

    public string PublicCallParameter {
        get {
            if(IsThisArgument)
                return null;
            return ArgumentType.PublicCallParameter(PublicVarName);
        }
    }

    public string PublicCallArgument {
        get {
            if(IsThisArgument)
                return "NativePtr";
            return ArgumentType.PublicCallArgument(PublicVarName);
        }
    }

    public string ProxyCallArgument {
        get {
            return ArgumentType.ProxyCallArgument(PublicVarName);
        }
    }

    public string RemoteCallParameter {
        get {
            if(IsThisArgument)
                return null;
            return ArgumentType.RemoteCallParameter(PublicVarName);
        }
    }

    public void EmitPreNativeCallStatements(CodeBuilder b) {
        ArgumentType.EmitPreNativeCallStatements(b, VarName);
    }

    public void EmitPostNativeCallStatements(CodeBuilder b) {
        ArgumentType.EmitPostNativeCallStatements(b, VarName);
    }

    public void EmitPreNativeCallbackStatements(CodeBuilder b) {
        ArgumentType.EmitPreNativeCallbackStatements(b, VarName);
    }

    public void EmitPostNativeCallbackStatements(CodeBuilder b) {
        ArgumentType.EmitPostNativeCallbackStatements(b, VarName);
    }

    public void EmitPrePublicCallStatements(CodeBuilder b) {
        ArgumentType.EmitPrePublicCallStatements(b, PublicVarName);
    }

    public void EmitPostPublicStatements(CodeBuilder b) {
        ArgumentType.EmitPostPublicCallStatements(b, PublicVarName);
    }

    public void EmitPreProxyCallStatements(CodeBuilder b) {
        ArgumentType.EmitPreProxyCallStatements(b, PublicVarName);
    }

    public void EmitPostProxyCallStatements(CodeBuilder b) {
        ArgumentType.EmitPostProxyCallStatements(b, PublicVarName);
    }

    public void EmitPreRemoteCallStatements(CodeBuilder b) {
        ArgumentType.EmitPreRemoteCallStatements(b, PublicVarName);
    }

    public void EmitPostRemoteCallStatements(CodeBuilder b) {
        ArgumentType.EmitPostRemoteCallStatements(b, PublicVarName);
    }

    public void EmitPublicEventCtorStatements(CodeBuilder b) {
        ArgumentType.EmitPublicEventCtorStatements(b, VarName);
    }

    public void EmitPublicEventArgGetterStatements(CodeBuilder b) {
        ArgumentType.EmitPublicEventArgGetterStatements(b, VarName);
    }

    public void EmitPublicEventArgSetterStatements(CodeBuilder b) {
        ArgumentType.EmitPublicEventArgSetterStatements(b, VarName);
    }

    public void EmitRemoteEventArgGetterStatements(CodeBuilder b) {
        ArgumentType.EmitRemoteEventArgGetterStatements(b, VarName);
    }

    public void EmitRemoteEventArgSetterStatements(CodeBuilder b) {
        ArgumentType.EmitRemoteEventArgSetterStatements(b, VarName);
    }

    public void EmitPublicEventArgFields(CodeBuilder b) {
        ArgumentType.EmitPublicEventArgFields(b, VarName);
    }

    public void EmitRemoteEventArgFields(CodeBuilder b) {
        ArgumentType.EmitRemoteEventArgFields(b, VarName);
    }

    public void EmitPostPublicRaiseEventStatements(CodeBuilder b) {
        ArgumentType.EmitPostPublicRaiseEventStatements(b, VarName);
    }

    public void EmitPostRemoteRaiseEventStatements(CodeBuilder b) {
        ArgumentType.EmitPostRemoteRaiseEventStatements(b, VarName);
    }

    public virtual void EmitRemoteCallFields(CodeBuilder b) {
        ArgumentType.EmitRemoteCallFields(b, CSharp.Escape(PublicVarName));
    }

    public void EmitRemoteWrite(CodeBuilder b) {
        ArgumentType.EmitRemoteWrite(b, CSharp.Escape(PublicVarName));
    }

    public void EmitRemoteRead(CodeBuilder b) {
        ArgumentType.EmitRemoteRead(b, CSharp.Escape(PublicVarName));
    }

    public override string ToString() {
        if(IsConst) {
            return string.Format("const {0} {1}", ArgumentType.OriginalSymbol, VarName);
        } else {
            return string.Format("{0} {1}", ArgumentType.OriginalSymbol, VarName);
        }
    }
}