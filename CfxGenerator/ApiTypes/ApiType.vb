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



Public Class ApiType

    Public Class Comparer
        Implements IComparer(Of ApiType)
        Public Function Compare(x As ApiType, y As ApiType) As Integer Implements System.Collections.Generic.IComparer(Of ApiType).Compare
            Return String.Compare(x.Name, y.Name)
        End Function
    End Class

    Protected Shared Function AddIndirection(typeName As String, indirection As String) As String
        If indirection.StartsWith("*") Then
            Return typeName & indirection
        Else
            Return typeName & " " & indirection
        End If
    End Function


    Public ReadOnly Name As String

    Sub New(name As String)
        Me.Name = name
    End Sub

    Public Overridable ReadOnly Property IsOut As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overridable ReadOnly Property IsIn As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overridable ReadOnly Property ParserMatches As String()
        Get
            Return {OriginalSymbol}
        End Get
    End Property


    Public Overridable ReadOnly Property OriginalSymbol As String
        Get
            Return Name
        End Get
    End Property

    Public Overridable ReadOnly Property NativeSymbol As String
        Get
            Return OriginalSymbol
        End Get
    End Property


    Public Overridable ReadOnly Property PInvokeSymbol As String
        Get
            Return NativeSymbol
        End Get
    End Property

    Public Overridable ReadOnly Property PublicSymbol As String
        Get
            Return PInvokeSymbol
        End Get
    End Property

    Public Overridable ReadOnly Property ProxySymbol As String
        Get
            Return PublicSymbol
        End Get
    End Property

    Public Overridable ReadOnly Property RemoteSymbol As String
        Get
            If ProxySymbol = "IntPtr" Then
                Return "RemotePtr"
            Else
                Return ProxySymbol
            End If
        End Get
    End Property

    Public Overridable Function NativeCallSignature(var As String, isConst As Boolean) As String
        If NativeSymbol Is Nothing Then
            Return Nothing
        End If
        If isConst Then
            Return String.Concat("const ", NativeSymbol, " ", var)
        Else
            Return String.Concat(NativeSymbol, " ", var)
        End If
    End Function

    Public Overridable Function PInvokeCallSignature(var As String) As String
        If PInvokeSymbol Is Nothing Then Return Nothing
        Return String.Format("{0} {1}", PInvokeSymbol, CSharp.Escape(var))
    End Function

    Public Overridable Function NativeOutSignature(var As String) As String
        If NativeSymbol Is Nothing Then Return Nothing
        Return String.Concat(NativeSymbol, "* ", var)
    End Function



    Public Overridable Function PInvokeCallbackSignature(var As String) As String
        Return PInvokeCallSignature(var)
    End Function

    Public Overridable Function PublicEventConstructorSignature(var As String) As String
        Return PInvokeCallbackSignature(var)
    End Function

    Public Overridable Function PInvokeOutSignature(var As String) As String
        If PInvokeSymbol Is Nothing Then Return Nothing
        Return "out " & PInvokeCallSignature(var)
    End Function

    Public Overridable Function PInvokeOutArgument(var As String) As String
        Return "out " & CSharp.Escape(var)
    End Function

    Public Overridable Function PublicCallSignature(var As String) As String
        If PublicSymbol Is Nothing Then Return Nothing
        Return String.Format("{0} {1}", PublicSymbol, CSharp.Escape(var))
    End Function

    Public Overridable Function ProxyCallSignature(var As String) As String
        If ProxySymbol Is Nothing Then Return Nothing
        Return String.Format("{0} {1}", ProxySymbol, CSharp.Escape(var))
    End Function

    Public Overridable Function RemoteCallSignature(var As String) As String
        If RemoteSymbol Is Nothing Then Return Nothing
        Return String.Format("{0} {1}", RemoteSymbol, CSharp.Escape(var))
    End Function

    Public Overridable Function NativeWrapExpression(var As String) As String
        Return var
    End Function

    Public Overridable Function NativeUnwrapExpression(var As String) As String
        Return var
    End Function

    Public Overridable Function PublicReturnExpression(var As String) As String
        Return PublicWrapExpression(var)
    End Function

    Public Overridable Function PublicWrapExpression(var As String) As String
        Return CSharp.Escape(var)
    End Function

    Public Overridable Function PublicUnwrapExpression(var As String) As String
        Return CSharp.Escape(var)
    End Function

    Public Overridable Function ProxyWrapExpression(var As String) As String
        Return CSharp.Escape(var)
    End Function

    Public Overridable Function ProxyUnwrapExpression(var As String) As String
        Return CSharp.Escape(var)
    End Function

    Public Overridable Function RemoteWrapExpression(var As String) As String
        If RemoteSymbol = "RemotePtr" Then
            Return String.Format("new RemotePtr({0})", CSharp.Escape(var))
        Else
            Return CSharp.Escape(var)
        End If
    End Function

    Public Overridable Function RemoteUnwrapExpression(var As String) As String
        If ProxySymbol Is Nothing Then Return Nothing
        If RemoteSymbol = "RemotePtr" Then
            Return CSharp.Escape(var) & ".ptr"
        Else
            Return CSharp.Escape(var)
        End If
    End Function

    Public Overridable Function PublicEventConstructorCall(var As String) As String
        Return CSharp.Escape(var)
    End Function


    Public Overridable Sub EmitPreNativeCallbackStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPostNativeCallbackStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPostNativeCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitNativeReturnStatements(b As CodeBuilder, functionCall As String, postCallStatements As CodeBuilder)

        If IsVoid Then
            b.AppendLine("{0};", NativeWrapExpression(functionCall))
            b.AppendBuilder(postCallStatements)
            Return
        End If

        If postCallStatements.IsNotEmpty Then
            b.AppendLine("{0} __ret_val_ = {1};", NativeSymbol, NativeWrapExpression(functionCall))
            b.AppendBuilder(postCallStatements)
            b.AppendLine("return __ret_val_;")
        Else
            b.AppendLine("return {0};", NativeWrapExpression(functionCall))
        End If
    End Sub


    Public Overridable Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPreProxyCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPostProxyCallStatements(b As CodeBuilder, var As String)
    End Sub

    Public Overridable Sub EmitPreRemoteCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("call.{0} = {1};", If(var = "this", "self", CSharp.Escape(var)), RemoteUnwrapExpression(var))
    End Sub

    Public Overridable Sub EmitPostRemoteCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} = {1};", var, RemoteWrapExpression("call." & If(var = "this", "self", CSharp.Escape(var))))
    End Sub

    ''' <summary>
    ''' Called if IsIn is true.
    ''' </summary>
    Public Overridable Sub EmitPublicEventCtorStatements(b As CodeBuilder, var As String)
        If IsIn Then
            b.AppendLine("m_{0} = {1};", var, CSharp.Escape(var))
        End If
    End Sub

    ''' <summary>
    ''' Called if IsIn is true.
    ''' </summary>
    Public Overridable Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("return {0};", PublicWrapExpression("m_" & var))
    End Sub

    ''' <summary>
    ''' Called if IsOut is true.
    ''' </summary>
    Public Overridable Sub EmitPublicEventArgSetterStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0} = {1};", var, PublicUnwrapExpression("value"))
    End Sub

    Public Overridable Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal {0} m_{1};", PInvokeSymbol, var)
    End Sub

    Public Overridable Sub EmitPostPublicRaiseEventStatements(b As CodeBuilder, var As String)
        If Me.IsOut Then
            b.AppendLine("{0} = e.m_{0};", var)
        End If
    End Sub

    Public Sub EmitRemoteCallFields(b As CodeBuilder, var As String)
        b.AppendLine("internal {0} {1};", ProxySymbol, var)
    End Sub

    Public Overridable Sub EmitRemoteWrite(b As CodeBuilder, var As String)
        b.AppendLine("h.Write({0});", var)
    End Sub

    Public Overridable Sub EmitRemoteRead(b As CodeBuilder, var As String)
        b.AppendLine("h.Read(out {0});", var)
    End Sub


    Public Overridable Sub EmitProxyEventArgSetter(b As CodeBuilder, var As String)
        b.AppendLine("e.{0} = {1};", var, ProxyUnwrapExpression("value"))
    End Sub

    Public Overridable Sub EmitValueStructGetterVars(b As CodeBuilder, var As String)
        b.AppendLine("{0} {1};", PInvokeSymbol, CSharp.Escape(var))
    End Sub

    Public Overridable Sub EmitAssignToNativeStructMember(b As CodeBuilder, var As String, Optional struct As String = "self")
        b.AppendLine("{0}->{1} = {2};", struct, var, NativeUnwrapExpression(var))
    End Sub

    Public Overridable Sub EmitAssignFromNativeStructMember(b As CodeBuilder, var As String, Optional struct As String = "self")
        b.AppendLine("*{0} = {1};", var, NativeWrapExpression(String.Format("{0}->{1}", struct, var)))
    End Sub

    Public Overridable Sub EmitNativeValueStructDtorStatements(b As CodeBuilder, var As String)
    End Sub

    Public ReadOnly Property IsVoid As Boolean
        Get
            Return Name = "void"
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStructType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStructType As CefStructType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefPlatformStructType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefPlatformStructType As CefPlatformStructType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStringType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStringType As CefStringType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefEnumType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefEnumType As CefEnumType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStructPtrType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStructPtrType As CefStructPtrType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStructPtrPtrType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStructPtrPtrType As CefStructPtrPtrType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStringPtrTypeConst As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStringPtrTypeConst As CefStringPtrTypeConst
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefStringPtrType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefStringPtrType As CefStringPtrType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsCefCallbackType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsCefCallbackType As CefCallbackType
        Get
            Throw New Exception
        End Get
    End Property

    Public Overridable ReadOnly Property IsBlittableType As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property AsBlittableType As BlittableType
        Get
            Throw New Exception
        End Get
    End Property
    Public Overridable ReadOnly Property IsStringCollectionType As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return OriginalSymbol
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return TypeOf obj Is ApiType AndAlso Me.Name.Equals(DirectCast(obj, ApiType).Name)
    End Function

End Class
