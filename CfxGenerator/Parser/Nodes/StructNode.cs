// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class StructNode {
        public string Name;
        public string CefBaseType;
        public readonly List<FunctionNode> CefFunctions = new List<FunctionNode>();
        public readonly List<StructMemberNode> StructMembers = new List<StructMemberNode>();
        public CommentNode Comments = new CommentNode();
        public CefConfigNode CefConfig;

        public override string ToString() {
            return Name;
        }
    }
}