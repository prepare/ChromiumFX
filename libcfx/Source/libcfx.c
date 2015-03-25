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


// this is the one and only translation unit in this project,
// which includes all the other c files


#if CFX_PLATFORM == WIN32
// void* cfx_platform_get_fptr(void *library, const char* function_name);
#define cfx_platform_get_fptr(X, Y) GetProcAddress((HMODULE)X, Y)
#define CFX_EXPORT __declspec(dllexport)
#else
#error unsupported platform
#endif

#include "include/cef_version.h"

#include "cef_headers.h"
#include "cef_function_pointers.c"

static int (*cef_string_utf16_set_ptr)(const char16* src, size_t src_len,	cef_string_utf16_t* output, int copy);
#define cef_string_utf16_set cef_string_utf16_set_ptr

typedef void* gc_handle_t;
static void (CEF_CALLBACK *cfx_gc_handle_free)(gc_handle_t gc_handle);


static __inline void* cfx_copy_structure(void* source, size_t size) {
	if(!source) return 0;
	void* target = malloc(size);
	memcpy(target, source, size);
	return target;
}


#include "cfx_amalgamation.c"
#include "cfx_function_pointers.c"


static int cfx_release(cef_base_t* base) {
	return base->release(base);
}

static char16* cfx_string_get_ptr(cef_string_t* cefstr, int *length) {
	*length = cefstr->length;
	return cefstr->str;
}

static void cfx_string_destroy(cef_string_t* cefstr) {
	cefstr->dtor(cefstr->str);
}

static void* cfx_get_function_pointer(int index) {
	return cfx_function_pointers[index];
}

CFX_EXPORT int cfx_api_initialize(void *libcef, void *gc_handle_free, void **release, void **string_get_ptr, void **string_destroy, void **get_function_pointer) {

	cef_api_hash_ptr = (char* (*)(int))cfx_platform_get_fptr(libcef, "cef_api_hash");
	if(!cef_api_hash_ptr)
		return 1;

	if(strcmp(cef_api_hash(0), CEF_API_HASH_PLATFORM)) {
		return 2;
	}

	cfx_gc_handle_free = (void(CEF_CALLBACK *)(gc_handle_t))gc_handle_free;
	*release = (void*)cfx_release;
	*string_get_ptr = (void*)cfx_string_get_ptr;
	*string_destroy = (void*)cfx_string_destroy;
	*get_function_pointer = (void*)cfx_get_function_pointer;

	cfx_load_cef_function_pointers(libcef);
	cef_string_utf16_set_ptr = (int(*)(const char16*, size_t, cef_string_utf16_t*, int))cfx_platform_get_fptr(libcef, "cef_string_utf16_set");

	return 0;
}