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

using System.Diagnostics;

/// <summary>
/// Array of struct pointers, cef_struct **array
/// </summary>
/// <remarks></remarks>
public class CefStructPtrArrayType : CefStructPtrPtrType {
    public readonly Argument StructArg;

    public readonly Argument CountArg;

    public CefStructPtrArrayType(Argument structArg, Argument countArg)
        : base(structArg.ArgumentType.AsCefStructPtrPtrType) {
        this.StructArg = structArg;
        this.CountArg = countArg;
    }

    public override string PublicSymbol {
        get { return Struct.ClassName + "[]"; }
    }

    public override string ProxySymbol {
        get { return "IntPtr[]"; }
    }

    public override string RemoteSymbol {
        get { return Struct.RemoteClassName + "[]"; }
    }

    public override string PublicUnwrapExpression(string var) {
        if(StructArg.Index < CountArg.Index) {
            return string.Format("{0}_pinned.PinnedPtr, {0}_length", var);
        } else {
            return string.Format("{0}_length, {0}_pinned.PinnedPtr", var);
        }
    }

    public override string ProxyWrapExpression(string var) {
        return string.Format("CfxArray.GetProxyIds<{0}>({1})", Struct.ClassName, var);
    }

    public override string ProxyUnwrapExpression(string var) {
        return var + "_unwrapped";
    }

    public override string RemoteWrapExpression(string var) {
        return string.Format("CfxArray.GetCfrObjects<{0}>({1}, {0}.Wrap)", Struct.RemoteClassName, var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return var + "_unwrapped";
    }

    public override string PublicEventConstructorParameter(string var) {
        return StructPtr.PublicEventConstructorParameter(var) + ", " + CountArg.PublicEventConstructorParameter;
    }

    public override string PublicEventConstructorArgument(string var) {
        return StructPtr.PublicEventConstructorArgument(var) + ", " + CountArg.PublicEventConstructorArgument;
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        b.BeginIf("{0}", CountArg.VarName);
        b.BeginBlock("for(size_t i = 0; i < {0}; ++i)", CountArg.VarName);
        b.AppendLine("if({0}[i]) ((cef_base_t*){0}[i])->add_ref((cef_base_t*){0}[i]);", StructArg.VarName);
        b.EndBlock();
        b.EndBlock();
    }

    public override void EmitPrePublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("UIntPtr {0}_length;", var);
        b.AppendLine("IntPtr[] {0}_ptrs;", var);
        b.BeginIf("{0} != null", var);
        b.AppendLine("{0}_length = (UIntPtr){0}.Length;", var);
        b.AppendLine("{0}_ptrs = new IntPtr[{0}.Length];", var);
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var);
        b.AppendLine("{0}_ptrs[i] = {1}.Unwrap({0}[i]);", var, Struct.ClassName);
        b.EndBlock();
        b.BeginElse();
        b.AppendLine("{0}_length = UIntPtr.Zero;", var);
        b.AppendLine("{0}_ptrs = null;", var);
        b.EndBlock();
        b.AppendLine("PinnedObject {0}_pinned = new PinnedObject({0}_ptrs);", var);
    }

    public override void EmitPostPublicCallStatements(CodeBuilder b, string var) {
        b.AppendLine("{0}_pinned.Free();", var);
    }

    public override void EmitPublicEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal IntPtr[] m_{0};", var);
        b.AppendLine("internal {0}[] m_{1}_managed;", Struct.ClassName, var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        b.AppendLine("m_{0} = new IntPtr[(ulong){1}];", var, CountArg.VarName);
        b.BeginIf("m_{0}.Length > 0", var);
        b.AppendLine("System.Runtime.InteropServices.Marshal.Copy({0}, m_{0}, 0, (int){1});", var, CountArg.VarName);
        b.EndBlock();
    }

    public override void EmitPublicEventArgGetterStatements(CodeBuilder b, string var) {
        b.BeginIf("m_{0}_managed == null", var);
        b.AppendLine("m_{0}_managed = new {1}[m_{0}.Length];", var, Struct.ClassName);
        b.BeginBlock("for(int i = 0; i < m_{0}.Length; ++i)", var);
        b.AppendLine("m_{0}_managed[i] = {1}.Wrap(m_{0}[i]);", var, Struct.ClassName);
        b.EndBlock();
        b.EndBlock();
        b.AppendLine("return m_{0}_managed;", var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        b.BeginIf("e.m_{0}_managed == null", var);
        b.BeginBlock("for({0} i = 0; i < ({0}){1}; ++i)", CountArg.ArgumentType.PublicSymbol, CountArg.VarName);
        b.AppendLine("CfxApi.cfx_release(e.m_{0}[i]);", var);
        b.EndBlock();
        b.EndBlock();
    }

    public override void EmitPreProxyCallStatements(CodeBuilder b, string var) {
        b.AppendLine("PinnedObject {0}_pinned = new PinnedObject({0});", var);
        b.AppendLine("var {0}_length = {0} == null ? UIntPtr.Zero : (UIntPtr){0}.LongLength;", var);
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        b.BeginIf("{0} != null", var);
        b.AppendLine("call.{0} = new IntPtr[{0}.Length];", var);
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var);
        b.AppendLine("call.{0}[i] = {1};", var, StructPtr.RemoteUnwrapExpression(var + "[i]"));
        b.EndBlock();
        b.EndBlock();
    }
}