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


// cef_urlparts

#ifdef __cplusplus
extern "C" {
#endif

static cef_urlparts_t* cfx_urlparts_ctor() {
    return (cef_urlparts_t*)calloc(1, sizeof(cef_urlparts_t));
}

static void cfx_urlparts_dtor(cef_urlparts_t* self) {
    if(self->spec.dtor) self->spec.dtor(self->spec.str);
    if(self->scheme.dtor) self->scheme.dtor(self->scheme.str);
    if(self->username.dtor) self->username.dtor(self->username.str);
    if(self->password.dtor) self->password.dtor(self->password.str);
    if(self->host.dtor) self->host.dtor(self->host.str);
    if(self->port.dtor) self->port.dtor(self->port.str);
    if(self->origin.dtor) self->origin.dtor(self->origin.str);
    if(self->path.dtor) self->path.dtor(self->path.str);
    if(self->query.dtor) self->query.dtor(self->query.str);
    free(self);
}

// cef_urlparts_t->spec
static void cfx_urlparts_set_spec(cef_urlparts_t *self, char16 *spec_str, int spec_length) {
    cef_string_utf16_set(spec_str, spec_length, &(self->spec), 1);
}
static void cfx_urlparts_get_spec(cef_urlparts_t *self, char16 **spec_str, int *spec_length) {
    *spec_str = self->spec.str;
    *spec_length = (int)self->spec.length;
}

// cef_urlparts_t->scheme
static void cfx_urlparts_set_scheme(cef_urlparts_t *self, char16 *scheme_str, int scheme_length) {
    cef_string_utf16_set(scheme_str, scheme_length, &(self->scheme), 1);
}
static void cfx_urlparts_get_scheme(cef_urlparts_t *self, char16 **scheme_str, int *scheme_length) {
    *scheme_str = self->scheme.str;
    *scheme_length = (int)self->scheme.length;
}

// cef_urlparts_t->username
static void cfx_urlparts_set_username(cef_urlparts_t *self, char16 *username_str, int username_length) {
    cef_string_utf16_set(username_str, username_length, &(self->username), 1);
}
static void cfx_urlparts_get_username(cef_urlparts_t *self, char16 **username_str, int *username_length) {
    *username_str = self->username.str;
    *username_length = (int)self->username.length;
}

// cef_urlparts_t->password
static void cfx_urlparts_set_password(cef_urlparts_t *self, char16 *password_str, int password_length) {
    cef_string_utf16_set(password_str, password_length, &(self->password), 1);
}
static void cfx_urlparts_get_password(cef_urlparts_t *self, char16 **password_str, int *password_length) {
    *password_str = self->password.str;
    *password_length = (int)self->password.length;
}

// cef_urlparts_t->host
static void cfx_urlparts_set_host(cef_urlparts_t *self, char16 *host_str, int host_length) {
    cef_string_utf16_set(host_str, host_length, &(self->host), 1);
}
static void cfx_urlparts_get_host(cef_urlparts_t *self, char16 **host_str, int *host_length) {
    *host_str = self->host.str;
    *host_length = (int)self->host.length;
}

// cef_urlparts_t->port
static void cfx_urlparts_set_port(cef_urlparts_t *self, char16 *port_str, int port_length) {
    cef_string_utf16_set(port_str, port_length, &(self->port), 1);
}
static void cfx_urlparts_get_port(cef_urlparts_t *self, char16 **port_str, int *port_length) {
    *port_str = self->port.str;
    *port_length = (int)self->port.length;
}

// cef_urlparts_t->origin
static void cfx_urlparts_set_origin(cef_urlparts_t *self, char16 *origin_str, int origin_length) {
    cef_string_utf16_set(origin_str, origin_length, &(self->origin), 1);
}
static void cfx_urlparts_get_origin(cef_urlparts_t *self, char16 **origin_str, int *origin_length) {
    *origin_str = self->origin.str;
    *origin_length = (int)self->origin.length;
}

// cef_urlparts_t->path
static void cfx_urlparts_set_path(cef_urlparts_t *self, char16 *path_str, int path_length) {
    cef_string_utf16_set(path_str, path_length, &(self->path), 1);
}
static void cfx_urlparts_get_path(cef_urlparts_t *self, char16 **path_str, int *path_length) {
    *path_str = self->path.str;
    *path_length = (int)self->path.length;
}

// cef_urlparts_t->query
static void cfx_urlparts_set_query(cef_urlparts_t *self, char16 *query_str, int query_length) {
    cef_string_utf16_set(query_str, query_length, &(self->query), 1);
}
static void cfx_urlparts_get_query(cef_urlparts_t *self, char16 **query_str, int *query_length) {
    *query_str = self->query.str;
    *query_length = (int)self->query.length;
}


#ifdef __cplusplus
} // extern "C"
#endif

