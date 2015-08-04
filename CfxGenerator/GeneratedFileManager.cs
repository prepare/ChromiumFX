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
		Debug.Assert (false);
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

                if(!content.StartsWith(licenseStub)) {

                    if(content.StartsWith("// Copyright")) {
                        var ex = new Regex(@"^// Copyright.*?POSSIBILITY OF SUCH DAMAGE\.", RegexOptions.Singleline);
                        Debug.Assert(ex.IsMatch(content));
                        content = ex.Replace(content, licenseStub);
                    } else {

                        var b = new CodeBuilder();
                        b.AppendLine(licenseStub);

                        b.AppendLine();
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