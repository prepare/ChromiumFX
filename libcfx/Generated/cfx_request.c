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


// cef_request

// CEF_EXPORT cef_request_t* cef_request_create();
static cef_request_t* cfx_request_create() {
    return cef_request_create();
}
// cef_base_t base

// is_read_only
static int cfx_request_is_read_only(cef_request_t* self) {
    return self->is_read_only(self);
}

// get_url
static cef_string_userfree_t cfx_request_get_url(cef_request_t* self) {
    return self->get_url(self);
}

// set_url
static void cfx_request_set_url(cef_request_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->set_url(self, &url);
}

// get_method
static cef_string_userfree_t cfx_request_get_method(cef_request_t* self) {
    return self->get_method(self);
}

// set_method
static void cfx_request_set_method(cef_request_t* self, char16 *method_str, int method_length) {
    cef_string_t method = { method_str, method_length, 0 };
    self->set_method(self, &method);
}

// get_post_data
static cef_post_data_t* cfx_request_get_post_data(cef_request_t* self) {
    return self->get_post_data(self);
}

// set_post_data
static void cfx_request_set_post_data(cef_request_t* self, cef_post_data_t* postData) {
    if(postData) ((cef_base_t*)postData)->add_ref((cef_base_t*)postData);
    self->set_post_data(self, postData);
}

// get_header_map
static void cfx_request_get_header_map(cef_request_t* self, cef_string_multimap_t headerMap) {
    self->get_header_map(self, headerMap);
}

// set_header_map
static void cfx_request_set_header_map(cef_request_t* self, cef_string_multimap_t headerMap) {
    self->set_header_map(self, headerMap);
}

// set
static void cfx_request_set(cef_request_t* self, char16 *url_str, int url_length, char16 *method_str, int method_length, cef_post_data_t* postData, cef_string_multimap_t headerMap) {
    cef_string_t url = { url_str, url_length, 0 };
    cef_string_t method = { method_str, method_length, 0 };
    if(postData) ((cef_base_t*)postData)->add_ref((cef_base_t*)postData);
    self->set(self, &url, &method, postData, headerMap);
}

// get_flags
static int cfx_request_get_flags(cef_request_t* self) {
    return self->get_flags(self);
}

// set_flags
static void cfx_request_set_flags(cef_request_t* self, int flags) {
    self->set_flags(self, flags);
}

// get_first_party_for_cookies
static cef_string_userfree_t cfx_request_get_first_party_for_cookies(cef_request_t* self) {
    return self->get_first_party_for_cookies(self);
}

// set_first_party_for_cookies
static void cfx_request_set_first_party_for_cookies(cef_request_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->set_first_party_for_cookies(self, &url);
}

// get_resource_type
static cef_resource_type_t cfx_request_get_resource_type(cef_request_t* self) {
    return self->get_resource_type(self);
}

// get_transition_type
static cef_transition_type_t cfx_request_get_transition_type(cef_request_t* self) {
    return self->get_transition_type(self);
}

// get_identifier
static uint64 cfx_request_get_identifier(cef_request_t* self) {
    return self->get_identifier(self);
}


