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

public class CefExportFunction : ISignatureOwner {

    public class Comparer : IComparer<CefExportFunction> {

        public int Compare(CefExportFunction x, CefExportFunction y) {
            return string.Compare(x.Name, y.Name);
        }
    }

    public readonly string Name;
    public readonly Signature Signature;
    public readonly bool PrivateWrapper;

    public CommentData Comments { get; private set; }

    public readonly CefType Parent;

    public int ApiIndex;

    public readonly CefPlatform Platform;

    public CefExportFunction(CefType parent, Parser.FunctionData fd, ApiTypeBuilder api, CefPlatform platform) {
        this.Name = fd.Name;
        this.Comments = fd.Comments;
        this.Signature = Signature.Create(SignatureType.LibraryCall, this, fd.Signature, api);
        this.PrivateWrapper = GeneratorConfig.HasPrivateWrapper(this.Name);
        this.Parent = parent;
        this.Platform = platform;
    }

    public CefExportFunction(CefType parent, Parser.FunctionData fd, ApiTypeBuilder api)
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

    public string ProxyFunctionName {
        get { return CSharp.ApplyStyle(CfxName).Substring(Parent == null ? 3 : 0); }
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

    public void EmitPublicFunction(CodeBuilder b) {
        b.AppendSummaryAndRemarks(Comments);

        var modifiers = PrivateWrapper ? "private" : "public";

        if(Signature.ManagedArguments.Length == 0 || !Signature.ManagedArguments[0].IsThisArgument) {
            modifiers += " static";
        }

        b.BeginFunction(Signature.PublicFunctionHeader(PublicName), modifiers);
        if(Platform != CefPlatform.Independent) {
            b.AppendLine("CfxApi.CheckPlatformOS(CfxPlatformOS.{0});", Platform.ToString());
        }

        Signature.EmitPublicCall(b);
        b.EndBlock();
    }

    public void EmitRemoteFunction(CodeBuilder b) {
        b.AppendSummaryAndRemarks(Comments, true);

        if(Parent == null) {
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, Signature.RemoteParameterList, "public static");
            Signature.EmitRemoteCall(b);
        } else {
            var sig = Signature.RemoteParameterList;
            if(string.IsNullOrWhiteSpace(sig)) {
                sig = "CfrRuntime remoteRuntime";
            } else {
                sig = "CfrRuntime remoteRuntime, " + sig;
            }
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, Signature.RemoteParameterList, "public static");
            Signature.EmitRemoteCall(b);
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
        get { return PublicClassName + PublicName + "RenderProcessCall"; }
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

    public CefConfigData CefConfig {
        get { return new CefConfigData(); }
    }
}