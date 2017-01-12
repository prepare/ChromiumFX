// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_task

typedef struct _cfx_task_t {
    cef_task_t cef_task;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *execute)(gc_handle_t self);
} cfx_task_t;

void CEF_CALLBACK _cfx_task_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_task_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_task_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_task_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_task_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_task_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_task_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_task_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_task_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_task_t* cfx_task_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_task_t* ptr = (cfx_task_t*)calloc(1, sizeof(cfx_task_t));
    if(!ptr) return 0;
    ptr->cef_task.base.size = sizeof(cef_task_t);
    ptr->cef_task.base.add_ref = _cfx_task_add_ref;
    ptr->cef_task.base.release = _cfx_task_release;
    ptr->cef_task.base.has_one_ref = _cfx_task_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_task_get_gc_handle(cfx_task_t* self) {
    return self->gc_handle;
}

// execute

void CEF_CALLBACK cfx_task_execute(cef_task_t* self) {
    ((cfx_task_t*)self)->execute(((cfx_task_t*)self)->gc_handle);
}

static void cfx_task_set_callback(cef_task_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_task_t*)self)->execute = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->execute = callback ? cfx_task_execute : 0;
        break;
    }
}

