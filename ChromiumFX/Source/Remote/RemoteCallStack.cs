// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Collections.Generic;

namespace Chromium.Remote {
    class RemoteCallStack {

        private readonly Dictionary<int, Stack<RemoteCall>> stacks = new Dictionary<int, Stack<RemoteCall>>();

        internal void Push(RemoteCall call) {
            lock(stacks) {
                Stack<RemoteCall> stack;
                if(!stacks.TryGetValue(call.localThreadId, out stack)) {
                    stack = new Stack<RemoteCall>();
                    stacks.Add(call.localThreadId, stack);
                }
                stack.Push(call);
            }
        }

        internal RemoteCall Peek(int threadId) {
            lock(stacks) {
                return stacks[threadId].Peek();
            }
        }

        internal RemoteCall Pop(int threadId) {
            lock(stacks) {
                return stacks[threadId].Pop();
            }
        }

        internal void ReleaseAll() {
            lock(stacks) {
                foreach(var stack in stacks.Values) {
                    if(stack.Count > 0) {
                        var call = stack.Peek();
                        // Lock with timeout: attempting a simple lock
                        // could hang forever in the browser process
                        // if the render process crashes or hangs.
                        bool lockTaken = false;
                        System.Threading.Monitor.TryEnter(call.waitLock, 100, ref lockTaken);
                        if(lockTaken) {
                            try {
                                System.Threading.Monitor.PulseAll(call.waitLock);
                            } finally {
                                System.Threading.Monitor.Exit(call.waitLock);
                            }
                        }
                    }
                }
            }
        }
    }
}
