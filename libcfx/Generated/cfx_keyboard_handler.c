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


// cef_keyboard_handler

typedef struct _cfx_keyboard_handler_t {
    cef_keyboard_handler_t cef_keyboard_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *on_pre_key_event)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut);
    void (CEF_CALLBACK *on_key_event)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, const cef_key_event_t* event, cef_event_handle_t os_event);
} cfx_keyboard_handler_t;

void CEF_CALLBACK _cfx_keyboard_handler_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_keyboard_handler_t*)base)->ref_count);
    if(count == 2) {
        cfx_set_native_reference(((cfx_keyboard_handler_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_keyboard_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_keyboard_handler_t*)base)->ref_count);
    if(count == 1) {
        cfx_set_native_reference(((cfx_keyboard_handler_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_keyboard_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_keyboard_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_keyboard_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_keyboard_handler_t* cfx_keyboard_handler_ctor(gc_handle_t gc_handle) {
    cfx_keyboard_handler_t* ptr = (cfx_keyboard_handler_t*)calloc(1, sizeof(cfx_keyboard_handler_t));
    if(!ptr) return 0;
    ptr->cef_keyboard_handler.base.size = sizeof(cef_keyboard_handler_t);
    ptr->cef_keyboard_handler.base.add_ref = _cfx_keyboard_handler_add_ref;
    ptr->cef_keyboard_handler.base.release = _cfx_keyboard_handler_release;
    ptr->cef_keyboard_handler.base.has_one_ref = _cfx_keyboard_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_keyboard_handler_get_gc_handle(cfx_keyboard_handler_t* self) {
    return self->gc_handle;
}

// on_pre_key_event

int CEF_CALLBACK cfx_keyboard_handler_on_pre_key_event(cef_keyboard_handler_t* self, cef_browser_t* browser, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut) {
    int __retval;
    int _release_browser;
    ((cfx_keyboard_handler_t*)self)->on_pre_key_event(((cfx_keyboard_handler_t*)self)->gc_handle, &__retval, browser, &_release_browser, event, os_event, is_keyboard_shortcut);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    return __retval;
}

// on_key_event

int CEF_CALLBACK cfx_keyboard_handler_on_key_event(cef_keyboard_handler_t* self, cef_browser_t* browser, const cef_key_event_t* event, cef_event_handle_t os_event) {
    int __retval;
    int _release_browser;
    ((cfx_keyboard_handler_t*)self)->on_key_event(((cfx_keyboard_handler_t*)self)->gc_handle, &__retval, browser, &_release_browser, event, os_event);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    return __retval;
}

static void cfx_keyboard_handler_set_callback(cef_keyboard_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_keyboard_handler_t*)self)->on_pre_key_event = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, const cef_key_event_t* event, cef_event_handle_t os_event, int* is_keyboard_shortcut))callback;
        self->on_pre_key_event = callback ? cfx_keyboard_handler_on_pre_key_event : 0;
        break;
    case 1:
        ((cfx_keyboard_handler_t*)self)->on_key_event = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, const cef_key_event_t* event, cef_event_handle_t os_event))callback;
        self->on_key_event = callback ? cfx_keyboard_handler_on_key_event : 0;
        break;
    }
}

