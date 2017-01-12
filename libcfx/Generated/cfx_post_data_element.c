// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_post_data_element

// CEF_EXPORT cef_post_data_element_t* cef_post_data_element_create();
static cef_post_data_element_t* cfx_post_data_element_create() {
    return cef_post_data_element_create();
}
// is_read_only
static int cfx_post_data_element_is_read_only(cef_post_data_element_t* self) {
    return self->is_read_only(self);
}

// set_to_empty
static void cfx_post_data_element_set_to_empty(cef_post_data_element_t* self) {
    self->set_to_empty(self);
}

// set_to_file
static void cfx_post_data_element_set_to_file(cef_post_data_element_t* self, char16 *fileName_str, int fileName_length) {
    cef_string_t fileName = { fileName_str, fileName_length, 0 };
    self->set_to_file(self, &fileName);
}

// set_to_bytes
static void cfx_post_data_element_set_to_bytes(cef_post_data_element_t* self, size_t size, const void* bytes) {
    self->set_to_bytes(self, size, bytes);
}

// get_type
static cef_postdataelement_type_t cfx_post_data_element_get_type(cef_post_data_element_t* self) {
    return self->get_type(self);
}

// get_file
static cef_string_userfree_t cfx_post_data_element_get_file(cef_post_data_element_t* self) {
    return self->get_file(self);
}

// get_bytes_count
static size_t cfx_post_data_element_get_bytes_count(cef_post_data_element_t* self) {
    return self->get_bytes_count(self);
}

// get_bytes
static size_t cfx_post_data_element_get_bytes(cef_post_data_element_t* self, size_t size, void* bytes) {
    return self->get_bytes(self, size, bytes);
}


