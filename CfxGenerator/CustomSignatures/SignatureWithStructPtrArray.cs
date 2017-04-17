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
        Parameters[arrayIndex] = new Parameter(Parameters[arrayIndex], new CefStructPtrArrayType(Parameters[arrayIndex], Parameters[countIndex]));
    }

    public override Parameter[] ManagedParameters {
        get {
            var list = new List<Parameter>();
            for(var i = 0; i <= Parameters.Length - 1; i++) {
                if(i != countIndex) {
                    list.Add(Parameters[i]);
                }
            }
            return list.ToArray();
        }
    }

    public override void DebugPrintUnhandledArrayParameters(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}