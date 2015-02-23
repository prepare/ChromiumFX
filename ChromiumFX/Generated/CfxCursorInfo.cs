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
    /// Structure representing cursor information. |buffer| will be
    /// |size.width|*|size.height|*4 bytes in size and represents a BGRA image with
    /// an upper-left origin.
    /// </summary>
    public sealed class CfxCursorInfo : CfxStructure {

        private CfxPoint m_Hotspot;
        private float m_ImageScaleFactor;
        private IntPtr m_Buffer;

        public CfxCursorInfo() : base(CfxApi.cfx_cursor_info_ctor, CfxApi.cfx_cursor_info_dtor) {}

        public CfxPoint Hotspot {
            get {
                return m_Hotspot;
            }
            set {
                m_Hotspot = value;
            }
        }

        public float ImageScaleFactor {
            get {
                return m_ImageScaleFactor;
            }
            set {
                m_ImageScaleFactor = value;
            }
        }

        public IntPtr Buffer {
            get {
                return m_Buffer;
            }
            set {
                m_Buffer = value;
            }
        }

        protected override void CopyToNative() {
            CfxApi.cfx_cursor_info_copy_to_native(nativePtrUnchecked, CfxPoint.Unwrap(m_Hotspot), m_ImageScaleFactor, m_Buffer);
        }

    }
}
