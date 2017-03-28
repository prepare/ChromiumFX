// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8interceptor

typedef struct _cfx_v8interceptor_t {
    cef_v8interceptor_t cef_v8interceptor;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *get_byname)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle);
    void (CEF_CALLBACK *get_byindex)(gc_handle_t self, int* __retval, int index, cef_v8value_t* object, int *object_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle);
    void (CEF_CALLBACK *set_byname)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, cef_v8value_t* value, int *value_release, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle);
    void (CEF_CALLBACK *set_byindex)(gc_handle_t self, int* __retval, int index, cef_v8value_t* object, int *object_release, cef_v8value_t* value, int *value_release, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle);
} cfx_v8interceptor_t;

void CEF_CALLBACK _cfx_v8interceptor_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_v8interceptor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_v8interceptor_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_v8interceptor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_v8interceptor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_v8interceptor_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_v8interceptor_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_v8interceptor_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_v8interceptor_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_v8interceptor_t* cfx_v8interceptor_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_v8interceptor_t* ptr = (cfx_v8interceptor_t*)calloc(1, sizeof(cfx_v8interceptor_t));
    if(!ptr) return 0;
    ptr->cef_v8interceptor.base.size = sizeof(cef_v8interceptor_t);
    ptr->cef_v8interceptor.base.add_ref = _cfx_v8interceptor_add_ref;
    ptr->cef_v8interceptor.base.release = _cfx_v8interceptor_release;
    ptr->cef_v8interceptor.base.has_one_ref = _cfx_v8interceptor_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// get_byname

int CEF_CALLBACK cfx_v8interceptor_get_byname(cef_v8interceptor_t* self, const cef_string_t* name, cef_v8value_t* object, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    int object_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->get_byname(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, name ? name->str : 0, name ? (int)name->length : 0, object, &object_release, retval, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_ref_counted_t*)object);
    if(*retval)((cef_base_ref_counted_t*)*retval)->add_ref((cef_base_ref_counted_t*)*retval);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_switch(&exception_gc_handle, GC_HANDLE_FREE);
    }
    return __retval;
}

// get_byindex

int CEF_CALLBACK cfx_v8interceptor_get_byindex(cef_v8interceptor_t* self, int index, cef_v8value_t* object, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    int object_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->get_byindex(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, index, object, &object_release, retval, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_ref_counted_t*)object);
    if(*retval)((cef_base_ref_counted_t*)*retval)->add_ref((cef_base_ref_counted_t*)*retval);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_switch(&exception_gc_handle, GC_HANDLE_FREE);
    }
    return __retval;
}

// set_byname

int CEF_CALLBACK cfx_v8interceptor_set_byname(cef_v8interceptor_t* self, const cef_string_t* name, cef_v8value_t* object, cef_v8value_t* value, cef_string_t* exception) {
    int __retval;
    int object_release;
    int value_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->set_byname(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, name ? name->str : 0, name ? (int)name->length : 0, object, &object_release, value, &value_release, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_ref_counted_t*)object);
    if(value_release) value->base.release((cef_base_ref_counted_t*)value);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_switch(&exception_gc_handle, GC_HANDLE_FREE);
    }
    return __retval;
}

// set_byindex

int CEF_CALLBACK cfx_v8interceptor_set_byindex(cef_v8interceptor_t* self, int index, cef_v8value_t* object, cef_v8value_t* value, cef_string_t* exception) {
    int __retval;
    int object_release;
    int value_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->set_byindex(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, index, object, &object_release, value, &value_release, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_ref_counted_t*)object);
    if(value_release) value->base.release((cef_base_ref_counted_t*)value);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_switch(&exception_gc_handle, GC_HANDLE_FREE);
    }
    return __retval;
}

static void cfx_v8interceptor_set_callback(cef_v8interceptor_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_v8interceptor_t*)self)->get_byname = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle))callback;
        self->get_byname = callback ? cfx_v8interceptor_get_byname : 0;
        break;
    case 1:
        ((cfx_v8interceptor_t*)self)->get_byindex = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int index, cef_v8value_t* object, int *object_release, cef_v8value_t** retval, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle))callback;
        self->get_byindex = callback ? cfx_v8interceptor_get_byindex : 0;
        break;
    case 2:
        ((cfx_v8interceptor_t*)self)->set_byname = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int *object_release, cef_v8value_t* value, int *value_release, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle))callback;
        self->set_byname = callback ? cfx_v8interceptor_set_byname : 0;
        break;
    case 3:
        ((cfx_v8interceptor_t*)self)->set_byindex = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int index, cef_v8value_t* object, int *object_release, cef_v8value_t* value, int *value_release, char16 **exception_str, int *exception_length, gc_handle_t *exception_gc_handle))callback;
        self->set_byindex = callback ? cfx_v8interceptor_set_byindex : 0;
        break;
    }
}

