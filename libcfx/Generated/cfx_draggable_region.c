// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_draggable_region

static cef_draggable_region_t* cfx_draggable_region_ctor() {
    return (cef_draggable_region_t*)calloc(1, sizeof(cef_draggable_region_t));
}

static void cfx_draggable_region_dtor(cef_draggable_region_t* self) {
    free(self);
}

// cef_draggable_region_t->bounds
static void cfx_draggable_region_set_bounds(cef_draggable_region_t *self, cef_rect_t* bounds) {
    self->bounds = *(bounds);
}
static void cfx_draggable_region_get_bounds(cef_draggable_region_t *self, cef_rect_t** bounds) {
    *bounds = &(self->bounds);
}

// cef_draggable_region_t->draggable
static void cfx_draggable_region_set_draggable(cef_draggable_region_t *self, int draggable) {
    self->draggable = draggable;
}
static void cfx_draggable_region_get_draggable(cef_draggable_region_t *self, int* draggable) {
    *draggable = self->draggable;
}


