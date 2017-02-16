using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    public class CefCppFunctionNode {
        public string Name;
        public bool IsStatic;
        public CefConfigNode CefConfig = new CefConfigNode();
        public bool IsRetvalBoolean;
        public List<string> BooleanParameters = new List<string>();
        public override string ToString() {
            return Name;
        }
    }
}
