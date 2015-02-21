# ChromiumFX #

### .NET bindings for the [Chromium Embedded Framework](https://code.google.com/p/chromiumembedded/). ###
----------

### Overview ###

* **Managed wrapper for the CEF API**

ChromiumFX provides a complete managed wrapper for CEF, based on it's C API. The bindings are realized through three layers designed for good performance: the **native layer** deals with subclassing and refcounting, providing a clean interface between CEF and ChromiumFX with opaque structs. The **pinvoke layer** is built on top of the native layer, takes care of optimized marshaling and deals exclusively with blittable types provided by the native layer. The **public layer** wraps it all up in .NET style classes prefixed with "Cfx": CfxApp, CfxBrowser, CfxBrowserHost, etc.

* **A transparent bridge between the browser process and the render process**

Due to the multi-process architecture of Chromium, CEF applications which deal with advanced features like DOM and V8 access have to split their logic between the browser process and the render process. ChromiumFX implements a fourth layer, the **remote layer**, providing a complete API of .NET style classes for **transparently accessing** the render process **from within the browser process**: CfrApp, CfrBrowser, CfrFrame, etc. Application logic can deal with CfrDomDocument, CfrV8Context, CfrV8Handler and so on directly in the browser process, ChromiumFX will marshal application calls and framework callbacks to and from the render process using IPC. **All Application logic can be kept in the browser process.**

* **WebBrowser control**

Built upon ChromiumFX, **ChromiumWebBrowser** is an easy to use Windows Forms control. Using the remote layer, it provides injection of **javascript functions with C# callback in the browser process**, access to the **DOM from within the browser process**, and so on.

### Getting started ###

* **Building ChromiumFX**

Pull the repo and build ChromiumFX.sln with Visual Studio 2013 Community Edition. You also have to download or build the CEF binaries. For the appropriate version of CEF binaries, see cef/README.txt.

* **Using ChromiumFX**

If you don't want to build ChromiumFX yourself, you can find the current release in the download section. The download package already comes bundled with the needed CEF binaries. For required and optional components, see cef/README.txt.

Then take a look at the walkthrough.

### Licensing and Credits ###

ChromiumFX is BSD licensed. The CEF project is BSD licensed. Please visit
"about:credits" in a CEF-based application for complete Chromium and third-party
licensing information. See also cef/LICENSE.txt and cef/README.txt.
