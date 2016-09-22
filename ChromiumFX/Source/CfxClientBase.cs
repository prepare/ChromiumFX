using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chromium {

    /// <summary>
    /// Base class for all wrapper classes for CEF client callback or handler structs.
    /// </summary>
    public class CfxClientBase : CfxBase {

        internal CfxClientBase(IntPtr nativePtr) : base(nativePtr) {}
        internal CfxClientBase(CfxApi.cfx_ctor_with_gc_handle_delegate cfx_ctor) {
            CreateNative(cfx_ctor);
        }

        /// <summary>
        /// Disables all CEF callback events in this class. CEF callbacks with arguments will return with all parameters set to default.
        /// </summary>
        public bool DisableCallbacks { get; set; }
    }
}
