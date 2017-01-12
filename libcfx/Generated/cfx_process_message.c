// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_process_message

// CEF_EXPORT cef_process_message_t* cef_process_message_create(const cef_string_t* name);
static cef_process_message_t* cfx_process_message_create(char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return cef_process_message_create(&name);
}
// is_valid
static int cfx_process_message_is_valid(cef_process_message_t* self) {
    return self->is_valid(self);
}

// is_read_only
static int cfx_process_message_is_read_only(cef_process_message_t* self) {
    return self->is_read_only(self);
}

// copy
static cef_process_message_t* cfx_process_message_copy(cef_process_message_t* self) {
    return self->copy(self);
}

// get_name
static cef_string_userfree_t cfx_process_message_get_name(cef_process_message_t* self) {
    return self->get_name(self);
}

// get_argument_list
static cef_list_value_t* cfx_process_message_get_argument_list(cef_process_message_t* self) {
    return self->get_argument_list(self);
}


