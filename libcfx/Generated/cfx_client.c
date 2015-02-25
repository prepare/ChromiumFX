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


// cef_client

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_client_t {
    cef_client_t cef_client;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_client_t;

void CEF_CALLBACK _cfx_client_add_ref(struct _cef_base_t* base) {
    cfx_client_t* ptr = (cfx_client_t*)base;
    InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_client_release(struct _cef_base_t* base) {
    cfx_client_t* ptr = (cfx_client_t*)base;
    int count = InterlockedDecrement(&((cfx_client_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_client_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}

CFX_EXPORT cfx_client_t* cfx_client_ctor(gc_handle_t gc_handle) {
    cfx_client_t* ptr = (cfx_client_t*)calloc(1, sizeof(cfx_client_t));
    if(!ptr) return 0;
    ptr->cef_client.base.size = sizeof(cef_client_t);
    ptr->cef_client.base.add_ref = _cfx_client_add_ref;
    ptr->cef_client.base.release = _cfx_client_release;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_client_get_gc_handle(cfx_client_t* self) {
    return self->gc_handle;
}

// get_context_menu_handler

void (CEF_CALLBACK *cfx_client_get_context_menu_handler_callback)(gc_handle_t self, cef_context_menu_handler_t** __retval);

cef_context_menu_handler_t* CEF_CALLBACK cfx_client_get_context_menu_handler(cef_client_t* self) {
    cef_context_menu_handler_t* __retval;
    cfx_client_get_context_menu_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_dialog_handler

void (CEF_CALLBACK *cfx_client_get_dialog_handler_callback)(gc_handle_t self, cef_dialog_handler_t** __retval);

cef_dialog_handler_t* CEF_CALLBACK cfx_client_get_dialog_handler(cef_client_t* self) {
    cef_dialog_handler_t* __retval;
    cfx_client_get_dialog_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_display_handler

void (CEF_CALLBACK *cfx_client_get_display_handler_callback)(gc_handle_t self, cef_display_handler_t** __retval);

cef_display_handler_t* CEF_CALLBACK cfx_client_get_display_handler(cef_client_t* self) {
    cef_display_handler_t* __retval;
    cfx_client_get_display_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_download_handler

void (CEF_CALLBACK *cfx_client_get_download_handler_callback)(gc_handle_t self, cef_download_handler_t** __retval);

cef_download_handler_t* CEF_CALLBACK cfx_client_get_download_handler(cef_client_t* self) {
    cef_download_handler_t* __retval;
    cfx_client_get_download_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_drag_handler

void (CEF_CALLBACK *cfx_client_get_drag_handler_callback)(gc_handle_t self, cef_drag_handler_t** __retval);

cef_drag_handler_t* CEF_CALLBACK cfx_client_get_drag_handler(cef_client_t* self) {
    cef_drag_handler_t* __retval;
    cfx_client_get_drag_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_focus_handler

void (CEF_CALLBACK *cfx_client_get_focus_handler_callback)(gc_handle_t self, cef_focus_handler_t** __retval);

cef_focus_handler_t* CEF_CALLBACK cfx_client_get_focus_handler(cef_client_t* self) {
    cef_focus_handler_t* __retval;
    cfx_client_get_focus_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_geolocation_handler

void (CEF_CALLBACK *cfx_client_get_geolocation_handler_callback)(gc_handle_t self, cef_geolocation_handler_t** __retval);

cef_geolocation_handler_t* CEF_CALLBACK cfx_client_get_geolocation_handler(cef_client_t* self) {
    cef_geolocation_handler_t* __retval;
    cfx_client_get_geolocation_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_jsdialog_handler

void (CEF_CALLBACK *cfx_client_get_jsdialog_handler_callback)(gc_handle_t self, cef_jsdialog_handler_t** __retval);

cef_jsdialog_handler_t* CEF_CALLBACK cfx_client_get_jsdialog_handler(cef_client_t* self) {
    cef_jsdialog_handler_t* __retval;
    cfx_client_get_jsdialog_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_keyboard_handler

void (CEF_CALLBACK *cfx_client_get_keyboard_handler_callback)(gc_handle_t self, cef_keyboard_handler_t** __retval);

cef_keyboard_handler_t* CEF_CALLBACK cfx_client_get_keyboard_handler(cef_client_t* self) {
    cef_keyboard_handler_t* __retval;
    cfx_client_get_keyboard_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_life_span_handler

void (CEF_CALLBACK *cfx_client_get_life_span_handler_callback)(gc_handle_t self, cef_life_span_handler_t** __retval);

cef_life_span_handler_t* CEF_CALLBACK cfx_client_get_life_span_handler(cef_client_t* self) {
    cef_life_span_handler_t* __retval;
    cfx_client_get_life_span_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_load_handler

void (CEF_CALLBACK *cfx_client_get_load_handler_callback)(gc_handle_t self, cef_load_handler_t** __retval);

cef_load_handler_t* CEF_CALLBACK cfx_client_get_load_handler(cef_client_t* self) {
    cef_load_handler_t* __retval;
    cfx_client_get_load_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_render_handler

void (CEF_CALLBACK *cfx_client_get_render_handler_callback)(gc_handle_t self, cef_render_handler_t** __retval);

cef_render_handler_t* CEF_CALLBACK cfx_client_get_render_handler(cef_client_t* self) {
    cef_render_handler_t* __retval;
    cfx_client_get_render_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_request_handler

void (CEF_CALLBACK *cfx_client_get_request_handler_callback)(gc_handle_t self, cef_request_handler_t** __retval);

cef_request_handler_t* CEF_CALLBACK cfx_client_get_request_handler(cef_client_t* self) {
    cef_request_handler_t* __retval;
    cfx_client_get_request_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// on_process_message_received

void (CEF_CALLBACK *cfx_client_on_process_message_received_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message);

int CEF_CALLBACK cfx_client_on_process_message_received(cef_client_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    cfx_client_on_process_message_received_callback(((cfx_client_t*)self)->gc_handle, &__retval, browser, source_process, message);
    return __retval;
}


CFX_EXPORT void cfx_client_activate_callback(cef_client_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->get_context_menu_handler = is_active ? cfx_client_get_context_menu_handler : 0;
        break;
    case 1:
        self->get_dialog_handler = is_active ? cfx_client_get_dialog_handler : 0;
        break;
    case 2:
        self->get_display_handler = is_active ? cfx_client_get_display_handler : 0;
        break;
    case 3:
        self->get_download_handler = is_active ? cfx_client_get_download_handler : 0;
        break;
    case 4:
        self->get_drag_handler = is_active ? cfx_client_get_drag_handler : 0;
        break;
    case 5:
        self->get_focus_handler = is_active ? cfx_client_get_focus_handler : 0;
        break;
    case 6:
        self->get_geolocation_handler = is_active ? cfx_client_get_geolocation_handler : 0;
        break;
    case 7:
        self->get_jsdialog_handler = is_active ? cfx_client_get_jsdialog_handler : 0;
        break;
    case 8:
        self->get_keyboard_handler = is_active ? cfx_client_get_keyboard_handler : 0;
        break;
    case 9:
        self->get_life_span_handler = is_active ? cfx_client_get_life_span_handler : 0;
        break;
    case 10:
        self->get_load_handler = is_active ? cfx_client_get_load_handler : 0;
        break;
    case 11:
        self->get_render_handler = is_active ? cfx_client_get_render_handler : 0;
        break;
    case 12:
        self->get_request_handler = is_active ? cfx_client_get_request_handler : 0;
        break;
    case 13:
        self->on_process_message_received = is_active ? cfx_client_on_process_message_received : 0;
        break;
    }
}
CFX_EXPORT void cfx_client_set_callback_ptrs(void *cb_0, void *cb_1, void *cb_2, void *cb_3, void *cb_4, void *cb_5, void *cb_6, void *cb_7, void *cb_8, void *cb_9, void *cb_10, void *cb_11, void *cb_12, void *cb_13) {
    cfx_client_get_context_menu_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_context_menu_handler_t** __retval)) cb_0;
    cfx_client_get_dialog_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_dialog_handler_t** __retval)) cb_1;
    cfx_client_get_display_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_display_handler_t** __retval)) cb_2;
    cfx_client_get_download_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_download_handler_t** __retval)) cb_3;
    cfx_client_get_drag_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_drag_handler_t** __retval)) cb_4;
    cfx_client_get_focus_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_focus_handler_t** __retval)) cb_5;
    cfx_client_get_geolocation_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_geolocation_handler_t** __retval)) cb_6;
    cfx_client_get_jsdialog_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_jsdialog_handler_t** __retval)) cb_7;
    cfx_client_get_keyboard_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_keyboard_handler_t** __retval)) cb_8;
    cfx_client_get_life_span_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_life_span_handler_t** __retval)) cb_9;
    cfx_client_get_load_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval)) cb_10;
    cfx_client_get_render_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_render_handler_t** __retval)) cb_11;
    cfx_client_get_request_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_request_handler_t** __retval)) cb_12;
    cfx_client_on_process_message_received_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message)) cb_13;
}

#ifdef __cplusplus
} // extern "C"
#endif

