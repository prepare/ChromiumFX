Public Class StringCollectionAsRetvalSignature
    Inherits Signature

    Public Sub New(parent As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder)
        MyBase.New(parent, sd, api)
    End Sub


    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return New Argument() {MyBase.ManagedArguments(0)}
        End Get
    End Property

    Public Overrides ReadOnly Property PublicReturnType As ApiType
        Get
            Return MyBase.ManagedArguments(1).ArgumentType
        End Get
    End Property


    Public Overrides Sub EmitPublicCall(b As CodeBuilder)
        b.AppendLine("{0} {1} = new {0}();", MyBase.ManagedArguments(1).ArgumentType.PublicSymbol, MyBase.ManagedArguments(1).VarName)
        MyBase.ManagedArguments(1).EmitPrePublicCallStatements(b)
        b.AppendLine(String.Format("CfxApi.{0}(NativePtr, {1});", Owner.CfxApiFunctionName, MyBase.ManagedArguments(1).PublicUnwrapExpression))
        MyBase.ManagedArguments(1).EmitPostPublicStatements(b)
        b.AppendLine("return {0};", MyBase.ManagedArguments(1).VarName)
    End Sub

End Class
