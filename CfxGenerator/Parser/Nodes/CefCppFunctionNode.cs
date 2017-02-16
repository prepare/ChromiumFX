// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    public class CefCppFunctionNode {
        public string Name;
        public bool IsStatic;
        public CefConfigNode CefConfig = new CefConfigNode();
        public bool IsRetvalBoolean;
        public List<string> BooleanParameters = new List<string>();
        public override string ToString() {
            return Name;
        }
    }
}
