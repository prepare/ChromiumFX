// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_browser

// get_host
static cef_browser_host_t* cfx_browser_get_host(cef_browser_t* self) {
    return self->get_host(self);
}

// can_go_back
static int cfx_browser_can_go_back(cef_browser_t* self) {
    return self->can_go_back(self);
}

// go_back
static void cfx_browser_go_back(cef_browser_t* self) {
    self->go_back(self);
}

// can_go_forward
static int cfx_browser_can_go_forward(cef_browser_t* self) {
    return self->can_go_forward(self);
}

// go_forward
static void cfx_browser_go_forward(cef_browser_t* self) {
    self->go_forward(self);
}

// is_loading
static int cfx_browser_is_loading(cef_browser_t* self) {
    return self->is_loading(self);
}

// reload
static void cfx_browser_reload(cef_browser_t* self) {
    self->reload(self);
}

// reload_ignore_cache
static void cfx_browser_reload_ignore_cache(cef_browser_t* self) {
    self->reload_ignore_cache(self);
}

// stop_load
static void cfx_browser_stop_load(cef_browser_t* self) {
    self->stop_load(self);
}

// get_identifier
static int cfx_browser_get_identifier(cef_browser_t* self) {
    return self->get_identifier(self);
}

// is_same
static int cfx_browser_is_same(cef_browser_t* self, cef_browser_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// is_popup
static int cfx_browser_is_popup(cef_browser_t* self) {
    return self->is_popup(self);
}

// has_document
static int cfx_browser_has_document(cef_browser_t* self) {
    return self->has_document(self);
}

// get_main_frame
static cef_frame_t* cfx_browser_get_main_frame(cef_browser_t* self) {
    return self->get_main_frame(self);
}

// get_focused_frame
static cef_frame_t* cfx_browser_get_focused_frame(cef_browser_t* self) {
    return self->get_focused_frame(self);
}

// get_frame_byident
static cef_frame_t* cfx_browser_get_frame_byident(cef_browser_t* self, int64 identifier) {
    return self->get_frame_byident(self, identifier);
}

// get_frame
static cef_frame_t* cfx_browser_get_frame(cef_browser_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->get_frame(self, &name);
}

// get_frame_count
static size_t cfx_browser_get_frame_count(cef_browser_t* self) {
    return self->get_frame_count(self);
}

// get_frame_identifiers
static void cfx_browser_get_frame_identifiers(cef_browser_t* self, size_t identifiersCount, int64* identifiers) {
    self->get_frame_identifiers(self, &identifiersCount, identifiers);
}

// get_frame_names
static void cfx_browser_get_frame_names(cef_browser_t* self, cef_string_list_t names) {
    self->get_frame_names(self, names);
}

// send_process_message
static int cfx_browser_send_process_message(cef_browser_t* self, cef_process_id_t target_process, cef_process_message_t* message) {
    if(message) ((cef_base_ref_counted_t*)message)->add_ref((cef_base_ref_counted_t*)message);
    return self->send_process_message(self, target_process, message);
}


