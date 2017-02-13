using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {

    /// <summary>
    /// Parser for files in the include/internals folder
    /// </summary>
    internal class CefInternalsParser : CHeaderParser {

        protected override void Parse(CefApiData api) {
            while(!Done) {
                Ensure(
                    ParseCefEnum(api.CefEnums)
                    || ParseCefTypeStruct(api.CefStructs)
                    || ParseCefExportFunction(api.CefFunctions)
                    || SkipCHeaderCode()
                );
            }
        }

        private bool ParseCefTypeStruct(List<StructData> structs) {
            Mark();
            var cefStruct = new StructData();
            var success =
                ParseSummary(cefStruct.Comments)
                && Scan(@"typedef struct _(cef_\w+_t) {", () => cefStruct.Name = Group01);

            if(success) {
                while(
                    ParseCefTypeStructMember(cefStruct.StructMembers)
                    || SkipCommentBlock()
                ) ;
                Ensure(Skip(@"} \w+;"));
                structs.Add(cefStruct);
            }
            Unmark(success);
            return success;
        }

        private bool ParseCefTypeStructMember(List<StructMemberData> members) {
            var m = new StructMemberData();
            Mark();
            ParseSummary(m.Comments);
            var success =
                ParseType(m.MemberType)
                && Scan(@"\w+", () => m.Name = Value)
                && Skip(";");
            if(success) members.Add(m);
            Unmark(success);
            return success;
        }

        private bool ParseCefEnum(List<EnumData> enums) {
            var e = new EnumData();
            Mark();
            var success =
                (ParseSummary(e.Comments) || ParseCommentBlock(e.Comments))
                && Skip(@"typedef\s+enum\s*{");

            if(!success) {
                Unmark(false);
                return false;
            }

            while(
                ParseCefEnumValue(e.Members)
                || SkipCommentBlock()
            ) ;
            success = Scan(@"}\s*(\w+);", () => e.Name = Group01);
            Unmark(success);
            enums.Add(e);
            return Ensure(success);
        }
    }
}
