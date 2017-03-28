// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_drag_handler

typedef struct _cfx_drag_handler_t {
    cef_drag_handler_t cef_drag_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_drag_enter)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_drag_data_t* dragData, int *dragData_release, cef_drag_operations_mask_t mask);
    void (CEF_CALLBACK *on_draggable_regions_changed)(gc_handle_t self, cef_browser_t* browser, int *browser_release, size_t regionsCount, cef_draggable_region_t const* regions, int regions_structsize);
} cfx_drag_handler_t;

void CEF_CALLBACK _cfx_drag_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_drag_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_drag_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_drag_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_drag_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_drag_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_drag_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_drag_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_drag_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_drag_handler_t* cfx_drag_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_drag_handler_t* ptr = (cfx_drag_handler_t*)calloc(1, sizeof(cfx_drag_handler_t));
    if(!ptr) return 0;
    ptr->cef_drag_handler.base.size = sizeof(cef_drag_handler_t);
    ptr->cef_drag_handler.base.add_ref = _cfx_drag_handler_add_ref;
    ptr->cef_drag_handler.base.release = _cfx_drag_handler_release;
    ptr->cef_drag_handler.base.has_one_ref = _cfx_drag_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_drag_enter

int CEF_CALLBACK cfx_drag_handler_on_drag_enter(cef_drag_handler_t* self, cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask) {
    int __retval;
    int browser_release;
    int dragData_release;
    ((cfx_drag_handler_t*)self)->on_drag_enter(((cfx_drag_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, dragData, &dragData_release, mask);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(dragData_release) dragData->base.release((cef_base_ref_counted_t*)dragData);
    return __retval;
}

// on_draggable_regions_changed

void CEF_CALLBACK cfx_drag_handler_on_draggable_regions_changed(cef_drag_handler_t* self, cef_browser_t* browser, size_t regionsCount, cef_draggable_region_t const* regions) {
    int browser_release;
    ((cfx_drag_handler_t*)self)->on_draggable_regions_changed(((cfx_drag_handler_t*)self)->gc_handle, browser, &browser_release, regionsCount, regions, (int)sizeof(cef_draggable_region_t));
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
}

static void cfx_drag_handler_set_callback(cef_drag_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_drag_handler_t*)self)->on_drag_enter = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_drag_data_t* dragData, int *dragData_release, cef_drag_operations_mask_t mask))callback;
        self->on_drag_enter = callback ? cfx_drag_handler_on_drag_enter : 0;
        break;
    case 1:
        ((cfx_drag_handler_t*)self)->on_draggable_regions_changed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, size_t regionsCount, cef_draggable_region_t const* regions, int regions_structsize))callback;
        self->on_draggable_regions_changed = callback ? cfx_drag_handler_on_draggable_regions_changed : 0;
        break;
    }
}

