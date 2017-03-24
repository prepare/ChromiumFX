// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_post_data

// CEF_EXPORT cef_post_data_t* cef_post_data_create();
static cef_post_data_t* cfx_post_data_create() {
    return cef_post_data_create();
}
// is_read_only
static int cfx_post_data_is_read_only(cef_post_data_t* self) {
    return self->is_read_only(self);
}

// has_excluded_elements
static int cfx_post_data_has_excluded_elements(cef_post_data_t* self) {
    return self->has_excluded_elements(self);
}

// get_element_count
static size_t cfx_post_data_get_element_count(cef_post_data_t* self) {
    return self->get_element_count(self);
}

// get_elements
static void cfx_post_data_get_elements(cef_post_data_t* self, size_t elementsCount, cef_post_data_element_t** elements) {
    self->get_elements(self, &elementsCount, elements);
}

// remove_element
static int cfx_post_data_remove_element(cef_post_data_t* self, cef_post_data_element_t* element) {
    if(element) ((cef_base_ref_counted_t*)element)->add_ref((cef_base_ref_counted_t*)element);
    return self->remove_element(self, element);
}

// add_element
static int cfx_post_data_add_element(cef_post_data_t* self, cef_post_data_element_t* element) {
    if(element) ((cef_base_ref_counted_t*)element)->add_ref((cef_base_ref_counted_t*)element);
    return self->add_element(self, element);
}

// remove_elements
static void cfx_post_data_remove_elements(cef_post_data_t* self) {
    self->remove_elements(self);
}


