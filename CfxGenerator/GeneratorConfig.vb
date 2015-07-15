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

Imports System.Text.RegularExpressions

Public Class GeneratorConfig

    Public Shared ReadOnly Property CreateRemoteProxy(item As String) As Boolean
        Get
            Return Not (IsBrowserProcessOnly(item) OrElse HasPrivateWrapper(item))
        End Get
    End Property

    Private Shared browserProcessOnly As String() = AssemblyResources.GetLines("BrowserProcessOnly.txt")
    Public Shared ReadOnly Property IsBrowserProcessOnly(item As String) As Boolean
        Get
            Return browserProcessOnly.Contains(item)
        End Get
    End Property

    Public Shared ReadOnly Property AdditionalCallIds As String()
        Get
            Dim lines As String() = AssemblyResources.GetLines("AdditionalCallIds.txt")
            Dim list = New List(Of String)
            For Each line In lines
                If Not String.IsNullOrWhiteSpace(line) Then
                    list.Add(line.Trim())
                End If
            Next
            Return list.ToArray()
        End Get
    End Property

    Public Shared Sub FindDoNotKeepParameters(cb As CefCallbackType)

        Dim cc = String.Join(" ", cb.Comments.Lines)

        Dim phrase = Regex.Match(cc, "\bnot\s+keep\b[^.]+\.").Value
        If phrase.Length = 0 Then Return

        For Each arg In cb.Signature.ManagedArguments
            If arg.ArgumentType.IsCefStructPtrType AndAlso arg.VarName <> "self" Then
                If arg.ArgumentType.OriginalSymbol.StartsWith("cef_dom") Then
                    arg.DoNotKeep = True
                    'Debug.Print("{0}::{1}({2} {3})", cb.Parent.OriginalSymbol, cb.OriginalSymbol, arg.ArgumentType.OriginalSymbol, arg.VarName)
                ElseIf Regex.Match(phrase, "\b" & arg.VarName & "\b").Success Then
                    arg.DoNotKeep = True
                    'Debug.Print("{0}::{1}({2} {3})", cb.Parent.OriginalSymbol, cb.OriginalSymbol, arg.ArgumentType.OriginalSymbol, arg.VarName)
                ElseIf Regex.Match(phrase, "\b" & arg.ArgumentType.OriginalSymbol & "\b").Success Then
                    arg.DoNotKeep = True
                    'Debug.Print("{0}::{1}({2} {3})", cb.Parent.OriginalSymbol, cb.OriginalSymbol, arg.ArgumentType.OriginalSymbol, arg.VarName)
                End If
            End If
        Next

    End Sub


    Private Shared privateWrapperFunctions As String() = AssemblyResources.GetLines("PrivateWrapper.txt")
    Public Shared ReadOnly Property HasPrivateWrapper(item As String) As Boolean
        Get
            Return privateWrapperFunctions.Contains(item)
        End Get
    End Property


    Private Shared callbackValueStructs As String() = AssemblyResources.GetLines("StructsNeedWrapping.txt")
    Public Shared ReadOnly Property ValueStructNeedsWrapping(item As String) As Boolean
        Get
            Return callbackValueStructs.Contains(item)
        End Get
    End Property


    Private Shared partialClasses As HashSet(Of String)


    Public Shared ReadOnly Property ClassModifiers(className As String, Optional baseModifiers As String = "public") As String
        Get
            If IsPartialClass(className) Then
                Return baseModifiers & " partial"
            Else
                Return baseModifiers
            End If
        End Get
    End Property

    Public Shared Function IsPartialClass(className As String) As Boolean
        If partialClasses Is Nothing Then
            FindPartialClasses()
        End If
        Return partialClasses.Contains(className)
    End Function

    Private Shared Sub FindPartialClasses()
        partialClasses = New HashSet(Of String)
        FindPartialClasses("ChromiumFX\Source")
        FindPartialClasses("ChromiumFX\Source\Remote")
    End Sub

    Private Shared Sub FindPartialClasses(path As String)
        If Not System.IO.Directory.Exists(path) Then Return
        Dim files = System.IO.Directory.GetFiles(path)
        For Each f In files
            partialClasses.Add(System.IO.Path.GetFileNameWithoutExtension(f))
        Next
    End Sub

End Class
