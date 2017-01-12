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


// cef_request_context_settings

static cef_request_context_settings_t* cfx_request_context_settings_ctor() {
    cef_request_context_settings_t* self = (cef_request_context_settings_t*)calloc(1, sizeof(cef_request_context_settings_t));
    if(!self) return 0;
    self->size = sizeof(cef_request_context_settings_t);
    return self;
}

static void cfx_request_context_settings_dtor(cef_request_context_settings_t* self) {
    if(self->cache_path.dtor) self->cache_path.dtor(self->cache_path.str);
    if(self->accept_language_list.dtor) self->accept_language_list.dtor(self->accept_language_list.str);
    free(self);
}

// cef_request_context_settings_t->cache_path
static void cfx_request_context_settings_set_cache_path(cef_request_context_settings_t *self, char16 *cache_path_str, int cache_path_length) {
    cef_string_utf16_set(cache_path_str, cache_path_length, &(self->cache_path), 1);
}
static void cfx_request_context_settings_get_cache_path(cef_request_context_settings_t *self, char16 **cache_path_str, int *cache_path_length) {
    *cache_path_str = self->cache_path.str;
    *cache_path_length = (int)self->cache_path.length;
}

// cef_request_context_settings_t->persist_session_cookies
static void cfx_request_context_settings_set_persist_session_cookies(cef_request_context_settings_t *self, int persist_session_cookies) {
    self->persist_session_cookies = persist_session_cookies;
}
static void cfx_request_context_settings_get_persist_session_cookies(cef_request_context_settings_t *self, int* persist_session_cookies) {
    *persist_session_cookies = self->persist_session_cookies;
}

// cef_request_context_settings_t->persist_user_preferences
static void cfx_request_context_settings_set_persist_user_preferences(cef_request_context_settings_t *self, int persist_user_preferences) {
    self->persist_user_preferences = persist_user_preferences;
}
static void cfx_request_context_settings_get_persist_user_preferences(cef_request_context_settings_t *self, int* persist_user_preferences) {
    *persist_user_preferences = self->persist_user_preferences;
}

// cef_request_context_settings_t->ignore_certificate_errors
static void cfx_request_context_settings_set_ignore_certificate_errors(cef_request_context_settings_t *self, int ignore_certificate_errors) {
    self->ignore_certificate_errors = ignore_certificate_errors;
}
static void cfx_request_context_settings_get_ignore_certificate_errors(cef_request_context_settings_t *self, int* ignore_certificate_errors) {
    *ignore_certificate_errors = self->ignore_certificate_errors;
}

// cef_request_context_settings_t->enable_net_security_expiration
static void cfx_request_context_settings_set_enable_net_security_expiration(cef_request_context_settings_t *self, int enable_net_security_expiration) {
    self->enable_net_security_expiration = enable_net_security_expiration;
}
static void cfx_request_context_settings_get_enable_net_security_expiration(cef_request_context_settings_t *self, int* enable_net_security_expiration) {
    *enable_net_security_expiration = self->enable_net_security_expiration;
}

// cef_request_context_settings_t->accept_language_list
static void cfx_request_context_settings_set_accept_language_list(cef_request_context_settings_t *self, char16 *accept_language_list_str, int accept_language_list_length) {
    cef_string_utf16_set(accept_language_list_str, accept_language_list_length, &(self->accept_language_list), 1);
}
static void cfx_request_context_settings_get_accept_language_list(cef_request_context_settings_t *self, char16 **accept_language_list_str, int *accept_language_list_length) {
    *accept_language_list_str = self->accept_language_list.str;
    *accept_language_list_length = (int)self->accept_language_list.length;
}


