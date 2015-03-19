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



Public Class BlittableType
    Inherits ApiType

    Public ReadOnly PInvokeType As String

    Sub New(name As String, pInvokeType As String)
        MyBase.New(name)
        Me.PInvokeType = pInvokeType
    End Sub


    Public Overrides ReadOnly Property NativeSymbol As String
        Get
            Select Case Name
                Case "bool", "BOOL"
                    Return "int"
                Case "time_t"
                    Return "int64"
                Case Else
                    Return MyBase.NativeSymbol
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return PInvokeType
        End Get
    End Property

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Select Case Name
                Case "bool", "BOOL"
                    Return "bool"
                Case "void"
                    Return String.Empty
                Case "char*"
                    Return "string"
                Case Else
                    Return MyBase.PublicSymbol
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property NativeWrapExpression(var As String) As String
        Get
            Select Case Name
                Case "bool", "BOOL"
                    Return String.Format("({0}) ? 1 : 0", var)
                Case "time_t"
                    Return String.Format("(int64)({0})", var)
                Case Else
                    Return var
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property NativeUnwrapExpression(var As String) As String
        Get
            Select Case Name
                Case "bool"
                    Return String.Format("({0}) ? true : false", var)
                Case "BOOL"
                    Return String.Format("(BOOL)({0})", var)
                Case "time_t"
                    Return String.Format("(time_t)({0})", var)
                Case Else
                    Return var
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            If PInvokeSymbol Is Nothing Then Return Nothing
            Select Case Name
                Case "bool", "BOOL"
                    Return String.Format("{0} ? 1 : 0", var)
                Case Else
                    Return MyBase.PublicUnwrapExpression(var)
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property PublicWrapExpression(var As String) As String
        Get
            Select Case Name
                Case "bool", "BOOL"
                    Return String.Format("0 != {0}", var)
                Case "char*"
                    Return String.Format("System.Runtime.InteropServices.Marshal.PtrToStringAnsi({0})", var)
                Case Else
                    Return MyBase.PublicWrapExpression(var)
            End Select
        End Get
    End Property

    Public Overrides ReadOnly Property IsBlittableType As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property AsBlittableType As BlittableType
        Get
            Return Me
        End Get
    End Property

End Class
