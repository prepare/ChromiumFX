using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chromium.Remote.Event {

    // this is a hack to make the shared seek event work in the remote interface.
    // it works because there are no out parameters in that event.

    partial class CfrSeekEventArgs {
        internal CfrSeekEventArgs(CfxWriteHandlerSeekRemoteEventCall call) {
            this.call = new CfxReadHandlerSeekRemoteEventCall();
            this.call.offset = call.offset;
            this.call.whence = call.whence;
        }
    }
}
