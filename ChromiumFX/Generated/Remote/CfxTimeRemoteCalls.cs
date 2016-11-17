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

    internal class CfxTimeCtorRemoteCall : CtorRemoteCall {

        internal CfxTimeCtorRemoteCall()
            : base(RemoteCallId.CfxTimeCtorRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteProxy.Wrap(new CfxTime());
        }
    }

    internal class CfxTimeGetYearRemoteCall : RemoteCall {

        internal CfxTimeGetYearRemoteCall()
            : base(RemoteCallId.CfxTimeGetYearRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Year;
        }
    }
    internal class CfxTimeSetYearRemoteCall : RemoteCall {

        internal CfxTimeSetYearRemoteCall()
            : base(RemoteCallId.CfxTimeSetYearRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Year = value;
        }
    }
    internal class CfxTimeGetMonthRemoteCall : RemoteCall {

        internal CfxTimeGetMonthRemoteCall()
            : base(RemoteCallId.CfxTimeGetMonthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Month;
        }
    }
    internal class CfxTimeSetMonthRemoteCall : RemoteCall {

        internal CfxTimeSetMonthRemoteCall()
            : base(RemoteCallId.CfxTimeSetMonthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Month = value;
        }
    }
    internal class CfxTimeGetDayOfWeekRemoteCall : RemoteCall {

        internal CfxTimeGetDayOfWeekRemoteCall()
            : base(RemoteCallId.CfxTimeGetDayOfWeekRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.DayOfWeek;
        }
    }
    internal class CfxTimeSetDayOfWeekRemoteCall : RemoteCall {

        internal CfxTimeSetDayOfWeekRemoteCall()
            : base(RemoteCallId.CfxTimeSetDayOfWeekRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.DayOfWeek = value;
        }
    }
    internal class CfxTimeGetDayOfMonthRemoteCall : RemoteCall {

        internal CfxTimeGetDayOfMonthRemoteCall()
            : base(RemoteCallId.CfxTimeGetDayOfMonthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.DayOfMonth;
        }
    }
    internal class CfxTimeSetDayOfMonthRemoteCall : RemoteCall {

        internal CfxTimeSetDayOfMonthRemoteCall()
            : base(RemoteCallId.CfxTimeSetDayOfMonthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.DayOfMonth = value;
        }
    }
    internal class CfxTimeGetHourRemoteCall : RemoteCall {

        internal CfxTimeGetHourRemoteCall()
            : base(RemoteCallId.CfxTimeGetHourRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Hour;
        }
    }
    internal class CfxTimeSetHourRemoteCall : RemoteCall {

        internal CfxTimeSetHourRemoteCall()
            : base(RemoteCallId.CfxTimeSetHourRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Hour = value;
        }
    }
    internal class CfxTimeGetMinuteRemoteCall : RemoteCall {

        internal CfxTimeGetMinuteRemoteCall()
            : base(RemoteCallId.CfxTimeGetMinuteRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Minute;
        }
    }
    internal class CfxTimeSetMinuteRemoteCall : RemoteCall {

        internal CfxTimeSetMinuteRemoteCall()
            : base(RemoteCallId.CfxTimeSetMinuteRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Minute = value;
        }
    }
    internal class CfxTimeGetSecondRemoteCall : RemoteCall {

        internal CfxTimeGetSecondRemoteCall()
            : base(RemoteCallId.CfxTimeGetSecondRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Second;
        }
    }
    internal class CfxTimeSetSecondRemoteCall : RemoteCall {

        internal CfxTimeSetSecondRemoteCall()
            : base(RemoteCallId.CfxTimeSetSecondRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Second = value;
        }
    }
    internal class CfxTimeGetMillisecondRemoteCall : RemoteCall {

        internal CfxTimeGetMillisecondRemoteCall()
            : base(RemoteCallId.CfxTimeGetMillisecondRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            value = sender.Millisecond;
        }
    }
    internal class CfxTimeSetMillisecondRemoteCall : RemoteCall {

        internal CfxTimeSetMillisecondRemoteCall()
            : base(RemoteCallId.CfxTimeSetMillisecondRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var sender = (CfxTime)RemoteProxy.Unwrap(this.sender, null);
            sender.Millisecond = value;
        }
    }
}
