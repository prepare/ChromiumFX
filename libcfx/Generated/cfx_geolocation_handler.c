// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_geolocation_handler

typedef struct _cfx_geolocation_handler_t {
    cef_geolocation_handler_t cef_geolocation_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_request_geolocation_permission)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *requesting_url_str, int requesting_url_length, int request_id, cef_geolocation_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_cancel_geolocation_permission)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int request_id);
} cfx_geolocation_handler_t;

void CEF_CALLBACK _cfx_geolocation_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_geolocation_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_geolocation_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_geolocation_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_geolocation_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_geolocation_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_geolocation_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_geolocation_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_geolocation_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_geolocation_handler_t* cfx_geolocation_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_geolocation_handler_t* ptr = (cfx_geolocation_handler_t*)calloc(1, sizeof(cfx_geolocation_handler_t));
    if(!ptr) return 0;
    ptr->cef_geolocation_handler.base.size = sizeof(cef_geolocation_handler_t);
    ptr->cef_geolocation_handler.base.add_ref = _cfx_geolocation_handler_add_ref;
    ptr->cef_geolocation_handler.base.release = _cfx_geolocation_handler_release;
    ptr->cef_geolocation_handler.base.has_one_ref = _cfx_geolocation_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_geolocation_handler_get_gc_handle(cfx_geolocation_handler_t* self) {
    return self->gc_handle;
}

// on_request_geolocation_permission

int CEF_CALLBACK cfx_geolocation_handler_on_request_geolocation_permission(cef_geolocation_handler_t* self, cef_browser_t* browser, const cef_string_t* requesting_url, int request_id, cef_geolocation_callback_t* callback) {
    int __retval;
    int browser_release;
    int callback_release;
    ((cfx_geolocation_handler_t*)self)->on_request_geolocation_permission(((cfx_geolocation_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, requesting_url ? requesting_url->str : 0, requesting_url ? (int)requesting_url->length : 0, request_id, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    if(callback_release) callback->base.release((cef_base_t*)callback);
    return __retval;
}

// on_cancel_geolocation_permission

void CEF_CALLBACK cfx_geolocation_handler_on_cancel_geolocation_permission(cef_geolocation_handler_t* self, cef_browser_t* browser, int request_id) {
    int browser_release;
    ((cfx_geolocation_handler_t*)self)->on_cancel_geolocation_permission(((cfx_geolocation_handler_t*)self)->gc_handle, browser, &browser_release, request_id);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

static void cfx_geolocation_handler_set_callback(cef_geolocation_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_geolocation_handler_t*)self)->on_request_geolocation_permission = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *requesting_url_str, int requesting_url_length, int request_id, cef_geolocation_callback_t* callback, int *callback_release))callback;
        self->on_request_geolocation_permission = callback ? cfx_geolocation_handler_on_request_geolocation_permission : 0;
        break;
    case 1:
        ((cfx_geolocation_handler_t*)self)->on_cancel_geolocation_permission = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int request_id))callback;
        self->on_cancel_geolocation_permission = callback ? cfx_geolocation_handler_on_cancel_geolocation_permission : 0;
        break;
    }
}

