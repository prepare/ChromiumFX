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
    /// Structure that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CfrV8Value.SetValue(). The
    /// functions of this structure will be called on the thread associated with the
    /// V8 accessor.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public class CfrV8Accessor : CfrClientBase {

        internal static CfrV8Accessor Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrV8Accessor)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrV8Accessor(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrV8Accessor(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrV8Accessor() : base(new CfxV8AccessorCtorWithGCHandleRemoteCall()) {
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        /// <summary>
        /// Handle retrieval the accessor value identified by |Name|. |Object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |Retval| to the return value. If retrieval fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor retrieval was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfrV8AccessorGetEventHandler Get {
            add {
                if(m_Get == null) {
                    var call = new CfxV8AccessorSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 0;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Get += value;
            }
            remove {
                m_Get -= value;
                if(m_Get == null) {
                    var call = new CfxV8AccessorSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 0;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrV8AccessorGetEventHandler m_Get;


        /// <summary>
        /// Handle assignment of the accessor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the accessor. |Value| is the new value
        /// being assigned to the accessor. If assignment fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor assignment was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfrV8AccessorSetEventHandler Set {
            add {
                if(m_Set == null) {
                    var call = new CfxV8AccessorSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 1;
                    call.active = true;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Set += value;
            }
            remove {
                m_Set -= value;
                if(m_Set == null) {
                    var call = new CfxV8AccessorSetCallbackRemoteCall();
                    call.self = RemotePtr.ptr;
                    call.index = 1;
                    call.active = false;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        internal CfrV8AccessorSetEventHandler m_Set;


    }

    namespace Event {

        /// <summary>
        /// Handle retrieval the accessor value identified by |Name|. |Object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |Retval| to the return value. If retrieval fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor retrieval was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfrV8AccessorGetEventHandler(object sender, CfrV8AccessorGetEventArgs e);

        /// <summary>
        /// Handle retrieval the accessor value identified by |Name|. |Object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |Retval| to the return value. If retrieval fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor retrieval was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfrV8AccessorGetEventArgs : CfrEventArgs {

            private CfxV8AccessorGetRemoteEventCall call;

            internal string m_name;
            internal bool m_name_fetched;
            internal CfrV8Value m_object_wrapped;
            internal CfrV8Value m_retval_wrapped;
            internal string m_exception_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfrV8AccessorGetEventArgs(CfxV8AccessorGetRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Get the Name parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    if(!m_name_fetched) {
                        m_name = call.name_str == IntPtr.Zero ? null : (call.name_length == 0 ? String.Empty : CfrRuntime.Marshal.PtrToStringUni(new RemotePtr(call.name_str), call.name_length));
                        m_name_fetched = true;
                    }
                    return m_name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public CfrV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfrV8Value.Wrap(new RemotePtr(call.@object));
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Set the Retval out parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public CfrV8Value Retval {
                set {
                    CheckAccess();
                    m_retval_wrapped = value;
                }
            }
            /// <summary>
            /// Set the Exception out parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public string Exception {
                set {
                    CheckAccess();
                    m_exception_wrapped = value;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}", Name, Object);
            }
        }

        /// <summary>
        /// Handle assignment of the accessor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the accessor. |Value| is the new value
        /// being assigned to the accessor. If assignment fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor assignment was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfrV8AccessorSetEventHandler(object sender, CfrV8AccessorSetEventArgs e);

        /// <summary>
        /// Handle assignment of the accessor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the accessor. |Value| is the new value
        /// being assigned to the accessor. If assignment fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor assignment was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfrV8AccessorSetEventArgs : CfrEventArgs {

            private CfxV8AccessorSetRemoteEventCall call;

            internal string m_name;
            internal bool m_name_fetched;
            internal CfrV8Value m_object_wrapped;
            internal CfrV8Value m_value_wrapped;
            internal string m_exception_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfrV8AccessorSetEventArgs(CfxV8AccessorSetRemoteEventCall call) { this.call = call; }

            /// <summary>
            /// Get the Name parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    if(!m_name_fetched) {
                        m_name = call.name_str == IntPtr.Zero ? null : (call.name_length == 0 ? String.Empty : CfrRuntime.Marshal.PtrToStringUni(new RemotePtr(call.name_str), call.name_length));
                        m_name_fetched = true;
                    }
                    return m_name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public CfrV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfrV8Value.Wrap(new RemotePtr(call.@object));
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Get the Value parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public CfrV8Value Value {
                get {
                    CheckAccess();
                    if(m_value_wrapped == null) m_value_wrapped = CfrV8Value.Wrap(new RemotePtr(call.value));
                    return m_value_wrapped;
                }
            }
            /// <summary>
            /// Set the Exception out parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public string Exception {
                set {
                    CheckAccess();
                    m_exception_wrapped = value;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                m_returnValue = returnValue;
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Value={{{2}}}", Name, Object, Value);
            }
        }

    }
}
