// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class CefApiDeclarations {
    public readonly CefExportFunction[] ExportFunctions;
    public readonly CefStructType[] CefStructTypes;
    public readonly CefEnumType[] CefEnumTypes;
    public readonly StringCollectionType[] StringCollectionTypes;

    public readonly CefExportFunction[] StringCollectionFunctions;

    public CefApiDeclarations(CefExportFunction[] exportFunctions, CefStructType[] cefStructTypes, CefEnumType[] cefEnumTypes, StringCollectionType[] stringCollectionTypes, CefExportFunction[] stringCollectionFunctions) {
        this.ExportFunctions = exportFunctions;
        this.CefStructTypes = cefStructTypes;
        this.CefEnumTypes = cefEnumTypes;
        this.StringCollectionTypes = stringCollectionTypes;
        this.StringCollectionFunctions = stringCollectionFunctions;
    }

    private SortedDictionary<string, CefExportFunction> remoteFuncs;

    private SortedDictionary<string, CefStructType> remoteStructs;
    private string[] retval;

    public string[] GetCfxApiFunctionNames() {
        if(retval == null) {
            var list = new List<string>();
            foreach(var f in ExportFunctions) {
                f.ApiIndex = list.Count;
                list.Add(f.CfxName);
            }
            foreach(var st in CefStructTypes) {
                if(st.ClassBuilder.ExportFunctions != null) {
                    foreach(var f in st.ClassBuilder.ExportFunctions) {
                        f.ApiIndex = list.Count;
                        list.Add(f.CfxName);
                    }
                }
                switch(st.ClassBuilder.Category) {
                    case StructCategory.ApiCalls:
                        foreach(var cb in st.ClassBuilder.CallbackFunctions) {
                            cb.ApiIndex = list.Count;
                            list.Add(cb.CfxApiFunctionName);
                        }

                        break;

                    case StructCategory.ApiCallbacks:
                        st.ApiIndex = list.Count;
                        list.Add(st.CfxName + "_ctor");
                        list.Add(st.CfxName + "_get_gc_handle");
                        list.Add(st.CfxName + "_set_callback");
                        break;

                    case StructCategory.Values:
                        st.ApiIndex = list.Count;
                        list.Add(st.CfxName + "_ctor");
                        list.Add(st.CfxName + "_dtor");
                        foreach(var sm in st.ClassBuilder.StructMembers) {
                            sm.ApiIndex = list.Count;
                            list.Add(st.CfxName + "_set_" + sm.Name);
                            list.Add(st.CfxName + "_get_" + sm.Name);
                        }

                        break;
                }
            }

            foreach(var f in StringCollectionFunctions) {
                f.ApiIndex = list.Count;
                list.Add(f.CfxName);
            }

            retval = list.ToArray();
        }
        return retval;
    }

    public CefApiDeclarations GetRemoteDeclarations() {
        remoteFuncs = new SortedDictionary<string, CefExportFunction>();
        remoteStructs = new SortedDictionary<string, CefStructType>();

        foreach(var f in ExportFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                AddRemoteFunc(f);
            }
        }

        foreach(var t in CefStructTypes) {
            if(t.ClassBuilder.ExportFunctions != null) {
                foreach(var f in t.ClassBuilder.ExportFunctions) {
                    if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                        AnalyzeSignature(f.Signature);
                    }
                }
            }
        }

        return new CefApiDeclarations(remoteFuncs.Values.ToArray(), remoteStructs.Values.ToArray(), CefEnumTypes, null, null);
    }

    private void AddRemoteFunc(CefExportFunction f) {
        if(remoteFuncs.ContainsKey(f.Name))
            return;
        remoteFuncs.Add(f.Name, f);
        AnalyzeSignature(f.Signature);
    }

    private void AnalyzeSignature(Signature sig) {
        if(sig.PublicReturnType.IsCefStructType) {
            AddRemoteStruct(sig.PublicReturnType.AsCefStructType);
        } else if(sig.PublicReturnType.IsCefStructPtrType) {
            AddRemoteStruct(sig.PublicReturnType.AsCefStructPtrType.Struct);
        }

        foreach(var arg in sig.ManagedParameters) {
            if(arg.ParameterType.IsCefStructType) {
                AddRemoteStruct(arg.ParameterType.AsCefStructType);
            } else if(arg.ParameterType.IsCefStructPtrType) {
                AddRemoteStruct(arg.ParameterType.AsCefStructPtrType.Struct);
            }
        }
    }

    private void AddRemoteStruct(CefStructType s) {
        if(remoteStructs.ContainsKey(s.Name))
            return;
        remoteStructs.Add(s.Name, s);

        switch(s.ClassBuilder.Category) {
            case StructCategory.Values:
                foreach(var sm in s.ClassBuilder.StructMembers) {
                    if(!GeneratorConfig.IsBrowserProcessOnly(s.Name + "::" + sm.Name)) {
                        if(sm.MemberType.IsCefStructType) {
                            AddRemoteStruct(sm.MemberType.AsCefStructType);
                        } else if(sm.MemberType.IsCefStructPtrType) {
                            AddRemoteStruct(sm.MemberType.AsCefStructPtrType.Struct);
                        }
                    }
                }
                break;
            case StructCategory.ApiCalls:
                foreach(var f in s.ClassBuilder.ExportFunctions) {
                    if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                        AnalyzeSignature(f.Signature);
                    }
                }
                goto case StructCategory.ApiCallbacks;
            case StructCategory.ApiCallbacks:
                foreach(var cb in s.ClassBuilder.CallbackFunctions) {
                    if(!GeneratorConfig.IsBrowserProcessOnly(s.Name + "::" + cb.Name)) {
                        AnalyzeSignature(cb.Signature);
                    }
                }
                break;
        }
    }

    private CefExportFunction[] funcs;

    public CefExportFunction[] AllExportFunctions() {
        if(funcs == null) {
            var ff = new List<CefExportFunction>(ExportFunctions);
            foreach(var t in CefStructTypes) {
                if(t.ClassBuilder.ExportFunctions != null)
                    ff.AddRange(t.ClassBuilder.ExportFunctions);
            }
            funcs = ff.ToArray();
        }
        return funcs;
    }
}