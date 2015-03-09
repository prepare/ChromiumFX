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
            cfx_end_tracing = (cfx_end_tracing_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing", typeof(cfx_end_tracing_delegate));
            cfx_execute_process = (cfx_execute_process_delegate)GetDelegate(libcfxPtr, "cfx_execute_process", typeof(cfx_execute_process_delegate));
            cfx_force_web_plugin_shutdown = (cfx_force_web_plugin_shutdown_delegate)GetDelegate(libcfxPtr, "cfx_force_web_plugin_shutdown", typeof(cfx_force_web_plugin_shutdown_delegate));
            cfx_get_extensions_for_mime_type = (cfx_get_extensions_for_mime_type_delegate)GetDelegate(libcfxPtr, "cfx_get_extensions_for_mime_type", typeof(cfx_get_extensions_for_mime_type_delegate));
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
            cfx_app_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_app_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_browser_host_get_navigation_entries = (cfx_browser_host_get_navigation_entries_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_navigation_entries", typeof(cfx_browser_host_get_navigation_entries_delegate));
            cfx_browser_host_set_mouse_cursor_change_disabled = (cfx_browser_host_set_mouse_cursor_change_disabled_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_set_mouse_cursor_change_disabled", typeof(cfx_browser_host_set_mouse_cursor_change_disabled_delegate));
            cfx_browser_host_is_mouse_cursor_change_disabled = (cfx_browser_host_is_mouse_cursor_change_disabled_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_is_mouse_cursor_change_disabled", typeof(cfx_browser_host_is_mouse_cursor_change_disabled_delegate));
            cfx_browser_host_replace_misspelling = (cfx_browser_host_replace_misspelling_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_replace_misspelling", typeof(cfx_browser_host_replace_misspelling_delegate));
            cfx_browser_host_add_word_to_dictionary = (cfx_browser_host_add_word_to_dictionary_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_add_word_to_dictionary", typeof(cfx_browser_host_add_word_to_dictionary_delegate));
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
            cfx_browser_host_notify_move_or_resize_started = (cfx_browser_host_notify_move_or_resize_started_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_notify_move_or_resize_started", typeof(cfx_browser_host_notify_move_or_resize_started_delegate));
            cfx_browser_host_get_nstext_input_context = (cfx_browser_host_get_nstext_input_context_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_get_nstext_input_context", typeof(cfx_browser_host_get_nstext_input_context_delegate));
            cfx_browser_host_handle_key_event_before_text_input_client = (cfx_browser_host_handle_key_event_before_text_input_client_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_handle_key_event_before_text_input_client", typeof(cfx_browser_host_handle_key_event_before_text_input_client_delegate));
            cfx_browser_host_handle_key_event_after_text_input_client = (cfx_browser_host_handle_key_event_after_text_input_client_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_handle_key_event_after_text_input_client", typeof(cfx_browser_host_handle_key_event_after_text_input_client_delegate));
            cfx_browser_host_drag_target_drag_enter = (cfx_browser_host_drag_target_drag_enter_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_target_drag_enter", typeof(cfx_browser_host_drag_target_drag_enter_delegate));
            cfx_browser_host_drag_target_drag_over = (cfx_browser_host_drag_target_drag_over_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_target_drag_over", typeof(cfx_browser_host_drag_target_drag_over_delegate));
            cfx_browser_host_drag_target_drag_leave = (cfx_browser_host_drag_target_drag_leave_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_target_drag_leave", typeof(cfx_browser_host_drag_target_drag_leave_delegate));
            cfx_browser_host_drag_target_drop = (cfx_browser_host_drag_target_drop_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_target_drop", typeof(cfx_browser_host_drag_target_drop_delegate));
            cfx_browser_host_drag_source_ended_at = (cfx_browser_host_drag_source_ended_at_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_source_ended_at", typeof(cfx_browser_host_drag_source_ended_at_delegate));
            cfx_browser_host_drag_source_system_drag_ended = (cfx_browser_host_drag_source_system_drag_ended_delegate)GetDelegate(libcfxPtr, "cfx_browser_host_drag_source_system_drag_ended", typeof(cfx_browser_host_drag_source_system_drag_ended_delegate));


            // cef_browser_process_handler

            cfx_browser_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_browser_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_browser_process_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_browser_settings

            cfx_browser_settings_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_ctor", typeof(cfx_ctor_delegate));
            cfx_browser_settings_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_dtor", typeof(cfx_dtor_delegate));

            cfx_browser_settings_set_windowless_frame_rate = (cfx_browser_settings_set_windowless_frame_rate_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_windowless_frame_rate", typeof(cfx_browser_settings_set_windowless_frame_rate_delegate));
            cfx_browser_settings_get_windowless_frame_rate = (cfx_browser_settings_get_windowless_frame_rate_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_windowless_frame_rate", typeof(cfx_browser_settings_get_windowless_frame_rate_delegate));
            cfx_browser_settings_set_standard_font_family = (cfx_browser_settings_set_standard_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_standard_font_family", typeof(cfx_browser_settings_set_standard_font_family_delegate));
            cfx_browser_settings_get_standard_font_family = (cfx_browser_settings_get_standard_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_standard_font_family", typeof(cfx_browser_settings_get_standard_font_family_delegate));
            cfx_browser_settings_set_fixed_font_family = (cfx_browser_settings_set_fixed_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_fixed_font_family", typeof(cfx_browser_settings_set_fixed_font_family_delegate));
            cfx_browser_settings_get_fixed_font_family = (cfx_browser_settings_get_fixed_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_fixed_font_family", typeof(cfx_browser_settings_get_fixed_font_family_delegate));
            cfx_browser_settings_set_serif_font_family = (cfx_browser_settings_set_serif_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_serif_font_family", typeof(cfx_browser_settings_set_serif_font_family_delegate));
            cfx_browser_settings_get_serif_font_family = (cfx_browser_settings_get_serif_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_serif_font_family", typeof(cfx_browser_settings_get_serif_font_family_delegate));
            cfx_browser_settings_set_sans_serif_font_family = (cfx_browser_settings_set_sans_serif_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_sans_serif_font_family", typeof(cfx_browser_settings_set_sans_serif_font_family_delegate));
            cfx_browser_settings_get_sans_serif_font_family = (cfx_browser_settings_get_sans_serif_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_sans_serif_font_family", typeof(cfx_browser_settings_get_sans_serif_font_family_delegate));
            cfx_browser_settings_set_cursive_font_family = (cfx_browser_settings_set_cursive_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_cursive_font_family", typeof(cfx_browser_settings_set_cursive_font_family_delegate));
            cfx_browser_settings_get_cursive_font_family = (cfx_browser_settings_get_cursive_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_cursive_font_family", typeof(cfx_browser_settings_get_cursive_font_family_delegate));
            cfx_browser_settings_set_fantasy_font_family = (cfx_browser_settings_set_fantasy_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_fantasy_font_family", typeof(cfx_browser_settings_set_fantasy_font_family_delegate));
            cfx_browser_settings_get_fantasy_font_family = (cfx_browser_settings_get_fantasy_font_family_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_fantasy_font_family", typeof(cfx_browser_settings_get_fantasy_font_family_delegate));
            cfx_browser_settings_set_default_font_size = (cfx_browser_settings_set_default_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_default_font_size", typeof(cfx_browser_settings_set_default_font_size_delegate));
            cfx_browser_settings_get_default_font_size = (cfx_browser_settings_get_default_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_default_font_size", typeof(cfx_browser_settings_get_default_font_size_delegate));
            cfx_browser_settings_set_default_fixed_font_size = (cfx_browser_settings_set_default_fixed_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_default_fixed_font_size", typeof(cfx_browser_settings_set_default_fixed_font_size_delegate));
            cfx_browser_settings_get_default_fixed_font_size = (cfx_browser_settings_get_default_fixed_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_default_fixed_font_size", typeof(cfx_browser_settings_get_default_fixed_font_size_delegate));
            cfx_browser_settings_set_minimum_font_size = (cfx_browser_settings_set_minimum_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_minimum_font_size", typeof(cfx_browser_settings_set_minimum_font_size_delegate));
            cfx_browser_settings_get_minimum_font_size = (cfx_browser_settings_get_minimum_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_minimum_font_size", typeof(cfx_browser_settings_get_minimum_font_size_delegate));
            cfx_browser_settings_set_minimum_logical_font_size = (cfx_browser_settings_set_minimum_logical_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_minimum_logical_font_size", typeof(cfx_browser_settings_set_minimum_logical_font_size_delegate));
            cfx_browser_settings_get_minimum_logical_font_size = (cfx_browser_settings_get_minimum_logical_font_size_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_minimum_logical_font_size", typeof(cfx_browser_settings_get_minimum_logical_font_size_delegate));
            cfx_browser_settings_set_default_encoding = (cfx_browser_settings_set_default_encoding_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_default_encoding", typeof(cfx_browser_settings_set_default_encoding_delegate));
            cfx_browser_settings_get_default_encoding = (cfx_browser_settings_get_default_encoding_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_default_encoding", typeof(cfx_browser_settings_get_default_encoding_delegate));
            cfx_browser_settings_set_remote_fonts = (cfx_browser_settings_set_remote_fonts_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_remote_fonts", typeof(cfx_browser_settings_set_remote_fonts_delegate));
            cfx_browser_settings_get_remote_fonts = (cfx_browser_settings_get_remote_fonts_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_remote_fonts", typeof(cfx_browser_settings_get_remote_fonts_delegate));
            cfx_browser_settings_set_javascript = (cfx_browser_settings_set_javascript_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_javascript", typeof(cfx_browser_settings_set_javascript_delegate));
            cfx_browser_settings_get_javascript = (cfx_browser_settings_get_javascript_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_javascript", typeof(cfx_browser_settings_get_javascript_delegate));
            cfx_browser_settings_set_javascript_open_windows = (cfx_browser_settings_set_javascript_open_windows_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_javascript_open_windows", typeof(cfx_browser_settings_set_javascript_open_windows_delegate));
            cfx_browser_settings_get_javascript_open_windows = (cfx_browser_settings_get_javascript_open_windows_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_javascript_open_windows", typeof(cfx_browser_settings_get_javascript_open_windows_delegate));
            cfx_browser_settings_set_javascript_close_windows = (cfx_browser_settings_set_javascript_close_windows_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_javascript_close_windows", typeof(cfx_browser_settings_set_javascript_close_windows_delegate));
            cfx_browser_settings_get_javascript_close_windows = (cfx_browser_settings_get_javascript_close_windows_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_javascript_close_windows", typeof(cfx_browser_settings_get_javascript_close_windows_delegate));
            cfx_browser_settings_set_javascript_access_clipboard = (cfx_browser_settings_set_javascript_access_clipboard_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_javascript_access_clipboard", typeof(cfx_browser_settings_set_javascript_access_clipboard_delegate));
            cfx_browser_settings_get_javascript_access_clipboard = (cfx_browser_settings_get_javascript_access_clipboard_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_javascript_access_clipboard", typeof(cfx_browser_settings_get_javascript_access_clipboard_delegate));
            cfx_browser_settings_set_javascript_dom_paste = (cfx_browser_settings_set_javascript_dom_paste_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_javascript_dom_paste", typeof(cfx_browser_settings_set_javascript_dom_paste_delegate));
            cfx_browser_settings_get_javascript_dom_paste = (cfx_browser_settings_get_javascript_dom_paste_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_javascript_dom_paste", typeof(cfx_browser_settings_get_javascript_dom_paste_delegate));
            cfx_browser_settings_set_caret_browsing = (cfx_browser_settings_set_caret_browsing_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_caret_browsing", typeof(cfx_browser_settings_set_caret_browsing_delegate));
            cfx_browser_settings_get_caret_browsing = (cfx_browser_settings_get_caret_browsing_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_caret_browsing", typeof(cfx_browser_settings_get_caret_browsing_delegate));
            cfx_browser_settings_set_java = (cfx_browser_settings_set_java_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_java", typeof(cfx_browser_settings_set_java_delegate));
            cfx_browser_settings_get_java = (cfx_browser_settings_get_java_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_java", typeof(cfx_browser_settings_get_java_delegate));
            cfx_browser_settings_set_plugins = (cfx_browser_settings_set_plugins_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_plugins", typeof(cfx_browser_settings_set_plugins_delegate));
            cfx_browser_settings_get_plugins = (cfx_browser_settings_get_plugins_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_plugins", typeof(cfx_browser_settings_get_plugins_delegate));
            cfx_browser_settings_set_universal_access_from_file_urls = (cfx_browser_settings_set_universal_access_from_file_urls_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_universal_access_from_file_urls", typeof(cfx_browser_settings_set_universal_access_from_file_urls_delegate));
            cfx_browser_settings_get_universal_access_from_file_urls = (cfx_browser_settings_get_universal_access_from_file_urls_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_universal_access_from_file_urls", typeof(cfx_browser_settings_get_universal_access_from_file_urls_delegate));
            cfx_browser_settings_set_file_access_from_file_urls = (cfx_browser_settings_set_file_access_from_file_urls_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_file_access_from_file_urls", typeof(cfx_browser_settings_set_file_access_from_file_urls_delegate));
            cfx_browser_settings_get_file_access_from_file_urls = (cfx_browser_settings_get_file_access_from_file_urls_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_file_access_from_file_urls", typeof(cfx_browser_settings_get_file_access_from_file_urls_delegate));
            cfx_browser_settings_set_web_security = (cfx_browser_settings_set_web_security_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_web_security", typeof(cfx_browser_settings_set_web_security_delegate));
            cfx_browser_settings_get_web_security = (cfx_browser_settings_get_web_security_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_web_security", typeof(cfx_browser_settings_get_web_security_delegate));
            cfx_browser_settings_set_image_loading = (cfx_browser_settings_set_image_loading_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_image_loading", typeof(cfx_browser_settings_set_image_loading_delegate));
            cfx_browser_settings_get_image_loading = (cfx_browser_settings_get_image_loading_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_image_loading", typeof(cfx_browser_settings_get_image_loading_delegate));
            cfx_browser_settings_set_image_shrink_standalone_to_fit = (cfx_browser_settings_set_image_shrink_standalone_to_fit_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_image_shrink_standalone_to_fit", typeof(cfx_browser_settings_set_image_shrink_standalone_to_fit_delegate));
            cfx_browser_settings_get_image_shrink_standalone_to_fit = (cfx_browser_settings_get_image_shrink_standalone_to_fit_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_image_shrink_standalone_to_fit", typeof(cfx_browser_settings_get_image_shrink_standalone_to_fit_delegate));
            cfx_browser_settings_set_text_area_resize = (cfx_browser_settings_set_text_area_resize_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_text_area_resize", typeof(cfx_browser_settings_set_text_area_resize_delegate));
            cfx_browser_settings_get_text_area_resize = (cfx_browser_settings_get_text_area_resize_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_text_area_resize", typeof(cfx_browser_settings_get_text_area_resize_delegate));
            cfx_browser_settings_set_tab_to_links = (cfx_browser_settings_set_tab_to_links_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_tab_to_links", typeof(cfx_browser_settings_set_tab_to_links_delegate));
            cfx_browser_settings_get_tab_to_links = (cfx_browser_settings_get_tab_to_links_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_tab_to_links", typeof(cfx_browser_settings_get_tab_to_links_delegate));
            cfx_browser_settings_set_local_storage = (cfx_browser_settings_set_local_storage_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_local_storage", typeof(cfx_browser_settings_set_local_storage_delegate));
            cfx_browser_settings_get_local_storage = (cfx_browser_settings_get_local_storage_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_local_storage", typeof(cfx_browser_settings_get_local_storage_delegate));
            cfx_browser_settings_set_databases = (cfx_browser_settings_set_databases_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_databases", typeof(cfx_browser_settings_set_databases_delegate));
            cfx_browser_settings_get_databases = (cfx_browser_settings_get_databases_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_databases", typeof(cfx_browser_settings_get_databases_delegate));
            cfx_browser_settings_set_application_cache = (cfx_browser_settings_set_application_cache_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_application_cache", typeof(cfx_browser_settings_set_application_cache_delegate));
            cfx_browser_settings_get_application_cache = (cfx_browser_settings_get_application_cache_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_application_cache", typeof(cfx_browser_settings_get_application_cache_delegate));
            cfx_browser_settings_set_webgl = (cfx_browser_settings_set_webgl_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_webgl", typeof(cfx_browser_settings_set_webgl_delegate));
            cfx_browser_settings_get_webgl = (cfx_browser_settings_get_webgl_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_webgl", typeof(cfx_browser_settings_get_webgl_delegate));
            cfx_browser_settings_set_background_color = (cfx_browser_settings_set_background_color_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_set_background_color", typeof(cfx_browser_settings_set_background_color_delegate));
            cfx_browser_settings_get_background_color = (cfx_browser_settings_get_background_color_delegate)GetDelegate(libcfxPtr, "cfx_browser_settings_get_background_color", typeof(cfx_browser_settings_get_background_color_delegate));



            // cef_callback

            cfx_callback_cont = (cfx_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_callback_cont", typeof(cfx_callback_cont_delegate));
            cfx_callback_cancel = (cfx_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_callback_cancel", typeof(cfx_callback_cancel_delegate));


            // cef_client

            cfx_client_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_client_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_client_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_client_set_managed_callback", typeof(cfx_set_callback_delegate));


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


            // cef_completion_callback

            cfx_completion_callback_on_complete = (cfx_completion_callback_on_complete_delegate)GetDelegate(libcfxPtr, "cfx_completion_callback_on_complete", typeof(cfx_completion_callback_on_complete_delegate));


            // cef_context_menu_handler

            cfx_context_menu_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_context_menu_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_context_menu_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_context_menu_params_get_misspelled_word = (cfx_context_menu_params_get_misspelled_word_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_misspelled_word", typeof(cfx_context_menu_params_get_misspelled_word_delegate));
            cfx_context_menu_params_get_misspelling_hash = (cfx_context_menu_params_get_misspelling_hash_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_misspelling_hash", typeof(cfx_context_menu_params_get_misspelling_hash_delegate));
            cfx_context_menu_params_get_dictionary_suggestions = (cfx_context_menu_params_get_dictionary_suggestions_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_dictionary_suggestions", typeof(cfx_context_menu_params_get_dictionary_suggestions_delegate));
            cfx_context_menu_params_is_editable = (cfx_context_menu_params_is_editable_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_is_editable", typeof(cfx_context_menu_params_is_editable_delegate));
            cfx_context_menu_params_is_spell_check_enabled = (cfx_context_menu_params_is_spell_check_enabled_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_is_spell_check_enabled", typeof(cfx_context_menu_params_is_spell_check_enabled_delegate));
            cfx_context_menu_params_get_edit_state_flags = (cfx_context_menu_params_get_edit_state_flags_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_params_get_edit_state_flags", typeof(cfx_context_menu_params_get_edit_state_flags_delegate));


            // cef_cookie

            cfx_cookie_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_cookie_ctor", typeof(cfx_ctor_delegate));
            cfx_cookie_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_cookie_dtor", typeof(cfx_dtor_delegate));

            cfx_cookie_set_name = (cfx_cookie_set_name_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_name", typeof(cfx_cookie_set_name_delegate));
            cfx_cookie_get_name = (cfx_cookie_get_name_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_name", typeof(cfx_cookie_get_name_delegate));
            cfx_cookie_set_value = (cfx_cookie_set_value_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_value", typeof(cfx_cookie_set_value_delegate));
            cfx_cookie_get_value = (cfx_cookie_get_value_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_value", typeof(cfx_cookie_get_value_delegate));
            cfx_cookie_set_domain = (cfx_cookie_set_domain_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_domain", typeof(cfx_cookie_set_domain_delegate));
            cfx_cookie_get_domain = (cfx_cookie_get_domain_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_domain", typeof(cfx_cookie_get_domain_delegate));
            cfx_cookie_set_path = (cfx_cookie_set_path_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_path", typeof(cfx_cookie_set_path_delegate));
            cfx_cookie_get_path = (cfx_cookie_get_path_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_path", typeof(cfx_cookie_get_path_delegate));
            cfx_cookie_set_secure = (cfx_cookie_set_secure_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_secure", typeof(cfx_cookie_set_secure_delegate));
            cfx_cookie_get_secure = (cfx_cookie_get_secure_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_secure", typeof(cfx_cookie_get_secure_delegate));
            cfx_cookie_set_httponly = (cfx_cookie_set_httponly_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_httponly", typeof(cfx_cookie_set_httponly_delegate));
            cfx_cookie_get_httponly = (cfx_cookie_get_httponly_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_httponly", typeof(cfx_cookie_get_httponly_delegate));
            cfx_cookie_set_creation = (cfx_cookie_set_creation_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_creation", typeof(cfx_cookie_set_creation_delegate));
            cfx_cookie_get_creation = (cfx_cookie_get_creation_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_creation", typeof(cfx_cookie_get_creation_delegate));
            cfx_cookie_set_last_access = (cfx_cookie_set_last_access_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_last_access", typeof(cfx_cookie_set_last_access_delegate));
            cfx_cookie_get_last_access = (cfx_cookie_get_last_access_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_last_access", typeof(cfx_cookie_get_last_access_delegate));
            cfx_cookie_set_has_expires = (cfx_cookie_set_has_expires_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_has_expires", typeof(cfx_cookie_set_has_expires_delegate));
            cfx_cookie_get_has_expires = (cfx_cookie_get_has_expires_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_has_expires", typeof(cfx_cookie_get_has_expires_delegate));
            cfx_cookie_set_expires = (cfx_cookie_set_expires_delegate)GetDelegate(libcfxPtr, "cfx_cookie_set_expires", typeof(cfx_cookie_set_expires_delegate));
            cfx_cookie_get_expires = (cfx_cookie_get_expires_delegate)GetDelegate(libcfxPtr, "cfx_cookie_get_expires", typeof(cfx_cookie_get_expires_delegate));



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
            cfx_cookie_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_cursor_info

            cfx_cursor_info_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_ctor", typeof(cfx_ctor_delegate));
            cfx_cursor_info_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_dtor", typeof(cfx_dtor_delegate));

            cfx_cursor_info_set_hotspot = (cfx_cursor_info_set_hotspot_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_set_hotspot", typeof(cfx_cursor_info_set_hotspot_delegate));
            cfx_cursor_info_get_hotspot = (cfx_cursor_info_get_hotspot_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_get_hotspot", typeof(cfx_cursor_info_get_hotspot_delegate));
            cfx_cursor_info_set_image_scale_factor = (cfx_cursor_info_set_image_scale_factor_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_set_image_scale_factor", typeof(cfx_cursor_info_set_image_scale_factor_delegate));
            cfx_cursor_info_get_image_scale_factor = (cfx_cursor_info_get_image_scale_factor_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_get_image_scale_factor", typeof(cfx_cursor_info_get_image_scale_factor_delegate));
            cfx_cursor_info_set_buffer = (cfx_cursor_info_set_buffer_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_set_buffer", typeof(cfx_cursor_info_set_buffer_delegate));
            cfx_cursor_info_get_buffer = (cfx_cursor_info_get_buffer_delegate)GetDelegate(libcfxPtr, "cfx_cursor_info_get_buffer", typeof(cfx_cursor_info_get_buffer_delegate));



            // cef_dialog_handler

            cfx_dialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_dialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_dialog_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_display_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_domvisitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_download_handler

            cfx_download_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_download_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_download_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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

            cfx_drag_data_create = (cfx_drag_data_create_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_create", typeof(cfx_drag_data_create_delegate));

            cfx_drag_data_clone = (cfx_drag_data_clone_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_clone", typeof(cfx_drag_data_clone_delegate));
            cfx_drag_data_is_read_only = (cfx_drag_data_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_is_read_only", typeof(cfx_drag_data_is_read_only_delegate));
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
            cfx_drag_data_get_file_contents = (cfx_drag_data_get_file_contents_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_file_contents", typeof(cfx_drag_data_get_file_contents_delegate));
            cfx_drag_data_get_file_names = (cfx_drag_data_get_file_names_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_get_file_names", typeof(cfx_drag_data_get_file_names_delegate));
            cfx_drag_data_set_link_url = (cfx_drag_data_set_link_url_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_link_url", typeof(cfx_drag_data_set_link_url_delegate));
            cfx_drag_data_set_link_title = (cfx_drag_data_set_link_title_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_link_title", typeof(cfx_drag_data_set_link_title_delegate));
            cfx_drag_data_set_link_metadata = (cfx_drag_data_set_link_metadata_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_link_metadata", typeof(cfx_drag_data_set_link_metadata_delegate));
            cfx_drag_data_set_fragment_text = (cfx_drag_data_set_fragment_text_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_fragment_text", typeof(cfx_drag_data_set_fragment_text_delegate));
            cfx_drag_data_set_fragment_html = (cfx_drag_data_set_fragment_html_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_fragment_html", typeof(cfx_drag_data_set_fragment_html_delegate));
            cfx_drag_data_set_fragment_base_url = (cfx_drag_data_set_fragment_base_url_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_set_fragment_base_url", typeof(cfx_drag_data_set_fragment_base_url_delegate));
            cfx_drag_data_reset_file_contents = (cfx_drag_data_reset_file_contents_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_reset_file_contents", typeof(cfx_drag_data_reset_file_contents_delegate));
            cfx_drag_data_add_file = (cfx_drag_data_add_file_delegate)GetDelegate(libcfxPtr, "cfx_drag_data_add_file", typeof(cfx_drag_data_add_file_delegate));


            // cef_drag_handler

            cfx_drag_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_drag_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_drag_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_end_tracing_callback

            cfx_end_tracing_callback_on_end_tracing_complete = (cfx_end_tracing_callback_on_end_tracing_complete_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_callback_on_end_tracing_complete", typeof(cfx_end_tracing_callback_on_end_tracing_complete_delegate));


            // cef_file_dialog_callback

            cfx_file_dialog_callback_cont = (cfx_file_dialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_file_dialog_callback_cont", typeof(cfx_file_dialog_callback_cont_delegate));
            cfx_file_dialog_callback_cancel = (cfx_file_dialog_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_file_dialog_callback_cancel", typeof(cfx_file_dialog_callback_cancel_delegate));


            // cef_focus_handler

            cfx_focus_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_focus_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_focus_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_geolocation_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_geoposition

            cfx_geoposition_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_ctor", typeof(cfx_ctor_delegate));
            cfx_geoposition_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_dtor", typeof(cfx_dtor_delegate));

            cfx_geoposition_set_latitude = (cfx_geoposition_set_latitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_latitude", typeof(cfx_geoposition_set_latitude_delegate));
            cfx_geoposition_get_latitude = (cfx_geoposition_get_latitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_latitude", typeof(cfx_geoposition_get_latitude_delegate));
            cfx_geoposition_set_longitude = (cfx_geoposition_set_longitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_longitude", typeof(cfx_geoposition_set_longitude_delegate));
            cfx_geoposition_get_longitude = (cfx_geoposition_get_longitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_longitude", typeof(cfx_geoposition_get_longitude_delegate));
            cfx_geoposition_set_altitude = (cfx_geoposition_set_altitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_altitude", typeof(cfx_geoposition_set_altitude_delegate));
            cfx_geoposition_get_altitude = (cfx_geoposition_get_altitude_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_altitude", typeof(cfx_geoposition_get_altitude_delegate));
            cfx_geoposition_set_accuracy = (cfx_geoposition_set_accuracy_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_accuracy", typeof(cfx_geoposition_set_accuracy_delegate));
            cfx_geoposition_get_accuracy = (cfx_geoposition_get_accuracy_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_accuracy", typeof(cfx_geoposition_get_accuracy_delegate));
            cfx_geoposition_set_altitude_accuracy = (cfx_geoposition_set_altitude_accuracy_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_altitude_accuracy", typeof(cfx_geoposition_set_altitude_accuracy_delegate));
            cfx_geoposition_get_altitude_accuracy = (cfx_geoposition_get_altitude_accuracy_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_altitude_accuracy", typeof(cfx_geoposition_get_altitude_accuracy_delegate));
            cfx_geoposition_set_heading = (cfx_geoposition_set_heading_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_heading", typeof(cfx_geoposition_set_heading_delegate));
            cfx_geoposition_get_heading = (cfx_geoposition_get_heading_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_heading", typeof(cfx_geoposition_get_heading_delegate));
            cfx_geoposition_set_speed = (cfx_geoposition_set_speed_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_speed", typeof(cfx_geoposition_set_speed_delegate));
            cfx_geoposition_get_speed = (cfx_geoposition_get_speed_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_speed", typeof(cfx_geoposition_get_speed_delegate));
            cfx_geoposition_set_timestamp = (cfx_geoposition_set_timestamp_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_timestamp", typeof(cfx_geoposition_set_timestamp_delegate));
            cfx_geoposition_get_timestamp = (cfx_geoposition_get_timestamp_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_timestamp", typeof(cfx_geoposition_get_timestamp_delegate));
            cfx_geoposition_set_error_code = (cfx_geoposition_set_error_code_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_error_code", typeof(cfx_geoposition_set_error_code_delegate));
            cfx_geoposition_get_error_code = (cfx_geoposition_get_error_code_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_error_code", typeof(cfx_geoposition_get_error_code_delegate));
            cfx_geoposition_set_error_message = (cfx_geoposition_set_error_message_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_set_error_message", typeof(cfx_geoposition_set_error_message_delegate));
            cfx_geoposition_get_error_message = (cfx_geoposition_get_error_message_delegate)GetDelegate(libcfxPtr, "cfx_geoposition_get_error_message", typeof(cfx_geoposition_get_error_message_delegate));



            // cef_get_geolocation_callback

            cfx_get_geolocation_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_get_geolocation_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_get_geolocation_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_jsdialog_callback

            cfx_jsdialog_callback_cont = (cfx_jsdialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_callback_cont", typeof(cfx_jsdialog_callback_cont_delegate));


            // cef_jsdialog_handler

            cfx_jsdialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_jsdialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_jsdialog_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_key_event

            cfx_key_event_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_key_event_ctor", typeof(cfx_ctor_delegate));
            cfx_key_event_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_key_event_dtor", typeof(cfx_dtor_delegate));

            cfx_key_event_set_type = (cfx_key_event_set_type_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_type", typeof(cfx_key_event_set_type_delegate));
            cfx_key_event_get_type = (cfx_key_event_get_type_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_type", typeof(cfx_key_event_get_type_delegate));
            cfx_key_event_set_modifiers = (cfx_key_event_set_modifiers_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_modifiers", typeof(cfx_key_event_set_modifiers_delegate));
            cfx_key_event_get_modifiers = (cfx_key_event_get_modifiers_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_modifiers", typeof(cfx_key_event_get_modifiers_delegate));
            cfx_key_event_set_windows_key_code = (cfx_key_event_set_windows_key_code_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_windows_key_code", typeof(cfx_key_event_set_windows_key_code_delegate));
            cfx_key_event_get_windows_key_code = (cfx_key_event_get_windows_key_code_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_windows_key_code", typeof(cfx_key_event_get_windows_key_code_delegate));
            cfx_key_event_set_native_key_code = (cfx_key_event_set_native_key_code_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_native_key_code", typeof(cfx_key_event_set_native_key_code_delegate));
            cfx_key_event_get_native_key_code = (cfx_key_event_get_native_key_code_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_native_key_code", typeof(cfx_key_event_get_native_key_code_delegate));
            cfx_key_event_set_is_system_key = (cfx_key_event_set_is_system_key_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_is_system_key", typeof(cfx_key_event_set_is_system_key_delegate));
            cfx_key_event_get_is_system_key = (cfx_key_event_get_is_system_key_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_is_system_key", typeof(cfx_key_event_get_is_system_key_delegate));
            cfx_key_event_set_character = (cfx_key_event_set_character_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_character", typeof(cfx_key_event_set_character_delegate));
            cfx_key_event_get_character = (cfx_key_event_get_character_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_character", typeof(cfx_key_event_get_character_delegate));
            cfx_key_event_set_unmodified_character = (cfx_key_event_set_unmodified_character_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_unmodified_character", typeof(cfx_key_event_set_unmodified_character_delegate));
            cfx_key_event_get_unmodified_character = (cfx_key_event_get_unmodified_character_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_unmodified_character", typeof(cfx_key_event_get_unmodified_character_delegate));
            cfx_key_event_set_focus_on_editable_field = (cfx_key_event_set_focus_on_editable_field_delegate)GetDelegate(libcfxPtr, "cfx_key_event_set_focus_on_editable_field", typeof(cfx_key_event_set_focus_on_editable_field_delegate));
            cfx_key_event_get_focus_on_editable_field = (cfx_key_event_get_focus_on_editable_field_delegate)GetDelegate(libcfxPtr, "cfx_key_event_get_focus_on_editable_field", typeof(cfx_key_event_get_focus_on_editable_field_delegate));



            // cef_keyboard_handler

            cfx_keyboard_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_keyboard_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_keyboard_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_life_span_handler

            cfx_life_span_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_life_span_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_life_span_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_load_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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

            cfx_mouse_event_set_x = (cfx_mouse_event_set_x_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_set_x", typeof(cfx_mouse_event_set_x_delegate));
            cfx_mouse_event_get_x = (cfx_mouse_event_get_x_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_get_x", typeof(cfx_mouse_event_get_x_delegate));
            cfx_mouse_event_set_y = (cfx_mouse_event_set_y_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_set_y", typeof(cfx_mouse_event_set_y_delegate));
            cfx_mouse_event_get_y = (cfx_mouse_event_get_y_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_get_y", typeof(cfx_mouse_event_get_y_delegate));
            cfx_mouse_event_set_modifiers = (cfx_mouse_event_set_modifiers_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_set_modifiers", typeof(cfx_mouse_event_set_modifiers_delegate));
            cfx_mouse_event_get_modifiers = (cfx_mouse_event_get_modifiers_delegate)GetDelegate(libcfxPtr, "cfx_mouse_event_get_modifiers", typeof(cfx_mouse_event_get_modifiers_delegate));



            // cef_navigation_entry

            cfx_navigation_entry_is_valid = (cfx_navigation_entry_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_is_valid", typeof(cfx_navigation_entry_is_valid_delegate));
            cfx_navigation_entry_get_url = (cfx_navigation_entry_get_url_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_url", typeof(cfx_navigation_entry_get_url_delegate));
            cfx_navigation_entry_get_display_url = (cfx_navigation_entry_get_display_url_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_display_url", typeof(cfx_navigation_entry_get_display_url_delegate));
            cfx_navigation_entry_get_original_url = (cfx_navigation_entry_get_original_url_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_original_url", typeof(cfx_navigation_entry_get_original_url_delegate));
            cfx_navigation_entry_get_title = (cfx_navigation_entry_get_title_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_title", typeof(cfx_navigation_entry_get_title_delegate));
            cfx_navigation_entry_get_transition_type = (cfx_navigation_entry_get_transition_type_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_transition_type", typeof(cfx_navigation_entry_get_transition_type_delegate));
            cfx_navigation_entry_has_post_data = (cfx_navigation_entry_has_post_data_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_has_post_data", typeof(cfx_navigation_entry_has_post_data_delegate));
            cfx_navigation_entry_get_frame_name = (cfx_navigation_entry_get_frame_name_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_frame_name", typeof(cfx_navigation_entry_get_frame_name_delegate));
            cfx_navigation_entry_get_completion_time = (cfx_navigation_entry_get_completion_time_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_completion_time", typeof(cfx_navigation_entry_get_completion_time_delegate));
            cfx_navigation_entry_get_http_status_code = (cfx_navigation_entry_get_http_status_code_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_get_http_status_code", typeof(cfx_navigation_entry_get_http_status_code_delegate));


            // cef_navigation_entry_visitor

            cfx_navigation_entry_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_navigation_entry_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_navigation_entry_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_page_range

            cfx_page_range_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_page_range_ctor", typeof(cfx_ctor_delegate));
            cfx_page_range_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_page_range_dtor", typeof(cfx_dtor_delegate));

            cfx_page_range_set_from = (cfx_page_range_set_from_delegate)GetDelegate(libcfxPtr, "cfx_page_range_set_from", typeof(cfx_page_range_set_from_delegate));
            cfx_page_range_get_from = (cfx_page_range_get_from_delegate)GetDelegate(libcfxPtr, "cfx_page_range_get_from", typeof(cfx_page_range_get_from_delegate));
            cfx_page_range_set_to = (cfx_page_range_set_to_delegate)GetDelegate(libcfxPtr, "cfx_page_range_set_to", typeof(cfx_page_range_set_to_delegate));
            cfx_page_range_get_to = (cfx_page_range_get_to_delegate)GetDelegate(libcfxPtr, "cfx_page_range_get_to", typeof(cfx_page_range_get_to_delegate));



            // cef_point

            cfx_point_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_point_ctor", typeof(cfx_ctor_delegate));
            cfx_point_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_point_dtor", typeof(cfx_dtor_delegate));

            cfx_point_set_x = (cfx_point_set_x_delegate)GetDelegate(libcfxPtr, "cfx_point_set_x", typeof(cfx_point_set_x_delegate));
            cfx_point_get_x = (cfx_point_get_x_delegate)GetDelegate(libcfxPtr, "cfx_point_get_x", typeof(cfx_point_get_x_delegate));
            cfx_point_set_y = (cfx_point_set_y_delegate)GetDelegate(libcfxPtr, "cfx_point_set_y", typeof(cfx_point_set_y_delegate));
            cfx_point_get_y = (cfx_point_get_y_delegate)GetDelegate(libcfxPtr, "cfx_point_get_y", typeof(cfx_point_get_y_delegate));



            // cef_popup_features

            cfx_popup_features_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_ctor", typeof(cfx_ctor_delegate));
            cfx_popup_features_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_dtor", typeof(cfx_dtor_delegate));

            cfx_popup_features_set_x = (cfx_popup_features_set_x_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_x", typeof(cfx_popup_features_set_x_delegate));
            cfx_popup_features_get_x = (cfx_popup_features_get_x_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_x", typeof(cfx_popup_features_get_x_delegate));
            cfx_popup_features_set_xSet = (cfx_popup_features_set_xSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_xSet", typeof(cfx_popup_features_set_xSet_delegate));
            cfx_popup_features_get_xSet = (cfx_popup_features_get_xSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_xSet", typeof(cfx_popup_features_get_xSet_delegate));
            cfx_popup_features_set_y = (cfx_popup_features_set_y_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_y", typeof(cfx_popup_features_set_y_delegate));
            cfx_popup_features_get_y = (cfx_popup_features_get_y_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_y", typeof(cfx_popup_features_get_y_delegate));
            cfx_popup_features_set_ySet = (cfx_popup_features_set_ySet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_ySet", typeof(cfx_popup_features_set_ySet_delegate));
            cfx_popup_features_get_ySet = (cfx_popup_features_get_ySet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_ySet", typeof(cfx_popup_features_get_ySet_delegate));
            cfx_popup_features_set_width = (cfx_popup_features_set_width_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_width", typeof(cfx_popup_features_set_width_delegate));
            cfx_popup_features_get_width = (cfx_popup_features_get_width_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_width", typeof(cfx_popup_features_get_width_delegate));
            cfx_popup_features_set_widthSet = (cfx_popup_features_set_widthSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_widthSet", typeof(cfx_popup_features_set_widthSet_delegate));
            cfx_popup_features_get_widthSet = (cfx_popup_features_get_widthSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_widthSet", typeof(cfx_popup_features_get_widthSet_delegate));
            cfx_popup_features_set_height = (cfx_popup_features_set_height_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_height", typeof(cfx_popup_features_set_height_delegate));
            cfx_popup_features_get_height = (cfx_popup_features_get_height_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_height", typeof(cfx_popup_features_get_height_delegate));
            cfx_popup_features_set_heightSet = (cfx_popup_features_set_heightSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_heightSet", typeof(cfx_popup_features_set_heightSet_delegate));
            cfx_popup_features_get_heightSet = (cfx_popup_features_get_heightSet_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_heightSet", typeof(cfx_popup_features_get_heightSet_delegate));
            cfx_popup_features_set_menuBarVisible = (cfx_popup_features_set_menuBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_menuBarVisible", typeof(cfx_popup_features_set_menuBarVisible_delegate));
            cfx_popup_features_get_menuBarVisible = (cfx_popup_features_get_menuBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_menuBarVisible", typeof(cfx_popup_features_get_menuBarVisible_delegate));
            cfx_popup_features_set_statusBarVisible = (cfx_popup_features_set_statusBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_statusBarVisible", typeof(cfx_popup_features_set_statusBarVisible_delegate));
            cfx_popup_features_get_statusBarVisible = (cfx_popup_features_get_statusBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_statusBarVisible", typeof(cfx_popup_features_get_statusBarVisible_delegate));
            cfx_popup_features_set_toolBarVisible = (cfx_popup_features_set_toolBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_toolBarVisible", typeof(cfx_popup_features_set_toolBarVisible_delegate));
            cfx_popup_features_get_toolBarVisible = (cfx_popup_features_get_toolBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_toolBarVisible", typeof(cfx_popup_features_get_toolBarVisible_delegate));
            cfx_popup_features_set_locationBarVisible = (cfx_popup_features_set_locationBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_locationBarVisible", typeof(cfx_popup_features_set_locationBarVisible_delegate));
            cfx_popup_features_get_locationBarVisible = (cfx_popup_features_get_locationBarVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_locationBarVisible", typeof(cfx_popup_features_get_locationBarVisible_delegate));
            cfx_popup_features_set_scrollbarsVisible = (cfx_popup_features_set_scrollbarsVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_scrollbarsVisible", typeof(cfx_popup_features_set_scrollbarsVisible_delegate));
            cfx_popup_features_get_scrollbarsVisible = (cfx_popup_features_get_scrollbarsVisible_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_scrollbarsVisible", typeof(cfx_popup_features_get_scrollbarsVisible_delegate));
            cfx_popup_features_set_resizable = (cfx_popup_features_set_resizable_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_resizable", typeof(cfx_popup_features_set_resizable_delegate));
            cfx_popup_features_get_resizable = (cfx_popup_features_get_resizable_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_resizable", typeof(cfx_popup_features_get_resizable_delegate));
            cfx_popup_features_set_fullscreen = (cfx_popup_features_set_fullscreen_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_fullscreen", typeof(cfx_popup_features_set_fullscreen_delegate));
            cfx_popup_features_get_fullscreen = (cfx_popup_features_get_fullscreen_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_fullscreen", typeof(cfx_popup_features_get_fullscreen_delegate));
            cfx_popup_features_set_dialog = (cfx_popup_features_set_dialog_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_dialog", typeof(cfx_popup_features_set_dialog_delegate));
            cfx_popup_features_get_dialog = (cfx_popup_features_get_dialog_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_dialog", typeof(cfx_popup_features_get_dialog_delegate));
            cfx_popup_features_set_additionalFeatures = (cfx_popup_features_set_additionalFeatures_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_set_additionalFeatures", typeof(cfx_popup_features_set_additionalFeatures_delegate));
            cfx_popup_features_get_additionalFeatures = (cfx_popup_features_get_additionalFeatures_delegate)GetDelegate(libcfxPtr, "cfx_popup_features_get_additionalFeatures", typeof(cfx_popup_features_get_additionalFeatures_delegate));



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


            // cef_print_dialog_callback

            cfx_print_dialog_callback_cont = (cfx_print_dialog_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_print_dialog_callback_cont", typeof(cfx_print_dialog_callback_cont_delegate));
            cfx_print_dialog_callback_cancel = (cfx_print_dialog_callback_cancel_delegate)GetDelegate(libcfxPtr, "cfx_print_dialog_callback_cancel", typeof(cfx_print_dialog_callback_cancel_delegate));


            // cef_print_handler

            cfx_print_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_print_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_print_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_print_job_callback

            cfx_print_job_callback_cont = (cfx_print_job_callback_cont_delegate)GetDelegate(libcfxPtr, "cfx_print_job_callback_cont", typeof(cfx_print_job_callback_cont_delegate));


            // cef_print_settings

            cfx_print_settings_create = (cfx_print_settings_create_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_create", typeof(cfx_print_settings_create_delegate));

            cfx_print_settings_is_valid = (cfx_print_settings_is_valid_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_is_valid", typeof(cfx_print_settings_is_valid_delegate));
            cfx_print_settings_is_read_only = (cfx_print_settings_is_read_only_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_is_read_only", typeof(cfx_print_settings_is_read_only_delegate));
            cfx_print_settings_copy = (cfx_print_settings_copy_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_copy", typeof(cfx_print_settings_copy_delegate));
            cfx_print_settings_set_orientation = (cfx_print_settings_set_orientation_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_orientation", typeof(cfx_print_settings_set_orientation_delegate));
            cfx_print_settings_is_landscape = (cfx_print_settings_is_landscape_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_is_landscape", typeof(cfx_print_settings_is_landscape_delegate));
            cfx_print_settings_set_printer_printable_area = (cfx_print_settings_set_printer_printable_area_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_printer_printable_area", typeof(cfx_print_settings_set_printer_printable_area_delegate));
            cfx_print_settings_set_device_name = (cfx_print_settings_set_device_name_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_device_name", typeof(cfx_print_settings_set_device_name_delegate));
            cfx_print_settings_get_device_name = (cfx_print_settings_get_device_name_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_device_name", typeof(cfx_print_settings_get_device_name_delegate));
            cfx_print_settings_set_dpi = (cfx_print_settings_set_dpi_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_dpi", typeof(cfx_print_settings_set_dpi_delegate));
            cfx_print_settings_get_dpi = (cfx_print_settings_get_dpi_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_dpi", typeof(cfx_print_settings_get_dpi_delegate));
            cfx_print_settings_set_page_ranges = (cfx_print_settings_set_page_ranges_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_page_ranges", typeof(cfx_print_settings_set_page_ranges_delegate));
            cfx_print_settings_get_page_ranges_count = (cfx_print_settings_get_page_ranges_count_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_page_ranges_count", typeof(cfx_print_settings_get_page_ranges_count_delegate));
            cfx_print_settings_get_page_ranges = (cfx_print_settings_get_page_ranges_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_page_ranges", typeof(cfx_print_settings_get_page_ranges_delegate));
            cfx_print_settings_set_selection_only = (cfx_print_settings_set_selection_only_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_selection_only", typeof(cfx_print_settings_set_selection_only_delegate));
            cfx_print_settings_is_selection_only = (cfx_print_settings_is_selection_only_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_is_selection_only", typeof(cfx_print_settings_is_selection_only_delegate));
            cfx_print_settings_set_collate = (cfx_print_settings_set_collate_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_collate", typeof(cfx_print_settings_set_collate_delegate));
            cfx_print_settings_will_collate = (cfx_print_settings_will_collate_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_will_collate", typeof(cfx_print_settings_will_collate_delegate));
            cfx_print_settings_set_color_model = (cfx_print_settings_set_color_model_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_color_model", typeof(cfx_print_settings_set_color_model_delegate));
            cfx_print_settings_get_color_model = (cfx_print_settings_get_color_model_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_color_model", typeof(cfx_print_settings_get_color_model_delegate));
            cfx_print_settings_set_copies = (cfx_print_settings_set_copies_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_copies", typeof(cfx_print_settings_set_copies_delegate));
            cfx_print_settings_get_copies = (cfx_print_settings_get_copies_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_copies", typeof(cfx_print_settings_get_copies_delegate));
            cfx_print_settings_set_duplex_mode = (cfx_print_settings_set_duplex_mode_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_set_duplex_mode", typeof(cfx_print_settings_set_duplex_mode_delegate));
            cfx_print_settings_get_duplex_mode = (cfx_print_settings_get_duplex_mode_delegate)GetDelegate(libcfxPtr, "cfx_print_settings_get_duplex_mode", typeof(cfx_print_settings_get_duplex_mode_delegate));


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
            cfx_read_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_rect

            cfx_rect_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_rect_ctor", typeof(cfx_ctor_delegate));
            cfx_rect_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_rect_dtor", typeof(cfx_dtor_delegate));

            cfx_rect_set_x = (cfx_rect_set_x_delegate)GetDelegate(libcfxPtr, "cfx_rect_set_x", typeof(cfx_rect_set_x_delegate));
            cfx_rect_get_x = (cfx_rect_get_x_delegate)GetDelegate(libcfxPtr, "cfx_rect_get_x", typeof(cfx_rect_get_x_delegate));
            cfx_rect_set_y = (cfx_rect_set_y_delegate)GetDelegate(libcfxPtr, "cfx_rect_set_y", typeof(cfx_rect_set_y_delegate));
            cfx_rect_get_y = (cfx_rect_get_y_delegate)GetDelegate(libcfxPtr, "cfx_rect_get_y", typeof(cfx_rect_get_y_delegate));
            cfx_rect_set_width = (cfx_rect_set_width_delegate)GetDelegate(libcfxPtr, "cfx_rect_set_width", typeof(cfx_rect_set_width_delegate));
            cfx_rect_get_width = (cfx_rect_get_width_delegate)GetDelegate(libcfxPtr, "cfx_rect_get_width", typeof(cfx_rect_get_width_delegate));
            cfx_rect_set_height = (cfx_rect_set_height_delegate)GetDelegate(libcfxPtr, "cfx_rect_set_height", typeof(cfx_rect_set_height_delegate));
            cfx_rect_get_height = (cfx_rect_get_height_delegate)GetDelegate(libcfxPtr, "cfx_rect_get_height", typeof(cfx_rect_get_height_delegate));



            // cef_render_handler

            cfx_render_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_render_process_handler

            cfx_render_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_process_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_request_context_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_request_context_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_request_handler

            cfx_request_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_request_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_request_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_request_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_resource_bundle_handler

            cfx_resource_bundle_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_resource_bundle_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_resource_bundle_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_resource_bundle_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_resource_handler

            cfx_resource_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_resource_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_resource_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_resource_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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

            cfx_screen_info_set_device_scale_factor = (cfx_screen_info_set_device_scale_factor_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_device_scale_factor", typeof(cfx_screen_info_set_device_scale_factor_delegate));
            cfx_screen_info_get_device_scale_factor = (cfx_screen_info_get_device_scale_factor_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_device_scale_factor", typeof(cfx_screen_info_get_device_scale_factor_delegate));
            cfx_screen_info_set_depth = (cfx_screen_info_set_depth_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_depth", typeof(cfx_screen_info_set_depth_delegate));
            cfx_screen_info_get_depth = (cfx_screen_info_get_depth_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_depth", typeof(cfx_screen_info_get_depth_delegate));
            cfx_screen_info_set_depth_per_component = (cfx_screen_info_set_depth_per_component_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_depth_per_component", typeof(cfx_screen_info_set_depth_per_component_delegate));
            cfx_screen_info_get_depth_per_component = (cfx_screen_info_get_depth_per_component_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_depth_per_component", typeof(cfx_screen_info_get_depth_per_component_delegate));
            cfx_screen_info_set_is_monochrome = (cfx_screen_info_set_is_monochrome_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_is_monochrome", typeof(cfx_screen_info_set_is_monochrome_delegate));
            cfx_screen_info_get_is_monochrome = (cfx_screen_info_get_is_monochrome_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_is_monochrome", typeof(cfx_screen_info_get_is_monochrome_delegate));
            cfx_screen_info_set_rect = (cfx_screen_info_set_rect_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_rect", typeof(cfx_screen_info_set_rect_delegate));
            cfx_screen_info_get_rect = (cfx_screen_info_get_rect_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_rect", typeof(cfx_screen_info_get_rect_delegate));
            cfx_screen_info_set_available_rect = (cfx_screen_info_set_available_rect_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_set_available_rect", typeof(cfx_screen_info_set_available_rect_delegate));
            cfx_screen_info_get_available_rect = (cfx_screen_info_get_available_rect_delegate)GetDelegate(libcfxPtr, "cfx_screen_info_get_available_rect", typeof(cfx_screen_info_get_available_rect_delegate));



            // cef_settings

            cfx_settings_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_settings_ctor", typeof(cfx_ctor_delegate));
            cfx_settings_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_settings_dtor", typeof(cfx_dtor_delegate));

            cfx_settings_set_single_process = (cfx_settings_set_single_process_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_single_process", typeof(cfx_settings_set_single_process_delegate));
            cfx_settings_get_single_process = (cfx_settings_get_single_process_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_single_process", typeof(cfx_settings_get_single_process_delegate));
            cfx_settings_set_no_sandbox = (cfx_settings_set_no_sandbox_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_no_sandbox", typeof(cfx_settings_set_no_sandbox_delegate));
            cfx_settings_get_no_sandbox = (cfx_settings_get_no_sandbox_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_no_sandbox", typeof(cfx_settings_get_no_sandbox_delegate));
            cfx_settings_set_browser_subprocess_path = (cfx_settings_set_browser_subprocess_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_browser_subprocess_path", typeof(cfx_settings_set_browser_subprocess_path_delegate));
            cfx_settings_get_browser_subprocess_path = (cfx_settings_get_browser_subprocess_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_browser_subprocess_path", typeof(cfx_settings_get_browser_subprocess_path_delegate));
            cfx_settings_set_multi_threaded_message_loop = (cfx_settings_set_multi_threaded_message_loop_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_multi_threaded_message_loop", typeof(cfx_settings_set_multi_threaded_message_loop_delegate));
            cfx_settings_get_multi_threaded_message_loop = (cfx_settings_get_multi_threaded_message_loop_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_multi_threaded_message_loop", typeof(cfx_settings_get_multi_threaded_message_loop_delegate));
            cfx_settings_set_windowless_rendering_enabled = (cfx_settings_set_windowless_rendering_enabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_windowless_rendering_enabled", typeof(cfx_settings_set_windowless_rendering_enabled_delegate));
            cfx_settings_get_windowless_rendering_enabled = (cfx_settings_get_windowless_rendering_enabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_windowless_rendering_enabled", typeof(cfx_settings_get_windowless_rendering_enabled_delegate));
            cfx_settings_set_command_line_args_disabled = (cfx_settings_set_command_line_args_disabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_command_line_args_disabled", typeof(cfx_settings_set_command_line_args_disabled_delegate));
            cfx_settings_get_command_line_args_disabled = (cfx_settings_get_command_line_args_disabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_command_line_args_disabled", typeof(cfx_settings_get_command_line_args_disabled_delegate));
            cfx_settings_set_cache_path = (cfx_settings_set_cache_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_cache_path", typeof(cfx_settings_set_cache_path_delegate));
            cfx_settings_get_cache_path = (cfx_settings_get_cache_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_cache_path", typeof(cfx_settings_get_cache_path_delegate));
            cfx_settings_set_persist_session_cookies = (cfx_settings_set_persist_session_cookies_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_persist_session_cookies", typeof(cfx_settings_set_persist_session_cookies_delegate));
            cfx_settings_get_persist_session_cookies = (cfx_settings_get_persist_session_cookies_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_persist_session_cookies", typeof(cfx_settings_get_persist_session_cookies_delegate));
            cfx_settings_set_user_agent = (cfx_settings_set_user_agent_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_user_agent", typeof(cfx_settings_set_user_agent_delegate));
            cfx_settings_get_user_agent = (cfx_settings_get_user_agent_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_user_agent", typeof(cfx_settings_get_user_agent_delegate));
            cfx_settings_set_product_version = (cfx_settings_set_product_version_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_product_version", typeof(cfx_settings_set_product_version_delegate));
            cfx_settings_get_product_version = (cfx_settings_get_product_version_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_product_version", typeof(cfx_settings_get_product_version_delegate));
            cfx_settings_set_locale = (cfx_settings_set_locale_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_locale", typeof(cfx_settings_set_locale_delegate));
            cfx_settings_get_locale = (cfx_settings_get_locale_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_locale", typeof(cfx_settings_get_locale_delegate));
            cfx_settings_set_log_file = (cfx_settings_set_log_file_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_log_file", typeof(cfx_settings_set_log_file_delegate));
            cfx_settings_get_log_file = (cfx_settings_get_log_file_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_log_file", typeof(cfx_settings_get_log_file_delegate));
            cfx_settings_set_log_severity = (cfx_settings_set_log_severity_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_log_severity", typeof(cfx_settings_set_log_severity_delegate));
            cfx_settings_get_log_severity = (cfx_settings_get_log_severity_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_log_severity", typeof(cfx_settings_get_log_severity_delegate));
            cfx_settings_set_javascript_flags = (cfx_settings_set_javascript_flags_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_javascript_flags", typeof(cfx_settings_set_javascript_flags_delegate));
            cfx_settings_get_javascript_flags = (cfx_settings_get_javascript_flags_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_javascript_flags", typeof(cfx_settings_get_javascript_flags_delegate));
            cfx_settings_set_resources_dir_path = (cfx_settings_set_resources_dir_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_resources_dir_path", typeof(cfx_settings_set_resources_dir_path_delegate));
            cfx_settings_get_resources_dir_path = (cfx_settings_get_resources_dir_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_resources_dir_path", typeof(cfx_settings_get_resources_dir_path_delegate));
            cfx_settings_set_locales_dir_path = (cfx_settings_set_locales_dir_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_locales_dir_path", typeof(cfx_settings_set_locales_dir_path_delegate));
            cfx_settings_get_locales_dir_path = (cfx_settings_get_locales_dir_path_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_locales_dir_path", typeof(cfx_settings_get_locales_dir_path_delegate));
            cfx_settings_set_pack_loading_disabled = (cfx_settings_set_pack_loading_disabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_pack_loading_disabled", typeof(cfx_settings_set_pack_loading_disabled_delegate));
            cfx_settings_get_pack_loading_disabled = (cfx_settings_get_pack_loading_disabled_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_pack_loading_disabled", typeof(cfx_settings_get_pack_loading_disabled_delegate));
            cfx_settings_set_remote_debugging_port = (cfx_settings_set_remote_debugging_port_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_remote_debugging_port", typeof(cfx_settings_set_remote_debugging_port_delegate));
            cfx_settings_get_remote_debugging_port = (cfx_settings_get_remote_debugging_port_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_remote_debugging_port", typeof(cfx_settings_get_remote_debugging_port_delegate));
            cfx_settings_set_uncaught_exception_stack_size = (cfx_settings_set_uncaught_exception_stack_size_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_uncaught_exception_stack_size", typeof(cfx_settings_set_uncaught_exception_stack_size_delegate));
            cfx_settings_get_uncaught_exception_stack_size = (cfx_settings_get_uncaught_exception_stack_size_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_uncaught_exception_stack_size", typeof(cfx_settings_get_uncaught_exception_stack_size_delegate));
            cfx_settings_set_context_safety_implementation = (cfx_settings_set_context_safety_implementation_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_context_safety_implementation", typeof(cfx_settings_set_context_safety_implementation_delegate));
            cfx_settings_get_context_safety_implementation = (cfx_settings_get_context_safety_implementation_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_context_safety_implementation", typeof(cfx_settings_get_context_safety_implementation_delegate));
            cfx_settings_set_ignore_certificate_errors = (cfx_settings_set_ignore_certificate_errors_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_ignore_certificate_errors", typeof(cfx_settings_set_ignore_certificate_errors_delegate));
            cfx_settings_get_ignore_certificate_errors = (cfx_settings_get_ignore_certificate_errors_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_ignore_certificate_errors", typeof(cfx_settings_get_ignore_certificate_errors_delegate));
            cfx_settings_set_background_color = (cfx_settings_set_background_color_delegate)GetDelegate(libcfxPtr, "cfx_settings_set_background_color", typeof(cfx_settings_set_background_color_delegate));
            cfx_settings_get_background_color = (cfx_settings_get_background_color_delegate)GetDelegate(libcfxPtr, "cfx_settings_get_background_color", typeof(cfx_settings_get_background_color_delegate));



            // cef_size

            cfx_size_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_size_ctor", typeof(cfx_ctor_delegate));
            cfx_size_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_size_dtor", typeof(cfx_dtor_delegate));

            cfx_size_set_width = (cfx_size_set_width_delegate)GetDelegate(libcfxPtr, "cfx_size_set_width", typeof(cfx_size_set_width_delegate));
            cfx_size_get_width = (cfx_size_get_width_delegate)GetDelegate(libcfxPtr, "cfx_size_get_width", typeof(cfx_size_get_width_delegate));
            cfx_size_set_height = (cfx_size_set_height_delegate)GetDelegate(libcfxPtr, "cfx_size_set_height", typeof(cfx_size_set_height_delegate));
            cfx_size_get_height = (cfx_size_get_height_delegate)GetDelegate(libcfxPtr, "cfx_size_get_height", typeof(cfx_size_get_height_delegate));



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
            cfx_string_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_task

            cfx_task_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_task_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_task_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_task_set_managed_callback", typeof(cfx_set_callback_delegate));


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

            cfx_time_set_year = (cfx_time_set_year_delegate)GetDelegate(libcfxPtr, "cfx_time_set_year", typeof(cfx_time_set_year_delegate));
            cfx_time_get_year = (cfx_time_get_year_delegate)GetDelegate(libcfxPtr, "cfx_time_get_year", typeof(cfx_time_get_year_delegate));
            cfx_time_set_month = (cfx_time_set_month_delegate)GetDelegate(libcfxPtr, "cfx_time_set_month", typeof(cfx_time_set_month_delegate));
            cfx_time_get_month = (cfx_time_get_month_delegate)GetDelegate(libcfxPtr, "cfx_time_get_month", typeof(cfx_time_get_month_delegate));
            cfx_time_set_day_of_week = (cfx_time_set_day_of_week_delegate)GetDelegate(libcfxPtr, "cfx_time_set_day_of_week", typeof(cfx_time_set_day_of_week_delegate));
            cfx_time_get_day_of_week = (cfx_time_get_day_of_week_delegate)GetDelegate(libcfxPtr, "cfx_time_get_day_of_week", typeof(cfx_time_get_day_of_week_delegate));
            cfx_time_set_day_of_month = (cfx_time_set_day_of_month_delegate)GetDelegate(libcfxPtr, "cfx_time_set_day_of_month", typeof(cfx_time_set_day_of_month_delegate));
            cfx_time_get_day_of_month = (cfx_time_get_day_of_month_delegate)GetDelegate(libcfxPtr, "cfx_time_get_day_of_month", typeof(cfx_time_get_day_of_month_delegate));
            cfx_time_set_hour = (cfx_time_set_hour_delegate)GetDelegate(libcfxPtr, "cfx_time_set_hour", typeof(cfx_time_set_hour_delegate));
            cfx_time_get_hour = (cfx_time_get_hour_delegate)GetDelegate(libcfxPtr, "cfx_time_get_hour", typeof(cfx_time_get_hour_delegate));
            cfx_time_set_minute = (cfx_time_set_minute_delegate)GetDelegate(libcfxPtr, "cfx_time_set_minute", typeof(cfx_time_set_minute_delegate));
            cfx_time_get_minute = (cfx_time_get_minute_delegate)GetDelegate(libcfxPtr, "cfx_time_get_minute", typeof(cfx_time_get_minute_delegate));
            cfx_time_set_second = (cfx_time_set_second_delegate)GetDelegate(libcfxPtr, "cfx_time_set_second", typeof(cfx_time_set_second_delegate));
            cfx_time_get_second = (cfx_time_get_second_delegate)GetDelegate(libcfxPtr, "cfx_time_get_second", typeof(cfx_time_get_second_delegate));
            cfx_time_set_millisecond = (cfx_time_set_millisecond_delegate)GetDelegate(libcfxPtr, "cfx_time_set_millisecond", typeof(cfx_time_set_millisecond_delegate));
            cfx_time_get_millisecond = (cfx_time_get_millisecond_delegate)GetDelegate(libcfxPtr, "cfx_time_get_millisecond", typeof(cfx_time_get_millisecond_delegate));



            // cef_urlparts

            cfx_urlparts_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_ctor", typeof(cfx_ctor_delegate));
            cfx_urlparts_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_dtor", typeof(cfx_dtor_delegate));

            cfx_urlparts_set_spec = (cfx_urlparts_set_spec_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_spec", typeof(cfx_urlparts_set_spec_delegate));
            cfx_urlparts_get_spec = (cfx_urlparts_get_spec_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_spec", typeof(cfx_urlparts_get_spec_delegate));
            cfx_urlparts_set_scheme = (cfx_urlparts_set_scheme_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_scheme", typeof(cfx_urlparts_set_scheme_delegate));
            cfx_urlparts_get_scheme = (cfx_urlparts_get_scheme_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_scheme", typeof(cfx_urlparts_get_scheme_delegate));
            cfx_urlparts_set_username = (cfx_urlparts_set_username_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_username", typeof(cfx_urlparts_set_username_delegate));
            cfx_urlparts_get_username = (cfx_urlparts_get_username_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_username", typeof(cfx_urlparts_get_username_delegate));
            cfx_urlparts_set_password = (cfx_urlparts_set_password_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_password", typeof(cfx_urlparts_set_password_delegate));
            cfx_urlparts_get_password = (cfx_urlparts_get_password_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_password", typeof(cfx_urlparts_get_password_delegate));
            cfx_urlparts_set_host = (cfx_urlparts_set_host_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_host", typeof(cfx_urlparts_set_host_delegate));
            cfx_urlparts_get_host = (cfx_urlparts_get_host_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_host", typeof(cfx_urlparts_get_host_delegate));
            cfx_urlparts_set_port = (cfx_urlparts_set_port_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_port", typeof(cfx_urlparts_set_port_delegate));
            cfx_urlparts_get_port = (cfx_urlparts_get_port_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_port", typeof(cfx_urlparts_get_port_delegate));
            cfx_urlparts_set_origin = (cfx_urlparts_set_origin_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_origin", typeof(cfx_urlparts_set_origin_delegate));
            cfx_urlparts_get_origin = (cfx_urlparts_get_origin_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_origin", typeof(cfx_urlparts_get_origin_delegate));
            cfx_urlparts_set_path = (cfx_urlparts_set_path_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_path", typeof(cfx_urlparts_set_path_delegate));
            cfx_urlparts_get_path = (cfx_urlparts_get_path_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_path", typeof(cfx_urlparts_get_path_delegate));
            cfx_urlparts_set_query = (cfx_urlparts_set_query_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_set_query", typeof(cfx_urlparts_set_query_delegate));
            cfx_urlparts_get_query = (cfx_urlparts_get_query_delegate)GetDelegate(libcfxPtr, "cfx_urlparts_get_query", typeof(cfx_urlparts_get_query_delegate));



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
            cfx_urlrequest_client_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_v8accessor

            cfx_v8accessor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_v8accessor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_v8accessor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_v8handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
            cfx_web_plugin_info_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_web_plugin_unstable_callback

            cfx_web_plugin_unstable_callback_is_unstable = (cfx_web_plugin_unstable_callback_is_unstable_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_unstable_callback_is_unstable", typeof(cfx_web_plugin_unstable_callback_is_unstable_delegate));


            // cef_window_info

            cfx_window_info_ctor = (cfx_ctor_delegate)GetDelegate(libcfxPtr, "cfx_window_info_ctor", typeof(cfx_ctor_delegate));
            cfx_window_info_dtor = (cfx_dtor_delegate)GetDelegate(libcfxPtr, "cfx_window_info_dtor", typeof(cfx_dtor_delegate));

            cfx_window_info_set_ex_style = (cfx_window_info_set_ex_style_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_ex_style", typeof(cfx_window_info_set_ex_style_delegate));
            cfx_window_info_get_ex_style = (cfx_window_info_get_ex_style_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_ex_style", typeof(cfx_window_info_get_ex_style_delegate));
            cfx_window_info_set_window_name = (cfx_window_info_set_window_name_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_window_name", typeof(cfx_window_info_set_window_name_delegate));
            cfx_window_info_get_window_name = (cfx_window_info_get_window_name_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_window_name", typeof(cfx_window_info_get_window_name_delegate));
            cfx_window_info_set_style = (cfx_window_info_set_style_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_style", typeof(cfx_window_info_set_style_delegate));
            cfx_window_info_get_style = (cfx_window_info_get_style_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_style", typeof(cfx_window_info_get_style_delegate));
            cfx_window_info_set_x = (cfx_window_info_set_x_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_x", typeof(cfx_window_info_set_x_delegate));
            cfx_window_info_get_x = (cfx_window_info_get_x_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_x", typeof(cfx_window_info_get_x_delegate));
            cfx_window_info_set_y = (cfx_window_info_set_y_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_y", typeof(cfx_window_info_set_y_delegate));
            cfx_window_info_get_y = (cfx_window_info_get_y_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_y", typeof(cfx_window_info_get_y_delegate));
            cfx_window_info_set_width = (cfx_window_info_set_width_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_width", typeof(cfx_window_info_set_width_delegate));
            cfx_window_info_get_width = (cfx_window_info_get_width_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_width", typeof(cfx_window_info_get_width_delegate));
            cfx_window_info_set_height = (cfx_window_info_set_height_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_height", typeof(cfx_window_info_set_height_delegate));
            cfx_window_info_get_height = (cfx_window_info_get_height_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_height", typeof(cfx_window_info_get_height_delegate));
            cfx_window_info_set_parent_window = (cfx_window_info_set_parent_window_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_parent_window", typeof(cfx_window_info_set_parent_window_delegate));
            cfx_window_info_get_parent_window = (cfx_window_info_get_parent_window_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_parent_window", typeof(cfx_window_info_get_parent_window_delegate));
            cfx_window_info_set_menu = (cfx_window_info_set_menu_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_menu", typeof(cfx_window_info_set_menu_delegate));
            cfx_window_info_get_menu = (cfx_window_info_get_menu_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_menu", typeof(cfx_window_info_get_menu_delegate));
            cfx_window_info_set_windowless_rendering_enabled = (cfx_window_info_set_windowless_rendering_enabled_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_windowless_rendering_enabled", typeof(cfx_window_info_set_windowless_rendering_enabled_delegate));
            cfx_window_info_get_windowless_rendering_enabled = (cfx_window_info_get_windowless_rendering_enabled_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_windowless_rendering_enabled", typeof(cfx_window_info_get_windowless_rendering_enabled_delegate));
            cfx_window_info_set_transparent_painting_enabled = (cfx_window_info_set_transparent_painting_enabled_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_transparent_painting_enabled", typeof(cfx_window_info_set_transparent_painting_enabled_delegate));
            cfx_window_info_get_transparent_painting_enabled = (cfx_window_info_get_transparent_painting_enabled_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_transparent_painting_enabled", typeof(cfx_window_info_get_transparent_painting_enabled_delegate));
            cfx_window_info_set_window = (cfx_window_info_set_window_delegate)GetDelegate(libcfxPtr, "cfx_window_info_set_window", typeof(cfx_window_info_set_window_delegate));
            cfx_window_info_get_window = (cfx_window_info_get_window_delegate)GetDelegate(libcfxPtr, "cfx_window_info_get_window", typeof(cfx_window_info_get_window_delegate));



            // cef_write_handler

            cfx_write_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_write_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_write_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


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
