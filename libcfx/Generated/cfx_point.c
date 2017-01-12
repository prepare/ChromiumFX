// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_point

static cef_point_t* cfx_point_ctor() {
    return (cef_point_t*)calloc(1, sizeof(cef_point_t));
}

static void cfx_point_dtor(cef_point_t* self) {
    free(self);
}

// cef_point_t->x
static void cfx_point_set_x(cef_point_t *self, int x) {
    self->x = x;
}
static void cfx_point_get_x(cef_point_t *self, int* x) {
    *x = self->x;
}

// cef_point_t->y
static void cfx_point_set_y(cef_point_t *self, int y) {
    self->y = y;
}
static void cfx_point_get_y(cef_point_t *self, int* y) {
    *y = self->y;
}


