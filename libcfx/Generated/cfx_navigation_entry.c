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


// cef_navigation_entry

// cef_base_t base

// is_valid
static int cfx_navigation_entry_is_valid(cef_navigation_entry_t* self) {
    return self->is_valid(self);
}

// get_url
static cef_string_userfree_t cfx_navigation_entry_get_url(cef_navigation_entry_t* self) {
    return self->get_url(self);
}

// get_display_url
static cef_string_userfree_t cfx_navigation_entry_get_display_url(cef_navigation_entry_t* self) {
    return self->get_display_url(self);
}

// get_original_url
static cef_string_userfree_t cfx_navigation_entry_get_original_url(cef_navigation_entry_t* self) {
    return self->get_original_url(self);
}

// get_title
static cef_string_userfree_t cfx_navigation_entry_get_title(cef_navigation_entry_t* self) {
    return self->get_title(self);
}

// get_transition_type
static cef_transition_type_t cfx_navigation_entry_get_transition_type(cef_navigation_entry_t* self) {
    return self->get_transition_type(self);
}

// has_post_data
static int cfx_navigation_entry_has_post_data(cef_navigation_entry_t* self) {
    return self->has_post_data(self);
}

// get_completion_time
static cef_time_t* cfx_navigation_entry_get_completion_time(cef_navigation_entry_t* self) {
    cef_time_t __retval_tmp = self->get_completion_time(self);
    return (cef_time_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_time_t));
}

// get_http_status_code
static int cfx_navigation_entry_get_http_status_code(cef_navigation_entry_t* self) {
    return self->get_http_status_code(self);
}


