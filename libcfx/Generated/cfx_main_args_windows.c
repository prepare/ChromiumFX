// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_main_args_windows

#ifdef CFX_WINDOWS

static cef_main_args_t* cfx_main_args_windows_ctor() {
    return (cef_main_args_t*)calloc(1, sizeof(cef_main_args_t));
}

static void cfx_main_args_windows_dtor(cef_main_args_t* self) {
    free(self);
}

// cef_main_args_t->instance
static void cfx_main_args_windows_set_instance(cef_main_args_t *self, HINSTANCE instance) {
    self->instance = instance;
}
static void cfx_main_args_windows_get_instance(cef_main_args_t *self, HINSTANCE* instance) {
    *instance = self->instance;
}

#else //ifdef CFX_WINDOWS
#define cfx_main_args_windows_ctor 0
#define cfx_main_args_windows_dtor 0
#define cfx_main_args_windows_set_instance 0
#define cfx_main_args_windows_get_instance 0
#endif //ifdef CFX_WINDOWS


