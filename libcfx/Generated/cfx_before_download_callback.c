// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_before_download_callback

// cont
static void cfx_before_download_callback_cont(cef_before_download_callback_t* self, char16 *download_path_str, int download_path_length, int show_dialog) {
    cef_string_t download_path = { download_path_str, download_path_length, 0 };
    self->cont(self, &download_path, show_dialog);
}


