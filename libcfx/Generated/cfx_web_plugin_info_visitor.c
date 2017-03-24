// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_web_plugin_info_visitor

typedef struct _cfx_web_plugin_info_visitor_t {
    cef_web_plugin_info_visitor_t cef_web_plugin_info_visitor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *visit)(gc_handle_t self, int* __retval, cef_web_plugin_info_t* info, int *info_release, int count, int total);
} cfx_web_plugin_info_visitor_t;

void CEF_CALLBACK _cfx_web_plugin_info_visitor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_web_plugin_info_visitor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_web_plugin_info_visitor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_web_plugin_info_visitor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_web_plugin_info_visitor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_web_plugin_info_visitor_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_web_plugin_info_visitor_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_web_plugin_info_visitor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_web_plugin_info_visitor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_web_plugin_info_visitor_t* cfx_web_plugin_info_visitor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_web_plugin_info_visitor_t* ptr = (cfx_web_plugin_info_visitor_t*)calloc(1, sizeof(cfx_web_plugin_info_visitor_t));
    if(!ptr) return 0;
    ptr->cef_web_plugin_info_visitor.base.size = sizeof(cef_web_plugin_info_visitor_t);
    ptr->cef_web_plugin_info_visitor.base.add_ref = _cfx_web_plugin_info_visitor_add_ref;
    ptr->cef_web_plugin_info_visitor.base.release = _cfx_web_plugin_info_visitor_release;
    ptr->cef_web_plugin_info_visitor.base.has_one_ref = _cfx_web_plugin_info_visitor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_web_plugin_info_visitor_get_gc_handle(cfx_web_plugin_info_visitor_t* self) {
    return self->gc_handle;
}

// visit

int CEF_CALLBACK cfx_web_plugin_info_visitor_visit(cef_web_plugin_info_visitor_t* self, cef_web_plugin_info_t* info, int count, int total) {
    int __retval;
    int info_release;
    ((cfx_web_plugin_info_visitor_t*)self)->visit(((cfx_web_plugin_info_visitor_t*)self)->gc_handle, &__retval, info, &info_release, count, total);
    if(info_release) info->base.release((cef_base_ref_counted_t*)info);
    return __retval;
}

static void cfx_web_plugin_info_visitor_set_callback(cef_web_plugin_info_visitor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_web_plugin_info_visitor_t*)self)->visit = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_web_plugin_info_t* info, int *info_release, int count, int total))callback;
        self->visit = callback ? cfx_web_plugin_info_visitor_visit : 0;
        break;
    }
}

