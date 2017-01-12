// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefColorType : ApiType {

    public CefColorType()
        : base("cef_color_t") {
    }

    public override string NativeSymbol {
        get { return "uint32"; }
    }

    public override string PInvokeSymbol {
        get { return "uint"; }
    }

    public override string PublicSymbol {
        get { return "CfxColor"; }
    }

    public override string PublicUnwrapExpression(string var) {
        return string.Format("CfxColor.Unwrap({0})", var);
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("CfxColor.Wrap({0})", var);
    }
}