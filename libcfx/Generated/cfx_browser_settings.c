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


// cef_browser_settings

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_browser_settings_t* cfx_browser_settings_ctor() {
    cef_browser_settings_t* ptr = (cef_browser_settings_t*)calloc(1, sizeof(cef_browser_settings_t));
    if(!ptr) return 0;
    ptr->size = sizeof(cef_browser_settings_t);
    return ptr;
}

CFX_EXPORT void cfx_browser_settings_dtor(cef_browser_settings_t* ptr) {
    if(ptr->standard_font_family.dtor) ptr->standard_font_family.dtor(ptr->standard_font_family.str);
    if(ptr->fixed_font_family.dtor) ptr->fixed_font_family.dtor(ptr->fixed_font_family.str);
    if(ptr->serif_font_family.dtor) ptr->serif_font_family.dtor(ptr->serif_font_family.str);
    if(ptr->sans_serif_font_family.dtor) ptr->sans_serif_font_family.dtor(ptr->sans_serif_font_family.str);
    if(ptr->cursive_font_family.dtor) ptr->cursive_font_family.dtor(ptr->cursive_font_family.str);
    if(ptr->fantasy_font_family.dtor) ptr->fantasy_font_family.dtor(ptr->fantasy_font_family.str);
    if(ptr->default_encoding.dtor) ptr->default_encoding.dtor(ptr->default_encoding.str);
    free(ptr);
}

CFX_EXPORT void cfx_browser_settings_copy_to_native(cef_browser_settings_t* self, int windowless_frame_rate, char16 *standard_font_family_str, int standard_font_family_length, char16 *fixed_font_family_str, int fixed_font_family_length, char16 *serif_font_family_str, int serif_font_family_length, char16 *sans_serif_font_family_str, int sans_serif_font_family_length, char16 *cursive_font_family_str, int cursive_font_family_length, char16 *fantasy_font_family_str, int fantasy_font_family_length, int default_font_size, int default_fixed_font_size, int minimum_font_size, int minimum_logical_font_size, char16 *default_encoding_str, int default_encoding_length, cef_state_t remote_fonts, cef_state_t javascript, cef_state_t javascript_open_windows, cef_state_t javascript_close_windows, cef_state_t javascript_access_clipboard, cef_state_t javascript_dom_paste, cef_state_t caret_browsing, cef_state_t java, cef_state_t plugins, cef_state_t universal_access_from_file_urls, cef_state_t file_access_from_file_urls, cef_state_t web_security, cef_state_t image_loading, cef_state_t image_shrink_standalone_to_fit, cef_state_t text_area_resize, cef_state_t tab_to_links, cef_state_t local_storage, cef_state_t databases, cef_state_t application_cache, cef_state_t webgl, uint32 background_color) {
    self->windowless_frame_rate = windowless_frame_rate;
    cef_string_utf16_set(standard_font_family_str, standard_font_family_length, &(self->standard_font_family), 1);
    cef_string_utf16_set(fixed_font_family_str, fixed_font_family_length, &(self->fixed_font_family), 1);
    cef_string_utf16_set(serif_font_family_str, serif_font_family_length, &(self->serif_font_family), 1);
    cef_string_utf16_set(sans_serif_font_family_str, sans_serif_font_family_length, &(self->sans_serif_font_family), 1);
    cef_string_utf16_set(cursive_font_family_str, cursive_font_family_length, &(self->cursive_font_family), 1);
    cef_string_utf16_set(fantasy_font_family_str, fantasy_font_family_length, &(self->fantasy_font_family), 1);
    self->default_font_size = default_font_size;
    self->default_fixed_font_size = default_fixed_font_size;
    self->minimum_font_size = minimum_font_size;
    self->minimum_logical_font_size = minimum_logical_font_size;
    cef_string_utf16_set(default_encoding_str, default_encoding_length, &(self->default_encoding), 1);
    self->remote_fonts = remote_fonts;
    self->javascript = javascript;
    self->javascript_open_windows = javascript_open_windows;
    self->javascript_close_windows = javascript_close_windows;
    self->javascript_access_clipboard = javascript_access_clipboard;
    self->javascript_dom_paste = javascript_dom_paste;
    self->caret_browsing = caret_browsing;
    self->java = java;
    self->plugins = plugins;
    self->universal_access_from_file_urls = universal_access_from_file_urls;
    self->file_access_from_file_urls = file_access_from_file_urls;
    self->web_security = web_security;
    self->image_loading = image_loading;
    self->image_shrink_standalone_to_fit = image_shrink_standalone_to_fit;
    self->text_area_resize = text_area_resize;
    self->tab_to_links = tab_to_links;
    self->local_storage = local_storage;
    self->databases = databases;
    self->application_cache = application_cache;
    self->webgl = webgl;
    self->background_color = background_color;
}

