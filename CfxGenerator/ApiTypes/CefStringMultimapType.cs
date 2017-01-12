// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStringMultimapType : StringCollectionType {

    public CefStringMultimapType()
        : base("cef_string_multimap") {
    }

    public override string PublicSymbol {
        get { return "System.Collections.Generic.List<string[]>"; }
    }
}