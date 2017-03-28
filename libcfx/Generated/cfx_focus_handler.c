// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_focus_handler

typedef struct _cfx_focus_handler_t {
    cef_focus_handler_t cef_focus_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_take_focus)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int next);
    void (CEF_CALLBACK *on_set_focus)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_focus_source_t source);
    void (CEF_CALLBACK *on_got_focus)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
} cfx_focus_handler_t;

void CEF_CALLBACK _cfx_focus_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_focus_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_focus_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_focus_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_focus_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_focus_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_focus_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_focus_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_focus_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_focus_handler_t* cfx_focus_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_focus_handler_t* ptr = (cfx_focus_handler_t*)calloc(1, sizeof(cfx_focus_handler_t));
    if(!ptr) return 0;
    ptr->cef_focus_handler.base.size = sizeof(cef_focus_handler_t);
    ptr->cef_focus_handler.base.add_ref = _cfx_focus_handler_add_ref;
    ptr->cef_focus_handler.base.release = _cfx_focus_handler_release;
    ptr->cef_focus_handler.base.has_one_ref = _cfx_focus_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_take_focus

void CEF_CALLBACK cfx_focus_handler_on_take_focus(cef_focus_handler_t* self, cef_browser_t* browser, int next) {
    int browser_release;
    ((cfx_focus_handler_t*)self)->on_take_focus(((cfx_focus_handler_t*)self)->gc_handle, browser, &browser_release, next);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_set_focus

int CEF_CALLBACK cfx_focus_handler_on_set_focus(cef_focus_handler_t* self, cef_browser_t* browser, cef_focus_source_t source) {
    int __retval;
    int browser_release;
    ((cfx_focus_handler_t*)self)->on_set_focus(((cfx_focus_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, source);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    return __retval;
}

// on_got_focus

void CEF_CALLBACK cfx_focus_handler_on_got_focus(cef_focus_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_focus_handler_t*)self)->on_got_focus(((cfx_focus_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

static void cfx_focus_handler_set_callback(cef_focus_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_focus_handler_t*)self)->on_take_focus = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int next))callback;
        self->on_take_focus = callback ? cfx_focus_handler_on_take_focus : 0;
        break;
    case 1:
        ((cfx_focus_handler_t*)self)->on_set_focus = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_focus_source_t source))callback;
        self->on_set_focus = callback ? cfx_focus_handler_on_set_focus : 0;
        break;
    case 2:
        ((cfx_focus_handler_t*)self)->on_got_focus = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_got_focus = callback ? cfx_focus_handler_on_got_focus : 0;
        break;
    }
}

