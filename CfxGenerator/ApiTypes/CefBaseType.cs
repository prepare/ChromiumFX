// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefBaseRefCountedType : SpecialType {

    public CefBaseRefCountedType()
        : base("cef_base_ref_counted_t") {
    }
}

public class CefBaseScopedType : SpecialType {

    public CefBaseScopedType()
        : base("cef_base_scoped_t") {
    }
}
