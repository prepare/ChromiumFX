// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_cookie_visitor

typedef struct _cfx_cookie_visitor_t {
    cef_cookie_visitor_t cef_cookie_visitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *visit)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie, int count, int total, int* deleteCookie);
} cfx_cookie_visitor_t;

void CEF_CALLBACK _cfx_cookie_visitor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_cookie_visitor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_cookie_visitor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_cookie_visitor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_cookie_visitor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_cookie_visitor_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_cookie_visitor_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_cookie_visitor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_cookie_visitor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_cookie_visitor_t* cfx_cookie_visitor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_cookie_visitor_t* ptr = (cfx_cookie_visitor_t*)calloc(1, sizeof(cfx_cookie_visitor_t));
    if(!ptr) return 0;
    ptr->cef_cookie_visitor.base.size = sizeof(cef_cookie_visitor_t);
    ptr->cef_cookie_visitor.base.add_ref = _cfx_cookie_visitor_add_ref;
    ptr->cef_cookie_visitor.base.release = _cfx_cookie_visitor_release;
    ptr->cef_cookie_visitor.base.has_one_ref = _cfx_cookie_visitor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_cookie_visitor_get_gc_handle(cfx_cookie_visitor_t* self) {
    return self->gc_handle;
}

// visit

int CEF_CALLBACK cfx_cookie_visitor_visit(cef_cookie_visitor_t* self, const cef_cookie_t* cookie, int count, int total, int* deleteCookie) {
    int __retval;
    ((cfx_cookie_visitor_t*)self)->visit(((cfx_cookie_visitor_t*)self)->gc_handle, &__retval, cookie, count, total, deleteCookie);
    return __retval;
}

static void cfx_cookie_visitor_set_callback(cef_cookie_visitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_cookie_visitor_t*)self)->visit = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie, int count, int total, int* deleteCookie))callback;
        self->visit = callback ? cfx_cookie_visitor_visit : 0;
        break;
    }
}

