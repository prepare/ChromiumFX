// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_string_visitor

typedef struct _cfx_string_visitor_t {
    cef_string_visitor_t cef_string_visitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *visit)(gc_handle_t self, char16 *string_str, int string_length);
} cfx_string_visitor_t;

void CEF_CALLBACK _cfx_string_visitor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_string_visitor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_string_visitor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_string_visitor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_string_visitor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_string_visitor_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_string_visitor_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_string_visitor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_string_visitor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_string_visitor_t* cfx_string_visitor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_string_visitor_t* ptr = (cfx_string_visitor_t*)calloc(1, sizeof(cfx_string_visitor_t));
    if(!ptr) return 0;
    ptr->cef_string_visitor.base.size = sizeof(cef_string_visitor_t);
    ptr->cef_string_visitor.base.add_ref = _cfx_string_visitor_add_ref;
    ptr->cef_string_visitor.base.release = _cfx_string_visitor_release;
    ptr->cef_string_visitor.base.has_one_ref = _cfx_string_visitor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_string_visitor_get_gc_handle(cfx_string_visitor_t* self) {
    return self->gc_handle;
}

// visit

void CEF_CALLBACK cfx_string_visitor_visit(cef_string_visitor_t* self, const cef_string_t* string) {
    ((cfx_string_visitor_t*)self)->visit(((cfx_string_visitor_t*)self)->gc_handle, string ? string->str : 0, string ? (int)string->length : 0);
}

static void cfx_string_visitor_set_callback(cef_string_visitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_string_visitor_t*)self)->visit = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *string_str, int string_length))callback;
        self->visit = callback ? cfx_string_visitor_visit : 0;
        break;
    }
}

