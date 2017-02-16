// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class SignatureNode {
        public readonly List<ParameterNode> Arguments = new List<ParameterNode>();
        public TypeNode ReturnType = new TypeNode();
        public bool ReturnValueIsConst;
    }
}