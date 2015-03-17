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


#define CFX_EXPORT __declspec(dllexport)

#include "libcfx\Generated\cfx_headers.h"
#include "cef\include\cef_version.h"

typedef void* gc_handle_t;
static void(CEF_CALLBACK *cfx_gc_handle_free)(gc_handle_t gc_handle);


static __inline void* cfx_copy_structure(void* source, size_t size) {
	if(!source) return 0;
	void* target = malloc(size);
	memcpy(target, source, size);
	return target;
}

#include "libcfx\Generated\cfx_amalgamation.c"


#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT void cfx_gc_handle_free_set_callback(void* callback) {
	cfx_gc_handle_free = (void(CEF_CALLBACK *)(gc_handle_t gc_handle))callback;
}

CFX_EXPORT int cfx_release(cef_base_t* base) {
	return base->release(base);
}

CFX_EXPORT char16* cfx_string_get_ptr(cef_string_t* cefstr,  int *length) {
	*length = cefstr->length;
	return cefstr->str;
}

CFX_EXPORT void cfx_string_destroy(cef_string_t* cefstr) {
	cefstr->dtor(cefstr->str);
}

#ifdef __cplusplus
} // extern "C"
#endif
