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

typedef struct _cfx_client_t {
    cef_client_t cef_client;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_client_t;

void CEF_CALLBACK _cfx_client_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_client_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_client_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_client_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_client_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_client_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_client_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_client_t* cfx_client_ctor(gc_handle_t gc_handle) {
    cfx_client_t* ptr = (cfx_client_t*)calloc(1, sizeof(cfx_client_t));
    if(!ptr) return 0;
    ptr->cef_client.base.size = sizeof(cef_client_t);
    ptr->cef_client.base.add_ref = _cfx_client_add_ref;
    ptr->cef_client.base.release = _cfx_client_release;
    ptr->cef_client.base.has_one_ref = _cfx_client_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_client_get_gc_handle(cfx_client_t* self) {
    return self->gc_handle;
}

// managed callbacks
void (CEF_CALLBACK *cfx_client_get_context_menu_handler_callback)(gc_handle_t self, cef_context_menu_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_dialog_handler_callback)(gc_handle_t self, cef_dialog_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_display_handler_callback)(gc_handle_t self, cef_display_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_download_handler_callback)(gc_handle_t self, cef_download_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_drag_handler_callback)(gc_handle_t self, cef_drag_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_find_handler_callback)(gc_handle_t self, cef_find_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_focus_handler_callback)(gc_handle_t self, cef_focus_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_geolocation_handler_callback)(gc_handle_t self, cef_geolocation_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_jsdialog_handler_callback)(gc_handle_t self, cef_jsdialog_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_keyboard_handler_callback)(gc_handle_t self, cef_keyboard_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_life_span_handler_callback)(gc_handle_t self, cef_life_span_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_load_handler_callback)(gc_handle_t self, cef_load_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_render_handler_callback)(gc_handle_t self, cef_render_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_get_request_handler_callback)(gc_handle_t self, cef_request_handler_t** __retval);
void (CEF_CALLBACK *cfx_client_on_process_message_received_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message);

static void cfx_client_set_managed_callbacks(void *get_context_menu_handler, void *get_dialog_handler, void *get_display_handler, void *get_download_handler, void *get_drag_handler, void *get_find_handler, void *get_focus_handler, void *get_geolocation_handler, void *get_jsdialog_handler, void *get_keyboard_handler, void *get_life_span_handler, void *get_load_handler, void *get_render_handler, void *get_request_handler, void *on_process_message_received) {
    cfx_client_get_context_menu_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_context_menu_handler_t** __retval)) get_context_menu_handler;
    cfx_client_get_dialog_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_dialog_handler_t** __retval)) get_dialog_handler;
    cfx_client_get_display_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_display_handler_t** __retval)) get_display_handler;
    cfx_client_get_download_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_download_handler_t** __retval)) get_download_handler;
    cfx_client_get_drag_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_drag_handler_t** __retval)) get_drag_handler;
    cfx_client_get_find_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_find_handler_t** __retval)) get_find_handler;
    cfx_client_get_focus_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_focus_handler_t** __retval)) get_focus_handler;
    cfx_client_get_geolocation_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_geolocation_handler_t** __retval)) get_geolocation_handler;
    cfx_client_get_jsdialog_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_jsdialog_handler_t** __retval)) get_jsdialog_handler;
    cfx_client_get_keyboard_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_keyboard_handler_t** __retval)) get_keyboard_handler;
    cfx_client_get_life_span_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_life_span_handler_t** __retval)) get_life_span_handler;
    cfx_client_get_load_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval)) get_load_handler;
    cfx_client_get_render_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_render_handler_t** __retval)) get_render_handler;
    cfx_client_get_request_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_request_handler_t** __retval)) get_request_handler;
    cfx_client_on_process_message_received_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message)) on_process_message_received;
}

// get_context_menu_handler

