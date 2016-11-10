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


// cef_scheme_handler_factory

typedef struct _cfx_scheme_handler_factory_t {
    cef_scheme_handler_factory_t cef_scheme_handler_factory;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_scheme_handler_factory_t;

void CEF_CALLBACK _cfx_scheme_handler_factory_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_scheme_handler_factory_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_scheme_handler_factory_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_scheme_handler_factory_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_scheme_handler_factory_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_scheme_handler_factory_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_scheme_handler_factory_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_scheme_handler_factory_t* cfx_scheme_handler_factory_ctor(gc_handle_t gc_handle) {
    cfx_scheme_handler_factory_t* ptr = (cfx_scheme_handler_factory_t*)calloc(1, sizeof(cfx_scheme_handler_factory_t));
    if(!ptr) return 0;
    ptr->cef_scheme_handler_factory.base.size = sizeof(cef_scheme_handler_factory_t);
    ptr->cef_scheme_handler_factory.base.add_ref = _cfx_scheme_handler_factory_add_ref;
    ptr->cef_scheme_handler_factory.base.release = _cfx_scheme_handler_factory_release;
    ptr->cef_scheme_handler_factory.base.has_one_ref = _cfx_scheme_handler_factory_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_scheme_handler_factory_get_gc_handle(cfx_scheme_handler_factory_t* self) {
    return self->gc_handle;
}

// managed callbacks
void (CEF_CALLBACK *cfx_scheme_handler_factory_create_callback)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *scheme_name_str, int scheme_name_length, cef_request_t* request);

static void cfx_scheme_handler_factory_set_managed_callbacks(void *create) {
    cfx_scheme_handler_factory_create_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *scheme_name_str, int scheme_name_length, cef_request_t* request)) create;
}

// create

cef_resource_handler_t* CEF_CALLBACK cfx_scheme_handler_factory_create(cef_scheme_handler_factory_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* scheme_name, cef_request_t* request) {
    cef_resource_handler_t* __retval;
    cfx_scheme_handler_factory_create_callback(((cfx_scheme_handler_factory_t*)self)->gc_handle, &__retval, browser, frame, scheme_name ? scheme_name->str : 0, scheme_name ? (int)scheme_name->length : 0, request);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


static void cfx_scheme_handler_factory_activate_callback(cef_scheme_handler_factory_t* self, int index, int active) {
    switch(index) {
    case 0:
        self->create = active ? cfx_scheme_handler_factory_create : 0;
        break;
    }
}

