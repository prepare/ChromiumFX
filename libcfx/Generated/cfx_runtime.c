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


// CEF_EXPORT int cef_add_cross_origin_whitelist_entry(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
static int cfx_add_cross_origin_whitelist_entry(char16 *source_origin_str, int source_origin_length, char16 *target_protocol_str, int target_protocol_length, char16 *target_domain_str, int target_domain_length, int allow_target_subdomains) {
    cef_string_t source_origin = { source_origin_str, source_origin_length, 0 };
    cef_string_t target_protocol = { target_protocol_str, target_protocol_length, 0 };
    cef_string_t target_domain = { target_domain_str, target_domain_length, 0 };
    return cef_add_cross_origin_whitelist_entry(&source_origin, &target_protocol, &target_domain, allow_target_subdomains);
}

// CEF_EXPORT char* cef_api_hash(int entry);
static const char* cfx_api_hash(int entry) {
    return cef_api_hash(entry);
}

// CEF_EXPORT int cef_begin_tracing(const cef_string_t* categories, cef_completion_callback_t* callback);
static int cfx_begin_tracing(char16 *categories_str, int categories_length, cef_completion_callback_t* callback) {
    cef_string_t categories = { categories_str, categories_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    return cef_begin_tracing(&categories, callback);
}

// CEF_EXPORT int cef_clear_cross_origin_whitelist();
static int cfx_clear_cross_origin_whitelist() {
    return cef_clear_cross_origin_whitelist();
}

// CEF_EXPORT int cef_clear_scheme_handler_factories();
static int cfx_clear_scheme_handler_factories() {
    return cef_clear_scheme_handler_factories();
}

// CEF_EXPORT cef_request_context_t* cef_create_context_shared(cef_request_context_t* other, cef_request_context_handler_t* handler);
static cef_request_context_t* cfx_create_context_shared(cef_request_context_t* other, cef_request_context_handler_t* handler) {
    if(other) ((cef_base_t*)other)->add_ref((cef_base_t*)other);
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_create_context_shared(other, handler);
}

// CEF_EXPORT int cef_create_url(const cef_urlparts_t* parts, cef_string_t* url);
static int cfx_create_url(const cef_urlparts_t* parts, char16 **url_str, int *url_length) {
    cef_string_t url = { 0 };
    int __ret_val_ = cef_create_url(parts, &url);
    *url_str = url.str; *url_length = (int)url.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_currently_on(cef_thread_id_t threadId);
static int cfx_currently_on(cef_thread_id_t threadId) {
    return cef_currently_on(threadId);
}

// CEF_EXPORT void cef_do_message_loop_work();
static void cfx_do_message_loop_work() {
    cef_do_message_loop_work();
}

// CEF_EXPORT void cef_enable_highdpi_support();
static void cfx_enable_highdpi_support() {
    cef_enable_highdpi_support();
}

// CEF_EXPORT int cef_end_tracing(const cef_string_t* tracing_file, cef_end_tracing_callback_t* callback);
static int cfx_end_tracing(char16 *tracing_file_str, int tracing_file_length, cef_end_tracing_callback_t* callback) {
    cef_string_t tracing_file = { tracing_file_str, tracing_file_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    return cef_end_tracing(&tracing_file, callback);
}

// CEF_EXPORT int cef_execute_process(const cef_main_args_t* args, cef_app_t* application, void* windows_sandbox_info);
static int cfx_execute_process(const cef_main_args_t* args, cef_app_t* application, void* windows_sandbox_info) {
    #if defined CFX_WINDOWS
    cef_main_args_t args_tmp = { GetModuleHandle(0) };
    args = &args_tmp;
    #endif
    if(application) ((cef_base_t*)application)->add_ref((cef_base_t*)application);
    return cef_execute_process(args, application, windows_sandbox_info);
}

// CEF_EXPORT cef_string_userfree_t cef_format_url_for_security_display(const cef_string_t* origin_url);
static cef_string_userfree_t cfx_format_url_for_security_display(char16 *origin_url_str, int origin_url_length) {
    cef_string_t origin_url = { origin_url_str, origin_url_length, 0 };
    return cef_format_url_for_security_display(&origin_url);
}

// CEF_EXPORT void cef_get_extensions_for_mime_type(const cef_string_t* mime_type, cef_string_list_t extensions);
static void cfx_get_extensions_for_mime_type(char16 *mime_type_str, int mime_type_length, cef_string_list_t extensions) {
    cef_string_t mime_type = { mime_type_str, mime_type_length, 0 };
    cef_get_extensions_for_mime_type(&mime_type, extensions);
}

// CEF_EXPORT int cef_get_geolocation(cef_get_geolocation_callback_t* callback);
static int cfx_get_geolocation(cef_get_geolocation_callback_t* callback) {
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    return cef_get_geolocation(callback);
}

// CEF_EXPORT cef_string_userfree_t cef_get_mime_type(const cef_string_t* extension);
static cef_string_userfree_t cfx_get_mime_type(char16 *extension_str, int extension_length) {
    cef_string_t extension = { extension_str, extension_length, 0 };
    return cef_get_mime_type(&extension);
}

// CEF_EXPORT int cef_get_path(cef_path_key_t key, cef_string_t* path);
static int cfx_get_path(cef_path_key_t key, char16 **path_str, int *path_length) {
    cef_string_t path = { 0 };
    int __ret_val_ = cef_get_path(key, &path);
    *path_str = path.str; *path_length = (int)path.length;
    return __ret_val_;
}

// CEF_EXPORT XDisplay* cef_get_xdisplay();
#ifdef CFX_LINUX
static void* cfx_get_xdisplay() {
    return cef_get_xdisplay();
}
#else
#define cfx_get_xdisplay 0
#endif

// CEF_EXPORT int cef_initialize(const cef_main_args_t* args, const cef_settings_t* settings, cef_app_t* application, void* windows_sandbox_info);
static int cfx_initialize(const cef_main_args_t* args, const cef_settings_t* settings, cef_app_t* application, void* windows_sandbox_info) {
    #if defined CFX_WINDOWS
    cef_main_args_t args_tmp = { GetModuleHandle(0) };
    args = &args_tmp;
    #endif
    if(application) ((cef_base_t*)application)->add_ref((cef_base_t*)application);
    return cef_initialize(args, settings, application, windows_sandbox_info);
}

// CEF_EXPORT int cef_is_cert_status_error(cef_cert_status_t status);
static int cfx_is_cert_status_error(cef_cert_status_t status) {
    return cef_is_cert_status_error(status);
}

// CEF_EXPORT int cef_is_cert_status_minor_error(cef_cert_status_t status);
static int cfx_is_cert_status_minor_error(cef_cert_status_t status) {
    return cef_is_cert_status_minor_error(status);
}

// CEF_EXPORT void cef_is_web_plugin_unstable(const cef_string_t* path, cef_web_plugin_unstable_callback_t* callback);
static void cfx_is_web_plugin_unstable(char16 *path_str, int path_length, cef_web_plugin_unstable_callback_t* callback) {
    cef_string_t path = { path_str, path_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    cef_is_web_plugin_unstable(&path, callback);
}

// CEF_EXPORT int cef_launch_process(cef_command_line_t* command_line);
static int cfx_launch_process(cef_command_line_t* command_line) {
    if(command_line) ((cef_base_t*)command_line)->add_ref((cef_base_t*)command_line);
    return cef_launch_process(command_line);
}

// CEF_EXPORT int64 cef_now_from_system_trace_time();
static int64 cfx_now_from_system_trace_time() {
    return cef_now_from_system_trace_time();
}

// CEF_EXPORT cef_value_t* cef_parse_json(const cef_string_t* json_string, cef_json_parser_options_t options);
static cef_value_t* cfx_parse_json(char16 *json_string_str, int json_string_length, cef_json_parser_options_t options) {
    cef_string_t json_string = { json_string_str, json_string_length, 0 };
    return cef_parse_json(&json_string, options);
}

// CEF_EXPORT cef_value_t* cef_parse_jsonand_return_error(const cef_string_t* json_string, cef_json_parser_options_t options, cef_json_parser_error_t* error_code_out, cef_string_t* error_msg_out);
static cef_value_t* cfx_parse_jsonand_return_error(char16 *json_string_str, int json_string_length, cef_json_parser_options_t options, cef_json_parser_error_t* error_code_out, char16 **error_msg_out_str, int *error_msg_out_length) {
    cef_string_t json_string = { json_string_str, json_string_length, 0 };
    cef_string_t error_msg_out = { 0 };
    cef_value_t* __ret_val_ = cef_parse_jsonand_return_error(&json_string, options, error_code_out, &error_msg_out);
    *error_msg_out_str = error_msg_out.str; *error_msg_out_length = (int)error_msg_out.length;
    return __ret_val_;
}

// CEF_EXPORT int cef_parse_url(const cef_string_t* url, cef_urlparts_t* parts);
static int cfx_parse_url(char16 *url_str, int url_length, cef_urlparts_t* parts) {
    cef_string_t url = { url_str, url_length, 0 };
    return cef_parse_url(&url, parts);
}

// CEF_EXPORT int cef_post_delayed_task(cef_thread_id_t threadId, cef_task_t* task, int64 delay_ms);
static int cfx_post_delayed_task(cef_thread_id_t threadId, cef_task_t* task, int64 delay_ms) {
    if(task) ((cef_base_t*)task)->add_ref((cef_base_t*)task);
    return cef_post_delayed_task(threadId, task, delay_ms);
}

// CEF_EXPORT int cef_post_task(cef_thread_id_t threadId, cef_task_t* task);
static int cfx_post_task(cef_thread_id_t threadId, cef_task_t* task) {
    if(task) ((cef_base_t*)task)->add_ref((cef_base_t*)task);
    return cef_post_task(threadId, task);
}

// CEF_EXPORT void cef_quit_message_loop();
static void cfx_quit_message_loop() {
    cef_quit_message_loop();
}

// CEF_EXPORT void cef_refresh_web_plugins();
static void cfx_refresh_web_plugins() {
    cef_refresh_web_plugins();
}

// CEF_EXPORT int cef_register_extension(const cef_string_t* extension_name, const cef_string_t* javascript_code, cef_v8handler_t* handler);
static int cfx_register_extension(char16 *extension_name_str, int extension_name_length, char16 *javascript_code_str, int javascript_code_length, cef_v8handler_t* handler) {
    cef_string_t extension_name = { extension_name_str, extension_name_length, 0 };
    cef_string_t javascript_code = { javascript_code_str, javascript_code_length, 0 };
    if(handler) ((cef_base_t*)handler)->add_ref((cef_base_t*)handler);
    return cef_register_extension(&extension_name, &javascript_code, handler);
}

// CEF_EXPORT int cef_register_scheme_handler_factory(const cef_string_t* scheme_name, const cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
static int cfx_register_scheme_handler_factory(char16 *scheme_name_str, int scheme_name_length, char16 *domain_name_str, int domain_name_length, cef_scheme_handler_factory_t* factory) {
    cef_string_t scheme_name = { scheme_name_str, scheme_name_length, 0 };
    cef_string_t domain_name = { domain_name_str, domain_name_length, 0 };
    if(factory) ((cef_base_t*)factory)->add_ref((cef_base_t*)factory);
    return cef_register_scheme_handler_factory(&scheme_name, &domain_name, factory);
}

// CEF_EXPORT void cef_register_web_plugin_crash(const cef_string_t* path);
static void cfx_register_web_plugin_crash(char16 *path_str, int path_length) {
    cef_string_t path = { path_str, path_length, 0 };
    cef_register_web_plugin_crash(&path);
}

// CEF_EXPORT void cef_register_widevine_cdm(const cef_string_t* path, cef_register_cdm_callback_t* callback);
static void cfx_register_widevine_cdm(char16 *path_str, int path_length, cef_register_cdm_callback_t* callback) {
    cef_string_t path = { path_str, path_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    cef_register_widevine_cdm(&path, callback);
}

// CEF_EXPORT int cef_remove_cross_origin_whitelist_entry(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
static int cfx_remove_cross_origin_whitelist_entry(char16 *source_origin_str, int source_origin_length, char16 *target_protocol_str, int target_protocol_length, char16 *target_domain_str, int target_domain_length, int allow_target_subdomains) {
    cef_string_t source_origin = { source_origin_str, source_origin_length, 0 };
    cef_string_t target_protocol = { target_protocol_str, target_protocol_length, 0 };
    cef_string_t target_domain = { target_domain_str, target_domain_length, 0 };
    return cef_remove_cross_origin_whitelist_entry(&source_origin, &target_protocol, &target_domain, allow_target_subdomains);
}

// CEF_EXPORT void cef_run_message_loop();
static void cfx_run_message_loop() {
    cef_run_message_loop();
}

// CEF_EXPORT void cef_set_osmodal_loop(int osModalLoop);
static void cfx_set_osmodal_loop(int osModalLoop) {
    cef_set_osmodal_loop(osModalLoop);
}

// CEF_EXPORT void cef_shutdown();
static void cfx_shutdown() {
    cef_shutdown();
}

// CEF_EXPORT void cef_unregister_internal_web_plugin(const cef_string_t* path);
static void cfx_unregister_internal_web_plugin(char16 *path_str, int path_length) {
    cef_string_t path = { path_str, path_length, 0 };
    cef_unregister_internal_web_plugin(&path);
}

// CEF_EXPORT cef_string_userfree_t cef_uridecode(const cef_string_t* text, int convert_to_utf8, cef_uri_unescape_rule_t unescape_rule);
static cef_string_userfree_t cfx_uridecode(char16 *text_str, int text_length, int convert_to_utf8, cef_uri_unescape_rule_t unescape_rule) {
    cef_string_t text = { text_str, text_length, 0 };
    return cef_uridecode(&text, convert_to_utf8, unescape_rule);
}

// CEF_EXPORT cef_string_userfree_t cef_uriencode(const cef_string_t* text, int use_plus);
static cef_string_userfree_t cfx_uriencode(char16 *text_str, int text_length, int use_plus) {
    cef_string_t text = { text_str, text_length, 0 };
    return cef_uriencode(&text, use_plus);
}

// CEF_EXPORT int cef_version_info(int entry);
static int cfx_version_info(int entry) {
    return cef_version_info(entry);
}

// CEF_EXPORT void cef_visit_web_plugin_info(cef_web_plugin_info_visitor_t* visitor);
static void cfx_visit_web_plugin_info(cef_web_plugin_info_visitor_t* visitor) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    cef_visit_web_plugin_info(visitor);
}

// CEF_EXPORT cef_string_userfree_t cef_write_json(cef_value_t* node, cef_json_writer_options_t options);
static cef_string_userfree_t cfx_write_json(cef_value_t* node, cef_json_writer_options_t options) {
    if(node) ((cef_base_t*)node)->add_ref((cef_base_t*)node);
    return cef_write_json(node, options);
}


