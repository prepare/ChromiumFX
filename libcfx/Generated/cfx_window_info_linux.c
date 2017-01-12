// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_window_info_linux

#ifdef CFX_LINUX

static cef_window_info_t* cfx_window_info_linux_ctor() {
    return (cef_window_info_t*)calloc(1, sizeof(cef_window_info_t));
}

static void cfx_window_info_linux_dtor(cef_window_info_t* self) {
    free(self);
}

// cef_window_info_t->x
static void cfx_window_info_linux_set_x(cef_window_info_t *self, unsigned int x) {
    self->x = x;
}
static void cfx_window_info_linux_get_x(cef_window_info_t *self, unsigned int* x) {
    *x = self->x;
}

// cef_window_info_t->y
static void cfx_window_info_linux_set_y(cef_window_info_t *self, unsigned int y) {
    self->y = y;
}
static void cfx_window_info_linux_get_y(cef_window_info_t *self, unsigned int* y) {
    *y = self->y;
}

// cef_window_info_t->width
static void cfx_window_info_linux_set_width(cef_window_info_t *self, unsigned int width) {
    self->width = width;
}
static void cfx_window_info_linux_get_width(cef_window_info_t *self, unsigned int* width) {
    *width = self->width;
}

// cef_window_info_t->height
static void cfx_window_info_linux_set_height(cef_window_info_t *self, unsigned int height) {
    self->height = height;
}
static void cfx_window_info_linux_get_height(cef_window_info_t *self, unsigned int* height) {
    *height = self->height;
}

// cef_window_info_t->parent_window
static void cfx_window_info_linux_set_parent_window(cef_window_info_t *self, cef_window_handle_t parent_window) {
    self->parent_window = parent_window;
}
static void cfx_window_info_linux_get_parent_window(cef_window_info_t *self, cef_window_handle_t* parent_window) {
    *parent_window = self->parent_window;
}

// cef_window_info_t->windowless_rendering_enabled
static void cfx_window_info_linux_set_windowless_rendering_enabled(cef_window_info_t *self, int windowless_rendering_enabled) {
    self->windowless_rendering_enabled = windowless_rendering_enabled;
}
static void cfx_window_info_linux_get_windowless_rendering_enabled(cef_window_info_t *self, int* windowless_rendering_enabled) {
    *windowless_rendering_enabled = self->windowless_rendering_enabled;
}

// cef_window_info_t->transparent_painting_enabled
static void cfx_window_info_linux_set_transparent_painting_enabled(cef_window_info_t *self, int transparent_painting_enabled) {
    self->transparent_painting_enabled = transparent_painting_enabled;
}
static void cfx_window_info_linux_get_transparent_painting_enabled(cef_window_info_t *self, int* transparent_painting_enabled) {
    *transparent_painting_enabled = self->transparent_painting_enabled;
}

// cef_window_info_t->window
static void cfx_window_info_linux_set_window(cef_window_info_t *self, cef_window_handle_t window) {
    self->window = window;
}
static void cfx_window_info_linux_get_window(cef_window_info_t *self, cef_window_handle_t* window) {
    *window = self->window;
}

#else //ifdef CFX_LINUX
#define cfx_window_info_linux_ctor 0
#define cfx_window_info_linux_dtor 0
#define cfx_window_info_linux_set_x 0
#define cfx_window_info_linux_get_x 0
#define cfx_window_info_linux_set_y 0
#define cfx_window_info_linux_get_y 0
#define cfx_window_info_linux_set_width 0
#define cfx_window_info_linux_get_width 0
#define cfx_window_info_linux_set_height 0
#define cfx_window_info_linux_get_height 0
#define cfx_window_info_linux_set_parent_window 0
#define cfx_window_info_linux_get_parent_window 0
#define cfx_window_info_linux_set_windowless_rendering_enabled 0
#define cfx_window_info_linux_get_windowless_rendering_enabled 0
#define cfx_window_info_linux_set_transparent_painting_enabled 0
#define cfx_window_info_linux_get_transparent_painting_enabled 0
#define cfx_window_info_linux_set_window 0
#define cfx_window_info_linux_get_window 0
#endif //ifdef CFX_LINUX


