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
    using Event;

    /// <summary>
    /// Structure used to implement render process callbacks. The functions of this
    /// structure will be called on the render process main thread (TID_RENDERER)
    /// unless otherwise indicated.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
    /// </remarks>
    public class CfrRenderProcessHandler : CfrClientBase {

        internal static CfrRenderProcessHandler Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrRenderProcessHandler)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrRenderProcessHandler(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static RemotePtr CreateRemote() {
            var call = new CfxRenderProcessHandlerCtorRemoteCall();
            call.RequestExecution();
            return new RemotePtr(call.__retval);
        }

        internal void raise_OnRenderThreadCreated(object sender, CfrOnRenderThreadCreatedEventArgs e) {
            var handler = m_OnRenderThreadCreated;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnWebKitInitialized(object sender, CfrEventArgs e) {
            var handler = m_OnWebKitInitialized;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnBrowserCreated(object sender, CfrOnBrowserCreatedEventArgs e) {
            var handler = m_OnBrowserCreated;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnBrowserDestroyed(object sender, CfrOnBrowserDestroyedEventArgs e) {
            var handler = m_OnBrowserDestroyed;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_GetLoadHandler(object sender, CfrGetLoadHandlerEventArgs e) {
            var handler = m_GetLoadHandler;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnBeforeNavigation(object sender, CfrOnBeforeNavigationEventArgs e) {
            var handler = m_OnBeforeNavigation;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnContextCreated(object sender, CfrOnContextCreatedEventArgs e) {
            var handler = m_OnContextCreated;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnContextReleased(object sender, CfrOnContextReleasedEventArgs e) {
            var handler = m_OnContextReleased;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnUncaughtException(object sender, CfrOnUncaughtExceptionEventArgs e) {
            var handler = m_OnUncaughtException;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnFocusedNodeChanged(object sender, CfrOnFocusedNodeChangedEventArgs e) {
            var handler = m_OnFocusedNodeChanged;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }

        internal void raise_OnProcessMessageReceived(object sender, CfrOnProcessMessageReceivedEventArgs e) {
            var handler = m_OnProcessMessageReceived;
            if(handler == null) return;
            handler(this, e);
            e.m_isInvalid = true;
        }


        private CfrRenderProcessHandler(RemotePtr remotePtr) : base(remotePtr) {}
        public CfrRenderProcessHandler() : base(CreateRemote()) {
            RemotePtr.connection.weakCache.Add(RemotePtr.ptr, this);
        }

        /// <summary>
        /// Called after the render process main thread has been created. |ExtraInfo|
        /// is a read-only value originating from
        /// CfrBrowserProcessHandler.OnRenderProcessThreadCreated(). Do not
        /// keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnRenderThreadCreatedEventHandler OnRenderThreadCreated {
            add {
                if(m_OnRenderThreadCreated == null) {
                    var call = new CfxOnRenderThreadCreatedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnRenderThreadCreated += value;
            }
            remove {
                m_OnRenderThreadCreated -= value;
                if(m_OnRenderThreadCreated == null) {
                    var call = new CfxOnRenderThreadCreatedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnRenderThreadCreatedEventHandler m_OnRenderThreadCreated;


        /// <summary>
        /// Called after WebKit has been initialized.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrEventHandler OnWebKitInitialized {
            add {
                if(m_OnWebKitInitialized == null) {
                    var call = new CfxOnWebKitInitializedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnWebKitInitialized += value;
            }
            remove {
                m_OnWebKitInitialized -= value;
                if(m_OnWebKitInitialized == null) {
                    var call = new CfxOnWebKitInitializedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrEventHandler m_OnWebKitInitialized;


        /// <summary>
        /// Called after a browser has been created. When browsing cross-origin a new
        /// browser will be created before the old browser with the same identifier is
        /// destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnBrowserCreatedEventHandler OnBrowserCreated {
            add {
                if(m_OnBrowserCreated == null) {
                    var call = new CfxOnBrowserCreatedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnBrowserCreated += value;
            }
            remove {
                m_OnBrowserCreated -= value;
                if(m_OnBrowserCreated == null) {
                    var call = new CfxOnBrowserCreatedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnBrowserCreatedEventHandler m_OnBrowserCreated;


        /// <summary>
        /// Called before a browser is destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnBrowserDestroyedEventHandler OnBrowserDestroyed {
            add {
                if(m_OnBrowserDestroyed == null) {
                    var call = new CfxOnBrowserDestroyedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnBrowserDestroyed += value;
            }
            remove {
                m_OnBrowserDestroyed -= value;
                if(m_OnBrowserDestroyed == null) {
                    var call = new CfxOnBrowserDestroyedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnBrowserDestroyedEventHandler m_OnBrowserDestroyed;


        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrGetLoadHandlerEventHandler GetLoadHandler {
            add {
                if(m_GetLoadHandler == null) {
                    var call = new CfxGetLoadHandlerActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_GetLoadHandler += value;
            }
            remove {
                m_GetLoadHandler -= value;
                if(m_GetLoadHandler == null) {
                    var call = new CfxGetLoadHandlerDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrGetLoadHandlerEventHandler m_GetLoadHandler;


        /// <summary>
        /// Called before browser navigation. Return true (1) to cancel the navigation
        /// or false (0) to allow the navigation to proceed. The |Request| object
        /// cannot be modified in this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnBeforeNavigationEventHandler OnBeforeNavigation {
            add {
                if(m_OnBeforeNavigation == null) {
                    var call = new CfxOnBeforeNavigationActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnBeforeNavigation += value;
            }
            remove {
                m_OnBeforeNavigation -= value;
                if(m_OnBeforeNavigation == null) {
                    var call = new CfxOnBeforeNavigationDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnBeforeNavigationEventHandler m_OnBeforeNavigation;


        /// <summary>
        /// Called immediately after the V8 context for a frame has been created. To
        /// retrieve the JavaScript 'window' object use the
        /// CfrV8Context.GetGlobal() function. V8 handles can only be accessed
        /// from the thread on which they are created. A task runner for posting tasks
        /// on the associated thread can be retrieved via the
        /// CfrV8Context.GetTaskRunner() function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnContextCreatedEventHandler OnContextCreated {
            add {
                if(m_OnContextCreated == null) {
                    var call = new CfxOnContextCreatedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnContextCreated += value;
            }
            remove {
                m_OnContextCreated -= value;
                if(m_OnContextCreated == null) {
                    var call = new CfxOnContextCreatedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnContextCreatedEventHandler m_OnContextCreated;


        /// <summary>
        /// Called immediately before the V8 context for a frame is released. No
        /// references to the context should be kept after this function is called.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnContextReleasedEventHandler OnContextReleased {
            add {
                if(m_OnContextReleased == null) {
                    var call = new CfxOnContextReleasedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnContextReleased += value;
            }
            remove {
                m_OnContextReleased -= value;
                if(m_OnContextReleased == null) {
                    var call = new CfxOnContextReleasedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnContextReleasedEventHandler m_OnContextReleased;


        /// <summary>
        /// Called for global uncaught exceptions in a frame. Execution of this
        /// callback is disabled by default. To enable set
        /// CfrSettings.UncaughtExceptionStackSize > 0.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnUncaughtExceptionEventHandler OnUncaughtException {
            add {
                if(m_OnUncaughtException == null) {
                    var call = new CfxOnUncaughtExceptionActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnUncaughtException += value;
            }
            remove {
                m_OnUncaughtException -= value;
                if(m_OnUncaughtException == null) {
                    var call = new CfxOnUncaughtExceptionDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnUncaughtExceptionEventHandler m_OnUncaughtException;


        /// <summary>
        /// Called when a new node in the the browser gets focus. The |Node| value may
        /// be NULL if no specific node has gained focus. The node object passed to
        /// this function represents a snapshot of the DOM at the time this function is
        /// executed. DOM objects are only valid for the scope of this function. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnFocusedNodeChangedEventHandler OnFocusedNodeChanged {
            add {
                if(m_OnFocusedNodeChanged == null) {
                    var call = new CfxOnFocusedNodeChangedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnFocusedNodeChanged += value;
            }
            remove {
                m_OnFocusedNodeChanged -= value;
                if(m_OnFocusedNodeChanged == null) {
                    var call = new CfxOnFocusedNodeChangedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnFocusedNodeChangedEventHandler m_OnFocusedNodeChanged;


        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public event CfrOnProcessMessageReceivedEventHandler OnProcessMessageReceived {
            add {
                if(m_OnProcessMessageReceived == null) {
                    var call = new CfxOnProcessMessageReceivedActivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
                m_OnProcessMessageReceived += value;
            }
            remove {
                m_OnProcessMessageReceived -= value;
                if(m_OnProcessMessageReceived == null) {
                    var call = new CfxOnProcessMessageReceivedDeactivateRemoteCall();
                    call.sender = RemotePtr.ptr;
                    call.RequestExecution(RemotePtr.connection);
                }
            }
        }

        CfrOnProcessMessageReceivedEventHandler m_OnProcessMessageReceived;


    }

    namespace Event {

        /// <summary>
        /// Called after the render process main thread has been created. |ExtraInfo|
        /// is a read-only value originating from
        /// CfrBrowserProcessHandler.OnRenderProcessThreadCreated(). Do not
        /// keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnRenderThreadCreatedEventHandler(object sender, CfrOnRenderThreadCreatedEventArgs e);

        /// <summary>
        /// Called after the render process main thread has been created. |ExtraInfo|
        /// is a read-only value originating from
        /// CfrBrowserProcessHandler.OnRenderProcessThreadCreated(). Do not
        /// keep a reference to |ExtraInfo| outside of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnRenderThreadCreatedEventArgs : CfrEventArgs {

            bool ExtraInfoFetched;
            CfrListValue m_ExtraInfo;

            internal CfrOnRenderThreadCreatedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the ExtraInfo parameter for the <see cref="CfrRenderProcessHandler.OnRenderThreadCreated"/> render process callback.
            /// </summary>
            public CfrListValue ExtraInfo {
                get {
                    CheckAccess();
                    if(!ExtraInfoFetched) {
                        ExtraInfoFetched = true;
                        var call = new CfxOnRenderThreadCreatedGetExtraInfoRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_ExtraInfo = CfrListValue.Wrap(new RemotePtr(call.value));
                    }
                    return m_ExtraInfo;
                }
            }

            public override string ToString() {
                return String.Format("ExtraInfo={{{0}}}", ExtraInfo);
            }
        }


        /// <summary>
        /// Called after a browser has been created. When browsing cross-origin a new
        /// browser will be created before the old browser with the same identifier is
        /// destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnBrowserCreatedEventHandler(object sender, CfrOnBrowserCreatedEventArgs e);

        /// <summary>
        /// Called after a browser has been created. When browsing cross-origin a new
        /// browser will be created before the old browser with the same identifier is
        /// destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnBrowserCreatedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;

            internal CfrOnBrowserCreatedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnBrowserCreated"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnBrowserCreatedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

        /// <summary>
        /// Called before a browser is destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnBrowserDestroyedEventHandler(object sender, CfrOnBrowserDestroyedEventArgs e);

        /// <summary>
        /// Called before a browser is destroyed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnBrowserDestroyedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;

            internal CfrOnBrowserDestroyedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnBrowserDestroyed"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnBrowserDestroyedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrGetLoadHandlerEventHandler(object sender, CfrGetLoadHandlerEventArgs e);

        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrGetLoadHandlerEventArgs : CfrEventArgs {


            private bool returnValueSet;

            internal CfrGetLoadHandlerEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Set the return value for the <see cref="CfrRenderProcessHandler.GetLoadHandler"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(CfrLoadHandler returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxGetLoadHandlerSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = CfrObject.Unwrap(returnValue).ptr;
                call.RequestExecution();
                returnValueSet = true;
            }
        }

        /// <summary>
        /// Called before browser navigation. Return true (1) to cancel the navigation
        /// or false (0) to allow the navigation to proceed. The |Request| object
        /// cannot be modified in this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnBeforeNavigationEventHandler(object sender, CfrOnBeforeNavigationEventArgs e);

        /// <summary>
        /// Called before browser navigation. Return true (1) to cancel the navigation
        /// or false (0) to allow the navigation to proceed. The |Request| object
        /// cannot be modified in this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnBeforeNavigationEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool RequestFetched;
            CfrRequest m_Request;
            bool NavigationTypeFetched;
            CfxNavigationType m_NavigationType;
            bool IsRedirectFetched;
            bool m_IsRedirect;

            private bool returnValueSet;

            internal CfrOnBeforeNavigationEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnBeforeNavigationGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the Frame parameter for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// </summary>
            public CfrFrame Frame {
                get {
                    CheckAccess();
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnBeforeNavigationGetFrameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Frame = CfrFrame.Wrap(new RemotePtr(call.value));
                    }
                    return m_Frame;
                }
            }
            /// <summary>
            /// Get the Request parameter for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// </summary>
            public CfrRequest Request {
                get {
                    CheckAccess();
                    if(!RequestFetched) {
                        RequestFetched = true;
                        var call = new CfxOnBeforeNavigationGetRequestRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Request = CfrRequest.Wrap(new RemotePtr(call.value));
                    }
                    return m_Request;
                }
            }
            /// <summary>
            /// Get the NavigationType parameter for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// </summary>
            public CfxNavigationType NavigationType {
                get {
                    CheckAccess();
                    if(!NavigationTypeFetched) {
                        NavigationTypeFetched = true;
                        var call = new CfxOnBeforeNavigationGetNavigationTypeRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_NavigationType = (CfxNavigationType)call.value;
                    }
                    return m_NavigationType;
                }
            }
            /// <summary>
            /// Get the IsRedirect parameter for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// </summary>
            public bool IsRedirect {
                get {
                    CheckAccess();
                    if(!IsRedirectFetched) {
                        IsRedirectFetched = true;
                        var call = new CfxOnBeforeNavigationGetIsRedirectRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_IsRedirect = call.value;
                    }
                    return m_IsRedirect;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrRenderProcessHandler.OnBeforeNavigation"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxOnBeforeNavigationSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}, NavigationType={{{3}}}, IsRedirect={{{4}}}", Browser, Frame, Request, NavigationType, IsRedirect);
            }
        }

        /// <summary>
        /// Called immediately after the V8 context for a frame has been created. To
        /// retrieve the JavaScript 'window' object use the
        /// CfrV8Context.GetGlobal() function. V8 handles can only be accessed
        /// from the thread on which they are created. A task runner for posting tasks
        /// on the associated thread can be retrieved via the
        /// CfrV8Context.GetTaskRunner() function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnContextCreatedEventHandler(object sender, CfrOnContextCreatedEventArgs e);

        /// <summary>
        /// Called immediately after the V8 context for a frame has been created. To
        /// retrieve the JavaScript 'window' object use the
        /// CfrV8Context.GetGlobal() function. V8 handles can only be accessed
        /// from the thread on which they are created. A task runner for posting tasks
        /// on the associated thread can be retrieved via the
        /// CfrV8Context.GetTaskRunner() function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnContextCreatedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool ContextFetched;
            CfrV8Context m_Context;

            internal CfrOnContextCreatedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnContextCreated"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnContextCreatedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the Frame parameter for the <see cref="CfrRenderProcessHandler.OnContextCreated"/> render process callback.
            /// </summary>
            public CfrFrame Frame {
                get {
                    CheckAccess();
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnContextCreatedGetFrameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Frame = CfrFrame.Wrap(new RemotePtr(call.value));
                    }
                    return m_Frame;
                }
            }
            /// <summary>
            /// Get the Context parameter for the <see cref="CfrRenderProcessHandler.OnContextCreated"/> render process callback.
            /// </summary>
            public CfrV8Context Context {
                get {
                    CheckAccess();
                    if(!ContextFetched) {
                        ContextFetched = true;
                        var call = new CfxOnContextCreatedGetContextRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Context = CfrV8Context.Wrap(new RemotePtr(call.value));
                    }
                    return m_Context;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}", Browser, Frame, Context);
            }
        }

        /// <summary>
        /// Called immediately before the V8 context for a frame is released. No
        /// references to the context should be kept after this function is called.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnContextReleasedEventHandler(object sender, CfrOnContextReleasedEventArgs e);

        /// <summary>
        /// Called immediately before the V8 context for a frame is released. No
        /// references to the context should be kept after this function is called.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnContextReleasedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool ContextFetched;
            CfrV8Context m_Context;

            internal CfrOnContextReleasedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnContextReleased"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnContextReleasedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the Frame parameter for the <see cref="CfrRenderProcessHandler.OnContextReleased"/> render process callback.
            /// </summary>
            public CfrFrame Frame {
                get {
                    CheckAccess();
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnContextReleasedGetFrameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Frame = CfrFrame.Wrap(new RemotePtr(call.value));
                    }
                    return m_Frame;
                }
            }
            /// <summary>
            /// Get the Context parameter for the <see cref="CfrRenderProcessHandler.OnContextReleased"/> render process callback.
            /// </summary>
            public CfrV8Context Context {
                get {
                    CheckAccess();
                    if(!ContextFetched) {
                        ContextFetched = true;
                        var call = new CfxOnContextReleasedGetContextRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Context = CfrV8Context.Wrap(new RemotePtr(call.value));
                    }
                    return m_Context;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}", Browser, Frame, Context);
            }
        }

        /// <summary>
        /// Called for global uncaught exceptions in a frame. Execution of this
        /// callback is disabled by default. To enable set
        /// CfrSettings.UncaughtExceptionStackSize > 0.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnUncaughtExceptionEventHandler(object sender, CfrOnUncaughtExceptionEventArgs e);

        /// <summary>
        /// Called for global uncaught exceptions in a frame. Execution of this
        /// callback is disabled by default. To enable set
        /// CfrSettings.UncaughtExceptionStackSize > 0.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnUncaughtExceptionEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool ContextFetched;
            CfrV8Context m_Context;
            bool ExceptionFetched;
            CfrV8Exception m_Exception;
            bool StackTraceFetched;
            CfrV8StackTrace m_StackTrace;

            internal CfrOnUncaughtExceptionEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnUncaughtException"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnUncaughtExceptionGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the Frame parameter for the <see cref="CfrRenderProcessHandler.OnUncaughtException"/> render process callback.
            /// </summary>
            public CfrFrame Frame {
                get {
                    CheckAccess();
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnUncaughtExceptionGetFrameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Frame = CfrFrame.Wrap(new RemotePtr(call.value));
                    }
                    return m_Frame;
                }
            }
            /// <summary>
            /// Get the Context parameter for the <see cref="CfrRenderProcessHandler.OnUncaughtException"/> render process callback.
            /// </summary>
            public CfrV8Context Context {
                get {
                    CheckAccess();
                    if(!ContextFetched) {
                        ContextFetched = true;
                        var call = new CfxOnUncaughtExceptionGetContextRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Context = CfrV8Context.Wrap(new RemotePtr(call.value));
                    }
                    return m_Context;
                }
            }
            /// <summary>
            /// Get the Exception parameter for the <see cref="CfrRenderProcessHandler.OnUncaughtException"/> render process callback.
            /// </summary>
            public CfrV8Exception Exception {
                get {
                    CheckAccess();
                    if(!ExceptionFetched) {
                        ExceptionFetched = true;
                        var call = new CfxOnUncaughtExceptionGetExceptionRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Exception = CfrV8Exception.Wrap(new RemotePtr(call.value));
                    }
                    return m_Exception;
                }
            }
            /// <summary>
            /// Get the StackTrace parameter for the <see cref="CfrRenderProcessHandler.OnUncaughtException"/> render process callback.
            /// </summary>
            public CfrV8StackTrace StackTrace {
                get {
                    CheckAccess();
                    if(!StackTraceFetched) {
                        StackTraceFetched = true;
                        var call = new CfxOnUncaughtExceptionGetStackTraceRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_StackTrace = CfrV8StackTrace.Wrap(new RemotePtr(call.value));
                    }
                    return m_StackTrace;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}, Exception={{{3}}}, StackTrace={{{4}}}", Browser, Frame, Context, Exception, StackTrace);
            }
        }

        /// <summary>
        /// Called when a new node in the the browser gets focus. The |Node| value may
        /// be NULL if no specific node has gained focus. The node object passed to
        /// this function represents a snapshot of the DOM at the time this function is
        /// executed. DOM objects are only valid for the scope of this function. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnFocusedNodeChangedEventHandler(object sender, CfrOnFocusedNodeChangedEventArgs e);

        /// <summary>
        /// Called when a new node in the the browser gets focus. The |Node| value may
        /// be NULL if no specific node has gained focus. The node object passed to
        /// this function represents a snapshot of the DOM at the time this function is
        /// executed. DOM objects are only valid for the scope of this function. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnFocusedNodeChangedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool FrameFetched;
            CfrFrame m_Frame;
            bool NodeFetched;
            CfrDomNode m_Node;

            internal CfrOnFocusedNodeChangedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnFocusedNodeChanged"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnFocusedNodeChangedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the Frame parameter for the <see cref="CfrRenderProcessHandler.OnFocusedNodeChanged"/> render process callback.
            /// </summary>
            public CfrFrame Frame {
                get {
                    CheckAccess();
                    if(!FrameFetched) {
                        FrameFetched = true;
                        var call = new CfxOnFocusedNodeChangedGetFrameRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Frame = CfrFrame.Wrap(new RemotePtr(call.value));
                    }
                    return m_Frame;
                }
            }
            /// <summary>
            /// Get the Node parameter for the <see cref="CfrRenderProcessHandler.OnFocusedNodeChanged"/> render process callback.
            /// </summary>
            public CfrDomNode Node {
                get {
                    CheckAccess();
                    if(!NodeFetched) {
                        NodeFetched = true;
                        var call = new CfxOnFocusedNodeChangedGetNodeRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Node = CfrDomNode.Wrap(new RemotePtr(call.value));
                    }
                    return m_Node;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Frame={{{1}}}, Node={{{2}}}", Browser, Frame, Node);
            }
        }

        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfrOnProcessMessageReceivedEventHandler(object sender, CfrOnProcessMessageReceivedEventArgs e);

        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_render_process_handler_capi.h">cef/include/capi/cef_render_process_handler_capi.h</see>.
        /// </remarks>
        public class CfrOnProcessMessageReceivedEventArgs : CfrEventArgs {

            bool BrowserFetched;
            CfrBrowser m_Browser;
            bool SourceProcessFetched;
            CfxProcessId m_SourceProcess;
            bool MessageFetched;
            CfrProcessMessage m_Message;

            private bool returnValueSet;

            internal CfrOnProcessMessageReceivedEventArgs(ulong eventArgsId) : base(eventArgsId) {}

            /// <summary>
            /// Get the Browser parameter for the <see cref="CfrRenderProcessHandler.OnProcessMessageReceived"/> render process callback.
            /// </summary>
            public CfrBrowser Browser {
                get {
                    CheckAccess();
                    if(!BrowserFetched) {
                        BrowserFetched = true;
                        var call = new CfxOnProcessMessageReceivedGetBrowserRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Browser = CfrBrowser.Wrap(new RemotePtr(call.value));
                    }
                    return m_Browser;
                }
            }
            /// <summary>
            /// Get the SourceProcess parameter for the <see cref="CfrRenderProcessHandler.OnProcessMessageReceived"/> render process callback.
            /// </summary>
            public CfxProcessId SourceProcess {
                get {
                    CheckAccess();
                    if(!SourceProcessFetched) {
                        SourceProcessFetched = true;
                        var call = new CfxOnProcessMessageReceivedGetSourceProcessRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_SourceProcess = (CfxProcessId)call.value;
                    }
                    return m_SourceProcess;
                }
            }
            /// <summary>
            /// Get the Message parameter for the <see cref="CfrRenderProcessHandler.OnProcessMessageReceived"/> render process callback.
            /// </summary>
            public CfrProcessMessage Message {
                get {
                    CheckAccess();
                    if(!MessageFetched) {
                        MessageFetched = true;
                        var call = new CfxOnProcessMessageReceivedGetMessageRemoteCall();
                        call.eventArgsId = eventArgsId;
                        call.RequestExecution();
                        m_Message = CfrProcessMessage.Wrap(new RemotePtr(call.value));
                    }
                    return m_Message;
                }
            }
            /// <summary>
            /// Set the return value for the <see cref="CfrRenderProcessHandler.OnProcessMessageReceived"/> render process callback.
            /// Calling SetReturnValue() more then once per callback or from different event handlers will cause an exception to be thrown.
            /// </summary>
            public void SetReturnValue(bool returnValue) {
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                var call = new CfxOnProcessMessageReceivedSetReturnValueRemoteCall();
                call.eventArgsId = eventArgsId;
                call.value = returnValue;
                call.RequestExecution();
                returnValueSet = true;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, SourceProcess={{{1}}}, Message={{{2}}}", Browser, SourceProcess, Message);
            }
        }

    }
}
