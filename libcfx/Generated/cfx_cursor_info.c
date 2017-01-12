// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_cursor_info

static cef_cursor_info_t* cfx_cursor_info_ctor() {
    return (cef_cursor_info_t*)calloc(1, sizeof(cef_cursor_info_t));
}

static void cfx_cursor_info_dtor(cef_cursor_info_t* self) {
    free(self);
}

// cef_cursor_info_t->hotspot
static void cfx_cursor_info_set_hotspot(cef_cursor_info_t *self, cef_point_t* hotspot) {
    self->hotspot = *(hotspot);
}
static void cfx_cursor_info_get_hotspot(cef_cursor_info_t *self, cef_point_t** hotspot) {
    *hotspot = &(self->hotspot);
}

// cef_cursor_info_t->image_scale_factor
static void cfx_cursor_info_set_image_scale_factor(cef_cursor_info_t *self, float image_scale_factor) {
    self->image_scale_factor = image_scale_factor;
}
static void cfx_cursor_info_get_image_scale_factor(cef_cursor_info_t *self, float* image_scale_factor) {
    *image_scale_factor = self->image_scale_factor;
}

// cef_cursor_info_t->buffer
static void cfx_cursor_info_set_buffer(cef_cursor_info_t *self, void* buffer) {
    self->buffer = buffer;
}
static void cfx_cursor_info_get_buffer(cef_cursor_info_t *self, void** buffer) {
    *buffer = self->buffer;
}

// cef_cursor_info_t->size
static void cfx_cursor_info_set_size(cef_cursor_info_t *self, cef_size_t* size) {
    self->size = *(size);
}
static void cfx_cursor_info_get_size(cef_cursor_info_t *self, cef_size_t** size) {
    *size = &(self->size);
}


