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


// cef_image

// CEF_EXPORT cef_image_t* cef_image_create();
static cef_image_t* cfx_image_create() {
    return cef_image_create();
}
// is_empty
static int cfx_image_is_empty(cef_image_t* self) {
    return self->is_empty(self);
}

// is_same
static int cfx_image_is_same(cef_image_t* self, cef_image_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// add_bitmap
static int cfx_image_add_bitmap(cef_image_t* self, float scale_factor, int pixel_width, int pixel_height, cef_color_type_t color_type, cef_alpha_type_t alpha_type, const void* pixel_data, size_t pixel_data_size) {
    return self->add_bitmap(self, scale_factor, pixel_width, pixel_height, color_type, alpha_type, pixel_data, pixel_data_size);
}

// add_png
static int cfx_image_add_png(cef_image_t* self, float scale_factor, const void* png_data, size_t png_data_size) {
    return self->add_png(self, scale_factor, png_data, png_data_size);
}

// add_jpeg
static int cfx_image_add_jpeg(cef_image_t* self, float scale_factor, const void* jpeg_data, size_t jpeg_data_size) {
    return self->add_jpeg(self, scale_factor, jpeg_data, jpeg_data_size);
}

// get_width
static size_t cfx_image_get_width(cef_image_t* self) {
    return self->get_width(self);
}

// get_height
static size_t cfx_image_get_height(cef_image_t* self) {
    return self->get_height(self);
}

// has_representation
static int cfx_image_has_representation(cef_image_t* self, float scale_factor) {
    return self->has_representation(self, scale_factor);
}

// remove_representation
static int cfx_image_remove_representation(cef_image_t* self, float scale_factor) {
    return self->remove_representation(self, scale_factor);
}

// get_representation_info
static int cfx_image_get_representation_info(cef_image_t* self, float scale_factor, float* actual_scale_factor, int* pixel_width, int* pixel_height) {
    return self->get_representation_info(self, scale_factor, actual_scale_factor, pixel_width, pixel_height);
}

// get_as_bitmap
static cef_binary_value_t* cfx_image_get_as_bitmap(cef_image_t* self, float scale_factor, cef_color_type_t color_type, cef_alpha_type_t alpha_type, int* pixel_width, int* pixel_height) {
    return self->get_as_bitmap(self, scale_factor, color_type, alpha_type, pixel_width, pixel_height);
}

// get_as_png
static cef_binary_value_t* cfx_image_get_as_png(cef_image_t* self, float scale_factor, int with_transparency, int* pixel_width, int* pixel_height) {
    return self->get_as_png(self, scale_factor, with_transparency, pixel_width, pixel_height);
}

// get_as_jpeg
static cef_binary_value_t* cfx_image_get_as_jpeg(cef_image_t* self, float scale_factor, int quality, int* pixel_width, int* pixel_height) {
    return self->get_as_jpeg(self, scale_factor, quality, pixel_width, pixel_height);
}


