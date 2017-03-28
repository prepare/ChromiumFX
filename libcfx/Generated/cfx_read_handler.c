// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_read_handler

typedef struct _cfx_read_handler_t {
    cef_read_handler_t cef_read_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *read)(gc_handle_t self, size_t* __retval, void* ptr, size_t size, size_t n);
    void (CEF_CALLBACK *seek)(gc_handle_t self, int* __retval, int64 offset, int whence);
    void (CEF_CALLBACK *tell)(gc_handle_t self, int64* __retval);
    void (CEF_CALLBACK *eof)(gc_handle_t self, int* __retval);
    void (CEF_CALLBACK *may_block)(gc_handle_t self, int* __retval);
} cfx_read_handler_t;

void CEF_CALLBACK _cfx_read_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_read_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_read_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_read_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_read_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_read_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_read_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_read_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_read_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_read_handler_t* cfx_read_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_read_handler_t* ptr = (cfx_read_handler_t*)calloc(1, sizeof(cfx_read_handler_t));
    if(!ptr) return 0;
    ptr->cef_read_handler.base.size = sizeof(cef_read_handler_t);
    ptr->cef_read_handler.base.add_ref = _cfx_read_handler_add_ref;
    ptr->cef_read_handler.base.release = _cfx_read_handler_release;
    ptr->cef_read_handler.base.has_one_ref = _cfx_read_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// read

size_t CEF_CALLBACK cfx_read_handler_read(cef_read_handler_t* self, void* ptr, size_t size, size_t n) {
    size_t __retval;
    ((cfx_read_handler_t*)self)->read(((cfx_read_handler_t*)self)->gc_handle, &__retval, ptr, size, n);
    return __retval;
}

// seek

int CEF_CALLBACK cfx_read_handler_seek(cef_read_handler_t* self, int64 offset, int whence) {
    int __retval;
    ((cfx_read_handler_t*)self)->seek(((cfx_read_handler_t*)self)->gc_handle, &__retval, offset, whence);
    return __retval;
}

// tell

int64 CEF_CALLBACK cfx_read_handler_tell(cef_read_handler_t* self) {
    int64 __retval;
    ((cfx_read_handler_t*)self)->tell(((cfx_read_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}

// eof

int CEF_CALLBACK cfx_read_handler_eof(cef_read_handler_t* self) {
    int __retval;
    ((cfx_read_handler_t*)self)->eof(((cfx_read_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}

// may_block

int CEF_CALLBACK cfx_read_handler_may_block(cef_read_handler_t* self) {
    int __retval;
    ((cfx_read_handler_t*)self)->may_block(((cfx_read_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}

static void cfx_read_handler_set_callback(cef_read_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_read_handler_t*)self)->read = (void (CEF_CALLBACK *)(gc_handle_t self, size_t* __retval, void* ptr, size_t size, size_t n))callback;
        self->read = callback ? cfx_read_handler_read : 0;
        break;
    case 1:
        ((cfx_read_handler_t*)self)->seek = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int64 offset, int whence))callback;
        self->seek = callback ? cfx_read_handler_seek : 0;
        break;
    case 2:
        ((cfx_read_handler_t*)self)->tell = (void (CEF_CALLBACK *)(gc_handle_t self, int64* __retval))callback;
        self->tell = callback ? cfx_read_handler_tell : 0;
        break;
    case 3:
        ((cfx_read_handler_t*)self)->eof = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval))callback;
        self->eof = callback ? cfx_read_handler_eof : 0;
        break;
    case 4:
        ((cfx_read_handler_t*)self)->may_block = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval))callback;
        self->may_block = callback ? cfx_read_handler_may_block : 0;
        break;
    }
}

