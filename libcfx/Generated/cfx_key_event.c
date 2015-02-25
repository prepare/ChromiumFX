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


// cef_key_event

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_key_event_t* cfx_key_event_ctor() {
    return (cef_key_event_t*)calloc(1, sizeof(cef_key_event_t));
}

CFX_EXPORT void cfx_key_event_dtor(cef_key_event_t* ptr) {
    free(ptr);
}

CFX_EXPORT void cfx_key_event_copy_to_native(cef_key_event_t* self, cef_key_event_type_t type, uint32 modifiers, int windows_key_code, int native_key_code, int is_system_key, char16 character, char16 unmodified_character, int focus_on_editable_field) {
    self->type = type;
    self->modifiers = modifiers;
    self->windows_key_code = windows_key_code;
    self->native_key_code = native_key_code;
    self->is_system_key = is_system_key;
    self->character = character;
    self->unmodified_character = unmodified_character;
    self->focus_on_editable_field = focus_on_editable_field;
}

CFX_EXPORT void cfx_key_event_copy_to_managed(cef_key_event_t* self, cef_key_event_type_t* type, uint32* modifiers, int* windows_key_code, int* native_key_code, int* is_system_key, char16* character, char16* unmodified_character, int* focus_on_editable_field) {
    *type = self->type;
    *modifiers = self->modifiers;
    *windows_key_code = self->windows_key_code;
    *native_key_code = self->native_key_code;
    *is_system_key = self->is_system_key;
    *character = self->character;
    *unmodified_character = self->unmodified_character;
    *focus_on_editable_field = self->focus_on_editable_field;
}

#ifdef __cplusplus
} // extern "C"
#endif

