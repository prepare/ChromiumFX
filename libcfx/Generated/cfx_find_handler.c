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


// cef_find_handler

typedef struct _cfx_find_handler_t {
    cef_find_handler_t cef_find_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *on_find_result)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate);
} cfx_find_handler_t;

void CEF_CALLBACK _cfx_find_handler_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_find_handler_t*)base)->ref_count);
    if(count == 2) {
        ((cfx_find_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_find_handler_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_find_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_find_handler_t*)base)->ref_count);
    if(count == 1) {
        ((cfx_find_handler_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_find_handler_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_find_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_find_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_find_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_find_handler_t* cfx_find_handler_ctor(gc_handle_t gc_handle) {
    cfx_find_handler_t* ptr = (cfx_find_handler_t*)calloc(1, sizeof(cfx_find_handler_t));
    if(!ptr) return 0;
    ptr->cef_find_handler.base.size = sizeof(cef_find_handler_t);
    ptr->cef_find_handler.base.add_ref = _cfx_find_handler_add_ref;
    ptr->cef_find_handler.base.release = _cfx_find_handler_release;
    ptr->cef_find_handler.base.has_one_ref = _cfx_find_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_find_handler_get_gc_handle(cfx_find_handler_t* self) {
    return self->gc_handle;
}

// on_find_result

void CEF_CALLBACK cfx_find_handler_on_find_result(cef_find_handler_t* self, cef_browser_t* browser, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate) {
    int _release_browser;
    ((cfx_find_handler_t*)self)->on_find_result(((cfx_find_handler_t*)self)->gc_handle, browser, &_release_browser, identifier, count, selectionRect, activeMatchOrdinal, finalUpdate);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
}

static void cfx_find_handler_set_callback(cef_find_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_find_handler_t*)self)->on_find_result = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate))callback;
        self->on_find_result = callback ? cfx_find_handler_on_find_result : 0;
        break;
    }
}

