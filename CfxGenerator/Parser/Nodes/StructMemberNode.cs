// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

namespace Parser {

    [Serializable()]
    public class StructMemberNode {
        public string Name;
        public CefConfigNode CefConfig;
        public TypeNode MemberType = new TypeNode();
        public SignatureNode CallbackSignature;
        public CommentNode Comments = new CommentNode();

        public override string ToString() {
            return Name;
        }
    }
}