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


// cef_render_handler

typedef struct _cfx_render_handler_t {
    cef_render_handler_t cef_render_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *get_root_screen_rect)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect);
    void (CEF_CALLBACK *get_view_rect)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect);
    void (CEF_CALLBACK *get_screen_point)(gc_handle_t self, int* __retval, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY);
    void (CEF_CALLBACK *get_screen_info)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_screen_info_t* screen_info);
    void (CEF_CALLBACK *on_popup_show)(gc_handle_t self, cef_browser_t* browser, int show);
    void (CEF_CALLBACK *on_popup_size)(gc_handle_t self, cef_browser_t* browser, const cef_rect_t* rect);
    void (CEF_CALLBACK *on_paint)(gc_handle_t self, cef_browser_t* browser, cef_paint_element_type_t type, size_t dirtyRectsCount, cef_rect_t const* dirtyRects, int dirtyRects_structsize, const void* buffer, int width, int height);
    void (CEF_CALLBACK *on_cursor_change)(gc_handle_t self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info);
    void (CEF_CALLBACK *start_dragging)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y);
    void (CEF_CALLBACK *update_drag_cursor)(gc_handle_t self, cef_browser_t* browser, cef_drag_operations_mask_t operation);
    void (CEF_CALLBACK *on_scroll_offset_changed)(gc_handle_t self, cef_browser_t* browser, double x, double y);
} cfx_render_handler_t;

