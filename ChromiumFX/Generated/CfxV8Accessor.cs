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
    /// Structure that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CfxV8Value.SetValueByAccessor().
    /// The functions of this structure will be called on the thread associated with
    /// the V8 accessor.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public class CfxV8Accessor : CfxBase {

        internal static CfxV8Accessor Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_v8accessor_get_gc_handle(nativePtr);
            return (CfxV8Accessor)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void get(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Accessor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                retval = default(IntPtr);
                return;
            }
            var e = new CfxV8AccessorGetEventArgs(name_str, name_length, @object, exception_str, exception_length);
            var eventHandler = self.m_Get;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_object_wrapped == null) CfxApi.cfx_release(e.m_object);
            retval = CfxV8Value.Unwrap(e.m_retval_wrapped);
            if(e.m_exception_changed) {
                var exception_pinned = new PinnedString(e.m_exception_wrapped);
                exception_str = exception_pinned.Obj.PinnedPtr;
                exception_length = exception_pinned.Length;
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void set(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Accessor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxV8AccessorSetEventArgs(name_str, name_length, @object, value, exception_str, exception_length);
            var eventHandler = self.m_Set;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_object_wrapped == null) CfxApi.cfx_release(e.m_object);
            if(e.m_value_wrapped == null) CfxApi.cfx_release(e.m_value);
            if(e.m_exception_changed) {
                var exception_pinned = new PinnedString(e.m_exception_wrapped);
                exception_str = exception_pinned.Obj.PinnedPtr;
                exception_length = exception_pinned.Length;
            }
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxV8Accessor(IntPtr nativePtr) : base(nativePtr) {}
        public CfxV8Accessor() : base(CfxApi.cfx_v8accessor_ctor) {}

        /// <summary>
        /// Handle retrieval the accessor value identified by |Name|. |Object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |Retval| to the return value. If retrieval fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor retrieval was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxV8AccessorGetEventHandler Get {
            add {
                if(m_Get == null) {
                    CfxApi.cfx_v8accessor_activate_callback(NativePtr, 0, 1);
                }
                m_Get += value;
            }
            remove {
                m_Get -= value;
                if(m_Get == null) {
                    CfxApi.cfx_v8accessor_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxV8AccessorGetEventHandler m_Get;

        /// <summary>
        /// Handle assignment of the accessor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the accessor. |Value| is the new value
        /// being assigned to the accessor. If assignment fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor assignment was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxV8AccessorSetEventHandler Set {
            add {
                if(m_Set == null) {
                    CfxApi.cfx_v8accessor_activate_callback(NativePtr, 1, 1);
                }
                m_Set += value;
            }
            remove {
                m_Set -= value;
                if(m_Set == null) {
                    CfxApi.cfx_v8accessor_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxV8AccessorSetEventHandler m_Set;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Get != null) {
                m_Get = null;
                CfxApi.cfx_v8accessor_activate_callback(NativePtr, 0, 0);
            }
            if(m_Set != null) {
                m_Set = null;
                CfxApi.cfx_v8accessor_activate_callback(NativePtr, 1, 0);
            }
            base.OnDispose(nativePtr);
        }
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxV8AccessorGetEventHandler(object sender, CfxV8AccessorGetEventArgs e);

        /// <summary>
        /// Handle retrieval the accessor value identified by |Name|. |Object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |Retval| to the return value. If retrieval fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor retrieval was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxV8AccessorGetEventArgs : CfxEventArgs {

            internal IntPtr m_name_str;
            internal int m_name_length;
            internal string m_name;
            internal IntPtr m_object;
            internal CfxV8Value m_object_wrapped;
            internal CfxV8Value m_retval_wrapped;
            internal IntPtr m_exception_str;
            internal int m_exception_length;
            internal string m_exception_wrapped;
            internal bool m_exception_changed;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxV8AccessorGetEventArgs(IntPtr name_str, int name_length, IntPtr @object, IntPtr exception_str, int exception_length) {
                m_name_str = name_str;
                m_name_length = name_length;
                m_object = @object;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            public string Name {
                get {
                    CheckAccess();
                    if(m_name == null && m_name_str != IntPtr.Zero) m_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_name_str, m_name_length);
                    return m_name;
                }
            }
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            public CfxV8Value Retval {
                set {
                    CheckAccess();
                    m_retval_wrapped = value;
                }
            }
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null && m_exception_str != IntPtr.Zero) {
                        m_exception_wrapped = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_exception_str, m_exception_length);
                    }
                    return m_exception_wrapped;
                }
                set {
                    CheckAccess();
                    m_exception_wrapped = value;
                    m_exception_changed = true;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Exception={{{3}}}", Name, Object, Exception);
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
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxV8AccessorSetEventHandler(object sender, CfxV8AccessorSetEventArgs e);

        /// <summary>
        /// Handle assignment of the accessor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the accessor. |Value| is the new value
        /// being assigned to the accessor. If assignment fails set |Exception| to the
        /// exception that will be thrown. Return true (1) if accessor assignment was
        /// handled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxV8AccessorSetEventArgs : CfxEventArgs {

            internal IntPtr m_name_str;
            internal int m_name_length;
            internal string m_name;
            internal IntPtr m_object;
            internal CfxV8Value m_object_wrapped;
            internal IntPtr m_value;
            internal CfxV8Value m_value_wrapped;
            internal IntPtr m_exception_str;
            internal int m_exception_length;
            internal string m_exception_wrapped;
            internal bool m_exception_changed;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxV8AccessorSetEventArgs(IntPtr name_str, int name_length, IntPtr @object, IntPtr value, IntPtr exception_str, int exception_length) {
                m_name_str = name_str;
                m_name_length = name_length;
                m_object = @object;
                m_value = value;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            public string Name {
                get {
                    CheckAccess();
                    if(m_name == null && m_name_str != IntPtr.Zero) m_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_name_str, m_name_length);
                    return m_name;
                }
            }
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            public CfxV8Value Value {
                get {
                    CheckAccess();
                    if(m_value_wrapped == null) m_value_wrapped = CfxV8Value.Wrap(m_value);
                    return m_value_wrapped;
                }
            }
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null && m_exception_str != IntPtr.Zero) {
                        m_exception_wrapped = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_exception_str, m_exception_length);
                    }
                    return m_exception_wrapped;
                }
                set {
                    CheckAccess();
                    m_exception_wrapped = value;
                    m_exception_changed = true;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Value={{{2}}}, Exception={{{3}}}", Name, Object, Value, Exception);
            }
        }

    }
}
