// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


