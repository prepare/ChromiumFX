// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


using System.Xml.Linq;

public class CefRectArrayType : ApiType {
    public readonly Argument CountArg;

    public CefRectArrayType(Argument countArg)
        : base("__cef_rect_t[]") {
        this.CountArg = countArg;
    }

    public override string PublicSymbol {
        get { return "CfxRect[]"; }
    }

    public override string PublicEventConstructorSignature(string var) {
        return string.Format("IntPtr {0}, {1}", var, CountArg.PublicEventConstructorSignature);
    }

    public override string PublicEventConstructorCall(string var) {
        return var + ", " + CountArg.PublicEventConstructorCall;
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal IntPtr m_{0};", var);
        CountArg.EmitPublicEventArgFields(b);
        b.AppendLine("internal CfxRect[] m_{0}_managed;", var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        base.EmitPublicEventCtorStatements(b, var);
        CountArg.ArgumentType.EmitPublicEventCtorStatements(b, CountArg.VarName);
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        var code = new XCData("\r\nif(m_{0}_managed == null) {{\r\n    if(m_{1} == 0) return new CfxRect[0];\r\n    var buffer = new int[4 * m_{1}];\r\n    System.Runtime.InteropServices.Marshal.Copy(m_{0}, buffer, 0, buffer.Length);\r\n    m_{0}_managed = new CfxRect[m_{1}];\r\n    for (var i = 0; i < m_{1};) {{\r\n        m_{0}_managed[i] = new CfxRect() {{\r\n            X = buffer[i++],\r\n            Y = buffer[i++],\r\n            Width = buffer[i++],\r\n            Height = buffer[i++]\r\n        }};\r\n    }}\r\n}}\r\nreturn m_{0}_managed;\r\n").Value.Trim();

        b.AppendMultiline(code, var, CountArg.VarName);
    }
}