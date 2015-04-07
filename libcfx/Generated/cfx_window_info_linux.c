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


// cef_window_info_linux

#ifdef __cplusplus
extern "C" {
#endif

#ifdef CFX_LINUX

static cef_window_info_t* cfx_window_info_linux_ctor() {
    return (cef_window_info_t*)calloc(1, sizeof(cef_window_info_t));
}

static void cfx_window_info_linux_dtor(cef_window_info_t* self) {
    free(self);
}

// cef_window_info_t->parent_widget
static void cfx_window_info_linux_set_parent_widget(cef_window_info_t *self, cef_window_handle_t parent_widget) {
    self->parent_widget = parent_widget;
}
static void cfx_window_info_linux_get_parent_widget(cef_window_info_t *self, cef_window_handle_t* parent_widget) {
    *parent_widget = self->parent_widget;
}

// cef_window_info_t->window_rendering_disabled
static void cfx_window_info_linux_set_window_rendering_disabled(cef_window_info_t *self, int window_rendering_disabled) {
    self->window_rendering_disabled = window_rendering_disabled;
}
static void cfx_window_info_linux_get_window_rendering_disabled(cef_window_info_t *self, int* window_rendering_disabled) {
    *window_rendering_disabled = self->window_rendering_disabled;
}

// cef_window_info_t->transparent_painting
static void cfx_window_info_linux_set_transparent_painting(cef_window_info_t *self, int transparent_painting) {
    self->transparent_painting = transparent_painting;
}
static void cfx_window_info_linux_get_transparent_painting(cef_window_info_t *self, int* transparent_painting) {
    *transparent_painting = self->transparent_painting;
}

// cef_window_info_t->widget
static void cfx_window_info_linux_set_widget(cef_window_info_t *self, cef_window_handle_t widget) {
    self->widget = widget;
}
static void cfx_window_info_linux_get_widget(cef_window_info_t *self, cef_window_handle_t* widget) {
    *widget = self->widget;
}

#else //ifdef CFX_LINUX
#define cfx_window_info_linux_ctor 0
#define cfx_window_info_linux_dtor 0
#define cfx_window_info_linux_set_parent_widget 0
#define cfx_window_info_linux_get_parent_widget 0
#define cfx_window_info_linux_set_window_rendering_disabled 0
#define cfx_window_info_linux_get_window_rendering_disabled 0
#define cfx_window_info_linux_set_transparent_painting 0
#define cfx_window_info_linux_get_transparent_painting 0
#define cfx_window_info_linux_set_widget 0
#define cfx_window_info_linux_get_widget 0
#endif //ifdef CFX_LINUX


#ifdef __cplusplus
} // extern "C"
#endif

