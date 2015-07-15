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



Public Class CSharp

    Public Shared Function Escape(symbol As String) As String
        Select Case symbol
            Case "event", "string", "checked", "object"
                Return "@" & symbol
            Case "params"
                Return "parameters"
            Case Else
                Return symbol
        End Select
    End Function

    Public Shared Function PrepareSummaryLine(line As String, Optional forRemote As Boolean = False, Optional forEvent As Boolean = False) As String

        line = Regex.Replace(line, "&(?!\w+;)", "&amp;")

        line = Regex.Replace(line, "\b(cef_\w+)_t(\w+)?\b", AddressOf PrepareSummaryLine_TypeMatch)
        line = Regex.Replace(line, "\b(Cef\w+)(?:\.|::|->)(\w+)\b", AddressOf PrepareSummaryLine_MemberMatch)
        line = Regex.Replace(line, "->([\w_]+)\(", AddressOf PrepareSummaryLine_FunctionMatch)

        PrepareSummaryLine_ArgumentMatch_ForEvent = forEvent
        line = Regex.Replace(line, "\|(\w+)\|", AddressOf PrepareSummaryLine_ArgumentMatch)

        Dim prefix = If(forRemote, "Cfr", "Cfx")
        line = Regex.Replace(line, "\bCef(\w+)\b", prefix & "$1")
        Return line
    End Function

    Private Shared Function PrepareSummaryLine_TypeMatch(m As Match) As String
        If m.Groups(2).Success Then
            Program.DocumentationFormatBugStillExists = True
            Return ApplyStyle(m.Groups(1).Value, False) & m.Groups(2).Value
        Else
            Return ApplyStyle(m.Groups(1).Value, False)
        End If
    End Function

    Private Shared Function PrepareSummaryLine_MemberMatch(m As Match) As String
        Return String.Format("{0}.{1}", m.Groups(1).Value, ApplyStyle(m.Groups(2).Value, False))
    End Function

    Private Shared Function PrepareSummaryLine_FunctionMatch(m As Match) As String
        Return String.Format(".{0}(", ApplyStyle(m.Groups(1).Value, False))
    End Function

    Private Shared PrepareSummaryLine_ArgumentMatch_ForEvent As Boolean
    Private Shared Function PrepareSummaryLine_ArgumentMatch(m As Match) As String
        Return String.Format("|{0}|", ApplyStyle(m.Groups(1).Value, Not PrepareSummaryLine_ArgumentMatch_ForEvent))
    End Function

    Public Shared Function ApplyStyle(name As String, Optional ByVal firstLower As Boolean = False) As String


        If Not name.Contains("_") Then

            If name = "cont" Then name = "continue"

            For i = 0 To name.Length - 1
                If Char.IsLower(name(i)) Then
                    GoTo skip_to_lower
                End If
            Next
            name = name.ToLowerInvariant()

skip_to_lower:

            name = CapitalizeParts(name)

            If firstLower Then
                If Char.IsUpper(name(0)) Then
                    name = Char.ToLower(name(0)) & name.Substring(1)
                End If
            Else
                If Char.IsLower(name(0)) Then
                    name = Char.ToUpper(name(0)) & name.Substring(1)
                End If
            End If

            Return name
        End If


        Dim n1 As String


        Dim parts = name.ToLowerInvariant().Split("_"c)
        Dim start = 0
        For i = 0 To parts.Length - 1
            parts(i) = CapitalizeFirst(parts(i))
        Next

        n1 = CapitalizeParts(String.Join("", parts))


        If firstLower Then
            n1 = Char.ToLowerInvariant(n1(0)) & n1.Substring(1)
        End If

        Return n1
    End Function

    Private Shared Function CapitalizeParts(name As String) As String
        name = name.Replace("type", "Type")
        name = name.Replace("dialog", "Dialog")
        name = name.Replace("flag", "Flag")
        name = name.Replace("item", "Item")
        name = name.Replace("event", "Event")
        name = name.Replace("severity", "Severity")
        name = name.Replace("storage", "Storage")
        name = name.Replace("parts", "Parts")
        name = name.Replace("request", "Request")
        name = name.Replace("accessor", "Accessor")
        name = name.Replace("context", "Context")
        name = name.Replace("exception", "Exception")
        name = name.Replace("handler", "Handler")
        name = name.Replace("stack", "Stack")
        name = name.Replace("value", "Value")
        name = name.Replace("modal", "Modal")
        name = name.Replace("loop", "Loop")
        name = name.Replace("document", "Document")
        name = name.Replace("node", "Node")
        name = name.Replace("visitor", "Visitor")
        name = name.Replace("text", "Text")
        name = name.Replace("case", "Case")
        name = name.Replace("next", "Next")
        name = name.Replace("selection", "Selection")
        name = name.Replace("dirtyrect", "dirtyRect")
        name = name.Replace("count", "Count")
        name = name.Replace("name", "Name")
        name = name.Replace("attrmap", "attrMap")
        name = name.Replace("ByqName", "ByQName")
        name = name.Replace("BylName", "ByLName")
        name = name.Replace("index", "Index")
        name = name.Replace("uri", "Uri")
        name = name.Replace("attribute", "Attribute")
        name = name.Replace("control", "Control")
        name = name.Replace("Errorcode", "ErrorCode")
        name = name.Replace("element", "Element")
        name = name.Replace("delete", "Delete")
        name = name.Replace("only", "Only")
        name = name.Replace("enum", "Enum")
        name = name.Replace("key", "Key")
        name = name.Replace("Byident", "ByIdentifier")
        name = name.Replace("model", "Model")
        name = name.Replace("color", "Color")
        name = name.Replace("mode", "Mode")
        name = name.Replace("resize", "Resize")
        name = name.Replace("panning", "Panning")
        name = name.Replace("drop", "Drop")
        name = name.Replace("allowed", "Allowed")
        name = name.Replace("menu", "Menu")
        name = name.Replace("south", "South")
        name = name.Replace("astwest", "astWest")
        name = name.Replace("oomout", "oomOut")
        name = name.Replace("oomin", "oomIn")
        name = name.Replace("Xdisplay", "XDisplay")
        name = name.Replace("Sslcert", "SslCert")
        name = name.Replace("Sslinfo", "SslInfo")
        name = name.Replace("Jsonand", "JsonAnd")
        name = name.Replace("Jsonand", "JsonAnd")
        name = name.Replace("decode", "Decode")
        name = name.Replace("encode", "Encode")
        
        name = name.Replace("ConText", "Context")
        name = name.Replace("DisAllowed", "Disallowed")
        name = name.Replace("ubMenu", "ubmenu")
        name = name.Replace("Uring", "uring")
        Return name
    End Function

    Private Shared Function CapitalizeFirst(s As String) As String
        Return Char.ToUpper(s(0)) & s.Substring(1)
    End Function

End Class
