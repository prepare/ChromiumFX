Public Class SignatureWithStructArray
    Inherits Signature

    Private arrayIndex As Integer
    Private countIndex As Integer

    Private m_publicArguments As Argument()

    Public Sub New(parent As ISignatureParent, sd As Parser.SignatureData, api As ApiTypeBuilder, arrayIndex As Integer, countIndex As Integer)
        MyBase.New(parent, sd, api)
        Me.arrayIndex = arrayIndex
        Me.countIndex = countIndex

        Dim list = New List(Of Argument)
        For i = 0 To Arguments.Length - 1
            If i <> arrayIndex AndAlso i <> countIndex Then
                list.Add(Arguments(i))
            ElseIf i = arrayIndex Then
                Dim a = New Argument(Arguments(arrayIndex), New CefStructArrayType(Arguments(arrayIndex), Arguments(countIndex)))
                list.Add(a)
                Arguments(i) = a
            End If
        Next
        m_publicArguments = list.ToArray()
    End Sub

    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return m_publicArguments
        End Get
    End Property


    Public Overrides Sub DebugPrintUnhandledArrayArguments()
    End Sub

End Class
