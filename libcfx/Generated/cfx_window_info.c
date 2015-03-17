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


// cef_window_info

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_window_info_t* cfx_window_info_ctor() {
    return (cef_window_info_t*)calloc(1, sizeof(cef_window_info_t));
}

CFX_EXPORT void cfx_window_info_dtor(cef_window_info_t* self) {
    if(self->window_name.dtor) self->window_name.dtor(self->window_name.str);
    free(self);
}

// cef_window_info_t->ex_style
CFX_EXPORT void cfx_window_info_set_ex_style(cef_window_info_t *self, DWORD ex_style) {
    self->ex_style = ex_style;
}
CFX_EXPORT void cfx_window_info_get_ex_style(cef_window_info_t *self, DWORD* ex_style) {
    *ex_style = self->ex_style;
}

// cef_window_info_t->window_name
CFX_EXPORT void cfx_window_info_set_window_name(cef_window_info_t *self, char16 *window_name_str, int window_name_length) {
    cef_string_utf16_set(window_name_str, window_name_length, &(self->window_name), 1);
}
CFX_EXPORT void cfx_window_info_get_window_name(cef_window_info_t *self, char16 **window_name_str, int *window_name_length) {
    *window_name_str = self->window_name.str;
    *window_name_length = self->window_name.length;
}

// cef_window_info_t->style
CFX_EXPORT void cfx_window_info_set_style(cef_window_info_t *self, DWORD style) {
    self->style = style;
}
CFX_EXPORT void cfx_window_info_get_style(cef_window_info_t *self, DWORD* style) {
    *style = self->style;
}

// cef_window_info_t->x
CFX_EXPORT void cfx_window_info_set_x(cef_window_info_t *self, int x) {
    self->x = x;
}
CFX_EXPORT void cfx_window_info_get_x(cef_window_info_t *self, int* x) {
    *x = self->x;
}

// cef_window_info_t->y
CFX_EXPORT void cfx_window_info_set_y(cef_window_info_t *self, int y) {
    self->y = y;
}
CFX_EXPORT void cfx_window_info_get_y(cef_window_info_t *self, int* y) {
    *y = self->y;
}

// cef_window_info_t->width
CFX_EXPORT void cfx_window_info_set_width(cef_window_info_t *self, int width) {
    self->width = width;
}
CFX_EXPORT void cfx_window_info_get_width(cef_window_info_t *self, int* width) {
    *width = self->width;
}

// cef_window_info_t->height
CFX_EXPORT void cfx_window_info_set_height(cef_window_info_t *self, int height) {
    self->height = height;
}
CFX_EXPORT void cfx_window_info_get_height(cef_window_info_t *self, int* height) {
    *height = self->height;
}

// cef_window_info_t->parent_window
CFX_EXPORT void cfx_window_info_set_parent_window(cef_window_info_t *self, cef_window_handle_t parent_window) {
    self->parent_window = parent_window;
}
CFX_EXPORT void cfx_window_info_get_parent_window(cef_window_info_t *self, cef_window_handle_t* parent_window) {
    *parent_window = self->parent_window;
}

// cef_window_info_t->menu
CFX_EXPORT void cfx_window_info_set_menu(cef_window_info_t *self, HMENU menu) {
    self->menu = menu;
}
CFX_EXPORT void cfx_window_info_get_menu(cef_window_info_t *self, HMENU* menu) {
    *menu = self->menu;
}

// cef_window_info_t->windowless_rendering_enabled
CFX_EXPORT void cfx_window_info_set_windowless_rendering_enabled(cef_window_info_t *self, int windowless_rendering_enabled) {
    self->windowless_rendering_enabled = windowless_rendering_enabled;
}
CFX_EXPORT void cfx_window_info_get_windowless_rendering_enabled(cef_window_info_t *self, int* windowless_rendering_enabled) {
    *windowless_rendering_enabled = self->windowless_rendering_enabled;
}

// cef_window_info_t->transparent_painting_enabled
CFX_EXPORT void cfx_window_info_set_transparent_painting_enabled(cef_window_info_t *self, int transparent_painting_enabled) {
    self->transparent_painting_enabled = transparent_painting_enabled;
}
CFX_EXPORT void cfx_window_info_get_transparent_painting_enabled(cef_window_info_t *self, int* transparent_painting_enabled) {
    *transparent_painting_enabled = self->transparent_painting_enabled;
}

// cef_window_info_t->window
CFX_EXPORT void cfx_window_info_set_window(cef_window_info_t *self, cef_window_handle_t window) {
    self->window = window;
}
CFX_EXPORT void cfx_window_info_get_window(cef_window_info_t *self, cef_window_handle_t* window) {
    *window = self->window;
}


#ifdef __cplusplus
} // extern "C"
#endif

