// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_request_handler

typedef struct _cfx_request_handler_t {
    cef_request_handler_t cef_request_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_before_browse)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, int is_redirect);
    void (CEF_CALLBACK *on_open_urlfrom_tab)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *target_url_str, int target_url_length, cef_window_open_disposition_t target_disposition, int user_gesture);
    void (CEF_CALLBACK *on_before_resource_load)(gc_handle_t self, cef_return_value_t* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_request_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *get_resource_handler)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release);
    void (CEF_CALLBACK *on_resource_redirect)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release, char16 **new_url_str, int *new_url_length);
    void (CEF_CALLBACK *on_resource_response)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release);
    void (CEF_CALLBACK *get_resource_response_filter)(gc_handle_t self, cef_response_filter_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release);
    void (CEF_CALLBACK *on_resource_load_complete)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release, cef_urlrequest_status_t status, int64 received_content_length);
    void (CEF_CALLBACK *get_auth_credentials)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_quota_request)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *origin_url_str, int origin_url_length, int64 new_size, cef_request_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_protocol_execution)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *url_str, int url_length, int* allow_os_execution);
    void (CEF_CALLBACK *on_certificate_error)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_errorcode_t cert_error, char16 *request_url_str, int request_url_length, cef_sslinfo_t* ssl_info, int *ssl_info_release, cef_request_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_select_client_certificate)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, int isProxy, char16 *host_str, int host_length, int port, size_t certificatesCount, cef_x509certificate_t* const* certificates, int *certificates_release, cef_select_client_certificate_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_plugin_crashed)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *plugin_path_str, int plugin_path_length);
    void (CEF_CALLBACK *on_render_view_ready)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *on_render_process_terminated)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_termination_status_t status);
} cfx_request_handler_t;

void CEF_CALLBACK _cfx_request_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_request_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_request_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_request_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_request_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_request_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_request_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_request_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_request_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_request_handler_t* cfx_request_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_request_handler_t* ptr = (cfx_request_handler_t*)calloc(1, sizeof(cfx_request_handler_t));
    if(!ptr) return 0;
    ptr->cef_request_handler.base.size = sizeof(cef_request_handler_t);
    ptr->cef_request_handler.base.add_ref = _cfx_request_handler_add_ref;
    ptr->cef_request_handler.base.release = _cfx_request_handler_release;
    ptr->cef_request_handler.base.has_one_ref = _cfx_request_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_before_browse

int CEF_CALLBACK cfx_request_handler_on_before_browse(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_redirect) {
    int __retval;
    int browser_release;
    int frame_release;
    int request_release;
    ((cfx_request_handler_t*)self)->on_before_browse(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release, is_redirect);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    return __retval;
}

// on_open_urlfrom_tab

int CEF_CALLBACK cfx_request_handler_on_open_urlfrom_tab(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* target_url, cef_window_open_disposition_t target_disposition, int user_gesture) {
    int __retval;
    int browser_release;
    int frame_release;
    ((cfx_request_handler_t*)self)->on_open_urlfrom_tab(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, target_url ? target_url->str : 0, target_url ? (int)target_url->length : 0, target_disposition, user_gesture);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    return __retval;
}

// on_before_resource_load

