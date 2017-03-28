// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_completion_callback

typedef struct _cfx_completion_callback_t {
    cef_completion_callback_t cef_completion_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_complete)(gc_handle_t self);
} cfx_completion_callback_t;

void CEF_CALLBACK _cfx_completion_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_completion_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_completion_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_completion_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_completion_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_completion_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_completion_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_completion_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_completion_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_completion_callback_t* cfx_completion_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_completion_callback_t* ptr = (cfx_completion_callback_t*)calloc(1, sizeof(cfx_completion_callback_t));
    if(!ptr) return 0;
    ptr->cef_completion_callback.base.size = sizeof(cef_completion_callback_t);
    ptr->cef_completion_callback.base.add_ref = _cfx_completion_callback_add_ref;
    ptr->cef_completion_callback.base.release = _cfx_completion_callback_release;
    ptr->cef_completion_callback.base.has_one_ref = _cfx_completion_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_complete

void CEF_CALLBACK cfx_completion_callback_on_complete(cef_completion_callback_t* self) {
    ((cfx_completion_callback_t*)self)->on_complete(((cfx_completion_callback_t*)self)->gc_handle);
}

static void cfx_completion_callback_set_callback(cef_completion_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_completion_callback_t*)self)->on_complete = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->on_complete = callback ? cfx_completion_callback_on_complete : 0;
        break;
    }
}

