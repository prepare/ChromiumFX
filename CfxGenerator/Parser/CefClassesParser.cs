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
using System.Text.RegularExpressions;

namespace Parser {

    /// <summary>
    /// Parser for files in the include folder with class definitions.
    /// </summary>
    internal class CefClassesParser : Parser {

        protected override void Parse(CefApiNode api) {
            while(!Done) {
                Ensure(
                    ParseClass(api.CefClasses)
                    || ParseFunction(api.CefCppFunctions)
                    || SkipCHeaderCode()
                    || SkipCppHeaderCode()
                );
            }
        }

        private bool ParseClass(List<CefClassNode> classes) {

            var c = new CefClassNode();
            Mark();
            var success =
                ParseCefConfig(c.CefConfig)
                && Scan(@"class (\w+)", () => c.Name = Group01)
                && Skip(": public (?:virtual )?CefBase {");

            if(success) {

                while(
                    ParseFunction(c.Methods)
                    || Skip("public:")
                    || SkipSummary()
                    || SkipCommentBlock()
                    || (Skip("typedef.*?;"))
                    ) ;

                Ensure(Skip(@"}\s*;"));
                classes.Add(c);
            }

            Unmark(success);
            return success;
        }

        private bool ParseFunction(List<CefCppFunctionNode> functions) {
            var f = new CefCppFunctionNode();

            Mark();

            var hasConfig = ParseCefConfig(f.CefConfig);

            while(
                Skip("virtual")
                || Scan("static", () => f.IsStatic = true)
            ) ;

            var success =
                ParseReturnType(f)
                && Scan(@"\w+", () => f.Name = Value)
                && Skip(@"\(");

            if(success) {
                while(ParseParameter(f.BooleanParameters))
                    Skip(",");
                Ensure(Skip(@"\)"));
                Ensure(Skip(";") || Skip(@"=\s*0;") || Skip(@"{.*?}", RegexOptions.Singleline));
                if(hasConfig) {
                    // only functions with the --cef(...)-- tag have a c-api counterpart.
                    functions.Add(f);
                }
            }

            Unmark(success);
            return success;
        }

        private bool ParseReturnType(CefCppFunctionNode f) {
            return
                Scan("bool", () => f.IsRetvalBoolean = true)
                || SkipType();
        }

        private bool ParseParameter(List<string> booleanParameters) {
            return
                Scan(@"bool\s+(\w+)", () => booleanParameters.Add(Group01))
                || Scan(@"bool\s*[&*]\s*(\w+)", () => booleanParameters.Add(Group01))
                || (SkipType() && Skip(@"\w+"));
        }

        private bool SkipType() {
            return
                Skip(@"(const\s+)?CefRefPtr<\w+>(?:\s*&)?")
                || Skip(@"(const\s+)?std::\w+<.+?>(?:\s*&)?")
                || Skip(@"const char\* const\*")
                || Skip(@"(const\s+)?\w+(?:\s*[&*])*");
        }

        private bool ParseCefConfig(CefConfigNode config) {

            if(!Skip(@"/\*--cef\(")) return false;

            while(ParseCefConfigItem(config)) {
                Skip(",");
            }
            Ensure(Skip(@"\)--\*/"));
            return true;
        }

        private bool ParseCefConfigItem(CefConfigNode config) {

            return
                Scan("api_hash_check", () => config.ApiHashCheck = true)
                || Scan("no_debugct_check", () => config.NoDebugctCheck = true)
                || Scan(@"optional_param=(\w+)", () => config.OptionalParameters.Add(Group01))
                || Scan(@"capi_name=(\w+)", () => config.CApiName = Group01)
                || Scan(@"index_param=(\w+)", () => config.IndexParameter = Group01)
                || Scan(@"count_func=(\w+:\w+)", () => config.CountFunction = Group01)
                || Scan(@"default_retval=(\w+)", () => config.DefaultRetval = Group01)
                || Scan(@"source=(\w+)", () => config.Source = Group01);
        }

        private bool SkipCppHeaderCode() {
            return 
                Skip(@"class\s+\w+\s*;")
                || (Skip("typedef.*?;"))
                ;
        }

    }
}
