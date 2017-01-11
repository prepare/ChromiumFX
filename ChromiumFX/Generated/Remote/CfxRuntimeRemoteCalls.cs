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

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    internal class CfxRuntimeCreateDirectoryRemoteCall : RemoteCall {

        internal CfxRuntimeCreateDirectoryRemoteCall()
            : base(RemoteCallId.CfxRuntimeCreateDirectoryRemoteCall) {}

        internal string fullPath;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(fullPath);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out fullPath);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var fullPath_pinned = new PinnedString(fullPath);
            __retval = 0 != CfxApi.Runtime.cfx_create_directory(fullPath_pinned.Obj.PinnedPtr, fullPath_pinned.Length);
            fullPath_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeCreateNewTempDirectoryRemoteCall : RemoteCall {

        internal CfxRuntimeCreateNewTempDirectoryRemoteCall()
            : base(RemoteCallId.CfxRuntimeCreateNewTempDirectoryRemoteCall) {}

        internal string prefix;
        internal string newTempPath;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(prefix);
            h.Write(newTempPath);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out prefix);
            h.Read(out newTempPath);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(newTempPath);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out newTempPath);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var prefix_pinned = new PinnedString(prefix);
            var newTempPath_pinned = new PinnedString(newTempPath);
            IntPtr newTempPath_str = newTempPath_pinned.Obj.PinnedPtr;
            int newTempPath_length = newTempPath_pinned.Length;
            __retval = 0 != CfxApi.Runtime.cfx_create_new_temp_directory(prefix_pinned.Obj.PinnedPtr, prefix_pinned.Length, ref newTempPath_str, ref newTempPath_length);
            prefix_pinned.Obj.Free();
            if(newTempPath_str != newTempPath_pinned.Obj.PinnedPtr) {
                if(newTempPath_length > 0) {
                    newTempPath = System.Runtime.InteropServices.Marshal.PtrToStringUni(newTempPath_str, newTempPath_length);
                    // free the native string?
                } else {
                    newTempPath = null;
                }
            }
            newTempPath_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeCreateTempDirectoryInDirectoryRemoteCall : RemoteCall {

        internal CfxRuntimeCreateTempDirectoryInDirectoryRemoteCall()
            : base(RemoteCallId.CfxRuntimeCreateTempDirectoryInDirectoryRemoteCall) {}

        internal string baseDir;
        internal string prefix;
        internal string newDir;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(baseDir);
            h.Write(prefix);
            h.Write(newDir);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out baseDir);
            h.Read(out prefix);
            h.Read(out newDir);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(newDir);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out newDir);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var baseDir_pinned = new PinnedString(baseDir);
            var prefix_pinned = new PinnedString(prefix);
            var newDir_pinned = new PinnedString(newDir);
            IntPtr newDir_str = newDir_pinned.Obj.PinnedPtr;
            int newDir_length = newDir_pinned.Length;
            __retval = 0 != CfxApi.Runtime.cfx_create_temp_directory_in_directory(baseDir_pinned.Obj.PinnedPtr, baseDir_pinned.Length, prefix_pinned.Obj.PinnedPtr, prefix_pinned.Length, ref newDir_str, ref newDir_length);
            baseDir_pinned.Obj.Free();
            prefix_pinned.Obj.Free();
            if(newDir_str != newDir_pinned.Obj.PinnedPtr) {
                if(newDir_length > 0) {
                    newDir = System.Runtime.InteropServices.Marshal.PtrToStringUni(newDir_str, newDir_length);
                    // free the native string?
                } else {
                    newDir = null;
                }
            }
            newDir_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeCurrentlyOnRemoteCall : RemoteCall {

        internal CfxRuntimeCurrentlyOnRemoteCall()
            : base(RemoteCallId.CfxRuntimeCurrentlyOnRemoteCall) {}

        internal int threadId;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_currently_on((int)threadId);
        }
    }

    internal class CfxRuntimeDeleteFileRemoteCall : RemoteCall {

        internal CfxRuntimeDeleteFileRemoteCall()
            : base(RemoteCallId.CfxRuntimeDeleteFileRemoteCall) {}

        internal string path;
        internal bool recursive;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(path);
            h.Write(recursive);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out path);
            h.Read(out recursive);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var path_pinned = new PinnedString(path);
            __retval = 0 != CfxApi.Runtime.cfx_delete_file(path_pinned.Obj.PinnedPtr, path_pinned.Length, recursive ? 1 : 0);
            path_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeDirectoryExistsRemoteCall : RemoteCall {

        internal CfxRuntimeDirectoryExistsRemoteCall()
            : base(RemoteCallId.CfxRuntimeDirectoryExistsRemoteCall) {}

        internal string path;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(path);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out path);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var path_pinned = new PinnedString(path);
            __retval = 0 != CfxApi.Runtime.cfx_directory_exists(path_pinned.Obj.PinnedPtr, path_pinned.Length);
            path_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeFormatUrlForSecurityDisplayRemoteCall : RemoteCall {

        internal CfxRuntimeFormatUrlForSecurityDisplayRemoteCall()
            : base(RemoteCallId.CfxRuntimeFormatUrlForSecurityDisplayRemoteCall) {}

        internal string originUrl;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(originUrl);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out originUrl);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var originUrl_pinned = new PinnedString(originUrl);
            __retval = StringFunctions.ConvertStringUserfree(CfxApi.Runtime.cfx_format_url_for_security_display(originUrl_pinned.Obj.PinnedPtr, originUrl_pinned.Length));
            originUrl_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeGetTempDirectoryRemoteCall : RemoteCall {

        internal CfxRuntimeGetTempDirectoryRemoteCall()
            : base(RemoteCallId.CfxRuntimeGetTempDirectoryRemoteCall) {}

        internal string tempDir;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(tempDir);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out tempDir);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(tempDir);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out tempDir);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var tempDir_pinned = new PinnedString(tempDir);
            IntPtr tempDir_str = tempDir_pinned.Obj.PinnedPtr;
            int tempDir_length = tempDir_pinned.Length;
            __retval = 0 != CfxApi.Runtime.cfx_get_temp_directory(ref tempDir_str, ref tempDir_length);
            if(tempDir_str != tempDir_pinned.Obj.PinnedPtr) {
                if(tempDir_length > 0) {
                    tempDir = System.Runtime.InteropServices.Marshal.PtrToStringUni(tempDir_str, tempDir_length);
                    // free the native string?
                } else {
                    tempDir = null;
                }
            }
            tempDir_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeIsCertStatusErrorRemoteCall : RemoteCall {

        internal CfxRuntimeIsCertStatusErrorRemoteCall()
            : base(RemoteCallId.CfxRuntimeIsCertStatusErrorRemoteCall) {}

        internal int status;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(status);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out status);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_is_cert_status_error((int)status);
        }
    }

    internal class CfxRuntimeIsCertStatusMinorErrorRemoteCall : RemoteCall {

        internal CfxRuntimeIsCertStatusMinorErrorRemoteCall()
            : base(RemoteCallId.CfxRuntimeIsCertStatusMinorErrorRemoteCall) {}

        internal int status;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(status);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out status);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_is_cert_status_minor_error((int)status);
        }
    }

    internal class CfxRuntimePostDelayedTaskRemoteCall : RemoteCall {

        internal CfxRuntimePostDelayedTaskRemoteCall()
            : base(RemoteCallId.CfxRuntimePostDelayedTaskRemoteCall) {}

        internal int threadId;
        internal IntPtr task;
        internal long delayMs;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
            h.Write(task);
            h.Write(delayMs);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
            h.Read(out task);
            h.Read(out delayMs);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_post_delayed_task((int)threadId, task, delayMs);
        }
    }

    internal class CfxRuntimePostTaskRemoteCall : RemoteCall {

        internal CfxRuntimePostTaskRemoteCall()
            : base(RemoteCallId.CfxRuntimePostTaskRemoteCall) {}

        internal int threadId;
        internal IntPtr task;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(threadId);
            h.Write(task);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out threadId);
            h.Read(out task);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Runtime.cfx_post_task((int)threadId, task);
        }
    }

    internal class CfxRuntimeRegisterExtensionRemoteCall : RemoteCall {

        internal CfxRuntimeRegisterExtensionRemoteCall()
            : base(RemoteCallId.CfxRuntimeRegisterExtensionRemoteCall) {}

        internal string extensionName;
        internal string javascriptCode;
        internal IntPtr handler;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(extensionName);
            h.Write(javascriptCode);
            h.Write(handler);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out extensionName);
            h.Read(out javascriptCode);
            h.Read(out handler);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var extensionName_pinned = new PinnedString(extensionName);
            var javascriptCode_pinned = new PinnedString(javascriptCode);
            __retval = 0 != CfxApi.Runtime.cfx_register_extension(extensionName_pinned.Obj.PinnedPtr, extensionName_pinned.Length, javascriptCode_pinned.Obj.PinnedPtr, javascriptCode_pinned.Length, handler);
            extensionName_pinned.Obj.Free();
            javascriptCode_pinned.Obj.Free();
        }
    }

    internal class CfxRuntimeZipDirectoryRemoteCall : RemoteCall {

        internal CfxRuntimeZipDirectoryRemoteCall()
            : base(RemoteCallId.CfxRuntimeZipDirectoryRemoteCall) {}

        internal string srcDir;
        internal string destFile;
        internal bool includeHiddenFiles;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(srcDir);
            h.Write(destFile);
            h.Write(includeHiddenFiles);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out srcDir);
            h.Read(out destFile);
            h.Read(out includeHiddenFiles);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var srcDir_pinned = new PinnedString(srcDir);
            var destFile_pinned = new PinnedString(destFile);
            __retval = 0 != CfxApi.Runtime.cfx_zip_directory(srcDir_pinned.Obj.PinnedPtr, srcDir_pinned.Length, destFile_pinned.Obj.PinnedPtr, destFile_pinned.Length, includeHiddenFiles ? 1 : 0);
            srcDir_pinned.Obj.Free();
            destFile_pinned.Obj.Free();
        }
    }

}
