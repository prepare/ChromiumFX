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


using System.Text.RegularExpressions;

public class CSharp {

    public static string Escape(string symbol) {
        switch(symbol) {
            case "event":
            case "string":
            case "checked":
            case "object":
            case "delegate":
            case "this":
                return "@" + symbol;

            case "params":
                return "parameters";

            default:
                return symbol;
        }
    }

    public static string PrepareSummaryLine(string line, bool forRemote = false, bool forEvent = false) {
        line = Regex.Replace(line, "&(?!\\w+;)", "&amp;");

        line = Regex.Replace(line, "\\b(cef_\\w+)_t(\\w+)?\\b", PrepareSummaryLine_TypeMatch);
        line = Regex.Replace(line, "\\b(Cef\\w+)(?:\\.|::|->)(\\w+)\\b", PrepareSummaryLine_MemberMatch);
        line = Regex.Replace(line, "->([\\w_]+)\\(", PrepareSummaryLine_FunctionMatch);

        PrepareSummaryLine_ArgumentMatch_ForEvent = forEvent;
        line = Regex.Replace(line, "\\|(\\w+)\\|", PrepareSummaryLine_ArgumentMatch);

        var prefix = forRemote ? "Cfr" : "Cfx";
        line = Regex.Replace(line, "\\bCef(\\w+)\\b", prefix + "$1");
        return line;
    }

    private static string PrepareSummaryLine_TypeMatch(Match m) {
        if(m.Groups[2].Success) {
            Program.DocumentationFormatBugStillExists = true;
            return ApplyStyle(m.Groups[1].Value, false) + m.Groups[2].Value;
        } else {
            return ApplyStyle(m.Groups[1].Value, false);
        }
    }

    private static string PrepareSummaryLine_MemberMatch(Match m) {
        return string.Format("{0}.{1}", m.Groups[1].Value, ApplyStyle(m.Groups[2].Value, false));
    }

    private static string PrepareSummaryLine_FunctionMatch(Match m) {
        return string.Format(".{0}(", ApplyStyle(m.Groups[1].Value, false));
    }

    private static bool PrepareSummaryLine_ArgumentMatch_ForEvent;

    private static string PrepareSummaryLine_ArgumentMatch(Match m) {
        return string.Format("|{0}|", ApplyStyle(m.Groups[1].Value, !PrepareSummaryLine_ArgumentMatch_ForEvent));
    }

    public static string ApplyStyle(string name, bool firstLower = false) {
        if(!name.Contains("_")) {
            if(name == "cont")
                name = "continue";

            for(var i = 0; i <= name.Length - 1; i++) {
                if(char.IsLower(name[i])) {
                    goto skip_to_lower;
                }
            }
            name = name.ToLowerInvariant();
            skip_to_lower:

            name = CapitalizeParts(name);

            if(firstLower) {
                if(char.IsUpper(name[0])) {
                    name = char.ToLower(name[0]) + name.Substring(1);
                }
            } else {
                if(char.IsLower(name[0])) {
                    name = char.ToUpper(name[0]) + name.Substring(1);
                }
            }

            return name;
        }

        string n1 = null;

        var parts = name.ToLowerInvariant().Split('_');
        for(var i = 0; i <= parts.Length - 1; i++) {
            parts[i] = CapitalizeFirst(parts[i]);
        }

        n1 = CapitalizeParts(string.Join("", parts));

        if(firstLower) {
            n1 = char.ToLowerInvariant(n1[0]) + n1.Substring(1);
        }

        return n1;
    }

    private static string CapitalizeParts(string name) {
        name = name.Replace("type", "Type");
        name = name.Replace("dialog", "Dialog");
        name = name.Replace("flag", "Flag");
        name = name.Replace("item", "Item");
        name = name.Replace("event", "Event");
        name = name.Replace("severity", "Severity");
        name = name.Replace("storage", "Storage");
        name = name.Replace("parts", "Parts");
        name = name.Replace("request", "Request");
        name = name.Replace("accessor", "Accessor");
        name = name.Replace("context", "Context");
        name = name.Replace("exception", "Exception");
        name = name.Replace("handler", "Handler");
        name = name.Replace("stack", "Stack");
        name = name.Replace("value", "Value");
        name = name.Replace("modal", "Modal");
        name = name.Replace("loop", "Loop");
        name = name.Replace("document", "Document");
        name = name.Replace("node", "Node");
        name = name.Replace("visitor", "Visitor");
        name = name.Replace("text", "Text");
        name = name.Replace("case", "Case");
        name = name.Replace("next", "Next");
        name = name.Replace("selection", "Selection");
        name = name.Replace("dirtyrect", "dirtyRect");
        name = name.Replace("count", "Count");
        name = name.Replace("name", "Name");
        name = name.Replace("attrmap", "attrMap");
        name = name.Replace("ByqName", "ByQName");
        name = name.Replace("BylName", "ByLName");
        name = name.Replace("index", "Index");
        name = name.Replace("uri", "Uri");
        name = name.Replace("attribute", "Attribute");
        name = name.Replace("control", "Control");
        name = name.Replace("Errorcode", "ErrorCode");
        name = name.Replace("element", "Element");
        name = name.Replace("delete", "Delete");
        name = name.Replace("only", "Only");
        name = name.Replace("enum", "Enum");
        name = name.Replace("key", "Key");
        name = name.Replace("Byident", "ByIdentifier");
        name = name.Replace("model", "Model");
        name = name.Replace("color", "Color");
        name = name.Replace("mode", "Mode");
        name = name.Replace("resize", "Resize");
        name = name.Replace("panning", "Panning");
        name = name.Replace("drop", "Drop");
        name = name.Replace("allowed", "Allowed");
        name = name.Replace("menu", "Menu");
        name = name.Replace("south", "South");
        name = name.Replace("status", "Status");
        name = name.Replace("certificate", "Certificate");
        name = name.Replace("interceptor", "Interceptor");
        name = name.Replace("certPrincipal", "CertPrincipal");
        name = name.Replace("version", "Version");
        name = name.Replace("astwest", "astWest");
        name = name.Replace("oomout", "oomOut");
        name = name.Replace("oomin", "oomIn");
        name = name.Replace("Xdisplay", "XDisplay");
        name = name.Replace("Sslcert", "SslCert");
        name = name.Replace("Sslinfo", "SslInfo");
        name = name.Replace("Jsonand", "JsonAnd");
        name = name.Replace("Jsonand", "JsonAnd");
        name = name.Replace("decode", "Decode");
        name = name.Replace("encode", "Encode");
        name = name.Replace("Highdpi", "HighDpi");
        name = name.Replace("prompt", "Prompt");
        name = name.Replace("Hideread", "HideRead");
        
        name = name.Replace("ConText", "Context");
        name = name.Replace("DisAllowed", "Disallowed");
        name = name.Replace("ubMenu", "ubmenu");
        name = name.Replace("Uring", "uring");
        name = name.Replace("SecUrity", "Security");
        return name;
    }

    private static string CapitalizeFirst(string s) {
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}