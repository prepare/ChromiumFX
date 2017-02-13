using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    public class CefCppFunctionData {
        public string Name;
        public bool IsStatic;
        public CefConfigData CefConfig = new CefConfigData();
        public bool IsRetvalBoolean;
        public List<string> BooleanParameters = new List<string>();
    }
}
