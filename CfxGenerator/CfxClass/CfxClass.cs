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

public class StructMember {
    public readonly ApiType MemberType;

    public readonly string Name;

    public int ApiIndex;

    public readonly CommentData Comments;
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

    public StructMember(CefStructType parent, StructCategory structCategory, Parser.StructMemberData smd, ApiTypeBuilder api) {

        Debug.Assert(structCategory == StructCategory.Values);
        Debug.Assert(smd.MemberType != null);

        Name = smd.Name;
        Comments = smd.Comments;
        cefConfig = smd.CefConfig;

        MemberType = api.GetApiType(smd.MemberType, false);
        if(MemberType.Name == "int" && Comments != null) {
            foreach(var c in Comments.Lines) {
                if(c.Contains("true") || c.Contains("false")) {
                    MemberType = BooleanInteger.Convert(MemberType);
                }
            }
        }
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

    public override string ToString() {
        return string.Format("{0} {1}", MemberType, Name);
    }
}

public enum StructCategory {
    Values,
    ApiCalls,
    ApiCallbacks
}

public abstract class CfxClass {

    public static CfxClass Create(CefStructType cefStruct, Parser.StructData sd, ApiTypeBuilder api) {
        if(sd.CefConfig != null) {
            switch(sd.CefConfig.Source) {
                case "client":
                    return new CfxClientClass(cefStruct, sd, api);
                case "library":
                    return new CfxLibraryClass(cefStruct, sd, api);
                default:
                    Debug.Assert(false);
                    throw new Exception();
            }
        } else {
            Debug.Assert(sd.StructMembers.Count == 1 || sd.StructMembers[1].CallbackSignature == null);
            return new CfxValueClass(cefStruct, sd, api);
        }
    }

    protected readonly CefStructType CefStruct;
    public CefExportFunction[] ExportFunctions;
    public CefCallbackFunction[] CallbackFunctions;

    public StructMember[] StructMembers;

    protected readonly CommentData Comments;

    protected readonly List<StructProperty> m_structProperties = new List<StructProperty>();

    protected readonly List<CefCallbackFunction> m_structFunctions = new List<CefCallbackFunction>();

    public readonly StructCategory Category;
    protected readonly string OriginalSymbol;
    protected readonly string CfxNativeSymbol;
    protected readonly string CfxName;
    protected readonly string ClassName;
    protected readonly string ApiClassName;

    protected readonly string RemoteClassName;

    protected bool NeedsWrapping;

    protected CfxClass(CefStructType cefStruct, Parser.StructData sd, ApiTypeBuilder api) {

        CefStruct = cefStruct;
        OriginalSymbol = cefStruct.OriginalSymbol;
        CfxNativeSymbol = cefStruct.CfxNativeSymbol;
        CfxName = cefStruct.CfxName;
        ClassName = cefStruct.ClassName;
        ApiClassName = ClassName.Substring(3);
        RemoteClassName = cefStruct.RemoteClassName;
        Comments = sd.Comments;

        if(sd.CefConfig != null) {
            switch(sd.CefConfig.Source) {
                case "client":
                    Category = StructCategory.ApiCallbacks;
                    break;

                case "library":
                    Category = StructCategory.ApiCalls;
                    break;

                default:
                    Debug.Assert(false);
                    break;
            }
        } else {
            Debug.Assert(sd.StructMembers.Count == 1 || sd.StructMembers[1].CallbackSignature == null);
            Category = StructCategory.Values;
        }

        Debug.Assert(sd.CefFunctions.Count == 0 || Category == StructCategory.ApiCalls);
    }

    protected void GetCallbackFunctions(Parser.StructData sd, ApiTypeBuilder api) {
        var cblist = new List<CefCallbackFunction>();
        for(int i = 1; i < sd.StructMembers.Count; ++i) {
            var sm = sd.StructMembers[i];
            Debug.Assert(sm.CallbackSignature != null);
            cblist.Add(new CefCallbackFunction(CefStruct, Category, sm.Name, sm.CefConfig, sm.CallbackSignature, api, sm.Comments));
        }
        CallbackFunctions = cblist.ToArray();
    }

    public bool IsRefCounted {
        get { return Category != StructCategory.Values; }
    }

    public abstract void EmitNativeWrapper(CodeBuilder b);

    public void EmitApiClass(CodeBuilder b) {

        b.BeginClass(ClassName.Substring(3), "internal static");
        b.AppendLine();

        b.BeginBlock("static {0} ()", ApiClassName);
        b.AppendLine("CfxApiLoader.Load{0}Api();", ClassName);
        b.EndBlock();
        b.AppendLine();

        EmitApiDeclarations(b);

        b.EndBlock();
    }

    protected abstract void EmitApiDeclarations(CodeBuilder b);

    public abstract void EmitPublicClass(CodeBuilder b);

    public abstract void EmitRemoteCalls(CodeBuilder b, List<string> callIds);

    protected void EmitRemoteConstructorCalls(CodeBuilder b, List<string> callIds) {
        b.BeginRemoteCallClass(ClassName + "Ctor", false, callIds);
        b.AppendLine();
        b.AppendLine("internal IntPtr __retval;");
        b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }");
        b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }");
        b.AppendLine();
        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
        b.AppendLine("__retval = RemoteProxy.Wrap(new {0}());", ClassName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
    }

    public abstract void EmitRemoteClass(CodeBuilder b);

    protected void EmitRemoteClassWrapperFunction(CodeBuilder b) {
        b.BeginFunction("Wrap", RemoteClassName, "IntPtr proxyId", "internal static");
        b.AppendLine("if(proxyId == IntPtr.Zero) return null;");
        b.AppendLine("var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;");
        b.BeginBlock("lock(weakCache)");
        b.AppendLine("var cfrObj = ({0})weakCache.Get(proxyId);", RemoteClassName);
        b.BeginBlock("if(cfrObj == null)");
        b.AppendLine("cfrObj = new {0}(proxyId);", RemoteClassName);
        b.AppendLine("weakCache.Add(proxyId, cfrObj);");
        b.EndBlock();
        b.AppendLine("return cfrObj;");
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();
    }
}
