// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

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


