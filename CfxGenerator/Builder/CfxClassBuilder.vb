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




Public Class StructMember

    Public ReadOnly MemberType As ApiType
    Public ReadOnly Name As String

    Public ReadOnly Comments As CommentData


    Public IsProperty As Boolean

    Sub New(parent As CefStructType, structCategory As StructCategory, smd As Parser.StructMemberData, api As ApiTypeBuilder)

        If smd.MemberType IsNot Nothing Then
            MemberType = api.GetApiType(smd.MemberType, False)
            If MemberType.Name = "int" Then
                If BooleanIntDetector.HasCommentHintForBooleanValue(smd.Comments) Then
                    MemberType = BooleanInteger.Convert(MemberType)
                End If
            End If
        Else
            MemberType = New CefCallbackType(parent, structCategory, smd.Name, smd.CallbackSignature, api, smd.Comments)
        End If
        Name = smd.Name
        Comments = smd.Comments
    End Sub

    Public ReadOnly Property PublicName As String
        Get
            Static _name As String = CSharp.ApplyStyle(Name)
            Return _name
        End Get
    End Property

    Public ReadOnly Property CallbackSignature As Signature
        Get
            Return MemberType.AsCefCallbackType.Signature
        End Get
    End Property

    Public ReadOnly Property Callback As CefCallbackType
        Get
            Return MemberType.AsCefCallbackType
        End Get
    End Property

    Public Overrides Function ToString() As String
        If MemberType.IsCefCallbackType Then
            Return MemberType.ToString()
        Else
            Return String.Format("{0} {1}", MemberType, Name)
        End If
    End Function
End Class

Public Enum StructCategory
    Values
    ApiCalls
    ApiCallbacks
End Enum


