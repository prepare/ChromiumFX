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
    /// Implement this structure to receive string values asynchronously.
    /// </summary>
    public class CfxStringVisitor : CfxBase {

        internal static CfxStringVisitor Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_string_visitor_get_gc_handle(nativePtr);
            return (CfxStringVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void visit(IntPtr gcHandlePtr, IntPtr string_str, int string_length) {
            var self = (CfxStringVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxStringVisitorVisitEventArgs(string_str, string_length);
            var eventHandler = self.m_Visit;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
        }

        internal CfxStringVisitor(IntPtr nativePtr) : base(nativePtr) {}
        public CfxStringVisitor() : base(CfxApi.cfx_string_visitor_ctor) {}

        /// <summary>
        /// Method that will be executed.
        /// </summary>
        public event CfxStringVisitorVisitEventHandler Visit {
            add {
                if(m_Visit == null) {
                    CfxApi.cfx_string_visitor_activate_callback(NativePtr, 0, 1);
                }
                m_Visit += value;
            }
            remove {
                m_Visit -= value;
                if(m_Visit == null) {
                    CfxApi.cfx_string_visitor_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxStringVisitorVisitEventHandler m_Visit;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Visit != null) {
                m_Visit = null;
                CfxApi.cfx_string_visitor_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxStringVisitorVisitEventHandler(object sender, CfxStringVisitorVisitEventArgs e);

        /// <summary>
        /// Method that will be executed.
        /// </summary>
        public class CfxStringVisitorVisitEventArgs : CfxEventArgs {

            internal IntPtr m_string_str;
            internal int m_string_length;
            internal string m_string;

            internal CfxStringVisitorVisitEventArgs(IntPtr string_str, int string_length) {
                m_string_str = string_str;
                m_string_length = string_length;
            }

            public string String {
                get {
                    CheckAccess();
                    if(m_string == null && m_string_str != IntPtr.Zero) m_string = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_string_str, m_string_length);
                    return m_string;
                }
            }

            public override string ToString() {
                return String.Format("String={{{0}}}", String);
            }
        }

    }
}
