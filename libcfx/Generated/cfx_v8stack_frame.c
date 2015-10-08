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


// cef_v8stack_frame

// cef_base_t base

// is_valid
static int cfx_v8stack_frame_is_valid(cef_v8stack_frame_t* self) {
    return self->is_valid(self);
}

// get_script_name
static cef_string_userfree_t cfx_v8stack_frame_get_script_name(cef_v8stack_frame_t* self) {
    return self->get_script_name(self);
}

// get_script_name_or_source_url
static cef_string_userfree_t cfx_v8stack_frame_get_script_name_or_source_url(cef_v8stack_frame_t* self) {
    return self->get_script_name_or_source_url(self);
}

// get_function_name
static cef_string_userfree_t cfx_v8stack_frame_get_function_name(cef_v8stack_frame_t* self) {
    return self->get_function_name(self);
}

// get_line_number
static int cfx_v8stack_frame_get_line_number(cef_v8stack_frame_t* self) {
    return self->get_line_number(self);
}

// get_column
static int cfx_v8stack_frame_get_column(cef_v8stack_frame_t* self) {
    return self->get_column(self);
}

// is_eval
static int cfx_v8stack_frame_is_eval(cef_v8stack_frame_t* self) {
    return self->is_eval(self);
}

// is_constructor
static int cfx_v8stack_frame_is_constructor(cef_v8stack_frame_t* self) {
    return self->is_constructor(self);
}


