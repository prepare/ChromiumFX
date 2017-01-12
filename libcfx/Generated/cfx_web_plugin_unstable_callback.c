// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_web_plugin_unstable_callback

typedef struct _cfx_web_plugin_unstable_callback_t {
    cef_web_plugin_unstable_callback_t cef_web_plugin_unstable_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *is_unstable)(gc_handle_t self, char16 *path_str, int path_length, int unstable);
} cfx_web_plugin_unstable_callback_t;

void CEF_CALLBACK _cfx_web_plugin_unstable_callback_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_web_plugin_unstable_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_web_plugin_unstable_callback_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_web_plugin_unstable_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_web_plugin_unstable_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_web_plugin_unstable_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_web_plugin_unstable_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_web_plugin_unstable_callback_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_web_plugin_unstable_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_web_plugin_unstable_callback_t* cfx_web_plugin_unstable_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_web_plugin_unstable_callback_t* ptr = (cfx_web_plugin_unstable_callback_t*)calloc(1, sizeof(cfx_web_plugin_unstable_callback_t));
    if(!ptr) return 0;
    ptr->cef_web_plugin_unstable_callback.base.size = sizeof(cef_web_plugin_unstable_callback_t);
    ptr->cef_web_plugin_unstable_callback.base.add_ref = _cfx_web_plugin_unstable_callback_add_ref;
    ptr->cef_web_plugin_unstable_callback.base.release = _cfx_web_plugin_unstable_callback_release;
    ptr->cef_web_plugin_unstable_callback.base.has_one_ref = _cfx_web_plugin_unstable_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_web_plugin_unstable_callback_get_gc_handle(cfx_web_plugin_unstable_callback_t* self) {
    return self->gc_handle;
}

// is_unstable

void CEF_CALLBACK cfx_web_plugin_unstable_callback_is_unstable(cef_web_plugin_unstable_callback_t* self, const cef_string_t* path, int unstable) {
    ((cfx_web_plugin_unstable_callback_t*)self)->is_unstable(((cfx_web_plugin_unstable_callback_t*)self)->gc_handle, path ? path->str : 0, path ? (int)path->length : 0, unstable);
}

static void cfx_web_plugin_unstable_callback_set_callback(cef_web_plugin_unstable_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_web_plugin_unstable_callback_t*)self)->is_unstable = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *path_str, int path_length, int unstable))callback;
        self->is_unstable = callback ? cfx_web_plugin_unstable_callback_is_unstable : 0;
        break;
    }
}

