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
            b.AppendLine("#include ""{0}""", f)
        Next
        b.AppendLine()
        fileManager.WriteFileIfContentChanged("cfx_amalgamation.c", b.ToString())
    End Sub

    Private Sub BuildHeaders(fileManager As GeneratedFileManager)
        Dim b = New CodeBuilder
        Dim files = Directory.GetFiles("cef\include\capi")
        For Each f In files
            b.AppendLine("#include ""{0}""", f)
        Next
        b.AppendLine()
        fileManager.WriteFileIfContentChanged("cfx_headers.h", b.ToString())
        b.Clear()
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

        For Each t In decls.StringCollectionTypes
            CodeSnippets.BeginExternC(b)
            b.AppendLine()
            For Each f In t.ExportFunctions
                f.EmitNativeFunction(b)
                b.AppendLine()
            Next
            CodeSnippets.EndExternC(b)
            fileManager.WriteFileIfContentChanged(t.CfxName & ".c", b.ToString())
            b.Clear()
        Next

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
        b.AppendComment("global cef export functions")
        b.AppendLine()

        For Each f In decls.ExportFunctions
            f.EmitPInvokeDeclaration(b)
        Next
        b.AppendLine()

        For Each o In decls.StringCollectionTypes
            For Each f In o.ExportFunctions
                f.EmitPInvokeDeclaration(b)
            Next
            b.AppendLine()
        Next

        b.AppendLine()


        For Each t In decls.CefStructTypes
            t.ClassBuilder.EmitApiDeclarations(b)
            b.AppendLine()
        Next

        b.EndBlock()
        b.EndBlock()

        fileManager.WriteFileIfContentChanged("CfxApi.cs", b.ToString())

        b.Clear()

        b.AppendLine("using System.Runtime.InteropServices;")
        b.AppendLine()
        b.BeginCfxNamespace()
        b.BeginClass("CfxApi", "internal partial")
        b.BeginFunction("void InitializeDelegates()", "private static")

        b.AppendLine()

        For Each f In decls.ExportFunctions
            CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
        Next

        For Each o In decls.StringCollectionTypes
            For Each f In o.ExportFunctions
                CodeSnippets.EmitPInvokeDelegateInitialization(b, f.CfxName)
            Next
            b.AppendLine()
        Next

        b.AppendLine()
        b.AppendLine()

        For Each t In decls.CefStructTypes
            t.ClassBuilder.EmitApiInitialization(b)
            b.AppendLine()
            b.AppendLine()
        Next

        b.EndBlock()
        b.EndBlock()
        b.EndBlock()

        fileManager.WriteFileIfContentChanged("CfxApiInit.cs", b.ToString())

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
        b.BeginClass("RemoteCallSwitch", "internal")
        b.BeginBlock("internal static RemoteCall ForCallId(RemoteCallId id)")
        b.BeginBlock("switch(id)")
        For Each id In callIds
            b.AppendLine("case RemoteCallId.{0}:", id)
            b.IncreaseIndent()
            b.AppendLine("return new {0}();", id)
            b.DecreaseIndent()
        Next
        b.AppendLine("default:")
        b.AppendComment("unreached")
        b.AppendLine("return null;")
        b.EndBlock()
        b.EndBlock()
        b.EndBlock()
        b.EndBlock()
        fileManager.WriteFileIfContentChanged("RemoteCallSwitch.cs", b.ToString())

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
