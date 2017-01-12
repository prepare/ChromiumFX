// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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

    public static void EmitPInvokeDelegateInitialization(CodeBuilder b, string apiClassName, string apiFuncName) {
        b.AppendLine("CfxApi.{0}.{1} = (CfxApi.{0}.{1}_delegate)CfxApi.GetDelegate(FunctionIndex.{1}, typeof(CfxApi.{0}.{1}_delegate));", apiClassName, apiFuncName);
    }
}