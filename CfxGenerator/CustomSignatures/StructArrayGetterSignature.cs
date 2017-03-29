// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Diagnostics;

public class StructArrayGetterSignature : Signature {

    private string countFunction;

    public StructArrayGetterSignature(Signature s, string countFunction)
        : base(s) {
        Debug.Assert(SignatureType.LibraryCall == s.Type);
        this.countFunction = countFunction;
    }

    public override Parameter[] ManagedParameters {
        get { return new Parameter[] { Parameters[0] }; }
    }

    public override ApiType PublicReturnType {
        get { return new CefStructPtrArrayType(Parameters[2], Parameters[1]); }
    }

    public override string NativeFunctionHeader(string functionName) {
        return string.Format("static void {0}({1} self, size_t {2}, {3})",
                                functionName, Parameters[0].ParameterType.OriginalSymbol, 
                                Parameters[1].VarName, Parameters[2].NativeCallParameter);
    }

    public override string PInvokeFunctionHeader(string functionName) {
        return string.Format("void {0}(IntPtr self, UIntPtr {1}, IntPtr {2})",
                                functionName, Parameters[1].VarName, Parameters[2].VarName);
    }

    public override void EmitNativeCall(CodeBuilder b, string functionName) {
        b.AppendLine("{0}(self, &{1}, {2});",
                        functionName, Parameters[1].VarName, Parameters[2].VarName);
    }

    public override void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {
        var countFunc = countFunction.Substring(countFunction.IndexOf(":") + 1);
        // it's translated into a property
        Debug.Assert(countFunc.StartsWith("Get"));
        countFunc = countFunc.Substring(3);
        b.AppendLine("var count = {0};", countFunc);
        b.AppendLine("if(count == 0) return new {0}[0];", Parameters[2].ParameterType.PublicSymbol);
        var code =
@"IntPtr[] ptrs = new IntPtr[count];
var ptrs_p = new PinnedObject(ptrs);
CfxApi.{2}.{0}(NativePtr, (UIntPtr)count, ptrs_p.PinnedPtr);
ptrs_p.Free();
{1}[] retval = new {1}[count];
for(ulong i = 0; i < count; ++i) {{
    retval[i] = {1}.Wrap(ptrs[i]);
}}
return retval;";

        b.AppendMultiline(code,
                apiFunctionName,
                Parameters[2].ParameterType.PublicSymbol,
                apiClassName);
    }

    protected override void EmitRemoteProcedure(CodeBuilder b, string apiClassName, string apiFunctionName) {
        Debug.Assert(Parameters[2].ParameterType.PublicSymbol == "CfxPostDataElement");
        var code =
@"var count = CfxApi.PostData.cfx_post_data_get_element_count(@this);
__retval = new IntPtr[(ulong)count];
if(__retval.Length == 0) return;
var ptrs_p = new PinnedObject(__retval);
CfxApi.PostData.cfx_post_data_get_elements(@this, count, ptrs_p.PinnedPtr);
ptrs_p.Free();
";

        b.AppendMultiline(code,
                apiFunctionName,
                Parameters[2].ParameterType.PublicSymbol);
        
    }

    public override void EmitRemoteCall(CodeBuilder b, string remoteCallId, bool isStatic) {
        Debug.Assert(Parameters[2].ParameterType.PublicSymbol == "CfxPostDataElement");
        b.AppendLine("var call = new CfxPostDataGetElementsRemoteCall();");
        b.AppendLine("call.@this = RemotePtr.ptr;");
        b.AppendLine("call.RequestExecution(RemotePtr.connection);");
        b.AppendLine("if(call.__retval == null) return null;");
        b.AppendLine("var retval = new CfrPostDataElement[call.__retval.Length];");
        b.BeginFor("retval.Length");
        b.AppendLine("retval[i] = CfrPostDataElement.Wrap(new RemotePtr(connection, call.__retval[i]));");
        b.EndBlock();
        b.AppendLine("return retval;");
    }

    public override void DebugPrintUnhandledArrayArguments(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}