// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_resource_bundle

// CEF_EXPORT cef_resource_bundle_t* cef_resource_bundle_get_global();
static cef_resource_bundle_t* cfx_resource_bundle_get_global() {
    return cef_resource_bundle_get_global();
}
// get_localized_string
static cef_string_userfree_t cfx_resource_bundle_get_localized_string(cef_resource_bundle_t* self, int string_id) {
    return self->get_localized_string(self, string_id);
}

// get_data_resource
static int cfx_resource_bundle_get_data_resource(cef_resource_bundle_t* self, int resource_id, void** data, size_t* data_size) {
    return self->get_data_resource(self, resource_id, data, data_size);
}

// get_data_resource_for_scale
static int cfx_resource_bundle_get_data_resource_for_scale(cef_resource_bundle_t* self, int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size) {
    return self->get_data_resource_for_scale(self, resource_id, scale_factor, data, data_size);
}


