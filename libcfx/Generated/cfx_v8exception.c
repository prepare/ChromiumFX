// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8exception

// get_message
static cef_string_userfree_t cfx_v8exception_get_message(cef_v8exception_t* self) {
    return self->get_message(self);
}

// get_source_line
static cef_string_userfree_t cfx_v8exception_get_source_line(cef_v8exception_t* self) {
    return self->get_source_line(self);
}

// get_script_resource_name
static cef_string_userfree_t cfx_v8exception_get_script_resource_name(cef_v8exception_t* self) {
    return self->get_script_resource_name(self);
}

// get_line_number
static int cfx_v8exception_get_line_number(cef_v8exception_t* self) {
    return self->get_line_number(self);
}

// get_start_position
static int cfx_v8exception_get_start_position(cef_v8exception_t* self) {
    return self->get_start_position(self);
}

// get_end_position
static int cfx_v8exception_get_end_position(cef_v8exception_t* self) {
    return self->get_end_position(self);
}

// get_start_column
static int cfx_v8exception_get_start_column(cef_v8exception_t* self) {
    return self->get_start_column(self);
}

// get_end_column
static int cfx_v8exception_get_end_column(cef_v8exception_t* self) {
    return self->get_end_column(self);
}


