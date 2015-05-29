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


// cef_context_menu_params

#ifdef __cplusplus
extern "C" {
#endif

// cef_base_t base

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


#ifdef __cplusplus
} // extern "C"
#endif

