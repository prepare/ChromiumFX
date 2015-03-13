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



Public Class BooleanIntDetector


    Public Shared Function HasCommentHintForBooleanRetval(comments As CommentData) As Boolean
        If comments Is Nothing Then Return False
        For Each c In comments.Lines
            If c.Contains("eturns true") OrElse c.Contains("eturns false") OrElse c.Contains("eturn true") OrElse c.Contains("eturn false") Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function HasCommentHintForBooleanValue(comments As CommentData) As Boolean
        If comments Is Nothing Then Return False
        For Each c In comments.Lines
            If c.Contains("true") OrElse c.Contains("false") Then
                Return True
            End If
        Next
        Return False
    End Function


    Public Shared Function GetBooleanArgumentsFromCommentHints(comments As CommentData) As String()
        If comments Is Nothing Then Return {}
        Static regex As New System.Text.RegularExpressions.Regex("\|(\w+)\|\s+(?:to|is)\s+(?:true|false)")
        Dim c1 = String.Join(" ", comments.Lines)
        Dim mm = regex.Matches(c1)
        If mm.Count > 0 Then
            Dim result(mm.Count - 1) As String
            For i = 0 To mm.Count - 1
                result(i) = mm(i).Groups(1).Value
            Next
            Return result
        End If
        Return {}
    End Function

    Private Shared prefixes As String() = {"is_", "can_", "has_", "allow_", "will_", "belongs_to",
                                           "cef_v8value::set_value_by", "cef_v8value::delete_value_by", "get_bool", "set_bool"}


    Private Shared vars As String() = {"allow", "success", "httponly", "enable", "cef_create_url", "cef_currently_on", "cef_get_path", "focus", "checked",
                                       "cef_launch_process", "cef_parse_url",
                                       "cef_browser_host_create_browser", "cef_initialize",
                                       "cef_v8context_in_context", "cef_v8value_create_bool::value",
                                       "clear_exception", "set_rethrow_exceptions", "eval",
                                       "isLoading", "canGoBack", "canGoForward",
                                       "on_before_resource_load", "process_request", "read_response",
                                       "forward", "matchCase", "findNext", "visible", "hidden", "mouseUp", "mouseLeave", "setFocus",
                                       "no_javascript_access", "exclude_empty_children"}

    Public Shared Function BooleanContext(context As String) As Boolean

        For Each var In vars
            If context.Equals(var) Then
                Return True
            End If
            If context.EndsWith("::" & var) Then
                Return True
            End If
        Next


        For Each p In prefixes
            If context.StartsWith(p) Then
                Return True
            End If
            If context.Contains("::" & p) Then
                Return True
            End If
        Next

        Return False

    End Function

End Class
