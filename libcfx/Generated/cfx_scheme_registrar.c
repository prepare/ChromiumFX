// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_scheme_registrar

// add_custom_scheme
static int cfx_scheme_registrar_add_custom_scheme(cef_scheme_registrar_t* self, char16 *scheme_name_str, int scheme_name_length, int is_standard, int is_local, int is_display_isolated) {
    cef_string_t scheme_name = { scheme_name_str, scheme_name_length, 0 };
    return self->add_custom_scheme(self, &scheme_name, is_standard, is_local, is_display_isolated);
}


