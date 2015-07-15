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



Public Class Signature

    Public Shared Function Create(owner As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder) As Signature
        Dim s = CustomSignatures.ForFunction(owner, sd, api)
        If s Is Nothing Then
            Return New Signature(owner, sd, api)
        Else
            Return s
        End If
    End Function

    Protected Class ArgList
        Private args As New List(Of String)
        Public Sub Add(arg As String)
            If Not String.IsNullOrWhiteSpace(arg) Then
                args.Add(arg)
                If arg = "cef_trace_client* client" Then Stop
            End If
        End Sub
        Public Function Join() As String
            Dim retval = String.Join(", ", args)
            args.Clear()
            Return retval
        End Function
    End Class

    Public ReadOnly Owner As ISignatureOwner
    Public ReadOnly Arguments As Argument()
    Public ReadOnly ReturnType As ApiType
    Public ReadOnly ReturnValueIsConst As Boolean

    Protected args As New ArgList

    Protected Sub New(owner As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder)
        Me.Owner = owner
        Dim args = New List(Of Argument)
        Dim index = 0
        For Each arg In sd.Arguments

            args.Add(New Argument(arg, api, index))
            index += 1
        Next

        Me.Arguments = args.ToArray()

        Me.ReturnType = api.GetApiType(sd.ReturnType, False)
        Me.ReturnValueIsConst = sd.ReturnValueIsConst
        Dim comments = owner.Comments

        DebugPrintUnhandledArrayArguments()

    End Sub

    Public Overridable ReadOnly Property RemoteArguments As Argument()
        Get
            Return ManagedArguments
        End Get
    End Property

    Public Overridable ReadOnly Property RemoteReturnType As ApiType
        Get
            Return PublicReturnType
        End Get
    End Property

    Private _managedArgs As Argument()
    Public Overridable ReadOnly Property ManagedArguments As Argument()
        Get
            If _managedArgs Is Nothing Then
                Dim list = New List(Of Argument)
                For Each arg In Arguments
                    If arg.ArgumentType.PInvokeSymbol IsNot Nothing Then
                        list.Add(arg)
                    End If
                Next
                _managedArgs = list.ToArray()
            End If
            Return _managedArgs
        End Get
    End Property

    Public Overridable ReadOnly Property PublicReturnType As ApiType
        Get
            Return ReturnType
        End Get
    End Property

    Public ReadOnly Property NativeCallback As String
        Get
            args.Add(String.Format("(({0}*)self)->gc_handle", Arguments(0).ArgumentType.AsCefStructPtrType.Struct.CfxNativeSymbol))
            If Not ReturnType.IsVoid Then
                args.Add("&__retval")
            End If
            For i = 1 To Arguments.Length - 1
                args.Add(Arguments(i).NativeWrapExpression)
            Next
            Return args.Join()
        End Get
    End Property

    Public ReadOnly Property NativeCall As String
        Get
            For i = 0 To Arguments.Length - 1
                args.Add(Arguments(i).NativeUnwrapExpression)
            Next
            Return args.Join()
        End Get
    End Property

    Public ReadOnly Property PublicEventConstructorSignature As String
        Get
            For i = 1 To ManagedArguments.Count - 1
                If ManagedArguments(i).ArgumentType.IsIn Then
                    args.Add(ManagedArguments(i).PublicEventConstructorSignature)
                End If
            Next
            Return args.Join()
        End Get
    End Property

    Public ReadOnly Property PublicEventConstructorCall As String
        Get
            For i = 1 To ManagedArguments.Length - 1
                If ManagedArguments(i).ArgumentType.IsIn Then
                    args.Add(ManagedArguments(i).PublicEventConstructorCall)
                End If
            Next
            Return args.Join()
        End Get
    End Property

    Public ReadOnly Property OriginalSignature As String
        Get
            For Each arg In Arguments
                args.Add(arg.OriginalSignature)
            Next
            Return args.Join()
        End Get
    End Property

    Public ReadOnly Property OriginalSignatureUnnamed As String
        Get
            For Each arg In Arguments
                If arg.IsConst Then
                    args.Add("const " & arg.ArgumentType.OriginalSymbol)
                Else
                    args.Add(arg.ArgumentType.OriginalSymbol)
                End If
            Next
            Return args.Join()
        End Get
    End Property


    Public ReadOnly Property NativeCallbackPtrSignature As String
        Get
            args.Add("gc_handle_t self")
            If Not ReturnType.IsVoid Then
                args.Add(ReturnType.NativeOutSignature("__retval"))
            End If
            For i = 1 To Arguments.Length - 1
                args.Add(Arguments(i).NativeCallSignature)
            Next
            Return args.Join()
        End Get
    End Property

    Public Overridable ReadOnly Property NativeSignature(functionName As String) As String
        Get
            For i = 0 To Arguments.Length - 1
                args.Add(Arguments(i).NativeCallSignature)
            Next

            Dim retType = ReturnType.NativeSymbol
            If ReturnValueIsConst Then
                retType = "const " & retType
            End If

            Return String.Format("static {0} {1}({2})", retType, functionName, args.Join())
        End Get
    End Property

    Public Overridable ReadOnly Property PInvokeSignature(functionName As String) As String
        Get
            For i = 0 To Arguments.Length - 1
                args.Add(Arguments(i).PInvokeCallSignature)
            Next
            Return String.Format("{0} {1}({2})", ReturnType.PInvokeSymbol, functionName, args.Join())
        End Get
    End Property

    Public ReadOnly Property PInvokeCallbackSignature As String
        Get
            args.Add("IntPtr gcHandlePtr")
            If Not ReturnType.IsVoid Then
                args.Add(ReturnType.PInvokeOutSignature("__retval"))
            End If
            For i = 1 To Arguments.Count - 1
                args.Add(Arguments(i).PInvokeCallbackSignature)
            Next
            Return args.Join()
        End Get
    End Property

    Public Overridable ReadOnly Property PublicSignature(functionName As String) As String
        Get
            For Each arg In ManagedArguments
                If arg.PublicSignature IsNot Nothing Then
                    args.Add(arg.PublicSignature)
                End If
            Next
            Return String.Format("{0} {1}({2})", PublicReturnType.PublicSymbol, functionName, args.Join())
        End Get
    End Property

    Public ReadOnly Property RemoteSignature As String
        Get
            For Each arg In RemoteArguments
                If arg.RemoteSignature IsNot Nothing Then
                    args.Add(arg.RemoteSignature)
                End If
            Next
            Return args.Join()
        End Get
    End Property

    Public Overridable Sub EmitPublicCall(b As CodeBuilder)

        For Each arg In ManagedArguments
            args.Add(arg.PublicUnwrapExpression)
        Next
        Dim callArgs = args.Join()

        Dim apiCall = String.Format("CfxApi.{0}({1})", Owner.CfxApiFunctionName, callArgs)

        For i = 0 To ManagedArguments.Length - 1
            ManagedArguments(i).EmitPrePublicCallStatements(b)
        Next

        Dim b1 = New CodeBuilder(b.CurrentIndent)
        For i = 0 To ManagedArguments.Length - 1
            ManagedArguments(i).EmitPostPublicStatements(b1)
        Next

        If PublicReturnType.IsVoid Then
            b.AppendLine(apiCall & ";")
            b.AppendBuilder(b1)
        Else
            If b1.IsNotEmpty Then
                b.AppendLine("var __retval = {0};", apiCall)
                b.AppendBuilder(b1)
                b.AppendLine("return {0};", PublicReturnType.PublicReturnExpression("__retval"))
            Else
                b.AppendLine("return {0};", PublicReturnType.PublicReturnExpression(apiCall))
            End If
        End If

    End Sub


    Protected Overridable Sub EmitExecuteInTargetProcess(b As CodeBuilder)

        Select Case Owner.CallMode
            Case CfxCallMode.FunctionCall

                For Each arg In ManagedArguments
                    If Not arg.IsThisArgument Then
                        arg.EmitPreProxyCallStatements(b)
                        args.Add(arg.ProxyUnwrapExpression)
                    End If
                Next

                Dim fCall As String
                If ManagedArguments.Length > 0 AndAlso ManagedArguments(0).IsThisArgument Then
                    b.AppendLine("var self_local = ({0})RemoteProxy.Unwrap(self);", ManagedArguments(0).ArgumentType.PublicSymbol)
                    fCall = String.Format("self_local.{0}({1})", Owner.PublicFunctionName, args.Join())
                Else
                    fCall = String.Format("{0}.{1}({2})", Owner.PublicClassName, Owner.PublicFunctionName, args.Join())
                End If

                If Not PublicReturnType.IsVoid Then
                    b.AppendLine("__retval = {0};", PublicReturnType.ProxyWrapExpression(fCall))
                Else
                    b.AppendLine(fCall & ";")
                End If

                For Each arg In ManagedArguments
                    If Not arg.IsThisArgument Then
                        arg.EmitPostProxyCallStatements(b)
                    End If
                Next

            Case CfxCallMode.PropertyGetter
                b.AppendLine("var self_local = ({0})RemoteProxy.Unwrap(self);", ManagedArguments(0).ArgumentType.PublicSymbol)
                b.AppendLine("__retval = {0};", PublicReturnType.ProxyWrapExpression("self_local." & Owner.PropertyName))
            Case CfxCallMode.PropertySetter
                b.AppendLine("var self_local = ({0})RemoteProxy.Unwrap(self);", ManagedArguments(0).ArgumentType.PublicSymbol)
                b.AppendLine("self_local.{0} = {1};", Owner.PropertyName, ManagedArguments(1).ProxyUnwrapExpression)
        End Select

    End Sub

    Public Sub EmitPublicEventCtorStatements(b As CodeBuilder)
        For i = 1 To ManagedArguments.Count - 1
            If ManagedArguments(i).ArgumentType.IsIn Then
                ManagedArguments(i).EmitPublicEventCtorStatements(b)
            End If
        Next
    End Sub

    Public Sub EmitPostPublicEventHandlerCallStatements(b As CodeBuilder)

        GeneratorConfig.FindDoNotKeepParameters(DirectCast(Owner, CefCallbackType))

        For i = 1 To ManagedArguments.Count - 1
            ManagedArguments(i).EmitPostPublicRaiseEventStatements(b)
            If ManagedArguments(i).TypeIsRefCounted Then
                If ManagedArguments(i).DoNotKeep Then
                    b.BeginIf("e.m_{0}_wrapped == null", ManagedArguments(i).VarName)
                    b.AppendLine("CfxApi.cfx_release(e.m_{0});", ManagedArguments(i).VarName)
                    b.BeginElse()
                    b.AppendLine("e.m_{0}_wrapped.Dispose();", ManagedArguments(i).VarName)
                    b.EndBlock()
                Else
                    b.AppendLine("if(e.m_{0}_wrapped == null) CfxApi.cfx_release(e.m_{0});", ManagedArguments(i).VarName)
                End If
            End If
        Next
        EmitPostPublicEventHandlerReturnValueStatements(b)
    End Sub

    Public Sub EmitPublicEventArgProperties(b As CodeBuilder)
        For i = 1 To ManagedArguments.Count - 1
            Dim arg = ManagedArguments(i)
            Dim cd = New CommentData
            If arg.ArgumentType.IsIn AndAlso arg.ArgumentType.IsOut Then
                cd.Lines = {String.Format("Get or set the {0} parameter for the <see cref=""{1}.{2}""/> callback.", arg.PublicPropertyName, Owner.PublicClassName, Owner.PublicFunctionName)}
            ElseIf arg.ArgumentType.IsIn Then
                cd.Lines = {String.Format("Get the {0} parameter for the <see cref=""{1}.{2}""/> callback.", arg.PublicPropertyName, Owner.PublicClassName, Owner.PublicFunctionName)}
            Else
                cd.Lines = {String.Format("Set the {0} out parameter for the <see cref=""{1}.{2}""/> callback.", arg.PublicPropertyName, Owner.PublicClassName, Owner.PublicFunctionName)}
            End If
            b.AppendSummary(cd)
            b.BeginBlock("public {0} {1}", arg.ArgumentType.PublicSymbol, arg.PublicPropertyName)
            If arg.ArgumentType.IsIn Then
                b.BeginBlock("get")
                b.AppendLine("CheckAccess();")
                arg.EmitPublicEventArgGetterStatements(b)
                b.EndBlock()
            End If
            If arg.ArgumentType.IsOut Then
                b.BeginBlock("set")
                b.AppendLine("CheckAccess();")
                arg.EmitPublicEventArgSetterStatements(b)
                b.EndBlock()
            End If
            b.EndBlock()
        Next
    End Sub


    Protected Overridable Sub EmitPostPublicEventHandlerReturnValueStatements(b As CodeBuilder)
        If Not PublicReturnType.IsVoid Then
            b.AppendLine("__retval = {0};", PublicReturnType.PublicUnwrapExpression("e.m_returnValue"))
        End If
    End Sub


    Public Overridable Sub EmitRemoteCall(b As CodeBuilder)

        b.AppendLine("var call = new {0}();", Owner.RemoteCallId)

        For Each arg In ManagedArguments
            If arg.ArgumentType.IsIn Then
                arg.EmitPreRemoteCallStatements(b)
            End If
        Next

        If Owner.RemoteCallId.StartsWith("CfxRuntime") Then
            b.AppendLine("call.Execute(connection);")
        Else
            b.AppendLine("call.Execute(remoteRuntime.connection);")
        End If

        For Each arg In ManagedArguments
            If arg.ArgumentType.IsOut Then
                arg.EmitPostRemoteCallStatements(b)
            End If
        Next

        If Not PublicReturnType.IsVoid Then
            b.AppendLine("return {0};", ReturnType.RemoteWrapExpression("call.__retval"))
        End If
    End Sub


    Public Sub EmitRemoteCallClassBody(b As CodeBuilder)

        b.AppendLine()

        For Each arg In ManagedArguments
            arg.EmitRemoteCallFields(b)
        Next

        If Not PublicReturnType.IsVoid Then
            PublicReturnType.EmitRemoteCallFields(b, "__retval")
        End If

        b.AppendLine()

        b.BeginBlock("protected override void WriteArgs(StreamHandler h)")
        For Each arg In ManagedArguments
            If arg.ArgumentType.IsIn Then
                arg.EmitRemoteWrite(b)
            End If
        Next
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("protected override void ReadArgs(StreamHandler h)")
        For Each arg In ManagedArguments
            If arg.ArgumentType.IsIn Then
                arg.EmitRemoteRead(b)
            End If
        Next
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("protected override void WriteReturn(StreamHandler h)")
        For Each arg In ManagedArguments
            If arg.ArgumentType.IsOut Then
                arg.EmitRemoteWrite(b)
            End If
        Next
        If Not PublicReturnType.IsVoid Then
            b.AppendLine("h.Write(__retval);", PublicReturnType.PublicSymbol)
        End If
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("protected override void ReadReturn(StreamHandler h)")
        For Each arg In ManagedArguments
            If arg.ArgumentType.IsOut Then
                arg.EmitRemoteRead(b)
            End If
        Next
        If Not PublicReturnType.IsVoid Then
            b.AppendLine("h.Read(out __retval);", PublicReturnType.PublicSymbol)
        End If
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
        EmitExecuteInTargetProcess(b)
        b.EndBlock()

    End Sub

    Public Overridable Sub EmitNativeCall(b As CodeBuilder, functionName As String)

        Dim b1 = New CodeBuilder(b.CurrentIndent)
        For i = 0 To Arguments.Length - 1
            Arguments(i).EmitPreNativeCallStatements(b)
            Arguments(i).EmitPostNativeCallStatements(b1)
        Next

        Dim functionCall = String.Format("{0}({1})", functionName, NativeCall)
        ReturnType.EmitNativeReturnStatements(b, functionCall, b1)

    End Sub

    Public Overridable Sub DebugPrintUnhandledArrayArguments()

        If Owner.CefName = "cef_binary_value_create" Then Return
        If Owner.CefName = "cef_binary_value::get_data" Then Return
        If Owner.CefName = "cef_resource_handler::get_response_headers" Then Return
        If Owner.CefName = "cef_resource_bundle_handler::get_data_resource" Then Return
        If Owner.CefName = "cef_urlrequest_client::on_download_data" Then Return
        If Owner.CefName = "cef_zip_reader::read_file" Then Return

        For i = 0 To Arguments.Length - 1
            Dim suffixLength = CountArgumentSuffixLength(Arguments(i))
            If suffixLength > 0 Then
                Dim arrName = Arguments(i).VarName.Substring(0, Arguments(i).VarName.Length - suffixLength)
                If i > 0 AndAlso Arguments(i - 1).VarName.StartsWith(arrName) Then
                    Debug.Print("{0} {1} {2} {3}", Owner.CallMode, Owner.CefName, Arguments(i - 1), Arguments(i))
                ElseIf i < Arguments.Length - 1 AndAlso Arguments(i + 1).VarName.StartsWith(arrName) Then
                    Debug.Print("{0} {1} {2} {3}", Owner.CallMode, Owner.CefName, Arguments(i), Arguments(i + 1))
                Else

                End If
            End If
        Next
    End Sub

    Private Function CountArgumentSuffixLength(arg As Argument) As Integer
        If arg.VarName.EndsWith("_size") Then Return 5
        If arg.VarName.EndsWith("_count") Then Return 6
        If arg.VarName.EndsWith("_length") Then Return 7
        If arg.VarName.EndsWith("Size") Then Return 4
        If arg.VarName.EndsWith("Count") Then Return 5
        If arg.VarName.EndsWith("Length") Then Return 6
        Return 0
    End Function

    Public Overrides Function ToString() As String
        For i = 0 To ManagedArguments.Length - 1
            args.Add(ManagedArguments(i).ToString())
        Next
        Return args.Join()
    End Function

End Class
