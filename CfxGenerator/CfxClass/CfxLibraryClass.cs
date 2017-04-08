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

public class CfxLibraryClass : CfxClass {

    public override StructCategory Category {
        get {
            return StructCategory.Library;
        }
    }

    public CfxLibraryClass(CefStructType cefStruct, Parser.CallbackStructNode sd, ApiTypeBuilder api)
        : base(cefStruct, sd.Comments) {

        var flist = new List<CefExportFunction>();
        foreach(var fd in sd.CefFunctions) {
            flist.Add(new CefExportFunction(cefStruct, fd, api));
        }
        ExportFunctions = flist.ToArray();

        GetCallbackFunctions(sd, api);
        
        foreach(var cb in CallbackFunctions) {
            var isBoolean = false;
            if(cb.IsPropertyGetter(ref isBoolean)) {
                CefCallbackFunction setter = null;
                foreach(var cb2 in CallbackFunctions) {
                    if(cb2.IsPropertySetterFor(cb)) {
                        setter = cb2;
                        setter.Signature.ManagedParameters[1].IsPropertySetterArgument = true;
                        break;
                    }
                }
                var prop = new StructProperty(cb, setter, isBoolean);
                m_structProperties.Add(prop);
            }
        }
        foreach(var sm in CallbackFunctions) {
            if(!sm.IsProperty) {
                m_structFunctions.Add(sm);
            }
        }

        NeedsWrapFunction = true;
    }

    public override void EmitNativeWrapper(CodeBuilder b) {

        b.AppendComment(CefStruct.Name);
        b.AppendLine();

        foreach(var f in ExportFunctions) {
            f.EmitNativeFunction(b);
        }

        foreach(var cb in CallbackFunctions) {
            b.AppendLine("// {0}", cb);
            b.BeginBlock(cb.Signature.NativeFunctionHeader(CfxName + "_" + cb.Name));
            cb.Signature.EmitNativeCall(b, "self->" + cb.Name);
            b.EndBlock();
            b.AppendLine();
        }

        b.AppendLine();
    }

    protected override void EmitApiDeclarations(CodeBuilder b) {
        if(ExportFunctions.Length > 0) {
            foreach(var f in this.ExportFunctions) {
                f.EmitPInvokeDeclaration(b);
            }
            b.AppendLine();
        }

        foreach(var cb in CallbackFunctions) {
            b.AppendComment(cb.Signature.NativeFunctionHeader(CfxName + "_" + cb.Name));
            CodeSnippets.EmitPInvokeDelegate(b, CfxName + "_" + cb.Name, cb.Signature);
            b.AppendLine();
        }
    }

    public override void EmitPublicClass(CodeBuilder b) {

        b.AppendSummaryAndRemarks(Comments);

        if(CefStruct.IsRefCounted)
            b.BeginClass(ClassName + " : CfxBaseLibrary", GeneratorConfig.ClassModifiers(ClassName));
        else if(CefStruct.IsScoped)
            b.BeginClass(ClassName + " : CfxBaseScoped", GeneratorConfig.ClassModifiers(ClassName));
        else
            throw new Exception();

        b.AppendLine();

        if(CefStruct.IsRefCounted) {
            b.AppendLine("private static readonly WeakCache weakCache = new WeakCache();");
            b.AppendLine();
        }

        b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static");
        b.AppendLine("if(nativePtr == IntPtr.Zero) return null;");
        if(CefStruct.IsRefCounted) {
            b.BeginBlock("lock(weakCache)");
            b.AppendLine("var wrapper = ({0})weakCache.Get(nativePtr);", ClassName);
            b.BeginBlock("if(wrapper == null)");
            b.AppendLine("wrapper = new {0}(nativePtr);", ClassName);
            b.AppendLine("weakCache.Add(wrapper);");
            b.BeginElse();
            //release the new ref and reuse the existing ref
            b.AppendLine("CfxApi.cfx_release(nativePtr);");
            b.EndBlock();
            b.AppendLine("return wrapper;");
            b.EndBlock();
        } else {
            b.AppendLine("return new {0}(nativePtr);", ClassName);
        }
        b.EndBlock();
        b.AppendLine();
        b.AppendLine();

        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName);

        foreach(var f in ExportFunctions) {
            b.AppendLine();
            f.EmitPublicFunction(b, ApiClassName);
        }

        foreach(var p in m_structProperties) {
            b.AppendLine();
            if(p.Setter != null && p.Setter.Comments != null) {
                var summary = new CommentNode();
                summary.FileName = p.Getter.Comments.FileName;

                if(p.Getter.Comments.Lines.Length == 1 && p.Setter.Comments.Lines.Length == 1 && p.Getter.Comments.Lines[0].StartsWith("Get ") && p.Setter.Comments.Lines[0].StartsWith("Set ") && p.Getter.Comments.Lines[0].Substring(4).Equals(p.Setter.Comments.Lines[0].Substring(4))) {
                    summary.Lines = new string[] { "Get or set " + p.Getter.Comments.Lines[0].Substring(4) };
                } else {
                    List<string> summaryLines = new List<string>();
                    summaryLines.AddRange(p.Getter.Comments.Lines);
                    summaryLines.Add("");
                    summaryLines.AddRange(p.Setter.Comments.Lines);
                    summary.Lines = summaryLines.ToArray();
                }

                b.AppendSummaryAndRemarks(summary);
            } else {
                b.AppendSummaryAndRemarks(p.Getter.Comments);
            }
            EmitPublicProperty(b, p);
        }

