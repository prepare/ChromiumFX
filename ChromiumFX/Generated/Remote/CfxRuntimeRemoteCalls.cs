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
    internal class CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeAddCrossOriginWhitelistEntryRenderProcessCall) {}

        internal string sourceOrigin;
        internal string targetProtocol;
        internal string targetDomain;
        internal bool allowTargetSubdomains;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(sourceOrigin);
            h.Write(targetProtocol);
            h.Write(targetDomain);
            h.Write(allowTargetSubdomains);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out sourceOrigin);
            h.Read(out targetProtocol);
            h.Read(out targetDomain);
            h.Read(out allowTargetSubdomains);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.AddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allowTargetSubdomains);
        }
    }

    internal class CfxRuntimeClearCrossOriginWhitelistRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeClearCrossOriginWhitelistRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeClearCrossOriginWhitelistRenderProcessCall) {}

        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
        }

        protected override void ReadArgs(StreamHandler h) {
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.ClearCrossOriginWhitelist();
        }
    }

    internal class CfxRuntimeCreateUrlRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeCreateUrlRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeCreateUrlRenderProcessCall) {}

        internal ulong parts;
        internal string url;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(parts);
            h.Write(url);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out parts);
            h.Read(out url);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(url);
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out url);
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.CreateUrl((CfxUrlParts)RemoteProxy.Unwrap(parts), ref url);
        }
    }

    internal class CfxRuntimeCurrentlyOnRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeCurrentlyOnRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeCurrentlyOnRenderProcessCall) {}

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
            __retval = CfxRuntime.CurrentlyOn((CfxThreadId)threadId);
        }
    }

    internal class CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeGetExtensionsForMimeTypeRenderProcessCall) {}

        internal string mimeType;
        internal System.Collections.Generic.List<string> extensions;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(mimeType);
            h.Write(extensions);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out mimeType);
            h.Read(out extensions);
        }

        protected override void WriteReturn(StreamHandler h) {
        }

        protected override void ReadReturn(StreamHandler h) {
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxRuntime.GetExtensionsForMimeType(mimeType, extensions);
        }
    }

    internal class CfxRuntimeGetMimeTypeRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeGetMimeTypeRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeGetMimeTypeRenderProcessCall) {}

        internal string extension;
        internal string __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(extension);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out extension);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.GetMimeType(extension);
        }
    }

    internal class CfxRuntimeNowFromSystemTraceTimeRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeNowFromSystemTraceTimeRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeNowFromSystemTraceTimeRenderProcessCall) {}

        internal long __retval;

        protected override void WriteArgs(StreamHandler h) {
        }

        protected override void ReadArgs(StreamHandler h) {
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.NowFromSystemTraceTime();
        }
    }

    internal class CfxRuntimeParseCssColorRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeParseCssColorRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeParseCssColorRenderProcessCall) {}

        internal string @string;
        internal bool strict;
        internal CfxColor color;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@string);
            h.Write(strict);
            h.Write(color);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @string);
            h.Read(out strict);
            h.Read(out color);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.ParseCssColor(@string, strict, ref color);
        }
    }

    internal class CfxRuntimeParseUrlRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeParseUrlRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeParseUrlRenderProcessCall) {}

        internal string url;
        internal ulong parts;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(url);
            h.Write(parts);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out url);
            h.Read(out parts);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.ParseUrl(url, (CfxUrlParts)RemoteProxy.Unwrap(parts));
        }
    }

    internal class CfxRuntimePostDelayedTaskRenderProcessCall : RenderProcessCall {

        internal CfxRuntimePostDelayedTaskRenderProcessCall()
            : base(RemoteCallId.CfxRuntimePostDelayedTaskRenderProcessCall) {}

        internal int threadId;
        internal ulong task;
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
            __retval = CfxRuntime.PostDelayedTask((CfxThreadId)threadId, (CfxTask)RemoteProxy.Unwrap(task), delayMs);
        }
    }

    internal class CfxRuntimePostTaskRenderProcessCall : RenderProcessCall {

        internal CfxRuntimePostTaskRenderProcessCall()
            : base(RemoteCallId.CfxRuntimePostTaskRenderProcessCall) {}

        internal int threadId;
        internal ulong task;
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
            __retval = CfxRuntime.PostTask((CfxThreadId)threadId, (CfxTask)RemoteProxy.Unwrap(task));
        }
    }

    internal class CfxRuntimeRegisterExtensionRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeRegisterExtensionRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeRegisterExtensionRenderProcessCall) {}

        internal string extensionName;
        internal string javascriptCode;
        internal ulong handler;
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
            __retval = CfxRuntime.RegisterExtension(extensionName, javascriptCode, (CfxV8Handler)RemoteProxy.Unwrap(handler));
        }
    }

    internal class CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall : RenderProcessCall {

        internal CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall()
            : base(RemoteCallId.CfxRuntimeRemoveCrossOriginWhitelistEntryRenderProcessCall) {}

        internal string sourceOrigin;
        internal string targetProtocol;
        internal string targetDomain;
        internal bool allowTargetSubdomains;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(sourceOrigin);
            h.Write(targetProtocol);
            h.Write(targetDomain);
            h.Write(allowTargetSubdomains);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out sourceOrigin);
            h.Read(out targetProtocol);
            h.Read(out targetDomain);
            h.Read(out allowTargetSubdomains);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxRuntime.RemoveCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allowTargetSubdomains);
        }
    }

}
