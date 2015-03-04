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
    using Event;

    /// <summary>
    /// Structure used to implement a custom resource bundle structure. The functions
    /// of this structure may be called on multiple threads.
    /// </summary>
    public class CfxResourceBundleHandler : CfxBase {

        internal static CfxResourceBundleHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_resource_bundle_handler_get_gc_handle(nativePtr);
            return (CfxResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void get_localized_string(IntPtr gcHandlePtr, out int __retval, int message_id, ref IntPtr string_str, ref int string_length) {
            var self = (CfxResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxGetLocalizedStringEventArgs(message_id, string_str, string_length);
            var eventHandler = self.m_GetLocalizedString;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_string_changed) {
                var string_pinned = new PinnedString(e.m_string_wrapped);
                string_str = string_pinned.Obj.PinnedPtr;
                string_length = string_pinned.Length;
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void get_data_resource(IntPtr gcHandlePtr, out int __retval, int resource_id, out IntPtr data, out int data_size) {
            var self = (CfxResourceBundleHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                data = default(IntPtr);
                data_size = default(int);
                return;
            }
            var e = new CfxGetDataResourceEventArgs(resource_id);
            var eventHandler = self.m_GetDataResource;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            data = e.m_data;
            data_size = e.m_data_size;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxResourceBundleHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxResourceBundleHandler() : base(CfxApi.cfx_resource_bundle_handler_ctor) {}

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        public event CfxGetLocalizedStringEventHandler GetLocalizedString {
            add {
                if(m_GetLocalizedString == null) {
                    CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 0, 1);
                }
                m_GetLocalizedString += value;
            }
            remove {
                m_GetLocalizedString -= value;
                if(m_GetLocalizedString == null) {
                    CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxGetLocalizedStringEventHandler m_GetLocalizedString;

        /// <summary>
        /// Called to retrieve data for the resource specified by |ResourceId|. To
        /// provide the resource data set |Data| and |DataSize| to the data pointer
        /// and size respectively and return true (1). To use the default resource data
        /// return false (0). The resource data will not be copied and must remain
        /// resident in memory. Supported resource IDs are listed in
        /// cef_pack_resources.h.
        /// </summary>
        public event CfxGetDataResourceEventHandler GetDataResource {
            add {
                if(m_GetDataResource == null) {
                    CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 1, 1);
                }
                m_GetDataResource += value;
            }
            remove {
                m_GetDataResource -= value;
                if(m_GetDataResource == null) {
                    CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxGetDataResourceEventHandler m_GetDataResource;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_GetLocalizedString != null) {
                m_GetLocalizedString = null;
                CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_GetDataResource != null) {
                m_GetDataResource = null;
                CfxApi.cfx_resource_bundle_handler_activate_callback(NativePtr, 1, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxGetLocalizedStringEventHandler(object sender, CfxGetLocalizedStringEventArgs e);

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        public class CfxGetLocalizedStringEventArgs : CfxEventArgs {

            internal int m_message_id;
            internal IntPtr m_string_str;
            internal int m_string_length;
            internal string m_string_wrapped;
            internal bool m_string_changed;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetLocalizedStringEventArgs(int message_id, IntPtr string_str, int string_length) {
                m_message_id = message_id;
                m_string_str = string_str;
                m_string_length = string_length;
            }

            public int MessageId {
                get {
                    CheckAccess();
                    return m_message_id;
                }
            }
            public string String {
                get {
                    CheckAccess();
                    if(!m_string_changed && m_string_wrapped == null && m_string_str != IntPtr.Zero) {
                        m_string_wrapped = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_string_str, m_string_length);
                    }
                    return m_string_wrapped;
                }
                set {
                    CheckAccess();
                    m_string_wrapped = value;
                    m_string_changed = true;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("MessageId={{{0}}}, String={{{1}}}", MessageId, String);
            }
        }

        public delegate void CfxGetDataResourceEventHandler(object sender, CfxGetDataResourceEventArgs e);

        /// <summary>
        /// Called to retrieve data for the resource specified by |ResourceId|. To
        /// provide the resource data set |Data| and |DataSize| to the data pointer
        /// and size respectively and return true (1). To use the default resource data
        /// return false (0). The resource data will not be copied and must remain
        /// resident in memory. Supported resource IDs are listed in
        /// cef_pack_resources.h.
        /// </summary>
        public class CfxGetDataResourceEventArgs : CfxEventArgs {

            internal int m_resource_id;
            internal IntPtr m_data;
            internal int m_data_size;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetDataResourceEventArgs(int resource_id) {
                m_resource_id = resource_id;
            }

            public int ResourceId {
                get {
                    CheckAccess();
                    return m_resource_id;
                }
            }
            public IntPtr Data {
                set {
                    CheckAccess();
                    m_data = value;
                }
            }
            public int DataSize {
                set {
                    CheckAccess();
                    m_data_size = value;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("ResourceId={{{0}}}", ResourceId);
            }
        }

    }
}
