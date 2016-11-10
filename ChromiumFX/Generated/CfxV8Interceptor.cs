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
    /// Structure that should be implemented to handle V8 interceptor calls. The
    /// functions of this structure will be called on the thread associated with the
    /// V8 interceptor. Interceptor's named property handlers (with first argument of
    /// type CfxString) are called when object is indexed by string. Indexed property
    /// handlers (with first argument of type int) are called when object is indexed
    /// by integer.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public class CfxV8Interceptor : CfxClientBase {

        internal static CfxV8Interceptor Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.V8Interceptor.cfx_v8interceptor_get_gc_handle(nativePtr);
            return (CfxV8Interceptor)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            get_byname_native = get_byname;
            get_byindex_native = get_byindex;
            set_byname_native = set_byname;
            set_byindex_native = set_byindex;
            var setCallbacks = (CfxApi.cfx_set_ptr_4_delegate)CfxApi.GetDelegate(CfxApiLoader.FunctionIndex.cfx_v8interceptor_set_managed_callbacks, typeof(CfxApi.cfx_set_ptr_4_delegate));
            setCallbacks(
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_byname_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(get_byindex_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(set_byname_native),
                System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(set_byindex_native)
            );
        }

        // get_byname
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_byname_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length);
        private static get_byname_delegate get_byname_native;

        internal static void get_byname(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Interceptor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(int);
                retval = default(IntPtr);
                return;
            }
            var e = new CfxGetByNameEventArgs(name_str, name_length, @object, exception_str, exception_length);
            var eventHandler = self.m_GetByName;
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

        // get_byindex
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void get_byindex_delegate(IntPtr gcHandlePtr, out int __retval, int index, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length);
        private static get_byindex_delegate get_byindex_native;

        internal static void get_byindex(IntPtr gcHandlePtr, out int __retval, int index, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Interceptor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(int);
                retval = default(IntPtr);
                return;
            }
            var e = new CfxGetByIndexEventArgs(index, @object, exception_str, exception_length);
            var eventHandler = self.m_GetByIndex;
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

        // set_byname
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void set_byname_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length);
        private static set_byname_delegate set_byname_native;

        internal static void set_byname(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Interceptor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(int);
                return;
            }
            var e = new CfxSetByNameEventArgs(name_str, name_length, @object, value, exception_str, exception_length);
            var eventHandler = self.m_SetByName;
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

        // set_byindex
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void set_byindex_delegate(IntPtr gcHandlePtr, out int __retval, int index, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length);
        private static set_byindex_delegate set_byindex_native;

        internal static void set_byindex(IntPtr gcHandlePtr, out int __retval, int index, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length) {
            var self = (CfxV8Interceptor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                __retval = default(int);
                return;
            }
            var e = new CfxSetByIndexEventArgs(index, @object, value, exception_str, exception_length);
            var eventHandler = self.m_SetByIndex;
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

        internal CfxV8Interceptor(IntPtr nativePtr) : base(nativePtr) {}
        public CfxV8Interceptor() : base(CfxApi.V8Interceptor.cfx_v8interceptor_ctor) {}

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
        /// |Retval| to the return value. If the requested value does not exist, don't
        /// set either |Retval| or |Exception|. If retrieval fails, set |Exception| to
        /// the exception that will be thrown. If the property has an associated
        /// accessor, it will be called only if you don't set |Retval|. Return true (1)
        /// if interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxGetByNameEventHandler GetByName {
            add {
                lock(eventLock) {
                    if(m_GetByName == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 0, 1);
                    }
                    m_GetByName += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetByName -= value;
                    if(m_GetByName == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 0, 0);
                    }
                }
            }
        }

        private CfxGetByNameEventHandler m_GetByName;

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
        /// set |Retval| to the return value. If the requested value does not exist,
        /// don't set either |Retval| or |Exception|. If retrieval fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxGetByIndexEventHandler GetByIndex {
            add {
                lock(eventLock) {
                    if(m_GetByIndex == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 1, 1);
                    }
                    m_GetByIndex += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_GetByIndex -= value;
                    if(m_GetByIndex == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 1, 0);
                    }
                }
            }
        }

        private CfxGetByIndexEventHandler m_GetByIndex;

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Name|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. This setter will always
        /// be called, even when the property has an associated accessor. Return true
        /// (1) if interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxSetByNameEventHandler SetByName {
            add {
                lock(eventLock) {
                    if(m_SetByName == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 2, 1);
                    }
                    m_SetByName += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_SetByName -= value;
                    if(m_SetByName == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 2, 0);
                    }
                }
            }
        }

        private CfxSetByNameEventHandler m_SetByName;

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public event CfxSetByIndexEventHandler SetByIndex {
            add {
                lock(eventLock) {
                    if(m_SetByIndex == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 3, 1);
                    }
                    m_SetByIndex += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_SetByIndex -= value;
                    if(m_SetByIndex == null) {
                        CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 3, 0);
                    }
                }
            }
        }

        private CfxSetByIndexEventHandler m_SetByIndex;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_GetByName != null) {
                m_GetByName = null;
                CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 0, 0);
            }
            if(m_GetByIndex != null) {
                m_GetByIndex = null;
                CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 1, 0);
            }
            if(m_SetByName != null) {
                m_SetByName = null;
                CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 2, 0);
            }
            if(m_SetByIndex != null) {
                m_SetByIndex = null;
                CfxApi.V8Interceptor.cfx_v8interceptor_activate_callback(NativePtr, 3, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
        /// |Retval| to the return value. If the requested value does not exist, don't
        /// set either |Retval| or |Exception|. If retrieval fails, set |Exception| to
        /// the exception that will be thrown. If the property has an associated
        /// accessor, it will be called only if you don't set |Retval|. Return true (1)
        /// if interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetByNameEventHandler(object sender, CfxGetByNameEventArgs e);

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Name|. |Object| is
        /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
        /// |Retval| to the return value. If the requested value does not exist, don't
        /// set either |Retval| or |Exception|. If retrieval fails, set |Exception| to
        /// the exception that will be thrown. If the property has an associated
        /// accessor, it will be called only if you don't set |Retval|. Return true (1)
        /// if interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxGetByNameEventArgs : CfxEventArgs {

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

            internal CfxGetByNameEventArgs(IntPtr name_str, int name_length, IntPtr @object, IntPtr exception_str, int exception_length) {
                m_name_str = name_str;
                m_name_length = name_length;
                m_object = @object;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            /// <summary>
            /// Get the Name parameter for the <see cref="CfxV8Interceptor.GetByName"/> callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    m_name = StringFunctions.PtrToStringUni(m_name_str, m_name_length);
                    return m_name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfxV8Interceptor.GetByName"/> callback.
            /// </summary>
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Set the Retval out parameter for the <see cref="CfxV8Interceptor.GetByName"/> callback.
            /// </summary>
            public CfxV8Value Retval {
                set {
                    CheckAccess();
                    m_retval_wrapped = value;
                }
            }
            /// <summary>
            /// Get or set the Exception parameter for the <see cref="CfxV8Interceptor.GetByName"/> callback.
            /// </summary>
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null) {
                        m_exception_wrapped = StringFunctions.PtrToStringUni(m_exception_str, m_exception_length);
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
            /// Set the return value for the <see cref="CfxV8Interceptor.GetByName"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Name={{{0}}}, Object={{{1}}}, Exception={{{2}}}", Name, Object, Exception);
            }
        }

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
        /// set |Retval| to the return value. If the requested value does not exist,
        /// don't set either |Retval| or |Exception|. If retrieval fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxGetByIndexEventHandler(object sender, CfxGetByIndexEventArgs e);

        /// <summary>
        /// Handle retrieval of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
        /// set |Retval| to the return value. If the requested value does not exist,
        /// don't set either |Retval| or |Exception|. If retrieval fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor retrieval was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxGetByIndexEventArgs : CfxEventArgs {

            internal int m_index;
            internal IntPtr m_object;
            internal CfxV8Value m_object_wrapped;
            internal CfxV8Value m_retval_wrapped;
            internal IntPtr m_exception_str;
            internal int m_exception_length;
            internal string m_exception_wrapped;
            internal bool m_exception_changed;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetByIndexEventArgs(int index, IntPtr @object, IntPtr exception_str, int exception_length) {
                m_index = index;
                m_object = @object;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            /// <summary>
            /// Get the Index parameter for the <see cref="CfxV8Interceptor.GetByIndex"/> callback.
            /// </summary>
            public int Index {
                get {
                    CheckAccess();
                    return m_index;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfxV8Interceptor.GetByIndex"/> callback.
            /// </summary>
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Set the Retval out parameter for the <see cref="CfxV8Interceptor.GetByIndex"/> callback.
            /// </summary>
            public CfxV8Value Retval {
                set {
                    CheckAccess();
                    m_retval_wrapped = value;
                }
            }
            /// <summary>
            /// Get or set the Exception parameter for the <see cref="CfxV8Interceptor.GetByIndex"/> callback.
            /// </summary>
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null) {
                        m_exception_wrapped = StringFunctions.PtrToStringUni(m_exception_str, m_exception_length);
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
            /// Set the return value for the <see cref="CfxV8Interceptor.GetByIndex"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Index={{{0}}}, Object={{{1}}}, Exception={{{2}}}", Index, Object, Exception);
            }
        }

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Name|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. This setter will always
        /// be called, even when the property has an associated accessor. Return true
        /// (1) if interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxSetByNameEventHandler(object sender, CfxSetByNameEventArgs e);

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Name|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. This setter will always
        /// be called, even when the property has an associated accessor. Return true
        /// (1) if interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxSetByNameEventArgs : CfxEventArgs {

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

            internal CfxSetByNameEventArgs(IntPtr name_str, int name_length, IntPtr @object, IntPtr value, IntPtr exception_str, int exception_length) {
                m_name_str = name_str;
                m_name_length = name_length;
                m_object = @object;
                m_value = value;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            /// <summary>
            /// Get the Name parameter for the <see cref="CfxV8Interceptor.SetByName"/> callback.
            /// </summary>
            public string Name {
                get {
                    CheckAccess();
                    m_name = StringFunctions.PtrToStringUni(m_name_str, m_name_length);
                    return m_name;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfxV8Interceptor.SetByName"/> callback.
            /// </summary>
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Get the Value parameter for the <see cref="CfxV8Interceptor.SetByName"/> callback.
            /// </summary>
            public CfxV8Value Value {
                get {
                    CheckAccess();
                    if(m_value_wrapped == null) m_value_wrapped = CfxV8Value.Wrap(m_value);
                    return m_value_wrapped;
                }
            }
            /// <summary>
            /// Get or set the Exception parameter for the <see cref="CfxV8Interceptor.SetByName"/> callback.
            /// </summary>
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null) {
                        m_exception_wrapped = StringFunctions.PtrToStringUni(m_exception_str, m_exception_length);
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
            /// Set the return value for the <see cref="CfxV8Interceptor.SetByName"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
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

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public delegate void CfxSetByIndexEventHandler(object sender, CfxSetByIndexEventArgs e);

        /// <summary>
        /// Handle assignment of the interceptor value identified by |Index|. |Object|
        /// is the receiver ('this' object) of the interceptor. |Value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |Exception| to the exception that will be thrown. Return true (1) if
        /// interceptor assignment was handled, false (0) otherwise.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public class CfxSetByIndexEventArgs : CfxEventArgs {

            internal int m_index;
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

            internal CfxSetByIndexEventArgs(int index, IntPtr @object, IntPtr value, IntPtr exception_str, int exception_length) {
                m_index = index;
                m_object = @object;
                m_value = value;
                m_exception_str = exception_str;
                m_exception_length = exception_length;
            }

            /// <summary>
            /// Get the Index parameter for the <see cref="CfxV8Interceptor.SetByIndex"/> callback.
            /// </summary>
            public int Index {
                get {
                    CheckAccess();
                    return m_index;
                }
            }
            /// <summary>
            /// Get the Object parameter for the <see cref="CfxV8Interceptor.SetByIndex"/> callback.
            /// </summary>
            public CfxV8Value Object {
                get {
                    CheckAccess();
                    if(m_object_wrapped == null) m_object_wrapped = CfxV8Value.Wrap(m_object);
                    return m_object_wrapped;
                }
            }
            /// <summary>
            /// Get the Value parameter for the <see cref="CfxV8Interceptor.SetByIndex"/> callback.
            /// </summary>
            public CfxV8Value Value {
                get {
                    CheckAccess();
                    if(m_value_wrapped == null) m_value_wrapped = CfxV8Value.Wrap(m_value);
                    return m_value_wrapped;
                }
            }
            /// <summary>
            /// Get or set the Exception parameter for the <see cref="CfxV8Interceptor.SetByIndex"/> callback.
            /// </summary>
            public string Exception {
                get {
                    CheckAccess();
                    if(!m_exception_changed && m_exception_wrapped == null) {
                        m_exception_wrapped = StringFunctions.PtrToStringUni(m_exception_str, m_exception_length);
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
            /// Set the return value for the <see cref="CfxV8Interceptor.SetByIndex"/> callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Index={{{0}}}, Object={{{1}}}, Value={{{2}}}, Exception={{{3}}}", Index, Object, Value, Exception);
            }
        }

    }
}
