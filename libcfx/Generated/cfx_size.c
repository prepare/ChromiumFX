// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_size

static cef_size_t* cfx_size_ctor() {
    return (cef_size_t*)calloc(1, sizeof(cef_size_t));
}

static void cfx_size_dtor(cef_size_t* self) {
    free(self);
}

// cef_size_t->width
static void cfx_size_set_width(cef_size_t *self, int width) {
    self->width = width;
}
static void cfx_size_get_width(cef_size_t *self, int* width) {
    *width = self->width;
}

// cef_size_t->height
static void cfx_size_set_height(cef_size_t *self, int height) {
    self->height = height;
}
static void cfx_size_get_height(cef_size_t *self, int* height) {
    *height = self->height;
}


