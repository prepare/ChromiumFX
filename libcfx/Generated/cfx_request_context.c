// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_request_context

// CEF_EXPORT cef_request_context_t* cef_request_context_get_global_context();
static cef_request_context_t* cfx_request_context_get_global_context() {
    return cef_request_context_get_global_context();
}
// CEF_EXPORT cef_request_context_t* cef_request_context_create_context(const cef_request_context_settings_t* settings, cef_request_context_handler_t* handler);
static cef_request_context_t* cfx_request_context_create_context(const cef_request_context_settings_t* settings, cef_request_context_handler_t* handler) {
    if(handler) ((cef_base_ref_counted_t*)handler)->add_ref((cef_base_ref_counted_t*)handler);
    return cef_request_context_create_context(settings, handler);
}
// is_same
static int cfx_request_context_is_same(cef_request_context_t* self, cef_request_context_t* other) {
    if(other) ((cef_base_ref_counted_t*)other)->add_ref((cef_base_ref_counted_t*)other);
    return self->is_same(self, other);
}

// is_sharing_with
static int cfx_request_context_is_sharing_with(cef_request_context_t* self, cef_request_context_t* other) {
    if(other) ((cef_base_ref_counted_t*)other)->add_ref((cef_base_ref_counted_t*)other);
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
    if(callback) ((cef_base_ref_counted_t*)callback)->add_ref((cef_base_ref_counted_t*)callback);
    return self->get_default_cookie_manager(self, callback);
}

// register_scheme_handler_factory
static int cfx_request_context_register_scheme_handler_factory(cef_request_context_t* self, char16 *scheme_name_str, int scheme_name_length, char16 *domain_name_str, int domain_name_length, cef_scheme_handler_factory_t* factory) {
    cef_string_t scheme_name = { scheme_name_str, scheme_name_length, 0 };
    cef_string_t domain_name = { domain_name_str, domain_name_length, 0 };
    if(factory) ((cef_base_ref_counted_t*)factory)->add_ref((cef_base_ref_counted_t*)factory);
    return self->register_scheme_handler_factory(self, &scheme_name, &domain_name, factory);
}

// clear_scheme_handler_factories
static int cfx_request_context_clear_scheme_handler_factories(cef_request_context_t* self) {
    return self->clear_scheme_handler_factories(self);
}

// purge_plugin_list_cache
static void cfx_request_context_purge_plugin_list_cache(cef_request_context_t* self, int reload_pages) {
    self->purge_plugin_list_cache(self, reload_pages);
}

// has_preference
static int cfx_request_context_has_preference(cef_request_context_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->has_preference(self, &name);
}

// get_preference
static cef_value_t* cfx_request_context_get_preference(cef_request_context_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->get_preference(self, &name);
}

// get_all_preferences
static cef_dictionary_value_t* cfx_request_context_get_all_preferences(cef_request_context_t* self, int include_defaults) {
    return self->get_all_preferences(self, include_defaults);
}

// can_set_preference
static int cfx_request_context_can_set_preference(cef_request_context_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    return self->can_set_preference(self, &name);
}

// set_preference
static int cfx_request_context_set_preference(cef_request_context_t* self, char16 *name_str, int name_length, cef_value_t* value, char16 **error_str, int *error_length) {
    cef_string_t name = { name_str, name_length, 0 };
    if(value) ((cef_base_ref_counted_t*)value)->add_ref((cef_base_ref_counted_t*)value);
    cef_string_t error = { 0 };
    int __ret_val_ = self->set_preference(self, &name, value, &error);
    *error_str = error.str; *error_length = (int)error.length;
    return __ret_val_;
}

// clear_certificate_exceptions
static void cfx_request_context_clear_certificate_exceptions(cef_request_context_t* self, cef_completion_callback_t* callback) {
    if(callback) ((cef_base_ref_counted_t*)callback)->add_ref((cef_base_ref_counted_t*)callback);
    self->clear_certificate_exceptions(self, callback);
}

// close_all_connections
static void cfx_request_context_close_all_connections(cef_request_context_t* self, cef_completion_callback_t* callback) {
    if(callback) ((cef_base_ref_counted_t*)callback)->add_ref((cef_base_ref_counted_t*)callback);
    self->close_all_connections(self, callback);
}

// resolve_host
static void cfx_request_context_resolve_host(cef_request_context_t* self, char16 *origin_str, int origin_length, cef_resolve_callback_t* callback) {
    cef_string_t origin = { origin_str, origin_length, 0 };
    if(callback) ((cef_base_ref_counted_t*)callback)->add_ref((cef_base_ref_counted_t*)callback);
    self->resolve_host(self, &origin, callback);
}

// resolve_host_cached
static cef_errorcode_t cfx_request_context_resolve_host_cached(cef_request_context_t* self, char16 *origin_str, int origin_length, cef_string_list_t resolved_ips) {
    cef_string_t origin = { origin_str, origin_length, 0 };
    return self->resolve_host_cached(self, &origin, resolved_ips);
}


