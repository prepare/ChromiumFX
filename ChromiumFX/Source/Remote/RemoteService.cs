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
using System.IO.Pipes;

namespace Chromium.Remote {

    internal class RemoteService {


        internal static CfxRenderProcessStartupDelegate renderProcessStartupCallback;
        internal static readonly List<RemoteConnection> connections = new List<RemoteConnection>();

        public static void Initialize(CfxRenderProcessStartupDelegate renderProcessStartupCallback, CfxBrowserProcessHandler browserProcessHandler) {
            RemoteService.renderProcessStartupCallback = renderProcessStartupCallback;
            browserProcessHandler.OnBeforeChildProcessLaunch += OnBeforeChildProcessLaunch;
        }

        private static void OnBeforeChildProcessLaunch(object sender, Chromium.Event.CfxOnBeforeChildProcessLaunchEventArgs e) {

            if(e.CommandLine.HasSwitch("type") && e.CommandLine.GetSwitchValue("type") == "renderer") {
                var pipeName = "cfx" + Guid.NewGuid().ToString().Replace("-", string.Empty);
                var pipeIn = new NamedPipeServerStream(pipeName + "si", PipeDirection.In, 1);
                var pipeOut = new NamedPipeServerStream(pipeName + "so", PipeDirection.Out, 1);
                var connection = new RemoteConnection(pipeIn, pipeOut, false);
                connections.Add(connection);
                e.CommandLine.AppendSwitchWithValue("cfxremote", pipeName);
            }
        }
    }
}
