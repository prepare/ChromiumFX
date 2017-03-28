// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_get_geolocation_callback

typedef struct _cfx_get_geolocation_callback_t {
    cef_get_geolocation_callback_t cef_get_geolocation_callback;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_location_update)(gc_handle_t self, const cef_geoposition_t* position);
} cfx_get_geolocation_callback_t;

void CEF_CALLBACK _cfx_get_geolocation_callback_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_get_geolocation_callback_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_get_geolocation_callback_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_get_geolocation_callback_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_get_geolocation_callback_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_get_geolocation_callback_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_get_geolocation_callback_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_get_geolocation_callback_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_get_geolocation_callback_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_get_geolocation_callback_t* cfx_get_geolocation_callback_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_get_geolocation_callback_t* ptr = (cfx_get_geolocation_callback_t*)calloc(1, sizeof(cfx_get_geolocation_callback_t));
    if(!ptr) return 0;
    ptr->cef_get_geolocation_callback.base.size = sizeof(cef_get_geolocation_callback_t);
    ptr->cef_get_geolocation_callback.base.add_ref = _cfx_get_geolocation_callback_add_ref;
    ptr->cef_get_geolocation_callback.base.release = _cfx_get_geolocation_callback_release;
    ptr->cef_get_geolocation_callback.base.has_one_ref = _cfx_get_geolocation_callback_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_location_update

void CEF_CALLBACK cfx_get_geolocation_callback_on_location_update(cef_get_geolocation_callback_t* self, const cef_geoposition_t* position) {
    ((cfx_get_geolocation_callback_t*)self)->on_location_update(((cfx_get_geolocation_callback_t*)self)->gc_handle, position);
}

static void cfx_get_geolocation_callback_set_callback(cef_get_geolocation_callback_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_get_geolocation_callback_t*)self)->on_location_update = (void (CEF_CALLBACK *)(gc_handle_t self, const cef_geoposition_t* position))callback;
        self->on_location_update = callback ? cfx_get_geolocation_callback_on_location_update : 0;
        break;
    }
}

