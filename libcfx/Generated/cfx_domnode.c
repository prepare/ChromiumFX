// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
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
    cef_rect_t *__retval = malloc(sizeof(cef_rect_t));
    if(__retval) *__retval = self->get_element_bounds(self);
    return __retval;
}


