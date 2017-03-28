// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_dialog_handler

typedef struct _cfx_dialog_handler_t {
    cef_dialog_handler_t cef_dialog_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_file_dialog)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_file_dialog_mode_t mode, char16 *title_str, int title_length, char16 *default_file_path_str, int default_file_path_length, cef_string_list_t accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback, int *callback_release);
} cfx_dialog_handler_t;

void CEF_CALLBACK _cfx_dialog_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_dialog_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_dialog_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_dialog_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_dialog_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_dialog_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_dialog_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_dialog_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_dialog_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_dialog_handler_t* cfx_dialog_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_dialog_handler_t* ptr = (cfx_dialog_handler_t*)calloc(1, sizeof(cfx_dialog_handler_t));
    if(!ptr) return 0;
    ptr->cef_dialog_handler.base.size = sizeof(cef_dialog_handler_t);
    ptr->cef_dialog_handler.base.add_ref = _cfx_dialog_handler_add_ref;
    ptr->cef_dialog_handler.base.release = _cfx_dialog_handler_release;
    ptr->cef_dialog_handler.base.has_one_ref = _cfx_dialog_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_file_dialog

int CEF_CALLBACK cfx_dialog_handler_on_file_dialog(cef_dialog_handler_t* self, cef_browser_t* browser, cef_file_dialog_mode_t mode, const cef_string_t* title, const cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback) {
    int __retval;
    int browser_release;
    int callback_release;
    ((cfx_dialog_handler_t*)self)->on_file_dialog(((cfx_dialog_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, mode, title ? title->str : 0, title ? (int)title->length : 0, default_file_path ? default_file_path->str : 0, default_file_path ? (int)default_file_path->length : 0, accept_filters, selected_accept_filter, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

static void cfx_dialog_handler_set_callback(cef_dialog_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_dialog_handler_t*)self)->on_file_dialog = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_file_dialog_mode_t mode, char16 *title_str, int title_length, char16 *default_file_path_str, int default_file_path_length, cef_string_list_t accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback, int *callback_release))callback;
        self->on_file_dialog = callback ? cfx_dialog_handler_on_file_dialog : 0;
        break;
    }
}

