// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_print_settings

// CEF_EXPORT cef_print_settings_t* cef_print_settings_create();
static cef_print_settings_t* cfx_print_settings_create() {
    return cef_print_settings_create();
}
// is_valid
static int cfx_print_settings_is_valid(cef_print_settings_t* self) {
    return self->is_valid(self);
}

// is_read_only
static int cfx_print_settings_is_read_only(cef_print_settings_t* self) {
    return self->is_read_only(self);
}

// copy
static cef_print_settings_t* cfx_print_settings_copy(cef_print_settings_t* self) {
    return self->copy(self);
}

// set_orientation
static void cfx_print_settings_set_orientation(cef_print_settings_t* self, int landscape) {
    self->set_orientation(self, landscape);
}

// is_landscape
static int cfx_print_settings_is_landscape(cef_print_settings_t* self) {
    return self->is_landscape(self);
}

// set_printer_printable_area
static void cfx_print_settings_set_printer_printable_area(cef_print_settings_t* self, const cef_size_t* physical_size_device_units, const cef_rect_t* printable_area_device_units, int landscape_needs_flip) {
    self->set_printer_printable_area(self, physical_size_device_units, printable_area_device_units, landscape_needs_flip);
}

// set_device_name
static void cfx_print_settings_set_device_name(cef_print_settings_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    self->set_device_name(self, &name);
}

// get_device_name
static cef_string_userfree_t cfx_print_settings_get_device_name(cef_print_settings_t* self) {
    return self->get_device_name(self);
}

// set_dpi
static void cfx_print_settings_set_dpi(cef_print_settings_t* self, int dpi) {
    self->set_dpi(self, dpi);
}

// get_dpi
static int cfx_print_settings_get_dpi(cef_print_settings_t* self) {
    return self->get_dpi(self);
}

// set_page_ranges
static void cfx_print_settings_set_page_ranges(cef_print_settings_t* self, size_t rangesCount, cef_range_t const** ranges, int* ranges_nomem) {
    cef_range_t *ranges_tmp = (cef_range_t*)malloc(rangesCount * sizeof(cef_range_t));
    if(ranges_tmp) {
        for(int i = 0; i < rangesCount; ++i) {
            ranges_tmp[i] = *ranges[i];
        }
        *ranges_nomem = 0;
    } else {
        rangesCount = 0;
        *ranges_nomem = 1;
    }
    self->set_page_ranges(self, rangesCount, ranges_tmp);
    if(ranges_tmp) free(ranges_tmp);
}

// get_page_ranges_count
static size_t cfx_print_settings_get_page_ranges_count(cef_print_settings_t* self) {
    return self->get_page_ranges_count(self);
}

// get_page_ranges
static void cfx_print_settings_get_page_ranges(cef_print_settings_t* self, size_t* rangesCount, cef_range_t** ranges, int* ranges_nomem) {
    cef_range_t *ranges_tmp = (cef_range_t*)malloc(*rangesCount * sizeof(cef_range_t));
    if(ranges_tmp) {
        *ranges_nomem = 0;
        self->get_page_ranges(self, rangesCount, ranges_tmp);
        for(size_t i = 0; i < *rangesCount; ++i) {
            ranges[i] = (cef_range_t*)malloc(sizeof(cef_range_t));
            *ranges[i] = ranges_tmp[i];
        }
        free(ranges_tmp);
    } else {
        *ranges_nomem = 1;
    }
}

// set_selection_only
static void cfx_print_settings_set_selection_only(cef_print_settings_t* self, int selection_only) {
    self->set_selection_only(self, selection_only);
}

// is_selection_only
static int cfx_print_settings_is_selection_only(cef_print_settings_t* self) {
    return self->is_selection_only(self);
}

// set_collate
static void cfx_print_settings_set_collate(cef_print_settings_t* self, int collate) {
    self->set_collate(self, collate);
}

// will_collate
static int cfx_print_settings_will_collate(cef_print_settings_t* self) {
    return self->will_collate(self);
}

// set_color_model
static void cfx_print_settings_set_color_model(cef_print_settings_t* self, cef_color_model_t model) {
    self->set_color_model(self, model);
}

// get_color_model
static cef_color_model_t cfx_print_settings_get_color_model(cef_print_settings_t* self) {
    return self->get_color_model(self);
}

// set_copies
static void cfx_print_settings_set_copies(cef_print_settings_t* self, int copies) {
    self->set_copies(self, copies);
}

// get_copies
static int cfx_print_settings_get_copies(cef_print_settings_t* self) {
    return self->get_copies(self);
}

// set_duplex_mode
static void cfx_print_settings_set_duplex_mode(cef_print_settings_t* self, cef_duplex_mode_t mode) {
    self->set_duplex_mode(self, mode);
}

// get_duplex_mode
static cef_duplex_mode_t cfx_print_settings_get_duplex_mode(cef_print_settings_t* self) {
    return self->get_duplex_mode(self);
}


