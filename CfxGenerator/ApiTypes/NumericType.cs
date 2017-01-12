// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class NumericType : ApiType {

    private static string[] typeSpecs = {
		"int|int",
		"int32|int",
		"int64|long",
		"uint32|uint",
		"uint64|ulong",
		"unsigned short|ushort",
		"long|int",
		"unsigned long|uint",
		"long long|long",
		"unsigned long long|ulong",
		"unsigned int|uint",
		"unsigned|uint",
		"float|float",
		"double|double",
		"DWORD|int"
	};

    public static void CreateAll(ApiTypeBuilder b) {
        b.AddType(new SizeType());
        b.AddType(new SizeTypeOut());
        foreach(var spec in typeSpecs) {
            var names = spec.Split('|');
            var t = new NumericType(names[0], names[1]);
            b.AddType(t);
            b.AddType(new NumericOutType(t));
        }
    }

    public readonly string PInvokeType;

    public NumericType(string name, string pInvokeType)
        : base(name) {
        this.PInvokeType = pInvokeType;
    }

    public override string PInvokeSymbol {
        get { return PInvokeType; }
    }
}