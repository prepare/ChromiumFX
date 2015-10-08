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


// cef_request_handler

typedef struct _cfx_request_handler_t {
    cef_request_handler_t cef_request_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_request_handler_t;

void CEF_CALLBACK _cfx_request_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_request_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_request_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_request_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_request_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_request_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_request_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_request_handler_t* cfx_request_handler_ctor(gc_handle_t gc_handle) {
    cfx_request_handler_t* ptr = (cfx_request_handler_t*)calloc(1, sizeof(cfx_request_handler_t));
    if(!ptr) return 0;
    ptr->cef_request_handler.base.size = sizeof(cef_request_handler_t);
    ptr->cef_request_handler.base.add_ref = _cfx_request_handler_add_ref;
    ptr->cef_request_handler.base.release = _cfx_request_handler_release;
    ptr->cef_request_handler.base.has_one_ref = _cfx_request_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_request_handler_get_gc_handle(cfx_request_handler_t* self) {
    return self->gc_handle;
}

// on_before_browse

void (CEF_CALLBACK *cfx_request_handler_on_before_browse_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_redirect);

int CEF_CALLBACK cfx_request_handler_on_before_browse(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_redirect) {
    int __retval;
    cfx_request_handler_on_before_browse_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, request, is_redirect);
    return __retval;
}


// on_open_urlfrom_tab

void (CEF_CALLBACK *cfx_request_handler_on_open_urlfrom_tab_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *target_url_str, int target_url_length, cef_window_open_disposition_t target_disposition, int user_gesture);

int CEF_CALLBACK cfx_request_handler_on_open_urlfrom_tab(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, const cef_string_t* target_url, cef_window_open_disposition_t target_disposition, int user_gesture) {
    int __retval;
    cfx_request_handler_on_open_urlfrom_tab_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, target_url ? target_url->str : 0, target_url ? (int)target_url->length : 0, target_disposition, user_gesture);
    return __retval;
}


// on_before_resource_load

void (CEF_CALLBACK *cfx_request_handler_on_before_resource_load_callback)(gc_handle_t self, cef_return_value_t* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback);

cef_return_value_t CEF_CALLBACK cfx_request_handler_on_before_resource_load(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback) {
    cef_return_value_t __retval;
    cfx_request_handler_on_before_resource_load_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, request, callback);
    return __retval;
}


// get_resource_handler

void (CEF_CALLBACK *cfx_request_handler_get_resource_handler_callback)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request);

cef_resource_handler_t* CEF_CALLBACK cfx_request_handler_get_resource_handler(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request) {
    cef_resource_handler_t* __retval;
    cfx_request_handler_get_resource_handler_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, request);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// on_resource_redirect

void (CEF_CALLBACK *cfx_request_handler_on_resource_redirect_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, char16 **new_url_str, int *new_url_length);

void CEF_CALLBACK cfx_request_handler_on_resource_redirect(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_string_t* new_url) {
    char16* new_url_tmp_str = new_url->str; int new_url_tmp_length = (int)new_url->length;
    cfx_request_handler_on_resource_redirect_callback(((cfx_request_handler_t*)self)->gc_handle, browser, frame, request, &(new_url_tmp_str), &(new_url_tmp_length));
    if(new_url_tmp_str != new_url->str) {
        if(new_url->dtor) new_url->dtor(new_url->str);
        cef_string_set(new_url_tmp_str, new_url_tmp_length, new_url, 1);
        cfx_gc_handle_free((gc_handle_t)new_url_tmp_str);
    }
}


// on_resource_response

void (CEF_CALLBACK *cfx_request_handler_on_resource_response_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response);

int CEF_CALLBACK cfx_request_handler_on_resource_response(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response) {
    int __retval;
    cfx_request_handler_on_resource_response_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, request, response);
    return __retval;
}


// get_auth_credentials

void (CEF_CALLBACK *cfx_request_handler_get_auth_credentials_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback);

int CEF_CALLBACK cfx_request_handler_get_auth_credentials(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, cef_auth_callback_t* callback) {
    int __retval;
    cfx_request_handler_get_auth_credentials_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, frame, isProxy, host ? host->str : 0, host ? (int)host->length : 0, port, realm ? realm->str : 0, realm ? (int)realm->length : 0, scheme ? scheme->str : 0, scheme ? (int)scheme->length : 0, callback);
    return __retval;
}


