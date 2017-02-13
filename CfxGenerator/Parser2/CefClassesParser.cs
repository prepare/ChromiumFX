using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser {

    /// <summary>
    /// Parser for files in the include folder with class definitions.
    /// </summary>
    internal class CefClassesParser : Parser {

        protected override void Parse(CefApiData api) {
            var classes = new List<CefClassData>();
            while(!Done) {
                Ensure(
                    ParseCppClass(classes)
                    
                );
            }
        }



        private bool ParseCppClass(List<CefClassData> classes) {
            return false;
        }



    }
}
