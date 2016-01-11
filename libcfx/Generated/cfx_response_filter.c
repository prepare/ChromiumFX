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


// cef_response_filter

typedef struct _cfx_response_filter_t {
    cef_response_filter_t cef_response_filter;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_response_filter_t;

void CEF_CALLBACK _cfx_response_filter_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_response_filter_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_response_filter_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_response_filter_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_response_filter_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_response_filter_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_response_filter_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_response_filter_t* cfx_response_filter_ctor(gc_handle_t gc_handle) {
    cfx_response_filter_t* ptr = (cfx_response_filter_t*)calloc(1, sizeof(cfx_response_filter_t));
    if(!ptr) return 0;
    ptr->cef_response_filter.base.size = sizeof(cef_response_filter_t);
    ptr->cef_response_filter.base.add_ref = _cfx_response_filter_add_ref;
    ptr->cef_response_filter.base.release = _cfx_response_filter_release;
    ptr->cef_response_filter.base.has_one_ref = _cfx_response_filter_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_response_filter_get_gc_handle(cfx_response_filter_t* self) {
    return self->gc_handle;
}

// init_filter

void (CEF_CALLBACK *cfx_response_filter_init_filter_callback)(gc_handle_t self, int* __retval);

int CEF_CALLBACK cfx_response_filter_init_filter(cef_response_filter_t* self) {
    int __retval;
    cfx_response_filter_init_filter_callback(((cfx_response_filter_t*)self)->gc_handle, &__retval);
    return __retval;
}


// filter

void (CEF_CALLBACK *cfx_response_filter_filter_callback)(gc_handle_t self, cef_response_filter_status_t* __retval, void* data_in, int data_in_size, size_t* data_in_read, void* data_out, int data_out_size, size_t* data_out_written);

cef_response_filter_status_t CEF_CALLBACK cfx_response_filter_filter(cef_response_filter_t* self, void* data_in, size_t data_in_size, size_t* data_in_read, void* data_out, size_t data_out_size, size_t* data_out_written) {
    cef_response_filter_status_t __retval;
    cfx_response_filter_filter_callback(((cfx_response_filter_t*)self)->gc_handle, &__retval, data_in, (int)(data_in_size), data_in_read, data_out, (int)(data_out_size), data_out_written);
    return __retval;
}


static void cfx_response_filter_set_managed_callback(cef_response_filter_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_response_filter_init_filter_callback)
            cfx_response_filter_init_filter_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval)) callback;
        self->init_filter = callback ? cfx_response_filter_init_filter : 0;
        break;
    case 1:
        if(callback && !cfx_response_filter_filter_callback)
            cfx_response_filter_filter_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_response_filter_status_t* __retval, void* data_in, int data_in_size, size_t* data_in_read, void* data_out, int data_out_size, size_t* data_out_written)) callback;
        self->filter = callback ? cfx_response_filter_filter : 0;
        break;
    }
}

