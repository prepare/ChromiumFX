// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class StructData {
        public string Name;
        public readonly List<FunctionData> CefFunctions = new List<FunctionData>();
        public readonly List<StructMemberData> StructMembers = new List<StructMemberData>();
        public CommentData Comments = new CommentData();
        public CefConfigData CefConfig;

        public override string ToString() {
            return Name;
        }
    }
}