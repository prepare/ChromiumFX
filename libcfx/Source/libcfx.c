// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// this is the one and only translation unit in this project,
// which includes all the other c files



#if defined CFX_WINDOWS
#define cfx_platform_get_fptr(X, Y) GetProcAddress((HMODULE)X, Y)
#define CFX_EXPORT __declspec(dllexport)
#elif defined CFX_LINUX
#include <stdlib.h>
#include <string.h>
#include <dlfcn.h>
#define cfx_platform_get_fptr dlsym
#define CFX_EXPORT
#define InterlockedIncrement(X) __sync_fetch_and_add(X, 1)
#define InterlockedDecrement(X) __sync_fetch_and_sub(X, 1)
#else
#error unsupported platform
#endif

#include "include/cef_version.h"

#include "cef_headers.h"
#include "cef_function_pointers.c"

static int (*cef_string_utf16_set_ptr)(const char16* src, size_t src_len,	cef_string_utf16_t* output, int copy);
#define cef_string_utf16_set cef_string_utf16_set_ptr

typedef void* gc_handle_t;
static void (CEF_CALLBACK *cfx_gc_handle_switch)(gc_handle_t*, int);

enum {
    GC_HANDLE_FREE = 0,
    GC_HANDLE_UPGRADE = 1,
    GC_HANDLE_DOWNGRADE = 2,
    GC_HANDLE_REMOTE = 4
};

static __inline void* cfx_copy_structure(void* source, size_t size) {
	if(!source) return 0;
	void* target = malloc(size);
	memcpy(target, source, size);
	return target;
}


#include "cfx_amalgamation.c"
#include "cfx_function_pointers.c"


static int cfx_release(cef_base_ref_counted_t* base) {
	return base->release(base);
}

static char16* cfx_string_get_ptr(cef_string_t* cefstr, int *length) {
	*length = (int)cefstr->length;
	return cefstr->str;
}

static void cfx_string_destroy(cef_string_t* cefstr) {
	cefstr->dtor(cefstr->str);
}

static void* cfx_get_function_pointer(int index) {
	return cfx_function_pointers[index];
}

CFX_EXPORT int cfx_api_initialize(void *libcef, void *gc_handle_switch, int *platform, int *cw_usedefault, void **release, void **string_get_ptr, void **string_destroy, void **get_function_pointer) {

	cef_api_hash_ptr = (const char* (*)(int))cfx_platform_get_fptr(libcef, "cef_api_hash");
	if(!cef_api_hash_ptr)
		return 1;

	if(strcmp(cef_api_hash(0), CEF_API_HASH_PLATFORM)) {
		return 2;
	}

#if defined CFX_WINDOWS
	*platform = 0;
	*cw_usedefault = CW_USEDEFAULT;
#elif defined CFX_LINUX
	*platform = 1;
	*cw_usedefault = 0;
#elif defined CFX_MACOS
	*platform = 2;
	*cw_usedefault = 0;
#endif

    cfx_gc_handle_switch = (void(CEF_CALLBACK *)(gc_handle_t*, int))gc_handle_switch;
    *release = (void*)cfx_release;
	*string_get_ptr = (void*)cfx_string_get_ptr;
	*string_destroy = (void*)cfx_string_destroy;
	*get_function_pointer = (void*)cfx_get_function_pointer;

	cfx_load_cef_function_pointers(libcef);
	cef_string_utf16_set_ptr = (int(*)(const char16*, size_t, cef_string_utf16_t*, int))cfx_platform_get_fptr(libcef, "cef_string_utf16_set");

	return 0;
}