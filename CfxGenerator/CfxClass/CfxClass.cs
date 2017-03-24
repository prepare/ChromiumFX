// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class StructMember {
    public readonly ApiType MemberType;

    public readonly string Name;

    public int ApiIndex;

    public readonly CommentNode Comments;
    private readonly CefConfigNode cefConfig;

    private string cppApiName {
        get {
            if(cefConfig != null) {
                return cefConfig.CppApiName;
            } else {
                return null;
            }
        }
    }

    public StructMember(CefStructType parent, StructCategory structCategory, Parser.StructMemberNode smd, ApiTypeBuilder api) {

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

    public static CfxClass Create(CefStructType cefStruct, Parser.StructNode sd, ApiTypeBuilder api) {
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

    public CefCallbackFunction[] RemoteCallbackFunctions {
        get {
            var l = new List<CefCallbackFunction>(CallbackFunctions.Length);
            foreach(var cb in CallbackFunctions) {
                if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name))
                    l.Add(cb);
            }
            return l.ToArray();
        }
    }

    public StructMember[] StructMembers;

    protected readonly CommentNode Comments;

    protected readonly List<StructProperty> m_structProperties = new List<StructProperty>();

    protected readonly List<CefCallbackFunction> m_structFunctions = new List<CefCallbackFunction>();

    public readonly StructCategory Category;
    protected readonly string OriginalSymbol;
    protected readonly string CfxNativeSymbol;
    protected readonly string CfxName;
    protected readonly string ClassName;
    protected readonly string ApiClassName;

    protected readonly string RemoteClassName;

    public bool NeedsWrapFunction;

    protected CfxClass(CefStructType cefStruct, Parser.StructNode sd, ApiTypeBuilder api) {

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

    protected void GetCallbackFunctions(Parser.StructNode sd, ApiTypeBuilder api) {
        var cblist = new List<CefCallbackFunction>();
        for(int i = 0; i < sd.StructMembers.Count; ++i) {
            var sm = sd.StructMembers[i];
            Debug.Assert(sm.CallbackSignature != null);
            cblist.Add(new CefCallbackFunction(CefStruct, Category, sm.Name, sm.CefConfig, sm.CallbackSignature, api, sm.Comments));
        }
        CallbackFunctions = cblist.ToArray();
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

    public abstract void EmitRemoteClass(CodeBuilder b);

    protected void EmitRemoteClassWrapperFunction(CodeBuilder b) {
        b.BeginFunction("Wrap", RemoteClassName, "RemotePtr remotePtr", "internal static");
        b.AppendLine("if(remotePtr == RemotePtr.Zero) return null;");
        b.AppendLine("var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;");
        b.BeginBlock("lock(weakCache)");
        b.AppendLine("var cfrObj = ({0})weakCache.Get(remotePtr.ptr);", RemoteClassName);
        b.BeginBlock("if(cfrObj == null)");
        b.AppendLine("cfrObj = new {0}(remotePtr);", RemoteClassName);
        b.AppendLine("weakCache.Add(remotePtr.ptr, cfrObj);");
        b.EndBlock();
        b.AppendLine("return cfrObj;");
        b.EndBlock();
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();
    }
}
