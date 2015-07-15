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



Public Class CefRectArrayType
    Inherits ApiType

    Public ReadOnly CountArg As Argument

    Sub New(countArg As Argument)
        MyBase.New("__cef_rect_t[]")
        Me.CountArg = countArg
    End Sub

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return "CfxRect[]"
        End Get
    End Property


    Public Overrides Function PublicEventConstructorSignature(var As String) As String
        Return String.Format("IntPtr {0}, {1}", var, CountArg.PublicEventConstructorSignature)
    End Function

    Public Overrides Function PublicEventConstructorCall(var As String) As String
        Return var & ", " & CountArg.PublicEventConstructorCall
    End Function

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal IntPtr m_{0};", var)
        CountArg.EmitPublicEventArgFields(b)
        b.AppendLine("internal CfxRect[] m_{0}_managed;", var)
    End Sub

    Public Overrides Sub EmitPublicEventCtorStatements(b As CodeBuilder, var As String)
        MyBase.EmitPublicEventCtorStatements(b, var)
        CountArg.ArgumentType.EmitPublicEventCtorStatements(b, CountArg.VarName)
    End Sub


    Public Overrides Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)

        Dim code = <![CDATA[
if(m_{0}_managed == null) {{
    if(m_{1} == 0) return new CfxRect[0];
    var buffer = new int[4 * m_{1}];
    System.Runtime.InteropServices.Marshal.Copy(m_{0}, buffer, 0, buffer.Length);
    m_{0}_managed = new CfxRect[m_{1}];
    for (var i = 0; i < m_{1};) {{
        m_{0}_managed[i] = new CfxRect() {{
            X = buffer[i++],
            Y = buffer[i++],
            Width = buffer[i++],
            Height = buffer[i++]
        }};
    }}
}}
return m_{0}_managed;
]]>.Value.Trim()

        b.AppendMultiline(code, var, CountArg.VarName)
    End Sub


End Class
