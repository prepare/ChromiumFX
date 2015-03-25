// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.



using System;
using System.Runtime.InteropServices;

namespace Chromium
{
    partial class CfxApi
    {

        internal static IntPtr libcfxPtr;
        internal static IntPtr libcefPtr;

        private static string cefDir;
        private static string cfxDir;
        internal static bool librariesLoaded;

        private static PlatformApi platformApi;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_ctor_delegate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_ctor_with_gc_handle_delegate(IntPtr gc_handle);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_dtor_delegate(IntPtr nativePtr);

        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_callback_delegate(IntPtr nativePtr, int index, IntPtr callback);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_get_gc_handle_delegate(IntPtr nativePtr);


        //CFX_EXPORT int cfx_api_initialize(HMODULE libcef, void *gc_handle_free, void **release, void **string_get_ptr, void **string_destroy, , void **get_function_pointer)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_api_initialize_delegate(IntPtr libcef, IntPtr gc_handle_free, out IntPtr release, out IntPtr string_get_ptr, out IntPtr string_destroy, out IntPtr get_function_pointer);

        //static int cfx_release(cef_base_t* base)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_release_delegate(IntPtr nativePtr);
        public static cfx_release_delegate cfx_release;

        //static char16* cfx_string_get_ptr(cef_string_t* cefstr,  unsigned int *length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_string_get_ptr_delegate(IntPtr cefstr, ref int length);
        public static cfx_string_get_ptr_delegate cfx_string_get_ptr;

        //static void cfx_string_destroy(cef_string_t* cefstr)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_destroy_delegate(IntPtr str);
        public static cfx_string_destroy_delegate cfx_string_destroy;

        //static void* cfx_get_function_pointer(int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_get_function_pointer_delegate(int index);
        public static cfx_get_function_pointer_delegate cfx_get_function_pointer;


        //CEF_EXPORT void cef_string_userfree_utf16_free(cef_string_userfree_utf16_t str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cef_string_userfree_utf16_free_delegate(IntPtr str);
        public static cef_string_userfree_utf16_free_delegate cef_string_userfree_utf16_free;
        

        //static void(CEF_CALLBACK *cfx_free_gc_handle)(gc_handle_t gc_handle)
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_free_gc_handle_delegate(IntPtr gc_handle);
        private static cfx_free_gc_handle_delegate cfx_free_gc_handle;
        
        private static void FreeGcHandle(IntPtr gc_handle) {
            GCHandle.FromIntPtr(gc_handle).Free();
        }


        public static void LoadLibraries() {
            LoadLibraries(null, null);
        }

        public static void LoadLibraries(string cefDir) {
            LoadLibraries(cefDir, null);
        }

