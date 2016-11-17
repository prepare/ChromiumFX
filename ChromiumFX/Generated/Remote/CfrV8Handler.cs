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
    /// Structure that should be implemented to handle V8 function calls. The
    /// functions of this structure will be called on the thread associated with the
    /// V8 function.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public class CfrV8Handler : CfrClientBase {

        internal static CfrV8Handler Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrV8Handler)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrV8Handler(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        internal void raise_Execute(object sender, CfrV8HandlerExecuteEventArgs e) {
            var handler = m_Execute;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }


        private CfrV8Handler(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrV8Handler() : base(new CfxV8HandlerCtorRemoteCall()) {
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        /// <summary>
        /// Handle execution of the function identified by |Name|. |Object| is the
        /// receiver ('this' object) of the function. |Arguments| is the list of
        /// arguments passed to the function. If execution succeeds set |Retval| to the
        /// function return value. If execution fails set |Exception| to the exception
        /// that will be thrown. Return true (1) if execution was handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfrV8HandlerExecuteEventHandler Execute {
            add {
                if(m_Execute == null) {
                    var call = new CfxV8HandlerExecuteActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_Execute += value;
            }
            remove {
                m_Execute -= value;
                if(m_Execute == null) {
                    var call = new CfxV8HandlerExecuteDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrV8HandlerExecuteEventHandler m_Execute;


    }

    namespace Event {

        /// <summary>
        /// Handle execution of the function identified by |Name|. |Object| is the
        /// receiver ('this' object) of the function. |Arguments| is the list of
        /// arguments passed to the function. If execution succeeds set |Retval| to the
        /// function return value. If execution fails set |Exception| to the exception
        /// that will be thrown. Return true (1) if execution was handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfrV8HandlerExecuteEventHandler(object sender, CfrV8HandlerExecuteEventArgs e);

        /// <summary>
        /// Handle execution of the function identified by |Name|. |Object| is the
        /// receiver ('this' object) of the function. |Arguments| is the list of
        /// arguments passed to the function. If execution succeeds set |Retval| to the
        /// function return value. If execution fails set |Exception| to the exception
        /// that will be thrown. Return true (1) if execution was handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfrV8HandlerExecuteEventArgs : CfrEventArgs {

            bool NameFetched;
            string m_Name;
            bool ObjectFetched;
            CfrV8Value m_Object;
            bool ArgumentsFetched;
            CfrV8Value[] m_Arguments;

            private bool returnValueSet;

            internal CfrV8HandlerExecuteEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Name parameter for the <see cref="CfrV8Handler.Execute"/> render process callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    if(!NameFetched) {
                        NameFetched = true;
                        var call = new CfxV8HandlerExecuteGetNameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Name = call.value;
                    }
                    return m_Name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfrV8Handler.Execute"/> render process callback.
            /// </summary>
            public CfrV8Value Object {
                get {
                    CheckAccess();
                    if(!ObjectFetched) {
                        ObjectFetched = true;
                        var call = new CfxV8HandlerExecuteGetObjectRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Object = CfrV8Value.Wrap(new RemotePtr(call.value));
                    }
                    return m_Object;
                }
            }
            /// <summary>
            /// Get the Arguments parameter for the <see cref="CfrV8Handler.Execute"/> render process callback.
            /// </summary>
            public CfrV8Value[] Arguments {
                get {
                    CheckAccess();
                    if(!ArgumentsFetched) {
                        ArgumentsFetched = true;
                        var call = new CfxV8HandlerExecuteGetArgumentsRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Arguments = CfxArray.GetCfrObjects<CfrV8Value>(CfxRemoteCallContext.CurrentContext.connection, call.value, CfrV8Value.Wrap);
                    }
                    return m_Arguments;
                }
            }
            /// <summary>
            /// Set the Exception out parameter for the <see cref="CfrV8Handler.Execute"/> render process callback.
            /// </summary>
            public string Exception {
                set {
                    CheckAccess();
                    var call = new CfxV8HandlerExecuteSetExceptionRemoteCall();
                    call.eventArgsId = eventArgsId;
                    call.value = value;
                    call.RequestExecution();
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrV8Handler.Execute"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfrV8Value returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxV8HandlerExecuteSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = CfrObject.Unwrap(returnValue).ptr;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Arguments={{{2}}}", Name, Object, Arguments);
            }
        }

    }
}
