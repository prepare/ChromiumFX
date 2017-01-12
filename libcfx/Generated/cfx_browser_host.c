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


// cef_browser_host

// CEF_EXPORT int cef_browser_host_create_browser(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static int cfx_browser_host_create_browser(const cef_window_info_t* windowInfo, cef_client_t* client, char16 *url_str, int url_length, const cef_browser_settings_t* settings, cef_request_context_t* request_context) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    cef_string_t url = { url_str, url_length, 0 };
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_browser_host_create_browser(windowInfo, client, &url, settings, request_context);
}
// CEF_EXPORT cef_browser_t* cef_browser_host_create_browser_sync(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static cef_browser_t* cfx_browser_host_create_browser_sync(const cef_window_info_t* windowInfo, cef_client_t* client, char16 *url_str, int url_length, const cef_browser_settings_t* settings, cef_request_context_t* request_context) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    cef_string_t url = { url_str, url_length, 0 };
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_browser_host_create_browser_sync(windowInfo, client, &url, settings, request_context);
}
// get_browser
static cef_browser_t* cfx_browser_host_get_browser(cef_browser_host_t* self) {
    return self->get_browser(self);
}

// close_browser
static void cfx_browser_host_close_browser(cef_browser_host_t* self, int force_close) {
    self->close_browser(self, force_close);
}

// try_close_browser
static int cfx_browser_host_try_close_browser(cef_browser_host_t* self) {
    return self->try_close_browser(self);
}

// set_focus
static void cfx_browser_host_set_focus(cef_browser_host_t* self, int focus) {
    self->set_focus(self, focus);
}

// get_window_handle
static cef_window_handle_t cfx_browser_host_get_window_handle(cef_browser_host_t* self) {
    return self->get_window_handle(self);
}

// get_opener_window_handle
static cef_window_handle_t cfx_browser_host_get_opener_window_handle(cef_browser_host_t* self) {
    return self->get_opener_window_handle(self);
}

// has_view
static int cfx_browser_host_has_view(cef_browser_host_t* self) {
    return self->has_view(self);
}

// get_client
static cef_client_t* cfx_browser_host_get_client(cef_browser_host_t* self) {
    return self->get_client(self);
}

// get_request_context
static cef_request_context_t* cfx_browser_host_get_request_context(cef_browser_host_t* self) {
    return self->get_request_context(self);
}

// get_zoom_level
static double cfx_browser_host_get_zoom_level(cef_browser_host_t* self) {
    return self->get_zoom_level(self);
}

// set_zoom_level
static void cfx_browser_host_set_zoom_level(cef_browser_host_t* self, double zoomLevel) {
    self->set_zoom_level(self, zoomLevel);
}

