// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_request_callback

// cont
static void cfx_request_callback_cont(cef_request_callback_t* self, int allow) {
    self->cont(self, allow);
}

// cancel
static void cfx_request_callback_cancel(cef_request_callback_t* self) {
    self->cancel(self);
}


