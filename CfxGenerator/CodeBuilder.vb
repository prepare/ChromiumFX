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



Public Class CodeBuilder

    Private Const spaces As String = "                                                                                                                        "

    Protected builder As New Text.StringBuilder

    Private currentLine As New List(Of String)

    Public CurrentIndent As Integer

    Sub New()
    End Sub

    Sub New(ByVal indent As Integer)
        CurrentIndent = indent
    End Sub

    Private Sub EmitDebugInfo()
        If Main.EmitDebugInfo > 0 Then
            Dim i = 2
            Dim caller = New StackFrame(2, False)
            Dim method = caller.GetMethod()
            Do While method.DeclaringType.Name = "CodeBuilder" OrElse method.DeclaringType.Name = "ClassBuilder"
                i += 1
                caller = New StackFrame(i, False)
                method = caller.GetMethod()
            Loop
            AppendComment(" {0}.{1}", method.DeclaringType.Name, method.Name)
        End If
    End Sub

    Private Sub CommitCurrentLine()
        If currentLine.Count > 0 Then
            If CurrentIndent > 0 Then builder.Append(spaces.Substring(0, CurrentIndent * 4))
            For Each s In currentLine
                builder.Append(s)
            Next
            currentLine.Clear()
        End If
    End Sub

    Public Sub IncreaseIndent()
        CurrentIndent += 1
    End Sub

    Public Sub DecreaseIndent()
        CurrentIndent -= 1
    End Sub

    Sub BeginBlock(ByVal header As String, ByVal ParamArray pm As Object())
        Append(header, pm)
        Append(" ")
        BeginBlock()
    End Sub

    Sub BeginBlock(ByVal header As String)
        Append(header)
        Append(" ")
        BeginBlock()
    End Sub

    Sub BeginBlock()
        AppendLine("{")
        IncreaseIndent()
    End Sub

    Sub EndBlock()
        DecreaseIndent()
        AppendLine("}")
    End Sub

    Sub EndBlock(ByVal suffix As String)
        DecreaseIndent()
        Append("} ")
        AppendLine(suffix)
    End Sub

    Sub EndBlock(ByVal suffix As String, ByVal ParamArray pm As Object())
        DecreaseIndent()
        Append("} ")
        AppendLine(suffix, pm)
    End Sub

    Sub Append(ByVal line As String)
        currentLine.Add(line)
    End Sub

    Sub AppendLine()
        CommitCurrentLine()
        EmitDebugInfo()
        builder.AppendLine()
    End Sub

    Sub AppendLine(ByVal line As String)
        Append(line)
        AppendLine()
    End Sub

    Sub Append(ByVal format As String, ByVal ParamArray pm As Object())
        Append(String.Format(format, pm))
    End Sub

    Sub AppendLine(ByVal format As String, ByVal ParamArray pm As Object())
        Append(format, pm)
        AppendLine()
    End Sub

    Sub AppendMultiline(ByVal code As String)
        Dim lines = code.Split(Environment.NewLine.ToCharArray())
        For Each line In lines
            AppendLine(line)
        Next
    End Sub

    Sub AppendMultiline(ByVal format As String, ByVal ParamArray pm As Object())
        Dim code = String.Format(format, pm)
        Dim lines = code.Split(Environment.NewLine.ToCharArray())
        For Each line In lines
            AppendLine(line)
        Next
    End Sub

    Sub AppendComment(line As String)
        Append("// ")
        AppendLine(line)
    End Sub

    Sub BeginCfxNamespace()
        BeginCfxNamespace({"System"})
    End Sub

    Sub BeginCfxNamespace(subspace As String)
        BeginCfxNamespace({"System"}, subspace)
    End Sub

    Sub BeginCfxNamespace(usingStmts As String(), Optional subspace As String = "")
        For Each stmt In usingStmts
            AppendLine("using {0};", stmt)
        Next
        AppendLine()
        BeginBlock("namespace Chromium" & subspace)
    End Sub

    Sub BeginClass(name As String, Optional modifiers As String = "public")
        BeginBlock("{0} class {1}", modifiers, name)
    End Sub

    Sub BeginRemoteCallClass(name As String, eventCall As Boolean, callIds As List(Of String))
        If Not eventCall Then
            BeginClass(name & "RenderProcessCall : RenderProcessCall", "internal")
            callIds.Add(name & "RenderProcessCall")
            AppendLine()
            AppendLine("internal {0}RenderProcessCall()", name)
            IncreaseIndent()
            AppendLine(": base(RemoteCallId.{0}RenderProcessCall) {{}}", name)
            DecreaseIndent()
        Else
            BeginClass(name & "BrowserProcessCall : BrowserProcessCall", "internal")
            callIds.Add(name & "BrowserProcessCall")
            AppendLine()
            AppendLine("internal {0}BrowserProcessCall()", name)
            IncreaseIndent()
            AppendLine(": base(RemoteCallId.{0}BrowserProcessCall) {{}}", name)
        DecreaseIndent()
        End If
    End Sub


    Sub BeginFunction(functionSignature As String, Optional modifiers As String = "public")
        BeginBlock("{0} {1}", modifiers, functionSignature)
    End Sub

    Sub BeginFunction(name As String, returnType As String, arguments As String, Optional modifiers As String = "public")
        BeginBlock("{0} {1} {2}({3})", modifiers, returnType, name, arguments)
    End Sub

    Sub BeginIf(condition As String)
        BeginBlock("if({0})", condition)
    End Sub

    Sub BeginIf(condition As String, ByVal ParamArray pm As Object())
        BeginBlock("if({0})", String.Format(condition, pm))
    End Sub

    Sub BeginFor(limit As String)
        BeginBlock("for(int i = 0; i < {0}; ++i)", limit)
    End Sub

    Sub BeginElse()
        EndBlock("else {")
        IncreaseIndent()
    End Sub

    Sub BeginCatch()
        EndBlock("catch {")
        IncreaseIndent()
    End Sub

    Sub BeginCatch(catchArgument As String)
        EndBlock(String.Format("catch({0}) {{", catchArgument))
        IncreaseIndent()
    End Sub

    Sub AppendComment(format As String, ByVal ParamArray pm As Object())
        AppendComment(String.Format(format, pm))
    End Sub

    Sub AppendSummary(summary As CommentData, Optional forRemote As Boolean = False, Optional forEvent As Boolean = False)
        If summary IsNot Nothing AndAlso Not summary.Lines.Length = 0 Then
            AppendLine("/// <summary>")
            For Each line In summary.Lines
                line = CSharp.PrepareSummaryLine(line, forRemote, forEvent)
                AppendLine("/// " & line)
            Next
            AppendLine("/// </summary>")
        End If
    End Sub


    Sub AppendBuilder(ByVal b As CodeBuilder)
        CommitCurrentLine()
        builder.Append(b.ToString())
    End Sub

    Sub CutRight(charCount As Integer)
        CommitCurrentLine()
        builder.Remove(builder.Length - charCount, charCount)
    End Sub

    Sub TrimRight()
        CommitCurrentLine()
        Dim i = builder.Length - 1
        Do While i >= 0 AndAlso Char.IsWhiteSpace(builder.Chars(i))
            i -= 1
        Loop
        If i < builder.Length - 1 Then
            builder.Remove(i + 1, builder.Length - i - 1)
        End If
    End Sub

    ReadOnly Property IsNotEmpty As Boolean
        Get
            Return currentLine.Count > 0 OrElse builder.Length > 0
        End Get
    End Property

    Sub Clear()
        builder.Clear()
    End Sub

    Public Overrides Function ToString() As String
        CommitCurrentLine()
        Return builder.ToString()
    End Function
End Class
