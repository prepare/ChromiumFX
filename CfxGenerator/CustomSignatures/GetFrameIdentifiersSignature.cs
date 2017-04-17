// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class GetFrameIdentifiersSignature : Signature {

    public GetFrameIdentifiersSignature(Signature s)
        : base(s) {
    }

    public override Parameter[] ManagedParameters {
        get { return new Parameter[] { Parameters[0] }; }
    }

    public override ApiType PublicReturnType {
        get { return new WrapperArrayType("long"); }
    }

    public override string NativeFunctionHeader(string functionName) {
        return "static void cfx_browser_get_frame_identifiers(cef_browser_t* self, size_t identifiersCount, int64* identifiers)";
    }

    public override string PInvokeFunctionHeader(string functionName) {
        return "void cfx_browser_get_frame_identifiers_delegate(IntPtr self, UIntPtr identifiersCount, IntPtr identifiers)";
    }

    public override string PublicFunctionHeader(string functionName) {
        return "long[] GetFrameIdentifiers()";
    }

    public override void EmitNativeCall(CodeBuilder b, string functionName) {
        b.AppendLine("self->get_frame_identifiers(self, &identifiersCount, identifiers);");
    }

    public override void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine("var identifiersCount = FrameCount;");
        b.AppendLine("if(identifiersCount == 0) return new long[0];");
        b.AppendLine("long[] retval = new long[identifiersCount];");
        b.AppendLine("var retval_p = new PinnedObject(retval);");
        b.AppendLine("CfxApi.Browser.cfx_browser_get_frame_identifiers(NativePtr, (UIntPtr)identifiersCount, retval_p.PinnedPtr);");
        b.AppendLine("retval_p.Free();");
        b.AppendLine("return retval;");
    }

    protected override void EmitRemoteProcedure(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine("var identifiersCount = CfxApi.Browser.cfx_browser_get_frame_count(@this);");
        b.AppendLine("__retval = new long[(ulong)identifiersCount];");
        b.AppendLine("if(identifiersCount == UIntPtr.Zero) return;");
        b.AppendLine("var retval_p = new PinnedObject(__retval);");
        b.AppendLine("CfxApi.Browser.cfx_browser_get_frame_identifiers(@this, identifiersCount, retval_p.PinnedPtr);");
        b.AppendLine("retval_p.Free();");
    }

    public override void DebugPrintUnhandledArrayParameters(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
    }
}