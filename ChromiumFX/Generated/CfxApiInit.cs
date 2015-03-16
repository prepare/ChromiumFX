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

            CfxApi.cfx_add_cross_origin_whitelist_entry = (CfxApi.cfx_add_cross_origin_whitelist_entry_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_add_cross_origin_whitelist_entry", typeof(CfxApi.cfx_add_cross_origin_whitelist_entry_delegate));
            CfxApi.cfx_add_web_plugin_directory = (CfxApi.cfx_add_web_plugin_directory_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_add_web_plugin_directory", typeof(CfxApi.cfx_add_web_plugin_directory_delegate));
            CfxApi.cfx_add_web_plugin_path = (CfxApi.cfx_add_web_plugin_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_add_web_plugin_path", typeof(CfxApi.cfx_add_web_plugin_path_delegate));
            CfxApi.cfx_api_hash = (CfxApi.cfx_api_hash_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_api_hash", typeof(CfxApi.cfx_api_hash_delegate));
            CfxApi.cfx_begin_tracing = (CfxApi.cfx_begin_tracing_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_begin_tracing", typeof(CfxApi.cfx_begin_tracing_delegate));
            CfxApi.cfx_build_revision = (CfxApi.cfx_build_revision_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_build_revision", typeof(CfxApi.cfx_build_revision_delegate));
            CfxApi.cfx_clear_cross_origin_whitelist = (CfxApi.cfx_clear_cross_origin_whitelist_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_clear_cross_origin_whitelist", typeof(CfxApi.cfx_clear_cross_origin_whitelist_delegate));
            CfxApi.cfx_clear_scheme_handler_factories = (CfxApi.cfx_clear_scheme_handler_factories_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_clear_scheme_handler_factories", typeof(CfxApi.cfx_clear_scheme_handler_factories_delegate));
            CfxApi.cfx_create_url = (CfxApi.cfx_create_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_create_url", typeof(CfxApi.cfx_create_url_delegate));
            CfxApi.cfx_currently_on = (CfxApi.cfx_currently_on_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_currently_on", typeof(CfxApi.cfx_currently_on_delegate));
            CfxApi.cfx_do_message_loop_work = (CfxApi.cfx_do_message_loop_work_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_do_message_loop_work", typeof(CfxApi.cfx_do_message_loop_work_delegate));
            CfxApi.cfx_end_tracing = (CfxApi.cfx_end_tracing_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_end_tracing", typeof(CfxApi.cfx_end_tracing_delegate));
            CfxApi.cfx_execute_process = (CfxApi.cfx_execute_process_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_execute_process", typeof(CfxApi.cfx_execute_process_delegate));
            CfxApi.cfx_force_web_plugin_shutdown = (CfxApi.cfx_force_web_plugin_shutdown_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_force_web_plugin_shutdown", typeof(CfxApi.cfx_force_web_plugin_shutdown_delegate));
            CfxApi.cfx_get_extensions_for_mime_type = (CfxApi.cfx_get_extensions_for_mime_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_get_extensions_for_mime_type", typeof(CfxApi.cfx_get_extensions_for_mime_type_delegate));
            CfxApi.cfx_get_geolocation = (CfxApi.cfx_get_geolocation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_get_geolocation", typeof(CfxApi.cfx_get_geolocation_delegate));
            CfxApi.cfx_get_mime_type = (CfxApi.cfx_get_mime_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_get_mime_type", typeof(CfxApi.cfx_get_mime_type_delegate));
            CfxApi.cfx_get_path = (CfxApi.cfx_get_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_get_path", typeof(CfxApi.cfx_get_path_delegate));
            CfxApi.cfx_initialize = (CfxApi.cfx_initialize_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_initialize", typeof(CfxApi.cfx_initialize_delegate));
            CfxApi.cfx_is_web_plugin_unstable = (CfxApi.cfx_is_web_plugin_unstable_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_is_web_plugin_unstable", typeof(CfxApi.cfx_is_web_plugin_unstable_delegate));
            CfxApi.cfx_launch_process = (CfxApi.cfx_launch_process_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_launch_process", typeof(CfxApi.cfx_launch_process_delegate));
            CfxApi.cfx_now_from_system_trace_time = (CfxApi.cfx_now_from_system_trace_time_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_now_from_system_trace_time", typeof(CfxApi.cfx_now_from_system_trace_time_delegate));
            CfxApi.cfx_parse_url = (CfxApi.cfx_parse_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_parse_url", typeof(CfxApi.cfx_parse_url_delegate));
            CfxApi.cfx_post_delayed_task = (CfxApi.cfx_post_delayed_task_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_post_delayed_task", typeof(CfxApi.cfx_post_delayed_task_delegate));
            CfxApi.cfx_post_task = (CfxApi.cfx_post_task_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_post_task", typeof(CfxApi.cfx_post_task_delegate));
            CfxApi.cfx_quit_message_loop = (CfxApi.cfx_quit_message_loop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_quit_message_loop", typeof(CfxApi.cfx_quit_message_loop_delegate));
            CfxApi.cfx_refresh_web_plugins = (CfxApi.cfx_refresh_web_plugins_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_refresh_web_plugins", typeof(CfxApi.cfx_refresh_web_plugins_delegate));
            CfxApi.cfx_register_extension = (CfxApi.cfx_register_extension_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_register_extension", typeof(CfxApi.cfx_register_extension_delegate));
            CfxApi.cfx_register_scheme_handler_factory = (CfxApi.cfx_register_scheme_handler_factory_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_register_scheme_handler_factory", typeof(CfxApi.cfx_register_scheme_handler_factory_delegate));
            CfxApi.cfx_register_web_plugin_crash = (CfxApi.cfx_register_web_plugin_crash_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_register_web_plugin_crash", typeof(CfxApi.cfx_register_web_plugin_crash_delegate));
            CfxApi.cfx_remove_cross_origin_whitelist_entry = (CfxApi.cfx_remove_cross_origin_whitelist_entry_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_remove_cross_origin_whitelist_entry", typeof(CfxApi.cfx_remove_cross_origin_whitelist_entry_delegate));
            CfxApi.cfx_remove_web_plugin_path = (CfxApi.cfx_remove_web_plugin_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_remove_web_plugin_path", typeof(CfxApi.cfx_remove_web_plugin_path_delegate));
            CfxApi.cfx_run_message_loop = (CfxApi.cfx_run_message_loop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_run_message_loop", typeof(CfxApi.cfx_run_message_loop_delegate));
            CfxApi.cfx_set_osmodal_loop = (CfxApi.cfx_set_osmodal_loop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_set_osmodal_loop", typeof(CfxApi.cfx_set_osmodal_loop_delegate));
            CfxApi.cfx_shutdown = (CfxApi.cfx_shutdown_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_shutdown", typeof(CfxApi.cfx_shutdown_delegate));
            CfxApi.cfx_unregister_internal_web_plugin = (CfxApi.cfx_unregister_internal_web_plugin_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_unregister_internal_web_plugin", typeof(CfxApi.cfx_unregister_internal_web_plugin_delegate));
            CfxApi.cfx_version_info = (CfxApi.cfx_version_info_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_version_info", typeof(CfxApi.cfx_version_info_delegate));
            CfxApi.cfx_visit_web_plugin_info = (CfxApi.cfx_visit_web_plugin_info_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_visit_web_plugin_info", typeof(CfxApi.cfx_visit_web_plugin_info_delegate));
            CfxApi.cfx_string_list_alloc = (CfxApi.cfx_string_list_alloc_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_alloc", typeof(CfxApi.cfx_string_list_alloc_delegate));
            CfxApi.cfx_string_list_size = (CfxApi.cfx_string_list_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_size", typeof(CfxApi.cfx_string_list_size_delegate));
            CfxApi.cfx_string_list_value = (CfxApi.cfx_string_list_value_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_value", typeof(CfxApi.cfx_string_list_value_delegate));
            CfxApi.cfx_string_list_append = (CfxApi.cfx_string_list_append_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_append", typeof(CfxApi.cfx_string_list_append_delegate));
            CfxApi.cfx_string_list_clear = (CfxApi.cfx_string_list_clear_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_clear", typeof(CfxApi.cfx_string_list_clear_delegate));
            CfxApi.cfx_string_list_free = (CfxApi.cfx_string_list_free_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_free", typeof(CfxApi.cfx_string_list_free_delegate));
            CfxApi.cfx_string_list_copy = (CfxApi.cfx_string_list_copy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_list_copy", typeof(CfxApi.cfx_string_list_copy_delegate));

            CfxApi.cfx_string_map_alloc = (CfxApi.cfx_string_map_alloc_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_alloc", typeof(CfxApi.cfx_string_map_alloc_delegate));
            CfxApi.cfx_string_map_size = (CfxApi.cfx_string_map_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_size", typeof(CfxApi.cfx_string_map_size_delegate));
            CfxApi.cfx_string_map_find = (CfxApi.cfx_string_map_find_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_find", typeof(CfxApi.cfx_string_map_find_delegate));
            CfxApi.cfx_string_map_key = (CfxApi.cfx_string_map_key_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_key", typeof(CfxApi.cfx_string_map_key_delegate));
            CfxApi.cfx_string_map_value = (CfxApi.cfx_string_map_value_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_value", typeof(CfxApi.cfx_string_map_value_delegate));
            CfxApi.cfx_string_map_append = (CfxApi.cfx_string_map_append_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_append", typeof(CfxApi.cfx_string_map_append_delegate));
            CfxApi.cfx_string_map_clear = (CfxApi.cfx_string_map_clear_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_clear", typeof(CfxApi.cfx_string_map_clear_delegate));
            CfxApi.cfx_string_map_free = (CfxApi.cfx_string_map_free_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_map_free", typeof(CfxApi.cfx_string_map_free_delegate));

            CfxApi.cfx_string_multimap_alloc = (CfxApi.cfx_string_multimap_alloc_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_alloc", typeof(CfxApi.cfx_string_multimap_alloc_delegate));
            CfxApi.cfx_string_multimap_size = (CfxApi.cfx_string_multimap_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_size", typeof(CfxApi.cfx_string_multimap_size_delegate));
            CfxApi.cfx_string_multimap_find_count = (CfxApi.cfx_string_multimap_find_count_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_find_count", typeof(CfxApi.cfx_string_multimap_find_count_delegate));
            CfxApi.cfx_string_multimap_enumerate = (CfxApi.cfx_string_multimap_enumerate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_enumerate", typeof(CfxApi.cfx_string_multimap_enumerate_delegate));
            CfxApi.cfx_string_multimap_key = (CfxApi.cfx_string_multimap_key_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_key", typeof(CfxApi.cfx_string_multimap_key_delegate));
            CfxApi.cfx_string_multimap_value = (CfxApi.cfx_string_multimap_value_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_value", typeof(CfxApi.cfx_string_multimap_value_delegate));
            CfxApi.cfx_string_multimap_append = (CfxApi.cfx_string_multimap_append_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_append", typeof(CfxApi.cfx_string_multimap_append_delegate));
            CfxApi.cfx_string_multimap_clear = (CfxApi.cfx_string_multimap_clear_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_clear", typeof(CfxApi.cfx_string_multimap_clear_delegate));
            CfxApi.cfx_string_multimap_free = (CfxApi.cfx_string_multimap_free_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_string_multimap_free", typeof(CfxApi.cfx_string_multimap_free_delegate));



            // cef_allow_certificate_error_callback



            // cef_app



            // cef_auth_callback



            // cef_before_download_callback



            // cef_binary_value



            // cef_browser



            // cef_browser_host



            // cef_browser_process_handler



            // cef_browser_settings




            // cef_callback



            // cef_client



            // cef_command_line



            // cef_completion_callback



            // cef_context_menu_handler



            // cef_context_menu_params



            // cef_cookie




            // cef_cookie_manager



            // cef_cookie_visitor



            // cef_cursor_info




            // cef_dialog_handler



            // cef_dictionary_value



            // cef_display_handler



            // cef_domdocument



            // cef_domnode



            // cef_domvisitor



            // cef_download_handler



            // cef_download_item



            // cef_download_item_callback



            // cef_drag_data



            // cef_drag_handler



            // cef_end_tracing_callback



            // cef_file_dialog_callback



            // cef_focus_handler



            // cef_frame



            // cef_geolocation_callback



            // cef_geolocation_handler



            // cef_geoposition




            // cef_get_geolocation_callback



            // cef_jsdialog_callback



            // cef_jsdialog_handler



            // cef_key_event




            // cef_keyboard_handler



            // cef_life_span_handler



            // cef_list_value



            // cef_load_handler



            // cef_menu_model



            // cef_mouse_event




            // cef_navigation_entry



            // cef_navigation_entry_visitor



            // cef_page_range




            // cef_point




            // cef_popup_features




            // cef_post_data



            // cef_post_data_element



            // cef_print_dialog_callback



            // cef_print_handler



            // cef_print_job_callback



            // cef_print_settings



            // cef_process_message



            // cef_quota_callback



            // cef_read_handler



            // cef_rect




            // cef_render_handler



            // cef_render_process_handler



            // cef_request



            // cef_request_context



            // cef_request_context_handler



            // cef_request_handler



            // cef_resource_bundle_handler



            // cef_resource_handler



            // cef_response



            // cef_run_file_dialog_callback



            // cef_scheme_handler_factory



            // cef_scheme_registrar



            // cef_screen_info




            // cef_settings




            // cef_size




            // cef_stream_reader



            // cef_stream_writer



            // cef_string_visitor



            // cef_task



            // cef_task_runner



            // cef_time




            // cef_urlparts




            // cef_urlrequest



            // cef_urlrequest_client



            // cef_v8accessor



            // cef_v8context



            // cef_v8exception



            // cef_v8handler



            // cef_v8stack_frame



            // cef_v8stack_trace



            // cef_v8value



            // cef_web_plugin_info



            // cef_web_plugin_info_visitor



            // cef_web_plugin_unstable_callback



            // cef_window_info




            // cef_write_handler



            // cef_xml_reader



            // cef_zip_reader



        }
    }
}
