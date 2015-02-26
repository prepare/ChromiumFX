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
    /// Structure representing geoposition information. The properties of this
    /// structure correspond to those of the JavaScript Position object although
    /// their types may differ.
    /// </summary>
    public sealed class CfxGeoposition : CfxStructure {

        internal static CfxGeoposition Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxGeoposition(nativePtr);
        }

        internal static CfxGeoposition WrapOwned(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxGeoposition(nativePtr, true);
        }

        private double m_Latitude;
        private double m_Longitude;
        private double m_Altitude;
        private double m_Accuracy;
        private double m_AltitudeAccuracy;
        private double m_Heading;
        private double m_Speed;
        private CfxTime m_Timestamp;
        private CfxGeopositionErrorCode m_ErrorCode;
        private string m_ErrorMessage;

        public CfxGeoposition() : base(CfxApi.cfx_geoposition_ctor, CfxApi.cfx_geoposition_dtor) {}
        internal CfxGeoposition(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_geoposition_ctor, CfxApi.cfx_geoposition_dtor) {}
        internal CfxGeoposition(IntPtr nativePtr, bool owned) : base(nativePtr, CfxApi.cfx_geoposition_ctor, CfxApi.cfx_geoposition_dtor, owned) {}

        /// <summary>
        /// Latitude in decimal degrees north (WGS84 coordinate frame).
        /// </summary>
        public double Latitude {
            get {
                return m_Latitude;
            }
            set {
                m_Latitude = value;
            }
        }

        /// <summary>
        /// Longitude in decimal degrees west (WGS84 coordinate frame).
        /// </summary>
        public double Longitude {
            get {
                return m_Longitude;
            }
            set {
                m_Longitude = value;
            }
        }

        /// <summary>
        /// Altitude in meters (above WGS84 datum).
        /// </summary>
        public double Altitude {
            get {
                return m_Altitude;
            }
            set {
                m_Altitude = value;
            }
        }

        /// <summary>
        /// Accuracy of horizontal position in meters.
        /// </summary>
        public double Accuracy {
            get {
                return m_Accuracy;
            }
            set {
                m_Accuracy = value;
            }
        }

        /// <summary>
        /// Accuracy of altitude in meters.
        /// </summary>
        public double AltitudeAccuracy {
            get {
                return m_AltitudeAccuracy;
            }
            set {
                m_AltitudeAccuracy = value;
            }
        }

        /// <summary>
        /// Heading in decimal degrees clockwise from true north.
        /// </summary>
        public double Heading {
            get {
                return m_Heading;
            }
            set {
                m_Heading = value;
            }
        }

        /// <summary>
        /// Horizontal component of device velocity in meters per second.
        /// </summary>
        public double Speed {
            get {
                return m_Speed;
            }
            set {
                m_Speed = value;
            }
        }

        /// <summary>
        /// Time of position measurement in miliseconds since Epoch in UTC time. This
        /// is taken from the host computer's system clock.
        /// </summary>
        public CfxTime Timestamp {
            get {
                return m_Timestamp;
            }
            set {
                m_Timestamp = value;
            }
        }

        /// <summary>
        /// Error code, see enum above.
        /// </summary>
        public CfxGeopositionErrorCode ErrorCode {
            get {
                return m_ErrorCode;
            }
            set {
                m_ErrorCode = value;
            }
        }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        public string ErrorMessage {
            get {
                return m_ErrorMessage;
            }
            set {
                m_ErrorMessage = value;
            }
        }

        protected override void CopyToNative() {
            var m_ErrorMessage_pinned = new PinnedString(m_ErrorMessage);
            CfxApi.cfx_geoposition_copy_to_native(nativePtrUnchecked, m_Latitude, m_Longitude, m_Altitude, m_Accuracy, m_AltitudeAccuracy, m_Heading, m_Speed, CfxTime.Unwrap(m_Timestamp), m_ErrorCode, m_ErrorMessage_pinned.Obj.PinnedPtr, m_ErrorMessage_pinned.Length);
            m_ErrorMessage_pinned.Obj.Free();
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            IntPtr timestamp = default(IntPtr);
            IntPtr error_message_str = IntPtr.Zero; int error_message_length = 0;
            CfxApi.cfx_geoposition_copy_to_managed(nativePtr, out m_Latitude, out m_Longitude, out m_Altitude, out m_Accuracy, out m_AltitudeAccuracy, out m_Heading, out m_Speed, out timestamp, out m_ErrorCode, out error_message_str, out error_message_length);
            m_Timestamp = CfxTime.Wrap(timestamp);
            m_ErrorMessage = error_message_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(error_message_str, error_message_length) : String.Empty;;
        }
    }
}
