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

namespace Parser {

    internal abstract class CHeaderParser : Parser {

        // rules for both c header parsers

        protected bool ParseCefExportFunction(List<FunctionNode> functions) {
            Mark();
            var f = new FunctionNode();
            ParseSummary(f.Comments);
            var success =
                Skip(@"CEF_EXPORT\b");
            if(success) {
                Scan(@"const\b", () => f.Signature.ReturnValueIsConst = true);
                Ensure(
                    ParseType(f.Signature.ReturnType)
                    && Scan(@"\w+", () => f.Name = Value)
                    && Skip(@"\(")
                    && ParseParameterList(f.Signature.Parameters)
                    && Skip(@"\)\s*;")
                );
            }
            if(success)
                functions.Add(f);
            Unmark(success);
            return success;
        }

        protected bool ParseParameterList(List<ParameterNode> parameters) {
            var p = new ParameterNode();
            while(ParseParameter(p)) {
                parameters.Add(p);
                if(!Skip(",")) break;
                p = new ParameterNode();
            }
            return true;
        }

        protected bool ParseParameter(ParameterNode parameter) {
            Mark();
            Scan(@"const\b", () => parameter.IsConst = true);
            var success =
                ParseType(parameter.ParameterType)
                && Scan(@"\w+", () => parameter.Var = Value);
            Unmark(success);
            return success;
        }

        protected bool ParseType(TypeNode type) {
            Mark();
            var success =
                Scan("long long", () => type.Name = Value)
                || Scan(@"unsigned \w+", () => type.Name = Value)
                || Scan(@"(?:struct _)?(\w+)", () => type.Name = Group01);
            if(success) {
                var tmp =
                    Scan(@"\*\s*const\s*\*", () => type.Indirection = Value)
                    || Scan(@"const\s*\*", () => type.Indirection = Value)
                    || Scan(@"(?:\s*\*)+", () => type.Indirection = Value);
            }
            Unmark(success);
            return success;
        }
    }
}
