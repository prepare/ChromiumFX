// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


using System.Diagnostics;
using System.Linq;
using System.Text;

public class CefEnumType : ApiType {

    public class EnumMember {
        public readonly string Name;
        public readonly string Value;

        public readonly CommentData Comments;

        public EnumMember(string name, string value, CommentData Comments) {
            this.Name = name;
            if(value.Length > 0)
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

    private readonly CommentData comments;

    public CefEnumType(Parser.EnumData data)
        : base(data.Name) {
        members = new EnumMember[data.Members.Count];
        for(var i = 0; i <= data.Members.Count - 1; i++) {
            members[i] = new EnumMember(data.Members[i].Name, data.Members[i].Value, data.Members[i].Comments);
        }
        comments = data.Comments;
    }

    protected CefEnumType(string name)
        : base(name) {
    }

    public override string OriginalSymbol {
        get { return Name + "_t"; }
    }

    public override string ProxySymbol {
        get { return "int"; }
    }

    public override string RemoteSymbol {
        get { return PublicSymbol; }
    }

    public string CfxName {
        get { return "cfx_" + Name.Substring(4); }
    }

    public override string PInvokeSymbol {
        get { return CSharp.ApplyStyle(CfxName); }
    }

    public override string RemoteUnwrapExpression(string var) {
        return "(int)" + var;
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("({0}){1}", RemoteSymbol, var);
    }

    public override string ProxyWrapExpression(string var) {
        return "(int)" + var;
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Format("({0}){1}", PublicSymbol, var);
    }

    private static string[] additionalFlags = { "CfxV8PropertyAttribute", "CfxDragOperationsMask", "CfxFileDialogMode", "CfxJsonWriterOptions", "CfxTransitionType", "CfxV8AccessControl" };

    private static string GetEnumMemberValue(string originalValue) {
        switch(originalValue) {

            case "ERR_CERT_COMMON_NAME_INVALID":
                return "CertCommonNameInvalid";
            case "ERR_CERT_VALIDITY_TOO_LONG":
                return "CertValidityTooLong";
            case "UINT_MAX":
                return "unchecked((int)UInt32.MaxValue)";
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