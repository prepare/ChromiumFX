// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public enum SignatureType {
    LibraryCall,
    ClientCallback
}

public class Signature {

    public static List<Signature> AllSignatures = new List<Signature>();

    public static Signature Create(SignatureType type, string cefName, CefConfigNode cefConfig, CfxCallMode callMode, Parser.SignatureNode sd, ApiTypeBuilder api) {
        var s = new Signature(type, sd, api);
        var cs = CustomSignatures.ForFunction(s, cefName, cefConfig);
        if(cs == null) {
            s.DebugPrintUnhandledArrayArguments(cefName, cefConfig, callMode);
            AllSignatures.Add(s);
            return s;
        } else {
            cs.DebugPrintUnhandledArrayArguments(cefName, cefConfig, callMode);
            AllSignatures.Add(cs);
            return cs;
        }
    }

    protected class ArgList {
        private List<string> args = new List<string>();

        public void Add(string arg) {
            if(!string.IsNullOrWhiteSpace(arg)) {
                args.Add(arg);
                if(arg == "cef_trace_client* client")
                    System.Diagnostics.Debugger.Break();
            }
        }

        public string Join() {
            var retval = string.Join(", ", args);
            args.Clear();
            return retval;
        }
    }

    public SignatureType Type { get; private set; }

    public readonly Parameter[] Parameters;
    public readonly ApiType ReturnType;

    public readonly bool ReturnValueIsConst;

    protected ArgList args = new ArgList();

    protected Signature(SignatureType type, Parser.SignatureNode sd, ApiTypeBuilder api) {
        Type = type;
        var args = new List<Parameter>();
        var index = 0;

        foreach(var arg in sd.Parameters) {
            args.Add(new Parameter(arg, api, index));
            index += 1;
        }

        this.Parameters = args.ToArray();

        this.ReturnType = api.GetApiType(sd.ReturnType, false);
        this.ReturnValueIsConst = sd.ReturnValueIsConst;
    }

    protected Signature(Signature s) {
        Type = s.Type;
        Parameters = s.Parameters;
        ReturnType = s.ReturnType;
        ReturnValueIsConst = s.ReturnValueIsConst;
    }

    public virtual Parameter[] RemoteParameters {
        get { return ManagedParameters; }
    }

    public virtual ApiType RemoteReturnType {
        get { return PublicReturnType; }
    }

    public virtual Parameter[] ManagedParameters {
        get {
            var list = new List<Parameter>();
            foreach(var arg in Parameters) {
                if(arg.ParameterType.PInvokeSymbol != null) {
                    list.Add(arg);
                }
            }
            return list.ToArray();
        }
    }

    public virtual ApiType PublicReturnType {
        get { return ReturnType; }
    }

    public string NativeArgumentList {
        get {
            if(Type == SignatureType.ClientCallback) {
                args.Add(string.Format("(({0}*)self)->gc_handle", Parameters[0].ParameterType.AsCefStructPtrType.Struct.CfxNativeSymbol));
                if(!ReturnType.IsVoid) {
                    args.Add(ReturnType.NativeCallbackReturnValueArgument());
                }
                for(var i = 1; i <= Parameters.Length - 1; i++) {
                    args.Add(Parameters[i].NativeCallbackArgument);
                }
            } else {
                for(var i = 0; i <= Parameters.Length - 1; i++) {
                    args.Add(Parameters[i].NativeCallArgument);
                }
            }
            return args.Join();
        }
    }

    public string PublicEventConstructorParameters {
        get {
            for(var i = 1; i <= ManagedParameters.Count() - 1; i++) {
                if(ManagedParameters[i].ParameterType.IsIn) {
                    args.Add(ManagedParameters[i].PublicEventConstructorParameter);
                }
            }
            return args.Join();
        }
    }

    public string PublicEventConstructorArguments {
        get {
            for(var i = 1; i <= ManagedParameters.Length - 1; i++) {
                //Debug.Assert(ManagedArguments[i].VarName != "exception");
                if(ManagedParameters[i].ParameterType.IsIn) {
                    args.Add(ManagedParameters[i].PublicEventConstructorArgument);
                }
            }
            return args.Join();
        }
    }

