// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_select_client_certificate_callback

// select
static void cfx_select_client_certificate_callback_select(cef_select_client_certificate_callback_t* self, cef_x509certificate_t* cert) {
    if(cert) ((cef_base_ref_counted_t*)cert)->add_ref((cef_base_ref_counted_t*)cert);
    self->select(self, cert);
}


