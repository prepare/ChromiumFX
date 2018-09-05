// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8array_buffer_release_callback

typedef struct _cfx_v8array_buffer_release_callback_t {
    cef_v8array_buffer_release_callback_t cef_v8array_buffer_release_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *release_buffer)(gc_handle_t self, void* buffer);
} cfx_v8array_buffer_release_callback_t;

void CEF_CALLBACK _cfx_v8array_buffer_release_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_v8array_buffer_release_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_v8array_buffer_release_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_v8array_buffer_release_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_v8array_buffer_release_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_v8array_buffer_release_callback_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_v8array_buffer_release_callback_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_v8array_buffer_release_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_v8array_buffer_release_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_v8array_buffer_release_callback_t* cfx_v8array_buffer_release_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_v8array_buffer_release_callback_t* ptr = (cfx_v8array_buffer_release_callback_t*)calloc(1, sizeof(cfx_v8array_buffer_release_callback_t));
    if(!ptr) return 0;
    ptr->cef_v8array_buffer_release_callback.base.size = sizeof(cef_v8array_buffer_release_callback_t);
    ptr->cef_v8array_buffer_release_callback.base.add_ref = _cfx_v8array_buffer_release_callback_add_ref;
    ptr->cef_v8array_buffer_release_callback.base.release = _cfx_v8array_buffer_release_callback_release;
    ptr->cef_v8array_buffer_release_callback.base.has_one_ref = _cfx_v8array_buffer_release_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_v8array_buffer_release_callback_get_gc_handle(cfx_v8array_buffer_release_callback_t* self) {
    return self->gc_handle;
}

// release_buffer

void CEF_CALLBACK cfx_v8array_buffer_release_callback_release_buffer(cef_v8array_buffer_release_callback_t* self, void* buffer) {
    ((cfx_v8array_buffer_release_callback_t*)self)->release_buffer(((cfx_v8array_buffer_release_callback_t*)self)->gc_handle, buffer);
}

static void cfx_v8array_buffer_release_callback_set_callback(cef_v8array_buffer_release_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_v8array_buffer_release_callback_t*)self)->release_buffer = (void (CEF_CALLBACK *)(gc_handle_t self, void* buffer))callback;
        self->release_buffer = callback ? cfx_v8array_buffer_release_callback_release_buffer : 0;
        break;
    }
}

