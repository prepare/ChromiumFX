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


// cef_main_args_linux

#ifdef CFX_LINUX

static cef_main_args_t* cfx_main_args_linux_ctor() {
    return (cef_main_args_t*)calloc(1, sizeof(cef_main_args_t));
}

static void cfx_main_args_linux_dtor(cef_main_args_t* self) {
    free(self);
}

// cef_main_args_t->argc
static void cfx_main_args_linux_set_argc(cef_main_args_t *self, int argc) {
    self->argc = argc;
}
static void cfx_main_args_linux_get_argc(cef_main_args_t *self, int* argc) {
    *argc = self->argc;
}

// cef_main_args_t->argv
static void cfx_main_args_linux_set_argv(cef_main_args_t *self, char** argv) {
    self->argv = argv;
}
static void cfx_main_args_linux_get_argv(cef_main_args_t *self, char*** argv) {
    *argv = self->argv;
}

#else //ifdef CFX_LINUX
#define cfx_main_args_linux_ctor 0
#define cfx_main_args_linux_dtor 0
#define cfx_main_args_linux_set_argc 0
#define cfx_main_args_linux_get_argc 0
#define cfx_main_args_linux_set_argv 0
#define cfx_main_args_linux_get_argv 0
#endif //ifdef CFX_LINUX


