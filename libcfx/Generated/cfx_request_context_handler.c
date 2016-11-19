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


// cef_request_context_handler

typedef struct _cfx_request_context_handler_t {
    cef_request_context_handler_t cef_request_context_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *get_cookie_manager)(gc_handle_t self, cef_cookie_manager_t** __retval);
    void (CEF_CALLBACK *on_before_plugin_load)(gc_handle_t self, int* __retval, char16 *mime_type_str, int mime_type_length, char16 *plugin_url_str, int plugin_url_length, char16 *top_origin_url_str, int top_origin_url_length, cef_web_plugin_info_t* plugin_info, int *_release_plugin_info, cef_plugin_policy_t* plugin_policy);
} cfx_request_context_handler_t;

void CEF_CALLBACK _cfx_request_context_handler_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_request_context_handler_t*)base)->ref_count);
    if(count == 2) {
        ((cfx_request_context_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_request_context_handler_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_request_context_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_request_context_handler_t*)base)->ref_count);
    if(count == 1) {
        ((cfx_request_context_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_request_context_handler_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_request_context_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_request_context_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_request_context_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_request_context_handler_t* cfx_request_context_handler_ctor(gc_handle_t gc_handle) {
    cfx_request_context_handler_t* ptr = (cfx_request_context_handler_t*)calloc(1, sizeof(cfx_request_context_handler_t));
    if(!ptr) return 0;
    ptr->cef_request_context_handler.base.size = sizeof(cef_request_context_handler_t);
    ptr->cef_request_context_handler.base.add_ref = _cfx_request_context_handler_add_ref;
    ptr->cef_request_context_handler.base.release = _cfx_request_context_handler_release;
    ptr->cef_request_context_handler.base.has_one_ref = _cfx_request_context_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_request_context_handler_get_gc_handle(cfx_request_context_handler_t* self) {
    return self->gc_handle;
}

// get_cookie_manager

cef_cookie_manager_t* CEF_CALLBACK cfx_request_context_handler_get_cookie_manager(cef_request_context_handler_t* self) {
    cef_cookie_manager_t* __retval;
    ((cfx_request_context_handler_t*)self)->get_cookie_manager(((cfx_request_context_handler_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// on_before_plugin_load

int CEF_CALLBACK cfx_request_context_handler_on_before_plugin_load(cef_request_context_handler_t* self, const cef_string_t* mime_type, const cef_string_t* plugin_url, const cef_string_t* top_origin_url, cef_web_plugin_info_t* plugin_info, cef_plugin_policy_t* plugin_policy) {
    int __retval;
    int _release_plugin_info;
    ((cfx_request_context_handler_t*)self)->on_before_plugin_load(((cfx_request_context_handler_t*)self)->gc_handle, &__retval, mime_type ? mime_type->str : 0, mime_type ? (int)mime_type->length : 0, plugin_url ? plugin_url->str : 0, plugin_url ? (int)plugin_url->length : 0, top_origin_url ? top_origin_url->str : 0, top_origin_url ? (int)top_origin_url->length : 0, plugin_info, &_release_plugin_info, plugin_policy);
    if(_release_plugin_info) plugin_info->base.release((cef_base_t*)plugin_info);
    return __retval;
}

static void cfx_request_context_handler_set_callback(cef_request_context_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_request_context_handler_t*)self)->get_cookie_manager = (void (CEF_CALLBACK *)(gc_handle_t self, cef_cookie_manager_t** __retval))callback;
        self->get_cookie_manager = callback ? cfx_request_context_handler_get_cookie_manager : 0;
        break;
    case 1:
        ((cfx_request_context_handler_t*)self)->on_before_plugin_load = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *mime_type_str, int mime_type_length, char16 *plugin_url_str, int plugin_url_length, char16 *top_origin_url_str, int top_origin_url_length, cef_web_plugin_info_t* plugin_info, int *_release_plugin_info, cef_plugin_policy_t* plugin_policy))callback;
        self->on_before_plugin_load = callback ? cfx_request_context_handler_on_before_plugin_load : 0;
        break;
    }
}

