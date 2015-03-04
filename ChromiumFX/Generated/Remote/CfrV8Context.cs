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
    /// Structure representing a V8 context handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CfrV8Context.GetTaskRunner() function.
    /// </summary>
    public class CfrV8Context : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrV8Context Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrV8Context)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrV8Context(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Returns the current (top) context object in the V8 context stack.
        /// </summary>
        public static CfrV8Context GetCurrentContext(CfrRuntime remoteRuntime) {
            var call = new CfxV8ContextGetCurrentContextRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrV8Context.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the entered (bottom) context object in the V8 context stack.
        /// </summary>
        public static CfrV8Context GetEnteredContext(CfrRuntime remoteRuntime) {
            var call = new CfxV8ContextGetEnteredContextRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrV8Context.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns true (1) if V8 is currently inside a context.
        /// </summary>
        public static bool InContext(CfrRuntime remoteRuntime) {
            var call = new CfxV8ContextInContextRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }


        private CfrV8Context(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns the task runner associated with this context. V8 handles can only
        /// be accessed from the thread on which they are created. This function can be
        /// called on any render process thread.
        /// </summary>
        public CfrTaskRunner TaskRunner {
            get {
                var call = new CfxV8ContextGetTaskRunnerRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrTaskRunner.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns true (1) if the underlying handle is valid and it can be accessed
        /// on the current thread. Do not call any other functions if this function
        /// returns false (0).
        /// </summary>
        public bool IsValid {
            get {
                var call = new CfxV8ContextIsValidRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the browser for this context. This function will return an NULL
        /// reference for WebWorker contexts.
        /// </summary>
        public CfrBrowser Browser {
            get {
                var call = new CfxV8ContextGetBrowserRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrBrowser.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the frame for this context. This function will return an NULL
        /// reference for WebWorker contexts.
        /// </summary>
        public CfrFrame Frame {
            get {
                var call = new CfxV8ContextGetFrameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrFrame.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this function.
        /// </summary>
        public CfrV8Value Global {
            get {
                var call = new CfxV8ContextGetGlobalRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrV8Value.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Enter this context. A context must be explicitly entered before creating a
        /// V8 Object, Array, Function or Date asynchronously. exit() must be called
        /// the same number of times as enter() before releasing this context. V8
        /// objects belong to the context in which they are created. Returns true (1)
        /// if the scope was entered successfully.
        /// </summary>
        public bool Enter() {
            var call = new CfxV8ContextEnterRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Exit this context. Call this function only after calling enter(). Returns
        /// true (1) if the scope was exited successfully.
        /// </summary>
        public int Exit() {
            var call = new CfxV8ContextExitRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        public bool IsSame(CfrV8Context that) {
            var call = new CfxV8ContextIsSameRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.that = CfrObject.Unwrap(that);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Evaluates the specified JavaScript code using this context's global object.
        /// On success |retval| will be set to the return value, if any, and the
        /// function will return true (1). On failure |exception| will be set to the
        /// exception, if any, and the function will return false (0).
        /// </summary>
        public bool Eval(string code, out CfrV8Value retval, out CfrV8Exception exception) {
            var call = new CfxV8ContextEvalRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.code = code;
            call.Execute(remoteRuntime.connection);
            retval = CfrV8Value.Wrap(call.retval, remoteRuntime);
            exception = CfrV8Exception.Wrap(call.exception, remoteRuntime);
            return call.__retval;
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