Public Class CfxClassBuilder

    Private ReadOnly struct As CefStructType

    Public ReadOnly ExportFunctions As CefExportFunction()
    Public ReadOnly StructMembers As StructMember()
    Private ReadOnly comments As CommentData

    Private ReadOnly StructCallbacks As StructMember()

    Private ReadOnly m_structProperties As New List(Of StructProperty)
    Private ReadOnly m_structFunctions As New List(Of StructMember)

    Public ReadOnly Category As StructCategory

    Private ReadOnly OriginalSymbol As String
    Private ReadOnly CfxNativeSymbol As String
    Private ReadOnly CfxName As String
    Private ReadOnly ClassName As String
    Private ReadOnly RemoteClassName As String

    Private ReadOnly NeedsWrapping As Boolean

    Public Sub New(struct As CefStructType, sd As Parser.StructData, api As ApiTypeBuilder)

        Me.struct = struct
        Me.OriginalSymbol = struct.OriginalSymbol
        Me.CfxNativeSymbol = struct.CfxNativeSymbol
        Me.CfxName = struct.CfxName
        Me.ClassName = struct.ClassName
        Me.RemoteClassName = struct.RemoteClassName

        Me.comments = sd.Comments
        If struct.Name.Equals("cef_app") OrElse
                struct.Name.Equals("cef_get_geolocation_callback") OrElse
                struct.Name.EndsWith("handler") OrElse
                struct.Name.EndsWith("_client") OrElse
                struct.Name.EndsWith("visitor") OrElse
                struct.Name.EndsWith("_listener") OrElse
                struct.Name.EndsWith("accessor") OrElse
                struct.Name.EndsWith("_task") Then
            Category = StructCategory.ApiCallbacks
        ElseIf sd.StructMembers.Count > 1 AndAlso sd.StructMembers(1).CallbackSignature IsNot Nothing Then
            Category = StructCategory.ApiCalls
        Else
            Category = StructCategory.Values
        End If


        Dim smlist = New List(Of StructMember)
        For Each smd In sd.StructMembers
            smlist.Add(New StructMember(struct, Category, smd, api))
        Next
        StructMembers = smlist.ToArray()

        Dim flist = New List(Of CefExportFunction)
        For Each fd In sd.CefFunctions
            flist.Add(New CefExportFunction(struct, fd, api))
        Next
        ExportFunctions = flist.ToArray()

        If StructMembers.Length > 1 AndAlso StructMembers(1).MemberType.IsCefCallbackType Then

            StructCallbacks = New StructMember(StructMembers.Length - 2) {}
            For i = 1 To StructMembers.Length - 1
                StructCallbacks(i - 1) = StructMembers(i)
            Next

            If Not Category = StructCategory.ApiCallbacks Then
                Category = StructCategory.ApiCalls
                For Each sm In StructCallbacks
                    Dim cb = sm.Callback
                    Dim isBoolean = False
                    If cb.IsPropertyGetter(isBoolean) Then
                        Dim setter As StructMember = Nothing
                        For Each sm2 In StructMembers
                            If sm2.MemberType.IsCefCallbackType AndAlso sm2.MemberType.AsCefCallbackType.IsPropertySetterFor(cb) Then
                                setter = sm2
                                setter.MemberType.AsCefCallbackType.Signature.ManagedArguments(1).IsPropertySetterArgument = True
                                Exit For
                            End If
                        Next
                        Dim prop = New StructProperty(sm, setter, isBoolean)
                        m_structProperties.Add(prop)

                    End If
                Next
                For Each sm In StructMembers
                    If sm.MemberType.IsCefCallbackType AndAlso Not sm.IsProperty Then
                        m_structFunctions.Add(sm)
                    Else
                        'If sm.Name.StartsWith("get_") OrElse sm.Name.StartsWith("set_") Then
                        '    m_structFunctions.Add(sm)
                        'End If
                    End If
                Next
            End If
        End If

        If Category = StructCategory.Values Then
            NeedsWrapping = GeneratorConfig.ValueStructNeedsWrapping(struct.Name)
        End If

    End Sub

    Public ReadOnly Property IsRefCounted As Boolean
        Get
            Return Category <> StructCategory.Values
        End Get
    End Property


    Public ReadOnly Property NeedsConstructor As Boolean
        Get
            Return Category = StructCategory.Values OrElse Category = StructCategory.ApiCallbacks
        End Get
    End Property


    Public Sub EmitNativeWrapper(b As CodeBuilder)

        b.AppendComment(struct.Name)
        b.AppendLine()
        CodeSnippets.BeginExternC(b)
        b.AppendLine()

        Select Case Category
            Case StructCategory.ApiCalls
                EmitNativeCallStruct(b)
            Case StructCategory.ApiCallbacks
                EmitNativeCallbackStruct(b)
            Case StructCategory.Values
                EmitNativeValueStruct(b)
        End Select

        b.AppendLine()
        CodeSnippets.EndExternC(b)
        b.AppendLine()

    End Sub

    Private Sub EmitNativeCallStruct(b As CodeBuilder)

        For Each f In ExportFunctions
            f.EmitNativeFunction(b)
        Next

        For Each sm In StructMembers
            b.AppendLine("// {0}", sm)
            If sm.MemberType.IsCefCallbackType Then
                Dim cb = sm.MemberType.AsCefCallbackType
                b.BeginBlock(cb.Signature.NativeExportSignature(CfxName & "_" & sm.Name))
                cb.Signature.EmitNativeCall(b, "self->" & sm.Name)
                b.EndBlock()
            End If
            b.AppendLine()
        Next

    End Sub

    Private Sub EmitNativeCallbackStruct(b As CodeBuilder)

        If ExportFunctions.Count > 0 Then Stop

        b.BeginBlock("typedef struct _{0}", CfxNativeSymbol)
        b.AppendLine("{0} {1};", OriginalSymbol, struct.Name)
        b.AppendLine("unsigned int ref_count;")
        b.AppendLine("gc_handle_t gc_handle;")
        b.EndBlock("{0};", CfxNativeSymbol)
        b.AppendLine()

        b.BeginBlock("void CEF_CALLBACK _{0}_add_ref(struct _cef_base_t* base)", CfxName)
        b.AppendLine("{0}* ptr = ({0}*)base;", CfxNativeSymbol)
        b.AppendLine("InterlockedIncrement(&ptr->ref_count);")
        b.EndBlock()
        b.BeginBlock("int CEF_CALLBACK _{0}_release(struct _cef_base_t* base)", CfxName)
        b.AppendLine("{0}* ptr = ({0}*)base;", CfxNativeSymbol)
        b.AppendLine("int count = InterlockedDecrement(&(({0}*)ptr)->ref_count);", CfxNativeSymbol)
        b.BeginBlock("if(!count)")
        b.AppendLine("cfx_gc_handle_free((({0}*)ptr)->gc_handle);", CfxNativeSymbol)
        b.AppendLine("free(ptr);")
        b.EndBlock()
        b.AppendLine("return count;")
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("CFX_EXPORT {0}* {1}_ctor(gc_handle_t gc_handle)", CfxNativeSymbol, CfxName)
        b.AppendLine("{0}* ptr = ({0}*)calloc(1, sizeof({0}));", CfxNativeSymbol)
        b.AppendLine("if(!ptr) return 0;")
        b.AppendLine("ptr->{0}.base.size = sizeof({1});", struct.Name, OriginalSymbol)
        b.AppendLine("ptr->{0}.base.add_ref = _{1}_add_ref;", struct.Name, CfxName)
        b.AppendLine("ptr->{0}.base.release = _{1}_release;", struct.Name, CfxName)
        b.AppendLine("ptr->ref_count = 1;")
        b.AppendLine("ptr->gc_handle = gc_handle;")
        b.AppendLine("return ptr;")
        b.EndBlock()
        b.AppendLine()
        b.BeginBlock("CFX_EXPORT gc_handle_t {0}_get_gc_handle({1}* self)", CfxName, CfxNativeSymbol)
        b.AppendLine("return self->gc_handle;")
        b.EndBlock()
        b.AppendLine()

        For Each sm In StructMembers
            If sm.MemberType.IsCefCallbackType Then
                b.AppendLine("// {0}", sm)
                b.AppendLine()

                Dim cb = sm.MemberType.AsCefCallbackType

                b.AppendLine("void (CEF_CALLBACK *{0}_callback)({1});", cb.NativeCallbackName, cb.Signature.NativeCallbackPtrSignature)
                b.AppendLine()
                b.BeginBlock("{0} CEF_CALLBACK {1}({2})", cb.NativeReturnType.OriginalSymbol, cb.NativeCallbackName, cb.Signature.OriginalCallbackSignature)
                If Not cb.NativeReturnType.IsVoid Then
                    b.AppendLine("{0} __retval;", cb.NativeReturnType.NativeSymbol)
                End If

                For Each arg In cb.Signature.Arguments
                    arg.EmitPreNativeCallbackStatements(b)
                Next

                b.AppendLine("{0}_callback({1});", cb.NativeCallbackName, cb.Signature.NativeCallback)

                For Each arg In cb.Signature.Arguments
                    arg.EmitPostNativeCallbackStatements(b)
                Next

                If Not cb.NativeReturnType.IsVoid Then
                    If cb.NativeReturnType.IsCefStructPtrType Then
                        b.BeginIf("__retval")
                        b.AppendLine("((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);")
                        b.EndBlock()
                    End If
                    b.AppendLine("return __retval;")
                End If

                b.EndBlock()
                b.AppendLine()
                b.AppendLine()
            End If
        Next

        b.BeginBlock("CFX_EXPORT void {0}_set_managed_callback({1}* self, int index, void* callback)", CfxName, OriginalSymbol)
        b.BeginBlock("switch(index)")
        Dim index = 0
        For Each sm In StructMembers
            If sm.MemberType.IsCefCallbackType Then
                b.DecreaseIndent()
                b.AppendLine("case {0}:", index)
                b.IncreaseIndent()
                b.AppendLine("if(callback && !{0}_callback)", sm.MemberType.AsCefCallbackType.NativeCallbackName)
                b.IncreaseIndent()
                b.AppendLine("{0}_callback = (void (CEF_CALLBACK *)({1})) callback;", sm.MemberType.AsCefCallbackType.NativeCallbackName, sm.MemberType.AsCefCallbackType.Signature.NativeCallbackPtrSignature, index)
                b.DecreaseIndent()
                b.AppendLine("self->{0} = callback ? {1} : 0;", sm.Name, sm.MemberType.AsCefCallbackType.NativeCallbackName)
                b.AppendLine("break;")

                index += 1
            End If
        Next
        b.EndBlock()
        b.EndBlock()

    End Sub

    Public Sub EmitNativeValueStruct(b As CodeBuilder)

        If ExportFunctions.Count > 0 Then Stop

        b.BeginBlock("CFX_EXPORT {0}* {1}_ctor()", OriginalSymbol, CfxName)
        If StructMembers.Length > 0 AndAlso StructMembers(0).Name = "size" Then
            b.AppendLine("{0}* ptr = ({0}*)calloc(1, sizeof({0}));", OriginalSymbol)
            b.AppendLine("if(!ptr) return 0;")
            b.AppendLine("ptr->size = sizeof({0});", OriginalSymbol)
            b.AppendLine("return ptr;")
        Else
            b.AppendLine("return ({0}*)calloc(1, sizeof({0}));", OriginalSymbol)
        End If
        b.EndBlock()
        b.AppendLine()

        b.BeginBlock("CFX_EXPORT void {1}_dtor({0}* ptr)", OriginalSymbol, CfxName)
        For Each sm In StructMembers
            If sm.MemberType.IsCefStringType Then
                b.AppendLine("if(ptr->{0}.dtor) ptr->{0}.dtor(ptr->{0}.str);", sm.Name)
            End If
        Next
        b.AppendLine("free(ptr);", OriginalSymbol)
        b.EndBlock()
        b.AppendLine()

        For Each sm In StructMembers
            If sm.Name <> "size" Then
                b.AppendComment("{0}->{1}", struct.OriginalSymbol, sm.Name)
                b.BeginBlock("CFX_EXPORT void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, struct.OriginalSymbol, sm.MemberType.NativeCallSignature(sm.Name, False))
                sm.MemberType.EmitAssignToNativeStructMember(b, sm.Name)
                b.EndBlock()
                b.BeginBlock("CFX_EXPORT void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, struct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name))
                sm.MemberType.EmitAssignFromNativeStructMember(b, sm.Name)
                b.EndBlock()
                b.AppendLine()
            End If
        Next

    End Sub


    Public Sub EmitApiDeclarations(b As CodeBuilder)

        b.AppendComment(ClassName)
        b.AppendLine()

        If ExportFunctions.Count > 0 Then
            For Each f In Me.ExportFunctions
                f.EmitPInvokeDeclaration(b)
            Next
            b.AppendLine()
        End If

        Select Case Category

            Case StructCategory.Values

                b.AppendComment("CFX_EXPORT {0}* {1}_ctor()", OriginalSymbol, CfxName)
                b.AppendLine("public static cfx_ctor_delegate {0}_ctor;", CfxName)
                b.AppendComment("CFX_EXPORT void {1}_dtor({0}* ptr)", OriginalSymbol, CfxName)
                b.AppendLine("public static cfx_dtor_delegate {0}_dtor;", CfxName)
                b.AppendLine()

                For Each sm In StructMembers
                    If sm.Name <> "size" Then
                        b.AppendComment("CFX_EXPORT void {0}_set_{1}({2} *self, {3})", CfxName, sm.Name, struct.OriginalSymbol, sm.MemberType.NativeCallSignature(sm.Name, False))
                        b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]")
                        b.AppendLine("public delegate void {0}_set_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeCallSignature(sm.Name))
                        b.AppendLine("public static {0}_set_{1}_delegate {0}_set_{1};", CfxName, sm.Name)
                        b.AppendComment("CFX_EXPORT void {0}_get_{1}({2} *self, {3})", CfxName, sm.Name, struct.OriginalSymbol, sm.MemberType.NativeOutSignature(sm.Name))
                        b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]")
                        b.AppendLine("public delegate void {0}_get_{1}_delegate(IntPtr self, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutSignature(sm.Name))
                        b.AppendLine("public static {0}_get_{1}_delegate {0}_get_{1};", CfxName, sm.Name)
                        b.AppendLine()
                    End If
                Next

            Case StructCategory.ApiCalls

                For Each sm In StructMembers
                    If sm.MemberType.IsCefCallbackType Then
                        Dim cb = sm.MemberType.AsCefCallbackType
                        b.AppendComment(cb.Signature.NativeExportSignature(CfxName & "_" & sm.Name))
                        CodeSnippets.EmitPInvokeDelegate(b, CfxName & "_" & sm.Name, cb.Signature)
                        b.AppendLine()
                    End If
                Next

            Case StructCategory.ApiCallbacks

                If Category = StructCategory.ApiCallbacks Then
                    b.AppendComment("CFX_EXPORT {0}* {1}_ctor();", CfxNativeSymbol, CfxName)
                    b.AppendLine("public static cfx_ctor_with_gc_handle_delegate {0}_ctor;", CfxName)
                    b.AppendLine("public static cfx_get_gc_handle_delegate {0}_get_gc_handle;", CfxName)
                    b.AppendLine("public static cfx_set_callback_delegate {0}_set_managed_callback;", CfxName)
                    b.AppendLine()
                End If

        End Select

    End Sub

    Public Sub EmitApiInitialization(b As CodeBuilder)

        b.AppendComment(struct.Name)
        b.AppendLine()

        If ExportFunctions.Count > 0 Then
            For Each f In Me.ExportFunctions
                CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
            Next
            b.AppendLine()
        End If

        If Category = StructCategory.Values Then
            CodeSnippets.EmitPInvokeDelegateInitialization(b, CfxName & "_ctor", "cfx_ctor_delegate")
            CodeSnippets.EmitPInvokeDelegateInitialization(b, CfxName & "_dtor", "cfx_dtor_delegate")
            b.AppendLine()

            For Each sm In StructMembers
                If sm.Name <> "size" Then
                    CodeSnippets.EmitPInvokeDelegateInitialization(b, CfxName & "_set_" & sm.Name)
                    CodeSnippets.EmitPInvokeDelegateInitialization(b, CfxName & "_get_" & sm.Name)
                End If
            Next
            b.AppendLine()

        ElseIf Category = StructCategory.ApiCalls Then
            For Each sm In StructMembers
                If sm.MemberType.IsCefCallbackType Then
                    CodeSnippets.EmitPInvokeDelegateInitialization(b, CfxName & "_" & sm.Name)
                End If
            Next
        Else

            b.AppendLine("{0}_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, ""{0}_ctor"", typeof(cfx_ctor_with_gc_handle_delegate));", CfxName)
            b.AppendLine("{0}_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, ""{0}_get_gc_handle"", typeof(cfx_get_gc_handle_delegate));", CfxName)
            b.AppendLine("{0}_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, ""{0}_set_managed_callback"", typeof(cfx_set_callback_delegate));", CfxName)

        End If

    End Sub

    Public Sub EmitPublicClass(b As CodeBuilder)

        Select Case Category
            Case StructCategory.ApiCalls
                EmitPublicCallClass(b)
            Case StructCategory.ApiCallbacks
                EmitPublicCallbackClass(b)
            Case StructCategory.Values
                EmitPublicValueClass(b)
        End Select


    End Sub

    Public Sub EmitPublicCallClass(b As CodeBuilder)

        b.AppendSummaryAndRemarks(comments)

        b.BeginClass(ClassName & " : CfxBase", GeneratorConfig.ClassModifiers(ClassName))
        b.AppendLine()
        b.AppendLine("private static readonly WeakCache weakCache = new WeakCache();")
        b.AppendLine()
        b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static")
        b.AppendLine("if(nativePtr == IntPtr.Zero) return null;")
        b.BeginBlock("lock(weakCache)")
        b.AppendLine("var wrapper = ({0})weakCache.Get(nativePtr);", ClassName)
        b.BeginBlock("if(wrapper == null)")
        b.AppendLine("wrapper = new {0}(nativePtr);", ClassName)
        b.AppendLine("weakCache.Add(wrapper);")
        b.BeginElse()
        'release the new ref and reuse the existing ref
        b.AppendLine("CfxApi.cfx_release(nativePtr);")
        b.EndBlock()
        b.AppendLine("return wrapper;")
        b.EndBlock()
        b.EndBlock()
        b.AppendLine()
        b.AppendLine()

        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName)

        b.AppendLine()


        For Each f In ExportFunctions
            f.EmitPublicFunction(b)
            b.AppendLine()
        Next

        For Each p In m_structProperties
            If p.Setter IsNot Nothing AndAlso p.Setter.Comments IsNot Nothing Then
                Dim summaryLines As New List(Of String)
                summaryLines.AddRange(p.Getter.Comments.Lines)
                summaryLines.Add("")
                summaryLines.AddRange(p.Setter.Comments.Lines)
                Dim summary = New CommentData
                summary.Lines = summaryLines.ToArray()
                summary.FileName = p.Getter.Comments.FileName
                b.AppendSummaryAndRemarks(summary)
            Else
                b.AppendSummaryAndRemarks(p.Getter.Comments)
            End If
            p.Getter.MemberType.AsCefCallbackType.EmitPublicProperty(b, If(p.Setter Is Nothing, Nothing, p.Setter.MemberType.AsCefCallbackType))
            b.AppendLine()
        Next

        For Each sm In m_structFunctions
            b.AppendSummaryAndRemarks(sm.Comments)
            sm.MemberType.AsCefCallbackType.EmitPublicFunction(b)
            b.AppendLine()
        Next

        b.BeginFunction("OnDispose", "void", "IntPtr nativePtr", "internal override")
        b.AppendLine("weakCache.Remove(nativePtr);")
        b.AppendLine("base.OnDispose(nativePtr);")
        b.EndBlock()

        b.EndBlock()

    End Sub

    Public Sub EmitPublicCallbackClass(b As CodeBuilder)

        b.AppendLine("using Event;")
        b.AppendLine()

        b.AppendSummaryAndRemarks(comments, False, True)

        b.BeginClass(ClassName & " : CfxBase", GeneratorConfig.ClassModifiers(ClassName))
        b.AppendLine()

        b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static")
        b.AppendLine("if(nativePtr == IntPtr.Zero) return null;")
        b.AppendLine("var handlePtr = CfxApi.{0}_get_gc_handle(nativePtr);", CfxName)
        b.AppendLine("return ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;", ClassName)
        b.EndBlock()
        b.AppendLine()
        b.AppendLine()

        b.AppendLine("private static object eventLock = new object();")
        b.AppendLine()

        For Each sm In StructCallbacks
            Dim cb = sm.Callback
            Dim sig = cb.Signature

            b.AppendComment(cb.ToString())
            CodeSnippets.EmitPInvokeCallbackDelegate(b, CfxName & "_" & sm.Name, cb.Signature)
            b.AppendLine("private static {0}_{1}_delegate {0}_{1};", CfxName, sm.Name)
            b.AppendLine("private static IntPtr {0}_{1}_ptr;", CfxName, sm.Name)
            b.AppendLine()

            b.BeginFunction(sm.Name, "void", sig.PInvokeCallbackSignature, "internal static")
            'b.AppendLine("var handle = System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr);")
            b.AppendLine("var self = ({0})System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;", ClassName)
            b.BeginIf("self == null")
            If Not sig.ReturnType.IsVoid Then
                b.AppendLine("__retval = default({0});", sig.ReturnType.PInvokeSymbol)
            End If
            For Each arg In sig.Arguments
                If arg.ArgumentType.IsOut AndAlso Not arg.ArgumentType.IsIn Then
                    b.AppendLine("{0} = default({1});", arg.VarName, arg.ArgumentType.PInvokeSymbol)
                End If
            Next
            b.AppendLine("return;")
            b.EndBlock()
            b.AppendLine("var e = new {0}({1});", cb.PublicEventArgsClassName, sig.PublicEventConstructorCall)
            b.AppendLine("var eventHandler = self.m_{0};", cb.PublicName)
            b.AppendLine("if(eventHandler != null) eventHandler(self, e);", cb.PublicName)
            b.AppendLine("e.m_isInvalid = true;")

            sig.EmitPostPublicEventHandlerCallStatements(b)

            b.EndBlock()
            b.AppendLine()
        Next


        b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName)
        b.AppendLine("public {0}() : base(CfxApi.{1}_ctor) {{}}", ClassName, CfxName)
        b.AppendLine()

        Dim cbIndex = 0
        For Each sm In StructCallbacks
            sm.Callback.EmitPublicEvent(b, cbIndex, sm.Comments)
            b.AppendLine()
            cbIndex += 1
        Next

        b.BeginFunction("OnDispose", "void", "IntPtr nativePtr", "internal override")
        cbIndex = 0
        For Each sm In StructCallbacks
            b.BeginIf("m_{0} != null", sm.PublicName)
            b.AppendLine("m_{0} = null;", sm.PublicName)
            b.AppendLine("CfxApi.{0}_set_managed_callback(NativePtr, {1}, IntPtr.Zero);", CfxName, cbIndex)
            b.EndBlock()
            cbIndex += 1
        Next
        b.AppendLine("base.OnDispose(nativePtr);")
        b.EndBlock()

        b.EndBlock()

        b.AppendLine()
        b.AppendLine()
        EmitPublicEventArgs(b)

    End Sub

    Public Sub EmitPublicValueClass(b As CodeBuilder)

        'asserts

        For Each sm In StructMembers
            If sm.MemberType.IsCefStructPtrType Then
                Stop
            End If
            If sm.MemberType.IsCefStructType AndAlso sm.MemberType.AsCefStructType.ClassBuilder.IsRefCounted Then
                Stop
            End If
        Next


        b.AppendSummaryAndRemarks(comments)

        b.BeginClass(ClassName & " : CfxStructure", GeneratorConfig.ClassModifiers(ClassName, "public sealed"))
        b.AppendLine()

        If NeedsWrapping Then
            b.BeginFunction("Wrap", ClassName, "IntPtr nativePtr", "internal static")
            b.AppendLine("if(nativePtr == IntPtr.Zero) return null;")
            b.AppendLine("return new {0}(nativePtr);", ClassName)
            b.EndBlock()
            b.AppendLine()
            b.BeginFunction("WrapOwned", ClassName, "IntPtr nativePtr", "internal static")
            b.AppendLine("if(nativePtr == IntPtr.Zero) return null;")
            b.AppendLine("return new {0}(nativePtr, CfxApi.{1}_dtor);", ClassName, CfxName)
            b.EndBlock()
            b.AppendLine()
        End If

        b.AppendLine("public {0}() : base(CfxApi.{1}_ctor, CfxApi.{1}_dtor) {{}}", ClassName, CfxName)
        If NeedsWrapping Then
            b.AppendLine("internal {0}(IntPtr nativePtr) : base(nativePtr) {{}}", ClassName, CfxName)
            b.AppendLine("internal {0}(IntPtr nativePtr, CfxApi.cfx_dtor_delegate cfx_dtor) : base(nativePtr, cfx_dtor) {{}}", ClassName, CfxName)
        End If
        b.AppendLine()

        For Each sm In StructMembers
            If sm.Name <> "size" Then
                b.AppendSummaryAndRemarks(sm.Comments)
                b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.PublicSymbol)
                b.BeginBlock("get")
                sm.MemberType.EmitValueStructGetterVars(b, "value")
                b.AppendLine("CfxApi.{0}_get_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PInvokeOutArgument("value"))
                b.AppendLine("return {0};", sm.MemberType.PublicWrapExpression("value"))
                b.EndBlock()
                b.BeginBlock("set")
                sm.MemberType.EmitPrePublicCallStatements(b, "value")
                b.AppendLine("CfxApi.{0}_set_{1}(nativePtrUnchecked, {2});", CfxName, sm.Name, sm.MemberType.PublicUnwrapExpression("value"))
                sm.MemberType.EmitPostPublicCallStatements(b, "value")
                b.EndBlock()
                b.EndBlock()
                b.AppendLine()
            End If
        Next

        b.EndBlock()

    End Sub

    Public Sub EmitRemoteCalls(b As CodeBuilder, callIds As List(Of String))

        If Category = StructCategory.ApiCallbacks Then
            b.AppendLine("using Event;")
            b.AppendLine("using Chromium.Event;")
        End If

        b.AppendLine()

        If NeedsConstructor Then
            b.BeginRemoteCallClass(ClassName & "Ctor", False, callIds)
            b.AppendLine()
            b.AppendLine("internal ulong __retval;")
            b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }")
            b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }")
            b.AppendLine()
            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
            b.AppendLine("__retval = RemoteProxy.Wrap(new {0}());", ClassName)
            b.EndBlock()
            b.EndBlock()
            b.AppendLine()
        End If

        If Category = StructCategory.Values Then
            For Each sm In StructMembers
                b.BeginRemoteCallClass(ClassName & "Get" & sm.PublicName, False, callIds)
                b.AppendLine("internal ulong sender;")
                b.AppendLine("internal {0} value;", sm.MemberType.ProxySymbol)
                b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }")
                b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }")
                b.AppendLine("protected override void WriteReturn(StreamHandler h) { h.Write(value); }")
                b.AppendLine("protected override void ReadReturn(StreamHandler h) { h.Read(out value); }")
                b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender);", ClassName)
                b.AppendLine("value = {0};", sm.MemberType.ProxyWrapExpression("sender." & sm.PublicName))
                b.EndBlock()
                b.EndBlock()
                b.BeginRemoteCallClass(ClassName & "Set" & sm.PublicName, False, callIds)
                b.AppendLine("internal ulong sender;")
                b.AppendLine("internal {0} value;", sm.MemberType.ProxySymbol)
                b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }")
                b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }")
                b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender);", ClassName)
                b.AppendLine("sender.{0} = {1};", sm.PublicName, sm.MemberType.ProxyUnwrapExpression("value"))
                b.EndBlock()
                b.EndBlock()
            Next

        ElseIf Category = StructCategory.ApiCallbacks Then

            For i = 1 To StructMembers.Length - 1

                Dim sm = StructMembers(i)

                If Not GeneratorConfig.IsBrowserProcessOnly(struct.Name & "::" & sm.Name) Then

                    Dim cb = sm.Callback
                    Dim sig = cb.Signature

                    b.BeginRemoteCallClass(cb.EventName, True, callIds)
                    b.AppendLine()

                    b.BeginBlock("internal static void EventCall(object sender, {0} e)", cb.PublicEventArgsClassName)
                    b.AppendLine("var call = new {0}BrowserProcessCall();", cb.EventName)
                    b.AppendLine("call.sender = RemoteProxy.Wrap((CfxBase)sender);")
                    b.AppendLine("call.eventArgsId = AddEventArgs(e);")
                    b.AppendLine("call.Execute(RemoteClient.connection);")
                    b.AppendLine("RemoveEventArgs(call.eventArgsId);")
                    b.EndBlock()

                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                    b.AppendLine("var sender = {0}.Wrap(this.sender, connection.remoteRuntime);", RemoteClassName)
                    b.AppendLine("var e = new {0}(eventArgsId, connection.remoteRuntime);", cb.RemoteEventArgsClassName)
                    b.AppendLine("sender.raise_{0}(sender, e);", cb.PublicName)
                    b.EndBlock()
                    b.EndBlock()
                    b.AppendLine()

                    b.BeginRemoteCallClass(cb.EventName & "Activate", False, callIds)
                    b.AppendLine()
                    b.AppendLine("internal ulong sender;")
                    b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }")
                    b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }")
                    b.AppendLine()
                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                    b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender);", ClassName)
                    b.AppendLine("sender.{0} += {1}BrowserProcessCall.EventCall;", cb.PublicName, StructMembers(i).Callback.EventName)
                    b.EndBlock()
                    b.EndBlock()
                    b.AppendLine()

                    b.BeginRemoteCallClass(cb.EventName & "Deactivate", False, callIds)
                    b.AppendLine()
                    b.AppendLine("internal ulong sender;")
                    b.AppendLine("protected override void WriteArgs(StreamHandler h) { h.Write(sender); }")
                    b.AppendLine("protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }")
                    b.AppendLine()
                    b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                    b.AppendLine("var sender = ({0})RemoteProxy.Unwrap(this.sender);", ClassName)
                    b.AppendLine("sender.{0} -= {1}BrowserProcessCall.EventCall;", cb.PublicName, cb.EventName)
                    b.EndBlock()
                    b.EndBlock()
                    b.AppendLine()

                    For ii = 1 To sig.ManagedArguments.Length - 1
                        Dim arg = sig.ManagedArguments(ii)
                        If arg.ArgumentType.IsOut Then
                            b.BeginRemoteCallClass(cb.EventName & "Set" & arg.PublicPropertyName, False, callIds)
                            b.AppendLine()
                            b.AppendLine("internal ulong eventArgsId;")
                            arg.ArgumentType.EmitRemoteCallFields(b, "value")
                            b.AppendLine()

                            b.BeginBlock("protected override void WriteArgs(StreamHandler h)")
                            b.AppendLine("h.Write(eventArgsId);")
                            arg.ArgumentType.EmitRemoteWrite(b, "value")
                            b.EndBlock()

                            b.BeginBlock("protected override void ReadArgs(StreamHandler h)")
                            b.AppendLine("h.Read(out eventArgsId);")
                            arg.ArgumentType.EmitRemoteRead(b, "value")
                            b.EndBlock()

                            b.AppendLine()
                            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                            b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName)
                            arg.EmitProxyEventArgSetter(b)
                            b.EndBlock()

                            b.EndBlock()
                            b.AppendLine()
                        End If
                        If arg.ArgumentType.IsIn Then
                            b.BeginRemoteCallClass(cb.EventName & "Get" & arg.PublicPropertyName, False, callIds)
                            b.AppendLine()

                            b.AppendLine("internal ulong eventArgsId;")
                            arg.ArgumentType.EmitRemoteCallFields(b, "value")
                            b.AppendLine()

                            b.BeginBlock("protected override void WriteArgs(StreamHandler h)")
                            b.AppendLine("h.Write(eventArgsId);")
                            b.EndBlock()

                            b.BeginBlock("protected override void ReadArgs(StreamHandler h)")
                            b.AppendLine("h.Read(out eventArgsId);")
                            b.EndBlock()

                            b.BeginBlock("protected override void WriteReturn(StreamHandler h)")
                            arg.ArgumentType.EmitRemoteWrite(b, "value")
                            b.EndBlock()

                            b.BeginBlock("protected override void ReadReturn(StreamHandler h)")
                            arg.ArgumentType.EmitRemoteRead(b, "value")
                            b.EndBlock()

                            b.AppendLine()

                            b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                            b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName)
                            b.AppendLine("value = {0};", arg.ArgumentType.ProxyWrapExpression("e." & arg.PublicPropertyName))
                            b.EndBlock()

                            b.EndBlock()
                            b.AppendLine()

                        End If
                    Next

                    If Not sig.PublicReturnType.IsVoid Then
                        b.BeginRemoteCallClass(cb.EventName & "SetReturnValue", False, callIds)
                        b.AppendLine()
                        b.AppendLine("internal ulong eventArgsId;")
                        sig.PublicReturnType.EmitRemoteCallFields(b, "value")
                        b.AppendLine()

                        b.BeginBlock("protected override void WriteArgs(StreamHandler h)")
                        b.AppendLine("h.Write(eventArgsId);")
                        sig.PublicReturnType.EmitRemoteWrite(b, "value")
                        b.EndBlock()

                        b.BeginBlock("protected override void ReadArgs(StreamHandler h)")
                        b.AppendLine("h.Read(out eventArgsId);")
                        sig.PublicReturnType.EmitRemoteRead(b, "value")
                        b.EndBlock()

                        b.AppendLine()
                        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)")
                        b.AppendLine("var e = ({0})BrowserProcessCall.GetEventArgs(eventArgsId);", cb.PublicEventArgsClassName)
                        b.AppendLine("e.SetReturnValue({0});", sig.PublicReturnType.ProxyUnwrapExpression("value"))
                        b.EndBlock()

                        b.EndBlock()
                        b.AppendLine()
                    End If

                End If
            Next

        Else

            For Each f In ExportFunctions
                If Not GeneratorConfig.IsBrowserProcessOnly(f.Name) Then
                    If Not f.PrivateWrapper Then
                        b.BeginRemoteCallClass(ClassName & f.PublicName, False, callIds)
                        f.Signature.EmitRemoteCallClassBody(b)
                        b.EndBlock()
                        b.AppendLine()
                    End If
                End If
            Next

            For i = 1 To StructMembers.Length - 1
                If Not GeneratorConfig.IsBrowserProcessOnly(struct.Name & "::" & StructMembers(i).Name) Then
                    b.BeginRemoteCallClass(ClassName & StructMembers(i).PublicName, False, callIds)
                    StructMembers(i).CallbackSignature.EmitRemoteCallClassBody(b)
                    b.EndBlock()
                    b.AppendLine()
                End If
            Next

        End If



    End Sub


    Public Sub EmitRemoteClass(b As CodeBuilder)

        If Category = StructCategory.ApiCallbacks Then
            b.AppendLine("using Event;")
        End If

        b.AppendLine()

        b.AppendSummaryAndRemarks(comments, True, Category = StructCategory.ApiCallbacks)
        If IsRefCounted Then
            b.BeginClass(RemoteClassName & " : CfrBase", GeneratorConfig.ClassModifiers(RemoteClassName))
        Else
            b.BeginClass(RemoteClassName & " : CfrStructure", GeneratorConfig.ClassModifiers(RemoteClassName, "public sealed"))
        End If
        b.AppendLine()

        b.AppendLine("private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();")
        b.AppendLine()
        b.BeginFunction("Wrap", RemoteClassName, "ulong proxyId, CfrRuntime remoteRuntime", "internal static")
        b.AppendLine("if(proxyId == 0) return null;")
        b.BeginBlock("lock(weakCache)")
        b.AppendLine("var cfrObj = ({0})weakCache.Get(remoteRuntime, proxyId);", RemoteClassName)
        b.BeginBlock("if(cfrObj == null)")
        b.AppendLine("cfrObj = new {0}(proxyId, remoteRuntime);", RemoteClassName)
        b.AppendLine("weakCache.Add(remoteRuntime, proxyId, cfrObj);")
        b.EndBlock()
        b.AppendLine("return cfrObj;")
        b.EndBlock()
        b.EndBlock()
        b.AppendLine()
        b.AppendLine()


        If NeedsConstructor Then
            b.BeginFunction("CreateRemote", "ulong", "CfrRuntime remoteRuntime", "internal static")
            b.AppendLine("var call = new {0}CtorRenderProcessCall();", ClassName)
            b.AppendLine("call.Execute(remoteRuntime.connection);")
            b.AppendLine("return call.__retval;")
            b.EndBlock()
        End If

        For Each f In ExportFunctions
            If Not GeneratorConfig.IsBrowserProcessOnly(f.Name) AndAlso Not f.PrivateWrapper Then
                f.EmitRemoteFunction(b)
                b.AppendLine()
            End If
        Next

        If Category = StructCategory.ApiCallbacks Then

            b.AppendLine()

            For Each sm In StructMembers
                If sm.MemberType.IsCefCallbackType AndAlso Not GeneratorConfig.IsBrowserProcessOnly(struct.Name & "::" & sm.Name) Then
                    sm.MemberType.AsCefCallbackType.EmitRemoteRaiseEventFunction(b, sm.Comments)
                End If
            Next

        End If

        b.AppendLine()

        b.AppendLine("private {0}(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {{}}", RemoteClassName)

        If NeedsConstructor Then
            b.BeginBlock("public {0}(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime)", RemoteClassName)
            b.AppendLine("weakCache.Add(remoteRuntime, this.proxyId, this);")
            b.EndBlock()
        End If

        b.AppendLine()


        Select Case Category

            Case StructCategory.ApiCallbacks

                For Each sm In StructMembers
                    If sm.MemberType.IsCefCallbackType AndAlso Not GeneratorConfig.IsBrowserProcessOnly(struct.Name & "::" & sm.Name) Then
                        sm.MemberType.AsCefCallbackType.EmitRemoteEvent(b, sm.Comments)
                        b.AppendLine()
                    End If
                Next

            Case StructCategory.ApiCalls

                For Each p In m_structProperties
                    If GeneratorConfig.CreateRemoteProxy(struct.Name & "::" & p.Getter.Name) Then

                        Dim cb = p.Getter.MemberType.AsCefCallbackType

                        If p.Setter IsNot Nothing AndAlso p.Setter.Comments IsNot Nothing Then
                            Dim summaryLines As New List(Of String)
                            summaryLines.AddRange(p.Getter.Comments.Lines)
                            summaryLines.Add("")
                            summaryLines.AddRange(p.Setter.Comments.Lines)
                            Dim summary = New CommentData
                            summary.Lines = summaryLines.ToArray()
                            summary.FileName = p.Getter.Comments.FileName
                            'If RemoteClassName = "CfrRequest" AndAlso p.Getter.PublicName = "GetFlags" Then Stop
                            b.AppendSummaryAndRemarks(summary, True)
                        Else
                            b.AppendSummaryAndRemarks(p.Getter.Comments, True)
                        End If

                        b.BeginBlock("public {0} {1}", cb.RemoteReturnType.RemoteSymbol, p.PropertyName)
                        b.BeginBlock("get")
                        p.Getter.CallbackSignature.EmitRemoteCall(b)
                        b.EndBlock()
                        If p.Setter IsNot Nothing Then
                            b.BeginBlock("set")
                            p.Setter.CallbackSignature.EmitRemoteCall(b)
                            b.EndBlock()
                        End If
                        b.EndBlock()
                        b.AppendLine()

                    End If
                Next

                For Each sm In m_structFunctions
                    If GeneratorConfig.CreateRemoteProxy(struct.Name & "::" & sm.Name) Then
                        Dim cb = sm.MemberType.AsCefCallbackType
                        b.AppendSummaryAndRemarks(sm.Comments, True)
                        b.BeginFunction(sm.PublicName, cb.RemoteReturnType.RemoteSymbol, cb.Signature.RemoteSignature)
                        cb.Signature.EmitRemoteCall(b)
                        b.EndBlock()
                        b.AppendLine()
                    End If
                Next

            Case StructCategory.Values

                For Each sm In StructMembers
                    If sm.Name <> "size" Then

                        b.AppendLine("{0} m_{1};", sm.MemberType.RemoteSymbol, sm.PublicName)
                        b.AppendLine("bool m_{0}_fetched;", sm.PublicName)
                        b.AppendLine()

                        b.AppendSummaryAndRemarks(sm.Comments, True)
                        b.BeginBlock("public {1} {0}", CSharp.Escape(sm.PublicName), sm.MemberType.RemoteSymbol)
                        b.BeginBlock("get")
                        b.BeginIf("!m_{0}_fetched", sm.PublicName)
                        b.AppendLine("var call = new {0}Get{1}RenderProcessCall();", ClassName, sm.PublicName)
                        b.AppendLine("call.sender = this.proxyId;")
                        b.AppendLine("call.Execute(remoteRuntime.connection);")
                        b.AppendLine("m_{0} = {1};", sm.PublicName, sm.MemberType.RemoteWrapExpression("call.value"))
                        b.AppendLine("m_{0}_fetched = true;", sm.PublicName)
                        b.EndBlock()
                        b.AppendLine("return m_{0};", sm.PublicName)
                        b.EndBlock()
                        b.BeginBlock("set")
                        b.AppendLine("var call = new {0}Set{1}RenderProcessCall();", ClassName, sm.PublicName)
                        b.AppendLine("call.sender = this.proxyId;")
                        b.AppendLine("call.value = {0};", sm.MemberType.RemoteUnwrapExpression("value"))
                        b.AppendLine("call.Execute(remoteRuntime.connection);")
                        b.AppendLine("m_{0} = value;", sm.PublicName)
                        b.AppendLine("m_{0}_fetched = true;", sm.PublicName)
                        b.EndBlock()
                        b.EndBlock()
                        b.AppendLine()
                    End If
                Next

        End Select


        b.BeginFunction("OnDispose", "void", "ulong proxyId", "internal override")
        b.AppendLine("weakCache.Remove(remoteRuntime, proxyId);")
        b.EndBlock()


        b.EndBlock()


        If Category = StructCategory.ApiCallbacks Then
            b.AppendLine()
            b.BeginBlock("namespace Event")
            b.AppendLine()
            EmitRemoteEventArgs(b)
            b.EndBlock()
        End If

    End Sub

    Public Sub EmitPublicEventArgs(b As CodeBuilder)

        b.BeginBlock("namespace Event")
        b.AppendLine()


        For Each sm In StructMembers
            If sm.MemberType.IsCefCallbackType Then
                sm.MemberType.AsCefCallbackType.EmitPublicEventArgsAndHandler(b, sm.Comments)
                b.AppendLine()
            End If
        Next

        b.EndBlock()

    End Sub


    Public Sub EmitRemoteEventArgs(b As CodeBuilder)
        For Each sm In StructMembers
            If sm.MemberType.IsCefCallbackType AndAlso Not GeneratorConfig.IsBrowserProcessOnly(struct.Name & "::" & sm.Name) Then
                sm.MemberType.AsCefCallbackType.EmitRemoteEventArgsAndHandler(b, sm.Comments)
                b.AppendLine()
            End If
        Next
    End Sub

End Class
