// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_domvisitor

typedef struct _cfx_domvisitor_t {
    cef_domvisitor_t cef_domvisitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *visit)(gc_handle_t self, cef_domdocument_t* document, int *document_release);
} cfx_domvisitor_t;

void CEF_CALLBACK _cfx_domvisitor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_domvisitor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_domvisitor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_domvisitor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_domvisitor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_domvisitor_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_domvisitor_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_domvisitor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_domvisitor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_domvisitor_t* cfx_domvisitor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_domvisitor_t* ptr = (cfx_domvisitor_t*)calloc(1, sizeof(cfx_domvisitor_t));
    if(!ptr) return 0;
    ptr->cef_domvisitor.base.size = sizeof(cef_domvisitor_t);
    ptr->cef_domvisitor.base.add_ref = _cfx_domvisitor_add_ref;
    ptr->cef_domvisitor.base.release = _cfx_domvisitor_release;
    ptr->cef_domvisitor.base.has_one_ref = _cfx_domvisitor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_domvisitor_get_gc_handle(cfx_domvisitor_t* self) {
    return self->gc_handle;
}

// visit

void CEF_CALLBACK cfx_domvisitor_visit(cef_domvisitor_t* self, cef_domdocument_t* document) {
    int document_release;
    ((cfx_domvisitor_t*)self)->visit(((cfx_domvisitor_t*)self)->gc_handle, document, &document_release);
    if(document_release) document->base.release((cef_base_ref_counted_t*)document);
}

static void cfx_domvisitor_set_callback(cef_domvisitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_domvisitor_t*)self)->visit = (void (CEF_CALLBACK *)(gc_handle_t self, cef_domdocument_t* document, int *document_release))callback;
        self->visit = callback ? cfx_domvisitor_visit : 0;
        break;
    }
}

