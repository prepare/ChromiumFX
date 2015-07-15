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



Public Class CefStringPtrTypeConst
    Inherits ApiType
    Public Sub New(baseType As CefStringType)
        MyBase.New(baseType.Name & "*")
    End Sub

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return "string"
        End Get
    End Property


    Public Overrides Function NativeCallSignature(var As String, isConst As Boolean) As String
        Return String.Format("char16 *{0}_str, int {0}_length", var)
    End Function

    Public Overrides Function PInvokeCallSignature(var As String) As String
        Return String.Format("IntPtr {0}_str, int {0}_length", var)
    End Function

    Public Overrides Function NativeWrapExpression(var As String) As String
        Return String.Format("{0} ? {0}->str : 0, {0} ? (int){0}->length : 0", var)
    End Function

    Public Overrides Function NativeUnwrapExpression(var As String) As String
        Return "&" & var
    End Function

    Public Overrides Function PublicWrapExpression(var As String) As String
        Return String.Format("{0}_str == IntPtr.Zero ? null : System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length)", var)
    End Function

    Public Overrides Function PublicUnwrapExpression(var As String) As String
        Return String.Format("{0}_pinned.Obj.PinnedPtr, {0}_pinned.Length", var)
    End Function

    Public Overrides Function PublicEventConstructorCall(var As String) As String
        Return String.Format("{0}_str, {0}_length", var)
    End Function

    Public Overrides Function PInvokeOutArgument(var As String) As String
        Return String.Format("out {0}_str, out {0}_length", var)
    End Function

    Public Overrides Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("cef_string_t {0} = {{ {0}_str, {0}_length, 0 }};", var)
    End Sub


    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var))
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0}_pinned.Obj.Free();", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0} = StringFunctions.PtrToStringUni(m_{0}_str, m_{0}_length);", var)
        b.AppendLine("return m_{0};", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal IntPtr m_{0}_str;", var)
        b.AppendLine("internal int m_{0}_length;", var)
        b.AppendLine("internal string m_{0};", var)
    End Sub

    Public Overrides Sub EmitPublicEventCtorStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0}_str = {0}_str;", var)
        b.AppendLine("m_{0}_length = {0}_length;", var)
    End Sub

    Public Overrides ReadOnly Property IsCefStringPtrTypeConst As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property AsCefStringPtrTypeConst As CefStringPtrTypeConst
        Get
            Return Me
        End Get
    End Property


End Class
