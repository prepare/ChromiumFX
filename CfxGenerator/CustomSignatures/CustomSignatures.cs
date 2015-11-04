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

    public static Signature ForFunction(SignatureType type, ISignatureOwner owner, Parser.SignatureData sd, ApiTypeBuilder api) {
        if(owner.CefName.Contains("::get_") && sd.Arguments.Count == 2) {
            if(sd.ReturnType.Name == "void" && string.IsNullOrEmpty(sd.ReturnType.Indirection)) {
                if(sd.Arguments[1].ArgumentType.Name.StartsWith("cef_string_list") || sd.Arguments[1].ArgumentType.Name.StartsWith("cef_string_m")) {
                    return new StringCollectionAsRetvalSignature(owner, sd, api);
                }
            }
        }

        if(owner.CefConfig.CountFunction != null && sd.Arguments.Count == 3 && sd.ReturnType.Name == "void") {

            Debug.Print(owner.CefName);
        }

        switch(owner.CefName) {
            case "cef_browser::get_frame_identifiers":
                return new GetFrameIdentifiersSignature(owner, sd, api);

            case "cef_v8value::execute_function_with_context":
                return new SignatureWithStructPtrArray(SignatureType.LibraryCall, owner, sd, api, 4, 3);

            case "cef_v8value::execute_function":
                return new SignatureWithStructPtrArray(SignatureType.LibraryCall, owner, sd, api, 3, 2);

            case "cef_render_handler::on_paint":
                return new SignatureWithStructArray(SignatureType.ClientCallback, owner, sd, api, 4, 3);

            case "cef_post_data::get_elements":
                return new GetPostDataElementsSignature(owner, sd, api);

            case "cef_v8handler::execute":
                return new CefV8HandlerExecuteSignature(owner, sd, api);

            case "cef_print_settings::set_page_ranges":
                return new SignatureWithStructArray(SignatureType.LibraryCall, owner, sd, api, 2, 1);

            case "cef_print_settings::get_page_ranges":
                return new GetPageRangesSignature(owner, sd, api, 2, 1);

            case "cef_drag_handler::on_draggable_regions_changed":
                return new SignatureWithStructArray(SignatureType.ClientCallback, owner, sd, api, 3, 2);

            default:
                return null;
        }
    }
}