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


// cef_domnode

// get_type
static cef_dom_node_type_t cfx_domnode_get_type(cef_domnode_t* self) {
    return self->get_type(self);
}

// is_text
static int cfx_domnode_is_text(cef_domnode_t* self) {
    return self->is_text(self);
}

// is_element
static int cfx_domnode_is_element(cef_domnode_t* self) {
    return self->is_element(self);
}

// is_editable
static int cfx_domnode_is_editable(cef_domnode_t* self) {
    return self->is_editable(self);
}

// is_form_control_element
static int cfx_domnode_is_form_control_element(cef_domnode_t* self) {
    return self->is_form_control_element(self);
}

// get_form_control_element_type
static cef_string_userfree_t cfx_domnode_get_form_control_element_type(cef_domnode_t* self) {
    return self->get_form_control_element_type(self);
}

// is_same
static int cfx_domnode_is_same(cef_domnode_t* self, cef_domnode_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// get_name
static cef_string_userfree_t cfx_domnode_get_name(cef_domnode_t* self) {
    return self->get_name(self);
}

// get_value
static cef_string_userfree_t cfx_domnode_get_value(cef_domnode_t* self) {
    return self->get_value(self);
}

// set_value
static int cfx_domnode_set_value(cef_domnode_t* self, char16 *value_str, int value_length) {
    cef_string_t value = { value_str, value_length, 0 };
    return self->set_value(self, &value);
}

// get_as_markup
static cef_string_userfree_t cfx_domnode_get_as_markup(cef_domnode_t* self) {
    return self->get_as_markup(self);
}

// get_document
static cef_domdocument_t* cfx_domnode_get_document(cef_domnode_t* self) {
    return self->get_document(self);
}

// get_parent
static cef_domnode_t* cfx_domnode_get_parent(cef_domnode_t* self) {
    return self->get_parent(self);
}

// get_previous_sibling
static cef_domnode_t* cfx_domnode_get_previous_sibling(cef_domnode_t* self) {
    return self->get_previous_sibling(self);
}

// get_next_sibling
static cef_domnode_t* cfx_domnode_get_next_sibling(cef_domnode_t* self) {
    return self->get_next_sibling(self);
}

// has_children
static int cfx_domnode_has_children(cef_domnode_t* self) {
    return self->has_children(self);
}

// get_first_child
static cef_domnode_t* cfx_domnode_get_first_child(cef_domnode_t* self) {
    return self->get_first_child(self);
}

// get_last_child
static cef_domnode_t* cfx_domnode_get_last_child(cef_domnode_t* self) {
    return self->get_last_child(self);
}

// get_element_tag_name
static cef_string_userfree_t cfx_domnode_get_element_tag_name(cef_domnode_t* self) {
    return self->get_element_tag_name(self);
}

// has_element_attributes
static int cfx_domnode_has_element_attributes(cef_domnode_t* self) {
    return self->has_element_attributes(self);
}

// has_element_attribute
static int cfx_domnode_has_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length) {
    cef_string_t attrName = { attrName_str, attrName_length, 0 };
    return self->has_element_attribute(self, &attrName);
}

// get_element_attribute
static cef_string_userfree_t cfx_domnode_get_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length) {
    cef_string_t attrName = { attrName_str, attrName_length, 0 };
    return self->get_element_attribute(self, &attrName);
}

// get_element_attributes
static void cfx_domnode_get_element_attributes(cef_domnode_t* self, cef_string_map_t attrMap) {
    self->get_element_attributes(self, attrMap);
}

// set_element_attribute
static int cfx_domnode_set_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length, char16 *value_str, int value_length) {
    cef_string_t attrName = { attrName_str, attrName_length, 0 };
    cef_string_t value = { value_str, value_length, 0 };
    return self->set_element_attribute(self, &attrName, &value);
}

// get_element_inner_text
static cef_string_userfree_t cfx_domnode_get_element_inner_text(cef_domnode_t* self) {
    return self->get_element_inner_text(self);
}

// get_element_bounds
static cef_rect_t* cfx_domnode_get_element_bounds(cef_domnode_t* self) {
    cef_rect_t __retval_tmp = self->get_element_bounds(self);
    return (cef_rect_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_rect_t));
}


