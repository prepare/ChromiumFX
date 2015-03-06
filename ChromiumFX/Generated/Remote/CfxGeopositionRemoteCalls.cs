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

    internal class CfxGeopositionCtorRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionCtorRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionCtorRenderProcessCall) {}

        internal ulong __retval;
        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxGeoposition());
        }
    }

    internal class CfxGeopositionGetLatitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetLatitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetLatitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Latitude;
        }
    }
    internal class CfxGeopositionSetLatitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetLatitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetLatitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Latitude = value;
        }
    }
    internal class CfxGeopositionGetLongitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetLongitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetLongitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Longitude;
        }
    }
    internal class CfxGeopositionSetLongitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetLongitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetLongitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Longitude = value;
        }
    }
    internal class CfxGeopositionGetAltitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetAltitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetAltitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Altitude;
        }
    }
    internal class CfxGeopositionSetAltitudeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetAltitudeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetAltitudeRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Altitude = value;
        }
    }
    internal class CfxGeopositionGetAccuracyRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetAccuracyRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetAccuracyRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Accuracy;
        }
    }
    internal class CfxGeopositionSetAccuracyRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetAccuracyRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetAccuracyRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Accuracy = value;
        }
    }
    internal class CfxGeopositionGetAltitudeAccuracyRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetAltitudeAccuracyRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetAltitudeAccuracyRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.AltitudeAccuracy;
        }
    }
    internal class CfxGeopositionSetAltitudeAccuracyRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetAltitudeAccuracyRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetAltitudeAccuracyRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.AltitudeAccuracy = value;
        }
    }
    internal class CfxGeopositionGetHeadingRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetHeadingRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetHeadingRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Heading;
        }
    }
    internal class CfxGeopositionSetHeadingRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetHeadingRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetHeadingRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Heading = value;
        }
    }
    internal class CfxGeopositionGetSpeedRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetSpeedRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetSpeedRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.Speed;
        }
    }
    internal class CfxGeopositionSetSpeedRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetSpeedRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetSpeedRenderProcessCall) {}
        internal ulong sender;
        internal double value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Speed = value;
        }
    }
    internal class CfxGeopositionGetTimestampRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetTimestampRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetTimestampRenderProcessCall) {}
        internal ulong sender;
        internal ulong value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = RemoteProxy.Wrap(sender.Timestamp);
        }
    }
    internal class CfxGeopositionSetTimestampRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetTimestampRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetTimestampRenderProcessCall) {}
        internal ulong sender;
        internal ulong value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.Timestamp = (CfxTime)RemoteProxy.Unwrap(value);
        }
    }
    internal class CfxGeopositionGetErrorCodeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetErrorCodeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetErrorCodeRenderProcessCall) {}
        internal ulong sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = (int)sender.ErrorCode;
        }
    }
    internal class CfxGeopositionSetErrorCodeRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetErrorCodeRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetErrorCodeRenderProcessCall) {}
        internal ulong sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.ErrorCode = (CfxGeopositionErrorCode)value;
        }
    }
    internal class CfxGeopositionGetErrorMessageRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionGetErrorMessageRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionGetErrorMessageRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            value = sender.ErrorMessage;
        }
    }
    internal class CfxGeopositionSetErrorMessageRenderProcessCall : RenderProcessCall {

        internal CfxGeopositionSetErrorMessageRenderProcessCall()
            : base(RemoteCallId.CfxGeopositionSetErrorMessageRenderProcessCall) {}
        internal ulong sender;
        internal string value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxGeoposition)RemoteProxy.Unwrap(this.sender);
            sender.ErrorMessage = value;
        }
    }
}
