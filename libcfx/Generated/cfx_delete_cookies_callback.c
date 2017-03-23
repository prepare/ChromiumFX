// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_delete_cookies_callback

typedef struct _cfx_delete_cookies_callback_t {
    cef_delete_cookies_callback_t cef_delete_cookies_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_complete)(gc_handle_t self, int num_deleted);
} cfx_delete_cookies_callback_t;

void CEF_CALLBACK _cfx_delete_cookies_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_delete_cookies_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_delete_cookies_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_delete_cookies_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_delete_cookies_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_delete_cookies_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_delete_cookies_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_delete_cookies_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_delete_cookies_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_delete_cookies_callback_t* cfx_delete_cookies_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_delete_cookies_callback_t* ptr = (cfx_delete_cookies_callback_t*)calloc(1, sizeof(cfx_delete_cookies_callback_t));
    if(!ptr) return 0;
    ptr->cef_delete_cookies_callback.base.size = sizeof(cef_delete_cookies_callback_t);
    ptr->cef_delete_cookies_callback.base.add_ref = _cfx_delete_cookies_callback_add_ref;
    ptr->cef_delete_cookies_callback.base.release = _cfx_delete_cookies_callback_release;
    ptr->cef_delete_cookies_callback.base.has_one_ref = _cfx_delete_cookies_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_delete_cookies_callback_get_gc_handle(cfx_delete_cookies_callback_t* self) {
    return self->gc_handle;
}

// on_complete

void CEF_CALLBACK cfx_delete_cookies_callback_on_complete(cef_delete_cookies_callback_t* self, int num_deleted) {
    ((cfx_delete_cookies_callback_t*)self)->on_complete(((cfx_delete_cookies_callback_t*)self)->gc_handle, num_deleted);
}

static void cfx_delete_cookies_callback_set_callback(cef_delete_cookies_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_delete_cookies_callback_t*)self)->on_complete = (void (CEF_CALLBACK *)(gc_handle_t self, int num_deleted))callback;
        self->on_complete = callback ? cfx_delete_cookies_callback_on_complete : 0;
        break;
    }
}

