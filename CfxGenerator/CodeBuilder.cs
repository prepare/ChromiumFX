// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

public class CodeBuilder {

    private const string spaces = "                                                                                                                        ";

    protected StringBuilder builder = new StringBuilder();

    private List<string> currentLine = new List<string>();

    public int CurrentIndent;

    public CodeBuilder() {
    }

    public CodeBuilder(int indent) {
        CurrentIndent = indent;
    }

    private void EmitDebugInfo() {
        if(Program.EmitDebugInfo > 0) {
            var i = 2;
            var caller = new StackFrame(2, false);
            var method = caller.GetMethod();
            while(method.DeclaringType.Name == "CodeBuilder" || method.DeclaringType.Name == "ClassBuilder") {
                i += 1;
                caller = new StackFrame(i, false);
                method = caller.GetMethod();
            }
            AppendComment(" {0}.{1}", method.DeclaringType.Name, method.Name);
        }
    }

    private void CommitCurrentLine() {
        if(currentLine.Count > 0) {
            if(CurrentIndent > 0)
                builder.Append(spaces.Substring(0, CurrentIndent * 4));
            foreach(var s in currentLine) {
                builder.Append(s);
            }
            currentLine.Clear();
        }
    }

    public void IncreaseIndent() {
        CurrentIndent += 1;
    }

    public void DecreaseIndent() {
        CurrentIndent -= 1;
    }

    public void BeginBlock(string header, params object[] pm) {
        Append(header, pm);
        Append(" ");
        BeginBlock();
    }

    public void BeginBlock(string header) {
        Append(header);
        Append(" ");
        BeginBlock();
    }

    public void BeginBlock() {
        AppendLine("{");
        IncreaseIndent();
    }

    public void EndBlock() {
        DecreaseIndent();
        AppendLine("}");
    }

    public void EndBlock(string suffix) {
        DecreaseIndent();
        Append("} ");
        AppendLine(suffix);
    }

    public void EndBlock(string suffix, params object[] pm) {
        DecreaseIndent();
        Append("} ");
        AppendLine(suffix, pm);
    }

    public void Append(string line) {
        currentLine.Add(line);
    }

    public void AppendLine() {
        CommitCurrentLine();
        EmitDebugInfo();
        builder.Append("\r\n");
    }

    public void AppendLine(string line) {
        Append(line);
        AppendLine();
    }

    public void Append(string format, params object[] pm) {
        Append(string.Format(format, pm));
    }

    public void AppendLine(string format, params object[] pm) {
        Append(format, pm);
        AppendLine();
    }

    public void AppendMultiline(string code) {
        var lines = Regex.Split(code, "[\r\n]+");
        foreach(var line in lines) {
            AppendLine(line);
        }
    }

    public void AppendMultiline(string format, params object[] pm) {
        var code = string.Format(format, pm);
        var lines = Regex.Split(code, "[\r\n]+");
        foreach(var line in lines) {
            AppendLine(line);
        }
    }

    public void AppendComment(string line) {
        Append("// ");
        AppendLine(line);
    }

    public void BeginCfxNamespace() {
        BeginCfxNamespace(new string[] { "System" });
    }

    public void BeginCfxNamespace(string subspace) {
        BeginCfxNamespace(new string[] { "System" }, subspace);
    }

    public void BeginCfxNamespace(string[] usingStmts, string subspace = "") {
        foreach(var stmt in usingStmts) {
            AppendLine("using {0};", stmt);
        }
        AppendLine();
        BeginBlock("namespace Chromium" + subspace);
    }

    public void BeginClass(string name, string modifiers = "public") {
        BeginBlock("{0} class {1}", modifiers, name);
    }

    public void BeginRemoteCallClass(string name, List<string> callIds, string baseClass = "RemoteCall") {
            BeginBlock("internal class {0}{1} : {1}", name, baseClass);
            callIds.Add(name + baseClass);
            AppendLine();
            AppendLine("internal {0}{1}()", name, baseClass);
            IncreaseIndent();
            AppendLine(": base(RemoteCallId.{0}{1}) {{}}", name, baseClass);
            DecreaseIndent();
    }

    public void BeginFunction(string functionSignature, string modifiers = "public") {
        BeginBlock("{0} {1}", modifiers, functionSignature);
    }

    public void BeginFunction(string name, string returnType, string parameters, string modifiers = "public") {
        BeginBlock("{0} {1} {2}({3})", modifiers, returnType, name, parameters);
    }

    public void BeginIf(string condition) {
        BeginBlock("if({0})", condition);
    }

    public void BeginIf(string condition, params object[] pm) {
        BeginBlock("if({0})", string.Format(condition, pm));
    }

    public void BeginFor(string limit) {
        BeginBlock("for(int i = 0; i < {0}; ++i)", limit);
    }

    public void BeginFor(string limit, params object[] pm) {
        BeginFor(string.Format(limit, pm));
    }

    public void BeginElse() {
        EndBlock("else {");
        IncreaseIndent();
    }

    public void BeginElseIf(string condition, params object[] pm) {
        EndBlock("else if({0}) {{", string.Format(condition, pm));
        IncreaseIndent();
    }

    public void BeginCatch() {
        EndBlock("catch {");
        IncreaseIndent();
    }

    public void BeginCatch(string catchArgument) {
        EndBlock(string.Format("catch({0}) {{", catchArgument));
        IncreaseIndent();
    }

    public void AppendComment(string format, params object[] pm) {
        AppendComment(string.Format(format, pm));
    }

    public void AppendSummary(CommentNode summary, bool forRemote = false, bool forEvent = false) {
        if(summary != null && !(summary.Lines.Length == 0)) {
            AppendLine("/// <summary>");
            foreach(var line in summary.Lines) {
                var l1 = CSharp.PrepareSummaryLine(line, forRemote, forEvent);
                AppendLine("/// " + l1);
            }
            AppendLine("/// </summary>");
        }
    }

    public void AppendSummaryAndRemarks(CommentNode summary, bool forRemote = false, bool forEvent = false) {
        if(summary != null && !(summary.Lines.Length == 0)) {
            AppendSummary(summary, forRemote, forEvent);
            AppendLine("/// <remarks>");
            AppendLine("/// See also the original CEF documentation in");
            AppendLine("/// <see href=\"https://bitbucket.org/chromiumfx/chromiumfx/src/tip/{0}\">{0}</see>.", summary.FileName.Replace("\\", "/"));
            AppendLine("/// </remarks>");
        }
    }

    public void AppendBuilder(CodeBuilder b) {
        CommitCurrentLine();
        builder.Append(b.ToString());
    }

    public void CutRight(int charCount) {
        CommitCurrentLine();
        builder.Remove(builder.Length - charCount, charCount);
    }

    public void TrimRight() {
        CommitCurrentLine();
        var i = builder.Length - 1;
        while(i >= 0 && char.IsWhiteSpace(builder[i])) {
            i -= 1;
        }
        if(i < builder.Length - 1) {
            builder.Remove(i + 1, builder.Length - i - 1);
        }
    }

    public bool IsNotEmpty {
        get { return currentLine.Count > 0 || builder.Length > 0; }
    }

    public void Clear() {
        builder.Clear();
    }

    public override string ToString() {
        CommitCurrentLine();
        return builder.ToString();
    }
}