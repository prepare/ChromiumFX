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


Public Class CefPlatformBasePtrType
    Inherits SpecialType

    Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return "Cfx" & CSharp.ApplyStyle(Name.Substring(4, Name.Length - 7)) & "Base"
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            Return String.Format("{0}.Unwrap({1})", PublicSymbol, var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicWrapExpression(var As String) As String
        Get
            Return String.Format("{0}.Cast({1})", PublicSymbol, var)
        End Get
    End Property

    Public Overrides Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
        If Name = "cef_main_args_t*" Then
            b.AppendLine("#if defined CFX_WINDOWS")
            b.AppendLine("cef_main_args_t args_tmp = { GetModuleHandle(0) };")
            b.AppendLine("args = &args_tmp;")
            b.AppendLine("#endif")
        End If
    End Sub

End Class
