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


