// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_get_extension_resource_callback

// cont
static void cfx_get_extension_resource_callback_cont(cef_get_extension_resource_callback_t* self, cef_stream_reader_t* stream) {
    if(stream) ((cef_base_ref_counted_t*)stream)->add_ref((cef_base_ref_counted_t*)stream);
    self->cont(self, stream);
}

// cancel
static void cfx_get_extension_resource_callback_cancel(cef_get_extension_resource_callback_t* self) {
    self->cancel(self);
}


