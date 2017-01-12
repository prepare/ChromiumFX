// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_run_file_dialog_callback

typedef struct _cfx_run_file_dialog_callback_t {
    cef_run_file_dialog_callback_t cef_run_file_dialog_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_file_dialog_dismissed)(gc_handle_t self, int selected_accept_filter, cef_string_list_t file_paths);
} cfx_run_file_dialog_callback_t;

void CEF_CALLBACK _cfx_run_file_dialog_callback_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_run_file_dialog_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_run_file_dialog_callback_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_run_file_dialog_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_run_file_dialog_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_run_file_dialog_callback_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_run_file_dialog_callback_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_run_file_dialog_callback_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_run_file_dialog_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_run_file_dialog_callback_t* cfx_run_file_dialog_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_run_file_dialog_callback_t* ptr = (cfx_run_file_dialog_callback_t*)calloc(1, sizeof(cfx_run_file_dialog_callback_t));
    if(!ptr) return 0;
    ptr->cef_run_file_dialog_callback.base.size = sizeof(cef_run_file_dialog_callback_t);
    ptr->cef_run_file_dialog_callback.base.add_ref = _cfx_run_file_dialog_callback_add_ref;
    ptr->cef_run_file_dialog_callback.base.release = _cfx_run_file_dialog_callback_release;
    ptr->cef_run_file_dialog_callback.base.has_one_ref = _cfx_run_file_dialog_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_run_file_dialog_callback_get_gc_handle(cfx_run_file_dialog_callback_t* self) {
    return self->gc_handle;
}

// on_file_dialog_dismissed

void CEF_CALLBACK cfx_run_file_dialog_callback_on_file_dialog_dismissed(cef_run_file_dialog_callback_t* self, int selected_accept_filter, cef_string_list_t file_paths) {
    ((cfx_run_file_dialog_callback_t*)self)->on_file_dialog_dismissed(((cfx_run_file_dialog_callback_t*)self)->gc_handle, selected_accept_filter, file_paths);
}

static void cfx_run_file_dialog_callback_set_callback(cef_run_file_dialog_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_run_file_dialog_callback_t*)self)->on_file_dialog_dismissed = (void (CEF_CALLBACK *)(gc_handle_t self, int selected_accept_filter, cef_string_list_t file_paths))callback;
        self->on_file_dialog_dismissed = callback ? cfx_run_file_dialog_callback_on_file_dialog_dismissed : 0;
        break;
    }
}

