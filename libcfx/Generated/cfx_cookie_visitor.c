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


// cef_cookie_visitor

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_cookie_visitor_t {
    cef_cookie_visitor_t cef_cookie_visitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_cookie_visitor_t;

void CEF_CALLBACK _cfx_cookie_visitor_add_ref(struct _cef_base_t* base) {
    cfx_cookie_visitor_t* ptr = (cfx_cookie_visitor_t*)base;
    InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_cookie_visitor_release(struct _cef_base_t* base) {
    cfx_cookie_visitor_t* ptr = (cfx_cookie_visitor_t*)base;
    int count = InterlockedDecrement(&((cfx_cookie_visitor_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_cookie_visitor_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}

CFX_EXPORT cfx_cookie_visitor_t* cfx_cookie_visitor_ctor(gc_handle_t gc_handle) {
    cfx_cookie_visitor_t* ptr = (cfx_cookie_visitor_t*)calloc(1, sizeof(cfx_cookie_visitor_t));
    if(!ptr) return 0;
    ptr->cef_cookie_visitor.base.size = sizeof(cef_cookie_visitor_t);
    ptr->cef_cookie_visitor.base.add_ref = _cfx_cookie_visitor_add_ref;
    ptr->cef_cookie_visitor.base.release = _cfx_cookie_visitor_release;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_cookie_visitor_get_gc_handle(cfx_cookie_visitor_t* self) {
    return self->gc_handle;
}

// visit

void (CEF_CALLBACK *cfx_cookie_visitor_visit_callback)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie, int count, int total, int* deleteCookie);

int CEF_CALLBACK cfx_cookie_visitor_visit(cef_cookie_visitor_t* self, const cef_cookie_t* cookie, int count, int total, int* deleteCookie) {
    int __retval;
    cfx_cookie_visitor_visit_callback(((cfx_cookie_visitor_t*)self)->gc_handle, &__retval, cookie, count, total, deleteCookie);
    return __retval;
}


CFX_EXPORT void cfx_cookie_visitor_set_managed_callback(cef_cookie_visitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_cookie_visitor_visit_callback)
            cfx_cookie_visitor_visit_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie, int count, int total, int* deleteCookie)) callback;
        self->visit = callback ? cfx_cookie_visitor_visit : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

