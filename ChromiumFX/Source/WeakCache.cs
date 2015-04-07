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

using System;
using System.Collections.Generic;

namespace Chromium {
    internal class WeakCache {

        private readonly Dictionary<IntPtr, WeakReference> cache;

        public WeakCache() {
            cache = new Dictionary<IntPtr, WeakReference>();
            CfxRuntime.OnCfxShutdown += this.OnShutdown;
        }

        public void Add(CfxBase obj) {
            // always locked by caller
            cache.Add(obj.nativePtrUnchecked, new WeakReference(obj, false));
        }

        public object Get(IntPtr ptr) {
            // always locked by caller
            WeakReference r;
            if(cache.TryGetValue(ptr, out r))
                return r.Target;
            else
                return null;
        }

        public void Remove(IntPtr ptr) {
            lock(this) {
                cache.Remove(ptr);
            }
        }

        private void OnShutdown() {
            lock(this) {
                // cannot use foreach because obj.Dispose() will cause Remove()
                // to be called modifying the collection
                WeakReference[] refs = new WeakReference[cache.Count];
                cache.Values.CopyTo(refs, 0);
                foreach(WeakReference r in refs) {
                    var obj = (CfxBase)r.Target;
                    if(obj != null) obj.Dispose();
                }
            }
        }
    }
}
