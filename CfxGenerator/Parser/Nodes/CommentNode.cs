// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

[Serializable()]
public class CommentNode {
    internal void SetParserLines(List<string> lines) {
        var ll = new List<string>();
        foreach(var l in lines) {
            var line = l.Trim();
            line = line.Replace("<", "&lt;");
            if(!string.IsNullOrWhiteSpace(line)) {
                if(!line.Equals("The resulting string must be freed by calling cef_string_userfree_free().")) {
                    ll.Add(line);
                }
            }
        }
        Lines = ll.ToArray();
    }
    public string FileName;
    public string[] Lines = new string[0];
}