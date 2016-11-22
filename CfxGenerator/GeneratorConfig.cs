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
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class GeneratorConfig {

    public static bool CreateRemoteProxy(string item) {
        return !(IsBrowserProcessOnly(item) || HasPrivateWrapper(item));
    }

    private static string[] browserProcessOnly = AssemblyResources.GetLines("BrowserProcessOnly.txt");

    public static bool IsBrowserProcessOnly(string item) {
        return browserProcessOnly.Contains(item);
    }

    public static string[] AdditionalCallIds {
        get {
            List<string> callIds = new List<string>();
            var files = Directory.GetFiles(Path.Combine("ChromiumFX", "Source", "Remote"));
            foreach(var f in files) {
                if(f.EndsWith("RemoteCallBases.cs"))
                    continue;
                var content = File.ReadAllText(f);
                var mm = Regex.Matches(content, @"class\s+(\w+)\s*:\s*(?:RemoteClientCall|\w*RemoteCall)");
                foreach(Match m in mm) {
                    callIds.Add(m.Groups[1].Value);
                }
            }
            return callIds.ToArray();
        }
    }

    private static string[] privateWrapperFunctions = AssemblyResources.GetLines("PrivateWrapper.txt");

    public static bool HasPrivateWrapper(string item) {
        return privateWrapperFunctions.Contains(item);
    }

    private static HashSet<string> partialClasses;

    public static string ClassModifiers(string className, string baseModifiers = "public") {
        if(IsPartialClass(className)) {
            return baseModifiers + " partial";
        } else {
            return baseModifiers;
        }
    }

    public static bool IsPartialClass(string className) {
        if(partialClasses == null) {
            FindPartialClasses();
        }
        return partialClasses.Contains(className);
    }

    private static void FindPartialClasses() {
        partialClasses = new HashSet<string>();
        FindPartialClasses(System.IO.Path.Combine("ChromiumFX", "Source"));
        FindPartialClasses(System.IO.Path.Combine("ChromiumFX", "Source", "Remote"));
    }

    private static void FindPartialClasses(string path) {
        if(!System.IO.Directory.Exists(path))
            return;
        var files = System.IO.Directory.GetFiles(path);
        foreach(var f in files) {
            partialClasses.Add(System.IO.Path.GetFileNameWithoutExtension(f));
        }
    }
}