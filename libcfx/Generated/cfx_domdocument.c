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


// cef_domdocument

// get_type
static cef_dom_document_type_t cfx_domdocument_get_type(cef_domdocument_t* self) {
    return self->get_type(self);
}

// get_document
static cef_domnode_t* cfx_domdocument_get_document(cef_domdocument_t* self) {
    return self->get_document(self);
}

// get_body
static cef_domnode_t* cfx_domdocument_get_body(cef_domdocument_t* self) {
    return self->get_body(self);
}

// get_head
static cef_domnode_t* cfx_domdocument_get_head(cef_domdocument_t* self) {
    return self->get_head(self);
}

// get_title
static cef_string_userfree_t cfx_domdocument_get_title(cef_domdocument_t* self) {
    return self->get_title(self);
}

// get_element_by_id
static cef_domnode_t* cfx_domdocument_get_element_by_id(cef_domdocument_t* self, char16 *id_str, int id_length) {
    cef_string_t id = { id_str, id_length, 0 };
    return self->get_element_by_id(self, &id);
}

// get_focused_node
static cef_domnode_t* cfx_domdocument_get_focused_node(cef_domdocument_t* self) {
    return self->get_focused_node(self);
}

// has_selection
static int cfx_domdocument_has_selection(cef_domdocument_t* self) {
    return self->has_selection(self);
}

// get_selection_start_offset
static int cfx_domdocument_get_selection_start_offset(cef_domdocument_t* self) {
    return self->get_selection_start_offset(self);
}

// get_selection_end_offset
static int cfx_domdocument_get_selection_end_offset(cef_domdocument_t* self) {
    return self->get_selection_end_offset(self);
}

// get_selection_as_markup
static cef_string_userfree_t cfx_domdocument_get_selection_as_markup(cef_domdocument_t* self) {
    return self->get_selection_as_markup(self);
}

// get_selection_as_text
static cef_string_userfree_t cfx_domdocument_get_selection_as_text(cef_domdocument_t* self) {
    return self->get_selection_as_text(self);
}

// get_base_url
static cef_string_userfree_t cfx_domdocument_get_base_url(cef_domdocument_t* self) {
    return self->get_base_url(self);
}

// get_complete_url
static cef_string_userfree_t cfx_domdocument_get_complete_url(cef_domdocument_t* self, char16 *partialURL_str, int partialURL_length) {
    cef_string_t partialURL = { partialURL_str, partialURL_length, 0 };
    return self->get_complete_url(self, &partialURL);
}


