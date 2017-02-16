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
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = Group01);

            if(success) {

                Ensure(
                    SkipSummary()
                    && Skip("cef_base_t base;")
                );

                while(
                    ParseCefCallback(cefStruct.StructMembers)
                    || SkipCommentBlock()
                ) ;
                Ensure(Skip(@"}\s*\w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool ParseCefCallback(List<StructMemberData> members) {
            Mark();
            var m = new StructMemberData();
            m.CallbackSignature = new SignatureData();
            var success =
                ParseSummary(m.Comments)
                && ParseType(m.CallbackSignature.ReturnType)
                && Skip(@"\(\s*CEF_CALLBACK \*")
                && Scan(@"\w+", () => m.Name = Value)
                && Skip(@"\)\(")
                && ParseParameterList(m.CallbackSignature.Arguments)
                && Skip(@"\)\s*;");
            if(success)
                members.Add(m);
            Unmark(success);
            return success;
        }

    }
}