// on_quota_request

void (CEF_CALLBACK *cfx_request_handler_on_quota_request_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *origin_url_str, int origin_url_length, int64 new_size, cef_request_callback_t* callback);

int CEF_CALLBACK cfx_request_handler_on_quota_request(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* origin_url, int64 new_size, cef_request_callback_t* callback) {
    int __retval;
    cfx_request_handler_on_quota_request_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, origin_url ? origin_url->str : 0, origin_url ? (int)origin_url->length : 0, new_size, callback);
    return __retval;
}


// on_protocol_execution

void (CEF_CALLBACK *cfx_request_handler_on_protocol_execution_callback)(gc_handle_t self, cef_browser_t* browser, char16 *url_str, int url_length, int* allow_os_execution);

void CEF_CALLBACK cfx_request_handler_on_protocol_execution(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* url, int* allow_os_execution) {
    cfx_request_handler_on_protocol_execution_callback(((cfx_request_handler_t*)self)->gc_handle, browser, url ? url->str : 0, url ? (int)url->length : 0, allow_os_execution);
}


// on_certificate_error

void (CEF_CALLBACK *cfx_request_handler_on_certificate_error_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_errorcode_t cert_error, char16 *request_url_str, int request_url_length, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback);

int CEF_CALLBACK cfx_request_handler_on_certificate_error(cef_request_handler_t* self, cef_browser_t* browser, cef_errorcode_t cert_error, const cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback) {
    int __retval;
    cfx_request_handler_on_certificate_error_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, cert_error, request_url ? request_url->str : 0, request_url ? (int)request_url->length : 0, ssl_info, callback);
    return __retval;
}


// on_before_plugin_load

void (CEF_CALLBACK *cfx_request_handler_on_before_plugin_load_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *url_str, int url_length, char16 *policy_url_str, int policy_url_length, cef_web_plugin_info_t* info);

int CEF_CALLBACK cfx_request_handler_on_before_plugin_load(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* url, const cef_string_t* policy_url, cef_web_plugin_info_t* info) {
    int __retval;
    cfx_request_handler_on_before_plugin_load_callback(((cfx_request_handler_t*)self)->gc_handle, &__retval, browser, url ? url->str : 0, url ? (int)url->length : 0, policy_url ? policy_url->str : 0, policy_url ? (int)policy_url->length : 0, info);
    return __retval;
}


// on_plugin_crashed

void (CEF_CALLBACK *cfx_request_handler_on_plugin_crashed_callback)(gc_handle_t self, cef_browser_t* browser, char16 *plugin_path_str, int plugin_path_length);

void CEF_CALLBACK cfx_request_handler_on_plugin_crashed(cef_request_handler_t* self, cef_browser_t* browser, const cef_string_t* plugin_path) {
    cfx_request_handler_on_plugin_crashed_callback(((cfx_request_handler_t*)self)->gc_handle, browser, plugin_path ? plugin_path->str : 0, plugin_path ? (int)plugin_path->length : 0);
}


// on_render_view_ready

