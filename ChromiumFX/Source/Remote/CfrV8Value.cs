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



using System;

namespace Chromium.Remote {
    partial class CfrV8Value {

        public static explicit operator CfrV8Value(bool value) {
            return CreateBool(value);
        }

        public static explicit operator CfrV8Value(CfrTime value) {
            return CreateDate(value);
        }

        public static explicit operator CfrV8Value(double value) {
            return CreateDouble(value);
        }

        public static explicit operator CfrV8Value(int value) {
            return CreateInt(value);
        }

        public static explicit operator CfrV8Value(string value) {
            return CreateString(value);
        }

        public static explicit operator CfrV8Value(uint value) {
            return CreateUint(value);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type object with accessor.
        /// This function should only be called from within the scope
        /// of a CfrRenderProcessHandler, CfrV8Handler or CfrV8Accessor
        /// callback, or in combination with calling enter() and exit() on a stored
        /// CfrV8Context reference.
        /// </summary>
        public static CfrV8Value CreateObject(CfrV8Accessor accessor) {
            return CreateObject(accessor, null);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type object with interceptor.
        /// This function should only be called from within the scope
        /// of a CfrRenderProcessHandler, CfrV8Handler or CfrV8Accessor
        /// callback, or in combination with calling enter() and exit() on a stored
        /// CfrV8Context reference.
        /// </summary>
        public static CfrV8Value CreateObject(CfrV8Interceptor interceptor) {
            return CreateObject(null, interceptor);
        }

        public override string ToString() {
            return StringValue;
        }
    }
}
