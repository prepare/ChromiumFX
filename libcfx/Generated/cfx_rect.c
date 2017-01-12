// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


