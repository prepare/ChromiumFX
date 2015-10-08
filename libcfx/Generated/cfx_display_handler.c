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


// cef_display_handler

typedef struct _cfx_display_handler_t {
    cef_display_handler_t cef_display_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_display_handler_t;

void CEF_CALLBACK _cfx_display_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_display_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_display_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_display_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_display_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_display_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_display_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_display_handler_t* cfx_display_handler_ctor(gc_handle_t gc_handle) {
    cfx_display_handler_t* ptr = (cfx_display_handler_t*)calloc(1, sizeof(cfx_display_handler_t));
    if(!ptr) return 0;
    ptr->cef_display_handler.base.size = sizeof(cef_display_handler_t);
    ptr->cef_display_handler.base.add_ref = _cfx_display_handler_add_ref;
    ptr->cef_display_handler.base.release = _cfx_display_handler_release;
    ptr->cef_display_handler.base.has_one_ref = _cfx_display_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_display_handler_get_gc_handle(cfx_display_handler_t* self) {
    return self->gc_handle;
}

// on_address_change

void (CEF_CALLBACK *cfx_display_handler_on_address_change_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, char16 *url_str, int url_length);

void CEF_CALLBACK cfx_display_handler_on_address_change(cef_display_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* url) {
    cfx_display_handler_on_address_change_callback(((cfx_display_handler_t*)self)->gc_handle, browser, frame, url ? url->str : 0, url ? (int)url->length : 0);
}


// on_title_change

void (CEF_CALLBACK *cfx_display_handler_on_title_change_callback)(gc_handle_t self, cef_browser_t* browser, char16 *title_str, int title_length);

void CEF_CALLBACK cfx_display_handler_on_title_change(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* title) {
    cfx_display_handler_on_title_change_callback(((cfx_display_handler_t*)self)->gc_handle, browser, title ? title->str : 0, title ? (int)title->length : 0);
}


// on_favicon_urlchange

void (CEF_CALLBACK *cfx_display_handler_on_favicon_urlchange_callback)(gc_handle_t self, cef_browser_t* browser, cef_string_list_t icon_urls);

void CEF_CALLBACK cfx_display_handler_on_favicon_urlchange(cef_display_handler_t* self, cef_browser_t* browser, cef_string_list_t icon_urls) {
    cfx_display_handler_on_favicon_urlchange_callback(((cfx_display_handler_t*)self)->gc_handle, browser, icon_urls);
}


// on_fullscreen_mode_change

void (CEF_CALLBACK *cfx_display_handler_on_fullscreen_mode_change_callback)(gc_handle_t self, cef_browser_t* browser, int fullscreen);

void CEF_CALLBACK cfx_display_handler_on_fullscreen_mode_change(cef_display_handler_t* self, cef_browser_t* browser, int fullscreen) {
    cfx_display_handler_on_fullscreen_mode_change_callback(((cfx_display_handler_t*)self)->gc_handle, browser, fullscreen);
}


// on_tooltip

void (CEF_CALLBACK *cfx_display_handler_on_tooltip_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 **text_str, int *text_length);

int CEF_CALLBACK cfx_display_handler_on_tooltip(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* text) {
    int __retval;
    char16* text_tmp_str = text->str; int text_tmp_length = (int)text->length;
    cfx_display_handler_on_tooltip_callback(((cfx_display_handler_t*)self)->gc_handle, &__retval, browser, &(text_tmp_str), &(text_tmp_length));
    if(text_tmp_str != text->str) {
        if(text->dtor) text->dtor(text->str);
        cef_string_set(text_tmp_str, text_tmp_length, text, 1);
        cfx_gc_handle_free((gc_handle_t)text_tmp_str);
    }
    return __retval;
}


// on_status_message

void (CEF_CALLBACK *cfx_display_handler_on_status_message_callback)(gc_handle_t self, cef_browser_t* browser, char16 *value_str, int value_length);

void CEF_CALLBACK cfx_display_handler_on_status_message(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* value) {
    cfx_display_handler_on_status_message_callback(((cfx_display_handler_t*)self)->gc_handle, browser, value ? value->str : 0, value ? (int)value->length : 0);
}


// on_console_message

void (CEF_CALLBACK *cfx_display_handler_on_console_message_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *message_str, int message_length, char16 *source_str, int source_length, int line);

int CEF_CALLBACK cfx_display_handler_on_console_message(cef_display_handler_t* self, cef_browser_t* browser, const cef_string_t* message, const cef_string_t* source, int line) {
    int __retval;
    cfx_display_handler_on_console_message_callback(((cfx_display_handler_t*)self)->gc_handle, &__retval, browser, message ? message->str : 0, message ? (int)message->length : 0, source ? source->str : 0, source ? (int)source->length : 0, line);
    return __retval;
}


static void cfx_display_handler_set_managed_callback(cef_display_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_display_handler_on_address_change_callback)
            cfx_display_handler_on_address_change_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, char16 *url_str, int url_length)) callback;
        self->on_address_change = callback ? cfx_display_handler_on_address_change : 0;
        break;
    case 1:
        if(callback && !cfx_display_handler_on_title_change_callback)
            cfx_display_handler_on_title_change_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *title_str, int title_length)) callback;
        self->on_title_change = callback ? cfx_display_handler_on_title_change : 0;
        break;
    case 2:
        if(callback && !cfx_display_handler_on_favicon_urlchange_callback)
            cfx_display_handler_on_favicon_urlchange_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_string_list_t icon_urls)) callback;
        self->on_favicon_urlchange = callback ? cfx_display_handler_on_favicon_urlchange : 0;
        break;
    case 3:
        if(callback && !cfx_display_handler_on_fullscreen_mode_change_callback)
            cfx_display_handler_on_fullscreen_mode_change_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int fullscreen)) callback;
        self->on_fullscreen_mode_change = callback ? cfx_display_handler_on_fullscreen_mode_change : 0;
        break;
    case 4:
        if(callback && !cfx_display_handler_on_tooltip_callback)
            cfx_display_handler_on_tooltip_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 **text_str, int *text_length)) callback;
        self->on_tooltip = callback ? cfx_display_handler_on_tooltip : 0;
        break;
    case 5:
        if(callback && !cfx_display_handler_on_status_message_callback)
            cfx_display_handler_on_status_message_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *value_str, int value_length)) callback;
        self->on_status_message = callback ? cfx_display_handler_on_status_message : 0;
        break;
    case 6:
        if(callback && !cfx_display_handler_on_console_message_callback)
            cfx_display_handler_on_console_message_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *message_str, int message_length, char16 *source_str, int source_length, int line)) callback;
        self->on_console_message = callback ? cfx_display_handler_on_console_message : 0;
        break;
    }
}

