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
    Library,
    Client
}

public abstract class CfxClass {

    public static CfxClass Create(CefStructType cefStruct, Parser.CallbackStructNode s, ApiTypeBuilder api) {
        if(s.CefConfig != null) {
            switch(s.CefConfig.Source) {
                case "client":
                    return new CfxClientClass(cefStruct, s, api);
                case "library":
                    return new CfxLibraryClass(cefStruct, s, api);
                default:
                    Debug.Assert(false);
                    throw new Exception();
            }
        } else {
            throw new Exception();
        }
    }

    public static CfxClass Create(CefStructType cefStruct, Parser.ValueStructNode s, ApiTypeBuilder api) {
        return new CfxValueClass(cefStruct, s, api);
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

    protected readonly string OriginalSymbol;
    protected readonly string CfxNativeSymbol;
    protected readonly string CfxName;
    protected readonly string ClassName;
    protected readonly string ApiClassName;

    protected readonly string RemoteClassName;

    public bool NeedsWrapFunction;

    public abstract StructCategory Category { get; }

    protected CfxClass(CefStructType cefStruct, CommentNode comments) {

        CefStruct = cefStruct;
        OriginalSymbol = cefStruct.OriginalSymbol;
        CfxNativeSymbol = cefStruct.CfxNativeSymbol;
        CfxName = cefStruct.CfxName;
        ClassName = cefStruct.ClassName;
        ApiClassName = ClassName.Substring(3);
        RemoteClassName = cefStruct.RemoteClassName;
        Comments = comments;
        
    }

    protected void GetCallbackFunctions(Parser.CallbackStructNode sd, ApiTypeBuilder api) {
        var cblist = new List<CefCallbackFunction>();
        foreach(var sm in sd.CefCallbacks) {
            cblist.Add(new CefCallbackFunction(CefStruct, Category, sm.Name, sm.CefConfig, sm.Signature, api, sm.Comments));
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
    
}