        foreach(var sf in m_structFunctions) {
            b.AppendLine();
            b.AppendSummaryAndRemarks(sf.Comments);
            if(GeneratorConfig.HasPrivateWrapper(sf.Parent.Name + "::" + sf.Name)) {
                b.BeginFunction(sf.Signature.PublicFunctionHeader(sf.PublicName), "private");
            } else {
                b.BeginFunction(sf.Signature.PublicFunctionHeader(sf.PublicName));
            }
            sf.Signature.EmitPublicCall(b, ApiClassName, sf.CfxApiFunctionName);
            b.EndBlock();
        }

        if(CefStruct.IsRefCounted) {
            b.AppendLine();
            b.BeginFunction("OnDispose", "void", "IntPtr nativePtr", "internal override");
            b.AppendLine("weakCache.Remove(nativePtr);");
            b.AppendLine("base.OnDispose(nativePtr);");
            b.EndBlock();
        }

        b.EndBlock();
    }

    private void EmitPublicProperty(CodeBuilder b, StructProperty p) {

        var propertyName = p.Getter.PublicName;
        if(p.Getter.Name.StartsWith("get_")) {
            propertyName = propertyName.Substring(3);
        }

        propertyName = CSharp.Escape(propertyName);

        b.BeginBlock("public {0} {1}", p.Getter.PublicReturnType.PublicSymbol, propertyName);

        b.BeginBlock("get");
        p.Getter.Signature.EmitPublicCall(b, ApiClassName, p.Getter.CfxApiFunctionName);
        b.EndBlock();
        if(p.Setter != null) {
            b.BeginBlock("set", p.Getter.PublicReturnType.PublicSymbol);
            p.Setter.Signature.EmitPublicCall(b, ApiClassName, p.Setter.CfxApiFunctionName);
            b.EndBlock();
        }
        b.EndBlock();
    }

    public override void EmitRemoteCalls(CodeBuilder b, List<string> callIds) {

        b.AppendLine();

        foreach(var f in ExportFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                if(!f.PrivateWrapper) {
                    b.BeginRemoteCallClass(ClassName + f.PublicName, callIds);
                    f.Signature.EmitRemoteCallClassBody(b, ApiClassName, f.CfxApiFunctionName);
                    b.EndBlock();
                    b.AppendLine();
                }
            }
        }

        foreach(var cb in CallbackFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(CefStruct.Name + "::" + cb.Name)) {
                b.BeginRemoteCallClass(ClassName + cb.RemoteCallClassName, callIds);
                cb.Signature.EmitRemoteCallClassBody(b, ApiClassName, cb.CfxApiFunctionName);
                b.EndBlock();
                b.AppendLine();
            }
        }
    }


    public override void EmitRemoteClass(CodeBuilder b) {

        b.AppendLine();

        b.AppendSummaryAndRemarks(Comments, true, Category == StructCategory.Client);
        b.BeginClass(RemoteClassName + " : CfrBaseLibrary", GeneratorConfig.ClassModifiers(RemoteClassName));
        b.AppendLine();

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

        foreach(var f in ExportFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(f.Name) && !f.PrivateWrapper) {
                f.EmitRemoteFunction(b);
                b.AppendLine();
            }
        }

        b.AppendLine();

        b.AppendLine("private {0}(RemotePtr remotePtr) : base(remotePtr) {{}}", RemoteClassName);

        foreach(var p in m_structProperties) {
            if(GeneratorConfig.CreateRemoteProxy(CefStruct.Name + "::" + p.Getter.Name)) {

                var cb = p.Getter;

                b.AppendLine();

                if(p.Setter != null && p.Setter.Comments != null) {
                    List<string> summaryLines = new List<string>();
                    summaryLines.AddRange(p.Getter.Comments.Lines);
                    summaryLines.Add("");
                    summaryLines.AddRange(p.Setter.Comments.Lines);
                    var summary = new CommentNode();
                    summary.Lines = summaryLines.ToArray();
                    summary.FileName = p.Getter.Comments.FileName;
                    //If RemoteClassName = "CfrRequest" AndAlso p.Getter.PublicName = "GetFlags" Then Stop
                    b.AppendSummaryAndRemarks(summary, true);
                } else {
                    b.AppendSummaryAndRemarks(p.Getter.Comments, true);
                }

                b.BeginBlock("public {0} {1}", cb.RemoteReturnType.RemoteSymbol, p.PropertyName);
                b.BeginBlock("get");
                p.Getter.Signature.EmitRemoteCall(b, p.Getter.RemoteCallId, false);
                b.EndBlock();
                if(p.Setter != null) {
                    b.BeginBlock("set");
                    p.Setter.Signature.EmitRemoteCall(b, p.Setter.RemoteCallId, false);
                    b.EndBlock();
                }
                b.EndBlock();
                
            }
        }

        foreach(var cb in m_structFunctions) {
            if(GeneratorConfig.CreateRemoteProxy(CefStruct.Name + "::" + cb.Name)) {
                b.AppendLine();
                b.AppendSummaryAndRemarks(cb.Comments, true);
                b.BeginFunction(cb.PublicName, cb.RemoteReturnType.RemoteSymbol, cb.Signature.RemoteParameterList);
                cb.Signature.EmitRemoteCall(b, cb.RemoteCallId, false);
                b.EndBlock();
            }
        }


        b.EndBlock();

    }
}
