// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_request

// CEF_EXPORT cef_request_t* cef_request_create();
static cef_request_t* cfx_request_create() {
    return cef_request_create();
}
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

// set_referrer
static void cfx_request_set_referrer(cef_request_t* self, char16 *referrer_url_str, int referrer_url_length, cef_referrer_policy_t policy) {
    cef_string_t referrer_url = { referrer_url_str, referrer_url_length, 0 };
    self->set_referrer(self, &referrer_url, policy);
}

// get_referrer_url
static cef_string_userfree_t cfx_request_get_referrer_url(cef_request_t* self) {
    return self->get_referrer_url(self);
}

// get_referrer_policy
static cef_referrer_policy_t cfx_request_get_referrer_policy(cef_request_t* self) {
    return self->get_referrer_policy(self);
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


