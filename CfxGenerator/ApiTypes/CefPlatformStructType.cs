// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class CefPlatformStructType : CefStructType {
    public readonly CefPlatform Platform;

    private readonly string baseTypeName;

    public CefPlatformStructType(string name, StructCategory category, CefPlatform platform)
        : base(name + "_" + platform.ToString().ToLowerInvariant(), category) {
        this.Platform = platform;
        baseTypeName = name;
    }

    public override string OriginalSymbol {
        get { return baseTypeName + "_t"; }
    }

    public override string[] ParserMatches {
        get { return new string[] { Name }; }
    }

    public override bool IsCefPlatformStructType {
        get { return true; }
    }

    public override CefPlatformStructType AsCefPlatformStructType {
        get { return this; }
    }
}