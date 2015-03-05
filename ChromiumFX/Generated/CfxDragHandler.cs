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
    /// Implement this structure to handle events related to dragging. The functions
    /// of this structure will be called on the UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_handler_capi.h">cef/include/capi/cef_drag_handler_capi.h</see>.
    /// </remarks>
    public class CfxDragHandler : CfxBase {

        internal static CfxDragHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_drag_handler_get_gc_handle(nativePtr);
            return (CfxDragHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void on_drag_enter(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr dragData, CfxDragOperationsMask mask) {
            var self = (CfxDragHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxDragHandlerOnDragEnterEventArgs(browser, dragData, mask);
            var eventHandler = self.m_OnDragEnter;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_dragData_wrapped == null) CfxApi.cfx_release(e.m_dragData);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxDragHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDragHandler() : base(CfxApi.cfx_drag_handler_ctor) {}

        /// <summary>
        /// Called when an external drag event enters the browser window. |DragData|
        /// contains the drag event data and |Mask| represents the type of drag
        /// operation. Return false (0) for default drag handling behavior or true (1)
        /// to cancel the drag event.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_handler_capi.h">cef/include/capi/cef_drag_handler_capi.h</see>.
        /// </remarks>
        public event CfxDragHandlerOnDragEnterEventHandler OnDragEnter {
            add {
                if(m_OnDragEnter == null) {
                    CfxApi.cfx_drag_handler_activate_callback(NativePtr, 0, 1);
                }
                m_OnDragEnter += value;
            }
            remove {
                m_OnDragEnter -= value;
                if(m_OnDragEnter == null) {
                    CfxApi.cfx_drag_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxDragHandlerOnDragEnterEventHandler m_OnDragEnter;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnDragEnter != null) {
                m_OnDragEnter = null;
                CfxApi.cfx_drag_handler_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Called when an external drag event enters the browser window. |DragData|
        /// contains the drag event data and |Mask| represents the type of drag
        /// operation. Return false (0) for default drag handling behavior or true (1)
        /// to cancel the drag event.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_handler_capi.h">cef/include/capi/cef_drag_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxDragHandlerOnDragEnterEventHandler(object sender, CfxDragHandlerOnDragEnterEventArgs e);

        /// <summary>
        /// Called when an external drag event enters the browser window. |DragData|
        /// contains the drag event data and |Mask| represents the type of drag
        /// operation. Return false (0) for default drag handling behavior or true (1)
        /// to cancel the drag event.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_handler_capi.h">cef/include/capi/cef_drag_handler_capi.h</see>.
        /// </remarks>
        public class CfxDragHandlerOnDragEnterEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_dragData;
            internal CfxDragData m_dragData_wrapped;
            internal CfxDragOperationsMask m_mask;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxDragHandlerOnDragEnterEventArgs(IntPtr browser, IntPtr dragData, CfxDragOperationsMask mask) {
                m_browser = browser;
                m_dragData = dragData;
                m_mask = mask;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxDragData DragData {
                get {
                    CheckAccess();
                    if(m_dragData_wrapped == null) m_dragData_wrapped = CfxDragData.Wrap(m_dragData);
                    return m_dragData_wrapped;
                }
            }
            public CfxDragOperationsMask Mask {
                get {
                    CheckAccess();
                    return m_mask;
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
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_handler_capi.h">cef/include/capi/cef_drag_handler_capi.h</see>.
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
                return String.Format("Browser={{{0}}}, DragData={{{1}}}, Mask={{{2}}}", Browser, DragData, Mask);
            }
        }

    }
}
