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
    /// Settings used when initializing a CfxBoxLayout.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
    /// </remarks>
    public sealed class CfxBoxLayoutSettings : CfxStructure {

        static CfxBoxLayoutSettings () {
            CfxApiLoader.LoadCfxBoxLayoutSettingsApi();
        }

        public CfxBoxLayoutSettings() : base(CfxApi.cfx_box_layout_settings_ctor, CfxApi.cfx_box_layout_settings_dtor) {}

        /// <summary>
        /// If true (1) the layout will be horizontal, otherwise the layout will be
        /// vertical.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public bool Horizontal {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_horizontal(nativePtrUnchecked, out value);
                return 0 != value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_horizontal(nativePtrUnchecked, value ? 1 : 0);
            }
        }

        /// <summary>
        /// Adds additional horizontal space between the child view area and the host
        /// view border.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public int InsideBorderHorizontalSpacing {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_inside_border_horizontal_spacing(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_inside_border_horizontal_spacing(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Adds additional vertical space between the child view area and the host
        /// view border.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public int InsideBorderVerticalSpacing {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_inside_border_vertical_spacing(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_inside_border_vertical_spacing(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Adds additional space around the child view area.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxInsets InsideBorderInsets {
            get {
                IntPtr value;
                CfxApi.cfx_box_layout_settings_get_inside_border_insets(nativePtrUnchecked, out value);
                return CfxInsets.Wrap(value);
            }
            set {
                CfxApi.cfx_box_layout_settings_set_inside_border_insets(nativePtrUnchecked, CfxInsets.Unwrap(value));
            }
        }

        /// <summary>
        /// Adds additional space between child views.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public int BetweenChildSpacing {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_between_child_spacing(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_between_child_spacing(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Specifies where along the main axis the child views should be laid out.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxMainAxisAlignment MainAxisAlignment {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_main_axis_alignment(nativePtrUnchecked, out value);
                return (CfxMainAxisAlignment)value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_main_axis_alignment(nativePtrUnchecked, (int)value);
            }
        }

        /// <summary>
        /// Specifies where along the cross axis the child views should be laid out.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public CfxCrossAxisAlignment CrossAxisAlignment {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_cross_axis_alignment(nativePtrUnchecked, out value);
                return (CfxCrossAxisAlignment)value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_cross_axis_alignment(nativePtrUnchecked, (int)value);
            }
        }

        /// <summary>
        /// Minimum cross axis size.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public int MinimumCrossAxisSize {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_minimum_cross_axis_size(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_minimum_cross_axis_size(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Default flex for views when none is specified via CfxBoxLayout methods.
        /// Using the preferred size as the basis, free space along the main axis is
        /// distributed to views in the ratio of their flex weights. Similarly, if the
        /// views will overflow the parent, space is subtracted in these ratios. A flex
        /// of 0 means this view is not resized. Flex values must not be negative.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/internal/cef_types.h">cef/include/internal/cef_types.h</see>.
        /// </remarks>
        public int DefaultFlex {
            get {
                int value;
                CfxApi.cfx_box_layout_settings_get_default_flex(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_box_layout_settings_set_default_flex(nativePtrUnchecked, value);
            }
        }

    }
}