    public string OriginalParameterList {
        get {
            foreach(var arg in Parameters) {
                args.Add(arg.OriginalParameter);
            }
            return args.Join();
        }
    }

    public string OriginalParameterListUnnamed {
        get {
            foreach(var arg in Parameters) {
                if(arg.IsConst) {
                    args.Add("const " + arg.ParameterType.OriginalSymbol);
                } else {
                    args.Add(arg.ParameterType.OriginalSymbol);
                }
            }
            return args.Join();
        }
    }

    public virtual string NativeParameterList {
        get {
            if(Type == SignatureType.ClientCallback) {
                args.Add("gc_handle_t self");
                if(!ReturnType.IsVoid) {
                    args.Add(ReturnType.NativeCallbackReturnValueParameter());
                }
                for(var i = 1; i <= Parameters.Length - 1; i++) {
                    args.Add(Parameters[i].NativeCallbackParameter);
                }
            } else {
                for(var i = 0; i <= Parameters.Length - 1; i++) {
                    args.Add(Parameters[i].NativeCallParameter);
                }
            }
            return args.Join();
        }
    }

    public virtual string NativeFunctionHeader(string functionName) {

        var retType = ReturnType.NativeSymbol;
        if(ReturnValueIsConst) {
            retType = "const " + retType;
        }

        return string.Format("static {0} {1}({2})", retType, functionName, NativeParameterList);
    }

    public virtual string PInvokeFunctionHeader(string functionName) {
        for(var i = 0; i <= Parameters.Length - 1; i++) {
            args.Add(Parameters[i].PInvokeCallParameter);
        }
        return string.Format("{0} {1}({2})", ReturnType.PInvokeSymbol, functionName, args.Join());
    }

    public string PInvokeParameterList {
        get {
            args.Add("IntPtr gcHandlePtr");
            if(!ReturnType.IsVoid) {
                args.Add(ReturnType.PInvokeCallbackReturnValueParameter());
            }
            for(var i = 1; i <= Parameters.Count() - 1; i++) {
                args.Add(Parameters[i].PInvokeCallbackParameter);
            }
            return args.Join();
        }
    }

    public string PublicParameterList {
        get {
            Debug.Assert(Type == SignatureType.LibraryCall);
            foreach(var arg in ManagedParameters) {
                if(arg.PublicCallParameter != null) {
                    args.Add(arg.PublicCallParameter);
                }
            }
            return args.Join();
        }
    }

    public string PublicArgumentList {
        get {
            Debug.Assert(Type == SignatureType.LibraryCall);
            foreach(var arg in ManagedParameters) {
                args.Add(arg.PublicCallArgument);
            }
            return args.Join();
        }
    }

    public string ProxyArgumentList {
        get {
            Debug.Assert(Type == SignatureType.LibraryCall);
            foreach(var arg in ManagedParameters) {
                args.Add(arg.ProxyCallArgument);
            }
            return args.Join();
        }
    }

    public virtual string PublicFunctionHeader(string functionName) {
        return string.Format("{0} {1}({2})", PublicReturnType.PublicSymbol, functionName, PublicParameterList);
    }

    public string RemoteParameterList {
        get {
            foreach(var arg in RemoteParameters) {
                if(arg.RemoteCallParameter != null) {
                    args.Add(arg.RemoteCallParameter);
                }
            }
            return args.Join();
        }
    }

    public virtual void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {

        var apiCall = string.Format("CfxApi.{2}.{0}({1})", apiFunctionName, PublicArgumentList, apiClassName);

        for(var i = 0; i <= ManagedParameters.Length - 1; i++) {
            ManagedParameters[i].EmitPrePublicCallStatements(b);
        }

        if(apiFunctionName == "cfx_task_runner_post_task" || apiFunctionName == "cfx_task_runner_post_delayed_task") {
            b.BeginBlock("lock(runningTasks)");
        }

        var b1 = new CodeBuilder(b.CurrentIndent);
        for(var i = 0; i <= ManagedParameters.Length - 1; i++) {
            ManagedParameters[i].EmitPostPublicStatements(b1);
        }
        ReturnType.EmitPublicCallProcessReturnValueStatements(b1);

        if(apiFunctionName == "cfx_task_runner_post_task" || apiFunctionName == "cfx_task_runner_post_delayed_task") {
            b1.AppendLine("if(0 != __retval) runningTasks.Add(task);");
        }

        if(PublicReturnType.IsVoid) {
            b.AppendLine(apiCall + ";");
            b.AppendBuilder(b1);
        } else {
            if(b1.IsNotEmpty) {
                b.AppendLine("var __retval = {0};", apiCall);
                b.AppendBuilder(b1);
                b.AppendLine("return {0};", PublicReturnType.PublicReturnExpression("__retval"));
            } else {
                b.AppendLine("return {0};", PublicReturnType.PublicReturnExpression(apiCall));
            }
        }

        if(apiFunctionName == "cfx_task_runner_post_task" || apiFunctionName == "cfx_task_runner_post_delayed_task") {
            b.EndBlock();
        }
    }

