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


// cef_v8value

// CEF_EXPORT cef_v8value_t* cef_v8value_create_undefined();
static cef_v8value_t* cfx_v8value_create_undefined() {
    return cef_v8value_create_undefined();
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_null();
static cef_v8value_t* cfx_v8value_create_null() {
    return cef_v8value_create_null();
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_bool(int value);
static cef_v8value_t* cfx_v8value_create_bool(int value) {
    return cef_v8value_create_bool(value);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_int(int32 value);
static cef_v8value_t* cfx_v8value_create_int(int32 value) {
    return cef_v8value_create_int(value);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_uint(uint32 value);
static cef_v8value_t* cfx_v8value_create_uint(uint32 value) {
    return cef_v8value_create_uint(value);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_double(double value);
static cef_v8value_t* cfx_v8value_create_double(double value) {
    return cef_v8value_create_double(value);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_date(const cef_time_t* date);
static cef_v8value_t* cfx_v8value_create_date(const cef_time_t* date) {
    return cef_v8value_create_date(date);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_string(const cef_string_t* value);
static cef_v8value_t* cfx_v8value_create_string(char16 *value_str, int value_length) {
    cef_string_t value = { value_str, value_length, 0 };
    return cef_v8value_create_string(&value);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_object(cef_v8accessor_t* accessor, cef_v8interceptor_t* interceptor);
static cef_v8value_t* cfx_v8value_create_object(cef_v8accessor_t* accessor, cef_v8interceptor_t* interceptor) {
    if(accessor) ((cef_base_t*)accessor)->add_ref((cef_base_t*)accessor);
    if(interceptor) ((cef_base_t*)interceptor)->add_ref((cef_base_t*)interceptor);
    return cef_v8value_create_object(accessor, interceptor);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_array(int length);
static cef_v8value_t* cfx_v8value_create_array(int length) {
    return cef_v8value_create_array(length);
}
// CEF_EXPORT cef_v8value_t* cef_v8value_create_function(const cef_string_t* name, cef_v8handler_t* handler);
static cef_v8value_t* cfx_v8value_create_function(char16 *name_str, int name_length, cef_v8handler_t* handler) {
    cef_string_t name = { name_str, name_length, 0 };
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_v8value_create_function(&name, handler);
}
// is_valid
static int cfx_v8value_is_valid(cef_v8value_t* self) {
    return self->is_valid(self);
}

// is_undefined
static int cfx_v8value_is_undefined(cef_v8value_t* self) {
    return self->is_undefined(self);
}

// is_null
static int cfx_v8value_is_null(cef_v8value_t* self) {
    return self->is_null(self);
}

// is_bool
static int cfx_v8value_is_bool(cef_v8value_t* self) {
    return self->is_bool(self);
}

// is_int
static int cfx_v8value_is_int(cef_v8value_t* self) {
    return self->is_int(self);
}

// is_uint
static int cfx_v8value_is_uint(cef_v8value_t* self) {
    return self->is_uint(self);
}

// is_double
static int cfx_v8value_is_double(cef_v8value_t* self) {
    return self->is_double(self);
}

// is_date
static int cfx_v8value_is_date(cef_v8value_t* self) {
    return self->is_date(self);
}

// is_string
static int cfx_v8value_is_string(cef_v8value_t* self) {
    return self->is_string(self);
}

// is_object
static int cfx_v8value_is_object(cef_v8value_t* self) {
    return self->is_object(self);
}

// is_array
static int cfx_v8value_is_array(cef_v8value_t* self) {
    return self->is_array(self);
}

// is_function
static int cfx_v8value_is_function(cef_v8value_t* self) {
    return self->is_function(self);
}

// is_same
static int cfx_v8value_is_same(cef_v8value_t* self, cef_v8value_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
    return self->is_same(self, that);
}

// get_bool_value
static int cfx_v8value_get_bool_value(cef_v8value_t* self) {
    return self->get_bool_value(self);
}

// get_int_value
static int32 cfx_v8value_get_int_value(cef_v8value_t* self) {
    return self->get_int_value(self);
}

// get_uint_value
static uint32 cfx_v8value_get_uint_value(cef_v8value_t* self) {
    return self->get_uint_value(self);
}

// get_double_value
static double cfx_v8value_get_double_value(cef_v8value_t* self) {
    return self->get_double_value(self);
}

// get_date_value
static cef_time_t* cfx_v8value_get_date_value(cef_v8value_t* self) {
    cef_time_t __retval_tmp = self->get_date_value(self);
    return (cef_time_t*)cfx_copy_structure(&__retval_tmp, sizeof(cef_time_t));
}

// get_string_value
static cef_string_userfree_t cfx_v8value_get_string_value(cef_v8value_t* self) {
    return self->get_string_value(self);
}

// is_user_created
static int cfx_v8value_is_user_created(cef_v8value_t* self) {
    return self->is_user_created(self);
}

// has_exception
static int cfx_v8value_has_exception(cef_v8value_t* self) {
    return self->has_exception(self);
}

// get_exception
static cef_v8exception_t* cfx_v8value_get_exception(cef_v8value_t* self) {
    return self->get_exception(self);
}

// clear_exception
static int cfx_v8value_clear_exception(cef_v8value_t* self) {
    return self->clear_exception(self);
}

// will_rethrow_exceptions
static int cfx_v8value_will_rethrow_exceptions(cef_v8value_t* self) {
    return self->will_rethrow_exceptions(self);
}

// set_rethrow_exceptions
static int cfx_v8value_set_rethrow_exceptions(cef_v8value_t* self, int rethrow) {
    return self->set_rethrow_exceptions(self, rethrow);
}

// has_value_bykey
static int cfx_v8value_has_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->has_value_bykey(self, &key);
}

// has_value_byindex
static int cfx_v8value_has_value_byindex(cef_v8value_t* self, int index) {
    return self->has_value_byindex(self, index);
}

// delete_value_bykey
static int cfx_v8value_delete_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->delete_value_bykey(self, &key);
}

// delete_value_byindex
static int cfx_v8value_delete_value_byindex(cef_v8value_t* self, int index) {
    return self->delete_value_byindex(self, index);
}

// get_value_bykey
static cef_v8value_t* cfx_v8value_get_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->get_value_bykey(self, &key);
}

// get_value_byindex
static cef_v8value_t* cfx_v8value_get_value_byindex(cef_v8value_t* self, int index) {
    return self->get_value_byindex(self, index);
}

// set_value_bykey
static int cfx_v8value_set_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length, cef_v8value_t* value, cef_v8_propertyattribute_t attribute) {
    cef_string_t key = { key_str, key_length, 0 };
    if(value) ((cef_base_t*)value)->add_ref((cef_base_t*)value);
    return self->set_value_bykey(self, &key, value, attribute);
}

// set_value_byindex
static int cfx_v8value_set_value_byindex(cef_v8value_t* self, int index, cef_v8value_t* value) {
    if(value) ((cef_base_t*)value)->add_ref((cef_base_t*)value);
    return self->set_value_byindex(self, index, value);
}

// set_value_byaccessor
static int cfx_v8value_set_value_byaccessor(cef_v8value_t* self, char16 *key_str, int key_length, cef_v8_accesscontrol_t settings, cef_v8_propertyattribute_t attribute) {
    cef_string_t key = { key_str, key_length, 0 };
    return self->set_value_byaccessor(self, &key, settings, attribute);
}

// get_keys
static int cfx_v8value_get_keys(cef_v8value_t* self, cef_string_list_t keys) {
    return self->get_keys(self, keys);
}

// set_user_data
static int cfx_v8value_set_user_data(cef_v8value_t* self, struct _cef_base_t* user_data) {
    return self->set_user_data(self, user_data);
}

// get_user_data
static struct _cef_base_t* cfx_v8value_get_user_data(cef_v8value_t* self) {
    return self->get_user_data(self);
}

// get_externally_allocated_memory
static int cfx_v8value_get_externally_allocated_memory(cef_v8value_t* self) {
    return self->get_externally_allocated_memory(self);
}

// adjust_externally_allocated_memory
static int cfx_v8value_adjust_externally_allocated_memory(cef_v8value_t* self, int change_in_bytes) {
    return self->adjust_externally_allocated_memory(self, change_in_bytes);
}

// get_array_length
static int cfx_v8value_get_array_length(cef_v8value_t* self) {
    return self->get_array_length(self);
}

// get_function_name
static cef_string_userfree_t cfx_v8value_get_function_name(cef_v8value_t* self) {
    return self->get_function_name(self);
}

// get_function_handler
static cef_v8handler_t* cfx_v8value_get_function_handler(cef_v8value_t* self) {
    return self->get_function_handler(self);
}

// execute_function
static cef_v8value_t* cfx_v8value_execute_function(cef_v8value_t* self, cef_v8value_t* object, size_t argumentsCount, cef_v8value_t* const* arguments) {
    if(object) ((cef_base_t*)object)->add_ref((cef_base_t*)object);
    if(argumentsCount) {
        for(size_t i = 0; i < argumentsCount; ++i) {
            if(arguments[i]) ((cef_base_t*)arguments[i])->add_ref((cef_base_t*)arguments[i]);
        }
    }
    return self->execute_function(self, object, argumentsCount, arguments);
}

// execute_function_with_context
static cef_v8value_t* cfx_v8value_execute_function_with_context(cef_v8value_t* self, cef_v8context_t* context, cef_v8value_t* object, size_t argumentsCount, cef_v8value_t* const* arguments) {
    if(context) ((cef_base_t*)context)->add_ref((cef_base_t*)context);
    if(object) ((cef_base_t*)object)->add_ref((cef_base_t*)object);
    if(argumentsCount) {
        for(size_t i = 0; i < argumentsCount; ++i) {
            if(arguments[i]) ((cef_base_t*)arguments[i])->add_ref((cef_base_t*)arguments[i]);
        }
    }
    return self->execute_function_with_context(self, context, object, argumentsCount, arguments);
}


