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
    /// Implement this structure to receive notification when CDM registration is
    /// complete. The functions of this structure will be called on the browser
    /// process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
    /// </remarks>
    public class CfxRegisterCdmCallback : CfxClientBase {

        internal static CfxRegisterCdmCallback Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.RegisterCdmCallback.cfx_register_cdm_callback_get_gc_handle(nativePtr);
            return (CfxRegisterCdmCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            on_cdm_registration_complete_native = on_cdm_registration_complete;
            var setCallbacks = (CfxApi.cfx_set_ptr_1_delegate)CfxApi.GetDelegate(CfxApiLoader.FunctionIndex.cfx_register_cdm_callback_set_managed_callbacks, typeof(CfxApi.cfx_set_ptr_1_delegate));
            setCallbacks(
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_cdm_registration_complete_native)
            );
        }

        // on_cdm_registration_complete
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_cdm_registration_complete_delegate(IntPtr gcHandlePtr, int result, IntPtr error_message_str, int error_message_length);
        private static on_cdm_registration_complete_delegate on_cdm_registration_complete_native;

        internal static void on_cdm_registration_complete(IntPtr gcHandlePtr, int result, IntPtr error_message_str, int error_message_length) {
            var self = (CfxRegisterCdmCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventArgs(result, error_message_str, error_message_length);
            var eventHandler = self.m_OnCdmRegistrationComplete;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
        }

        internal CfxRegisterCdmCallback(IntPtr nativePtr) : base(nativePtr) {}
        public CfxRegisterCdmCallback() : base(CfxApi.RegisterCdmCallback.cfx_register_cdm_callback_ctor) {}

        /// <summary>
        /// Method that will be called when CDM registration is complete. |Result| will
        /// be CEF_CDM_REGISTRATION_ERROR_NONE if registration completed successfully.
        /// Otherwise, |Result| and |ErrorMessage| will contain additional information
        /// about why registration failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public event CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventHandler OnCdmRegistrationComplete {
            add {
                lock(eventLock) {
                    if(m_OnCdmRegistrationComplete == null) {
                        CfxApi.RegisterCdmCallback.cfx_register_cdm_callback_activate_callback(NativePtr, 0, 1);
                    }
                    m_OnCdmRegistrationComplete += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnCdmRegistrationComplete -= value;
                    if(m_OnCdmRegistrationComplete == null) {
                        CfxApi.RegisterCdmCallback.cfx_register_cdm_callback_activate_callback(NativePtr, 0, 0);
                    }
                }
            }
        }

        private CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventHandler m_OnCdmRegistrationComplete;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnCdmRegistrationComplete != null) {
                m_OnCdmRegistrationComplete = null;
                CfxApi.RegisterCdmCallback.cfx_register_cdm_callback_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Method that will be called when CDM registration is complete. |Result| will
        /// be CEF_CDM_REGISTRATION_ERROR_NONE if registration completed successfully.
        /// Otherwise, |Result| and |ErrorMessage| will contain additional information
        /// about why registration failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public delegate void CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventHandler(object sender, CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventArgs e);

        /// <summary>
        /// Method that will be called when CDM registration is complete. |Result| will
        /// be CEF_CDM_REGISTRATION_ERROR_NONE if registration completed successfully.
        /// Otherwise, |Result| and |ErrorMessage| will contain additional information
        /// about why registration failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public class CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventArgs : CfxEventArgs {

            internal int m_result;
            internal IntPtr m_error_message_str;
            internal int m_error_message_length;
            internal string m_error_message;

            internal CfxRegisterCdmCallbackOnCdmRegistrationCompleteEventArgs(int result, IntPtr error_message_str, int error_message_length) {
                m_result = result;
                m_error_message_str = error_message_str;
                m_error_message_length = error_message_length;
            }

            /// <summary>
            /// Get the Result parameter for the <see cref="CfxRegisterCdmCallback.OnCdmRegistrationComplete"/> callback.
            /// </summary>
            public CfxCdmRegistrationError Result {
                get {
                    CheckAccess();
                    return (CfxCdmRegistrationError)m_result;
                }
            }
            /// <summary>
            /// Get the ErrorMessage parameter for the <see cref="CfxRegisterCdmCallback.OnCdmRegistrationComplete"/> callback.
            /// </summary>
            public string ErrorMessage {
                get {
                    CheckAccess();
                    m_error_message = StringFunctions.PtrToStringUni(m_error_message_str, m_error_message_length);
                    return m_error_message;
                }
            }

            public override string ToString() {
                return String.Format("Result={{{0}}}, ErrorMessage={{{1}}}", Result, ErrorMessage);
            }
        }

    }
}
