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


public class CodeSnippets {

    public static void EmitPInvokeDelegate(CodeBuilder b, string functionName, Signature signature) {
        EmitPInvokeDelegate(b, signature.PInvokeFunctionHeader(functionName + "_delegate"), functionName);
    }

    public static void EmitPInvokeDelegate(CodeBuilder b, string delegateSignature, string functionName) {
        EmitDelegate(b, delegateSignature, "Cdecl", false, false);
        b.AppendLine("public static {0}_delegate {0};", functionName);
    }

    public static void EmitPInvokeCallbackDelegate(CodeBuilder b, string functionName, Signature signature) {
        EmitDelegate(b, functionName, "void", signature.PInvokeParameterList, "StdCall", true, true);
    }

    public static void EmitDelegate(CodeBuilder b, string functionName, string returnType, string arguments, string callingConvention, bool fullyQualified, bool priv) {
        if(string.IsNullOrWhiteSpace(returnType))
            System.Diagnostics.Debugger.Break();
        EmitDelegate(b, string.Format("{0} {1}_delegate({2})", returnType, functionName, arguments), callingConvention, fullyQualified, priv);
    }

    public static void EmitDelegate(CodeBuilder b, string delegateSignature, string callingConvention, bool fullyQualified, bool priv) {
        if(fullyQualified) {
            b.AppendLine("[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.{0}, SetLastError = false)]", callingConvention);
        } else {
            b.AppendLine("[UnmanagedFunctionPointer(CallingConvention.{0}, SetLastError = false)]", callingConvention);
        }
        if(priv) {
            b.AppendLine("private delegate {0};", delegateSignature);
        } else {
            b.AppendLine("public delegate {0};", delegateSignature);
        }
    }

    public static void EmitPInvokeDelegateInitialization(CodeBuilder b, string functionName) {
        b.AppendLine("CfxApi.{0} = (CfxApi.{0}_delegate)CfxApi.GetDelegate(FunctionIndex.{0}, typeof(CfxApi.{0}_delegate));", functionName);
    }
}