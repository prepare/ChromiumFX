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



Public Class CefStructType
    Inherits CefType

    Public ApiIndex As Integer

    Private m_classBuilder As CfxClassBuilder

    Public Sub New(name As String, comments As CommentData)
        MyBase.New(name)
    End Sub

    Public Sub SetMembers(sd As Parser.StructData, api As ApiTypeBuilder)
        m_classBuilder = New CfxClassBuilder(Me, sd, api)
    End Sub

    Public ReadOnly Property ClassBuilder As CfxClassBuilder
        Get
            Return m_classBuilder
        End Get
    End Property


    Public ReadOnly Property CfxNativeSymbol As String
        Get
            Return CfxName & "_t"
        End Get
    End Property

    Public ReadOnly Property RemoteClassName As String
        Get
            Return "Cfr" & CSharp.ApplyStyle(Name.Substring(4))
        End Get
    End Property




    Public Overrides ReadOnly Property OriginalSymbol As String
        Get
            Return Name & "_t"
        End Get
    End Property

    Public Overrides ReadOnly Property NativeSymbol As String
        Get
            Return OriginalSymbol & "*"
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return "IntPtr"
        End Get
    End Property

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return ClassName
        End Get
    End Property

    Public Overrides ReadOnly Property ProxySymbol As String
        Get
            Return "ulong"
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteSymbol As String
        Get
            Return RemoteClassName
        End Get
    End Property

    Public Overrides Sub EmitNativeReturnStatements(b As CodeBuilder, functionCall As String, postCallStatements As CodeBuilder)
        b.AppendLine("{0} __retval_tmp = {1};", OriginalSymbol, functionCall)
        If postCallStatements.IsNotEmpty Then
            b.AppendLine("{0} *__retval = ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol)
            b.AppendBuilder(postCallStatements)
            b.AppendLine("return __retval;")
        Else
            b.AppendLine("return ({0}*)cfx_copy_structure(&__retval_tmp, sizeof({0}));", OriginalSymbol)
        End If

    End Sub

    Public Overrides Function NativeWrapExpression(var As String) As String
        Return String.Format("&({0})", var)
    End Function

    Public Overrides Function NativeUnwrapExpression(var As String) As String
        Return String.Format("*({0})", var)
    End Function

    Public Overrides Function PublicReturnExpression(var As String) As String
        Return String.Format("{0}.WrapOwned({1})", ClassName, var)
        Return MyBase.PublicReturnExpression(var)
    End Function


    Public Overrides Function PublicWrapExpression(var As String) As String
        Return String.Format("{0}.Wrap({1})", ClassName, var)
    End Function

    Public Overrides Function PublicUnwrapExpression(var As String) As String
        Return String.Format("{0}.Unwrap({1})", ClassName, var)
    End Function

    Public Overrides Function ProxyWrapExpression(var As String) As String
        Return String.Format("RemoteProxy.Wrap({0})", var)
    End Function

    Public Overrides Function ProxyUnwrapExpression(var As String) As String
        Return String.Format("({0})RemoteProxy.Unwrap({1})", ClassName, var)
    End Function

    Public Overrides Function RemoteWrapExpression(var As String) As String
        Return String.Format("{0}.Wrap({1}, remoteRuntime)", RemoteClassName, var)
    End Function

    Public Overrides Function RemoteUnwrapExpression(var As String) As String
        Return String.Format("{0}.Unwrap({1})", RemoteClassName, var)
    End Function

    Public Overrides ReadOnly Property ParserMatches As String()
        Get
            Return New String() {OriginalSymbol, "struct _" & OriginalSymbol}
        End Get
    End Property



    Public Overrides ReadOnly Property IsCefStructType As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property AsCefStructType As CefStructType
        Get
            Return Me
        End Get
    End Property

End Class
