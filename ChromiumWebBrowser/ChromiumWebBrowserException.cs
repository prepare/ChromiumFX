using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Chromium.WebBrowser {
    class ChromiumWebBrowserException : Exception {
        internal ChromiumWebBrowserException(string message) : base(message) { }
    }
}
