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

Public Class GeneratedFileManager

    Private directoryPath As String
    Private oldFiles As New HashSet(Of String)
    Private newFiles As New List(Of String)

    Private licenseStub As String

    Public Sub New(directoryPath As String)
        Me.directoryPath = directoryPath
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        Dim files = Directory.GetFiles(directoryPath)
        For Each f In files
            oldFiles.Add(f)
        Next

        licenseStub = AssemblyResources.GetString("LicenseStub")

    End Sub

    Public Sub New()
        'need a dummp writer
        directoryPath = Nothing
    End Sub

    Public Sub WriteFileIfContentChanged(filename As String, content As String)

        If directoryPath = Nothing Then Return

        Dim filepath = Path.Combine(directoryPath, filename)

        If newFiles.Contains(filepath) Then
            Stop
        End If

        Dim b = New CodeBuilder
        b.AppendLine(licenseStub)
        b.AppendComment("Generated file. Do not edit.")
        b.AppendLine()
        b.AppendLine()
        b.Append(content)

        content = b.ToString()

        Dim oldcontent = String.Empty
        If oldFiles.Contains(filepath) Then
            oldcontent = File.ReadAllText(filepath)
            oldFiles.Remove(filepath)
        End If

        If Not content.Equals(oldcontent) Then
            File.WriteAllText(filepath, content)
        End If

        newFiles.Add(filepath)

    End Sub

    Public Sub DeleteObsoleteFiles()
        For Each f In oldFiles
            File.Delete(f)
        Next
    End Sub

    Public Function GetNewFiles() As String()
        Return newFiles.ToArray()
    End Function



    Shared Sub PatchFilesLicense(dir As String)

        Dim licenseStub = AssemblyResources.GetString("LicenseStub")
        Dim licenseVB = licenseStub.Replace("//", "''")

        Dim files = Directory.GetFiles(dir)
        For Each f In files
            Dim ext = Path.GetExtension(f)
            If New String() {".cs", ".vb", ".c", ".cpp", ".h"}.Contains(ext.ToLowerInvariant()) Then
                Dim content = File.ReadAllText(f)

                If Not content.StartsWith("'' Copyright") AndAlso Not content.StartsWith("// Copyright") Then
                    Dim b = New CodeBuilder
                    If ext = ".vb" Then
                        b.AppendLine(licenseVB)
                    Else

                        b.AppendLine(licenseStub)
                    End If

                    b.AppendLine()
                    b.AppendLine()
                    b.Append(content)

                    content = b.ToString()

                    Debug.Print(f)
                    File.WriteAllText(f, content)

                Else
                    Debug.Assert(content.StartsWith(licenseVB) OrElse content.StartsWith(licenseStub))
                End If
            End If
        Next

        Dim dirs = Directory.GetDirectories(dir)
        For Each d In dirs
            If Not d.EndsWith(".hg") AndAlso Not d.Contains("\Generated\") AndAlso Not d.Contains("\cef\") Then
                PatchFilesLicense(d)
            End If
        Next


    End Sub


End Class
