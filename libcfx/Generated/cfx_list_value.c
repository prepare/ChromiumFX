// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_list_value

// CEF_EXPORT cef_list_value_t* cef_list_value_create();
static cef_list_value_t* cfx_list_value_create() {
    return cef_list_value_create();
}
// is_valid
static int cfx_list_value_is_valid(cef_list_value_t* self) {
    return self->is_valid(self);
}

// is_owned
static int cfx_list_value_is_owned(cef_list_value_t* self) {
    return self->is_owned(self);
}

// is_read_only
static int cfx_list_value_is_read_only(cef_list_value_t* self) {
    return self->is_read_only(self);
}

// is_same
static int cfx_list_value_is_same(cef_list_value_t* self, cef_list_value_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// is_equal
static int cfx_list_value_is_equal(cef_list_value_t* self, cef_list_value_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_equal(self, that);
}

// copy
static cef_list_value_t* cfx_list_value_copy(cef_list_value_t* self) {
    return self->copy(self);
}

// set_size
static int cfx_list_value_set_size(cef_list_value_t* self, size_t size) {
    return self->set_size(self, size);
}

// get_size
static size_t cfx_list_value_get_size(cef_list_value_t* self) {
    return self->get_size(self);
}

// clear
static int cfx_list_value_clear(cef_list_value_t* self) {
    return self->clear(self);
}

// remove
static int cfx_list_value_remove(cef_list_value_t* self, size_t index) {
    return self->remove(self, index);
}

// get_type
static cef_value_type_t cfx_list_value_get_type(cef_list_value_t* self, size_t index) {
    return self->get_type(self, index);
}

// get_value
static cef_value_t* cfx_list_value_get_value(cef_list_value_t* self, size_t index) {
    return self->get_value(self, index);
}

// get_bool
static int cfx_list_value_get_bool(cef_list_value_t* self, size_t index) {
    return self->get_bool(self, index);
}

// get_int
static int cfx_list_value_get_int(cef_list_value_t* self, size_t index) {
    return self->get_int(self, index);
}

// get_double
static double cfx_list_value_get_double(cef_list_value_t* self, size_t index) {
    return self->get_double(self, index);
}

// get_string
static cef_string_userfree_t cfx_list_value_get_string(cef_list_value_t* self, size_t index) {
    return self->get_string(self, index);
}

// get_binary
static cef_binary_value_t* cfx_list_value_get_binary(cef_list_value_t* self, size_t index) {
    return self->get_binary(self, index);
}

// get_dictionary
static cef_dictionary_value_t* cfx_list_value_get_dictionary(cef_list_value_t* self, size_t index) {
    return self->get_dictionary(self, index);
}

// get_list
static cef_list_value_t* cfx_list_value_get_list(cef_list_value_t* self, size_t index) {
    return self->get_list(self, index);
}

// set_value
static int cfx_list_value_set_value(cef_list_value_t* self, size_t index, cef_value_t* value) {
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_value(self, index, value);
}

// set_null
static int cfx_list_value_set_null(cef_list_value_t* self, size_t index) {
    return self->set_null(self, index);
}

// set_bool
static int cfx_list_value_set_bool(cef_list_value_t* self, size_t index, int value) {
    return self->set_bool(self, index, value);
}

// set_int
static int cfx_list_value_set_int(cef_list_value_t* self, size_t index, int value) {
    return self->set_int(self, index, value);
}

// set_double
static int cfx_list_value_set_double(cef_list_value_t* self, size_t index, double value) {
    return self->set_double(self, index, value);
}

// set_string
static int cfx_list_value_set_string(cef_list_value_t* self, size_t index, char16 *value_str, int value_length) {
    cef_string_t value = { value_str, value_length, 0 };
    return self->set_string(self, index, &value);
}

// set_binary
static int cfx_list_value_set_binary(cef_list_value_t* self, size_t index, cef_binary_value_t* value) {
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_binary(self, index, value);
}

// set_dictionary
static int cfx_list_value_set_dictionary(cef_list_value_t* self, size_t index, cef_dictionary_value_t* value) {
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_dictionary(self, index, value);
}

// set_list
static int cfx_list_value_set_list(cef_list_value_t* self, size_t index, cef_list_value_t* value) {
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_list(self, index, value);
}


