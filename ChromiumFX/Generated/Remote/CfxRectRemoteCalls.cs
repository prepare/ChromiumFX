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

    internal class CfxRectCtorRenderProcessCall : RenderProcessCall {

        internal CfxRectCtorRenderProcessCall()
            : base(RemoteCallId.CfxRectCtorRenderProcessCall) {}

        internal IntPtr __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxRect());
        }
    }

    internal class CfxRectGetXRenderProcessCall : RenderProcessCall {

        internal CfxRectGetXRenderProcessCall()
            : base(RemoteCallId.CfxRectGetXRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            value = sender.X;
        }
    }
    internal class CfxRectSetXRenderProcessCall : RenderProcessCall {

        internal CfxRectSetXRenderProcessCall()
            : base(RemoteCallId.CfxRectSetXRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            sender.X = value;
        }
    }
    internal class CfxRectGetYRenderProcessCall : RenderProcessCall {

        internal CfxRectGetYRenderProcessCall()
            : base(RemoteCallId.CfxRectGetYRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Y;
        }
    }
    internal class CfxRectSetYRenderProcessCall : RenderProcessCall {

        internal CfxRectSetYRenderProcessCall()
            : base(RemoteCallId.CfxRectSetYRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            sender.Y = value;
        }
    }
    internal class CfxRectGetWidthRenderProcessCall : RenderProcessCall {

        internal CfxRectGetWidthRenderProcessCall()
            : base(RemoteCallId.CfxRectGetWidthRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Width;
        }
    }
    internal class CfxRectSetWidthRenderProcessCall : RenderProcessCall {

        internal CfxRectSetWidthRenderProcessCall()
            : base(RemoteCallId.CfxRectSetWidthRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            sender.Width = value;
        }
    }
    internal class CfxRectGetHeightRenderProcessCall : RenderProcessCall {

        internal CfxRectGetHeightRenderProcessCall()
            : base(RemoteCallId.CfxRectGetHeightRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Height;
        }
    }
    internal class CfxRectSetHeightRenderProcessCall : RenderProcessCall {

        internal CfxRectSetHeightRenderProcessCall()
            : base(RemoteCallId.CfxRectSetHeightRenderProcessCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxRect)RemoteProxy.Unwrap(this.sender, null);
            sender.Height = value;
        }
    }
}
