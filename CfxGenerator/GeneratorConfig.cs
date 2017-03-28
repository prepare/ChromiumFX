// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class GeneratorConfig {


    private static string[] strongHandleClients = { "cef_task" };

    public static bool UseStrongHandleFor(string client) {
        return strongHandleClients.Contains(client);
    }

    public static bool CreateRemoteProxy(string item) {
        return !(IsBrowserProcessOnly(item) || HasPrivateWrapper(item));
    }

    private static string[] browserProcessOnly = AssemblyResources.GetLines("BrowserProcessOnly.txt");

    public static bool IsBrowserProcessOnly(string item) {
        foreach(var func in browserProcessOnly) {
            if(item == func) return true;
            if(func.EndsWith("_") && item.StartsWith(func))
                return true;
        }
        return false;
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