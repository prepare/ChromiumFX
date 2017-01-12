// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_urlrequest

// CEF_EXPORT cef_urlrequest_t* cef_urlrequest_create(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context);
static cef_urlrequest_t* cfx_urlrequest_create(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context) {
    if(request) ((cef_base_t*)request)->add_ref((cef_base_t*)request);
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_urlrequest_create(request, client, request_context);
}
// get_request
static cef_request_t* cfx_urlrequest_get_request(cef_urlrequest_t* self) {
    return self->get_request(self);
}

// get_client
static cef_urlrequest_client_t* cfx_urlrequest_get_client(cef_urlrequest_t* self) {
    return self->get_client(self);
}

// get_request_status
static cef_urlrequest_status_t cfx_urlrequest_get_request_status(cef_urlrequest_t* self) {
    return self->get_request_status(self);
}

// get_request_error
static cef_errorcode_t cfx_urlrequest_get_request_error(cef_urlrequest_t* self) {
    return self->get_request_error(self);
}

// get_response
static cef_response_t* cfx_urlrequest_get_response(cef_urlrequest_t* self) {
    return self->get_response(self);
}

// cancel
static void cfx_urlrequest_cancel(cef_urlrequest_t* self) {
    self->cancel(self);
}


