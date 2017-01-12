// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_binary_value

// CEF_EXPORT cef_binary_value_t* cef_binary_value_create(const void* data, size_t data_size);
static cef_binary_value_t* cfx_binary_value_create(const void* data, size_t data_size) {
    return cef_binary_value_create(data, data_size);
}
// is_valid
static int cfx_binary_value_is_valid(cef_binary_value_t* self) {
    return self->is_valid(self);
}

// is_owned
static int cfx_binary_value_is_owned(cef_binary_value_t* self) {
    return self->is_owned(self);
}

// is_same
static int cfx_binary_value_is_same(cef_binary_value_t* self, cef_binary_value_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// is_equal
static int cfx_binary_value_is_equal(cef_binary_value_t* self, cef_binary_value_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_equal(self, that);
}

// copy
static cef_binary_value_t* cfx_binary_value_copy(cef_binary_value_t* self) {
    return self->copy(self);
}

// get_size
static size_t cfx_binary_value_get_size(cef_binary_value_t* self) {
    return self->get_size(self);
}

// get_data
static size_t cfx_binary_value_get_data(cef_binary_value_t* self, void* buffer, size_t buffer_size, size_t data_offset) {
    return self->get_data(self, buffer, buffer_size, data_offset);
}


