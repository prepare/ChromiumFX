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
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Parser {

    public class ApiParser {

        private HashSet<string> booleanRetvals = new HashSet<string>();

        private HashSet<string> booleanParameters = new HashSet<string>();

        private Dictionary<string, CefConfigData> cefConfigs = new Dictionary<string, CefConfigData>();

        private Dictionary<string, string> codeFiles = new Dictionary<string, string>();

        public static string ParseApiHash() {
			var code = File.ReadAllText(System.IO.Path.Combine("cef", "include", "cef_version.h"));
            var ex = new Regex(@"CEF_API_HASH_UNIVERSAL ""(\w+)""");
            Debug.Assert(ex.IsMatch(code));
            return ex.Match(code).Groups[1].Value;
        }

        public CefApiData Parse() {
            ParseCppHeaders();

			AddFile(System.IO.Path.Combine("cef", "include", "cef_version.h"));

			AddFile(System.IO.Path.Combine("cef", "include", "internal", "cef_types.h"));
			AddFile(System.IO.Path.Combine("cef", "include", "internal", "cef_time.h"));

			var files = Directory.GetFiles(System.IO.Path.Combine("cef", "include", "capi"));
            foreach(var f in files) {
                AddFile(f);
            }

            var enums = new List<EnumData>();
            var structs = new List<StructData>();
            var funcs = new List<FunctionData>();

			ParseEnums(StripComments(codeFiles[System.IO.Path.Combine("cef", "include", "internal", "cef_types.h")]), enums);

            foreach(var cf in codeFiles) {
                var code = StripComments(cf.Value);
                ParseStructs(code, structs);
				if(cf.Key != System.IO.Path.Combine("cef", "include", "internal", "cef_time.h")) {
                    ParseFunctions(code, funcs);
                }
            }

            var api = new CefApiData();
            api.ApiHashUniversal = ParseApiHash();
            api.CefEnums = enums;
            api.CefStructs = structs;
            api.CefFunctions = new List<FunctionData>();

            foreach(var f in funcs) {
                var cefStruct = MatchCefStructPrefix(f.Name, structs);
                if(cefStruct == null) {
                    api.CefFunctions.Add(f);
                } else {
                    cefStruct.CefFunctions.Add(f);
                }

                var token = ReduceToken(f.Name);
                if(booleanRetvals.Contains(token)) {
                    f.Signature.ReturnType.Name = "bool";
                    //booleanRetvals.Remove(token)
                }
                foreach(var arg in f.Signature.Arguments) {
                    var t1 = token + ReduceToken(arg.Var);
                    if(booleanParameters.Contains(t1)) {
                        arg.ArgumentType.Name = "bool";
                        //booleanParameters.Remove(t1)
                    }
                }
            }

            foreach(var cefStruct in api.CefStructs) {
                var structToken = ReduceToken(cefStruct.Name.Substring(0, cefStruct.Name.Length - 2));
                if(cefConfigs.ContainsKey(structToken)) {
                    cefStruct.CefConfig = cefConfigs[structToken];
                }

                foreach(var sm in cefStruct.StructMembers) {
                    if(sm.CallbackSignature != null) {
                        var token = structToken + ReduceToken(sm.Name);

                        if(cefConfigs.ContainsKey(token)) {
                            sm.CefConfig = cefConfigs[token];
                            if(sm.CefConfig.CppApiName != null) {
                                token = ReduceToken(cefStruct.Name.Substring(0, cefStruct.Name.Length - 2) + sm.CefConfig.CppApiName);
                            }
                        }

                        if(booleanRetvals.Contains(token)) {
                            sm.CallbackSignature.ReturnType.Name = "bool";
                            //booleanRetvals.Remove(token)
                        }
                        foreach(var arg in sm.CallbackSignature.Arguments) {
                            var t1 = token + ReduceToken(arg.Var);
                            if(booleanParameters.Contains(t1)) {
                                arg.ArgumentType.Name = "bool";
                                //booleanParameters.Remove(t1)
                            }
                        }
                    }
                }
            }

            //If booleanRetvals.Count > 0 Then
            //    Stop
            //End If

            //If booleanParameters.Count > 0 Then
            //    Stop
            //End If

			var stringListCode = File.ReadAllText(System.IO.Path.Combine("cef", "include", "internal", "cef_string_list.h"));
			var stringMapCode = File.ReadAllText(System.IO.Path.Combine("cef", "include", "internal", "cef_string_map.h"));
			var stringMultiMapCode = File.ReadAllText(System.IO.Path.Combine("cef", "include", "internal", "cef_string_multimap.h"));

            funcs.Clear();
            ParseFunctions(stringListCode, funcs);
            ParseFunctions(stringMapCode, funcs);
            ParseFunctions(stringMultiMapCode, funcs);
            api.CefStringCollectionFunctions = funcs.ToArray();

            ParseComments(api);

			var pa = ParsePlatformApi(System.IO.Path.Combine("cef", "include", "internal", "cef_types_win.h"));
            api.CefFunctionsWindows = pa.CefFunctions;
            api.CefStructsWindows = pa.CefStructs;

			pa = ParsePlatformApi(System.IO.Path.Combine("cef", "include", "internal", "cef_types_linux.h"));
            api.CefFunctionsLinux = pa.CefFunctions;
            api.CefStructsLinux = pa.CefStructs;

            return api;
        }

        private CefApiData ParsePlatformApi(string filename) {
            var platformApi = new CefApiData();

            platformApi.CefEnums = new List<EnumData>();
            platformApi.CefStructs = new List<StructData>();
            platformApi.CefFunctions = new List<FunctionData>();
            codeFiles.Clear();
            AddFile(filename);

            ParseStructs(StripComments(codeFiles[filename]), platformApi.CefStructs);
            ParseFunctions(StripComments(codeFiles[filename]), platformApi.CefFunctions);
            ParseComments(platformApi);
            return platformApi;
        }

        private Regex stripCommentsRegex;

        private string StripComments(string code) {
            if(stripCommentsRegex == null) {
                var c1 = "/\\*.*?\\*/([\\r\\n]+)?";
                var c2 = "//.*?([\\r\\n]+)";
                stripCommentsRegex = new Regex("(?:" + c1 + "|" + c2 + ")", RegexOptions.Singleline);
            }
            return stripCommentsRegex.Replace(code, "$1");
        }

        private void AddFile(string filename) {
            var fcode = File.ReadAllText(filename);
            codeFiles.Add(filename, fcode);
        }

        private Regex memberEx = new Regex("\\b(\\w+)\\s*(?:=\\s*((?:[\\w<+-]|\\s)+))?");
        private Regex enumRegex = new Regex("typedef\\s+enum\\s*{(.*?)}\\s*(\\w+?)_t\\s*;", RegexOptions.Singleline);

        private void ParseEnums(string code, List<EnumData> enums) {
            var mm = enumRegex.Matches(code);

            foreach(Match m in mm) {
                var e = new EnumData();
                e.Name = m.Groups[2].Value;

                var mm1 = memberEx.Matches(m.Groups[1].Value);
                
                for(var i = 0; i <= mm1.Count - 1; i++) {
                    var em = new EnumMemberData();
                    em.Name = mm1[i].Groups[1].Value;
                    em.Value = mm1[i].Groups[2].Value.Trim();
                    e.Members.Add(em);
                }
                enums.Add(e);
            }
        }

        private Regex exportFunctionRegex = new Regex("CEF_EXPORT\\s+([^(]+?)\\s+(cef_.+?)\\((.*?)\\);", RegexOptions.Singleline);

        private void ParseFunctions(string code, List<FunctionData> funcs) {
            var mm = exportFunctionRegex.Matches(code);
            foreach(Match m in mm) {
                var f = new FunctionData();
                f.Name = m.Groups[2].Value;
                f.Signature = new SignatureData();
                f.Signature.ReturnType = ParseTypeDecl(m.Groups[1].Value, ref f.Signature.ReturnValueIsConst);
                ParseArgumentList(f.Signature, m.Groups[3].Value);
                funcs.Add(f);
            }
        }

        private Regex structRegex = new Regex("typedef\\s+struct\\s+_(\\w+?_t)\\s*{(.*?)}\\s*\\1;", RegexOptions.Singleline);

        private void ParseStructs(string code, List<StructData> structs) {
            var mm = structRegex.Matches(code);
            foreach(Match m in mm) {
                var cefStruct = new StructData();
                cefStruct.Name = m.Groups[1].Value;
                ParseBody(cefStruct, m.Groups[2].Value);
                structs.Add(cefStruct);
            }
        }

        private Regex varEx = new Regex("^\\s*(.+?)\\s+(\\w+)\\s*$");

        private void ParseBody(StructData parent, string body) {
            var memberDeclerations = body.Split(';');

            for(var i = 0; i <= memberDeclerations.Length - 2; i++) {
                if(memberDeclerations[i].Contains("CEF_CALLBACK")) {
                    var sm = ParseCallback(memberDeclerations[i]);
                    if(sm != null) {
                        parent.StructMembers.Add(sm);
                    }
                } else {
                    if(!varEx.IsMatch(memberDeclerations[i])) {
                        System.Diagnostics.Debugger.Break();
                    }
                    var m = varEx.Match(memberDeclerations[i]);

                    var sm = new StructMemberData();
                    var unused = false;
                    sm.MemberType = ParseTypeDecl(m.Groups[1].Value.Trim(), ref unused);
                    sm.Name = m.Groups[2].Value;
                    parent.StructMembers.Add(sm);
                }
            }
        }

        private Regex argsEx = new Regex("([^,]+)");

        private void ParseArgumentList(SignatureData signature, string argsString) {
            var mm = argsEx.Matches(argsString);
            foreach(Match m in mm) {
                signature.Arguments.Add(ParseArgument(m.Groups[1].Value));
            }
        }

        private Regex parseArgumentRegex = new Regex("^\\s*(.+)(\\b\\w+)\\s*$");

        private ArgumentData ParseArgument(string argString) {
            var m = parseArgumentRegex.Match(argString);

            var arg = new ArgumentData();
            arg.Var = m.Groups[2].Value;
            arg.ArgumentType = ParseTypeDecl(m.Groups[1].Value, ref arg.IsConst);
            return arg;
        }

        private Regex typeDeclRegex = new Regex("^\\s*(const)?((?:\\s*\\b\\w+\\b)+)\\s*$");
        private Regex indirEx = new Regex("(?:(?:\\bconst\\s*)?\\*\\s*)+$");

        private TypeData ParseTypeDecl(string typeDecl, ref bool isConst) {
            var t = new TypeData();

            var m1 = indirEx.Match(typeDecl);
            var td2 = typeDecl;
            if(m1.Success) {
                t.Indirection = m1.Value.Trim();
                td2 = typeDecl.Substring(0, typeDecl.Length - m1.Value.Length);
            }

            var m = typeDeclRegex.Match(td2);
            if(!m.Success) {
                System.Diagnostics.Debugger.Break();
            }

            isConst = m.Groups[1].Value.Length > 0;
            t.Name = m.Groups[2].Value.Trim();

            return t;
        }

        private Regex callbackRegex = new Regex("\\s*(.*?)\\s*\\(\\s*CEF_CALLBACK\\s*\\*\\s*(\\w+)\\s*\\)\\s*\\((.*?)\\)", RegexOptions.Singleline);

        private StructMemberData ParseCallback(string declaration) {
            if(!callbackRegex.IsMatch(declaration)) {
                System.Diagnostics.Debugger.Break();
            }

            var m = callbackRegex.Match(declaration);

            var cb = new StructMemberData();
            cb.Name = m.Groups[2].Value;
            cb.CallbackSignature = new SignatureData();
            cb.CallbackSignature.ReturnType = ParseTypeDecl(m.Groups[1].Value.Trim(), ref cb.CallbackSignature.ReturnValueIsConst);
            ParseArgumentList(cb.CallbackSignature, m.Groups[3].Value);
            return cb;
        }

        private StructData MatchCefStructPrefix(string name, List<StructData> structs) {
            StructData result = null;
            foreach(var cefStruct in structs) {
                if(name.StartsWith(cefStruct.Name.Substring(0, cefStruct.Name.Length - 2))) {
                    if(result == null || result.Name.Length < cefStruct.Name.Length) {
                        result = cefStruct;
                    }
                }
            }
            return result;
        }

        private string commentPattern = "((?:\\s*^\\s*//+.*?$)+)";

        private void ParseComments(CefApiData api) {
            var enums = new Dictionary<string, EnumData>();
            var structs = new Dictionary<string, StructData>();

            foreach(var e in api.CefEnums) {
                enums.Add(e.Name, e);
            }

            foreach(var s in api.CefStructs) {
                structs.Add(s.Name, s);
            }

            var comments = new Dictionary<string, CommentData>();

            var regex = new Regex(commentPattern + "\\s*CEF_EXPORT\\s+.*?\\b(\\w+)\\s*\\(", RegexOptions.Multiline);

            foreach(var cf in codeFiles) {
                var file = cf.Key;
                var code = cf.Value;
                ParseComments(file, code, regex, comments);
            }

            foreach(var f in api.CefFunctions) {
                f.Comments = comments[f.Name];
            }

            foreach(var s in api.CefStructs) {
                foreach(var f in s.CefFunctions) {
                    f.Comments = comments[f.Name];
                }
            }

            comments.Clear();

            regex = new Regex(commentPattern + "\\s*typedef\\s+enum\\s*{[^}]+}\\s*(\\w+)_t\\s*;", RegexOptions.Multiline);

            var enumFile = System.IO.Path.Combine("cef", "include", "internal", "cef_types.h");
            if(codeFiles.ContainsKey(enumFile)) {
                var enumCode = codeFiles[enumFile];
                ParseComments(enumFile, enumCode, regex, comments);
                foreach(var e in api.CefEnums) {
                    comments.TryGetValue(e.Name, out e.Comments);
                }

                comments.Clear();

                var enumBodyEx = new Regex("typedef\\s+enum\\s*({[^}]+})\\s*(\\w+)_t\\s*;", RegexOptions.Singleline);
                var enumFieldCommentEx = new Regex(commentPattern + "\\s*\\b(\\w+)(?:\\s*=\\s*\\w+)?\\s*[,}]", RegexOptions.Multiline);

                var mm = enumBodyEx.Matches(enumCode);
                foreach(Match m in mm) {
                    var body = m.Groups[1].Value;
                    var name = m.Groups[2].Value;
                    ParseComments(enumFile, body, enumFieldCommentEx, comments);
                    var e = enums[name];
                    foreach(var member in e.Members) {
                        comments.TryGetValue(member.Name, out member.Comments);
                    }
                    comments.Clear();
                }
            }

            regex = new Regex(commentPattern + "\\s*typedef\\s+struct\\s+_(cef_\\w+)\\b", RegexOptions.Multiline);

            foreach(var cf in codeFiles) {
                var file = cf.Key;
                var code = cf.Value;
                ParseComments(file, code, regex, comments);
            }

            foreach(var s in api.CefStructs) {
                s.Comments = comments[s.Name];
            }

            comments.Clear();

            var structBodyEx = new Regex("typedef\\s+struct\\s+_(\\w+)\\s*{(.*?)}\\s*\\1\\s*;", RegexOptions.Singleline);
            var callbackCommentsEx = new Regex(commentPattern + "[^;]*CEF_CALLBACK\\s*\\*\\s*(\\w+)", RegexOptions.Multiline | RegexOptions.Compiled);
            var valueCommentsEx = new Regex(commentPattern + "[^;]*\\b(\\w+)\\s*;", RegexOptions.Multiline | RegexOptions.Compiled);

            foreach(var cf in codeFiles) {
                var file = cf.Key;
                var code = cf.Value;

                var mm = structBodyEx.Matches(code);
                foreach(Match m in mm) {
                    var name = m.Groups[1].Value;
                    var body = m.Groups[2].Value;
                    var t = structs[name];

                    ParseComments(file, body, callbackCommentsEx, comments);
                    foreach(var sm in t.StructMembers) {
                        comments.TryGetValue(sm.Name, out sm.Comments);
                    }
                    comments.Clear();

                    ParseComments(file, body, valueCommentsEx, comments);
                    foreach(var sm in t.StructMembers) {
                        if(sm.Comments == null)
                            comments.TryGetValue(sm.Name, out sm.Comments);
                    }
                    comments.Clear();
                }
            }
        }

        private void ParseComments(string file, string code, Regex ex, Dictionary<string, CommentData> comments) {
            var mm = ex.Matches(code);
            foreach(Match m in mm) {
                var commentLines = m.Groups[1].Value;
                var name = m.Groups[2].Value;
                var cdat = GetCommentArray(commentLines);
                cdat.FileName = file;
                comments.Add(name, cdat);
            }
        }

        private List<string> l = new List<string>();
        private Regex commentArrayRegex = new Regex("^\\s*//+(.*?)$", RegexOptions.Multiline);

        private CommentData GetCommentArray(string comments) {
            var mm = commentArrayRegex.Matches(comments);
            l.Clear();
            for(var i = 0; i <= mm.Count - 1; i++) {
                var line = mm[i].Groups[1].Value.Trim();
                line = line.Replace("<", "&lt;");
                if(!string.IsNullOrWhiteSpace(line)) {
                    if(!line.Equals("The resulting string must be freed by calling cef_string_userfree_free().")) {
                        l.Add(line);
                    }
                }
            }
            var cc = new CommentData();
            cc.Lines = l.ToArray();
            return cc;
        }

        private void ParseCppHeaders() {
            var classEx = new Regex("(?:/\\*--cef\\(([^)]*)\\)--\\*/\\s*)?class\\s+(\\w+)\\s*(?::\\s*public\\s+virtual\\s+CefBase\\s*)?{(.+?)};", RegexOptions.Singleline);
            var boolRetvalEx = new Regex("\\bbool\\b\\s+(\\w+)\\s*\\(");
            var funcEx = new Regex("(\\w+)\\s*\\((.*?)\\)", RegexOptions.Singleline);
            var boolParamEx = new Regex("\\bbool\\b(?:\\s*[&*])?\\s*\\b(\\w+)\\b");

			var files = Directory.GetFiles(System.IO.Path.Combine("cef", "include"));
            foreach(var f in files) {
                var code = File.ReadAllText(f);

                var mmClasses = classEx.Matches(code);
                foreach(Match m in mmClasses) {
                    var cefConfig = m.Groups[1].Value;
                    var className = m.Groups[2].Value;
                    var body = m.Groups[3].Value;

                    AddCefConfig(ReduceToken(className), cefConfig, null, null);

                    ParseCefConfig(className, body);

                    var mmRetvals = boolRetvalEx.Matches(body);
                    foreach(Match m1 in mmRetvals) {
                        booleanRetvals.Add(ReduceToken(className + m1.Groups[1].Value));
                    }
                    var mmFunc = funcEx.Matches(body);
                    foreach(Match m1 in mmFunc) {
                        var funcName = m1.Groups[1].Value;
                        var mmParam = boolParamEx.Matches(m1.Groups[2].Value);
                        foreach(Match m2 in mmParam) {
                            booleanParameters.Add(ReduceToken(className + funcName + m2.Groups[1].Value));
                        }
                    }
                }

                code = classEx.Replace(code, "");

                var mmRetvalsGlob = boolRetvalEx.Matches(code);
                foreach(Match m in mmRetvalsGlob) {
                    booleanRetvals.Add(ReduceToken(m.Groups[1].Value));
                }

                var mmFuncGlob = funcEx.Matches(code);
                foreach(Match m1 in mmFuncGlob) {
                    var funcName = m1.Groups[1].Value;
                    var mmParam = boolParamEx.Matches(m1.Groups[2].Value);
                    foreach(Match m2 in mmParam) {
                        booleanParameters.Add(ReduceToken(funcName + m2.Groups[1].Value));
                    }
                }
            }
        }

        private string ReduceToken(string token) {
            // Reduce the token to lowercase characters for matching against the C api
            return token.Replace("_", "").ToLowerInvariant();
        }

        private void ParseCefConfig(string className, string code) {
            var cefConfigTagEx = new Regex("/\\*--cef\\(([^)]*)\\)--\\*/[^(]*\\b(\\w+)\\s*\\(");

            var mm = cefConfigTagEx.Matches(code);
            foreach(Match m in mm) {
                var config = m.Groups[1].Value;
                if(config.Length > 0) {
                    var funcName = m.Groups[2].Value;
                    var token = ReduceToken(className + funcName);
                    AddCefConfig(token, config, className, funcName);
                }
            }
        }

        private void AddCefConfig(string token, string config, string className, string funcName) {
            if(config.Length > 0) {
                var items = config.Split(',');
                var data = new CefConfigData();
                var optParams = new List<string>();
                foreach(var item in items) {
                    var pair = item.Split('=');
                    string value = null;
                    if(pair.Length == 2) {
                        value = pair[1].Trim();
                    }

                    switch(pair[0].Trim()) {
                        case "capi_name":
                            data.CppApiName = funcName;
                            token = ReduceToken(className + value);
                            break;

                        case "index_param":
                            data.IndexParameter = value;
                            break;

                        case "optional_param":
                            optParams.Add(value);
                            break;

                        case "count_func":
                            data.CountFunction = value;
                            break;

                        case "default_retval":
                            data.DefaultRetval = value;
                            break;

                        case "api_hash_check":
                            data.ApiHashCheck = true;
                            break;

                        case "source":
                            data.Source = value;
                            break;

                        case "no_debugct_check":
                            data.NoDebugctCheck = true;
                            break;

                        default:
                            System.Diagnostics.Debugger.Break();
                            break;
                    }
                }
                data.OptionalParameters = optParams.ToArray();
                cefConfigs.Add(token, data);
            }
        }
    }
}