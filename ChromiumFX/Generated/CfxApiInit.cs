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


using System.Runtime.InteropServices;

using System;

namespace Chromium {
    internal partial class CfxApi {
        private static void InitializeDelegates() {

            cfx_add_cross_origin_whitelist_entry = (cfx_add_cross_origin_whitelist_entry_delegate)GetDelegate(libcfxPtr, "cfx_add_cross_origin_whitelist_entry", typeof(cfx_add_cross_origin_whitelist_entry_delegate));
            cfx_add_web_plugin_directory = (cfx_add_web_plugin_directory_delegate)GetDelegate(libcfxPtr, "cfx_add_web_plugin_directory", typeof(cfx_add_web_plugin_directory_delegate));
            cfx_add_web_plugin_path = (cfx_add_web_plugin_path_delegate)GetDelegate(libcfxPtr, "cfx_add_web_plugin_path", typeof(cfx_add_web_plugin_path_delegate));
            cfx_begin_tracing = (cfx_begin_tracing_delegate)GetDelegate(libcfxPtr, "cfx_begin_tracing", typeof(cfx_begin_tracing_delegate));
            cfx_clear_cross_origin_whitelist = (cfx_clear_cross_origin_whitelist_delegate)GetDelegate(libcfxPtr, "cfx_clear_cross_origin_whitelist", typeof(cfx_clear_cross_origin_whitelist_delegate));
            cfx_clear_scheme_handler_factories = (cfx_clear_scheme_handler_factories_delegate)GetDelegate(libcfxPtr, "cfx_clear_scheme_handler_factories", typeof(cfx_clear_scheme_handler_factories_delegate));
            cfx_create_url = (cfx_create_url_delegate)GetDelegate(libcfxPtr, "cfx_create_url", typeof(cfx_create_url_delegate));
            cfx_currently_on = (cfx_currently_on_delegate)GetDelegate(libcfxPtr, "cfx_currently_on", typeof(cfx_currently_on_delegate));
            cfx_do_message_loop_work = (cfx_do_message_loop_work_delegate)GetDelegate(libcfxPtr, "cfx_do_message_loop_work", typeof(cfx_do_message_loop_work_delegate));
            cfx_end_tracing_async = (cfx_end_tracing_async_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_async", typeof(cfx_end_tracing_async_delegate));
            cfx_execute_process = (cfx_execute_process_delegate)GetDelegate(libcfxPtr, "cfx_execute_process", typeof(cfx_execute_process_delegate));
            cfx_force_web_plugin_shutdown = (cfx_force_web_plugin_shutdown_delegate)GetDelegate(libcfxPtr, "cfx_force_web_plugin_shutdown", typeof(cfx_force_web_plugin_shutdown_delegate));
            cfx_get_geolocation = (cfx_get_geolocation_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation", typeof(cfx_get_geolocation_delegate));
            cfx_get_mime_type = (cfx_get_mime_type_delegate)GetDelegate(libcfxPtr, "cfx_get_mime_type", typeof(cfx_get_mime_type_delegate));
            cfx_get_path = (cfx_get_path_delegate)GetDelegate(libcfxPtr, "cfx_get_path", typeof(cfx_get_path_delegate));
            cfx_initialize = (cfx_initialize_delegate)GetDelegate(libcfxPtr, "cfx_initialize", typeof(cfx_initialize_delegate));
            cfx_is_web_plugin_unstable = (cfx_is_web_plugin_unstable_delegate)GetDelegate(libcfxPtr, "cfx_is_web_plugin_unstable", typeof(cfx_is_web_plugin_unstable_delegate));
            cfx_launch_process = (cfx_launch_process_delegate)GetDelegate(libcfxPtr, "cfx_launch_process", typeof(cfx_launch_process_delegate));
            cfx_now_from_system_trace_time = (cfx_now_from_system_trace_time_delegate)GetDelegate(libcfxPtr, "cfx_now_from_system_trace_time", typeof(cfx_now_from_system_trace_time_delegate));
            cfx_parse_url = (cfx_parse_url_delegate)GetDelegate(libcfxPtr, "cfx_parse_url", typeof(cfx_parse_url_delegate));
            cfx_post_delayed_task = (cfx_post_delayed_task_delegate)GetDelegate(libcfxPtr, "cfx_post_delayed_task", typeof(cfx_post_delayed_task_delegate));
            cfx_post_task = (cfx_post_task_delegate)GetDelegate(libcfxPtr, "cfx_post_task", typeof(cfx_post_task_delegate));
            cfx_quit_message_loop = (cfx_quit_message_loop_delegate)GetDelegate(libcfxPtr, "cfx_quit_message_loop", typeof(cfx_quit_message_loop_delegate));
            cfx_refresh_web_plugins = (cfx_refresh_web_plugins_delegate)GetDelegate(libcfxPtr, "cfx_refresh_web_plugins", typeof(cfx_refresh_web_plugins_delegate));
            cfx_register_extension = (cfx_register_extension_delegate)GetDelegate(libcfxPtr, "cfx_register_extension", typeof(cfx_register_extension_delegate));
            cfx_register_scheme_handler_factory = (cfx_register_scheme_handler_factory_delegate)GetDelegate(libcfxPtr, "cfx_register_scheme_handler_factory", typeof(cfx_register_scheme_handler_factory_delegate));
            cfx_register_web_plugin_crash = (cfx_register_web_plugin_crash_delegate)GetDelegate(libcfxPtr, "cfx_register_web_plugin_crash", typeof(cfx_register_web_plugin_crash_delegate));
            cfx_remove_cross_origin_whitelist_entry = (cfx_remove_cross_origin_whitelist_entry_delegate)GetDelegate(libcfxPtr, "cfx_remove_cross_origin_whitelist_entry", typeof(cfx_remove_cross_origin_whitelist_entry_delegate));
            cfx_remove_web_plugin_path = (cfx_remove_web_plugin_path_delegate)GetDelegate(libcfxPtr, "cfx_remove_web_plugin_path", typeof(cfx_remove_web_plugin_path_delegate));
            cfx_run_message_loop = (cfx_run_message_loop_delegate)GetDelegate(libcfxPtr, "cfx_run_message_loop", typeof(cfx_run_message_loop_delegate));
            cfx_set_osmodal_loop = (cfx_set_osmodal_loop_delegate)GetDelegate(libcfxPtr, "cfx_set_osmodal_loop", typeof(cfx_set_osmodal_loop_delegate));
            cfx_shutdown = (cfx_shutdown_delegate)GetDelegate(libcfxPtr, "cfx_shutdown", typeof(cfx_shutdown_delegate));
            cfx_unregister_internal_web_plugin = (cfx_unregister_internal_web_plugin_delegate)GetDelegate(libcfxPtr, "cfx_unregister_internal_web_plugin", typeof(cfx_unregister_internal_web_plugin_delegate));
            cfx_visit_web_plugin_info = (cfx_visit_web_plugin_info_delegate)GetDelegate(libcfxPtr, "cfx_visit_web_plugin_info", typeof(cfx_visit_web_plugin_info_delegate));
            cfx_string_list_alloc = (cfx_string_list_alloc_delegate)GetDelegate(libcfxPtr, "cfx_string_list_alloc", typeof(cfx_string_list_alloc_delegate));
            cfx_string_list_size = (cfx_string_list_size_delegate)GetDelegate(libcfxPtr, "cfx_string_list_size", typeof(cfx_string_list_size_delegate));
            cfx_string_list_value = (cfx_string_list_value_delegate)GetDelegate(libcfxPtr, "cfx_string_list_value", typeof(cfx_string_list_value_delegate));
            cfx_string_list_append = (cfx_string_list_append_delegate)GetDelegate(libcfxPtr, "cfx_string_list_append", typeof(cfx_string_list_append_delegate));
            cfx_string_list_clear = (cfx_string_list_clear_delegate)GetDelegate(libcfxPtr, "cfx_string_list_clear", typeof(cfx_string_list_clear_delegate));
            cfx_string_list_free = (cfx_string_list_free_delegate)GetDelegate(libcfxPtr, "cfx_string_list_free", typeof(cfx_string_list_free_delegate));
            cfx_string_list_copy = (cfx_string_list_copy_delegate)GetDelegate(libcfxPtr, "cfx_string_list_copy", typeof(cfx_string_list_copy_delegate));

            cfx_string_map_alloc = (cfx_string_map_alloc_delegate)GetDelegate(libcfxPtr, "cfx_string_map_alloc", typeof(cfx_string_map_alloc_delegate));
            cfx_string_map_size = (cfx_string_map_size_delegate)GetDelegate(libcfxPtr, "cfx_string_map_size", typeof(cfx_string_map_size_delegate));
            cfx_string_map_find = (cfx_string_map_find_delegate)GetDelegate(libcfxPtr, "cfx_string_map_find", typeof(cfx_string_map_find_delegate));
            cfx_string_map_key = (cfx_string_map_key_delegate)GetDelegate(libcfxPtr, "cfx_string_map_key", typeof(cfx_string_map_key_delegate));
            cfx_string_map_value = (cfx_string_map_value_delegate)GetDelegate(libcfxPtr, "cfx_string_map_value", typeof(cfx_string_map_value_delegate));
            cfx_string_map_append = (cfx_string_map_append_delegate)GetDelegate(libcfxPtr, "cfx_string_map_append", typeof(cfx_string_map_append_delegate));
            cfx_string_map_clear = (cfx_string_map_clear_delegate)GetDelegate(libcfxPtr, "cfx_string_map_clear", typeof(cfx_string_map_clear_delegate));
            cfx_string_map_free = (cfx_string_map_free_delegate)GetDelegate(libcfxPtr, "cfx_string_map_free", typeof(cfx_string_map_free_delegate));

            cfx_string_multimap_alloc = (cfx_string_multimap_alloc_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_alloc", typeof(cfx_string_multimap_alloc_delegate));
            cfx_string_multimap_size = (cfx_string_multimap_size_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_size", typeof(cfx_string_multimap_size_delegate));
            cfx_string_multimap_find_count = (cfx_string_multimap_find_count_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_find_count", typeof(cfx_string_multimap_find_count_delegate));
            cfx_string_multimap_enumerate = (cfx_string_multimap_enumerate_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_enumerate", typeof(cfx_string_multimap_enumerate_delegate));
            cfx_string_multimap_key = (cfx_string_multimap_key_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_key", typeof(cfx_string_multimap_key_delegate));
            cfx_string_multimap_value = (cfx_string_multimap_value_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_value", typeof(cfx_string_multimap_value_delegate));
            cfx_string_multimap_append = (cfx_string_multimap_append_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_append", typeof(cfx_string_multimap_append_delegate));
            cfx_string_multimap_clear = (cfx_string_multimap_clear_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_clear", typeof(cfx_string_multimap_clear_delegate));
            cfx_string_multimap_free = (cfx_string_multimap_free_delegate)GetDelegate(libcfxPtr, "cfx_string_multimap_free", typeof(cfx_string_multimap_free_delegate));



            // cef_allow_certificate_error_callback

            cfx_allow_certificate_error_callback_cont = (cfx_allow_certificate_error_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_allow_certificate_error_callback_cont", typeof(cfx_allow_certificate_error_callback_cont_delegate));


            // cef_app

            cfx_app_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_app_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_app_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_app_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_app_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_app_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_app_on_before_command_line_processing = CfxApp.on_before_command_line_processing;
            cfx_app_on_register_custom_schemes = CfxApp.on_register_custom_schemes;
            cfx_app_get_resource_bundle_handler = CfxApp.get_resource_bundle_handler;
            cfx_app_get_browser_process_handler = CfxApp.get_browser_process_handler;
            cfx_app_get_render_process_handler = CfxApp.get_render_process_handler;

            var cfx_app_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_app_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_app_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_app_on_before_command_line_processing),
                Marshal.GetFunctionPointerForDelegate(cfx_app_on_register_custom_schemes),
                Marshal.GetFunctionPointerForDelegate(cfx_app_get_resource_bundle_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_app_get_browser_process_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_app_get_render_process_handler)
            );


            // cef_auth_callback

            cfx_auth_callback_cont = (cfx_auth_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_auth_callback_cont", typeof(cfx_auth_callback_cont_delegate));
            cfx_auth_callback_cancel = (cfx_auth_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_auth_callback_cancel", typeof(cfx_auth_callback_cancel_delegate));


            // cef_before_download_callback

            cfx_before_download_callback_cont = (cfx_before_download_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_before_download_callback_cont", typeof(cfx_before_download_callback_cont_delegate));


            // cef_binary_value

            cfx_binary_value_create = (cfx_binary_value_create_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_create", typeof(cfx_binary_value_create_delegate));

            cfx_binary_value_is_valid = (cfx_binary_value_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_is_valid", typeof(cfx_binary_value_is_valid_delegate));
            cfx_binary_value_is_owned = (cfx_binary_value_is_owned_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_is_owned", typeof(cfx_binary_value_is_owned_delegate));
            cfx_binary_value_copy = (cfx_binary_value_copy_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_copy", typeof(cfx_binary_value_copy_delegate));
            cfx_binary_value_get_size = (cfx_binary_value_get_size_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_get_size", typeof(cfx_binary_value_get_size_delegate));
            cfx_binary_value_get_data = (cfx_binary_value_get_data_delegate)GetDelegate(libcfxPtr, "cfx_binary_value_get_data", typeof(cfx_binary_value_get_data_delegate));


            // cef_browser

            cfx_browser_get_host = (cfx_browser_get_host_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_host", typeof(cfx_browser_get_host_delegate));
            cfx_browser_can_go_back = (cfx_browser_can_go_back_delegate)GetDelegate(libcfxPtr, "cfx_browser_can_go_back", typeof(cfx_browser_can_go_back_delegate));
            cfx_browser_go_back = (cfx_browser_go_back_delegate)GetDelegate(libcfxPtr, "cfx_browser_go_back", typeof(cfx_browser_go_back_delegate));
            cfx_browser_can_go_forward = (cfx_browser_can_go_forward_delegate)GetDelegate(libcfxPtr, "cfx_browser_can_go_forward", typeof(cfx_browser_can_go_forward_delegate));
            cfx_browser_go_forward = (cfx_browser_go_forward_delegate)GetDelegate(libcfxPtr, "cfx_browser_go_forward", typeof(cfx_browser_go_forward_delegate));
            cfx_browser_is_loading = (cfx_browser_is_loading_delegate)GetDelegate(libcfxPtr, "cfx_browser_is_loading", typeof(cfx_browser_is_loading_delegate));
            cfx_browser_reload = (cfx_browser_reload_delegate)GetDelegate(libcfxPtr, "cfx_browser_reload", typeof(cfx_browser_reload_delegate));
            cfx_browser_reload_ignore_cache = (cfx_browser_reload_ignore_cache_delegate)GetDelegate(libcfxPtr, "cfx_browser_reload_ignore_cache", typeof(cfx_browser_reload_ignore_cache_delegate));
            cfx_browser_stop_load = (cfx_browser_stop_load_delegate)GetDelegate(libcfxPtr, "cfx_browser_stop_load", typeof(cfx_browser_stop_load_delegate));
            cfx_browser_get_identifier = (cfx_browser_get_identifier_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_identifier", typeof(cfx_browser_get_identifier_delegate));
            cfx_browser_is_same = (cfx_browser_is_same_delegate)GetDelegate(libcfxPtr, "cfx_browser_is_same", typeof(cfx_browser_is_same_delegate));
            cfx_browser_is_popup = (cfx_browser_is_popup_delegate)GetDelegate(libcfxPtr, "cfx_browser_is_popup", typeof(cfx_browser_is_popup_delegate));
            cfx_browser_has_document = (cfx_browser_has_document_delegate)GetDelegate(libcfxPtr, "cfx_browser_has_document", typeof(cfx_browser_has_document_delegate));
            cfx_browser_get_main_frame = (cfx_browser_get_main_frame_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_main_frame", typeof(cfx_browser_get_main_frame_delegate));
            cfx_browser_get_focused_frame = (cfx_browser_get_focused_frame_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_focused_frame", typeof(cfx_browser_get_focused_frame_delegate));
            cfx_browser_get_frame_byident = (cfx_browser_get_frame_byident_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_frame_byident", typeof(cfx_browser_get_frame_byident_delegate));
            cfx_browser_get_frame = (cfx_browser_get_frame_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_frame", typeof(cfx_browser_get_frame_delegate));
            cfx_browser_get_frame_count = (cfx_browser_get_frame_count_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_frame_count", typeof(cfx_browser_get_frame_count_delegate));
            cfx_browser_get_frame_identifiers = (cfx_browser_get_frame_identifiers_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_frame_identifiers", typeof(cfx_browser_get_frame_identifiers_delegate));
            cfx_browser_get_frame_names = (cfx_browser_get_frame_names_delegate)GetDelegate(libcfxPtr, "cfx_browser_get_frame_names", typeof(cfx_browser_get_frame_names_delegate));
            cfx_browser_send_process_message = (cfx_browser_send_process_message_delegate)GetDelegate(libcfxPtr, "cfx_browser_send_process_message", typeof(cfx_browser_send_process_message_delegate));


            // cef_browser_host

            cfx_browser_host_create_browser = (cfx_browser_host_create_browser_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_create_browser", typeof(cfx_browser_host_create_browser_delegate));
            cfx_browser_host_create_browser_sync = (cfx_browser_host_create_browser_sync_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_create_browser_sync", typeof(cfx_browser_host_create_browser_sync_delegate));

            cfx_browser_host_get_browser = (cfx_browser_host_get_browser_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_browser", typeof(cfx_browser_host_get_browser_delegate));
            cfx_browser_host_parent_window_will_close = (cfx_browser_host_parent_window_will_close_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_parent_window_will_close", typeof(cfx_browser_host_parent_window_will_close_delegate));
            cfx_browser_host_close_browser = (cfx_browser_host_close_browser_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_close_browser", typeof(cfx_browser_host_close_browser_delegate));
            cfx_browser_host_set_focus = (cfx_browser_host_set_focus_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_set_focus", typeof(cfx_browser_host_set_focus_delegate));
            cfx_browser_host_set_window_visibility = (cfx_browser_host_set_window_visibility_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_set_window_visibility", typeof(cfx_browser_host_set_window_visibility_delegate));
            cfx_browser_host_get_window_handle = (cfx_browser_host_get_window_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_window_handle", typeof(cfx_browser_host_get_window_handle_delegate));
            cfx_browser_host_get_opener_window_handle = (cfx_browser_host_get_opener_window_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_opener_window_handle", typeof(cfx_browser_host_get_opener_window_handle_delegate));
            cfx_browser_host_get_client = (cfx_browser_host_get_client_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_client", typeof(cfx_browser_host_get_client_delegate));
            cfx_browser_host_get_request_context = (cfx_browser_host_get_request_context_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_request_context", typeof(cfx_browser_host_get_request_context_delegate));
            cfx_browser_host_get_zoom_level = (cfx_browser_host_get_zoom_level_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_zoom_level", typeof(cfx_browser_host_get_zoom_level_delegate));
            cfx_browser_host_set_zoom_level = (cfx_browser_host_set_zoom_level_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_set_zoom_level", typeof(cfx_browser_host_set_zoom_level_delegate));
            cfx_browser_host_run_file_dialog = (cfx_browser_host_run_file_dialog_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_run_file_dialog", typeof(cfx_browser_host_run_file_dialog_delegate));
            cfx_browser_host_start_download = (cfx_browser_host_start_download_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_start_download", typeof(cfx_browser_host_start_download_delegate));
            cfx_browser_host_print = (cfx_browser_host_print_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_print", typeof(cfx_browser_host_print_delegate));
            cfx_browser_host_find = (cfx_browser_host_find_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_find", typeof(cfx_browser_host_find_delegate));
            cfx_browser_host_stop_finding = (cfx_browser_host_stop_finding_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_stop_finding", typeof(cfx_browser_host_stop_finding_delegate));
            cfx_browser_host_show_dev_tools = (cfx_browser_host_show_dev_tools_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_show_dev_tools", typeof(cfx_browser_host_show_dev_tools_delegate));
            cfx_browser_host_close_dev_tools = (cfx_browser_host_close_dev_tools_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_close_dev_tools", typeof(cfx_browser_host_close_dev_tools_delegate));
            cfx_browser_host_set_mouse_cursor_change_disabled = (cfx_browser_host_set_mouse_cursor_change_disabled_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_set_mouse_cursor_change_disabled", typeof(cfx_browser_host_set_mouse_cursor_change_disabled_delegate));
            cfx_browser_host_is_mouse_cursor_change_disabled = (cfx_browser_host_is_mouse_cursor_change_disabled_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_is_mouse_cursor_change_disabled", typeof(cfx_browser_host_is_mouse_cursor_change_disabled_delegate));
            cfx_browser_host_is_window_rendering_disabled = (cfx_browser_host_is_window_rendering_disabled_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_is_window_rendering_disabled", typeof(cfx_browser_host_is_window_rendering_disabled_delegate));
            cfx_browser_host_was_resized = (cfx_browser_host_was_resized_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_was_resized", typeof(cfx_browser_host_was_resized_delegate));
            cfx_browser_host_was_hidden = (cfx_browser_host_was_hidden_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_was_hidden", typeof(cfx_browser_host_was_hidden_delegate));
            cfx_browser_host_notify_screen_info_changed = (cfx_browser_host_notify_screen_info_changed_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_notify_screen_info_changed", typeof(cfx_browser_host_notify_screen_info_changed_delegate));
            cfx_browser_host_invalidate = (cfx_browser_host_invalidate_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_invalidate", typeof(cfx_browser_host_invalidate_delegate));
            cfx_browser_host_send_key_event = (cfx_browser_host_send_key_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_key_event", typeof(cfx_browser_host_send_key_event_delegate));
            cfx_browser_host_send_mouse_click_event = (cfx_browser_host_send_mouse_click_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_mouse_click_event", typeof(cfx_browser_host_send_mouse_click_event_delegate));
            cfx_browser_host_send_mouse_move_event = (cfx_browser_host_send_mouse_move_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_mouse_move_event", typeof(cfx_browser_host_send_mouse_move_event_delegate));
            cfx_browser_host_send_mouse_wheel_event = (cfx_browser_host_send_mouse_wheel_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_mouse_wheel_event", typeof(cfx_browser_host_send_mouse_wheel_event_delegate));
            cfx_browser_host_send_focus_event = (cfx_browser_host_send_focus_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_focus_event", typeof(cfx_browser_host_send_focus_event_delegate));
            cfx_browser_host_send_capture_lost_event = (cfx_browser_host_send_capture_lost_event_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_send_capture_lost_event", typeof(cfx_browser_host_send_capture_lost_event_delegate));
            cfx_browser_host_get_nstext_input_context = (cfx_browser_host_get_nstext_input_context_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_nstext_input_context", typeof(cfx_browser_host_get_nstext_input_context_delegate));
            cfx_browser_host_handle_key_event_before_text_input_client = (cfx_browser_host_handle_key_event_before_text_input_client_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_handle_key_event_before_text_input_client", typeof(cfx_browser_host_handle_key_event_before_text_input_client_delegate));
            cfx_browser_host_handle_key_event_after_text_input_client = (cfx_browser_host_handle_key_event_after_text_input_client_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_handle_key_event_after_text_input_client", typeof(cfx_browser_host_handle_key_event_after_text_input_client_delegate));


            // cef_browser_process_handler

            cfx_browser_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_browser_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_browser_process_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_browser_process_handler_on_context_initialized = CfxBrowserProcessHandler.on_context_initialized;
            cfx_browser_process_handler_on_before_child_process_launch = CfxBrowserProcessHandler.on_before_child_process_launch;
            cfx_browser_process_handler_on_render_process_thread_created = CfxBrowserProcessHandler.on_render_process_thread_created;

            var cfx_browser_process_handler_set_callback_ptrs = (cfx_set_3_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_set_callback_ptrs", typeof(cfx_set_3_callback_ptrs_delegate));
            cfx_browser_process_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_browser_process_handler_on_context_initialized),
                Marshal.GetFunctionPointerForDelegate(cfx_browser_process_handler_on_before_child_process_launch),
                Marshal.GetFunctionPointerForDelegate(cfx_browser_process_handler_on_render_process_thread_created)
            );


            // cef_browser_settings

            cfx_browser_settings_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_ctor", typeof(cfx_ctor_delegate));
            cfx_browser_settings_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_dtor", typeof(cfx_dtor_delegate));

            cfx_browser_settings_copy_to_native = (cfx_browser_settings_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_copy_to_native", typeof(cfx_browser_settings_copy_to_native_delegate));
            cfx_browser_settings_copy_to_managed = (cfx_browser_settings_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_copy_to_managed", typeof(cfx_browser_settings_copy_to_managed_delegate));


            // cef_callback

            cfx_callback_cont = (cfx_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_callback_cont", typeof(cfx_callback_cont_delegate));
            cfx_callback_cancel = (cfx_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_callback_cancel", typeof(cfx_callback_cancel_delegate));


            // cef_client

            cfx_client_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_client_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_client_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_client_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_client_get_context_menu_handler = CfxClient.get_context_menu_handler;
            cfx_client_get_dialog_handler = CfxClient.get_dialog_handler;
            cfx_client_get_display_handler = CfxClient.get_display_handler;
            cfx_client_get_download_handler = CfxClient.get_download_handler;
            cfx_client_get_drag_handler = CfxClient.get_drag_handler;
            cfx_client_get_focus_handler = CfxClient.get_focus_handler;
            cfx_client_get_geolocation_handler = CfxClient.get_geolocation_handler;
            cfx_client_get_jsdialog_handler = CfxClient.get_jsdialog_handler;
            cfx_client_get_keyboard_handler = CfxClient.get_keyboard_handler;
            cfx_client_get_life_span_handler = CfxClient.get_life_span_handler;
            cfx_client_get_load_handler = CfxClient.get_load_handler;
            cfx_client_get_render_handler = CfxClient.get_render_handler;
            cfx_client_get_request_handler = CfxClient.get_request_handler;
            cfx_client_on_process_message_received = CfxClient.on_process_message_received;

            var cfx_client_set_callback_ptrs = (cfx_set_14_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_client_set_callback_ptrs", typeof(cfx_set_14_callback_ptrs_delegate));
            cfx_client_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_context_menu_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_dialog_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_display_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_download_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_drag_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_focus_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_geolocation_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_jsdialog_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_keyboard_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_life_span_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_load_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_render_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_get_request_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_client_on_process_message_received)
            );


            // cef_command_line

            cfx_command_line_create = (cfx_command_line_create_delegate)GetDelegate(libcfxPtr, "cfx_command_line_create", typeof(cfx_command_line_create_delegate));
            cfx_command_line_get_global = (cfx_command_line_get_global_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_global", typeof(cfx_command_line_get_global_delegate));

            cfx_command_line_is_valid = (cfx_command_line_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_command_line_is_valid", typeof(cfx_command_line_is_valid_delegate));
            cfx_command_line_is_read_only = (cfx_command_line_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_command_line_is_read_only", typeof(cfx_command_line_is_read_only_delegate));
            cfx_command_line_copy = (cfx_command_line_copy_delegate)GetDelegate(libcfxPtr, "cfx_command_line_copy", typeof(cfx_command_line_copy_delegate));
            cfx_command_line_init_from_argv = (cfx_command_line_init_from_argv_delegate)GetDelegate(libcfxPtr, "cfx_command_line_init_from_argv", typeof(cfx_command_line_init_from_argv_delegate));
            cfx_command_line_init_from_string = (cfx_command_line_init_from_string_delegate)GetDelegate(libcfxPtr, "cfx_command_line_init_from_string", typeof(cfx_command_line_init_from_string_delegate));
            cfx_command_line_reset = (cfx_command_line_reset_delegate)GetDelegate(libcfxPtr, "cfx_command_line_reset", typeof(cfx_command_line_reset_delegate));
            cfx_command_line_get_argv = (cfx_command_line_get_argv_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_argv", typeof(cfx_command_line_get_argv_delegate));
            cfx_command_line_get_command_line_string = (cfx_command_line_get_command_line_string_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_command_line_string", typeof(cfx_command_line_get_command_line_string_delegate));
            cfx_command_line_get_program = (cfx_command_line_get_program_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_program", typeof(cfx_command_line_get_program_delegate));
            cfx_command_line_set_program = (cfx_command_line_set_program_delegate)GetDelegate(libcfxPtr, "cfx_command_line_set_program", typeof(cfx_command_line_set_program_delegate));
            cfx_command_line_has_switches = (cfx_command_line_has_switches_delegate)GetDelegate(libcfxPtr, "cfx_command_line_has_switches", typeof(cfx_command_line_has_switches_delegate));
            cfx_command_line_has_switch = (cfx_command_line_has_switch_delegate)GetDelegate(libcfxPtr, "cfx_command_line_has_switch", typeof(cfx_command_line_has_switch_delegate));
            cfx_command_line_get_switch_value = (cfx_command_line_get_switch_value_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_switch_value", typeof(cfx_command_line_get_switch_value_delegate));
            cfx_command_line_get_switches = (cfx_command_line_get_switches_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_switches", typeof(cfx_command_line_get_switches_delegate));
            cfx_command_line_append_switch = (cfx_command_line_append_switch_delegate)GetDelegate(libcfxPtr, "cfx_command_line_append_switch", typeof(cfx_command_line_append_switch_delegate));
            cfx_command_line_append_switch_with_value = (cfx_command_line_append_switch_with_value_delegate)GetDelegate(libcfxPtr, "cfx_command_line_append_switch_with_value", typeof(cfx_command_line_append_switch_with_value_delegate));
            cfx_command_line_has_arguments = (cfx_command_line_has_arguments_delegate)GetDelegate(libcfxPtr, "cfx_command_line_has_arguments", typeof(cfx_command_line_has_arguments_delegate));
            cfx_command_line_get_arguments = (cfx_command_line_get_arguments_delegate)GetDelegate(libcfxPtr, "cfx_command_line_get_arguments", typeof(cfx_command_line_get_arguments_delegate));
            cfx_command_line_append_argument = (cfx_command_line_append_argument_delegate)GetDelegate(libcfxPtr, "cfx_command_line_append_argument", typeof(cfx_command_line_append_argument_delegate));
            cfx_command_line_prepend_wrapper = (cfx_command_line_prepend_wrapper_delegate)GetDelegate(libcfxPtr, "cfx_command_line_prepend_wrapper", typeof(cfx_command_line_prepend_wrapper_delegate));


            // cef_completion_handler

            cfx_completion_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_completion_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_completion_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_completion_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_completion_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_completion_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_completion_handler_on_complete = CfxCompletionHandler.on_complete;

            var cfx_completion_handler_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_completion_handler_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_completion_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_completion_handler_on_complete)
            );


            // cef_context_menu_handler

            cfx_context_menu_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_context_menu_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_context_menu_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_context_menu_handler_on_before_context_menu = CfxContextMenuHandler.on_before_context_menu;
            cfx_context_menu_handler_on_context_menu_command = CfxContextMenuHandler.on_context_menu_command;
            cfx_context_menu_handler_on_context_menu_dismissed = CfxContextMenuHandler.on_context_menu_dismissed;

            var cfx_context_menu_handler_set_callback_ptrs = (cfx_set_3_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_set_callback_ptrs", typeof(cfx_set_3_callback_ptrs_delegate));
            cfx_context_menu_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_context_menu_handler_on_before_context_menu),
                Marshal.GetFunctionPointerForDelegate(cfx_context_menu_handler_on_context_menu_command),
                Marshal.GetFunctionPointerForDelegate(cfx_context_menu_handler_on_context_menu_dismissed)
            );


            // cef_context_menu_params

            cfx_context_menu_params_get_xcoord = (cfx_context_menu_params_get_xcoord_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_xcoord", typeof(cfx_context_menu_params_get_xcoord_delegate));
            cfx_context_menu_params_get_ycoord = (cfx_context_menu_params_get_ycoord_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_ycoord", typeof(cfx_context_menu_params_get_ycoord_delegate));
            cfx_context_menu_params_get_type_flags = (cfx_context_menu_params_get_type_flags_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_type_flags", typeof(cfx_context_menu_params_get_type_flags_delegate));
            cfx_context_menu_params_get_link_url = (cfx_context_menu_params_get_link_url_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_link_url", typeof(cfx_context_menu_params_get_link_url_delegate));
            cfx_context_menu_params_get_unfiltered_link_url = (cfx_context_menu_params_get_unfiltered_link_url_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_unfiltered_link_url", typeof(cfx_context_menu_params_get_unfiltered_link_url_delegate));
            cfx_context_menu_params_get_source_url = (cfx_context_menu_params_get_source_url_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_source_url", typeof(cfx_context_menu_params_get_source_url_delegate));
            cfx_context_menu_params_has_image_contents = (cfx_context_menu_params_has_image_contents_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_has_image_contents", typeof(cfx_context_menu_params_has_image_contents_delegate));
            cfx_context_menu_params_get_page_url = (cfx_context_menu_params_get_page_url_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_page_url", typeof(cfx_context_menu_params_get_page_url_delegate));
            cfx_context_menu_params_get_frame_url = (cfx_context_menu_params_get_frame_url_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_frame_url", typeof(cfx_context_menu_params_get_frame_url_delegate));
            cfx_context_menu_params_get_frame_charset = (cfx_context_menu_params_get_frame_charset_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_frame_charset", typeof(cfx_context_menu_params_get_frame_charset_delegate));
            cfx_context_menu_params_get_media_type = (cfx_context_menu_params_get_media_type_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_media_type", typeof(cfx_context_menu_params_get_media_type_delegate));
            cfx_context_menu_params_get_media_state_flags = (cfx_context_menu_params_get_media_state_flags_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_media_state_flags", typeof(cfx_context_menu_params_get_media_state_flags_delegate));
            cfx_context_menu_params_get_selection_text = (cfx_context_menu_params_get_selection_text_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_selection_text", typeof(cfx_context_menu_params_get_selection_text_delegate));
            cfx_context_menu_params_is_editable = (cfx_context_menu_params_is_editable_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_is_editable", typeof(cfx_context_menu_params_is_editable_delegate));
            cfx_context_menu_params_is_speech_input_enabled = (cfx_context_menu_params_is_speech_input_enabled_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_is_speech_input_enabled", typeof(cfx_context_menu_params_is_speech_input_enabled_delegate));
            cfx_context_menu_params_get_edit_state_flags = (cfx_context_menu_params_get_edit_state_flags_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_edit_state_flags", typeof(cfx_context_menu_params_get_edit_state_flags_delegate));


            // cef_cookie

            cfx_cookie_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_cookie_ctor", typeof(cfx_ctor_delegate));
            cfx_cookie_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_cookie_dtor", typeof(cfx_dtor_delegate));

            cfx_cookie_copy_to_native = (cfx_cookie_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_cookie_copy_to_native", typeof(cfx_cookie_copy_to_native_delegate));
            cfx_cookie_copy_to_managed = (cfx_cookie_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_cookie_copy_to_managed", typeof(cfx_cookie_copy_to_managed_delegate));


            // cef_cookie_manager

            cfx_cookie_manager_get_global_manager = (cfx_cookie_manager_get_global_manager_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_get_global_manager", typeof(cfx_cookie_manager_get_global_manager_delegate));
            cfx_cookie_manager_create_manager = (cfx_cookie_manager_create_manager_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_create_manager", typeof(cfx_cookie_manager_create_manager_delegate));

            cfx_cookie_manager_set_supported_schemes = (cfx_cookie_manager_set_supported_schemes_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_set_supported_schemes", typeof(cfx_cookie_manager_set_supported_schemes_delegate));
            cfx_cookie_manager_visit_all_cookies = (cfx_cookie_manager_visit_all_cookies_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_visit_all_cookies", typeof(cfx_cookie_manager_visit_all_cookies_delegate));
            cfx_cookie_manager_visit_url_cookies = (cfx_cookie_manager_visit_url_cookies_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_visit_url_cookies", typeof(cfx_cookie_manager_visit_url_cookies_delegate));
            cfx_cookie_manager_set_cookie = (cfx_cookie_manager_set_cookie_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_set_cookie", typeof(cfx_cookie_manager_set_cookie_delegate));
            cfx_cookie_manager_delete_cookies = (cfx_cookie_manager_delete_cookies_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_delete_cookies", typeof(cfx_cookie_manager_delete_cookies_delegate));
            cfx_cookie_manager_set_storage_path = (cfx_cookie_manager_set_storage_path_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_set_storage_path", typeof(cfx_cookie_manager_set_storage_path_delegate));
            cfx_cookie_manager_flush_store = (cfx_cookie_manager_flush_store_delegate)GetDelegate(libcfxPtr, "cfx_cookie_manager_flush_store", typeof(cfx_cookie_manager_flush_store_delegate));


            // cef_cookie_visitor

            cfx_cookie_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_cookie_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_cookie_visitor_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_cookie_visitor_visit = CfxCookieVisitor.visit;

            var cfx_cookie_visitor_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_cookie_visitor_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_cookie_visitor_visit)
            );


            // cef_dialog_handler

            cfx_dialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_dialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_dialog_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_dialog_handler_on_file_dialog = CfxDialogHandler.on_file_dialog;

            var cfx_dialog_handler_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_dialog_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_dialog_handler_on_file_dialog)
            );


            // cef_dictionary_value

            cfx_dictionary_value_create = (cfx_dictionary_value_create_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_create", typeof(cfx_dictionary_value_create_delegate));

            cfx_dictionary_value_is_valid = (cfx_dictionary_value_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_is_valid", typeof(cfx_dictionary_value_is_valid_delegate));
            cfx_dictionary_value_is_owned = (cfx_dictionary_value_is_owned_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_is_owned", typeof(cfx_dictionary_value_is_owned_delegate));
            cfx_dictionary_value_is_read_only = (cfx_dictionary_value_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_is_read_only", typeof(cfx_dictionary_value_is_read_only_delegate));
            cfx_dictionary_value_copy = (cfx_dictionary_value_copy_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_copy", typeof(cfx_dictionary_value_copy_delegate));
            cfx_dictionary_value_get_size = (cfx_dictionary_value_get_size_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_size", typeof(cfx_dictionary_value_get_size_delegate));
            cfx_dictionary_value_clear = (cfx_dictionary_value_clear_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_clear", typeof(cfx_dictionary_value_clear_delegate));
            cfx_dictionary_value_has_key = (cfx_dictionary_value_has_key_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_has_key", typeof(cfx_dictionary_value_has_key_delegate));
            cfx_dictionary_value_get_keys = (cfx_dictionary_value_get_keys_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_keys", typeof(cfx_dictionary_value_get_keys_delegate));
            cfx_dictionary_value_remove = (cfx_dictionary_value_remove_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_remove", typeof(cfx_dictionary_value_remove_delegate));
            cfx_dictionary_value_get_type = (cfx_dictionary_value_get_type_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_type", typeof(cfx_dictionary_value_get_type_delegate));
            cfx_dictionary_value_get_bool = (cfx_dictionary_value_get_bool_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_bool", typeof(cfx_dictionary_value_get_bool_delegate));
            cfx_dictionary_value_get_int = (cfx_dictionary_value_get_int_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_int", typeof(cfx_dictionary_value_get_int_delegate));
            cfx_dictionary_value_get_double = (cfx_dictionary_value_get_double_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_double", typeof(cfx_dictionary_value_get_double_delegate));
            cfx_dictionary_value_get_string = (cfx_dictionary_value_get_string_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_string", typeof(cfx_dictionary_value_get_string_delegate));
            cfx_dictionary_value_get_binary = (cfx_dictionary_value_get_binary_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_binary", typeof(cfx_dictionary_value_get_binary_delegate));
            cfx_dictionary_value_get_dictionary = (cfx_dictionary_value_get_dictionary_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_dictionary", typeof(cfx_dictionary_value_get_dictionary_delegate));
            cfx_dictionary_value_get_list = (cfx_dictionary_value_get_list_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_get_list", typeof(cfx_dictionary_value_get_list_delegate));
            cfx_dictionary_value_set_null = (cfx_dictionary_value_set_null_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_null", typeof(cfx_dictionary_value_set_null_delegate));
            cfx_dictionary_value_set_bool = (cfx_dictionary_value_set_bool_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_bool", typeof(cfx_dictionary_value_set_bool_delegate));
            cfx_dictionary_value_set_int = (cfx_dictionary_value_set_int_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_int", typeof(cfx_dictionary_value_set_int_delegate));
            cfx_dictionary_value_set_double = (cfx_dictionary_value_set_double_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_double", typeof(cfx_dictionary_value_set_double_delegate));
            cfx_dictionary_value_set_string = (cfx_dictionary_value_set_string_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_string", typeof(cfx_dictionary_value_set_string_delegate));
            cfx_dictionary_value_set_binary = (cfx_dictionary_value_set_binary_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_binary", typeof(cfx_dictionary_value_set_binary_delegate));
            cfx_dictionary_value_set_dictionary = (cfx_dictionary_value_set_dictionary_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_dictionary", typeof(cfx_dictionary_value_set_dictionary_delegate));
            cfx_dictionary_value_set_list = (cfx_dictionary_value_set_list_delegate)GetDelegate(libcfxPtr, "cfx_dictionary_value_set_list", typeof(cfx_dictionary_value_set_list_delegate));


            // cef_display_handler

            cfx_display_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_display_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_display_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_display_handler_on_address_change = CfxDisplayHandler.on_address_change;
            cfx_display_handler_on_title_change = CfxDisplayHandler.on_title_change;
            cfx_display_handler_on_tooltip = CfxDisplayHandler.on_tooltip;
            cfx_display_handler_on_status_message = CfxDisplayHandler.on_status_message;
            cfx_display_handler_on_console_message = CfxDisplayHandler.on_console_message;

            var cfx_display_handler_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_display_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_display_handler_on_address_change),
                Marshal.GetFunctionPointerForDelegate(cfx_display_handler_on_title_change),
                Marshal.GetFunctionPointerForDelegate(cfx_display_handler_on_tooltip),
                Marshal.GetFunctionPointerForDelegate(cfx_display_handler_on_status_message),
                Marshal.GetFunctionPointerForDelegate(cfx_display_handler_on_console_message)
            );


            // cef_domdocument

            cfx_domdocument_get_type = (cfx_domdocument_get_type_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_type", typeof(cfx_domdocument_get_type_delegate));
            cfx_domdocument_get_document = (cfx_domdocument_get_document_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_document", typeof(cfx_domdocument_get_document_delegate));
            cfx_domdocument_get_body = (cfx_domdocument_get_body_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_body", typeof(cfx_domdocument_get_body_delegate));
            cfx_domdocument_get_head = (cfx_domdocument_get_head_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_head", typeof(cfx_domdocument_get_head_delegate));
            cfx_domdocument_get_title = (cfx_domdocument_get_title_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_title", typeof(cfx_domdocument_get_title_delegate));
            cfx_domdocument_get_element_by_id = (cfx_domdocument_get_element_by_id_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_element_by_id", typeof(cfx_domdocument_get_element_by_id_delegate));
            cfx_domdocument_get_focused_node = (cfx_domdocument_get_focused_node_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_focused_node", typeof(cfx_domdocument_get_focused_node_delegate));
            cfx_domdocument_has_selection = (cfx_domdocument_has_selection_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_has_selection", typeof(cfx_domdocument_has_selection_delegate));
            cfx_domdocument_get_selection_start_node = (cfx_domdocument_get_selection_start_node_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_start_node", typeof(cfx_domdocument_get_selection_start_node_delegate));
            cfx_domdocument_get_selection_start_offset = (cfx_domdocument_get_selection_start_offset_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_start_offset", typeof(cfx_domdocument_get_selection_start_offset_delegate));
            cfx_domdocument_get_selection_end_node = (cfx_domdocument_get_selection_end_node_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_end_node", typeof(cfx_domdocument_get_selection_end_node_delegate));
            cfx_domdocument_get_selection_end_offset = (cfx_domdocument_get_selection_end_offset_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_end_offset", typeof(cfx_domdocument_get_selection_end_offset_delegate));
            cfx_domdocument_get_selection_as_markup = (cfx_domdocument_get_selection_as_markup_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_as_markup", typeof(cfx_domdocument_get_selection_as_markup_delegate));
            cfx_domdocument_get_selection_as_text = (cfx_domdocument_get_selection_as_text_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_selection_as_text", typeof(cfx_domdocument_get_selection_as_text_delegate));
            cfx_domdocument_get_base_url = (cfx_domdocument_get_base_url_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_base_url", typeof(cfx_domdocument_get_base_url_delegate));
            cfx_domdocument_get_complete_url = (cfx_domdocument_get_complete_url_delegate)GetDelegate(libcfxPtr, "cfx_domdocument_get_complete_url", typeof(cfx_domdocument_get_complete_url_delegate));


            // cef_domevent

            cfx_domevent_get_type = (cfx_domevent_get_type_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_type", typeof(cfx_domevent_get_type_delegate));
            cfx_domevent_get_category = (cfx_domevent_get_category_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_category", typeof(cfx_domevent_get_category_delegate));
            cfx_domevent_get_phase = (cfx_domevent_get_phase_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_phase", typeof(cfx_domevent_get_phase_delegate));
            cfx_domevent_can_bubble = (cfx_domevent_can_bubble_delegate)GetDelegate(libcfxPtr, "cfx_domevent_can_bubble", typeof(cfx_domevent_can_bubble_delegate));
            cfx_domevent_can_cancel = (cfx_domevent_can_cancel_delegate)GetDelegate(libcfxPtr, "cfx_domevent_can_cancel", typeof(cfx_domevent_can_cancel_delegate));
            cfx_domevent_get_document = (cfx_domevent_get_document_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_document", typeof(cfx_domevent_get_document_delegate));
            cfx_domevent_get_target = (cfx_domevent_get_target_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_target", typeof(cfx_domevent_get_target_delegate));
            cfx_domevent_get_current_target = (cfx_domevent_get_current_target_delegate)GetDelegate(libcfxPtr, "cfx_domevent_get_current_target", typeof(cfx_domevent_get_current_target_delegate));


            // cef_domevent_listener

            cfx_domevent_listener_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domevent_listener_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_domevent_listener_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domevent_listener_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_domevent_listener_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_domevent_listener_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_domevent_listener_handle_event = CfxDomEventListener.handle_event;

            var cfx_domevent_listener_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_domevent_listener_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_domevent_listener_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_domevent_listener_handle_event)
            );


            // cef_domnode

            cfx_domnode_get_type = (cfx_domnode_get_type_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_type", typeof(cfx_domnode_get_type_delegate));
            cfx_domnode_is_text = (cfx_domnode_is_text_delegate)GetDelegate(libcfxPtr, "cfx_domnode_is_text", typeof(cfx_domnode_is_text_delegate));
            cfx_domnode_is_element = (cfx_domnode_is_element_delegate)GetDelegate(libcfxPtr, "cfx_domnode_is_element", typeof(cfx_domnode_is_element_delegate));
            cfx_domnode_is_editable = (cfx_domnode_is_editable_delegate)GetDelegate(libcfxPtr, "cfx_domnode_is_editable", typeof(cfx_domnode_is_editable_delegate));
            cfx_domnode_is_form_control_element = (cfx_domnode_is_form_control_element_delegate)GetDelegate(libcfxPtr, "cfx_domnode_is_form_control_element", typeof(cfx_domnode_is_form_control_element_delegate));
            cfx_domnode_get_form_control_element_type = (cfx_domnode_get_form_control_element_type_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_form_control_element_type", typeof(cfx_domnode_get_form_control_element_type_delegate));
            cfx_domnode_is_same = (cfx_domnode_is_same_delegate)GetDelegate(libcfxPtr, "cfx_domnode_is_same", typeof(cfx_domnode_is_same_delegate));
            cfx_domnode_get_name = (cfx_domnode_get_name_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_name", typeof(cfx_domnode_get_name_delegate));
            cfx_domnode_get_value = (cfx_domnode_get_value_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_value", typeof(cfx_domnode_get_value_delegate));
            cfx_domnode_set_value = (cfx_domnode_set_value_delegate)GetDelegate(libcfxPtr, "cfx_domnode_set_value", typeof(cfx_domnode_set_value_delegate));
            cfx_domnode_get_as_markup = (cfx_domnode_get_as_markup_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_as_markup", typeof(cfx_domnode_get_as_markup_delegate));
            cfx_domnode_get_document = (cfx_domnode_get_document_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_document", typeof(cfx_domnode_get_document_delegate));
            cfx_domnode_get_parent = (cfx_domnode_get_parent_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_parent", typeof(cfx_domnode_get_parent_delegate));
            cfx_domnode_get_previous_sibling = (cfx_domnode_get_previous_sibling_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_previous_sibling", typeof(cfx_domnode_get_previous_sibling_delegate));
            cfx_domnode_get_next_sibling = (cfx_domnode_get_next_sibling_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_next_sibling", typeof(cfx_domnode_get_next_sibling_delegate));
            cfx_domnode_has_children = (cfx_domnode_has_children_delegate)GetDelegate(libcfxPtr, "cfx_domnode_has_children", typeof(cfx_domnode_has_children_delegate));
            cfx_domnode_get_first_child = (cfx_domnode_get_first_child_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_first_child", typeof(cfx_domnode_get_first_child_delegate));
            cfx_domnode_get_last_child = (cfx_domnode_get_last_child_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_last_child", typeof(cfx_domnode_get_last_child_delegate));
            cfx_domnode_add_event_listener = (cfx_domnode_add_event_listener_delegate)GetDelegate(libcfxPtr, "cfx_domnode_add_event_listener", typeof(cfx_domnode_add_event_listener_delegate));
            cfx_domnode_get_element_tag_name = (cfx_domnode_get_element_tag_name_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_element_tag_name", typeof(cfx_domnode_get_element_tag_name_delegate));
            cfx_domnode_has_element_attributes = (cfx_domnode_has_element_attributes_delegate)GetDelegate(libcfxPtr, "cfx_domnode_has_element_attributes", typeof(cfx_domnode_has_element_attributes_delegate));
            cfx_domnode_has_element_attribute = (cfx_domnode_has_element_attribute_delegate)GetDelegate(libcfxPtr, "cfx_domnode_has_element_attribute", typeof(cfx_domnode_has_element_attribute_delegate));
            cfx_domnode_get_element_attribute = (cfx_domnode_get_element_attribute_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_element_attribute", typeof(cfx_domnode_get_element_attribute_delegate));
            cfx_domnode_get_element_attributes = (cfx_domnode_get_element_attributes_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_element_attributes", typeof(cfx_domnode_get_element_attributes_delegate));
            cfx_domnode_set_element_attribute = (cfx_domnode_set_element_attribute_delegate)GetDelegate(libcfxPtr, "cfx_domnode_set_element_attribute", typeof(cfx_domnode_set_element_attribute_delegate));
            cfx_domnode_get_element_inner_text = (cfx_domnode_get_element_inner_text_delegate)GetDelegate(libcfxPtr, "cfx_domnode_get_element_inner_text", typeof(cfx_domnode_get_element_inner_text_delegate));


            // cef_domvisitor

            cfx_domvisitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_domvisitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_domvisitor_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_domvisitor_visit = CfxDomVisitor.visit;

            var cfx_domvisitor_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_domvisitor_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_domvisitor_visit)
            );


            // cef_download_handler

            cfx_download_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_download_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_download_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_download_handler_on_before_download = CfxDownloadHandler.on_before_download;
            cfx_download_handler_on_download_updated = CfxDownloadHandler.on_download_updated;

            var cfx_download_handler_set_callback_ptrs = (cfx_set_2_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_set_callback_ptrs", typeof(cfx_set_2_callback_ptrs_delegate));
            cfx_download_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_download_handler_on_before_download),
                Marshal.GetFunctionPointerForDelegate(cfx_download_handler_on_download_updated)
            );


            // cef_download_item

            cfx_download_item_is_valid = (cfx_download_item_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_download_item_is_valid", typeof(cfx_download_item_is_valid_delegate));
            cfx_download_item_is_in_progress = (cfx_download_item_is_in_progress_delegate)GetDelegate(libcfxPtr, "cfx_download_item_is_in_progress", typeof(cfx_download_item_is_in_progress_delegate));
            cfx_download_item_is_complete = (cfx_download_item_is_complete_delegate)GetDelegate(libcfxPtr, "cfx_download_item_is_complete", typeof(cfx_download_item_is_complete_delegate));
            cfx_download_item_is_canceled = (cfx_download_item_is_canceled_delegate)GetDelegate(libcfxPtr, "cfx_download_item_is_canceled", typeof(cfx_download_item_is_canceled_delegate));
            cfx_download_item_get_current_speed = (cfx_download_item_get_current_speed_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_current_speed", typeof(cfx_download_item_get_current_speed_delegate));
            cfx_download_item_get_percent_complete = (cfx_download_item_get_percent_complete_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_percent_complete", typeof(cfx_download_item_get_percent_complete_delegate));
            cfx_download_item_get_total_bytes = (cfx_download_item_get_total_bytes_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_total_bytes", typeof(cfx_download_item_get_total_bytes_delegate));
            cfx_download_item_get_received_bytes = (cfx_download_item_get_received_bytes_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_received_bytes", typeof(cfx_download_item_get_received_bytes_delegate));
            cfx_download_item_get_start_time = (cfx_download_item_get_start_time_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_start_time", typeof(cfx_download_item_get_start_time_delegate));
            cfx_download_item_get_end_time = (cfx_download_item_get_end_time_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_end_time", typeof(cfx_download_item_get_end_time_delegate));
            cfx_download_item_get_full_path = (cfx_download_item_get_full_path_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_full_path", typeof(cfx_download_item_get_full_path_delegate));
            cfx_download_item_get_id = (cfx_download_item_get_id_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_id", typeof(cfx_download_item_get_id_delegate));
            cfx_download_item_get_url = (cfx_download_item_get_url_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_url", typeof(cfx_download_item_get_url_delegate));
            cfx_download_item_get_suggested_file_name = (cfx_download_item_get_suggested_file_name_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_suggested_file_name", typeof(cfx_download_item_get_suggested_file_name_delegate));
            cfx_download_item_get_content_disposition = (cfx_download_item_get_content_disposition_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_content_disposition", typeof(cfx_download_item_get_content_disposition_delegate));
            cfx_download_item_get_mime_type = (cfx_download_item_get_mime_type_delegate)GetDelegate(libcfxPtr, "cfx_download_item_get_mime_type", typeof(cfx_download_item_get_mime_type_delegate));


            // cef_download_item_callback

            cfx_download_item_callback_cancel = (cfx_download_item_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_download_item_callback_cancel", typeof(cfx_download_item_callback_cancel_delegate));


            // cef_drag_data

            cfx_drag_data_is_link = (cfx_drag_data_is_link_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_is_link", typeof(cfx_drag_data_is_link_delegate));
            cfx_drag_data_is_fragment = (cfx_drag_data_is_fragment_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_is_fragment", typeof(cfx_drag_data_is_fragment_delegate));
            cfx_drag_data_is_file = (cfx_drag_data_is_file_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_is_file", typeof(cfx_drag_data_is_file_delegate));
            cfx_drag_data_get_link_url = (cfx_drag_data_get_link_url_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_link_url", typeof(cfx_drag_data_get_link_url_delegate));
            cfx_drag_data_get_link_title = (cfx_drag_data_get_link_title_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_link_title", typeof(cfx_drag_data_get_link_title_delegate));
            cfx_drag_data_get_link_metadata = (cfx_drag_data_get_link_metadata_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_link_metadata", typeof(cfx_drag_data_get_link_metadata_delegate));
            cfx_drag_data_get_fragment_text = (cfx_drag_data_get_fragment_text_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_fragment_text", typeof(cfx_drag_data_get_fragment_text_delegate));
            cfx_drag_data_get_fragment_html = (cfx_drag_data_get_fragment_html_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_fragment_html", typeof(cfx_drag_data_get_fragment_html_delegate));
            cfx_drag_data_get_fragment_base_url = (cfx_drag_data_get_fragment_base_url_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_fragment_base_url", typeof(cfx_drag_data_get_fragment_base_url_delegate));
            cfx_drag_data_get_file_name = (cfx_drag_data_get_file_name_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_file_name", typeof(cfx_drag_data_get_file_name_delegate));
            cfx_drag_data_get_file_names = (cfx_drag_data_get_file_names_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_file_names", typeof(cfx_drag_data_get_file_names_delegate));


            // cef_drag_handler

            cfx_drag_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_drag_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_drag_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_drag_handler_on_drag_enter = CfxDragHandler.on_drag_enter;

            var cfx_drag_handler_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_drag_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_drag_handler_on_drag_enter)
            );


            // cef_end_tracing_callback

            cfx_end_tracing_callback_on_end_tracing_complete = (cfx_end_tracing_callback_on_end_tracing_complete_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_callback_on_end_tracing_complete", typeof(cfx_end_tracing_callback_on_end_tracing_complete_delegate));


            // cef_file_dialog_callback

            cfx_file_dialog_callback_cont = (cfx_file_dialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_file_dialog_callback_cont", typeof(cfx_file_dialog_callback_cont_delegate));
            cfx_file_dialog_callback_cancel = (cfx_file_dialog_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_file_dialog_callback_cancel", typeof(cfx_file_dialog_callback_cancel_delegate));


            // cef_focus_handler

            cfx_focus_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_focus_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_focus_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_focus_handler_on_take_focus = CfxFocusHandler.on_take_focus;
            cfx_focus_handler_on_set_focus = CfxFocusHandler.on_set_focus;
            cfx_focus_handler_on_got_focus = CfxFocusHandler.on_got_focus;

            var cfx_focus_handler_set_callback_ptrs = (cfx_set_3_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_set_callback_ptrs", typeof(cfx_set_3_callback_ptrs_delegate));
            cfx_focus_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_focus_handler_on_take_focus),
                Marshal.GetFunctionPointerForDelegate(cfx_focus_handler_on_set_focus),
                Marshal.GetFunctionPointerForDelegate(cfx_focus_handler_on_got_focus)
            );


            // cef_frame

            cfx_frame_is_valid = (cfx_frame_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_frame_is_valid", typeof(cfx_frame_is_valid_delegate));
            cfx_frame_undo = (cfx_frame_undo_delegate)GetDelegate(libcfxPtr, "cfx_frame_undo", typeof(cfx_frame_undo_delegate));
            cfx_frame_redo = (cfx_frame_redo_delegate)GetDelegate(libcfxPtr, "cfx_frame_redo", typeof(cfx_frame_redo_delegate));
            cfx_frame_cut = (cfx_frame_cut_delegate)GetDelegate(libcfxPtr, "cfx_frame_cut", typeof(cfx_frame_cut_delegate));
            cfx_frame_copy = (cfx_frame_copy_delegate)GetDelegate(libcfxPtr, "cfx_frame_copy", typeof(cfx_frame_copy_delegate));
            cfx_frame_paste = (cfx_frame_paste_delegate)GetDelegate(libcfxPtr, "cfx_frame_paste", typeof(cfx_frame_paste_delegate));
            cfx_frame_del = (cfx_frame_del_delegate)GetDelegate(libcfxPtr, "cfx_frame_del", typeof(cfx_frame_del_delegate));
            cfx_frame_select_all = (cfx_frame_select_all_delegate)GetDelegate(libcfxPtr, "cfx_frame_select_all", typeof(cfx_frame_select_all_delegate));
            cfx_frame_view_source = (cfx_frame_view_source_delegate)GetDelegate(libcfxPtr, "cfx_frame_view_source", typeof(cfx_frame_view_source_delegate));
            cfx_frame_get_source = (cfx_frame_get_source_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_source", typeof(cfx_frame_get_source_delegate));
            cfx_frame_get_text = (cfx_frame_get_text_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_text", typeof(cfx_frame_get_text_delegate));
            cfx_frame_load_request = (cfx_frame_load_request_delegate)GetDelegate(libcfxPtr, "cfx_frame_load_request", typeof(cfx_frame_load_request_delegate));
            cfx_frame_load_url = (cfx_frame_load_url_delegate)GetDelegate(libcfxPtr, "cfx_frame_load_url", typeof(cfx_frame_load_url_delegate));
            cfx_frame_load_string = (cfx_frame_load_string_delegate)GetDelegate(libcfxPtr, "cfx_frame_load_string", typeof(cfx_frame_load_string_delegate));
            cfx_frame_execute_java_script = (cfx_frame_execute_java_script_delegate)GetDelegate(libcfxPtr, "cfx_frame_execute_java_script", typeof(cfx_frame_execute_java_script_delegate));
            cfx_frame_is_main = (cfx_frame_is_main_delegate)GetDelegate(libcfxPtr, "cfx_frame_is_main", typeof(cfx_frame_is_main_delegate));
            cfx_frame_is_focused = (cfx_frame_is_focused_delegate)GetDelegate(libcfxPtr, "cfx_frame_is_focused", typeof(cfx_frame_is_focused_delegate));
            cfx_frame_get_name = (cfx_frame_get_name_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_name", typeof(cfx_frame_get_name_delegate));
            cfx_frame_get_identifier = (cfx_frame_get_identifier_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_identifier", typeof(cfx_frame_get_identifier_delegate));
            cfx_frame_get_parent = (cfx_frame_get_parent_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_parent", typeof(cfx_frame_get_parent_delegate));
            cfx_frame_get_url = (cfx_frame_get_url_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_url", typeof(cfx_frame_get_url_delegate));
            cfx_frame_get_browser = (cfx_frame_get_browser_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_browser", typeof(cfx_frame_get_browser_delegate));
            cfx_frame_get_v8context = (cfx_frame_get_v8context_delegate)GetDelegate(libcfxPtr, "cfx_frame_get_v8context", typeof(cfx_frame_get_v8context_delegate));
            cfx_frame_visit_dom = (cfx_frame_visit_dom_delegate)GetDelegate(libcfxPtr, "cfx_frame_visit_dom", typeof(cfx_frame_visit_dom_delegate));


            // cef_geolocation_callback

            cfx_geolocation_callback_cont = (cfx_geolocation_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_callback_cont", typeof(cfx_geolocation_callback_cont_delegate));


            // cef_geolocation_handler

            cfx_geolocation_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_geolocation_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_geolocation_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_geolocation_handler_on_request_geolocation_permission = CfxGeolocationHandler.on_request_geolocation_permission;
            cfx_geolocation_handler_on_cancel_geolocation_permission = CfxGeolocationHandler.on_cancel_geolocation_permission;

            var cfx_geolocation_handler_set_callback_ptrs = (cfx_set_2_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_set_callback_ptrs", typeof(cfx_set_2_callback_ptrs_delegate));
            cfx_geolocation_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_geolocation_handler_on_request_geolocation_permission),
                Marshal.GetFunctionPointerForDelegate(cfx_geolocation_handler_on_cancel_geolocation_permission)
            );


            // cef_geoposition

            cfx_geoposition_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_ctor", typeof(cfx_ctor_delegate));
            cfx_geoposition_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_dtor", typeof(cfx_dtor_delegate));

            cfx_geoposition_copy_to_native = (cfx_geoposition_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_copy_to_native", typeof(cfx_geoposition_copy_to_native_delegate));
            cfx_geoposition_copy_to_managed = (cfx_geoposition_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_copy_to_managed", typeof(cfx_geoposition_copy_to_managed_delegate));


            // cef_get_geolocation_callback

            cfx_get_geolocation_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_get_geolocation_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_get_geolocation_callback_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_get_geolocation_callback_on_location_update = CfxGetGeolocationCallback.on_location_update;

            var cfx_get_geolocation_callback_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_get_geolocation_callback_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_get_geolocation_callback_on_location_update)
            );


            // cef_jsdialog_callback

            cfx_jsdialog_callback_cont = (cfx_jsdialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_callback_cont", typeof(cfx_jsdialog_callback_cont_delegate));


            // cef_jsdialog_handler

            cfx_jsdialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_jsdialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_jsdialog_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_jsdialog_handler_on_jsdialog = CfxJsDialogHandler.on_jsdialog;
            cfx_jsdialog_handler_on_before_unload_dialog = CfxJsDialogHandler.on_before_unload_dialog;
            cfx_jsdialog_handler_on_reset_dialog_state = CfxJsDialogHandler.on_reset_dialog_state;
            cfx_jsdialog_handler_on_dialog_closed = CfxJsDialogHandler.on_dialog_closed;

            var cfx_jsdialog_handler_set_callback_ptrs = (cfx_set_4_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_set_callback_ptrs", typeof(cfx_set_4_callback_ptrs_delegate));
            cfx_jsdialog_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_jsdialog_handler_on_jsdialog),
                Marshal.GetFunctionPointerForDelegate(cfx_jsdialog_handler_on_before_unload_dialog),
                Marshal.GetFunctionPointerForDelegate(cfx_jsdialog_handler_on_reset_dialog_state),
                Marshal.GetFunctionPointerForDelegate(cfx_jsdialog_handler_on_dialog_closed)
            );


            // cef_key_event

            cfx_key_event_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_key_event_ctor", typeof(cfx_ctor_delegate));
            cfx_key_event_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_key_event_dtor", typeof(cfx_dtor_delegate));

            cfx_key_event_copy_to_native = (cfx_key_event_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_key_event_copy_to_native", typeof(cfx_key_event_copy_to_native_delegate));
            cfx_key_event_copy_to_managed = (cfx_key_event_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_key_event_copy_to_managed", typeof(cfx_key_event_copy_to_managed_delegate));


            // cef_keyboard_handler

            cfx_keyboard_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_keyboard_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_keyboard_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_keyboard_handler_on_pre_key_event = CfxKeyboardHandler.on_pre_key_event;
            cfx_keyboard_handler_on_key_event = CfxKeyboardHandler.on_key_event;

            var cfx_keyboard_handler_set_callback_ptrs = (cfx_set_2_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_set_callback_ptrs", typeof(cfx_set_2_callback_ptrs_delegate));
            cfx_keyboard_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_keyboard_handler_on_pre_key_event),
                Marshal.GetFunctionPointerForDelegate(cfx_keyboard_handler_on_key_event)
            );


            // cef_life_span_handler

            cfx_life_span_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_life_span_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_life_span_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_life_span_handler_on_before_popup = CfxLifeSpanHandler.on_before_popup;
            cfx_life_span_handler_on_after_created = CfxLifeSpanHandler.on_after_created;
            cfx_life_span_handler_run_modal = CfxLifeSpanHandler.run_modal;
            cfx_life_span_handler_do_close = CfxLifeSpanHandler.do_close;
            cfx_life_span_handler_on_before_close = CfxLifeSpanHandler.on_before_close;

            var cfx_life_span_handler_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_life_span_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_life_span_handler_on_before_popup),
                Marshal.GetFunctionPointerForDelegate(cfx_life_span_handler_on_after_created),
                Marshal.GetFunctionPointerForDelegate(cfx_life_span_handler_run_modal),
                Marshal.GetFunctionPointerForDelegate(cfx_life_span_handler_do_close),
                Marshal.GetFunctionPointerForDelegate(cfx_life_span_handler_on_before_close)
            );


            // cef_list_value

            cfx_list_value_create = (cfx_list_value_create_delegate)GetDelegate(libcfxPtr, "cfx_list_value_create", typeof(cfx_list_value_create_delegate));

            cfx_list_value_is_valid = (cfx_list_value_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_list_value_is_valid", typeof(cfx_list_value_is_valid_delegate));
            cfx_list_value_is_owned = (cfx_list_value_is_owned_delegate)GetDelegate(libcfxPtr, "cfx_list_value_is_owned", typeof(cfx_list_value_is_owned_delegate));
            cfx_list_value_is_read_only = (cfx_list_value_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_list_value_is_read_only", typeof(cfx_list_value_is_read_only_delegate));
            cfx_list_value_copy = (cfx_list_value_copy_delegate)GetDelegate(libcfxPtr, "cfx_list_value_copy", typeof(cfx_list_value_copy_delegate));
            cfx_list_value_set_size = (cfx_list_value_set_size_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_size", typeof(cfx_list_value_set_size_delegate));
            cfx_list_value_get_size = (cfx_list_value_get_size_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_size", typeof(cfx_list_value_get_size_delegate));
            cfx_list_value_clear = (cfx_list_value_clear_delegate)GetDelegate(libcfxPtr, "cfx_list_value_clear", typeof(cfx_list_value_clear_delegate));
            cfx_list_value_remove = (cfx_list_value_remove_delegate)GetDelegate(libcfxPtr, "cfx_list_value_remove", typeof(cfx_list_value_remove_delegate));
            cfx_list_value_get_type = (cfx_list_value_get_type_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_type", typeof(cfx_list_value_get_type_delegate));
            cfx_list_value_get_bool = (cfx_list_value_get_bool_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_bool", typeof(cfx_list_value_get_bool_delegate));
            cfx_list_value_get_int = (cfx_list_value_get_int_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_int", typeof(cfx_list_value_get_int_delegate));
            cfx_list_value_get_double = (cfx_list_value_get_double_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_double", typeof(cfx_list_value_get_double_delegate));
            cfx_list_value_get_string = (cfx_list_value_get_string_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_string", typeof(cfx_list_value_get_string_delegate));
            cfx_list_value_get_binary = (cfx_list_value_get_binary_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_binary", typeof(cfx_list_value_get_binary_delegate));
            cfx_list_value_get_dictionary = (cfx_list_value_get_dictionary_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_dictionary", typeof(cfx_list_value_get_dictionary_delegate));
            cfx_list_value_get_list = (cfx_list_value_get_list_delegate)GetDelegate(libcfxPtr, "cfx_list_value_get_list", typeof(cfx_list_value_get_list_delegate));
            cfx_list_value_set_null = (cfx_list_value_set_null_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_null", typeof(cfx_list_value_set_null_delegate));
            cfx_list_value_set_bool = (cfx_list_value_set_bool_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_bool", typeof(cfx_list_value_set_bool_delegate));
            cfx_list_value_set_int = (cfx_list_value_set_int_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_int", typeof(cfx_list_value_set_int_delegate));
            cfx_list_value_set_double = (cfx_list_value_set_double_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_double", typeof(cfx_list_value_set_double_delegate));
            cfx_list_value_set_string = (cfx_list_value_set_string_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_string", typeof(cfx_list_value_set_string_delegate));
            cfx_list_value_set_binary = (cfx_list_value_set_binary_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_binary", typeof(cfx_list_value_set_binary_delegate));
            cfx_list_value_set_dictionary = (cfx_list_value_set_dictionary_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_dictionary", typeof(cfx_list_value_set_dictionary_delegate));
            cfx_list_value_set_list = (cfx_list_value_set_list_delegate)GetDelegate(libcfxPtr, "cfx_list_value_set_list", typeof(cfx_list_value_set_list_delegate));


            // cef_load_handler

            cfx_load_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_load_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_load_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_load_handler_on_loading_state_change = CfxLoadHandler.on_loading_state_change;
            cfx_load_handler_on_load_start = CfxLoadHandler.on_load_start;
            cfx_load_handler_on_load_end = CfxLoadHandler.on_load_end;
            cfx_load_handler_on_load_error = CfxLoadHandler.on_load_error;

            var cfx_load_handler_set_callback_ptrs = (cfx_set_4_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_set_callback_ptrs", typeof(cfx_set_4_callback_ptrs_delegate));
            cfx_load_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_load_handler_on_loading_state_change),
                Marshal.GetFunctionPointerForDelegate(cfx_load_handler_on_load_start),
                Marshal.GetFunctionPointerForDelegate(cfx_load_handler_on_load_end),
                Marshal.GetFunctionPointerForDelegate(cfx_load_handler_on_load_error)
            );


            // cef_menu_model

            cfx_menu_model_clear = (cfx_menu_model_clear_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_clear", typeof(cfx_menu_model_clear_delegate));
            cfx_menu_model_get_count = (cfx_menu_model_get_count_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_count", typeof(cfx_menu_model_get_count_delegate));
            cfx_menu_model_add_separator = (cfx_menu_model_add_separator_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_add_separator", typeof(cfx_menu_model_add_separator_delegate));
            cfx_menu_model_add_item = (cfx_menu_model_add_item_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_add_item", typeof(cfx_menu_model_add_item_delegate));
            cfx_menu_model_add_check_item = (cfx_menu_model_add_check_item_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_add_check_item", typeof(cfx_menu_model_add_check_item_delegate));
            cfx_menu_model_add_radio_item = (cfx_menu_model_add_radio_item_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_add_radio_item", typeof(cfx_menu_model_add_radio_item_delegate));
            cfx_menu_model_add_sub_menu = (cfx_menu_model_add_sub_menu_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_add_sub_menu", typeof(cfx_menu_model_add_sub_menu_delegate));
            cfx_menu_model_insert_separator_at = (cfx_menu_model_insert_separator_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_insert_separator_at", typeof(cfx_menu_model_insert_separator_at_delegate));
            cfx_menu_model_insert_item_at = (cfx_menu_model_insert_item_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_insert_item_at", typeof(cfx_menu_model_insert_item_at_delegate));
            cfx_menu_model_insert_check_item_at = (cfx_menu_model_insert_check_item_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_insert_check_item_at", typeof(cfx_menu_model_insert_check_item_at_delegate));
            cfx_menu_model_insert_radio_item_at = (cfx_menu_model_insert_radio_item_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_insert_radio_item_at", typeof(cfx_menu_model_insert_radio_item_at_delegate));
            cfx_menu_model_insert_sub_menu_at = (cfx_menu_model_insert_sub_menu_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_insert_sub_menu_at", typeof(cfx_menu_model_insert_sub_menu_at_delegate));
            cfx_menu_model_remove = (cfx_menu_model_remove_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_remove", typeof(cfx_menu_model_remove_delegate));
            cfx_menu_model_remove_at = (cfx_menu_model_remove_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_remove_at", typeof(cfx_menu_model_remove_at_delegate));
            cfx_menu_model_get_index_of = (cfx_menu_model_get_index_of_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_index_of", typeof(cfx_menu_model_get_index_of_delegate));
            cfx_menu_model_get_command_id_at = (cfx_menu_model_get_command_id_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_command_id_at", typeof(cfx_menu_model_get_command_id_at_delegate));
            cfx_menu_model_set_command_id_at = (cfx_menu_model_set_command_id_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_command_id_at", typeof(cfx_menu_model_set_command_id_at_delegate));
            cfx_menu_model_get_label = (cfx_menu_model_get_label_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_label", typeof(cfx_menu_model_get_label_delegate));
            cfx_menu_model_get_label_at = (cfx_menu_model_get_label_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_label_at", typeof(cfx_menu_model_get_label_at_delegate));
            cfx_menu_model_set_label = (cfx_menu_model_set_label_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_label", typeof(cfx_menu_model_set_label_delegate));
            cfx_menu_model_set_label_at = (cfx_menu_model_set_label_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_label_at", typeof(cfx_menu_model_set_label_at_delegate));
            cfx_menu_model_get_type = (cfx_menu_model_get_type_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_type", typeof(cfx_menu_model_get_type_delegate));
            cfx_menu_model_get_type_at = (cfx_menu_model_get_type_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_type_at", typeof(cfx_menu_model_get_type_at_delegate));
            cfx_menu_model_get_group_id = (cfx_menu_model_get_group_id_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_group_id", typeof(cfx_menu_model_get_group_id_delegate));
            cfx_menu_model_get_group_id_at = (cfx_menu_model_get_group_id_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_group_id_at", typeof(cfx_menu_model_get_group_id_at_delegate));
            cfx_menu_model_set_group_id = (cfx_menu_model_set_group_id_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_group_id", typeof(cfx_menu_model_set_group_id_delegate));
            cfx_menu_model_set_group_id_at = (cfx_menu_model_set_group_id_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_group_id_at", typeof(cfx_menu_model_set_group_id_at_delegate));
            cfx_menu_model_get_sub_menu = (cfx_menu_model_get_sub_menu_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_sub_menu", typeof(cfx_menu_model_get_sub_menu_delegate));
            cfx_menu_model_get_sub_menu_at = (cfx_menu_model_get_sub_menu_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_sub_menu_at", typeof(cfx_menu_model_get_sub_menu_at_delegate));
            cfx_menu_model_is_visible = (cfx_menu_model_is_visible_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_visible", typeof(cfx_menu_model_is_visible_delegate));
            cfx_menu_model_is_visible_at = (cfx_menu_model_is_visible_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_visible_at", typeof(cfx_menu_model_is_visible_at_delegate));
            cfx_menu_model_set_visible = (cfx_menu_model_set_visible_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_visible", typeof(cfx_menu_model_set_visible_delegate));
            cfx_menu_model_set_visible_at = (cfx_menu_model_set_visible_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_visible_at", typeof(cfx_menu_model_set_visible_at_delegate));
            cfx_menu_model_is_enabled = (cfx_menu_model_is_enabled_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_enabled", typeof(cfx_menu_model_is_enabled_delegate));
            cfx_menu_model_is_enabled_at = (cfx_menu_model_is_enabled_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_enabled_at", typeof(cfx_menu_model_is_enabled_at_delegate));
            cfx_menu_model_set_enabled = (cfx_menu_model_set_enabled_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_enabled", typeof(cfx_menu_model_set_enabled_delegate));
            cfx_menu_model_set_enabled_at = (cfx_menu_model_set_enabled_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_enabled_at", typeof(cfx_menu_model_set_enabled_at_delegate));
            cfx_menu_model_is_checked = (cfx_menu_model_is_checked_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_checked", typeof(cfx_menu_model_is_checked_delegate));
            cfx_menu_model_is_checked_at = (cfx_menu_model_is_checked_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_is_checked_at", typeof(cfx_menu_model_is_checked_at_delegate));
            cfx_menu_model_set_checked = (cfx_menu_model_set_checked_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_checked", typeof(cfx_menu_model_set_checked_delegate));
            cfx_menu_model_set_checked_at = (cfx_menu_model_set_checked_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_checked_at", typeof(cfx_menu_model_set_checked_at_delegate));
            cfx_menu_model_has_accelerator = (cfx_menu_model_has_accelerator_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_has_accelerator", typeof(cfx_menu_model_has_accelerator_delegate));
            cfx_menu_model_has_accelerator_at = (cfx_menu_model_has_accelerator_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_has_accelerator_at", typeof(cfx_menu_model_has_accelerator_at_delegate));
            cfx_menu_model_set_accelerator = (cfx_menu_model_set_accelerator_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_accelerator", typeof(cfx_menu_model_set_accelerator_delegate));
            cfx_menu_model_set_accelerator_at = (cfx_menu_model_set_accelerator_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_set_accelerator_at", typeof(cfx_menu_model_set_accelerator_at_delegate));
            cfx_menu_model_remove_accelerator = (cfx_menu_model_remove_accelerator_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_remove_accelerator", typeof(cfx_menu_model_remove_accelerator_delegate));
            cfx_menu_model_remove_accelerator_at = (cfx_menu_model_remove_accelerator_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_remove_accelerator_at", typeof(cfx_menu_model_remove_accelerator_at_delegate));
            cfx_menu_model_get_accelerator = (cfx_menu_model_get_accelerator_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_accelerator", typeof(cfx_menu_model_get_accelerator_delegate));
            cfx_menu_model_get_accelerator_at = (cfx_menu_model_get_accelerator_at_delegate)GetDelegate(libcfxPtr, "cfx_menu_model_get_accelerator_at", typeof(cfx_menu_model_get_accelerator_at_delegate));


            // cef_mouse_event

            cfx_mouse_event_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_ctor", typeof(cfx_ctor_delegate));
            cfx_mouse_event_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_dtor", typeof(cfx_dtor_delegate));

            cfx_mouse_event_copy_to_native = (cfx_mouse_event_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_copy_to_native", typeof(cfx_mouse_event_copy_to_native_delegate));


            // cef_popup_features

            cfx_popup_features_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_ctor", typeof(cfx_ctor_delegate));
            cfx_popup_features_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_dtor", typeof(cfx_dtor_delegate));

            cfx_popup_features_copy_to_native = (cfx_popup_features_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_copy_to_native", typeof(cfx_popup_features_copy_to_native_delegate));
            cfx_popup_features_copy_to_managed = (cfx_popup_features_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_copy_to_managed", typeof(cfx_popup_features_copy_to_managed_delegate));


            // cef_post_data

            cfx_post_data_create = (cfx_post_data_create_delegate)GetDelegate(libcfxPtr, "cfx_post_data_create", typeof(cfx_post_data_create_delegate));

            cfx_post_data_is_read_only = (cfx_post_data_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_post_data_is_read_only", typeof(cfx_post_data_is_read_only_delegate));
            cfx_post_data_get_element_count = (cfx_post_data_get_element_count_delegate)GetDelegate(libcfxPtr, "cfx_post_data_get_element_count", typeof(cfx_post_data_get_element_count_delegate));
            cfx_post_data_get_elements = (cfx_post_data_get_elements_delegate)GetDelegate(libcfxPtr, "cfx_post_data_get_elements", typeof(cfx_post_data_get_elements_delegate));
            cfx_post_data_remove_element = (cfx_post_data_remove_element_delegate)GetDelegate(libcfxPtr, "cfx_post_data_remove_element", typeof(cfx_post_data_remove_element_delegate));
            cfx_post_data_add_element = (cfx_post_data_add_element_delegate)GetDelegate(libcfxPtr, "cfx_post_data_add_element", typeof(cfx_post_data_add_element_delegate));
            cfx_post_data_remove_elements = (cfx_post_data_remove_elements_delegate)GetDelegate(libcfxPtr, "cfx_post_data_remove_elements", typeof(cfx_post_data_remove_elements_delegate));


            // cef_post_data_element

            cfx_post_data_element_create = (cfx_post_data_element_create_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_create", typeof(cfx_post_data_element_create_delegate));

            cfx_post_data_element_is_read_only = (cfx_post_data_element_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_is_read_only", typeof(cfx_post_data_element_is_read_only_delegate));
            cfx_post_data_element_set_to_empty = (cfx_post_data_element_set_to_empty_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_set_to_empty", typeof(cfx_post_data_element_set_to_empty_delegate));
            cfx_post_data_element_set_to_file = (cfx_post_data_element_set_to_file_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_set_to_file", typeof(cfx_post_data_element_set_to_file_delegate));
            cfx_post_data_element_set_to_bytes = (cfx_post_data_element_set_to_bytes_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_set_to_bytes", typeof(cfx_post_data_element_set_to_bytes_delegate));
            cfx_post_data_element_get_type = (cfx_post_data_element_get_type_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_get_type", typeof(cfx_post_data_element_get_type_delegate));
            cfx_post_data_element_get_file = (cfx_post_data_element_get_file_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_get_file", typeof(cfx_post_data_element_get_file_delegate));
            cfx_post_data_element_get_bytes_count = (cfx_post_data_element_get_bytes_count_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_get_bytes_count", typeof(cfx_post_data_element_get_bytes_count_delegate));
            cfx_post_data_element_get_bytes = (cfx_post_data_element_get_bytes_delegate)GetDelegate(libcfxPtr, "cfx_post_data_element_get_bytes", typeof(cfx_post_data_element_get_bytes_delegate));


            // cef_process_message

            cfx_process_message_create = (cfx_process_message_create_delegate)GetDelegate(libcfxPtr, "cfx_process_message_create", typeof(cfx_process_message_create_delegate));

            cfx_process_message_is_valid = (cfx_process_message_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_process_message_is_valid", typeof(cfx_process_message_is_valid_delegate));
            cfx_process_message_is_read_only = (cfx_process_message_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_process_message_is_read_only", typeof(cfx_process_message_is_read_only_delegate));
            cfx_process_message_copy = (cfx_process_message_copy_delegate)GetDelegate(libcfxPtr, "cfx_process_message_copy", typeof(cfx_process_message_copy_delegate));
            cfx_process_message_get_name = (cfx_process_message_get_name_delegate)GetDelegate(libcfxPtr, "cfx_process_message_get_name", typeof(cfx_process_message_get_name_delegate));
            cfx_process_message_get_argument_list = (cfx_process_message_get_argument_list_delegate)GetDelegate(libcfxPtr, "cfx_process_message_get_argument_list", typeof(cfx_process_message_get_argument_list_delegate));


            // cef_quota_callback

            cfx_quota_callback_cont = (cfx_quota_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_quota_callback_cont", typeof(cfx_quota_callback_cont_delegate));
            cfx_quota_callback_cancel = (cfx_quota_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_quota_callback_cancel", typeof(cfx_quota_callback_cancel_delegate));


            // cef_read_handler

            cfx_read_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_read_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_read_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_read_handler_read = CfxReadHandler.read;
            cfx_read_handler_seek = CfxReadHandler.seek;
            cfx_read_handler_tell = CfxReadHandler.tell;
            cfx_read_handler_eof = CfxReadHandler.eof;
            cfx_read_handler_may_block = CfxReadHandler.may_block;

            var cfx_read_handler_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_read_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_read_handler_read),
                Marshal.GetFunctionPointerForDelegate(cfx_read_handler_seek),
                Marshal.GetFunctionPointerForDelegate(cfx_read_handler_tell),
                Marshal.GetFunctionPointerForDelegate(cfx_read_handler_eof),
                Marshal.GetFunctionPointerForDelegate(cfx_read_handler_may_block)
            );


            // cef_rect

            cfx_rect_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_rect_ctor", typeof(cfx_ctor_delegate));
            cfx_rect_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_rect_dtor", typeof(cfx_dtor_delegate));

            cfx_rect_copy_to_native = (cfx_rect_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_rect_copy_to_native", typeof(cfx_rect_copy_to_native_delegate));
            cfx_rect_copy_to_managed = (cfx_rect_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_rect_copy_to_managed", typeof(cfx_rect_copy_to_managed_delegate));


            // cef_render_handler

            cfx_render_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_render_handler_get_root_screen_rect = CfxRenderHandler.get_root_screen_rect;
            cfx_render_handler_get_view_rect = CfxRenderHandler.get_view_rect;
            cfx_render_handler_get_screen_point = CfxRenderHandler.get_screen_point;
            cfx_render_handler_get_screen_info = CfxRenderHandler.get_screen_info;
            cfx_render_handler_on_popup_show = CfxRenderHandler.on_popup_show;
            cfx_render_handler_on_popup_size = CfxRenderHandler.on_popup_size;
            cfx_render_handler_on_paint = CfxRenderHandler.on_paint;
            cfx_render_handler_on_cursor_change = CfxRenderHandler.on_cursor_change;
            cfx_render_handler_on_scroll_offset_changed = CfxRenderHandler.on_scroll_offset_changed;

            var cfx_render_handler_set_callback_ptrs = (cfx_set_9_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_set_callback_ptrs", typeof(cfx_set_9_callback_ptrs_delegate));
            cfx_render_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_get_root_screen_rect),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_get_view_rect),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_get_screen_point),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_get_screen_info),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_on_popup_show),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_on_popup_size),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_on_paint),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_on_cursor_change),
                Marshal.GetFunctionPointerForDelegate(cfx_render_handler_on_scroll_offset_changed)
            );


            // cef_render_process_handler

            cfx_render_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_process_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_render_process_handler_on_render_thread_created = CfxRenderProcessHandler.on_render_thread_created;
            cfx_render_process_handler_on_web_kit_initialized = CfxRenderProcessHandler.on_web_kit_initialized;
            cfx_render_process_handler_on_browser_created = CfxRenderProcessHandler.on_browser_created;
            cfx_render_process_handler_on_browser_destroyed = CfxRenderProcessHandler.on_browser_destroyed;
            cfx_render_process_handler_get_load_handler = CfxRenderProcessHandler.get_load_handler;
            cfx_render_process_handler_on_before_navigation = CfxRenderProcessHandler.on_before_navigation;
            cfx_render_process_handler_on_context_created = CfxRenderProcessHandler.on_context_created;
            cfx_render_process_handler_on_context_released = CfxRenderProcessHandler.on_context_released;
            cfx_render_process_handler_on_uncaught_exception = CfxRenderProcessHandler.on_uncaught_exception;
            cfx_render_process_handler_on_focused_node_changed = CfxRenderProcessHandler.on_focused_node_changed;
            cfx_render_process_handler_on_process_message_received = CfxRenderProcessHandler.on_process_message_received;

            var cfx_render_process_handler_set_callback_ptrs = (cfx_set_11_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_set_callback_ptrs", typeof(cfx_set_11_callback_ptrs_delegate));
            cfx_render_process_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_render_thread_created),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_web_kit_initialized),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_browser_created),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_browser_destroyed),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_get_load_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_before_navigation),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_context_created),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_context_released),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_uncaught_exception),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_focused_node_changed),
                Marshal.GetFunctionPointerForDelegate(cfx_render_process_handler_on_process_message_received)
            );


            // cef_request

            cfx_request_create = (cfx_request_create_delegate)GetDelegate(libcfxPtr, "cfx_request_create", typeof(cfx_request_create_delegate));

            cfx_request_is_read_only = (cfx_request_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_request_is_read_only", typeof(cfx_request_is_read_only_delegate));
            cfx_request_get_url = (cfx_request_get_url_delegate)GetDelegate(libcfxPtr, "cfx_request_get_url", typeof(cfx_request_get_url_delegate));
            cfx_request_set_url = (cfx_request_set_url_delegate)GetDelegate(libcfxPtr, "cfx_request_set_url", typeof(cfx_request_set_url_delegate));
            cfx_request_get_method = (cfx_request_get_method_delegate)GetDelegate(libcfxPtr, "cfx_request_get_method", typeof(cfx_request_get_method_delegate));
            cfx_request_set_method = (cfx_request_set_method_delegate)GetDelegate(libcfxPtr, "cfx_request_set_method", typeof(cfx_request_set_method_delegate));
            cfx_request_get_post_data = (cfx_request_get_post_data_delegate)GetDelegate(libcfxPtr, "cfx_request_get_post_data", typeof(cfx_request_get_post_data_delegate));
            cfx_request_set_post_data = (cfx_request_set_post_data_delegate)GetDelegate(libcfxPtr, "cfx_request_set_post_data", typeof(cfx_request_set_post_data_delegate));
            cfx_request_get_header_map = (cfx_request_get_header_map_delegate)GetDelegate(libcfxPtr, "cfx_request_get_header_map", typeof(cfx_request_get_header_map_delegate));
            cfx_request_set_header_map = (cfx_request_set_header_map_delegate)GetDelegate(libcfxPtr, "cfx_request_set_header_map", typeof(cfx_request_set_header_map_delegate));
            cfx_request_set = (cfx_request_set_delegate)GetDelegate(libcfxPtr, "cfx_request_set", typeof(cfx_request_set_delegate));
            cfx_request_get_flags = (cfx_request_get_flags_delegate)GetDelegate(libcfxPtr, "cfx_request_get_flags", typeof(cfx_request_get_flags_delegate));
            cfx_request_set_flags = (cfx_request_set_flags_delegate)GetDelegate(libcfxPtr, "cfx_request_set_flags", typeof(cfx_request_set_flags_delegate));
            cfx_request_get_first_party_for_cookies = (cfx_request_get_first_party_for_cookies_delegate)GetDelegate(libcfxPtr, "cfx_request_get_first_party_for_cookies", typeof(cfx_request_get_first_party_for_cookies_delegate));
            cfx_request_set_first_party_for_cookies = (cfx_request_set_first_party_for_cookies_delegate)GetDelegate(libcfxPtr, "cfx_request_set_first_party_for_cookies", typeof(cfx_request_set_first_party_for_cookies_delegate));
            cfx_request_get_resource_type = (cfx_request_get_resource_type_delegate)GetDelegate(libcfxPtr, "cfx_request_get_resource_type", typeof(cfx_request_get_resource_type_delegate));
            cfx_request_get_transition_type = (cfx_request_get_transition_type_delegate)GetDelegate(libcfxPtr, "cfx_request_get_transition_type", typeof(cfx_request_get_transition_type_delegate));


            // cef_request_context

            cfx_request_context_get_global_context = (cfx_request_context_get_global_context_delegate)GetDelegate(libcfxPtr, "cfx_request_context_get_global_context", typeof(cfx_request_context_get_global_context_delegate));
            cfx_request_context_create_context = (cfx_request_context_create_context_delegate)GetDelegate(libcfxPtr, "cfx_request_context_create_context", typeof(cfx_request_context_create_context_delegate));

            cfx_request_context_is_same = (cfx_request_context_is_same_delegate)GetDelegate(libcfxPtr, "cfx_request_context_is_same", typeof(cfx_request_context_is_same_delegate));
            cfx_request_context_is_global = (cfx_request_context_is_global_delegate)GetDelegate(libcfxPtr, "cfx_request_context_is_global", typeof(cfx_request_context_is_global_delegate));
            cfx_request_context_get_handler = (cfx_request_context_get_handler_delegate)GetDelegate(libcfxPtr, "cfx_request_context_get_handler", typeof(cfx_request_context_get_handler_delegate));


            // cef_request_context_handler

            cfx_request_context_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_context_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_request_context_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_context_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_request_context_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_request_context_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_request_context_handler_get_cookie_manager = CfxRequestContextHandler.get_cookie_manager;

            var cfx_request_context_handler_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_request_context_handler_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_request_context_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_request_context_handler_get_cookie_manager)
            );


            // cef_request_handler

            cfx_request_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_request_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_request_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_request_handler_on_before_browse = CfxRequestHandler.on_before_browse;
            cfx_request_handler_on_before_resource_load = CfxRequestHandler.on_before_resource_load;
            cfx_request_handler_get_resource_handler = CfxRequestHandler.get_resource_handler;
            cfx_request_handler_on_resource_redirect = CfxRequestHandler.on_resource_redirect;
            cfx_request_handler_get_auth_credentials = CfxRequestHandler.get_auth_credentials;
            cfx_request_handler_on_quota_request = CfxRequestHandler.on_quota_request;
            cfx_request_handler_on_protocol_execution = CfxRequestHandler.on_protocol_execution;
            cfx_request_handler_on_certificate_error = CfxRequestHandler.on_certificate_error;
            cfx_request_handler_on_before_plugin_load = CfxRequestHandler.on_before_plugin_load;
            cfx_request_handler_on_plugin_crashed = CfxRequestHandler.on_plugin_crashed;
            cfx_request_handler_on_render_process_terminated = CfxRequestHandler.on_render_process_terminated;

            var cfx_request_handler_set_callback_ptrs = (cfx_set_11_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_set_callback_ptrs", typeof(cfx_set_11_callback_ptrs_delegate));
            cfx_request_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_browse),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_resource_load),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_get_resource_handler),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_resource_redirect),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_get_auth_credentials),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_quota_request),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_protocol_execution),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_certificate_error),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_before_plugin_load),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_plugin_crashed),
                Marshal.GetFunctionPointerForDelegate(cfx_request_handler_on_render_process_terminated)
            );


            // cef_resource_bundle_handler

            cfx_resource_bundle_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_resource_bundle_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_resource_bundle_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_resource_bundle_handler_get_localized_string = CfxResourceBundleHandler.get_localized_string;
            cfx_resource_bundle_handler_get_data_resource = CfxResourceBundleHandler.get_data_resource;

            var cfx_resource_bundle_handler_set_callback_ptrs = (cfx_set_2_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_set_callback_ptrs", typeof(cfx_set_2_callback_ptrs_delegate));
            cfx_resource_bundle_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_resource_bundle_handler_get_localized_string),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_bundle_handler_get_data_resource)
            );


            // cef_resource_handler

            cfx_resource_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_resource_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_resource_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_resource_handler_process_request = CfxResourceHandler.process_request;
            cfx_resource_handler_get_response_headers = CfxResourceHandler.get_response_headers;
            cfx_resource_handler_read_response = CfxResourceHandler.read_response;
            cfx_resource_handler_can_get_cookie = CfxResourceHandler.can_get_cookie;
            cfx_resource_handler_can_set_cookie = CfxResourceHandler.can_set_cookie;
            cfx_resource_handler_cancel = CfxResourceHandler.cancel;

            var cfx_resource_handler_set_callback_ptrs = (cfx_set_6_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_set_callback_ptrs", typeof(cfx_set_6_callback_ptrs_delegate));
            cfx_resource_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_process_request),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_get_response_headers),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_read_response),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_can_get_cookie),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_can_set_cookie),
                Marshal.GetFunctionPointerForDelegate(cfx_resource_handler_cancel)
            );


            // cef_response

            cfx_response_create = (cfx_response_create_delegate)GetDelegate(libcfxPtr, "cfx_response_create", typeof(cfx_response_create_delegate));

            cfx_response_is_read_only = (cfx_response_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_response_is_read_only", typeof(cfx_response_is_read_only_delegate));
            cfx_response_get_status = (cfx_response_get_status_delegate)GetDelegate(libcfxPtr, "cfx_response_get_status", typeof(cfx_response_get_status_delegate));
            cfx_response_set_status = (cfx_response_set_status_delegate)GetDelegate(libcfxPtr, "cfx_response_set_status", typeof(cfx_response_set_status_delegate));
            cfx_response_get_status_text = (cfx_response_get_status_text_delegate)GetDelegate(libcfxPtr, "cfx_response_get_status_text", typeof(cfx_response_get_status_text_delegate));
            cfx_response_set_status_text = (cfx_response_set_status_text_delegate)GetDelegate(libcfxPtr, "cfx_response_set_status_text", typeof(cfx_response_set_status_text_delegate));
            cfx_response_get_mime_type = (cfx_response_get_mime_type_delegate)GetDelegate(libcfxPtr, "cfx_response_get_mime_type", typeof(cfx_response_get_mime_type_delegate));
            cfx_response_set_mime_type = (cfx_response_set_mime_type_delegate)GetDelegate(libcfxPtr, "cfx_response_set_mime_type", typeof(cfx_response_set_mime_type_delegate));
            cfx_response_get_header = (cfx_response_get_header_delegate)GetDelegate(libcfxPtr, "cfx_response_get_header", typeof(cfx_response_get_header_delegate));
            cfx_response_get_header_map = (cfx_response_get_header_map_delegate)GetDelegate(libcfxPtr, "cfx_response_get_header_map", typeof(cfx_response_get_header_map_delegate));
            cfx_response_set_header_map = (cfx_response_set_header_map_delegate)GetDelegate(libcfxPtr, "cfx_response_set_header_map", typeof(cfx_response_set_header_map_delegate));


            // cef_run_file_dialog_callback

            cfx_run_file_dialog_callback_cont = (cfx_run_file_dialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_run_file_dialog_callback_cont", typeof(cfx_run_file_dialog_callback_cont_delegate));


            // cef_scheme_handler_factory

            cfx_scheme_handler_factory_create = (cfx_scheme_handler_factory_create_delegate)GetDelegate(libcfxPtr, "cfx_scheme_handler_factory_create", typeof(cfx_scheme_handler_factory_create_delegate));


            // cef_scheme_registrar

            cfx_scheme_registrar_add_custom_scheme = (cfx_scheme_registrar_add_custom_scheme_delegate)GetDelegate(libcfxPtr, "cfx_scheme_registrar_add_custom_scheme", typeof(cfx_scheme_registrar_add_custom_scheme_delegate));


            // cef_screen_info

            cfx_screen_info_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_ctor", typeof(cfx_ctor_delegate));
            cfx_screen_info_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_dtor", typeof(cfx_dtor_delegate));

            cfx_screen_info_copy_to_native = (cfx_screen_info_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_copy_to_native", typeof(cfx_screen_info_copy_to_native_delegate));
            cfx_screen_info_copy_to_managed = (cfx_screen_info_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_copy_to_managed", typeof(cfx_screen_info_copy_to_managed_delegate));


            // cef_settings

            cfx_settings_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_settings_ctor", typeof(cfx_ctor_delegate));
            cfx_settings_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_settings_dtor", typeof(cfx_dtor_delegate));

            cfx_settings_copy_to_native = (cfx_settings_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_settings_copy_to_native", typeof(cfx_settings_copy_to_native_delegate));


            // cef_stream_reader

            cfx_stream_reader_create_for_file = (cfx_stream_reader_create_for_file_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_create_for_file", typeof(cfx_stream_reader_create_for_file_delegate));
            cfx_stream_reader_create_for_data = (cfx_stream_reader_create_for_data_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_create_for_data", typeof(cfx_stream_reader_create_for_data_delegate));
            cfx_stream_reader_create_for_handler = (cfx_stream_reader_create_for_handler_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_create_for_handler", typeof(cfx_stream_reader_create_for_handler_delegate));

            cfx_stream_reader_read = (cfx_stream_reader_read_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_read", typeof(cfx_stream_reader_read_delegate));
            cfx_stream_reader_seek = (cfx_stream_reader_seek_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_seek", typeof(cfx_stream_reader_seek_delegate));
            cfx_stream_reader_tell = (cfx_stream_reader_tell_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_tell", typeof(cfx_stream_reader_tell_delegate));
            cfx_stream_reader_eof = (cfx_stream_reader_eof_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_eof", typeof(cfx_stream_reader_eof_delegate));
            cfx_stream_reader_may_block = (cfx_stream_reader_may_block_delegate)GetDelegate(libcfxPtr, "cfx_stream_reader_may_block", typeof(cfx_stream_reader_may_block_delegate));


            // cef_stream_writer

            cfx_stream_writer_create_for_file = (cfx_stream_writer_create_for_file_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_create_for_file", typeof(cfx_stream_writer_create_for_file_delegate));
            cfx_stream_writer_create_for_handler = (cfx_stream_writer_create_for_handler_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_create_for_handler", typeof(cfx_stream_writer_create_for_handler_delegate));

            cfx_stream_writer_write = (cfx_stream_writer_write_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_write", typeof(cfx_stream_writer_write_delegate));
            cfx_stream_writer_seek = (cfx_stream_writer_seek_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_seek", typeof(cfx_stream_writer_seek_delegate));
            cfx_stream_writer_tell = (cfx_stream_writer_tell_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_tell", typeof(cfx_stream_writer_tell_delegate));
            cfx_stream_writer_flush = (cfx_stream_writer_flush_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_flush", typeof(cfx_stream_writer_flush_delegate));
            cfx_stream_writer_may_block = (cfx_stream_writer_may_block_delegate)GetDelegate(libcfxPtr, "cfx_stream_writer_may_block", typeof(cfx_stream_writer_may_block_delegate));


            // cef_string_visitor

            cfx_string_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_string_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_string_visitor_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_string_visitor_visit = CfxStringVisitor.visit;

            var cfx_string_visitor_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_string_visitor_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_string_visitor_visit)
            );


            // cef_task

            cfx_task_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_task_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_task_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_task_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_task_execute = CfxTask.execute;

            var cfx_task_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_task_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_task_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_task_execute)
            );


            // cef_task_runner

            cfx_task_runner_get_for_current_thread = (cfx_task_runner_get_for_current_thread_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_get_for_current_thread", typeof(cfx_task_runner_get_for_current_thread_delegate));
            cfx_task_runner_get_for_thread = (cfx_task_runner_get_for_thread_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_get_for_thread", typeof(cfx_task_runner_get_for_thread_delegate));

            cfx_task_runner_is_same = (cfx_task_runner_is_same_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_is_same", typeof(cfx_task_runner_is_same_delegate));
            cfx_task_runner_belongs_to_current_thread = (cfx_task_runner_belongs_to_current_thread_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_belongs_to_current_thread", typeof(cfx_task_runner_belongs_to_current_thread_delegate));
            cfx_task_runner_belongs_to_thread = (cfx_task_runner_belongs_to_thread_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_belongs_to_thread", typeof(cfx_task_runner_belongs_to_thread_delegate));
            cfx_task_runner_post_task = (cfx_task_runner_post_task_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_post_task", typeof(cfx_task_runner_post_task_delegate));
            cfx_task_runner_post_delayed_task = (cfx_task_runner_post_delayed_task_delegate)GetDelegate(libcfxPtr, "cfx_task_runner_post_delayed_task", typeof(cfx_task_runner_post_delayed_task_delegate));


            // cef_time

            cfx_time_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_time_ctor", typeof(cfx_ctor_delegate));
            cfx_time_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_time_dtor", typeof(cfx_dtor_delegate));

            cfx_time_copy_to_native = (cfx_time_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_time_copy_to_native", typeof(cfx_time_copy_to_native_delegate));
            cfx_time_copy_to_managed = (cfx_time_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_time_copy_to_managed", typeof(cfx_time_copy_to_managed_delegate));


            // cef_urlparts

            cfx_urlparts_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_ctor", typeof(cfx_ctor_delegate));
            cfx_urlparts_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_dtor", typeof(cfx_dtor_delegate));

            cfx_urlparts_copy_to_native = (cfx_urlparts_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_copy_to_native", typeof(cfx_urlparts_copy_to_native_delegate));


            // cef_urlrequest

            cfx_urlrequest_create = (cfx_urlrequest_create_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_create", typeof(cfx_urlrequest_create_delegate));

            cfx_urlrequest_get_request = (cfx_urlrequest_get_request_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_get_request", typeof(cfx_urlrequest_get_request_delegate));
            cfx_urlrequest_get_client = (cfx_urlrequest_get_client_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_get_client", typeof(cfx_urlrequest_get_client_delegate));
            cfx_urlrequest_get_request_status = (cfx_urlrequest_get_request_status_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_get_request_status", typeof(cfx_urlrequest_get_request_status_delegate));
            cfx_urlrequest_get_request_error = (cfx_urlrequest_get_request_error_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_get_request_error", typeof(cfx_urlrequest_get_request_error_delegate));
            cfx_urlrequest_get_response = (cfx_urlrequest_get_response_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_get_response", typeof(cfx_urlrequest_get_response_delegate));
            cfx_urlrequest_cancel = (cfx_urlrequest_cancel_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_cancel", typeof(cfx_urlrequest_cancel_delegate));


            // cef_urlrequest_client

            cfx_urlrequest_client_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_urlrequest_client_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_urlrequest_client_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_urlrequest_client_on_request_complete = CfxUrlRequestClient.on_request_complete;
            cfx_urlrequest_client_on_upload_progress = CfxUrlRequestClient.on_upload_progress;
            cfx_urlrequest_client_on_download_progress = CfxUrlRequestClient.on_download_progress;
            cfx_urlrequest_client_on_download_data = CfxUrlRequestClient.on_download_data;
            cfx_urlrequest_client_get_auth_credentials = CfxUrlRequestClient.get_auth_credentials;

            var cfx_urlrequest_client_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_urlrequest_client_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_urlrequest_client_on_request_complete),
                Marshal.GetFunctionPointerForDelegate(cfx_urlrequest_client_on_upload_progress),
                Marshal.GetFunctionPointerForDelegate(cfx_urlrequest_client_on_download_progress),
                Marshal.GetFunctionPointerForDelegate(cfx_urlrequest_client_on_download_data),
                Marshal.GetFunctionPointerForDelegate(cfx_urlrequest_client_get_auth_credentials)
            );


            // cef_v8accessor

            cfx_v8accessor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_v8accessor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_v8accessor_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_v8accessor_get = CfxV8Accessor.get;
            cfx_v8accessor_set = CfxV8Accessor.set;

            var cfx_v8accessor_set_callback_ptrs = (cfx_set_2_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_set_callback_ptrs", typeof(cfx_set_2_callback_ptrs_delegate));
            cfx_v8accessor_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_v8accessor_get),
                Marshal.GetFunctionPointerForDelegate(cfx_v8accessor_set)
            );


            // cef_v8context

            cfx_v8context_get_current_context = (cfx_v8context_get_current_context_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_current_context", typeof(cfx_v8context_get_current_context_delegate));
            cfx_v8context_get_entered_context = (cfx_v8context_get_entered_context_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_entered_context", typeof(cfx_v8context_get_entered_context_delegate));
            cfx_v8context_in_context = (cfx_v8context_in_context_delegate)GetDelegate(libcfxPtr, "cfx_v8context_in_context", typeof(cfx_v8context_in_context_delegate));

            cfx_v8context_get_task_runner = (cfx_v8context_get_task_runner_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_task_runner", typeof(cfx_v8context_get_task_runner_delegate));
            cfx_v8context_is_valid = (cfx_v8context_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_v8context_is_valid", typeof(cfx_v8context_is_valid_delegate));
            cfx_v8context_get_browser = (cfx_v8context_get_browser_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_browser", typeof(cfx_v8context_get_browser_delegate));
            cfx_v8context_get_frame = (cfx_v8context_get_frame_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_frame", typeof(cfx_v8context_get_frame_delegate));
            cfx_v8context_get_global = (cfx_v8context_get_global_delegate)GetDelegate(libcfxPtr, "cfx_v8context_get_global", typeof(cfx_v8context_get_global_delegate));
            cfx_v8context_enter = (cfx_v8context_enter_delegate)GetDelegate(libcfxPtr, "cfx_v8context_enter", typeof(cfx_v8context_enter_delegate));
            cfx_v8context_exit = (cfx_v8context_exit_delegate)GetDelegate(libcfxPtr, "cfx_v8context_exit", typeof(cfx_v8context_exit_delegate));
            cfx_v8context_is_same = (cfx_v8context_is_same_delegate)GetDelegate(libcfxPtr, "cfx_v8context_is_same", typeof(cfx_v8context_is_same_delegate));
            cfx_v8context_eval = (cfx_v8context_eval_delegate)GetDelegate(libcfxPtr, "cfx_v8context_eval", typeof(cfx_v8context_eval_delegate));


            // cef_v8exception

            cfx_v8exception_get_message = (cfx_v8exception_get_message_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_message", typeof(cfx_v8exception_get_message_delegate));
            cfx_v8exception_get_source_line = (cfx_v8exception_get_source_line_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_source_line", typeof(cfx_v8exception_get_source_line_delegate));
            cfx_v8exception_get_script_resource_name = (cfx_v8exception_get_script_resource_name_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_script_resource_name", typeof(cfx_v8exception_get_script_resource_name_delegate));
            cfx_v8exception_get_line_number = (cfx_v8exception_get_line_number_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_line_number", typeof(cfx_v8exception_get_line_number_delegate));
            cfx_v8exception_get_start_position = (cfx_v8exception_get_start_position_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_start_position", typeof(cfx_v8exception_get_start_position_delegate));
            cfx_v8exception_get_end_position = (cfx_v8exception_get_end_position_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_end_position", typeof(cfx_v8exception_get_end_position_delegate));
            cfx_v8exception_get_start_column = (cfx_v8exception_get_start_column_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_start_column", typeof(cfx_v8exception_get_start_column_delegate));
            cfx_v8exception_get_end_column = (cfx_v8exception_get_end_column_delegate)GetDelegate(libcfxPtr, "cfx_v8exception_get_end_column", typeof(cfx_v8exception_get_end_column_delegate));


            // cef_v8handler

            cfx_v8handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_v8handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_v8handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_v8handler_execute = CfxV8Handler.execute;

            var cfx_v8handler_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_v8handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_v8handler_execute)
            );


            // cef_v8stack_frame

            cfx_v8stack_frame_is_valid = (cfx_v8stack_frame_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_is_valid", typeof(cfx_v8stack_frame_is_valid_delegate));
            cfx_v8stack_frame_get_script_name = (cfx_v8stack_frame_get_script_name_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_get_script_name", typeof(cfx_v8stack_frame_get_script_name_delegate));
            cfx_v8stack_frame_get_script_name_or_source_url = (cfx_v8stack_frame_get_script_name_or_source_url_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_get_script_name_or_source_url", typeof(cfx_v8stack_frame_get_script_name_or_source_url_delegate));
            cfx_v8stack_frame_get_function_name = (cfx_v8stack_frame_get_function_name_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_get_function_name", typeof(cfx_v8stack_frame_get_function_name_delegate));
            cfx_v8stack_frame_get_line_number = (cfx_v8stack_frame_get_line_number_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_get_line_number", typeof(cfx_v8stack_frame_get_line_number_delegate));
            cfx_v8stack_frame_get_column = (cfx_v8stack_frame_get_column_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_get_column", typeof(cfx_v8stack_frame_get_column_delegate));
            cfx_v8stack_frame_is_eval = (cfx_v8stack_frame_is_eval_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_is_eval", typeof(cfx_v8stack_frame_is_eval_delegate));
            cfx_v8stack_frame_is_constructor = (cfx_v8stack_frame_is_constructor_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_frame_is_constructor", typeof(cfx_v8stack_frame_is_constructor_delegate));


            // cef_v8stack_trace

            cfx_v8stack_trace_get_current = (cfx_v8stack_trace_get_current_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_trace_get_current", typeof(cfx_v8stack_trace_get_current_delegate));

            cfx_v8stack_trace_is_valid = (cfx_v8stack_trace_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_trace_is_valid", typeof(cfx_v8stack_trace_is_valid_delegate));
            cfx_v8stack_trace_get_frame_count = (cfx_v8stack_trace_get_frame_count_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_trace_get_frame_count", typeof(cfx_v8stack_trace_get_frame_count_delegate));
            cfx_v8stack_trace_get_frame = (cfx_v8stack_trace_get_frame_delegate)GetDelegate(libcfxPtr, "cfx_v8stack_trace_get_frame", typeof(cfx_v8stack_trace_get_frame_delegate));


            // cef_v8value

            cfx_v8value_create_undefined = (cfx_v8value_create_undefined_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_undefined", typeof(cfx_v8value_create_undefined_delegate));
            cfx_v8value_create_null = (cfx_v8value_create_null_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_null", typeof(cfx_v8value_create_null_delegate));
            cfx_v8value_create_bool = (cfx_v8value_create_bool_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_bool", typeof(cfx_v8value_create_bool_delegate));
            cfx_v8value_create_int = (cfx_v8value_create_int_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_int", typeof(cfx_v8value_create_int_delegate));
            cfx_v8value_create_uint = (cfx_v8value_create_uint_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_uint", typeof(cfx_v8value_create_uint_delegate));
            cfx_v8value_create_double = (cfx_v8value_create_double_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_double", typeof(cfx_v8value_create_double_delegate));
            cfx_v8value_create_date = (cfx_v8value_create_date_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_date", typeof(cfx_v8value_create_date_delegate));
            cfx_v8value_create_string = (cfx_v8value_create_string_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_string", typeof(cfx_v8value_create_string_delegate));
            cfx_v8value_create_object = (cfx_v8value_create_object_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_object", typeof(cfx_v8value_create_object_delegate));
            cfx_v8value_create_array = (cfx_v8value_create_array_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_array", typeof(cfx_v8value_create_array_delegate));
            cfx_v8value_create_function = (cfx_v8value_create_function_delegate)GetDelegate(libcfxPtr, "cfx_v8value_create_function", typeof(cfx_v8value_create_function_delegate));

            cfx_v8value_is_valid = (cfx_v8value_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_valid", typeof(cfx_v8value_is_valid_delegate));
            cfx_v8value_is_undefined = (cfx_v8value_is_undefined_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_undefined", typeof(cfx_v8value_is_undefined_delegate));
            cfx_v8value_is_null = (cfx_v8value_is_null_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_null", typeof(cfx_v8value_is_null_delegate));
            cfx_v8value_is_bool = (cfx_v8value_is_bool_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_bool", typeof(cfx_v8value_is_bool_delegate));
            cfx_v8value_is_int = (cfx_v8value_is_int_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_int", typeof(cfx_v8value_is_int_delegate));
            cfx_v8value_is_uint = (cfx_v8value_is_uint_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_uint", typeof(cfx_v8value_is_uint_delegate));
            cfx_v8value_is_double = (cfx_v8value_is_double_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_double", typeof(cfx_v8value_is_double_delegate));
            cfx_v8value_is_date = (cfx_v8value_is_date_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_date", typeof(cfx_v8value_is_date_delegate));
            cfx_v8value_is_string = (cfx_v8value_is_string_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_string", typeof(cfx_v8value_is_string_delegate));
            cfx_v8value_is_object = (cfx_v8value_is_object_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_object", typeof(cfx_v8value_is_object_delegate));
            cfx_v8value_is_array = (cfx_v8value_is_array_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_array", typeof(cfx_v8value_is_array_delegate));
            cfx_v8value_is_function = (cfx_v8value_is_function_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_function", typeof(cfx_v8value_is_function_delegate));
            cfx_v8value_is_same = (cfx_v8value_is_same_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_same", typeof(cfx_v8value_is_same_delegate));
            cfx_v8value_get_bool_value = (cfx_v8value_get_bool_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_bool_value", typeof(cfx_v8value_get_bool_value_delegate));
            cfx_v8value_get_int_value = (cfx_v8value_get_int_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_int_value", typeof(cfx_v8value_get_int_value_delegate));
            cfx_v8value_get_uint_value = (cfx_v8value_get_uint_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_uint_value", typeof(cfx_v8value_get_uint_value_delegate));
            cfx_v8value_get_double_value = (cfx_v8value_get_double_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_double_value", typeof(cfx_v8value_get_double_value_delegate));
            cfx_v8value_get_date_value = (cfx_v8value_get_date_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_date_value", typeof(cfx_v8value_get_date_value_delegate));
            cfx_v8value_get_string_value = (cfx_v8value_get_string_value_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_string_value", typeof(cfx_v8value_get_string_value_delegate));
            cfx_v8value_is_user_created = (cfx_v8value_is_user_created_delegate)GetDelegate(libcfxPtr, "cfx_v8value_is_user_created", typeof(cfx_v8value_is_user_created_delegate));
            cfx_v8value_has_exception = (cfx_v8value_has_exception_delegate)GetDelegate(libcfxPtr, "cfx_v8value_has_exception", typeof(cfx_v8value_has_exception_delegate));
            cfx_v8value_get_exception = (cfx_v8value_get_exception_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_exception", typeof(cfx_v8value_get_exception_delegate));
            cfx_v8value_clear_exception = (cfx_v8value_clear_exception_delegate)GetDelegate(libcfxPtr, "cfx_v8value_clear_exception", typeof(cfx_v8value_clear_exception_delegate));
            cfx_v8value_will_rethrow_exceptions = (cfx_v8value_will_rethrow_exceptions_delegate)GetDelegate(libcfxPtr, "cfx_v8value_will_rethrow_exceptions", typeof(cfx_v8value_will_rethrow_exceptions_delegate));
            cfx_v8value_set_rethrow_exceptions = (cfx_v8value_set_rethrow_exceptions_delegate)GetDelegate(libcfxPtr, "cfx_v8value_set_rethrow_exceptions", typeof(cfx_v8value_set_rethrow_exceptions_delegate));
            cfx_v8value_has_value_bykey = (cfx_v8value_has_value_bykey_delegate)GetDelegate(libcfxPtr, "cfx_v8value_has_value_bykey", typeof(cfx_v8value_has_value_bykey_delegate));
            cfx_v8value_has_value_byindex = (cfx_v8value_has_value_byindex_delegate)GetDelegate(libcfxPtr, "cfx_v8value_has_value_byindex", typeof(cfx_v8value_has_value_byindex_delegate));
            cfx_v8value_delete_value_bykey = (cfx_v8value_delete_value_bykey_delegate)GetDelegate(libcfxPtr, "cfx_v8value_delete_value_bykey", typeof(cfx_v8value_delete_value_bykey_delegate));
            cfx_v8value_delete_value_byindex = (cfx_v8value_delete_value_byindex_delegate)GetDelegate(libcfxPtr, "cfx_v8value_delete_value_byindex", typeof(cfx_v8value_delete_value_byindex_delegate));
            cfx_v8value_get_value_bykey = (cfx_v8value_get_value_bykey_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_value_bykey", typeof(cfx_v8value_get_value_bykey_delegate));
            cfx_v8value_get_value_byindex = (cfx_v8value_get_value_byindex_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_value_byindex", typeof(cfx_v8value_get_value_byindex_delegate));
            cfx_v8value_set_value_bykey = (cfx_v8value_set_value_bykey_delegate)GetDelegate(libcfxPtr, "cfx_v8value_set_value_bykey", typeof(cfx_v8value_set_value_bykey_delegate));
            cfx_v8value_set_value_byindex = (cfx_v8value_set_value_byindex_delegate)GetDelegate(libcfxPtr, "cfx_v8value_set_value_byindex", typeof(cfx_v8value_set_value_byindex_delegate));
            cfx_v8value_set_value_byaccessor = (cfx_v8value_set_value_byaccessor_delegate)GetDelegate(libcfxPtr, "cfx_v8value_set_value_byaccessor", typeof(cfx_v8value_set_value_byaccessor_delegate));
            cfx_v8value_get_keys = (cfx_v8value_get_keys_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_keys", typeof(cfx_v8value_get_keys_delegate));
            cfx_v8value_set_user_data = (cfx_v8value_set_user_data_delegate)GetDelegate(libcfxPtr, "cfx_v8value_set_user_data", typeof(cfx_v8value_set_user_data_delegate));
            cfx_v8value_get_user_data = (cfx_v8value_get_user_data_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_user_data", typeof(cfx_v8value_get_user_data_delegate));
            cfx_v8value_get_externally_allocated_memory = (cfx_v8value_get_externally_allocated_memory_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_externally_allocated_memory", typeof(cfx_v8value_get_externally_allocated_memory_delegate));
            cfx_v8value_adjust_externally_allocated_memory = (cfx_v8value_adjust_externally_allocated_memory_delegate)GetDelegate(libcfxPtr, "cfx_v8value_adjust_externally_allocated_memory", typeof(cfx_v8value_adjust_externally_allocated_memory_delegate));
            cfx_v8value_get_array_length = (cfx_v8value_get_array_length_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_array_length", typeof(cfx_v8value_get_array_length_delegate));
            cfx_v8value_get_function_name = (cfx_v8value_get_function_name_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_function_name", typeof(cfx_v8value_get_function_name_delegate));
            cfx_v8value_get_function_handler = (cfx_v8value_get_function_handler_delegate)GetDelegate(libcfxPtr, "cfx_v8value_get_function_handler", typeof(cfx_v8value_get_function_handler_delegate));
            cfx_v8value_execute_function = (cfx_v8value_execute_function_delegate)GetDelegate(libcfxPtr, "cfx_v8value_execute_function", typeof(cfx_v8value_execute_function_delegate));
            cfx_v8value_execute_function_with_context = (cfx_v8value_execute_function_with_context_delegate)GetDelegate(libcfxPtr, "cfx_v8value_execute_function_with_context", typeof(cfx_v8value_execute_function_with_context_delegate));


            // cef_web_plugin_info

            cfx_web_plugin_info_get_name = (cfx_web_plugin_info_get_name_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_get_name", typeof(cfx_web_plugin_info_get_name_delegate));
            cfx_web_plugin_info_get_path = (cfx_web_plugin_info_get_path_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_get_path", typeof(cfx_web_plugin_info_get_path_delegate));
            cfx_web_plugin_info_get_version = (cfx_web_plugin_info_get_version_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_get_version", typeof(cfx_web_plugin_info_get_version_delegate));
            cfx_web_plugin_info_get_description = (cfx_web_plugin_info_get_description_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_get_description", typeof(cfx_web_plugin_info_get_description_delegate));


            // cef_web_plugin_info_visitor

            cfx_web_plugin_info_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_web_plugin_info_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_web_plugin_info_visitor_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_web_plugin_info_visitor_visit = CfxWebPluginInfoVisitor.visit;

            var cfx_web_plugin_info_visitor_set_callback_ptrs = (cfx_set_1_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_set_callback_ptrs", typeof(cfx_set_1_callback_ptrs_delegate));
            cfx_web_plugin_info_visitor_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_web_plugin_info_visitor_visit)
            );


            // cef_web_plugin_unstable_callback

            cfx_web_plugin_unstable_callback_is_unstable = (cfx_web_plugin_unstable_callback_is_unstable_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_unstable_callback_is_unstable", typeof(cfx_web_plugin_unstable_callback_is_unstable_delegate));


            // cef_window_info

            cfx_window_info_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_window_info_ctor", typeof(cfx_ctor_delegate));
            cfx_window_info_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_window_info_dtor", typeof(cfx_dtor_delegate));

            cfx_window_info_copy_to_native = (cfx_window_info_copy_to_native_delegate)GetDelegate(libcfxPtr, "cfx_window_info_copy_to_native", typeof(cfx_window_info_copy_to_native_delegate));
            cfx_window_info_copy_to_managed = (cfx_window_info_copy_to_managed_delegate)GetDelegate(libcfxPtr, "cfx_window_info_copy_to_managed", typeof(cfx_window_info_copy_to_managed_delegate));


            // cef_write_handler

            cfx_write_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_write_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_write_handler_activate_callback = (cfx_activate_callback_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_activate_callback", typeof(cfx_activate_callback_delegate));

            cfx_write_handler_write = CfxWriteHandler.write;
            cfx_write_handler_seek = CfxWriteHandler.seek;
            cfx_write_handler_tell = CfxWriteHandler.tell;
            cfx_write_handler_flush = CfxWriteHandler.flush;
            cfx_write_handler_may_block = CfxWriteHandler.may_block;

            var cfx_write_handler_set_callback_ptrs = (cfx_set_5_callback_ptrs_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_set_callback_ptrs", typeof(cfx_set_5_callback_ptrs_delegate));
            cfx_write_handler_set_callback_ptrs(
                Marshal.GetFunctionPointerForDelegate(cfx_write_handler_write),
                Marshal.GetFunctionPointerForDelegate(cfx_write_handler_seek),
                Marshal.GetFunctionPointerForDelegate(cfx_write_handler_tell),
                Marshal.GetFunctionPointerForDelegate(cfx_write_handler_flush),
                Marshal.GetFunctionPointerForDelegate(cfx_write_handler_may_block)
            );


            // cef_xml_reader

            cfx_xml_reader_create = (cfx_xml_reader_create_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_create", typeof(cfx_xml_reader_create_delegate));

            cfx_xml_reader_move_to_next_node = (cfx_xml_reader_move_to_next_node_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_next_node", typeof(cfx_xml_reader_move_to_next_node_delegate));
            cfx_xml_reader_close = (cfx_xml_reader_close_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_close", typeof(cfx_xml_reader_close_delegate));
            cfx_xml_reader_has_error = (cfx_xml_reader_has_error_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_has_error", typeof(cfx_xml_reader_has_error_delegate));
            cfx_xml_reader_get_error = (cfx_xml_reader_get_error_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_error", typeof(cfx_xml_reader_get_error_delegate));
            cfx_xml_reader_get_type = (cfx_xml_reader_get_type_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_type", typeof(cfx_xml_reader_get_type_delegate));
            cfx_xml_reader_get_depth = (cfx_xml_reader_get_depth_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_depth", typeof(cfx_xml_reader_get_depth_delegate));
            cfx_xml_reader_get_local_name = (cfx_xml_reader_get_local_name_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_local_name", typeof(cfx_xml_reader_get_local_name_delegate));
            cfx_xml_reader_get_prefix = (cfx_xml_reader_get_prefix_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_prefix", typeof(cfx_xml_reader_get_prefix_delegate));
            cfx_xml_reader_get_qualified_name = (cfx_xml_reader_get_qualified_name_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_qualified_name", typeof(cfx_xml_reader_get_qualified_name_delegate));
            cfx_xml_reader_get_namespace_uri = (cfx_xml_reader_get_namespace_uri_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_namespace_uri", typeof(cfx_xml_reader_get_namespace_uri_delegate));
            cfx_xml_reader_get_base_uri = (cfx_xml_reader_get_base_uri_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_base_uri", typeof(cfx_xml_reader_get_base_uri_delegate));
            cfx_xml_reader_get_xml_lang = (cfx_xml_reader_get_xml_lang_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_xml_lang", typeof(cfx_xml_reader_get_xml_lang_delegate));
            cfx_xml_reader_is_empty_element = (cfx_xml_reader_is_empty_element_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_is_empty_element", typeof(cfx_xml_reader_is_empty_element_delegate));
            cfx_xml_reader_has_value = (cfx_xml_reader_has_value_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_has_value", typeof(cfx_xml_reader_has_value_delegate));
            cfx_xml_reader_get_value = (cfx_xml_reader_get_value_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_value", typeof(cfx_xml_reader_get_value_delegate));
            cfx_xml_reader_has_attributes = (cfx_xml_reader_has_attributes_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_has_attributes", typeof(cfx_xml_reader_has_attributes_delegate));
            cfx_xml_reader_get_attribute_count = (cfx_xml_reader_get_attribute_count_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_attribute_count", typeof(cfx_xml_reader_get_attribute_count_delegate));
            cfx_xml_reader_get_attribute_byindex = (cfx_xml_reader_get_attribute_byindex_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_attribute_byindex", typeof(cfx_xml_reader_get_attribute_byindex_delegate));
            cfx_xml_reader_get_attribute_byqname = (cfx_xml_reader_get_attribute_byqname_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_attribute_byqname", typeof(cfx_xml_reader_get_attribute_byqname_delegate));
            cfx_xml_reader_get_attribute_bylname = (cfx_xml_reader_get_attribute_bylname_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_attribute_bylname", typeof(cfx_xml_reader_get_attribute_bylname_delegate));
            cfx_xml_reader_get_inner_xml = (cfx_xml_reader_get_inner_xml_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_inner_xml", typeof(cfx_xml_reader_get_inner_xml_delegate));
            cfx_xml_reader_get_outer_xml = (cfx_xml_reader_get_outer_xml_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_outer_xml", typeof(cfx_xml_reader_get_outer_xml_delegate));
            cfx_xml_reader_get_line_number = (cfx_xml_reader_get_line_number_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_get_line_number", typeof(cfx_xml_reader_get_line_number_delegate));
            cfx_xml_reader_move_to_attribute_byindex = (cfx_xml_reader_move_to_attribute_byindex_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_attribute_byindex", typeof(cfx_xml_reader_move_to_attribute_byindex_delegate));
            cfx_xml_reader_move_to_attribute_byqname = (cfx_xml_reader_move_to_attribute_byqname_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_attribute_byqname", typeof(cfx_xml_reader_move_to_attribute_byqname_delegate));
            cfx_xml_reader_move_to_attribute_bylname = (cfx_xml_reader_move_to_attribute_bylname_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_attribute_bylname", typeof(cfx_xml_reader_move_to_attribute_bylname_delegate));
            cfx_xml_reader_move_to_first_attribute = (cfx_xml_reader_move_to_first_attribute_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_first_attribute", typeof(cfx_xml_reader_move_to_first_attribute_delegate));
            cfx_xml_reader_move_to_next_attribute = (cfx_xml_reader_move_to_next_attribute_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_next_attribute", typeof(cfx_xml_reader_move_to_next_attribute_delegate));
            cfx_xml_reader_move_to_carrying_element = (cfx_xml_reader_move_to_carrying_element_delegate)GetDelegate(libcfxPtr, "cfx_xml_reader_move_to_carrying_element", typeof(cfx_xml_reader_move_to_carrying_element_delegate));


            // cef_zip_reader

            cfx_zip_reader_create = (cfx_zip_reader_create_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_create", typeof(cfx_zip_reader_create_delegate));

            cfx_zip_reader_move_to_first_file = (cfx_zip_reader_move_to_first_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_move_to_first_file", typeof(cfx_zip_reader_move_to_first_file_delegate));
            cfx_zip_reader_move_to_next_file = (cfx_zip_reader_move_to_next_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_move_to_next_file", typeof(cfx_zip_reader_move_to_next_file_delegate));
            cfx_zip_reader_move_to_file = (cfx_zip_reader_move_to_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_move_to_file", typeof(cfx_zip_reader_move_to_file_delegate));
            cfx_zip_reader_close = (cfx_zip_reader_close_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_close", typeof(cfx_zip_reader_close_delegate));
            cfx_zip_reader_get_file_name = (cfx_zip_reader_get_file_name_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_get_file_name", typeof(cfx_zip_reader_get_file_name_delegate));
            cfx_zip_reader_get_file_size = (cfx_zip_reader_get_file_size_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_get_file_size", typeof(cfx_zip_reader_get_file_size_delegate));
            cfx_zip_reader_get_file_last_modified = (cfx_zip_reader_get_file_last_modified_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_get_file_last_modified", typeof(cfx_zip_reader_get_file_last_modified_delegate));
            cfx_zip_reader_open_file = (cfx_zip_reader_open_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_open_file", typeof(cfx_zip_reader_open_file_delegate));
            cfx_zip_reader_close_file = (cfx_zip_reader_close_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_close_file", typeof(cfx_zip_reader_close_file_delegate));
            cfx_zip_reader_read_file = (cfx_zip_reader_read_file_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_read_file", typeof(cfx_zip_reader_read_file_delegate));
            cfx_zip_reader_tell = (cfx_zip_reader_tell_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_tell", typeof(cfx_zip_reader_tell_delegate));
            cfx_zip_reader_eof = (cfx_zip_reader_eof_delegate)GetDelegate(libcfxPtr, "cfx_zip_reader_eof", typeof(cfx_zip_reader_eof_delegate));


        }
    }
}