// run_file_dialog
static void cfx_browser_host_run_file_dialog(cef_browser_host_t* self, cef_file_dialog_mode_t mode, char16 *title_str, int title_length, char16 *default_file_path_str, int default_file_path_length, cef_string_list_t accept_filters, int selected_accept_filter, cef_run_file_dialog_callback_t* callback) {
    cef_string_t title = { title_str, title_length, 0 };
    cef_string_t default_file_path = { default_file_path_str, default_file_path_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    self->run_file_dialog(self, mode, &title, &default_file_path, accept_filters, selected_accept_filter, callback);
}

// start_download
static void cfx_browser_host_start_download(cef_browser_host_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->start_download(self, &url);
}

// download_image
static void cfx_browser_host_download_image(cef_browser_host_t* self, char16 *image_url_str, int image_url_length, int is_favicon, uint32 max_image_size, int bypass_cache, cef_download_image_callback_t* callback) {
    cef_string_t image_url = { image_url_str, image_url_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    self->download_image(self, &image_url, is_favicon, max_image_size, bypass_cache, callback);
}

// print
static void cfx_browser_host_print(cef_browser_host_t* self) {
    self->print(self);
}

// print_to_pdf
static void cfx_browser_host_print_to_pdf(cef_browser_host_t* self, char16 *path_str, int path_length, const cef_pdf_print_settings_t* settings, cef_pdf_print_callback_t* callback) {
    cef_string_t path = { path_str, path_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    self->print_to_pdf(self, &path, settings, callback);
}

// find
static void cfx_browser_host_find(cef_browser_host_t* self, int identifier, char16 *searchText_str, int searchText_length, int forward, int matchCase, int findNext) {
    cef_string_t searchText = { searchText_str, searchText_length, 0 };
    self->find(self, identifier, &searchText, forward, matchCase, findNext);
}

// stop_finding
static void cfx_browser_host_stop_finding(cef_browser_host_t* self, int clearSelection) {
    self->stop_finding(self, clearSelection);
}

// show_dev_tools
static void cfx_browser_host_show_dev_tools(cef_browser_host_t* self, const cef_window_info_t* windowInfo, cef_client_t* client, const cef_browser_settings_t* settings, const cef_point_t* inspect_element_at) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    self->show_dev_tools(self, windowInfo, client, settings, inspect_element_at);
}

// close_dev_tools
static void cfx_browser_host_close_dev_tools(cef_browser_host_t* self) {
    self->close_dev_tools(self);
}

// has_dev_tools
static int cfx_browser_host_has_dev_tools(cef_browser_host_t* self) {
    return self->has_dev_tools(self);
}

// get_navigation_entries
static void cfx_browser_host_get_navigation_entries(cef_browser_host_t* self, cef_navigation_entry_visitor_t* visitor, int current_only) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    self->get_navigation_entries(self, visitor, current_only);
}

// set_mouse_cursor_change_disabled
static void cfx_browser_host_set_mouse_cursor_change_disabled(cef_browser_host_t* self, int disabled) {
    self->set_mouse_cursor_change_disabled(self, disabled);
}

// is_mouse_cursor_change_disabled
static int cfx_browser_host_is_mouse_cursor_change_disabled(cef_browser_host_t* self) {
    return self->is_mouse_cursor_change_disabled(self);
}

// replace_misspelling
static void cfx_browser_host_replace_misspelling(cef_browser_host_t* self, char16 *word_str, int word_length) {
    cef_string_t word = { word_str, word_length, 0 };
    self->replace_misspelling(self, &word);
}

// add_word_to_dictionary
static void cfx_browser_host_add_word_to_dictionary(cef_browser_host_t* self, char16 *word_str, int word_length) {
    cef_string_t word = { word_str, word_length, 0 };
    self->add_word_to_dictionary(self, &word);
}

// is_window_rendering_disabled
static int cfx_browser_host_is_window_rendering_disabled(cef_browser_host_t* self) {
    return self->is_window_rendering_disabled(self);
}

// was_resized
static void cfx_browser_host_was_resized(cef_browser_host_t* self) {
    self->was_resized(self);
}

// was_hidden
static void cfx_browser_host_was_hidden(cef_browser_host_t* self, int hidden) {
    self->was_hidden(self, hidden);
}

// notify_screen_info_changed
static void cfx_browser_host_notify_screen_info_changed(cef_browser_host_t* self) {
    self->notify_screen_info_changed(self);
}

// invalidate
static void cfx_browser_host_invalidate(cef_browser_host_t* self, cef_paint_element_type_t type) {
    self->invalidate(self, type);
}

// send_key_event
static void cfx_browser_host_send_key_event(cef_browser_host_t* self, const cef_key_event_t* event) {
    self->send_key_event(self, event);
}

// send_mouse_click_event
static void cfx_browser_host_send_mouse_click_event(cef_browser_host_t* self, const cef_mouse_event_t* event, cef_mouse_button_type_t type, int mouseUp, int clickCount) {
    self->send_mouse_click_event(self, event, type, mouseUp, clickCount);
}

// send_mouse_move_event
static void cfx_browser_host_send_mouse_move_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int mouseLeave) {
    self->send_mouse_move_event(self, event, mouseLeave);
}

// send_mouse_wheel_event
static void cfx_browser_host_send_mouse_wheel_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int deltaX, int deltaY) {
    self->send_mouse_wheel_event(self, event, deltaX, deltaY);
}

// send_focus_event
static void cfx_browser_host_send_focus_event(cef_browser_host_t* self, int setFocus) {
    self->send_focus_event(self, setFocus);
}

