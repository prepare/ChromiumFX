using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {

    internal abstract class CHeaderParser : Parser {

        // rules for both c header parsers

        protected bool ParseCefExportFunction(List<FunctionData> functions) {
            Mark();
            var f = new FunctionData();
            ParseSummary(f.Comments);
            var success =
                Skip(@"CEF_EXPORT\b")
                && ParseType(f.Signature.ReturnType)
                && Scan(@"\w+", () => f.Name = Value)
                && Skip(@"\(")
                && ParseParameterList(f.Signature.Arguments)
                && Skip(@"\)\s*;");
            if(success)
                functions.Add(f);
            Unmark(success);
            return success;
        }

        protected bool ParseParameterList(List<ArgumentData> parameters) {
            var p = new ArgumentData();
            while(ParseParameter(p)) {
                parameters.Add(p);
                if(!Skip(",")) break;
                p = new ArgumentData();
            }
            return true;
        }

        protected bool ParseParameter(ArgumentData parameter) {
            Mark();
            Scan(@"const\b", () => parameter.IsConst = true);
            var success =
                ParseType(parameter.ArgumentType)
                && Scan(@"\w+", () => parameter.Var = Value);
            Unmark(success);
            return success;
        }

        protected bool ParseType(TypeData type) {
            Mark();
            var success =
                Scan("long long", () => type.Name = Value)
                || Scan(@"unsigned \w+", () => type.Name = Value)
                || Scan(@"(?:struct _)?(\w+)", () => type.Name = Group01);
            if(success) {
                type.Indirection = string.Empty;
                while(
                    Scan(@"const\b", () => { type.Indirection += Value; })
                    || Scan(@"\*", () => type.Indirection += Value)
                ) ;
            }
            Unmark(success);
            return success;
        }

        protected bool ParseCefEnumValue(List<EnumMemberData> members) {
            var member = new EnumMemberData();
            Mark();
            ParseSummary(member.Comments);
            var success = Scan(@"\w+", () => member.Name = Value);
            if(success) {
                if(Skip("="))
                    Ensure(Scan("[^,}\n]+", () => member.Value = Value));
                members.Add(member);
            }
            Skip(",");
            Unmark(success);
            return success;
        }
    }
}
