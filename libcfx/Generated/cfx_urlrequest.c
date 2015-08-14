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


// cef_urlrequest

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_urlrequest_t* cef_urlrequest_create(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context);
static cef_urlrequest_t* cfx_urlrequest_create(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context) {
    if(request) ((cef_base_t*)request)->add_ref((cef_base_t*)request);
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_urlrequest_create(request, client, request_context);
}
// cef_base_t base

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


#ifdef __cplusplus
} // extern "C"
#endif

