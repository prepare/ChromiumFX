// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class SizeType : NumericType {

    public SizeType()
        : base("size_t", "UIntPtr") {
    }

    public override string PublicSymbol {
        get {
            return "ulong";
        }
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("(ulong){0}", CSharp.Escape(var));
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("(UIntPtr){0}", CSharp.Escape(var));
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("(UIntPtr){0}", CSharp.Escape(var));
    }

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("return (ulong)call.{0};", CSharp.Escape(var));
    }

}
