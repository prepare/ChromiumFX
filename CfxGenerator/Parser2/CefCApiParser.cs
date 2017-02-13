using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Parser {

    /// <summary>
    /// Parser for files in the include/capi folder
    /// </summary>
    internal class CefCApiParser : CHeaderParser {

        protected override void Parse(CefApiData api) {
            while(!Done) {
                Ensure(
                    ParseCefCallbackStruct(api.CefStructs)
                    || ParseCefExportFunction(api.CefFunctions)
                    || SkipCHeaderCode()
                );
            }
        }

        private bool ParseCefCallbackStruct(List<StructData> structs) {
            Mark();
            var cefStruct = new StructData();
            var success =
                ParseSummary(cefStruct.Comments)
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = Group01)
                && Skip(@"///.*cef_base_t base;", RegexOptions.Singleline);

            if(success) {
                while(
                    ParseCefCallback(cefStruct.CefFunctions)
                    || SkipCommentBlock()
                ) ;
                Ensure(Skip(@"} \w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool ParseCefCallback(List<FunctionData> functions) {
            Mark();
            var f = new FunctionData();
            var success =
                ParseSummary(f.Comments)
                && ParseType(f.Signature.ReturnType)
                && Skip(@"\(\s*CEF_CALLBACK \*")
                && Scan(@"\w+", () => f.Name = Value)
                && Skip(@"\)\(")
                && ParseParameterList(f.Signature.Arguments)
                && Skip(@"\)\s*;");
            if(success)
                functions.Add(f);
            Unmark(success);
            return success;
        }

    }
}
