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


// cef_resource_bundle_handler

typedef struct _cfx_resource_bundle_handler_t {
    cef_resource_bundle_handler_t cef_resource_bundle_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *get_localized_string)(gc_handle_t self, int* __retval, int string_id, char16 **string_str, int *string_length, gc_handle_t *string_gc_handle);
    void (CEF_CALLBACK *get_data_resource)(gc_handle_t self, int* __retval, int resource_id, void** data, size_t* data_size);
    void (CEF_CALLBACK *get_data_resource_for_scale)(gc_handle_t self, int* __retval, int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size);
} cfx_resource_bundle_handler_t;

void CEF_CALLBACK _cfx_resource_bundle_handler_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_resource_bundle_handler_t*)base)->ref_count);
    if(count == 2) {
        ((cfx_resource_bundle_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_resource_bundle_handler_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_resource_bundle_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_resource_bundle_handler_t*)base)->ref_count);
    if(count == 1) {
        ((cfx_resource_bundle_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_resource_bundle_handler_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_resource_bundle_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_resource_bundle_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_resource_bundle_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_resource_bundle_handler_t* cfx_resource_bundle_handler_ctor(gc_handle_t gc_handle) {
    cfx_resource_bundle_handler_t* ptr = (cfx_resource_bundle_handler_t*)calloc(1, sizeof(cfx_resource_bundle_handler_t));
    if(!ptr) return 0;
    ptr->cef_resource_bundle_handler.base.size = sizeof(cef_resource_bundle_handler_t);
    ptr->cef_resource_bundle_handler.base.add_ref = _cfx_resource_bundle_handler_add_ref;
    ptr->cef_resource_bundle_handler.base.release = _cfx_resource_bundle_handler_release;
    ptr->cef_resource_bundle_handler.base.has_one_ref = _cfx_resource_bundle_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_resource_bundle_handler_get_gc_handle(cfx_resource_bundle_handler_t* self) {
    return self->gc_handle;
}

// get_localized_string

int CEF_CALLBACK cfx_resource_bundle_handler_get_localized_string(cef_resource_bundle_handler_t* self, int string_id, cef_string_t* string) {
    int __retval;
    char16* string_tmp_str = 0; int string_tmp_length = 0; gc_handle_t string_gc_handle = 0;
    ((cfx_resource_bundle_handler_t*)self)->get_localized_string(((cfx_resource_bundle_handler_t*)self)->gc_handle, &__retval, string_id, &string_tmp_str, &string_tmp_length, &string_gc_handle);
    if(string_tmp_length > 0) {
        cef_string_set(string_tmp_str, string_tmp_length, string, 1);
        cfx_gc_handle_free(string_gc_handle);
    }
    return __retval;
}

// get_data_resource

int CEF_CALLBACK cfx_resource_bundle_handler_get_data_resource(cef_resource_bundle_handler_t* self, int resource_id, void** data, size_t* data_size) {
    int __retval;
    ((cfx_resource_bundle_handler_t*)self)->get_data_resource(((cfx_resource_bundle_handler_t*)self)->gc_handle, &__retval, resource_id, data, data_size);
    return __retval;
}

// get_data_resource_for_scale

int CEF_CALLBACK cfx_resource_bundle_handler_get_data_resource_for_scale(cef_resource_bundle_handler_t* self, int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size) {
    int __retval;
    ((cfx_resource_bundle_handler_t*)self)->get_data_resource_for_scale(((cfx_resource_bundle_handler_t*)self)->gc_handle, &__retval, resource_id, scale_factor, data, data_size);
    return __retval;
}

static void cfx_resource_bundle_handler_set_callback(cef_resource_bundle_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_resource_bundle_handler_t*)self)->get_localized_string = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int string_id, char16 **string_str, int *string_length, gc_handle_t *string_gc_handle))callback;
        self->get_localized_string = callback ? cfx_resource_bundle_handler_get_localized_string : 0;
        break;
    case 1:
        ((cfx_resource_bundle_handler_t*)self)->get_data_resource = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int resource_id, void** data, size_t* data_size))callback;
        self->get_data_resource = callback ? cfx_resource_bundle_handler_get_data_resource : 0;
        break;
    case 2:
        ((cfx_resource_bundle_handler_t*)self)->get_data_resource_for_scale = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size))callback;
        self->get_data_resource_for_scale = callback ? cfx_resource_bundle_handler_get_data_resource_for_scale : 0;
        break;
    }
}

