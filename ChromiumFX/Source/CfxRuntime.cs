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
namespace Chromium {
    partial class CfxRuntime {

        internal static event Action OnCfxShutdown;


        /// <summary>
        /// Loads the native libraries libcef.dll and libcfx.dll from default locations.
        /// Tries to find the cef binaries in the executing assembly's directory
        /// or in subdirectory called cef.
        /// </summary>
        public static void LoadLibraries() {
            CfxApi.LoadLibraries();
        }

        /// <summary>
        /// Loads the native library libcef.dll from the given location.
        /// Tries to find libcfx.dll in the executing assembly's directory
        /// or in the given cef directory.
        /// </summary>
        /// <param name="cefDir"></param>
        public static void LoadLibraries(string cefDir) {
            CfxApi.LoadLibraries(cefDir);
        }

        /// <summary>
        /// Loads the native libraries libcef.dll and libcfx.dll
        /// from the given locations.
        /// </summary>
        /// <param name="cefDir"></param>
        /// <param name="cfxDir"></param>
        public static void LoadLibraries(string cefDir, string cfxDir) {
            CfxApi.LoadLibraries(cefDir, cfxDir);
        }

        /// <summary>
        /// True if the native libraries are loaded.
        /// </summary>
        public static bool LibrariesLoaded { get { return CfxApi.librariesLoaded; } }

        /// <summary>
        /// This function should be called from the application entry point function to
        /// execute a secondary process. It can be used to run secondary processes from
        /// the browser client executable (default behavior) or from a separate
        /// executable specified by the CefSettings.browser_subprocess_path value. If
        /// called for the browser process (identified by no "type" command-line value)
        /// it will return immediately with a value of -1. If called for a recognized
        /// secondary process it will block until the process should exit and then return
        /// the process exit code. The |application| parameter may be NULL.
        /// No sandbox info is provided.
        /// </summary>
        public static int ExecuteProcess(CfxApp application) {
            return ExecuteProcessPrivate(application, IntPtr.Zero);
        }

        /// <summary>
        /// This function should be called on the main application thread to initialize
        /// the CEF browser process. The |application| parameter may be NULL. A return
        /// value of true (1) indicates that it succeeded and false (0) indicates that it
        /// failed.
        /// No sandbox info is provided.
        /// </summary>
        public static bool Initialize(CfxSettings settings, CfxApp application) {
            return InitializePrivate(settings, application, IntPtr.Zero);
        }

        /// <summary>
        /// This function should be called on the main application thread to shut down
        /// the CEF browser process before the application exits.
        /// </summary>
        public static void Shutdown() {
            var handler = OnCfxShutdown;
            if(handler != null)
                handler();
            ShutdownPrivate();
        }

    }
}
