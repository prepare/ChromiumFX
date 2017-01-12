// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chromium {

    /// <summary>
    /// Base class for all wrapper classes for CEF library structs.
    /// </summary>
    public class CfxLibraryBase : CfxBase {

        internal CfxLibraryBase(IntPtr nativePtr) : base(nativePtr) { }

        /// <summary>
        /// Provides access to the underlying native cef struct.
        /// This is a refcounted library struct derived from cef_base_t.
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

        internal override void OnDispose(IntPtr nativePtr) {
            CfxApi.cfx_release(nativePtr);
        }
    }
}
