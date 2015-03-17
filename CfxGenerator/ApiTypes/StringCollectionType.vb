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



Public Class StringCollectionType
    Inherits CefType

    Public ExportFunctions As CefExportFunction()

    'TODO: user created string lists and maps don't copy appended strings so the normal scheme won't work

    Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Sub SetFunctions(funcs As Parser.FunctionData(), api As ApiTypeBuilder)
        Dim list = New List(Of CefExportFunction)
        For Each fd In funcs
            list.Add(New CefExportFunction(Me, fd, api))
        Next
        ExportFunctions = list.ToArray()

        For Each f In ExportFunctions
            If f.Signature.ManagedArguments.Length > 0 Then
                If f.Signature.ManagedArguments(0).ArgumentType.Equals(Me) Then
                    f.Signature.ManagedArguments(0).IsThisArgument = True
                End If
            End If
        Next

    End Sub

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return "IntPtr"
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            Return String.Format("{0}_unwrapped", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicWrapExpression(var As String) As String
        Get
            Return String.Format("StringFunctions.Wrap{0}({1})", ClassName, var)
        End Get
    End Property

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("PinnedString[] {0}_handles;", var)
        b.AppendLine("var {0}_unwrapped = StringFunctions.Unwrap{1}({0}, out {0}_handles);", var, ClassName)
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("StringFunctions.FreePinnedStrings({0}_handles);", var)
        b.AppendLine("StringFunctions.{0}CopyToManaged({1}_unwrapped, {1});", ClassName, var)
        b.AppendLine("CfxApi.{0}_free({1}_unwrapped);", CfxName, var)
    End Sub


    Public Overrides ReadOnly Property IsStringCollectionType As Boolean
        Get
            Return True
        End Get
    End Property

End Class
