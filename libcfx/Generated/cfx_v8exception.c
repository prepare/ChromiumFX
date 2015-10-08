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


// cef_v8exception

// cef_base_t base

// get_message
static cef_string_userfree_t cfx_v8exception_get_message(cef_v8exception_t* self) {
    return self->get_message(self);
}

// get_source_line
static cef_string_userfree_t cfx_v8exception_get_source_line(cef_v8exception_t* self) {
    return self->get_source_line(self);
}

// get_script_resource_name
static cef_string_userfree_t cfx_v8exception_get_script_resource_name(cef_v8exception_t* self) {
    return self->get_script_resource_name(self);
}

// get_line_number
static int cfx_v8exception_get_line_number(cef_v8exception_t* self) {
    return self->get_line_number(self);
}

// get_start_position
static int cfx_v8exception_get_start_position(cef_v8exception_t* self) {
    return self->get_start_position(self);
}

// get_end_position
static int cfx_v8exception_get_end_position(cef_v8exception_t* self) {
    return self->get_end_position(self);
}

// get_start_column
static int cfx_v8exception_get_start_column(cef_v8exception_t* self) {
    return self->get_start_column(self);
}

// get_end_column
static int cfx_v8exception_get_end_column(cef_v8exception_t* self) {
    return self->get_end_column(self);
}


