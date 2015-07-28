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
using System.Collections.Generic;
using System.Diagnostics;
using Chromium.Remote;

namespace Chromium {

    /// <summary>
    /// Delegate for the entry callback of the render process remote layer.
    /// </summary>
    /// <returns></returns>
    public delegate int CfxRenderProcessMainDelegate();

    /// <summary>
    /// Represents the context of a remote render process. Unless in the scope of a 
    /// remote callback event, a context must be explicitly entered before calling 
    /// constructors or static members on remote (Cfr*) classes. In the scope of a 
    /// remote callback event, the executing thread is always in the context of the
    /// render process which originated the callback.
    /// </summary>
    public class CfxRemoteContext {

        /// <summary>
        /// Indicates if the remoting framework is initialized. The remoting framework is
        /// initialized if CfxRuntime.Initialize has been called with a valid
        /// render process main callback. 
        /// </summary>
        public static bool RemotingInitialized {
            get { return RemoteService.renderProcessMainCallback != null; }
        }

        


        internal readonly RemoteConnection connection;

        internal CfxRemoteContext(RemoteConnection connection) {
            this.connection = connection;
        }


        [ThreadStatic]
        private static Stack<CfxRemoteContext> contextStack;

        /// <summary>
        /// Enter the context of a remote render process. Calls to Enter()/Exit() 
        /// must be balanced. Use try/finally constructs to make sure that 
        /// Exit() is called the same number of times as Enter().
        /// </summary>
        public void Enter() {
            if(contextStack == null) contextStack = new Stack<CfxRemoteContext>();
            contextStack.Push(this);
        }

        /// <summary>
        /// Exit the context of a remote render process. Throws an exception if the 
        /// calling thread is not currently in this remote context.
        /// </summary>
        public void Exit() {
            if(contextStack == null || contextStack.Count == 0 || this != contextStack.Peek())
                throw new CfxException("The calling thread is not currently in this remote context");
            contextStack.Pop();
        }

        /// <summary>
        /// Returns the current remote context for the calling thread. Throws an exception if the 
        /// calling thread is not currently in the context of a remote render process.
        /// </summary>
        public static CfxRemoteContext CurrentContext {
            get {
                if(contextStack != null && contextStack.Count > 0)
                    return contextStack.Peek();
                else
                    throw new CfxException("The calling thread is not currently in the context of a remote render process");
            }
        }

        /// <summary>
        /// True if the calling thread is currently in the context of a remote render process, false otherwise.
        /// </summary>
        public static bool IsInContext {
            get {
                return contextStack != null && contextStack.Count > 0;
            }
        }

        internal static int ContextStackCount {
            get {
                return contextStack == null ? 0 : contextStack.Count;
            }
        }

        internal static void ResetContextStackTo(int count) {
            if(contextStack == null) return;
            while(contextStack.Count > count)
                contextStack.Pop();
        }


        /// <summary>
        /// Thread-relative static property indicating the thread id of an affine thread
        /// in the remote process. Zero if the calling thread has no affinity with a remote thread.
        /// </summary>
        public static int RemoteThreadId {
            get { return remoteThreadId; }
        }

        /// <summary>
        /// Set thread-relative affinity to a thread in the remote process.
        /// Use with care, if the identified remote thread does not exist or is not 
        /// waiting on the remote call interface, then the behaviour is undefined.
        /// Use try/finally to make sure the thread calls SetThreadAffinity(0) when it's 
        /// done calling into the render process on behalf of the identified thread.
        /// Typical use case: marshal an Invoke call to the render thread.
        /// </summary>
        /// <param name="remoteThreadId"></param>
        public static void SetThreadAffinity(int remoteThreadId) {

            if(CfxRemoteContext.remoteThreadId != 0 && !threadAffinityIsExternal)
                throw new CfxException("Can's set thread affinity on a framework provided thread.");

            threadAffinityIsExternal = true;
            CfxRemoteContext.remoteThreadId = remoteThreadId;

        }

        [ThreadStatic]
        internal static int remoteThreadId;

        [ThreadStatic]
        internal static bool threadAffinityIsExternal;

    }
}
