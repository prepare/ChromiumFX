// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_frame

// is_valid
static int cfx_frame_is_valid(cef_frame_t* self) {
    return self->is_valid(self);
}

// undo
static void cfx_frame_undo(cef_frame_t* self) {
    self->undo(self);
}

// redo
static void cfx_frame_redo(cef_frame_t* self) {
    self->redo(self);
}

// cut
static void cfx_frame_cut(cef_frame_t* self) {
    self->cut(self);
}

// copy
static void cfx_frame_copy(cef_frame_t* self) {
    self->copy(self);
}

// paste
static void cfx_frame_paste(cef_frame_t* self) {
    self->paste(self);
}

// del
static void cfx_frame_del(cef_frame_t* self) {
    self->del(self);
}

// select_all
static void cfx_frame_select_all(cef_frame_t* self) {
    self->select_all(self);
}

// view_source
static void cfx_frame_view_source(cef_frame_t* self) {
    self->view_source(self);
}

// get_source
static void cfx_frame_get_source(cef_frame_t* self, cef_string_visitor_t* visitor) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    self->get_source(self, visitor);
}

// get_text
static void cfx_frame_get_text(cef_frame_t* self, cef_string_visitor_t* visitor) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    self->get_text(self, visitor);
}

// load_request
static void cfx_frame_load_request(cef_frame_t* self, cef_request_t* request) {
    if(request) ((cef_base_t*)request)->add_ref((cef_base_t*)request);
    self->load_request(self, request);
}

// load_url
static void cfx_frame_load_url(cef_frame_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->load_url(self, &url);
}

// load_string
static void cfx_frame_load_string(cef_frame_t* self, char16 *string_val_str, int string_val_length, char16 *url_str, int url_length) {
    cef_string_t string_val = { string_val_str, string_val_length, 0 };
    cef_string_t url = { url_str, url_length, 0 };
    self->load_string(self, &string_val, &url);
}

// execute_java_script
static void cfx_frame_execute_java_script(cef_frame_t* self, char16 *code_str, int code_length, char16 *script_url_str, int script_url_length, int start_line) {
    cef_string_t code = { code_str, code_length, 0 };
    cef_string_t script_url = { script_url_str, script_url_length, 0 };
    self->execute_java_script(self, &code, &script_url, start_line);
}

// is_main
static int cfx_frame_is_main(cef_frame_t* self) {
    return self->is_main(self);
}

// is_focused
static int cfx_frame_is_focused(cef_frame_t* self) {
    return self->is_focused(self);
}

// get_name
static cef_string_userfree_t cfx_frame_get_name(cef_frame_t* self) {
    return self->get_name(self);
}

// get_identifier
static int64 cfx_frame_get_identifier(cef_frame_t* self) {
    return self->get_identifier(self);
}

// get_parent
static cef_frame_t* cfx_frame_get_parent(cef_frame_t* self) {
    return self->get_parent(self);
}

// get_url
static cef_string_userfree_t cfx_frame_get_url(cef_frame_t* self) {
    return self->get_url(self);
}

// get_browser
static cef_browser_t* cfx_frame_get_browser(cef_frame_t* self) {
    return self->get_browser(self);
}

// get_v8context
static cef_v8context_t* cfx_frame_get_v8context(cef_frame_t* self) {
    return self->get_v8context(self);
}

// visit_dom
static void cfx_frame_visit_dom(cef_frame_t* self, cef_domvisitor_t* visitor) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    self->visit_dom(self, visitor);
}


