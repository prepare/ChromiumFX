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
using System.Runtime.InteropServices;


namespace Chromium.Remote {

    public partial class CfrRuntime {

        /// <summary>
        /// Provides access to the remote process unmanaged memory.
        /// A thread must be in a remote context in order to access these function.
        /// </summary>
        public class Marshal {

            /// <summary>
            /// Call Marshal.AllocHGlobal in the target process.
            /// </summary>
            public static RemotePtr AllocHGlobal(int cb) {
                var call = new CfrMarshalAllocHGlobalRemoteCall();
                call.cb = cb;
                call.RequestExecution();
                return new RemotePtr(call.__retval);
            }

            /// <summary>
            /// Call Marshal.FreeHGlobal in the target process.
            /// </summary>
            public static void FreeHGlobal(RemotePtr hglobal) {
                var call = new CfrMarshalFreeHGlobalRemoteCall();
                call.hglobal = hglobal.ptr;
                call.RequestExecution(hglobal.connection);
            }

            /// <summary>
            /// Call Marshal.Copy in the target process.
            /// </summary>
            public static void Copy(byte[] source, int startIndex, RemotePtr destination, int length) {
                var call = new CfrMarshalCopyToNativeRemoteCall();
                call.source = source;
                call.startIndex = startIndex;
                call.destination = destination.ptr;
                call.length = length;
                call.RequestExecution(destination.connection);
            }

            /// <summary>
            /// Call Marshal.Copy in the target process.
            /// </summary>
            public static void Copy(RemotePtr source, byte[] destination, int startIndex, int length) {
                var call = new CfrMarshalCopyToManagedRemoteCall();
                call.source = source.ptr;
                call.destination = destination;
                call.startIndex = startIndex;
                call.length = length;
                call.RequestExecution(source.connection);

            }
        }
    }
    
    internal class CfrMarshalAllocHGlobalRemoteCall : RemoteCall {

        internal int cb;
        internal IntPtr __retval;

        internal CfrMarshalAllocHGlobalRemoteCall() : base(RemoteCallId.CfrMarshalAllocHGlobalRemoteCall) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(cb);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out cb);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = Marshal.AllocHGlobal(cb);
        }
    }


    internal class CfrMarshalFreeHGlobalRemoteCall : RemoteCall {

        internal IntPtr hglobal;

        internal CfrMarshalFreeHGlobalRemoteCall() : base(RemoteCallId.CfrMarshalFreeHGlobalRemoteCall) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(hglobal);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out hglobal);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            Marshal.FreeHGlobal(hglobal);
        }
    }


    internal class CfrMarshalCopyToNativeRemoteCall : RemoteCall {

        internal byte[] source;
        internal int startIndex;
        internal IntPtr destination;
        internal int length;

        internal CfrMarshalCopyToNativeRemoteCall() : base(RemoteCallId.CfrMarshalCopyToNativeRemoteCall) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(source);
            h.Write(startIndex);
            h.Write(destination);
            h.Write(length);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out source);
            h.Read(out startIndex);
            h.Read(out destination);
            h.Read(out length);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            Marshal.Copy(source, startIndex, destination, length);
        }
    }

    internal class CfrMarshalCopyToManagedRemoteCall : RemoteCall {

        internal IntPtr source;
        internal byte[] destination;
        internal int startIndex;
        internal int length;

        internal CfrMarshalCopyToManagedRemoteCall() : base(RemoteCallId.CfrMarshalCopyToManagedRemoteCall) { }

        protected override void WriteArgs(StreamHandler h) {
            h.Write(source);
            h.Write(destination);
            h.Write(startIndex);
            h.Write(length);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out source);
            h.Read(out destination);
            h.Read(out startIndex);
            h.Read(out length);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            Marshal.Copy(source, destination, startIndex, length);
        }
    }

}

