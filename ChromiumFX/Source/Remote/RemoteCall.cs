// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Diagnostics;
using System.Threading;

namespace Chromium.Remote {
    internal abstract class RemoteCall {

        private readonly RemoteCallId callId;
        private readonly bool returnImmediately;

        internal readonly object waitLock = new object();

        private RemoteCall reentryCall;

        internal int localThreadId;
        private int remoteThreadId;

        private bool responseReceived;

        internal RemoteCall(RemoteCallId callId) {
            this.callId = callId;
            this.returnImmediately = false;
        }

        internal RemoteCall(RemoteCallId callId, bool returnImmediately) {
            this.callId = callId;
            this.returnImmediately = returnImmediately;
        }


        internal void RequestExecution() {
            RequestExecution(CfxRemoteCallContext.CurrentContext.connection);
        }

        internal void RequestExecution(RemoteConnection connection) {
            
            if(CfxRemoteCallContext.IsInContext && CfxRemoteCallContext.CurrentContext.connection != connection) {
                // The thread is in a remote call context, but the requestor wants to call
                // on another connection. This can happen if a CfrObject method from one connection
                // is used within the scope of a callback from another connection.
                // In this case, the call has to be made in a temporary context with remote thread id zero.
                var ctx = new CfxRemoteCallContext(connection, 0);
                ctx.Enter();
                try {
                    RequestExecution(connection);
                } finally {
                    ctx.Exit();
                }
                return;
            }

            if(returnImmediately) {
                if(connection.ShuttingDown)
                    return;
                else if(connection.connectionLostException != null)
                    throw new CfxRemotingException("Remote connection lost.", connection.connectionLostException);
                connection.Write(WriteRequest);
                return;
            }


            lock(waitLock) {

                // The lock must begin here. Otherwise,
                // there is a race between Wait and PulseAll
                // causing this thread to wait forever
                // under some circumstances.

                localThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
                connection.callStack.Push(this);

                remoteThreadId = CfxRemoteCallContext.currentThreadId;

                connection.Write(WriteRequest);

                for(; ; ) {

                    if(responseReceived) {
                        Debug.Assert(reentryCall == null);
                        return;
                    }

                    if(this.reentryCall != null) {
                        reentryCall.ExecutionThreadEntry(connection);
                        reentryCall = null;
                    }

                    if(!connection.ShuttingDown && connection.connectionLostException == null)
                        System.Threading.Monitor.Wait(waitLock);

                    if(connection.ShuttingDown)
                        return;
                    else if(connection.connectionLostException != null) {
                        if(RemoteClient.connection != null) {
                            // this is the render process calling back into the browser process
                            // reaching this point usually means the browser process crashed or was killed
                            // don't throw, just return so the process can exit gracefully
                            return;
                        }
                        throw new CfxRemotingException("Remote connection lost.", connection.connectionLostException);
                    }
                }
            }
        }


        internal void WriteRequest(StreamHandler h) {
            h.Write((ushort)callId);
            if(!returnImmediately) {
                h.Write(localThreadId);
                h.Write(remoteThreadId);
            }
            WriteArgs(h);
            h.Flush();
        }

        internal void ReadRequest(RemoteConnection connection) {

            if(returnImmediately) {
                ReadArgs(connection.streamHandler);
                WorkerPool.EnqueueTask(() => ExecutionThreadEntry(connection));
                return;
            }

            var h = connection.streamHandler;

            h.Read(out remoteThreadId);
            h.Read(out localThreadId);
            ReadArgs(h);

            if(localThreadId != 0) {
                var call = connection.callStack.Peek(localThreadId);
                lock(call.waitLock) {
                    call.reentryCall = this;
                    System.Threading.Monitor.PulseAll(call.waitLock);
                }
            } else {
                WorkerPool.EnqueueTask(() => ExecutionThreadEntry(connection));
            }
        }

        internal void WriteResponse(StreamHandler h) {
            h.Write(ushort.MaxValue);
            h.Write(remoteThreadId);
            WriteReturn(h);
            h.Flush();
        }

        internal void ReadResponse(StreamHandler h) {
            ReadReturn(h);
            lock(waitLock) {
                responseReceived = true;
                System.Threading.Monitor.PulseAll(waitLock);
            }
        }

        private void ExecutionThreadEntry(RemoteConnection connection) {

            if(returnImmediately) {
                ExecuteInTargetProcess(connection);
                return;
            }

            if(RemoteClient.connection == null) {
                if(!CfxRemoteCallbackManager.IncrementCallbackCount(connection.remoteProcessId)) {
                    // The application has suspended remote callbacks.
                    // Write the response without ececuting event handlers, returning default values.
                    connection.Write(WriteResponse);
                    return;
                }
            }

            var threadContext = new CfxRemoteCallContext(connection, remoteThreadId);
            threadContext.Enter();
            var threadStackCount = CfxRemoteCallContext.ContextStackCount;

            try {
                ExecuteInTargetProcess(connection);
            } finally {
                if(RemoteClient.connection == null) {
                    CfxRemoteCallbackManager.DecrementCallbackCount(connection.remoteProcessId);
                }
                if(threadStackCount != CfxRemoteCallContext.ContextStackCount || CfxRemoteCallContext.CurrentContext != threadContext) {
                    CfxRemoteCallContext.resetStack(threadStackCount - 1);
                    throw new CfxException("Unbalanced remote call context stack. Make sure to balance calls to CfxRemoteCallContext.Enter() and CfxRemoteCallContext.Exit() in all render process callback events.");
                }
                threadContext.Exit();
            }

            connection.Write(WriteResponse);
        }

        protected virtual void WriteArgs(StreamHandler h) { }
        protected virtual void ReadArgs(StreamHandler h) { }

        protected virtual void WriteReturn(StreamHandler h) { }
        protected virtual void ReadReturn(StreamHandler h) { }

        protected abstract void ExecuteInTargetProcess(RemoteConnection connection);

    }
}