// send_capture_lost_event
static void cfx_browser_host_send_capture_lost_event(cef_browser_host_t* self) {
    self->send_capture_lost_event(self);
}

// notify_move_or_resize_started
static void cfx_browser_host_notify_move_or_resize_started(cef_browser_host_t* self) {
    self->notify_move_or_resize_started(self);
}

// get_windowless_frame_rate
static int cfx_browser_host_get_windowless_frame_rate(cef_browser_host_t* self) {
    return self->get_windowless_frame_rate(self);
}

// set_windowless_frame_rate
static void cfx_browser_host_set_windowless_frame_rate(cef_browser_host_t* self, int frame_rate) {
    self->set_windowless_frame_rate(self, frame_rate);
}

// ime_set_composition
static void cfx_browser_host_ime_set_composition(cef_browser_host_t* self, char16 *text_str, int text_length, size_t underlinesCount, cef_composition_underline_t const** underlines, int* underlines_nomem, const cef_range_t* replacement_range, const cef_range_t* selection_range) {
    cef_string_t text = { text_str, text_length, 0 };
    cef_composition_underline_t *underlines_tmp = (cef_composition_underline_t*)malloc(underlinesCount * sizeof(cef_composition_underline_t));
    if(underlines_tmp) {
        for(size_t i = 0; i < underlinesCount; ++i) {
            underlines_tmp[i] = *underlines[i];
        }
        *underlines_nomem = 0;
    } else {
        underlinesCount = 0;
        *underlines_nomem = 1;
    }
    self->ime_set_composition(self, &text, underlinesCount, underlines_tmp, replacement_range, selection_range);
    if(underlines_tmp) free(underlines_tmp);
}

// ime_commit_text
static void cfx_browser_host_ime_commit_text(cef_browser_host_t* self, char16 *text_str, int text_length, const cef_range_t* replacement_range, int relative_cursor_pos) {
    cef_string_t text = { text_str, text_length, 0 };
    self->ime_commit_text(self, &text, replacement_range, relative_cursor_pos);
}

// ime_finish_composing_text
static void cfx_browser_host_ime_finish_composing_text(cef_browser_host_t* self, int keep_selection) {
    self->ime_finish_composing_text(self, keep_selection);
}

// ime_cancel_composition
static void cfx_browser_host_ime_cancel_composition(cef_browser_host_t* self) {
    self->ime_cancel_composition(self);
}

// drag_target_drag_enter
static void cfx_browser_host_drag_target_drag_enter(cef_browser_host_t* self, cef_drag_data_t* drag_data, const cef_mouse_event_t* event, cef_drag_operations_mask_t allowed_ops) {
    if(drag_data) ((cef_base_t*)drag_data)->add_ref((cef_base_t*)drag_data);
    self->drag_target_drag_enter(self, drag_data, event, allowed_ops);
}

// drag_target_drag_over
static void cfx_browser_host_drag_target_drag_over(cef_browser_host_t* self, const cef_mouse_event_t* event, cef_drag_operations_mask_t allowed_ops) {
    self->drag_target_drag_over(self, event, allowed_ops);
}

// drag_target_drag_leave
static void cfx_browser_host_drag_target_drag_leave(cef_browser_host_t* self) {
    self->drag_target_drag_leave(self);
}

// drag_target_drop
static void cfx_browser_host_drag_target_drop(cef_browser_host_t* self, const cef_mouse_event_t* event) {
    self->drag_target_drop(self, event);
}

// drag_source_ended_at
static void cfx_browser_host_drag_source_ended_at(cef_browser_host_t* self, int x, int y, cef_drag_operations_mask_t op) {
    self->drag_source_ended_at(self, x, y, op);
}

// drag_source_system_drag_ended
static void cfx_browser_host_drag_source_system_drag_ended(cef_browser_host_t* self) {
    self->drag_source_system_drag_ended(self);
}

// get_visible_navigation_entry
static cef_navigation_entry_t* cfx_browser_host_get_visible_navigation_entry(cef_browser_host_t* self) {
    return self->get_visible_navigation_entry(self);
}


