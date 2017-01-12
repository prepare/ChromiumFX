// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_mouse_event

static cef_mouse_event_t* cfx_mouse_event_ctor() {
    return (cef_mouse_event_t*)calloc(1, sizeof(cef_mouse_event_t));
}

static void cfx_mouse_event_dtor(cef_mouse_event_t* self) {
    free(self);
}

// cef_mouse_event_t->x
static void cfx_mouse_event_set_x(cef_mouse_event_t *self, int x) {
    self->x = x;
}
static void cfx_mouse_event_get_x(cef_mouse_event_t *self, int* x) {
    *x = self->x;
}

// cef_mouse_event_t->y
static void cfx_mouse_event_set_y(cef_mouse_event_t *self, int y) {
    self->y = y;
}
static void cfx_mouse_event_get_y(cef_mouse_event_t *self, int* y) {
    *y = self->y;
}

// cef_mouse_event_t->modifiers
static void cfx_mouse_event_set_modifiers(cef_mouse_event_t *self, uint32 modifiers) {
    self->modifiers = modifiers;
}
static void cfx_mouse_event_get_modifiers(cef_mouse_event_t *self, uint32* modifiers) {
    *modifiers = self->modifiers;
}


