// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_jsdialog_callback

// cont
static void cfx_jsdialog_callback_cont(cef_jsdialog_callback_t* self, int success, char16 *user_input_str, int user_input_length) {
    cef_string_t user_input = { user_input_str, user_input_length, 0 };
    self->cont(self, success, &user_input);
}


