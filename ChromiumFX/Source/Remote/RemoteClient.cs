// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;

namespace Chromium.Remote {

    internal class RemoteClient {

        internal static RemoteConnection connection;

        internal static int ExecuteProcess(string pipeName) {

            //System.Diagnostics.Debugger.Launch();

            var pipeIn = PipeFactory.Instance.CreateClientPipeInputStream(pipeName + "so");
            var pipeOut = PipeFactory.Instance.CreateClientPipeOutputStream(pipeName + "si");

            connection = new RemoteConnection(pipeIn, pipeOut, true);

            var call = new ExecuteProcessRemoteCall();
            call.RequestExecution(connection);
            return call.__retval;

        }
    }

    internal class ExecuteProcessRemoteCall : RemoteCall {

        internal int __retval;

        internal ExecuteProcessRemoteCall() 
            : base(RemoteCallId.ExecuteProcessRemoteCall) { }

        protected override void WriteReturn(StreamHandler h) { h.Write(__retval); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out __retval); }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = RemoteService.renderProcessMainCallback();
        }
    }
}
