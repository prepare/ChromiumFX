// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


