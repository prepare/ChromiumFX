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


#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_string_list_t cef_string_list_alloc();
CFX_EXPORT cef_string_list_t cfx_string_list_alloc() {
    return cef_string_list_alloc();
}

// CEF_EXPORT int cef_string_list_size(cef_string_list_t list);
CFX_EXPORT int cfx_string_list_size(cef_string_list_t list) {
    return cef_string_list_size(list);
}

// CEF_EXPORT int cef_string_list_value(cef_string_list_t list, int index, cef_string_t* value);
CFX_EXPORT int cfx_string_list_value(cef_string_list_t list, int index, char16 **value_str, int *value_length) {
    cef_string_t value = { *value_str, *value_length, 0 };
    int __ret_val_ = cef_string_list_value(list, index, &value);
    *value_str = value.str; *value_length = (int)value.length;
    return __ret_val_;
}

// CEF_EXPORT void cef_string_list_append(cef_string_list_t list, const cef_string_t* value);
CFX_EXPORT void cfx_string_list_append(cef_string_list_t list, char16 *value_str, int value_length) {
    cef_string_t value = { value_str, value_length, 0 };
    cef_string_list_append(list, &value);
}

// CEF_EXPORT void cef_string_list_clear(cef_string_list_t list);
CFX_EXPORT void cfx_string_list_clear(cef_string_list_t list) {
    cef_string_list_clear(list);
}

// CEF_EXPORT void cef_string_list_free(cef_string_list_t list);
CFX_EXPORT void cfx_string_list_free(cef_string_list_t list) {
    cef_string_list_free(list);
}

// CEF_EXPORT cef_string_list_t cef_string_list_copy(cef_string_list_t list);
CFX_EXPORT cef_string_list_t cfx_string_list_copy(cef_string_list_t list) {
    return cef_string_list_copy(list);
}

#ifdef __cplusplus
} // extern "C"
#endif
