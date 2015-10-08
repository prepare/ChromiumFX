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


// cef_pdf_print_settings

static cef_pdf_print_settings_t* cfx_pdf_print_settings_ctor() {
    return (cef_pdf_print_settings_t*)calloc(1, sizeof(cef_pdf_print_settings_t));
}

static void cfx_pdf_print_settings_dtor(cef_pdf_print_settings_t* self) {
    if(self->header_footer_title.dtor) self->header_footer_title.dtor(self->header_footer_title.str);
    if(self->header_footer_url.dtor) self->header_footer_url.dtor(self->header_footer_url.str);
    free(self);
}

// cef_pdf_print_settings_t->header_footer_title
static void cfx_pdf_print_settings_set_header_footer_title(cef_pdf_print_settings_t *self, char16 *header_footer_title_str, int header_footer_title_length) {
    cef_string_utf16_set(header_footer_title_str, header_footer_title_length, &(self->header_footer_title), 1);
}
static void cfx_pdf_print_settings_get_header_footer_title(cef_pdf_print_settings_t *self, char16 **header_footer_title_str, int *header_footer_title_length) {
    *header_footer_title_str = self->header_footer_title.str;
    *header_footer_title_length = (int)self->header_footer_title.length;
}

// cef_pdf_print_settings_t->header_footer_url
static void cfx_pdf_print_settings_set_header_footer_url(cef_pdf_print_settings_t *self, char16 *header_footer_url_str, int header_footer_url_length) {
    cef_string_utf16_set(header_footer_url_str, header_footer_url_length, &(self->header_footer_url), 1);
}
static void cfx_pdf_print_settings_get_header_footer_url(cef_pdf_print_settings_t *self, char16 **header_footer_url_str, int *header_footer_url_length) {
    *header_footer_url_str = self->header_footer_url.str;
    *header_footer_url_length = (int)self->header_footer_url.length;
}

// cef_pdf_print_settings_t->page_width
static void cfx_pdf_print_settings_set_page_width(cef_pdf_print_settings_t *self, int page_width) {
    self->page_width = page_width;
}
static void cfx_pdf_print_settings_get_page_width(cef_pdf_print_settings_t *self, int* page_width) {
    *page_width = self->page_width;
}

// cef_pdf_print_settings_t->page_height
static void cfx_pdf_print_settings_set_page_height(cef_pdf_print_settings_t *self, int page_height) {
    self->page_height = page_height;
}
static void cfx_pdf_print_settings_get_page_height(cef_pdf_print_settings_t *self, int* page_height) {
    *page_height = self->page_height;
}

// cef_pdf_print_settings_t->margin_top
static void cfx_pdf_print_settings_set_margin_top(cef_pdf_print_settings_t *self, double margin_top) {
    self->margin_top = margin_top;
}
static void cfx_pdf_print_settings_get_margin_top(cef_pdf_print_settings_t *self, double* margin_top) {
    *margin_top = self->margin_top;
}

// cef_pdf_print_settings_t->margin_right
static void cfx_pdf_print_settings_set_margin_right(cef_pdf_print_settings_t *self, double margin_right) {
    self->margin_right = margin_right;
}
static void cfx_pdf_print_settings_get_margin_right(cef_pdf_print_settings_t *self, double* margin_right) {
    *margin_right = self->margin_right;
}

// cef_pdf_print_settings_t->margin_bottom
static void cfx_pdf_print_settings_set_margin_bottom(cef_pdf_print_settings_t *self, double margin_bottom) {
    self->margin_bottom = margin_bottom;
}
static void cfx_pdf_print_settings_get_margin_bottom(cef_pdf_print_settings_t *self, double* margin_bottom) {
    *margin_bottom = self->margin_bottom;
}

// cef_pdf_print_settings_t->margin_left
static void cfx_pdf_print_settings_set_margin_left(cef_pdf_print_settings_t *self, double margin_left) {
    self->margin_left = margin_left;
}
static void cfx_pdf_print_settings_get_margin_left(cef_pdf_print_settings_t *self, double* margin_left) {
    *margin_left = self->margin_left;
}

// cef_pdf_print_settings_t->margin_type
static void cfx_pdf_print_settings_set_margin_type(cef_pdf_print_settings_t *self, cef_pdf_print_margin_type_t margin_type) {
    self->margin_type = margin_type;
}
static void cfx_pdf_print_settings_get_margin_type(cef_pdf_print_settings_t *self, cef_pdf_print_margin_type_t* margin_type) {
    *margin_type = self->margin_type;
}

// cef_pdf_print_settings_t->header_footer_enabled
static void cfx_pdf_print_settings_set_header_footer_enabled(cef_pdf_print_settings_t *self, int header_footer_enabled) {
    self->header_footer_enabled = header_footer_enabled;
}
static void cfx_pdf_print_settings_get_header_footer_enabled(cef_pdf_print_settings_t *self, int* header_footer_enabled) {
    *header_footer_enabled = self->header_footer_enabled;
}

// cef_pdf_print_settings_t->selection_only
static void cfx_pdf_print_settings_set_selection_only(cef_pdf_print_settings_t *self, int selection_only) {
    self->selection_only = selection_only;
}
static void cfx_pdf_print_settings_get_selection_only(cef_pdf_print_settings_t *self, int* selection_only) {
    *selection_only = self->selection_only;
}

// cef_pdf_print_settings_t->landscape
static void cfx_pdf_print_settings_set_landscape(cef_pdf_print_settings_t *self, int landscape) {
    self->landscape = landscape;
}
static void cfx_pdf_print_settings_get_landscape(cef_pdf_print_settings_t *self, int* landscape) {
    *landscape = self->landscape;
}

// cef_pdf_print_settings_t->backgrounds_enabled
static void cfx_pdf_print_settings_set_backgrounds_enabled(cef_pdf_print_settings_t *self, int backgrounds_enabled) {
    self->backgrounds_enabled = backgrounds_enabled;
}
static void cfx_pdf_print_settings_get_backgrounds_enabled(cef_pdf_print_settings_t *self, int* backgrounds_enabled) {
    *backgrounds_enabled = self->backgrounds_enabled;
}


