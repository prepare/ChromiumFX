// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_dictionary_value

// CEF_EXPORT cef_dictionary_value_t* cef_dictionary_value_create();
static cef_dictionary_value_t* cfx_dictionary_value_create() {
    return cef_dictionary_value_create();
}
// is_valid
static int cfx_dictionary_value_is_valid(cef_dictionary_value_t* self) {
    return self->is_valid(self);
}

// is_owned
static int cfx_dictionary_value_is_owned(cef_dictionary_value_t* self) {
    return self->is_owned(self);
}

// is_read_only
static int cfx_dictionary_value_is_read_only(cef_dictionary_value_t* self) {
    return self->is_read_only(self);
}

// is_same
static int cfx_dictionary_value_is_same(cef_dictionary_value_t* self, cef_dictionary_value_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// is_equal
static int cfx_dictionary_value_is_equal(cef_dictionary_value_t* self, cef_dictionary_value_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_equal(self, that);
}

// copy
static cef_dictionary_value_t* cfx_dictionary_value_copy(cef_dictionary_value_t* self, int exclude_empty_children) {
    return self->copy(self, exclude_empty_children);
}

// get_size
static size_t cfx_dictionary_value_get_size(cef_dictionary_value_t* self) {
    return self->get_size(self);
}

// clear
static int cfx_dictionary_value_clear(cef_dictionary_value_t* self) {
    return self->clear(self);
}

// has_key
static int cfx_dictionary_value_has_key(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->has_key(self, &key);
}

// get_keys
static int cfx_dictionary_value_get_keys(cef_dictionary_value_t* self, cef_string_list_t keys) {
    return self->get_keys(self, keys);
}

// remove
static int cfx_dictionary_value_remove(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->remove(self, &key);
}

// get_type
static cef_value_type_t cfx_dictionary_value_get_type(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_type(self, &key);
}

// get_value
static cef_value_t* cfx_dictionary_value_get_value(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_value(self, &key);
}

// get_bool
static int cfx_dictionary_value_get_bool(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_bool(self, &key);
}

// get_int
static int cfx_dictionary_value_get_int(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_int(self, &key);
}

// get_double
static double cfx_dictionary_value_get_double(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_double(self, &key);
}

// get_string
static cef_string_userfree_t cfx_dictionary_value_get_string(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_string(self, &key);
}

// get_binary
static cef_binary_value_t* cfx_dictionary_value_get_binary(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_binary(self, &key);
}

// get_dictionary
static cef_dictionary_value_t* cfx_dictionary_value_get_dictionary(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_dictionary(self, &key);
}

// get_list
static cef_list_value_t* cfx_dictionary_value_get_list(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_list(self, &key);
}

// set_value
static int cfx_dictionary_value_set_value(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_value_t* value) {
    cef_string_t key = { key_str, key_length, 0 };
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_value(self, &key, value);
}

// set_null
static int cfx_dictionary_value_set_null(cef_dictionary_value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->set_null(self, &key);
}

// set_bool
static int cfx_dictionary_value_set_bool(cef_dictionary_value_t* self, char16 *key_str, int key_length, int value) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->set_bool(self, &key, value);
}

// set_int
static int cfx_dictionary_value_set_int(cef_dictionary_value_t* self, char16 *key_str, int key_length, int value) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->set_int(self, &key, value);
}

// set_double
static int cfx_dictionary_value_set_double(cef_dictionary_value_t* self, char16 *key_str, int key_length, double value) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->set_double(self, &key, value);
}

// set_string
static int cfx_dictionary_value_set_string(cef_dictionary_value_t* self, char16 *key_str, int key_length, char16 *value_str, int value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { value_str, value_length, 0 };
    return self->set_string(self, &key, &value);
}

// set_binary
static int cfx_dictionary_value_set_binary(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_binary_value_t* value) {
    cef_string_t key = { key_str, key_length, 0 };
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_binary(self, &key, value);
}

// set_dictionary
static int cfx_dictionary_value_set_dictionary(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_dictionary_value_t* value) {
    cef_string_t key = { key_str, key_length, 0 };
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_dictionary(self, &key, value);
}

// set_list
static int cfx_dictionary_value_set_list(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_list_value_t* value) {
    cef_string_t key = { key_str, key_length, 0 };
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    return self->set_list(self, &key, value);
}


