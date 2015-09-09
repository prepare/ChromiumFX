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

// Generated file. Do not edit.


// cef_request_context

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_request_context_t* cef_request_context_get_global_context();
static cef_request_context_t* cfx_request_context_get_global_context() {
    return cef_request_context_get_global_context();
}
// CEF_EXPORT cef_request_context_t* cef_request_context_create_context(cef_request_context_handler_t* handler);
static cef_request_context_t* cfx_request_context_create_context(cef_request_context_handler_t* handler) {
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_request_context_create_context(handler);
}
// cef_base_t base

// is_same
static int cfx_request_context_is_same(cef_request_context_t* self, cef_request_context_t* other) {
    if(other) ((cef_base_t*)other)->add_ref((cef_base_t*)other);
    return self->is_same(self, other);
}

// is_global
static int cfx_request_context_is_global(cef_request_context_t* self) {
    return self->is_global(self);
}

// get_handler
static cef_request_context_handler_t* cfx_request_context_get_handler(cef_request_context_t* self) {
    return self->get_handler(self);
}


#ifdef __cplusplus
} // extern "C"
#endif

