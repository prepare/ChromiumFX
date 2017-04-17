// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class BlittableType : ApiType {
    public readonly string PInvokeType;

    public BlittableType(string name, string pInvokeType)
        : base(name) {
        this.PInvokeType = pInvokeType;
    }

    public override string NativeSymbol {
        get {
            switch(Name) {
                case "bool":
                case "BOOL":
                    return "int";

                case "time_t":
                    return "uint64";

                default:
                    return base.NativeSymbol;
            }
        }
    }

    public override string PInvokeSymbol {
        get { return PInvokeType; }
    }

    public override string PublicSymbol {
        get {
            switch(Name) {
                case "bool":
                case "BOOL":
                    return "bool";

                case "void":
                    return string.Empty;

                case "char*":
                    return "string";

                case "time_t":
                    return "DateTime";

                default:
                    return base.PublicSymbol;
            }
        }
    }

    public override string RemoteSymbol {
        get {
            switch(Name) {
                case "void*":
                    return "RemotePtr";
                default:
                    return base.RemoteSymbol;
            }
        }
    }

    public override string NativeWrapExpression(string var) {
        switch(Name) {
            case "bool":
            case "BOOL":
                return string.Format("({0}) ? 1 : 0", var);

            case "time_t":
                return string.Format("(uint64)({0})", var);

            default:
                return var;
        }
    }

    public override string NativeUnwrapExpression(string var) {
        switch(Name) {
            case "bool":
                return string.Format("({0}) ? true : false", var);

            case "BOOL":
                return string.Format("(BOOL)({0})", var);

            case "time_t":
                return string.Format("(time_t)({0})", var);

            default:
                return var;
        }
    }

    public override string PublicUnwrapExpression(string var) {
        if(PInvokeSymbol == null)
            return null;
        switch(Name) {
            case "bool":
            case "BOOL":
                return string.Format("{0} ? 1 : 0", var);

            case "time_t":
                return string.Format("TimeFunctions.ToTimeT({0})", var);

            default:
                return base.PublicUnwrapExpression(var);
        }
    }

    public override string PublicWrapExpression(string var) {
        switch(Name) {
            case "bool":
            case "BOOL":
                return string.Format("0 != {0}", var);

            case "char*":
                return string.Format("System.Runtime.InteropServices.Marshal.PtrToStringAnsi({0})", var);

            case "time_t":
                return string.Format("TimeFunctions.FromTimeT({0})", var);

            default:
                return base.PublicWrapExpression(var);
        }
    }

    public override void EmitPreRemoteCallStatements(CodeBuilder b, string var) {
        switch(RemoteSymbol) {
            case "RemotePtr":
                b.AppendLine("if({0}.connection != connection) throw new ArgumentException(\"Render process connection mismatch.\", \"{1}\");", CSharp.Escape(var), var);
                b.AppendLine("call.{0} = {0}.ptr;", CSharp.Escape(var));
                return;
            default:
                base.EmitPreRemoteCallStatements(b, var);
                return;
        }
        
    }

    public override void EmitRemoteEventArgGetterStatements(CodeBuilder b, string var) {
        switch(Name) {
            case "void*":
                b.AppendLine("return new RemotePtr(connection, call.{0});", CSharp.Escape(var));
                break;
            default:
                base.EmitRemoteEventArgGetterStatements(b, var);
                break;
        }
        
    }

    public override bool IsBlittableType {
        get { return true; }
    }

    public override BlittableType AsBlittableType {
        get { return this; }
    }
}