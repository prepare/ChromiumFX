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
    /// Structure to implement for handling DOM events. The functions of this
    /// structure will be called on the render process main thread.
    /// </summary>
    public class CfxDomEventListener : CfxBase {

        internal static CfxDomEventListener Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_domevent_listener_get_gc_handle(nativePtr);
            return (CfxDomEventListener)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void handle_event(IntPtr gcHandlePtr, IntPtr @event) {
            var self = (CfxDomEventListener)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxDomEventListenerHandleEventEventArgs(@event);
            var eventHandler = self.m_HandleEvent;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_event_wrapped == null) {
                CfxApi.cfx_release(e.m_event);
            } else {
                e.m_event_wrapped.Dispose();
            }
        }

        internal CfxDomEventListener(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDomEventListener() : base(CfxApi.cfx_domevent_listener_ctor) {}

        /// <summary>
        /// Called when an event is received. The event object passed to this function
        /// contains a snapshot of the DOM at the time this function is executed. DOM
        /// objects are only valid for the scope of this function. Do not keep
        /// references to or attempt to access any DOM objects outside the scope of
        /// this function.
        /// </summary>
        public event CfxDomEventListenerHandleEventEventHandler HandleEvent {
            add {
                if(m_HandleEvent == null) {
                    CfxApi.cfx_domevent_listener_activate_callback(NativePtr, 0, 1);
                }
                m_HandleEvent += value;
            }
            remove {
                m_HandleEvent -= value;
                if(m_HandleEvent == null) {
                    CfxApi.cfx_domevent_listener_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxDomEventListenerHandleEventEventHandler m_HandleEvent;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_HandleEvent != null) {
                m_HandleEvent = null;
                CfxApi.cfx_domevent_listener_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    public delegate void CfxDomEventListenerHandleEventEventHandler(object sender, CfxDomEventListenerHandleEventEventArgs e);

    /// <summary>
    /// Called when an event is received. The event object passed to this function
    /// contains a snapshot of the DOM at the time this function is executed. DOM
    /// objects are only valid for the scope of this function. Do not keep
    /// references to or attempt to access any DOM objects outside the scope of
    /// this function.
    /// </summary>
    public class CfxDomEventListenerHandleEventEventArgs : CfxEventArgs {

        internal IntPtr m_event;
        internal CfxDomEvent m_event_wrapped;

        internal CfxDomEventListenerHandleEventEventArgs(IntPtr @event) {
            m_event = @event;
        }

        public CfxDomEvent Event {
            get {
                CheckAccess();
                if(m_event_wrapped == null) m_event_wrapped = CfxDomEvent.Wrap(m_event);
                return m_event_wrapped;
            }
        }

        public override string ToString() {
            return String.Format("Event={{{0}}}", Event);
        }
    }

}
