// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class GetPageRangesSignature : SignatureWithStructArray {

    public GetPageRangesSignature(Signature s, int arrayIndex, int countIndex)
        : base(s, arrayIndex, countIndex) {
    }

    public override Argument[] ManagedArguments {
        get { return new Argument[-1 + 1]; }
    }

    public override ApiType PublicReturnType {
        get { return new WrapperArrayType("CfxRange"); }
    }

    public override string PInvokeFunctionHeader(string functionName) {
        return "void cfx_print_settings_get_page_ranges_delegate(IntPtr self, ref UIntPtr rangesCount, IntPtr ranges, out int ranges_nomem)";
    }

    public override void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine("var rangesCount = CfxApi.PrintSettings.cfx_print_settings_get_page_ranges_count(NativePtr);");
        b.AppendLine("IntPtr[] pp = new IntPtr[(ulong)rangesCount];");
        b.AppendLine("PinnedObject pp_pinned = new PinnedObject(pp);");
        b.AppendLine("int ranges_nomem;");
        b.AppendLine("CfxApi.PrintSettings.cfx_print_settings_get_page_ranges(NativePtr, ref rangesCount, pp_pinned.PinnedPtr, out ranges_nomem);");
        b.AppendLine("pp_pinned.Free();");
        b.BeginBlock("if(ranges_nomem != 0)");
        b.AppendLine("throw new OutOfMemoryException();");
        b.EndBlock();
        b.AppendLine("var retval = new CfxRange[(ulong)rangesCount];");
        b.BeginBlock("for(ulong i = 0; i < (ulong)rangesCount; ++i)");
        b.AppendLine("retval[i] = CfxRange.WrapOwned(pp[i]);");
        b.EndBlock();
        b.AppendLine("return retval;");
    }

    public override void EmitNativeCall(CodeBuilder b, string functionName) {
        b.AppendLine("cef_range_t *ranges_tmp = (cef_range_t*)malloc(*rangesCount * sizeof(cef_range_t));");
        b.BeginIf("ranges_tmp");
        b.AppendLine("*ranges_nomem = 0;");
        b.AppendLine("self->get_page_ranges(self, rangesCount, ranges_tmp);");
        b.BeginBlock("for(size_t i = 0; i < *rangesCount; ++i)");
        b.AppendLine("ranges[i] = (cef_range_t*)malloc(sizeof(cef_range_t));");
        b.AppendLine("*ranges[i] = ranges_tmp[i];");
        b.EndBlock();
        b.AppendLine("free(ranges_tmp);");
        b.BeginElse();
        b.AppendLine("*ranges_nomem = 1;");
        b.EndBlock();
    }
}