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


// cef_drag_data

// CEF_EXPORT cef_drag_data_t* cef_drag_data_create();
static cef_drag_data_t* cfx_drag_data_create() {
    return cef_drag_data_create();
}
// clone
static cef_drag_data_t* cfx_drag_data_clone(cef_drag_data_t* self) {
    return self->clone(self);
}

// is_read_only
static int cfx_drag_data_is_read_only(cef_drag_data_t* self) {
    return self->is_read_only(self);
}

// is_link
static int cfx_drag_data_is_link(cef_drag_data_t* self) {
    return self->is_link(self);
}

// is_fragment
static int cfx_drag_data_is_fragment(cef_drag_data_t* self) {
    return self->is_fragment(self);
}

// is_file
static int cfx_drag_data_is_file(cef_drag_data_t* self) {
    return self->is_file(self);
}

// get_link_url
static cef_string_userfree_t cfx_drag_data_get_link_url(cef_drag_data_t* self) {
    return self->get_link_url(self);
}

// get_link_title
static cef_string_userfree_t cfx_drag_data_get_link_title(cef_drag_data_t* self) {
    return self->get_link_title(self);
}

// get_link_metadata
static cef_string_userfree_t cfx_drag_data_get_link_metadata(cef_drag_data_t* self) {
    return self->get_link_metadata(self);
}

// get_fragment_text
static cef_string_userfree_t cfx_drag_data_get_fragment_text(cef_drag_data_t* self) {
    return self->get_fragment_text(self);
}

// get_fragment_html
static cef_string_userfree_t cfx_drag_data_get_fragment_html(cef_drag_data_t* self) {
    return self->get_fragment_html(self);
}

// get_fragment_base_url
static cef_string_userfree_t cfx_drag_data_get_fragment_base_url(cef_drag_data_t* self) {
    return self->get_fragment_base_url(self);
}

// get_file_name
static cef_string_userfree_t cfx_drag_data_get_file_name(cef_drag_data_t* self) {
    return self->get_file_name(self);
}

// get_file_contents
static int cfx_drag_data_get_file_contents(cef_drag_data_t* self, cef_stream_writer_t* writer) {
    if(writer) ((cef_base_t*)writer)->add_ref((cef_base_t*)writer);
    return (int)(self->get_file_contents(self, writer));
}

// get_file_names
static int cfx_drag_data_get_file_names(cef_drag_data_t* self, cef_string_list_t names) {
    return self->get_file_names(self, names);
}

// set_link_url
static void cfx_drag_data_set_link_url(cef_drag_data_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->set_link_url(self, &url);
}

// set_link_title
static void cfx_drag_data_set_link_title(cef_drag_data_t* self, char16 *title_str, int title_length) {
    cef_string_t title = { title_str, title_length, 0 };
    self->set_link_title(self, &title);
}

// set_link_metadata
static void cfx_drag_data_set_link_metadata(cef_drag_data_t* self, char16 *data_str, int data_length) {
    cef_string_t data = { data_str, data_length, 0 };
    self->set_link_metadata(self, &data);
}

// set_fragment_text
static void cfx_drag_data_set_fragment_text(cef_drag_data_t* self, char16 *text_str, int text_length) {
    cef_string_t text = { text_str, text_length, 0 };
    self->set_fragment_text(self, &text);
}

// set_fragment_html
static void cfx_drag_data_set_fragment_html(cef_drag_data_t* self, char16 *html_str, int html_length) {
    cef_string_t html = { html_str, html_length, 0 };
    self->set_fragment_html(self, &html);
}

// set_fragment_base_url
static void cfx_drag_data_set_fragment_base_url(cef_drag_data_t* self, char16 *base_url_str, int base_url_length) {
    cef_string_t base_url = { base_url_str, base_url_length, 0 };
    self->set_fragment_base_url(self, &base_url);
}

// reset_file_contents
static void cfx_drag_data_reset_file_contents(cef_drag_data_t* self) {
    self->reset_file_contents(self);
}

// add_file
static void cfx_drag_data_add_file(cef_drag_data_t* self, char16 *path_str, int path_length, char16 *display_name_str, int display_name_length) {
    cef_string_t path = { path_str, path_length, 0 };
    cef_string_t display_name = { display_name_str, display_name_length, 0 };
    self->add_file(self, &path, &display_name);
}


