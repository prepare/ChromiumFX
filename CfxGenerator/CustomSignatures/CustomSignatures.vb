'' Copyright (c) 2014-2015 Wolfgang Borgsmüller
'' All rights reserved.
'' 
'' Redistribution and use in source and binary forms, with or without 
'' modification, are permitted provided that the following conditions 
'' are met:
'' 
'' 1. Redistributions of source code must retain the above copyright 
''    notice, this list of conditions and the following disclaimer.
'' 
'' 2. Redistributions in binary form must reproduce the above copyright 
''    notice, this list of conditions and the following disclaimer in the 
''    documentation and/or other materials provided with the distribution.
'' 
'' 3. Neither the name of the copyright holder nor the names of its 
''    contributors may be used to endorse or promote products derived 
''    from this software without specific prior written permission.
'' 
'' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
'' "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
'' LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
'' FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
'' COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
'' INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
'' BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
'' OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
'' ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
'' TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
'' USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.



Public Class CustomSignatures

    Public Shared Function ForFunction(parent As ISignatureParent, sd As Parser.SignatureData, api As ApiTypeBuilder) As Signature
        Select Case parent.CefName
            Case "cef_browser::get_frame_identifiers"
                Return New GetFrameIdentifiersSignature(parent, sd, api)
            Case "cef_v8value::execute_function_with_context"
                Return New SignatureWithStructPtrArray(parent, sd, api, 4, 3)
            Case "cef_v8value::execute_function"
                Return New SignatureWithStructPtrArray(parent, sd, api, 3, 2)
            Case "cef_render_handler::on_paint"
                Return New OnPaintSignature(parent, sd, api)
            Case "cef_post_data::get_elements"
                Return New GetPostDataElementsSignature(parent, sd, api)
            Case "cef_v8handler::execute"
                Return New CefV8HandlerExecuteSignature(parent, sd, api)
            Case Else
                Return Nothing
        End Select

    End Function
End Class
