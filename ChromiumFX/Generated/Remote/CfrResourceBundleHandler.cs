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
    using Event;

    /// <summary>
    /// Structure used to implement a custom resource bundle structure. The functions
    /// of this structure may be called on multiple threads.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
    /// </remarks>
    public class CfrResourceBundleHandler : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrResourceBundleHandler Wrap(IntPtr proxyId) {
            if(proxyId == IntPtr.Zero) return null;
            lock(weakCache) {
                var cfrObj = (CfrResourceBundleHandler)weakCache.Get(proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrResourceBundleHandler(proxyId);
                    weakCache.Add(proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static IntPtr CreateRemote() {
            var call = new CfxResourceBundleHandlerCtorRenderProcessCall();
            call.RequestExecution();
            return call.__retval;
        }

        internal void raise_GetLocalizedString(object sender, CfrGetLocalizedStringEventArgs e) {
            var handler = m_GetLocalizedString;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_GetDataResource(object sender, CfrGetDataResourceEventArgs e) {
            var handler = m_GetDataResource;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }


        private CfrResourceBundleHandler(IntPtr proxyId) : base(proxyId) {}
        [Obsolete("new CfrResourceBundleHandler(CfrRuntime) is deprecated, please use new CfrResourceBundleHandler() without CfrRuntime instead.")]
        public CfrResourceBundleHandler(CfrRuntime remoteRuntime) : base(CreateRemote()) {
            weakCache.Add(this.proxyId, this);
        }
        public CfrResourceBundleHandler() : base(CreateRemote()) {
            weakCache.Add(this.proxyId, this);
        }

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public event CfrGetLocalizedStringEventHandler GetLocalizedString {
            add {
                if(m_GetLocalizedString == null) {
                    var call = new CfxGetLocalizedStringActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.RequestExecution();
                }
                m_GetLocalizedString += value;
            }
            remove {
                m_GetLocalizedString -= value;
                if(m_GetLocalizedString == null) {
                    var call = new CfxGetLocalizedStringDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.RequestExecution();
                }
            }
        }

        CfrGetLocalizedStringEventHandler m_GetLocalizedString;


        /// <summary>
        /// Called to retrieve data for the resource specified by |ResourceId|. To
        /// provide the resource data set |Data| and |DataSize| to the data pointer
        /// and size respectively and return true (1). To use the default resource data
        /// return false (0). The resource data will not be copied and must remain
        /// resident in memory. Supported resource IDs are listed in
        /// cef_pack_resources.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public event CfrGetDataResourceEventHandler GetDataResource {
            add {
                if(m_GetDataResource == null) {
                    var call = new CfxGetDataResourceActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.RequestExecution();
                }
                m_GetDataResource += value;
            }
            remove {
                m_GetDataResource -= value;
                if(m_GetDataResource == null) {
                    var call = new CfxGetDataResourceDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.RequestExecution();
                }
            }
        }

        CfrGetDataResourceEventHandler m_GetDataResource;


        internal override void OnDispose(IntPtr proxyId) {
            weakCache.Remove(proxyId);
        }
    }

    namespace Event {

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrGetLocalizedStringEventHandler(object sender, CfrGetLocalizedStringEventArgs e);

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public class CfrGetLocalizedStringEventArgs : CfrEventArgs {

            bool MessageIdFetched;
            int m_MessageId;
            bool StringFetched;
            string m_String;

            private bool returnValueSet;

            internal CfrGetLocalizedStringEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the MessageId parameter for the <see cref="CfrResourceBundleHandler.GetLocalizedString"/> render process callback.
            /// </summary>
            public int MessageId {
                get {
                    CheckAccess();
                    if(!MessageIdFetched) {
                        MessageIdFetched = true;
                        var call = new CfxGetLocalizedStringGetMessageIdRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_MessageId = call.value;
                    }
                    return m_MessageId;
                }
            }
            /// <summary>
            /// Get or set the String parameter for the <see cref="CfrResourceBundleHandler.GetLocalizedString"/> render process callback.
            /// </summary>
            public string String {
                get {
                    CheckAccess();
                    if(!StringFetched) {
                        StringFetched = true;
                        var call = new CfxGetLocalizedStringGetStringRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_String = call.value;
                    }
                    return m_String;
                }
                set {
                    CheckAccess();
                    m_String = value;
                    StringFetched = true;
                    var call = new CfxGetLocalizedStringSetStringRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.RequestExecution();
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrResourceBundleHandler.GetLocalizedString"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxGetLocalizedStringSetReturnValueRenderProcessCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("MessageId={{{0}}}, String={{{1}}}", MessageId, String);
            }
        }

        /// <summary>
        /// Called to retrieve data for the resource specified by |ResourceId|. To
        /// provide the resource data set |Data| and |DataSize| to the data pointer
        /// and size respectively and return true (1). To use the default resource data
        /// return false (0). The resource data will not be copied and must remain
        /// resident in memory. Supported resource IDs are listed in
        /// cef_pack_resources.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrGetDataResourceEventHandler(object sender, CfrGetDataResourceEventArgs e);

        /// <summary>
        /// Called to retrieve data for the resource specified by |ResourceId|. To
        /// provide the resource data set |Data| and |DataSize| to the data pointer
        /// and size respectively and return true (1). To use the default resource data
        /// return false (0). The resource data will not be copied and must remain
        /// resident in memory. Supported resource IDs are listed in
        /// cef_pack_resources.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public class CfrGetDataResourceEventArgs : CfrEventArgs {

            bool ResourceIdFetched;
            int m_ResourceId;

            private bool returnValueSet;

            internal CfrGetDataResourceEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the ResourceId parameter for the <see cref="CfrResourceBundleHandler.GetDataResource"/> render process callback.
            /// </summary>
            public int ResourceId {
                get {
                    CheckAccess();
                    if(!ResourceIdFetched) {
                        ResourceIdFetched = true;
                        var call = new CfxGetDataResourceGetResourceIdRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_ResourceId = call.value;
                    }
                    return m_ResourceId;
                }
            }
            /// <summary>
            /// Set the Data out parameter for the <see cref="CfrResourceBundleHandler.GetDataResource"/> render process callback.
            /// </summary>
            public RemotePtr Data {
                set {
                    CheckAccess();
                    var call = new CfxGetDataResourceSetDataRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value.ptr;
                    call.RequestExecution();
                }
            }
            /// <summary>
            /// Set the DataSize out parameter for the <see cref="CfrResourceBundleHandler.GetDataResource"/> render process callback.
            /// </summary>
            public int DataSize {
                set {
                    CheckAccess();
                    var call = new CfxGetDataResourceSetDataSizeRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.RequestExecution();
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrResourceBundleHandler.GetDataResource"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxGetDataResourceSetReturnValueRenderProcessCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("ResourceId={{{0}}}", ResourceId);
            }
        }

    }
}
