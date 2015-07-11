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



Public Class CefStructOutType
    Inherits CefStructPtrPtrType

    Public Sub New(structPtr As CefStructPtrType, Indirection As String)
        MyBase.New(structPtr, Indirection)
    End Sub

    Public Overrides ReadOnly Property IsOut As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property IsIn As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return StructPtr.PublicSymbol
        End Get
    End Property

    Public Overrides ReadOnly Property ProxySymbol As String
        Get
            Return StructPtr.ProxySymbol
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteSymbol As String
        Get
            Return StructPtr.RemoteSymbol
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeCallSignature(var As String) As String
        Get
            Return "out IntPtr " & var
        End Get
    End Property

    Public Overrides ReadOnly Property PublicCallSignature(var As String) As String
        Get
            Return "out " & StructPtr.PublicCallSignature(var)
        End Get
    End Property


    Public Overrides ReadOnly Property ProxyCallSignature(var As String) As String
        Get
            Return "out " & StructPtr.ProxyCallSignature(var)
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteCallSignature(var As String) As String
        Get
            Return "out " & StructPtr.RemoteCallSignature(var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            Return String.Format("out {0}_ptr", var)
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyUnwrapExpression(var As String) As String
        Get
            Return String.Format("out {0}_local", var)
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteUnwrapExpression(var As String) As String
        Get
            Return String.Format("{0}.Unwrap({1})", Struct.RemoteClassName, var)
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteWrapExpression(var As String) As String
        Get
            Return String.Format("{0}.Wrap({1}, remoteRuntime)", Struct.RemoteClassName, var)
        End Get
    End Property

    Public Overrides ReadOnly Property PublicEventConstructorSignature(var As String) As String
        Get
            Return Nothing
        End Get
    End Property

    Public Overrides ReadOnly Property PublicEventConstructorCall(var As String) As String
        Get
            Return Nothing
        End Get
    End Property

    Public Overrides Sub EmitPostNativeCallbackStatements(b As CodeBuilder, var As String)
        b.AppendLine("if(*{0})((cef_base_t*)*{0})->add_ref((cef_base_t*)*{0});", var)
    End Sub

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("IntPtr {0}_ptr;", var)
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} = {1};", var, StructPtr.PublicWrapExpression(var & "_ptr"))
    End Sub

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal {0} m_{1}_wrapped;", PublicSymbol, var)
    End Sub

    Public Overrides Sub EmitPostPublicRaiseEventStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} = {1};", var, StructPtr.PublicUnwrapExpression(String.Concat("e.m_", var, "_wrapped")))
    End Sub

    Public Overrides Sub EmitPublicEventArgSetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0}_wrapped = value;", var)
    End Sub

    Public Overrides Sub EmitProxyEventArgSetter(b As CodeBuilder, var As String)
        b.AppendLine("e.{0} = {1};", var, StructPtr.ProxyUnwrapExpression("value"))
    End Sub

    Public Overrides Sub EmitPreProxyCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} {1}_local;", Struct.ClassName, var)
    End Sub

    Public Overrides Sub EmitPostProxyCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} = {1};", var, StructPtr.ProxyWrapExpression(var & "_local"))
    End Sub

End Class
