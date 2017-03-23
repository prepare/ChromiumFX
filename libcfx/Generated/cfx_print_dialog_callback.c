// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_print_dialog_callback

// cont
static void cfx_print_dialog_callback_cont(cef_print_dialog_callback_t* self, cef_print_settings_t* settings) {
    if(settings) ((cef_base_ref_counted_t*)settings)->add_ref((cef_base_ref_counted_t*)settings);
    self->cont(self, settings);
}

// cancel
static void cfx_print_dialog_callback_cancel(cef_print_dialog_callback_t* self) {
    self->cancel(self);
}


