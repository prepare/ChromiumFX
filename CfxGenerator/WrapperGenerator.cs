// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class WrapperGenerator {
    private readonly CefApiDeclarations decls;

    private readonly CefApiDeclarations remoteDecls;

    public WrapperGenerator(CefApiDeclarations decls) {
        this.decls = decls;
        CheckForNeededWrapFunctions();
        CheckForStringOutArguments();
        this.remoteDecls = decls.GetRemoteDeclarations();
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

    private void CheckForNeededWrapFunctions() {

        foreach(var s in Signature.AllSignatures) {

            switch(s.Type) {
                case SignatureType.ClientCallback:
                    foreach(var arg in s.Arguments) {
                        if(!arg.IsThisArgument) {
                            if(arg.ArgumentType.IsCefStructPtrType) {
                                var t = arg.ArgumentType.AsCefStructPtrType;
                                t.Struct.ClassBuilder.NeedsWrapFunction = true;
                            } else if(arg.ArgumentType.IsCefStructType) {
                                var t = arg.ArgumentType.AsCefStructType;
                                Debug.Assert(t.ClassBuilder is CfxValueClass);
                                t.ClassBuilder.NeedsWrapFunction = true;
                            } else if(arg.ArgumentType is CefStructPtrArrayType) {
                                var t = arg.ArgumentType as CefStructPtrArrayType;
                                t.Struct.ClassBuilder.NeedsWrapFunction = true;
                            }
                        }
                    }
                    break;
                case SignatureType.LibraryCall:
                    if(s.ReturnType.IsCefStructPtrType) {
                        var t = s.ReturnType.AsCefStructPtrType;
                        if(t.Struct.ClassBuilder is CfxClientClass) {
                            (t.Struct.ClassBuilder as CfxClientClass).NeedsWrapFunction = true;
                        }
                    }
                    break;
            }
        }

        foreach(var st in decls.CefStructTypes) {
            if(st.ClassBuilder is CfxValueClass) {
                foreach(var sm in st.ClassBuilder.StructMembers) {
                    if(sm.MemberType.IsCefStructType) {
                        var t = sm.MemberType.AsCefStructType;
                        Debug.Assert(t.ClassBuilder is CfxValueClass);
                        (t.ClassBuilder as CfxValueClass).NeedsWrapFunction = true;
                    }
                }
            }
            switch(st.Name) {
                case "cef_window_info_windows":
                case "cef_window_info_linux":
                case "cef_range":
                    st.ClassBuilder.NeedsWrapFunction = true;
                    break;
            }
        }
    }

    private void CheckForStringOutArguments() {
        foreach(var f in decls.AllExportFunctions()) {
            CheckForStringOutArguments(f.Signature, f.Name, f.Comments.Lines);
        }
        foreach(var f in decls.StringCollectionFunctions) {
            CheckForStringOutArguments(f.Signature, f.Name, null);
        }
        foreach(var st in decls.CefStructTypes) {
            if(st.ClassBuilder.CallbackFunctions != null) {
                foreach(var cb in st.ClassBuilder.CallbackFunctions) {
                    CheckForStringOutArguments(cb.Signature, st.Name + "::" + cb.Name, cb.Comments.Lines);
                }
            }
        }
    }

    private void CheckForStringOutArguments(Signature s, string function, string[] funcComments) {
        for(int i = 0; i < s.Arguments.Length; ++i) {
            var arg = s.Arguments[i];
            if(arg.ArgumentType.IsCefStringPtrType) {
                switch(function + "!" + arg.VarName) {

                    case "cef_create_url!url":
                    case "cef_get_path!path":
                    case "cef_parse_jsonand_return_error!error_msg_out":
                    case "cef_request_context::set_preference!error":
                    case "cef_resource_bundle_handler::get_localized_string!string":
                    case "cef_resource_handler::get_response_headers!redirectUrl":
                    case "cef_v8accessor::get!exception":
                    case "cef_v8accessor::set!exception":
                    case "cef_v8handler::execute!exception":
                    case "cef_v8interceptor::get_byname!exception":
                    case "cef_v8interceptor::get_byindex!exception":
                    case "cef_v8interceptor::set_byname!exception":
                    case "cef_v8interceptor::set_byindex!exception":
                    case "cef_create_new_temp_directory!new_temp_path":
                    case "cef_create_temp_directory_in_directory!new_dir":
                    case "cef_get_temp_directory!temp_dir":

                        s.Arguments[i] = new Argument(arg, new CefStringOutType());
                        break;

                    case "cef_display_handler::on_tooltip!text":
                    case "cef_menu_model_delegate::format_label!label":
                    case "cef_request_handler::on_resource_redirect!new_url":
                        break;

                    default:

                        if(funcComments == null) {
                            //this is arg string collection function
                            s.Arguments[i] = new Argument(arg, new CefStringOutType());
                            break;
                        }

                        Debug.Print("Check comments to see if string pointer argument is out our inout:");
                        Debug.Print("If in doubt, leave it inout.");
                        Debug.Print(function + "!" + arg.VarName);
                        Debug.Print(string.Join(Environment.NewLine, funcComments));
                        Debugger.Break();
                        break;
                }
            }
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
            b.AppendLine("static {0} (*{1}_ptr)({2});", retSymbol, f.Name, f.Signature.OriginalParameterList);
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
                b.AppendLine("{0}_ptr = ({1} (*)({2}))cfx_platform_get_fptr(libcef, \"{0}\");", f.Name, f.ReturnType.OriginalSymbol, f.Signature.OriginalParameterListUnnamed);
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
                f.EmitPublicFunction(b, "Runtime");
                b.AppendLine();
            } else {
                lxFuncs.Add(f);
            }
        }
        b.BeginClass("Linux", "public");
        b.AppendLine();
        foreach(var f in lxFuncs) {
            f.EmitPublicFunction(b, "Runtime");
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

        b.BeginClass("Runtime", "internal static");

        foreach(var f in decls.ExportFunctions) {
            f.EmitPInvokeDeclaration(b);
        }
        b.AppendLine();

        foreach(var f in decls.StringCollectionFunctions) {
            f.EmitPInvokeDeclaration(b);
        }
        b.EndBlock();

        b.AppendLine();

        foreach(var t in decls.CefStructTypes) {
            t.ClassBuilder.EmitApiClass(b);
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
            CodeSnippets.EmitPInvokeDelegateInitialization(b, "Runtime", f.CfxApiFunctionName);
            if(f.Platform != CefPlatform.Independent) {
                b.EndBlock();
            }
        }
        b.EndBlock();
        b.AppendLine();

        b.BeginFunction("void LoadStringCollectionApi()", "internal static");
        b.AppendLine("CfxApi.Probe();");
        foreach(var f in decls.StringCollectionFunctions) {
            CodeSnippets.EmitPInvokeDelegateInitialization(b, "Runtime", f.CfxApiFunctionName);
        }
        b.EndBlock();
        b.AppendLine();

        foreach(var cefStruct in decls.CefStructTypes) {
            b.BeginBlock("internal static void Load{0}Api()", cefStruct.ClassName);
            b.AppendLine("CfxApi.Probe();");

            var apiClassName = cefStruct.ClassName.Substring(3);

            switch(cefStruct.ClassBuilder.Category) {
                case StructCategory.ApiCalls:
                    foreach(var f in cefStruct.ClassBuilder.ExportFunctions) {
                        CodeSnippets.EmitPInvokeDelegateInitialization(b, f.PublicClassName.Substring(3), f.CfxApiFunctionName);
                    }
                    foreach(var cb in cefStruct.ClassBuilder.CallbackFunctions) {
                        CodeSnippets.EmitPInvokeDelegateInitialization(b, cb.PublicClassName.Substring(3), cb.CfxApiFunctionName);
                    }

                    break;

                case StructCategory.ApiCallbacks:
                    b.AppendLine("CfxApi.{0}.{1}_ctor = (CfxApi.cfx_ctor_with_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{1}_ctor, typeof(CfxApi.cfx_ctor_with_gc_handle_delegate));", apiClassName, cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}.{1}_get_gc_handle = (CfxApi.cfx_get_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{1}_get_gc_handle, typeof(CfxApi.cfx_get_gc_handle_delegate));", apiClassName, cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}.{1}_set_callback = (CfxApi.cfx_set_callback_delegate)CfxApi.GetDelegate(FunctionIndex.{1}_set_callback, typeof(CfxApi.cfx_set_callback_delegate));", apiClassName, cefStruct.CfxName);
                    b.AppendLine("{0}.SetNativeCallbacks();", cefStruct.ClassName);
                    break;

                case StructCategory.Values:
                    b.AppendLine("CfxApi.{0}.{1}_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(FunctionIndex.{1}_ctor, typeof(CfxApi.cfx_ctor_delegate));", apiClassName, cefStruct.CfxName);
                    b.AppendLine("CfxApi.{0}.{1}_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(FunctionIndex.{1}_dtor, typeof(CfxApi.cfx_dtor_delegate));", apiClassName, cefStruct.CfxName);

                    foreach(var sm in cefStruct.ClassBuilder.StructMembers) {
                        CodeSnippets.EmitPInvokeDelegateInitialization(b, apiClassName, cefStruct.CfxName + "_set_" + sm.Name);
                        CodeSnippets.EmitPInvokeDelegateInitialization(b, apiClassName, cefStruct.CfxName + "_get_" + sm.Name);
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
                b.BeginRemoteCallClass("CfxRuntime" + f.PublicName, callIds);
                f.Signature.EmitRemoteCallClassBody(b, "Runtime", f.CfxApiFunctionName);
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

        foreach(var t in remoteDecls.CefStructTypes) {
            if(t.ClassBuilder is CfxClientClass) {
                b.Clear();
                b.BeginCfxNamespace(".Remote");
                (t.ClassBuilder as CfxClientClass).EmitRemoteClient(b);
                b.EndBlock();
                fileManager.WriteFileIfContentChanged(t.ClassName + "RemoteClient.cs", b.ToString());
            }
        }

        callIds.AddRange(GeneratorConfig.AdditionalCallIds);
        callIds.Sort();

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