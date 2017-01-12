// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_sslstatus

// is_secure_connection
static int cfx_sslstatus_is_secure_connection(cef_sslstatus_t* self) {
    return self->is_secure_connection(self);
}

// get_cert_status
static cef_cert_status_t cfx_sslstatus_get_cert_status(cef_sslstatus_t* self) {
    return self->get_cert_status(self);
}

// get_sslversion
static cef_ssl_version_t cfx_sslstatus_get_sslversion(cef_sslstatus_t* self) {
    return self->get_sslversion(self);
}

// get_content_status
static cef_ssl_content_status_t cfx_sslstatus_get_content_status(cef_sslstatus_t* self) {
    return self->get_content_status(self);
}

// get_x509certificate
static cef_x509certificate_t* cfx_sslstatus_get_x509certificate(cef_sslstatus_t* self) {
    return self->get_x509certificate(self);
}


