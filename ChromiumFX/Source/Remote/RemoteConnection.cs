// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace Chromium.Remote {
    internal class RemoteConnection {


        private readonly Stream pipeIn;
        private readonly Stream pipeOut;
        internal readonly StreamHandler streamHandler;

        internal int localProcessId { get; private set; }
        internal int remoteProcessId { get; private set; }

        private readonly bool isClient;

        private bool connected;
        
        private readonly Thread reader;

        private readonly object syncRoot = new object();

        internal bool ShuttingDown { get; private set; }
        internal Exception connectionLostException { get; private set; }

        internal readonly RemoteCallStack callStack;

        internal readonly RemoteWeakCache weakCache = new RemoteWeakCache();


        internal RemoteConnection(Stream pipeIn, Stream pipeOut, bool isClient) {

            this.pipeIn = pipeIn;
            this.pipeOut = pipeOut;
            this.isClient = isClient;

            localProcessId = Process.GetCurrentProcess().Id;
            callStack = new RemoteCallStack();

            streamHandler = new StreamHandler(pipeIn, pipeOut);

            if(!isClient) {
                CfxRuntime.OnCfxShutdown += new Action(CfxRuntime_OnCfxShutdown);
            }

            reader = new Thread(ReadLoopEntry);
            reader.Name = "cfx_rpc_reader";
            reader.IsBackground = true;
            reader.Start();
        }

        void CfxRuntime_OnCfxShutdown() {
            ShuttingDown = true;
            callStack.ReleaseAll();
            RemoteService.RemoveConnection(this);
        }

        internal void Write(Action<StreamHandler> callback) {
            Monitor.Enter(syncRoot);
            try {
                if(!connected) {
                    Connect(pipeOut);
                    streamHandler.Write(localProcessId);
                    streamHandler.Flush();
                    connected = true;
                }
                callback.Invoke(streamHandler);
            } catch(EndOfStreamException ex) {
                OnConnectionLost(ex);
            } catch(IOException ex) {
                OnConnectionLost(ex);
            } finally {
                Monitor.Exit(syncRoot);
            }
        }

        internal void ReadLoopEntry() {
            try {
                Connect(pipeIn);
                remoteProcessId = streamHandler.ReadInt32();
                ReadLoop();
            } catch(EndOfStreamException ex) {
                OnConnectionLost(ex);
            } catch(IOException ex) {
                OnConnectionLost(ex);
            }
        }

        private void Connect(Stream stream) {
            if(isClient) {
                PipeFactory.Instance.Connect(stream);
            } else {
                PipeFactory.Instance.WaitForConnection(stream);
            }
        }

        private void ReadLoop() {
            for(;;) {
                var callId = streamHandler.ReadUInt16();
                if(callId == ushort.MaxValue) {
                    var threadId = streamHandler.ReadInt32();
                    var call = callStack.Pop(threadId);
                    call.ReadResponse(streamHandler);
                } else {
                    var call = RemoteCallFactory.ForCallId((RemoteCallId)callId);
                    call.ReadRequest(this);
                }
            }
        }


        private void OnConnectionLost(Exception ex) {
            // When a connection is lost, both the 
            // reader and the writer thread can
            // reach this code under some
            // conditions.
            lock(syncRoot) {
                if(connectionLostException != null)
                    return;
                connectionLostException = ex;
                callStack.ReleaseAll();
                if(!isClient) {
                    RemoteService.RemoveConnection(this);
                }
            }
        }
    }
}
