// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_download_item_callback

// cancel
static void cfx_download_item_callback_cancel(cef_download_item_callback_t* self) {
    self->cancel(self);
}

// pause
static void cfx_download_item_callback_pause(cef_download_item_callback_t* self) {
    self->pause(self);
}

// resume
static void cfx_download_item_callback_resume(cef_download_item_callback_t* self) {
    self->resume(self);
}


