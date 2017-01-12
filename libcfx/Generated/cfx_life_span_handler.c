// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_life_span_handler

typedef struct _cfx_life_span_handler_t {
    cef_life_span_handler_t cef_life_span_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_before_popup)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *target_url_str, int target_url_length, char16 *target_frame_name_str, int target_frame_name_length, cef_window_open_disposition_t target_disposition, int user_gesture, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access);
    void (CEF_CALLBACK *on_after_created)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *do_close)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *on_before_close)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
} cfx_life_span_handler_t;

void CEF_CALLBACK _cfx_life_span_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_life_span_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_life_span_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_life_span_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_life_span_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_life_span_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_life_span_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_life_span_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_life_span_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_life_span_handler_t* cfx_life_span_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_life_span_handler_t* ptr = (cfx_life_span_handler_t*)calloc(1, sizeof(cfx_life_span_handler_t));
    if(!ptr) return 0;
    ptr->cef_life_span_handler.base.size = sizeof(cef_life_span_handler_t);
    ptr->cef_life_span_handler.base.add_ref = _cfx_life_span_handler_add_ref;
    ptr->cef_life_span_handler.base.release = _cfx_life_span_handler_release;
    ptr->cef_life_span_handler.base.has_one_ref = _cfx_life_span_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_life_span_handler_get_gc_handle(cfx_life_span_handler_t* self) {
    return self->gc_handle;
}

// on_before_popup

int CEF_CALLBACK cfx_life_span_handler_on_before_popup(cef_life_span_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* target_url, const cef_string_t* target_frame_name, cef_window_open_disposition_t target_disposition, int user_gesture, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access) {
    int __retval;
    int browser_release;
    int frame_release;
    ((cfx_life_span_handler_t*)self)->on_before_popup(((cfx_life_span_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, target_url ? target_url->str : 0, target_url ? (int)target_url->length : 0, target_frame_name ? target_frame_name->str : 0, target_frame_name ? (int)target_frame_name->length : 0, target_disposition, user_gesture, popupFeatures, windowInfo, client, settings, no_javascript_access);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    if(frame_release) frame->base.release((cef_base_t*)frame);
    if(*client)((cef_base_t*)*client)->add_ref((cef_base_t*)*client);
    return __retval;
}

// on_after_created

void CEF_CALLBACK cfx_life_span_handler_on_after_created(cef_life_span_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_life_span_handler_t*)self)->on_after_created(((cfx_life_span_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

// do_close

int CEF_CALLBACK cfx_life_span_handler_do_close(cef_life_span_handler_t* self, cef_browser_t* browser) {
    int __retval;
    int browser_release;
    ((cfx_life_span_handler_t*)self)->do_close(((cfx_life_span_handler_t*)self)->gc_handle, &__retval, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    return __retval;
}

// on_before_close

void CEF_CALLBACK cfx_life_span_handler_on_before_close(cef_life_span_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_life_span_handler_t*)self)->on_before_close(((cfx_life_span_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

static void cfx_life_span_handler_set_callback(cef_life_span_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_life_span_handler_t*)self)->on_before_popup = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *target_url_str, int target_url_length, char16 *target_frame_name_str, int target_frame_name_length, cef_window_open_disposition_t target_disposition, int user_gesture, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access))callback;
        self->on_before_popup = callback ? cfx_life_span_handler_on_before_popup : 0;
        break;
    case 1:
        ((cfx_life_span_handler_t*)self)->on_after_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_after_created = callback ? cfx_life_span_handler_on_after_created : 0;
        break;
    case 2:
        ((cfx_life_span_handler_t*)self)->do_close = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release))callback;
        self->do_close = callback ? cfx_life_span_handler_do_close : 0;
        break;
    case 3:
        ((cfx_life_span_handler_t*)self)->on_before_close = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_before_close = callback ? cfx_life_span_handler_on_before_close : 0;
        break;
    }
}

