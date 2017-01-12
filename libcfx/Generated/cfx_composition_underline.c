// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


