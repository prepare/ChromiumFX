// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


static int (*cef_add_cross_origin_whitelist_entry_ptr)(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
static const char* (*cef_api_hash_ptr)(int entry);
static cef_binary_value_t* (*cef_base64decode_ptr)(const cef_string_t* data);
static cef_string_userfree_t (*cef_base64encode_ptr)(const void* data, size_t data_size);
static int (*cef_begin_tracing_ptr)(const cef_string_t* categories, cef_completion_callback_t* callback);
static int (*cef_clear_cross_origin_whitelist_ptr)();
static int (*cef_clear_scheme_handler_factories_ptr)();
static int (*cef_crash_reporting_enabled_ptr)();
static cef_request_context_t* (*cef_create_context_shared_ptr)(cef_request_context_t* other, cef_request_context_handler_t* handler);
static int (*cef_create_directory_ptr)(const cef_string_t* full_path);
static int (*cef_create_new_temp_directory_ptr)(const cef_string_t* prefix, cef_string_t* new_temp_path);
static int (*cef_create_temp_directory_in_directory_ptr)(const cef_string_t* base_dir, const cef_string_t* prefix, cef_string_t* new_dir);
static int (*cef_create_url_ptr)(const cef_urlparts_t* parts, cef_string_t* url);
static int (*cef_currently_on_ptr)(cef_thread_id_t threadId);
static int (*cef_delete_file_ptr)(const cef_string_t* path, int recursive);
static int (*cef_directory_exists_ptr)(const cef_string_t* path);
static void (*cef_do_message_loop_work_ptr)();
static void (*cef_enable_highdpi_support_ptr)();
static int (*cef_end_tracing_ptr)(const cef_string_t* tracing_file, cef_end_tracing_callback_t* callback);
static int (*cef_execute_process_ptr)(const cef_main_args_t* args, cef_app_t* application, void* windows_sandbox_info);
static cef_string_userfree_t (*cef_format_url_for_security_display_ptr)(const cef_string_t* origin_url);
static void (*cef_get_extensions_for_mime_type_ptr)(const cef_string_t* mime_type, cef_string_list_t extensions);
static int (*cef_get_geolocation_ptr)(cef_get_geolocation_callback_t* callback);
static cef_string_userfree_t (*cef_get_mime_type_ptr)(const cef_string_t* extension);
static int (*cef_get_path_ptr)(cef_path_key_t key, cef_string_t* path);
static int (*cef_get_temp_directory_ptr)(cef_string_t* temp_dir);
#ifdef CFX_LINUX
static XDisplay* (*cef_get_xdisplay_ptr)();
#endif
static int (*cef_initialize_ptr)(const cef_main_args_t* args, const cef_settings_t* settings, cef_app_t* application, void* windows_sandbox_info);
static int (*cef_is_cert_status_error_ptr)(cef_cert_status_t status);
static int (*cef_is_cert_status_minor_error_ptr)(cef_cert_status_t status);
static void (*cef_is_web_plugin_unstable_ptr)(const cef_string_t* path, cef_web_plugin_unstable_callback_t* callback);
static int (*cef_launch_process_ptr)(cef_command_line_t* command_line);
static void (*cef_load_crlsets_file_ptr)(const cef_string_t* path);
static int64 (*cef_now_from_system_trace_time_ptr)();
static cef_value_t* (*cef_parse_json_ptr)(const cef_string_t* json_string, cef_json_parser_options_t options);
static cef_value_t* (*cef_parse_jsonand_return_error_ptr)(const cef_string_t* json_string, cef_json_parser_options_t options, cef_json_parser_error_t* error_code_out, cef_string_t* error_msg_out);
static int (*cef_parse_url_ptr)(const cef_string_t* url, cef_urlparts_t* parts);
static int (*cef_post_delayed_task_ptr)(cef_thread_id_t threadId, cef_task_t* task, int64 delay_ms);
static int (*cef_post_task_ptr)(cef_thread_id_t threadId, cef_task_t* task);
static void (*cef_quit_message_loop_ptr)();
static void (*cef_refresh_web_plugins_ptr)();
static int (*cef_register_extension_ptr)(const cef_string_t* extension_name, const cef_string_t* javascript_code, cef_v8handler_t* handler);
static int (*cef_register_scheme_handler_factory_ptr)(const cef_string_t* scheme_name, const cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
static void (*cef_register_web_plugin_crash_ptr)(const cef_string_t* path);
static void (*cef_register_widevine_cdm_ptr)(const cef_string_t* path, cef_register_cdm_callback_t* callback);
static int (*cef_remove_cross_origin_whitelist_entry_ptr)(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
static void (*cef_run_message_loop_ptr)();
static void (*cef_set_crash_key_value_ptr)(const cef_string_t* key, const cef_string_t* value);
static void (*cef_set_osmodal_loop_ptr)(int osModalLoop);
static void (*cef_shutdown_ptr)();
static void (*cef_unregister_internal_web_plugin_ptr)(const cef_string_t* path);
static cef_string_userfree_t (*cef_uridecode_ptr)(const cef_string_t* text, int convert_to_utf8, cef_uri_unescape_rule_t unescape_rule);
static cef_string_userfree_t (*cef_uriencode_ptr)(const cef_string_t* text, int use_plus);
static int (*cef_version_info_ptr)(int entry);
static void (*cef_visit_web_plugin_info_ptr)(cef_web_plugin_info_visitor_t* visitor);
static cef_string_userfree_t (*cef_write_json_ptr)(cef_value_t* node, cef_json_writer_options_t options);
static int (*cef_zip_directory_ptr)(const cef_string_t* src_dir, const cef_string_t* dest_file, int include_hidden_files);
static cef_binary_value_t* (*cef_binary_value_create_ptr)(const void* data, size_t data_size);
static int (*cef_browser_host_create_browser_ptr)(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static cef_browser_t* (*cef_browser_host_create_browser_sync_ptr)(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static cef_command_line_t* (*cef_command_line_create_ptr)();
static cef_command_line_t* (*cef_command_line_get_global_ptr)();
static cef_cookie_manager_t* (*cef_cookie_manager_get_global_manager_ptr)(cef_completion_callback_t* callback);
static cef_cookie_manager_t* (*cef_cookie_manager_create_manager_ptr)(const cef_string_t* path, int persist_session_cookies, cef_completion_callback_t* callback);
static cef_dictionary_value_t* (*cef_dictionary_value_create_ptr)();
static cef_drag_data_t* (*cef_drag_data_create_ptr)();
static cef_image_t* (*cef_image_create_ptr)();
static cef_list_value_t* (*cef_list_value_create_ptr)();
static cef_menu_model_t* (*cef_menu_model_create_ptr)(cef_menu_model_delegate_t* delegate);
static cef_post_data_t* (*cef_post_data_create_ptr)();
static cef_post_data_element_t* (*cef_post_data_element_create_ptr)();
static cef_print_settings_t* (*cef_print_settings_create_ptr)();
static cef_process_message_t* (*cef_process_message_create_ptr)(const cef_string_t* name);
static cef_request_t* (*cef_request_create_ptr)();
static cef_request_context_t* (*cef_request_context_get_global_context_ptr)();
static cef_request_context_t* (*cef_request_context_create_context_ptr)(const cef_request_context_settings_t* settings, cef_request_context_handler_t* handler);
static cef_resource_bundle_t* (*cef_resource_bundle_get_global_ptr)();
static cef_response_t* (*cef_response_create_ptr)();
static cef_stream_reader_t* (*cef_stream_reader_create_for_file_ptr)(const cef_string_t* fileName);
static cef_stream_reader_t* (*cef_stream_reader_create_for_data_ptr)(void* data, size_t size);
static cef_stream_reader_t* (*cef_stream_reader_create_for_handler_ptr)(cef_read_handler_t* handler);
static cef_stream_writer_t* (*cef_stream_writer_create_for_file_ptr)(const cef_string_t* fileName);
static cef_stream_writer_t* (*cef_stream_writer_create_for_handler_ptr)(cef_write_handler_t* handler);
static cef_task_runner_t* (*cef_task_runner_get_for_current_thread_ptr)();
static cef_task_runner_t* (*cef_task_runner_get_for_thread_ptr)(cef_thread_id_t threadId);
static cef_thread_t* (*cef_thread_create_ptr)(const cef_string_t* display_name, cef_thread_priority_t priority, cef_message_loop_type_t message_loop_type, int stoppable, cef_com_init_mode_t com_init_mode);
static cef_urlrequest_t* (*cef_urlrequest_create_ptr)(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context);
static cef_v8context_t* (*cef_v8context_get_current_context_ptr)();
static cef_v8context_t* (*cef_v8context_get_entered_context_ptr)();
static int (*cef_v8context_in_context_ptr)();
static cef_v8stack_trace_t* (*cef_v8stack_trace_get_current_ptr)(int frame_limit);
static cef_v8value_t* (*cef_v8value_create_undefined_ptr)();
static cef_v8value_t* (*cef_v8value_create_null_ptr)();
static cef_v8value_t* (*cef_v8value_create_bool_ptr)(int value);
static cef_v8value_t* (*cef_v8value_create_int_ptr)(int32 value);
static cef_v8value_t* (*cef_v8value_create_uint_ptr)(uint32 value);
static cef_v8value_t* (*cef_v8value_create_double_ptr)(double value);
static cef_v8value_t* (*cef_v8value_create_date_ptr)(const cef_time_t* date);
static cef_v8value_t* (*cef_v8value_create_string_ptr)(const cef_string_t* value);
static cef_v8value_t* (*cef_v8value_create_object_ptr)(cef_v8accessor_t* accessor, cef_v8interceptor_t* interceptor);
static cef_v8value_t* (*cef_v8value_create_array_ptr)(int length);
static cef_v8value_t* (*cef_v8value_create_function_ptr)(const cef_string_t* name, cef_v8handler_t* handler);
static cef_value_t* (*cef_value_create_ptr)();
static cef_waitable_event_t* (*cef_waitable_event_create_ptr)(int automatic_reset, int initially_signaled);
static cef_xml_reader_t* (*cef_xml_reader_create_ptr)(cef_stream_reader_t* stream, cef_xml_encoding_type_t encodingType, const cef_string_t* URI);
static cef_zip_reader_t* (*cef_zip_reader_create_ptr)(cef_stream_reader_t* stream);
static cef_string_list_t (*cef_string_list_alloc_ptr)();
static size_t (*cef_string_list_size_ptr)(cef_string_list_t list);
static int (*cef_string_list_value_ptr)(cef_string_list_t list, size_t index, cef_string_t* value);
static void (*cef_string_list_append_ptr)(cef_string_list_t list, const cef_string_t* value);
static void (*cef_string_list_clear_ptr)(cef_string_list_t list);
static void (*cef_string_list_free_ptr)(cef_string_list_t list);
static cef_string_list_t (*cef_string_list_copy_ptr)(cef_string_list_t list);
static cef_string_map_t (*cef_string_map_alloc_ptr)();
static size_t (*cef_string_map_size_ptr)(cef_string_map_t map);
static int (*cef_string_map_find_ptr)(cef_string_map_t map, const cef_string_t* key, cef_string_t* value);
static int (*cef_string_map_key_ptr)(cef_string_map_t map, size_t index, cef_string_t* key);
static int (*cef_string_map_value_ptr)(cef_string_map_t map, size_t index, cef_string_t* value);
static int (*cef_string_map_append_ptr)(cef_string_map_t map, const cef_string_t* key, const cef_string_t* value);
static void (*cef_string_map_clear_ptr)(cef_string_map_t map);
static void (*cef_string_map_free_ptr)(cef_string_map_t map);
static cef_string_multimap_t (*cef_string_multimap_alloc_ptr)();
static size_t (*cef_string_multimap_size_ptr)(cef_string_multimap_t map);
static size_t (*cef_string_multimap_find_count_ptr)(cef_string_multimap_t map, const cef_string_t* key);
static int (*cef_string_multimap_enumerate_ptr)(cef_string_multimap_t map, const cef_string_t* key, size_t value_index, cef_string_t* value);
static int (*cef_string_multimap_key_ptr)(cef_string_multimap_t map, size_t index, cef_string_t* key);
static int (*cef_string_multimap_value_ptr)(cef_string_multimap_t map, size_t index, cef_string_t* value);
static int (*cef_string_multimap_append_ptr)(cef_string_multimap_t map, const cef_string_t* key, const cef_string_t* value);
static void (*cef_string_multimap_clear_ptr)(cef_string_multimap_t map);
static void (*cef_string_multimap_free_ptr)(cef_string_multimap_t map);

static void cfx_load_cef_function_pointers(void *libcef) {
    cef_add_cross_origin_whitelist_entry_ptr = (int (*)(const cef_string_t*, const cef_string_t*, const cef_string_t*, int))cfx_platform_get_fptr(libcef, "cef_add_cross_origin_whitelist_entry");
    cef_base64decode_ptr = (cef_binary_value_t* (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_base64decode");
    cef_base64encode_ptr = (cef_string_userfree_t (*)(const void*, size_t))cfx_platform_get_fptr(libcef, "cef_base64encode");
    cef_begin_tracing_ptr = (int (*)(const cef_string_t*, cef_completion_callback_t*))cfx_platform_get_fptr(libcef, "cef_begin_tracing");
    cef_clear_cross_origin_whitelist_ptr = (int (*)())cfx_platform_get_fptr(libcef, "cef_clear_cross_origin_whitelist");
    cef_clear_scheme_handler_factories_ptr = (int (*)())cfx_platform_get_fptr(libcef, "cef_clear_scheme_handler_factories");
    cef_crash_reporting_enabled_ptr = (int (*)())cfx_platform_get_fptr(libcef, "cef_crash_reporting_enabled");
    cef_create_context_shared_ptr = (cef_request_context_t* (*)(cef_request_context_t*, cef_request_context_handler_t*))cfx_platform_get_fptr(libcef, "cef_create_context_shared");
    cef_create_directory_ptr = (int (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_create_directory");
    cef_create_new_temp_directory_ptr = (int (*)(const cef_string_t*, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_create_new_temp_directory");
    cef_create_temp_directory_in_directory_ptr = (int (*)(const cef_string_t*, const cef_string_t*, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_create_temp_directory_in_directory");
    cef_create_url_ptr = (int (*)(const cef_urlparts_t*, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_create_url");
    cef_currently_on_ptr = (int (*)(cef_thread_id_t))cfx_platform_get_fptr(libcef, "cef_currently_on");
    cef_delete_file_ptr = (int (*)(const cef_string_t*, int))cfx_platform_get_fptr(libcef, "cef_delete_file");
    cef_directory_exists_ptr = (int (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_directory_exists");
    cef_do_message_loop_work_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_do_message_loop_work");
    cef_enable_highdpi_support_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_enable_highdpi_support");
    cef_end_tracing_ptr = (int (*)(const cef_string_t*, cef_end_tracing_callback_t*))cfx_platform_get_fptr(libcef, "cef_end_tracing");
    cef_execute_process_ptr = (int (*)(const cef_main_args_t*, cef_app_t*, void*))cfx_platform_get_fptr(libcef, "cef_execute_process");
    cef_format_url_for_security_display_ptr = (cef_string_userfree_t (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_format_url_for_security_display");
    cef_get_extensions_for_mime_type_ptr = (void (*)(const cef_string_t*, cef_string_list_t))cfx_platform_get_fptr(libcef, "cef_get_extensions_for_mime_type");
    cef_get_geolocation_ptr = (int (*)(cef_get_geolocation_callback_t*))cfx_platform_get_fptr(libcef, "cef_get_geolocation");
    cef_get_mime_type_ptr = (cef_string_userfree_t (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_get_mime_type");
    cef_get_path_ptr = (int (*)(cef_path_key_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_get_path");
    cef_get_temp_directory_ptr = (int (*)(cef_string_t*))cfx_platform_get_fptr(libcef, "cef_get_temp_directory");
    #ifdef CFX_LINUX
    cef_get_xdisplay_ptr = (XDisplay* (*)())cfx_platform_get_fptr(libcef, "cef_get_xdisplay");
    #endif
    cef_initialize_ptr = (int (*)(const cef_main_args_t*, const cef_settings_t*, cef_app_t*, void*))cfx_platform_get_fptr(libcef, "cef_initialize");
    cef_is_cert_status_error_ptr = (int (*)(cef_cert_status_t))cfx_platform_get_fptr(libcef, "cef_is_cert_status_error");
    cef_is_cert_status_minor_error_ptr = (int (*)(cef_cert_status_t))cfx_platform_get_fptr(libcef, "cef_is_cert_status_minor_error");
    cef_is_web_plugin_unstable_ptr = (void (*)(const cef_string_t*, cef_web_plugin_unstable_callback_t*))cfx_platform_get_fptr(libcef, "cef_is_web_plugin_unstable");
    cef_launch_process_ptr = (int (*)(cef_command_line_t*))cfx_platform_get_fptr(libcef, "cef_launch_process");
    cef_load_crlsets_file_ptr = (void (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_load_crlsets_file");
    cef_now_from_system_trace_time_ptr = (int64 (*)())cfx_platform_get_fptr(libcef, "cef_now_from_system_trace_time");
    cef_parse_json_ptr = (cef_value_t* (*)(const cef_string_t*, cef_json_parser_options_t))cfx_platform_get_fptr(libcef, "cef_parse_json");
    cef_parse_jsonand_return_error_ptr = (cef_value_t* (*)(const cef_string_t*, cef_json_parser_options_t, cef_json_parser_error_t*, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_parse_jsonand_return_error");
    cef_parse_url_ptr = (int (*)(const cef_string_t*, cef_urlparts_t*))cfx_platform_get_fptr(libcef, "cef_parse_url");
    cef_post_delayed_task_ptr = (int (*)(cef_thread_id_t, cef_task_t*, int64))cfx_platform_get_fptr(libcef, "cef_post_delayed_task");
    cef_post_task_ptr = (int (*)(cef_thread_id_t, cef_task_t*))cfx_platform_get_fptr(libcef, "cef_post_task");
    cef_quit_message_loop_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_quit_message_loop");
    cef_refresh_web_plugins_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_refresh_web_plugins");
    cef_register_extension_ptr = (int (*)(const cef_string_t*, const cef_string_t*, cef_v8handler_t*))cfx_platform_get_fptr(libcef, "cef_register_extension");
    cef_register_scheme_handler_factory_ptr = (int (*)(const cef_string_t*, const cef_string_t*, cef_scheme_handler_factory_t*))cfx_platform_get_fptr(libcef, "cef_register_scheme_handler_factory");
    cef_register_web_plugin_crash_ptr = (void (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_register_web_plugin_crash");
    cef_register_widevine_cdm_ptr = (void (*)(const cef_string_t*, cef_register_cdm_callback_t*))cfx_platform_get_fptr(libcef, "cef_register_widevine_cdm");
    cef_remove_cross_origin_whitelist_entry_ptr = (int (*)(const cef_string_t*, const cef_string_t*, const cef_string_t*, int))cfx_platform_get_fptr(libcef, "cef_remove_cross_origin_whitelist_entry");
    cef_run_message_loop_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_run_message_loop");
    cef_set_crash_key_value_ptr = (void (*)(const cef_string_t*, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_set_crash_key_value");
    cef_set_osmodal_loop_ptr = (void (*)(int))cfx_platform_get_fptr(libcef, "cef_set_osmodal_loop");
    cef_shutdown_ptr = (void (*)())cfx_platform_get_fptr(libcef, "cef_shutdown");
    cef_unregister_internal_web_plugin_ptr = (void (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_unregister_internal_web_plugin");
    cef_uridecode_ptr = (cef_string_userfree_t (*)(const cef_string_t*, int, cef_uri_unescape_rule_t))cfx_platform_get_fptr(libcef, "cef_uridecode");
    cef_uriencode_ptr = (cef_string_userfree_t (*)(const cef_string_t*, int))cfx_platform_get_fptr(libcef, "cef_uriencode");
    cef_version_info_ptr = (int (*)(int))cfx_platform_get_fptr(libcef, "cef_version_info");
    cef_visit_web_plugin_info_ptr = (void (*)(cef_web_plugin_info_visitor_t*))cfx_platform_get_fptr(libcef, "cef_visit_web_plugin_info");
    cef_write_json_ptr = (cef_string_userfree_t (*)(cef_value_t*, cef_json_writer_options_t))cfx_platform_get_fptr(libcef, "cef_write_json");
    cef_zip_directory_ptr = (int (*)(const cef_string_t*, const cef_string_t*, int))cfx_platform_get_fptr(libcef, "cef_zip_directory");
    cef_binary_value_create_ptr = (cef_binary_value_t* (*)(const void*, size_t))cfx_platform_get_fptr(libcef, "cef_binary_value_create");
    cef_browser_host_create_browser_ptr = (int (*)(const cef_window_info_t*, cef_client_t*, const cef_string_t*, const cef_browser_settings_t*, cef_request_context_t*))cfx_platform_get_fptr(libcef, "cef_browser_host_create_browser");
    cef_browser_host_create_browser_sync_ptr = (cef_browser_t* (*)(const cef_window_info_t*, cef_client_t*, const cef_string_t*, const cef_browser_settings_t*, cef_request_context_t*))cfx_platform_get_fptr(libcef, "cef_browser_host_create_browser_sync");
    cef_command_line_create_ptr = (cef_command_line_t* (*)())cfx_platform_get_fptr(libcef, "cef_command_line_create");
    cef_command_line_get_global_ptr = (cef_command_line_t* (*)())cfx_platform_get_fptr(libcef, "cef_command_line_get_global");
    cef_cookie_manager_get_global_manager_ptr = (cef_cookie_manager_t* (*)(cef_completion_callback_t*))cfx_platform_get_fptr(libcef, "cef_cookie_manager_get_global_manager");
    cef_cookie_manager_create_manager_ptr = (cef_cookie_manager_t* (*)(const cef_string_t*, int, cef_completion_callback_t*))cfx_platform_get_fptr(libcef, "cef_cookie_manager_create_manager");
    cef_dictionary_value_create_ptr = (cef_dictionary_value_t* (*)())cfx_platform_get_fptr(libcef, "cef_dictionary_value_create");
    cef_drag_data_create_ptr = (cef_drag_data_t* (*)())cfx_platform_get_fptr(libcef, "cef_drag_data_create");
    cef_image_create_ptr = (cef_image_t* (*)())cfx_platform_get_fptr(libcef, "cef_image_create");
    cef_list_value_create_ptr = (cef_list_value_t* (*)())cfx_platform_get_fptr(libcef, "cef_list_value_create");
    cef_menu_model_create_ptr = (cef_menu_model_t* (*)(cef_menu_model_delegate_t*))cfx_platform_get_fptr(libcef, "cef_menu_model_create");
    cef_post_data_create_ptr = (cef_post_data_t* (*)())cfx_platform_get_fptr(libcef, "cef_post_data_create");
    cef_post_data_element_create_ptr = (cef_post_data_element_t* (*)())cfx_platform_get_fptr(libcef, "cef_post_data_element_create");
    cef_print_settings_create_ptr = (cef_print_settings_t* (*)())cfx_platform_get_fptr(libcef, "cef_print_settings_create");
    cef_process_message_create_ptr = (cef_process_message_t* (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_process_message_create");
    cef_request_create_ptr = (cef_request_t* (*)())cfx_platform_get_fptr(libcef, "cef_request_create");
    cef_request_context_get_global_context_ptr = (cef_request_context_t* (*)())cfx_platform_get_fptr(libcef, "cef_request_context_get_global_context");
    cef_request_context_create_context_ptr = (cef_request_context_t* (*)(const cef_request_context_settings_t*, cef_request_context_handler_t*))cfx_platform_get_fptr(libcef, "cef_request_context_create_context");
    cef_resource_bundle_get_global_ptr = (cef_resource_bundle_t* (*)())cfx_platform_get_fptr(libcef, "cef_resource_bundle_get_global");
    cef_response_create_ptr = (cef_response_t* (*)())cfx_platform_get_fptr(libcef, "cef_response_create");
    cef_stream_reader_create_for_file_ptr = (cef_stream_reader_t* (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_stream_reader_create_for_file");
    cef_stream_reader_create_for_data_ptr = (cef_stream_reader_t* (*)(void*, size_t))cfx_platform_get_fptr(libcef, "cef_stream_reader_create_for_data");
    cef_stream_reader_create_for_handler_ptr = (cef_stream_reader_t* (*)(cef_read_handler_t*))cfx_platform_get_fptr(libcef, "cef_stream_reader_create_for_handler");
    cef_stream_writer_create_for_file_ptr = (cef_stream_writer_t* (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_stream_writer_create_for_file");
    cef_stream_writer_create_for_handler_ptr = (cef_stream_writer_t* (*)(cef_write_handler_t*))cfx_platform_get_fptr(libcef, "cef_stream_writer_create_for_handler");
    cef_task_runner_get_for_current_thread_ptr = (cef_task_runner_t* (*)())cfx_platform_get_fptr(libcef, "cef_task_runner_get_for_current_thread");
    cef_task_runner_get_for_thread_ptr = (cef_task_runner_t* (*)(cef_thread_id_t))cfx_platform_get_fptr(libcef, "cef_task_runner_get_for_thread");
    cef_thread_create_ptr = (cef_thread_t* (*)(const cef_string_t*, cef_thread_priority_t, cef_message_loop_type_t, int, cef_com_init_mode_t))cfx_platform_get_fptr(libcef, "cef_thread_create");
    cef_urlrequest_create_ptr = (cef_urlrequest_t* (*)(cef_request_t*, cef_urlrequest_client_t*, cef_request_context_t*))cfx_platform_get_fptr(libcef, "cef_urlrequest_create");
    cef_v8context_get_current_context_ptr = (cef_v8context_t* (*)())cfx_platform_get_fptr(libcef, "cef_v8context_get_current_context");
    cef_v8context_get_entered_context_ptr = (cef_v8context_t* (*)())cfx_platform_get_fptr(libcef, "cef_v8context_get_entered_context");
    cef_v8context_in_context_ptr = (int (*)())cfx_platform_get_fptr(libcef, "cef_v8context_in_context");
    cef_v8stack_trace_get_current_ptr = (cef_v8stack_trace_t* (*)(int))cfx_platform_get_fptr(libcef, "cef_v8stack_trace_get_current");
    cef_v8value_create_undefined_ptr = (cef_v8value_t* (*)())cfx_platform_get_fptr(libcef, "cef_v8value_create_undefined");
    cef_v8value_create_null_ptr = (cef_v8value_t* (*)())cfx_platform_get_fptr(libcef, "cef_v8value_create_null");
    cef_v8value_create_bool_ptr = (cef_v8value_t* (*)(int))cfx_platform_get_fptr(libcef, "cef_v8value_create_bool");
    cef_v8value_create_int_ptr = (cef_v8value_t* (*)(int32))cfx_platform_get_fptr(libcef, "cef_v8value_create_int");
    cef_v8value_create_uint_ptr = (cef_v8value_t* (*)(uint32))cfx_platform_get_fptr(libcef, "cef_v8value_create_uint");
    cef_v8value_create_double_ptr = (cef_v8value_t* (*)(double))cfx_platform_get_fptr(libcef, "cef_v8value_create_double");
    cef_v8value_create_date_ptr = (cef_v8value_t* (*)(const cef_time_t*))cfx_platform_get_fptr(libcef, "cef_v8value_create_date");
    cef_v8value_create_string_ptr = (cef_v8value_t* (*)(const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_v8value_create_string");
    cef_v8value_create_object_ptr = (cef_v8value_t* (*)(cef_v8accessor_t*, cef_v8interceptor_t*))cfx_platform_get_fptr(libcef, "cef_v8value_create_object");
    cef_v8value_create_array_ptr = (cef_v8value_t* (*)(int))cfx_platform_get_fptr(libcef, "cef_v8value_create_array");
    cef_v8value_create_function_ptr = (cef_v8value_t* (*)(const cef_string_t*, cef_v8handler_t*))cfx_platform_get_fptr(libcef, "cef_v8value_create_function");
    cef_value_create_ptr = (cef_value_t* (*)())cfx_platform_get_fptr(libcef, "cef_value_create");
    cef_waitable_event_create_ptr = (cef_waitable_event_t* (*)(int, int))cfx_platform_get_fptr(libcef, "cef_waitable_event_create");
    cef_xml_reader_create_ptr = (cef_xml_reader_t* (*)(cef_stream_reader_t*, cef_xml_encoding_type_t, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_xml_reader_create");
    cef_zip_reader_create_ptr = (cef_zip_reader_t* (*)(cef_stream_reader_t*))cfx_platform_get_fptr(libcef, "cef_zip_reader_create");
    cef_string_list_alloc_ptr = (cef_string_list_t (*)())cfx_platform_get_fptr(libcef, "cef_string_list_alloc");
    cef_string_list_size_ptr = (size_t (*)(cef_string_list_t))cfx_platform_get_fptr(libcef, "cef_string_list_size");
    cef_string_list_value_ptr = (int (*)(cef_string_list_t, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_list_value");
    cef_string_list_append_ptr = (void (*)(cef_string_list_t, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_list_append");
    cef_string_list_clear_ptr = (void (*)(cef_string_list_t))cfx_platform_get_fptr(libcef, "cef_string_list_clear");
    cef_string_list_free_ptr = (void (*)(cef_string_list_t))cfx_platform_get_fptr(libcef, "cef_string_list_free");
    cef_string_list_copy_ptr = (cef_string_list_t (*)(cef_string_list_t))cfx_platform_get_fptr(libcef, "cef_string_list_copy");
    cef_string_map_alloc_ptr = (cef_string_map_t (*)())cfx_platform_get_fptr(libcef, "cef_string_map_alloc");
    cef_string_map_size_ptr = (size_t (*)(cef_string_map_t))cfx_platform_get_fptr(libcef, "cef_string_map_size");
    cef_string_map_find_ptr = (int (*)(cef_string_map_t, const cef_string_t*, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_map_find");
    cef_string_map_key_ptr = (int (*)(cef_string_map_t, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_map_key");
    cef_string_map_value_ptr = (int (*)(cef_string_map_t, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_map_value");
    cef_string_map_append_ptr = (int (*)(cef_string_map_t, const cef_string_t*, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_map_append");
    cef_string_map_clear_ptr = (void (*)(cef_string_map_t))cfx_platform_get_fptr(libcef, "cef_string_map_clear");
    cef_string_map_free_ptr = (void (*)(cef_string_map_t))cfx_platform_get_fptr(libcef, "cef_string_map_free");
    cef_string_multimap_alloc_ptr = (cef_string_multimap_t (*)())cfx_platform_get_fptr(libcef, "cef_string_multimap_alloc");
    cef_string_multimap_size_ptr = (size_t (*)(cef_string_multimap_t))cfx_platform_get_fptr(libcef, "cef_string_multimap_size");
    cef_string_multimap_find_count_ptr = (size_t (*)(cef_string_multimap_t, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_multimap_find_count");
    cef_string_multimap_enumerate_ptr = (int (*)(cef_string_multimap_t, const cef_string_t*, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_multimap_enumerate");
    cef_string_multimap_key_ptr = (int (*)(cef_string_multimap_t, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_multimap_key");
    cef_string_multimap_value_ptr = (int (*)(cef_string_multimap_t, size_t, cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_multimap_value");
    cef_string_multimap_append_ptr = (int (*)(cef_string_multimap_t, const cef_string_t*, const cef_string_t*))cfx_platform_get_fptr(libcef, "cef_string_multimap_append");
    cef_string_multimap_clear_ptr = (void (*)(cef_string_multimap_t))cfx_platform_get_fptr(libcef, "cef_string_multimap_clear");
    cef_string_multimap_free_ptr = (void (*)(cef_string_multimap_t))cfx_platform_get_fptr(libcef, "cef_string_multimap_free");
}

#define cef_add_cross_origin_whitelist_entry cef_add_cross_origin_whitelist_entry_ptr
#define cef_api_hash cef_api_hash_ptr
#define cef_base64decode cef_base64decode_ptr
#define cef_base64encode cef_base64encode_ptr
#define cef_begin_tracing cef_begin_tracing_ptr
#define cef_clear_cross_origin_whitelist cef_clear_cross_origin_whitelist_ptr
#define cef_clear_scheme_handler_factories cef_clear_scheme_handler_factories_ptr
#define cef_crash_reporting_enabled cef_crash_reporting_enabled_ptr
#define cef_create_context_shared cef_create_context_shared_ptr
#define cef_create_directory cef_create_directory_ptr
#define cef_create_new_temp_directory cef_create_new_temp_directory_ptr
#define cef_create_temp_directory_in_directory cef_create_temp_directory_in_directory_ptr
#define cef_create_url cef_create_url_ptr
#define cef_currently_on cef_currently_on_ptr
#define cef_delete_file cef_delete_file_ptr
#define cef_directory_exists cef_directory_exists_ptr
#define cef_do_message_loop_work cef_do_message_loop_work_ptr
#define cef_enable_highdpi_support cef_enable_highdpi_support_ptr
#define cef_end_tracing cef_end_tracing_ptr
#define cef_execute_process cef_execute_process_ptr
#define cef_format_url_for_security_display cef_format_url_for_security_display_ptr
#define cef_get_extensions_for_mime_type cef_get_extensions_for_mime_type_ptr
#define cef_get_geolocation cef_get_geolocation_ptr
#define cef_get_mime_type cef_get_mime_type_ptr
#define cef_get_path cef_get_path_ptr
#define cef_get_temp_directory cef_get_temp_directory_ptr
#ifdef CFX_LINUX
#define cef_get_xdisplay cef_get_xdisplay_ptr
#endif
#define cef_initialize cef_initialize_ptr
#define cef_is_cert_status_error cef_is_cert_status_error_ptr
#define cef_is_cert_status_minor_error cef_is_cert_status_minor_error_ptr
#define cef_is_web_plugin_unstable cef_is_web_plugin_unstable_ptr
#define cef_launch_process cef_launch_process_ptr
#define cef_load_crlsets_file cef_load_crlsets_file_ptr
#define cef_now_from_system_trace_time cef_now_from_system_trace_time_ptr
#define cef_parse_json cef_parse_json_ptr
#define cef_parse_jsonand_return_error cef_parse_jsonand_return_error_ptr
#define cef_parse_url cef_parse_url_ptr
#define cef_post_delayed_task cef_post_delayed_task_ptr
#define cef_post_task cef_post_task_ptr
#define cef_quit_message_loop cef_quit_message_loop_ptr
#define cef_refresh_web_plugins cef_refresh_web_plugins_ptr
#define cef_register_extension cef_register_extension_ptr
#define cef_register_scheme_handler_factory cef_register_scheme_handler_factory_ptr
#define cef_register_web_plugin_crash cef_register_web_plugin_crash_ptr
#define cef_register_widevine_cdm cef_register_widevine_cdm_ptr
#define cef_remove_cross_origin_whitelist_entry cef_remove_cross_origin_whitelist_entry_ptr
#define cef_run_message_loop cef_run_message_loop_ptr
#define cef_set_crash_key_value cef_set_crash_key_value_ptr
#define cef_set_osmodal_loop cef_set_osmodal_loop_ptr
#define cef_shutdown cef_shutdown_ptr
#define cef_unregister_internal_web_plugin cef_unregister_internal_web_plugin_ptr
#define cef_uridecode cef_uridecode_ptr
#define cef_uriencode cef_uriencode_ptr
#define cef_version_info cef_version_info_ptr
#define cef_visit_web_plugin_info cef_visit_web_plugin_info_ptr
#define cef_write_json cef_write_json_ptr
#define cef_zip_directory cef_zip_directory_ptr
#define cef_binary_value_create cef_binary_value_create_ptr
#define cef_browser_host_create_browser cef_browser_host_create_browser_ptr
#define cef_browser_host_create_browser_sync cef_browser_host_create_browser_sync_ptr
#define cef_command_line_create cef_command_line_create_ptr
#define cef_command_line_get_global cef_command_line_get_global_ptr
#define cef_cookie_manager_get_global_manager cef_cookie_manager_get_global_manager_ptr
#define cef_cookie_manager_create_manager cef_cookie_manager_create_manager_ptr
#define cef_dictionary_value_create cef_dictionary_value_create_ptr
#define cef_drag_data_create cef_drag_data_create_ptr
#define cef_image_create cef_image_create_ptr
#define cef_list_value_create cef_list_value_create_ptr
#define cef_menu_model_create cef_menu_model_create_ptr
#define cef_post_data_create cef_post_data_create_ptr
#define cef_post_data_element_create cef_post_data_element_create_ptr
#define cef_print_settings_create cef_print_settings_create_ptr
#define cef_process_message_create cef_process_message_create_ptr
#define cef_request_create cef_request_create_ptr
#define cef_request_context_get_global_context cef_request_context_get_global_context_ptr
#define cef_request_context_create_context cef_request_context_create_context_ptr
#define cef_resource_bundle_get_global cef_resource_bundle_get_global_ptr
#define cef_response_create cef_response_create_ptr
#define cef_stream_reader_create_for_file cef_stream_reader_create_for_file_ptr
#define cef_stream_reader_create_for_data cef_stream_reader_create_for_data_ptr
#define cef_stream_reader_create_for_handler cef_stream_reader_create_for_handler_ptr
#define cef_stream_writer_create_for_file cef_stream_writer_create_for_file_ptr
#define cef_stream_writer_create_for_handler cef_stream_writer_create_for_handler_ptr
#define cef_task_runner_get_for_current_thread cef_task_runner_get_for_current_thread_ptr
#define cef_task_runner_get_for_thread cef_task_runner_get_for_thread_ptr
#define cef_thread_create cef_thread_create_ptr
#define cef_urlrequest_create cef_urlrequest_create_ptr
#define cef_v8context_get_current_context cef_v8context_get_current_context_ptr
#define cef_v8context_get_entered_context cef_v8context_get_entered_context_ptr
#define cef_v8context_in_context cef_v8context_in_context_ptr
#define cef_v8stack_trace_get_current cef_v8stack_trace_get_current_ptr
#define cef_v8value_create_undefined cef_v8value_create_undefined_ptr
#define cef_v8value_create_null cef_v8value_create_null_ptr
#define cef_v8value_create_bool cef_v8value_create_bool_ptr
#define cef_v8value_create_int cef_v8value_create_int_ptr
#define cef_v8value_create_uint cef_v8value_create_uint_ptr
#define cef_v8value_create_double cef_v8value_create_double_ptr
#define cef_v8value_create_date cef_v8value_create_date_ptr
#define cef_v8value_create_string cef_v8value_create_string_ptr
#define cef_v8value_create_object cef_v8value_create_object_ptr
#define cef_v8value_create_array cef_v8value_create_array_ptr
#define cef_v8value_create_function cef_v8value_create_function_ptr
#define cef_value_create cef_value_create_ptr
#define cef_waitable_event_create cef_waitable_event_create_ptr
#define cef_xml_reader_create cef_xml_reader_create_ptr
#define cef_zip_reader_create cef_zip_reader_create_ptr
#define cef_string_list_alloc cef_string_list_alloc_ptr
#define cef_string_list_size cef_string_list_size_ptr
#define cef_string_list_value cef_string_list_value_ptr
#define cef_string_list_append cef_string_list_append_ptr
#define cef_string_list_clear cef_string_list_clear_ptr
#define cef_string_list_free cef_string_list_free_ptr
#define cef_string_list_copy cef_string_list_copy_ptr
#define cef_string_map_alloc cef_string_map_alloc_ptr
#define cef_string_map_size cef_string_map_size_ptr
#define cef_string_map_find cef_string_map_find_ptr
#define cef_string_map_key cef_string_map_key_ptr
#define cef_string_map_value cef_string_map_value_ptr
#define cef_string_map_append cef_string_map_append_ptr
#define cef_string_map_clear cef_string_map_clear_ptr
#define cef_string_map_free cef_string_map_free_ptr
#define cef_string_multimap_alloc cef_string_multimap_alloc_ptr
#define cef_string_multimap_size cef_string_multimap_size_ptr
#define cef_string_multimap_find_count cef_string_multimap_find_count_ptr
#define cef_string_multimap_enumerate cef_string_multimap_enumerate_ptr
#define cef_string_multimap_key cef_string_multimap_key_ptr
#define cef_string_multimap_value cef_string_multimap_value_ptr
#define cef_string_multimap_append cef_string_multimap_append_ptr
#define cef_string_multimap_clear cef_string_multimap_clear_ptr
#define cef_string_multimap_free cef_string_multimap_free_ptr

