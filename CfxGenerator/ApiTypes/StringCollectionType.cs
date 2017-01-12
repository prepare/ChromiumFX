// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class StringCollectionType : CefType {

    public StringCollectionType(string name)
        : base(name) {
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0}_unwrapped", var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("StringFunctions.Wrap{0}({1})", ClassName, var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("PinnedString[] {0}_handles;", var);
        b.AppendLine("var {0}_unwrapped = StringFunctions.Unwrap{1}({0}, out {0}_handles);", var, ClassName);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("StringFunctions.FreePinnedStrings({0}_handles);", var);
        b.AppendLine("StringFunctions.{0}CopyToManaged({1}_unwrapped, {1});", ClassName, var);
        b.AppendLine("CfxApi.Runtime.{0}_free({1}_unwrapped);", CfxName, var);
    }

    public override void EmitNativeValueStructDtorStatements(CodeBuilder b, string var) {
        b.BeginBlock("if(self->{0})", var);
        b.AppendLine("{0}_clear(self->{1});", Name, var);
        b.AppendLine("{0}_free(self->{1});", Name, var);
        b.EndBlock();
    }

    public override void EmitPostRemoteCallStatements(CodeBuilder b, string var) {
        // TODO
        if(ClassName == "CfxStringList")
            b.AppendLine("StringFunctions.Copy{0}(call.{1}, {1});", ClassName, var);
    }

    public override bool IsStringCollectionType {
        get { return true; }
    }

    public override StringCollectionType AsStringCollectionType {
        get {
            return this;
        }
    }
}