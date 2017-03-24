// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_end_tracing_callback

typedef struct _cfx_end_tracing_callback_t {
    cef_end_tracing_callback_t cef_end_tracing_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_end_tracing_complete)(gc_handle_t self, char16 *tracing_file_str, int tracing_file_length);
} cfx_end_tracing_callback_t;

void CEF_CALLBACK _cfx_end_tracing_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_end_tracing_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_end_tracing_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_end_tracing_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_end_tracing_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_end_tracing_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_end_tracing_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_end_tracing_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_end_tracing_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_end_tracing_callback_t* cfx_end_tracing_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_end_tracing_callback_t* ptr = (cfx_end_tracing_callback_t*)calloc(1, sizeof(cfx_end_tracing_callback_t));
    if(!ptr) return 0;
    ptr->cef_end_tracing_callback.base.size = sizeof(cef_end_tracing_callback_t);
    ptr->cef_end_tracing_callback.base.add_ref = _cfx_end_tracing_callback_add_ref;
    ptr->cef_end_tracing_callback.base.release = _cfx_end_tracing_callback_release;
    ptr->cef_end_tracing_callback.base.has_one_ref = _cfx_end_tracing_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_end_tracing_callback_get_gc_handle(cfx_end_tracing_callback_t* self) {
    return self->gc_handle;
}

// on_end_tracing_complete

void CEF_CALLBACK cfx_end_tracing_callback_on_end_tracing_complete(cef_end_tracing_callback_t* self, const cef_string_t* tracing_file) {
    ((cfx_end_tracing_callback_t*)self)->on_end_tracing_complete(((cfx_end_tracing_callback_t*)self)->gc_handle, tracing_file ? tracing_file->str : 0, tracing_file ? (int)tracing_file->length : 0);
}

static void cfx_end_tracing_callback_set_callback(cef_end_tracing_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_end_tracing_callback_t*)self)->on_end_tracing_complete = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *tracing_file_str, int tracing_file_length))callback;
        self->on_end_tracing_complete = callback ? cfx_end_tracing_callback_on_end_tracing_complete : 0;
        break;
    }
}

