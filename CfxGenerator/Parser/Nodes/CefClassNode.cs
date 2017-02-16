using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    public class CefClassNode {
        public string Name;
        public CefConfigNode CefConfig = new CefConfigNode();
        public List<CefCppFunctionNode> Methods = new List<CefCppFunctionNode>();
        public override string ToString() {
            return $"class {Name} ({Methods.Count} methods)";
        }
    }
}
