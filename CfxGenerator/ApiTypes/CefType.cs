// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public abstract class CefType : ApiType {

    public CefType(string name)
        : base(name) {
    }

    public override string OriginalSymbol {
        get { return Name + "_t"; }
    }

    public string CfxName {
        get { return "cfx_" + Name.Substring(4); }
    }

    public virtual string ClassName {
        get { return CSharp.ApplyStyle(CfxName); }
    }
}