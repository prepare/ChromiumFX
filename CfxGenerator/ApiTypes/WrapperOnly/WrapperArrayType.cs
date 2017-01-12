// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class WrapperArrayType : ApiType {
    public readonly string ArrayType;

    public WrapperArrayType(string arrayType)
        : base("__wrapperArray[]") {
        this.ArrayType = arrayType;
    }

    public override string PublicSymbol {
        get { return ArrayType + "[]"; }
    }
}