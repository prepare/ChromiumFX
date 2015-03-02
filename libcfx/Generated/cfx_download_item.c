// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_download_item

#ifdef __cplusplus
extern "C" {
#endif

// cef_base_t base

// is_valid
CFX_EXPORT int cfx_download_item_is_valid(cef_download_item_t* self) {
    return self->is_valid(self);
}

// is_in_progress
CFX_EXPORT int cfx_download_item_is_in_progress(cef_download_item_t* self) {
    return self->is_in_progress(self);
}

// is_complete
CFX_EXPORT int cfx_download_item_is_complete(cef_download_item_t* self) {
    return self->is_complete(self);
}

// is_canceled
CFX_EXPORT int cfx_download_item_is_canceled(cef_download_item_t* self) {
    return self->is_canceled(self);
}

// get_current_speed
CFX_EXPORT int64 cfx_download_item_get_current_speed(cef_download_item_t* self) {
    return self->get_current_speed(self);
}

// get_percent_complete
CFX_EXPORT int cfx_download_item_get_percent_complete(cef_download_item_t* self) {
    return self->get_percent_complete(self);
}

// get_total_bytes
CFX_EXPORT int64 cfx_download_item_get_total_bytes(cef_download_item_t* self) {
    return self->get_total_bytes(self);
}

// get_received_bytes
CFX_EXPORT int64 cfx_download_item_get_received_bytes(cef_download_item_t* self) {
    return self->get_received_bytes(self);
}

// get_start_time
CFX_EXPORT cef_time_t* cfx_download_item_get_start_time(cef_download_item_t* self) {
    return (cef_time_t*)cfx_tmp_return_value(&self->get_start_time(self), sizeof(cef_time_t));
}

// get_end_time
CFX_EXPORT cef_time_t* cfx_download_item_get_end_time(cef_download_item_t* self) {
    return (cef_time_t*)cfx_tmp_return_value(&self->get_end_time(self), sizeof(cef_time_t));
}

// get_full_path
CFX_EXPORT cef_string_userfree_t cfx_download_item_get_full_path(cef_download_item_t* self) {
    return self->get_full_path(self);
}

// get_id
CFX_EXPORT uint32 cfx_download_item_get_id(cef_download_item_t* self) {
    return self->get_id(self);
}

// get_url
CFX_EXPORT cef_string_userfree_t cfx_download_item_get_url(cef_download_item_t* self) {
    return self->get_url(self);
}

// get_suggested_file_name
CFX_EXPORT cef_string_userfree_t cfx_download_item_get_suggested_file_name(cef_download_item_t* self) {
    return self->get_suggested_file_name(self);
}

// get_content_disposition
CFX_EXPORT cef_string_userfree_t cfx_download_item_get_content_disposition(cef_download_item_t* self) {
    return self->get_content_disposition(self);
}

// get_mime_type
CFX_EXPORT cef_string_userfree_t cfx_download_item_get_mime_type(cef_download_item_t* self) {
    return self->get_mime_type(self);
}


#ifdef __cplusplus
} // extern "C"
#endif

