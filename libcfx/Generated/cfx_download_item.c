// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_download_item

// is_valid
static int cfx_download_item_is_valid(cef_download_item_t* self) {
    return self->is_valid(self);
}

// is_in_progress
static int cfx_download_item_is_in_progress(cef_download_item_t* self) {
    return self->is_in_progress(self);
}

// is_complete
static int cfx_download_item_is_complete(cef_download_item_t* self) {
    return self->is_complete(self);
}

// is_canceled
static int cfx_download_item_is_canceled(cef_download_item_t* self) {
    return self->is_canceled(self);
}

// get_current_speed
static int64 cfx_download_item_get_current_speed(cef_download_item_t* self) {
    return self->get_current_speed(self);
}

// get_percent_complete
static int cfx_download_item_get_percent_complete(cef_download_item_t* self) {
    return self->get_percent_complete(self);
}

// get_total_bytes
static int64 cfx_download_item_get_total_bytes(cef_download_item_t* self) {
    return self->get_total_bytes(self);
}

// get_received_bytes
static int64 cfx_download_item_get_received_bytes(cef_download_item_t* self) {
    return self->get_received_bytes(self);
}

// get_start_time
static cef_time_t* cfx_download_item_get_start_time(cef_download_item_t* self) {
    cef_time_t __retval_tmp = self->get_start_time(self);
    return (cef_time_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_time_t));
}

// get_end_time
static cef_time_t* cfx_download_item_get_end_time(cef_download_item_t* self) {
    cef_time_t __retval_tmp = self->get_end_time(self);
    return (cef_time_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_time_t));
}

// get_full_path
static cef_string_userfree_t cfx_download_item_get_full_path(cef_download_item_t* self) {
    return self->get_full_path(self);
}

// get_id
static uint32 cfx_download_item_get_id(cef_download_item_t* self) {
    return self->get_id(self);
}

// get_url
static cef_string_userfree_t cfx_download_item_get_url(cef_download_item_t* self) {
    return self->get_url(self);
}

// get_original_url
static cef_string_userfree_t cfx_download_item_get_original_url(cef_download_item_t* self) {
    return self->get_original_url(self);
}

// get_suggested_file_name
static cef_string_userfree_t cfx_download_item_get_suggested_file_name(cef_download_item_t* self) {
    return self->get_suggested_file_name(self);
}

// get_content_disposition
static cef_string_userfree_t cfx_download_item_get_content_disposition(cef_download_item_t* self) {
    return self->get_content_disposition(self);
}

// get_mime_type
static cef_string_userfree_t cfx_download_item_get_mime_type(cef_download_item_t* self) {
    return self->get_mime_type(self);
}


