// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_resource_bundle_handler

typedef struct _cfx_resource_bundle_handler_t {
    cef_resource_bundle_handler_t cef_resource_bundle_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *get_localized_string)(gc_handle_t self, int* __retval, int string_id, char16 **string_str, int *string_length, gc_handle_t *string_gc_handle);
    void (CEF_CALLBACK *get_data_resource)(gc_handle_t self, int* __retval, int resource_id, void** data, size_t* data_size);
    void (CEF_CALLBACK *get_data_resource_for_scale)(gc_handle_t self, int* __retval, int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size);
} cfx_resource_bundle_handler_t;

void CEF_CALLBACK _cfx_resource_bundle_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_resource_bundle_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_resource_bundle_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_resource_bundle_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_resource_bundle_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_resource_bundle_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_resource_bundle_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_resource_bundle_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_resource_bundle_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_resource_bundle_handler_t* cfx_resource_bundle_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_resource_bundle_handler_t* ptr = (cfx_resource_bundle_handler_t*)calloc(1, sizeof(cfx_resource_bundle_handler_t));
    if(!ptr) return 0;
    ptr->cef_resource_bundle_handler.base.size = sizeof(cef_resource_bundle_handler_t);
    ptr->cef_resource_bundle_handler.base.add_ref = _cfx_resource_bundle_handler_add_ref;
    ptr->cef_resource_bundle_handler.base.release = _cfx_resource_bundle_handler_release;
    ptr->cef_resource_bundle_handler.base.has_one_ref = _cfx_resource_bundle_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// get_localized_string

int CEF_CALLBACK cfx_resource_bundle_handler_get_localized_string(cef_resource_bundle_handler_t* self, int string_id, cef_string_t* string) {
    int __retval;
    char16* string_tmp_str = 0; int string_tmp_length = 0; gc_handle_t string_gc_handle = 0;
    ((cfx_resource_bundle_handler_t*)self)->get_localized_string(((cfx_resource_bundle_handler_t*)self)->gc_handle, &__retval, string_id, &string_tmp_str, &string_tmp_length, &string_gc_handle);
    if(string_tmp_length > 0) {
        cef_string_set(string_tmp_str, string_tmp_length, string, 1);
        cfx_gc_handle_switch(&string_gc_handle, GC_HANDLE_FREE);
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

