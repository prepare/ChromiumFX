// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_resolve_callback

typedef struct _cfx_resolve_callback_t {
    cef_resolve_callback_t cef_resolve_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_resolve_completed)(gc_handle_t self, cef_errorcode_t result, cef_string_list_t resolved_ips);
} cfx_resolve_callback_t;

void CEF_CALLBACK _cfx_resolve_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_resolve_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_resolve_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_resolve_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_resolve_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_resolve_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_resolve_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_resolve_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_resolve_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_resolve_callback_t* cfx_resolve_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_resolve_callback_t* ptr = (cfx_resolve_callback_t*)calloc(1, sizeof(cfx_resolve_callback_t));
    if(!ptr) return 0;
    ptr->cef_resolve_callback.base.size = sizeof(cef_resolve_callback_t);
    ptr->cef_resolve_callback.base.add_ref = _cfx_resolve_callback_add_ref;
    ptr->cef_resolve_callback.base.release = _cfx_resolve_callback_release;
    ptr->cef_resolve_callback.base.has_one_ref = _cfx_resolve_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_resolve_completed

void CEF_CALLBACK cfx_resolve_callback_on_resolve_completed(cef_resolve_callback_t* self, cef_errorcode_t result, cef_string_list_t resolved_ips) {
    ((cfx_resolve_callback_t*)self)->on_resolve_completed(((cfx_resolve_callback_t*)self)->gc_handle, result, resolved_ips);
}

static void cfx_resolve_callback_set_callback(cef_resolve_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_resolve_callback_t*)self)->on_resolve_completed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_errorcode_t result, cef_string_list_t resolved_ips))callback;
        self->on_resolve_completed = callback ? cfx_resolve_callback_on_resolve_completed : 0;
        break;
    }
}

