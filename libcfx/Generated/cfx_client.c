// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_client

typedef struct _cfx_client_t {
    cef_client_t cef_client;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *get_context_menu_handler)(gc_handle_t self, cef_context_menu_handler_t** __retval);
    void (CEF_CALLBACK *get_dialog_handler)(gc_handle_t self, cef_dialog_handler_t** __retval);
    void (CEF_CALLBACK *get_display_handler)(gc_handle_t self, cef_display_handler_t** __retval);
    void (CEF_CALLBACK *get_download_handler)(gc_handle_t self, cef_download_handler_t** __retval);
    void (CEF_CALLBACK *get_drag_handler)(gc_handle_t self, cef_drag_handler_t** __retval);
    void (CEF_CALLBACK *get_find_handler)(gc_handle_t self, cef_find_handler_t** __retval);
    void (CEF_CALLBACK *get_focus_handler)(gc_handle_t self, cef_focus_handler_t** __retval);
    void (CEF_CALLBACK *get_geolocation_handler)(gc_handle_t self, cef_geolocation_handler_t** __retval);
    void (CEF_CALLBACK *get_jsdialog_handler)(gc_handle_t self, cef_jsdialog_handler_t** __retval);
    void (CEF_CALLBACK *get_keyboard_handler)(gc_handle_t self, cef_keyboard_handler_t** __retval);
    void (CEF_CALLBACK *get_life_span_handler)(gc_handle_t self, cef_life_span_handler_t** __retval);
    void (CEF_CALLBACK *get_load_handler)(gc_handle_t self, cef_load_handler_t** __retval);
    void (CEF_CALLBACK *get_render_handler)(gc_handle_t self, cef_render_handler_t** __retval);
    void (CEF_CALLBACK *get_request_handler)(gc_handle_t self, cef_request_handler_t** __retval);
    void (CEF_CALLBACK *on_process_message_received)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_process_id_t source_process, cef_process_message_t* message, int *message_release);
} cfx_client_t;

void CEF_CALLBACK _cfx_client_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_client_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_client_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_client_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_client_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_client_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_client_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_client_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_client_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_client_t* cfx_client_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_client_t* ptr = (cfx_client_t*)calloc(1, sizeof(cfx_client_t));
    if(!ptr) return 0;
    ptr->cef_client.base.size = sizeof(cef_client_t);
    ptr->cef_client.base.add_ref = _cfx_client_add_ref;
    ptr->cef_client.base.release = _cfx_client_release;
    ptr->cef_client.base.has_one_ref = _cfx_client_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_client_get_gc_handle(cfx_client_t* self) {
    return self->gc_handle;
}

// get_context_menu_handler

