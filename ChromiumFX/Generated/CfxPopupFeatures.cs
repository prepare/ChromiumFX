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
    /// Popup window features.
    /// </summary>
    public sealed class CfxPopupFeatures : CfxStructure {

        internal static CfxPopupFeatures Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxPopupFeatures(nativePtr);
        }

        internal static CfxPopupFeatures WrapOwned(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxPopupFeatures(nativePtr, true);
        }

        private int m_X;
        private int m_XSet;
        private int m_Y;
        private int m_YSet;
        private int m_Width;
        private int m_WidthSet;
        private int m_Height;
        private int m_HeightSet;
        private int m_MenuBarVisible;
        private int m_StatusBarVisible;
        private int m_ToolBarVisible;
        private int m_LocationBarVisible;
        private int m_ScrollbarsVisible;
        private int m_Resizable;
        private int m_Fullscreen;
        private int m_Dialog;
        private System.Collections.Generic.List<string> m_AdditionalFeatures;

        public CfxPopupFeatures() : base(CfxApi.cfx_popup_features_ctor, CfxApi.cfx_popup_features_dtor) {}
        internal CfxPopupFeatures(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_popup_features_ctor, CfxApi.cfx_popup_features_dtor) {}
        internal CfxPopupFeatures(IntPtr nativePtr, bool owned) : base(nativePtr, CfxApi.cfx_popup_features_ctor, CfxApi.cfx_popup_features_dtor, owned) {}

        public int X {
            get {
                return m_X;
            }
            set {
                m_X = value;
            }
        }

        public int XSet {
            get {
                return m_XSet;
            }
            set {
                m_XSet = value;
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

        public int YSet {
            get {
                return m_YSet;
            }
            set {
                m_YSet = value;
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

        public int WidthSet {
            get {
                return m_WidthSet;
            }
            set {
                m_WidthSet = value;
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

        public int HeightSet {
            get {
                return m_HeightSet;
            }
            set {
                m_HeightSet = value;
            }
        }

        public int MenuBarVisible {
            get {
                return m_MenuBarVisible;
            }
            set {
                m_MenuBarVisible = value;
            }
        }

        public int StatusBarVisible {
            get {
                return m_StatusBarVisible;
            }
            set {
                m_StatusBarVisible = value;
            }
        }

        public int ToolBarVisible {
            get {
                return m_ToolBarVisible;
            }
            set {
                m_ToolBarVisible = value;
            }
        }

        public int LocationBarVisible {
            get {
                return m_LocationBarVisible;
            }
            set {
                m_LocationBarVisible = value;
            }
        }

        public int ScrollbarsVisible {
            get {
                return m_ScrollbarsVisible;
            }
            set {
                m_ScrollbarsVisible = value;
            }
        }

        public int Resizable {
            get {
                return m_Resizable;
            }
            set {
                m_Resizable = value;
            }
        }

        public int Fullscreen {
            get {
                return m_Fullscreen;
            }
            set {
                m_Fullscreen = value;
            }
        }

        public int Dialog {
            get {
                return m_Dialog;
            }
            set {
                m_Dialog = value;
            }
        }

        public System.Collections.Generic.List<string> AdditionalFeatures {
            get {
                return m_AdditionalFeatures;
            }
            set {
                m_AdditionalFeatures = value;
            }
        }

        protected override void CopyToNative() {
            PinnedString[] m_AdditionalFeatures_handles;
            var m_AdditionalFeatures_unwrapped = CfxStringCollections.UnwrapCfxStringList(m_AdditionalFeatures, out m_AdditionalFeatures_handles);
            CfxApi.cfx_popup_features_copy_to_native(nativePtrUnchecked, m_X, m_XSet, m_Y, m_YSet, m_Width, m_WidthSet, m_Height, m_HeightSet, m_MenuBarVisible, m_StatusBarVisible, m_ToolBarVisible, m_LocationBarVisible, m_ScrollbarsVisible, m_Resizable, m_Fullscreen, m_Dialog, m_AdditionalFeatures_unwrapped);
            CfxStringCollections.FreePinnedStrings(m_AdditionalFeatures_handles);
            CfxStringCollections.CfxStringListCopyToManaged(m_AdditionalFeatures_unwrapped, m_AdditionalFeatures);
            CfxApi.cfx_string_list_free(m_AdditionalFeatures_unwrapped);
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            IntPtr additionalFeatures = default(IntPtr);
            CfxApi.cfx_popup_features_copy_to_managed(nativePtr, out m_X, out m_XSet, out m_Y, out m_YSet, out m_Width, out m_WidthSet, out m_Height, out m_HeightSet, out m_MenuBarVisible, out m_StatusBarVisible, out m_ToolBarVisible, out m_LocationBarVisible, out m_ScrollbarsVisible, out m_Resizable, out m_Fullscreen, out m_Dialog, out additionalFeatures);
            m_AdditionalFeatures = CfxStringCollections.WrapCfxStringList(additionalFeatures);
        }
    }
}
