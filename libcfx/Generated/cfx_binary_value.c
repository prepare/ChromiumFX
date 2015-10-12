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


// cef_binary_value

// CEF_EXPORT cef_binary_value_t* cef_binary_value_create(const void* data, size_t data_size);
static cef_binary_value_t* cfx_binary_value_create(const void* data, int data_size) {
    return cef_binary_value_create(data, (size_t)(data_size));
}
// is_valid
static int cfx_binary_value_is_valid(cef_binary_value_t* self) {
    return self->is_valid(self);
}

// is_owned
static int cfx_binary_value_is_owned(cef_binary_value_t* self) {
    return self->is_owned(self);
}

// is_same
static int cfx_binary_value_is_same(cef_binary_value_t* self, cef_binary_value_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// is_equal
static int cfx_binary_value_is_equal(cef_binary_value_t* self, cef_binary_value_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_equal(self, that);
}

// copy
static cef_binary_value_t* cfx_binary_value_copy(cef_binary_value_t* self) {
    return self->copy(self);
}

// get_size
static int cfx_binary_value_get_size(cef_binary_value_t* self) {
    return (int)(self->get_size(self));
}

// get_data
static int cfx_binary_value_get_data(cef_binary_value_t* self, void* buffer, int buffer_size, int data_offset) {
    return (int)(self->get_data(self, buffer, (size_t)(buffer_size), (size_t)(data_offset)));
}


