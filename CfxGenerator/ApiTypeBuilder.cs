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
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

public class ApiTypeBuilder {

    private Parser.CefApiData apiData;

    private SortedDictionary<string, ApiType> apiTypes;

    private CefStringPtrTypeConst constStringPtrType = new CefStringPtrTypeConst();

    public CefApiDeclarations GetDeclarations() {
        apiData = Deserialize();
        string hash = Parser.ApiParser.ParseApiHash();
        if(apiData == null || !hash.Equals(apiData.ApiHashUniversal)) {
            var parser = new Parser.ApiParser();
            apiData = parser.Parse();
            Serialize(apiData);
        }
        return BuildTypes();
    }

    private string serializedApi = System.IO.Path.Combine("cef", "SerializedApi.data");

    private void Serialize(Parser.CefApiData apiData) {
        var formatter = new BinaryFormatter();
        var stream = new FileStream(serializedApi, FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, apiData);
        stream.Close();
    }

    private Parser.CefApiData Deserialize() {
        if(!File.Exists(serializedApi))
            return null;
        var formatter = new BinaryFormatter();
        var stream = new FileStream(serializedApi, FileMode.Open, FileAccess.Read, FileShare.Read);
        try {
            return (Parser.CefApiData)formatter.Deserialize(stream);
        } catch(Exception) {
            return null;
        } finally {
            stream.Close();
        }
    }

    private CefApiDeclarations BuildTypes() {
        var structs = new List<CefStructType>();
        var enums = new List<CefEnumType>();
        var stringCollectionTypes = new List<StringCollectionType>();
        List<CefExportFunction> stringCollectionFunctions = new List<CefExportFunction>();
        List<CefExportFunction> functions = new List<CefExportFunction>();

        apiTypes = new SortedDictionary<string, ApiType>();

        AddType(new ApiType("void"));

        AddType(new CefBaseType());
        AddType(new CefBasePtrType());

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

        foreach(var ed in apiData.CefEnums) {
            var t = new CefEnumType(ed);
            AddType(t);
            enums.Add(t);
        }

        foreach(var sd in apiData.CefStructs) {
            if(!apiTypes.Keys.Contains(sd.Name)) {
                var structName = sd.Name.Substring(0, sd.Name.Length - 2);
                var t = new CefStructType(structName, sd.Comments);
                AddType(t);
                structs.Add(t);
            }
        }

        foreach(var sd in apiData.CefStructsWindows) {
            var structName = sd.Name.Substring(0, sd.Name.Length - 2);
            var t = new CefPlatformStructType(structName, sd.Comments, CefPlatform.Windows);
            AddType(t);
            structs.Add(t);
        }

        foreach(var sd in apiData.CefStructsLinux) {
            var structName = sd.Name.Substring(0, sd.Name.Length - 2);
            var t = new CefPlatformStructType(structName, sd.Comments, CefPlatform.Linux);
            AddType(t);
            structs.Add(t);
        }

        stringCollectionTypes.Add(new CefStringListType());
        stringCollectionTypes.Add(new CefStringMapType());
        stringCollectionTypes.Add(new CefStringMultimapType());

        foreach(var t in stringCollectionTypes) {
            AddType(t);
        }

        foreach(var sd in apiData.CefStructs) {
            var t = apiTypes[sd.Name];
            if(t.IsCefStructType) {
                t.AsCefStructType.SetMembers(sd, this);
            }
        }

        foreach(var sd in apiData.CefStructsWindows) {
            var t = apiTypes[sd.Name.Substring(0, sd.Name.Length - 2) + "_windows"];
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var sd in apiData.CefStructsLinux) {
            var t = apiTypes[sd.Name.Substring(0, sd.Name.Length - 2) + "_linux"];
            t.AsCefStructType.SetMembers(sd, this);
        }

        foreach(var fd in apiData.CefStringCollectionFunctions) {
            stringCollectionFunctions.Add(new CefExportFunction(null, fd, this));
        }

        foreach(var fd in apiData.CefFunctions) {
            var f = new CefExportFunction(null, fd, this);
            functions.Add(f);
        }

        if(apiData.CefFunctionsWindows.Count > 0)
            System.Diagnostics.Debugger.Break();

        foreach(var fd in apiData.CefFunctionsLinux) {
            var f = new CefExportFunction(null, fd, this, CefPlatform.Linux);
            functions.Add(f);
        }

        functions.Sort(new CefExportFunction.Comparer());
        structs.Sort(new ApiType.Comparer());
        enums.Sort(new ApiType.Comparer());

        var decl = new CefApiDeclarations(functions.ToArray(), structs.ToArray(), enums.ToArray(), stringCollectionTypes.ToArray(), stringCollectionFunctions.ToArray());
        return decl;
    }

    public void AddType(ApiType t) {
        foreach(var m in t.ParserMatches) {
            apiTypes.Add(m, t);
        }
    }

    public ApiType GetApiType(Parser.TypeData td, bool isConst) {
        var t = FindApiType(td);

        if(t.IsCefStringPtrType && isConst) {
            return constStringPtrType;
        }

        return t;
    }

    private ApiType FindApiType(Parser.TypeData td) {
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