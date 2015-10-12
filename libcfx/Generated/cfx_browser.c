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
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
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
static int cfx_browser_get_frame_count(cef_browser_t* self) {
    return (int)(self->get_frame_count(self));
}

// get_frame_identifiers
static void cfx_browser_get_frame_identifiers(cef_browser_t* self, int identifiersCount, int64* identifiers) {
    size_t tmp_identifiersCount = (size_t)identifiersCount;
    self->get_frame_identifiers(self, &tmp_identifiersCount, identifiers);
}

// get_frame_names
static void cfx_browser_get_frame_names(cef_browser_t* self, cef_string_list_t names) {
    self->get_frame_names(self, names);
}

// send_process_message
static int cfx_browser_send_process_message(cef_browser_t* self, cef_process_id_t target_process, cef_process_message_t* message) {
    if(message) ((cef_base_t*)message)->add_ref((cef_base_t*)message);
    return self->send_process_message(self, target_process, message);
}


