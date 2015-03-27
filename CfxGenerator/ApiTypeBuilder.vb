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
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ApiTypeBuilder

    Private apiData As Parser.CefApiData
    Private apiTypes As SortedDictionary(Of String, ApiType)

    Private constStringPtrType As CefStringPtrTypeConst

    Public Function GetDeclarations() As CefApiDeclarations
        apiData = Deserialize()
        If apiData Is Nothing Then
            Dim parser = New Parser.ApiParser
            apiData = parser.Parse()
            Serialize(apiData)
        End If
        Return BuildTypes()
    End Function

    Private Sub Serialize(apiData As Parser.CefApiData)
        Dim formatter = New BinaryFormatter
        Dim stream = New FileStream("cef\SerializedApi.data", FileMode.Create, FileAccess.Write, FileShare.None)
        formatter.Serialize(stream, apiData)
        stream.Close()
    End Sub

    Private Function Deserialize() As Parser.CefApiData

        If Not File.Exists("cef\SerializedApi.data") Then Return Nothing
        Dim formatter = New BinaryFormatter
        Dim stream = New FileStream("cef\SerializedApi.data", FileMode.Open, FileAccess.Read, FileShare.Read)
        Try
            Return DirectCast(formatter.Deserialize(stream), Parser.CefApiData)
        Catch ex As Exception
            Return Nothing
        Finally
            stream.Close()
        End Try
    End Function

    Private Function BuildTypes() As CefApiDeclarations

        Dim structs = New List(Of CefStructType)
        Dim enums = New List(Of CefEnumType)
        Dim stringCollectionTypes = New List(Of StringCollectionType)
        Dim stringCollectionFunctions As New List(Of CefExportFunction)
        Dim functions As New List(Of CefExportFunction)


        apiTypes = New SortedDictionary(Of String, ApiType)

        AddType(New ApiType("void"))

        AddType(New CefBaseType)
        AddType(New CefBasePtrType)

        AddType(New CefColorType)

        AddType(New BooleanInteger)
        AddType(New BooleanIntegerOutType)

        AddType(New OpaquePtrType("XDisplay"))
        AddType(New CefPlatformBasePtrType("cef_window_info_t*"))
        AddType(New CefPlatformBasePtrType("cef_main_args_t*"))

        Dim tStr As ApiType = New CefStringType
        AddType(tStr)
        AddType(New CefStringPtrType(tStr.AsCefStringType))
        constStringPtrType = New CefStringPtrTypeConst(tStr.AsCefStringType)

        AddType(New CefStringUserFreeType)

        NumericType.CreateAll(Me)

        Dim bTypes = AssemblyResources.GetLines("BlittableTypes.txt")
        For Each bt In bTypes
            Dim def = bt.Split("|"c)
            If def.Length = 2 AndAlso def(0).Length > 0 AndAlso def(1).Length > 0 Then
                AddType(New BlittableType(def(0), def(1)))
            End If
        Next

        AddType(New VoidPtrPtrType())

        For Each ed In apiData.CefEnums
            Dim t = New CefEnumType(ed)
            AddType(t)
            enums.Add(t)
        Next

        For Each sd In apiData.CefStructs
            If Not apiTypes.Keys.Contains(sd.Name) Then
                Dim structName = sd.Name.Substring(0, sd.Name.Length - 2)
                Dim t = New CefStructType(structName, sd.Comments)
                AddType(t)
                structs.Add(t)
            End If
        Next

        For Each sd In apiData.CefStructsWindows
            Dim structName = sd.Name.Substring(0, sd.Name.Length - 2)
            Dim t = New CefPlatformStructType(structName, sd.Comments, CefPlatform.Windows)
            AddType(t)
            structs.Add(t)
        Next

        For Each sd In apiData.CefStructsLinux
            Dim structName = sd.Name.Substring(0, sd.Name.Length - 2)
            Dim t = New CefPlatformStructType(structName, sd.Comments, CefPlatform.Linux)
            AddType(t)
            structs.Add(t)
        Next

        stringCollectionTypes.Add(New CefStringListType)
        stringCollectionTypes.Add(New CefStringMapType)
        stringCollectionTypes.Add(New CefStringMultimapType)

        For Each t In stringCollectionTypes
            AddType(t)
        Next

        
        For Each sd In apiData.CefStructs
            Dim t = apiTypes(sd.Name)
            If t.IsCefStructType Then
                t.AsCefStructType.SetMembers(sd, Me)
            End If
        Next

        For Each sd In apiData.CefStructsWindows
            Dim t = apiTypes(sd.Name.Substring(0, sd.Name.Length - 2) & "_windows")
            t.AsCefStructType.SetMembers(sd, Me)
        Next

        For Each sd In apiData.CefStructsLinux
            Dim t = apiTypes(sd.Name.Substring(0, sd.Name.Length - 2) & "_linux")
            t.AsCefStructType.SetMembers(sd, Me)
        Next

        For Each fd In apiData.CefStringCollectionFunctions
            stringCollectionFunctions.Add(New CefExportFunction(Nothing, fd, Me))
        Next

        For Each fd In apiData.CefFunctions
            Dim f = New CefExportFunction(Nothing, fd, Me)
            functions.Add(f)
        Next

        functions.Sort(New CefExportFunction.Comparer)
        structs.Sort(New ApiType.Comparer)
        enums.Sort(New ApiType.Comparer)

        Dim decl = New CefApiDeclarations(functions.ToArray(), structs.ToArray(), enums.ToArray(), stringCollectionTypes.ToArray(), stringCollectionFunctions.ToArray())
        Return decl

    End Function

    Public Sub AddType(t As ApiType)
        For Each m In t.ParserMatches
            apiTypes.Add(m, t)
        Next
    End Sub

    Public Function GetApiType(td As Parser.TypeData, isConst As Boolean) As ApiType

        Dim t = FindApiType(td)

        If t.IsCefStringPtrType AndAlso isConst Then
            Return constStringPtrType
        End If

        Return t
    End Function

    Private Function FindApiType(td As Parser.TypeData) As ApiType

        Dim t As ApiType = Nothing

        If td.Indirection Is Nothing Then
            If Not apiTypes.TryGetValue(td.Name, t) Then
                Stop
            End If
            Return t
        End If

        If apiTypes.TryGetValue(td.Name & td.Indirection, t) Then
            Return t
        End If

        If Not apiTypes.TryGetValue(td.Name, t) Then
            Stop
        End If

        If t.IsCefStructType Then
            If td.Indirection.Count(Function(c As Char) c.Equals("*"c)) = 1 Then
                t = New CefStructPtrType(t.AsCefStructType, td.Indirection)
            ElseIf td.Indirection = "**" Then
                Dim t0 = New CefStructPtrType(t.AsCefStructType, "*")
                t = New CefStructOutType(t0, td.Indirection)
                't = New CefStructRefType(t0, td.Indirection)
                'Debug.Print("StructRef " & t.ToString())
            ElseIf td.Indirection.Count(Function(c As Char) c.Equals("*"c)) = 2 Then
                Dim t0 = New CefStructPtrType(t.AsCefStructType, "*")
                t = New CefStructPtrPtrType(t0, td.Indirection)
            Else
                Stop
            End If
        ElseIf t.IsBlittableType Then
            t = New BlittablePtrType(t.AsBlittableType, td.Indirection)
        Else
            Stop
        End If

        AddType(t)

        Return t
    End Function

End Class
