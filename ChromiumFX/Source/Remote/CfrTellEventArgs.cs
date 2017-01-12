using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chromium.Remote.Event {

    // this is a hack to make the shared tell event work in the remote interface.
    // it works because there are no out parameters in that event.

    partial class CfrTellEventArgs {
        internal CfrTellEventArgs(CfxWriteHandlerTellRemoteEventCall call) {
            this.call = new CfxReadHandlerTellRemoteEventCall();
        }
    }
}
