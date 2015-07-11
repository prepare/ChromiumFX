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


// cef_urlrequest_client

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_urlrequest_client_t {
    cef_urlrequest_client_t cef_urlrequest_client;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_urlrequest_client_t;

void CEF_CALLBACK _cfx_urlrequest_client_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_urlrequest_client_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_urlrequest_client_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_urlrequest_client_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_urlrequest_client_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_urlrequest_client_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_urlrequest_client_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_urlrequest_client_t* cfx_urlrequest_client_ctor(gc_handle_t gc_handle) {
    cfx_urlrequest_client_t* ptr = (cfx_urlrequest_client_t*)calloc(1, sizeof(cfx_urlrequest_client_t));
    if(!ptr) return 0;
    ptr->cef_urlrequest_client.base.size = sizeof(cef_urlrequest_client_t);
    ptr->cef_urlrequest_client.base.add_ref = _cfx_urlrequest_client_add_ref;
    ptr->cef_urlrequest_client.base.release = _cfx_urlrequest_client_release;
    ptr->cef_urlrequest_client.base.has_one_ref = _cfx_urlrequest_client_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_urlrequest_client_get_gc_handle(cfx_urlrequest_client_t* self) {
    return self->gc_handle;
}

// on_request_complete

void (CEF_CALLBACK *cfx_urlrequest_client_on_request_complete_callback)(gc_handle_t self, cef_urlrequest_t* request);

void CEF_CALLBACK cfx_urlrequest_client_on_request_complete(cef_urlrequest_client_t* self, cef_urlrequest_t* request) {
    cfx_urlrequest_client_on_request_complete_callback(((cfx_urlrequest_client_t*)self)->gc_handle, request);
}


// on_upload_progress

void (CEF_CALLBACK *cfx_urlrequest_client_on_upload_progress_callback)(gc_handle_t self, cef_urlrequest_t* request, int64 current, int64 total);

void CEF_CALLBACK cfx_urlrequest_client_on_upload_progress(cef_urlrequest_client_t* self, cef_urlrequest_t* request, int64 current, int64 total) {
    cfx_urlrequest_client_on_upload_progress_callback(((cfx_urlrequest_client_t*)self)->gc_handle, request, current, total);
}


// on_download_progress

void (CEF_CALLBACK *cfx_urlrequest_client_on_download_progress_callback)(gc_handle_t self, cef_urlrequest_t* request, int64 current, int64 total);

void CEF_CALLBACK cfx_urlrequest_client_on_download_progress(cef_urlrequest_client_t* self, cef_urlrequest_t* request, int64 current, int64 total) {
    cfx_urlrequest_client_on_download_progress_callback(((cfx_urlrequest_client_t*)self)->gc_handle, request, current, total);
}


// on_download_data

void (CEF_CALLBACK *cfx_urlrequest_client_on_download_data_callback)(gc_handle_t self, cef_urlrequest_t* request, const void* data, int data_length);

void CEF_CALLBACK cfx_urlrequest_client_on_download_data(cef_urlrequest_client_t* self, cef_urlrequest_t* request, const void* data, size_t data_length) {
    cfx_urlrequest_client_on_download_data_callback(((cfx_urlrequest_client_t*)self)->gc_handle, request, data, (int)(data_length));
}


// get_auth_credentials

void (CEF_CALLBACK *cfx_urlrequest_client_get_auth_credentials_callback)(gc_handle_t self, int* __retval, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback);

int CEF_CALLBACK cfx_urlrequest_client_get_auth_credentials(cef_urlrequest_client_t* self, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, cef_auth_callback_t* callback) {
    int __retval;
    cfx_urlrequest_client_get_auth_credentials_callback(((cfx_urlrequest_client_t*)self)->gc_handle, &__retval, isProxy, host ? host->str : 0, host ? (int)host->length : 0, port, realm ? realm->str : 0, realm ? (int)realm->length : 0, scheme ? scheme->str : 0, scheme ? (int)scheme->length : 0, callback);
    return __retval;
}


static void cfx_urlrequest_client_set_managed_callback(cef_urlrequest_client_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_urlrequest_client_on_request_complete_callback)
            cfx_urlrequest_client_on_request_complete_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request)) callback;
        self->on_request_complete = callback ? cfx_urlrequest_client_on_request_complete : 0;
        break;
    case 1:
        if(callback && !cfx_urlrequest_client_on_upload_progress_callback)
            cfx_urlrequest_client_on_upload_progress_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int64 current, int64 total)) callback;
        self->on_upload_progress = callback ? cfx_urlrequest_client_on_upload_progress : 0;
        break;
    case 2:
        if(callback && !cfx_urlrequest_client_on_download_progress_callback)
            cfx_urlrequest_client_on_download_progress_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int64 current, int64 total)) callback;
        self->on_download_progress = callback ? cfx_urlrequest_client_on_download_progress : 0;
        break;
    case 3:
        if(callback && !cfx_urlrequest_client_on_download_data_callback)
            cfx_urlrequest_client_on_download_data_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, const void* data, int data_length)) callback;
        self->on_download_data = callback ? cfx_urlrequest_client_on_download_data : 0;
        break;
    case 4:
        if(callback && !cfx_urlrequest_client_get_auth_credentials_callback)
            cfx_urlrequest_client_get_auth_credentials_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback)) callback;
        self->get_auth_credentials = callback ? cfx_urlrequest_client_get_auth_credentials : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

