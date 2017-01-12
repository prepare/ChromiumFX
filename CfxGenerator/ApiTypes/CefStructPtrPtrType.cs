// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefStructPtrPtrType : ApiType {
    public readonly CefStructPtrType StructPtr;
    public readonly CefStructType Struct;

    public readonly string Indirection;

    public CefStructPtrPtrType(CefStructPtrType structPtr, string Indirection)
        : base(AddIndirection(structPtr.Name, Indirection)) {
        this.StructPtr = structPtr;
        this.Struct = structPtr.Struct;
        this.Indirection = Indirection;
    }

    protected CefStructPtrPtrType(CefStructPtrPtrType structPtrPtr)
        : this(structPtrPtr.StructPtr, structPtrPtr.Indirection) {
    }

    public override string OriginalSymbol {
        get { return AddIndirection(Struct.OriginalSymbol, Indirection); }
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string[] ParserMatches {
        get { return new string[] { Struct.ParserMatches[0] + Indirection, Struct.ParserMatches[1] + Indirection }; }
    }

    public override bool IsCefStructPtrPtrType {
        get { return true; }
    }

    public override CefStructPtrPtrType AsCefStructPtrPtrType {
        get { return this; }
    }
}