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



Public Class CodeSnippets

    Shared Sub EmitPInvokeDelegate(b As CodeBuilder, functionName As String, signature As Signature)
        EmitPInvokeDelegate(b, signature.PInvokeSignature(functionName & "_delegate"), functionName)
    End Sub

    Shared Sub EmitPInvokeDelegate(b As CodeBuilder, delegateSignature As String, functionName As String)
        EmitDelegate(b, delegateSignature, "Cdecl", False, False)
        b.AppendLine("public static {0}_delegate {0};", functionName)
    End Sub

    Shared Sub EmitPInvokeCallbackDelegate(b As CodeBuilder, functionName As String, signature As Signature)
        EmitDelegate(b, functionName, "void", signature.PInvokeCallbackSignature, "StdCall", True, True)
    End Sub

    Shared Sub EmitDelegate(b As CodeBuilder, functionName As String, returnType As String, arguments As String, callingConvention As String, fullyQualified As Boolean, priv As Boolean)
        If String.IsNullOrWhiteSpace(returnType) Then Stop
        EmitDelegate(b, String.Format("{0} {1}_delegate({2})", returnType, functionName, arguments), callingConvention, fullyQualified, priv)
    End Sub

    Shared Sub EmitDelegate(b As CodeBuilder, delegateSignature As String, callingConvention As String, fullyQualified As Boolean, priv As Boolean)
        If fullyQualified Then
            b.AppendLine("[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.{0}, SetLastError = false)]", callingConvention)
        Else
            b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.{0}, SetLastError = false)]", callingConvention)
        End If
        If priv Then
            b.AppendLine("private delegate {0};", delegateSignature)
        Else
            b.AppendLine("public delegate {0};", delegateSignature)
        End If
    End Sub

    Shared Sub EmitPInvokeDelegateInitialization(b As CodeBuilder, functionName As String)
        EmitPInvokeDelegateInitialization(b, functionName, functionName & "_delegate")
    End Sub

    Shared Sub EmitPInvokeDelegateInitialization(b As CodeBuilder, functionName As String, delegateName As String)
        Dim hmodule As String
        If functionName.StartsWith("cef_") Then
            hmodule = "libcefPtr"
        Else
            hmodule = "libcfxPtr"
        End If
        b.AppendLine("{1} = ({2})GetDelegate({0}, ""{1}"", typeof({2}));", hmodule, functionName, delegateName)
    End Sub


    Shared Sub BeginExternC(b As CodeBuilder)
        b.AppendLine("#ifdef __cplusplus")
        b.AppendLine("extern ""C"" {")
        b.AppendLine("#endif")
    End Sub

    Shared Sub EndExternC(b As CodeBuilder)
        b.AppendLine("#ifdef __cplusplus")
        b.AppendLine("} // extern ""C""")
        b.AppendLine("#endif")
    End Sub

End Class
