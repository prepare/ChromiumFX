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
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Parser;

public class ApiTypeBuilder {

    private Parser.CefApiNode apiNode;

    private SortedDictionary<string, ApiType> apiTypes;

    private CefStringPtrTypeConst constStringPtrType = new CefStringPtrTypeConst();

    public CefApiDeclarations GetDeclarations() {
        apiNode = Deserialize();
        string hash = Parser.Parser.ParseApiHash();
        if(apiNode == null || !hash.Equals(apiNode.ApiHashUniversal)) {
            apiNode = Parser.Parser.Parse();
            apiNode.ApiHashUniversal = hash;
            Serialize(apiNode);
        }
        return BuildTypes();
    }

    private string serializedApi = System.IO.Path.Combine("cef", "SerializedApi.data");

    private void Serialize(Parser.CefApiNode apiNode) {
        var formatter = new BinaryFormatter();
        var stream = new FileStream(serializedApi, FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, apiNode);
        stream.Close();
    }

    private Parser.CefApiNode Deserialize() {
        if(!File.Exists(serializedApi))
            return null;
        var formatter = new BinaryFormatter();
        var stream = new FileStream(serializedApi, FileMode.Open, FileAccess.Read, FileShare.Read);
        try {
            return (Parser.CefApiNode)formatter.Deserialize(stream);
        } catch(Exception) {
            return null;
        } finally {
            stream.Close();
        }
    }

    private void ProcessApi() {
        // process c++ findings (compat with previous parser)

        var classes = new Dictionary<string, CefClassNode>(apiNode.CefClasses.Count);
        var funcs = new Dictionary<string, CefCppFunctionNode>();
        foreach(var f in apiNode.CefCppFunctions) {
            if(f.CefConfig.CApiName == null) {
                funcs.Add(CppStyle2CStyle(f.Name), f);
            } else {
                f.CefConfig.CppApiName = f.Name;
                funcs.Add(f.CefConfig.CApiName, f);
            }
        }
        foreach(var c in apiNode.CefClasses) {
            classes.Add(CppStyle2CStyle(c.Name) + "_t", c);
            foreach(var f in c.Methods) {
                if(f.CefConfig.CApiName == null) {
                    if(f.IsStatic && f.Name.EndsWith(c.Name.Substring(3))) {
                        funcs.Add(CppStyle2CStyle(c.Name) + "_" + CppStyle2CStyle(f.Name.Substring(0, f.Name.Length - (c.Name.Length - 3))), f);
                    } else {
                        funcs.Add(CppStyle2CStyle(c.Name) + "_" + CppStyle2CStyle(f.Name), f);
                    }
                } else {
                    f.CefConfig.CppApiName = f.Name;
                    funcs.Add(CppStyle2CStyle(c.Name) + "_" + f.CefConfig.CApiName, f);
                }
            }
        }

        foreach(var s in apiNode.CefCallbackStructs) {
            if(classes.ContainsKey(s.Name)) {
                var c = classes[s.Name];
                classes.Remove(s.Name);
                s.CefConfig = c.CefConfig;
            } else {
                if(s.CefFunctions.Count > 0)
                    Debugger.Break();
            }
            foreach(var c in s.CefCallbacks) {
                if(funcs.ContainsKey(s.Name.Substring(0, s.Name.Length - 1) + c.Name)) {
                    var cf = funcs[s.Name.Substring(0, s.Name.Length - 1) + c.Name];
                    c.CefConfig = cf.CefConfig;
                    ApplyBoolParameters(c.Signature, cf);
                } else {
                    if(c.Signature != null)
                        Debugger.Break();
                }
            }
        }

        foreach(var f in apiNode.CefFunctions) {
            if(funcs.ContainsKey(f.Name)) {
                var cf = funcs[f.Name];
                ApplyBoolParameters(f.Signature, cf);
            } else {
                //Debugger.Break();
            }
        }

        apiNode.CefCallbackStructs.Sort((x, y) => {
            return y.Name.Length - x.Name.Length;
        });

        int ifunc = 0;
        while(ifunc < apiNode.CefFunctions.Count) {
            var f = apiNode.CefFunctions[ifunc];
            var found = false;
            foreach(var s in apiNode.CefCallbackStructs) {
                if(f.Name.StartsWith(s.Name.Substring(0, s.Name.Length - 1))) {
                    s.CefFunctions.Add(f);
                    found = true;
                    break;
                }
            }
            if(found) {
                apiNode.CefFunctions.RemoveAt(ifunc);
            } else {
                ++ifunc;
            }
        }
    }

