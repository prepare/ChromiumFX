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


public class GetFrameIdentifiersSignature : Signature {

    public GetFrameIdentifiersSignature(Signature s)
        : base(s) {
    }

    public override Argument[] ManagedArguments {
        get { return new Argument[] { Arguments[0] }; }
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

    protected override void EmitExecuteInTargetProcess(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine("var identifiersCount = CfxApi.Browser.cfx_browser_get_frame_count(@this);");
        b.AppendLine("__retval = new long[(ulong)identifiersCount];");
        b.AppendLine("if(identifiersCount == UIntPtr.Zero) return;");
        b.AppendLine("var retval_p = new PinnedObject(__retval);");
        b.AppendLine("CfxApi.Browser.cfx_browser_get_frame_identifiers(@this, identifiersCount, retval_p.PinnedPtr);");
        b.AppendLine("retval_p.Free();");
    }

    public override void DebugPrintUnhandledArrayArguments(string cefName, CefConfigData cefConfig, CfxCallMode callMode) {
    }
}