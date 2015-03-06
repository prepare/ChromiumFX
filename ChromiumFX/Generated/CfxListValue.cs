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
    /// Structure representing a list value. Can be used on any process and thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
    /// </remarks>
    public class CfxListValue : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxListValue Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxListValue)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxListValue(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxListValue(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public static CfxListValue Create() {
            return CfxListValue.Wrap(CfxApi.cfx_list_value_create());
        }

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_list_value_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this object is currently owned by another object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsOwned {
            get {
                return 0 != CfxApi.cfx_list_value_is_owned(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                return 0 != CfxApi.cfx_list_value_is_read_only(NativePtr);
            }
        }

        /// <summary>
        /// Returns the number of values.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public int Size {
            get {
                return CfxApi.cfx_list_value_get_size(NativePtr);
            }
        }

        /// <summary>
        /// Returns a writable copy of this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxListValue Copy() {
            return CfxListValue.Wrap(CfxApi.cfx_list_value_copy(NativePtr));
        }

        /// <summary>
        /// Sets the number of values. If the number of values is expanded all new
        /// value slots will default to type null. Returns true (1) on success.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetSize(int size) {
            return 0 != CfxApi.cfx_list_value_set_size(NativePtr, size);
        }

        /// <summary>
        /// Removes all values. Returns true (1) on success.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool Clear() {
            return 0 != CfxApi.cfx_list_value_clear(NativePtr);
        }

        /// <summary>
        /// Removes the value at the specified index.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public int Remove(int index) {
            return CfxApi.cfx_list_value_remove(NativePtr, index);
        }

        /// <summary>
        /// Returns the value type at the specified index.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxValueType GetType(int index) {
            return CfxApi.cfx_list_value_get_type(NativePtr, index);
        }

        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public int GetBool(int index) {
            return CfxApi.cfx_list_value_get_bool(NativePtr, index);
        }

        /// <summary>
        /// Returns the value at the specified index as type int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public int GetInt(int index) {
            return CfxApi.cfx_list_value_get_int(NativePtr, index);
        }

        /// <summary>
        /// Returns the value at the specified index as type double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public double GetDouble(int index) {
            return CfxApi.cfx_list_value_get_double(NativePtr, index);
        }

        /// <summary>
        /// Returns the value at the specified index as type string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public String GetString(int index) {
            return StringUserfree.Convert(CfxApi.cfx_list_value_get_string(NativePtr, index));
        }

        /// <summary>
        /// Returns the value at the specified index as type binary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxBinaryValue GetBinary(int index) {
            return CfxBinaryValue.Wrap(CfxApi.cfx_list_value_get_binary(NativePtr, index));
        }

        /// <summary>
        /// Returns the value at the specified index as type dictionary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxDictionaryValue GetDictionary(int index) {
            return CfxDictionaryValue.Wrap(CfxApi.cfx_list_value_get_dictionary(NativePtr, index));
        }

        /// <summary>
        /// Returns the value at the specified index as type list.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxListValue GetList(int index) {
            return CfxListValue.Wrap(CfxApi.cfx_list_value_get_list(NativePtr, index));
        }

        /// <summary>
        /// Sets the value at the specified index as type null. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetNull(int index) {
            return 0 != CfxApi.cfx_list_value_set_null(NativePtr, index);
        }

        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetBool(int index, int value) {
            return 0 != CfxApi.cfx_list_value_set_bool(NativePtr, index, value);
        }

        /// <summary>
        /// Sets the value at the specified index as type int. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetInt(int index, int value) {
            return 0 != CfxApi.cfx_list_value_set_int(NativePtr, index, value);
        }

        /// <summary>
        /// Sets the value at the specified index as type double. Returns true (1) if
        /// the value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetDouble(int index, double value) {
            return 0 != CfxApi.cfx_list_value_set_double(NativePtr, index, value);
        }

        /// <summary>
        /// Sets the value at the specified index as type string. Returns true (1) if
        /// the value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetString(int index, string value) {
            var value_pinned = new PinnedString(value);
            var __retval = CfxApi.cfx_list_value_set_string(NativePtr, index, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Sets the value at the specified index as type binary. Returns true (1) if
        /// the value was set successfully. After calling this function the |value|
        /// object will no longer be valid. If |value| is currently owned by another
        /// object then the value will be copied and the |value| reference will not
        /// change. Otherwise, ownership will be transferred to this object and the
        /// |value| reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetBinary(int index, CfxBinaryValue value) {
            return 0 != CfxApi.cfx_list_value_set_binary(NativePtr, index, CfxBinaryValue.Unwrap(value));
        }

        /// <summary>
        /// Sets the value at the specified index as type dict. Returns true (1) if the
        /// value was set successfully. After calling this function the |value| object
        /// will no longer be valid. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetDictionary(int index, CfxDictionaryValue value) {
            return 0 != CfxApi.cfx_list_value_set_dictionary(NativePtr, index, CfxDictionaryValue.Unwrap(value));
        }

        /// <summary>
        /// Sets the value at the specified index as type list. Returns true (1) if the
        /// value was set successfully. After calling this function the |value| object
        /// will no longer be valid. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetList(int index, CfxListValue value) {
            return 0 != CfxApi.cfx_list_value_set_list(NativePtr, index, CfxListValue.Unwrap(value));
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
