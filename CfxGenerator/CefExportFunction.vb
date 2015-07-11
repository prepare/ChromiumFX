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



Public Class CefExportFunction
    Implements ISignatureOwner

    Public Class Comparer
        Implements IComparer(Of CefExportFunction)
        Public Function Compare(x As CefExportFunction, y As CefExportFunction) As Integer Implements System.Collections.Generic.IComparer(Of CefExportFunction).Compare
            Return String.Compare(x.Name, y.Name)
        End Function
    End Class

    Public ReadOnly Name As String
    Public ReadOnly Signature As Signature
    Public ReadOnly PrivateWrapper As Boolean
    Public ReadOnly Comments As CommentData

    Public ReadOnly Parent As CefType

    Public ApiIndex As Integer

    Public ReadOnly Platform As CefPlatform

    Public Sub New(parent As CefType, fd As Parser.FunctionData, api As ApiTypeBuilder, platform As CefPlatform)
        Me.Name = fd.Name
        Me.Comments = fd.Comments
        Me.Signature = Signature.Create(Me, fd.Signature, api)
        Me.PrivateWrapper = GeneratorConfig.HasPrivateWrapper(Me.Name)
        Me.Parent = parent
        Me.Platform = platform
    End Sub

    Public Sub New(parent As CefType, fd As Parser.FunctionData, api As ApiTypeBuilder)
        Me.New(parent, fd, api, CefPlatform.Independent)
    End Sub

    Public ReadOnly Property CfxName As String
        Get
            Static _name As String = "cfx_" & Name.Substring(4)
            Return _name
        End Get
    End Property

    Public ReadOnly Property ReturnType As ApiType
        Get
            Return Signature.PublicReturnType
        End Get
    End Property

    Public ReadOnly Property PublicName As String
        Get
            Static _name As String = CSharp.ApplyStyle(Name).Substring(If(Parent Is Nothing, 3, Parent.ClassName.Length)) & If(PrivateWrapper, "Private", "")
            Return _name
        End Get
    End Property

    Public ReadOnly Property ProxyFunctionName As String
        Get
            Static _name As String = CSharp.ApplyStyle(CfxName).Substring(If(Parent Is Nothing, 3, 0))
            Return _name
        End Get
    End Property

    Public Sub EmitPInvokeDeclaration(b As CodeBuilder)
        b.AppendComment(Me.ToString())
        CodeSnippets.EmitPInvokeDelegate(b, CfxName, Signature)
    End Sub

    Public Sub EmitNativeFunction(b As CodeBuilder)

        b.AppendComment(Me.ToString())
        If Platform <> CefPlatform.Independent Then
            b.AppendLine("#ifdef CFX_" & Platform.ToString().ToUpperInvariant())
        End If
        b.BeginBlock(Signature.NativeSignature(CfxName))
        Signature.EmitNativeCall(b, Name)
        b.EndBlock()
        If Platform <> CefPlatform.Independent Then
            b.AppendLine("#else")
            b.AppendLine("#define {0} 0", CfxName)
            b.AppendLine("#endif")
        End If
    End Sub

    Public Sub EmitPublicFunction(b As CodeBuilder)

        b.AppendSummaryAndRemarks(Comments)

        Dim modifiers = If(PrivateWrapper, "private", "public")

        If Signature.ManagedArguments.Length = 0 OrElse Not Signature.ManagedArguments(0).IsThisArgument Then
            modifiers &= " static"
        End If

        b.BeginFunction(Signature.PublicSignature(PublicName), modifiers)
        If Platform <> CefPlatform.Independent Then
            b.AppendLine("CfxApi.CheckPlatformOS(CfxPlatformOS.{0});", Platform.ToString())
        End If

        Signature.EmitPublicCall(b)
        b.EndBlock()

    End Sub

    Public Sub EmitRemoteFunction(b As CodeBuilder)

        b.AppendSummaryAndRemarks(Comments, True)

        If Parent Is Nothing Then
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, Signature.RemoteSignature)
            Signature.EmitRemoteCall(b)
        Else
            Dim sig = Signature.RemoteSignature
            If String.IsNullOrWhiteSpace(sig) Then
                sig = "CfrRuntime remoteRuntime"
            Else
                sig = "CfrRuntime remoteRuntime, " & sig
            End If
            b.BeginFunction(PublicFunctionName, ReturnType.RemoteSymbol, sig, "public static")
            Signature.EmitRemoteCall(b)
        End If
        b.EndBlock()

    End Sub


    Public Overrides Function ToString() As String
        Return String.Format("CEF_EXPORT {1} {0}({2});", Name, ReturnType, Signature)
    End Function

    Public ReadOnly Property CallType As CfxCallMode Implements ISignatureOwner.CallMode
        Get
            Return CfxCallMode.FunctionCall
        End Get
    End Property

    Public ReadOnly Property CefName As String Implements ISignatureOwner.CefName
        Get
            Return Name
        End Get
    End Property

    Public ReadOnly Property CfxApiFunctionName As String Implements ISignatureOwner.CfxApiFunctionName
        Get
            Return CfxName
        End Get
    End Property

    Public ReadOnly Property PublicFunctionName As String Implements ISignatureOwner.PublicFunctionName
        Get
            Return PublicName
        End Get
    End Property

    Public ReadOnly Property PropertyName As String Implements ISignatureOwner.PropertyName
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property RemoteCallId As String Implements ISignatureOwner.RemoteCallId
        Get
            Return PublicClassName & PublicName & "RenderProcessCall"
        End Get
    End Property

    Public ReadOnly Property PublicClassName As String Implements ISignatureOwner.PublicClassName
        Get
            If Parent IsNot Nothing Then
                Return Parent.ClassName
            Else
                Return "CfxRuntime"
            End If
        End Get
    End Property

    Public ReadOnly Property Comments1 As CommentData Implements ISignatureOwner.Comments
        Get
            Return Comments
        End Get
    End Property

    Public ReadOnly Property CefConfig As CefConfigData Implements ISignatureOwner.CefConfig
        Get
            Return Nothing
        End Get
    End Property
End Class
