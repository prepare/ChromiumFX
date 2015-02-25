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
namespace Chromium {
    public abstract class CfxStructure : CfxObject {

        static internal IntPtr Unwrap(CfxStructure structure) {
            if(structure == null)
                return IntPtr.Zero;
            return structure.NativePtr;
        }

        private readonly CfxApi.cfx_ctor_delegate m_cfx_ctor;
        private readonly CfxApi.cfx_dtor_delegate m_cfx_dtor;
        
        internal CfxStructure(CfxApi.cfx_ctor_delegate cfx_ctor, CfxApi.cfx_dtor_delegate cfx_dtor) {
            this.m_cfx_ctor = cfx_ctor;
            this.m_cfx_dtor = cfx_dtor;
            CreateNative(cfx_ctor);
        }

        internal CfxStructure(IntPtr nativePtr, CfxApi.cfx_ctor_delegate cfx_ctor, CfxApi.cfx_dtor_delegate cfx_dtor) {
            this.m_cfx_ctor = cfx_ctor;
            this.m_cfx_dtor = cfx_dtor;
            CreateNative(cfx_ctor);
            CopyToManaged(nativePtr);
        }

        /// <summary>
        /// Provides access to the underlying native cef struct.
        /// This object is not refcounted. The native cef struct
        /// will be destroyed when this object is disposed or finalized.
        /// Changes made to this managed object will not be copied
        /// to the native struct until you call this property again.
        /// </summary>
        public sealed override IntPtr NativePtr {
            get {
                if(nativePtrUnchecked == IntPtr.Zero) {
                    CreateNative(m_cfx_ctor);
                }
                CopyToNative();
                return nativePtrUnchecked;
            }
        }

        protected abstract void CopyToNative();
        protected virtual void CopyToManaged(IntPtr nativePtr) { }

        internal override sealed void OnDispose(IntPtr nativePtr) {
            m_cfx_dtor(nativePtr);
        }
    }
}
