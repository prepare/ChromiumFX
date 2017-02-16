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

    /// <summary>
    /// Parser for files in the include/internals folder
    /// </summary>
    internal class CefInternalsParser : CHeaderParser {

        protected override void Parse(CefApiNode api) {
            while(!Done) {
                Ensure(
                    ParseCefEnum(api.CefEnums)
                    || ParseCefTypeStruct(api.CefStructs)
                    || ParseCefExportFunction(api.CefFunctions)
                    || SkipCHeaderCode()
                );
            }
        }

        private bool ParseCefTypeStruct(List<StructNode> structs) {
            Mark();
            var cefStruct = new StructNode();
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

        private bool ParseCefTypeStructMember(List<StructMemberNode> members) {
            var m = new StructMemberNode();
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

        private bool ParseCefEnum(List<EnumNode> enums) {
            var e = new EnumNode();
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
            success = Scan(@"}\s*(\w+)_t\s*;", () => e.Name = Group01);
            Unmark(success);
            enums.Add(e);
            return Ensure(success);
        }

        private bool ParseCefEnumValue(List<EnumValueNode> members) {
            var member = new EnumValueNode();
            Mark();
            ParseSummary(member.Comments);
            var success = Scan(@"\w+", () => member.Name = Value);
            if(success) {
                if(Skip("="))
                    Ensure(Scan("[^,}\n/]+", () => member.Value = Value.Trim()));
                members.Add(member);
            }
            Skip(",");
            Unmark(success);
            return success;
        }
    }
}
