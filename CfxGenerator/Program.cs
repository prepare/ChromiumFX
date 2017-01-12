// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.IO;

internal static class Program {



    public static int EmitDebugInfo = 0;

    public static bool DocumentationFormatBugStillExists;

    public static void Main() {

		// find project directory
		var path = Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
		while(Path.GetFileName(path) != "linux" && Path.GetFileName(path) != "CfxGenerator")
			path = Path.GetDirectoryName(path);

		path = Path.GetDirectoryName(path);

        //GeneratedFileManager.PatchFilesLicense(path);
        //Environment.Exit(0);

        Environment.CurrentDirectory = path;

        var parser = new ApiTypeBuilder();
        var decls = parser.GetDeclarations();

        var gen = new WrapperGenerator(decls);
        gen.Run();

        if(!DocumentationFormatBugStillExists) {
            //remove workaroung for this bug in CSharp.PrepareSummaryLine
            System.Diagnostics.Debugger.Break();
        }
    }
}
