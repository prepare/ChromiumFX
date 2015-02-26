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
    /// Structure representing window information.
    /// </summary>
    public sealed class CfxWindowInfo : CfxStructure {

        internal static CfxWindowInfo Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxWindowInfo(nativePtr);
        }

        internal static CfxWindowInfo WrapOwned(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxWindowInfo(nativePtr, true);
        }

        private int m_ExStyle;
        private string m_WindowName;
        private int m_Style;
        private int m_X;
        private int m_Y;
        private int m_Width;
        private int m_Height;
        private IntPtr m_ParentWindow;
        private IntPtr m_Menu;
        private bool m_WindowlessRenderingEnabled;
        private bool m_TransparentPaintingEnabled;
        private IntPtr m_Window;

        public CfxWindowInfo() : base(CfxApi.cfx_window_info_ctor, CfxApi.cfx_window_info_dtor) {}
        internal CfxWindowInfo(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_window_info_ctor, CfxApi.cfx_window_info_dtor) {}
        internal CfxWindowInfo(IntPtr nativePtr, bool owned) : base(nativePtr, CfxApi.cfx_window_info_ctor, CfxApi.cfx_window_info_dtor, owned) {}

        /// <summary>
        /// Standard parameters required by CreateWindowEx()
        /// </summary>
        public int ExStyle {
            get {
                return m_ExStyle;
            }
            set {
                m_ExStyle = value;
            }
        }

        public string WindowName {
            get {
                return m_WindowName;
            }
            set {
                m_WindowName = value;
            }
        }

        public int Style {
            get {
                return m_Style;
            }
            set {
                m_Style = value;
            }
        }

        public int X {
            get {
                return m_X;
            }
            set {
                m_X = value;
            }
        }

        public int Y {
            get {
                return m_Y;
            }
            set {
                m_Y = value;
            }
        }

        public int Width {
            get {
                return m_Width;
            }
            set {
                m_Width = value;
            }
        }

        public int Height {
            get {
                return m_Height;
            }
            set {
                m_Height = value;
            }
        }

        public IntPtr ParentWindow {
            get {
                return m_ParentWindow;
            }
            set {
                m_ParentWindow = value;
            }
        }

        public IntPtr Menu {
            get {
                return m_Menu;
            }
            set {
                m_Menu = value;
            }
        }

        /// <summary>
        /// Set to true (1) to create the browser using windowless (off-screen)
        /// rendering. No window will be created for the browser and all rendering will
        /// occur via the CefRenderHandler interface. The |parent_window| value will be
        /// used to identify monitor info and to act as the parent window for dialogs,
        /// context menus, etc. If |parent_window| is not provided then the main screen
        /// monitor will be used and some functionality that requires a parent window
        /// may not function correctly. In order to create windowless browsers the
        /// CefSettings.windowless_rendering_enabled value must be set to true.
        /// </summary>
        public bool WindowlessRenderingEnabled {
            get {
                return m_WindowlessRenderingEnabled;
            }
            set {
                m_WindowlessRenderingEnabled = value;
            }
        }

        /// <summary>
        /// Set to true (1) to enable transparent painting in combination with
        /// windowless rendering. When this value is true a transparent background
        /// color will be used (RGBA=0x00000000). When this value is false the
        /// background will be white and opaque.
        /// </summary>
        public bool TransparentPaintingEnabled {
            get {
                return m_TransparentPaintingEnabled;
            }
            set {
                m_TransparentPaintingEnabled = value;
            }
        }

        /// <summary>
        /// Handle for the new browser window. Only used with windowed rendering.
        /// </summary>
        public IntPtr Window {
            get {
                return m_Window;
            }
            set {
                m_Window = value;
            }
        }

        protected override void CopyToNative() {
            var m_WindowName_pinned = new PinnedString(m_WindowName);
            CfxApi.cfx_window_info_copy_to_native(nativePtrUnchecked, m_ExStyle, m_WindowName_pinned.Obj.PinnedPtr, m_WindowName_pinned.Length, m_Style, m_X, m_Y, m_Width, m_Height, m_ParentWindow, m_Menu, m_WindowlessRenderingEnabled ? 1 : 0, m_TransparentPaintingEnabled ? 1 : 0, m_Window);
            m_WindowName_pinned.Obj.Free();
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            IntPtr window_name_str = IntPtr.Zero; int window_name_length = 0;
            int windowless_rendering_enabled = default(int);
            int transparent_painting_enabled = default(int);
            CfxApi.cfx_window_info_copy_to_managed(nativePtr, out m_ExStyle, out window_name_str, out window_name_length, out m_Style, out m_X, out m_Y, out m_Width, out m_Height, out m_ParentWindow, out m_Menu, out windowless_rendering_enabled, out transparent_painting_enabled, out m_Window);
            m_WindowName = window_name_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(window_name_str, window_name_length) : String.Empty;;
            m_WindowlessRenderingEnabled = 0 != windowless_rendering_enabled;
            m_TransparentPaintingEnabled = 0 != transparent_painting_enabled;
        }
    }
}
