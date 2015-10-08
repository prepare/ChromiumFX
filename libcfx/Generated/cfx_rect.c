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


// cef_rect

static cef_rect_t* cfx_rect_ctor() {
    return (cef_rect_t*)calloc(1, sizeof(cef_rect_t));
}

static void cfx_rect_dtor(cef_rect_t* self) {
    free(self);
}

// cef_rect_t->x
static void cfx_rect_set_x(cef_rect_t *self, int x) {
    self->x = x;
}
static void cfx_rect_get_x(cef_rect_t *self, int* x) {
    *x = self->x;
}

// cef_rect_t->y
static void cfx_rect_set_y(cef_rect_t *self, int y) {
    self->y = y;
}
static void cfx_rect_get_y(cef_rect_t *self, int* y) {
    *y = self->y;
}

// cef_rect_t->width
static void cfx_rect_set_width(cef_rect_t *self, int width) {
    self->width = width;
}
static void cfx_rect_get_width(cef_rect_t *self, int* width) {
    *width = self->width;
}

// cef_rect_t->height
static void cfx_rect_set_height(cef_rect_t *self, int height) {
    self->height = height;
}
static void cfx_rect_get_height(cef_rect_t *self, int* height) {
    *height = self->height;
}