CFX_EXPORT void cfx_browser_settings_copy_to_managed(cef_browser_settings_t* self, int* windowless_frame_rate, char16 **standard_font_family_str, int *standard_font_family_length, char16 **fixed_font_family_str, int *fixed_font_family_length, char16 **serif_font_family_str, int *serif_font_family_length, char16 **sans_serif_font_family_str, int *sans_serif_font_family_length, char16 **cursive_font_family_str, int *cursive_font_family_length, char16 **fantasy_font_family_str, int *fantasy_font_family_length, int* default_font_size, int* default_fixed_font_size, int* minimum_font_size, int* minimum_logical_font_size, char16 **default_encoding_str, int *default_encoding_length, cef_state_t* remote_fonts, cef_state_t* javascript, cef_state_t* javascript_open_windows, cef_state_t* javascript_close_windows, cef_state_t* javascript_access_clipboard, cef_state_t* javascript_dom_paste, cef_state_t* caret_browsing, cef_state_t* java, cef_state_t* plugins, cef_state_t* universal_access_from_file_urls, cef_state_t* file_access_from_file_urls, cef_state_t* web_security, cef_state_t* image_loading, cef_state_t* image_shrink_standalone_to_fit, cef_state_t* text_area_resize, cef_state_t* tab_to_links, cef_state_t* local_storage, cef_state_t* databases, cef_state_t* application_cache, cef_state_t* webgl, uint32* background_color) {
    *windowless_frame_rate = self->windowless_frame_rate;
    *standard_font_family_str = self->standard_font_family.str;
    *standard_font_family_length = self->standard_font_family.length;
    *fixed_font_family_str = self->fixed_font_family.str;
    *fixed_font_family_length = self->fixed_font_family.length;
    *serif_font_family_str = self->serif_font_family.str;
    *serif_font_family_length = self->serif_font_family.length;
    *sans_serif_font_family_str = self->sans_serif_font_family.str;
    *sans_serif_font_family_length = self->sans_serif_font_family.length;
    *cursive_font_family_str = self->cursive_font_family.str;
    *cursive_font_family_length = self->cursive_font_family.length;
    *fantasy_font_family_str = self->fantasy_font_family.str;
    *fantasy_font_family_length = self->fantasy_font_family.length;
    *default_font_size = self->default_font_size;
    *default_fixed_font_size = self->default_fixed_font_size;
    *minimum_font_size = self->minimum_font_size;
    *minimum_logical_font_size = self->minimum_logical_font_size;
    *default_encoding_str = self->default_encoding.str;
    *default_encoding_length = self->default_encoding.length;
    *remote_fonts = self->remote_fonts;
    *javascript = self->javascript;
    *javascript_open_windows = self->javascript_open_windows;
    *javascript_close_windows = self->javascript_close_windows;
    *javascript_access_clipboard = self->javascript_access_clipboard;
    *javascript_dom_paste = self->javascript_dom_paste;
    *caret_browsing = self->caret_browsing;
    *java = self->java;
    *plugins = self->plugins;
    *universal_access_from_file_urls = self->universal_access_from_file_urls;
    *file_access_from_file_urls = self->file_access_from_file_urls;
    *web_security = self->web_security;
    *image_loading = self->image_loading;
    *image_shrink_standalone_to_fit = self->image_shrink_standalone_to_fit;
    *text_area_resize = self->text_area_resize;
    *tab_to_links = self->tab_to_links;
    *local_storage = self->local_storage;
    *databases = self->databases;
    *application_cache = self->application_cache;
    *webgl = self->webgl;
    *background_color = self->background_color;
}

#ifdef __cplusplus
} // extern "C"
#endif

