// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_response_filter

typedef struct _cfx_response_filter_t {
    cef_response_filter_t cef_response_filter;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *init_filter)(gc_handle_t self, int* __retval);
    void (CEF_CALLBACK *filter)(gc_handle_t self, cef_response_filter_status_t* __retval, void* data_in, size_t data_in_size, size_t* data_in_read, void* data_out, size_t data_out_size, size_t* data_out_written);
} cfx_response_filter_t;

void CEF_CALLBACK _cfx_response_filter_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_response_filter_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_response_filter_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_response_filter_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_response_filter_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_response_filter_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_response_filter_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_response_filter_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_response_filter_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_response_filter_t* cfx_response_filter_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_response_filter_t* ptr = (cfx_response_filter_t*)calloc(1, sizeof(cfx_response_filter_t));
    if(!ptr) return 0;
    ptr->cef_response_filter.base.size = sizeof(cef_response_filter_t);
    ptr->cef_response_filter.base.add_ref = _cfx_response_filter_add_ref;
    ptr->cef_response_filter.base.release = _cfx_response_filter_release;
    ptr->cef_response_filter.base.has_one_ref = _cfx_response_filter_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_response_filter_get_gc_handle(cfx_response_filter_t* self) {
    return self->gc_handle;
}

// init_filter

int CEF_CALLBACK cfx_response_filter_init_filter(cef_response_filter_t* self) {
    int __retval;
    ((cfx_response_filter_t*)self)->init_filter(((cfx_response_filter_t*)self)->gc_handle, &__retval);
    return __retval;
}

// filter

cef_response_filter_status_t CEF_CALLBACK cfx_response_filter_filter(cef_response_filter_t* self, void* data_in, size_t data_in_size, size_t* data_in_read, void* data_out, size_t data_out_size, size_t* data_out_written) {
    cef_response_filter_status_t __retval;
    ((cfx_response_filter_t*)self)->filter(((cfx_response_filter_t*)self)->gc_handle, &__retval, data_in, data_in_size, data_in_read, data_out, data_out_size, data_out_written);
    return __retval;
}

static void cfx_response_filter_set_callback(cef_response_filter_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_response_filter_t*)self)->init_filter = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval))callback;
        self->init_filter = callback ? cfx_response_filter_init_filter : 0;
        break;
    case 1:
        ((cfx_response_filter_t*)self)->filter = (void (CEF_CALLBACK *)(gc_handle_t self, cef_response_filter_status_t* __retval, void* data_in, size_t data_in_size, size_t* data_in_read, void* data_out, size_t data_out_size, size_t* data_out_written))callback;
        self->filter = callback ? cfx_response_filter_filter : 0;
        break;
    }
}