void CEF_CALLBACK _cfx_render_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_render_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_render_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_render_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_render_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_render_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_render_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_render_handler_t* cfx_render_handler_ctor(gc_handle_t gc_handle) {
    cfx_render_handler_t* ptr = (cfx_render_handler_t*)calloc(1, sizeof(cfx_render_handler_t));
    if(!ptr) return 0;
    ptr->cef_render_handler.base.size = sizeof(cef_render_handler_t);
    ptr->cef_render_handler.base.add_ref = _cfx_render_handler_add_ref;
    ptr->cef_render_handler.base.release = _cfx_render_handler_release;
    ptr->cef_render_handler.base.has_one_ref = _cfx_render_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_render_handler_get_gc_handle(cfx_render_handler_t* self) {
    return self->gc_handle;
}

// get_root_screen_rect

int CEF_CALLBACK cfx_render_handler_get_root_screen_rect(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect) {
    int __retval;
    ((cfx_render_handler_t*)self)->get_root_screen_rect(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, rect);
    return __retval;
}

// get_view_rect

int CEF_CALLBACK cfx_render_handler_get_view_rect(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect) {
    int __retval;
    ((cfx_render_handler_t*)self)->get_view_rect(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, rect);
    return __retval;
}

// get_screen_point

int CEF_CALLBACK cfx_render_handler_get_screen_point(cef_render_handler_t* self, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY) {
    int __retval;
    ((cfx_render_handler_t*)self)->get_screen_point(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, viewX, viewY, screenX, screenY);
    return __retval;
}

// get_screen_info

int CEF_CALLBACK cfx_render_handler_get_screen_info(cef_render_handler_t* self, cef_browser_t* browser, cef_screen_info_t* screen_info) {
    int __retval;
    ((cfx_render_handler_t*)self)->get_screen_info(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, screen_info);
    return __retval;
}

// on_popup_show

void CEF_CALLBACK cfx_render_handler_on_popup_show(cef_render_handler_t* self, cef_browser_t* browser, int show) {
    ((cfx_render_handler_t*)self)->on_popup_show(((cfx_render_handler_t*)self)->gc_handle, browser, show);
}

// on_popup_size

void CEF_CALLBACK cfx_render_handler_on_popup_size(cef_render_handler_t* self, cef_browser_t* browser, const cef_rect_t* rect) {
    ((cfx_render_handler_t*)self)->on_popup_size(((cfx_render_handler_t*)self)->gc_handle, browser, rect);
}

// on_paint

void CEF_CALLBACK cfx_render_handler_on_paint(cef_render_handler_t* self, cef_browser_t* browser, cef_paint_element_type_t type, size_t dirtyRectsCount, cef_rect_t const* dirtyRects, const void* buffer, int width, int height) {
    ((cfx_render_handler_t*)self)->on_paint(((cfx_render_handler_t*)self)->gc_handle, browser, type, dirtyRectsCount, dirtyRects, (int)sizeof(cef_rect_t), buffer, width, height);
}

// on_cursor_change

void CEF_CALLBACK cfx_render_handler_on_cursor_change(cef_render_handler_t* self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info) {
    ((cfx_render_handler_t*)self)->on_cursor_change(((cfx_render_handler_t*)self)->gc_handle, browser, cursor, type, custom_cursor_info);
}

// start_dragging

int CEF_CALLBACK cfx_render_handler_start_dragging(cef_render_handler_t* self, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y) {
    int __retval;
    ((cfx_render_handler_t*)self)->start_dragging(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, drag_data, allowed_ops, x, y);
    return __retval;
}

// update_drag_cursor

void CEF_CALLBACK cfx_render_handler_update_drag_cursor(cef_render_handler_t* self, cef_browser_t* browser, cef_drag_operations_mask_t operation) {
    ((cfx_render_handler_t*)self)->update_drag_cursor(((cfx_render_handler_t*)self)->gc_handle, browser, operation);
}

// on_scroll_offset_changed

void CEF_CALLBACK cfx_render_handler_on_scroll_offset_changed(cef_render_handler_t* self, cef_browser_t* browser, double x, double y) {
    ((cfx_render_handler_t*)self)->on_scroll_offset_changed(((cfx_render_handler_t*)self)->gc_handle, browser, x, y);
}

static void cfx_render_handler_set_callback(cef_render_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_render_handler_t*)self)->get_root_screen_rect = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect))callback;
        self->get_root_screen_rect = callback ? cfx_render_handler_get_root_screen_rect : 0;
        break;
    case 1:
        ((cfx_render_handler_t*)self)->get_view_rect = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect))callback;
        self->get_view_rect = callback ? cfx_render_handler_get_view_rect : 0;
        break;
    case 2:
        ((cfx_render_handler_t*)self)->get_screen_point = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY))callback;
        self->get_screen_point = callback ? cfx_render_handler_get_screen_point : 0;
        break;
    case 3:
        ((cfx_render_handler_t*)self)->get_screen_info = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_screen_info_t* screen_info))callback;
        self->get_screen_info = callback ? cfx_render_handler_get_screen_info : 0;
        break;
    case 4:
        ((cfx_render_handler_t*)self)->on_popup_show = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int show))callback;
        self->on_popup_show = callback ? cfx_render_handler_on_popup_show : 0;
        break;
    case 5:
        ((cfx_render_handler_t*)self)->on_popup_size = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, const cef_rect_t* rect))callback;
        self->on_popup_size = callback ? cfx_render_handler_on_popup_size : 0;
        break;
    case 6:
        ((cfx_render_handler_t*)self)->on_paint = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_paint_element_type_t type, size_t dirtyRectsCount, cef_rect_t const* dirtyRects, int dirtyRects_structsize, const void* buffer, int width, int height))callback;
        self->on_paint = callback ? cfx_render_handler_on_paint : 0;
        break;
    case 7:
        ((cfx_render_handler_t*)self)->on_cursor_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info))callback;
        self->on_cursor_change = callback ? cfx_render_handler_on_cursor_change : 0;
        break;
    case 8:
        ((cfx_render_handler_t*)self)->start_dragging = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y))callback;
        self->start_dragging = callback ? cfx_render_handler_start_dragging : 0;
        break;
    case 9:
        ((cfx_render_handler_t*)self)->update_drag_cursor = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_drag_operations_mask_t operation))callback;
        self->update_drag_cursor = callback ? cfx_render_handler_update_drag_cursor : 0;
        break;
    case 10:
        ((cfx_render_handler_t*)self)->on_scroll_offset_changed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, double x, double y))callback;
        self->on_scroll_offset_changed = callback ? cfx_render_handler_on_scroll_offset_changed : 0;
        break;
    }
}

