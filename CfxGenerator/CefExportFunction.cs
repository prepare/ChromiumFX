// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;

public class CefExportFunction {

    public readonly string Name;
    public readonly Signature Signature;
    public readonly bool PrivateWrapper;

    public CommentNode Comments { get; private set; }

    public readonly CefType Parent;

    public int ApiIndex;

    public readonly CefPlatform Platform;

    public CefExportFunction(CefType parent, Parser.FunctionNode fd, ApiTypeBuilder api, CefPlatform platform) {
        this.Name = fd.Name;
        this.Comments = fd.Comments;
        this.Signature = Signature.Create(SignatureType.LibraryCall, CefName, CefConfig, CallMode, fd.Signature, api);
        this.PrivateWrapper = GeneratorConfig.HasPrivateWrapper(this.Name);
        this.Parent = parent;
        this.Platform = platform;
    }

    public CefExportFunction(CefType parent, Parser.FunctionNode fd, ApiTypeBuilder api)
        : this(parent, fd, api, CefPlatform.Independent) {
    }

    public string CfxName {
        get { return "cfx_" + Name.Substring(4); }
    }

    public ApiType ReturnType {
        get { return Signature.PublicReturnType; }
    }

    public string PublicName {
        get { return CSharp.ApplyStyle(Name).Substring(Parent == null ? 3 : Parent.ClassName.Length) + (PrivateWrapper ? "Private" : ""); }
    }

    public void EmitPInvokeDeclaration(CodeBuilder b) {
        b.AppendComment(this.ToString());
        CodeSnippets.EmitPInvokeDelegate(b, CfxName, Signature);
    }

    public void EmitNativeFunction(CodeBuilder b) {
        b.AppendComment(this.ToString());
        if(Platform != CefPlatform.Independent) {
            b.AppendLine("#ifdef CFX_" + Platform.ToString().ToUpperInvariant());
        }
        b.BeginBlock(Signature.NativeFunctionHeader(CfxName));
        Signature.EmitNativeCall(b, Name);
        b.EndBlock();
        if(Platform != CefPlatform.Independent) {
            b.AppendLine("#else");
            b.AppendLine("#define {0} 0", CfxName);
            b.AppendLine("#endif");
        }
    }

    public void EmitPublicFunction(CodeBuilder b, string apiClassName) {
        b.AppendSummaryAndRemarks(Comments);

        var modifiers = PrivateWrapper ? "private" : "public";

        if(Signature.ManagedParameters.Length == 0 || !Signature.ManagedParameters[0].IsThisArgument) {
            modifiers += " static";
        }

        b.BeginFunction(Signature.PublicFunctionHeader(PublicName), modifiers);
        if(Platform != CefPlatform.Independent) {
            b.AppendLine("CfxApi.CheckPlatformOS(CfxPlatformOS.{0});", Platform.ToString());
        }

        Signature.EmitPublicCall(b, apiClassName, CfxApiFunctionName);
        b.EndBlock();
    }

    public void EmitRemoteFunction(CodeBuilder b) {
        b.AppendSummaryAndRemarks(Comments, true);

        if(Parent == null) {
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, Signature.RemoteParameterList, "public static");
            Signature.EmitRemoteCall(b, RemoteCallId, true);
        } else {
            var sig = Signature.RemoteParameterList;
            if(string.IsNullOrWhiteSpace(sig)) {
                sig = "CfrRuntime remoteRuntime";
            } else {
                sig = "CfrRuntime remoteRuntime, " + sig;
            }
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, Signature.RemoteParameterList, "public static");
            Signature.EmitRemoteCall(b, RemoteCallId, true);
        }
        b.EndBlock();
    }

    public override string ToString() {
        return string.Format("CEF_EXPORT {1} {0}({2});", Name, ReturnType, Signature);
    }

    public CfxCallMode CallMode {
        get { return CfxCallMode.FunctionCall; }
    }

    public string CefName {
        get { return Name; }
    }

    public string CfxApiFunctionName {
        get { return CfxName; }
    }

    public string PublicFunctionName {
        get { return PublicName; }
    }

    public string PropertyName {
        get { return null; }
    }

    public string RemoteCallId {
        get { return PublicClassName + PublicName + "RemoteCall"; }
    }

    public string PublicClassName {
        get {
            if(Parent != null) {
                return Parent.ClassName;
            } else {
                return "CfxRuntime";
            }
        }
    }

    public CefConfigNode CefConfig {
        get { return new CefConfigNode(); }
    }
}