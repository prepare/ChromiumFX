using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Parser {

    internal class Parser {

        private Scanner scanner;
        private string currentFile;

        private bool Skip(string pattern) {
            return scanner.Scan(pattern, RegexOptions.None);
        }

        private bool Skip(string pattern, RegexOptions options) {
            return scanner.Scan(pattern, options);
        }

        private bool Scan(string pattern, Action onSuccess) {
            if(scanner.Scan(pattern, RegexOptions.None)) {
                onSuccess?.Invoke();
                return true;
            }
            return false;
        }

        private void Mark() {
            scanner.Mark();
        }

        private void Unmark(bool success) {
            scanner.Unmark(success);
        }

        [DebuggerStepThrough]
        private bool Ensure(bool success) {
            if(success) return true;
            Debug.Print("File: " + currentFile);
            scanner.ShowPosition();
            throw new Exception("Ensure failed.");
        }

        internal CefApiData Parse() {

            var api = new CefApiData();

            var files = Directory.GetFiles(System.IO.Path.Combine("cef", "include", "capi"));
            foreach(var f in files) {
                if(Path.GetFileName(f) == "cef_base_capi.h") continue;
                var content = File.ReadAllText(f);
                currentFile = f;
                scanner = new Scanner(content);
                ParseCApiFile(api);
            }

            currentFile = Path.Combine("cef", "include", "internal", "cef_types.h");
            scanner = new Scanner(File.ReadAllText(currentFile));
            ParseInternalFile(api);
            currentFile = Path.Combine("cef", "include", "internal", "cef_time.h");
            scanner = new Scanner(File.ReadAllText(currentFile));
            ParseInternalFile(api);

            return api;
        }

        /// <summary>
        /// A file in the include/capi folder
        /// </summary>
        private void ParseCApiFile(CefApiData api) {
            while(!scanner.Done) {
                Mark();
                var success =
                    ParseCallbackStruct(api.CefStructs)
                    || ParseCefExportFunction(api.CefFunctions)
                    || SkipHeaderCode();
                Unmark(success);
                Ensure(success);
            }
        }

        /// <summary>
        /// A file in the include/internal folder
        /// </summary>
        private void ParseInternalFile(CefApiData api) {
            while(!scanner.Done) {
                Mark();
                var success =
                    ParseCefEnum(api.CefEnums)
                    || ParseCefTypeStruct(api.CefStructs)
                    || SkipHeaderCode();
                Unmark(success);
                Ensure(success);
            }
        }

        private bool ParseCallbackStruct(List<StructData> structs) {
            Mark();
            var cefStruct = new StructData();
            var success =
                ParseSummary(cefStruct.Comments)
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = scanner.Group01)
                && Skip(@"///.*cef_base_t base;", RegexOptions.Singleline);

            if(success) {
                while(
                    ParseCefCallback(cefStruct.CefFunctions)
                    || SkipComments()
                ) ;
                Ensure(Skip(@"} \w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool ParseCefExportFunction(List<FunctionData> functions) {
            Mark();
            var f = new FunctionData();
            var success =
                ParseSummary(f.Comments)
                && Skip(@"CEF_EXPORT\b")
                && ParseType(f.Signature.ReturnType)
                && Scan(@"\w+", () => f.Name = scanner.Value)
                && Skip(@"\(")
                && ParseParameterList(f.Signature.Arguments)
                && Skip(@"\);");
            if(success)
                functions.Add(f);
            Unmark(success);
            return success;
        }

        private bool ParseCefEnum(List<EnumData> enums) {
            var e = new EnumData();
            Mark();
            var success =
                ParseSummary(e.Comments)
                && Skip(@"typedef\s+enum\s*{");

            if(!success) {
                Unmark(false);
                return false;
            }

            while(ParseCefEnumValue(e.Members)) {
                if(!Skip(",")) break;
            }
            success = Scan(@"}\s*(\w+);", () => e.Name = scanner.Group01);
            Unmark(success);
            enums.Add(e);
            return Ensure(success);
        }

        private bool ParseCefEnumValue(List<EnumMemberData> members) {
            var member = new EnumMemberData();
            ParseSummary(member.Comments);
            if(!Scan(@"\w+", () => member.Name = scanner.Value)) return false;
            if(Skip("=")) {
                Ensure(Scan("[^,}\n]+", () => member.Value = scanner.Value));
            }
            members.Add(member);
            return true;
        }


        private bool ParseCefTypeStruct(List<StructData> structs) {
            Mark();
            var cefStruct = new StructData();
            var success =
                ParseSummary(cefStruct.Comments)
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = scanner.Group01);

            if(success) {
                while(
                    ParseCefCallback(cefStruct.CefFunctions)
                    || SkipComments()
                ) ;
                Ensure(Skip(@"} \w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool SkipHeaderCode() {
            return
                Skip(@"#ifdef\s+__cplusplus\s*}\s*#endif")
                || Skip(@"extern\s*""C""\s*{")
                || SkipAll(@"struct\s+\w+;")
                || SkipAll(@"typedef\s+\w+\s+\w+\s*;")
                || SkipPreprocessorDirective()
                || SkipComments();
        }

        private bool SkipComments() {
            return
                SkipAll(@"// .*")
                || SkipAll(@"//\n");
        }
        private bool SkipPreprocessorDirective() {
            string line = null;
            var success = Scan(@"#\w+.*", () => line = scanner.Value);
            if(!success) return false;
            while(line.EndsWith(@"\")) {
                Scan(@".*", () => line = scanner.Value);
            }
            return true;
        }

        private bool SkipAll(string pattern) {
            if(Skip(pattern)) {
                while(Skip(pattern)) ;
                return true;
            }
            return false;
        }

        private bool ParseSummary(CommentData comments) {
            var lines = new List<string>();
            var success = Skip(@"///");
            if(success) {
                while(
                    Scan(@"// (.*)", () => lines.Add(scanner.Group01))
                    || Scan(@"//\n", () => lines.Add(string.Empty))
                ) ;
                Ensure(Skip(@"///"));
                comments.Lines = lines.ToArray();
                SkipComments();
            }
            return success;
        }

        private bool ParseCefCallback(List<FunctionData> functions) {
            Mark();
            var f = new FunctionData();
            var success =
                ParseSummary(f.Comments)
                && ParseType(f.Signature.ReturnType)
                && Skip(@"\(\s*CEF_CALLBACK \*")
                && Scan(@"\w+", () => f.Name = scanner.Value)
                && Skip(@"\)\(")
                && ParseParameterList(f.Signature.Arguments)
                && Skip(@"\);");
            if(success)
                functions.Add(f);
            Unmark(success);
            return success;
        }

        private bool ParseType(TypeData type) {
            Mark();
            var success = Scan(@"(?:struct _)?(\w+)", () => type.Name = scanner.Group01);
            if(success) {
                type.Indirection = string.Empty;
                while(
                    Scan(@"const\b", () => { type.Indirection += scanner.Value; })
                    || Scan(@"\*", () => type.Indirection += scanner.Value)
                ) ;
            }
            Unmark(success);
            return success;
        }

        private bool ParseParameterList(List<ArgumentData> parameters) {
            var p = new ArgumentData();
            while(ParseParameter(p)) {
                parameters.Add(p);
                if(!Skip(",")) break;
                p = new ArgumentData();
            }
            return true;
        }

        private bool ParseParameter(ArgumentData parameter) {
            Mark();
            Scan(@"const\b", () => parameter.IsConst = true);
            var success =
                ParseType(parameter.ArgumentType)
                && Scan(@"\w+", () => parameter.Var = scanner.Value);
            Unmark(success);
            return success;
        }
    }
}
