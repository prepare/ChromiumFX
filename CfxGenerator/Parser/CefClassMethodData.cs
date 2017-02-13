using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {
    [Serializable()]
    internal class CefClassMethodData {
        string CefConfig;
        bool IsRetvalBoolean;
        List<int> BooleanParameterIndexes;
    }
}
