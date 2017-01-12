// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Parser {

    [Serializable()]
    public class EnumData {
        public string Name;
        public readonly List<EnumMemberData> Members = new List<EnumMemberData>();
        public CommentData Comments;
    }
}