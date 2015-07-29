using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Chromium {
    
    /// <summary>
    /// Represents the context of a remote thread in the render process. In the scope of a 
    /// remote callback event, the executing thread is always in the context of the
    /// render process thread which originated the callback. This is used for
    /// correct marshaling of remote calls within the scope of an invoked method.
    /// </summary>
    public class CfxRemoteThreadContext {

        internal static int currentThreadId {
            get {
                if(IsInContext)
                    return CurrentContext.ThreadId;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Represents the remote context of the render process this thread context belongs to.
        /// </summary>
        public CfxRemoteProcessContext RemoteProcess { get; private set; }

        /// <summary>
        /// The managed thread id of the remote thread.
        /// </summary>
        public int ThreadId { get; private set; }

        internal CfxRemoteThreadContext(CfxRemoteProcessContext remoteProcess, int threadId) {
            RemoteProcess = remoteProcess;
            ThreadId = threadId;
        }


        [ThreadStatic]
        private static Stack<CfxRemoteThreadContext> contextStack;

        /// <summary>
        /// Enter the context of a remote thread. Calls to Enter()/Exit() 
        /// must be balanced. Use try/finally constructs to make sure that 
        /// Exit() is called the same number of times as Enter().
        /// By entering a context, the thread also enters the associated
        /// remote process context.
        /// </summary>
        public void Enter() {
            RemoteProcess.Enter();
            if(contextStack == null) contextStack = new Stack<CfxRemoteThreadContext>();
            contextStack.Push(this);
        }

        /// <summary>
        /// Exit the context of a remote thread. Throws an exception if the 
        /// calling thread is not currently in this remote thread context.
        /// By exiting a context, the thread also exits the associated
        /// remote process context.
        /// </summary>
        public void Exit() {
            RemoteProcess.Exit();
            if(contextStack == null || contextStack.Count == 0 || this != contextStack.Peek())
                throw new CfxException("The calling thread is not currently in this remote thread context");
            contextStack.Pop();
        }

        /// <summary>
        /// Returns the current remote thread context for the calling thread. Throws an exception if the 
        /// calling thread is not currently in the context of a remote thread.
        /// </summary>
        public static CfxRemoteThreadContext CurrentContext {
            get {
                if(contextStack != null && contextStack.Count > 0)
                    return contextStack.Peek();
                else
                    throw new CfxException("The calling thread is not currently in the context of a remote thread");
            }
        }

        /// <summary>
        /// True if the calling thread is currently in the context of a remote thread, false otherwise.
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

        internal static void resetStack(int count) {
            if(contextStack == null) return;
            while(contextStack.Count > count)
                contextStack.Pop();
        }
    }
}
