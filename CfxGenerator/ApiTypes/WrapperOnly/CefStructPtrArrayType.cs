// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;

/// <summary>
/// Array of struct pointers, cef_struct **array
/// </summary>
/// <remarks></remarks>
public class CefStructPtrArrayType : CefStructPtrPtrType {
    public readonly Parameter StructArg;

    public readonly Parameter CountArg;

    public CefStructPtrArrayType(Parameter structArg, Parameter countArg)
        : base(structArg.ParameterType.AsCefStructPtrPtrType) {
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
        return string.Format("CfxArray.GetCfrObjects<{0}>(CfxRemoteCallContext.CurrentContext.connection, {1}, {0}.Wrap)", Struct.RemoteClassName, var);
    }

    public override string RemoteUnwrapExpression(string var) {
        return var + "_unwrapped";
    }

    public override string PInvokeCallbackParameter(string var) {
        if(Struct.IsRefCounted)
            return base.PInvokeCallbackParameter(var) + ", out int " + var + "_release";
        else
            return base.PInvokeCallbackParameter(var);
    }

    public override string NativeCallbackParameter(string var, bool isConst) {
        if(Struct.IsRefCounted)
            return base.NativeCallbackParameter(var, isConst) + ", int *" + var + "_release";
        else
            return base.NativeCallbackParameter(var, isConst);
    }

    public override string NativeCallbackArgument(string var) {
        if(Struct.IsRefCounted)
            return base.NativeCallbackArgument(var) + ", &" + var + "_release";
        else
            return base.NativeCallbackArgument(var);
    }

    public override void EmitPreNativeCallbackStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted)
            b.AppendLine("int " + var + "_release;");
    }

    public override void EmitPostNativeCallbackStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted) {
            b.BeginBlock("if({0}_release)", var);
            b.BeginBlock("for(size_t i = 0; i < {0}; ++i)", CountArg.VarName);
            b.AppendLine("{0}[i]->base.release((cef_base_ref_counted_t*){0}[i]);", var);
            b.EndBlock();
            b.EndBlock();
        }
    }

    public override void EmitPreNativeCallStatements(CodeBuilder b, string var) {
        Debug.Assert(Struct.IsRefCounted);
        b.BeginIf("{0}", CountArg.VarName);
        b.BeginBlock("for(size_t i = 0; i < {0}; ++i)", CountArg.VarName);
        b.AppendLine("if({0}[i]) ((cef_base_ref_counted_t*){0}[i])->add_ref((cef_base_ref_counted_t*){0}[i]);", StructArg.VarName);
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

    public override void EmitRemoteEventArgFields(CodeBuilder b, string var) {
        b.AppendLine("internal {0}[] m_{1}_managed;", Struct.RemoteClassName, var);
    }

    public override void EmitPublicEventCtorStatements(CodeBuilder b, string var) {
        b.AppendLine("e.m_{0} = new IntPtr[(ulong){1}];", var, CountArg.VarName);
        b.BeginIf("e.m_{0}.Length > 0", var);
        b.AppendLine("System.Runtime.InteropServices.Marshal.Copy({0}, e.m_{0}, 0, (int){1});", var, CountArg.VarName);
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

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        b.BeginIf("m_{0}_managed == null", var);
        b.AppendLine("var {0} = new RemotePtr[(ulong)call.{1}];", var, CountArg.VarName);
        b.AppendLine("m_{0}_managed = new {1}[{0}.Length];", var, Struct.RemoteClassName);
        b.BeginIf("{0}.Length > 0", var);
        b.AppendLine("CfrRuntime.Marshal.Copy(new RemotePtr(connection, call.{0}), {0}, 0, {0}.Length);", var);
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var);
        b.AppendLine("m_{0}_managed[i] = {1}.Wrap({0}[i]);", var, Struct.RemoteClassName);
        b.EndBlock();
        b.EndBlock();
        b.EndBlock();
        b.AppendLine("return m_{0}_managed;", var);
    }

    public override void EmitPostPublicRaiseEventStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted)
            b.AppendLine("{0}_release = e.m_{0}_managed == null? 1 : 0;", var);
        else if(Struct.IsScoped) {
            // never reached, but if this is reached in the future, 
            // then emit code to dispose all array elements
            throw new Exception();
        }
    }

    public override void EmitPostRemoteRaiseEventStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted)
            b.AppendLine("{0}_release = e.m_{0}_managed == null? 1 : 0;", var);
        else if(Struct.IsScoped) {
            // never reached, but if this is reached in the future, 
            // then emit code to dispose all array elements
            throw new Exception();
        }
    }

    public override void EmitSetCallbackArgumentToDefaultStatements(CodeBuilder b, string var) {
        if(Struct.IsRefCounted)
            b.AppendLine("{0}_release = 1;", var);
    }
    
    public override void EmitPreProxyCallStatements(CodeBuilder b, string var) {
        b.AppendLine("PinnedObject {0}_pinned = new PinnedObject({0});", var);
        b.AppendLine("var {0}_length = {0} == null ? UIntPtr.Zero : (UIntPtr){0}.LongLength;", var);
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        b.BeginIf("{0} != null", var);
        b.AppendLine("call.{0} = new IntPtr[{0}.Length];", var);
        b.BeginBlock("for(int i = 0; i < {0}.Length; ++i)", var);
        b.AppendLine("if(!CheckConnection({0}[i], connection)) throw new ArgumentException(\"Render process connection mismatch.\", \"{1}[\" + i + \"]\");", CSharp.Escape(var), var);
        b.AppendLine("call.{0}[i] = {1};", var, StructPtr.RemoteUnwrapExpression(var + "[i]"));
        b.EndBlock();
        b.EndBlock();
    }
}