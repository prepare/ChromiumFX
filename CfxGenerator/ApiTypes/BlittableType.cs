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

    public override bool IsBlittableType {
        get { return true; }
    }

    public override BlittableType AsBlittableType {
        get { return this; }
    }
}