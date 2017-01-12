// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

public class CefStringUserFreeType : BlittableType {

    public CefStringUserFreeType()
        : base("cef_string_userfree_t", "IntPtr") {
    }

    public override string PublicSymbol {
        get { return "string"; }
    }

    public override string PublicWrapExpression(string var) {
        return string.Format("StringFunctions.ConvertStringUserfree({0})", var);
    }

    public override string PublicUnwrapExpression(string var) {
        throw new Exception();
    }
}