// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class CefEnumType : ApiType {

    public class EnumMember {
        public readonly string Name;
        public readonly string Value;

        public readonly CommentNode Comments;

        public EnumMember(string name, string value, CommentNode Comments) {
            this.Name = name;
            if(!string.IsNullOrEmpty(value))
                this.Value = value;
            this.Comments = Comments;
        }

        public override string ToString() {
            if(Value != null) {
                return Name + " = " + Value;
            } else {
                return Name;
            }
        }
    }

    private readonly EnumMember[] members;

    private readonly CommentNode comments;

    public CefEnumType(Parser.EnumNode enumNode)
        : base(enumNode.Name) {
        members = new EnumMember[enumNode.Members.Count];
        for(var i = 0; i <= enumNode.Members.Count - 1; i++) {
            members[i] = new EnumMember(enumNode.Members[i].Name, enumNode.Members[i].Value, enumNode.Members[i].Comments);
        }
        comments = enumNode.Comments;
    }

    protected CefEnumType(string name)
        : base(name) {
    }

    public override string OriginalSymbol {
        get { return Name + "_t"; }
    }

    public override string PInvokeSymbol {
        get { return "int"; }
    }

    public override string PublicSymbol {
        get { return CSharp.ApplyStyle(CfxName); }
    }

    public override string RemoteCallSymbol {
        get { return "int"; }
    }

    public override string RemoteSymbol {
        get { return PublicSymbol; }
    }

    public string CfxName {
        get { return "cfx_" + Name.Substring(4); }
    }

    public override string PublicCallArgument(string var) {
        return string.Format("(int){0}", var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("({0}){1}", PublicSymbol, var);
    }

    public override string PublicUnwrapExpression(string var) {
        return "(int)" + var;
    }

    public override string RemoteUnwrapExpression(string var) {
        return "(int)" + var;
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("({0}){1}", RemoteSymbol, var);
    }

    private static string[] additionalFlags = { "CfxSslContentStatus", "CfxV8PropertyAttribute", "CfxDragOperationsMask", "CfxFileDialogMode", "CfxJsonWriterOptions", "CfxTransitionType", "CfxV8AccessControl" };

    public override void EmitRemotePreCallStatements(CodeBuilder b, string var) {
        b.AppendLine("call.{0} = (int){0};", CSharp.Escape(var));
    }

    private static string GetEnumMemberValue(string originalValue) {
        switch(originalValue) {

            case "ERR_CERT_COMMON_NAME_INVALID":
                return "CertCommonNameInvalid";
            case "ERR_CERT_VALIDITY_TOO_LONG":
                return "CertValidityTooLong";
            case "UINT_MAX":
                return "unchecked((int)UInt32.MaxValue)";
            case "REFERRER_POLICY_CLEAR_REFERRER_ON_TRANSITION_FROM_SECURE_TO_INSECURE":
                return "ClearReferrerOnTransitionFromSecureToInsecure";
            default:
                return string.Format("unchecked((int){0})", originalValue);
        }
    }

    public void EmitEnum(CodeBuilder b) {
        var enumName = CSharp.ApplyStyle(CfxName);

        b.AppendSummaryAndRemarks(comments);

        if(Name.Contains("_flags") || additionalFlags.Contains(enumName)) {
            b.AppendLine("[Flags()]");
        }

        var prefixBuilder = new StringBuilder();
        var allEqual = true;

        do {
            char c = members[0].Name[prefixBuilder.Length];
            for(var i = 1; i <= members.Length - 1; i++) {
                if(c != members[i].Name[prefixBuilder.Length]) {
                    allEqual = false;
                    break;
                }
            }
            if(allEqual)
                prefixBuilder.Append(c);

        } while(allEqual);

        while(prefixBuilder.Length > 0 && prefixBuilder[prefixBuilder.Length - 1] != '_')
            --prefixBuilder.Length;

        b.BeginBlock("public enum {0}", enumName);
        foreach(var m in members) {
            var var = CSharp.ApplyStyle(m.Name.Substring(prefixBuilder.Length));

            if(char.IsDigit(var[0])) {
                switch(enumName) {
                    case "CfxScaleFactor":
                        var = "ScaleFactor" + var;
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                }
            }

            b.AppendSummary(m.Comments);
            b.Append(var);
            if(m.Value != null) {
                b.Append(" = {0}", GetEnumMemberValue(m.Value));
            }
            b.AppendLine(",");
        }
        b.TrimRight();
        b.CutRight(1);
        b.AppendLine();
        b.EndBlock();
    }

    public override bool IsCefEnumType {
        get { return true; }
    }

    public override CefEnumType AsCefEnumType {
        get { return this; }
    }
}