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


// cef_insets

static cef_insets_t* cfx_insets_ctor() {
    return (cef_insets_t*)calloc(1, sizeof(cef_insets_t));
}

static void cfx_insets_dtor(cef_insets_t* self) {
    free(self);
}

// cef_insets_t->top
static void cfx_insets_set_top(cef_insets_t *self, int top) {
    self->top = top;
}
static void cfx_insets_get_top(cef_insets_t *self, int* top) {
    *top = self->top;
}

// cef_insets_t->left
static void cfx_insets_set_left(cef_insets_t *self, int left) {
    self->left = left;
}
static void cfx_insets_get_left(cef_insets_t *self, int* left) {
    *left = self->left;
}

// cef_insets_t->bottom
static void cfx_insets_set_bottom(cef_insets_t *self, int bottom) {
    self->bottom = bottom;
}
static void cfx_insets_get_bottom(cef_insets_t *self, int* bottom) {
    *bottom = self->bottom;
}

// cef_insets_t->right
static void cfx_insets_set_right(cef_insets_t *self, int right) {
    self->right = right;
}
static void cfx_insets_get_right(cef_insets_t *self, int* right) {
    *right = self->right;
}


