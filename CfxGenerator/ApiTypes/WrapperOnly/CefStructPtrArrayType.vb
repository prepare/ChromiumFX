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



''' <summary>
''' Array of struct pointers, cef_struct **array
''' </summary>
''' <remarks></remarks>
Public Class CefStructPtrArrayType
    Inherits CefStructPtrPtrType

    Public ReadOnly StructArg As Argument
    Public ReadOnly CountArg As Argument

    Sub New(structArg As Argument, countArg As Argument)
        MyBase.New(structArg.ArgumentType.AsCefStructPtrPtrType)
        Me.StructArg = structArg
        Me.CountArg = countArg
    End Sub

    Public Overrides ReadOnly Property PublicSymbol As String
        Get
            Return Struct.ClassName & "[]"
        End Get
    End Property

    Public Overrides ReadOnly Property ProxySymbol As String
        Get
            Return "ulong[]"
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteSymbol As String
        Get
            Return Struct.RemoteClassName & "[]"
        End Get
    End Property

    Public Overrides ReadOnly Property PublicUnwrapExpression(var As String) As String
        Get
            If StructArg.Index < CountArg.Index Then
                Return String.Format("{0}_pinned.PinnedPtr, {0}_length", var)
            Else
                Return String.Format("{0}_length, {0}_pinned.PinnedPtr", var)
            End If
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyWrapExpression(var As String) As String
        Get
            Return String.Format("CfxArray.GetProxyIds<{0}>({1})", Struct.ClassName, var)
        End Get
    End Property

    Public Overrides ReadOnly Property ProxyUnwrapExpression(var As String) As String
        Get
            Return var & "_unwrapped"
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteWrapExpression(var As String) As String
        Get
            Return String.Format("CfxArray.GetCfrObjects<{0}>({1}, remoteRuntime, {0}.Wrap)", Struct.RemoteClassName, var)
        End Get
    End Property

    Public Overrides ReadOnly Property RemoteUnwrapExpression(var As String) As String
        Get
            Return var & "_unwrapped"
        End Get
    End Property


    Public Overrides ReadOnly Property PublicEventConstructorSignature(var As String) As String
        Get
            Return StructPtr.PublicEventConstructorSignature(var) & ", " & CountArg.PublicEventConstructorSignature
        End Get
    End Property

    Public Overrides ReadOnly Property PublicEventConstructorCall(var As String) As String
        Get
            Return StructPtr.PublicEventConstructorCall(var) & ", " & CountArg.PublicEventConstructorCall
        End Get
    End Property

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)

        b.AppendLine("int {0}_length;", var)
        b.AppendLine("IntPtr[] {0}_ptrs;", var)
        b.BeginIf("{0} != null", var)
        b.AppendLine("{0}_length = {0}.Length;", var)
        b.AppendLine("{0}_ptrs = new IntPtr[{0}_length];", var)
        b.BeginBlock("for(int i = 0; i < {0}_length; ++i)", var)
        b.AppendLine("{0}_ptrs[i] = {1}.Unwrap({0}[i]);", var, Struct.ClassName)
        b.EndBlock()
        b.BeginElse()
        b.AppendLine("{0}_length = 0;", var)
        b.AppendLine("{0}_ptrs = null;", var)
        b.EndBlock()
        b.AppendLine("PinnedObject {0}_pinned = new PinnedObject({0}_ptrs);", var)
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0}_pinned.Free();", var)
    End Sub

    Public Overrides Sub EmitPublicEventArgFields(b As CodeBuilder, var As String)
        b.AppendLine("internal IntPtr[] m_{0};", var)
        b.AppendLine("internal {0}[] m_{1}_managed;", Struct.ClassName, var)
    End Sub

    Public Overrides Sub EmitPublicEventCtorStatements(b As CodeBuilder, var As String)
        b.AppendLine("m_{0} = new IntPtr[{1}];", var, CountArg.VarName)
        b.BeginIf("{0} > 0", CountArg.VarName)
        b.AppendLine("System.Runtime.InteropServices.Marshal.Copy({0}, m_{0}, 0, {1});", var, CountArg.VarName)
        b.EndBlock()
    End Sub

    Public Overrides Sub EmitPublicEventArgGetterStatements(b As CodeBuilder, var As String)
        b.BeginIf("m_{0}_managed == null", var)
        b.AppendLine("m_{0}_managed = new {1}[m_{0}.Length];", var, Struct.ClassName)
        b.BeginBlock("for(int i = 0; i < m_{0}.Length; ++i)", var)
        b.AppendLine("m_{0}_managed[i] = {1}.Wrap(m_{0}[i]);", var, Struct.ClassName)
        b.EndBlock()
        b.EndBlock()
        b.AppendLine("return m_{0}_managed;", var)
    End Sub

    Public Overrides Sub EmitPostPublicRaiseEventStatements(b As CodeBuilder, var As String)
        b.BeginIf("e.m_{0}_managed == null", var)
        b.BeginBlock("for(int i = 0; i < {1}; ++i)", var, CountArg.VarName)
        b.AppendLine("CfxApi.cfx_release(e.m_{0}[i]);", var)
        b.EndBlock()
        b.EndBlock()
    End Sub

    Public Overrides Sub EmitPreProxyCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0}[] {1}_unwrapped;", Struct.ClassName, var)
        b.BeginIf("{0} != null", var)
        b.AppendLine("{0}_unwrapped = new {1}[{0}.Length];", var, Struct.ClassName)
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var)
        b.AppendLine("{0}_unwrapped[i] = {1};", var, StructPtr.ProxyUnwrapExpression(var & "[i]"))
        b.EndBlock()
        b.BeginElse()
        b.AppendLine("{0}_unwrapped = null;", var)
        b.EndBlock()
    End Sub

    Public Overrides Sub EmitPreRemoteCallStatements(b As CodeBuilder, var As String)
        b.BeginIf("{0} != null", var)
        b.AppendLine("call.{0} = new ulong[{0}.Length];", var)
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var)
        b.AppendLine("call.{0}[i] = {1};", var, StructPtr.RemoteUnwrapExpression(var & "[i]"))
        b.EndBlock()
        b.EndBlock()
    End Sub

End Class
