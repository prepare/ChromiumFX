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

public class StructArrayGetterSignature : Signature {

    public StructArrayGetterSignature(Signature s)
        : base(s) {
        Debug.Assert(SignatureType.LibraryCall == s.Type);
    }

    public override Argument[] ManagedArguments {
        get { return new Argument[] { Arguments[0] }; }
    }

    public override ApiType PublicReturnType {
        get { return new CefStructPtrArrayType(Arguments[2], Arguments[1]); }
    }

    public override string NativeFunctionHeader(string functionName) {
        return string.Format("static void {0}({1} self, size_t {2}, {3})",
                                functionName, Arguments[0].ArgumentType.OriginalSymbol, 
                                Arguments[1].VarName, Arguments[2].NativeCallParameter);
    }

    public override string PInvokeFunctionHeader(string functionName) {
        return string.Format("void {0}(IntPtr self, UIntPtr {1}, IntPtr {2})",
                                functionName, Arguments[1].VarName, Arguments[2].VarName);
    }

    public override void EmitNativeCall(CodeBuilder b, string functionName) {
        b.AppendLine("{0}(self, &{1}, {2});",
                        functionName, Arguments[1].VarName, Arguments[2].VarName);
    }

    public override void EmitPublicCall(CodeBuilder b) {
        var countFunc = Owner.CefConfig.CountFunction.Substring(Owner.CefConfig.CountFunction.IndexOf(":") + 1);
        // it's translated into a property
        Debug.Assert(countFunc.StartsWith("Get"));
        countFunc = countFunc.Substring(3);
        b.AppendLine("var count = {0};", countFunc);
        b.AppendLine("if(count == 0) return new {0}[0];", Arguments[2].ArgumentType.PublicSymbol);
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
                Owner.CfxApiFunctionName,
                Arguments[2].ArgumentType.PublicSymbol,
                Owner.PublicClassName.Substring(3));
    }

    protected override void EmitExecuteInTargetProcess(CodeBuilder b) {
        Debug.Assert(Arguments[2].ArgumentType.PublicSymbol == "CfxPostDataElement");
        var code =
@"var count = CfxApi.PostData.cfx_post_data_get_element_count(@this);
__retval = new IntPtr[(ulong)count];
if(__retval.Length == 0) return;
var ptrs_p = new PinnedObject(__retval);
CfxApi.PostData.cfx_post_data_get_elements(@this, count, ptrs_p.PinnedPtr);
ptrs_p.Free();
";

        b.AppendMultiline(code,
                Owner.CfxApiFunctionName,
                Arguments[2].ArgumentType.PublicSymbol);
        
    }

    public override void EmitRemoteCall(CodeBuilder b) {
        Debug.Assert(Arguments[2].ArgumentType.PublicSymbol == "CfxPostDataElement");
        b.AppendLine("var call = new CfxPostDataGetElementsRenderProcessCall();");
        b.AppendLine("call.@this = proxyId;");
        b.AppendLine("call.RequestExecution(this);");
        b.AppendLine("if(call.__retval == null) return null;");
        b.AppendLine("var retval = new CfrPostDataElement[call.__retval.Length];");
        b.BeginFor("retval.Length");
        b.AppendLine("retval[i] = CfrPostDataElement.Wrap(call.__retval[i]);");
        b.EndBlock();
        b.AppendLine("return retval;");
    }

    public override void DebugPrintUnhandledArrayArguments() {
    }
}