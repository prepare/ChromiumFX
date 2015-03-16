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

            cfx_app_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_app_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_app_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_app_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_app_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_app_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_auth_callback



            // cef_before_download_callback



            // cef_binary_value



            // cef_browser



            // cef_browser_host



            // cef_browser_process_handler

            cfx_browser_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_browser_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_browser_process_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_browser_process_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_browser_settings

            CfxApi.cfx_browser_settings_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_browser_settings_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_browser_settings_set_windowless_frame_rate = (CfxApi.cfx_browser_settings_set_windowless_frame_rate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_windowless_frame_rate", typeof(CfxApi.cfx_browser_settings_set_windowless_frame_rate_delegate));
            CfxApi.cfx_browser_settings_get_windowless_frame_rate = (CfxApi.cfx_browser_settings_get_windowless_frame_rate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_windowless_frame_rate", typeof(CfxApi.cfx_browser_settings_get_windowless_frame_rate_delegate));
            CfxApi.cfx_browser_settings_set_standard_font_family = (CfxApi.cfx_browser_settings_set_standard_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_standard_font_family", typeof(CfxApi.cfx_browser_settings_set_standard_font_family_delegate));
            CfxApi.cfx_browser_settings_get_standard_font_family = (CfxApi.cfx_browser_settings_get_standard_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_standard_font_family", typeof(CfxApi.cfx_browser_settings_get_standard_font_family_delegate));
            CfxApi.cfx_browser_settings_set_fixed_font_family = (CfxApi.cfx_browser_settings_set_fixed_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_fixed_font_family", typeof(CfxApi.cfx_browser_settings_set_fixed_font_family_delegate));
            CfxApi.cfx_browser_settings_get_fixed_font_family = (CfxApi.cfx_browser_settings_get_fixed_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_fixed_font_family", typeof(CfxApi.cfx_browser_settings_get_fixed_font_family_delegate));
            CfxApi.cfx_browser_settings_set_serif_font_family = (CfxApi.cfx_browser_settings_set_serif_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_serif_font_family", typeof(CfxApi.cfx_browser_settings_set_serif_font_family_delegate));
            CfxApi.cfx_browser_settings_get_serif_font_family = (CfxApi.cfx_browser_settings_get_serif_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_serif_font_family", typeof(CfxApi.cfx_browser_settings_get_serif_font_family_delegate));
            CfxApi.cfx_browser_settings_set_sans_serif_font_family = (CfxApi.cfx_browser_settings_set_sans_serif_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_sans_serif_font_family", typeof(CfxApi.cfx_browser_settings_set_sans_serif_font_family_delegate));
            CfxApi.cfx_browser_settings_get_sans_serif_font_family = (CfxApi.cfx_browser_settings_get_sans_serif_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_sans_serif_font_family", typeof(CfxApi.cfx_browser_settings_get_sans_serif_font_family_delegate));
            CfxApi.cfx_browser_settings_set_cursive_font_family = (CfxApi.cfx_browser_settings_set_cursive_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_cursive_font_family", typeof(CfxApi.cfx_browser_settings_set_cursive_font_family_delegate));
            CfxApi.cfx_browser_settings_get_cursive_font_family = (CfxApi.cfx_browser_settings_get_cursive_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_cursive_font_family", typeof(CfxApi.cfx_browser_settings_get_cursive_font_family_delegate));
            CfxApi.cfx_browser_settings_set_fantasy_font_family = (CfxApi.cfx_browser_settings_set_fantasy_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_fantasy_font_family", typeof(CfxApi.cfx_browser_settings_set_fantasy_font_family_delegate));
            CfxApi.cfx_browser_settings_get_fantasy_font_family = (CfxApi.cfx_browser_settings_get_fantasy_font_family_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_fantasy_font_family", typeof(CfxApi.cfx_browser_settings_get_fantasy_font_family_delegate));
            CfxApi.cfx_browser_settings_set_default_font_size = (CfxApi.cfx_browser_settings_set_default_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_default_font_size", typeof(CfxApi.cfx_browser_settings_set_default_font_size_delegate));
            CfxApi.cfx_browser_settings_get_default_font_size = (CfxApi.cfx_browser_settings_get_default_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_default_font_size", typeof(CfxApi.cfx_browser_settings_get_default_font_size_delegate));
            CfxApi.cfx_browser_settings_set_default_fixed_font_size = (CfxApi.cfx_browser_settings_set_default_fixed_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_default_fixed_font_size", typeof(CfxApi.cfx_browser_settings_set_default_fixed_font_size_delegate));
            CfxApi.cfx_browser_settings_get_default_fixed_font_size = (CfxApi.cfx_browser_settings_get_default_fixed_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_default_fixed_font_size", typeof(CfxApi.cfx_browser_settings_get_default_fixed_font_size_delegate));
            CfxApi.cfx_browser_settings_set_minimum_font_size = (CfxApi.cfx_browser_settings_set_minimum_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_minimum_font_size", typeof(CfxApi.cfx_browser_settings_set_minimum_font_size_delegate));
            CfxApi.cfx_browser_settings_get_minimum_font_size = (CfxApi.cfx_browser_settings_get_minimum_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_minimum_font_size", typeof(CfxApi.cfx_browser_settings_get_minimum_font_size_delegate));
            CfxApi.cfx_browser_settings_set_minimum_logical_font_size = (CfxApi.cfx_browser_settings_set_minimum_logical_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_minimum_logical_font_size", typeof(CfxApi.cfx_browser_settings_set_minimum_logical_font_size_delegate));
            CfxApi.cfx_browser_settings_get_minimum_logical_font_size = (CfxApi.cfx_browser_settings_get_minimum_logical_font_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_minimum_logical_font_size", typeof(CfxApi.cfx_browser_settings_get_minimum_logical_font_size_delegate));
            CfxApi.cfx_browser_settings_set_default_encoding = (CfxApi.cfx_browser_settings_set_default_encoding_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_default_encoding", typeof(CfxApi.cfx_browser_settings_set_default_encoding_delegate));
            CfxApi.cfx_browser_settings_get_default_encoding = (CfxApi.cfx_browser_settings_get_default_encoding_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_default_encoding", typeof(CfxApi.cfx_browser_settings_get_default_encoding_delegate));
            CfxApi.cfx_browser_settings_set_remote_fonts = (CfxApi.cfx_browser_settings_set_remote_fonts_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_remote_fonts", typeof(CfxApi.cfx_browser_settings_set_remote_fonts_delegate));
            CfxApi.cfx_browser_settings_get_remote_fonts = (CfxApi.cfx_browser_settings_get_remote_fonts_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_remote_fonts", typeof(CfxApi.cfx_browser_settings_get_remote_fonts_delegate));
            CfxApi.cfx_browser_settings_set_javascript = (CfxApi.cfx_browser_settings_set_javascript_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_javascript", typeof(CfxApi.cfx_browser_settings_set_javascript_delegate));
            CfxApi.cfx_browser_settings_get_javascript = (CfxApi.cfx_browser_settings_get_javascript_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_javascript", typeof(CfxApi.cfx_browser_settings_get_javascript_delegate));
            CfxApi.cfx_browser_settings_set_javascript_open_windows = (CfxApi.cfx_browser_settings_set_javascript_open_windows_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_javascript_open_windows", typeof(CfxApi.cfx_browser_settings_set_javascript_open_windows_delegate));
            CfxApi.cfx_browser_settings_get_javascript_open_windows = (CfxApi.cfx_browser_settings_get_javascript_open_windows_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_javascript_open_windows", typeof(CfxApi.cfx_browser_settings_get_javascript_open_windows_delegate));
            CfxApi.cfx_browser_settings_set_javascript_close_windows = (CfxApi.cfx_browser_settings_set_javascript_close_windows_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_javascript_close_windows", typeof(CfxApi.cfx_browser_settings_set_javascript_close_windows_delegate));
            CfxApi.cfx_browser_settings_get_javascript_close_windows = (CfxApi.cfx_browser_settings_get_javascript_close_windows_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_javascript_close_windows", typeof(CfxApi.cfx_browser_settings_get_javascript_close_windows_delegate));
            CfxApi.cfx_browser_settings_set_javascript_access_clipboard = (CfxApi.cfx_browser_settings_set_javascript_access_clipboard_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_javascript_access_clipboard", typeof(CfxApi.cfx_browser_settings_set_javascript_access_clipboard_delegate));
            CfxApi.cfx_browser_settings_get_javascript_access_clipboard = (CfxApi.cfx_browser_settings_get_javascript_access_clipboard_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_javascript_access_clipboard", typeof(CfxApi.cfx_browser_settings_get_javascript_access_clipboard_delegate));
            CfxApi.cfx_browser_settings_set_javascript_dom_paste = (CfxApi.cfx_browser_settings_set_javascript_dom_paste_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_javascript_dom_paste", typeof(CfxApi.cfx_browser_settings_set_javascript_dom_paste_delegate));
            CfxApi.cfx_browser_settings_get_javascript_dom_paste = (CfxApi.cfx_browser_settings_get_javascript_dom_paste_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_javascript_dom_paste", typeof(CfxApi.cfx_browser_settings_get_javascript_dom_paste_delegate));
            CfxApi.cfx_browser_settings_set_caret_browsing = (CfxApi.cfx_browser_settings_set_caret_browsing_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_caret_browsing", typeof(CfxApi.cfx_browser_settings_set_caret_browsing_delegate));
            CfxApi.cfx_browser_settings_get_caret_browsing = (CfxApi.cfx_browser_settings_get_caret_browsing_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_caret_browsing", typeof(CfxApi.cfx_browser_settings_get_caret_browsing_delegate));
            CfxApi.cfx_browser_settings_set_java = (CfxApi.cfx_browser_settings_set_java_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_java", typeof(CfxApi.cfx_browser_settings_set_java_delegate));
            CfxApi.cfx_browser_settings_get_java = (CfxApi.cfx_browser_settings_get_java_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_java", typeof(CfxApi.cfx_browser_settings_get_java_delegate));
            CfxApi.cfx_browser_settings_set_plugins = (CfxApi.cfx_browser_settings_set_plugins_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_plugins", typeof(CfxApi.cfx_browser_settings_set_plugins_delegate));
            CfxApi.cfx_browser_settings_get_plugins = (CfxApi.cfx_browser_settings_get_plugins_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_plugins", typeof(CfxApi.cfx_browser_settings_get_plugins_delegate));
            CfxApi.cfx_browser_settings_set_universal_access_from_file_urls = (CfxApi.cfx_browser_settings_set_universal_access_from_file_urls_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_universal_access_from_file_urls", typeof(CfxApi.cfx_browser_settings_set_universal_access_from_file_urls_delegate));
            CfxApi.cfx_browser_settings_get_universal_access_from_file_urls = (CfxApi.cfx_browser_settings_get_universal_access_from_file_urls_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_universal_access_from_file_urls", typeof(CfxApi.cfx_browser_settings_get_universal_access_from_file_urls_delegate));
            CfxApi.cfx_browser_settings_set_file_access_from_file_urls = (CfxApi.cfx_browser_settings_set_file_access_from_file_urls_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_file_access_from_file_urls", typeof(CfxApi.cfx_browser_settings_set_file_access_from_file_urls_delegate));
            CfxApi.cfx_browser_settings_get_file_access_from_file_urls = (CfxApi.cfx_browser_settings_get_file_access_from_file_urls_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_file_access_from_file_urls", typeof(CfxApi.cfx_browser_settings_get_file_access_from_file_urls_delegate));
            CfxApi.cfx_browser_settings_set_web_security = (CfxApi.cfx_browser_settings_set_web_security_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_web_security", typeof(CfxApi.cfx_browser_settings_set_web_security_delegate));
            CfxApi.cfx_browser_settings_get_web_security = (CfxApi.cfx_browser_settings_get_web_security_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_web_security", typeof(CfxApi.cfx_browser_settings_get_web_security_delegate));
            CfxApi.cfx_browser_settings_set_image_loading = (CfxApi.cfx_browser_settings_set_image_loading_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_image_loading", typeof(CfxApi.cfx_browser_settings_set_image_loading_delegate));
            CfxApi.cfx_browser_settings_get_image_loading = (CfxApi.cfx_browser_settings_get_image_loading_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_image_loading", typeof(CfxApi.cfx_browser_settings_get_image_loading_delegate));
            CfxApi.cfx_browser_settings_set_image_shrink_standalone_to_fit = (CfxApi.cfx_browser_settings_set_image_shrink_standalone_to_fit_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_image_shrink_standalone_to_fit", typeof(CfxApi.cfx_browser_settings_set_image_shrink_standalone_to_fit_delegate));
            CfxApi.cfx_browser_settings_get_image_shrink_standalone_to_fit = (CfxApi.cfx_browser_settings_get_image_shrink_standalone_to_fit_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_image_shrink_standalone_to_fit", typeof(CfxApi.cfx_browser_settings_get_image_shrink_standalone_to_fit_delegate));
            CfxApi.cfx_browser_settings_set_text_area_resize = (CfxApi.cfx_browser_settings_set_text_area_resize_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_text_area_resize", typeof(CfxApi.cfx_browser_settings_set_text_area_resize_delegate));
            CfxApi.cfx_browser_settings_get_text_area_resize = (CfxApi.cfx_browser_settings_get_text_area_resize_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_text_area_resize", typeof(CfxApi.cfx_browser_settings_get_text_area_resize_delegate));
            CfxApi.cfx_browser_settings_set_tab_to_links = (CfxApi.cfx_browser_settings_set_tab_to_links_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_tab_to_links", typeof(CfxApi.cfx_browser_settings_set_tab_to_links_delegate));
            CfxApi.cfx_browser_settings_get_tab_to_links = (CfxApi.cfx_browser_settings_get_tab_to_links_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_tab_to_links", typeof(CfxApi.cfx_browser_settings_get_tab_to_links_delegate));
            CfxApi.cfx_browser_settings_set_local_storage = (CfxApi.cfx_browser_settings_set_local_storage_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_local_storage", typeof(CfxApi.cfx_browser_settings_set_local_storage_delegate));
            CfxApi.cfx_browser_settings_get_local_storage = (CfxApi.cfx_browser_settings_get_local_storage_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_local_storage", typeof(CfxApi.cfx_browser_settings_get_local_storage_delegate));
            CfxApi.cfx_browser_settings_set_databases = (CfxApi.cfx_browser_settings_set_databases_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_databases", typeof(CfxApi.cfx_browser_settings_set_databases_delegate));
            CfxApi.cfx_browser_settings_get_databases = (CfxApi.cfx_browser_settings_get_databases_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_databases", typeof(CfxApi.cfx_browser_settings_get_databases_delegate));
            CfxApi.cfx_browser_settings_set_application_cache = (CfxApi.cfx_browser_settings_set_application_cache_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_application_cache", typeof(CfxApi.cfx_browser_settings_set_application_cache_delegate));
            CfxApi.cfx_browser_settings_get_application_cache = (CfxApi.cfx_browser_settings_get_application_cache_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_application_cache", typeof(CfxApi.cfx_browser_settings_get_application_cache_delegate));
            CfxApi.cfx_browser_settings_set_webgl = (CfxApi.cfx_browser_settings_set_webgl_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_webgl", typeof(CfxApi.cfx_browser_settings_set_webgl_delegate));
            CfxApi.cfx_browser_settings_get_webgl = (CfxApi.cfx_browser_settings_get_webgl_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_webgl", typeof(CfxApi.cfx_browser_settings_get_webgl_delegate));
            CfxApi.cfx_browser_settings_set_background_color = (CfxApi.cfx_browser_settings_set_background_color_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_set_background_color", typeof(CfxApi.cfx_browser_settings_set_background_color_delegate));
            CfxApi.cfx_browser_settings_get_background_color = (CfxApi.cfx_browser_settings_get_background_color_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_settings_get_background_color", typeof(CfxApi.cfx_browser_settings_get_background_color_delegate));



            // cef_callback



            // cef_client

            cfx_client_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_client_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_client_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_client_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_client_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_command_line



            // cef_completion_callback

            cfx_completion_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_completion_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_completion_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_completion_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_completion_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_completion_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_context_menu_handler

            cfx_context_menu_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_context_menu_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_context_menu_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_context_menu_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_context_menu_params



            // cef_cookie

            CfxApi.cfx_cookie_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_cookie_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_cookie_set_name = (CfxApi.cfx_cookie_set_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_name", typeof(CfxApi.cfx_cookie_set_name_delegate));
            CfxApi.cfx_cookie_get_name = (CfxApi.cfx_cookie_get_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_name", typeof(CfxApi.cfx_cookie_get_name_delegate));
            CfxApi.cfx_cookie_set_value = (CfxApi.cfx_cookie_set_value_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_value", typeof(CfxApi.cfx_cookie_set_value_delegate));
            CfxApi.cfx_cookie_get_value = (CfxApi.cfx_cookie_get_value_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_value", typeof(CfxApi.cfx_cookie_get_value_delegate));
            CfxApi.cfx_cookie_set_domain = (CfxApi.cfx_cookie_set_domain_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_domain", typeof(CfxApi.cfx_cookie_set_domain_delegate));
            CfxApi.cfx_cookie_get_domain = (CfxApi.cfx_cookie_get_domain_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_domain", typeof(CfxApi.cfx_cookie_get_domain_delegate));
            CfxApi.cfx_cookie_set_path = (CfxApi.cfx_cookie_set_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_path", typeof(CfxApi.cfx_cookie_set_path_delegate));
            CfxApi.cfx_cookie_get_path = (CfxApi.cfx_cookie_get_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_path", typeof(CfxApi.cfx_cookie_get_path_delegate));
            CfxApi.cfx_cookie_set_secure = (CfxApi.cfx_cookie_set_secure_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_secure", typeof(CfxApi.cfx_cookie_set_secure_delegate));
            CfxApi.cfx_cookie_get_secure = (CfxApi.cfx_cookie_get_secure_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_secure", typeof(CfxApi.cfx_cookie_get_secure_delegate));
            CfxApi.cfx_cookie_set_httponly = (CfxApi.cfx_cookie_set_httponly_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_httponly", typeof(CfxApi.cfx_cookie_set_httponly_delegate));
            CfxApi.cfx_cookie_get_httponly = (CfxApi.cfx_cookie_get_httponly_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_httponly", typeof(CfxApi.cfx_cookie_get_httponly_delegate));
            CfxApi.cfx_cookie_set_creation = (CfxApi.cfx_cookie_set_creation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_creation", typeof(CfxApi.cfx_cookie_set_creation_delegate));
            CfxApi.cfx_cookie_get_creation = (CfxApi.cfx_cookie_get_creation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_creation", typeof(CfxApi.cfx_cookie_get_creation_delegate));
            CfxApi.cfx_cookie_set_last_access = (CfxApi.cfx_cookie_set_last_access_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_last_access", typeof(CfxApi.cfx_cookie_set_last_access_delegate));
            CfxApi.cfx_cookie_get_last_access = (CfxApi.cfx_cookie_get_last_access_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_last_access", typeof(CfxApi.cfx_cookie_get_last_access_delegate));
            CfxApi.cfx_cookie_set_has_expires = (CfxApi.cfx_cookie_set_has_expires_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_has_expires", typeof(CfxApi.cfx_cookie_set_has_expires_delegate));
            CfxApi.cfx_cookie_get_has_expires = (CfxApi.cfx_cookie_get_has_expires_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_has_expires", typeof(CfxApi.cfx_cookie_get_has_expires_delegate));
            CfxApi.cfx_cookie_set_expires = (CfxApi.cfx_cookie_set_expires_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_set_expires", typeof(CfxApi.cfx_cookie_set_expires_delegate));
            CfxApi.cfx_cookie_get_expires = (CfxApi.cfx_cookie_get_expires_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cookie_get_expires", typeof(CfxApi.cfx_cookie_get_expires_delegate));



            // cef_cookie_manager



            // cef_cookie_visitor

            cfx_cookie_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_cookie_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_cookie_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_cookie_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_cursor_info

            CfxApi.cfx_cursor_info_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_cursor_info_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_cursor_info_set_hotspot = (CfxApi.cfx_cursor_info_set_hotspot_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_set_hotspot", typeof(CfxApi.cfx_cursor_info_set_hotspot_delegate));
            CfxApi.cfx_cursor_info_get_hotspot = (CfxApi.cfx_cursor_info_get_hotspot_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_get_hotspot", typeof(CfxApi.cfx_cursor_info_get_hotspot_delegate));
            CfxApi.cfx_cursor_info_set_image_scale_factor = (CfxApi.cfx_cursor_info_set_image_scale_factor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_set_image_scale_factor", typeof(CfxApi.cfx_cursor_info_set_image_scale_factor_delegate));
            CfxApi.cfx_cursor_info_get_image_scale_factor = (CfxApi.cfx_cursor_info_get_image_scale_factor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_get_image_scale_factor", typeof(CfxApi.cfx_cursor_info_get_image_scale_factor_delegate));
            CfxApi.cfx_cursor_info_set_buffer = (CfxApi.cfx_cursor_info_set_buffer_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_set_buffer", typeof(CfxApi.cfx_cursor_info_set_buffer_delegate));
            CfxApi.cfx_cursor_info_get_buffer = (CfxApi.cfx_cursor_info_get_buffer_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_cursor_info_get_buffer", typeof(CfxApi.cfx_cursor_info_get_buffer_delegate));



            // cef_dialog_handler

            cfx_dialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_dialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_dialog_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_dialog_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_dictionary_value



            // cef_display_handler

            cfx_display_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_display_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_display_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_display_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_domdocument



            // cef_domnode



            // cef_domvisitor

            cfx_domvisitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_domvisitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_domvisitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_domvisitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_download_handler

            cfx_download_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_download_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_download_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_download_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_download_item



            // cef_download_item_callback



            // cef_drag_data



            // cef_drag_handler

            cfx_drag_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_drag_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_drag_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_drag_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_end_tracing_callback

            cfx_end_tracing_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_end_tracing_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_end_tracing_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_end_tracing_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_file_dialog_callback



            // cef_focus_handler

            cfx_focus_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_focus_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_focus_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_focus_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_frame



            // cef_geolocation_callback



            // cef_geolocation_handler

            cfx_geolocation_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_geolocation_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_geolocation_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_geolocation_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_geoposition

            CfxApi.cfx_geoposition_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_geoposition_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_geoposition_set_latitude = (CfxApi.cfx_geoposition_set_latitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_latitude", typeof(CfxApi.cfx_geoposition_set_latitude_delegate));
            CfxApi.cfx_geoposition_get_latitude = (CfxApi.cfx_geoposition_get_latitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_latitude", typeof(CfxApi.cfx_geoposition_get_latitude_delegate));
            CfxApi.cfx_geoposition_set_longitude = (CfxApi.cfx_geoposition_set_longitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_longitude", typeof(CfxApi.cfx_geoposition_set_longitude_delegate));
            CfxApi.cfx_geoposition_get_longitude = (CfxApi.cfx_geoposition_get_longitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_longitude", typeof(CfxApi.cfx_geoposition_get_longitude_delegate));
            CfxApi.cfx_geoposition_set_altitude = (CfxApi.cfx_geoposition_set_altitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_altitude", typeof(CfxApi.cfx_geoposition_set_altitude_delegate));
            CfxApi.cfx_geoposition_get_altitude = (CfxApi.cfx_geoposition_get_altitude_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_altitude", typeof(CfxApi.cfx_geoposition_get_altitude_delegate));
            CfxApi.cfx_geoposition_set_accuracy = (CfxApi.cfx_geoposition_set_accuracy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_accuracy", typeof(CfxApi.cfx_geoposition_set_accuracy_delegate));
            CfxApi.cfx_geoposition_get_accuracy = (CfxApi.cfx_geoposition_get_accuracy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_accuracy", typeof(CfxApi.cfx_geoposition_get_accuracy_delegate));
            CfxApi.cfx_geoposition_set_altitude_accuracy = (CfxApi.cfx_geoposition_set_altitude_accuracy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_altitude_accuracy", typeof(CfxApi.cfx_geoposition_set_altitude_accuracy_delegate));
            CfxApi.cfx_geoposition_get_altitude_accuracy = (CfxApi.cfx_geoposition_get_altitude_accuracy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_altitude_accuracy", typeof(CfxApi.cfx_geoposition_get_altitude_accuracy_delegate));
            CfxApi.cfx_geoposition_set_heading = (CfxApi.cfx_geoposition_set_heading_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_heading", typeof(CfxApi.cfx_geoposition_set_heading_delegate));
            CfxApi.cfx_geoposition_get_heading = (CfxApi.cfx_geoposition_get_heading_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_heading", typeof(CfxApi.cfx_geoposition_get_heading_delegate));
            CfxApi.cfx_geoposition_set_speed = (CfxApi.cfx_geoposition_set_speed_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_speed", typeof(CfxApi.cfx_geoposition_set_speed_delegate));
            CfxApi.cfx_geoposition_get_speed = (CfxApi.cfx_geoposition_get_speed_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_speed", typeof(CfxApi.cfx_geoposition_get_speed_delegate));
            CfxApi.cfx_geoposition_set_timestamp = (CfxApi.cfx_geoposition_set_timestamp_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_timestamp", typeof(CfxApi.cfx_geoposition_set_timestamp_delegate));
            CfxApi.cfx_geoposition_get_timestamp = (CfxApi.cfx_geoposition_get_timestamp_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_timestamp", typeof(CfxApi.cfx_geoposition_get_timestamp_delegate));
            CfxApi.cfx_geoposition_set_error_code = (CfxApi.cfx_geoposition_set_error_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_error_code", typeof(CfxApi.cfx_geoposition_set_error_code_delegate));
            CfxApi.cfx_geoposition_get_error_code = (CfxApi.cfx_geoposition_get_error_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_error_code", typeof(CfxApi.cfx_geoposition_get_error_code_delegate));
            CfxApi.cfx_geoposition_set_error_message = (CfxApi.cfx_geoposition_set_error_message_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_set_error_message", typeof(CfxApi.cfx_geoposition_set_error_message_delegate));
            CfxApi.cfx_geoposition_get_error_message = (CfxApi.cfx_geoposition_get_error_message_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_geoposition_get_error_message", typeof(CfxApi.cfx_geoposition_get_error_message_delegate));



            // cef_get_geolocation_callback

            cfx_get_geolocation_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_get_geolocation_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_get_geolocation_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_get_geolocation_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_jsdialog_callback



            // cef_jsdialog_handler

            cfx_jsdialog_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_jsdialog_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_jsdialog_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_jsdialog_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_key_event

            CfxApi.cfx_key_event_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_key_event_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_key_event_set_type = (CfxApi.cfx_key_event_set_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_type", typeof(CfxApi.cfx_key_event_set_type_delegate));
            CfxApi.cfx_key_event_get_type = (CfxApi.cfx_key_event_get_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_type", typeof(CfxApi.cfx_key_event_get_type_delegate));
            CfxApi.cfx_key_event_set_modifiers = (CfxApi.cfx_key_event_set_modifiers_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_modifiers", typeof(CfxApi.cfx_key_event_set_modifiers_delegate));
            CfxApi.cfx_key_event_get_modifiers = (CfxApi.cfx_key_event_get_modifiers_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_modifiers", typeof(CfxApi.cfx_key_event_get_modifiers_delegate));
            CfxApi.cfx_key_event_set_windows_key_code = (CfxApi.cfx_key_event_set_windows_key_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_windows_key_code", typeof(CfxApi.cfx_key_event_set_windows_key_code_delegate));
            CfxApi.cfx_key_event_get_windows_key_code = (CfxApi.cfx_key_event_get_windows_key_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_windows_key_code", typeof(CfxApi.cfx_key_event_get_windows_key_code_delegate));
            CfxApi.cfx_key_event_set_native_key_code = (CfxApi.cfx_key_event_set_native_key_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_native_key_code", typeof(CfxApi.cfx_key_event_set_native_key_code_delegate));
            CfxApi.cfx_key_event_get_native_key_code = (CfxApi.cfx_key_event_get_native_key_code_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_native_key_code", typeof(CfxApi.cfx_key_event_get_native_key_code_delegate));
            CfxApi.cfx_key_event_set_is_system_key = (CfxApi.cfx_key_event_set_is_system_key_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_is_system_key", typeof(CfxApi.cfx_key_event_set_is_system_key_delegate));
            CfxApi.cfx_key_event_get_is_system_key = (CfxApi.cfx_key_event_get_is_system_key_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_is_system_key", typeof(CfxApi.cfx_key_event_get_is_system_key_delegate));
            CfxApi.cfx_key_event_set_character = (CfxApi.cfx_key_event_set_character_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_character", typeof(CfxApi.cfx_key_event_set_character_delegate));
            CfxApi.cfx_key_event_get_character = (CfxApi.cfx_key_event_get_character_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_character", typeof(CfxApi.cfx_key_event_get_character_delegate));
            CfxApi.cfx_key_event_set_unmodified_character = (CfxApi.cfx_key_event_set_unmodified_character_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_unmodified_character", typeof(CfxApi.cfx_key_event_set_unmodified_character_delegate));
            CfxApi.cfx_key_event_get_unmodified_character = (CfxApi.cfx_key_event_get_unmodified_character_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_unmodified_character", typeof(CfxApi.cfx_key_event_get_unmodified_character_delegate));
            CfxApi.cfx_key_event_set_focus_on_editable_field = (CfxApi.cfx_key_event_set_focus_on_editable_field_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_set_focus_on_editable_field", typeof(CfxApi.cfx_key_event_set_focus_on_editable_field_delegate));
            CfxApi.cfx_key_event_get_focus_on_editable_field = (CfxApi.cfx_key_event_get_focus_on_editable_field_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_key_event_get_focus_on_editable_field", typeof(CfxApi.cfx_key_event_get_focus_on_editable_field_delegate));



            // cef_keyboard_handler

            cfx_keyboard_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_keyboard_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_keyboard_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_keyboard_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_life_span_handler

            cfx_life_span_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_life_span_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_life_span_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_life_span_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_list_value



            // cef_load_handler

            cfx_load_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_load_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_load_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_load_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_menu_model



            // cef_mouse_event

            CfxApi.cfx_mouse_event_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_mouse_event_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_mouse_event_set_x = (CfxApi.cfx_mouse_event_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_set_x", typeof(CfxApi.cfx_mouse_event_set_x_delegate));
            CfxApi.cfx_mouse_event_get_x = (CfxApi.cfx_mouse_event_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_get_x", typeof(CfxApi.cfx_mouse_event_get_x_delegate));
            CfxApi.cfx_mouse_event_set_y = (CfxApi.cfx_mouse_event_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_set_y", typeof(CfxApi.cfx_mouse_event_set_y_delegate));
            CfxApi.cfx_mouse_event_get_y = (CfxApi.cfx_mouse_event_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_get_y", typeof(CfxApi.cfx_mouse_event_get_y_delegate));
            CfxApi.cfx_mouse_event_set_modifiers = (CfxApi.cfx_mouse_event_set_modifiers_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_set_modifiers", typeof(CfxApi.cfx_mouse_event_set_modifiers_delegate));
            CfxApi.cfx_mouse_event_get_modifiers = (CfxApi.cfx_mouse_event_get_modifiers_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_mouse_event_get_modifiers", typeof(CfxApi.cfx_mouse_event_get_modifiers_delegate));



            // cef_navigation_entry



            // cef_navigation_entry_visitor

            cfx_navigation_entry_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_navigation_entry_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_navigation_entry_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_navigation_entry_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_page_range

            CfxApi.cfx_page_range_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_page_range_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_page_range_set_from = (CfxApi.cfx_page_range_set_from_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_set_from", typeof(CfxApi.cfx_page_range_set_from_delegate));
            CfxApi.cfx_page_range_get_from = (CfxApi.cfx_page_range_get_from_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_get_from", typeof(CfxApi.cfx_page_range_get_from_delegate));
            CfxApi.cfx_page_range_set_to = (CfxApi.cfx_page_range_set_to_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_set_to", typeof(CfxApi.cfx_page_range_set_to_delegate));
            CfxApi.cfx_page_range_get_to = (CfxApi.cfx_page_range_get_to_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_page_range_get_to", typeof(CfxApi.cfx_page_range_get_to_delegate));



            // cef_point

            CfxApi.cfx_point_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_point_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_point_set_x = (CfxApi.cfx_point_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_set_x", typeof(CfxApi.cfx_point_set_x_delegate));
            CfxApi.cfx_point_get_x = (CfxApi.cfx_point_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_get_x", typeof(CfxApi.cfx_point_get_x_delegate));
            CfxApi.cfx_point_set_y = (CfxApi.cfx_point_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_set_y", typeof(CfxApi.cfx_point_set_y_delegate));
            CfxApi.cfx_point_get_y = (CfxApi.cfx_point_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_point_get_y", typeof(CfxApi.cfx_point_get_y_delegate));



            // cef_popup_features

            CfxApi.cfx_popup_features_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_popup_features_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_popup_features_set_x = (CfxApi.cfx_popup_features_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_x", typeof(CfxApi.cfx_popup_features_set_x_delegate));
            CfxApi.cfx_popup_features_get_x = (CfxApi.cfx_popup_features_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_x", typeof(CfxApi.cfx_popup_features_get_x_delegate));
            CfxApi.cfx_popup_features_set_xSet = (CfxApi.cfx_popup_features_set_xSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_xSet", typeof(CfxApi.cfx_popup_features_set_xSet_delegate));
            CfxApi.cfx_popup_features_get_xSet = (CfxApi.cfx_popup_features_get_xSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_xSet", typeof(CfxApi.cfx_popup_features_get_xSet_delegate));
            CfxApi.cfx_popup_features_set_y = (CfxApi.cfx_popup_features_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_y", typeof(CfxApi.cfx_popup_features_set_y_delegate));
            CfxApi.cfx_popup_features_get_y = (CfxApi.cfx_popup_features_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_y", typeof(CfxApi.cfx_popup_features_get_y_delegate));
            CfxApi.cfx_popup_features_set_ySet = (CfxApi.cfx_popup_features_set_ySet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_ySet", typeof(CfxApi.cfx_popup_features_set_ySet_delegate));
            CfxApi.cfx_popup_features_get_ySet = (CfxApi.cfx_popup_features_get_ySet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_ySet", typeof(CfxApi.cfx_popup_features_get_ySet_delegate));
            CfxApi.cfx_popup_features_set_width = (CfxApi.cfx_popup_features_set_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_width", typeof(CfxApi.cfx_popup_features_set_width_delegate));
            CfxApi.cfx_popup_features_get_width = (CfxApi.cfx_popup_features_get_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_width", typeof(CfxApi.cfx_popup_features_get_width_delegate));
            CfxApi.cfx_popup_features_set_widthSet = (CfxApi.cfx_popup_features_set_widthSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_widthSet", typeof(CfxApi.cfx_popup_features_set_widthSet_delegate));
            CfxApi.cfx_popup_features_get_widthSet = (CfxApi.cfx_popup_features_get_widthSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_widthSet", typeof(CfxApi.cfx_popup_features_get_widthSet_delegate));
            CfxApi.cfx_popup_features_set_height = (CfxApi.cfx_popup_features_set_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_height", typeof(CfxApi.cfx_popup_features_set_height_delegate));
            CfxApi.cfx_popup_features_get_height = (CfxApi.cfx_popup_features_get_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_height", typeof(CfxApi.cfx_popup_features_get_height_delegate));
            CfxApi.cfx_popup_features_set_heightSet = (CfxApi.cfx_popup_features_set_heightSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_heightSet", typeof(CfxApi.cfx_popup_features_set_heightSet_delegate));
            CfxApi.cfx_popup_features_get_heightSet = (CfxApi.cfx_popup_features_get_heightSet_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_heightSet", typeof(CfxApi.cfx_popup_features_get_heightSet_delegate));
            CfxApi.cfx_popup_features_set_menuBarVisible = (CfxApi.cfx_popup_features_set_menuBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_menuBarVisible", typeof(CfxApi.cfx_popup_features_set_menuBarVisible_delegate));
            CfxApi.cfx_popup_features_get_menuBarVisible = (CfxApi.cfx_popup_features_get_menuBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_menuBarVisible", typeof(CfxApi.cfx_popup_features_get_menuBarVisible_delegate));
            CfxApi.cfx_popup_features_set_statusBarVisible = (CfxApi.cfx_popup_features_set_statusBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_statusBarVisible", typeof(CfxApi.cfx_popup_features_set_statusBarVisible_delegate));
            CfxApi.cfx_popup_features_get_statusBarVisible = (CfxApi.cfx_popup_features_get_statusBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_statusBarVisible", typeof(CfxApi.cfx_popup_features_get_statusBarVisible_delegate));
            CfxApi.cfx_popup_features_set_toolBarVisible = (CfxApi.cfx_popup_features_set_toolBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_toolBarVisible", typeof(CfxApi.cfx_popup_features_set_toolBarVisible_delegate));
            CfxApi.cfx_popup_features_get_toolBarVisible = (CfxApi.cfx_popup_features_get_toolBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_toolBarVisible", typeof(CfxApi.cfx_popup_features_get_toolBarVisible_delegate));
            CfxApi.cfx_popup_features_set_locationBarVisible = (CfxApi.cfx_popup_features_set_locationBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_locationBarVisible", typeof(CfxApi.cfx_popup_features_set_locationBarVisible_delegate));
            CfxApi.cfx_popup_features_get_locationBarVisible = (CfxApi.cfx_popup_features_get_locationBarVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_locationBarVisible", typeof(CfxApi.cfx_popup_features_get_locationBarVisible_delegate));
            CfxApi.cfx_popup_features_set_scrollbarsVisible = (CfxApi.cfx_popup_features_set_scrollbarsVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_scrollbarsVisible", typeof(CfxApi.cfx_popup_features_set_scrollbarsVisible_delegate));
            CfxApi.cfx_popup_features_get_scrollbarsVisible = (CfxApi.cfx_popup_features_get_scrollbarsVisible_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_scrollbarsVisible", typeof(CfxApi.cfx_popup_features_get_scrollbarsVisible_delegate));
            CfxApi.cfx_popup_features_set_resizable = (CfxApi.cfx_popup_features_set_resizable_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_resizable", typeof(CfxApi.cfx_popup_features_set_resizable_delegate));
            CfxApi.cfx_popup_features_get_resizable = (CfxApi.cfx_popup_features_get_resizable_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_resizable", typeof(CfxApi.cfx_popup_features_get_resizable_delegate));
            CfxApi.cfx_popup_features_set_fullscreen = (CfxApi.cfx_popup_features_set_fullscreen_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_fullscreen", typeof(CfxApi.cfx_popup_features_set_fullscreen_delegate));
            CfxApi.cfx_popup_features_get_fullscreen = (CfxApi.cfx_popup_features_get_fullscreen_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_fullscreen", typeof(CfxApi.cfx_popup_features_get_fullscreen_delegate));
            CfxApi.cfx_popup_features_set_dialog = (CfxApi.cfx_popup_features_set_dialog_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_dialog", typeof(CfxApi.cfx_popup_features_set_dialog_delegate));
            CfxApi.cfx_popup_features_get_dialog = (CfxApi.cfx_popup_features_get_dialog_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_dialog", typeof(CfxApi.cfx_popup_features_get_dialog_delegate));
            CfxApi.cfx_popup_features_set_additionalFeatures = (CfxApi.cfx_popup_features_set_additionalFeatures_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_set_additionalFeatures", typeof(CfxApi.cfx_popup_features_set_additionalFeatures_delegate));
            CfxApi.cfx_popup_features_get_additionalFeatures = (CfxApi.cfx_popup_features_get_additionalFeatures_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_popup_features_get_additionalFeatures", typeof(CfxApi.cfx_popup_features_get_additionalFeatures_delegate));



            // cef_post_data



            // cef_post_data_element



            // cef_print_dialog_callback



            // cef_print_handler

            cfx_print_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_print_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_print_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_print_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_print_job_callback



            // cef_print_settings



            // cef_process_message



            // cef_quota_callback



            // cef_read_handler

            cfx_read_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_read_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_read_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_read_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_rect

            CfxApi.cfx_rect_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_rect_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_rect_set_x = (CfxApi.cfx_rect_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_set_x", typeof(CfxApi.cfx_rect_set_x_delegate));
            CfxApi.cfx_rect_get_x = (CfxApi.cfx_rect_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_get_x", typeof(CfxApi.cfx_rect_get_x_delegate));
            CfxApi.cfx_rect_set_y = (CfxApi.cfx_rect_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_set_y", typeof(CfxApi.cfx_rect_set_y_delegate));
            CfxApi.cfx_rect_get_y = (CfxApi.cfx_rect_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_get_y", typeof(CfxApi.cfx_rect_get_y_delegate));
            CfxApi.cfx_rect_set_width = (CfxApi.cfx_rect_set_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_set_width", typeof(CfxApi.cfx_rect_set_width_delegate));
            CfxApi.cfx_rect_get_width = (CfxApi.cfx_rect_get_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_get_width", typeof(CfxApi.cfx_rect_get_width_delegate));
            CfxApi.cfx_rect_set_height = (CfxApi.cfx_rect_set_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_set_height", typeof(CfxApi.cfx_rect_set_height_delegate));
            CfxApi.cfx_rect_get_height = (CfxApi.cfx_rect_get_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_rect_get_height", typeof(CfxApi.cfx_rect_get_height_delegate));



            // cef_render_handler

            cfx_render_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_render_process_handler

            cfx_render_process_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_render_process_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_render_process_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_render_process_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_request



            // cef_request_context



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



            // cef_run_file_dialog_callback

            cfx_run_file_dialog_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_run_file_dialog_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_run_file_dialog_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_run_file_dialog_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_run_file_dialog_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_run_file_dialog_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_scheme_handler_factory

            cfx_scheme_handler_factory_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_scheme_handler_factory_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_scheme_handler_factory_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_scheme_handler_factory_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_scheme_handler_factory_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_scheme_handler_factory_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_scheme_registrar



            // cef_screen_info

            CfxApi.cfx_screen_info_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_screen_info_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_screen_info_set_device_scale_factor = (CfxApi.cfx_screen_info_set_device_scale_factor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_device_scale_factor", typeof(CfxApi.cfx_screen_info_set_device_scale_factor_delegate));
            CfxApi.cfx_screen_info_get_device_scale_factor = (CfxApi.cfx_screen_info_get_device_scale_factor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_device_scale_factor", typeof(CfxApi.cfx_screen_info_get_device_scale_factor_delegate));
            CfxApi.cfx_screen_info_set_depth = (CfxApi.cfx_screen_info_set_depth_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_depth", typeof(CfxApi.cfx_screen_info_set_depth_delegate));
            CfxApi.cfx_screen_info_get_depth = (CfxApi.cfx_screen_info_get_depth_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_depth", typeof(CfxApi.cfx_screen_info_get_depth_delegate));
            CfxApi.cfx_screen_info_set_depth_per_component = (CfxApi.cfx_screen_info_set_depth_per_component_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_depth_per_component", typeof(CfxApi.cfx_screen_info_set_depth_per_component_delegate));
            CfxApi.cfx_screen_info_get_depth_per_component = (CfxApi.cfx_screen_info_get_depth_per_component_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_depth_per_component", typeof(CfxApi.cfx_screen_info_get_depth_per_component_delegate));
            CfxApi.cfx_screen_info_set_is_monochrome = (CfxApi.cfx_screen_info_set_is_monochrome_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_is_monochrome", typeof(CfxApi.cfx_screen_info_set_is_monochrome_delegate));
            CfxApi.cfx_screen_info_get_is_monochrome = (CfxApi.cfx_screen_info_get_is_monochrome_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_is_monochrome", typeof(CfxApi.cfx_screen_info_get_is_monochrome_delegate));
            CfxApi.cfx_screen_info_set_rect = (CfxApi.cfx_screen_info_set_rect_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_rect", typeof(CfxApi.cfx_screen_info_set_rect_delegate));
            CfxApi.cfx_screen_info_get_rect = (CfxApi.cfx_screen_info_get_rect_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_rect", typeof(CfxApi.cfx_screen_info_get_rect_delegate));
            CfxApi.cfx_screen_info_set_available_rect = (CfxApi.cfx_screen_info_set_available_rect_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_set_available_rect", typeof(CfxApi.cfx_screen_info_set_available_rect_delegate));
            CfxApi.cfx_screen_info_get_available_rect = (CfxApi.cfx_screen_info_get_available_rect_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_screen_info_get_available_rect", typeof(CfxApi.cfx_screen_info_get_available_rect_delegate));



            // cef_settings

            CfxApi.cfx_settings_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_settings_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_settings_set_single_process = (CfxApi.cfx_settings_set_single_process_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_single_process", typeof(CfxApi.cfx_settings_set_single_process_delegate));
            CfxApi.cfx_settings_get_single_process = (CfxApi.cfx_settings_get_single_process_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_single_process", typeof(CfxApi.cfx_settings_get_single_process_delegate));
            CfxApi.cfx_settings_set_no_sandbox = (CfxApi.cfx_settings_set_no_sandbox_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_no_sandbox", typeof(CfxApi.cfx_settings_set_no_sandbox_delegate));
            CfxApi.cfx_settings_get_no_sandbox = (CfxApi.cfx_settings_get_no_sandbox_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_no_sandbox", typeof(CfxApi.cfx_settings_get_no_sandbox_delegate));
            CfxApi.cfx_settings_set_browser_subprocess_path = (CfxApi.cfx_settings_set_browser_subprocess_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_browser_subprocess_path", typeof(CfxApi.cfx_settings_set_browser_subprocess_path_delegate));
            CfxApi.cfx_settings_get_browser_subprocess_path = (CfxApi.cfx_settings_get_browser_subprocess_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_browser_subprocess_path", typeof(CfxApi.cfx_settings_get_browser_subprocess_path_delegate));
            CfxApi.cfx_settings_set_multi_threaded_message_loop = (CfxApi.cfx_settings_set_multi_threaded_message_loop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_multi_threaded_message_loop", typeof(CfxApi.cfx_settings_set_multi_threaded_message_loop_delegate));
            CfxApi.cfx_settings_get_multi_threaded_message_loop = (CfxApi.cfx_settings_get_multi_threaded_message_loop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_multi_threaded_message_loop", typeof(CfxApi.cfx_settings_get_multi_threaded_message_loop_delegate));
            CfxApi.cfx_settings_set_windowless_rendering_enabled = (CfxApi.cfx_settings_set_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_windowless_rendering_enabled", typeof(CfxApi.cfx_settings_set_windowless_rendering_enabled_delegate));
            CfxApi.cfx_settings_get_windowless_rendering_enabled = (CfxApi.cfx_settings_get_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_windowless_rendering_enabled", typeof(CfxApi.cfx_settings_get_windowless_rendering_enabled_delegate));
            CfxApi.cfx_settings_set_command_line_args_disabled = (CfxApi.cfx_settings_set_command_line_args_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_command_line_args_disabled", typeof(CfxApi.cfx_settings_set_command_line_args_disabled_delegate));
            CfxApi.cfx_settings_get_command_line_args_disabled = (CfxApi.cfx_settings_get_command_line_args_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_command_line_args_disabled", typeof(CfxApi.cfx_settings_get_command_line_args_disabled_delegate));
            CfxApi.cfx_settings_set_cache_path = (CfxApi.cfx_settings_set_cache_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_cache_path", typeof(CfxApi.cfx_settings_set_cache_path_delegate));
            CfxApi.cfx_settings_get_cache_path = (CfxApi.cfx_settings_get_cache_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_cache_path", typeof(CfxApi.cfx_settings_get_cache_path_delegate));
            CfxApi.cfx_settings_set_persist_session_cookies = (CfxApi.cfx_settings_set_persist_session_cookies_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_persist_session_cookies", typeof(CfxApi.cfx_settings_set_persist_session_cookies_delegate));
            CfxApi.cfx_settings_get_persist_session_cookies = (CfxApi.cfx_settings_get_persist_session_cookies_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_persist_session_cookies", typeof(CfxApi.cfx_settings_get_persist_session_cookies_delegate));
            CfxApi.cfx_settings_set_user_agent = (CfxApi.cfx_settings_set_user_agent_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_user_agent", typeof(CfxApi.cfx_settings_set_user_agent_delegate));
            CfxApi.cfx_settings_get_user_agent = (CfxApi.cfx_settings_get_user_agent_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_user_agent", typeof(CfxApi.cfx_settings_get_user_agent_delegate));
            CfxApi.cfx_settings_set_product_version = (CfxApi.cfx_settings_set_product_version_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_product_version", typeof(CfxApi.cfx_settings_set_product_version_delegate));
            CfxApi.cfx_settings_get_product_version = (CfxApi.cfx_settings_get_product_version_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_product_version", typeof(CfxApi.cfx_settings_get_product_version_delegate));
            CfxApi.cfx_settings_set_locale = (CfxApi.cfx_settings_set_locale_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_locale", typeof(CfxApi.cfx_settings_set_locale_delegate));
            CfxApi.cfx_settings_get_locale = (CfxApi.cfx_settings_get_locale_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_locale", typeof(CfxApi.cfx_settings_get_locale_delegate));
            CfxApi.cfx_settings_set_log_file = (CfxApi.cfx_settings_set_log_file_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_log_file", typeof(CfxApi.cfx_settings_set_log_file_delegate));
            CfxApi.cfx_settings_get_log_file = (CfxApi.cfx_settings_get_log_file_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_log_file", typeof(CfxApi.cfx_settings_get_log_file_delegate));
            CfxApi.cfx_settings_set_log_severity = (CfxApi.cfx_settings_set_log_severity_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_log_severity", typeof(CfxApi.cfx_settings_set_log_severity_delegate));
            CfxApi.cfx_settings_get_log_severity = (CfxApi.cfx_settings_get_log_severity_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_log_severity", typeof(CfxApi.cfx_settings_get_log_severity_delegate));
            CfxApi.cfx_settings_set_javascript_flags = (CfxApi.cfx_settings_set_javascript_flags_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_javascript_flags", typeof(CfxApi.cfx_settings_set_javascript_flags_delegate));
            CfxApi.cfx_settings_get_javascript_flags = (CfxApi.cfx_settings_get_javascript_flags_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_javascript_flags", typeof(CfxApi.cfx_settings_get_javascript_flags_delegate));
            CfxApi.cfx_settings_set_resources_dir_path = (CfxApi.cfx_settings_set_resources_dir_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_resources_dir_path", typeof(CfxApi.cfx_settings_set_resources_dir_path_delegate));
            CfxApi.cfx_settings_get_resources_dir_path = (CfxApi.cfx_settings_get_resources_dir_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_resources_dir_path", typeof(CfxApi.cfx_settings_get_resources_dir_path_delegate));
            CfxApi.cfx_settings_set_locales_dir_path = (CfxApi.cfx_settings_set_locales_dir_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_locales_dir_path", typeof(CfxApi.cfx_settings_set_locales_dir_path_delegate));
            CfxApi.cfx_settings_get_locales_dir_path = (CfxApi.cfx_settings_get_locales_dir_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_locales_dir_path", typeof(CfxApi.cfx_settings_get_locales_dir_path_delegate));
            CfxApi.cfx_settings_set_pack_loading_disabled = (CfxApi.cfx_settings_set_pack_loading_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_pack_loading_disabled", typeof(CfxApi.cfx_settings_set_pack_loading_disabled_delegate));
            CfxApi.cfx_settings_get_pack_loading_disabled = (CfxApi.cfx_settings_get_pack_loading_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_pack_loading_disabled", typeof(CfxApi.cfx_settings_get_pack_loading_disabled_delegate));
            CfxApi.cfx_settings_set_remote_debugging_port = (CfxApi.cfx_settings_set_remote_debugging_port_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_remote_debugging_port", typeof(CfxApi.cfx_settings_set_remote_debugging_port_delegate));
            CfxApi.cfx_settings_get_remote_debugging_port = (CfxApi.cfx_settings_get_remote_debugging_port_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_remote_debugging_port", typeof(CfxApi.cfx_settings_get_remote_debugging_port_delegate));
            CfxApi.cfx_settings_set_uncaught_exception_stack_size = (CfxApi.cfx_settings_set_uncaught_exception_stack_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_uncaught_exception_stack_size", typeof(CfxApi.cfx_settings_set_uncaught_exception_stack_size_delegate));
            CfxApi.cfx_settings_get_uncaught_exception_stack_size = (CfxApi.cfx_settings_get_uncaught_exception_stack_size_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_uncaught_exception_stack_size", typeof(CfxApi.cfx_settings_get_uncaught_exception_stack_size_delegate));
            CfxApi.cfx_settings_set_context_safety_implementation = (CfxApi.cfx_settings_set_context_safety_implementation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_context_safety_implementation", typeof(CfxApi.cfx_settings_set_context_safety_implementation_delegate));
            CfxApi.cfx_settings_get_context_safety_implementation = (CfxApi.cfx_settings_get_context_safety_implementation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_context_safety_implementation", typeof(CfxApi.cfx_settings_get_context_safety_implementation_delegate));
            CfxApi.cfx_settings_set_ignore_certificate_errors = (CfxApi.cfx_settings_set_ignore_certificate_errors_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_ignore_certificate_errors", typeof(CfxApi.cfx_settings_set_ignore_certificate_errors_delegate));
            CfxApi.cfx_settings_get_ignore_certificate_errors = (CfxApi.cfx_settings_get_ignore_certificate_errors_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_ignore_certificate_errors", typeof(CfxApi.cfx_settings_get_ignore_certificate_errors_delegate));
            CfxApi.cfx_settings_set_background_color = (CfxApi.cfx_settings_set_background_color_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_set_background_color", typeof(CfxApi.cfx_settings_set_background_color_delegate));
            CfxApi.cfx_settings_get_background_color = (CfxApi.cfx_settings_get_background_color_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_settings_get_background_color", typeof(CfxApi.cfx_settings_get_background_color_delegate));



            // cef_size

            CfxApi.cfx_size_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_size_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_size_set_width = (CfxApi.cfx_size_set_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_set_width", typeof(CfxApi.cfx_size_set_width_delegate));
            CfxApi.cfx_size_get_width = (CfxApi.cfx_size_get_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_get_width", typeof(CfxApi.cfx_size_get_width_delegate));
            CfxApi.cfx_size_set_height = (CfxApi.cfx_size_set_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_set_height", typeof(CfxApi.cfx_size_set_height_delegate));
            CfxApi.cfx_size_get_height = (CfxApi.cfx_size_get_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_size_get_height", typeof(CfxApi.cfx_size_get_height_delegate));



            // cef_stream_reader



            // cef_stream_writer



            // cef_string_visitor

            cfx_string_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_string_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_string_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_string_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_task

            cfx_task_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_task_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_task_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_task_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_task_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_task_runner



            // cef_time

            CfxApi.cfx_time_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_time_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_time_set_year = (CfxApi.cfx_time_set_year_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_year", typeof(CfxApi.cfx_time_set_year_delegate));
            CfxApi.cfx_time_get_year = (CfxApi.cfx_time_get_year_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_year", typeof(CfxApi.cfx_time_get_year_delegate));
            CfxApi.cfx_time_set_month = (CfxApi.cfx_time_set_month_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_month", typeof(CfxApi.cfx_time_set_month_delegate));
            CfxApi.cfx_time_get_month = (CfxApi.cfx_time_get_month_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_month", typeof(CfxApi.cfx_time_get_month_delegate));
            CfxApi.cfx_time_set_day_of_week = (CfxApi.cfx_time_set_day_of_week_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_day_of_week", typeof(CfxApi.cfx_time_set_day_of_week_delegate));
            CfxApi.cfx_time_get_day_of_week = (CfxApi.cfx_time_get_day_of_week_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_day_of_week", typeof(CfxApi.cfx_time_get_day_of_week_delegate));
            CfxApi.cfx_time_set_day_of_month = (CfxApi.cfx_time_set_day_of_month_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_day_of_month", typeof(CfxApi.cfx_time_set_day_of_month_delegate));
            CfxApi.cfx_time_get_day_of_month = (CfxApi.cfx_time_get_day_of_month_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_day_of_month", typeof(CfxApi.cfx_time_get_day_of_month_delegate));
            CfxApi.cfx_time_set_hour = (CfxApi.cfx_time_set_hour_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_hour", typeof(CfxApi.cfx_time_set_hour_delegate));
            CfxApi.cfx_time_get_hour = (CfxApi.cfx_time_get_hour_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_hour", typeof(CfxApi.cfx_time_get_hour_delegate));
            CfxApi.cfx_time_set_minute = (CfxApi.cfx_time_set_minute_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_minute", typeof(CfxApi.cfx_time_set_minute_delegate));
            CfxApi.cfx_time_get_minute = (CfxApi.cfx_time_get_minute_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_minute", typeof(CfxApi.cfx_time_get_minute_delegate));
            CfxApi.cfx_time_set_second = (CfxApi.cfx_time_set_second_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_second", typeof(CfxApi.cfx_time_set_second_delegate));
            CfxApi.cfx_time_get_second = (CfxApi.cfx_time_get_second_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_second", typeof(CfxApi.cfx_time_get_second_delegate));
            CfxApi.cfx_time_set_millisecond = (CfxApi.cfx_time_set_millisecond_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_set_millisecond", typeof(CfxApi.cfx_time_set_millisecond_delegate));
            CfxApi.cfx_time_get_millisecond = (CfxApi.cfx_time_get_millisecond_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_time_get_millisecond", typeof(CfxApi.cfx_time_get_millisecond_delegate));



            // cef_urlparts

            CfxApi.cfx_urlparts_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_urlparts_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_urlparts_set_spec = (CfxApi.cfx_urlparts_set_spec_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_spec", typeof(CfxApi.cfx_urlparts_set_spec_delegate));
            CfxApi.cfx_urlparts_get_spec = (CfxApi.cfx_urlparts_get_spec_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_spec", typeof(CfxApi.cfx_urlparts_get_spec_delegate));
            CfxApi.cfx_urlparts_set_scheme = (CfxApi.cfx_urlparts_set_scheme_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_scheme", typeof(CfxApi.cfx_urlparts_set_scheme_delegate));
            CfxApi.cfx_urlparts_get_scheme = (CfxApi.cfx_urlparts_get_scheme_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_scheme", typeof(CfxApi.cfx_urlparts_get_scheme_delegate));
            CfxApi.cfx_urlparts_set_username = (CfxApi.cfx_urlparts_set_username_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_username", typeof(CfxApi.cfx_urlparts_set_username_delegate));
            CfxApi.cfx_urlparts_get_username = (CfxApi.cfx_urlparts_get_username_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_username", typeof(CfxApi.cfx_urlparts_get_username_delegate));
            CfxApi.cfx_urlparts_set_password = (CfxApi.cfx_urlparts_set_password_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_password", typeof(CfxApi.cfx_urlparts_set_password_delegate));
            CfxApi.cfx_urlparts_get_password = (CfxApi.cfx_urlparts_get_password_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_password", typeof(CfxApi.cfx_urlparts_get_password_delegate));
            CfxApi.cfx_urlparts_set_host = (CfxApi.cfx_urlparts_set_host_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_host", typeof(CfxApi.cfx_urlparts_set_host_delegate));
            CfxApi.cfx_urlparts_get_host = (CfxApi.cfx_urlparts_get_host_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_host", typeof(CfxApi.cfx_urlparts_get_host_delegate));
            CfxApi.cfx_urlparts_set_port = (CfxApi.cfx_urlparts_set_port_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_port", typeof(CfxApi.cfx_urlparts_set_port_delegate));
            CfxApi.cfx_urlparts_get_port = (CfxApi.cfx_urlparts_get_port_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_port", typeof(CfxApi.cfx_urlparts_get_port_delegate));
            CfxApi.cfx_urlparts_set_origin = (CfxApi.cfx_urlparts_set_origin_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_origin", typeof(CfxApi.cfx_urlparts_set_origin_delegate));
            CfxApi.cfx_urlparts_get_origin = (CfxApi.cfx_urlparts_get_origin_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_origin", typeof(CfxApi.cfx_urlparts_get_origin_delegate));
            CfxApi.cfx_urlparts_set_path = (CfxApi.cfx_urlparts_set_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_path", typeof(CfxApi.cfx_urlparts_set_path_delegate));
            CfxApi.cfx_urlparts_get_path = (CfxApi.cfx_urlparts_get_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_path", typeof(CfxApi.cfx_urlparts_get_path_delegate));
            CfxApi.cfx_urlparts_set_query = (CfxApi.cfx_urlparts_set_query_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_set_query", typeof(CfxApi.cfx_urlparts_set_query_delegate));
            CfxApi.cfx_urlparts_get_query = (CfxApi.cfx_urlparts_get_query_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_urlparts_get_query", typeof(CfxApi.cfx_urlparts_get_query_delegate));



            // cef_urlrequest



            // cef_urlrequest_client

            cfx_urlrequest_client_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_urlrequest_client_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_urlrequest_client_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_urlrequest_client_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_v8accessor

            cfx_v8accessor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_v8accessor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_v8accessor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8accessor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_v8context



            // cef_v8exception



            // cef_v8handler

            cfx_v8handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_v8handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_v8handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_v8handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_v8stack_frame



            // cef_v8stack_trace



            // cef_v8value



            // cef_web_plugin_info



            // cef_web_plugin_info_visitor

            cfx_web_plugin_info_visitor_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_web_plugin_info_visitor_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_web_plugin_info_visitor_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_info_visitor_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_web_plugin_unstable_callback

            cfx_web_plugin_unstable_callback_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_unstable_callback_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_web_plugin_unstable_callback_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_unstable_callback_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_web_plugin_unstable_callback_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_web_plugin_unstable_callback_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_window_info

            CfxApi.cfx_window_info_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_window_info_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_dtor", typeof(CfxApi.cfx_dtor_delegate));

            CfxApi.cfx_window_info_set_ex_style = (CfxApi.cfx_window_info_set_ex_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_ex_style", typeof(CfxApi.cfx_window_info_set_ex_style_delegate));
            CfxApi.cfx_window_info_get_ex_style = (CfxApi.cfx_window_info_get_ex_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_ex_style", typeof(CfxApi.cfx_window_info_get_ex_style_delegate));
            CfxApi.cfx_window_info_set_window_name = (CfxApi.cfx_window_info_set_window_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_window_name", typeof(CfxApi.cfx_window_info_set_window_name_delegate));
            CfxApi.cfx_window_info_get_window_name = (CfxApi.cfx_window_info_get_window_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_window_name", typeof(CfxApi.cfx_window_info_get_window_name_delegate));
            CfxApi.cfx_window_info_set_style = (CfxApi.cfx_window_info_set_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_style", typeof(CfxApi.cfx_window_info_set_style_delegate));
            CfxApi.cfx_window_info_get_style = (CfxApi.cfx_window_info_get_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_style", typeof(CfxApi.cfx_window_info_get_style_delegate));
            CfxApi.cfx_window_info_set_x = (CfxApi.cfx_window_info_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_x", typeof(CfxApi.cfx_window_info_set_x_delegate));
            CfxApi.cfx_window_info_get_x = (CfxApi.cfx_window_info_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_x", typeof(CfxApi.cfx_window_info_get_x_delegate));
            CfxApi.cfx_window_info_set_y = (CfxApi.cfx_window_info_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_y", typeof(CfxApi.cfx_window_info_set_y_delegate));
            CfxApi.cfx_window_info_get_y = (CfxApi.cfx_window_info_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_y", typeof(CfxApi.cfx_window_info_get_y_delegate));
            CfxApi.cfx_window_info_set_width = (CfxApi.cfx_window_info_set_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_width", typeof(CfxApi.cfx_window_info_set_width_delegate));
            CfxApi.cfx_window_info_get_width = (CfxApi.cfx_window_info_get_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_width", typeof(CfxApi.cfx_window_info_get_width_delegate));
            CfxApi.cfx_window_info_set_height = (CfxApi.cfx_window_info_set_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_height", typeof(CfxApi.cfx_window_info_set_height_delegate));
            CfxApi.cfx_window_info_get_height = (CfxApi.cfx_window_info_get_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_height", typeof(CfxApi.cfx_window_info_get_height_delegate));
            CfxApi.cfx_window_info_set_parent_window = (CfxApi.cfx_window_info_set_parent_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_parent_window", typeof(CfxApi.cfx_window_info_set_parent_window_delegate));
            CfxApi.cfx_window_info_get_parent_window = (CfxApi.cfx_window_info_get_parent_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_parent_window", typeof(CfxApi.cfx_window_info_get_parent_window_delegate));
            CfxApi.cfx_window_info_set_menu = (CfxApi.cfx_window_info_set_menu_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_menu", typeof(CfxApi.cfx_window_info_set_menu_delegate));
            CfxApi.cfx_window_info_get_menu = (CfxApi.cfx_window_info_get_menu_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_menu", typeof(CfxApi.cfx_window_info_get_menu_delegate));
            CfxApi.cfx_window_info_set_windowless_rendering_enabled = (CfxApi.cfx_window_info_set_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_windowless_rendering_enabled", typeof(CfxApi.cfx_window_info_set_windowless_rendering_enabled_delegate));
            CfxApi.cfx_window_info_get_windowless_rendering_enabled = (CfxApi.cfx_window_info_get_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_windowless_rendering_enabled", typeof(CfxApi.cfx_window_info_get_windowless_rendering_enabled_delegate));
            CfxApi.cfx_window_info_set_transparent_painting_enabled = (CfxApi.cfx_window_info_set_transparent_painting_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_transparent_painting_enabled", typeof(CfxApi.cfx_window_info_set_transparent_painting_enabled_delegate));
            CfxApi.cfx_window_info_get_transparent_painting_enabled = (CfxApi.cfx_window_info_get_transparent_painting_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_transparent_painting_enabled", typeof(CfxApi.cfx_window_info_get_transparent_painting_enabled_delegate));
            CfxApi.cfx_window_info_set_window = (CfxApi.cfx_window_info_set_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_window", typeof(CfxApi.cfx_window_info_set_window_delegate));
            CfxApi.cfx_window_info_get_window = (CfxApi.cfx_window_info_get_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_window", typeof(CfxApi.cfx_window_info_get_window_delegate));



            // cef_write_handler

            cfx_write_handler_ctor = (cfx_ctor_with_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_ctor", typeof(cfx_ctor_with_gc_handle_delegate));
            cfx_write_handler_get_gc_handle = (cfx_get_gc_handle_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_get_gc_handle", typeof(cfx_get_gc_handle_delegate));
            cfx_write_handler_set_managed_callback = (cfx_set_callback_delegate)GetDelegate(libcfxPtr, "cfx_write_handler_set_managed_callback", typeof(cfx_set_callback_delegate));


            // cef_xml_reader



            // cef_zip_reader



        }
    }
}
