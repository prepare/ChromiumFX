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


// cef_request_context

// CEF_EXPORT cef_request_context_t* cef_request_context_get_global_context();
static cef_request_context_t* cfx_request_context_get_global_context() {
    return cef_request_context_get_global_context();
}
// CEF_EXPORT cef_request_context_t* cef_request_context_create_context(const cef_request_context_settings_t* settings, cef_request_context_handler_t* handler);
static cef_request_context_t* cfx_request_context_create_context(const cef_request_context_settings_t* settings, cef_request_context_handler_t* handler) {
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_request_context_create_context(settings, handler);
}
// is_same
static int cfx_request_context_is_same(cef_request_context_t* self, cef_request_context_t* other) {
    if(other) ((cef_base_t*)other)->add_ref((cef_base_t*)other);
    return self->is_same(self, other);
}

// is_sharing_with
static int cfx_request_context_is_sharing_with(cef_request_context_t* self, cef_request_context_t* other) {
    if(other) ((cef_base_t*)other)->add_ref((cef_base_t*)other);
    return self->is_sharing_with(self, other);
}

// is_global
static int cfx_request_context_is_global(cef_request_context_t* self) {
    return self->is_global(self);
}

// get_handler
static cef_request_context_handler_t* cfx_request_context_get_handler(cef_request_context_t* self) {
    return self->get_handler(self);
}

// get_cache_path
static cef_string_userfree_t cfx_request_context_get_cache_path(cef_request_context_t* self) {
    return self->get_cache_path(self);
}

// get_default_cookie_manager
static cef_cookie_manager_t* cfx_request_context_get_default_cookie_manager(cef_request_context_t* self, cef_completion_callback_t* callback) {
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    return self->get_default_cookie_manager(self, callback);
}

// register_scheme_handler_factory
static int cfx_request_context_register_scheme_handler_factory(cef_request_context_t* self, char16 *scheme_name_str, int scheme_name_length, char16 *domain_name_str, int domain_name_length, cef_scheme_handler_factory_t* factory) {
    cef_string_t scheme_name = { scheme_name_str, scheme_name_length, 0 };
    cef_string_t domain_name = { domain_name_str, domain_name_length, 0 };
    if(factory) ((cef_base_t*)factory)->add_ref((cef_base_t*)factory);
    return self->register_scheme_handler_factory(self, &scheme_name, &domain_name, factory);
}

// clear_scheme_handler_factories
static int cfx_request_context_clear_scheme_handler_factories(cef_request_context_t* self) {
    return self->clear_scheme_handler_factories(self);
}


