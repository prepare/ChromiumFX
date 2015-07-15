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



Public Class GetFrameIdentifiersSignature
    Inherits Signature

    Public Sub New(parent As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder)
        MyBase.New(parent, sd, api)
    End Sub

    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return {Arguments(0)}
        End Get
    End Property

    Public Overrides ReadOnly Property PublicReturnType As ApiType
        Get
            Return New WrapperArrayType("long")
        End Get
    End Property

    Public Overrides Function NativeSignature(functionName As String) As String
        Return "static void cfx_browser_get_frame_identifiers(cef_browser_t* self, int identifiersCount, int64* identifiers)"
    End Function

    Public Overrides Function PInvokeSignature(functionName As String) As String
        Return "void cfx_browser_get_frame_identifiers_delegate(IntPtr self, int identifiersCount, IntPtr identifiers)"
    End Function

    Public Overrides Function PublicSignature(functionName As String) As String
        Return "long[] GetFrameIdentifiers()"
    End Function

    Public Overrides Sub EmitNativeCall(b As CodeBuilder, functionName As String)
        b.AppendLine("size_t tmp_identifiersCount = (size_t)identifiersCount;")
        b.AppendLine("self->get_frame_identifiers(self, &tmp_identifiersCount, identifiers);")
    End Sub

    Public Overrides Sub EmitPublicCall(b As CodeBuilder)
        b.AppendLine("int identifiersCount = FrameCount;")
        b.AppendLine("if(identifiersCount == 0) return new long[0];")
        b.AppendLine("long[] retval = new long[identifiersCount];")
        b.AppendLine("var retval_p = new PinnedObject(retval);")
        b.AppendLine("CfxApi.cfx_browser_get_frame_identifiers(NativePtr, identifiersCount, retval_p.PinnedPtr);")
        b.AppendLine("retval_p.Free();")
        b.AppendLine("return retval;")
    End Sub


    Public Overrides Sub DebugPrintUnhandledArrayArguments()
    End Sub

End Class
