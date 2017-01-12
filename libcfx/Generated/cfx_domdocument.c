// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


