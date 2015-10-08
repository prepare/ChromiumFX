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


// cef_screen_info

static cef_screen_info_t* cfx_screen_info_ctor() {
    return (cef_screen_info_t*)calloc(1, sizeof(cef_screen_info_t));
}

static void cfx_screen_info_dtor(cef_screen_info_t* self) {
    free(self);
}

// cef_screen_info_t->device_scale_factor
static void cfx_screen_info_set_device_scale_factor(cef_screen_info_t *self, float device_scale_factor) {
    self->device_scale_factor = device_scale_factor;
}
static void cfx_screen_info_get_device_scale_factor(cef_screen_info_t *self, float* device_scale_factor) {
    *device_scale_factor = self->device_scale_factor;
}

// cef_screen_info_t->depth
static void cfx_screen_info_set_depth(cef_screen_info_t *self, int depth) {
    self->depth = depth;
}
static void cfx_screen_info_get_depth(cef_screen_info_t *self, int* depth) {
    *depth = self->depth;
}

// cef_screen_info_t->depth_per_component
static void cfx_screen_info_set_depth_per_component(cef_screen_info_t *self, int depth_per_component) {
    self->depth_per_component = depth_per_component;
}
static void cfx_screen_info_get_depth_per_component(cef_screen_info_t *self, int* depth_per_component) {
    *depth_per_component = self->depth_per_component;
}

// cef_screen_info_t->is_monochrome
static void cfx_screen_info_set_is_monochrome(cef_screen_info_t *self, int is_monochrome) {
    self->is_monochrome = is_monochrome;
}
static void cfx_screen_info_get_is_monochrome(cef_screen_info_t *self, int* is_monochrome) {
    *is_monochrome = self->is_monochrome;
}

// cef_screen_info_t->rect
static void cfx_screen_info_set_rect(cef_screen_info_t *self, cef_rect_t* rect) {
    self->rect = *(rect);
}
static void cfx_screen_info_get_rect(cef_screen_info_t *self, cef_rect_t** rect) {
    *rect = &(self->rect);
}

// cef_screen_info_t->available_rect
static void cfx_screen_info_set_available_rect(cef_screen_info_t *self, cef_rect_t* available_rect) {
    self->available_rect = *(available_rect);
}
static void cfx_screen_info_get_available_rect(cef_screen_info_t *self, cef_rect_t** available_rect) {
    *available_rect = &(self->available_rect);
}


