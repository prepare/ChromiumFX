// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefColorRefType : ApiType {

    public CefColorRefType()
        : base("cef_color_t*") {
    }

    public override string NativeSymbol {
        get { return "uint32*"; }
    }

    public override string PInvokeSymbol {
        get { return "ref uint"; }
    }

    public override string PublicSymbol {
        get { return "CfxColor"; }
    }

    public override string PublicCallParameter(string var) {
        return string.Concat("ref ", PublicSymbol, " ", var);
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("ref {0}.color", var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return string.Concat("ref ", var);
    }
}