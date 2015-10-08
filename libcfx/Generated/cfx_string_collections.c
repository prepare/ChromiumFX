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


// CEF_EXPORT cef_string_list_t cef_string_list_alloc();
static cef_string_list_t cfx_string_list_alloc() {
    return cef_string_list_alloc();
}

// CEF_EXPORT int cef_string_list_size(cef_string_list_t list);
static int cfx_string_list_size(cef_string_list_t list) {
    return cef_string_list_size(list);
}

// CEF_EXPORT int cef_string_list_value(cef_string_list_t list, int index, cef_string_t* value);
static int cfx_string_list_value(cef_string_list_t list, int index, char16 **value_str, int *value_length) {
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_list_value(list, index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT void cef_string_list_append(cef_string_list_t list, const cef_string_t* value);
static void cfx_string_list_append(cef_string_list_t list, char16 *value_str, int value_length) {
    cef_string_t value = { value_str, value_length, 0 };
    cef_string_list_append(list, &value);
}

// CEF_EXPORT void cef_string_list_clear(cef_string_list_t list);
static void cfx_string_list_clear(cef_string_list_t list) {
    cef_string_list_clear(list);
}

// CEF_EXPORT void cef_string_list_free(cef_string_list_t list);
static void cfx_string_list_free(cef_string_list_t list) {
    cef_string_list_free(list);
}

// CEF_EXPORT cef_string_list_t cef_string_list_copy(cef_string_list_t list);
static cef_string_list_t cfx_string_list_copy(cef_string_list_t list) {
    return cef_string_list_copy(list);
}

// CEF_EXPORT cef_string_map_t cef_string_map_alloc();
static cef_string_map_t cfx_string_map_alloc() {
    return cef_string_map_alloc();
}

// CEF_EXPORT int cef_string_map_size(cef_string_map_t map);
static int cfx_string_map_size(cef_string_map_t map) {
    return cef_string_map_size(map);
}

// CEF_EXPORT int cef_string_map_find(cef_string_map_t map, const cef_string_t* key, cef_string_t* value);
static int cfx_string_map_find(cef_string_map_t map, char16 *key_str, int key_length, char16 **value_str, int *value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_map_find(map, &key, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_map_key(cef_string_map_t map, int index, cef_string_t* key);
static int cfx_string_map_key(cef_string_map_t map, int index, char16 **key_str, int *key_length) {
    cef_string_t key = { *key_str, *key_length, 0 };
    int __ret_val_ = cef_string_map_key(map, index, &key);
    *key_str = key.str; *key_length = (int)key.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_map_value(cef_string_map_t map, int index, cef_string_t* value);
static int cfx_string_map_value(cef_string_map_t map, int index, char16 **value_str, int *value_length) {
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_map_value(map, index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_map_append(cef_string_map_t map, const cef_string_t* key, const cef_string_t* value);
static int cfx_string_map_append(cef_string_map_t map, char16 *key_str, int key_length, char16 *value_str, int value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { value_str, value_length, 0 };
    return cef_string_map_append(map, &key, &value);
}

// CEF_EXPORT void cef_string_map_clear(cef_string_map_t map);
static void cfx_string_map_clear(cef_string_map_t map) {
    cef_string_map_clear(map);
}

// CEF_EXPORT void cef_string_map_free(cef_string_map_t map);
static void cfx_string_map_free(cef_string_map_t map) {
    cef_string_map_free(map);
}

// CEF_EXPORT cef_string_multimap_t cef_string_multimap_alloc();
static cef_string_multimap_t cfx_string_multimap_alloc() {
    return cef_string_multimap_alloc();
}

// CEF_EXPORT int cef_string_multimap_size(cef_string_multimap_t map);
static int cfx_string_multimap_size(cef_string_multimap_t map) {
    return cef_string_multimap_size(map);
}

// CEF_EXPORT int cef_string_multimap_find_count(cef_string_multimap_t map, const cef_string_t* key);
static int cfx_string_multimap_find_count(cef_string_multimap_t map, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return cef_string_multimap_find_count(map, &key);
}

// CEF_EXPORT int cef_string_multimap_enumerate(cef_string_multimap_t map, const cef_string_t* key, int value_index, cef_string_t* value);
static int cfx_string_multimap_enumerate(cef_string_multimap_t map, char16 *key_str, int key_length, int value_index, char16 **value_str, int *value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_multimap_enumerate(map, &key, value_index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_multimap_key(cef_string_multimap_t map, int index, cef_string_t* key);
static int cfx_string_multimap_key(cef_string_multimap_t map, int index, char16 **key_str, int *key_length) {
    cef_string_t key = { *key_str, *key_length, 0 };
    int __ret_val_ = cef_string_multimap_key(map, index, &key);
    *key_str = key.str; *key_length = (int)key.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_multimap_value(cef_string_multimap_t map, int index, cef_string_t* value);
static int cfx_string_multimap_value(cef_string_multimap_t map, int index, char16 **value_str, int *value_length) {
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_multimap_value(map, index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_multimap_append(cef_string_multimap_t map, const cef_string_t* key, const cef_string_t* value);
static int cfx_string_multimap_append(cef_string_multimap_t map, char16 *key_str, int key_length, char16 *value_str, int value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { value_str, value_length, 0 };
    return cef_string_multimap_append(map, &key, &value);
}

// CEF_EXPORT void cef_string_multimap_clear(cef_string_multimap_t map);
static void cfx_string_multimap_clear(cef_string_multimap_t map) {
    cef_string_multimap_clear(map);
}

// CEF_EXPORT void cef_string_multimap_free(cef_string_multimap_t map);
static void cfx_string_multimap_free(cef_string_multimap_t map) {
    cef_string_multimap_free(map);
}