    private static void ApplyBoolParameters(SignatureNode signature, CefCppFunctionNode cf) {
        if(cf.IsRetvalBoolean) {
            signature.ReturnType.Name = "bool";
        }
        foreach(var pm in cf.BooleanParameters) {
            var success = false;
            foreach(var pm1 in signature.Parameters) {
                if(pm1.Var == pm) {
                    pm1.ParameterType.Name = "bool";
                    success = true;
                    break;
                }
            }
            if(!success) {
                Debugger.Break();
            }
        }
    }

    private static string CppStyle2CStyle(string symbol) {
        var s = new StringBuilder();
        for(int i = 0; i < symbol.Length; ++i) {
            var c = symbol[i];
            if(char.IsUpper(c)) {
                if(s.Length > 0 && char.IsLower(symbol[i - 1])) s.Append("_");
                s.Append(char.ToLowerInvariant(c));
            } else {
                s.Append(c);
            }
        }
        return s.ToString();
    }

    private CefApiDeclarations BuildTypes() {

        ProcessApi();

        var structs = new List<CefStructType>();
        var enums = new List<CefEnumType>();
        var stringCollectionTypes = new List<StringCollectionType>();
        List<CefExportFunction> stringCollectionFunctions = new List<CefExportFunction>();
        List<CefExportFunction> functions = new List<CefExportFunction>();

        apiTypes = new SortedDictionary<string, ApiType>();

        AddType(new ApiType("void"));

        AddType(new CefBaseRefCountedType());
        AddType(new CefBaseScopedType());
        AddType(new CefBaseRefCountedPtrType());

        AddType(new CefColorType());
        AddType(new CefColorRefType());

        AddType(new BooleanInteger());
        AddType(new BooleanIntegerOutType());

        AddType(new OpaquePtrType("XDisplay"));
        AddType(new CefPlatformBasePtrType("cef_window_info_t*"));
        AddType(new CefPlatformBasePtrType("cef_main_args_t*"));

        AddType(new CefStringType());
        AddType(new CefStringPtrType());
        AddType(new CefStringUserFreeType());

        NumericType.CreateAll(this);

        var bTypes = AssemblyResources.GetLines("BlittableTypes.txt");
        foreach(var bt in bTypes) {
            var def = bt.Split('|');
            if(def.Length == 2 && def[0].Length > 0 && def[1].Length > 0) {
                AddType(new BlittableType(def[0], def[1]));
            }
        }

        AddType(new VoidPtrPtrType());

        foreach(var ed in apiNode.CefEnums) {
            var t = new CefEnumType(ed);
            AddType(t);
            enums.Add(t);
        }

        foreach(var s in apiNode.CefCallbackStructs) {
            if(!apiTypes.Keys.Contains(s.Name)) {
                var structName = s.Name.Substring(0, s.Name.Length - 2);
                var t = new CefStructType(structName, s.CefConfig.Source == "client" ? StructCategory.Client : StructCategory.Library);
                AddType(t);
                structs.Add(t);
            }
        }

        foreach(var s in apiNode.CefValueStructs) {
            if(!apiTypes.Keys.Contains(s.Name)) {
                var structName = s.Name.Substring(0, s.Name.Length - 2);
                var t = new CefStructType(structName, StructCategory.Values);
                AddType(t);
                structs.Add(t);
            }
        }

        foreach(var s in apiNode.CefStructsWindows) {
            var structName = s.Name.Substring(0, s.Name.Length - 2);
            var t = new CefPlatformStructType(structName, StructCategory.Values, CefPlatform.Windows);
            AddType(t);
            structs.Add(t);
        }

        foreach(var s in apiNode.CefStructsLinux) {
            var structName = s.Name.Substring(0, s.Name.Length - 2);
            var t = new CefPlatformStructType(structName, StructCategory.Values, CefPlatform.Linux);
            AddType(t);
            structs.Add(t);
        }

        stringCollectionTypes.Add(new CefStringListType());
        stringCollectionTypes.Add(new CefStringMapType());
        stringCollectionTypes.Add(new CefStringMultimapType());

        foreach(var t in stringCollectionTypes) {
            AddType(t);
        }

        foreach(var sd in apiNode.CefCallbackStructs) {
            var t = apiTypes[sd.Name];
            Debug.Assert(t.IsCefStructType);
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var sd in apiNode.CefValueStructs) {
            var t = apiTypes[sd.Name];
            Debug.Assert(t.IsCefStructType);
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var sd in apiNode.CefStructsWindows) {
            var t = apiTypes[sd.Name.Substring(0, sd.Name.Length - 2) + "_windows"];
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var sd in apiNode.CefStructsLinux) {
            var t = apiTypes[sd.Name.Substring(0, sd.Name.Length - 2) + "_linux"];
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var fd in apiNode.CefStringCollectionFunctions) {
            stringCollectionFunctions.Add(new CefExportFunction(null, fd, this));
        }

        foreach(var fd in apiNode.CefFunctions) {
            var f = new CefExportFunction(null, fd, this);
            functions.Add(f);
        }

        if(apiNode.CefFunctionsWindows.Count > 0)
            System.Diagnostics.Debugger.Break();

        foreach(var fd in apiNode.CefFunctionsLinux) {
            var f = new CefExportFunction(null, fd, this, CefPlatform.Linux);
            functions.Add(f);
        }

        functions.Sort((x, y) => string.Compare(x.Name, y.Name));
        structs.Sort((x, y) => string.Compare(x.Name, y.Name));
        enums.Sort((x, y) => string.Compare(x.Name, y.Name));

        var decl = new CefApiDeclarations(functions.ToArray(), structs.ToArray(), enums.ToArray(), stringCollectionTypes.ToArray(), stringCollectionFunctions.ToArray());
        return decl;
    }

