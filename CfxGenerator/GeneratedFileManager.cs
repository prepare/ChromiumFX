// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class GeneratedFileManager {
    private string directoryPath;
    private HashSet<string> oldFiles = new HashSet<string>();

    private List<string> newFiles = new List<string>();

    private string licenseStub;

    public GeneratedFileManager(string directoryPath) {
        this.directoryPath = directoryPath;
        if(!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }
        var files = Directory.GetFiles(directoryPath);
        foreach(var f in files) {
            oldFiles.Add(f);
        }

        licenseStub = AssemblyResources.GetString("LicenseStub");
    }

    public GeneratedFileManager() {
        //need a dummp writer
        directoryPath = null;
    }

    public void WriteFileIfContentChanged(string filename, string content) {
        if(directoryPath == null)
            return;

        var filepath = Path.Combine(directoryPath, filename);

        if(newFiles.Contains(filepath)) {
            System.Diagnostics.Debugger.Break();
        }

        var b = new CodeBuilder();
        b.AppendLine(licenseStub);
        b.AppendComment("Generated file. Do not edit.");
        b.AppendLine();
        b.AppendLine();
        b.Append(content);

        content = b.ToString();

        var oldcontent = string.Empty;
        if(oldFiles.Contains(filepath)) {
            oldcontent = File.ReadAllText(filepath);
            oldFiles.Remove(filepath);
        }

        if(!content.Equals(oldcontent)) {
            File.WriteAllText(filepath, content);
        }

        newFiles.Add(filepath);
    }

    public void DeleteObsoleteFiles() {
        foreach(var f in oldFiles) {
            File.Delete(f);
        }
    }

    public string[] GetNewFiles() {
        return newFiles.ToArray();
    }

    public static void PatchFilesLicense(string dir) {
		
        var licenseStub = AssemblyResources.GetString("LicenseStub");

        var files = Directory.GetFiles(dir);
        foreach(var f in files) {
            var ext = Path.GetExtension(f);
            if(new string[] {
				".cs",
				".c",
				".cpp",
				".h"
			}.Contains(ext.ToLowerInvariant())) {
                var content = File.ReadAllText(f);

                if(true || !content.StartsWith(licenseStub)) {

                    if(content.StartsWith("// Copyright")) {
                        var ex = new Regex(@"^// Copyright.*?txt file for details.\s*", RegexOptions.Singleline);
                        Debug.Assert(ex.IsMatch(content));
                        content = ex.Replace(content, licenseStub + Environment.NewLine);
                    } else {

                        var b = new CodeBuilder();
                        b.AppendLine(licenseStub);
                        b.Append(content);

                        content = b.ToString();

                    }


                    Debug.Print(f);
                    File.WriteAllText(f, content);
                }
            }
        }

        var dirs = Directory.GetDirectories(dir);
        foreach(var d in dirs) {
            if(!d.EndsWith(".hg") && !d.Contains("\\Generated\\") && !d.Contains("\\cef\\")) {
                PatchFilesLicense(d);
            }
        }
    }
}