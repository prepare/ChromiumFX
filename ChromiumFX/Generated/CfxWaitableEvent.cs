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
    /// WaitableEvent is a thread synchronization tool that allows one thread to wait
    /// for another thread to finish some work. This is equivalent to using a
    /// Lock+ConditionVariable to protect a simple boolean value. However, using
    /// WaitableEvent in conjunction with a Lock to wait for a more complex state
    /// change (e.g., for an item to be added to a queue) is not recommended. In that
    /// case consider using a ConditionVariable instead of a WaitableEvent. It is
    /// safe to create and/or signal a WaitableEvent from any thread. Blocking on a
    /// WaitableEvent by calling the *wait() functions is not allowed on the browser
    /// process UI or IO threads.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
    /// </remarks>
    public class CfxWaitableEvent : CfxLibraryBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxWaitableEvent Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxWaitableEvent)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxWaitableEvent(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxWaitableEvent(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new waitable event. If |automaticReset| is true (1) then the event
        /// state is automatically reset to un-signaled after a single waiting thread has
        /// been released; otherwise, the state remains signaled until reset() is called
        /// manually. If |initiallySignaled| is true (1) then the event will start in
        /// the signaled state.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public static CfxWaitableEvent Create(int automaticReset, int initiallySignaled) {
            return CfxWaitableEvent.Wrap(CfxApi.WaitableEvent.cfx_waitable_event_create(automaticReset, initiallySignaled));
        }

        /// <summary>
        /// Returns true (1) if the event is in the signaled state, else false (0). If
        /// the event was created with |automaticReset| set to true (1) then calling
        /// this function will also cause a reset.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public bool IsSignaled {
            get {
                return 0 != CfxApi.WaitableEvent.cfx_waitable_event_is_signaled(NativePtr);
            }
        }

        /// <summary>
        /// Put the event in the un-signaled state.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public void Reset() {
            CfxApi.WaitableEvent.cfx_waitable_event_reset(NativePtr);
        }

        /// <summary>
        /// Put the event in the signaled state. This causes any thread blocked on Wait
        /// to be woken up.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public void Signal() {
            CfxApi.WaitableEvent.cfx_waitable_event_signal(NativePtr);
        }

        /// <summary>
        /// Wait indefinitely for the event to be signaled. This function will not
        /// return until after the call to signal() has completed. This function cannot
        /// be called on the browser process UI or IO threads.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public void Wait() {
            CfxApi.WaitableEvent.cfx_waitable_event_wait(NativePtr);
        }

        /// <summary>
        /// Wait up to |maxMs| milliseconds for the event to be signaled. Returns true
        /// (1) if the event was signaled. A return value of false (0) does not
        /// necessarily mean that |maxMs| was exceeded. This function will not return
        /// until after the call to signal() has completed. This function cannot be
        /// called on the browser process UI or IO threads.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_waitable_event_capi.h">cef/include/capi/cef_waitable_event_capi.h</see>.
        /// </remarks>
        public bool TimedWait(long maxMs) {
            return 0 != CfxApi.WaitableEvent.cfx_waitable_event_timed_wait(NativePtr, maxMs);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