cef_context_menu_handler_t* CEF_CALLBACK cfx_client_get_context_menu_handler(cef_client_t* self) {
    cef_context_menu_handler_t* __retval;
    cfx_client_get_context_menu_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_dialog_handler

cef_dialog_handler_t* CEF_CALLBACK cfx_client_get_dialog_handler(cef_client_t* self) {
    cef_dialog_handler_t* __retval;
    cfx_client_get_dialog_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_display_handler

cef_display_handler_t* CEF_CALLBACK cfx_client_get_display_handler(cef_client_t* self) {
    cef_display_handler_t* __retval;
    cfx_client_get_display_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_download_handler

cef_download_handler_t* CEF_CALLBACK cfx_client_get_download_handler(cef_client_t* self) {
    cef_download_handler_t* __retval;
    cfx_client_get_download_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_drag_handler

cef_drag_handler_t* CEF_CALLBACK cfx_client_get_drag_handler(cef_client_t* self) {
    cef_drag_handler_t* __retval;
    cfx_client_get_drag_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_find_handler

cef_find_handler_t* CEF_CALLBACK cfx_client_get_find_handler(cef_client_t* self) {
    cef_find_handler_t* __retval;
    cfx_client_get_find_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_focus_handler

cef_focus_handler_t* CEF_CALLBACK cfx_client_get_focus_handler(cef_client_t* self) {
    cef_focus_handler_t* __retval;
    cfx_client_get_focus_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_geolocation_handler

cef_geolocation_handler_t* CEF_CALLBACK cfx_client_get_geolocation_handler(cef_client_t* self) {
    cef_geolocation_handler_t* __retval;
    cfx_client_get_geolocation_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_jsdialog_handler

cef_jsdialog_handler_t* CEF_CALLBACK cfx_client_get_jsdialog_handler(cef_client_t* self) {
    cef_jsdialog_handler_t* __retval;
    cfx_client_get_jsdialog_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_keyboard_handler

cef_keyboard_handler_t* CEF_CALLBACK cfx_client_get_keyboard_handler(cef_client_t* self) {
    cef_keyboard_handler_t* __retval;
    cfx_client_get_keyboard_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_life_span_handler

cef_life_span_handler_t* CEF_CALLBACK cfx_client_get_life_span_handler(cef_client_t* self) {
    cef_life_span_handler_t* __retval;
    cfx_client_get_life_span_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_load_handler

cef_load_handler_t* CEF_CALLBACK cfx_client_get_load_handler(cef_client_t* self) {
    cef_load_handler_t* __retval;
    cfx_client_get_load_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_render_handler

cef_render_handler_t* CEF_CALLBACK cfx_client_get_render_handler(cef_client_t* self) {
    cef_render_handler_t* __retval;
    cfx_client_get_render_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// get_request_handler

cef_request_handler_t* CEF_CALLBACK cfx_client_get_request_handler(cef_client_t* self) {
    cef_request_handler_t* __retval;
    cfx_client_get_request_handler_callback(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// on_process_message_received

int CEF_CALLBACK cfx_client_on_process_message_received(cef_client_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    cfx_client_on_process_message_received_callback(((cfx_client_t*)self)->gc_handle, &__retval, browser, source_process, message);
    return __retval;
}


static void cfx_client_activate_callback(cef_client_t* self, int index, int active) {
    switch(index) {
    case 0:
        self->get_context_menu_handler = active ? cfx_client_get_context_menu_handler : 0;
        break;
    case 1:
        self->get_dialog_handler = active ? cfx_client_get_dialog_handler : 0;
        break;
    case 2:
        self->get_display_handler = active ? cfx_client_get_display_handler : 0;
        break;
    case 3:
        self->get_download_handler = active ? cfx_client_get_download_handler : 0;
        break;
    case 4:
        self->get_drag_handler = active ? cfx_client_get_drag_handler : 0;
        break;
    case 5:
        self->get_find_handler = active ? cfx_client_get_find_handler : 0;
        break;
    case 6:
        self->get_focus_handler = active ? cfx_client_get_focus_handler : 0;
        break;
    case 7:
        self->get_geolocation_handler = active ? cfx_client_get_geolocation_handler : 0;
        break;
    case 8:
        self->get_jsdialog_handler = active ? cfx_client_get_jsdialog_handler : 0;
        break;
    case 9:
        self->get_keyboard_handler = active ? cfx_client_get_keyboard_handler : 0;
        break;
    case 10:
        self->get_life_span_handler = active ? cfx_client_get_life_span_handler : 0;
        break;
    case 11:
        self->get_load_handler = active ? cfx_client_get_load_handler : 0;
        break;
    case 12:
        self->get_render_handler = active ? cfx_client_get_render_handler : 0;
        break;
    case 13:
        self->get_request_handler = active ? cfx_client_get_request_handler : 0;
        break;
    case 14:
        self->on_process_message_received = active ? cfx_client_on_process_message_received : 0;
        break;
    }
}

