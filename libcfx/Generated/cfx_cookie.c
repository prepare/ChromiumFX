// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_cookie

static cef_cookie_t* cfx_cookie_ctor() {
    return (cef_cookie_t*)calloc(1, sizeof(cef_cookie_t));
}

static void cfx_cookie_dtor(cef_cookie_t* self) {
    if(self->name.dtor) self->name.dtor(self->name.str);
    if(self->value.dtor) self->value.dtor(self->value.str);
    if(self->domain.dtor) self->domain.dtor(self->domain.str);
    if(self->path.dtor) self->path.dtor(self->path.str);
    free(self);
}

// cef_cookie_t->name
static void cfx_cookie_set_name(cef_cookie_t *self, char16 *name_str, int name_length) {
    cef_string_utf16_set(name_str, name_length, &(self->name), 1);
}
static void cfx_cookie_get_name(cef_cookie_t *self, char16 **name_str, int *name_length) {
    *name_str = self->name.str;
    *name_length = (int)self->name.length;
}

// cef_cookie_t->value
static void cfx_cookie_set_value(cef_cookie_t *self, char16 *value_str, int value_length) {
    cef_string_utf16_set(value_str, value_length, &(self->value), 1);
}
static void cfx_cookie_get_value(cef_cookie_t *self, char16 **value_str, int *value_length) {
    *value_str = self->value.str;
    *value_length = (int)self->value.length;
}

// cef_cookie_t->domain
static void cfx_cookie_set_domain(cef_cookie_t *self, char16 *domain_str, int domain_length) {
    cef_string_utf16_set(domain_str, domain_length, &(self->domain), 1);
}
static void cfx_cookie_get_domain(cef_cookie_t *self, char16 **domain_str, int *domain_length) {
    *domain_str = self->domain.str;
    *domain_length = (int)self->domain.length;
}

// cef_cookie_t->path
static void cfx_cookie_set_path(cef_cookie_t *self, char16 *path_str, int path_length) {
    cef_string_utf16_set(path_str, path_length, &(self->path), 1);
}
static void cfx_cookie_get_path(cef_cookie_t *self, char16 **path_str, int *path_length) {
    *path_str = self->path.str;
    *path_length = (int)self->path.length;
}

// cef_cookie_t->secure
static void cfx_cookie_set_secure(cef_cookie_t *self, int secure) {
    self->secure = secure;
}
static void cfx_cookie_get_secure(cef_cookie_t *self, int* secure) {
    *secure = self->secure;
}

// cef_cookie_t->httponly
static void cfx_cookie_set_httponly(cef_cookie_t *self, int httponly) {
    self->httponly = httponly;
}
static void cfx_cookie_get_httponly(cef_cookie_t *self, int* httponly) {
    *httponly = self->httponly;
}

// cef_cookie_t->creation
static void cfx_cookie_set_creation(cef_cookie_t *self, cef_time_t* creation) {
    self->creation = *(creation);
}
static void cfx_cookie_get_creation(cef_cookie_t *self, cef_time_t** creation) {
    *creation = &(self->creation);
}

// cef_cookie_t->last_access
static void cfx_cookie_set_last_access(cef_cookie_t *self, cef_time_t* last_access) {
    self->last_access = *(last_access);
}
static void cfx_cookie_get_last_access(cef_cookie_t *self, cef_time_t** last_access) {
    *last_access = &(self->last_access);
}

// cef_cookie_t->has_expires
static void cfx_cookie_set_has_expires(cef_cookie_t *self, int has_expires) {
    self->has_expires = has_expires;
}
static void cfx_cookie_get_has_expires(cef_cookie_t *self, int* has_expires) {
    *has_expires = self->has_expires;
}

// cef_cookie_t->expires
static void cfx_cookie_set_expires(cef_cookie_t *self, cef_time_t* expires) {
    self->expires = *(expires);
}
static void cfx_cookie_get_expires(cef_cookie_t *self, cef_time_t** expires) {
    *expires = &(self->expires);
}


