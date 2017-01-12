// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_run_context_menu_callback

// cont
static void cfx_run_context_menu_callback_cont(cef_run_context_menu_callback_t* self, int command_id, cef_event_flags_t event_flags) {
    self->cont(self, command_id, event_flags);
}

// cancel
static void cfx_run_context_menu_callback_cancel(cef_run_context_menu_callback_t* self) {
    self->cancel(self);
}


