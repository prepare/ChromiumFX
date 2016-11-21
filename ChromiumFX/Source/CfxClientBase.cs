// Copyright (c) 2014-2016 Wolfgang Borgsmüller
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
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Chromium {

    /// <summary>
    /// Base class for all wrapper classes for CEF client callback or handler structs.
    /// </summary>
    public class CfxClientBase : CfxBase {

        /// <summary>
        /// Set to a strong handle whenever CEF holds a reference to the underlying
        /// native client struct, in order to keep this object alive if it is not
        /// explicitly referenced from managed code.
        /// </summary>
        internal GCHandle nativeReference;

        internal CfxClientBase(IntPtr nativePtr) : base(nativePtr) {}
        internal CfxClientBase(CfxApi.cfx_ctor_with_gc_handle_delegate cfx_ctor) {
            // must be a weak handle
            // otherwise transient callback structs never go out of scope if
            // they are not explicitly disposed
            System.Runtime.InteropServices.GCHandle handle =
                System.Runtime.InteropServices.GCHandle.Alloc(this, System.Runtime.InteropServices.GCHandleType.Weak);
            var nativePtr = cfx_ctor(System.Runtime.InteropServices.GCHandle.ToIntPtr(handle));
            if(nativePtr == IntPtr.Zero)
                throw new OutOfMemoryException();
            SetNative(nativePtr);
        }

        /// <summary>
        /// Provides access to the underlying native cef struct.
        /// This is a refcounted client struct derived from cef_base_t.
        /// Add a ref in order to keep it alive when this managed object go out of scope.
        /// </summary>
        public sealed override IntPtr NativePtr {
            get {
                if(nativePtrUnchecked == IntPtr.Zero) {
                    throw new ObjectDisposedException(this.GetType().Name);
                } else {
                    return nativePtrUnchecked;
                }
            }
        }

        /// <summary>
        /// When true, all CEF callback events are disabled for this handler. Incoming callbacks will return default values to CEF.
        /// </summary>
        public bool CallbacksDisabled { get; set; }

        internal override void OnDispose(IntPtr nativePtr) {
            CallbacksDisabled = true;
            CfxApi.cfx_release(nativePtr);
        }
    }
}
