// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_find_handler

typedef struct _cfx_find_handler_t {
    cef_find_handler_t cef_find_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_find_result)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate);
} cfx_find_handler_t;

void CEF_CALLBACK _cfx_find_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_find_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_find_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_find_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_find_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_find_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_find_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_find_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_find_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_find_handler_t* cfx_find_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_find_handler_t* ptr = (cfx_find_handler_t*)calloc(1, sizeof(cfx_find_handler_t));
    if(!ptr) return 0;
    ptr->cef_find_handler.base.size = sizeof(cef_find_handler_t);
    ptr->cef_find_handler.base.add_ref = _cfx_find_handler_add_ref;
    ptr->cef_find_handler.base.release = _cfx_find_handler_release;
    ptr->cef_find_handler.base.has_one_ref = _cfx_find_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_find_handler_get_gc_handle(cfx_find_handler_t* self) {
    return self->gc_handle;
}

// on_find_result

void CEF_CALLBACK cfx_find_handler_on_find_result(cef_find_handler_t* self, cef_browser_t* browser, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate) {
    int browser_release;
    ((cfx_find_handler_t*)self)->on_find_result(((cfx_find_handler_t*)self)->gc_handle, browser, &browser_release, identifier, count, selectionRect, activeMatchOrdinal, finalUpdate);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

static void cfx_find_handler_set_callback(cef_find_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_find_handler_t*)self)->on_find_result = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, int identifier, int count, const cef_rect_t* selectionRect, int activeMatchOrdinal, int finalUpdate))callback;
        self->on_find_result = callback ? cfx_find_handler_on_find_result : 0;
        break;
    }
}

