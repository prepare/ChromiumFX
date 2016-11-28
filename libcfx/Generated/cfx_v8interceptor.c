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

void CEF_CALLBACK _cfx_v8interceptor_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_v8interceptor_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_v8interceptor_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_v8interceptor_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_v8interceptor_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_v8interceptor_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_v8interceptor_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_v8interceptor_has_one_ref(struct _cef_base_t* base) {
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

static gc_handle_t cfx_v8interceptor_get_gc_handle(cfx_v8interceptor_t* self) {
    return self->gc_handle;
}

// get_byname

int CEF_CALLBACK cfx_v8interceptor_get_byname(cef_v8interceptor_t* self, const cef_string_t* name, cef_v8value_t* object, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    int object_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->get_byname(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, name ? name->str : 0, name ? (int)name->length : 0, object, &object_release, retval, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_t*)object);
    if(*retval)((cef_base_t*)*retval)->add_ref((cef_base_t*)*retval);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free(exception_gc_handle);
    }
    return __retval;
}

// get_byindex

int CEF_CALLBACK cfx_v8interceptor_get_byindex(cef_v8interceptor_t* self, int index, cef_v8value_t* object, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    int object_release;
    char16* exception_tmp_str = 0; int exception_tmp_length = 0; gc_handle_t exception_gc_handle = 0;
    ((cfx_v8interceptor_t*)self)->get_byindex(((cfx_v8interceptor_t*)self)->gc_handle, &__retval, index, object, &object_release, retval, &exception_tmp_str, &exception_tmp_length, &exception_gc_handle);
    if(object_release) object->base.release((cef_base_t*)object);
    if(*retval)((cef_base_t*)*retval)->add_ref((cef_base_t*)*retval);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free(exception_gc_handle);
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
    if(object_release) object->base.release((cef_base_t*)object);
    if(value_release) value->base.release((cef_base_t*)value);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free(exception_gc_handle);
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
    if(object_release) object->base.release((cef_base_t*)object);
    if(value_release) value->base.release((cef_base_t*)value);
    if(exception_tmp_length > 0) {
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free(exception_gc_handle);
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

