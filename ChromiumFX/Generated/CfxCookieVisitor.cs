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
    /// Structure to implement for visiting cookie values. The functions of this
    /// structure will always be called on the IO thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
    /// </remarks>
    public class CfxCookieVisitor : CfxBase {

        internal static CfxCookieVisitor Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_cookie_visitor_get_gc_handle(nativePtr);
            return (CfxCookieVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void visit(IntPtr gcHandlePtr, out int __retval, IntPtr cookie, int count, int total, out int deleteCookie) {
            var self = (CfxCookieVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                deleteCookie = default(int);
                return;
            }
            var e = new CfxCookieVisitorVisitEventArgs(cookie, count, total);
            var eventHandler = self.m_Visit;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            deleteCookie = e.m_deleteCookie;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxCookieVisitor(IntPtr nativePtr) : base(nativePtr) {}
        public CfxCookieVisitor() : base(CfxApi.cfx_cookie_visitor_ctor) {}

        /// <summary>
        /// Method that will be called once for each cookie. |Count| is the 0-based
        /// index for the current cookie. |Total| is the total number of cookies. Set
        /// |DeleteCookie| to true (1) to delete the cookie currently being visited.
        /// Return false (0) to stop visiting cookies. This function may never be
        /// called if no cookies are found.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public event CfxCookieVisitorVisitEventHandler Visit {
            add {
                if(m_Visit == null) {
                    CfxApi.cfx_cookie_visitor_activate_callback(NativePtr, 0, 1);
                }
                m_Visit += value;
            }
            remove {
                m_Visit -= value;
                if(m_Visit == null) {
                    CfxApi.cfx_cookie_visitor_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxCookieVisitorVisitEventHandler m_Visit;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Visit != null) {
                m_Visit = null;
                CfxApi.cfx_cookie_visitor_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Method that will be called once for each cookie. |Count| is the 0-based
        /// index for the current cookie. |Total| is the total number of cookies. Set
        /// |DeleteCookie| to true (1) to delete the cookie currently being visited.
        /// Return false (0) to stop visiting cookies. This function may never be
        /// called if no cookies are found.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public delegate void CfxCookieVisitorVisitEventHandler(object sender, CfxCookieVisitorVisitEventArgs e);

        /// <summary>
        /// Method that will be called once for each cookie. |Count| is the 0-based
        /// index for the current cookie. |Total| is the total number of cookies. Set
        /// |DeleteCookie| to true (1) to delete the cookie currently being visited.
        /// Return false (0) to stop visiting cookies. This function may never be
        /// called if no cookies are found.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public class CfxCookieVisitorVisitEventArgs : CfxEventArgs {

            internal IntPtr m_cookie;
            internal CfxCookie m_cookie_wrapped;
            internal int m_count;
            internal int m_total;
            internal int m_deleteCookie;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxCookieVisitorVisitEventArgs(IntPtr cookie, int count, int total) {
                m_cookie = cookie;
                m_count = count;
                m_total = total;
            }

            public CfxCookie Cookie {
                get {
                    CheckAccess();
                    if(m_cookie_wrapped == null) m_cookie_wrapped = CfxCookie.Wrap(m_cookie);
                    return m_cookie_wrapped;
                }
            }
            public int Count {
                get {
                    CheckAccess();
                    return m_count;
                }
            }
            public int Total {
                get {
                    CheckAccess();
                    return m_total;
                }
            }
            public bool DeleteCookie {
                set {
                    CheckAccess();
                    m_deleteCookie = value ? 1 : 0;
                }
            }
            /// <summary>
            /// The underlying CEF framework callback for this event has a return value.
            /// Since .NET style events do not support return values, SetReturnValue()
            /// is used to set the return value for the callback. Although an application
            /// may attach various event handlers to a framework callback event,
            /// only one event handler can set the return value. Trying to call SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
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
                return String.Format("Cookie={{{0}}}, Count={{{1}}}, Total={{{2}}}", Cookie, Count, Total);
            }
        }

    }
}
