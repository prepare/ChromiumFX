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



' Array of structs, cef_struct_t *array

Public Class CefStructArrayType
    ' inherit from CefStructPtrArrayType because the public layer is the same
    Inherits CefStructPtrArrayType

    Sub New(structArg As Argument, countArg As Argument)
        MyBase.New(New Argument(structArg, New CefStructPtrPtrType(structArg.ArgumentType.AsCefStructPtrType, "*")), countArg)
    End Sub

    Public Overrides ReadOnly Property IsOut As Boolean
        Get
            Return CountArg.ArgumentType.IsOut
        End Get
    End Property

    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return StructPtr.PInvokeSymbol
        End Get
    End Property

    Public Overrides ReadOnly Property NativeSymbol As String
        Get
            Return StructPtr.NativeSymbol & "*"
        End Get
    End Property

    Public Overrides Function PInvokeCallSignature(var As String) As String
        Return String.Format("{0}, out int {1}_nomem", MyBase.PInvokeCallSignature(var), var)
    End Function

    Public Overrides Function NativeCallSignature(var As String, isConst As Boolean) As String
        Return String.Format("{0}, int* {1}_nomem", MyBase.NativeCallSignature(var, isConst), var)
    End Function

    Public Overrides Function PublicUnwrapExpression(var As String) As String
        Return String.Format("{0}, out {1}_nomem", MyBase.PublicUnwrapExpression(var), var)
    End Function

    Public Overrides Function NativeUnwrapExpression(var As String) As String
        Return String.Format("{0}_tmp", var)
    End Function

    Public Overrides Sub EmitPrePublicCallStatements(b As CodeBuilder, var As String)
        MyBase.EmitPrePublicCallStatements(b, var)
        b.AppendLine("int {0}_nomem;", var)
    End Sub

    Public Overrides Sub EmitPostPublicCallStatements(b As CodeBuilder, var As String)
        MyBase.EmitPostPublicCallStatements(b, var)
        b.BeginBlock("if({0}_nomem != 0)", var)
        b.AppendLine("throw new OutOfMemoryException();")
        b.EndBlock()
    End Sub

    Public Overrides Sub EmitPreNativeCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("{0} *{1}_tmp = ({0}*)malloc({2} * sizeof({0}));", Struct.OriginalSymbol, var, CountArg.VarName)
        b.BeginBlock("if({0}_tmp)", var)
        b.BeginFor(CountArg.VarName)
        b.AppendLine("{0}_tmp[i] = *{0}[i];", var)
        b.EndBlock()
        b.AppendLine("*{0}_nomem = 0;", var)
        b.BeginElse()
        b.AppendLine("{0} = 0;", CountArg.VarName)
        b.AppendLine("*{0}_nomem = 1;", var)
        b.EndBlock()

    End Sub

    Public Overrides Sub EmitPostNativeCallStatements(b As CodeBuilder, var As String)
        b.AppendLine("if({0}_tmp) free({0}_tmp);", var)
    End Sub

End Class
