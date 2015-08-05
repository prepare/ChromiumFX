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


// cef_drag_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_drag_handler_t {
    cef_drag_handler_t cef_drag_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_drag_handler_t;

void CEF_CALLBACK _cfx_drag_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_drag_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_drag_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_drag_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_drag_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_drag_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_drag_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_drag_handler_t* cfx_drag_handler_ctor(gc_handle_t gc_handle) {
    cfx_drag_handler_t* ptr = (cfx_drag_handler_t*)calloc(1, sizeof(cfx_drag_handler_t));
    if(!ptr) return 0;
    ptr->cef_drag_handler.base.size = sizeof(cef_drag_handler_t);
    ptr->cef_drag_handler.base.add_ref = _cfx_drag_handler_add_ref;
    ptr->cef_drag_handler.base.release = _cfx_drag_handler_release;
    ptr->cef_drag_handler.base.has_one_ref = _cfx_drag_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_drag_handler_get_gc_handle(cfx_drag_handler_t* self) {
    return self->gc_handle;
}

// on_drag_enter

void (CEF_CALLBACK *cfx_drag_handler_on_drag_enter_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask);

int CEF_CALLBACK cfx_drag_handler_on_drag_enter(cef_drag_handler_t* self, cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask) {
    int __retval;
    cfx_drag_handler_on_drag_enter_callback(((cfx_drag_handler_t*)self)->gc_handle, &__retval, browser, dragData, mask);
    return __retval;
}


// on_draggable_regions_changed

void (CEF_CALLBACK *cfx_drag_handler_on_draggable_regions_changed_callback)(gc_handle_t self, cef_browser_t* browser, int regionsCount, cef_draggable_region_t const** regions, int* regions_flags);

void CEF_CALLBACK cfx_drag_handler_on_draggable_regions_changed(cef_drag_handler_t* self, cef_browser_t* browser, size_t regionsCount, cef_draggable_region_t const* regions) {
    int regions_flags;
    cef_draggable_region_t **regions_array = malloc(regionsCount * sizeof(cef_draggable_region_t*));
    if(regions_array) {
        for(int i = 0; i < regionsCount; ++i) {
            regions_array[i] = malloc(sizeof(regions));
            *regions_array[i] = regions[i];
        }
        regions_flags = 0;
    } else {
        regionsCount = 0;
        regions_flags = 1;
    }
    cfx_drag_handler_on_draggable_regions_changed_callback(((cfx_drag_handler_t*)self)->gc_handle, browser, (int)(regionsCount), regions_array, &regions_flags);
    if(regions_flags) {
        for(int i = 0; i < regionsCount; ++i) {
            free(regions_array[i]);
        }
    }
    free(regions_array);
}


static void cfx_drag_handler_set_managed_callback(cef_drag_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_drag_handler_on_drag_enter_callback)
            cfx_drag_handler_on_drag_enter_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask)) callback;
        self->on_drag_enter = callback ? cfx_drag_handler_on_drag_enter : 0;
        break;
    case 1:
        if(callback && !cfx_drag_handler_on_draggable_regions_changed_callback)
            cfx_drag_handler_on_draggable_regions_changed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int regionsCount, cef_draggable_region_t const** regions, int* regions_flags)) callback;
        self->on_draggable_regions_changed = callback ? cfx_drag_handler_on_draggable_regions_changed : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