    protected virtual void EmitExecuteInTargetProcess(CodeBuilder b, string apiClassName, string apiFunctionName) {

        for(var i = 0; i <= ManagedParameters.Length - 1; i++) {
            ManagedParameters[i].EmitPreProxyCallStatements(b);
        }

        var apiCall = string.Format("CfxApi.{2}.{0}({1})", apiFunctionName, ProxyArgumentList, apiClassName);
        if(PublicReturnType.IsVoid) {
            b.AppendLine(apiCall + ";");
        } else {
            b.AppendLine("__retval = {0};", PublicReturnType.ProxyReturnExpression(apiCall));
        }

        for(var i = 0; i <= ManagedParameters.Length - 1; i++) {
            ManagedParameters[i].EmitPostProxyCallStatements(b);
        }
    }

    public void EmitPublicEventCtorStatements(CodeBuilder b) {
        for(var i = 1; i <= ManagedParameters.Count() - 1; i++) {
            if(ManagedParameters[i].ParameterType.IsIn) {
                ManagedParameters[i].EmitPublicEventCtorStatements(b);
            }
        }
    }

    public virtual void EmitPostPublicEventHandlerReturnValueStatements(CodeBuilder b) {
        if(!PublicReturnType.IsVoid) {
            PublicReturnType.EmitSetCallbackReturnValueStatements(b);
        }
    }

    public virtual void EmitPostRemoteEventHandlerReturnValueStatements(CodeBuilder b) {
        if(!PublicReturnType.IsVoid) {
            b.AppendLine("__retval = {0};", PublicReturnType.RemoteUnwrapExpression("e.m_returnValue"));
        }
    }

    public virtual void EmitRemoteCall(CodeBuilder b, string remoteCallId, bool isStatic) {

        b.AppendLine("var call = new {0}();", remoteCallId);

        foreach(var arg in ManagedParameters) {
            if(arg.ParameterType.IsIn) {
                arg.EmitPreRemoteCallStatements(b);
            }
        }

        if(remoteCallId == "CfxTaskRunnerPostTaskRemoteCall" || remoteCallId == "CfxTaskRunnerPostDelayedTaskRemoteCall") {
            b.BeginBlock("lock(runningTasks)");
        }

        if(isStatic)
            b.AppendLine("call.RequestExecution();");
        else
            b.AppendLine("call.RequestExecution(RemotePtr.connection);");

        if(remoteCallId == "CfxTaskRunnerPostTaskRemoteCall" || remoteCallId == "CfxTaskRunnerPostDelayedTaskRemoteCall") {
            b.AppendLine("if(call.__retval) runningTasks.Add(task);");
            b.EndBlock();
        }

        foreach(var arg in ManagedParameters) {
            arg.EmitPostRemoteCallStatements(b);
        }
        ReturnType.EmitRemoteCallProcessReturnValueStatements(b);


        if(!PublicReturnType.IsVoid) {
            b.AppendLine("return {0};", ReturnType.RemoteWrapExpression("call.__retval"));
        }
    }

