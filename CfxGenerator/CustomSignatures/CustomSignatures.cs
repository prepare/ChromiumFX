// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


using System.Diagnostics;

public class CustomSignatures {

    public static Signature ForFunction(Signature s, string cefName, CefConfigData cefConfig) {
        if(cefName.Contains("::get_") && s.Arguments.Length == 2) {
            if(s.ReturnType.IsVoid) {
                if(s.Arguments[1].ArgumentType.Name.StartsWith("cef_string_list") || s.Arguments[1].ArgumentType.Name.StartsWith("cef_string_m")) {
                    return new StringCollectionAsRetvalSignature(s);
                }
            }
        }

        if(cefConfig.CountFunction != null && s.Arguments.Length == 3 && s.ReturnType.IsVoid) {
            if(s.Arguments[2].ArgumentType.IsCefStructPtrPtrType) {
                return new StructArrayGetterSignature(s, cefConfig.CountFunction);
            }
        }

        switch(cefName) {
            case "cef_browser::get_frame_identifiers":
                return new GetFrameIdentifiersSignature(s);

            case "cef_v8value::execute_function_with_context":
                return new SignatureWithStructPtrArray(s, 4, 3);

            case "cef_v8value::execute_function":
                return new SignatureWithStructPtrArray(s, 3, 2);

            case "cef_request_handler::on_select_client_certificate":
                return new SignatureWithStructPtrArray(s, 6, 5);

            case "cef_v8handler::execute":
                return new CefV8HandlerExecuteSignature(s);

            case "cef_print_settings::get_page_ranges":
                return new GetPageRangesSignature(s, 2, 1);

        }

        for(var i = 0; i <= s.Arguments.Length - 1; i++) {

            var suffixLength = 0;
            if(s.Arguments[i].VarName.EndsWith("_count")) suffixLength = 6;
            if(s.Arguments[i].VarName.EndsWith("Count")) suffixLength = 5;

            if(suffixLength > 0) {
                var arrName = s.Arguments[i].VarName.Substring(0, s.Arguments[i].VarName.Length - suffixLength);
                int arrayArgIndex = -1;
                if(i > 0 && s.Arguments[i - 1].VarName.StartsWith(arrName)) {
                    arrayArgIndex = i - 1;
                } else if(i < s.Arguments.Length - 1 && s.Arguments[i + 1].VarName.StartsWith(arrName)) {
                    arrayArgIndex = i + 1;
                } else {
                }
                if(arrayArgIndex > 0) {
                    var arrayType = s.Arguments[arrayArgIndex].ArgumentType;
                    if(arrayType.IsCefStructPtrType) {
                        Debug.Assert(arrayType.AsCefStructPtrType.Struct.ClassBuilder.Category == StructCategory.Values);
                        return new SignatureWithStructArray(s, arrayArgIndex, i);
                    }
                }
            }
        }

        return null;
    }
}