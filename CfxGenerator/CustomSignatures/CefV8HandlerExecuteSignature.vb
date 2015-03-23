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



Public Class CefV8HandlerExecuteSignature
    Inherits SignatureWithStructPtrArray

    Private m_publicArguments As Argument()

    Public Sub New(owner As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder)
        MyBase.New(owner, sd, api, 4, 3)

        Dim list = New List(Of Argument)
        For Each arg In MyBase.ManagedArguments
            If arg.VarName <> "retval" Then
                list.Add(arg)
            End If
        Next
        m_publicArguments = list.ToArray()
    End Sub


    Public Overrides ReadOnly Property PublicReturnType As ApiType
        Get
            Return New CefStructPtrType(New CefStructType("cef_v8value", Nothing), "*")
        End Get
    End Property

    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return m_publicArguments
        End Get
    End Property

    Protected Overrides Sub EmitPostPublicEventHandlerReturnValueStatements(b As CodeBuilder)
        b.BeginIf("e.m_returnValue != null")
        b.AppendLine("retval = CfxV8Value.Unwrap(e.m_returnValue);")
        b.AppendLine("__retval = 1;")
        b.BeginElse()
        b.AppendLine("retval = IntPtr.Zero;")
        b.AppendLine("__retval = 0;")
        b.EndBlock()
    End Sub

End Class