    public void AddType(ApiType t) {
        foreach(var m in t.ParserMatches) {
            apiTypes.Add(m, t);
        }
    }

    public ApiType GetApiType(Parser.TypeNode td, bool isConst) {
        var t = FindApiType(td);

        if(t.IsCefStringPtrType && isConst) {
            return constStringPtrType;
        }

        return t;
    }

    private ApiType FindApiType(Parser.TypeNode td) {
        ApiType t = null;

        if(td.Indirection == null) {
            if(!apiTypes.TryGetValue(td.Name, out t)) {
                System.Diagnostics.Debugger.Break();
            }
            return t;
        }

        if(apiTypes.TryGetValue(td.Name + td.Indirection, out t)) {
            return t;
        }

        if(!apiTypes.TryGetValue(td.Name, out t)) {
            System.Diagnostics.Debugger.Break();
        }

        if(t.IsCefEnumType) {
            if(td.Indirection == "*") {
                t = new CefEnumPtrType(t.AsCefEnumType);
            } else {
                System.Diagnostics.Debugger.Break();
            }
        } else if(t.IsCefStructType) {
            if(td.Indirection.Count((char c) => c.Equals('*')) == 1) {
                t = new CefStructPtrType(t.AsCefStructType, td.Indirection);
            } else if(td.Indirection == "**") {
                var t0 = new CefStructPtrType(t.AsCefStructType, "*");
                t = new CefStructOutType(t0, td.Indirection);
                //t = New CefStructRefType(t0, td.Indirection)
                //Debug.Print("StructRef " & t.ToString())
            } else if(td.Indirection.Count((char c) => c.Equals('*')) == 2) {
                var t0 = new CefStructPtrType(t.AsCefStructType, "*");
                t = new CefStructPtrPtrType(t0, td.Indirection);
            } else {
                System.Diagnostics.Debugger.Break();
            }
        } else if(t.IsBlittableType) {
            t = new BlittablePtrType(t.AsBlittableType, td.Indirection);
        } else {
            System.Diagnostics.Debugger.Break();
        }

        AddType(t);

        return t;
    }
}