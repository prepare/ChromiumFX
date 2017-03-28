// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_navigation_entry_visitor

typedef struct _cfx_navigation_entry_visitor_t {
    cef_navigation_entry_visitor_t cef_navigation_entry_visitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *visit)(gc_handle_t self, int* __retval, cef_navigation_entry_t* entry, int *entry_release, int current, int index, int total);
} cfx_navigation_entry_visitor_t;

void CEF_CALLBACK _cfx_navigation_entry_visitor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_navigation_entry_visitor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_navigation_entry_visitor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_navigation_entry_visitor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_navigation_entry_visitor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_navigation_entry_visitor_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_navigation_entry_visitor_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_navigation_entry_visitor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_navigation_entry_visitor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_navigation_entry_visitor_t* cfx_navigation_entry_visitor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_navigation_entry_visitor_t* ptr = (cfx_navigation_entry_visitor_t*)calloc(1, sizeof(cfx_navigation_entry_visitor_t));
    if(!ptr) return 0;
    ptr->cef_navigation_entry_visitor.base.size = sizeof(cef_navigation_entry_visitor_t);
    ptr->cef_navigation_entry_visitor.base.add_ref = _cfx_navigation_entry_visitor_add_ref;
    ptr->cef_navigation_entry_visitor.base.release = _cfx_navigation_entry_visitor_release;
    ptr->cef_navigation_entry_visitor.base.has_one_ref = _cfx_navigation_entry_visitor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// visit

int CEF_CALLBACK cfx_navigation_entry_visitor_visit(cef_navigation_entry_visitor_t* self, cef_navigation_entry_t* entry, int current, int index, int total) {
    int __retval;
    int entry_release;
    ((cfx_navigation_entry_visitor_t*)self)->visit(((cfx_navigation_entry_visitor_t*)self)->gc_handle, &__retval, entry, &entry_release, current, index, total);
    if(entry_release) entry->base.release((cef_base_ref_counted_t*)entry);
    return __retval;
}

static void cfx_navigation_entry_visitor_set_callback(cef_navigation_entry_visitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_navigation_entry_visitor_t*)self)->visit = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_navigation_entry_t* entry, int *entry_release, int current, int index, int total))callback;
        self->visit = callback ? cfx_navigation_entry_visitor_visit : 0;
        break;
    }
}

