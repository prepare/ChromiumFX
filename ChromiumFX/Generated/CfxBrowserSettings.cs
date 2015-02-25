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
    /// Browser initialization settings. Specify NULL or 0 to get the recommended
    /// default values. The consequences of using custom values may not be well
    /// tested. Many of these and other settings can also configured using command-
    /// line switches.
    /// </summary>
    public sealed class CfxBrowserSettings : CfxStructure {

        internal static CfxBrowserSettings Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxBrowserSettings(nativePtr);
        }

        private int m_WindowlessFrameRate;
        private string m_StandardFontFamily;
        private string m_FixedFontFamily;
        private string m_SerifFontFamily;
        private string m_SansSerifFontFamily;
        private string m_CursiveFontFamily;
        private string m_FantasyFontFamily;
        private int m_DefaultFontSize;
        private int m_DefaultFixedFontSize;
        private int m_MinimumFontSize;
        private int m_MinimumLogicalFontSize;
        private string m_DefaultEncoding;
        private CfxState m_RemoteFonts;
        private CfxState m_Javascript;
        private CfxState m_JavascriptOpenWindows;
        private CfxState m_JavascriptCloseWindows;
        private CfxState m_JavascriptAccessClipboard;
        private CfxState m_JavascriptDomPaste;
        private CfxState m_CaretBrowsing;
        private CfxState m_Java;
        private CfxState m_Plugins;
        private CfxState m_UniversalAccessFromFileUrls;
        private CfxState m_FileAccessFromFileUrls;
        private CfxState m_WebSecUrity;
        private CfxState m_ImageLoading;
        private CfxState m_ImageShrinkStandaloneToFit;
        private CfxState m_TextAreaResize;
        private CfxState m_TabToLinks;
        private CfxState m_LocalStorage;
        private CfxState m_Databases;
        private CfxState m_ApplicationCache;
        private CfxState m_Webgl;
        private CfxColor m_BackgroundColor;

        public CfxBrowserSettings() : base(CfxApi.cfx_browser_settings_ctor, CfxApi.cfx_browser_settings_dtor) {}
        internal CfxBrowserSettings(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_browser_settings_ctor, CfxApi.cfx_browser_settings_dtor) {}

        /// <summary>
        /// The maximum rate in frames per second (fps) that CefRenderHandler::OnPaint
        /// will be called for a windowless browser. The actual fps may be lower if
        /// the browser cannot generate frames at the requested rate. The minimum
        /// value is 1 and the maximum value is 60 (default 30).
        /// </summary>
        public int WindowlessFrameRate {
            get {
                return m_WindowlessFrameRate;
            }
            set {
                m_WindowlessFrameRate = value;
            }
        }

        /// <summary>
        /// The below values map to WebPreferences settings.
        /// Font settings.
        /// </summary>
        public string StandardFontFamily {
            get {
                return m_StandardFontFamily;
            }
            set {
                m_StandardFontFamily = value;
            }
        }

        public string FixedFontFamily {
            get {
                return m_FixedFontFamily;
            }
            set {
                m_FixedFontFamily = value;
            }
        }

        public string SerifFontFamily {
            get {
                return m_SerifFontFamily;
            }
            set {
                m_SerifFontFamily = value;
            }
        }

        public string SansSerifFontFamily {
            get {
                return m_SansSerifFontFamily;
            }
            set {
                m_SansSerifFontFamily = value;
            }
        }

        public string CursiveFontFamily {
            get {
                return m_CursiveFontFamily;
            }
            set {
                m_CursiveFontFamily = value;
            }
        }

        public string FantasyFontFamily {
            get {
                return m_FantasyFontFamily;
            }
            set {
                m_FantasyFontFamily = value;
            }
        }

        public int DefaultFontSize {
            get {
                return m_DefaultFontSize;
            }
            set {
                m_DefaultFontSize = value;
            }
        }

        public int DefaultFixedFontSize {
            get {
                return m_DefaultFixedFontSize;
            }
            set {
                m_DefaultFixedFontSize = value;
            }
        }

        public int MinimumFontSize {
            get {
                return m_MinimumFontSize;
            }
            set {
                m_MinimumFontSize = value;
            }
        }

        public int MinimumLogicalFontSize {
            get {
                return m_MinimumLogicalFontSize;
            }
            set {
                m_MinimumLogicalFontSize = value;
            }
        }

        /// <summary>
        /// Default encoding for Web content. If empty "ISO-8859-1" will be used. Also
        /// configurable using the "default-encoding" command-line switch.
        /// </summary>
        public string DefaultEncoding {
            get {
                return m_DefaultEncoding;
            }
            set {
                m_DefaultEncoding = value;
            }
        }

        /// <summary>
        /// Controls the loading of fonts from remote sources. Also configurable using
        /// the "disable-remote-fonts" command-line switch.
        /// </summary>
        public CfxState RemoteFonts {
            get {
                return m_RemoteFonts;
            }
            set {
                m_RemoteFonts = value;
            }
        }

        /// <summary>
        /// Controls whether JavaScript can be executed. Also configurable using the
        /// "disable-javascript" command-line switch.
        /// </summary>
        public CfxState Javascript {
            get {
                return m_Javascript;
            }
            set {
                m_Javascript = value;
            }
        }

        /// <summary>
        /// Controls whether JavaScript can be used for opening windows. Also
        /// configurable using the "disable-javascript-open-windows" command-line
        /// switch.
        /// </summary>
        public CfxState JavascriptOpenWindows {
            get {
                return m_JavascriptOpenWindows;
            }
            set {
                m_JavascriptOpenWindows = value;
            }
        }

        /// <summary>
        /// Controls whether JavaScript can be used to close windows that were not
        /// opened via JavaScript. JavaScript can still be used to close windows that
        /// were opened via JavaScript. Also configurable using the
        /// "disable-javascript-close-windows" command-line switch.
        /// </summary>
        public CfxState JavascriptCloseWindows {
            get {
                return m_JavascriptCloseWindows;
            }
            set {
                m_JavascriptCloseWindows = value;
            }
        }

        /// <summary>
        /// Controls whether JavaScript can access the clipboard. Also configurable
        /// using the "disable-javascript-access-clipboard" command-line switch.
        /// </summary>
        public CfxState JavascriptAccessClipboard {
            get {
                return m_JavascriptAccessClipboard;
            }
            set {
                m_JavascriptAccessClipboard = value;
            }
        }

        /// <summary>
        /// Controls whether DOM pasting is supported in the editor via
        /// execCommand("paste"). The |javascript_access_clipboard| setting must also
        /// be enabled. Also configurable using the "disable-javascript-dom-paste"
        /// command-line switch.
        /// </summary>
        public CfxState JavascriptDomPaste {
            get {
                return m_JavascriptDomPaste;
            }
            set {
                m_JavascriptDomPaste = value;
            }
        }

        /// <summary>
        /// Controls whether the caret position will be drawn. Also configurable using
        /// the "enable-caret-browsing" command-line switch.
        /// </summary>
        public CfxState CaretBrowsing {
            get {
                return m_CaretBrowsing;
            }
            set {
                m_CaretBrowsing = value;
            }
        }

        /// <summary>
        /// Controls whether the Java plugin will be loaded. Also configurable using
        /// the "disable-java" command-line switch.
        /// </summary>
        public CfxState Java {
            get {
                return m_Java;
            }
            set {
                m_Java = value;
            }
        }

        /// <summary>
        /// Controls whether any plugins will be loaded. Also configurable using the
        /// "disable-plugins" command-line switch.
        /// </summary>
        public CfxState Plugins {
            get {
                return m_Plugins;
            }
            set {
                m_Plugins = value;
            }
        }

        /// <summary>
        /// Controls whether file URLs will have access to all URLs. Also configurable
        /// using the "allow-universal-access-from-files" command-line switch.
        /// </summary>
        public CfxState UniversalAccessFromFileUrls {
            get {
                return m_UniversalAccessFromFileUrls;
            }
            set {
                m_UniversalAccessFromFileUrls = value;
            }
        }

        /// <summary>
        /// Controls whether file URLs will have access to other file URLs. Also
        /// configurable using the "allow-access-from-files" command-line switch.
        /// </summary>
        public CfxState FileAccessFromFileUrls {
            get {
                return m_FileAccessFromFileUrls;
            }
            set {
                m_FileAccessFromFileUrls = value;
            }
        }

        /// <summary>
        /// Controls whether web security restrictions (same-origin policy) will be
        /// enforced. Disabling this setting is not recommend as it will allow risky
        /// security behavior such as cross-site scripting (XSS). Also configurable
        /// using the "disable-web-security" command-line switch.
        /// </summary>
        public CfxState WebSecUrity {
            get {
                return m_WebSecUrity;
            }
            set {
                m_WebSecUrity = value;
            }
        }

        /// <summary>
        /// Controls whether image URLs will be loaded from the network. A cached image
        /// will still be rendered if requested. Also configurable using the
        /// "disable-image-loading" command-line switch.
        /// </summary>
        public CfxState ImageLoading {
            get {
                return m_ImageLoading;
            }
            set {
                m_ImageLoading = value;
            }
        }

        /// <summary>
        /// Controls whether standalone images will be shrunk to fit the page. Also
        /// configurable using the "image-shrink-standalone-to-fit" command-line
        /// switch.
        /// </summary>
        public CfxState ImageShrinkStandaloneToFit {
            get {
                return m_ImageShrinkStandaloneToFit;
            }
            set {
                m_ImageShrinkStandaloneToFit = value;
            }
        }

        /// <summary>
        /// Controls whether text areas can be resized. Also configurable using the
        /// "disable-text-area-resize" command-line switch.
        /// </summary>
        public CfxState TextAreaResize {
            get {
                return m_TextAreaResize;
            }
            set {
                m_TextAreaResize = value;
            }
        }

        /// <summary>
        /// Controls whether the tab key can advance focus to links. Also configurable
        /// using the "disable-tab-to-links" command-line switch.
        /// </summary>
        public CfxState TabToLinks {
            get {
                return m_TabToLinks;
            }
            set {
                m_TabToLinks = value;
            }
        }

        /// <summary>
        /// Controls whether local storage can be used. Also configurable using the
        /// "disable-local-storage" command-line switch.
        /// </summary>
        public CfxState LocalStorage {
            get {
                return m_LocalStorage;
            }
            set {
                m_LocalStorage = value;
            }
        }

        /// <summary>
        /// Controls whether databases can be used. Also configurable using the
        /// "disable-databases" command-line switch.
        /// </summary>
        public CfxState Databases {
            get {
                return m_Databases;
            }
            set {
                m_Databases = value;
            }
        }

        /// <summary>
        /// Controls whether the application cache can be used. Also configurable using
        /// the "disable-application-cache" command-line switch.
        /// </summary>
        public CfxState ApplicationCache {
            get {
                return m_ApplicationCache;
            }
            set {
                m_ApplicationCache = value;
            }
        }

        /// <summary>
        /// Controls whether WebGL can be used. Note that WebGL requires hardware
        /// support and may not work on all systems even when enabled. Also
        /// configurable using the "disable-webgl" command-line switch.
        /// </summary>
        public CfxState Webgl {
            get {
                return m_Webgl;
            }
            set {
                m_Webgl = value;
            }
        }

        /// <summary>
        /// Opaque background color used for the browser before a document is loaded
        /// and when no document color is specified. By default the background color
        /// will be the same as CefSettings.background_color. Only the RGB compontents
        /// of the specified value will be used. The alpha component must greater than
        /// 0 to enable use of the background color but will be otherwise ignored.
        /// </summary>
        public CfxColor BackgroundColor {
            get {
                return m_BackgroundColor;
            }
            set {
                m_BackgroundColor = value;
            }
        }

        protected override void CopyToNative() {
            var m_StandardFontFamily_pinned = new PinnedString(m_StandardFontFamily);
            var m_FixedFontFamily_pinned = new PinnedString(m_FixedFontFamily);
            var m_SerifFontFamily_pinned = new PinnedString(m_SerifFontFamily);
            var m_SansSerifFontFamily_pinned = new PinnedString(m_SansSerifFontFamily);
            var m_CursiveFontFamily_pinned = new PinnedString(m_CursiveFontFamily);
            var m_FantasyFontFamily_pinned = new PinnedString(m_FantasyFontFamily);
            var m_DefaultEncoding_pinned = new PinnedString(m_DefaultEncoding);
            CfxApi.cfx_browser_settings_copy_to_native(nativePtrUnchecked, m_WindowlessFrameRate, m_StandardFontFamily_pinned.Obj.PinnedPtr, m_StandardFontFamily_pinned.Length, m_FixedFontFamily_pinned.Obj.PinnedPtr, m_FixedFontFamily_pinned.Length, m_SerifFontFamily_pinned.Obj.PinnedPtr, m_SerifFontFamily_pinned.Length, m_SansSerifFontFamily_pinned.Obj.PinnedPtr, m_SansSerifFontFamily_pinned.Length, m_CursiveFontFamily_pinned.Obj.PinnedPtr, m_CursiveFontFamily_pinned.Length, m_FantasyFontFamily_pinned.Obj.PinnedPtr, m_FantasyFontFamily_pinned.Length, m_DefaultFontSize, m_DefaultFixedFontSize, m_MinimumFontSize, m_MinimumLogicalFontSize, m_DefaultEncoding_pinned.Obj.PinnedPtr, m_DefaultEncoding_pinned.Length, m_RemoteFonts, m_Javascript, m_JavascriptOpenWindows, m_JavascriptCloseWindows, m_JavascriptAccessClipboard, m_JavascriptDomPaste, m_CaretBrowsing, m_Java, m_Plugins, m_UniversalAccessFromFileUrls, m_FileAccessFromFileUrls, m_WebSecUrity, m_ImageLoading, m_ImageShrinkStandaloneToFit, m_TextAreaResize, m_TabToLinks, m_LocalStorage, m_Databases, m_ApplicationCache, m_Webgl, CfxColor.Unwrap(m_BackgroundColor));
            m_StandardFontFamily_pinned.Obj.Free();
            m_FixedFontFamily_pinned.Obj.Free();
            m_SerifFontFamily_pinned.Obj.Free();
            m_SansSerifFontFamily_pinned.Obj.Free();
            m_CursiveFontFamily_pinned.Obj.Free();
            m_FantasyFontFamily_pinned.Obj.Free();
            m_DefaultEncoding_pinned.Obj.Free();
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            IntPtr standard_font_family_str = IntPtr.Zero; int standard_font_family_length = 0;
            IntPtr fixed_font_family_str = IntPtr.Zero; int fixed_font_family_length = 0;
            IntPtr serif_font_family_str = IntPtr.Zero; int serif_font_family_length = 0;
            IntPtr sans_serif_font_family_str = IntPtr.Zero; int sans_serif_font_family_length = 0;
            IntPtr cursive_font_family_str = IntPtr.Zero; int cursive_font_family_length = 0;
            IntPtr fantasy_font_family_str = IntPtr.Zero; int fantasy_font_family_length = 0;
            IntPtr default_encoding_str = IntPtr.Zero; int default_encoding_length = 0;
            uint background_color = default(uint);
            CfxApi.cfx_browser_settings_copy_to_managed(nativePtr, out m_WindowlessFrameRate, out standard_font_family_str, out standard_font_family_length, out fixed_font_family_str, out fixed_font_family_length, out serif_font_family_str, out serif_font_family_length, out sans_serif_font_family_str, out sans_serif_font_family_length, out cursive_font_family_str, out cursive_font_family_length, out fantasy_font_family_str, out fantasy_font_family_length, out m_DefaultFontSize, out m_DefaultFixedFontSize, out m_MinimumFontSize, out m_MinimumLogicalFontSize, out default_encoding_str, out default_encoding_length, out m_RemoteFonts, out m_Javascript, out m_JavascriptOpenWindows, out m_JavascriptCloseWindows, out m_JavascriptAccessClipboard, out m_JavascriptDomPaste, out m_CaretBrowsing, out m_Java, out m_Plugins, out m_UniversalAccessFromFileUrls, out m_FileAccessFromFileUrls, out m_WebSecUrity, out m_ImageLoading, out m_ImageShrinkStandaloneToFit, out m_TextAreaResize, out m_TabToLinks, out m_LocalStorage, out m_Databases, out m_ApplicationCache, out m_Webgl, out background_color);
            m_StandardFontFamily = standard_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(standard_font_family_str, standard_font_family_length) : String.Empty;;
            m_FixedFontFamily = fixed_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(fixed_font_family_str, fixed_font_family_length) : String.Empty;;
            m_SerifFontFamily = serif_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(serif_font_family_str, serif_font_family_length) : String.Empty;;
            m_SansSerifFontFamily = sans_serif_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(sans_serif_font_family_str, sans_serif_font_family_length) : String.Empty;;
            m_CursiveFontFamily = cursive_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(cursive_font_family_str, cursive_font_family_length) : String.Empty;;
            m_FantasyFontFamily = fantasy_font_family_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(fantasy_font_family_str, fantasy_font_family_length) : String.Empty;;
            m_DefaultEncoding = default_encoding_str != IntPtr.Zero ? System.Runtime.InteropServices.Marshal.PtrToStringUni(default_encoding_str, default_encoding_length) : String.Empty;;
            m_BackgroundColor = CfxColor.Wrap(background_color);
        }
    }
}
