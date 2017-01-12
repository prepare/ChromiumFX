// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_display_handler

typedef struct _cfx_display_handler_t {
    cef_display_handler_t cef_display_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_address_change)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *url_str, int url_length);
    void (CEF_CALLBACK *on_title_change)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *title_str, int title_length);
    void (CEF_CALLBACK *on_favicon_urlchange)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_string_list_t icon_urls);
    void (CEF_CALLBACK *on_fullscreen_mode_change)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int fullscreen);
    void (CEF_CALLBACK *on_tooltip)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 **text_str, int *text_length);
    void (CEF_CALLBACK *on_status_message)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *value_str, int value_length);
    void (CEF_CALLBACK *on_console_message)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *message_str, int message_length, char16 *source_str, int source_length, int line);
} cfx_display_handler_t;

void CEF_CALLBACK _cfx_display_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_display_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_display_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_display_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_display_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_display_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_display_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_display_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_display_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_display_handler_t* cfx_display_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_display_handler_t* ptr = (cfx_display_handler_t*)calloc(1, sizeof(cfx_display_handler_t));
    if(!ptr) return 0;
    ptr->cef_display_handler.base.size = sizeof(cef_display_handler_t);
    ptr->cef_display_handler.base.add_ref = _cfx_display_handler_add_ref;
    ptr->cef_display_handler.base.release = _cfx_display_handler_release;
    ptr->cef_display_handler.base.has_one_ref = _cfx_display_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_display_handler_get_gc_handle(cfx_display_handler_t* self) {
    return self->gc_handle;
}

// on_address_change

void CEF_CALLBACK cfx_display_handler_on_address_change(cef_display_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* url) {
    int browser_release;
    int frame_release;
    ((cfx_display_handler_t*)self)->on_address_change(((cfx_display_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, url ? url->str : 0, url ? (int)url->length : 0);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    if(frame_release) frame->base.release((cef_base_t*)frame);
}

// on_title_change

void CEF_CALLBACK cfx_display_handler_on_title_change(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* title) {
    int browser_release;
    ((cfx_display_handler_t*)self)->on_title_change(((cfx_display_handler_t*)self)->gc_handle, browser, &browser_release, title ? title->str : 0, title ? (int)title->length : 0);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

// on_favicon_urlchange

void CEF_CALLBACK cfx_display_handler_on_favicon_urlchange(cef_display_handler_t* self, cef_browser_t* browser, cef_string_list_t icon_urls) {
    int browser_release;
    ((cfx_display_handler_t*)self)->on_favicon_urlchange(((cfx_display_handler_t*)self)->gc_handle, browser, &browser_release, icon_urls);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

// on_fullscreen_mode_change

void CEF_CALLBACK cfx_display_handler_on_fullscreen_mode_change(cef_display_handler_t* self, cef_browser_t* browser, int fullscreen) {
    int browser_release;
    ((cfx_display_handler_t*)self)->on_fullscreen_mode_change(((cfx_display_handler_t*)self)->gc_handle, browser, &browser_release, fullscreen);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

// on_tooltip

int CEF_CALLBACK cfx_display_handler_on_tooltip(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* text) {
    int __retval;
    int browser_release;
    char16* text_tmp_str = text->str; int text_tmp_length = (int)text->length;
    ((cfx_display_handler_t*)self)->on_tooltip(((cfx_display_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, &(text_tmp_str), &(text_tmp_length));
    if(browser_release) browser->base.release((cef_base_t*)browser);
    if(text_tmp_str != text->str) {
        if(text->dtor) text->dtor(text->str);
        cef_string_set(text_tmp_str, text_tmp_length, text, 1);
        cfx_gc_handle_free((gc_handle_t)text_tmp_str);
    }
    return __retval;
}

// on_status_message

void CEF_CALLBACK cfx_display_handler_on_status_message(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* value) {
    int browser_release;
    ((cfx_display_handler_t*)self)->on_status_message(((cfx_display_handler_t*)self)->gc_handle, browser, &browser_release, value ? value->str : 0, value ? (int)value->length : 0);
    if(browser_release) browser->base.release((cef_base_t*)browser);
}

// on_console_message

int CEF_CALLBACK cfx_display_handler_on_console_message(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* message, const cef_string_t* source, int line) {
    int __retval;
    int browser_release;
    ((cfx_display_handler_t*)self)->on_console_message(((cfx_display_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, message ? message->str : 0, message ? (int)message->length : 0, source ? source->str : 0, source ? (int)source->length : 0, line);
    if(browser_release) browser->base.release((cef_base_t*)browser);
    return __retval;
}

static void cfx_display_handler_set_callback(cef_display_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_display_handler_t*)self)->on_address_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *url_str, int url_length))callback;
        self->on_address_change = callback ? cfx_display_handler_on_address_change : 0;
        break;
    case 1:
        ((cfx_display_handler_t*)self)->on_title_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *title_str, int title_length))callback;
        self->on_title_change = callback ? cfx_display_handler_on_title_change : 0;
        break;
    case 2:
        ((cfx_display_handler_t*)self)->on_favicon_urlchange = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_string_list_t icon_urls))callback;
        self->on_favicon_urlchange = callback ? cfx_display_handler_on_favicon_urlchange : 0;
        break;
    case 3:
        ((cfx_display_handler_t*)self)->on_fullscreen_mode_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int fullscreen))callback;
        self->on_fullscreen_mode_change = callback ? cfx_display_handler_on_fullscreen_mode_change : 0;
        break;
    case 4:
        ((cfx_display_handler_t*)self)->on_tooltip = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 **text_str, int *text_length))callback;
        self->on_tooltip = callback ? cfx_display_handler_on_tooltip : 0;
        break;
    case 5:
        ((cfx_display_handler_t*)self)->on_status_message = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *value_str, int value_length))callback;
        self->on_status_message = callback ? cfx_display_handler_on_status_message : 0;
        break;
    case 6:
        ((cfx_display_handler_t*)self)->on_console_message = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *message_str, int message_length, char16 *source_str, int source_length, int line))callback;
        self->on_console_message = callback ? cfx_display_handler_on_console_message : 0;
        break;
    }
}

