// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;
using System.Reflection;

public class AssemblyResources {
    private static string[] m_resourceNames;

    public static string[] ResourceNames {
        get {
            if(m_resourceNames == null) {
                var asm = Assembly.GetExecutingAssembly();
                m_resourceNames = asm.GetManifestResourceNames();
            }
            return m_resourceNames;
        }
    }

    public static string GetResourceName(string partialName) {
        foreach(var rn in ResourceNames) {
            if(rn.Contains(partialName)) {
                return rn;
            }
        }
        return null;
    }

    public static System.IO.Stream GetStream(string partialName) {
        var name = GetResourceName(partialName);
        if(name == null)
            return null;
        return Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
    }

    public static byte[] GetBinary(string partialName) {
        var stream = GetStream(partialName);
        var data = new System.IO.MemoryStream();
        stream.CopyTo(data);
        return data.ToArray();
    }

    public static string GetString(string partialName) {
        using(var stream = GetStream(partialName)) {
            return new System.IO.StreamReader(stream).ReadToEnd();
        }
    }

    public static string[] GetLines(string partialName) {
        using(var stream = GetStream(partialName)) {
            var reader = new System.IO.StreamReader(stream);
            var ll = new List<string>();
            var l = reader.ReadLine();
            while(l != null) {
                ll.Add(l);
                l = reader.ReadLine();
            }
            return ll.ToArray();
        }
    }

    public static byte[] GetData(string partialName) {
        var data = new System.IO.MemoryStream();
        using(var stream = GetStream(partialName)) {
            stream.CopyTo(data);
        }
        return data.GetBuffer();
    }
}