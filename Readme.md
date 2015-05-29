# ChromiumFX #

### .NET bindings for the [Chromium Embedded Framework](https://bitbucket.org/chromiumembedded/cef/). ###
----------

## Home ##
[https://bitbucket.org/chromiumfx/chromiumfx]()

## Overview ##

### ChromiumFX.dll ###

* **[Managed wrapper](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Project) for the complete CEF API**
* **[Remote wrapper](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_02) for full access to DOM and V8 from within the browser process**

### ChromiumWebBrowser.dll ###

* **[Windows Forms control](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_01) based on ChromiumFX**

### See Also ###

* [Project Setup and Description](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Project)
* [Getting started with the Browser Control](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_01) 
* [Getting started with the Remoting Framework](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_02)
* [API Reference](http://chromiumfx.bitbucket.org/api/)
* [Binary releases](https://bitbucket.org/chromiumfx/chromiumfx/downloads)

### Warning ###
The API of this project is not frozen and is subject to change. The overall structure will be kept though.

### Versioning ###

ChromiumFX version numbers have the format X.Y.Z where X is the CEF version (currently 3), Y is the CEF branch and Z is the ChromiumFX release number for a specific CEF version and branch. 

*"Within a release branch the CEF API is 'frozen' and generally only security/bug fixes are applied"*[[1](https://bitbucket.org/chromiumembedded/cef/wiki/BranchesAndBuilding#markdown-header-release-branches)]. So ChromiumFX binaries should work with any set of CEF binaries from the same branch. For example, ChromiumFX 3.2171.\* works with CEF 3.2171.1979 from the [CEF download page](http://www.magpcss.net/cef_downloads/), CEF 3.2171.2039 from [cefbuilds.com](https://cefbuilds.com/) or any other CEF 3.2171.\* build. 

At startup, API compatibility is verified by checking the API hash of the loaded libcef.dll, making sure ChromiumFX fails early when loading incompatible CEF binaries.

ChromiumFX exposes the following methods for querying version information: `CfxRuntime.GetCefVersion()`, `CfxRuntime.GetChromeVersion()`, `CfxRuntime.VersionInfo(entry)` and `CfxRuntime.ApiHash(entry)`. 

### Licensing and Credits ###

ChromiumFX is BSD licensed. The CEF project is BSD licensed. Please visit
"about:credits" in a CEF-based application for complete Chromium and third-party
licensing information. See also [cef/LICENSE.txt](https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/LICENSE.txt) and [cef/README.txt](https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/README.txt).


## Changes ##

This is a summary of the most important changes and those relevant to embedders (API changes etc.).

### Version 3.2357.0 ###

* Updated to CEF release branch 2357, the newest release branch considered production ready. If you update to this revision, you have to replace all CEF binary and resource files to the latest binary package found at [https://cefbuilds.com](). And you should test it with your use case to verify that there are no issues.
* As usual, the new release branch brings in a few API changes, see commit  393ad75 for an overview.
* The [API reference](http://chromiumfx.bitbucket.org/api/html/welcome.htm) has been updated to branch 2357 as well.

### Version 3.2171.15 ###

* Fixed a deadlock in the IPC code which caused the UI freeze after a renderer crash under some circumstances.
* Fixed a null reference bug unwrapping arrays of cef structs.
* Fixed a ref counting bug for arrays of cef structs.
* Issue #16 resolved; added test code for the use case described in that issue. 

### Version 3.2171.14 ###

* Enhanced javascript intgration: Additionally to the existing JSFunction, it is now possible to add javascript objects to the WebBrowser control and define functions and properties for those javascript objects, including other javascript objects and dynamic properties the application can handle at runtime. For a working example, see the test application (JsTestObject.cs).

### Version 3.2171.13 ###

* The `WindowStyles` enum was renamed to `WindowStyle`. The `CfxWindowInfo.Style` property type was changed to `WindowStyle`. Methods `CfxWindowInfo.SetAsChild()`, `CfxWindowInfo.SetAsPopup()` and `CfxWindowInfo.SetAsWindowless()` were added.
* Method `CfxRuntime.LoadLibraries()` was removed, the native libraries are now loaded transparently. To change locations for native libraries, use the `CfxRuntime.LibCefDirPath` and/or `CfxRuntime.LibCfxDirPath` properties before calling anything else in the Chromium namespaces.
* Method `CfxRemoting.ExecuteProcess()` was removed. `CfxRuntime.ExecuteProcess()` now checks transparently if a remote connection is required in the render process.

### Version 3.2171.12 ###

* The ChromiumWebBrowser control now exposes all client handlers as properties.
* ChromiumFX and ChromiumWebBrowser now support 64-bit CEF binaries. As a consequence, both assemblies are now compiled for platform AnyCPU. See [wiki](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Project#markdown-header-application-layout) for details about application layouts.
* A small test application for windowless browsing was added [here](https://bitbucket.org/chromiumfx/chromiumfx/src/tip/Tests/Windowless/).
* `CfxRemoting.Initialize` was removed, applications now pass their render process startup callback directly through `CfxRuntime.Initialize(CfxSettings, CfxApp, CfxRenderProcessStartupDelegate)`.
* Some work has been done for linux support, but it's still broken. [Issue 9](https://bitbucket.org/chromiumfx/chromiumfx/issue/9/mono-support) is tracking this.

### Version 3.2171.11 ###

Fixed a bug introduced in 3.2171.10: for not refcounted cef types, the pinvoke layer would use the wrong native function as a dtor function, causing memory leaks and possibly corruption. Sorry for that :)

### Version 3.2171.10 ###

* libcfx.dll now loads libcef.dll function pointers explicitly instead of linking to libcef.lib, removing the link time dependency. This means that ChromiumFX is now compatible with any set of CEF binaries within the same branch.
* As a consequence, ChromiumFX version numbers now have the format X.Y.Z where X is the CEF version (currently 3), Y is the CEF branch and Z is the ChromiumFX release number for a specific CEF version and branch.
* At startup, API compatibility is verified by checking the API hash of the loaded libcef.dll, making sure ChromiumFX fails early when loading incompatible CEF binaries. 

### Version 3.2171.1979.9 ###

* The generator tool now extracts additional information about the public CEF C++ API to help translation of the C API:
 * The translation from C int (0/1) to C# bool (false/true) is now based on the signatures found in the C++ header files. This should have fixed the remaining issues with the int to bool translation.
 * Some CEF C functions have different names in the CEF C++ API. The C# translation now prefers the C++ names, including overloads like `CfxV8Value.HasValue()` for both `cef_v8value->has_value_bykey()` and `cef_v8value->has_value_byindex()`.

### Version 3.2171.1979.8 ###

* ChromiumFX and ChromiumWebBrowser assemblies are now built for platform x86 instead of AnyCPU, so the compiler will complain if you reference them from AnyCPU projects.
* Fixed int to bool conversion for `SetOsModalLoop` and `SetOsModalLoop` was removed from remote layer.
* Moved API delegate instantiation into static initializers of the types they belong to. This reduces work load at startup and avoids the allocation of unnecessary delegates for types never used by an application or secondary processes.
* CEF getter functions for string collections (`cef_string_list`, `cef_string_map`, `cef_string_multimap`) are now translated as functions with return value instead of functions with out paramenter. Example: `CfxBrowser.GetFrameNames(List<string> names)` ->  `List<string> CfxBrowser.GetFrameNames()`. This affects the public API of several classes.

### Version 3.2171.1979.7 ###

* Some of the framework callback container classes were not recognized as such by the code generator. This has been fixed. `CfxEndTracingCallback`, `CfxCompletionCallback`, `CfxRunFileDialogCallback` and `CfxSchemeHandlerFactory` are now correctly wrapped as framework callbacks.
* Removed browser-only `EndTracing` and `CfxEndTracingCallback` from remote layer.
* Fixed int to bool conversion for `GetBool` and `SetBool` functions in several classes.

### Version 3.2171.1979.6 ###

* Removed the `CfxRuntime.Initialize()` and `CfxRuntime.ExecuteProcess()` functions with sandbox parameter from the public API. Currently there is no way to start this within a sandbox. 
* Internally, the callback delegates and native function pointers are now created on demand, reducing the work load at startup. Most applications won't use all callbacks anyway. 
* Version information functions added to CfxRuntime.

### Version 3.2171.1979.5 ###

* The event handler and event arg classes for the framework callback events moved into their own namespaces. If you get errors, add `using Chromium.Event` and/or `using Chromium.Remote.Event` directives.
* A Sandcastle Help File Builder project was added and the xml documentation comments were improved for the new API reference.