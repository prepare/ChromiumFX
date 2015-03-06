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



Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Namespace Parser
    Public Class ApiParser

        Private api As CefApiData

        Private codeFiles As New Dictionary(Of String, String)

        Public Function Parse() As CefApiData

            api = New CefApiData

            Dim c1 = "/\*.*?\*/([\r\n]+)?"
            Dim c2 = "//.*?([\r\n]+)"
            Dim commentRegex = New Regex("(?:" & c1 & "|" & c2 & ")", RegexOptions.Singleline)

            Dim sb As New Text.StringBuilder


            AddFile("cef\include\internal\cef_types.h", sb)
            AddFile("cef\include\internal\cef_types_win.h", sb)

            Dim files = Directory.GetFiles("cef\include\capi")
            For Each f In files
                AddFile(f, sb)
            Next

            Dim code = sb.ToString()

            sb.Clear()
            AddFile("cef\include\internal\cef_time.h", sb)
            Dim structOnlyCode = sb.ToString()

            code = commentRegex.Replace(code, "$1")
            structOnlyCode = commentRegex.Replace(structOnlyCode, "$1")


            Dim enumRegex = New Regex("typedef\s+enum\s*{(.*?)}\s*(\w+?)_t\s*;", RegexOptions.Singleline)
            Dim memberEx = New Regex("\b(\w+)\s*(?:=\s*((?:[0-9xA-Fa-f<+-]|\s)+))?")
            Dim mm = enumRegex.Matches(code)
            For Each m As Match In mm

                Dim e = New EnumData
                e.Name = m.Groups(2).Value

                Dim mm1 = memberEx.Matches(m.Groups(1).Value)
                Dim members As New List(Of CefEnumType.EnumMember)
                For i = 0 To mm1.Count - 1
                    Dim em = New EnumMemberData
                    em.Name = mm1(i).Groups(1).Value
                    em.Value = mm1(i).Groups(2).Value.Trim()
                    e.Members.Add(em)
                Next
                api.CefEnums.Add(e)
            Next

            ParseStructs(code)
            ParseStructs(structOnlyCode)

            Dim ff = ParseFunctions(code)
            For Each f In ff
                Dim struct = MatchCefStructPrefix(f.Name)
                If struct Is Nothing Then
                    api.CefFunctions.Add(f)
                Else
                    struct.CefFunctions.Add(f)
                End If
            Next

            Dim stringListCode = File.ReadAllText("cef\include\internal\cef_string_list.h")
            Dim stringMapCode = File.ReadAllText("cef\include\internal\cef_string_map.h")
            Dim stringMultiMapCode = File.ReadAllText("cef\include\internal\cef_string_multimap.h")

            api.CefStringListFunctions = ParseFunctions(stringListCode)
            api.CefStringMapFunctions = ParseFunctions(stringMapCode)
            api.CefStringMultimapFunctions = ParseFunctions(stringMultiMapCode)

            'Dim comments = ParseFunctionComments(stringListCode & stringMapCode & stringMultiMapCode)
            'AssignFunctionComments(comments, api.CefStringListFunctions)
            'AssignFunctionComments(comments, api.CefStringMapFunctions)
            'AssignFunctionComments(comments, api.CefStringMultimapFunctions)

            ParseComments()

            Return api

        End Function

        Sub AddFile(filename As String, sb As Text.StringBuilder)
            Dim fcode = File.ReadAllText(filename)
            sb.AppendLine(fcode)
            codeFiles.Add(filename, fcode)
        End Sub

        Private Function ParseFunctions(code As String) As FunctionData()
            Static exportFunctionRegex As New Regex("CEF_EXPORT\s+([^(]+?)\s+(cef_.+?)\((.*?)\);", RegexOptions.Singleline)
            Dim mm = exportFunctionRegex.Matches(code)
            Dim list = New List(Of FunctionData)
            For Each m As Match In mm
                Dim f = New FunctionData
                f.Name = m.Groups(2).Value
                f.Signature = New SignatureData
                f.Signature.ReturnType = ParseTypeDecl(m.Groups(1).Value, False)
                ParseArgumentList(f.Signature, m.Groups(3).Value)
                list.Add(f)
            Next
            Return list.ToArray()
        End Function

        Private Sub ParseStructs(code As String)
            Static structRegex As New Regex("typedef\s+struct\s+_(\w+?_t)\s*{(.*?)}\s*\1;", RegexOptions.Singleline)
            Dim mm = structRegex.Matches(code)
            For Each m As Match In mm
                Dim struct = New StructData
                struct.Name = m.Groups(1).Value
                ParseBody(struct, m.Groups(2).Value)
                api.CefStructs.Add(struct)
            Next
        End Sub

        Private Sub ParseBody(parent As StructData, body As String)

            Static varEx As New Regex("\s*(.+?)\s+(\w+)")

            Dim memberDeclerations = body.Split(";"c)

            For i = 0 To memberDeclerations.Length - 2
                If memberDeclerations(i).Contains("CEF_CALLBACK") Then
                    Dim sm = ParseCallback(memberDeclerations(i))
                    If sm IsNot Nothing Then
                        parent.StructMembers.Add(sm)
                    End If
                Else
                    If Not varEx.IsMatch(memberDeclerations(i)) Then
                        Stop
                    End If
                    Dim m = varEx.Match(memberDeclerations(i))

                    Dim sm = New StructMemberData
                    sm.MemberType = ParseTypeDecl(m.Groups(1).Value.Trim(), False)
                    sm.Name = m.Groups(2).Value
                    parent.StructMembers.Add(sm)
                End If
            Next
        End Sub

        Private Sub ParseArgumentList(signature As SignatureData, argsString As String)

            Static argsEx As New Regex("([^,]+)")

            Dim mm = argsEx.Matches(argsString)
            For Each m As Match In mm
                signature.Arguments.Add(ParseArgument(m.Groups(1).Value))
            Next

        End Sub

        Private Function ParseArgument(argString As String) As ArgumentData

            Static ex As New Regex("^\s*(.+)(\b\w+)\s*$")
            Dim m = ex.Match(argString)

            Dim arg = New ArgumentData
            arg.Var = m.Groups(2).Value
            arg.ArgumentType = ParseTypeDecl(m.Groups(1).Value, arg.IsConst)
            Return arg

        End Function

        Private Function ParseTypeDecl(typeDecl As String, ByRef isConst As Boolean) As TypeData

            Dim t = New TypeData

            Static indirEx As New Regex("(?:(?:\bconst\s*)?\*\s*)+$")
            Dim m1 = indirEx.Match(typeDecl)
            Dim td2 = typeDecl
            If m1.Success Then
                t.Indirection = m1.Value.Trim()
                td2 = typeDecl.Substring(0, typeDecl.Length - m1.Value.Length)
            End If

            Static ex As New Regex("^\s*(const\s+)?((?:struct\s+|enum\s+)?\w+)\s*$")
            Dim m = ex.Match(td2)
            If Not m.Success Then
                Stop
            End If

            isConst = m.Groups(1).Value.Length > 0
            t.Name = m.Groups(2).Value.Trim()

            Return t
        End Function


        Private Function ParseCallback(declaration As String) As StructMemberData

            Static callbackRegex As New Regex("\s*(.*?)\s*\(\s*CEF_CALLBACK\s*\*\s*(\w+)\s*\)\s*\((.*?)\)", RegexOptions.Singleline)

            If Not callbackRegex.IsMatch(declaration) Then
                Stop
            End If

            Dim m = callbackRegex.Match(declaration)

            Dim cb = New StructMemberData
            cb.Name = m.Groups(2).Value
            cb.CallbackSignature = New SignatureData
            cb.CallbackSignature.ReturnType = ParseTypeDecl(m.Groups(1).Value.Trim(), False)
            ParseArgumentList(cb.CallbackSignature, m.Groups(3).Value)
            Return cb

        End Function


        Private Function MatchCefStructPrefix(name As String) As StructData
            Dim result As StructData = Nothing
            For Each struct In api.CefStructs
                If name.StartsWith(struct.Name.Substring(0, struct.Name.Length - 2)) Then
                    If result Is Nothing OrElse result.Name.Length < struct.Name.Length Then
                        result = struct
                    End If
                End If
            Next
            Return result
        End Function

        Private Function GetStruct(name As String) As StructData
            For Each struct In api.CefStructs
                If name.Equals(struct.Name) Then
                    Return struct
                End If
            Next
            Return Nothing
        End Function

        Private Function GetEnum(name As String) As EnumData
            For Each e In api.CefEnums
                If name.Equals(e.Name) Then
                    Return e
                End If
            Next
            Return Nothing
        End Function

        Private commentPattern As String = "((?:\s*^\s*//+.*?$)+)"

        Private Sub ParseComments()

            Dim comments = New Dictionary(Of String, CommentData)

            Dim regex = New Regex(commentPattern & "\s*CEF_EXPORT\s+.*?\b(\w+)\s*\(", RegexOptions.Multiline)

            For Each cf In codeFiles
                Dim file = cf.Key
                Dim code = cf.Value
                ParseComments(file, code, regex, comments)
            Next

            For Each f In api.CefFunctions
                f.Comments = comments(f.Name)
            Next

            For Each s In api.CefStructs
                For Each f In s.CefFunctions
                    f.Comments = comments(f.Name)
                Next
            Next

            comments.Clear()


            regex = New Regex(commentPattern & "\s*typedef\s+enum\s*{[^}]+}\s*(\w+)_t\s*;", RegexOptions.Multiline)

            Dim enumFile = "cef\include\internal\cef_types.h"
            Dim enumCode = codeFiles(enumFile)
            ParseComments(enumFile, enumCode, regex, comments)

            For Each e In api.CefEnums
                comments.TryGetValue(e.Name, e.Comments)
            Next

            comments.Clear()

            Dim enumBodyEx = New Regex("typedef\s+enum\s*({[^}]+})\s*(\w+)_t\s*;", RegexOptions.Singleline)
            Dim enumFieldCommentEx = New Regex(commentPattern & "\s*\b(\w+)(?:\s*=\s*\w+)?\s*[,}]", RegexOptions.Multiline)

            Dim mm = enumBodyEx.Matches(enumCode)
            For Each m As Match In mm
                Dim body = m.Groups(1).Value
                Dim name = m.Groups(2).Value
                ParseComments(enumFile, body, enumFieldCommentEx, comments)
                Dim e = GetEnum(name)
                For Each member In e.Members
                    comments.TryGetValue(member.Name, member.Comments)
                Next
                comments.Clear()
            Next

            regex = New Regex(commentPattern & "\s*typedef\s+struct\s+_(cef_\w+)\b", RegexOptions.Multiline)

            For Each cf In codeFiles
                Dim file = cf.Key
                Dim code = cf.Value
                ParseComments(file, code, regex, comments)
            Next

            For Each s In api.CefStructs
                s.Comments = comments(s.Name)
            Next

            comments.Clear()

            Dim structBodyEx = New Regex("typedef\s+struct\s+_(\w+)\s*{(.*?)}\s*\1\s*;", RegexOptions.Singleline)
            Dim callbackCommentsEx = New Regex(commentPattern & "[^;]*CEF_CALLBACK\s*\*\s*(\w+)", RegexOptions.Multiline Or RegexOptions.Compiled)
            Dim valueCommentsEx = New Regex(commentPattern & "[^;]*\b(\w+)\s*;", RegexOptions.Multiline Or RegexOptions.Compiled)

            For Each cf In codeFiles
                Dim file = cf.Key
                Dim code = cf.Value


                mm = structBodyEx.Matches(code)
                For Each m As Match In mm
                    Dim name = m.Groups(1).Value
                    Dim body = m.Groups(2).Value
                    Dim t = GetStruct(name)

                    ParseComments(file, body, callbackCommentsEx, comments)
                    For Each sm In t.StructMembers
                        comments.TryGetValue(sm.Name, sm.Comments)
                    Next
                    comments.Clear()

                    ParseComments(file, body, valueCommentsEx, comments)
                    For Each sm In t.StructMembers
                        If sm.Comments Is Nothing Then comments.TryGetValue(sm.Name, sm.Comments)
                    Next
                    comments.Clear()

                Next

            Next

        End Sub

        Private Sub ParseComments(file As String, code As String, ex As Regex, comments As Dictionary(Of String, CommentData))
            Dim mm = ex.Matches(code)
            For Each m As Match In mm
                Dim commentLines = m.Groups(1).Value
                Dim name = m.Groups(2).Value
                Dim cdat = GetCommentArray(commentLines)
                cdat.FileName = file
                comments.Add(name, cdat)
            Next
        End Sub

        Private Function GetCommentArray(comments As String) As CommentData
            Static ex As New Regex("^\s*//+(.*?)$", RegexOptions.Multiline)
            Static l As New List(Of String)
            Dim mm = ex.Matches(comments)
            l.Clear()
            For i = 0 To mm.Count - 1
                Dim line = mm(i).Groups(1).Value.Trim()
                line = line.Replace("<", "&lt;")
                If Not String.IsNullOrWhiteSpace(line) Then
                    If Not line.Equals("The resulting string must be freed by calling cef_string_userfree_free().") Then
                        l.Add(line)
                    End If
                End If
            Next
            Dim cc = New CommentData
            cc.Lines = l.ToArray()
            Return cc
        End Function

    End Class
End Namespace
