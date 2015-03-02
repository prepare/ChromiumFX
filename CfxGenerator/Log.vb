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



Public Class Log

    Private Shared ReadOnly _logs As New Dictionary(Of String, Text.StringBuilder)

    Shared Sub New()
        Dim tmp = Logs("Unchanged types")
        tmp = Logs("Missing Functions")
    End Sub

    Shared ReadOnly Property Logs(ByVal name As String) As Text.StringBuilder
        Get
            Dim sb As Text.StringBuilder = Nothing
            If Not _logs.TryGetValue(name, sb) Then
                sb = New Text.StringBuilder
                _logs.Add(name, sb)
            End If
            Return sb
        End Get
    End Property

    Shared Function GetOutput() As String

        Dim sb = New Text.StringBuilder

        For Each l In _logs
            sb.Append(l.Key)
            sb.AppendLine(":")
            sb.AppendLine(l.Value.ToString())
            sb.AppendLine()
        Next
        Return sb.ToString
    End Function

    Shared Sub LogUnchangedType(ByVal text As String)
        logs("Unchanged types").AppendLine(text)
    End Sub

    Shared Sub LogMissingFunction(ByVal text As String)
        logs("Missing Functions").AppendLine(text)
    End Sub

    Shared Sub LogChangedFiles(ByVal text As String)
        logs("Changed files").AppendLine(text)
    End Sub
End Class
