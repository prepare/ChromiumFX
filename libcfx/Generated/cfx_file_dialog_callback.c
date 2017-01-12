// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_file_dialog_callback

// cont
static void cfx_file_dialog_callback_cont(cef_file_dialog_callback_t* self, int selected_accept_filter, cef_string_list_t file_paths) {
    self->cont(self, selected_accept_filter, file_paths);
}

// cancel
static void cfx_file_dialog_callback_cancel(cef_file_dialog_callback_t* self) {
    self->cancel(self);
}


