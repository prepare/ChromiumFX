// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_scheme_handler_factory

typedef struct _cfx_scheme_handler_factory_t {
    cef_scheme_handler_factory_t cef_scheme_handler_factory;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *create)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *scheme_name_str, int scheme_name_length, cef_request_t* request, int *request_release);
} cfx_scheme_handler_factory_t;

void CEF_CALLBACK _cfx_scheme_handler_factory_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_scheme_handler_factory_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_scheme_handler_factory_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_scheme_handler_factory_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_scheme_handler_factory_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_scheme_handler_factory_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_scheme_handler_factory_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_scheme_handler_factory_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_scheme_handler_factory_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_scheme_handler_factory_t* cfx_scheme_handler_factory_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_scheme_handler_factory_t* ptr = (cfx_scheme_handler_factory_t*)calloc(1, sizeof(cfx_scheme_handler_factory_t));
    if(!ptr) return 0;
    ptr->cef_scheme_handler_factory.base.size = sizeof(cef_scheme_handler_factory_t);
    ptr->cef_scheme_handler_factory.base.add_ref = _cfx_scheme_handler_factory_add_ref;
    ptr->cef_scheme_handler_factory.base.release = _cfx_scheme_handler_factory_release;
    ptr->cef_scheme_handler_factory.base.has_one_ref = _cfx_scheme_handler_factory_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// create

cef_resource_handler_t* CEF_CALLBACK cfx_scheme_handler_factory_create(cef_scheme_handler_factory_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* scheme_name, cef_request_t* request) {
    cef_resource_handler_t* __retval;
    int browser_release;
    int frame_release;
    int request_release;
    ((cfx_scheme_handler_factory_t*)self)->create(((cfx_scheme_handler_factory_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, scheme_name ? scheme_name->str : 0, scheme_name ? (int)scheme_name->length : 0, request, &request_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release && request) request->base.release((cef_base_ref_counted_t*)request);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

static void cfx_scheme_handler_factory_set_callback(cef_scheme_handler_factory_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_scheme_handler_factory_t*)self)->create = (void (CEF_CALLBACK *)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *scheme_name_str, int scheme_name_length, cef_request_t* request, int *request_release))callback;
        self->create = callback ? cfx_scheme_handler_factory_create : 0;
        break;
    }
}

