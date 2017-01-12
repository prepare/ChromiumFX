// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// CEF_EXPORT cef_string_list_t cef_string_list_alloc();
static cef_string_list_t cfx_string_list_alloc() {
    return cef_string_list_alloc();
}

// CEF_EXPORT size_t cef_string_list_size(cef_string_list_t list);
static size_t cfx_string_list_size(cef_string_list_t list) {
    return cef_string_list_size(list);
}

// CEF_EXPORT int cef_string_list_value(cef_string_list_t list, size_t index, cef_string_t* value);
static int cfx_string_list_value(cef_string_list_t list, size_t index, char16 **value_str, int *value_length) {
    cef_string_t value = { 0 };
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

// CEF_EXPORT size_t cef_string_map_size(cef_string_map_t map);
static size_t cfx_string_map_size(cef_string_map_t map) {
    return cef_string_map_size(map);
}

// CEF_EXPORT int cef_string_map_find(cef_string_map_t map, const cef_string_t* key, cef_string_t* value);
static int cfx_string_map_find(cef_string_map_t map, char16 *key_str, int key_length, char16 **value_str, int *value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { 0 };
    int __ret_val_ = cef_string_map_find(map, &key, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_map_key(cef_string_map_t map, size_t index, cef_string_t* key);
static int cfx_string_map_key(cef_string_map_t map, size_t index, char16 **key_str, int *key_length) {
    cef_string_t key = { 0 };
    int __ret_val_ = cef_string_map_key(map, index, &key);
    *key_str = key.str; *key_length = (int)key.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_map_value(cef_string_map_t map, size_t index, cef_string_t* value);
static int cfx_string_map_value(cef_string_map_t map, size_t index, char16 **value_str, int *value_length) {
    cef_string_t value = { 0 };
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

// CEF_EXPORT size_t cef_string_multimap_size(cef_string_multimap_t map);
static size_t cfx_string_multimap_size(cef_string_multimap_t map) {
    return cef_string_multimap_size(map);
}

// CEF_EXPORT size_t cef_string_multimap_find_count(cef_string_multimap_t map, const cef_string_t* key);
static size_t cfx_string_multimap_find_count(cef_string_multimap_t map, char16 *key_str, int key_length) {
    cef_string_t key = { key_str, key_length, 0 };
    return cef_string_multimap_find_count(map, &key);
}

// CEF_EXPORT int cef_string_multimap_enumerate(cef_string_multimap_t map, const cef_string_t* key, size_t value_index, cef_string_t* value);
static int cfx_string_multimap_enumerate(cef_string_multimap_t map, char16 *key_str, int key_length, size_t value_index, char16 **value_str, int *value_length) {
    cef_string_t key = { key_str, key_length, 0 };
    cef_string_t value = { 0 };
    int __ret_val_ = cef_string_multimap_enumerate(map, &key, value_index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_multimap_key(cef_string_multimap_t map, size_t index, cef_string_t* key);
static int cfx_string_multimap_key(cef_string_multimap_t map, size_t index, char16 **key_str, int *key_length) {
    cef_string_t key = { 0 };
    int __ret_val_ = cef_string_multimap_key(map, index, &key);
    *key_str = key.str; *key_length = (int)key.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_string_multimap_value(cef_string_multimap_t map, size_t index, cef_string_t* value);
static int cfx_string_multimap_value(cef_string_multimap_t map, size_t index, char16 **value_str, int *value_length) {
    cef_string_t value = { 0 };
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

