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


// cef_sslcert_principal

// get_display_name
static cef_string_userfree_t cfx_sslcert_principal_get_display_name(cef_sslcert_principal_t* self) {
    return self->get_display_name(self);
}

// get_common_name
static cef_string_userfree_t cfx_sslcert_principal_get_common_name(cef_sslcert_principal_t* self) {
    return self->get_common_name(self);
}

// get_locality_name
static cef_string_userfree_t cfx_sslcert_principal_get_locality_name(cef_sslcert_principal_t* self) {
    return self->get_locality_name(self);
}

// get_state_or_province_name
static cef_string_userfree_t cfx_sslcert_principal_get_state_or_province_name(cef_sslcert_principal_t* self) {
    return self->get_state_or_province_name(self);
}

// get_country_name
static cef_string_userfree_t cfx_sslcert_principal_get_country_name(cef_sslcert_principal_t* self) {
    return self->get_country_name(self);
}

// get_street_addresses
static void cfx_sslcert_principal_get_street_addresses(cef_sslcert_principal_t* self, cef_string_list_t addresses) {
    self->get_street_addresses(self, addresses);
}

// get_organization_names
static void cfx_sslcert_principal_get_organization_names(cef_sslcert_principal_t* self, cef_string_list_t names) {
    self->get_organization_names(self, names);
}

// get_organization_unit_names
static void cfx_sslcert_principal_get_organization_unit_names(cef_sslcert_principal_t* self, cef_string_list_t names) {
    self->get_organization_unit_names(self, names);
}

// get_domain_components
static void cfx_sslcert_principal_get_domain_components(cef_sslcert_principal_t* self, cef_string_list_t components) {
    self->get_domain_components(self, components);
}


