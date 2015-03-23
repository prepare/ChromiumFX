Imports System.Reflection

Public Class AssemblyResources

    Private Shared m_resourceNames As String()
    Public Shared ReadOnly Property ResourceNames As String()
        Get
            
            If m_resourceNames Is Nothing Then
                Dim asm = Assembly.GetExecutingAssembly()
                m_resourceNames = asm.GetManifestResourceNames()
            End If
            Return m_resourceNames
        End Get
    End Property

    Public Shared Function GetResourceName(partialName As String) As String
        Dim name As String = Nothing
        For Each rn In ResourceNames
            If rn.Contains(partialName) Then
                Return rn
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function GetStream(partialName As String) As System.IO.Stream
        Dim name = GetResourceName(partialName)
        If name Is Nothing Then Return Nothing
        Return Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
    End Function

    Public Shared Function GetBinary(partialName As String) As Byte()
        Dim stream = GetStream(partialName)
        Dim data = New IO.MemoryStream
        stream.CopyTo(data)
        Return data.ToArray()
    End Function

    Public Shared Function GetString(partialName As String) As String
        Using stream = GetStream(partialName)
            Using reader = New IO.StreamReader(stream)
                Return reader.ReadToEnd()
            End Using
        End Using
    End Function

    Public Shared Function GetLines(partialName As String) As String()
        Using stream = GetStream(partialName)
            Using reader = New IO.StreamReader(stream)
                Dim ll = New List(Of String)
                Dim l = reader.ReadLine()
                While l IsNot Nothing
                    ll.Add(l)
                    l = reader.ReadLine()
                End While
                Return ll.ToArray()
            End Using
        End Using
    End Function

    Public Shared Function GetData(partialName As String) As Byte()
        Dim data = New System.IO.MemoryStream
        Using stream = GetStream(partialName)
            stream.CopyTo(data)
        End Using
        Return data.GetBuffer()
    End Function

End Class