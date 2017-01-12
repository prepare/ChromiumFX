// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_response

// CEF_EXPORT cef_response_t* cef_response_create();
static cef_response_t* cfx_response_create() {
    return cef_response_create();
}
// is_read_only
static int cfx_response_is_read_only(cef_response_t* self) {
    return self->is_read_only(self);
}

// get_error
static cef_errorcode_t cfx_response_get_error(cef_response_t* self) {
    return self->get_error(self);
}

// set_error
static void cfx_response_set_error(cef_response_t* self, cef_errorcode_t error) {
    self->set_error(self, error);
}

// get_status
static int cfx_response_get_status(cef_response_t* self) {
    return self->get_status(self);
}

// set_status
static void cfx_response_set_status(cef_response_t* self, int status) {
    self->set_status(self, status);
}

// get_status_text
static cef_string_userfree_t cfx_response_get_status_text(cef_response_t* self) {
    return self->get_status_text(self);
}

// set_status_text
static void cfx_response_set_status_text(cef_response_t* self, char16 *statusText_str, int statusText_length) {
    cef_string_t statusText = { statusText_str, statusText_length, 0 };
    self->set_status_text(self, &statusText);
}

// get_mime_type
static cef_string_userfree_t cfx_response_get_mime_type(cef_response_t* self) {
    return self->get_mime_type(self);
}

// set_mime_type
static void cfx_response_set_mime_type(cef_response_t* self, char16 *mimeType_str, int mimeType_length) {
    cef_string_t mimeType = { mimeType_str, mimeType_length, 0 };
    self->set_mime_type(self, &mimeType);
}

// get_header
static cef_string_userfree_t cfx_response_get_header(cef_response_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->get_header(self, &name);
}

// get_header_map
static void cfx_response_get_header_map(cef_response_t* self, cef_string_multimap_t headerMap) {
    self->get_header_map(self, headerMap);
}

// set_header_map
static void cfx_response_set_header_map(cef_response_t* self, cef_string_multimap_t headerMap) {
    self->set_header_map(self, headerMap);
}


