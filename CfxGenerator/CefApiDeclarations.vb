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



Public Class CefApiDeclarations

    Public ReadOnly ExportFunctions As CefExportFunction()
    Public ReadOnly CefStructTypes As CefStructType()
    Public ReadOnly CefEnumTypes As CefEnumType()
    Public ReadOnly StringCollectionTypes As StringCollectionType()
    Public ReadOnly StringCollectionFunctions As CefExportFunction()


    Public Sub New(exportFunctions As CefExportFunction(), cefStructTypes As CefStructType(), cefEnumTypes As CefEnumType(), stringCollectionTypes As StringCollectionType(), stringCollectionFunctions As CefExportFunction())
        Me.ExportFunctions = exportFunctions
        Me.CefStructTypes = cefStructTypes
        Me.CefEnumTypes = cefEnumTypes
        Me.StringCollectionTypes = stringCollectionTypes
        Me.StringCollectionFunctions = stringCollectionFunctions
    End Sub

    Private remoteFuncs As SortedDictionary(Of String, CefExportFunction)
    Private remoteStructs As SortedDictionary(Of String, CefStructType)

    Private retval As String()
    Public Function GetCfxApiFunctionNames() As String()
        If retval Is Nothing Then
            Dim list = New List(Of String)
            For Each f In ExportFunctions
                f.ApiIndex = list.Count
                list.Add(f.CfxName)
            Next
            For Each st In CefStructTypes
                For Each f In st.ClassBuilder.ExportFunctions
                    f.ApiIndex = list.Count
                    list.Add(f.CfxName)
                Next
                Select Case st.ClassBuilder.Category
                    Case StructCategory.ApiCalls
                        For Each sm In st.ClassBuilder.StructMembers
                            If sm.MemberType.IsCefCallbackType Then
                                sm.ApiIndex = list.Count
                                list.Add(sm.Callback.CfxApiFunctionName)
                            End If
                        Next
                    Case StructCategory.ApiCallbacks
                        st.ApiIndex = list.Count
                        list.Add(st.CfxName & "_ctor")
                        list.Add(st.CfxName & "_get_gc_handle")
                        list.Add(st.CfxName & "_set_managed_callback")
                    Case StructCategory.Values
                        st.ApiIndex = list.Count
                        list.Add(st.CfxName & "_ctor")
                        list.Add(st.CfxName & "_dtor")
                        For Each sm In st.ClassBuilder.StructMembers
                            If sm.Name <> "size" Then
                                sm.ApiIndex = list.Count
                                list.Add(st.CfxName & "_set_" & sm.Name)
                                list.Add(st.CfxName & "_get_" & sm.Name)
                            End If
                        Next
                End Select
            Next

            For Each f In StringCollectionFunctions
                f.ApiIndex = list.Count
                list.Add(f.CfxName)
            Next

            retval = list.ToArray()
        End If
        Return retval
    End Function

    Public Function GetRemoteDeclarations() As CefApiDeclarations

        remoteFuncs = New SortedDictionary(Of String, CefExportFunction)
        remoteStructs = New SortedDictionary(Of String, CefStructType)

        For Each f In ExportFunctions
            If Not GeneratorConfig.IsBrowserProcessOnly(f.Name) Then
                AddRemoteFunc(f)
            End If
        Next

        Return New CefApiDeclarations(remoteFuncs.Values.ToArray(), remoteStructs.Values.ToArray(), CefEnumTypes, Nothing, Nothing)

    End Function

    Private Sub AddRemoteFunc(f As CefExportFunction)
        If remoteFuncs.ContainsKey(f.Name) Then Return
        remoteFuncs.Add(f.Name, f)
        AnalyzeSignature(f.Signature)
    End Sub

    Private Sub AnalyzeSignature(sig As Signature)
        If sig.PublicReturnType.IsCefStructType Then
            AddRemoteStruct(sig.PublicReturnType.AsCefStructType)
        ElseIf sig.PublicReturnType.IsCefStructPtrType Then
            AddRemoteStruct(sig.PublicReturnType.AsCefStructPtrType.Struct)
        End If

        For Each arg In sig.ManagedArguments
            If arg.ArgumentType.IsCefStructType Then
                AddRemoteStruct(arg.ArgumentType.AsCefStructType)
            ElseIf arg.ArgumentType.IsCefStructPtrType Then
                AddRemoteStruct(arg.ArgumentType.AsCefStructPtrType.Struct)
            End If
        Next
    End Sub

    Private Sub AddRemoteStruct(s As CefStructType)


        If remoteStructs.ContainsKey(s.Name) Then Return
        remoteStructs.Add(s.Name, s)

        For Each f In s.ClassBuilder.ExportFunctions
            If Not GeneratorConfig.IsBrowserProcessOnly(f.Name) Then
                AnalyzeSignature(f.Signature)
            End If
        Next

        For Each sm In s.ClassBuilder.StructMembers
            If Not GeneratorConfig.IsBrowserProcessOnly(s.Name & "::" & sm.Name) Then
                If sm.MemberType.IsCefStructType Then
                    AddRemoteStruct(sm.MemberType.AsCefStructType)
                ElseIf sm.MemberType.IsCefStructPtrType Then
                    AddRemoteStruct(sm.MemberType.AsCefStructPtrType.Struct)
                ElseIf sm.MemberType.IsCefCallbackType Then
                    AnalyzeSignature(sm.MemberType.AsCefCallbackType.Signature)
                End If
            End If
        Next

    End Sub


    Private funcs As CefExportFunction()
    Public Function AllExportFunctions() As CefExportFunction()
        If funcs Is Nothing Then
            Dim ff = New List(Of CefExportFunction)(ExportFunctions)
            For Each t In CefStructTypes
                ff.AddRange(t.ClassBuilder.ExportFunctions)
            Next
            funcs = ff.ToArray()
        End If
        Return funcs
    End Function

End Class
