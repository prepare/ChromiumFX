// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_load_handler

typedef struct _cfx_load_handler_t {
    cef_load_handler_t cef_load_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_loading_state_change)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int isLoading, int canGoBack, int canGoForward);
    void (CEF_CALLBACK *on_load_start)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_transition_type_t transition_type);
    void (CEF_CALLBACK *on_load_end)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, int httpStatusCode);
    void (CEF_CALLBACK *on_load_error)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_errorcode_t errorCode, char16 *errorText_str, int errorText_length, char16 *failedUrl_str, int failedUrl_length);
} cfx_load_handler_t;

void CEF_CALLBACK _cfx_load_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_load_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_load_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_load_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_load_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_load_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_load_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_load_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_load_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_load_handler_t* cfx_load_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_load_handler_t* ptr = (cfx_load_handler_t*)calloc(1, sizeof(cfx_load_handler_t));
    if(!ptr) return 0;
    ptr->cef_load_handler.base.size = sizeof(cef_load_handler_t);
    ptr->cef_load_handler.base.add_ref = _cfx_load_handler_add_ref;
    ptr->cef_load_handler.base.release = _cfx_load_handler_release;
    ptr->cef_load_handler.base.has_one_ref = _cfx_load_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_loading_state_change

void CEF_CALLBACK cfx_load_handler_on_loading_state_change(cef_load_handler_t* self, cef_browser_t* browser, int isLoading, int canGoBack, int canGoForward) {
    int browser_release;
    ((cfx_load_handler_t*)self)->on_loading_state_change(((cfx_load_handler_t*)self)->gc_handle, browser, &browser_release, isLoading, canGoBack, canGoForward);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_load_start

void CEF_CALLBACK cfx_load_handler_on_load_start(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_transition_type_t transition_type) {
    int browser_release;
    int frame_release;
    ((cfx_load_handler_t*)self)->on_load_start(((cfx_load_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, transition_type);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
}

// on_load_end

void CEF_CALLBACK cfx_load_handler_on_load_end(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode) {
    int browser_release;
    int frame_release;
    ((cfx_load_handler_t*)self)->on_load_end(((cfx_load_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, httpStatusCode);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
}

// on_load_error

void CEF_CALLBACK cfx_load_handler_on_load_error(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_errorcode_t errorCode, const cef_string_t* errorText, const cef_string_t* failedUrl) {
    int browser_release;
    int frame_release;
    ((cfx_load_handler_t*)self)->on_load_error(((cfx_load_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, errorCode, errorText ? errorText->str : 0, errorText ? (int)errorText->length : 0, failedUrl ? failedUrl->str : 0, failedUrl ? (int)failedUrl->length : 0);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
}

static void cfx_load_handler_set_callback(cef_load_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_load_handler_t*)self)->on_loading_state_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int isLoading, int canGoBack, int canGoForward))callback;
        self->on_loading_state_change = callback ? cfx_load_handler_on_loading_state_change : 0;
        break;
    case 1:
        ((cfx_load_handler_t*)self)->on_load_start = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_transition_type_t transition_type))callback;
        self->on_load_start = callback ? cfx_load_handler_on_load_start : 0;
        break;
    case 2:
        ((cfx_load_handler_t*)self)->on_load_end = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, int httpStatusCode))callback;
        self->on_load_end = callback ? cfx_load_handler_on_load_end : 0;
        break;
    case 3:
        ((cfx_load_handler_t*)self)->on_load_error = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_errorcode_t errorCode, char16 *errorText_str, int errorText_length, char16 *failedUrl_str, int failedUrl_length))callback;
        self->on_load_error = callback ? cfx_load_handler_on_load_error : 0;
        break;
    }
}

