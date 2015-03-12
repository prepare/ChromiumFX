// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_life_span_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_life_span_handler_t {
    cef_life_span_handler_t cef_life_span_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_life_span_handler_t;

void CEF_CALLBACK _cfx_life_span_handler_add_ref(struct _cef_base_t* base) {
    cfx_life_span_handler_t* ptr = (cfx_life_span_handler_t*)base;
    InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_life_span_handler_release(struct _cef_base_t* base) {
    cfx_life_span_handler_t* ptr = (cfx_life_span_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_life_span_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_life_span_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}

CFX_EXPORT cfx_life_span_handler_t* cfx_life_span_handler_ctor(gc_handle_t gc_handle) {
    cfx_life_span_handler_t* ptr = (cfx_life_span_handler_t*)calloc(1, sizeof(cfx_life_span_handler_t));
    if(!ptr) return 0;
    ptr->cef_life_span_handler.base.size = sizeof(cef_life_span_handler_t);
    ptr->cef_life_span_handler.base.add_ref = _cfx_life_span_handler_add_ref;
    ptr->cef_life_span_handler.base.release = _cfx_life_span_handler_release;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_life_span_handler_get_gc_handle(cfx_life_span_handler_t* self) {
    return self->gc_handle;
}

// on_before_popup

void (CEF_CALLBACK *cfx_life_span_handler_on_before_popup_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *target_url_str, int target_url_length, char16 *target_frame_name_str, int target_frame_name_length, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access);

int CEF_CALLBACK cfx_life_span_handler_on_before_popup(cef_life_span_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* target_url, const cef_string_t* target_frame_name, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access) {
    int __retval;
    cfx_life_span_handler_on_before_popup_callback(((cfx_life_span_handler_t*)self)->gc_handle, &__retval, browser, frame, target_url ? target_url->str : 0, target_url ? target_url->length : 0, target_frame_name ? target_frame_name->str : 0, target_frame_name ? target_frame_name->length : 0, popupFeatures, windowInfo, client, settings, no_javascript_access);
    if(*client)((cef_base_t*)*client)->add_ref((cef_base_t*)*client);
    return __retval;
}


// on_after_created

void (CEF_CALLBACK *cfx_life_span_handler_on_after_created_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_life_span_handler_on_after_created(cef_life_span_handler_t* self, cef_browser_t* browser) {
    cfx_life_span_handler_on_after_created_callback(((cfx_life_span_handler_t*)self)->gc_handle, browser);
}


// run_modal

void (CEF_CALLBACK *cfx_life_span_handler_run_modal_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser);

int CEF_CALLBACK cfx_life_span_handler_run_modal(cef_life_span_handler_t* self, cef_browser_t* browser) {
    int __retval;
    cfx_life_span_handler_run_modal_callback(((cfx_life_span_handler_t*)self)->gc_handle, &__retval, browser);
    return __retval;
}


// do_close

void (CEF_CALLBACK *cfx_life_span_handler_do_close_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser);

int CEF_CALLBACK cfx_life_span_handler_do_close(cef_life_span_handler_t* self, cef_browser_t* browser) {
    int __retval;
    cfx_life_span_handler_do_close_callback(((cfx_life_span_handler_t*)self)->gc_handle, &__retval, browser);
    return __retval;
}


// on_before_close

void (CEF_CALLBACK *cfx_life_span_handler_on_before_close_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_life_span_handler_on_before_close(cef_life_span_handler_t* self, cef_browser_t* browser) {
    cfx_life_span_handler_on_before_close_callback(((cfx_life_span_handler_t*)self)->gc_handle, browser);
}


CFX_EXPORT void cfx_life_span_handler_set_managed_callback(cef_life_span_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_life_span_handler_on_before_popup_callback)
            cfx_life_span_handler_on_before_popup_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *target_url_str, int target_url_length, char16 *target_frame_name_str, int target_frame_name_length, const cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access)) callback;
        self->on_before_popup = callback ? cfx_life_span_handler_on_before_popup : 0;
        break;
    case 1:
        if(callback && !cfx_life_span_handler_on_after_created_callback)
            cfx_life_span_handler_on_after_created_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) callback;
        self->on_after_created = callback ? cfx_life_span_handler_on_after_created : 0;
        break;
    case 2:
        if(callback && !cfx_life_span_handler_run_modal_callback)
            cfx_life_span_handler_run_modal_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser)) callback;
        self->run_modal = callback ? cfx_life_span_handler_run_modal : 0;
        break;
    case 3:
        if(callback && !cfx_life_span_handler_do_close_callback)
            cfx_life_span_handler_do_close_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser)) callback;
        self->do_close = callback ? cfx_life_span_handler_do_close : 0;
        break;
    case 4:
        if(callback && !cfx_life_span_handler_on_before_close_callback)
            cfx_life_span_handler_on_before_close_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) callback;
        self->on_before_close = callback ? cfx_life_span_handler_on_before_close : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

