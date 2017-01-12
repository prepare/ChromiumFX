// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_keyboard_handler

typedef struct _cfx_keyboard_handler_t {
    cef_keyboard_handler_t cef_keyboard_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_pre_key_event)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut);
    void (CEF_CALLBACK *on_key_event)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, const cef_key_event_t* event, cef_event_handle_t os_event);
} cfx_keyboard_handler_t;

void CEF_CALLBACK _cfx_keyboard_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_keyboard_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_keyboard_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_keyboard_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_keyboard_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_keyboard_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_keyboard_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_keyboard_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_keyboard_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_keyboard_handler_t* cfx_keyboard_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_keyboard_handler_t* ptr = (cfx_keyboard_handler_t*)calloc(1, sizeof(cfx_keyboard_handler_t));
    if(!ptr) return 0;
    ptr->cef_keyboard_handler.base.size = sizeof(cef_keyboard_handler_t);
    ptr->cef_keyboard_handler.base.add_ref = _cfx_keyboard_handler_add_ref;
    ptr->cef_keyboard_handler.base.release = _cfx_keyboard_handler_release;
    ptr->cef_keyboard_handler.base.has_one_ref = _cfx_keyboard_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_keyboard_handler_get_gc_handle(cfx_keyboard_handler_t* self) {
    return self->gc_handle;
}

// on_pre_key_event

int CEF_CALLBACK cfx_keyboard_handler_on_pre_key_event(cef_keyboard_handler_t* self, cef_browser_t* browser, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut) {
    int __retval;
    int browser_release;
    ((cfx_keyboard_handler_t*)self)->on_pre_key_event(((cfx_keyboard_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, event, os_event, is_keyboard_shortcut);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    return __retval;
}

// on_key_event

int CEF_CALLBACK cfx_keyboard_handler_on_key_event(cef_keyboard_handler_t* self, cef_browser_t* browser, const cef_key_event_t* event, cef_event_handle_t os_event) {
    int __retval;
    int browser_release;
    ((cfx_keyboard_handler_t*)self)->on_key_event(((cfx_keyboard_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, event, os_event);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    return __retval;
}

static void cfx_keyboard_handler_set_callback(cef_keyboard_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_keyboard_handler_t*)self)->on_pre_key_event = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut))callback;
        self->on_pre_key_event = callback ? cfx_keyboard_handler_on_pre_key_event : 0;
        break;
    case 1:
        ((cfx_keyboard_handler_t*)self)->on_key_event = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, const cef_key_event_t* event, cef_event_handle_t os_event))callback;
        self->on_key_event = callback ? cfx_keyboard_handler_on_key_event : 0;
        break;
    }
}

