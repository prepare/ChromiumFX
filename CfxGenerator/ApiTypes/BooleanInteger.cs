// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

public class BooleanInteger : NumericType {

    public static ApiType Convert(ApiType boolInt) {
        switch(boolInt.Name) {
            case "int":
                return Instance;

            case "int*":
                return OutInstance;

            default:
                throw new Exception();
        }
    }

    private static BooleanInteger Instance = new BooleanInteger();

    private static BooleanIntegerOutType OutInstance = new BooleanIntegerOutType();

    public BooleanInteger()
        : base("int", "int") {
    }

    public override string PublicSymbol {
        get { return "bool"; }
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("0 != {0}", CSharp.Escape(var));
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("{0} ? 1 : 0", CSharp.Escape(var));
    }

    public override string RemoteUnwrapExpression(string var) {
        return string.Format("{0} ? 1 : 0", CSharp.Escape(var));
    }

    public override string[] ParserMatches {
        get { return new string[] { "bool" }; }
    }

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.AppendLine("return 0 != call.{0};", CSharp.Escape(var));
    }
}

public class BooleanIntegerOutType : NumericOutType {

    public BooleanIntegerOutType()
        : base(new BooleanInteger()) {
    }

    public override string PublicSymbol {
        get { return "bool"; }
    }

    public override string PublicCallParameter(string var) {
        return "out bool " + var;
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("out {0}_unwrapped", var);
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0} = value ? 1 : 0;", var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("int {0}_unwrapped;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = {0}_unwrapped != 0;", var);
    }

    public override string[] ParserMatches {
        get { return new string[] { "bool*" }; }
    }
}