// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;

public class SignatureWithStructArray : Signature {

    private Argument[] m_publicArguments;

    public SignatureWithStructArray(Signature s, int arrayIndex, int countIndex)
        : base(s) {

        var list = new List<Argument>();
        for(var i = 0; i <= Arguments.Length - 1; i++) {
            if(i != arrayIndex && i != countIndex) {
                list.Add(Arguments[i]);
            } else if(i == arrayIndex) {
                var a = new Argument(Arguments[arrayIndex], new CefStructArrayType(Arguments[arrayIndex], Arguments[countIndex]));
                list.Add(a);
                Arguments[i] = a;
            }
        }
        m_publicArguments = list.ToArray();
    }

    public override Argument[] ManagedArguments {
        get { return m_publicArguments; }
    }

    public override void DebugPrintUnhandledArrayArguments(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}