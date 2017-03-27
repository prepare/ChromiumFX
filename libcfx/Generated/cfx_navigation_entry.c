// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_navigation_entry

// is_valid
static int cfx_navigation_entry_is_valid(cef_navigation_entry_t* self) {
    return self->is_valid(self);
}

// get_url
static cef_string_userfree_t cfx_navigation_entry_get_url(cef_navigation_entry_t* self) {
    return self->get_url(self);
}

// get_display_url
static cef_string_userfree_t cfx_navigation_entry_get_display_url(cef_navigation_entry_t* self) {
    return self->get_display_url(self);
}

// get_original_url
static cef_string_userfree_t cfx_navigation_entry_get_original_url(cef_navigation_entry_t* self) {
    return self->get_original_url(self);
}

// get_title
static cef_string_userfree_t cfx_navigation_entry_get_title(cef_navigation_entry_t* self) {
    return self->get_title(self);
}

// get_transition_type
static cef_transition_type_t cfx_navigation_entry_get_transition_type(cef_navigation_entry_t* self) {
    return self->get_transition_type(self);
}

// has_post_data
static int cfx_navigation_entry_has_post_data(cef_navigation_entry_t* self) {
    return self->has_post_data(self);
}

// get_completion_time
static cef_time_t* cfx_navigation_entry_get_completion_time(cef_navigation_entry_t* self) {
    cef_time_t *__retval = malloc(sizeof(cef_time_t));
    if(__retval) *__retval = self->get_completion_time(self);
    return __retval;
}

// get_http_status_code
static int cfx_navigation_entry_get_http_status_code(cef_navigation_entry_t* self) {
    return self->get_http_status_code(self);
}

// get_sslstatus
static cef_sslstatus_t* cfx_navigation_entry_get_sslstatus(cef_navigation_entry_t* self) {
    return self->get_sslstatus(self);
}


