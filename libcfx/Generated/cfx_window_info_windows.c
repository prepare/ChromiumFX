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


// cef_window_info_windows

#ifdef __cplusplus
extern "C" {
#endif

#ifdef CFX_WINDOWS

static cef_window_info_t* cfx_window_info_windows_ctor() {
    return (cef_window_info_t*)calloc(1, sizeof(cef_window_info_t));
}

static void cfx_window_info_windows_dtor(cef_window_info_t* self) {
    if(self->window_name.dtor) self->window_name.dtor(self->window_name.str);
    free(self);
}

// cef_window_info_t->ex_style
static void cfx_window_info_windows_set_ex_style(cef_window_info_t *self, DWORD ex_style) {
    self->ex_style = ex_style;
}
static void cfx_window_info_windows_get_ex_style(cef_window_info_t *self, DWORD* ex_style) {
    *ex_style = self->ex_style;
}

// cef_window_info_t->window_name
static void cfx_window_info_windows_set_window_name(cef_window_info_t *self, char16 *window_name_str, int window_name_length) {
    cef_string_utf16_set(window_name_str, window_name_length, &(self->window_name), 1);
}
static void cfx_window_info_windows_get_window_name(cef_window_info_t *self, char16 **window_name_str, int *window_name_length) {
    *window_name_str = self->window_name.str;
    *window_name_length = (int)self->window_name.length;
}

// cef_window_info_t->style
static void cfx_window_info_windows_set_style(cef_window_info_t *self, DWORD style) {
    self->style = style;
}
static void cfx_window_info_windows_get_style(cef_window_info_t *self, DWORD* style) {
    *style = self->style;
}

// cef_window_info_t->x
static void cfx_window_info_windows_set_x(cef_window_info_t *self, int x) {
    self->x = x;
}
static void cfx_window_info_windows_get_x(cef_window_info_t *self, int* x) {
    *x = self->x;
}

// cef_window_info_t->y
static void cfx_window_info_windows_set_y(cef_window_info_t *self, int y) {
    self->y = y;
}
static void cfx_window_info_windows_get_y(cef_window_info_t *self, int* y) {
    *y = self->y;
}

// cef_window_info_t->width
static void cfx_window_info_windows_set_width(cef_window_info_t *self, int width) {
    self->width = width;
}
static void cfx_window_info_windows_get_width(cef_window_info_t *self, int* width) {
    *width = self->width;
}

// cef_window_info_t->height
static void cfx_window_info_windows_set_height(cef_window_info_t *self, int height) {
    self->height = height;
}
static void cfx_window_info_windows_get_height(cef_window_info_t *self, int* height) {
    *height = self->height;
}

// cef_window_info_t->parent_window
static void cfx_window_info_windows_set_parent_window(cef_window_info_t *self, cef_window_handle_t parent_window) {
    self->parent_window = parent_window;
}
static void cfx_window_info_windows_get_parent_window(cef_window_info_t *self, cef_window_handle_t* parent_window) {
    *parent_window = self->parent_window;
}

// cef_window_info_t->menu
static void cfx_window_info_windows_set_menu(cef_window_info_t *self, HMENU menu) {
    self->menu = menu;
}
static void cfx_window_info_windows_get_menu(cef_window_info_t *self, HMENU* menu) {
    *menu = self->menu;
}

// cef_window_info_t->windowless_rendering_enabled
static void cfx_window_info_windows_set_windowless_rendering_enabled(cef_window_info_t *self, int windowless_rendering_enabled) {
    self->windowless_rendering_enabled = windowless_rendering_enabled;
}
static void cfx_window_info_windows_get_windowless_rendering_enabled(cef_window_info_t *self, int* windowless_rendering_enabled) {
    *windowless_rendering_enabled = self->windowless_rendering_enabled;
}

// cef_window_info_t->transparent_painting_enabled
static void cfx_window_info_windows_set_transparent_painting_enabled(cef_window_info_t *self, int transparent_painting_enabled) {
    self->transparent_painting_enabled = transparent_painting_enabled;
}
static void cfx_window_info_windows_get_transparent_painting_enabled(cef_window_info_t *self, int* transparent_painting_enabled) {
    *transparent_painting_enabled = self->transparent_painting_enabled;
}

// cef_window_info_t->window
static void cfx_window_info_windows_set_window(cef_window_info_t *self, cef_window_handle_t window) {
    self->window = window;
}
static void cfx_window_info_windows_get_window(cef_window_info_t *self, cef_window_handle_t* window) {
    *window = self->window;
}

#else //ifdef CFX_WINDOWS
#define cfx_window_info_windows_ctor 0
#define cfx_window_info_windows_dtor 0
#define cfx_window_info_windows_set_ex_style 0
#define cfx_window_info_windows_get_ex_style 0
#define cfx_window_info_windows_set_window_name 0
#define cfx_window_info_windows_get_window_name 0
#define cfx_window_info_windows_set_style 0
#define cfx_window_info_windows_get_style 0
#define cfx_window_info_windows_set_x 0
#define cfx_window_info_windows_get_x 0
#define cfx_window_info_windows_set_y 0
#define cfx_window_info_windows_get_y 0
#define cfx_window_info_windows_set_width 0
#define cfx_window_info_windows_get_width 0
#define cfx_window_info_windows_set_height 0
#define cfx_window_info_windows_get_height 0
#define cfx_window_info_windows_set_parent_window 0
#define cfx_window_info_windows_get_parent_window 0
#define cfx_window_info_windows_set_menu 0
#define cfx_window_info_windows_get_menu 0
#define cfx_window_info_windows_set_windowless_rendering_enabled 0
#define cfx_window_info_windows_get_windowless_rendering_enabled 0
#define cfx_window_info_windows_set_transparent_painting_enabled 0
#define cfx_window_info_windows_get_transparent_painting_enabled 0
#define cfx_window_info_windows_set_window 0
#define cfx_window_info_windows_get_window 0
#endif //ifdef CFX_WINDOWS


#ifdef __cplusplus
} // extern "C"
#endif

