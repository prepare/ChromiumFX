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



Public Class CefStringPtrType
    Inherits ApiType

    Public Sub New(baseType As CefStringType)
        MyBase.New(baseType.Name & "*")
    End Sub

    Public Overrides ReadOnly Property IsOut As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return "string"
        End Get
    End Property

    Public Overrides ReadOnly Property NativeCallSignature(var As String, isConst As Boolean) As String
        Get
            Return String.Format("char16 **{0}_str, int *{0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeCallSignature(var As String) As String
        Get
            Return String.Format("ref IntPtr {0}_str, ref int {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicCallSignature(var As String) As String
        Get
            Return String.Format("ref string {0}", var)
        End Get
    End Property

    Public Overrides ReadOnly Property NativeWrapExpression(var As String) As String
        Get
            Return String.Format("&({0}_tmp_str), &({0}_tmp_length)", var)
        End Get
    End Property

    Public Overrides ReadOnly Property NativeUnwrapExpression(var As String) As String
        Get
            Return "&" & var
        End Get
    End Property

    Public Overrides ReadOnly Property PublicWrapExpression(var As String) As String
        Get
            Return String.Format("System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length)", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            Return String.Format("ref {0}_str, ref {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyUnwrapExpression(var As String) As String
        Get
            Return String.Format("ref {0}", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicEventConstructorSignature(var As String) As String
        Get
            Return String.Format("IntPtr {0}_str, int {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicEventConstructorCall(var As String) As String
        Get
            Return String.Format("{0}_str, {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeOutArgument(var As String) As String
        Get
            Return String.Format("out {0}_str, out {0}_length", var)
        End Get
    End Property

    Public Overrides Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("cef_string_t {0} = {{ *{0}_str, *{0}_length, 0 }};", var)
    End Sub

    Public Overrides Sub EmitPostNativeCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("*{0}_str = {0}.str; *{0}_length = (int){0}.length;", var)
    End Sub

    Public Overrides Sub EmitPreNativeCallbackStatements(b As CodeBuilder, var As String)
        b.AppendLine("char16* {0}_tmp_str = {0}->str; int {0}_tmp_length = (int){0}->length;", var)
    End Sub

    Public Overrides Sub EmitPostNativeCallbackStatements(b As CodeBuilder, var As String)
        b.BeginBlock("if({0}_tmp_str != {0}->str)", var)
        b.AppendLine("if({0}->dtor) {0}->dtor({0}->str);", var)
        b.AppendLine("cef_string_set({0}_tmp_str, {0}_tmp_length, {0}, 1);", var)
        b.AppendLine("cfx_gc_handle_free((gc_handle_t){0}_tmp_str);", var)
        b.EndBlock()
    End Sub

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var))
        b.AppendLine("IntPtr {0}_str = {0}_pinned.Obj.PinnedPtr;", var)
        b.AppendLine("int {0}_length = {0}_pinned.Length;", var)
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.BeginBlock("if({0}_str != {0}_pinned.Obj.PinnedPtr)", var)
        b.AppendLine("{0} = System.Runtime.InteropServices.Marshal.PtrToStringUni({0}_str, {0}_length);", var)
        b.EndBlock()
        b.AppendLine("{0}_pinned.Obj.Free();", var)
    End Sub


    Public Overrides Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)
        b.BeginIf("!m_{0}_changed && m_{0}_wrapped == null", var)
        b.AppendLine("m_{0}_wrapped = StringFunctions.PtrToStringUni(m_{0}_str, m_{0}_length);", var)
        b.EndBlock()
        b.AppendLine("return m_{0}_wrapped;", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgSetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0}_wrapped = value;", var)
        b.AppendLine("m_{0}_changed = true;", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal IntPtr m_{0}_str;", var)
        b.AppendLine("internal int m_{0}_length;", var)
        b.AppendLine("internal string m_{0}_wrapped;", var)
        b.AppendLine("internal bool m_{0}_changed;", var)
    End Sub

    Public Overrides Sub EmitPublicEventCtorStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0}_str = {0}_str;", var)
        b.AppendLine("m_{0}_length = {0}_length;", var)
    End Sub

    Public Overrides Sub EmitPostPublicRaiseEventStatements(b As CodeBuilder, var As String)
        b.BeginIf("e.m_{0}_changed", var)
        b.AppendLine("var {0}_pinned = new PinnedString(e.m_{0}_wrapped);", var)
        b.AppendLine("{0}_str = {0}_pinned.Obj.PinnedPtr;", var)
        b.AppendLine("{0}_length = {0}_pinned.Length;", var)
        b.EndBlock()
    End Sub


    Public Overrides Sub EmitProxyEventArgSetter(b As CodeBuilder, var As String)
        b.AppendLine("e.{0} = value;", var)
    End Sub

    Public Overrides ReadOnly Property IsCefStringPtrType As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property AsCefStringPtrType As CefStringPtrType
        Get
            Return Me
        End Get
    End Property

End Class
