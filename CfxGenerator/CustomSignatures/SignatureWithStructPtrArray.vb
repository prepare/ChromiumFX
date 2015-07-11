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



Public Class SignatureWithStructPtrArray
    Inherits Signature

    Private arrayIndex As Integer
    Private countIndex As Integer

    Private m_publicArguments As Argument()

    Public Sub New(owner As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder, arrayIndex As Integer, countIndex As Integer)
        MyBase.New(owner, sd, api)
        Me.arrayIndex = arrayIndex
        Me.countIndex = countIndex

        Dim list = New List(Of Argument)
        For i = 0 To Arguments.Length - 1
            If i <> arrayIndex AndAlso i <> countIndex Then
                list.Add(Arguments(i))
            ElseIf i = arrayIndex Then
                Dim a = New Argument(Arguments(arrayIndex), New CefStructPtrArrayType(Arguments(arrayIndex), Arguments(countIndex)))
                list.Add(a)
                Arguments(i) = a
            End If
        Next
        m_publicArguments = list.ToArray()
    End Sub

    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return m_publicArguments
        End Get
    End Property


    Public Overrides Sub DebugPrintUnhandledArrayArguments()
    End Sub

End Class