    public void EmitRemoteCallClassBody(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine();

        foreach(var arg in ManagedParameters) {
            arg.EmitRemoteCallFields(b);
        }

        if(!PublicReturnType.IsVoid) {
            PublicReturnType.EmitRemoteCallFields(b, "__retval");
        }

        b.AppendLine();
        if(ManagedParameters.Length > 0) {
            b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
            foreach(var arg in ManagedParameters) {
                if(arg.ParameterType.IsIn) {
                    arg.EmitRemoteWrite(b);
                }
            }
            b.EndBlock();
            b.AppendLine();

            b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
            foreach(var arg in ManagedParameters) {
                if(arg.ParameterType.IsIn) {
                    arg.EmitRemoteRead(b);
                }
            }
            b.EndBlock();
            b.AppendLine();
        }

        var outArgs = new List<Parameter>();
        foreach(var arg in ManagedParameters) {
            if(arg.ParameterType.IsOut) {
                outArgs.Add(arg);
            } else if(arg.ParameterType.IsStringCollectionType && arg.ParameterType.AsStringCollectionType.ClassName == "CfxStringList") {
                outArgs.Add(arg);
            }
        }

        if(outArgs.Count > 0 || !PublicReturnType.IsVoid) {

            b.BeginBlock("protected override void WriteReturn(StreamHandler h)");
            foreach(var arg in outArgs) {
                arg.EmitRemoteWrite(b);
            }
            if(!PublicReturnType.IsVoid) {
                b.AppendLine("h.Write(__retval);", PublicReturnType.PublicSymbol);
            }
            b.EndBlock();
            b.AppendLine();

            b.BeginBlock("protected override void ReadReturn(StreamHandler h)");
            foreach(var arg in outArgs) {
                arg.EmitRemoteRead(b);
            }
            if(!PublicReturnType.IsVoid) {
                b.AppendLine("h.Read(out __retval);", PublicReturnType.PublicSymbol);
            }
            b.EndBlock();
            b.AppendLine();
        }

        b.BeginBlock("protected override void ExecuteInTargetProcess(RemoteConnection connection)");
        EmitExecuteInTargetProcess(b, apiClassName, apiFunctionName);
        b.EndBlock();
    }

    public virtual void EmitNativeCall(CodeBuilder b, string functionName) {
        var b1 = new CodeBuilder(b.CurrentIndent);
        for(var i = 0; i <= Parameters.Length - 1; i++) {
            Parameters[i].EmitPreNativeCallStatements(b);
            Parameters[i].EmitPostNativeCallStatements(b1);
        }

        var functionCall = string.Format("{0}({1})", functionName, NativeArgumentList);
        ReturnType.EmitNativeReturnStatements(b, functionCall, b1);
    }

    public virtual void DebugPrintUnhandledArrayArguments(string cefName, CefConfigNode cefConfig, CfxCallMode callMode) {
        
        if(cefName == "cef_resource_handler::get_response_headers")
            return;
        
        for(var i = 0; i <= Parameters.Length - 1; i++) {
            var suffixLength = CountArgumentSuffixLength(Parameters[i]);
            if(suffixLength > 0) {
                var arrName = Parameters[i].VarName.Substring(0, Parameters[i].VarName.Length - suffixLength);
                int iArray = -1;
                if(i > 0 && Parameters[i - 1].VarName.StartsWith(arrName)) {
                    iArray = i - 1;
                } else if(i < Parameters.Length - 1 && Parameters[i + 1].VarName.StartsWith(arrName)) {
                    iArray = i + 1;
                } else {
                }
                if(iArray >= 0) {
                    switch(Parameters[iArray].ParameterType.Name) {
                        case "void*":
                        case "void**":
                            //binary data
                            break;
                        default:
                            Debug.Print("UnhandledArrayArgument {0} {1} {2} {3}", callMode, cefName, Parameters[i], Parameters[iArray]);
                            break;
                    }
                }
            }
        }
    }

    private int CountArgumentSuffixLength(Parameter arg) {
        if(arg.VarName.EndsWith("_size"))
            return 5;
        if(arg.VarName.EndsWith("_count"))
            return 6;
        if(arg.VarName.EndsWith("_length"))
            return 7;
        if(arg.VarName.EndsWith("Size"))
            return 4;
        if(arg.VarName.EndsWith("Count"))
            return 5;
        if(arg.VarName.EndsWith("Length"))
            return 6;
        return 0;
    }

    public override string ToString() {
        for(var i = 0; i <= Parameters.Length - 1; i++) {
            args.Add(Parameters[i].ToString());
        }
        return args.Join();
    }
}