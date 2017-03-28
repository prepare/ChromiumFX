// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_jsdialog_handler

typedef struct _cfx_jsdialog_handler_t {
    cef_jsdialog_handler_t cef_jsdialog_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_jsdialog)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *origin_url_str, int origin_url_length, cef_jsdialog_type_t dialog_type, char16 *message_text_str, int message_text_length, char16 *default_prompt_text_str, int default_prompt_text_length, cef_jsdialog_callback_t* callback, int *callback_release, int* suppress_message);
    void (CEF_CALLBACK *on_before_unload_dialog)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *message_text_str, int message_text_length, int is_reload, cef_jsdialog_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_reset_dialog_state)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *on_dialog_closed)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
} cfx_jsdialog_handler_t;

void CEF_CALLBACK _cfx_jsdialog_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_jsdialog_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_jsdialog_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_jsdialog_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_jsdialog_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_jsdialog_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_jsdialog_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_jsdialog_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_jsdialog_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_jsdialog_handler_t* cfx_jsdialog_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_jsdialog_handler_t* ptr = (cfx_jsdialog_handler_t*)calloc(1, sizeof(cfx_jsdialog_handler_t));
    if(!ptr) return 0;
    ptr->cef_jsdialog_handler.base.size = sizeof(cef_jsdialog_handler_t);
    ptr->cef_jsdialog_handler.base.add_ref = _cfx_jsdialog_handler_add_ref;
    ptr->cef_jsdialog_handler.base.release = _cfx_jsdialog_handler_release;
    ptr->cef_jsdialog_handler.base.has_one_ref = _cfx_jsdialog_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_jsdialog

int CEF_CALLBACK cfx_jsdialog_handler_on_jsdialog(cef_jsdialog_handler_t* self, cef_browser_t* browser, const cef_string_t* origin_url, cef_jsdialog_type_t dialog_type, const cef_string_t* message_text, const cef_string_t* default_prompt_text, cef_jsdialog_callback_t* callback, int* suppress_message) {
    int __retval;
    int browser_release;
    int callback_release;
    ((cfx_jsdialog_handler_t*)self)->on_jsdialog(((cfx_jsdialog_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, origin_url ? origin_url->str : 0, origin_url ? (int)origin_url->length : 0, dialog_type, message_text ? message_text->str : 0, message_text ? (int)message_text->length : 0, default_prompt_text ? default_prompt_text->str : 0, default_prompt_text ? (int)default_prompt_text->length : 0, callback, &callback_release, suppress_message);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_before_unload_dialog

int CEF_CALLBACK cfx_jsdialog_handler_on_before_unload_dialog(cef_jsdialog_handler_t* self, cef_browser_t* browser, const cef_string_t* message_text, int is_reload, cef_jsdialog_callback_t* callback) {
    int __retval;
    int browser_release;
    int callback_release;
    ((cfx_jsdialog_handler_t*)self)->on_before_unload_dialog(((cfx_jsdialog_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, message_text ? message_text->str : 0, message_text ? (int)message_text->length : 0, is_reload, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_reset_dialog_state

void CEF_CALLBACK cfx_jsdialog_handler_on_reset_dialog_state(cef_jsdialog_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_jsdialog_handler_t*)self)->on_reset_dialog_state(((cfx_jsdialog_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_dialog_closed

void CEF_CALLBACK cfx_jsdialog_handler_on_dialog_closed(cef_jsdialog_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_jsdialog_handler_t*)self)->on_dialog_closed(((cfx_jsdialog_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

static void cfx_jsdialog_handler_set_callback(cef_jsdialog_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_jsdialog_handler_t*)self)->on_jsdialog = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *origin_url_str, int origin_url_length, cef_jsdialog_type_t dialog_type, char16 *message_text_str, int message_text_length, char16 *default_prompt_text_str, int default_prompt_text_length, cef_jsdialog_callback_t* callback, int *callback_release, int* suppress_message))callback;
        self->on_jsdialog = callback ? cfx_jsdialog_handler_on_jsdialog : 0;
        break;
    case 1:
        ((cfx_jsdialog_handler_t*)self)->on_before_unload_dialog = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *message_text_str, int message_text_length, int is_reload, cef_jsdialog_callback_t* callback, int *callback_release))callback;
        self->on_before_unload_dialog = callback ? cfx_jsdialog_handler_on_before_unload_dialog : 0;
        break;
    case 2:
        ((cfx_jsdialog_handler_t*)self)->on_reset_dialog_state = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_reset_dialog_state = callback ? cfx_jsdialog_handler_on_reset_dialog_state : 0;
        break;
    case 3:
        ((cfx_jsdialog_handler_t*)self)->on_dialog_closed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_dialog_closed = callback ? cfx_jsdialog_handler_on_dialog_closed : 0;
        break;
    }
}

