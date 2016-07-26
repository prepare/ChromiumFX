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


// cef_post_data_element

// CEF_EXPORT cef_post_data_element_t* cef_post_data_element_create();
static cef_post_data_element_t* cfx_post_data_element_create() {
    return cef_post_data_element_create();
}
// is_read_only
static int cfx_post_data_element_is_read_only(cef_post_data_element_t* self) {
    return self->is_read_only(self);
}

// set_to_empty
static void cfx_post_data_element_set_to_empty(cef_post_data_element_t* self) {
    self->set_to_empty(self);
}

// set_to_file
static void cfx_post_data_element_set_to_file(cef_post_data_element_t* self, char16 *fileName_str, int fileName_length) {
    cef_string_t fileName = { fileName_str, fileName_length, 0 };
    self->set_to_file(self, &fileName);
}

// set_to_bytes
static void cfx_post_data_element_set_to_bytes(cef_post_data_element_t* self, size_t size, const void* bytes) {
    self->set_to_bytes(self, size, bytes);
}

// get_type
static cef_postdataelement_type_t cfx_post_data_element_get_type(cef_post_data_element_t* self) {
    return self->get_type(self);
}

// get_file
static cef_string_userfree_t cfx_post_data_element_get_file(cef_post_data_element_t* self) {
    return self->get_file(self);
}

// get_bytes_count
static size_t cfx_post_data_element_get_bytes_count(cef_post_data_element_t* self) {
    return self->get_bytes_count(self);
}

// get_bytes
static size_t cfx_post_data_element_get_bytes(cef_post_data_element_t* self, size_t size, void* bytes) {
    return self->get_bytes(self, size, bytes);
}


