// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class StringCollectionAsRetvalSignature : Signature {

    public StringCollectionAsRetvalSignature(Signature s)
        : base(s) {
    }

    public override Argument[] ManagedArguments {
        get { return new Argument[] { base.ManagedArguments[0] }; }
    }

    public override ApiType PublicReturnType {
        get { return base.ManagedArguments[1].ArgumentType; }
    }

    public override void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine("{0} {1} = new {0}();", base.ManagedArguments[1].ArgumentType.PublicSymbol, base.ManagedArguments[1].VarName);
        base.ManagedArguments[1].EmitPrePublicCallStatements(b);
        b.AppendLine(string.Format("CfxApi.{2}.{0}(NativePtr, {1});", apiFunctionName, base.ManagedArguments[1].PublicCallArgument, apiClassName));
        base.ManagedArguments[1].EmitPostPublicStatements(b);
        b.AppendLine("return {0};", base.ManagedArguments[1].VarName);
    }

    protected override void EmitExecuteInTargetProcess(CodeBuilder b, string apiClassName, string apiFunctionName) {
        var collectionType = base.ManagedArguments[1].ArgumentType.AsStringCollectionType.ClassName;
        b.AppendLine("__retval = new {0}();", base.ManagedArguments[1].ArgumentType.PublicSymbol);
        b.AppendLine("var list = StringFunctions.Alloc{0}();", collectionType);
        b.AppendLine("CfxApi.{0}.{1}(@this, list);", apiClassName, apiFunctionName);
        b.AppendLine("StringFunctions.{0}CopyToManaged(list, __retval);", collectionType);
        b.AppendLine("StringFunctions.Free{0}(list);", collectionType);
    }

}