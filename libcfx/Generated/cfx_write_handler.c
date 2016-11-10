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

typedef struct _cfx_write_handler_t {
    cef_write_handler_t cef_write_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_write_handler_t;

void CEF_CALLBACK _cfx_write_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_write_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_write_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_write_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_write_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_write_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_write_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_write_handler_t* cfx_write_handler_ctor(gc_handle_t gc_handle) {
    cfx_write_handler_t* ptr = (cfx_write_handler_t*)calloc(1, sizeof(cfx_write_handler_t));
    if(!ptr) return 0;
    ptr->cef_write_handler.base.size = sizeof(cef_write_handler_t);
    ptr->cef_write_handler.base.add_ref = _cfx_write_handler_add_ref;
    ptr->cef_write_handler.base.release = _cfx_write_handler_release;
    ptr->cef_write_handler.base.has_one_ref = _cfx_write_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_write_handler_get_gc_handle(cfx_write_handler_t* self) {
    return self->gc_handle;
}

// managed callbacks
void (CEF_CALLBACK *cfx_write_handler_write_callback)(gc_handle_t self, size_t* __retval, const void* ptr, size_t size, size_t n);
void (CEF_CALLBACK *cfx_write_handler_seek_callback)(gc_handle_t self, int* __retval, int64 offset, int whence);
void (CEF_CALLBACK *cfx_write_handler_tell_callback)(gc_handle_t self, int64* __retval);
void (CEF_CALLBACK *cfx_write_handler_flush_callback)(gc_handle_t self, int* __retval);
void (CEF_CALLBACK *cfx_write_handler_may_block_callback)(gc_handle_t self, int* __retval);

static void cfx_write_handler_set_managed_callbacks(void *write, void *seek, void *tell, void *flush, void *may_block) {
    cfx_write_handler_write_callback = (void (CEF_CALLBACK *)(gc_handle_t self, size_t* __retval, const void* ptr, size_t size, size_t n)) write;
    cfx_write_handler_seek_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int64 offset, int whence)) seek;
    cfx_write_handler_tell_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int64* __retval)) tell;
    cfx_write_handler_flush_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval)) flush;
    cfx_write_handler_may_block_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval)) may_block;
}

// write

size_t CEF_CALLBACK cfx_write_handler_write(cef_write_handler_t* self, const void* ptr, size_t size, size_t n) {
    size_t __retval;
    cfx_write_handler_write_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval, ptr, size, n);
    return __retval;
}


// seek

int CEF_CALLBACK cfx_write_handler_seek(cef_write_handler_t* self, int64 offset, int whence) {
    int __retval;
    cfx_write_handler_seek_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval, offset, whence);
    return __retval;
}


// tell

int64 CEF_CALLBACK cfx_write_handler_tell(cef_write_handler_t* self) {
    int64 __retval;
    cfx_write_handler_tell_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


// flush

int CEF_CALLBACK cfx_write_handler_flush(cef_write_handler_t* self) {
    int __retval;
    cfx_write_handler_flush_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


// may_block

int CEF_CALLBACK cfx_write_handler_may_block(cef_write_handler_t* self) {
    int __retval;
    cfx_write_handler_may_block_callback(((cfx_write_handler_t*)self)->gc_handle, &__retval);
    return __retval;
}


static void cfx_write_handler_activate_callback(cef_write_handler_t* self, int index, int active) {
    switch(index) {
    case 0:
        self->write = active ? cfx_write_handler_write : 0;
        break;
    case 1:
        self->seek = active ? cfx_write_handler_seek : 0;
        break;
    case 2:
        self->tell = active ? cfx_write_handler_tell : 0;
        break;
    case 3:
        self->flush = active ? cfx_write_handler_flush : 0;
        break;
    case 4:
        self->may_block = active ? cfx_write_handler_may_block : 0;
        break;
    }
}

