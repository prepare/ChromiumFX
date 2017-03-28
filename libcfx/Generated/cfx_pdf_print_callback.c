// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_pdf_print_callback

typedef struct _cfx_pdf_print_callback_t {
    cef_pdf_print_callback_t cef_pdf_print_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_pdf_print_finished)(gc_handle_t self, char16 *path_str, int path_length, int ok);
} cfx_pdf_print_callback_t;

void CEF_CALLBACK _cfx_pdf_print_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_pdf_print_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_pdf_print_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_pdf_print_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_pdf_print_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_pdf_print_callback_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_pdf_print_callback_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_pdf_print_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_pdf_print_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_pdf_print_callback_t* cfx_pdf_print_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_pdf_print_callback_t* ptr = (cfx_pdf_print_callback_t*)calloc(1, sizeof(cfx_pdf_print_callback_t));
    if(!ptr) return 0;
    ptr->cef_pdf_print_callback.base.size = sizeof(cef_pdf_print_callback_t);
    ptr->cef_pdf_print_callback.base.add_ref = _cfx_pdf_print_callback_add_ref;
    ptr->cef_pdf_print_callback.base.release = _cfx_pdf_print_callback_release;
    ptr->cef_pdf_print_callback.base.has_one_ref = _cfx_pdf_print_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_pdf_print_finished

void CEF_CALLBACK cfx_pdf_print_callback_on_pdf_print_finished(cef_pdf_print_callback_t* self, const cef_string_t* path, int ok) {
    ((cfx_pdf_print_callback_t*)self)->on_pdf_print_finished(((cfx_pdf_print_callback_t*)self)->gc_handle, path ? path->str : 0, path ? (int)path->length : 0, ok);
}

static void cfx_pdf_print_callback_set_callback(cef_pdf_print_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_pdf_print_callback_t*)self)->on_pdf_print_finished = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *path_str, int path_length, int ok))callback;
        self->on_pdf_print_finished = callback ? cfx_pdf_print_callback_on_pdf_print_finished : 0;
        break;
    }
}

