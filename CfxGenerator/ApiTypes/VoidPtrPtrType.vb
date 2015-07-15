Public Class VoidPtrPtrType
    Inherits ApiType

    Sub New()
        MyBase.New("void**")
    End Sub

    Public Overrides ReadOnly Property IsIn As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property IsOut As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return "IntPtr"
        End Get
    End Property

    Public Overrides Function PInvokeCallSignature(var As String) As String
        Return "out IntPtr " & CSharp.Escape(var)
    End Function


End Class
