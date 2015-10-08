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
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class WrapperGenerator {
    private readonly CefApiDeclarations decls;

    private readonly CefApiDeclarations remoteDecls;

    private readonly int maxCallbackCount;

    public WrapperGenerator(CefApiDeclarations decls) {
        this.decls = decls;
        this.remoteDecls = decls.GetRemoteDeclarations();

        //For Each f In decls.ExportFunctions
        //    f.Signature.FindArrayArguments()
        //Next

        foreach(var t in decls.CefStructTypes) {
            if(t.ClassBuilder.Category == StructCategory.ApiCallbacks) {
                if(maxCallbackCount < t.ClassBuilder.StructMembers.Count() - 1) {
                    maxCallbackCount = t.ClassBuilder.StructMembers.Count() - 1;
                }
            }
            //For Each sm In t.StructMembers
            //    If sm.MemberType.IsCefCallbackType Then
            //        sm.MemberType.AsCefCallbackType.Signature.FindArrayArguments()
            //    End If
            //Next
        }
    }

    public void Run() {
        var fileManager = new GeneratedFileManager(System.IO.Path.Combine("libcfx", "Generated"));
        BuildLibCfx(fileManager);
        BuildAmalgamation(fileManager);
        BuildHeaders(fileManager);
        BuildFunctionPointers(fileManager);
        fileManager.DeleteObsoleteFiles();

        generatedCSFiles = new List<string>();

		fileManager = new GeneratedFileManager(System.IO.Path.Combine("ChromiumFX", "Generated"));
        BuildPInvokeApi(fileManager);
        BuildEnums(fileManager);
        BuildCfxRuntime(fileManager);
        BuildApiClasses(fileManager, StructCategory.ApiCalls);
        BuildApiClasses(fileManager, StructCategory.ApiCallbacks);
        BuildApiClasses(fileManager, StructCategory.Values);
        fileManager.DeleteObsoleteFiles();
        generatedCSFiles.AddRange(fileManager.GetNewFiles());

		fileManager = new GeneratedFileManager(System.IO.Path.Combine("ChromiumFX", "Generated", "Remote"));
        BuildRemoteCalls(fileManager);
        BuildCfrRuntime(fileManager);
        BuildRemoteClasses(fileManager);
        fileManager.DeleteObsoleteFiles();
        generatedCSFiles.AddRange(fileManager.GetNewFiles());

        generatedCSFiles.Sort();

        var projectFile = Path.Combine("ChromiumFX", "ChromiumFX.csproj");
        var project = File.ReadAllText(projectFile);
        var ex = new Regex("(?:\\s*<Compile Include=\"Generated(?:\\\\\\w+)*?\\\\\\w+.cs\" />)+");
        var p1 = ex.Replace(project, ProjectMatch);
        if(!project.Equals(p1)) {
            File.WriteAllText(projectFile, p1);
        }
    }

    private List<string> generatedCSFiles;

    private string ProjectMatch(Match m) {
        if(generatedCSFiles != null) {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            for(var i = 0; i <= generatedCSFiles.Count - 2; i++) {
                sb.AppendFormat("    <Compile Include=\"{0}\" />", generatedCSFiles[i].Substring(11));
                sb.Append("\r\n");
            }
            sb.AppendFormat("    <Compile Include=\"{0}\" />", generatedCSFiles[generatedCSFiles.Count - 1].Substring(11));
            generatedCSFiles = null;
            return sb.ToString();
        } else {
            return string.Empty;
        }
    }

    private void BuildAmalgamation(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();
        var files = fileManager.GetNewFiles();
        foreach(var f in files) {
            b.AppendLine("#include \"{0}\"", System.IO.Path.GetFileName(f));
        }
        b.AppendLine();
        fileManager.WriteFileIfContentChanged("cfx_amalgamation.c", b.ToString());
    }

    private void BuildHeaders(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();
		var files = Directory.GetFiles(System.IO.Path.Combine("cef", "include", "capi"));
        foreach(var f in files) {
            var f1 = f.Replace("\\", "/");
            b.AppendLine("#include \"{0}\"", f1.Substring(4));
        }
        b.AppendLine();
        fileManager.WriteFileIfContentChanged("cef_headers.h", b.ToString());
        b.Clear();
    }

    private void BuildFunctionPointers(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();
        var ff = new List<CefExportFunction>(decls.AllExportFunctions());
        ff.AddRange(decls.StringCollectionFunctions);

        foreach(var f in ff) {
            var retSymbol = f.ReturnType.OriginalSymbol;
            if(f.Signature.ReturnValueIsConst) {
                retSymbol = "const " + retSymbol;
            }
            if(f.Platform != CefPlatform.Independent) {
                b.AppendLine("#ifdef CFX_" + f.Platform.ToString().ToUpperInvariant());
            }
            b.AppendLine("static {0} (*{1}_ptr)({2});", retSymbol, f.Name, f.Signature.OriginalSignature);
            if(f.Platform != CefPlatform.Independent) {
                b.AppendLine("#endif");
            }
        }
        b.AppendLine();

        b.BeginBlock("static void cfx_load_cef_function_pointers(void *libcef)");
        foreach(var f in ff) {
            if((f.Name != "cef_api_hash")) {
                if(f.Platform != CefPlatform.Independent) {
                    b.AppendLine("#ifdef CFX_" + f.Platform.ToString().ToUpperInvariant());
                }
                b.AppendLine("{0}_ptr = ({1} (*)({2}))cfx_platform_get_fptr(libcef, \"{0}\");", f.Name, f.ReturnType.OriginalSymbol, f.Signature.OriginalSignatureUnnamed);
                if(f.Platform != CefPlatform.Independent) {
                    b.AppendLine("#endif");
                }
            }
        }
        b.EndBlock();
        b.AppendLine();

        foreach(var f in ff) {
            if(f.Platform != CefPlatform.Independent) {
                b.AppendLine("#ifdef CFX_" + f.Platform.ToString().ToUpperInvariant());
            }
            b.AppendLine("#define {0} {0}_ptr", f.Name);
            if(f.Platform != CefPlatform.Independent) {
                b.AppendLine("#endif");
            }
        }
        b.AppendLine();

        fileManager.WriteFileIfContentChanged("cef_function_pointers.c", b.ToString());
        b.Clear();

        var cfxfuncs = decls.GetCfxApiFunctionNames();

        b.BeginBlock("static void* cfx_function_pointers[{0}] = ", cfxfuncs.Count());
        for(var i = 0; i <= cfxfuncs.Length - 1; i++) {
            b.AppendLine("(void*){0},", cfxfuncs[i]);
        }
        b.EndBlock(";");

        fileManager.WriteFileIfContentChanged("cfx_function_pointers.c", b.ToString());
    }

    private void BuildLibCfx(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();

        foreach(var f in decls.ExportFunctions) {
            f.EmitNativeFunction(b);
            b.AppendLine();
        }
        b.AppendLine();

        fileManager.WriteFileIfContentChanged("cfx_runtime.c", b.ToString());

        b.Clear();

        foreach(var t in decls.CefStructTypes) {
            t.ClassBuilder.EmitNativeWrapper(b);
            fileManager.WriteFileIfContentChanged(t.CfxName + ".c", b.ToString());
            b.Clear();
        }

        foreach(var f in decls.StringCollectionFunctions) {
            f.EmitNativeFunction(b);
            b.AppendLine();
        }

        fileManager.WriteFileIfContentChanged("cfx_string_collections.c", b.ToString());
        b.Clear();
    }

    private void BuildEnums(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();
        b.BeginCfxNamespace();
        foreach(var t in decls.CefEnumTypes) {
            t.EmitEnum(b);
        }
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("CfxEnums.cs", b.ToString());
    }

    private void BuildCfxRuntime(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();
        b.BeginCfxNamespace();
        b.BeginClass("CfxRuntime", "public partial");
        b.AppendLine();

        var lxFuncs = new List<CefExportFunction>();
        foreach(var f in decls.ExportFunctions) {
            if(f.Platform == CefPlatform.Independent) {
                f.EmitPublicFunction(b);
                b.AppendLine();
            } else {
                lxFuncs.Add(f);
            }
        }
        b.BeginClass("Linux", "public");
        b.AppendLine();
        foreach(var f in lxFuncs) {
            f.EmitPublicFunction(b);
            b.AppendLine();
        }
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("CfxRuntime.cs", b.ToString());
    }

    private void BuildCfrRuntime(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();

        b.BeginCfxNamespace(".Remote");
        b.BeginClass("CfrRuntime", "public partial");
        b.AppendLine();

        foreach(var f in remoteDecls.ExportFunctions) {
            if(!f.PrivateWrapper) {
                f.EmitRemoteFunction(b);
                b.AppendLine();
            }
        }
        b.EndBlock();
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("CfrRuntime.cs", b.ToString());
    }

    private void BuildPInvokeApi(GeneratedFileManager fileManager) {
        var b = new CodeBuilder();

        b.AppendLine("using System.Runtime.InteropServices;");
        b.AppendLine();
        b.BeginCfxNamespace();
        b.BeginClass("CfxApi", "internal partial");

        b.AppendLine();

        b.AppendComment("global cef export functions");
        b.AppendLine();

        foreach(var f in decls.ExportFunctions) {
            f.EmitPInvokeDeclaration(b);
        }
        b.AppendLine();

        foreach(var f in decls.StringCollectionFunctions) {
            f.EmitPInvokeDeclaration(b);
        }
        b.AppendLine();

        b.AppendLine();

        foreach(var t in decls.CefStructTypes) {
            t.ClassBuilder.EmitApiDeclarations(b);
            b.AppendLine();
        }

        b.EndBlock();
        b.EndBlock();

        fileManager.WriteFileIfContentChanged("CfxApi.cs", b.ToString());
        b.Clear();

        var cfxfuncs = decls.GetCfxApiFunctionNames();
        b.BeginCfxNamespace();
        b.BeginClass("CfxApiLoader", "internal partial");
        b.BeginBlock("internal enum FunctionIndex");
        foreach(var f in cfxfuncs) {
            b.AppendLine(f + ",");
        }

        b.EndBlock();
        b.AppendLine();

        b.BeginFunction("void LoadCfxRuntimeApi()", "internal static");
        foreach(var f in decls.ExportFunctions) {
            if(f.Platform != CefPlatform.Independent) {
                b.BeginIf("CfxApi.PlatformOS == CfxPlatformOS.{0}", f.Platform.ToString());
            }
            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName);
            if(f.Platform != CefPlatform.Independent) {
                b.EndBlock();
            }
        }
        b.EndBlock();
        b.AppendLine();

        b.BeginFunction("void LoadStringCollectionApi()", "internal static");
        b.AppendLine("CfxApi.Probe();");
        foreach(var f in decls.StringCollectionFunctions) {
            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName);
        }
        b.EndBlock();
        b.AppendLine();

        foreach(var cefStruct in decls.CefStructTypes) {
            b.AppendLine("private static bool {0}ApiLoaded;", cefStruct.ClassName);
            b.BeginBlock("internal static void Load{0}Api()", cefStruct.ClassName);
            b.AppendLine("if({0}ApiLoaded) return;", cefStruct.ClassName);
            b.AppendLine("{0}ApiLoaded = true;", cefStruct.ClassName);
            b.AppendLine("CfxApi.Probe();");
            switch(cefStruct.ClassBuilder.Category) {
                case StructCategory.ApiCalls:
                    if(cefStruct.ClassBuilder.ExportFunctions.Count() > 0) {
                        foreach(var f in cefStruct.ClassBuilder.ExportFunctions) {
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName);
                        }
                    }
                    foreach(var sm in cefStruct.ClassBuilder.StructMembers) {
                        if(sm.MemberType.IsCefCallbackType) {
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, cefStruct.CfxName + "_" + sm.Name);
                        }
                    }

                    break;

                case StructCategory.ApiCallbacks:
                    b.AppendLine("CfxApi.{0}_ctor = (CfxApi.cfx_ctor_with_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_ctor, typeof(CfxApi.cfx_ctor_with_gc_handle_delegate));", cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}_get_gc_handle = (CfxApi.cfx_get_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_get_gc_handle, typeof(CfxApi.cfx_get_gc_handle_delegate));", cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}_set_managed_callback = (CfxApi.cfx_set_callback_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_set_managed_callback, typeof(CfxApi.cfx_set_callback_delegate));", cefStruct.CfxName);
                    if(cefStruct.ClassBuilder.ExportFunctions.Count() > 0) {
                        System.Diagnostics.Debugger.Break();
                    }
                    break;

                case StructCategory.Values:
                    b.AppendLine("CfxApi.{0}_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_ctor, typeof(CfxApi.cfx_ctor_delegate));", cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_dtor, typeof(CfxApi.cfx_dtor_delegate));", cefStruct.CfxName);

                    foreach(var sm in cefStruct.ClassBuilder.StructMembers) {
                        if(sm.Name != "size") {
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, cefStruct.CfxName + "_set_" + sm.Name);
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, cefStruct.CfxName + "_get_" + sm.Name);
                        }
                    }

                    if(cefStruct.ClassBuilder.ExportFunctions.Count() > 0) {
                        System.Diagnostics.Debugger.Break();
                    }

                    break;
            }
            b.EndBlock();
            b.AppendLine();
        }

        b.EndBlock();
        b.EndBlock();

        fileManager.WriteFileIfContentChanged("CfxApiLoader.cs", b.ToString());
    }

    private void BuildApiClasses(GeneratedFileManager fileManager, StructCategory category) {
        var b = new CodeBuilder();
        foreach(var t in decls.CefStructTypes) {
            if(t.ClassBuilder.Category == category) {
                b.BeginCfxNamespace();
                t.ClassBuilder.EmitPublicClass(b);
                b.EndBlock();
                fileManager.WriteFileIfContentChanged(t.ClassName + ".cs", b.ToString());
                b.Clear();
            }
        }
    }

    private void BuildRemoteCalls(GeneratedFileManager fileManager) {
        var callIds = new List<string>();

        var b = new CodeBuilder();
        b.BeginCfxNamespace(".Remote");
        foreach(var f in remoteDecls.ExportFunctions) {
            if(!f.PrivateWrapper) {
                b.BeginRemoteCallClass("CfxRuntime" + f.PublicName, false, callIds);
                f.Signature.EmitRemoteCallClassBody(b);
                b.EndBlock();
                b.AppendLine();
            }
        }
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("CfxRuntimeRemoteCalls.cs", b.ToString());

        foreach(var t in remoteDecls.CefStructTypes) {
            b.Clear();
            b.BeginCfxNamespace(".Remote");
            t.ClassBuilder.EmitRemoteCalls(b, callIds);
            b.EndBlock();
            fileManager.WriteFileIfContentChanged(t.ClassName + "RemoteCalls.cs", b.ToString());
        }

        callIds.AddRange(GeneratorConfig.AdditionalCallIds);

        b.Clear();
        b.BeginCfxNamespace(".Remote");
        b.BeginBlock("internal enum RemoteCallId : ushort");
        foreach(var id in callIds) {
            b.AppendLine(id + ",");
        }
        b.TrimRight();
        b.CutRight(1);
        b.AppendLine();
        b.EndBlock();
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("RemoteCallId.cs", b.ToString());

        b.Clear();
        b.BeginCfxNamespace(".Remote");
        b.BeginClass("RemoteCallFactory", "internal");
        b.AppendLine("private delegate RemoteCall RemoteCallCtor();");
        b.BeginBlock("private static RemoteCallCtor[] callConstructors = ");
        foreach(var id in callIds) {
            b.AppendLine("() => {{ return new {0}(); }},", id);
        }
        b.EndBlock(";");
        b.AppendLine();

        b.BeginBlock("internal static RemoteCall ForCallId(RemoteCallId id)");
        b.AppendLine("return callConstructors[(int)id]();");
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        fileManager.WriteFileIfContentChanged("RemoteCallFactory.cs", b.ToString());
    }

    private void BuildRemoteClasses(GeneratedFileManager fileManager) {
        foreach(var t in remoteDecls.CefStructTypes) {
            var b = new CodeBuilder();
            b.BeginCfxNamespace(".Remote");
            t.ClassBuilder.EmitRemoteClass(b);
            b.EndBlock();
            fileManager.WriteFileIfContentChanged(t.RemoteClassName + ".cs", b.ToString());
        }
    }
}