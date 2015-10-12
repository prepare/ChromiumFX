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


// cef_process_message

// CEF_EXPORT cef_process_message_t* cef_process_message_create(const cef_string_t* name);
static cef_process_message_t* cfx_process_message_create(char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return cef_process_message_create(&name);
}
// is_valid
static int cfx_process_message_is_valid(cef_process_message_t* self) {
    return self->is_valid(self);
}

// is_read_only
static int cfx_process_message_is_read_only(cef_process_message_t* self) {
    return self->is_read_only(self);
}

// copy
static cef_process_message_t* cfx_process_message_copy(cef_process_message_t* self) {
    return self->copy(self);
}

// get_name
static cef_string_userfree_t cfx_process_message_get_name(cef_process_message_t* self) {
    return self->get_name(self);
}

// get_argument_list
static cef_list_value_t* cfx_process_message_get_argument_list(cef_process_message_t* self) {
    return self->get_argument_list(self);
}


