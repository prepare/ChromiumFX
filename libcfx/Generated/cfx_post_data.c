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


// cef_post_data

// CEF_EXPORT cef_post_data_t* cef_post_data_create();
static cef_post_data_t* cfx_post_data_create() {
    return cef_post_data_create();
}
// is_read_only
static int cfx_post_data_is_read_only(cef_post_data_t* self) {
    return self->is_read_only(self);
}

// has_excluded_elements
static int cfx_post_data_has_excluded_elements(cef_post_data_t* self) {
    return self->has_excluded_elements(self);
}

// get_element_count
static int cfx_post_data_get_element_count(cef_post_data_t* self) {
    return (int)(self->get_element_count(self));
}

// get_elements
static void cfx_post_data_get_elements(cef_post_data_t* self, int elementsCount, cef_post_data_element_t** elements) {
    size_t tmp_elementsCount = (size_t)elementsCount;
    self->get_elements(self, &tmp_elementsCount, elements);
}

// remove_element
static int cfx_post_data_remove_element(cef_post_data_t* self, cef_post_data_element_t* element) {
    if(element) ((cef_base_t*)element)->add_ref((cef_base_t*)element);
    return self->remove_element(self, element);
}

// add_element
static int cfx_post_data_add_element(cef_post_data_t* self, cef_post_data_element_t* element) {
    if(element) ((cef_base_t*)element)->add_ref((cef_base_t*)element);
    return self->add_element(self, element);
}

// remove_elements
static void cfx_post_data_remove_elements(cef_post_data_t* self) {
    self->remove_elements(self);
}


