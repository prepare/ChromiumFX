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
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
    /// </remarks>
    public class CfrResourceBundleHandler : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrResourceBundleHandler Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrResourceBundleHandler)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrResourceBundleHandler(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxResourceBundleHandlerCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_GetLocalizedString(object sender, CfrGetLocalizedStringEventArgs e) {
            var handler = m_GetLocalizedString;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_GetDataResource(object sender, CfrGetDataResourceEventArgs e) {
            var handler = m_GetDataResource;
            if(handler == null) return;
            handler(this, e);
        }


        private CfrResourceBundleHandler(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrResourceBundleHandler(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Called to retrieve a localized translation for the string specified by
        /// |MessageId|. To provide the translation set |String| to the translation
        /// string and return true (1). To use the default translation return false
        /// (0). Supported message IDs are listed in cef_pack_strings.h.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public event CfrGetLocalizedStringEventHandler GetLocalizedString {
            add {
                if(m_GetLocalizedString == null) {
                    var call = new CfxGetLocalizedStringActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_GetLocalizedString += value;
            }
            remove {
                m_GetLocalizedString -= value;
                if(m_GetLocalizedString == null) {
                    var call = new CfxGetLocalizedStringDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public event CfrGetDataResourceEventHandler GetDataResource {
            add {
                if(m_GetDataResource == null) {
                    var call = new CfxGetDataResourceActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_GetDataResource += value;
            }
            remove {
                m_GetDataResource -= value;
                if(m_GetDataResource == null) {
                    var call = new CfxGetDataResourceDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrGetDataResourceEventHandler m_GetDataResource;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public class CfrGetLocalizedStringEventArgs : CfrEventArgs {

            bool MessageIdFetched;
            int m_MessageId;
            bool StringFetched;
            string m_String;

            internal CfrGetLocalizedStringEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public int MessageId {
                get {
                    if(!MessageIdFetched) {
                        MessageIdFetched = true;
                        var call = new CfxGetLocalizedStringGetMessageIdRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_MessageId = call.value;
                    }
                    return m_MessageId;
                }
            }
            public string String {
                get {
                    if(!StringFetched) {
                        StringFetched = true;
                        var call = new CfxGetLocalizedStringGetStringRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_String = call.value;
                    }
                    return m_String;
                }
                set {
                    m_String = value;
                    StringFetched = true;
                    var call = new CfxGetLocalizedStringSetStringRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.Execute(remoteRuntime.connection);
                }
            }
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                var call = new CfxGetLocalizedStringSetReturnValueRenderProcessCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.Execute(remoteRuntime.connection);
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
        /// </remarks>
        public class CfrGetDataResourceEventArgs : CfrEventArgs {

            bool ResourceIdFetched;
            int m_ResourceId;
            RemotePtr m_Data;
            int m_DataSize;

            internal CfrGetDataResourceEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

            public int ResourceId {
                get {
                    if(!ResourceIdFetched) {
                        ResourceIdFetched = true;
                        var call = new CfxGetDataResourceGetResourceIdRenderProcessCall();
                        call.eventArgsId = eventArgsId;
                        call.Execute(remoteRuntime.connection);
                        m_ResourceId = call.value;
                    }
                    return m_ResourceId;
                }
            }
            public RemotePtr Data {
                get {
                    return m_Data;
                }
                set {
                    m_Data = value;
                    var call = new CfxGetDataResourceSetDataRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value.ptr;
                    call.Execute(remoteRuntime.connection);
                }
            }
            public int DataSize {
                get {
                    return m_DataSize;
                }
                set {
                    m_DataSize = value;
                    var call = new CfxGetDataResourceSetDataSizeRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.Execute(remoteRuntime.connection);
                }
            }
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_resource_bundle_handler_capi.h">cef/include/capi/cef_resource_bundle_handler_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                var call = new CfxGetDataResourceSetReturnValueRenderProcessCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.Execute(remoteRuntime.connection);
            }

            public override string ToString() {
                return String.Format("ResourceId={{{0}}}", ResourceId);
            }
        }

    }
}
