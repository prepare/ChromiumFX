// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_write_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_write_handler_t {
    cef_write_handler_t cef_write_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_write_handler_t;

void CEF_CALLBACK _cfx_write_handler_add_ref(struct _cef_base_t* base) {
    cfx_write_handler_t* ptr = (cfx_write_handler_t*)base;
    InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_write_handler_release(struct _cef_base_t* base) {
    cfx_write_handler_t* ptr = (cfx_write_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_write_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_write_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}

CFX_EXPORT cfx_write_handler_t* cfx_write_handler_ctor(gc_handle_t gc_handle) {
    cfx_write_handler_t* ptr = (cfx_write_handler_t*)calloc(1, sizeof(cfx_write_handler_t));
    if(!ptr) return 0;
    ptr->cef_write_handler.base.size = sizeof(cef_write_handler_t);
    ptr->cef_write_handler.base.add_ref = _cfx_write_handler_add_ref;
    ptr->cef_write_handler.base.release = _cfx_write_handler_release;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_write_handler_get_gc_handle(cfx_write_handler_t* self) {
    return self->gc_handle;
}

// write

void (CEF_CALLBACK *cfx_write_handler_write_callback)(gc_handle_t self, int* __retval, const void* ptr, int size, int n);

size_t CEF_CALLBACK cfx_write_handler_write(cef_write_handler_t* self, const void* ptr, size_t size, size_t n) {
    int __retval;
    cfx_write_handler_write_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval, ptr, (int)(size), (int)(n));
    return __retval;
}


// seek

void (CEF_CALLBACK *cfx_write_handler_seek_callback)(gc_handle_t self, int* __retval, int64 offset, int whence);

int CEF_CALLBACK cfx_write_handler_seek(cef_write_handler_t* self, int64 offset, int whence) {
    int __retval;
    cfx_write_handler_seek_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval, offset, whence);
    return __retval;
}


// tell

void (CEF_CALLBACK *cfx_write_handler_tell_callback)(gc_handle_t self, int64* __retval);

int64 CEF_CALLBACK cfx_write_handler_tell(cef_write_handler_t* self) {
    int64 __retval;
    cfx_write_handler_tell_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


// flush

void (CEF_CALLBACK *cfx_write_handler_flush_callback)(gc_handle_t self, int* __retval);

int CEF_CALLBACK cfx_write_handler_flush(cef_write_handler_t* self) {
    int __retval;
    cfx_write_handler_flush_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


// may_block

void (CEF_CALLBACK *cfx_write_handler_may_block_callback)(gc_handle_t self, int* __retval);

int CEF_CALLBACK cfx_write_handler_may_block(cef_write_handler_t* self) {
    int __retval;
    cfx_write_handler_may_block_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


CFX_EXPORT void cfx_write_handler_set_managed_callback(cef_write_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_write_handler_write_callback)
            cfx_write_handler_write_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, const void* ptr, int size, int n)) callback;
        self->write = callback ? cfx_write_handler_write : 0;
        break;
    case 1:
        if(callback && !cfx_write_handler_seek_callback)
            cfx_write_handler_seek_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int64 offset, int whence)) callback;
        self->seek = callback ? cfx_write_handler_seek : 0;
        break;
    case 2:
        if(callback && !cfx_write_handler_tell_callback)
            cfx_write_handler_tell_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int64* __retval)) callback;
        self->tell = callback ? cfx_write_handler_tell : 0;
        break;
    case 3:
        if(callback && !cfx_write_handler_flush_callback)
            cfx_write_handler_flush_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval)) callback;
        self->flush = callback ? cfx_write_handler_flush : 0;
        break;
    case 4:
        if(callback && !cfx_write_handler_may_block_callback)
            cfx_write_handler_may_block_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval)) callback;
        self->may_block = callback ? cfx_write_handler_may_block : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

