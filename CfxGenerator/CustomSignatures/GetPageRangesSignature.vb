Public Class GetPageRangesSignature
    Inherits SignatureWithStructArray

    Public Sub New(parent As ISignatureOwner, sd As Parser.SignatureData, api As ApiTypeBuilder, arrayIndex As Integer, countIndex As Integer)
        MyBase.New(parent, sd, api, arrayIndex, countIndex)

    End Sub

    Public Overrides ReadOnly Property ManagedArguments As Argument()
        Get
            Return New Argument() {}
        End Get
    End Property

    Public Overrides ReadOnly Property PublicReturnType As ApiType
        Get
            Return New WrapperArrayType("CfxPageRange")
        End Get
    End Property

    Public Overrides Function PInvokeSignature(functionName As String) As String
        Return "void cfx_print_settings_get_page_ranges_delegate(IntPtr self, ref int rangesCount, IntPtr ranges, out int ranges_nomem)"
    End Function

    Public Overrides Sub EmitPublicCall(b As CodeBuilder)

        b.AppendLine("int rangesCount = CfxApi.cfx_print_settings_get_page_ranges_count(NativePtr);")
        b.AppendLine("IntPtr[] pp = new IntPtr[rangesCount];")
        b.AppendLine("PinnedObject pp_pinned = new PinnedObject(pp);")
        b.AppendLine("int ranges_nomem;")
        b.AppendLine("CfxApi.cfx_print_settings_get_page_ranges(NativePtr, ref rangesCount, pp_pinned.PinnedPtr, out ranges_nomem);")
        b.AppendLine("pp_pinned.Free();")
        b.BeginBlock("if(ranges_nomem != 0)")
        b.AppendLine("throw new OutOfMemoryException();")
        b.EndBlock()
        b.AppendLine("var retval = new CfxPageRange[rangesCount];")
        b.BeginFor("rangesCount")
        b.AppendLine("retval[i] = CfxPageRange.WrapOwned(pp[i]);")
        b.EndBlock()
        b.AppendLine("return retval;")
    End Sub

    Public Overrides Sub EmitNativeCall(b As CodeBuilder, functionName As String)
        b.AppendLine("cef_page_range_t *ranges_tmp = (cef_page_range_t*)malloc(*rangesCount * sizeof(cef_page_range_t));")
        b.BeginIf("ranges_tmp")
        b.AppendLine("*ranges_nomem = 0;")
        b.AppendLine("self->get_page_ranges(self, rangesCount, ranges_tmp);")
        b.BeginBlock("for(size_t i = 0; i < *rangesCount; ++i)")
        b.AppendLine("ranges[i] = (cef_page_range_t*)malloc(sizeof(cef_page_range_t));")
        b.AppendLine("*ranges[i] = ranges_tmp[i];")
        b.EndBlock()
        b.AppendLine("free(ranges_tmp);")
        b.BeginElse()
        b.AppendLine("*ranges_nomem = 1;")
        b.EndBlock()
    End Sub

End Class
