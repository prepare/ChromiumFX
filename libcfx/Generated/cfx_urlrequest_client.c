// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_urlrequest_client

typedef struct _cfx_urlrequest_client_t {
    cef_urlrequest_client_t cef_urlrequest_client;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_request_complete)(gc_handle_t self, cef_urlrequest_t* request, int *request_release);
    void (CEF_CALLBACK *on_upload_progress)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, int64 current, int64 total);
    void (CEF_CALLBACK *on_download_progress)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, int64 current, int64 total);
    void (CEF_CALLBACK *on_download_data)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, const void* data, size_t data_length);
    void (CEF_CALLBACK *get_auth_credentials)(gc_handle_t self, int* __retval, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback, int *callback_release);
} cfx_urlrequest_client_t;

void CEF_CALLBACK _cfx_urlrequest_client_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_urlrequest_client_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_urlrequest_client_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_urlrequest_client_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_urlrequest_client_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_urlrequest_client_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_urlrequest_client_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_urlrequest_client_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_urlrequest_client_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_urlrequest_client_t* cfx_urlrequest_client_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_urlrequest_client_t* ptr = (cfx_urlrequest_client_t*)calloc(1, sizeof(cfx_urlrequest_client_t));
    if(!ptr) return 0;
    ptr->cef_urlrequest_client.base.size = sizeof(cef_urlrequest_client_t);
    ptr->cef_urlrequest_client.base.add_ref = _cfx_urlrequest_client_add_ref;
    ptr->cef_urlrequest_client.base.release = _cfx_urlrequest_client_release;
    ptr->cef_urlrequest_client.base.has_one_ref = _cfx_urlrequest_client_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_urlrequest_client_get_gc_handle(cfx_urlrequest_client_t* self) {
    return self->gc_handle;
}

// on_request_complete

void CEF_CALLBACK cfx_urlrequest_client_on_request_complete(cef_urlrequest_client_t* self, cef_urlrequest_t* request) {
    int request_release;
    ((cfx_urlrequest_client_t*)self)->on_request_complete(((cfx_urlrequest_client_t*)self)->gc_handle, request, &request_release);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
}

// on_upload_progress

void CEF_CALLBACK cfx_urlrequest_client_on_upload_progress(cef_urlrequest_client_t* self, cef_urlrequest_t* request, int64 current, int64 total) {
    int request_release;
    ((cfx_urlrequest_client_t*)self)->on_upload_progress(((cfx_urlrequest_client_t*)self)->gc_handle, request, &request_release, current, total);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
}

// on_download_progress

void CEF_CALLBACK cfx_urlrequest_client_on_download_progress(cef_urlrequest_client_t* self, cef_urlrequest_t* request, int64 current, int64 total) {
    int request_release;
    ((cfx_urlrequest_client_t*)self)->on_download_progress(((cfx_urlrequest_client_t*)self)->gc_handle, request, &request_release, current, total);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
}

// on_download_data

void CEF_CALLBACK cfx_urlrequest_client_on_download_data(cef_urlrequest_client_t* self, cef_urlrequest_t* request, const void* data, size_t data_length) {
    int request_release;
    ((cfx_urlrequest_client_t*)self)->on_download_data(((cfx_urlrequest_client_t*)self)->gc_handle, request, &request_release, data, data_length);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
}

// get_auth_credentials

int CEF_CALLBACK cfx_urlrequest_client_get_auth_credentials(cef_urlrequest_client_t* self, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, cef_auth_callback_t* callback) {
    int __retval;
    int callback_release;
    ((cfx_urlrequest_client_t*)self)->get_auth_credentials(((cfx_urlrequest_client_t*)self)->gc_handle, &__retval, isProxy, host ? host->str : 0, host ? (int)host->length : 0, port, realm ? realm->str : 0, realm ? (int)realm->length : 0, scheme ? scheme->str : 0, scheme ? (int)scheme->length : 0, callback, &callback_release);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

static void cfx_urlrequest_client_set_callback(cef_urlrequest_client_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_urlrequest_client_t*)self)->on_request_complete = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int *request_release))callback;
        self->on_request_complete = callback ? cfx_urlrequest_client_on_request_complete : 0;
        break;
    case 1:
        ((cfx_urlrequest_client_t*)self)->on_upload_progress = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, int64 current, int64 total))callback;
        self->on_upload_progress = callback ? cfx_urlrequest_client_on_upload_progress : 0;
        break;
    case 2:
        ((cfx_urlrequest_client_t*)self)->on_download_progress = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, int64 current, int64 total))callback;
        self->on_download_progress = callback ? cfx_urlrequest_client_on_download_progress : 0;
        break;
    case 3:
        ((cfx_urlrequest_client_t*)self)->on_download_data = (void (CEF_CALLBACK *)(gc_handle_t self, cef_urlrequest_t* request, int *request_release, const void* data, size_t data_length))callback;
        self->on_download_data = callback ? cfx_urlrequest_client_on_download_data : 0;
        break;
    case 4:
        ((cfx_urlrequest_client_t*)self)->get_auth_credentials = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback, int *callback_release))callback;
        self->get_auth_credentials = callback ? cfx_urlrequest_client_get_auth_credentials : 0;
        break;
    }
}

