// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_x509certificate

// get_subject
static cef_x509cert_principal_t* cfx_x509certificate_get_subject(cef_x509certificate_t* self) {
    return self->get_subject(self);
}

// get_issuer
static cef_x509cert_principal_t* cfx_x509certificate_get_issuer(cef_x509certificate_t* self) {
    return self->get_issuer(self);
}

// get_serial_number
static cef_binary_value_t* cfx_x509certificate_get_serial_number(cef_x509certificate_t* self) {
    return self->get_serial_number(self);
}

// get_valid_start
static cef_time_t* cfx_x509certificate_get_valid_start(cef_x509certificate_t* self) {
    cef_time_t *__retval = malloc(sizeof(cef_time_t));
    if(__retval) *__retval = self->get_valid_start(self);
    return __retval;
}

// get_valid_expiry
static cef_time_t* cfx_x509certificate_get_valid_expiry(cef_x509certificate_t* self) {
    cef_time_t *__retval = malloc(sizeof(cef_time_t));
    if(__retval) *__retval = self->get_valid_expiry(self);
    return __retval;
}

// get_derencoded
static cef_binary_value_t* cfx_x509certificate_get_derencoded(cef_x509certificate_t* self) {
    return self->get_derencoded(self);
}

// get_pemencoded
static cef_binary_value_t* cfx_x509certificate_get_pemencoded(cef_x509certificate_t* self) {
    return self->get_pemencoded(self);
}

// get_issuer_chain_size
static size_t cfx_x509certificate_get_issuer_chain_size(cef_x509certificate_t* self) {
    return self->get_issuer_chain_size(self);
}

// get_derencoded_issuer_chain
static void cfx_x509certificate_get_derencoded_issuer_chain(cef_x509certificate_t* self, size_t chainCount, cef_binary_value_t** chain) {
    self->get_derencoded_issuer_chain(self, &chainCount, chain);
}

// get_pemencoded_issuer_chain
static void cfx_x509certificate_get_pemencoded_issuer_chain(cef_x509certificate_t* self, size_t chainCount, cef_binary_value_t** chain) {
    self->get_pemencoded_issuer_chain(self, &chainCount, chain);
}


