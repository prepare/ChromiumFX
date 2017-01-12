// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_box_layout_settings

static cef_box_layout_settings_t* cfx_box_layout_settings_ctor() {
    return (cef_box_layout_settings_t*)calloc(1, sizeof(cef_box_layout_settings_t));
}

static void cfx_box_layout_settings_dtor(cef_box_layout_settings_t* self) {
    free(self);
}

// cef_box_layout_settings_t->horizontal
static void cfx_box_layout_settings_set_horizontal(cef_box_layout_settings_t *self, int horizontal) {
    self->horizontal = horizontal;
}
static void cfx_box_layout_settings_get_horizontal(cef_box_layout_settings_t *self, int* horizontal) {
    *horizontal = self->horizontal;
}

// cef_box_layout_settings_t->inside_border_horizontal_spacing
static void cfx_box_layout_settings_set_inside_border_horizontal_spacing(cef_box_layout_settings_t *self, int inside_border_horizontal_spacing) {
    self->inside_border_horizontal_spacing = inside_border_horizontal_spacing;
}
static void cfx_box_layout_settings_get_inside_border_horizontal_spacing(cef_box_layout_settings_t *self, int* inside_border_horizontal_spacing) {
    *inside_border_horizontal_spacing = self->inside_border_horizontal_spacing;
}

// cef_box_layout_settings_t->inside_border_vertical_spacing
static void cfx_box_layout_settings_set_inside_border_vertical_spacing(cef_box_layout_settings_t *self, int inside_border_vertical_spacing) {
    self->inside_border_vertical_spacing = inside_border_vertical_spacing;
}
static void cfx_box_layout_settings_get_inside_border_vertical_spacing(cef_box_layout_settings_t *self, int* inside_border_vertical_spacing) {
    *inside_border_vertical_spacing = self->inside_border_vertical_spacing;
}

// cef_box_layout_settings_t->inside_border_insets
static void cfx_box_layout_settings_set_inside_border_insets(cef_box_layout_settings_t *self, cef_insets_t* inside_border_insets) {
    self->inside_border_insets = *(inside_border_insets);
}
static void cfx_box_layout_settings_get_inside_border_insets(cef_box_layout_settings_t *self, cef_insets_t** inside_border_insets) {
    *inside_border_insets = &(self->inside_border_insets);
}

// cef_box_layout_settings_t->between_child_spacing
static void cfx_box_layout_settings_set_between_child_spacing(cef_box_layout_settings_t *self, int between_child_spacing) {
    self->between_child_spacing = between_child_spacing;
}
static void cfx_box_layout_settings_get_between_child_spacing(cef_box_layout_settings_t *self, int* between_child_spacing) {
    *between_child_spacing = self->between_child_spacing;
}

// cef_box_layout_settings_t->main_axis_alignment
static void cfx_box_layout_settings_set_main_axis_alignment(cef_box_layout_settings_t *self, cef_main_axis_alignment_t main_axis_alignment) {
    self->main_axis_alignment = main_axis_alignment;
}
static void cfx_box_layout_settings_get_main_axis_alignment(cef_box_layout_settings_t *self, cef_main_axis_alignment_t* main_axis_alignment) {
    *main_axis_alignment = self->main_axis_alignment;
}

// cef_box_layout_settings_t->cross_axis_alignment
static void cfx_box_layout_settings_set_cross_axis_alignment(cef_box_layout_settings_t *self, cef_cross_axis_alignment_t cross_axis_alignment) {
    self->cross_axis_alignment = cross_axis_alignment;
}
static void cfx_box_layout_settings_get_cross_axis_alignment(cef_box_layout_settings_t *self, cef_cross_axis_alignment_t* cross_axis_alignment) {
    *cross_axis_alignment = self->cross_axis_alignment;
}

// cef_box_layout_settings_t->minimum_cross_axis_size
static void cfx_box_layout_settings_set_minimum_cross_axis_size(cef_box_layout_settings_t *self, int minimum_cross_axis_size) {
    self->minimum_cross_axis_size = minimum_cross_axis_size;
}
static void cfx_box_layout_settings_get_minimum_cross_axis_size(cef_box_layout_settings_t *self, int* minimum_cross_axis_size) {
    *minimum_cross_axis_size = self->minimum_cross_axis_size;
}

// cef_box_layout_settings_t->default_flex
static void cfx_box_layout_settings_set_default_flex(cef_box_layout_settings_t *self, int default_flex) {
    self->default_flex = default_flex;
}
static void cfx_box_layout_settings_get_default_flex(cef_box_layout_settings_t *self, int* default_flex) {
    *default_flex = self->default_flex;
}


