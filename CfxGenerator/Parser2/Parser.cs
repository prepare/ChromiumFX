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


        internal static CefApiData Parse() {

            var api = new CefApiData();

            Parser p = new CefCApiParser();

            var files = Directory.GetFiles(System.IO.Path.Combine("cef", "include", "capi"));
            foreach(var f in files) {
                if(Path.GetFileName(f) == "cef_base_capi.h") continue;
                p.SetFile(f);
                p.Parse(api);
            }

            p = new CefInternalsParser();

            p.SetFile(Path.Combine("cef", "include", "internal", "cef_types.h"));
            p.Parse(api);
            p.SetFile(Path.Combine("cef", "include", "internal", "cef_time.h"));
            p.Parse(api);

            CefApiData tmpApi = new CefApiData();

            p.SetFile(Path.Combine(System.IO.Path.Combine("cef", "include", "internal", "cef_string_list.h")));
            p.Parse(tmpApi);
            p.SetFile(Path.Combine(System.IO.Path.Combine("cef", "include", "internal", "cef_string_map.h")));
            p.Parse(tmpApi);
            p.SetFile(Path.Combine(System.IO.Path.Combine("cef", "include", "internal", "cef_string_multimap.h")));
            p.Parse(tmpApi);
            api.CefStringCollectionFunctions = tmpApi.CefFunctions.ToArray();

            tmpApi = new CefApiData();
            p.SetFile(Path.Combine(System.IO.Path.Combine("cef", "include", "internal", "cef_types_win.h")));
            p.Parse(tmpApi);
            api.CefFunctionsWindows = tmpApi.CefFunctions;
            api.CefStructsWindows = tmpApi.CefStructs;

            tmpApi = new CefApiData();
            p.SetFile(Path.Combine(System.IO.Path.Combine("cef", "include", "internal", "cef_types_linux.h")));
            p.Parse(tmpApi);
            api.CefFunctionsWindows = tmpApi.CefFunctions;
            api.CefStructsWindows = tmpApi.CefStructs;

            p = new CefClassesParser();

            files = Directory.GetFiles(System.IO.Path.Combine("cef", "include"));
            foreach(var f in files) {
                if(Path.GetFileName(f) == "cef_base.h") continue;
                if(Path.GetFileName(f) == "cef_pack_resources.h") continue;
                if(Path.GetFileName(f) == "cef_pack_strings.h") continue;
                if(Path.GetFileName(f) == "cef_sandbox_win.h") continue;
                if(Path.GetFileName(f) == "cef_version.h") continue;

                p.SetFile(f);
                p.Parse(api);
            }

            return api;
        }



        private Scanner scanner;
        protected string currentFile;

        protected abstract void Parse(CefApiData data);

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
            scanner = new Scanner(File.ReadAllText(currentFile));
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

        protected bool ParseSummary(CommentData comments) {
            var success = Skip(@"///");
            if(success) {
                ParseCommentBlock(comments);
                if(Skip(@"///"))
                    SkipCommentBlock();
            }
            return success;
        }

        protected bool SkipSummary() {
            var success = Skip(@"///");
            if(Skip(@"///")) {
                SkipCommentBlock();
            }
            return success;
        }

        protected bool ParseCommentBlock(CommentData comments) {
            var lines = new List<string>();
            while(
                Scan(@"// (.*)", () => lines.Add(scanner.Group01))
                || Scan(@"//\n", () => lines.Add(string.Empty))
            ) ;
            comments.Lines = lines.ToArray();
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
