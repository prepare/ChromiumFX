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

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    internal class CfxResourceBundleGetGlobalRemoteCall : RemoteCall {

        internal CfxResourceBundleGetGlobalRemoteCall()
            : base(RemoteCallId.CfxResourceBundleGetGlobalRemoteCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.ResourceBundle.cfx_resource_bundle_get_global();
        }
    }

    internal class CfxResourceBundleGetLocalizedStringRemoteCall : RemoteCall {

        internal CfxResourceBundleGetLocalizedStringRemoteCall()
            : base(RemoteCallId.CfxResourceBundleGetLocalizedStringRemoteCall) {}

        internal IntPtr @this;
        internal int stringId;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(stringId);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out stringId);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.ResourceBundle.cfx_resource_bundle_get_localized_string(@this, stringId));
        }
    }

    internal class CfxResourceBundleGetDataResourceRemoteCall : RemoteCall {

        internal CfxResourceBundleGetDataResourceRemoteCall()
            : base(RemoteCallId.CfxResourceBundleGetDataResourceRemoteCall) {}

        internal IntPtr @this;
        internal int resourceId;
        internal IntPtr data;
        internal ulong dataSize;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(resourceId);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out resourceId);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(data);
            h.Write(dataSize);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out data);
            h.Read(out dataSize);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            UIntPtr dataSize_tmp = UIntPtr.Zero;
            __retval = 0 != CfxApi.ResourceBundle.cfx_resource_bundle_get_data_resource(@this, resourceId, out data, out dataSize_tmp);
            dataSize = (ulong)dataSize_tmp;
        }
    }

    internal class CfxResourceBundleGetDataResourceForScaleRemoteCall : RemoteCall {

        internal CfxResourceBundleGetDataResourceForScaleRemoteCall()
            : base(RemoteCallId.CfxResourceBundleGetDataResourceForScaleRemoteCall) {}

        internal IntPtr @this;
        internal int resourceId;
        internal int scaleFactor;
        internal IntPtr data;
        internal ulong dataSize;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(resourceId);
            h.Write(scaleFactor);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out resourceId);
            h.Read(out scaleFactor);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(data);
            h.Write(dataSize);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out data);
            h.Read(out dataSize);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            UIntPtr dataSize_tmp = UIntPtr.Zero;
            __retval = 0 != CfxApi.ResourceBundle.cfx_resource_bundle_get_data_resource_for_scale(@this, resourceId, (int)scaleFactor, out data, out dataSize_tmp);
            dataSize = (ulong)dataSize_tmp;
        }
    }

}
