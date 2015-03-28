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


// cef_resource_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_resource_handler_t {
    cef_resource_handler_t cef_resource_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_resource_handler_t;

void CEF_CALLBACK _cfx_resource_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_resource_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_resource_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_resource_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_resource_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_resource_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_resource_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_resource_handler_t* cfx_resource_handler_ctor(gc_handle_t gc_handle) {
    cfx_resource_handler_t* ptr = (cfx_resource_handler_t*)calloc(1, sizeof(cfx_resource_handler_t));
    if(!ptr) return 0;
    ptr->cef_resource_handler.base.size = sizeof(cef_resource_handler_t);
    ptr->cef_resource_handler.base.add_ref = _cfx_resource_handler_add_ref;
    ptr->cef_resource_handler.base.release = _cfx_resource_handler_release;
    ptr->cef_resource_handler.base.has_one_ref = _cfx_resource_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_resource_handler_get_gc_handle(cfx_resource_handler_t* self) {
    return self->gc_handle;
}

// process_request

void (CEF_CALLBACK *cfx_resource_handler_process_request_callback)(gc_handle_t self, int* __retval, cef_request_t* request, cef_callback_t* callback);

int CEF_CALLBACK cfx_resource_handler_process_request(cef_resource_handler_t* self, cef_request_t* request, cef_callback_t* callback) {
    int __retval;
    cfx_resource_handler_process_request_callback(((cfx_resource_handler_t*)self)->gc_handle, &__retval, request, callback);
    return __retval;
}


// get_response_headers

void (CEF_CALLBACK *cfx_resource_handler_get_response_headers_callback)(gc_handle_t self, cef_response_t* response, int64* response_length, char16 **redirectUrl_str, int *redirectUrl_length);

void CEF_CALLBACK cfx_resource_handler_get_response_headers(cef_resource_handler_t* self, cef_response_t* response, int64* response_length, cef_string_t* redirectUrl) {
    char16* redirectUrl_tmp_str = redirectUrl->str; int redirectUrl_tmp_length = (int)redirectUrl->length;
    cfx_resource_handler_get_response_headers_callback(((cfx_resource_handler_t*)self)->gc_handle, response, response_length, &(redirectUrl_tmp_str), &(redirectUrl_tmp_length));
    if(redirectUrl_tmp_str != redirectUrl->str) {
        if(redirectUrl->dtor) redirectUrl->dtor(redirectUrl->str);
        cef_string_set(redirectUrl_tmp_str, redirectUrl_tmp_length, redirectUrl, 1);
        cfx_gc_handle_free((gc_handle_t)redirectUrl_tmp_str);
    }
}


// read_response

void (CEF_CALLBACK *cfx_resource_handler_read_response_callback)(gc_handle_t self, int* __retval, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback);

int CEF_CALLBACK cfx_resource_handler_read_response(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback) {
    int __retval;
    cfx_resource_handler_read_response_callback(((cfx_resource_handler_t*)self)->gc_handle, &__retval, data_out, bytes_to_read, bytes_read, callback);
    return __retval;
}


// can_get_cookie

void (CEF_CALLBACK *cfx_resource_handler_can_get_cookie_callback)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie);

int CEF_CALLBACK cfx_resource_handler_can_get_cookie(cef_resource_handler_t* self, const cef_cookie_t* cookie) {
    int __retval;
    cfx_resource_handler_can_get_cookie_callback(((cfx_resource_handler_t*)self)->gc_handle, &__retval, cookie);
    return __retval;
}


// can_set_cookie

void (CEF_CALLBACK *cfx_resource_handler_can_set_cookie_callback)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie);

int CEF_CALLBACK cfx_resource_handler_can_set_cookie(cef_resource_handler_t* self, const cef_cookie_t* cookie) {
    int __retval;
    cfx_resource_handler_can_set_cookie_callback(((cfx_resource_handler_t*)self)->gc_handle, &__retval, cookie);
    return __retval;
}


// cancel

void (CEF_CALLBACK *cfx_resource_handler_cancel_callback)(gc_handle_t self);

void CEF_CALLBACK cfx_resource_handler_cancel(cef_resource_handler_t* self) {
    cfx_resource_handler_cancel_callback(((cfx_resource_handler_t*)self)->gc_handle);
}


static void cfx_resource_handler_set_managed_callback(cef_resource_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_resource_handler_process_request_callback)
            cfx_resource_handler_process_request_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_request_t* request, cef_callback_t* callback)) callback;
        self->process_request = callback ? cfx_resource_handler_process_request : 0;
        break;
    case 1:
        if(callback && !cfx_resource_handler_get_response_headers_callback)
            cfx_resource_handler_get_response_headers_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_response_t* response, int64* response_length, char16 **redirectUrl_str, int *redirectUrl_length)) callback;
        self->get_response_headers = callback ? cfx_resource_handler_get_response_headers : 0;
        break;
    case 2:
        if(callback && !cfx_resource_handler_read_response_callback)
            cfx_resource_handler_read_response_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback)) callback;
        self->read_response = callback ? cfx_resource_handler_read_response : 0;
        break;
    case 3:
        if(callback && !cfx_resource_handler_can_get_cookie_callback)
            cfx_resource_handler_can_get_cookie_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie)) callback;
        self->can_get_cookie = callback ? cfx_resource_handler_can_get_cookie : 0;
        break;
    case 4:
        if(callback && !cfx_resource_handler_can_set_cookie_callback)
            cfx_resource_handler_can_set_cookie_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, const cef_cookie_t* cookie)) callback;
        self->can_set_cookie = callback ? cfx_resource_handler_can_set_cookie : 0;
        break;
    case 5:
        if(callback && !cfx_resource_handler_cancel_callback)
            cfx_resource_handler_cancel_callback = (void (CEF_CALLBACK *)(gc_handle_t self)) callback;
        self->cancel = callback ? cfx_resource_handler_cancel : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

