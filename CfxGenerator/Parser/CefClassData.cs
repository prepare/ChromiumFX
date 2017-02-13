using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    internal class CefClassData {
        string CefConfig;
        List<CefClassMethodData> Methods = new List<CefClassMethodData>();
    }
}
