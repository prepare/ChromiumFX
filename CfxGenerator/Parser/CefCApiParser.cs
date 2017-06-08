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
    /// Parser for files in the include/capi folder
    /// </summary>
    internal class CefCApiParser : CHeaderParser {

        protected override void Parse(CefApiNode api) {
            while(!Done) {
                Ensure(
                    ParseCefCallbackStruct(api.CefCallbackStructs)
                    || ParseCefExportFunction(api.CefFunctions)
                    || SkipCHeaderCode()
                );
            }
        }

        private bool ParseCefCallbackStruct(List<CallbackStructNode> structs) {
            Mark();
            var cefStruct = new CallbackStructNode();
            var success =
                ParseSummary(cefStruct.Comments)
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = Group01);

            if(success) {

                Ensure(
                    SkipSummary()
                    && Scan("(cef_base_(?:ref_counted|scoped)_t) base;", () => cefStruct.CefBaseType = Group01)
                    );

                while(
                    ParseCefCallback(cefStruct.CefCallbacks)
                    || SkipCommentBlock()
                ) ;
                Ensure(Skip(@"}\s*\w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool ParseCefCallback(List<CallbackNode> members) {
            Mark();
            var m = new CallbackNode();
            m.Signature = new SignatureNode();
            var success =
                ParseSummary(m.Comments)
                && ParseType(m.Signature.ReturnType)
                && Skip(@"\(\s*CEF_CALLBACK\s*\*\s*")
                && Scan(@"\w+", () => m.Name = Value)
                && Skip(@"\)\(")
                && ParseParameterList(m.Signature.Parameters)
                && Skip(@"\)\s*;");
            if(success)
                members.Add(m);
            Unmark(success);
            return success;
        }

    }
}
