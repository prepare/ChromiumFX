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



Public Class CefCallbackType
    Inherits ApiType
    Implements ISignatureParent

    Public ReadOnly Signature As Signature
    Public ReadOnly Parent As CefStructType
    Public ReadOnly Comments As CommentData

    Public PropertyName As String

    Private m_callMode As CfxCallMode

    Private Shared setReturnValueComments As CommentData

    Shared Sub New()
        setReturnValueComments = New CommentData
        setReturnValueComments.Lines = {
            "Sets the return value for the underlying CEF framework callback.",
            "Applications may attach more than one event handler to a framework callback event,",
            "but only one event handler can set the return value. Calling SetReturnValue()",
            "more then once will cause an exception to be thrown."
            }
    End Sub

    Public Sub New(parent As CefStructType, structCategory As StructCategory, name As String, sd As Parser.SignatureData, api As ApiTypeBuilder, comments As CommentData)
        MyBase.New(name)
        Me.Parent = parent
        Me.Comments = comments
        If structCategory = structCategory.ApiCallbacks Then
            m_callMode = CfxCallMode.Callback
        Else
            m_callMode = CfxCallMode.FunctionCall
        End If
        Me.Signature = Signature.Create(Me, sd, api)
    End Sub

    Public ReadOnly Property NativeReturnType As ApiType
        Get
            Return Signature.ReturnType
        End Get
    End Property

    Public ReadOnly Property PublicReturnType As ApiType
        Get
            Return Signature.PublicReturnType
        End Get
    End Property

    Public ReadOnly Property RemoteReturnType As ApiType
        Get
            Return Signature.RemoteReturnType
        End Get
    End Property

    Public ReadOnly Property PublicName() As String
        Get
            Static _name As String = CSharp.ApplyStyle(Name)
            Return _name
        End Get
    End Property

    Public Function IsPropertyGetter(ByRef isBoolean As Boolean) As Boolean
        Dim retval = IsPropertyGetterPrivate(isBoolean)
        If retval Then m_callMode = CfxCallMode.PropertyGetter
        Return retval
    End Function

    Private Function IsPropertyGetterPrivate(ByRef isBoolean As Boolean) As Boolean

        If Signature.PublicReturnType.IsVoid Then Return False
        If Signature.ManagedArguments.Length <> 1 Then Return False

        If Name.StartsWith("has_") Then isBoolean = True : Return True
        If Name.StartsWith("is_") Then isBoolean = True : Return True
        If Name.StartsWith("can_") Then isBoolean = True : Return True

        If Name.StartsWith("get_") Then
            If Signature.PublicReturnType.Name = "cef_string_userfree_t" Then
                If Name = "get_error" Then
                    Return False
                End If
            End If
            Return True
        End If

        Return False
    End Function

    Public Function IsPropertySetterFor(getter As CefCallbackType) As Boolean
        Dim retval = IsPropertySetterForPrivate(getter)
        If retval Then m_callMode = CfxCallMode.PropertySetter
        Return retval
    End Function

    Public Function IsPropertySetterForPrivate(getter As CefCallbackType) As Boolean
        If Not Signature.PublicReturnType.IsVoid Then Return False
        If Not Signature.ManagedArguments.Count = 2 Then Return False
        If Not Signature.ManagedArguments(1).ArgumentType.Equals(getter.Signature.PublicReturnType) Then
            If Not (getter.Signature.PublicReturnType.Name = "cef_string_userfree_t" AndAlso Signature.ManagedArguments(1).ArgumentType.IsCefStringPtrTypeConst) Then Return False
        End If
        If Not Name.Substring(1).Equals(getter.Name.Substring(1)) Then Return False
        Return True
    End Function

    Public ReadOnly Property IsBasicEvent() As Boolean
        Get
            Return Signature.ManagedArguments.Length = 1 AndAlso Signature.PublicReturnType.IsVoid
        End Get
    End Property

    Public ReadOnly Property NativeCallbackName() As String
        Get
            Return String.Concat(Parent.CfxName, "_", Name)
        End Get
    End Property

    Public ReadOnly Property EventName() As String
        Get
            If Parent.ClassBuilder.StructMembers.Length = 2 Then
                Return Parent.ClassName & PublicName
            ElseIf PublicName = "GetAuthCredentials" Then
                Return Parent.ClassName & PublicName
            ElseIf PublicName.Length < 4 Then
                Return Parent.ClassName & PublicName
            Else
                Return "Cfx" & PublicName
            End If
        End Get
    End Property

    Public ReadOnly Property EventHandlerName() As String
        Get
            If IsBasicEvent Then Return "CfxEventHandler"
            Return EventName & "EventHandler"
        End Get
    End Property

    Public ReadOnly Property RemoteEventHandlerName() As String
        Get
            Return "Cfr" & EventHandlerName.Substring(3)
        End Get
    End Property

    Public ReadOnly Property ProxyEventHandlerName() As String
        Get
            Return RemoteEventHandlerName & "Proxy"
        End Get
    End Property

    Public ReadOnly Property PublicEventArgsClassName() As String
        Get
            If IsBasicEvent Then Return "CfxEventArgs"
            Return EventName & "EventArgs"
        End Get
    End Property

    Public ReadOnly Property RemoteEventArgsClassName() As String
        Get
            Return "Cfr" & PublicEventArgsClassName.Substring(3)
        End Get
    End Property

    Public ReadOnly Property ProxyEventArgsClassName() As String
        Get
            Return RemoteEventArgsClassName & "Proxy"
        End Get
    End Property

    Public Sub EmitPublicFunction(b As CodeBuilder)
        If GeneratorConfig.HasPrivateWrapper(Parent.Name & "::" & Name) Then
            b.BeginFunction(Signature.PublicSignature(PublicName), "private")
        Else
            b.BeginFunction(Signature.PublicSignature(PublicName))
        End If
        Signature.EmitPublicCall(b)
        b.EndBlock()
    End Sub

    Public Sub EmitPublicProperty(b As CodeBuilder, setter As CefCallbackType)

        Dim propertyName = Me.PublicName
        If Name.StartsWith("get_") Then
            propertyName = propertyName.Substring(3)
        End If

        propertyName = CSharp.Escape(propertyName)

        b.BeginBlock("public {0} {1}", PublicReturnType.PublicSymbol, propertyName)

        b.BeginBlock("get")
        Signature.EmitPublicCall(b)
        b.EndBlock()
        If setter IsNot Nothing Then
            b.BeginBlock("set", PublicReturnType.PublicSymbol)
            setter.Signature.EmitPublicCall(b)
            b.EndBlock()
        End If
        b.EndBlock()
    End Sub

    Private Shared emittedHandlers As New Dictionary(Of String, CommentData)

    Public Sub EmitPublicEventArgsAndHandler(b As CodeBuilder, comments As CommentData)

        If emittedHandlers.ContainsKey(EventName) Then
            Dim c0 = emittedHandlers(EventName)
            If c0 IsNot Nothing Then
                If c0.Lines.Length <> comments.Lines.Length Then
                    Stop
                End If
                For i = 0 To c0.Lines.Length - 1
                    If c0.Lines(i) <> comments.Lines(i) Then
                        ' two handlers use same event but with different comments
                        Stop
                    End If
                Next
            End If
            Return
        End If
        emittedHandlers.Add(EventName, comments)

        If IsBasicEvent Then Return

        b.AppendSummaryAndRemarks(comments, False, True)
        b.AppendLine("public delegate void {0}(object sender, {1} e);", EventHandlerName, PublicEventArgsClassName)
        b.AppendLine()

        b.AppendSummaryAndRemarks(comments, False, True)
        b.BeginClass(PublicEventArgsClassName & " : CfxEventArgs", GeneratorConfig.ClassModifiers(PublicEventArgsClassName))
        b.AppendLine()

        For i = 1 To Signature.ManagedArguments.Count - 1
            Signature.ManagedArguments(i).EmitPublicEventArgFields(b)
        Next
        b.AppendLine()

        If Not Signature.PublicReturnType.IsVoid Then
            b.AppendLine("internal {0} m_returnValue;", Signature.PublicReturnType.PublicSymbol)
            b.AppendLine("private bool returnValueSet;")
            b.AppendLine()
        End If

        b.BeginBlock("internal {0}({1})", PublicEventArgsClassName, Signature.PublicEventConstructorSignature)
        Signature.EmitPublicEventCtorStatements(b)
        b.EndBlock()
        b.AppendLine()

        Signature.EmitPublicEventArgProperties(b)

        If Not Signature.PublicReturnType.IsVoid Then
            setReturnValueComments.FileName = comments.FileName
            b.AppendSummaryAndRemarks(setReturnValueComments)
            b.BeginBlock("public void SetReturnValue({0} returnValue)", Signature.PublicReturnType.PublicSymbol)
            b.AppendLine("CheckAccess();")
            b.BeginIf("returnValueSet")
            b.AppendLine("throw new CfxException(""The return value has already been set"");")
            b.EndBlock()
            b.AppendLine("returnValueSet = true;")
            b.AppendLine("this.m_returnValue = returnValue;")
            b.EndBlock()
        End If

        If Signature.ManagedArguments.Count > 1 Then
            b.AppendLine()
            EmitEventToString(b)
        End If
        b.EndBlock()

    End Sub

    Private Sub EmitEventToString(b As CodeBuilder)

        b.BeginBlock("public override string ToString()")
        Dim format = New List(Of String)
        Dim vars = New List(Of String)
        For i = 1 To Signature.ManagedArguments.Count - 1
            Dim arg = Signature.ManagedArguments(i)
            If arg.ArgumentType.IsIn Then
                format.Add(String.Format("{0}={{{{{{{1}}}}}}}", arg.PublicPropertyName, i - 1))
                vars.Add(arg.PublicPropertyName)
            End If
        Next
        b.AppendLine("return String.Format(""{0}"", {1});", String.Join(", ", format.ToArray()), String.Join(", ", vars.ToArray()))
        b.EndBlock()
    End Sub



    'Public Sub EmitProxyEventArgsAndHandler(b As CodeBuilder)

    '    If IsBasicEvent Then Return

    '    b.AppendLine("internal delegate void {0}(object sender, {1} e);", ProxyEventHandlerName, ProxyEventArgsClassName)
    '    b.AppendLine()

    '    b.BeginBlock("internal class {0} : CfrEventArgsProxy", ProxyEventArgsClassName)
    '    b.AppendLine()

    '    b.AppendLine("private {0} localEventArgs;", PublicEventArgsClassName)
    '    b.AppendLine()

    '    b.BeginBlock("internal {0}({1} localEventArgs)", ProxyEventArgsClassName, PublicEventArgsClassName)
    '    b.AppendLine("this.localEventArgs = localEventArgs;")
    '    b.EndBlock()
    '    b.AppendLine()

    '    For i = 1 To Signature.PublicArguments.Count - 1
    '        Dim arg = Signature.PublicArguments(i)
    '        b.BeginBlock("public {1} {0}", arg.PublicPropertyName, arg.ArgumentType.ProxySymbol)
    '        b.BeginBlock("get")
    '        arg.EmitProxyEventArgGetterStatements(b)
    '        b.EndBlock()
    '        arg.EmitProxyEventArgSetter(b)
    '        b.EndBlock()
    '    Next
    '    If Not Signature.PublicReturnType.IsVoid Then
    '        b.BeginBlock("public void SetReturnValue({0} returnValue)", Signature.PublicReturnType.ProxySymbol)
    '        b.AppendLine("localEventArgs.SetReturnValue({0});", Signature.PublicReturnType.ProxyUnwrapExpression("returnValue"))
    '        b.EndBlock()
    '    End If
    '    b.EndBlock()

    'End Sub

    Public Sub EmitRemoteEventArgsAndHandler(b As CodeBuilder, comments As CommentData)


        If IsBasicEvent Then Return

        b.AppendSummaryAndRemarks(comments, True, True)
        b.AppendLine("public delegate void {0}(object sender, {1} e);", RemoteEventHandlerName, RemoteEventArgsClassName)
        b.AppendLine()

        b.AppendSummaryAndRemarks(comments, True, True)
        b.BeginClass(RemoteEventArgsClassName & " : CfrEventArgs", GeneratorConfig.ClassModifiers(RemoteEventArgsClassName))
        b.AppendLine()

        For i = 1 To Signature.ManagedArguments.Count - 1
            If Signature.ManagedArguments(i).ArgumentType.IsIn Then b.AppendLine("bool {0}Fetched;", Signature.ManagedArguments(i).PublicPropertyName)
            b.AppendLine("{0} m_{1};", Signature.ManagedArguments(i).ArgumentType.RemoteSymbol, Signature.ManagedArguments(i).PublicPropertyName)
        Next
        b.AppendLine()


        b.AppendLine("internal {0}(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {{}}", RemoteEventArgsClassName)
        b.AppendLine()

        For i = 1 To Signature.ManagedArguments.Count - 1
            Dim arg = Signature.ManagedArguments(i)
            b.BeginBlock("public {0} {1}", arg.ArgumentType.RemoteSymbol, arg.PublicPropertyName)
            b.BeginBlock("get")
            If arg.ArgumentType.IsIn Then
                b.BeginBlock("if(!{0}Fetched)", arg.PublicPropertyName)
                b.AppendLine("{0}Fetched = true;", arg.PublicPropertyName)
                b.AppendLine("var call = new {0}Get{1}RenderProcessCall();", EventName, arg.PublicPropertyName)
                b.AppendLine("call.eventArgsId = eventArgsId;")
                b.AppendLine("call.Execute(remoteRuntime.connection);")
                b.AppendLine("m_{0} = {1};", arg.PublicPropertyName, arg.ArgumentType.RemoteWrapExpression("call.value"))
                b.EndBlock()
            End If
            b.AppendLine("return m_{0};", arg.PublicPropertyName)
            b.EndBlock()
            If arg.ArgumentType.IsOut Then
                b.BeginBlock("set")
                b.AppendLine("m_{0} = value;", arg.PublicPropertyName)
                If arg.ArgumentType.IsIn Then b.AppendLine("{0}Fetched = true;", arg.PublicPropertyName)
                b.AppendLine("var call = new {0}Set{1}RenderProcessCall();", EventName, arg.PublicPropertyName)
                b.AppendLine("call.eventArgsId = eventArgsId;")
                b.AppendLine("call.value = {0};", arg.ArgumentType.RemoteUnwrapExpression("value"))
                b.AppendLine("call.Execute(remoteRuntime.connection);")
                b.EndBlock()
            End If
            b.EndBlock()
        Next
        If Not Signature.PublicReturnType.IsVoid Then
            setReturnValueComments.FileName = comments.FileName
            b.AppendSummaryAndRemarks(setReturnValueComments)
            b.BeginBlock("public void SetReturnValue({0} returnValue)", Signature.PublicReturnType.RemoteSymbol)
            b.AppendLine("var call = new {0}SetReturnValueRenderProcessCall();", EventName)
            b.AppendLine("call.eventArgsId = eventArgsId;")
            b.AppendLine("call.value = {0};", Signature.PublicReturnType.RemoteUnwrapExpression("returnValue"))
            b.AppendLine("call.Execute(remoteRuntime.connection);")
            b.EndBlock()
        End If

        If Signature.ManagedArguments.Count > 1 Then
            b.AppendLine()
            EmitEventToString(b)
        End If
        b.EndBlock()

    End Sub

    Public Sub EmitPublicEvent(b As CodeBuilder, cbIndex As Integer, comments As CommentData)

        Dim callbackName = Parent.CfxName & "_" & Name
        b.AppendSummaryAndRemarks(comments, False, True)
        b.BeginBlock("public event {0} {1}", EventHandlerName, CSharp.Escape(PublicName))
        b.BeginBlock("add")
        b.BeginBlock("if(m_{0} == null)", PublicName)
        b.AppendLine("CfxApi.{0}_activate_callback(NativePtr, {1}, 1);", Parent.CfxName, cbIndex)
        b.EndBlock()
        'b.AppendLine("m_{0} = ({1})System.Delegate.Combine(m_{0}, value);", PublicName, EventHandlerName)
        b.AppendLine("m_{0} += value;", PublicName)
        b.EndBlock()
        b.BeginBlock("remove")
        'b.AppendLine("m_{0} = ({1})System.Delegate.Remove(m_{0}, value);", PublicName, EventHandlerName)
        b.AppendLine("m_{0} -= value;", PublicName)
        b.BeginBlock("if(m_{0} == null)", PublicName)
        b.AppendLine("CfxApi.{0}_activate_callback(NativePtr, {1}, 0);", Parent.CfxName, cbIndex)
        b.EndBlock()
        b.EndBlock()
        b.EndBlock()
        b.AppendLine()
        b.AppendLine("private {0} m_{1};", EventHandlerName, PublicName)

    End Sub


    Public Sub EmitRemoteEvent(b As CodeBuilder, comments As CommentData)

        b.AppendSummaryAndRemarks(comments, True, True)
        b.BeginBlock("public event {0} {1}", RemoteEventHandlerName, CSharp.Escape(PublicName))
        b.BeginBlock("add")
        b.BeginBlock("if(m_{0} == null)", PublicName)
        b.AppendLine("var call = new {0}ActivateRenderProcessCall();", EventName)
        b.AppendLine("call.sender = proxyId;")
        b.AppendLine("call.Execute(remoteRuntime.connection);")
        b.EndBlock()
        b.AppendLine("m_{0} += value;", PublicName)
        b.EndBlock()
        b.BeginBlock("remove")
        b.AppendLine("m_{0} -= value;", PublicName)
        b.BeginBlock("if(m_{0} == null)", PublicName)
        b.AppendLine("var call = new {0}DeactivateRenderProcessCall();", EventName)
        b.AppendLine("call.sender = proxyId;")
        b.AppendLine("call.Execute(remoteRuntime.connection);")
        b.EndBlock()
        b.EndBlock()
        b.EndBlock()
        b.AppendLine()
        b.AppendLine("{0} m_{1};", RemoteEventHandlerName, PublicName)
        b.AppendLine()

    End Sub

    Public Sub EmitRemoteRaiseEventFunction(b As CodeBuilder, comments As CommentData)
        'b.AppendLine("internal {0} m_{1};", ProxyEventHandlerName, PublicName)
        b.BeginBlock("internal void raise_{0}(object sender, {1} e)", PublicName, RemoteEventArgsClassName)
        b.AppendLine("var handler = m_{0};", PublicName)
        b.AppendLine("if(handler == null) return;")
        b.AppendLine("handler(this, e);")
        b.EndBlock()
        b.AppendLine()

    End Sub

    Public Overrides ReadOnly Property NativeSymbol As String
        Get
            Return String.Format("{1} (CEF_CALLBACK *{0})({2})", Name, PublicReturnType, Signature)
        End Get
    End Property

    Public Overrides ReadOnly Property ParserMatches As String()
        Get
            Return New String() {}
        End Get
    End Property

    Public Overrides ReadOnly Property IsCefCallbackType As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property AsCefCallbackType As CefCallbackType
        Get
            Return Me
        End Get
    End Property

    Public ReadOnly Property CallMode As CfxCallMode Implements ISignatureParent.CallMode
        Get
            Return Me.m_callMode
        End Get
    End Property

    Public ReadOnly Property ProxyCallName As String Implements ISignatureParent.ProxyCallName
        Get
            If m_callMode = Global.CfxCallMode.FunctionCall Then
                Return String.Format("(({0})localObject).{1}", Parent.ClassName, PublicName)
            Else
                Return String.Format("(({0})localObject).{1}", Parent.ClassName, PropertyName)
            End If
        End Get
    End Property

    Public ReadOnly Property CefName As String Implements ISignatureParent.CefName
        Get
            Return Parent.Name & "::" & Name
        End Get
    End Property

    Public ReadOnly Property CfxApiFunctionName As String Implements ISignatureParent.CfxApiFunctionName
        Get
            Return String.Concat(Parent.CfxName, "_", Name)
        End Get
    End Property

    Public ReadOnly Property PublicFunctionName As String Implements ISignatureParent.PublicFunctionName
        Get
            Return PublicName
        End Get
    End Property

    Public ReadOnly Property PublicPropertyName As String Implements ISignatureParent.PropertyName
        Get
            Return PropertyName
        End Get
    End Property

    Public ReadOnly Property RemoteCallId As String Implements ISignatureParent.RemoteCallId
        Get
            If Parent.ClassBuilder.Category = StructCategory.ApiCallbacks Then
                Return Parent.ClassName & PublicName & "BrowserProcessCall"
            Else
                Return Parent.ClassName & PublicName & "RenderProcessCall"
            End If
        End Get
    End Property

    Public ReadOnly Property PublicClassName As String Implements ISignatureParent.PublicClassName
        Get
            Return Parent.ClassName
        End Get
    End Property

    Public ReadOnly Property Comments1 As CommentData Implements ISignatureParent.Comments
        Get
            Return Comments
        End Get
    End Property
End Class
