// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;

public class CefV8HandlerExecuteSignature : SignatureWithStructPtrArray {

    public CefV8HandlerExecuteSignature(Signature s)
        : base(s, 4, 3) {
    }

    public override ApiType PublicReturnType {
        get { return new CefStructPtrType(new CefStructType("cef_v8value", null), "*"); }
    }

    public override Argument[] ManagedArguments {
        get {
            var list = new List<Argument>();
            foreach(var arg in base.ManagedArguments) {
                if(arg.VarName != "retval") {
                    list.Add(arg);
                }
            }
            return list.ToArray();
        }
    }

    public override void EmitPostPublicEventHandlerReturnValueStatements(CodeBuilder b) {
        b.AppendLine("retval = CfxV8Value.Unwrap(e.m_returnValue);");
        b.AppendLine("__retval = e.m_returnValue != null || e.m_exception_wrapped != null ? 1 : 0;");
    }

    public override void EmitPostRemoteEventHandlerReturnValueStatements(CodeBuilder b) {
        b.AppendLine("retval = CfrV8Value.Unwrap(e.m_returnValue).ptr;");
        b.AppendLine("__retval = e.m_returnValue != null || e.m_exception_wrapped != null ? 1 : 0;");
    }

}