void (CEF_CALLBACK *cfx_request_handler_on_render_view_ready_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_request_handler_on_render_view_ready(cef_request_handler_t* self, cef_browser_t* browser) {
    cfx_request_handler_on_render_view_ready_callback(((cfx_request_handler_t*)self)->gc_handle, browser);
}


// on_render_process_terminated

void (CEF_CALLBACK *cfx_request_handler_on_render_process_terminated_callback)(gc_handle_t self, cef_browser_t* browser, cef_termination_status_t status);

void CEF_CALLBACK cfx_request_handler_on_render_process_terminated(cef_request_handler_t* self, cef_browser_t* browser, cef_termination_status_t status) {
    cfx_request_handler_on_render_process_terminated_callback(((cfx_request_handler_t*)self)->gc_handle, browser, status);
}


static void cfx_request_handler_set_managed_callback(cef_request_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_request_handler_on_before_browse_callback)
            cfx_request_handler_on_before_browse_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_redirect)) callback;
        self->on_before_browse = callback ? cfx_request_handler_on_before_browse : 0;
        break;
    case 1:
        if(callback && !cfx_request_handler_on_open_urlfrom_tab_callback)
            cfx_request_handler_on_open_urlfrom_tab_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, char16 *target_url_str, int target_url_length, cef_window_open_disposition_t target_disposition, int user_gesture)) callback;
        self->on_open_urlfrom_tab = callback ? cfx_request_handler_on_open_urlfrom_tab : 0;
        break;
    case 2:
        if(callback && !cfx_request_handler_on_before_resource_load_callback)
            cfx_request_handler_on_before_resource_load_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_return_value_t* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback)) callback;
        self->on_before_resource_load = callback ? cfx_request_handler_on_before_resource_load : 0;
        break;
    case 3:
        if(callback && !cfx_request_handler_get_resource_handler_callback)
            cfx_request_handler_get_resource_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_resource_handler_t** __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request)) callback;
        self->get_resource_handler = callback ? cfx_request_handler_get_resource_handler : 0;
        break;
    case 4:
        if(callback && !cfx_request_handler_on_resource_redirect_callback)
            cfx_request_handler_on_resource_redirect_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, char16 **new_url_str, int *new_url_length)) callback;
        self->on_resource_redirect = callback ? cfx_request_handler_on_resource_redirect : 0;
        break;
    case 5:
        if(callback && !cfx_request_handler_on_resource_response_callback)
            cfx_request_handler_on_resource_response_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)) callback;
        self->on_resource_response = callback ? cfx_request_handler_on_resource_response : 0;
        break;
    case 6:
        if(callback && !cfx_request_handler_get_auth_credentials_callback)
            cfx_request_handler_get_auth_credentials_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, int isProxy, char16 *host_str, int host_length, int port, char16 *realm_str, int realm_length, char16 *scheme_str, int scheme_length, cef_auth_callback_t* callback)) callback;
        self->get_auth_credentials = callback ? cfx_request_handler_get_auth_credentials : 0;
        break;
    case 7:
        if(callback && !cfx_request_handler_on_quota_request_callback)
            cfx_request_handler_on_quota_request_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *origin_url_str, int origin_url_length, int64 new_size, cef_request_callback_t* callback)) callback;
        self->on_quota_request = callback ? cfx_request_handler_on_quota_request : 0;
        break;
    case 8:
        if(callback && !cfx_request_handler_on_protocol_execution_callback)
            cfx_request_handler_on_protocol_execution_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *url_str, int url_length, int* allow_os_execution)) callback;
        self->on_protocol_execution = callback ? cfx_request_handler_on_protocol_execution : 0;
        break;
    case 9:
        if(callback && !cfx_request_handler_on_certificate_error_callback)
            cfx_request_handler_on_certificate_error_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_errorcode_t cert_error, char16 *request_url_str, int request_url_length, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback)) callback;
        self->on_certificate_error = callback ? cfx_request_handler_on_certificate_error : 0;
        break;
    case 10:
        if(callback && !cfx_request_handler_on_before_plugin_load_callback)
            cfx_request_handler_on_before_plugin_load_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, char16 *url_str, int url_length, char16 *policy_url_str, int policy_url_length, cef_web_plugin_info_t* info)) callback;
        self->on_before_plugin_load = callback ? cfx_request_handler_on_before_plugin_load : 0;
        break;
    case 11:
        if(callback && !cfx_request_handler_on_plugin_crashed_callback)
            cfx_request_handler_on_plugin_crashed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *plugin_path_str, int plugin_path_length)) callback;
        self->on_plugin_crashed = callback ? cfx_request_handler_on_plugin_crashed : 0;
        break;
    case 12:
        if(callback && !cfx_request_handler_on_render_view_ready_callback)
            cfx_request_handler_on_render_view_ready_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) callback;
        self->on_render_view_ready = callback ? cfx_request_handler_on_render_view_ready : 0;
        break;
    case 13:
        if(callback && !cfx_request_handler_on_render_process_terminated_callback)
            cfx_request_handler_on_render_process_terminated_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_termination_status_t status)) callback;
        self->on_render_process_terminated = callback ? cfx_request_handler_on_render_process_terminated : 0;
        break;
    }
}

