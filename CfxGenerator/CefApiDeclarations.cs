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
                foreach(var f in st.ClassBuilder.ExportFunctions) {
                    f.ApiIndex = list.Count;
                    list.Add(f.CfxName);
                }
                switch(st.ClassBuilder.Category) {
                    case StructCategory.ApiCalls:
                        foreach(var sm in st.ClassBuilder.StructMembers) {
                            if(sm.MemberType.IsCefCallbackType) {
                                sm.ApiIndex = list.Count;
                                list.Add(sm.Callback.CfxApiFunctionName);
                            }
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
                            if(sm.Name != "size") {
                                sm.ApiIndex = list.Count;
                                list.Add(st.CfxName + "_set_" + sm.Name);
                                list.Add(st.CfxName + "_get_" + sm.Name);
                            }
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

        foreach(var arg in sig.ManagedArguments) {
            if(arg.ArgumentType.IsCefStructType) {
                AddRemoteStruct(arg.ArgumentType.AsCefStructType);
            } else if(arg.ArgumentType.IsCefStructPtrType) {
                AddRemoteStruct(arg.ArgumentType.AsCefStructPtrType.Struct);
            }
        }
    }

    private void AddRemoteStruct(CefStructType s) {
        if(remoteStructs.ContainsKey(s.Name))
            return;
        remoteStructs.Add(s.Name, s);

        foreach(var f in s.ClassBuilder.ExportFunctions) {
            if(!GeneratorConfig.IsBrowserProcessOnly(f.Name)) {
                AnalyzeSignature(f.Signature);
            }
        }

        foreach(var sm in s.ClassBuilder.StructMembers) {
            if(!GeneratorConfig.IsBrowserProcessOnly(s.Name + "::" + sm.Name)) {
                if(sm.MemberType.IsCefStructType) {
                    AddRemoteStruct(sm.MemberType.AsCefStructType);
                } else if(sm.MemberType.IsCefStructPtrType) {
                    AddRemoteStruct(sm.MemberType.AsCefStructPtrType.Struct);
                } else if(sm.MemberType.IsCefCallbackType) {
                    AnalyzeSignature(sm.MemberType.AsCefCallbackType.Signature);
                }
            }
        }
    }

    private CefExportFunction[] funcs;

    public CefExportFunction[] AllExportFunctions() {
        if(funcs == null) {
            var ff = new List<CefExportFunction>(ExportFunctions);
            foreach(var t in CefStructTypes) {
                ff.AddRange(t.ClassBuilder.ExportFunctions);
            }
            funcs = ff.ToArray();
        }
        return funcs;
    }
}