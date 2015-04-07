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

#ifdef __cplusplus
extern "C" {
#endif

// cef_base_t base

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

// get_file_names
static int cfx_drag_data_get_file_names(cef_drag_data_t* self, cef_string_list_t names) {
    return self->get_file_names(self, names);
}


#ifdef __cplusplus
} // extern "C"
#endif

