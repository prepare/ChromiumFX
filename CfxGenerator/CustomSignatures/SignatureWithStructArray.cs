// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;

public class SignatureWithStructArray : Signature {

    private Parameter[] m_publicParameters;

    public SignatureWithStructArray(Signature s, int arrayIndex, int countIndex)
        : base(s) {

        var list = new List<Parameter>();
        for(var i = 0; i <= Parameters.Length - 1; i++) {
            if(i != arrayIndex && i != countIndex) {
                list.Add(Parameters[i]);
            } else if(i == arrayIndex) {
                var a = new Parameter(Parameters[arrayIndex], new CefStructArrayType(Parameters[arrayIndex], Parameters[countIndex]));
                list.Add(a);
                Parameters[i] = a;
            }
        }
        m_publicParameters = list.ToArray();
    }

    public override Parameter[] ManagedParameters {
        get { return m_publicParameters; }
    }

    public override void DebugPrintUnhandledArrayArguments(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}