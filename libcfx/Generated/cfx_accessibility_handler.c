// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_accessibility_handler

typedef struct _cfx_accessibility_handler_t {
    cef_accessibility_handler_t cef_accessibility_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_accessibility_tree_change)(gc_handle_t self, cef_value_t* value, int *value_release);
    void (CEF_CALLBACK *on_accessibility_location_change)(gc_handle_t self, cef_value_t* value, int *value_release);
} cfx_accessibility_handler_t;

void CEF_CALLBACK _cfx_accessibility_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_accessibility_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_accessibility_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_accessibility_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_accessibility_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_accessibility_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_accessibility_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_accessibility_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_accessibility_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_accessibility_handler_t* cfx_accessibility_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_accessibility_handler_t* ptr = (cfx_accessibility_handler_t*)calloc(1, sizeof(cfx_accessibility_handler_t));
    if(!ptr) return 0;
    ptr->cef_accessibility_handler.base.size = sizeof(cef_accessibility_handler_t);
    ptr->cef_accessibility_handler.base.add_ref = _cfx_accessibility_handler_add_ref;
    ptr->cef_accessibility_handler.base.release = _cfx_accessibility_handler_release;
    ptr->cef_accessibility_handler.base.has_one_ref = _cfx_accessibility_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_accessibility_tree_change

void CEF_CALLBACK cfx_accessibility_handler_on_accessibility_tree_change(cef_accessibility_handler_t* self, cef_value_t* value) {
    int value_release;
    ((cfx_accessibility_handler_t*)self)->on_accessibility_tree_change(((cfx_accessibility_handler_t*)self)->gc_handle, value, &value_release);
    if(value_release && value) value->base.release((cef_base_ref_counted_t*)value);
}

// on_accessibility_location_change

void CEF_CALLBACK cfx_accessibility_handler_on_accessibility_location_change(cef_accessibility_handler_t* self, cef_value_t* value) {
    int value_release;
    ((cfx_accessibility_handler_t*)self)->on_accessibility_location_change(((cfx_accessibility_handler_t*)self)->gc_handle, value, &value_release);
    if(value_release && value) value->base.release((cef_base_ref_counted_t*)value);
}

static void cfx_accessibility_handler_set_callback(cef_accessibility_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_accessibility_handler_t*)self)->on_accessibility_tree_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_value_t* value, int *value_release))callback;
        self->on_accessibility_tree_change = callback ? cfx_accessibility_handler_on_accessibility_tree_change : 0;
        break;
    case 1:
        ((cfx_accessibility_handler_t*)self)->on_accessibility_location_change = (void (CEF_CALLBACK *)(gc_handle_t self, cef_value_t* value, int *value_release))callback;
        self->on_accessibility_location_change = callback ? cfx_accessibility_handler_on_accessibility_location_change : 0;
        break;
    }
}

