// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_extension

// get_identifier
static cef_string_userfree_t cfx_extension_get_identifier(cef_extension_t* self) {
    return self->get_identifier(self);
}

// get_path
static cef_string_userfree_t cfx_extension_get_path(cef_extension_t* self) {
    return self->get_path(self);
}

// get_manifest
static cef_dictionary_value_t* cfx_extension_get_manifest(cef_extension_t* self) {
    return self->get_manifest(self);
}

// is_same
static int cfx_extension_is_same(cef_extension_t* self, cef_extension_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// get_handler
static cef_extension_handler_t* cfx_extension_get_handler(cef_extension_t* self) {
    return self->get_handler(self);
}

// get_loader_context
static cef_request_context_t* cfx_extension_get_loader_context(cef_extension_t* self) {
    return self->get_loader_context(self);
}

// is_loaded
static int cfx_extension_is_loaded(cef_extension_t* self) {
    return self->is_loaded(self);
}

// unload
static void cfx_extension_unload(cef_extension_t* self) {
    self->unload(self);
}


