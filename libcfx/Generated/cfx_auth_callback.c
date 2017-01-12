// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_auth_callback

// cont
static void cfx_auth_callback_cont(cef_auth_callback_t* self, char16 *username_str, int username_length, char16 *password_str, int password_length) {
    cef_string_t username = { username_str, username_length, 0 };
    cef_string_t password = { password_str, password_length, 0 };
    self->cont(self, &username, &password);
}

// cancel
static void cfx_auth_callback_cancel(cef_auth_callback_t* self) {
    self->cancel(self);
}