cef_return_value_t CEF_CALLBACK cfx_request_handler_on_before_resource_load(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback) {
    cef_return_value_t __retval;
    int browser_release;
    int frame_release;
    int request_release;
    int callback_release;
    ((cfx_request_handler_t*)self)->on_before_resource_load(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// get_resource_handler

cef_resource_handler_t* CEF_CALLBACK cfx_request_handler_get_resource_handler(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request) {
    cef_resource_handler_t* __retval;
    int browser_release;
    int frame_release;
    int request_release;
    ((cfx_request_handler_t*)self)->get_resource_handler(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// on_resource_redirect

void CEF_CALLBACK cfx_request_handler_on_resource_redirect(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_string_t* new_url) {
    int browser_release;
    int frame_release;
    int request_release;
    int response_release;
    char16* new_url_tmp_str = new_url->str; int new_url_tmp_length = (int)new_url->length;
    ((cfx_request_handler_t*)self)->on_resource_redirect(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, request, &request_release, response, &response_release, &(new_url_tmp_str), &(new_url_tmp_length));
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(response_release) response->base.release((cef_base_ref_counted_t*)response);
    if(new_url_tmp_str != new_url->str) {
        if(new_url->dtor) new_url->dtor(new_url->str);
        cef_string_set(new_url_tmp_str, new_url_tmp_length, new_url, 1);
        cfx_gc_handle_switch(&(gc_handle_t)new_url_tmp_str, GC_HANDLE_FREE);
    }
}

// on_resource_response

int CEF_CALLBACK cfx_request_handler_on_resource_response(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response) {
    int __retval;
    int browser_release;
    int frame_release;
    int request_release;
    int response_release;
    ((cfx_request_handler_t*)self)->on_resource_response(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release, response, &response_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(response_release) response->base.release((cef_base_ref_counted_t*)response);
    return __retval;
}

// get_resource_response_filter

cef_response_filter_t* CEF_CALLBACK cfx_request_handler_get_resource_response_filter(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response) {
    cef_response_filter_t* __retval;
    int browser_release;
    int frame_release;
    int request_release;
    int response_release;
    ((cfx_request_handler_t*)self)->get_resource_response_filter(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release, response, &response_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(response_release) response->base.release((cef_base_ref_counted_t*)response);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// on_resource_load_complete

void CEF_CALLBACK cfx_request_handler_on_resource_load_complete(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_urlrequest_status_t status, int64 received_content_length) {
    int browser_release;
    int frame_release;
    int request_release;
    int response_release;
    ((cfx_request_handler_t*)self)->on_resource_load_complete(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, request, &request_release, response, &response_release, status, received_content_length);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release) request->base.release((cef_base_ref_counted_t*)request);
    if(response_release) response->base.release((cef_base_ref_counted_t*)response);
}

// get_auth_credentials

int CEF_CALLBACK cfx_request_handler_get_auth_credentials(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, cef_auth_callback_t* callback) {
    int __retval;
    int browser_release;
    int frame_release;
    int callback_release;
    ((cfx_request_handler_t*)self)->get_auth_credentials(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, isProxy, host ? host->str : 0, host ? (int)host->length : 0, port, realm ? realm->str : 0, realm ? (int)realm->length : 0, scheme ? scheme->str : 0, scheme ? (int)scheme->length : 0, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_quota_request

int CEF_CALLBACK cfx_request_handler_on_quota_request(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* origin_url, int64 new_size, cef_request_callback_t* callback) {
    int __retval;
    int browser_release;
    int callback_release;
    ((cfx_request_handler_t*)self)->on_quota_request(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, origin_url ? origin_url->str : 0, origin_url ? (int)origin_url->length : 0, new_size, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_protocol_execution

void CEF_CALLBACK cfx_request_handler_on_protocol_execution(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* url, int* allow_os_execution) {
    int browser_release;
    ((cfx_request_handler_t*)self)->on_protocol_execution(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release, url ? url->str : 0, url ? (int)url->length : 0, allow_os_execution);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_certificate_error

int CEF_CALLBACK cfx_request_handler_on_certificate_error(cef_request_handler_t* self, cef_browser_t* browser, cef_errorcode_t cert_error, const cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback) {
    int __retval;
    int browser_release;
    int ssl_info_release;
    int callback_release;
    ((cfx_request_handler_t*)self)->on_certificate_error(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, cert_error, request_url ? request_url->str : 0, request_url ? (int)request_url->length : 0, ssl_info, &ssl_info_release, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(ssl_info_release) ssl_info->base.release((cef_base_ref_counted_t*)ssl_info);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_select_client_certificate

int CEF_CALLBACK cfx_request_handler_on_select_client_certificate(cef_request_handler_t* self, cef_browser_t* browser, int isProxy, const cef_string_t* host, int port, size_t certificatesCount, cef_x509certificate_t* const* certificates, cef_select_client_certificate_callback_t* callback) {
    int __retval;
    int browser_release;
    int certificates_release;
    int callback_release;
    ((cfx_request_handler_t*)self)->on_select_client_certificate(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, isProxy, host ? host->str : 0, host ? (int)host->length : 0, port, certificatesCount, certificates, &certificates_release, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(certificates_release) {
        for(size_t i = 0; i < certificatesCount; ++i) {
            certificates[i]->base.release((cef_base_ref_counted_t*)certificates[i]);
        }
    }
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_plugin_crashed

void CEF_CALLBACK cfx_request_handler_on_plugin_crashed(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* plugin_path) {
    int browser_release;
    ((cfx_request_handler_t*)self)->on_plugin_crashed(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release, plugin_path ? plugin_path->str : 0, plugin_path ? (int)plugin_path->length : 0);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_render_view_ready

void CEF_CALLBACK cfx_request_handler_on_render_view_ready(cef_request_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_request_handler_t*)self)->on_render_view_ready(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_render_process_terminated

void CEF_CALLBACK cfx_request_handler_on_render_process_terminated(cef_request_handler_t* self, cef_browser_t* browser, cef_termination_status_t status) {
    int browser_release;
    ((cfx_request_handler_t*)self)->on_render_process_terminated(((cfx_request_handler_t*)self)->gc_handle, browser, &browser_release, status);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

static void cfx_request_handler_set_callback(cef_request_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_request_handler_t*)self)->on_before_browse = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, int is_redirect))callback;
        self->on_before_browse = callback ? cfx_request_handler_on_before_browse : 0;
        break;
    case 1:
        ((cfx_request_handler_t*)self)->on_open_urlfrom_tab = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, char16 *target_url_str, int target_url_length, cef_window_open_disposition_t target_disposition, int user_gesture))callback;
        self->on_open_urlfrom_tab = callback ? cfx_request_handler_on_open_urlfrom_tab : 0;
        break;
    case 2:
        ((cfx_request_handler_t*)self)->on_before_resource_load = (void (CEF_CALLBACK *)(gc_handle_t self, cef_return_value_t* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_request_callback_t* callback, int *callback_release))callback;
        self->on_before_resource_load = callback ? cfx_request_handler_on_before_resource_load : 0;
        break;
    case 3:
        ((cfx_request_handler_t*)self)->get_resource_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release))callback;
        self->get_resource_handler = callback ? cfx_request_handler_get_resource_handler : 0;
        break;
    case 4:
        ((cfx_request_handler_t*)self)->on_resource_redirect = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release, char16 **new_url_str, int *new_url_length))callback;
        self->on_resource_redirect = callback ? cfx_request_handler_on_resource_redirect : 0;
        break;
    case 5:
        ((cfx_request_handler_t*)self)->on_resource_response = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release))callback;
        self->on_resource_response = callback ? cfx_request_handler_on_resource_response : 0;
        break;
    case 6:
        ((cfx_request_handler_t*)self)->get_resource_response_filter = (void (CEF_CALLBACK *)(gc_handle_t self, cef_response_filter_t** __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release))callback;
        self->get_resource_response_filter = callback ? cfx_request_handler_get_resource_response_filter : 0;
        break;
    case 7:
        ((cfx_request_handler_t*)self)->on_resource_load_complete = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_response_t* response, int *response_release, cef_urlrequest_status_t status, int64 received_content_length))callback;
        self->on_resource_load_complete = callback ? cfx_request_handler_on_resource_load_complete : 0;
        break;
    case 8:
        ((cfx_request_handler_t*)self)->get_auth_credentials = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback, int *callback_release))callback;
        self->get_auth_credentials = callback ? cfx_request_handler_get_auth_credentials : 0;
        break;
    case 9:
        ((cfx_request_handler_t*)self)->on_quota_request = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, char16 *origin_url_str, int origin_url_length, int64 new_size, cef_request_callback_t* callback, int *callback_release))callback;
        self->on_quota_request = callback ? cfx_request_handler_on_quota_request : 0;
        break;
    case 10:
        ((cfx_request_handler_t*)self)->on_protocol_execution = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *url_str, int url_length, int* allow_os_execution))callback;
        self->on_protocol_execution = callback ? cfx_request_handler_on_protocol_execution : 0;
        break;
    case 11:
        ((cfx_request_handler_t*)self)->on_certificate_error = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_errorcode_t cert_error, char16 *request_url_str, int request_url_length, cef_sslinfo_t* ssl_info, int *ssl_info_release, cef_request_callback_t* callback, int *callback_release))callback;
        self->on_certificate_error = callback ? cfx_request_handler_on_certificate_error : 0;
        break;
    case 12:
        ((cfx_request_handler_t*)self)->on_select_client_certificate = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, int isProxy, char16 *host_str, int host_length, int port, size_t certificatesCount, cef_x509certificate_t* const* certificates, int *certificates_release, cef_select_client_certificate_callback_t* callback, int *callback_release))callback;
        self->on_select_client_certificate = callback ? cfx_request_handler_on_select_client_certificate : 0;
        break;
    case 13:
        ((cfx_request_handler_t*)self)->on_plugin_crashed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, char16 *plugin_path_str, int plugin_path_length))callback;
        self->on_plugin_crashed = callback ? cfx_request_handler_on_plugin_crashed : 0;
        break;
    case 14:
        ((cfx_request_handler_t*)self)->on_render_view_ready = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_render_view_ready = callback ? cfx_request_handler_on_render_view_ready : 0;
        break;
    case 15:
        ((cfx_request_handler_t*)self)->on_render_process_terminated = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_termination_status_t status))callback;
        self->on_render_process_terminated = callback ? cfx_request_handler_on_render_process_terminated : 0;
        break;
    }
}

