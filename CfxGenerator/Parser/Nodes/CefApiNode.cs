// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class CefApiNode {

        public string ApiHashUniversal;

        public List<CallbackStructNode> CefCallbackStructs = new List<CallbackStructNode>();
        public List<ValueStructNode> CefValueStructs = new List<ValueStructNode>();

        public List<FunctionNode> CefFunctions = new List<FunctionNode>();
        public List<EnumNode> CefEnums = new List<EnumNode>();

        public FunctionNode[] CefStringCollectionFunctions;

        public List<ValueStructNode> CefStructsWindows;
        public List<FunctionNode> CefFunctionsWindows;

        public List<ValueStructNode> CefStructsLinux;
        public List<FunctionNode> CefFunctionsLinux;

        public List<CefClassNode> CefClasses = new List<CefClassNode>();
        public List<CefCppFunctionNode> CefCppFunctions = new List<CefCppFunctionNode>();
        
    }
}