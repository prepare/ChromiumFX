// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Parser {

    /// <summary>
    /// A simple recursive descent parser for scraping the CEF API header files
    /// with a regex scanner as token stream.
    /// 
    /// The C API header files are scraped for type and function definitions and comments. 
    /// 
    /// The C++ API header files are scraped
    /// for useful additional information needed for the wrapper generator 
    /// like --cef(...)-- tags and boolean function parameters.
    /// </summary>
    internal abstract class Parser {


        internal static CefApiNode Parse() {

            var apiNode = new CefApiNode();

            Parser p = new CefCApiParser();
            p.SetFile(Path.Combine("cef", "include", "cef_version.h"));
            p.Parse(apiNode);
            var files = Directory.GetFiles(Path.Combine("cef", "include", "capi"));
            foreach(var f in files) {
                if(Path.GetFileName(f) == "cef_base_capi.h") continue;
                p.SetFile(f);
                p.Parse(apiNode);
            }



            p = new CefInternalsParser();

            p.SetFile(Path.Combine("cef", "include", "internal", "cef_types.h"));
            p.Parse(apiNode);

            CefApiNode tmpApi = new CefApiNode();

            p.SetFile(Path.Combine("cef", "include", "internal", "cef_time.h"));
            p.Parse(tmpApi);
            apiNode.CefValueStructs.AddRange(tmpApi.CefValueStructs);

            tmpApi = new CefApiNode();

            p.SetFile(Path.Combine("cef", "include", "internal", "cef_string_list.h"));
            p.Parse(tmpApi);
            p.SetFile(Path.Combine("cef", "include", "internal", "cef_string_map.h"));
            p.Parse(tmpApi);
            p.SetFile(Path.Combine("cef", "include", "internal", "cef_string_multimap.h"));
            p.Parse(tmpApi);
            apiNode.CefStringCollectionFunctions = tmpApi.CefFunctions.ToArray();

            tmpApi = new CefApiNode();
            p.SetFile(Path.Combine("cef", "include", "internal", "cef_types_win.h"));
            p.Parse(tmpApi);
            apiNode.CefFunctionsWindows = tmpApi.CefFunctions;
            apiNode.CefStructsWindows = tmpApi.CefValueStructs;

            tmpApi = new CefApiNode();
            p.SetFile(Path.Combine("cef", "include", "internal", "cef_types_linux.h"));
            p.Parse(tmpApi);
            apiNode.CefFunctionsLinux = tmpApi.CefFunctions;
            apiNode.CefStructsLinux = tmpApi.CefValueStructs;

            p = new CefClassesParser();

            files = Directory.GetFiles(System.IO.Path.Combine("cef", "include"));
            foreach(var f in files) {
                if(Path.GetFileName(f) == "cef_base.h") continue;
                if(Path.GetFileName(f) == "cef_pack_resources.h") continue;
                if(Path.GetFileName(f) == "cef_pack_strings.h") continue;
                if(Path.GetFileName(f) == "cef_sandbox_win.h") continue;
                if(Path.GetFileName(f) == "cef_version.h") continue;

                p.SetFile(f);
                p.Parse(apiNode);
            }
            
            return apiNode;
        }
        
        public static string ParseApiHash() {
            var code = File.ReadAllText(System.IO.Path.Combine("cef", "include", "cef_version.h"));
            var ex = new Regex(@"CEF_API_HASH_UNIVERSAL ""(\w+)""");
            Debug.Assert(ex.IsMatch(code));
            return ex.Match(code).Groups[1].Value;
        }


        private Scanner scanner;
        protected string currentFile;

        protected abstract void Parse(CefApiNode data);

        protected bool Skip(string pattern) {
            return scanner.Scan(pattern, RegexOptions.None);
        }

        protected bool Skip(string pattern, RegexOptions options) {
            return scanner.Scan(pattern, options);
        }

        protected bool Scan(string pattern, Action onSuccess) {
            if(scanner.Scan(pattern, RegexOptions.None)) {
                onSuccess?.Invoke();
                return true;
            }
            return false;
        }

        protected void Mark() {
            scanner.Mark();
        }

        protected void Unmark(bool success) {
            scanner.Unmark(success);
        }

        protected bool Done {
            get {
                return scanner.Done;
            }
        }

        protected string Value {
            get {
                return scanner.Value;
            }
        }

        protected string Group01 {
            get {
                return scanner.Group01;
            }
        }

        [DebuggerStepThrough]
        protected bool Ensure(bool success) {
            if(success) return true;
            Debug.Print("***** Parser Failure *****");
            Debug.Print("File: " + currentFile);
            scanner.ShowPosition();
            throw new Exception("Parser Failure.");
        }

        protected void SetFile(string filename) {
            currentFile = filename;
            var content = File.ReadAllText(currentFile);
            content = Regex.Replace(content, @"\r\n", "\n");
            scanner = new Scanner(content);
        }

        protected bool SkipAll(string pattern) {
            if(Skip(pattern)) {
                while(Skip(pattern)) ;
                return true;
            }
            return false;
        }

        // common rules for all parsers

        protected bool SkipPreprocessorDirective() {
            string line = null;
            var success = Scan(@"#\w+.*", () => line = scanner.Value);
            if(!success) return false;
            while(line.EndsWith(@"\")) {
                Scan(@".*", () => line = scanner.Value);
            }
            return true;
        }

        protected bool ParseSummary(CommentNode comments) {
            Mark();
            var startFound = Skip(@"///");
            ParseCommentBlock(comments);
            var endFound = Skip(@"///");
            var success = startFound || endFound;
            if(success) {
                SkipCommentBlock();
            }
            Unmark(success);
            return success;
        }

        protected bool SkipSummary() {
            var success = Skip(@"///");
            if(success) {
                SkipCommentBlock();
                Skip(@"///");
            }
            return success;
        }

        protected bool ParseCommentBlock(CommentNode comments) {
            var lines = new List<string>();
            while(
                Scan(@"// (.*)", () => lines.Add(scanner.Group01))
                || Scan(@"//\n", () => lines.Add(string.Empty))
            ) ;
            comments.SetParserLines(lines);
            comments.FileName = currentFile;
            return lines.Count > 0;
        }

        protected bool SkipCommentBlock() {
            return
                SkipAll(@"// .*")
                || SkipAll(@"//\n");
        }

        protected bool SkipCHeaderCode() {
            return
                Skip(@"#ifdef\s+__cplusplus\s*}\s*#endif")
                || Skip(@"extern\s*""C""\s*{")
                || SkipAll(@"struct\s+\w+;")
                || SkipAll(@"typedef\s+(?:\w+(?:\s*\*)*\s+)+\w+\s*;")
                || SkipPreprocessorDirective()
                || SkipCommentBlock()
                || SkipSummary();
        }
    }
}
