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

static cef_key_event_t* cfx_key_event_ctor() {
    return (cef_key_event_t*)calloc(1, sizeof(cef_key_event_t));
}

static void cfx_key_event_dtor(cef_key_event_t* self) {
    free(self);
}

// cef_key_event_t->type
static void cfx_key_event_set_type(cef_key_event_t *self, cef_key_event_type_t type) {
    self->type = type;
}
static void cfx_key_event_get_type(cef_key_event_t *self, cef_key_event_type_t* type) {
    *type = self->type;
}

// cef_key_event_t->modifiers
static void cfx_key_event_set_modifiers(cef_key_event_t *self, uint32 modifiers) {
    self->modifiers = modifiers;
}
static void cfx_key_event_get_modifiers(cef_key_event_t *self, uint32* modifiers) {
    *modifiers = self->modifiers;
}

// cef_key_event_t->windows_key_code
static void cfx_key_event_set_windows_key_code(cef_key_event_t *self, int windows_key_code) {
    self->windows_key_code = windows_key_code;
}
static void cfx_key_event_get_windows_key_code(cef_key_event_t *self, int* windows_key_code) {
    *windows_key_code = self->windows_key_code;
}

// cef_key_event_t->native_key_code
static void cfx_key_event_set_native_key_code(cef_key_event_t *self, int native_key_code) {
    self->native_key_code = native_key_code;
}
static void cfx_key_event_get_native_key_code(cef_key_event_t *self, int* native_key_code) {
    *native_key_code = self->native_key_code;
}

// cef_key_event_t->is_system_key
static void cfx_key_event_set_is_system_key(cef_key_event_t *self, int is_system_key) {
    self->is_system_key = is_system_key;
}
static void cfx_key_event_get_is_system_key(cef_key_event_t *self, int* is_system_key) {
    *is_system_key = self->is_system_key;
}

// cef_key_event_t->character
static void cfx_key_event_set_character(cef_key_event_t *self, char16 character) {
    self->character = character;
}
static void cfx_key_event_get_character(cef_key_event_t *self, char16* character) {
    *character = self->character;
}

// cef_key_event_t->unmodified_character
static void cfx_key_event_set_unmodified_character(cef_key_event_t *self, char16 unmodified_character) {
    self->unmodified_character = unmodified_character;
}
static void cfx_key_event_get_unmodified_character(cef_key_event_t *self, char16* unmodified_character) {
    *unmodified_character = self->unmodified_character;
}

// cef_key_event_t->focus_on_editable_field
static void cfx_key_event_set_focus_on_editable_field(cef_key_event_t *self, int focus_on_editable_field) {
    self->focus_on_editable_field = focus_on_editable_field;
}
static void cfx_key_event_get_focus_on_editable_field(cef_key_event_t *self, int* focus_on_editable_field) {
    *focus_on_editable_field = self->focus_on_editable_field;
}


