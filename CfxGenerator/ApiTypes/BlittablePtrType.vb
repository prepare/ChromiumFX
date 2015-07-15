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



Public Class BlittablePtrType
    Inherits ApiType

    Public ReadOnly BlittableType As BlittableType
    Public ReadOnly Indirection As String

    Public Sub New(baseType As BlittableType, indirection As String)
        MyBase.New(AddIndirection(baseType.Name, indirection))
        Me.Indirection = indirection
        Me.BlittableType = baseType
    End Sub


    Public Overrides ReadOnly Property OriginalSymbol As String
        Get
            Return AddIndirection(BlittableType.OriginalSymbol, Indirection)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return "IntPtr"
        End Get
    End Property

    Private _matches As String()
    Public Overrides ReadOnly Property ParserMatches As String()
        Get
            If _matches Is Nothing Then
                _matches = New String(BlittableType.ParserMatches.Length - 1) {}
                For i = 0 To _matches.Length - 1
                    _matches(i) = BlittableType.ParserMatches(i) & Indirection
                Next
            End If
            Return _matches
        End Get
    End Property

End Class
