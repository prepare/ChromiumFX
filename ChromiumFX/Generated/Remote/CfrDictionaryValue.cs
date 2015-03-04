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

    /// <summary>
    /// Structure representing a dictionary value. Can be used on any process and
    /// thread.
    /// </summary>
    public class CfrDictionaryValue : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrDictionaryValue Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrDictionaryValue)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrDictionaryValue(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// </summary>
        public static CfrDictionaryValue Create(CfrRuntime remoteRuntime) {
            var call = new CfxDictionaryValueCreateRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrDictionaryValue.Wrap(call.__retval, remoteRuntime);
        }


        private CfrDictionaryValue(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        public bool IsValid {
            get {
                var call = new CfxDictionaryValueIsValidRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this object is currently owned by another object.
        /// </summary>
        public bool IsOwned {
            get {
                var call = new CfxDictionaryValueIsOwnedRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        public bool IsReadOnly {
            get {
                var call = new CfxDictionaryValueIsReadOnlyRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the number of values.
        /// </summary>
        public int Size {
            get {
                var call = new CfxDictionaryValueGetSizeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns a writable copy of this object. If |excludeNullChildren| is true
        /// (1) any NULL dictionaries or lists will be excluded from the copy.
        /// </summary>
        public CfrDictionaryValue Copy(bool excludeEmptyChildren) {
            var call = new CfxDictionaryValueCopyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.excludeEmptyChildren = excludeEmptyChildren;
            call.Execute(remoteRuntime.connection);
            return CfrDictionaryValue.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Removes all values. Returns true (1) on success.
        /// </summary>
        public bool Clear() {
            var call = new CfxDictionaryValueClearRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the current dictionary has a value for the given key.
        /// </summary>
        public bool HasKey(string key) {
            var call = new CfxDictionaryValueHasKeyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// </summary>
        public int GetKeys(System.Collections.Generic.List<string> keys) {
            var call = new CfxDictionaryValueGetKeysRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.keys = keys;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Removes the value at the specified key. Returns true (1) is the value was
        /// removed successfully.
        /// </summary>
        public bool Remove(string key) {
            var call = new CfxDictionaryValueRemoveRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value type for the specified key.
        /// </summary>
        public CfxValueType GetType(string key) {
            var call = new CfxDictionaryValueGetTypeRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return (CfxValueType)call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// </summary>
        public int GetBool(string key) {
            var call = new CfxDictionaryValueGetBoolRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type int.
        /// </summary>
        public int GetInt(string key) {
            var call = new CfxDictionaryValueGetIntRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type double.
        /// </summary>
        public double GetDouble(string key) {
            var call = new CfxDictionaryValueGetDoubleRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type string.
        /// </summary>
        public String GetString(string key) {
            var call = new CfxDictionaryValueGetStringRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type binary.
        /// </summary>
        public CfrBinaryValue GetBinary(string key) {
            var call = new CfxDictionaryValueGetBinaryRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return CfrBinaryValue.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the value at the specified key as type dictionary.
        /// </summary>
        public CfrDictionaryValue GetDictionary(string key) {
            var call = new CfxDictionaryValueGetDictionaryRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return CfrDictionaryValue.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the value at the specified key as type list.
        /// </summary>
        public CfrListValue GetList(string key) {
            var call = new CfxDictionaryValueGetListRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return CfrListValue.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Sets the value at the specified key as type null. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        public bool SetNull(string key) {
            var call = new CfxDictionaryValueSetNullRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        public bool SetBool(string key, int value) {
            var call = new CfxDictionaryValueSetBoolRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type int. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        public bool SetInt(string key, int value) {
            var call = new CfxDictionaryValueSetIntRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type double. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        public bool SetDouble(string key, double value) {
            var call = new CfxDictionaryValueSetDoubleRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type string. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        public bool SetString(string key, string value) {
            var call = new CfxDictionaryValueSetStringRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type binary. Returns true (1) if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public bool SetBinary(string key, CfrBinaryValue value) {
            var call = new CfxDictionaryValueSetBinaryRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = CfrObject.Unwrap(value);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type dict. Returns true (1) if the
        /// value was set successfully. After calling this function the |value| object
        /// will no longer be valid. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public bool SetDictionary(string key, CfrDictionaryValue value) {
            var call = new CfxDictionaryValueSetDictionaryRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = CfrObject.Unwrap(value);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type list. Returns true (1) if the
        /// value was set successfully. After calling this function the |value| object
        /// will no longer be valid. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public bool SetList(string key, CfrListValue value) {
            var call = new CfxDictionaryValueSetListRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = CfrObject.Unwrap(value);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
