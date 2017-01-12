// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Runtime.InteropServices;

namespace Chromium.Remote {
    /// <summary>
    /// Base class for all remote wrapper classes for CEF client structs.
    /// </summary>
    public abstract class CfrClientBase : CfrBase {

        internal CfrClientBase(CtorWithGCHandleRemoteCall call) {
            System.Runtime.InteropServices.GCHandle handle =
                System.Runtime.InteropServices.GCHandle.Alloc(this, System.Runtime.InteropServices.GCHandleType.Weak);
            call.gcHandlePtr = System.Runtime.InteropServices.GCHandle.ToIntPtr(handle);
            call.RequestExecution();
            SetRemotePtr(new RemotePtr(call.__retval));
        }

        internal CfrClientBase(RemotePtr remotePtr) : base(remotePtr) { }

        /// <summary>
        /// When true, all CEF callback events are disabled for this handler. Incoming callbacks will return default values to CEF.
        /// </summary>
        public bool CallbacksDisabled { get; set; }

        internal sealed override void OnDispose(RemotePtr nativePtr) {
            CallbacksDisabled = true;
            base.OnDispose(nativePtr);
        }
    }

    internal class FreeGCHandleRemoteCall : RemoteCall {
        internal IntPtr gc_handle;
        internal FreeGCHandleRemoteCall() : base(RemoteCallId.FreeGCHandleRemoteCall, true) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gc_handle);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gc_handle);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var h = GCHandle.FromIntPtr(gc_handle);
            h.Free();
        }
    }
}
