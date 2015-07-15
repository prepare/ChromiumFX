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



Public Class CefStructPtrType
    Inherits ApiType

    Public ReadOnly Struct As CefStructType
    Public ReadOnly Indirection As String

    Public Sub New(struct As CefStructType, Indirection As String)
        MyBase.New(AddIndirection(struct.Name, Indirection))
        Me.Struct = struct
        Me.Indirection = Indirection
    End Sub

    Public Overrides ReadOnly Property OriginalSymbol As String
        Get
            Return AddIndirection(Struct.OriginalSymbol, Indirection)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return Struct.ClassName
        End Get
    End Property

    Public Overrides ReadOnly Property ProxySymbol As String
        Get
            Return "ulong"
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteSymbol As String
        Get
            Return Struct.RemoteClassName
        End Get
    End Property

    Public Overrides Function PublicWrapExpression(var As String) As String
        Return String.Format("{0}.Wrap({1})", Struct.ClassName, var)
    End Function

    Public Overrides Function PublicUnwrapExpression(var As String) As String
        Return String.Format("{0}.Unwrap({1})", Struct.ClassName, CSharp.Escape(var))
    End Function

    Public Overrides Function ProxyUnwrapExpression(var As String) As String
        Return String.Format("({0})RemoteProxy.Unwrap({1})", Struct.ClassName, CSharp.Escape(var))
    End Function

    Public Overrides Function ProxyWrapExpression(var As String) As String
        Return String.Format("RemoteProxy.Wrap({0})", CSharp.Escape(var))
    End Function

    Public Overrides Function RemoteUnwrapExpression(var As String) As String
        Return String.Format("CfrObject.Unwrap({0})", CSharp.Escape(var))
    End Function

    Public Overrides Function RemoteWrapExpression(var As String) As String
        Return String.Format("{0}.Wrap({1}, remoteRuntime)", RemoteSymbol, var)
    End Function

    Public Overrides Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
        If Struct.ClassBuilder.IsRefCounted AndAlso var <> "self" Then
            b.AppendLine("if({0}) ((cef_base_t*){0})->add_ref((cef_base_t*){0});", var)
        End If
    End Sub

    Public Overrides Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("if(m_{0}_wrapped == null) m_{0}_wrapped = {1};", var, PublicWrapExpression("m_" & var))
        b.AppendLine("return m_{0}_wrapped;", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        MyBase.EmitPublicEventArgFields(b, var)
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var)
    End Sub

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return "IntPtr"
        End Get
    End Property

    Public Overrides ReadOnly Property IsCefStructPtrType As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property AsCefStructPtrType As CefStructPtrType
        Get
            Return Me
        End Get
    End Property

    Public Overrides ReadOnly Property ParserMatches As String()
        Get
            Return {Struct.ParserMatches(0) & Indirection, Struct.ParserMatches(1) & Indirection}
        End Get
    End Property

End Class
