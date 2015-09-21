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