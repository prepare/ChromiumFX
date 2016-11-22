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