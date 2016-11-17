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

    internal class CfxPostDataCreateRemoteCall : RemoteCall {

        internal CfxPostDataCreateRemoteCall()
            : base(RemoteCallId.CfxPostDataCreateRemoteCall) {}

        internal IntPtr __retval;

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.PostData.cfx_post_data_create();
        }
    }

    internal class CfxPostDataIsReadOnlyRemoteCall : RemoteCall {

        internal CfxPostDataIsReadOnlyRemoteCall()
            : base(RemoteCallId.CfxPostDataIsReadOnlyRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.PostData.cfx_post_data_is_read_only(@this);
        }
    }

    internal class CfxPostDataHasExcludedElementsRemoteCall : RemoteCall {

        internal CfxPostDataHasExcludedElementsRemoteCall()
            : base(RemoteCallId.CfxPostDataHasExcludedElementsRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.PostData.cfx_post_data_has_excluded_elements(@this);
        }
    }

    internal class CfxPostDataGetElementCountRemoteCall : RemoteCall {

        internal CfxPostDataGetElementCountRemoteCall()
            : base(RemoteCallId.CfxPostDataGetElementCountRemoteCall) {}

        internal IntPtr @this;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = (ulong)CfxApi.PostData.cfx_post_data_get_element_count(@this);
        }
    }

    internal class CfxPostDataGetElementsRemoteCall : RemoteCall {

        internal CfxPostDataGetElementsRemoteCall()
            : base(RemoteCallId.CfxPostDataGetElementsRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr[] __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var count = CfxApi.PostData.cfx_post_data_get_element_count(@this);
            __retval = new IntPtr[(ulong)count];
            if(__retval.Length == 0) return;
            var ptrs_p = new PinnedObject(__retval);
            CfxApi.PostData.cfx_post_data_get_elements(@this, count, ptrs_p.PinnedPtr);
            ptrs_p.Free();
            
        }
    }

    internal class CfxPostDataRemoveElementRemoteCall : RemoteCall {

        internal CfxPostDataRemoveElementRemoteCall()
            : base(RemoteCallId.CfxPostDataRemoveElementRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr element;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(element);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out element);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.PostData.cfx_post_data_remove_element(@this, element);
        }
    }

    internal class CfxPostDataAddElementRemoteCall : RemoteCall {

        internal CfxPostDataAddElementRemoteCall()
            : base(RemoteCallId.CfxPostDataAddElementRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr element;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(element);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out element);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.PostData.cfx_post_data_add_element(@this, element);
        }
    }

    internal class CfxPostDataRemoveElementsRemoteCall : RemoteCall {

        internal CfxPostDataRemoveElementsRemoteCall()
            : base(RemoteCallId.CfxPostDataRemoveElementsRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.PostData.cfx_post_data_remove_elements(@this);
        }
    }

}
