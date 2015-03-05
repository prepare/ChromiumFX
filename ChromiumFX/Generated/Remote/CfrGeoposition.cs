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

    /// <summary>
    /// Structure representing geoposition information. The properties of this
    /// structure correspond to those of the JavaScript Position object although
    /// their types may differ.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
    /// </remarks>
    public sealed class CfrGeoposition : CfrStructure {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrGeoposition Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrGeoposition)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrGeoposition(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxGeopositionCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        private CfrGeoposition(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrGeoposition(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        double m_Latitude;
        bool m_Latitude_fetched;

        /// <summary>
        /// Latitude in decimal degrees north (WGS84 coordinate frame).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Latitude {
            get {
                if(!m_Latitude_fetched) {
                    var call = new CfxGeopositionGetLatitudeRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Latitude = call.value;
                    m_Latitude_fetched = true;
                }
                return m_Latitude;
            }
            set {
                var call = new CfxGeopositionSetLatitudeRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Latitude = value;
                m_Latitude_fetched = true;
            }
        }

        double m_Longitude;
        bool m_Longitude_fetched;

        /// <summary>
        /// Longitude in decimal degrees west (WGS84 coordinate frame).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Longitude {
            get {
                if(!m_Longitude_fetched) {
                    var call = new CfxGeopositionGetLongitudeRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Longitude = call.value;
                    m_Longitude_fetched = true;
                }
                return m_Longitude;
            }
            set {
                var call = new CfxGeopositionSetLongitudeRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Longitude = value;
                m_Longitude_fetched = true;
            }
        }

        double m_Altitude;
        bool m_Altitude_fetched;

        /// <summary>
        /// Altitude in meters (above WGS84 datum).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Altitude {
            get {
                if(!m_Altitude_fetched) {
                    var call = new CfxGeopositionGetAltitudeRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Altitude = call.value;
                    m_Altitude_fetched = true;
                }
                return m_Altitude;
            }
            set {
                var call = new CfxGeopositionSetAltitudeRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Altitude = value;
                m_Altitude_fetched = true;
            }
        }

        double m_Accuracy;
        bool m_Accuracy_fetched;

        /// <summary>
        /// Accuracy of horizontal position in meters.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Accuracy {
            get {
                if(!m_Accuracy_fetched) {
                    var call = new CfxGeopositionGetAccuracyRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Accuracy = call.value;
                    m_Accuracy_fetched = true;
                }
                return m_Accuracy;
            }
            set {
                var call = new CfxGeopositionSetAccuracyRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Accuracy = value;
                m_Accuracy_fetched = true;
            }
        }

        double m_AltitudeAccuracy;
        bool m_AltitudeAccuracy_fetched;

        /// <summary>
        /// Accuracy of altitude in meters.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double AltitudeAccuracy {
            get {
                if(!m_AltitudeAccuracy_fetched) {
                    var call = new CfxGeopositionGetAltitudeAccuracyRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_AltitudeAccuracy = call.value;
                    m_AltitudeAccuracy_fetched = true;
                }
                return m_AltitudeAccuracy;
            }
            set {
                var call = new CfxGeopositionSetAltitudeAccuracyRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_AltitudeAccuracy = value;
                m_AltitudeAccuracy_fetched = true;
            }
        }

        double m_Heading;
        bool m_Heading_fetched;

        /// <summary>
        /// Heading in decimal degrees clockwise from true north.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Heading {
            get {
                if(!m_Heading_fetched) {
                    var call = new CfxGeopositionGetHeadingRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Heading = call.value;
                    m_Heading_fetched = true;
                }
                return m_Heading;
            }
            set {
                var call = new CfxGeopositionSetHeadingRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Heading = value;
                m_Heading_fetched = true;
            }
        }

        double m_Speed;
        bool m_Speed_fetched;

        /// <summary>
        /// Horizontal component of device velocity in meters per second.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public double Speed {
            get {
                if(!m_Speed_fetched) {
                    var call = new CfxGeopositionGetSpeedRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Speed = call.value;
                    m_Speed_fetched = true;
                }
                return m_Speed;
            }
            set {
                var call = new CfxGeopositionSetSpeedRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_Speed = value;
                m_Speed_fetched = true;
            }
        }

        CfrTime m_Timestamp;
        bool m_Timestamp_fetched;

        /// <summary>
        /// Time of position measurement in miliseconds since Epoch in UTC time. This
        /// is taken from the host computer's system clock.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfrTime Timestamp {
            get {
                if(!m_Timestamp_fetched) {
                    var call = new CfxGeopositionGetTimestampRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_Timestamp = CfrTime.Wrap(call.value, remoteRuntime);
                    m_Timestamp_fetched = true;
                }
                return m_Timestamp;
            }
            set {
                var call = new CfxGeopositionSetTimestampRenderProcessCall();
                call.sender = this.proxyId;
                call.value = CfrTime.Unwrap(value);
                call.Execute(remoteRuntime.connection);
                m_Timestamp = value;
                m_Timestamp_fetched = true;
            }
        }

        CfxGeopositionErrorCode m_ErrorCode;
        bool m_ErrorCode_fetched;

        /// <summary>
        /// Error code, see enum above.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxGeopositionErrorCode ErrorCode {
            get {
                if(!m_ErrorCode_fetched) {
                    var call = new CfxGeopositionGetErrorCodeRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_ErrorCode = (CfxGeopositionErrorCode)call.value;
                    m_ErrorCode_fetched = true;
                }
                return m_ErrorCode;
            }
            set {
                var call = new CfxGeopositionSetErrorCodeRenderProcessCall();
                call.sender = this.proxyId;
                call.value = (int)value;
                call.Execute(remoteRuntime.connection);
                m_ErrorCode = value;
                m_ErrorCode_fetched = true;
            }
        }

        string m_ErrorMessage;
        bool m_ErrorMessage_fetched;

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public string ErrorMessage {
            get {
                if(!m_ErrorMessage_fetched) {
                    var call = new CfxGeopositionGetErrorMessageRenderProcessCall();
                    call.sender = this.proxyId;
                    call.Execute(remoteRuntime.connection);
                    m_ErrorMessage = call.value;
                    m_ErrorMessage_fetched = true;
                }
                return m_ErrorMessage;
            }
            set {
                var call = new CfxGeopositionSetErrorMessageRenderProcessCall();
                call.sender = this.proxyId;
                call.value = value;
                call.Execute(remoteRuntime.connection);
                m_ErrorMessage = value;
                m_ErrorMessage_fetched = true;
            }
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
