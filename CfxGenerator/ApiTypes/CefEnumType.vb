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



Public Class CefEnumType
    Inherits ApiType

    Public Class EnumMember
        Public ReadOnly Name As String
        Public ReadOnly Value As String
        Public ReadOnly Comments As CommentData

        Sub New(ByVal name As String, ByVal value As String, Comments As CommentData)
            Me.Name = name
            If value.Length > 0 Then Me.Value = value
            Me.Comments = Comments
        End Sub
        Public Overrides Function ToString() As String
            If Value IsNot Nothing Then
                Return Name & " = " & Value
            Else
                Return Name
            End If
        End Function
    End Class

    Private ReadOnly members As EnumMember()
    Private ReadOnly comments As CommentData

    Sub New(data As Parser.EnumData)
        MyBase.New(data.Name)
        members = New EnumMember(data.Members.Count - 1) {}
        For i = 0 To data.Members.Count - 1
            members(i) = New EnumMember(data.Members(i).Name, data.Members(i).Value, data.Members(i).Comments)
        Next
        comments = data.Comments
    End Sub

    Protected Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides ReadOnly Property OriginalSymbol As String
        Get
            Return Name & "_t"
        End Get
    End Property

    Public Overrides ReadOnly Property ProxySymbol As String
        Get
            Return "int"
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteSymbol As String
        Get
            Return PublicSymbol
        End Get
    End Property

    Public ReadOnly Property CfxName As String
        Get
            Return "cfx_" & Name.Substring(4)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return CSharp.ApplyStyle(CfxName)
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteUnwrapExpression(var As String) As String
        Get
            Return "(int)" & var
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteWrapExpression(var As String) As String
        Get
            Return String.Format("({0}){1}", RemoteSymbol, var)
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyWrapExpression(var As String) As String
        Get
            Return "(int)" & var
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyUnwrapExpression(var As String) As String
        Get
            Return String.Format("({0}){1}", PublicSymbol, var)
        End Get
    End Property


    Private Shared additionalFlags As String() = {"CfxV8PropertyAttribute"}

    Public Sub EmitEnum(b As CodeBuilder)

        Dim enumName = CSharp.ApplyStyle(CfxName)

        b.AppendSummaryAndRemarks(comments)

        If Name.Contains("_flags") OrElse additionalFlags.Contains(enumName) Then
            b.AppendLine("[Flags()]")
        End If

        Dim varPrefix = members(0).Name
        For i = 1 To members.Length - 1
            If varPrefix.Length > members(i).Name.Length Then
                varPrefix = varPrefix.Substring(0, members(i).Name.Length)
            End If
            For c = 0 To varPrefix.Length - 1
                If varPrefix(c) <> members(i).Name(c) Then
                    varPrefix = varPrefix.Substring(0, c)
                    Exit For
                End If
            Next
            If varPrefix.Length = 0 Then Exit For
        Next


        b.BeginBlock("public enum {0}", enumName)
        For Each m In members
            Dim var = CSharp.ApplyStyle(m.Name.Substring(varPrefix.Length))
            b.AppendSummary(m.Comments)
            b.Append(var)
            If m.Value IsNot Nothing Then
                b.Append(" = unchecked((int){0})", m.Value)
            End If
            b.AppendLine(",")
        Next
        b.TrimRight()
        b.CutRight(1)
        b.AppendLine()
        b.EndBlock()
    End Sub

    Public Overrides ReadOnly Property IsCefEnumType As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property AsCefEnumType As CefEnumType
        Get
            Return Me
        End Get
    End Property

End Class
