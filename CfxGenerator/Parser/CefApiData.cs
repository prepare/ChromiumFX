// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class CefApiData {

        public string ApiHashUniversal;

        public List<StructData> CefStructs;
        public List<FunctionData> CefFunctions;
        public List<EnumData> CefEnums;

        public FunctionData[] CefStringCollectionFunctions;
        public List<StructData> CefStructsWindows;

        public List<FunctionData> CefFunctionsWindows;
        public List<StructData> CefStructsLinux;

        public List<FunctionData> CefFunctionsLinux;
    }
}