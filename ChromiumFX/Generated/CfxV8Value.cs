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
    /// Structure representing a V8 value handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CfxV8Context.GetTaskRunner() function.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public class CfxV8Value : CfxBase {

        static CfxV8Value () {
            CfxApi.cfx_v8value_create_undefined = (CfxApi.cfx_v8value_create_undefined_delegate)CfxApi.GetDelegate(944, typeof(CfxApi.cfx_v8value_create_undefined_delegate));
            CfxApi.cfx_v8value_create_null = (CfxApi.cfx_v8value_create_null_delegate)CfxApi.GetDelegate(945, typeof(CfxApi.cfx_v8value_create_null_delegate));
            CfxApi.cfx_v8value_create_bool = (CfxApi.cfx_v8value_create_bool_delegate)CfxApi.GetDelegate(946, typeof(CfxApi.cfx_v8value_create_bool_delegate));
            CfxApi.cfx_v8value_create_int = (CfxApi.cfx_v8value_create_int_delegate)CfxApi.GetDelegate(947, typeof(CfxApi.cfx_v8value_create_int_delegate));
            CfxApi.cfx_v8value_create_uint = (CfxApi.cfx_v8value_create_uint_delegate)CfxApi.GetDelegate(948, typeof(CfxApi.cfx_v8value_create_uint_delegate));
            CfxApi.cfx_v8value_create_double = (CfxApi.cfx_v8value_create_double_delegate)CfxApi.GetDelegate(949, typeof(CfxApi.cfx_v8value_create_double_delegate));
            CfxApi.cfx_v8value_create_date = (CfxApi.cfx_v8value_create_date_delegate)CfxApi.GetDelegate(950, typeof(CfxApi.cfx_v8value_create_date_delegate));
            CfxApi.cfx_v8value_create_string = (CfxApi.cfx_v8value_create_string_delegate)CfxApi.GetDelegate(951, typeof(CfxApi.cfx_v8value_create_string_delegate));
            CfxApi.cfx_v8value_create_object = (CfxApi.cfx_v8value_create_object_delegate)CfxApi.GetDelegate(952, typeof(CfxApi.cfx_v8value_create_object_delegate));
            CfxApi.cfx_v8value_create_array = (CfxApi.cfx_v8value_create_array_delegate)CfxApi.GetDelegate(953, typeof(CfxApi.cfx_v8value_create_array_delegate));
            CfxApi.cfx_v8value_create_function = (CfxApi.cfx_v8value_create_function_delegate)CfxApi.GetDelegate(954, typeof(CfxApi.cfx_v8value_create_function_delegate));
            CfxApi.cfx_v8value_is_valid = (CfxApi.cfx_v8value_is_valid_delegate)CfxApi.GetDelegate(955, typeof(CfxApi.cfx_v8value_is_valid_delegate));
            CfxApi.cfx_v8value_is_undefined = (CfxApi.cfx_v8value_is_undefined_delegate)CfxApi.GetDelegate(956, typeof(CfxApi.cfx_v8value_is_undefined_delegate));
            CfxApi.cfx_v8value_is_null = (CfxApi.cfx_v8value_is_null_delegate)CfxApi.GetDelegate(957, typeof(CfxApi.cfx_v8value_is_null_delegate));
            CfxApi.cfx_v8value_is_bool = (CfxApi.cfx_v8value_is_bool_delegate)CfxApi.GetDelegate(958, typeof(CfxApi.cfx_v8value_is_bool_delegate));
            CfxApi.cfx_v8value_is_int = (CfxApi.cfx_v8value_is_int_delegate)CfxApi.GetDelegate(959, typeof(CfxApi.cfx_v8value_is_int_delegate));
            CfxApi.cfx_v8value_is_uint = (CfxApi.cfx_v8value_is_uint_delegate)CfxApi.GetDelegate(960, typeof(CfxApi.cfx_v8value_is_uint_delegate));
            CfxApi.cfx_v8value_is_double = (CfxApi.cfx_v8value_is_double_delegate)CfxApi.GetDelegate(961, typeof(CfxApi.cfx_v8value_is_double_delegate));
            CfxApi.cfx_v8value_is_date = (CfxApi.cfx_v8value_is_date_delegate)CfxApi.GetDelegate(962, typeof(CfxApi.cfx_v8value_is_date_delegate));
            CfxApi.cfx_v8value_is_string = (CfxApi.cfx_v8value_is_string_delegate)CfxApi.GetDelegate(963, typeof(CfxApi.cfx_v8value_is_string_delegate));
            CfxApi.cfx_v8value_is_object = (CfxApi.cfx_v8value_is_object_delegate)CfxApi.GetDelegate(964, typeof(CfxApi.cfx_v8value_is_object_delegate));
            CfxApi.cfx_v8value_is_array = (CfxApi.cfx_v8value_is_array_delegate)CfxApi.GetDelegate(965, typeof(CfxApi.cfx_v8value_is_array_delegate));
            CfxApi.cfx_v8value_is_function = (CfxApi.cfx_v8value_is_function_delegate)CfxApi.GetDelegate(966, typeof(CfxApi.cfx_v8value_is_function_delegate));
            CfxApi.cfx_v8value_is_same = (CfxApi.cfx_v8value_is_same_delegate)CfxApi.GetDelegate(967, typeof(CfxApi.cfx_v8value_is_same_delegate));
            CfxApi.cfx_v8value_get_bool_value = (CfxApi.cfx_v8value_get_bool_value_delegate)CfxApi.GetDelegate(968, typeof(CfxApi.cfx_v8value_get_bool_value_delegate));
            CfxApi.cfx_v8value_get_int_value = (CfxApi.cfx_v8value_get_int_value_delegate)CfxApi.GetDelegate(969, typeof(CfxApi.cfx_v8value_get_int_value_delegate));
            CfxApi.cfx_v8value_get_uint_value = (CfxApi.cfx_v8value_get_uint_value_delegate)CfxApi.GetDelegate(970, typeof(CfxApi.cfx_v8value_get_uint_value_delegate));
            CfxApi.cfx_v8value_get_double_value = (CfxApi.cfx_v8value_get_double_value_delegate)CfxApi.GetDelegate(971, typeof(CfxApi.cfx_v8value_get_double_value_delegate));
            CfxApi.cfx_v8value_get_date_value = (CfxApi.cfx_v8value_get_date_value_delegate)CfxApi.GetDelegate(972, typeof(CfxApi.cfx_v8value_get_date_value_delegate));
            CfxApi.cfx_v8value_get_string_value = (CfxApi.cfx_v8value_get_string_value_delegate)CfxApi.GetDelegate(973, typeof(CfxApi.cfx_v8value_get_string_value_delegate));
            CfxApi.cfx_v8value_is_user_created = (CfxApi.cfx_v8value_is_user_created_delegate)CfxApi.GetDelegate(974, typeof(CfxApi.cfx_v8value_is_user_created_delegate));
            CfxApi.cfx_v8value_has_exception = (CfxApi.cfx_v8value_has_exception_delegate)CfxApi.GetDelegate(975, typeof(CfxApi.cfx_v8value_has_exception_delegate));
            CfxApi.cfx_v8value_get_exception = (CfxApi.cfx_v8value_get_exception_delegate)CfxApi.GetDelegate(976, typeof(CfxApi.cfx_v8value_get_exception_delegate));
            CfxApi.cfx_v8value_clear_exception = (CfxApi.cfx_v8value_clear_exception_delegate)CfxApi.GetDelegate(977, typeof(CfxApi.cfx_v8value_clear_exception_delegate));
            CfxApi.cfx_v8value_will_rethrow_exceptions = (CfxApi.cfx_v8value_will_rethrow_exceptions_delegate)CfxApi.GetDelegate(978, typeof(CfxApi.cfx_v8value_will_rethrow_exceptions_delegate));
            CfxApi.cfx_v8value_set_rethrow_exceptions = (CfxApi.cfx_v8value_set_rethrow_exceptions_delegate)CfxApi.GetDelegate(979, typeof(CfxApi.cfx_v8value_set_rethrow_exceptions_delegate));
            CfxApi.cfx_v8value_has_value_bykey = (CfxApi.cfx_v8value_has_value_bykey_delegate)CfxApi.GetDelegate(980, typeof(CfxApi.cfx_v8value_has_value_bykey_delegate));
            CfxApi.cfx_v8value_has_value_byindex = (CfxApi.cfx_v8value_has_value_byindex_delegate)CfxApi.GetDelegate(981, typeof(CfxApi.cfx_v8value_has_value_byindex_delegate));
            CfxApi.cfx_v8value_delete_value_bykey = (CfxApi.cfx_v8value_delete_value_bykey_delegate)CfxApi.GetDelegate(982, typeof(CfxApi.cfx_v8value_delete_value_bykey_delegate));
            CfxApi.cfx_v8value_delete_value_byindex = (CfxApi.cfx_v8value_delete_value_byindex_delegate)CfxApi.GetDelegate(983, typeof(CfxApi.cfx_v8value_delete_value_byindex_delegate));
            CfxApi.cfx_v8value_get_value_bykey = (CfxApi.cfx_v8value_get_value_bykey_delegate)CfxApi.GetDelegate(984, typeof(CfxApi.cfx_v8value_get_value_bykey_delegate));
            CfxApi.cfx_v8value_get_value_byindex = (CfxApi.cfx_v8value_get_value_byindex_delegate)CfxApi.GetDelegate(985, typeof(CfxApi.cfx_v8value_get_value_byindex_delegate));
            CfxApi.cfx_v8value_set_value_bykey = (CfxApi.cfx_v8value_set_value_bykey_delegate)CfxApi.GetDelegate(986, typeof(CfxApi.cfx_v8value_set_value_bykey_delegate));
            CfxApi.cfx_v8value_set_value_byindex = (CfxApi.cfx_v8value_set_value_byindex_delegate)CfxApi.GetDelegate(987, typeof(CfxApi.cfx_v8value_set_value_byindex_delegate));
            CfxApi.cfx_v8value_set_value_byaccessor = (CfxApi.cfx_v8value_set_value_byaccessor_delegate)CfxApi.GetDelegate(988, typeof(CfxApi.cfx_v8value_set_value_byaccessor_delegate));
            CfxApi.cfx_v8value_get_keys = (CfxApi.cfx_v8value_get_keys_delegate)CfxApi.GetDelegate(989, typeof(CfxApi.cfx_v8value_get_keys_delegate));
            CfxApi.cfx_v8value_set_user_data = (CfxApi.cfx_v8value_set_user_data_delegate)CfxApi.GetDelegate(990, typeof(CfxApi.cfx_v8value_set_user_data_delegate));
            CfxApi.cfx_v8value_get_user_data = (CfxApi.cfx_v8value_get_user_data_delegate)CfxApi.GetDelegate(991, typeof(CfxApi.cfx_v8value_get_user_data_delegate));
            CfxApi.cfx_v8value_get_externally_allocated_memory = (CfxApi.cfx_v8value_get_externally_allocated_memory_delegate)CfxApi.GetDelegate(992, typeof(CfxApi.cfx_v8value_get_externally_allocated_memory_delegate));
            CfxApi.cfx_v8value_adjust_externally_allocated_memory = (CfxApi.cfx_v8value_adjust_externally_allocated_memory_delegate)CfxApi.GetDelegate(993, typeof(CfxApi.cfx_v8value_adjust_externally_allocated_memory_delegate));
            CfxApi.cfx_v8value_get_array_length = (CfxApi.cfx_v8value_get_array_length_delegate)CfxApi.GetDelegate(994, typeof(CfxApi.cfx_v8value_get_array_length_delegate));
            CfxApi.cfx_v8value_get_function_name = (CfxApi.cfx_v8value_get_function_name_delegate)CfxApi.GetDelegate(995, typeof(CfxApi.cfx_v8value_get_function_name_delegate));
            CfxApi.cfx_v8value_get_function_handler = (CfxApi.cfx_v8value_get_function_handler_delegate)CfxApi.GetDelegate(996, typeof(CfxApi.cfx_v8value_get_function_handler_delegate));
            CfxApi.cfx_v8value_execute_function = (CfxApi.cfx_v8value_execute_function_delegate)CfxApi.GetDelegate(997, typeof(CfxApi.cfx_v8value_execute_function_delegate));
            CfxApi.cfx_v8value_execute_function_with_context = (CfxApi.cfx_v8value_execute_function_with_context_delegate)CfxApi.GetDelegate(998, typeof(CfxApi.cfx_v8value_execute_function_with_context_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxV8Value Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxV8Value)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxV8Value(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxV8Value(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new CfxV8Value object of type undefined.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateUndefined() {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_undefined());
        }

        /// <summary>
        /// Create a new CfxV8Value object of type null.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateNull() {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_null());
        }

        /// <summary>
        /// Create a new CfxV8Value object of type bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateBool(bool value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_bool(value ? 1 : 0));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateInt(int value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_int(value));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type unsigned int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateUint(uint value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_uint(value));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateDouble(double value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_double(value));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type Date. This function should only be
        /// called from within the scope of a CfxV8ContextHandler, CfxV8Handler or
        /// CfxV8Accessor callback, or in combination with calling enter() and exit()
        /// on a stored CfxV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateDate(CfxTime date) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_date(CfxTime.Unwrap(date)));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateString(string value) {
            var value_pinned = new PinnedString(value);
            var __retval = CfxApi.cfx_v8value_create_string(value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Create a new CfxV8Value object of type object with optional accessor. This
        /// function should only be called from within the scope of a
        /// CfxV8ContextHandler, CfxV8Handler or CfxV8Accessor callback, or in
        /// combination with calling enter() and exit() on a stored CfxV8Context
        /// reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateObject(CfxV8Accessor accessor) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_object(CfxV8Accessor.Unwrap(accessor)));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type array with the specified |length|.
        /// If |length| is negative the returned array will have length 0. This function
        /// should only be called from within the scope of a CfxV8ContextHandler,
        /// CfxV8Handler or CfxV8Accessor callback, or in combination with calling
        /// enter() and exit() on a stored CfxV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateArray(int length) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_array(length));
        }

        /// <summary>
        /// Create a new CfxV8Value object of type function. This function should only
        /// be called from within the scope of a CfxV8ContextHandler, CfxV8Handler
        /// or CfxV8Accessor callback, or in combination with calling enter() and
        /// exit() on a stored CfxV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfxV8Value CreateFunction(string name, CfxV8Handler handler) {
            var name_pinned = new PinnedString(name);
            var __retval = CfxApi.cfx_v8value_create_function(name_pinned.Obj.PinnedPtr, name_pinned.Length, CfxV8Handler.Unwrap(handler));
            name_pinned.Obj.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Returns true (1) if the underlying handle is valid and it can be accessed
        /// on the current thread. Do not call any other functions if this function
        /// returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_v8value_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is undefined.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUndefined {
            get {
                return 0 != CfxApi.cfx_v8value_is_undefined(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is null.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsNull {
            get {
                return 0 != CfxApi.cfx_v8value_is_null(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsBool {
            get {
                return 0 != CfxApi.cfx_v8value_is_bool(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsInt {
            get {
                return 0 != CfxApi.cfx_v8value_is_int(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is unsigned int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUint {
            get {
                return 0 != CfxApi.cfx_v8value_is_uint(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsDouble {
            get {
                return 0 != CfxApi.cfx_v8value_is_double(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is Date.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsDate {
            get {
                return 0 != CfxApi.cfx_v8value_is_date(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsString {
            get {
                return 0 != CfxApi.cfx_v8value_is_string(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsObject {
            get {
                return 0 != CfxApi.cfx_v8value_is_object(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is array.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsArray {
            get {
                return 0 != CfxApi.cfx_v8value_is_array(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsFunction {
            get {
                return 0 != CfxApi.cfx_v8value_is_function(NativePtr);
            }
        }

        /// <summary>
        /// Return a bool value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool BoolValue {
            get {
                return 0 != CfxApi.cfx_v8value_get_bool_value(NativePtr);
            }
        }

        /// <summary>
        /// Return an int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int IntValue {
            get {
                return CfxApi.cfx_v8value_get_int_value(NativePtr);
            }
        }

        /// <summary>
        /// Return an unisgned int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public uint UintValue {
            get {
                return CfxApi.cfx_v8value_get_uint_value(NativePtr);
            }
        }

        /// <summary>
        /// Return a double value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public double DoubleValue {
            get {
                return CfxApi.cfx_v8value_get_double_value(NativePtr);
            }
        }

        /// <summary>
        /// Return a Date value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxTime DateValue {
            get {
                return CfxTime.WrapOwned(CfxApi.cfx_v8value_get_date_value(NativePtr));
            }
        }

        /// <summary>
        /// Return a string value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public string StringValue {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_v8value_get_string_value(NativePtr));
            }
        }

        /// <summary>
        /// OBJECT METHODS - These functions are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true (1) if this is a user created object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUserCreated {
            get {
                return 0 != CfxApi.cfx_v8value_is_user_created(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the last function call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasException {
            get {
                return 0 != CfxApi.cfx_v8value_has_exception(NativePtr);
            }
        }

        /// <summary>
        /// Returns the exception resulting from the last function call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Exception Exception {
            get {
                return CfxV8Exception.Wrap(CfxApi.cfx_v8value_get_exception(NativePtr));
            }
        }

        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxBase UserData {
            get {
                return CfxBase.Cast(CfxApi.cfx_v8value_get_user_data(NativePtr));
            }
        }

        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int ExternallyAllocatedMemory {
            get {
                return CfxApi.cfx_v8value_get_externally_allocated_memory(NativePtr);
            }
        }

        /// <summary>
        /// ARRAY METHODS - These functions are only available on arrays.
        /// Returns the number of elements in the array.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int ArrayLength {
            get {
                return CfxApi.cfx_v8value_get_array_length(NativePtr);
            }
        }

        /// <summary>
        /// FUNCTION METHODS - These functions are only available on functions.
        /// Returns the function name.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public string FunctionName {
            get {
                return StringFunctions.ConvertStringUserfree(CfxApi.cfx_v8value_get_function_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Handler FunctionHandler {
            get {
                return CfxV8Handler.Wrap(CfxApi.cfx_v8value_get_function_handler(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsSame(CfxV8Value that) {
            return 0 != CfxApi.cfx_v8value_is_same(NativePtr, CfxV8Value.Unwrap(that));
        }

        /// <summary>
        /// Clears the last exception and returns true (1) on success.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool ClearException() {
            return 0 != CfxApi.cfx_v8value_clear_exception(NativePtr);
        }

        /// <summary>
        /// Returns true (1) if this object will re-throw future exceptions. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool WillRethrowExceptions() {
            return 0 != CfxApi.cfx_v8value_will_rethrow_exceptions(NativePtr);
        }

        /// <summary>
        /// Set whether this object will re-throw future exceptions. By default
        /// exceptions are not re-thrown. If a exception is re-thrown the current
        /// context should not be accessed again until after the exception has been
        /// caught and not re-thrown. Returns true (1) on success. This attribute
        /// exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetRethrowExceptions(bool rethrow) {
            return 0 != CfxApi.cfx_v8value_set_rethrow_exceptions(NativePtr, rethrow ? 1 : 0);
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasValue(string key) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_has_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasValue(int index) {
            return 0 != CfxApi.cfx_v8value_has_value_byindex(NativePtr, index);
        }

        /// <summary>
        /// Deletes the value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only and don't-delete values this function
        /// will return true (1) even though deletion failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool DeleteValue(string key) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_delete_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Deletes the value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly, deletion
        /// fails or an exception is thrown. For read-only and don't-delete values this
        /// function will return true (1) even though deletion failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool DeleteValue(int index) {
            return 0 != CfxApi.cfx_v8value_delete_value_byindex(NativePtr, index);
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Value GetValue(string key) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_get_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Value GetValue(int index) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_get_value_byindex(NativePtr, index));
        }

        /// <summary>
        /// Associates a value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only values this function will return true
        /// (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValue(string key, CfxV8Value value, CfxV8PropertyAttribute attribute) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_set_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length, CfxV8Value.Unwrap(value), attribute);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Associates a value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only values this function will return true
        /// (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValue(int index, CfxV8Value value) {
            return 0 != CfxApi.cfx_v8value_set_value_byindex(NativePtr, index, CfxV8Value.Unwrap(value));
        }

        /// <summary>
        /// Registers an identifier and returns true (1) on success. Access to the
        /// identifier will be forwarded to the CfxV8Accessor instance passed to
        /// CfxV8Value.CfxV8ValueCreateObject(). Returns false (0) if this
        /// function is called incorrectly or an exception is thrown. For read-only
        /// values this function will return true (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValue(string key, CfxV8AccessControl settings, CfxV8PropertyAttribute attribute) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_set_value_byaccessor(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length, settings, attribute);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool GetKeys(System.Collections.Generic.List<string> keys) {
            PinnedString[] keys_handles;
            var keys_unwrapped = StringFunctions.UnwrapCfxStringList(keys, out keys_handles);
            var __retval = CfxApi.cfx_v8value_get_keys(NativePtr, keys_unwrapped);
            StringFunctions.FreePinnedStrings(keys_handles);
            StringFunctions.CfxStringListCopyToManaged(keys_unwrapped, keys);
            CfxApi.cfx_string_list_free(keys_unwrapped);
            return 0 != __retval;
        }

        /// <summary>
        /// Sets the user data for this object and returns true (1) on success. Returns
        /// false (0) if this function is called incorrectly. This function can only be
        /// called on user created objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetUserData(CfxBase userData) {
            return 0 != CfxApi.cfx_v8value_set_user_data(NativePtr, CfxBase.Unwrap(userData));
        }

        /// <summary>
        /// Adjusts the amount of registered external memory for the object. Used to
        /// give V8 an indication of the amount of externally allocated memory that is
        /// kept alive by JavaScript objects. V8 uses this information to decide when
        /// to perform global garbage collection. Each CfxV8Value tracks the amount
        /// of external memory associated with it and automatically decreases the
        /// global total by the appropriate amount on its destruction.
        /// |changeInBytes| specifies the number of bytes to adjust by. This function
        /// returns the number of bytes associated with the object after the
        /// adjustment. This function can only be called on user created objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int AdjustExternallyAllocatedMemory(int changeInBytes) {
            return CfxApi.cfx_v8value_adjust_externally_allocated_memory(NativePtr, changeInBytes);
        }

        /// <summary>
        /// Execute the function using the current V8 context. This function should
        /// only be called from within the scope of a CfxV8Handler or
        /// CfxV8Accessor callback, or in combination with calling enter() and
        /// exit() on a stored CfxV8Context reference. |object| is the receiver
        /// ('this' object) of the function. If |object| is NULL the current context's
        /// global object will be used. |arguments| is the list of arguments that will
        /// be passed to the function. Returns the function return value on success.
        /// Returns NULL if this function is called incorrectly or an exception is
        /// thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Value ExecuteFunction(CfxV8Value @object, CfxV8Value[] arguments) {
            int arguments_length = arguments.Length;
            IntPtr[] arguments_ptrs = new IntPtr[arguments_length];
            for(int i = 0; i < arguments_length; ++i) {
                arguments_ptrs[i] = CfxV8Value.Unwrap(arguments[i]);
            }
            PinnedObject arguments_pinned = new PinnedObject(arguments_ptrs);
            var __retval = CfxApi.cfx_v8value_execute_function(NativePtr, CfxV8Value.Unwrap(@object), arguments_length, arguments_pinned.PinnedPtr);
            arguments_pinned.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Execute the function using the specified V8 context. |object| is the
        /// receiver ('this' object) of the function. If |object| is NULL the specified
        /// context's global object will be used. |arguments| is the list of arguments
        /// that will be passed to the function. Returns the function return value on
        /// success. Returns NULL if this function is called incorrectly or an
        /// exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfxV8Value ExecuteFunctionWithContext(CfxV8Context context, CfxV8Value @object, CfxV8Value[] arguments) {
            int arguments_length = arguments.Length;
            IntPtr[] arguments_ptrs = new IntPtr[arguments_length];
            for(int i = 0; i < arguments_length; ++i) {
                arguments_ptrs[i] = CfxV8Value.Unwrap(arguments[i]);
            }
            PinnedObject arguments_pinned = new PinnedObject(arguments_ptrs);
            var __retval = CfxApi.cfx_v8value_execute_function_with_context(NativePtr, CfxV8Context.Unwrap(context), CfxV8Value.Unwrap(@object), arguments_length, arguments_pinned.PinnedPtr);
            arguments_pinned.Free();
            return CfxV8Value.Wrap(__retval);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
