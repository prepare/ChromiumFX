// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_range

static cef_range_t* cfx_range_ctor() {
    return (cef_range_t*)calloc(1, sizeof(cef_range_t));
}

static void cfx_range_dtor(cef_range_t* self) {
    free(self);
}

// cef_range_t->from
static void cfx_range_set_from(cef_range_t *self, int from) {
    self->from = from;
}
static void cfx_range_get_from(cef_range_t *self, int* from) {
    *from = self->from;
}

// cef_range_t->to
static void cfx_range_set_to(cef_range_t *self, int to) {
    self->to = to;
}
static void cfx_range_get_to(cef_range_t *self, int* to) {
    *to = self->to;
}


