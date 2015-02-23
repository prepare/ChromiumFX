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

CFX_EXPORT void cfx_window_info_dtor(cef_window_info_t* ptr) {
    if(ptr->window_name.dtor) ptr->window_name.dtor(ptr->window_name.str);
    free(ptr);
}

CFX_EXPORT void cfx_window_info_copy_to_native(cef_window_info_t* self, DWORD ex_style, char16 *window_name_str, int window_name_length, DWORD style, int x, int y, int width, int height, cef_window_handle_t parent_window, HMENU menu, int windowless_rendering_enabled, int transparent_painting_enabled, cef_window_handle_t window) {
    self->ex_style = ex_style;
    cef_string_utf16_set(window_name_str, window_name_length, &(self->window_name), 1);
    self->style = style;
    self->x = x;
    self->y = y;
    self->width = width;
    self->height = height;
    self->parent_window = parent_window;
    self->menu = menu;
    self->windowless_rendering_enabled = windowless_rendering_enabled;
    self->transparent_painting_enabled = transparent_painting_enabled;
    self->window = window;
}

CFX_EXPORT void cfx_window_info_copy_to_managed(cef_window_info_t* self, DWORD* ex_style, char16 **window_name_str, int *window_name_length, DWORD* style, int* x, int* y, int* width, int* height, cef_window_handle_t* parent_window, HMENU* menu, int* windowless_rendering_enabled, int* transparent_painting_enabled, cef_window_handle_t* window) {
    *ex_style = self->ex_style;
    *window_name_str = self->window_name.str;
    *window_name_length = self->window_name.length;
    *style = self->style;
    *x = self->x;
    *y = self->y;
    *width = self->width;
    *height = self->height;
    *parent_window = self->parent_window;
    *menu = self->menu;
    *windowless_rendering_enabled = self->windowless_rendering_enabled;
    *transparent_painting_enabled = self->transparent_painting_enabled;
    *window = self->window;
}

#ifdef __cplusplus
} // extern "C"
#endif

