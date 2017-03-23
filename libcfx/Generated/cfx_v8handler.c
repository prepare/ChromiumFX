// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8handler

typedef struct _cfx_v8handler_t {
    cef_v8handler_t cef_v8handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *execute)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, size_t argumentsCount, cef_v8value_t* const* arguments, int *arguments_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle);
} cfx_v8handler_t;

void CEF_CALLBACK _cfx_v8handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_v8handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_v8handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_v8handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_v8handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_v8handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_v8handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_v8handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_v8handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_v8handler_t* cfx_v8handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_v8handler_t* ptr = (cfx_v8handler_t*)calloc(1, sizeof(cfx_v8handler_t));
    if(!ptr) return 0;
    ptr->cef_v8handler.base.size = sizeof(cef_v8handler_t);
    ptr->cef_v8handler.base.add_ref = _cfx_v8handler_add_ref;
    ptr->cef_v8handler.base.release = _cfx_v8handler_release;
    ptr->cef_v8handler.base.has_one_ref = _cfx_v8handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_v8handler_get_gc_handle(cfx_v8handler_t* self) {
    return self->gc_handle;
}

// execute

int CEF_CALLBACK cfx_v8handler_execute(cef_v8handler_t* self, const cef_string_t* name, cef_v8value_t* object, size_t argumentsCount, cef_v8value_t* const* arguments, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    int object_release;
    int arguments_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8handler_t*)self)->execute(((cfx_v8handler_t*)self)->gc_handle, &__retval, name ? name->str : 0, name ? (int)name->length : 0, object, &object_release, argumentsCount, arguments, &arguments_release, retval, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_ref_counted_t*)object);
    if(arguments_release) {
        for(size_t i = 0; i < argumentsCount; ++i) {
            arguments[i]->base.release((cef_base_ref_counted_t*)arguments[i]);
        }
    }
    if(*retval)((cef_base_ref_counted_t*)*retval)->add_ref((cef_base_ref_counted_t*)*retval);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free(exception_gc_handle);
    }
    return __retval;
}

static void cfx_v8handler_set_callback(cef_v8handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_v8handler_t*)self)->execute = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, size_t argumentsCount, cef_v8value_t* const* arguments, int *arguments_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle))callback;
        self->execute = callback ? cfx_v8handler_execute : 0;
        break;
    }
}

