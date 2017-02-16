// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

namespace Parser {

    [Serializable()]
    public class StructMemberData {
        public string Name;
        public CefConfigData CefConfig;
        public TypeData MemberType = new TypeData();
        public SignatureData CallbackSignature;
        public CommentData Comments = new CommentData();

        public override string ToString() {
            return Name;
        }
    }
}