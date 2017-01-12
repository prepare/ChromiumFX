// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_sslinfo

// get_cert_status
static cef_cert_status_t cfx_sslinfo_get_cert_status(cef_sslinfo_t* self) {
    return self->get_cert_status(self);
}

// get_x509certificate
static cef_x509certificate_t* cfx_sslinfo_get_x509certificate(cef_sslinfo_t* self) {
    return self->get_x509certificate(self);
}


