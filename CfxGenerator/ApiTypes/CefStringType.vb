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



Public Class CefStringType
    Inherits SpecialType
    Public Sub New()
        MyBase.New("cef_string_t")
    End Sub

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return "string"
        End Get
    End Property

    Public Overrides ReadOnly Property NativeCallSignature(var As String, isConst As Boolean) As String
        Get
            Return String.Format("char16 *{0}_str, int {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property NativeOutSignature(var As String) As String
        Get
            Return String.Format("char16 **{0}_str, int *{0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeCallSignature(var As String) As String
        Get
            Return String.Format("IntPtr {0}_str, int {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeOutSignature(var As String) As String
        Get
            Return String.Format("out IntPtr {0}_str, out int {0}_length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicWrapExpression(var As String) As String
        Get
            Return String.Format("StringFunctions.PtrToStringUni({0}_str, {0}_length)", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            Return String.Format("{0}_pinned.Obj.PinnedPtr, {0}_pinned.Length", var)
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeOutArgument(var As String) As String
        Get
            Return String.Format("out {0}_str, out {0}_length", var)
        End Get
    End Property

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("var {0}_pinned = new PinnedString({1});", var, CSharp.Escape(var))
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0}_pinned.Obj.Free();", var)
    End Sub

    Public Overrides Sub EmitValueStructGetterVars(b As CodeBuilder, var As String)
        b.AppendLine("IntPtr {0}_str;", var)
        b.AppendLine("int {0}_length;", var)
    End Sub

    Public Overrides Sub EmitAssignToNativeStructMember(b As CodeBuilder, var As String, Optional struct As String = "self")
        b.AppendLine("cef_string_utf16_set({0}_str, {0}_length, &({1}->{0}), 1);", var, struct)
    End Sub

    Public Overrides Sub EmitAssignFromNativeStructMember(b As CodeBuilder, var As String, Optional struct As String = "self")
        b.AppendLine("*{0}_str = {1}->{0}.str;", var, struct)
        b.AppendLine("*{0}_length = (int){1}->{0}.length;", var, struct)
    End Sub

    Public Overrides Sub EmitNativeValueStructDtorStatements(b As CodeBuilder, var As String)
        b.AppendLine("if(self->{0}.dtor) self->{0}.dtor(self->{0}.str);", var)
    End Sub

    Public Overrides ReadOnly Property IsCefStringType As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property AsCefStringType As CefStringType
        Get
            Return Me
        End Get
    End Property

End Class
