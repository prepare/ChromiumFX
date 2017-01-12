// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_x509cert_principal

// get_display_name
static cef_string_userfree_t cfx_x509cert_principal_get_display_name(cef_x509cert_principal_t* self) {
    return self->get_display_name(self);
}

// get_common_name
static cef_string_userfree_t cfx_x509cert_principal_get_common_name(cef_x509cert_principal_t* self) {
    return self->get_common_name(self);
}

// get_locality_name
static cef_string_userfree_t cfx_x509cert_principal_get_locality_name(cef_x509cert_principal_t* self) {
    return self->get_locality_name(self);
}

// get_state_or_province_name
static cef_string_userfree_t cfx_x509cert_principal_get_state_or_province_name(cef_x509cert_principal_t* self) {
    return self->get_state_or_province_name(self);
}

// get_country_name
static cef_string_userfree_t cfx_x509cert_principal_get_country_name(cef_x509cert_principal_t* self) {
    return self->get_country_name(self);
}

// get_street_addresses
static void cfx_x509cert_principal_get_street_addresses(cef_x509cert_principal_t* self, cef_string_list_t addresses) {
    self->get_street_addresses(self, addresses);
}

// get_organization_names
static void cfx_x509cert_principal_get_organization_names(cef_x509cert_principal_t* self, cef_string_list_t names) {
    self->get_organization_names(self, names);
}

// get_organization_unit_names
static void cfx_x509cert_principal_get_organization_unit_names(cef_x509cert_principal_t* self, cef_string_list_t names) {
    self->get_organization_unit_names(self, names);
}

// get_domain_components
static void cfx_x509cert_principal_get_domain_components(cef_x509cert_principal_t* self, cef_string_list_t components) {
    self->get_domain_components(self, components);
}


