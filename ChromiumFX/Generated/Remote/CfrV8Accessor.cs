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


        internal void raise_Get(object sender, CfrV8AccessorGetEventArgs e) {
            var handler = m_Get;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_Set(object sender, CfrV8AccessorSetEventArgs e) {
            var handler = m_Set;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }


        private CfrV8Accessor(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrV8Accessor() : base(new CfxV8AccessorCtorRemoteCall()) {
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
                    var call = new CfxV8AccessorGetActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Get += value;
            }
            remove {
                m_Get -= value;
                if(m_Get == null) {
                    var call = new CfxV8AccessorGetDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrV8AccessorGetEventHandler m_Get;


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
                    var call = new CfxV8AccessorSetActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Set += value;
            }
            remove {
                m_Set -= value;
                if(m_Set == null) {
                    var call = new CfxV8AccessorSetDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrV8AccessorSetEventHandler m_Set;


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

            bool NameFetched;
            string m_Name;
            bool ObjectFetched;
            CfrV8Value m_Object;

            private bool returnValueSet;

            internal CfrV8AccessorGetEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Name parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    if(!NameFetched) {
                        NameFetched = true;
                        var call = new CfxV8AccessorGetGetNameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Name = call.value;
                    }
                    return m_Name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public CfrV8Value Object {
                get {
                    CheckAccess();
                    if(!ObjectFetched) {
                        ObjectFetched = true;
                        var call = new CfxV8AccessorGetGetObjectRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Object = CfrV8Value.Wrap(new RemotePtr(call.value));
                    }
                    return m_Object;
                }
            }
            /// <summary>
            /// Set the Retval out parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public CfrV8Value Retval {
                set {
                    CheckAccess();
                    var call = new CfxV8AccessorGetSetRetvalRemoteCall();
                    call.eventArgsId = eventArgsId;
                    call.value = CfrV8Value.Unwrap(value).ptr;
                    call.RequestExecution();
                }
            }
            /// <summary>
            /// Set the Exception out parameter for the <see cref="CfrV8Accessor.Get"/> render process callback.
            /// </summary>
            public string Exception {
                set {
                    CheckAccess();
                    var call = new CfxV8AccessorGetSetExceptionRemoteCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.RequestExecution();
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
                var call = new CfxV8AccessorGetSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
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

            bool NameFetched;
            string m_Name;
            bool ObjectFetched;
            CfrV8Value m_Object;
            bool ValueFetched;
            CfrV8Value m_Value;

            private bool returnValueSet;

            internal CfrV8AccessorSetEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Name parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    if(!NameFetched) {
                        NameFetched = true;
                        var call = new CfxV8AccessorSetGetNameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Name = call.value;
                    }
                    return m_Name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public CfrV8Value Object {
                get {
                    CheckAccess();
                    if(!ObjectFetched) {
                        ObjectFetched = true;
                        var call = new CfxV8AccessorSetGetObjectRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Object = CfrV8Value.Wrap(new RemotePtr(call.value));
                    }
                    return m_Object;
                }
            }
            /// <summary>
            /// Get the Value parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public CfrV8Value Value {
                get {
                    CheckAccess();
                    if(!ValueFetched) {
                        ValueFetched = true;
                        var call = new CfxV8AccessorSetGetValueRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Value = CfrV8Value.Wrap(new RemotePtr(call.value));
                    }
                    return m_Value;
                }
            }
            /// <summary>
            /// Set the Exception out parameter for the <see cref="CfrV8Accessor.Set"/> render process callback.
            /// </summary>
            public string Exception {
                set {
                    CheckAccess();
                    var call = new CfxV8AccessorSetSetExceptionRemoteCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.RequestExecution();
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
                var call = new CfxV8AccessorSetSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Value={{{2}}}", Name, Object, Value);
            }
        }

    }
}
