// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;

public class SignatureWithStructPtrArray : Signature {

    int arrayIndex;
    int countIndex;

    public SignatureWithStructPtrArray(Signature s, int arrayIndex, int countIndex)
        : base(s) {
        this.arrayIndex = arrayIndex;
        this.countIndex = countIndex;
        Arguments[arrayIndex] = new Argument(Arguments[arrayIndex], new CefStructPtrArrayType(Arguments[arrayIndex], Arguments[countIndex]));
    }

    public override Argument[] ManagedArguments {
        get {
            var list = new List<Argument>();
            for(var i = 0; i <= Arguments.Length - 1; i++) {
                if(i != countIndex) {
                    list.Add(Arguments[i]);
                }
            }
            return list.ToArray();
        }
    }

    public override void DebugPrintUnhandledArrayArguments(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}