        public static void LoadLibraries(string cefDir, string cfxDir)
        {

            CfxDebug.Announce();

            if (cfxDir == null)
                cfxDir = System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
           
            if(cefDir == null) {
                cefDir = cfxDir;
                if(!System.IO.File.Exists(System.IO.Path.Combine(cefDir, "libcef.dll")))
                    cefDir = System.IO.Path.Combine(cefDir, "cef");
                if(!System.IO.File.Exists(System.IO.Path.Combine(cefDir, "libcef.dll")))
                    throw new DllNotFoundException("Unable to find libcef.dll in default locations.");
            } else {
                if(!System.IO.File.Exists(System.IO.Path.Combine(cefDir, "libcef.dll")))
                    throw new DllNotFoundException("Unable to find libcef.dll in the provided location.");
            }
            
            if(!System.IO.File.Exists(System.IO.Path.Combine(cfxDir, "libcfx.dll")))
                cfxDir = cefDir;
            if(!System.IO.File.Exists(System.IO.Path.Combine(cfxDir, "libcfx.dll")))
                throw new DllNotFoundException("Unable to find libcfx.dll.");

            cefDir = System.IO.Path.GetFullPath(cefDir);
            cfxDir = System.IO.Path.GetFullPath(cfxDir);

            if (libcfxPtr != IntPtr.Zero || libcefPtr != IntPtr.Zero) {

                if(CfxApi.cefDir != cefDir) {
                    throw new InvalidOperationException("CEF API libraries already loaded from a different directory: " + CfxApi.cefDir);
                }

                if (CfxApi.cfxDir != cfxDir) {
                    throw new InvalidOperationException("libcfx.dll already loaded from a different directory: " + CfxApi.cfxDir);
                }
                
                return;
            }

            
            switch(Environment.OSVersion.Platform) {
                case PlatformID.Win32NT:
                    platformApi = new WindowsApi();
                    break;
                default:
                    throw new CfxException("Unsupported platform: " + Environment.OSVersion.VersionString);
            }


            CfxApi.cefDir = cefDir;
            CfxApi.cfxDir = cfxDir;
            
            var libcfx = System.IO.Path.Combine(cfxDir, "libcfx.dll");
            var libcef = System.IO.Path.Combine(cefDir, "libcef.dll");

            libcefPtr = platformApi.LoadNativeLibrary(libcef);
            if(libcefPtr == IntPtr.Zero) {
                throw new DllNotFoundException("Unable to load libcef.dll from directory " + cefDir + ".");
            }

            libcfxPtr = platformApi.LoadNativeLibrary(libcfx);
            if (libcfxPtr == IntPtr.Zero) {
                throw new DllNotFoundException("Unable to load libcfx.dll from directory " + cefDir + ".");
            }

            cfx_free_gc_handle = FreeGcHandle;

            IntPtr release;
            IntPtr string_get_pointer;
            IntPtr string_destroy;
            IntPtr get_function_pointer;

            cfx_api_initialize_delegate api_initialize = (cfx_api_initialize_delegate)LoadDelegate(libcfxPtr, "cfx_api_initialize", typeof(cfx_api_initialize_delegate));
            int retval = api_initialize(libcefPtr, Marshal.GetFunctionPointerForDelegate(cfx_free_gc_handle), out release, out string_get_pointer, out string_destroy, out get_function_pointer);

            if(retval != 0) {
                switch(retval) {
                    case 1:
                        throw new CfxException("Unable to load native function cef_api_hash from libcef.dll");
                    case 2:
                        throw new CfxException("API hash mismatch: incompatible libcef.dll");
                }
            }

            cfx_release = (cfx_release_delegate)Marshal.GetDelegateForFunctionPointer(release, typeof(cfx_release_delegate));
            cfx_string_get_ptr = (cfx_string_get_ptr_delegate)Marshal.GetDelegateForFunctionPointer(string_get_pointer, typeof(cfx_string_get_ptr_delegate));
            cfx_string_destroy = (cfx_string_destroy_delegate)Marshal.GetDelegateForFunctionPointer(string_destroy, typeof(cfx_string_destroy_delegate));
            cfx_get_function_pointer = (cfx_get_function_pointer_delegate)Marshal.GetDelegateForFunctionPointer(get_function_pointer, typeof(cfx_get_function_pointer_delegate));

            cef_string_userfree_utf16_free = (cef_string_userfree_utf16_free_delegate)LoadDelegate(libcefPtr, "cef_string_userfree_utf16_free", typeof(cef_string_userfree_utf16_free_delegate));

            InstantiateRuntimeDelegates();
            librariesLoaded = true;

        }

        internal static Delegate GetDelegate(int apiIndex, Type delegateType) {
            IntPtr functionPtr = cfx_get_function_pointer(apiIndex);
            return Marshal.GetDelegateForFunctionPointer(functionPtr, delegateType);
        }
        
        private static Delegate LoadDelegate(IntPtr hModule, string procName, Type delegateType) {
            IntPtr procAdress = platformApi.GetFunctionPointer(hModule, procName);
            if (procAdress == IntPtr.Zero) {
                throw new CfxException("Unable to load native function " + procName + ". Check libcef.dll and libcfx.dll compatibility.");
            }
            return Marshal.GetDelegateForFunctionPointer(procAdress, delegateType);
        }
    }

}
