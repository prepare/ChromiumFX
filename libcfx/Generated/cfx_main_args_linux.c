// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


