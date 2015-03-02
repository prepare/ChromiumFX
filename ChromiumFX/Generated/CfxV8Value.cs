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
    /// retrieved via the cef_v8context_t::get_task_runner() function.
    /// </summary>
    public class CfxV8Value : CfxBase {

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
        /// Create a new cef_v8value_t object of type undefined.
        /// </summary>
        public static CfxV8Value CreateUndefined() {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_undefined());
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type null.
        /// </summary>
        public static CfxV8Value CreateNull() {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_null());
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type bool.
        /// </summary>
        public static CfxV8Value CreateBool(bool value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_bool(value ? 1 : 0));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type int.
        /// </summary>
        public static CfxV8Value CreateInt(int value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_int(value));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type unsigned int.
        /// </summary>
        public static CfxV8Value CreateUint(uint value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_uint(value));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type double.
        /// </summary>
        public static CfxV8Value CreateDouble(double value) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_double(value));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type Date. This function should only be
        /// called from within the scope of a cef_v8context_tHandler, cef_v8handler_t or
        /// cef_v8accessor_t callback, or in combination with calling enter() and exit()
        /// on a stored cef_v8context_t reference.
        /// </summary>
        public static CfxV8Value CreateDate(CfxTime date) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_date(CfxTime.Unwrap(date)));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type string.
        /// </summary>
        public static CfxV8Value CreateString(string value) {
            var value_pinned = new PinnedString(value);
            var __retval = CfxApi.cfx_v8value_create_string(value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type object with optional accessor. This
        /// function should only be called from within the scope of a
        /// cef_v8context_tHandler, cef_v8handler_t or cef_v8accessor_t callback, or in
        /// combination with calling enter() and exit() on a stored cef_v8context_t
        /// reference.
        /// </summary>
        public static CfxV8Value CreateObject(CfxV8Accessor accessor) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_object(CfxV8Accessor.Unwrap(accessor)));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type array with the specified |length|.
        /// If |length| is negative the returned array will have length 0. This function
        /// should only be called from within the scope of a cef_v8context_tHandler,
        /// cef_v8handler_t or cef_v8accessor_t callback, or in combination with calling
        /// enter() and exit() on a stored cef_v8context_t reference.
        /// </summary>
        public static CfxV8Value CreateArray(int length) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_create_array(length));
        }

        /// <summary>
        /// Create a new cef_v8value_t object of type function. This function should only
        /// be called from within the scope of a cef_v8context_tHandler, cef_v8handler_t
        /// or cef_v8accessor_t callback, or in combination with calling enter() and
        /// exit() on a stored cef_v8context_t reference.
        /// </summary>
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
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_v8value_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is undefined.
        /// </summary>
        public bool IsUndefined {
            get {
                return 0 != CfxApi.cfx_v8value_is_undefined(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is null.
        /// </summary>
        public bool IsNull {
            get {
                return 0 != CfxApi.cfx_v8value_is_null(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is bool.
        /// </summary>
        public bool IsBool {
            get {
                return 0 != CfxApi.cfx_v8value_is_bool(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is int.
        /// </summary>
        public bool IsInt {
            get {
                return 0 != CfxApi.cfx_v8value_is_int(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is unsigned int.
        /// </summary>
        public bool IsUint {
            get {
                return 0 != CfxApi.cfx_v8value_is_uint(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is double.
        /// </summary>
        public bool IsDouble {
            get {
                return 0 != CfxApi.cfx_v8value_is_double(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is Date.
        /// </summary>
        public bool IsDate {
            get {
                return 0 != CfxApi.cfx_v8value_is_date(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is string.
        /// </summary>
        public bool IsString {
            get {
                return 0 != CfxApi.cfx_v8value_is_string(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is object.
        /// </summary>
        public bool IsObject {
            get {
                return 0 != CfxApi.cfx_v8value_is_object(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is array.
        /// </summary>
        public bool IsArray {
            get {
                return 0 != CfxApi.cfx_v8value_is_array(NativePtr);
            }
        }

        /// <summary>
        /// True if the value type is function.
        /// </summary>
        public bool IsFunction {
            get {
                return 0 != CfxApi.cfx_v8value_is_function(NativePtr);
            }
        }

        /// <summary>
        /// Return a bool value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public int BoolValue {
            get {
                return CfxApi.cfx_v8value_get_bool_value(NativePtr);
            }
        }

        /// <summary>
        /// Return an int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public int IntValue {
            get {
                return CfxApi.cfx_v8value_get_int_value(NativePtr);
            }
        }

        /// <summary>
        /// Return an unisgned int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public uint UintValue {
            get {
                return CfxApi.cfx_v8value_get_uint_value(NativePtr);
            }
        }

        /// <summary>
        /// Return a double value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public double DoubleValue {
            get {
                return CfxApi.cfx_v8value_get_double_value(NativePtr);
            }
        }

        /// <summary>
        /// Return a Date value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public CfxTime DateValue {
            get {
                return CfxTime.WrapOwned(CfxApi.cfx_v8value_get_date_value(NativePtr));
            }
        }

        /// <summary>
        /// Return a string value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        public String StringValue {
            get {
                return StringUserfree.Convert(CfxApi.cfx_v8value_get_string_value(NativePtr));
            }
        }

        /// <summary>
        /// OBJECT METHODS - These functions are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true (1) if this is a user created object.
        /// </summary>
        public bool IsUserCreated {
            get {
                return 0 != CfxApi.cfx_v8value_is_user_created(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the last function call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
        public bool HasException {
            get {
                return 0 != CfxApi.cfx_v8value_has_exception(NativePtr);
            }
        }

        /// <summary>
        /// Returns the exception resulting from the last function call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// </summary>
        public CfxV8Exception Exception {
            get {
                return CfxV8Exception.Wrap(CfxApi.cfx_v8value_get_exception(NativePtr));
            }
        }

        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// </summary>
        public CfxBase UserData {
            get {
                return CfxBase.Cast(CfxApi.cfx_v8value_get_user_data(NativePtr));
            }
        }

        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// </summary>
        public int ExternallyAllocatedMemory {
            get {
                return CfxApi.cfx_v8value_get_externally_allocated_memory(NativePtr);
            }
        }

        /// <summary>
        /// ARRAY METHODS - These functions are only available on arrays.
        /// Returns the number of elements in the array.
        /// </summary>
        public int ArrayLength {
            get {
                return CfxApi.cfx_v8value_get_array_length(NativePtr);
            }
        }

        /// <summary>
        /// FUNCTION METHODS - These functions are only available on functions.
        /// Returns the function name.
        /// </summary>
        public String FunctionName {
            get {
                return StringUserfree.Convert(CfxApi.cfx_v8value_get_function_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// </summary>
        public CfxV8Handler FunctionHandler {
            get {
                return CfxV8Handler.Wrap(CfxApi.cfx_v8value_get_function_handler(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        public bool IsSame(CfxV8Value that) {
            return 0 != CfxApi.cfx_v8value_is_same(NativePtr, CfxV8Value.Unwrap(that));
        }

        /// <summary>
        /// Clears the last exception and returns true (1) on success.
        /// </summary>
        public bool ClearException() {
            return 0 != CfxApi.cfx_v8value_clear_exception(NativePtr);
        }

        /// <summary>
        /// Returns true (1) if this object will re-throw future exceptions. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
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
        public bool SetRethrowExceptions(int rethrow) {
            return 0 != CfxApi.cfx_v8value_set_rethrow_exceptions(NativePtr, rethrow);
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        public bool HasValueByKey(string key) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_has_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        public bool HasValueByIndex(bool index) {
            return 0 != CfxApi.cfx_v8value_has_value_byindex(NativePtr, index ? 1 : 0);
        }

        /// <summary>
        /// Deletes the value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only and don't-delete values this function
        /// will return true (1) even though deletion failed.
        /// </summary>
        public bool DeleteValueByKey(string key) {
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
        public bool DeleteValueByIndex(bool index) {
            return 0 != CfxApi.cfx_v8value_delete_value_byindex(NativePtr, index ? 1 : 0);
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        public CfxV8Value GetValueByKey(string key) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_get_value_bykey(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length);
            key_pinned.Obj.Free();
            return CfxV8Value.Wrap(__retval);
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        public CfxV8Value GetValueByIndex(int index) {
            return CfxV8Value.Wrap(CfxApi.cfx_v8value_get_value_byindex(NativePtr, index));
        }

        /// <summary>
        /// Associates a value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only values this function will return true
        /// (1) even though assignment failed.
        /// </summary>
        public bool SetValueByKey(string key, CfxV8Value value, CfxV8PropertyAttribute attribute) {
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
        public bool SetValueByIndex(bool index, CfxV8Value value) {
            return 0 != CfxApi.cfx_v8value_set_value_byindex(NativePtr, index ? 1 : 0, CfxV8Value.Unwrap(value));
        }

        /// <summary>
        /// Registers an identifier and returns true (1) on success. Access to the
        /// identifier will be forwarded to the cef_v8accessor_t instance passed to
        /// cef_v8value_t::cef_v8value_create_object(). Returns false (0) if this
        /// function is called incorrectly or an exception is thrown. For read-only
        /// values this function will return true (1) even though assignment failed.
        /// </summary>
        public bool SetValueByAccessor(string key, CfxV8AccessControl settings, CfxV8PropertyAttribute attribute) {
            var key_pinned = new PinnedString(key);
            var __retval = CfxApi.cfx_v8value_set_value_byaccessor(NativePtr, key_pinned.Obj.PinnedPtr, key_pinned.Length, settings, attribute);
            key_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// </summary>
        public int GetKeys(System.Collections.Generic.List<string> keys) {
            PinnedString[] keys_handles;
            var keys_unwrapped = CfxStringCollections.UnwrapCfxStringList(keys, out keys_handles);
            var __retval = CfxApi.cfx_v8value_get_keys(NativePtr, keys_unwrapped);
            CfxStringCollections.FreePinnedStrings(keys_handles);
            CfxStringCollections.CfxStringListCopyToManaged(keys_unwrapped, keys);
            CfxApi.cfx_string_list_free(keys_unwrapped);
            return __retval;
        }

        /// <summary>
        /// Sets the user data for this object and returns true (1) on success. Returns
        /// false (0) if this function is called incorrectly. This function can only be
        /// called on user created objects.
        /// </summary>
        public bool SetUserData(CfxBase userData) {
            return 0 != CfxApi.cfx_v8value_set_user_data(NativePtr, CfxBase.Unwrap(userData));
        }

        /// <summary>
        /// Adjusts the amount of registered external memory for the object. Used to
        /// give V8 an indication of the amount of externally allocated memory that is
        /// kept alive by JavaScript objects. V8 uses this information to decide when
        /// to perform global garbage collection. Each cef_v8value_t tracks the amount
        /// of external memory associated with it and automatically decreases the
        /// global total by the appropriate amount on its destruction.
        /// |change_in_bytes| specifies the number of bytes to adjust by. This function
        /// returns the number of bytes associated with the object after the
        /// adjustment. This function can only be called on user created objects.
        /// </summary>
        public int AdjustExternallyAllocatedMemory(int changeInBytes) {
            return CfxApi.cfx_v8value_adjust_externally_allocated_memory(NativePtr, changeInBytes);
        }

        /// <summary>
        /// Execute the function using the current V8 context. This function should
        /// only be called from within the scope of a cef_v8handler_t or
        /// cef_v8accessor_t callback, or in combination with calling enter() and
        /// exit() on a stored cef_v8context_t reference. |object| is the receiver
        /// ('this' object) of the function. If |object| is NULL the current context's
        /// global object will be used. |arguments| is the list of arguments that will
        /// be passed to the function. Returns the function return value on success.
        /// Returns NULL if this function is called incorrectly or an exception is
        /// thrown.
        /// </summary>
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
