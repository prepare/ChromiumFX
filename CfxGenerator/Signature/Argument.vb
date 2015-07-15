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



Public Class Argument

    Public ReadOnly ArgumentType As ApiType
    Public ReadOnly VarName As String
    Public ReadOnly Index As Integer
    Public ReadOnly IsConst As Boolean

    Public IsThisArgument As Boolean

    Public IsPropertySetterArgument As Boolean
    Public DoNotKeep As Boolean

    Public Sub New(ad As Parser.ArgumentData, api As ApiTypeBuilder, index As Integer)
        Me.ArgumentType = api.GetApiType(ad.ArgumentType, ad.IsConst)
        Me.VarName = ad.Var
        Me.Index = index
        Me.IsConst = ad.IsConst
        Me.IsThisArgument = Me.VarName.Equals("self")
    End Sub

    Public Sub New(replacedArg As Argument, newType As ApiType)
        Me.ArgumentType = newType
        Me.VarName = replacedArg.VarName
        Me.Index = replacedArg.Index
        Me.IsConst = replacedArg.IsConst
        Me.IsThisArgument = replacedArg.IsThisArgument
        Me.IsPropertySetterArgument = replacedArg.IsPropertySetterArgument
    End Sub

    Public ReadOnly Property TypeIsRefCounted As Boolean
        Get
            Return ArgumentType.IsCefStructPtrType AndAlso ArgumentType.AsCefStructPtrType.Struct.ClassBuilder.IsRefCounted
        End Get
    End Property

    Public ReadOnly Property PublicVarName As String
        Get
            If IsPropertySetterArgument Then
                Return "value"
            ElseIf IsThisArgument Then
                Return "this"
            Else
                Return CSharp.ApplyStyle(VarName, True)
            End If
        End Get
    End Property

    Public ReadOnly Property ProxyVarName As String
        Get
            Return If(IsThisArgument, "self", PublicVarName)
        End Get
    End Property

    Public ReadOnly Property PublicPropertyName As String
        Get
            Return CSharp.Escape(CSharp.ApplyStyle(VarName, False))
        End Get
    End Property

    Public ReadOnly Property NativeWrapExpression As String
        Get
            Return ArgumentType.NativeWrapExpression(VarName)
        End Get
    End Property

    Public ReadOnly Property NativeUnwrapExpression As String
        Get
            Return ArgumentType.NativeUnwrapExpression(VarName)
        End Get
    End Property

    Public ReadOnly Property PublicWrapExpression As String
        Get
            Return ArgumentType.PublicWrapExpression(PublicVarName)
        End Get
    End Property

    Public ReadOnly Property PublicUnwrapExpression As String
        Get
            If IsThisArgument Then Return "NativePtr"
            Return ArgumentType.PublicUnwrapExpression(PublicVarName)
        End Get
    End Property

    Public ReadOnly Property ProxyUnwrapExpression As String
        Get
            If IsThisArgument Then Return Nothing
            Return ArgumentType.ProxyUnwrapExpression(PublicVarName)
        End Get
    End Property

    Public ReadOnly Property RemoteUnwrapExpression As String
        Get
            If IsThisArgument Then Return "remotePtr"
            Return ArgumentType.RemoteUnwrapExpression(CSharp.Escape(PublicVarName))
        End Get
    End Property

    Public ReadOnly Property PublicEventConstructorCall As String
        Get
            Return ArgumentType.PublicEventConstructorCall(VarName)
        End Get
    End Property

    Public ReadOnly Property OriginalSignature As String
        Get
            If IsConst Then
                Return String.Concat("const ", ArgumentType.OriginalSymbol, " ", VarName)
            Else
                Return String.Concat(ArgumentType.OriginalSymbol, " ", VarName)
            End If
        End Get
    End Property

    Public ReadOnly Property NativeCallSignature As String
        Get
            Return ArgumentType.NativeCallSignature(VarName, IsConst)
        End Get
    End Property

    Public ReadOnly Property PInvokeCallSignature As String
        Get
            Return ArgumentType.PInvokeCallSignature(VarName)
        End Get
    End Property

    Public ReadOnly Property PInvokeCallbackSignature As String
        Get
            Return ArgumentType.PInvokeCallbackSignature(VarName)
        End Get
    End Property

    Public ReadOnly Property PublicEventConstructorSignature As String
        Get
            Return ArgumentType.PublicEventConstructorSignature(VarName)
        End Get
    End Property

    Public Overridable ReadOnly Property PublicSignature As String
        Get
            If IsThisArgument Then Return Nothing
            Return ArgumentType.PublicCallSignature(PublicVarName)
        End Get
    End Property

    Public ReadOnly Property RemoteSignature As String
        Get
            If IsThisArgument Then Return Nothing
            Return ArgumentType.RemoteCallSignature(PublicVarName)
        End Get
    End Property

    Public Sub EmitPreNativeCallStatements(b As CodeBuilder)
        ArgumentType.EmitPreNativeCallStatements(b, VarName)
    End Sub

    Public Sub EmitPostNativeCallStatements(b As CodeBuilder)
        ArgumentType.EmitPostNativeCallStatements(b, VarName)
    End Sub

    Public Sub EmitPreNativeCallbackStatements(b As CodeBuilder)
        ArgumentType.EmitPreNativeCallbackStatements(b, VarName)
    End Sub

    Public Sub EmitPostNativeCallbackStatements(b As CodeBuilder)
        ArgumentType.EmitPostNativeCallbackStatements(b, VarName)
    End Sub

    Public Sub EmitPrePublicCallStatements(b As CodeBuilder)
        ArgumentType.EmitPrePublicCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPostPublicStatements(b As CodeBuilder)
        ArgumentType.EmitPostPublicCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPreProxyCallStatements(b As CodeBuilder)
        ArgumentType.EmitPreProxyCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPostProxyCallStatements(b As CodeBuilder)
        ArgumentType.EmitPostProxyCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPreRemoteCallStatements(b As CodeBuilder)
        ArgumentType.EmitPreRemoteCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPostRemoteCallStatements(b As CodeBuilder)
        ArgumentType.EmitPostRemoteCallStatements(b, PublicVarName)
    End Sub

    Public Sub EmitPublicEventCtorStatements(b As CodeBuilder)
        ArgumentType.EmitPublicEventCtorStatements(b, VarName)
    End Sub

    Public Sub EmitPublicEventArgGetterStatements(b As CodeBuilder)
        ArgumentType.EmitPublicEventArgGetterStatements(b, VarName)
    End Sub

    Public Sub EmitPublicEventArgSetterStatements(b As CodeBuilder)
        ArgumentType.EmitPublicEventArgSetterStatements(b, VarName)
    End Sub

    Public Sub EmitPublicEventArgFields(b As CodeBuilder)
        ArgumentType.EmitPublicEventArgFields(b, VarName)
    End Sub

    Public Sub EmitPostPublicRaiseEventStatements(b As CodeBuilder)
        ArgumentType.EmitPostPublicRaiseEventStatements(b, VarName)
    End Sub

    Public Overridable Sub EmitRemoteCallFields(b As CodeBuilder)
        ArgumentType.EmitRemoteCallFields(b, CSharp.Escape(ProxyVarName))
    End Sub

    Public Sub EmitRemoteWrite(b As CodeBuilder)
        ArgumentType.EmitRemoteWrite(b, CSharp.Escape(ProxyVarName))
    End Sub

    Public Sub EmitRemoteRead(b As CodeBuilder)
        ArgumentType.EmitRemoteRead(b, CSharp.Escape(ProxyVarName))
    End Sub

    Public Sub EmitProxyEventArgSetter(b As CodeBuilder)
        ArgumentType.EmitProxyEventArgSetter(b, PublicPropertyName)
    End Sub

    Public Overrides Function ToString() As String
        If IsConst Then
            Return String.Format("const {0} {1}", ArgumentType.OriginalSymbol, VarName)
        Else
            Return String.Format("{0} {1}", ArgumentType.OriginalSymbol, VarName)
        End If
    End Function

End Class
