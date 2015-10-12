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


// cef_v8context

// CEF_EXPORT cef_v8context_t* cef_v8context_get_current_context();
static cef_v8context_t* cfx_v8context_get_current_context() {
    return cef_v8context_get_current_context();
}
// CEF_EXPORT cef_v8context_t* cef_v8context_get_entered_context();
static cef_v8context_t* cfx_v8context_get_entered_context() {
    return cef_v8context_get_entered_context();
}
// CEF_EXPORT int cef_v8context_in_context();
static int cfx_v8context_in_context() {
    return cef_v8context_in_context();
}
// get_task_runner
static cef_task_runner_t* cfx_v8context_get_task_runner(cef_v8context_t* self) {
    return self->get_task_runner(self);
}

// is_valid
static int cfx_v8context_is_valid(cef_v8context_t* self) {
    return self->is_valid(self);
}

// get_browser
static cef_browser_t* cfx_v8context_get_browser(cef_v8context_t* self) {
    return self->get_browser(self);
}

// get_frame
static cef_frame_t* cfx_v8context_get_frame(cef_v8context_t* self) {
    return self->get_frame(self);
}

// get_global
static cef_v8value_t* cfx_v8context_get_global(cef_v8context_t* self) {
    return self->get_global(self);
}

// enter
static int cfx_v8context_enter(cef_v8context_t* self) {
    return self->enter(self);
}

// exit
static int cfx_v8context_exit(cef_v8context_t* self) {
    return self->exit(self);
}

// is_same
static int cfx_v8context_is_same(cef_v8context_t* self, cef_v8context_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// eval
static int cfx_v8context_eval(cef_v8context_t* self, char16 *code_str, int code_length, cef_v8value_t** retval, cef_v8exception_t** exception) {
    cef_string_t code = { code_str, code_length, 0 };
    return self->eval(self, &code, retval, exception);
}


