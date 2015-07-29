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
using Chromium.Remote;

namespace Chromium {

    [Obsolete("CfxRenderProcessStartupDelegate is deprecated, please use CfxRenderProcessMainDelegate instead.")]
    public delegate int CfxRenderProcessStartupDelegate(CfrRuntime remoteRumtime);

    /// <summary>
    /// Properties and methods for the remoting interface.
    /// </summary>
    [Obsolete("CfxRemoting is deprecated, please use CfxRemoteProcessContext instead.")]
    public class CfxRemoting {

        /// <summary>
        /// Indicates if the remoting framework is active. The remoting framework is
        /// active if CfxRuntime.Initialize has been called with a valid
        /// render process startup callback. 
        /// </summary>
        [Obsolete("CfxRemoting.IsActive is deprecated, please use CfxRemoteProcessContext.RemotingInitialized instead.")]
        public static bool IsActive {
            get { return CfxRemoteProcessContext.RemotingInitialized; }
        }

        /// <summary>
        /// Thread-relative static property indicating the thread id of an affine thread
        /// in the remote process. Zero if the calling thread has no affinity with a remote thread.
        /// </summary>
        [Obsolete("CfxRemoting.RemoteThreadId is deprecated, please use CfxRemoteThreadContext.CurrentContext.ThreadId instead.")]
        public static int RemoteThreadId {
            get { return CfxRemoteThreadContext.CurrentContext.ThreadId; }
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
        [Obsolete("CfxRemoting.SetThreadAffinity is deprecated, please use CfxRemoteProcessContext.SetThreadAffinity instead.")]
        public static void SetThreadAffinity(int remoteThreadId) {
            throw new NotImplementedException("SetThreadAffinity doesn't work any more, use CfxRemoteThreadContext.Enter/Exit");
        }
    }
}