cef_context_menu_handler_t* CEF_CALLBACK cfx_client_get_context_menu_handler(cef_client_t* self) {
    cef_context_menu_handler_t* __retval;
    ((cfx_client_t*)self)->get_context_menu_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_dialog_handler

cef_dialog_handler_t* CEF_CALLBACK cfx_client_get_dialog_handler(cef_client_t* self) {
    cef_dialog_handler_t* __retval;
    ((cfx_client_t*)self)->get_dialog_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_display_handler

cef_display_handler_t* CEF_CALLBACK cfx_client_get_display_handler(cef_client_t* self) {
    cef_display_handler_t* __retval;
    ((cfx_client_t*)self)->get_display_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_download_handler

cef_download_handler_t* CEF_CALLBACK cfx_client_get_download_handler(cef_client_t* self) {
    cef_download_handler_t* __retval;
    ((cfx_client_t*)self)->get_download_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_drag_handler

cef_drag_handler_t* CEF_CALLBACK cfx_client_get_drag_handler(cef_client_t* self) {
    cef_drag_handler_t* __retval;
    ((cfx_client_t*)self)->get_drag_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_find_handler

cef_find_handler_t* CEF_CALLBACK cfx_client_get_find_handler(cef_client_t* self) {
    cef_find_handler_t* __retval;
    ((cfx_client_t*)self)->get_find_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_focus_handler

cef_focus_handler_t* CEF_CALLBACK cfx_client_get_focus_handler(cef_client_t* self) {
    cef_focus_handler_t* __retval;
    ((cfx_client_t*)self)->get_focus_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_geolocation_handler

cef_geolocation_handler_t* CEF_CALLBACK cfx_client_get_geolocation_handler(cef_client_t* self) {
    cef_geolocation_handler_t* __retval;
    ((cfx_client_t*)self)->get_geolocation_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_jsdialog_handler

cef_jsdialog_handler_t* CEF_CALLBACK cfx_client_get_jsdialog_handler(cef_client_t* self) {
    cef_jsdialog_handler_t* __retval;
    ((cfx_client_t*)self)->get_jsdialog_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_keyboard_handler

cef_keyboard_handler_t* CEF_CALLBACK cfx_client_get_keyboard_handler(cef_client_t* self) {
    cef_keyboard_handler_t* __retval;
    ((cfx_client_t*)self)->get_keyboard_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_life_span_handler

cef_life_span_handler_t* CEF_CALLBACK cfx_client_get_life_span_handler(cef_client_t* self) {
    cef_life_span_handler_t* __retval;
    ((cfx_client_t*)self)->get_life_span_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_load_handler

cef_load_handler_t* CEF_CALLBACK cfx_client_get_load_handler(cef_client_t* self) {
    cef_load_handler_t* __retval;
    ((cfx_client_t*)self)->get_load_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_render_handler

cef_render_handler_t* CEF_CALLBACK cfx_client_get_render_handler(cef_client_t* self) {
    cef_render_handler_t* __retval;
    ((cfx_client_t*)self)->get_render_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_request_handler

cef_request_handler_t* CEF_CALLBACK cfx_client_get_request_handler(cef_client_t* self) {
    cef_request_handler_t* __retval;
    ((cfx_client_t*)self)->get_request_handler(((cfx_client_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// on_process_message_received

int CEF_CALLBACK cfx_client_on_process_message_received(cef_client_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    int browser_release;
    int message_release;
    ((cfx_client_t*)self)->on_process_message_received(((cfx_client_t*)self)->gc_handle, &__retval, browser, &browser_release, source_process, message, &message_release);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    if(message_release) message->base.release((cef_base_t*)message);
    return __retval;
}

static void cfx_client_set_callback(cef_client_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_client_t*)self)->get_context_menu_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_context_menu_handler_t** __retval))callback;
        self->get_context_menu_handler = callback ? cfx_client_get_context_menu_handler : 0;
        break;
    case 1:
        ((cfx_client_t*)self)->get_dialog_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_dialog_handler_t** __retval))callback;
        self->get_dialog_handler = callback ? cfx_client_get_dialog_handler : 0;
        break;
    case 2:
        ((cfx_client_t*)self)->get_display_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_display_handler_t** __retval))callback;
        self->get_display_handler = callback ? cfx_client_get_display_handler : 0;
        break;
    case 3:
        ((cfx_client_t*)self)->get_download_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_download_handler_t** __retval))callback;
        self->get_download_handler = callback ? cfx_client_get_download_handler : 0;
        break;
    case 4:
        ((cfx_client_t*)self)->get_drag_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_drag_handler_t** __retval))callback;
        self->get_drag_handler = callback ? cfx_client_get_drag_handler : 0;
        break;
    case 5:
        ((cfx_client_t*)self)->get_find_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_find_handler_t** __retval))callback;
        self->get_find_handler = callback ? cfx_client_get_find_handler : 0;
        break;
    case 6:
        ((cfx_client_t*)self)->get_focus_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_focus_handler_t** __retval))callback;
        self->get_focus_handler = callback ? cfx_client_get_focus_handler : 0;
        break;
    case 7:
        ((cfx_client_t*)self)->get_geolocation_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_geolocation_handler_t** __retval))callback;
        self->get_geolocation_handler = callback ? cfx_client_get_geolocation_handler : 0;
        break;
    case 8:
        ((cfx_client_t*)self)->get_jsdialog_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_jsdialog_handler_t** __retval))callback;
        self->get_jsdialog_handler = callback ? cfx_client_get_jsdialog_handler : 0;
        break;
    case 9:
        ((cfx_client_t*)self)->get_keyboard_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_keyboard_handler_t** __retval))callback;
        self->get_keyboard_handler = callback ? cfx_client_get_keyboard_handler : 0;
        break;
    case 10:
        ((cfx_client_t*)self)->get_life_span_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_life_span_handler_t** __retval))callback;
        self->get_life_span_handler = callback ? cfx_client_get_life_span_handler : 0;
        break;
    case 11:
        ((cfx_client_t*)self)->get_load_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval))callback;
        self->get_load_handler = callback ? cfx_client_get_load_handler : 0;
        break;
    case 12:
        ((cfx_client_t*)self)->get_render_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_render_handler_t** __retval))callback;
        self->get_render_handler = callback ? cfx_client_get_render_handler : 0;
        break;
    case 13:
        ((cfx_client_t*)self)->get_request_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_request_handler_t** __retval))callback;
        self->get_request_handler = callback ? cfx_client_get_request_handler : 0;
        break;
    case 14:
        ((cfx_client_t*)self)->on_process_message_received = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_process_id_t source_process, cef_process_message_t* message, int *message_release))callback;
        self->on_process_message_received = callback ? cfx_client_on_process_message_received : 0;
        break;
    }
}

