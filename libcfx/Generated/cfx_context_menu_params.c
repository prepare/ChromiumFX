// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_context_menu_params

// get_xcoord
static int cfx_context_menu_params_get_xcoord(cef_context_menu_params_t* self) {
    return self->get_xcoord(self);
}

// get_ycoord
static int cfx_context_menu_params_get_ycoord(cef_context_menu_params_t* self) {
    return self->get_ycoord(self);
}

// get_type_flags
static cef_context_menu_type_flags_t cfx_context_menu_params_get_type_flags(cef_context_menu_params_t* self) {
    return self->get_type_flags(self);
}

// get_link_url
static cef_string_userfree_t cfx_context_menu_params_get_link_url(cef_context_menu_params_t* self) {
    return self->get_link_url(self);
}

// get_unfiltered_link_url
static cef_string_userfree_t cfx_context_menu_params_get_unfiltered_link_url(cef_context_menu_params_t* self) {
    return self->get_unfiltered_link_url(self);
}

// get_source_url
static cef_string_userfree_t cfx_context_menu_params_get_source_url(cef_context_menu_params_t* self) {
    return self->get_source_url(self);
}

// has_image_contents
static int cfx_context_menu_params_has_image_contents(cef_context_menu_params_t* self) {
    return self->has_image_contents(self);
}

// get_page_url
static cef_string_userfree_t cfx_context_menu_params_get_page_url(cef_context_menu_params_t* self) {
    return self->get_page_url(self);
}

// get_frame_url
static cef_string_userfree_t cfx_context_menu_params_get_frame_url(cef_context_menu_params_t* self) {
    return self->get_frame_url(self);
}

// get_frame_charset
static cef_string_userfree_t cfx_context_menu_params_get_frame_charset(cef_context_menu_params_t* self) {
    return self->get_frame_charset(self);
}

// get_media_type
static cef_context_menu_media_type_t cfx_context_menu_params_get_media_type(cef_context_menu_params_t* self) {
    return self->get_media_type(self);
}

// get_media_state_flags
static cef_context_menu_media_state_flags_t cfx_context_menu_params_get_media_state_flags(cef_context_menu_params_t* self) {
    return self->get_media_state_flags(self);
}

// get_selection_text
static cef_string_userfree_t cfx_context_menu_params_get_selection_text(cef_context_menu_params_t* self) {
    return self->get_selection_text(self);
}

// get_misspelled_word
static cef_string_userfree_t cfx_context_menu_params_get_misspelled_word(cef_context_menu_params_t* self) {
    return self->get_misspelled_word(self);
}

// get_dictionary_suggestions
static int cfx_context_menu_params_get_dictionary_suggestions(cef_context_menu_params_t* self, cef_string_list_t suggestions) {
    return self->get_dictionary_suggestions(self, suggestions);
}

// is_editable
static int cfx_context_menu_params_is_editable(cef_context_menu_params_t* self) {
    return self->is_editable(self);
}

// is_spell_check_enabled
static int cfx_context_menu_params_is_spell_check_enabled(cef_context_menu_params_t* self) {
    return self->is_spell_check_enabled(self);
}

// get_edit_state_flags
static cef_context_menu_edit_state_flags_t cfx_context_menu_params_get_edit_state_flags(cef_context_menu_params_t* self) {
    return self->get_edit_state_flags(self);
}

// is_custom_menu
static int cfx_context_menu_params_is_custom_menu(cef_context_menu_params_t* self) {
    return self->is_custom_menu(self);
}

// is_pepper_menu
static int cfx_context_menu_params_is_pepper_menu(cef_context_menu_params_t* self) {
    return self->is_pepper_menu(self);
}


