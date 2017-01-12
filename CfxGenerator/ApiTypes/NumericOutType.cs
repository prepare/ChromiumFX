// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class NumericOutType : ApiType {
    public readonly NumericType BaseType;

    public NumericOutType(NumericType baseType)
        : base(AddIndirection(baseType.Name, "*")) {
        this.BaseType = baseType;
    }

    public override string PInvokeSymbol {
        get { return BaseType.PInvokeSymbol; }
    }

    public override string PInvokeCallParameter(string var) {
        return "out " + BaseType.PInvokeCallParameter(var);
    }

    public override string PublicCallParameter(string var) {
        return "out " + BaseType.PublicCallParameter(var);
    }

    public override string PublicUnwrapExpression(string var) {
        return "out " + var;
    }

    public override void EmitPublicEventArgSetterStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0} = value;", var);
    }

    public override bool IsOut {
        get { return true; }
    }

    public override bool IsIn {
        get { return false; }
    }
}