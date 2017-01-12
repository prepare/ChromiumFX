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

    public static Signature Create(SignatureType type, string cefName, CefConfigData cefConfig, CfxCallMode callMode, Parser.SignatureData sd, ApiTypeBuilder api) {
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

    public readonly Argument[] Arguments;
    public readonly ApiType ReturnType;

    public readonly bool ReturnValueIsConst;

    protected ArgList args = new ArgList();

    protected Signature(SignatureType type, Parser.SignatureData sd, ApiTypeBuilder api) {
        Type = type;
        var args = new List<Argument>();
        var index = 0;

        foreach(var arg in sd.Arguments) {
            args.Add(new Argument(arg, api, index));
            index += 1;
        }

        this.Arguments = args.ToArray();

        this.ReturnType = api.GetApiType(sd.ReturnType, false);
        this.ReturnValueIsConst = sd.ReturnValueIsConst;
    }

    protected Signature(Signature s) {
        Type = s.Type;
        Arguments = s.Arguments;
        ReturnType = s.ReturnType;
        ReturnValueIsConst = s.ReturnValueIsConst;
    }

    public virtual Argument[] RemoteArguments {
        get { return ManagedArguments; }
    }

    public virtual ApiType RemoteReturnType {
        get { return PublicReturnType; }
    }

    public virtual Argument[] ManagedArguments {
        get {
            var list = new List<Argument>();
            foreach(var arg in Arguments) {
                if(arg.ArgumentType.PInvokeSymbol != null) {
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
                args.Add(string.Format("(({0}*)self)->gc_handle", Arguments[0].ArgumentType.AsCefStructPtrType.Struct.CfxNativeSymbol));
                if(!ReturnType.IsVoid) {
                    args.Add("&__retval");
                }
                for(var i = 1; i <= Arguments.Length - 1; i++) {
                    args.Add(Arguments[i].NativeCallbackArgument);
                }
            } else {
                for(var i = 0; i <= Arguments.Length - 1; i++) {
                    args.Add(Arguments[i].NativeCallArgument);
                }
            }
            return args.Join();
        }
    }

    public string PublicEventConstructorParameters {
        get {
            for(var i = 1; i <= ManagedArguments.Count() - 1; i++) {
                if(ManagedArguments[i].ArgumentType.IsIn) {
                    args.Add(ManagedArguments[i].PublicEventConstructorParameter);
                }
            }
            return args.Join();
        }
    }

    public string PublicEventConstructorArguments {
        get {
            for(var i = 1; i <= ManagedArguments.Length - 1; i++) {
                //Debug.Assert(ManagedArguments[i].VarName != "exception");
                if(ManagedArguments[i].ArgumentType.IsIn) {
                    args.Add(ManagedArguments[i].PublicEventConstructorArgument);
                }
            }
            return args.Join();
        }
    }

    public string OriginalParameterList {
        get {
            foreach(var arg in Arguments) {
                args.Add(arg.OriginalParameter);
            }
            return args.Join();
        }
    }

    public string OriginalParameterListUnnamed {
        get {
            foreach(var arg in Arguments) {
                if(arg.IsConst) {
                    args.Add("const " + arg.ArgumentType.OriginalSymbol);
                } else {
                    args.Add(arg.ArgumentType.OriginalSymbol);
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
                    args.Add(ReturnType.NativeOutSignature("__retval"));
                }
                for(var i = 1; i <= Arguments.Length - 1; i++) {
                    args.Add(Arguments[i].NativeCallbackParameter);
                }
            } else {
                for(var i = 0; i <= Arguments.Length - 1; i++) {
                    args.Add(Arguments[i].NativeCallParameter);
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
        for(var i = 0; i <= Arguments.Length - 1; i++) {
            args.Add(Arguments[i].PInvokeCallParameter);
        }
        return string.Format("{0} {1}({2})", ReturnType.PInvokeSymbol, functionName, args.Join());
    }

    public string PInvokeParameterList {
        get {
            args.Add("IntPtr gcHandlePtr");
            if(!ReturnType.IsVoid) {
                args.Add(ReturnType.PInvokeOutSignature("__retval"));
            }
            for(var i = 1; i <= Arguments.Count() - 1; i++) {
                args.Add(Arguments[i].PInvokeCallbackParameter);
            }
            return args.Join();
        }
    }

    public string PublicParameterList {
        get {
            Debug.Assert(Type == SignatureType.LibraryCall);
            foreach(var arg in ManagedArguments) {
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
            foreach(var arg in ManagedArguments) {
                args.Add(arg.PublicCallArgument);
            }
            return args.Join();
        }
    }

    public string ProxyArgumentList {
        get {
            Debug.Assert(Type == SignatureType.LibraryCall);
            foreach(var arg in ManagedArguments) {
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
            foreach(var arg in RemoteArguments) {
                if(arg.RemoteCallParameter != null) {
                    args.Add(arg.RemoteCallParameter);
                }
            }
            return args.Join();
        }
    }

    public virtual void EmitPublicCall(CodeBuilder b, string apiClassName, string apiFunctionName) {

        var apiCall = string.Format("CfxApi.{2}.{0}({1})", apiFunctionName, PublicArgumentList, apiClassName);

        for(var i = 0; i <= ManagedArguments.Length - 1; i++) {
            ManagedArguments[i].EmitPrePublicCallStatements(b);
        }

        var b1 = new CodeBuilder(b.CurrentIndent);
        for(var i = 0; i <= ManagedArguments.Length - 1; i++) {
            ManagedArguments[i].EmitPostPublicStatements(b1);
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
    }

    protected virtual void EmitExecuteInTargetProcess(CodeBuilder b, string apiClassName, string apiFunctionName) {

        for(var i = 0; i <= ManagedArguments.Length - 1; i++) {
            ManagedArguments[i].EmitPreProxyCallStatements(b);
        }

        var apiCall = string.Format("CfxApi.{2}.{0}({1})", apiFunctionName, ProxyArgumentList, apiClassName);
        if(PublicReturnType.IsVoid) {
            b.AppendLine(apiCall + ";");
        } else {
            b.AppendLine("__retval = {0};", PublicReturnType.ProxyReturnExpression(apiCall));
        }

        for(var i = 0; i <= ManagedArguments.Length - 1; i++) {
            ManagedArguments[i].EmitPostProxyCallStatements(b);
        }
    }

    public void EmitPublicEventCtorStatements(CodeBuilder b) {
        for(var i = 1; i <= ManagedArguments.Count() - 1; i++) {
            if(ManagedArguments[i].ArgumentType.IsIn) {
                ManagedArguments[i].EmitPublicEventCtorStatements(b);
            }
        }
    }

    public virtual void EmitPostPublicEventHandlerReturnValueStatements(CodeBuilder b) {
        if(!PublicReturnType.IsVoid) {
            b.AppendLine("__retval = {0};", PublicReturnType.PublicUnwrapExpression("e.m_returnValue"));
        }
    }

    public virtual void EmitPostRemoteEventHandlerReturnValueStatements(CodeBuilder b) {
        if(!PublicReturnType.IsVoid) {
            b.AppendLine("__retval = {0};", PublicReturnType.RemoteUnwrapExpression("e.m_returnValue"));
        }
    }

    public virtual void EmitRemoteCall(CodeBuilder b, string remoteCallId, bool isStatic) {

        b.AppendLine("var call = new {0}();", remoteCallId);

        foreach(var arg in ManagedArguments) {
            if(arg.ArgumentType.IsIn) {
                arg.EmitPreRemoteCallStatements(b);
            }
        }

        if(isStatic)
            b.AppendLine("call.RequestExecution();");
        else
            b.AppendLine("call.RequestExecution(RemotePtr.connection);");

        foreach(var arg in ManagedArguments) {
            arg.EmitPostRemoteCallStatements(b);
        }

        if(!PublicReturnType.IsVoid) {
            b.AppendLine("return {0};", ReturnType.RemoteWrapExpression("call.__retval"));
        }
    }

    public void EmitRemoteCallClassBody(CodeBuilder b, string apiClassName, string apiFunctionName) {
        b.AppendLine();

        foreach(var arg in ManagedArguments) {
            arg.EmitRemoteCallFields(b);
        }

        if(!PublicReturnType.IsVoid) {
            PublicReturnType.EmitRemoteCallFields(b, "__retval");
        }

        b.AppendLine();
        if(ManagedArguments.Length > 0) {
            b.BeginBlock("protected override void WriteArgs(StreamHandler h)");
            foreach(var arg in ManagedArguments) {
                if(arg.ArgumentType.IsIn) {
                    arg.EmitRemoteWrite(b);
                }
            }
            b.EndBlock();
            b.AppendLine();

            b.BeginBlock("protected override void ReadArgs(StreamHandler h)");
            foreach(var arg in ManagedArguments) {
                if(arg.ArgumentType.IsIn) {
                    arg.EmitRemoteRead(b);
                }
            }
            b.EndBlock();
            b.AppendLine();
        }

        var outArgs = new List<Argument>();
        foreach(var arg in ManagedArguments) {
            if(arg.ArgumentType.IsOut) {
                outArgs.Add(arg);
            } else if(arg.ArgumentType.IsStringCollectionType && arg.ArgumentType.AsStringCollectionType.ClassName == "CfxStringList") {
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
        for(var i = 0; i <= Arguments.Length - 1; i++) {
            Arguments[i].EmitPreNativeCallStatements(b);
            Arguments[i].EmitPostNativeCallStatements(b1);
        }

        var functionCall = string.Format("{0}({1})", functionName, NativeArgumentList);
        ReturnType.EmitNativeReturnStatements(b, functionCall, b1);
    }

    public virtual void DebugPrintUnhandledArrayArguments(string cefName, CefConfigData cefConfig, CfxCallMode callMode) {
        if(cefName == "cef_binary_value_create")
            return;
        if(cefName == "cef_binary_value::get_data")
            return;
        if(cefName == "cef_resource_handler::get_response_headers")
            return;
        if(cefName == "cef_resource_bundle_handler::get_data_resource")
            return;
        if(cefName == "cef_resource_bundle_handler::get_data_resource_for_scale")
            return;
        if(cefName == "cef_urlrequest_client::on_download_data")
            return;
        if(cefName == "cef_zip_reader::read_file")
            return;
        if(cefName == "cef_resource_bundle::get_data_resource")
            return;
        if(cefName == "cef_resource_bundle::get_data_resource_for_scale")
            return;
        if(cefName == "cef_response_filter::filter")
            return;
        if(cefName.StartsWith("cef_image::add_"))
            return;


        for(var i = 0; i <= Arguments.Length - 1; i++) {
            var suffixLength = CountArgumentSuffixLength(Arguments[i]);
            if(suffixLength > 0) {
                var arrName = Arguments[i].VarName.Substring(0, Arguments[i].VarName.Length - suffixLength);
                if(i > 0 && Arguments[i - 1].VarName.StartsWith(arrName)) {
                    Debug.Print("UnhandledArrayArgument {0} {1} {2} {3}", callMode, cefName, Arguments[i - 1], Arguments[i]);
                } else if(i < Arguments.Length - 1 && Arguments[i + 1].VarName.StartsWith(arrName)) {
                    Debug.Print("UnhandledArrayArgument {0} {1} {2} {3}", callMode, cefName, Arguments[i], Arguments[i + 1]);
                } else {
                }
            }
        }
    }

    private int CountArgumentSuffixLength(Argument arg) {
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
        for(var i = 0; i <= Arguments.Length - 1; i++) {
            args.Add(Arguments[i].ToString());
        }
        return args.Join();
    }
}