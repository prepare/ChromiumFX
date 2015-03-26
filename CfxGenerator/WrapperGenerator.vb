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



Imports System.IO

Public Class WrapperGenerator

    Private ReadOnly decls As CefApiDeclarations
    Private ReadOnly remoteDecls As CefApiDeclarations

    Private ReadOnly maxCallbackCount As Integer

    Public Sub New(decls As CefApiDeclarations)
        Me.decls = decls
        Me.remoteDecls = decls.GetRemoteDeclarations()

        'For Each f In decls.ExportFunctions
        '    f.Signature.FindArrayArguments()
        'Next

        For Each t In decls.CefStructTypes
            If t.ClassBuilder.Category = StructCategory.ApiCallbacks Then
                If maxCallbackCount < t.ClassBuilder.StructMembers.Count - 1 Then
                    maxCallbackCount = t.ClassBuilder.StructMembers.Count - 1
                End If
            End If
            'For Each sm In t.StructMembers
            '    If sm.MemberType.IsCefCallbackType Then
            '        sm.MemberType.AsCefCallbackType.Signature.FindArrayArguments()
            '    End If
            'Next
        Next

    End Sub

    Public Sub Run()

        Dim fileManager = New GeneratedFileManager("libcfx\Generated")
        BuildLibCfx(fileManager)
        BuildAmalgamation(fileManager)
        BuildHeaders(fileManager)
        BuildFunctionPointers(fileManager)
        fileManager.DeleteObsoleteFiles()

        ''first pass without building files
        ''needed to set the WrapFunctionUsed and UnwrapFunctionUsed flags
        'fileManager = New GeneratedFileManager()
        'BuildCfxRuntime(fileManager)
        'BuildApiClasses(fileManager, StructCategory.ApiCalls)
        'BuildApiClasses(fileManager, StructCategory.ApiCallbacks)
        'BuildApiClasses(fileManager, StructCategory.Values)


        generatedCSFiles = New List(Of String)

        fileManager = New GeneratedFileManager("ChromiumFX\Generated")
        BuildPInvokeApi(fileManager)
        BuildEnums(fileManager)
        BuildCfxRuntime(fileManager)
        BuildApiClasses(fileManager, StructCategory.ApiCalls)
        BuildApiClasses(fileManager, StructCategory.ApiCallbacks)
        BuildApiClasses(fileManager, StructCategory.Values)
        fileManager.DeleteObsoleteFiles()
        generatedCSFiles.AddRange(fileManager.GetNewFiles())

        For Each struct In decls.CefStructTypes
            'Debug.Print("{0}: Wrap {1} Unwrap {2}", struct.ClassName, struct.ClassBuilder.WrapFunctionUsed, struct.ClassBuilder.UnwrapFunctionUsed)
        Next


        fileManager = New GeneratedFileManager("ChromiumFX\Generated\Remote")
        BuildRemoteCalls(fileManager)
        BuildCfrRuntime(fileManager)
        BuildRemoteClasses(fileManager)
        fileManager.DeleteObsoleteFiles()
        generatedCSFiles.AddRange(fileManager.GetNewFiles())

        generatedCSFiles.Sort()

        Dim projectFile = Path.Combine("ChromiumFX", "ChromiumFX.csproj")
        Dim project = File.ReadAllText(projectFile)
        Dim ex = New Regex("(?:\s*<Compile Include=""Generated(?:\\\w+)*?\\\w+.cs"" />)+")
        Dim p1 = ex.Replace(project, AddressOf ProjectMatch)
        If Not project.Equals(p1) Then
            File.WriteAllText(projectFile, p1)
        End If

    End Sub

    Private generatedCSFiles As List(Of String)
    Private Function ProjectMatch(m As Match) As String
        If generatedCSFiles IsNot Nothing Then
            Dim sb As New System.Text.StringBuilder
            sb.AppendLine()
            For i = 0 To generatedCSFiles.Count - 2
                sb.AppendFormat("    <Compile Include=""{0}"" />", generatedCSFiles(i).Substring(11))
                sb.AppendLine()
            Next
            sb.AppendFormat("    <Compile Include=""{0}"" />", generatedCSFiles(generatedCSFiles.Count - 1).Substring(11))
            generatedCSFiles = Nothing
            Return sb.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Sub BuildAmalgamation(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        Dim files = fileManager.GetNewFiles()
        For Each f In files
            b.AppendLine("#include ""{0}""", System.IO.Path.GetFileName(f))
        Next
        b.AppendLine()
        fileManager.WriteFileIfContentChanged("cfx_amalgamation.c", b.ToString())
    End Sub

    Private Sub BuildHeaders(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        Dim files = Directory.GetFiles("cef\include\capi")
        For Each f In files
            f = f.Replace("\", "/")
            b.AppendLine("#include ""{0}""", f.Substring(4))
        Next
        b.AppendLine()
        fileManager.WriteFileIfContentChanged("cef_headers.h", b.ToString())
        b.Clear()
    End Sub

    Private Sub BuildFunctionPointers(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        Dim ff = New List(Of CefExportFunction)(decls.AllExportFunctions())
        ff.AddRange(decls.StringCollectionFunctions)

        For Each f In ff
            Dim retSymbol = f.ReturnType.OriginalSymbol
            If f.Signature.ReturnValueIsConst Then
                retSymbol = "const " & retSymbol
            End If
            b.AppendLine("static {0} (*{1}_ptr)({2});", retSymbol, f.Name, f.Signature.OriginalSignature)
        Next
        b.AppendLine()

        b.BeginBlock("static void cfx_load_cef_function_pointers(void *libcef)")
        For Each f In ff
            If (f.Name <> "cef_api_hash") Then
                b.AppendLine("{0}_ptr = ({1} (*)({2}))cfx_platform_get_fptr(libcef, ""{0}"");", f.Name, f.ReturnType.OriginalSymbol, f.Signature.OriginalSignatureUnnamed)
            End If
        Next
        b.EndBlock()
        b.AppendLine()

        For Each f In ff
            b.AppendLine("#define {0} {0}_ptr", f.Name)
        Next
        b.AppendLine()

        fileManager.WriteFileIfContentChanged("cef_function_pointers.c", b.ToString())
        b.Clear()

        Dim cfxfuncs = decls.GetCfxApiFunctionNames()

        b.BeginBlock("static void* cfx_function_pointers[{0}] = ", cfxfuncs.Count)
        For i = 0 To cfxfuncs.Length - 1
            b.AppendLine("(void*){0},", cfxfuncs(i))
        Next
        b.EndBlock(";")

        fileManager.WriteFileIfContentChanged("cfx_function_pointers.c", b.ToString())

    End Sub

    Private Sub BuildLibCfx(fileManager As GeneratedFileManager)

        Dim b = New CodeBuilder
        CodeSnippets.BeginExternC(b)
        b.AppendLine()

        For Each f In decls.ExportFunctions
            f.EmitNativeFunction(b)
            b.AppendLine()
        Next
        b.AppendLine()

        CodeSnippets.EndExternC(b)
        fileManager.WriteFileIfContentChanged("cfx_runtime.c", b.ToString())

        b.Clear()



        For Each t In decls.CefStructTypes
            t.ClassBuilder.EmitNativeWrapper(b)
            fileManager.WriteFileIfContentChanged(t.CfxName & ".c", b.ToString())
            b.Clear()
        Next

        CodeSnippets.BeginExternC(b)
        b.AppendLine()
        For Each f In decls.StringCollectionFunctions
            f.EmitNativeFunction(b)
            b.AppendLine()
        Next
        CodeSnippets.EndExternC(b)
        fileManager.WriteFileIfContentChanged("cfx_string_collections.c", b.ToString())
        b.Clear()

    End Sub

    Private Sub BuildEnums(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        b.BeginCfxNamespace()
        For Each t In decls.CefEnumTypes
            t.EmitEnum(b)
        Next
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("CfxEnums.cs", b.ToString())
    End Sub

    Private Sub BuildCfxRuntime(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        b.BeginCfxNamespace()
        b.BeginClass("CfxRuntime", "public partial")
        b.AppendLine()
        For Each f In decls.ExportFunctions
            f.EmitPublicFunction(b)
            b.AppendLine()
        Next
        b.EndBlock()
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("CfxRuntime.cs", b.ToString())
    End Sub

    Private Sub BuildCfrRuntime(fileManager As GeneratedFileManager)

        Dim b = New CodeBuilder

        b.BeginCfxNamespace(".Remote")
        b.BeginClass("CfrRuntime", "public partial")
        b.AppendLine()

        For Each f In remoteDecls.ExportFunctions
            If Not f.PrivateWrapper Then
                f.EmitRemoteFunction(b)
                b.AppendLine()
            End If
        Next
        b.EndBlock()
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("CfrRuntime.cs", b.ToString())
    End Sub

    Private Sub BuildPInvokeApi(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder

        b.AppendLine("using System.Runtime.InteropServices;")
        b.AppendLine()
        b.BeginCfxNamespace()
        b.BeginClass("CfxApi", "internal partial")

        b.AppendLine()

        b.AppendComment("global cef export functions")
        b.AppendLine()

        For Each f In decls.ExportFunctions
            f.EmitPInvokeDeclaration(b)
        Next
        b.AppendLine()


        For Each f In decls.StringCollectionFunctions
            f.EmitPInvokeDeclaration(b)
        Next
        b.AppendLine()

        b.AppendLine()


        For Each t In decls.CefStructTypes
            t.ClassBuilder.EmitApiDeclarations(b)
            b.AppendLine()
        Next

        b.EndBlock()
        b.EndBlock()

        fileManager.WriteFileIfContentChanged("CfxApi.cs", b.ToString())
        b.Clear()

        Dim cfxfuncs = decls.GetCfxApiFunctionNames()
        b.BeginCfxNamespace()
        b.BeginClass("CfxApiLoader", "internal partial")
        b.BeginBlock("internal enum FunctionIndex")
        For Each f In cfxfuncs
            b.AppendLine(f & ",")
        Next

        b.EndBlock()
        b.AppendLine()

        b.BeginFunction("void LoadCfxRuntimeApi()", "internal static")
        For Each f In decls.ExportFunctions
            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
        Next
        b.EndBlock()
        b.AppendLine()

        b.BeginFunction("void LoadStringCollectionApi()", "internal static")
        For Each f In decls.StringCollectionFunctions
            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
        Next
        b.EndBlock()
        b.AppendLine()


        For Each struct In decls.CefStructTypes
            b.BeginBlock("internal static void Load{0}Api()", struct.ClassName)
            Select Case struct.ClassBuilder.Category
                Case StructCategory.ApiCalls
                    If struct.ClassBuilder.ExportFunctions.Count > 0 Then
                        For Each f In struct.ClassBuilder.ExportFunctions
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
                        Next
                    End If
                    For Each sm In struct.ClassBuilder.StructMembers
                        If sm.MemberType.IsCefCallbackType Then
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, struct.CfxName & "_" & sm.Name)
                        End If
                    Next
                Case StructCategory.ApiCallbacks
                    b.AppendLine("CfxApi.{0}_ctor = (CfxApi.cfx_ctor_with_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_ctor, typeof(CfxApi.cfx_ctor_with_gc_handle_delegate));", struct.CfxName)
                    b.AppendLine("CfxApi.{0}_get_gc_handle = (CfxApi.cfx_get_gc_handle_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_get_gc_handle, typeof(CfxApi.cfx_get_gc_handle_delegate));", struct.CfxName)
                    b.AppendLine("CfxApi.{0}_set_managed_callback = (CfxApi.cfx_set_callback_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_set_managed_callback, typeof(CfxApi.cfx_set_callback_delegate));", struct.CfxName)
                    If struct.ClassBuilder.ExportFunctions.Count > 0 Then
                        Stop
                    End If
                Case StructCategory.Values
                    b.AppendLine("CfxApi.{0}_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_ctor, typeof(CfxApi.cfx_ctor_delegate));", struct.CfxName)
                    b.AppendLine("CfxApi.{0}_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(FunctionIndex.{0}_dtor, typeof(CfxApi.cfx_dtor_delegate));", struct.CfxName)

                    For Each sm In struct.ClassBuilder.StructMembers
                        If sm.Name <> "size" Then
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, struct.CfxName & "_set_" & sm.Name)
                            CodeSnippets.EmitPInvokeDelegateInitialization(b, struct.CfxName & "_get_" & sm.Name)
                        End If
                    Next
                    If struct.ClassBuilder.ExportFunctions.Count > 0 Then
                        Stop
                    End If

            End Select
            b.EndBlock()
            b.AppendLine()

        Next

        b.EndBlock()
        b.EndBlock()

        fileManager.WriteFileIfContentChanged("CfxApiLoader.cs", b.ToString())

    End Sub


    Private Sub BuildApiClasses(fileManager As GeneratedFileManager, category As StructCategory)
        Dim b = New CodeBuilder
        For Each t In decls.CefStructTypes
            If t.ClassBuilder.Category = category Then
                b.BeginCfxNamespace()
                t.ClassBuilder.EmitPublicClass(b)
                b.EndBlock()
                fileManager.WriteFileIfContentChanged(t.ClassName & ".cs", b.ToString())
                b.Clear()
            End If
        Next
    End Sub


    Private Sub BuildRemoteCalls(fileManager As GeneratedFileManager)

        Dim callIds = New List(Of String)

        Dim b = New CodeBuilder
        b.BeginCfxNamespace(".Remote")
        For Each f In remoteDecls.ExportFunctions
            If Not f.PrivateWrapper Then
                b.BeginRemoteCallClass("CfxRuntime" & f.PublicName, False, callIds)
                f.Signature.EmitRemoteCallClassBody(b)
                b.EndBlock()
                b.AppendLine()
            End If
        Next
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("CfxRuntimeRemoteCalls.cs", b.ToString())

        For Each t In remoteDecls.CefStructTypes
            b.Clear()
            b.BeginCfxNamespace(".Remote")
            t.ClassBuilder.EmitRemoteCalls(b, callIds)
            b.EndBlock()
            fileManager.WriteFileIfContentChanged(t.ClassName & "RemoteCalls.cs", b.ToString())
        Next

        callIds.AddRange(GeneratorConfig.AdditionalCallIds)

        b.Clear()
        b.BeginCfxNamespace(".Remote")
        b.BeginBlock("internal enum RemoteCallId : ushort")
        For Each id In callIds
            b.AppendLine(id & ",")
        Next
        b.TrimRight()
        b.CutRight(1)
        b.AppendLine()
        b.EndBlock()
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("RemoteCallId.cs", b.ToString())

        b.Clear()
        b.BeginCfxNamespace(".Remote")
        b.BeginClass("RemoteCallConstructor", "internal")
        b.AppendLine("private delegate RemoteCall RemoteCallCtor();")
        b.BeginBlock("private static RemoteCallCtor[] callConstructors = ")
        For Each id In callIds
            b.AppendLine("() => {{ return new {0}(); }},", id)
        Next
        b.EndBlock(";")
        b.AppendLine()

        b.BeginBlock("internal static RemoteCall ForCallId(RemoteCallId id)")
        b.AppendLine("return callConstructors[(int)id]();")
        b.EndBlock()
        b.EndBlock()
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("RemoteCallConstructor.cs", b.ToString())


    End Sub

    Private Sub BuildRemoteClasses(fileManager As GeneratedFileManager)
        For Each t In remoteDecls.CefStructTypes
            Dim b = New CodeBuilder
            b.BeginCfxNamespace(".Remote")
            t.ClassBuilder.EmitRemoteClass(b)
            b.EndBlock()
            fileManager.WriteFileIfContentChanged(t.RemoteClassName & ".cs", b.ToString())
        Next
    End Sub


End Class
