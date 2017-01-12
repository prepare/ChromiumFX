// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

[Serializable()]
public class CefConfigData {
    public string CppApiName;
    public string IndexParameter;
    public string[] OptionalParameters;
    public string CountFunction;
    public string DefaultRetval;
    public bool ApiHashCheck;
    public string Source;
    public bool NoDebugctCheck;
}