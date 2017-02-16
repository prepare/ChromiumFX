// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

namespace Parser {

    [Serializable()]
    public class FunctionNode {
        public string Name;
        public SignatureNode Signature = new SignatureNode();
        public CommentNode Comments = new CommentNode();
        public override string ToString() {
            return Name;
        }
    }
}