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

        Private booleanRetvals As New HashSet(Of String)
        Private booleanParameters As New HashSet(Of String)

        Private cefConfigs As New Dictionary(Of String, CefConfigData)

        Private codeFiles As New Dictionary(Of String, String)

        Public Function Parse() As CefApiData

            ParseCppHeaders()

            AddFile("cef\include\cef_version.h")

            AddFile("cef\include\internal\cef_types.h")
            AddFile("cef\include\internal\cef_time.h")

            Dim files = Directory.GetFiles("cef\include\capi")
            For Each f In files
                AddFile(f)
            Next

            Dim enums = New List(Of EnumData)
            Dim structs = New List(Of StructData)
            Dim funcs = New List(Of FunctionData)

            ParseEnums(StripComments(codeFiles("cef\include\internal\cef_types.h")), enums)

            For Each cf In codeFiles
                Dim code = StripComments(cf.Value)
                ParseStructs(code, structs)
                If cf.Key <> "cef\include\internal\cef_time.h" Then
                    ParseFunctions(code, funcs)
                End If
            Next

            Dim api = New CefApiData
            api.CefEnums = enums
            api.CefStructs = structs
            api.CefFunctions = New List(Of FunctionData)

            For Each f In funcs

                Dim struct = MatchCefStructPrefix(f.Name, structs)
                If struct Is Nothing Then
                    api.CefFunctions.Add(f)
                Else
                    struct.CefFunctions.Add(f)
                End If

                Dim token = ReduceToken(f.Name)
                If booleanRetvals.Contains(token) Then
                    f.Signature.ReturnType.Name = "bool"
                    'booleanRetvals.Remove(token)
                End If
                For Each arg In f.Signature.Arguments
                    Dim t1 = token & ReduceToken(arg.Var)
                    If booleanParameters.Contains(t1) Then
                        arg.ArgumentType.Name = "bool"
                        'booleanParameters.Remove(t1)
                    End If
                Next

            Next

            For Each struct In api.CefStructs
                For Each sm In struct.StructMembers
                    If sm.CallbackSignature IsNot Nothing Then
                        Dim token = ReduceToken(struct.Name.Substring(0, struct.Name.Length - 2) & sm.Name)

                        If cefConfigs.ContainsKey(token) Then
                            sm.CefConfig = cefConfigs(token)
                            If sm.CefConfig.CppApiName IsNot Nothing Then
                                token = ReduceToken(struct.Name.Substring(0, struct.Name.Length - 2) & sm.CefConfig.CppApiName)
                            End If
                        End If

                        If booleanRetvals.Contains(token) Then
                            sm.CallbackSignature.ReturnType.Name = "bool"
                            'booleanRetvals.Remove(token)
                        End If
                        For Each arg In sm.CallbackSignature.Arguments
                            Dim t1 = token & ReduceToken(arg.Var)
                            If booleanParameters.Contains(t1) Then
                                arg.ArgumentType.Name = "bool"
                                'booleanParameters.Remove(t1)
                            End If
                        Next
                    End If
                Next
            Next

            'If booleanRetvals.Count > 0 Then
            '    Stop
            'End If

            'If booleanParameters.Count > 0 Then
            '    Stop
            'End If

            Dim stringListCode = File.ReadAllText("cef\include\internal\cef_string_list.h")
            Dim stringMapCode = File.ReadAllText("cef\include\internal\cef_string_map.h")
            Dim stringMultiMapCode = File.ReadAllText("cef\include\internal\cef_string_multimap.h")

            funcs.Clear()
            ParseFunctions(stringListCode, funcs)
            ParseFunctions(stringMapCode, funcs)
            ParseFunctions(stringMultiMapCode, funcs)
            api.CefStringCollectionFunctions = funcs.ToArray()

            ParseComments(api)

            Dim pa = ParsePlatformApi("cef\include\internal\cef_types_win.h")
            api.CefFunctionsWindows = pa.CefFunctions
            api.CefStructsWindows = pa.CefStructs

            pa = ParsePlatformApi("linux\cef\include\internal\cef_types_linux.h")
            api.CefFunctionsLinux = pa.CefFunctions
            api.CefStructsLinux = pa.CefStructs

            Return api

        End Function

        Private Function ParsePlatformApi(filename As String) As CefApiData
            Dim platformApi = New CefApiData

            platformApi.CefEnums = New List(Of EnumData)
            platformApi.CefStructs = New List(Of StructData)
            platformApi.CefFunctions = New List(Of FunctionData)
            codeFiles.Clear()
            AddFile(filename)

            ParseStructs(StripComments(codeFiles(filename)), platformApi.CefStructs)
            ParseFunctions(StripComments(codeFiles(filename)), platformApi.CefFunctions)
            ParseComments(platformApi)
            Return platformApi
        End Function

        Private Function StripComments(code As String) As String
            Static stripCommentsRegex As Regex
            If stripCommentsRegex Is Nothing Then
                Dim c1 = "/\*.*?\*/([\r\n]+)?"
                Dim c2 = "//.*?([\r\n]+)"
                stripCommentsRegex = New Regex("(?:" & c1 & "|" & c2 & ")", RegexOptions.Singleline)
            End If
            Return stripCommentsRegex.Replace(code, "$1")
        End Function

        Private Sub AddFile(filename As String)
            Dim fcode = File.ReadAllText(filename)
            codeFiles.Add(filename, fcode)
        End Sub

        Private Sub ParseEnums(code As String, enums As List(Of EnumData))
            Static enumRegex As New Regex("typedef\s+enum\s*{(.*?)}\s*(\w+?)_t\s*;", RegexOptions.Singleline)
            Static memberEx As New Regex("\b(\w+)\s*(?:=\s*((?:[0-9xA-Fa-f<+-]|\s)+))?")

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
                enums.Add(e)
            Next
        End Sub

        Private Sub ParseFunctions(code As String, funcs As List(Of FunctionData))
            Static exportFunctionRegex As New Regex("CEF_EXPORT\s+([^(]+?)\s+(cef_.+?)\((.*?)\);", RegexOptions.Singleline)
            Dim mm = exportFunctionRegex.Matches(code)
            For Each m As Match In mm
                Dim f = New FunctionData
                f.Name = m.Groups(2).Value
                f.Signature = New SignatureData
                f.Signature.ReturnType = ParseTypeDecl(m.Groups(1).Value, f.Signature.ReturnValueIsConst)
                ParseArgumentList(f.Signature, m.Groups(3).Value)
                funcs.Add(f)
            Next
        End Sub

        Private Sub ParseStructs(code As String, structs As List(Of StructData))
            Static structRegex As New Regex("typedef\s+struct\s+_(\w+?_t)\s*{(.*?)}\s*\1;", RegexOptions.Singleline)
            Dim mm = structRegex.Matches(code)
            For Each m As Match In mm
                Dim struct = New StructData
                struct.Name = m.Groups(1).Value
                ParseBody(struct, m.Groups(2).Value)
                structs.Add(struct)
            Next
        End Sub

        Private Sub ParseBody(parent As StructData, body As String)

            Static varEx As New Regex("^\s*(.+?)\s+(\w+)\s*$")

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

            Static ex As New Regex("^\s*(const)?((?:\s*\b\w+\b)+)\s*$")
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
            cb.CallbackSignature.ReturnType = ParseTypeDecl(m.Groups(1).Value.Trim(), cb.CallbackSignature.ReturnValueIsConst)
            ParseArgumentList(cb.CallbackSignature, m.Groups(3).Value)
            Return cb

        End Function


        Private Function MatchCefStructPrefix(name As String, structs As List(Of StructData)) As StructData
            Dim result As StructData = Nothing
            For Each struct In structs
                If name.StartsWith(struct.Name.Substring(0, struct.Name.Length - 2)) Then
                    If result Is Nothing OrElse result.Name.Length < struct.Name.Length Then
                        result = struct
                    End If
                End If
            Next
            Return result
        End Function


        Private commentPattern As String = "((?:\s*^\s*//+.*?$)+)"

        Private Sub ParseComments(api As CefApiData)

            Dim enums = New Dictionary(Of String, EnumData)
            Dim structs = New Dictionary(Of String, StructData)

            For Each e In api.CefEnums
                enums.Add(e.Name, e)
            Next

            For Each s In api.CefStructs
                structs.Add(s.Name, s)
            Next

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
            If codeFiles.ContainsKey(enumFile) Then
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
                    Dim e = enums(name)
                    For Each member In e.Members
                        comments.TryGetValue(member.Name, member.Comments)
                    Next
                    comments.Clear()
                Next
            End If

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


                Dim mm = structBodyEx.Matches(code)
                For Each m As Match In mm
                    Dim name = m.Groups(1).Value
                    Dim body = m.Groups(2).Value
                    Dim t = structs(name)

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


        Private Sub ParseCppHeaders()

            Dim classEx = New Regex("class\s+(\w+)\s*(?::\s*public\s+virtual\s+CefBase\s*)?{(.+?)};", RegexOptions.Singleline)
            Dim boolRetvalEx = New Regex("\bbool\b\s+(\w+)\s*\(")
            Dim funcEx = New Regex("(\w+)\s*\((.*?)\)", RegexOptions.Singleline)
            Dim boolParamEx = New Regex("\bbool\b(?:\s*[&*])?\s*\b(\w+)\b")

            Dim files = Directory.GetFiles("cef\include")
            For Each f In files
                Dim code = File.ReadAllText(f)

                Dim mmClasses = classEx.Matches(code)
                For Each m As Match In mmClasses
                    Dim className = m.Groups(1).Value
                    Dim body = m.Groups(2).Value

                    ParseCefConfig(className, body)

                    Dim mmRetvals = boolRetvalEx.Matches(body)
                    For Each m1 As Match In mmRetvals
                        booleanRetvals.Add(ReduceToken(className & m1.Groups(1).Value))
                    Next
                    Dim mmFunc = funcEx.Matches(body)
                    For Each m1 As Match In mmFunc
                        Dim funcName = m1.Groups(1).Value
                        Dim mmParam = boolParamEx.Matches(m1.Groups(2).Value)
                        For Each m2 As Match In mmParam
                            booleanParameters.Add(ReduceToken(className & funcName & m2.Groups(1).Value))
                        Next
                    Next
                Next

                code = classEx.Replace(code, "")

                Dim mmRetvalsGlob = boolRetvalEx.Matches(code)
                For Each m As Match In mmRetvalsGlob
                    booleanRetvals.Add(ReduceToken(m.Groups(1).Value))
                Next

                Dim mmFuncGlob = funcEx.Matches(code)
                For Each m1 As Match In mmFuncGlob
                    Dim funcName = m1.Groups(1).Value
                    Dim mmParam = boolParamEx.Matches(m1.Groups(2).Value)
                    For Each m2 As Match In mmParam
                        booleanParameters.Add(ReduceToken(funcName & m2.Groups(1).Value))
                    Next
                Next

            Next

        End Sub

        Private Function ReduceToken(token As String) As String
            ' Reduce the token to lowercase characters for matching against the C api
            Return token.Replace("_", "").ToLowerInvariant()
        End Function

        Private Sub ParseCefConfig(className As String, code As String)

            Dim cefConfigTagEx = New Regex("/\*--cef\(([^)]*)\)--\*/[^(]*\b(\w+)\s*\(")

            Dim mm = cefConfigTagEx.Matches(code)
            For Each m As Match In mm
                Dim config = m.Groups(1).Value
                If config.Length > 0 Then
                    Dim funcName = m.Groups(2).Value
                    Dim token = ReduceToken(className & funcName)
                    Dim items = config.Split(","c)
                    Dim data = New CefConfigData
                    Dim optParams = New List(Of String)
                    For Each item In items
                        Dim pair = item.Split("="c)
                        Dim value As String = Nothing
                        If pair.Length = 2 Then
                            value = pair(1).Trim()
                        End If

                        Select Case pair(0).Trim()
                            Case "capi_name"
                                data.CppApiName = funcName
                                token = ReduceToken(className & value)
                            Case "index_param"
                                data.IndexParameter = value
                            Case "optional_param"
                                optParams.Add(value)
                            Case "count_func"
                                data.CountFunction = value
                            Case "default_retval"
                                data.DefaultRetval = value
                            Case "api_hash_check"
                                data.ApiHashCheck = True
                            Case Else
                                Stop
                        End Select
                    Next
                    data.OptionalParameters = optParams.ToArray()
                    cefConfigs.Add(token, data)
                End If
            Next

        End Sub

    End Class
End Namespace
