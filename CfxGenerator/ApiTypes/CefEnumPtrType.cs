// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;

public class CefEnumPtrType : CefType {
    private CefEnumType cefEnum;

    public CefEnumPtrType(CefEnumType cefEnum)
        : base(cefEnum.Name + "*") {
        this.cefEnum = cefEnum;
    }

    public override string OriginalSymbol {
        get { return cefEnum.OriginalSymbol + "*"; }
    }

    public override string PInvokeSymbol {
        get {
            return cefEnum.PInvokeSymbol;
        }
    }

    public override string PublicSymbol {
        get { return cefEnum.PublicSymbol; }
    }

    public override string PInvokeCallParameter(string var) {
        return "out " + cefEnum.PInvokeCallParameter(var);
    }

    public override string PInvokeCallbackParameter(string var) {
        return "ref " + cefEnum.PInvokeCallParameter(var);
    }

    public override string PublicCallParameter(string var) {
        return "out " + cefEnum.PublicCallParameter(var);
    }

    public override string PublicCallArgument(string var) {
        return string.Format("out {0}_tmp", var);
    }

    public override string PublicWrapExpression(string var) {
        return cefEnum.PublicWrapExpression(var);
    }

    public override string PublicUnwrapExpression(string var) {
        return cefEnum.PublicUnwrapExpression(var);
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("int {0}_tmp;", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = ({1}){0}_tmp;", var, cefEnum.PublicSymbol);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("{0} = e.m_{0};", var);
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        b.AppendLine("/* implement this */;");
        Debug.Print("implement this");
        Debugger.Break();
    }

    public override bool IsOut {
        get {
            return true;
        }
    }

}
