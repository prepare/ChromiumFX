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
    /// Structure representing IME composition underline information. This is a thin
    /// wrapper around Blink's WebCompositionUnderline class and should be kept in
    /// sync with that.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
    /// </remarks>
    public sealed class CfxCompositionUnderline : CfxStructure {

        public CfxCompositionUnderline() : base(CfxApi.CompositionUnderline.cfx_composition_underline_ctor, CfxApi.CompositionUnderline.cfx_composition_underline_dtor) {}

        /// <summary>
        /// Underline character range.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxRange Range {
            get {
                IntPtr value;
                CfxApi.CompositionUnderline.cfx_composition_underline_get_range(nativePtrUnchecked, out value);
                return CfxRange.Wrap(value);
            }
            set {
                CfxApi.CompositionUnderline.cfx_composition_underline_set_range(nativePtrUnchecked, CfxRange.Unwrap(value));
            }
        }

        /// <summary>
        /// Text color.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxColor Color {
            get {
                uint value;
                CfxApi.CompositionUnderline.cfx_composition_underline_get_color(nativePtrUnchecked, out value);
                return CfxColor.Wrap(value);
            }
            set {
                CfxApi.CompositionUnderline.cfx_composition_underline_set_color(nativePtrUnchecked, CfxColor.Unwrap(value));
            }
        }

        /// <summary>
        /// Background color.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxColor BackgroundColor {
            get {
                uint value;
                CfxApi.CompositionUnderline.cfx_composition_underline_get_background_color(nativePtrUnchecked, out value);
                return CfxColor.Wrap(value);
            }
            set {
                CfxApi.CompositionUnderline.cfx_composition_underline_set_background_color(nativePtrUnchecked, CfxColor.Unwrap(value));
            }
        }

        /// <summary>
        /// Set to true (1) for thick underline.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public bool Thick {
            get {
                int value;
                CfxApi.CompositionUnderline.cfx_composition_underline_get_thick(nativePtrUnchecked, out value);
                return 0 != value;
            }
            set {
                CfxApi.CompositionUnderline.cfx_composition_underline_set_thick(nativePtrUnchecked, value ? 1 : 0);
            }
        }

    }
}
