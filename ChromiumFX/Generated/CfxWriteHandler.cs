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
    /// Structure the client can implement to provide a custom stream writer. The
    /// functions of this structure may be called on any thread.
    /// </summary>
    public class CfxWriteHandler : CfxBase {

        internal static CfxWriteHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_write_handler_get_gc_handle(nativePtr);
            return (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void write(IntPtr gcHandlePtr, out int __retval, IntPtr ptr, int size, int n) {
            var self = (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxWriteEventArgs(ptr, size, n);
            var eventHandler = self.m_Write;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void seek(IntPtr gcHandlePtr, out int __retval, long offset, int whence) {
            var self = (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxSeekEventArgs(offset, whence);
            var eventHandler = self.m_Seek;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void tell(IntPtr gcHandlePtr, out long __retval) {
            var self = (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(long);
                return;
            }
            var e = new CfxTellEventArgs();
            var eventHandler = self.m_Tell;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void flush(IntPtr gcHandlePtr, out int __retval) {
            var self = (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxFlushEventArgs();
            var eventHandler = self.m_Flush;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void may_block(IntPtr gcHandlePtr, out int __retval) {
            var self = (CfxWriteHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxMayBlockEventArgs();
            var eventHandler = self.m_MayBlock;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxWriteHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxWriteHandler() : base(CfxApi.cfx_write_handler_ctor) {}

        /// <summary>
        /// Write raw binary data.
        /// </summary>
        public event CfxWriteEventHandler Write {
            add {
                if(m_Write == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 0, 1);
                }
                m_Write += value;
            }
            remove {
                m_Write -= value;
                if(m_Write == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxWriteEventHandler m_Write;

        /// <summary>
        /// Seek to the specified offset position. |Whence| may be any one of SEEK_CUR,
        /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
        /// </summary>
        public event CfxSeekEventHandler Seek {
            add {
                if(m_Seek == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 1, 1);
                }
                m_Seek += value;
            }
            remove {
                m_Seek -= value;
                if(m_Seek == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxSeekEventHandler m_Seek;

        /// <summary>
        /// Return the current offset position.
        /// </summary>
        public event CfxTellEventHandler Tell {
            add {
                if(m_Tell == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 2, 1);
                }
                m_Tell += value;
            }
            remove {
                m_Tell -= value;
                if(m_Tell == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxTellEventHandler m_Tell;

        /// <summary>
        /// Flush the stream.
        /// </summary>
        public event CfxFlushEventHandler Flush {
            add {
                if(m_Flush == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 3, 1);
                }
                m_Flush += value;
            }
            remove {
                m_Flush -= value;
                if(m_Flush == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxFlushEventHandler m_Flush;

        /// <summary>
        /// Return true (1) if this handler performs work like accessing the file
        /// system which may block. Used as a hint for determining the thread to access
        /// the handler from.
        /// </summary>
        public event CfxMayBlockEventHandler MayBlock {
            add {
                if(m_MayBlock == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 4, 1);
                }
                m_MayBlock += value;
            }
            remove {
                m_MayBlock -= value;
                if(m_MayBlock == null) {
                    CfxApi.cfx_write_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxMayBlockEventHandler m_MayBlock;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Write != null) {
                m_Write = null;
                CfxApi.cfx_write_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_Seek != null) {
                m_Seek = null;
                CfxApi.cfx_write_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_Tell != null) {
                m_Tell = null;
                CfxApi.cfx_write_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_Flush != null) {
                m_Flush = null;
                CfxApi.cfx_write_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_MayBlock != null) {
                m_MayBlock = null;
                CfxApi.cfx_write_handler_activate_callback(NativePtr, 4, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxWriteEventHandler(object sender, CfxWriteEventArgs e);

        /// <summary>
        /// Write raw binary data.
        /// </summary>
        public class CfxWriteEventArgs : CfxEventArgs {

            internal IntPtr m_ptr;
            internal int m_size;
            internal int m_n;

            internal int m_returnValue;
            private bool returnValueSet;

            internal CfxWriteEventArgs(IntPtr ptr, int size, int n) {
                m_ptr = ptr;
                m_size = size;
                m_n = n;
            }

            public IntPtr Ptr {
                get {
                    CheckAccess();
                    return m_ptr;
                }
            }
            public int Size {
                get {
                    CheckAccess();
                    return m_size;
                }
            }
            public int N {
                get {
                    CheckAccess();
                    return m_n;
                }
            }
            public void SetReturnValue(int returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Ptr={{{0}}}, Size={{{1}}}, N={{{2}}}", Ptr, Size, N);
            }
        }



        public delegate void CfxFlushEventHandler(object sender, CfxFlushEventArgs e);

        /// <summary>
        /// Flush the stream.
        /// </summary>
        public class CfxFlushEventArgs : CfxEventArgs {


            internal int m_returnValue;
            private bool returnValueSet;

            internal CfxFlushEventArgs() {
            }

            public void SetReturnValue(int returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }
        }


    }
}
