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

namespace Chromium {
    /// <summary>
    /// Time information. Values should always be in UTC.
    /// </summary>
    public sealed partial class CfxTime : CfxStructure {

        internal static CfxTime Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxTime(nativePtr);
        }

        private int m_Year;
        private int m_Month;
        private int m_DayOfWeek;
        private int m_DayOfMonth;
        private int m_Hour;
        private int m_Minute;
        private int m_Second;
        private int m_Millisecond;

        public CfxTime() : base(CfxApi.cfx_time_ctor, CfxApi.cfx_time_dtor) {}
        internal CfxTime(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_time_ctor, CfxApi.cfx_time_dtor) {}

        public int Year {
            get {
                return m_Year;
            }
            set {
                m_Year = value;
            }
        }

        public int Month {
            get {
                return m_Month;
            }
            set {
                m_Month = value;
            }
        }

        public int DayOfWeek {
            get {
                return m_DayOfWeek;
            }
            set {
                m_DayOfWeek = value;
            }
        }

        public int DayOfMonth {
            get {
                return m_DayOfMonth;
            }
            set {
                m_DayOfMonth = value;
            }
        }

        public int Hour {
            get {
                return m_Hour;
            }
            set {
                m_Hour = value;
            }
        }

        public int Minute {
            get {
                return m_Minute;
            }
            set {
                m_Minute = value;
            }
        }

        public int Second {
            get {
                return m_Second;
            }
            set {
                m_Second = value;
            }
        }

        /// <summary>
        /// seconds which may take it up to 60).
        /// </summary>
        public int Millisecond {
            get {
                return m_Millisecond;
            }
            set {
                m_Millisecond = value;
            }
        }

        protected override void CopyToNative() {
            CfxApi.cfx_time_copy_to_native(nativePtrUnchecked, m_Year, m_Month, m_DayOfWeek, m_DayOfMonth, m_Hour, m_Minute, m_Second, m_Millisecond);
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            CfxApi.cfx_time_copy_to_managed(nativePtr, out m_Year, out m_Month, out m_DayOfWeek, out m_DayOfMonth, out m_Hour, out m_Minute, out m_Second, out m_Millisecond);
        }
    }
}
