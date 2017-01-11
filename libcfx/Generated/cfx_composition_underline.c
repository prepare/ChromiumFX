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


// cef_composition_underline

static cef_composition_underline_t* cfx_composition_underline_ctor() {
    return (cef_composition_underline_t*)calloc(1, sizeof(cef_composition_underline_t));
}

static void cfx_composition_underline_dtor(cef_composition_underline_t* self) {
    free(self);
}

// cef_composition_underline_t->range
static void cfx_composition_underline_set_range(cef_composition_underline_t *self, cef_range_t* range) {
    self->range = *(range);
}
static void cfx_composition_underline_get_range(cef_composition_underline_t *self, cef_range_t** range) {
    *range = &(self->range);
}

// cef_composition_underline_t->color
static void cfx_composition_underline_set_color(cef_composition_underline_t *self, uint32 color) {
    self->color = color;
}
static void cfx_composition_underline_get_color(cef_composition_underline_t *self, uint32* color) {
    *color = self->color;
}

// cef_composition_underline_t->background_color
static void cfx_composition_underline_set_background_color(cef_composition_underline_t *self, uint32 background_color) {
    self->background_color = background_color;
}
static void cfx_composition_underline_get_background_color(cef_composition_underline_t *self, uint32* background_color) {
    *background_color = self->background_color;
}

// cef_composition_underline_t->thick
static void cfx_composition_underline_set_thick(cef_composition_underline_t *self, int thick) {
    self->thick = thick;
}
static void cfx_composition_underline_get_thick(cef_composition_underline_t *self, int* thick) {
    *thick = self->thick;
}


