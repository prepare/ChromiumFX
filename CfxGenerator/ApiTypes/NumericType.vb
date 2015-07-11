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



Public Class NumericType
    Inherits ApiType

    Private Shared typeSpecs As String() = {
        "int|int",
        "int32|int",
        "int64|long",
        "uint32|uint",
        "uint64|ulong",
        "unsigned short|ushort",
        "long|int",
        "unsigned long|uint",
        "long long|long",
        "unsigned long long|ulong",
        "unsigned int|uint",
        "unsigned|uint",
        "float|float",
        "double|double",
        "DWORD|int"
    }

    Public Shared Sub CreateAll(b As ApiTypeBuilder)
        Dim t As NumericType = New SizeType
        b.AddType(t)
        b.AddType(New NumericOutType(t))
        For Each spec In typeSpecs
            Dim names = spec.Split("|"c)
            t = New NumericType(names(0), names(1))
            b.AddType(t)
            b.AddType(New NumericOutType(t))
        Next
    End Sub


    Public ReadOnly PInvokeType As String

    Sub New(name As String, pInvokeType As String)
        MyBase.New(name)
        Me.PInvokeType = pInvokeType
    End Sub


    Public Overrides ReadOnly Property PInvokeSymbol As String
        Get
            Return PInvokeType
        End Get
    End Property


End Class
