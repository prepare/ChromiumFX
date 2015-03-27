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



Public Class CefPlatformStructType
    Inherits CefStructType

    Public ReadOnly Platform As CefPlatform
    Private ReadOnly baseTypeName As String

    Sub New(name As String, comments As CommentData, platform As CefPlatform)
        MyBase.New(name & "_" & platform.ToString().ToLowerInvariant(), comments)
        Me.Platform = platform
        baseTypeName = name
    End Sub

    Public ReadOnly Property BaseClassName As String
        Get
            Return "Cfx" & CSharp.ApplyStyle(baseTypeName.Substring(4)) & "Base"
        End Get
    End Property


    Public Overrides ReadOnly Property OriginalSymbol As String
        Get
            Return baseTypeName & "_t"
        End Get
    End Property

    Public Overrides ReadOnly Property ClassName As String
        Get
            If Platform = CefPlatform.Windows Then
                Return "Cfx" & CSharp.ApplyStyle(baseTypeName.Substring(4))
            End If
            Return MyBase.ClassName
        End Get
    End Property

    Public Overrides ReadOnly Property ParserMatches As String()
        Get
            Return {Name}
        End Get
    End Property

    Public Overrides ReadOnly Property IsCefPlatformStructType As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property AsCefPlatformStructType As CefPlatformStructType
        Get
            Return Me
        End Get
    End Property
End Class
