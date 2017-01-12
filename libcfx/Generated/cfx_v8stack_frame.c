// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8stack_frame

// is_valid
static int cfx_v8stack_frame_is_valid(cef_v8stack_frame_t* self) {
    return self->is_valid(self);
}

// get_script_name
static cef_string_userfree_t cfx_v8stack_frame_get_script_name(cef_v8stack_frame_t* self) {
    return self->get_script_name(self);
}

// get_script_name_or_source_url
static cef_string_userfree_t cfx_v8stack_frame_get_script_name_or_source_url(cef_v8stack_frame_t* self) {
    return self->get_script_name_or_source_url(self);
}

// get_function_name
static cef_string_userfree_t cfx_v8stack_frame_get_function_name(cef_v8stack_frame_t* self) {
    return self->get_function_name(self);
}

// get_line_number
static int cfx_v8stack_frame_get_line_number(cef_v8stack_frame_t* self) {
    return self->get_line_number(self);
}

// get_column
static int cfx_v8stack_frame_get_column(cef_v8stack_frame_t* self) {
    return self->get_column(self);
}

// is_eval
static int cfx_v8stack_frame_is_eval(cef_v8stack_frame_t* self) {
    return self->is_eval(self);
}

// is_constructor
static int cfx_v8stack_frame_is_constructor(cef_v8stack_frame_t* self) {
    return self->is_constructor(self);
}


