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
        // global cef export functions

        // CEF_EXPORT int cef_add_cross_origin_whitelist_entry(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_add_cross_origin_whitelist_entry_delegate(IntPtr source_origin_str, int source_origin_length, IntPtr target_protocol_str, int target_protocol_length, IntPtr target_domain_str, int target_domain_length, int allow_target_subdomains);
        public static cfx_add_cross_origin_whitelist_entry_delegate cfx_add_cross_origin_whitelist_entry;
        // CEF_EXPORT void cef_add_web_plugin_directory(const cef_string_t* dir);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_add_web_plugin_directory_delegate(IntPtr dir_str, int dir_length);
        public static cfx_add_web_plugin_directory_delegate cfx_add_web_plugin_directory;
        // CEF_EXPORT void cef_add_web_plugin_path(const cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_add_web_plugin_path_delegate(IntPtr path_str, int path_length);
        public static cfx_add_web_plugin_path_delegate cfx_add_web_plugin_path;
        // CEF_EXPORT int cef_begin_tracing(const cef_string_t* categories);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_begin_tracing_delegate(IntPtr categories_str, int categories_length);
        public static cfx_begin_tracing_delegate cfx_begin_tracing;
        // CEF_EXPORT int cef_clear_cross_origin_whitelist();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_clear_cross_origin_whitelist_delegate();
        public static cfx_clear_cross_origin_whitelist_delegate cfx_clear_cross_origin_whitelist;
        // CEF_EXPORT int cef_clear_scheme_handler_factories();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_clear_scheme_handler_factories_delegate();
        public static cfx_clear_scheme_handler_factories_delegate cfx_clear_scheme_handler_factories;
        // CEF_EXPORT int cef_create_url(const cef_urlparts_t* parts, cef_string_t* url);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_create_url_delegate(IntPtr parts, ref IntPtr url_str, ref int url_length);
        public static cfx_create_url_delegate cfx_create_url;
        // CEF_EXPORT int cef_currently_on(cef_thread_id_t threadId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_currently_on_delegate(CfxThreadId threadId);
        public static cfx_currently_on_delegate cfx_currently_on;
        // CEF_EXPORT void cef_do_message_loop_work();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_do_message_loop_work_delegate();
        public static cfx_do_message_loop_work_delegate cfx_do_message_loop_work;
        // CEF_EXPORT int cef_end_tracing_async(const cef_string_t* tracing_file, cef_end_tracing_callback_t* callback);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_end_tracing_async_delegate(IntPtr tracing_file_str, int tracing_file_length, IntPtr callback);
        public static cfx_end_tracing_async_delegate cfx_end_tracing_async;
        // CEF_EXPORT int cef_execute_process(cef_app_t* application, void* windows_sandbox_info);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_execute_process_delegate(IntPtr application, IntPtr windows_sandbox_info);
        public static cfx_execute_process_delegate cfx_execute_process;
        // CEF_EXPORT void cef_force_web_plugin_shutdown(const cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_force_web_plugin_shutdown_delegate(IntPtr path_str, int path_length);
        public static cfx_force_web_plugin_shutdown_delegate cfx_force_web_plugin_shutdown;
        // CEF_EXPORT int cef_get_geolocation(cef_get_geolocation_callback_t* callback);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_get_geolocation_delegate(IntPtr callback);
        public static cfx_get_geolocation_delegate cfx_get_geolocation;
        // CEF_EXPORT cef_string_userfree_t cef_get_mime_type(const cef_string_t* extension);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_get_mime_type_delegate(IntPtr extension_str, int extension_length);
        public static cfx_get_mime_type_delegate cfx_get_mime_type;
        // CEF_EXPORT int cef_get_path(cef_path_key_t key, cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_get_path_delegate(CfxPathKey key, ref IntPtr path_str, ref int path_length);
        public static cfx_get_path_delegate cfx_get_path;
        // CEF_EXPORT int cef_initialize(const cef_settings_t* settings, cef_app_t* application, void* windows_sandbox_info);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_initialize_delegate(IntPtr settings, IntPtr application, IntPtr windows_sandbox_info);
        public static cfx_initialize_delegate cfx_initialize;
        // CEF_EXPORT void cef_is_web_plugin_unstable(const cef_string_t* path, cef_web_plugin_unstable_callback_t* callback);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_is_web_plugin_unstable_delegate(IntPtr path_str, int path_length, IntPtr callback);
        public static cfx_is_web_plugin_unstable_delegate cfx_is_web_plugin_unstable;
        // CEF_EXPORT int cef_launch_process(cef_command_line_t* command_line);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_launch_process_delegate(IntPtr command_line);
        public static cfx_launch_process_delegate cfx_launch_process;
        // CEF_EXPORT int64 cef_now_from_system_trace_time();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_now_from_system_trace_time_delegate();
        public static cfx_now_from_system_trace_time_delegate cfx_now_from_system_trace_time;
        // CEF_EXPORT int cef_parse_url(const cef_string_t* url, cef_urlparts_t* parts);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_parse_url_delegate(IntPtr url_str, int url_length, IntPtr parts);
        public static cfx_parse_url_delegate cfx_parse_url;
        // CEF_EXPORT int cef_post_delayed_task(cef_thread_id_t threadId, cef_task_t* task, int64 delay_ms);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_delayed_task_delegate(CfxThreadId threadId, IntPtr task, long delay_ms);
        public static cfx_post_delayed_task_delegate cfx_post_delayed_task;
        // CEF_EXPORT int cef_post_task(cef_thread_id_t threadId, cef_task_t* task);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_task_delegate(CfxThreadId threadId, IntPtr task);
        public static cfx_post_task_delegate cfx_post_task;
        // CEF_EXPORT void cef_quit_message_loop();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_quit_message_loop_delegate();
        public static cfx_quit_message_loop_delegate cfx_quit_message_loop;
        // CEF_EXPORT void cef_refresh_web_plugins();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_refresh_web_plugins_delegate();
        public static cfx_refresh_web_plugins_delegate cfx_refresh_web_plugins;
        // CEF_EXPORT int cef_register_extension(const cef_string_t* extension_name, const cef_string_t* javascript_code, cef_v8handler_t* handler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_register_extension_delegate(IntPtr extension_name_str, int extension_name_length, IntPtr javascript_code_str, int javascript_code_length, IntPtr handler);
        public static cfx_register_extension_delegate cfx_register_extension;
        // CEF_EXPORT int cef_register_scheme_handler_factory(const cef_string_t* scheme_name, const cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_register_scheme_handler_factory_delegate(IntPtr scheme_name_str, int scheme_name_length, IntPtr domain_name_str, int domain_name_length, IntPtr factory);
        public static cfx_register_scheme_handler_factory_delegate cfx_register_scheme_handler_factory;
        // CEF_EXPORT void cef_register_web_plugin_crash(const cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_register_web_plugin_crash_delegate(IntPtr path_str, int path_length);
        public static cfx_register_web_plugin_crash_delegate cfx_register_web_plugin_crash;
        // CEF_EXPORT int cef_remove_cross_origin_whitelist_entry(const cef_string_t* source_origin, const cef_string_t* target_protocol, const cef_string_t* target_domain, int allow_target_subdomains);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_remove_cross_origin_whitelist_entry_delegate(IntPtr source_origin_str, int source_origin_length, IntPtr target_protocol_str, int target_protocol_length, IntPtr target_domain_str, int target_domain_length, int allow_target_subdomains);
        public static cfx_remove_cross_origin_whitelist_entry_delegate cfx_remove_cross_origin_whitelist_entry;
        // CEF_EXPORT void cef_remove_web_plugin_path(const cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_remove_web_plugin_path_delegate(IntPtr path_str, int path_length);
        public static cfx_remove_web_plugin_path_delegate cfx_remove_web_plugin_path;
        // CEF_EXPORT void cef_run_message_loop();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_run_message_loop_delegate();
        public static cfx_run_message_loop_delegate cfx_run_message_loop;
        // CEF_EXPORT void cef_set_osmodal_loop(int osModalLoop);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_osmodal_loop_delegate(int osModalLoop);
        public static cfx_set_osmodal_loop_delegate cfx_set_osmodal_loop;
        // CEF_EXPORT void cef_shutdown();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_shutdown_delegate();
        public static cfx_shutdown_delegate cfx_shutdown;
        // CEF_EXPORT void cef_unregister_internal_web_plugin(const cef_string_t* path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_unregister_internal_web_plugin_delegate(IntPtr path_str, int path_length);
        public static cfx_unregister_internal_web_plugin_delegate cfx_unregister_internal_web_plugin;
        // CEF_EXPORT void cef_visit_web_plugin_info(cef_web_plugin_info_visitor_t* visitor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_visit_web_plugin_info_delegate(IntPtr visitor);
        public static cfx_visit_web_plugin_info_delegate cfx_visit_web_plugin_info;

        // CEF_EXPORT cef_string_list_t cef_string_list_alloc();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_string_list_alloc_delegate();
        public static cfx_string_list_alloc_delegate cfx_string_list_alloc;
        // CEF_EXPORT int cef_string_list_size(cef_string_list_t list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_list_size_delegate(IntPtr list);
        public static cfx_string_list_size_delegate cfx_string_list_size;
        // CEF_EXPORT int cef_string_list_value(cef_string_list_t list, int index, cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_list_value_delegate(IntPtr list, int index, ref IntPtr value_str, ref int value_length);
        public static cfx_string_list_value_delegate cfx_string_list_value;
        // CEF_EXPORT void cef_string_list_append(cef_string_list_t list, const cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_list_append_delegate(IntPtr list, IntPtr value_str, int value_length);
        public static cfx_string_list_append_delegate cfx_string_list_append;
        // CEF_EXPORT void cef_string_list_clear(cef_string_list_t list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_list_clear_delegate(IntPtr list);
        public static cfx_string_list_clear_delegate cfx_string_list_clear;
        // CEF_EXPORT void cef_string_list_free(cef_string_list_t list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_list_free_delegate(IntPtr list);
        public static cfx_string_list_free_delegate cfx_string_list_free;
        // CEF_EXPORT cef_string_list_t cef_string_list_copy(cef_string_list_t list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_string_list_copy_delegate(IntPtr list);
        public static cfx_string_list_copy_delegate cfx_string_list_copy;

        // CEF_EXPORT cef_string_map_t cef_string_map_alloc();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_string_map_alloc_delegate();
        public static cfx_string_map_alloc_delegate cfx_string_map_alloc;
        // CEF_EXPORT int cef_string_map_size(cef_string_map_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_map_size_delegate(IntPtr map);
        public static cfx_string_map_size_delegate cfx_string_map_size;
        // CEF_EXPORT int cef_string_map_find(cef_string_map_t map, const cef_string_t* key, cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_map_find_delegate(IntPtr map, IntPtr key_str, int key_length, ref IntPtr value_str, ref int value_length);
        public static cfx_string_map_find_delegate cfx_string_map_find;
        // CEF_EXPORT int cef_string_map_key(cef_string_map_t map, int index, cef_string_t* key);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_map_key_delegate(IntPtr map, int index, ref IntPtr key_str, ref int key_length);
        public static cfx_string_map_key_delegate cfx_string_map_key;
        // CEF_EXPORT int cef_string_map_value(cef_string_map_t map, int index, cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_map_value_delegate(IntPtr map, int index, ref IntPtr value_str, ref int value_length);
        public static cfx_string_map_value_delegate cfx_string_map_value;
        // CEF_EXPORT int cef_string_map_append(cef_string_map_t map, const cef_string_t* key, const cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_map_append_delegate(IntPtr map, IntPtr key_str, int key_length, IntPtr value_str, int value_length);
        public static cfx_string_map_append_delegate cfx_string_map_append;
        // CEF_EXPORT void cef_string_map_clear(cef_string_map_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_map_clear_delegate(IntPtr map);
        public static cfx_string_map_clear_delegate cfx_string_map_clear;
        // CEF_EXPORT void cef_string_map_free(cef_string_map_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_map_free_delegate(IntPtr map);
        public static cfx_string_map_free_delegate cfx_string_map_free;

        // CEF_EXPORT cef_string_multimap_t cef_string_multimap_alloc();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_string_multimap_alloc_delegate();
        public static cfx_string_multimap_alloc_delegate cfx_string_multimap_alloc;
        // CEF_EXPORT int cef_string_multimap_size(cef_string_multimap_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_size_delegate(IntPtr map);
        public static cfx_string_multimap_size_delegate cfx_string_multimap_size;
        // CEF_EXPORT int cef_string_multimap_find_count(cef_string_multimap_t map, const cef_string_t* key);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_find_count_delegate(IntPtr map, IntPtr key_str, int key_length);
        public static cfx_string_multimap_find_count_delegate cfx_string_multimap_find_count;
        // CEF_EXPORT int cef_string_multimap_enumerate(cef_string_multimap_t map, const cef_string_t* key, int value_index, cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_enumerate_delegate(IntPtr map, IntPtr key_str, int key_length, int value_index, ref IntPtr value_str, ref int value_length);
        public static cfx_string_multimap_enumerate_delegate cfx_string_multimap_enumerate;
        // CEF_EXPORT int cef_string_multimap_key(cef_string_multimap_t map, int index, cef_string_t* key);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_key_delegate(IntPtr map, int index, ref IntPtr key_str, ref int key_length);
        public static cfx_string_multimap_key_delegate cfx_string_multimap_key;
        // CEF_EXPORT int cef_string_multimap_value(cef_string_multimap_t map, int index, cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_value_delegate(IntPtr map, int index, ref IntPtr value_str, ref int value_length);
        public static cfx_string_multimap_value_delegate cfx_string_multimap_value;
        // CEF_EXPORT int cef_string_multimap_append(cef_string_multimap_t map, const cef_string_t* key, const cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_string_multimap_append_delegate(IntPtr map, IntPtr key_str, int key_length, IntPtr value_str, int value_length);
        public static cfx_string_multimap_append_delegate cfx_string_multimap_append;
        // CEF_EXPORT void cef_string_multimap_clear(cef_string_multimap_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_multimap_clear_delegate(IntPtr map);
        public static cfx_string_multimap_clear_delegate cfx_string_multimap_clear;
        // CEF_EXPORT void cef_string_multimap_free(cef_string_multimap_t map);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_string_multimap_free_delegate(IntPtr map);
        public static cfx_string_multimap_free_delegate cfx_string_multimap_free;

        // callback setters
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_1_callback_ptrs_delegate(IntPtr cb_0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_2_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_3_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_4_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_5_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_6_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_7_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_8_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_9_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_10_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8, IntPtr cb_9);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_11_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8, IntPtr cb_9, IntPtr cb_10);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_12_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8, IntPtr cb_9, IntPtr cb_10, IntPtr cb_11);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_13_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8, IntPtr cb_9, IntPtr cb_10, IntPtr cb_11, IntPtr cb_12);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_set_14_callback_ptrs_delegate(IntPtr cb_0, IntPtr cb_1, IntPtr cb_2, IntPtr cb_3, IntPtr cb_4, IntPtr cb_5, IntPtr cb_6, IntPtr cb_7, IntPtr cb_8, IntPtr cb_9, IntPtr cb_10, IntPtr cb_11, IntPtr cb_12, IntPtr cb_13);


        // CfxAllowCertificateErrorCallback

        // CFX_EXPORT void cfx_allow_certificate_error_callback_cont(cef_allow_certificate_error_callback_t* self, int allow)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_allow_certificate_error_callback_cont_delegate(IntPtr self, int allow);
        public static cfx_allow_certificate_error_callback_cont_delegate cfx_allow_certificate_error_callback_cont;


        // CfxApp

        // CFX_EXPORT cfx_app_t* cfx_app_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_app_ctor;
        public static cfx_get_gc_handle_delegate cfx_app_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_app_activate_callback;

        // on_before_command_line_processing
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_app_on_before_command_line_processing_delegate(IntPtr gcHandlePtr, IntPtr process_type_str, int process_type_length, IntPtr command_line);
        public static cfx_app_on_before_command_line_processing_delegate cfx_app_on_before_command_line_processing;

        // on_register_custom_schemes
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_app_on_register_custom_schemes_delegate(IntPtr gcHandlePtr, IntPtr registrar);
        public static cfx_app_on_register_custom_schemes_delegate cfx_app_on_register_custom_schemes;

        // get_resource_bundle_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_app_get_resource_bundle_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_app_get_resource_bundle_handler_delegate cfx_app_get_resource_bundle_handler;

        // get_browser_process_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_app_get_browser_process_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_app_get_browser_process_handler_delegate cfx_app_get_browser_process_handler;

        // get_render_process_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_app_get_render_process_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_app_get_render_process_handler_delegate cfx_app_get_render_process_handler;


        // CfxAuthCallback

        // CFX_EXPORT void cfx_auth_callback_cont(cef_auth_callback_t* self, char16 *username_str, int username_length, char16 *password_str, int password_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_auth_callback_cont_delegate(IntPtr self, IntPtr username_str, int username_length, IntPtr password_str, int password_length);
        public static cfx_auth_callback_cont_delegate cfx_auth_callback_cont;

        // CFX_EXPORT void cfx_auth_callback_cancel(cef_auth_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_auth_callback_cancel_delegate(IntPtr self);
        public static cfx_auth_callback_cancel_delegate cfx_auth_callback_cancel;


        // CfxBeforeDownloadCallback

        // CFX_EXPORT void cfx_before_download_callback_cont(cef_before_download_callback_t* self, char16 *download_path_str, int download_path_length, int show_dialog)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_before_download_callback_cont_delegate(IntPtr self, IntPtr download_path_str, int download_path_length, int show_dialog);
        public static cfx_before_download_callback_cont_delegate cfx_before_download_callback_cont;


        // CfxBinaryValue

        // CEF_EXPORT cef_binary_value_t* cef_binary_value_create(const void* data, size_t data_size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_binary_value_create_delegate(IntPtr data, int data_size);
        public static cfx_binary_value_create_delegate cfx_binary_value_create;

        // CFX_EXPORT int cfx_binary_value_is_valid(cef_binary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_binary_value_is_valid_delegate(IntPtr self);
        public static cfx_binary_value_is_valid_delegate cfx_binary_value_is_valid;

        // CFX_EXPORT int cfx_binary_value_is_owned(cef_binary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_binary_value_is_owned_delegate(IntPtr self);
        public static cfx_binary_value_is_owned_delegate cfx_binary_value_is_owned;

        // CFX_EXPORT cef_binary_value_t* cfx_binary_value_copy(cef_binary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_binary_value_copy_delegate(IntPtr self);
        public static cfx_binary_value_copy_delegate cfx_binary_value_copy;

        // CFX_EXPORT int cfx_binary_value_get_size(cef_binary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_binary_value_get_size_delegate(IntPtr self);
        public static cfx_binary_value_get_size_delegate cfx_binary_value_get_size;

        // CFX_EXPORT int cfx_binary_value_get_data(cef_binary_value_t* self, void* buffer, int buffer_size, int data_offset)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_binary_value_get_data_delegate(IntPtr self, IntPtr buffer, int buffer_size, int data_offset);
        public static cfx_binary_value_get_data_delegate cfx_binary_value_get_data;


        // CfxBrowser

        // CFX_EXPORT cef_browser_host_t* cfx_browser_get_host(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_get_host_delegate(IntPtr self);
        public static cfx_browser_get_host_delegate cfx_browser_get_host;

        // CFX_EXPORT int cfx_browser_can_go_back(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_can_go_back_delegate(IntPtr self);
        public static cfx_browser_can_go_back_delegate cfx_browser_can_go_back;

        // CFX_EXPORT void cfx_browser_go_back(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_go_back_delegate(IntPtr self);
        public static cfx_browser_go_back_delegate cfx_browser_go_back;

        // CFX_EXPORT int cfx_browser_can_go_forward(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_can_go_forward_delegate(IntPtr self);
        public static cfx_browser_can_go_forward_delegate cfx_browser_can_go_forward;

        // CFX_EXPORT void cfx_browser_go_forward(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_go_forward_delegate(IntPtr self);
        public static cfx_browser_go_forward_delegate cfx_browser_go_forward;

        // CFX_EXPORT int cfx_browser_is_loading(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_is_loading_delegate(IntPtr self);
        public static cfx_browser_is_loading_delegate cfx_browser_is_loading;

        // CFX_EXPORT void cfx_browser_reload(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_reload_delegate(IntPtr self);
        public static cfx_browser_reload_delegate cfx_browser_reload;

        // CFX_EXPORT void cfx_browser_reload_ignore_cache(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_reload_ignore_cache_delegate(IntPtr self);
        public static cfx_browser_reload_ignore_cache_delegate cfx_browser_reload_ignore_cache;

        // CFX_EXPORT void cfx_browser_stop_load(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_stop_load_delegate(IntPtr self);
        public static cfx_browser_stop_load_delegate cfx_browser_stop_load;

        // CFX_EXPORT int cfx_browser_get_identifier(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_get_identifier_delegate(IntPtr self);
        public static cfx_browser_get_identifier_delegate cfx_browser_get_identifier;

        // CFX_EXPORT int cfx_browser_is_same(cef_browser_t* self, cef_browser_t* that)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_is_same_delegate(IntPtr self, IntPtr that);
        public static cfx_browser_is_same_delegate cfx_browser_is_same;

        // CFX_EXPORT int cfx_browser_is_popup(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_is_popup_delegate(IntPtr self);
        public static cfx_browser_is_popup_delegate cfx_browser_is_popup;

        // CFX_EXPORT int cfx_browser_has_document(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_has_document_delegate(IntPtr self);
        public static cfx_browser_has_document_delegate cfx_browser_has_document;

        // CFX_EXPORT cef_frame_t* cfx_browser_get_main_frame(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_get_main_frame_delegate(IntPtr self);
        public static cfx_browser_get_main_frame_delegate cfx_browser_get_main_frame;

        // CFX_EXPORT cef_frame_t* cfx_browser_get_focused_frame(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_get_focused_frame_delegate(IntPtr self);
        public static cfx_browser_get_focused_frame_delegate cfx_browser_get_focused_frame;

        // CFX_EXPORT cef_frame_t* cfx_browser_get_frame_byident(cef_browser_t* self, int64 identifier)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_get_frame_byident_delegate(IntPtr self, long identifier);
        public static cfx_browser_get_frame_byident_delegate cfx_browser_get_frame_byident;

        // CFX_EXPORT cef_frame_t* cfx_browser_get_frame(cef_browser_t* self, char16 *name_str, int name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_get_frame_delegate(IntPtr self, IntPtr name_str, int name_length);
        public static cfx_browser_get_frame_delegate cfx_browser_get_frame;

        // CFX_EXPORT int cfx_browser_get_frame_count(cef_browser_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_get_frame_count_delegate(IntPtr self);
        public static cfx_browser_get_frame_count_delegate cfx_browser_get_frame_count;

        // CFX_EXPORT void cfx_browser_get_frame_identifiers(cef_browser_t* self, int identifiersCount, int64* identifiers)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_get_frame_identifiers_delegate(IntPtr self, int identifiersCount, IntPtr identifiers);
        public static cfx_browser_get_frame_identifiers_delegate cfx_browser_get_frame_identifiers;

        // CFX_EXPORT void cfx_browser_get_frame_names(cef_browser_t* self, cef_string_list_t names)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_get_frame_names_delegate(IntPtr self, IntPtr names);
        public static cfx_browser_get_frame_names_delegate cfx_browser_get_frame_names;

        // CFX_EXPORT int cfx_browser_send_process_message(cef_browser_t* self, cef_process_id_t target_process, cef_process_message_t* message)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_send_process_message_delegate(IntPtr self, CfxProcessId target_process, IntPtr message);
        public static cfx_browser_send_process_message_delegate cfx_browser_send_process_message;


        // CfxBrowserHost

        // CEF_EXPORT int cef_browser_host_create_browser(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_host_create_browser_delegate(IntPtr windowInfo, IntPtr client, IntPtr url_str, int url_length, IntPtr settings, IntPtr request_context);
        public static cfx_browser_host_create_browser_delegate cfx_browser_host_create_browser;
        // CEF_EXPORT cef_browser_t* cef_browser_host_create_browser_sync(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_create_browser_sync_delegate(IntPtr windowInfo, IntPtr client, IntPtr url_str, int url_length, IntPtr settings, IntPtr request_context);
        public static cfx_browser_host_create_browser_sync_delegate cfx_browser_host_create_browser_sync;

        // CFX_EXPORT cef_browser_t* cfx_browser_host_get_browser(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_browser_delegate(IntPtr self);
        public static cfx_browser_host_get_browser_delegate cfx_browser_host_get_browser;

        // CFX_EXPORT void cfx_browser_host_parent_window_will_close(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_parent_window_will_close_delegate(IntPtr self);
        public static cfx_browser_host_parent_window_will_close_delegate cfx_browser_host_parent_window_will_close;

        // CFX_EXPORT void cfx_browser_host_close_browser(cef_browser_host_t* self, int force_close)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_close_browser_delegate(IntPtr self, int force_close);
        public static cfx_browser_host_close_browser_delegate cfx_browser_host_close_browser;

        // CFX_EXPORT void cfx_browser_host_set_focus(cef_browser_host_t* self, int focus)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_set_focus_delegate(IntPtr self, int focus);
        public static cfx_browser_host_set_focus_delegate cfx_browser_host_set_focus;

        // CFX_EXPORT void cfx_browser_host_set_window_visibility(cef_browser_host_t* self, int visible)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_set_window_visibility_delegate(IntPtr self, int visible);
        public static cfx_browser_host_set_window_visibility_delegate cfx_browser_host_set_window_visibility;

        // CFX_EXPORT cef_window_handle_t cfx_browser_host_get_window_handle(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_window_handle_delegate(IntPtr self);
        public static cfx_browser_host_get_window_handle_delegate cfx_browser_host_get_window_handle;

        // CFX_EXPORT cef_window_handle_t cfx_browser_host_get_opener_window_handle(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_opener_window_handle_delegate(IntPtr self);
        public static cfx_browser_host_get_opener_window_handle_delegate cfx_browser_host_get_opener_window_handle;

        // CFX_EXPORT cef_client_t* cfx_browser_host_get_client(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_client_delegate(IntPtr self);
        public static cfx_browser_host_get_client_delegate cfx_browser_host_get_client;

        // CFX_EXPORT cef_request_context_t* cfx_browser_host_get_request_context(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_request_context_delegate(IntPtr self);
        public static cfx_browser_host_get_request_context_delegate cfx_browser_host_get_request_context;

        // CFX_EXPORT double cfx_browser_host_get_zoom_level(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate double cfx_browser_host_get_zoom_level_delegate(IntPtr self);
        public static cfx_browser_host_get_zoom_level_delegate cfx_browser_host_get_zoom_level;

        // CFX_EXPORT void cfx_browser_host_set_zoom_level(cef_browser_host_t* self, double zoomLevel)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_set_zoom_level_delegate(IntPtr self, double zoomLevel);
        public static cfx_browser_host_set_zoom_level_delegate cfx_browser_host_set_zoom_level;

        // CFX_EXPORT void cfx_browser_host_run_file_dialog(cef_browser_host_t* self, cef_file_dialog_mode_t mode, char16 *title_str, int title_length, char16 *default_file_name_str, int default_file_name_length, cef_string_list_t accept_types, cef_run_file_dialog_callback_t* callback)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_run_file_dialog_delegate(IntPtr self, CfxFileDialogMode mode, IntPtr title_str, int title_length, IntPtr default_file_name_str, int default_file_name_length, IntPtr accept_types, IntPtr callback);
        public static cfx_browser_host_run_file_dialog_delegate cfx_browser_host_run_file_dialog;

        // CFX_EXPORT void cfx_browser_host_start_download(cef_browser_host_t* self, char16 *url_str, int url_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_start_download_delegate(IntPtr self, IntPtr url_str, int url_length);
        public static cfx_browser_host_start_download_delegate cfx_browser_host_start_download;

        // CFX_EXPORT void cfx_browser_host_print(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_print_delegate(IntPtr self);
        public static cfx_browser_host_print_delegate cfx_browser_host_print;

        // CFX_EXPORT void cfx_browser_host_find(cef_browser_host_t* self, int identifier, char16 *searchText_str, int searchText_length, int forward, int matchCase, int findNext)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_find_delegate(IntPtr self, int identifier, IntPtr searchText_str, int searchText_length, int forward, int matchCase, int findNext);
        public static cfx_browser_host_find_delegate cfx_browser_host_find;

        // CFX_EXPORT void cfx_browser_host_stop_finding(cef_browser_host_t* self, int clearSelection)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_stop_finding_delegate(IntPtr self, int clearSelection);
        public static cfx_browser_host_stop_finding_delegate cfx_browser_host_stop_finding;

        // CFX_EXPORT void cfx_browser_host_show_dev_tools(cef_browser_host_t* self, const cef_window_info_t* windowInfo, cef_client_t* client, const cef_browser_settings_t* settings)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_show_dev_tools_delegate(IntPtr self, IntPtr windowInfo, IntPtr client, IntPtr settings);
        public static cfx_browser_host_show_dev_tools_delegate cfx_browser_host_show_dev_tools;

        // CFX_EXPORT void cfx_browser_host_close_dev_tools(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_close_dev_tools_delegate(IntPtr self);
        public static cfx_browser_host_close_dev_tools_delegate cfx_browser_host_close_dev_tools;

        // CFX_EXPORT void cfx_browser_host_set_mouse_cursor_change_disabled(cef_browser_host_t* self, int disabled)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_set_mouse_cursor_change_disabled_delegate(IntPtr self, int disabled);
        public static cfx_browser_host_set_mouse_cursor_change_disabled_delegate cfx_browser_host_set_mouse_cursor_change_disabled;

        // CFX_EXPORT int cfx_browser_host_is_mouse_cursor_change_disabled(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_host_is_mouse_cursor_change_disabled_delegate(IntPtr self);
        public static cfx_browser_host_is_mouse_cursor_change_disabled_delegate cfx_browser_host_is_mouse_cursor_change_disabled;

        // CFX_EXPORT int cfx_browser_host_is_window_rendering_disabled(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_browser_host_is_window_rendering_disabled_delegate(IntPtr self);
        public static cfx_browser_host_is_window_rendering_disabled_delegate cfx_browser_host_is_window_rendering_disabled;

        // CFX_EXPORT void cfx_browser_host_was_resized(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_was_resized_delegate(IntPtr self);
        public static cfx_browser_host_was_resized_delegate cfx_browser_host_was_resized;

        // CFX_EXPORT void cfx_browser_host_was_hidden(cef_browser_host_t* self, int hidden)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_was_hidden_delegate(IntPtr self, int hidden);
        public static cfx_browser_host_was_hidden_delegate cfx_browser_host_was_hidden;

        // CFX_EXPORT void cfx_browser_host_notify_screen_info_changed(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_notify_screen_info_changed_delegate(IntPtr self);
        public static cfx_browser_host_notify_screen_info_changed_delegate cfx_browser_host_notify_screen_info_changed;

        // CFX_EXPORT void cfx_browser_host_invalidate(cef_browser_host_t* self, const cef_rect_t* dirtyRect, cef_paint_element_type_t type)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_invalidate_delegate(IntPtr self, IntPtr dirtyRect, CfxPaintElementType type);
        public static cfx_browser_host_invalidate_delegate cfx_browser_host_invalidate;

        // CFX_EXPORT void cfx_browser_host_send_key_event(cef_browser_host_t* self, const cef_key_event_t* event)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_key_event_delegate(IntPtr self, IntPtr @event);
        public static cfx_browser_host_send_key_event_delegate cfx_browser_host_send_key_event;

        // CFX_EXPORT void cfx_browser_host_send_mouse_click_event(cef_browser_host_t* self, const cef_mouse_event_t* event, cef_mouse_button_type_t type, int mouseUp, int clickCount)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_mouse_click_event_delegate(IntPtr self, IntPtr @event, CfxMouseButtonType type, int mouseUp, int clickCount);
        public static cfx_browser_host_send_mouse_click_event_delegate cfx_browser_host_send_mouse_click_event;

        // CFX_EXPORT void cfx_browser_host_send_mouse_move_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int mouseLeave)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_mouse_move_event_delegate(IntPtr self, IntPtr @event, int mouseLeave);
        public static cfx_browser_host_send_mouse_move_event_delegate cfx_browser_host_send_mouse_move_event;

        // CFX_EXPORT void cfx_browser_host_send_mouse_wheel_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int deltaX, int deltaY)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_mouse_wheel_event_delegate(IntPtr self, IntPtr @event, int deltaX, int deltaY);
        public static cfx_browser_host_send_mouse_wheel_event_delegate cfx_browser_host_send_mouse_wheel_event;

        // CFX_EXPORT void cfx_browser_host_send_focus_event(cef_browser_host_t* self, int setFocus)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_focus_event_delegate(IntPtr self, int setFocus);
        public static cfx_browser_host_send_focus_event_delegate cfx_browser_host_send_focus_event;

        // CFX_EXPORT void cfx_browser_host_send_capture_lost_event(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_send_capture_lost_event_delegate(IntPtr self);
        public static cfx_browser_host_send_capture_lost_event_delegate cfx_browser_host_send_capture_lost_event;

        // CFX_EXPORT cef_text_input_context_t cfx_browser_host_get_nstext_input_context(cef_browser_host_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_browser_host_get_nstext_input_context_delegate(IntPtr self);
        public static cfx_browser_host_get_nstext_input_context_delegate cfx_browser_host_get_nstext_input_context;

        // CFX_EXPORT void cfx_browser_host_handle_key_event_before_text_input_client(cef_browser_host_t* self, cef_event_handle_t keyEvent)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_handle_key_event_before_text_input_client_delegate(IntPtr self, IntPtr keyEvent);
        public static cfx_browser_host_handle_key_event_before_text_input_client_delegate cfx_browser_host_handle_key_event_before_text_input_client;

        // CFX_EXPORT void cfx_browser_host_handle_key_event_after_text_input_client(cef_browser_host_t* self, cef_event_handle_t keyEvent)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_host_handle_key_event_after_text_input_client_delegate(IntPtr self, IntPtr keyEvent);
        public static cfx_browser_host_handle_key_event_after_text_input_client_delegate cfx_browser_host_handle_key_event_after_text_input_client;


        // CfxBrowserProcessHandler

        // CFX_EXPORT cfx_browser_process_handler_t* cfx_browser_process_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_browser_process_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_browser_process_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_browser_process_handler_activate_callback;

        // on_context_initialized
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_browser_process_handler_on_context_initialized_delegate(IntPtr gcHandlePtr);
        public static cfx_browser_process_handler_on_context_initialized_delegate cfx_browser_process_handler_on_context_initialized;

        // on_before_child_process_launch
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_browser_process_handler_on_before_child_process_launch_delegate(IntPtr gcHandlePtr, IntPtr command_line);
        public static cfx_browser_process_handler_on_before_child_process_launch_delegate cfx_browser_process_handler_on_before_child_process_launch;

        // on_render_process_thread_created
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_browser_process_handler_on_render_process_thread_created_delegate(IntPtr gcHandlePtr, IntPtr extra_info);
        public static cfx_browser_process_handler_on_render_process_thread_created_delegate cfx_browser_process_handler_on_render_process_thread_created;


        // CfxBrowserSettings

        // CFX_EXPORT cef_browser_settings_t* cfx_browser_settings_ctor()
        public static cfx_ctor_delegate cfx_browser_settings_ctor;
        // CFX_EXPORT void cfx_browser_settings_dtor(cef_browser_settings_t* ptr)
        public static cfx_dtor_delegate cfx_browser_settings_dtor;

        // CFX_EXPORT void cfx_browser_settings_copy_to_native(cef_browser_settings_t* self, char16 *standard_font_family_str, int standard_font_family_length, char16 *fixed_font_family_str, int fixed_font_family_length, char16 *serif_font_family_str, int serif_font_family_length, char16 *sans_serif_font_family_str, int sans_serif_font_family_length, char16 *cursive_font_family_str, int cursive_font_family_length, char16 *fantasy_font_family_str, int fantasy_font_family_length, int default_font_size, int default_fixed_font_size, int minimum_font_size, int minimum_logical_font_size, char16 *default_encoding_str, int default_encoding_length, cef_state_t remote_fonts, cef_state_t javascript, cef_state_t javascript_open_windows, cef_state_t javascript_close_windows, cef_state_t javascript_access_clipboard, cef_state_t javascript_dom_paste, cef_state_t caret_browsing, cef_state_t java, cef_state_t plugins, cef_state_t universal_access_from_file_urls, cef_state_t file_access_from_file_urls, cef_state_t web_security, cef_state_t image_loading, cef_state_t image_shrink_standalone_to_fit, cef_state_t text_area_resize, cef_state_t tab_to_links, cef_state_t local_storage, cef_state_t databases, cef_state_t application_cache, cef_state_t webgl, cef_state_t accelerated_compositing, uint32 background_color)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_settings_copy_to_native_delegate(IntPtr self, IntPtr standard_font_family_str, int standard_font_family_length, IntPtr fixed_font_family_str, int fixed_font_family_length, IntPtr serif_font_family_str, int serif_font_family_length, IntPtr sans_serif_font_family_str, int sans_serif_font_family_length, IntPtr cursive_font_family_str, int cursive_font_family_length, IntPtr fantasy_font_family_str, int fantasy_font_family_length, int default_font_size, int default_fixed_font_size, int minimum_font_size, int minimum_logical_font_size, IntPtr default_encoding_str, int default_encoding_length, CfxState remote_fonts, CfxState javascript, CfxState javascript_open_windows, CfxState javascript_close_windows, CfxState javascript_access_clipboard, CfxState javascript_dom_paste, CfxState caret_browsing, CfxState java, CfxState plugins, CfxState universal_access_from_file_urls, CfxState file_access_from_file_urls, CfxState web_security, CfxState image_loading, CfxState image_shrink_standalone_to_fit, CfxState text_area_resize, CfxState tab_to_links, CfxState local_storage, CfxState databases, CfxState application_cache, CfxState webgl, CfxState accelerated_compositing, uint background_color);
        public static cfx_browser_settings_copy_to_native_delegate cfx_browser_settings_copy_to_native;
        // CFX_EXPORT void cfx_browser_settings_copy_to_managed(cef_browser_settings_t* self, char16 **standard_font_family_str, int *standard_font_family_length, char16 **fixed_font_family_str, int *fixed_font_family_length, char16 **serif_font_family_str, int *serif_font_family_length, char16 **sans_serif_font_family_str, int *sans_serif_font_family_length, char16 **cursive_font_family_str, int *cursive_font_family_length, char16 **fantasy_font_family_str, int *fantasy_font_family_length, int* default_font_size, int* default_fixed_font_size, int* minimum_font_size, int* minimum_logical_font_size, char16 **default_encoding_str, int *default_encoding_length, cef_state_t* remote_fonts, cef_state_t* javascript, cef_state_t* javascript_open_windows, cef_state_t* javascript_close_windows, cef_state_t* javascript_access_clipboard, cef_state_t* javascript_dom_paste, cef_state_t* caret_browsing, cef_state_t* java, cef_state_t* plugins, cef_state_t* universal_access_from_file_urls, cef_state_t* file_access_from_file_urls, cef_state_t* web_security, cef_state_t* image_loading, cef_state_t* image_shrink_standalone_to_fit, cef_state_t* text_area_resize, cef_state_t* tab_to_links, cef_state_t* local_storage, cef_state_t* databases, cef_state_t* application_cache, cef_state_t* webgl, cef_state_t* accelerated_compositing, uint32* background_color)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_browser_settings_copy_to_managed_delegate(IntPtr self, out IntPtr standard_font_family_str, out int standard_font_family_length, out IntPtr fixed_font_family_str, out int fixed_font_family_length, out IntPtr serif_font_family_str, out int serif_font_family_length, out IntPtr sans_serif_font_family_str, out int sans_serif_font_family_length, out IntPtr cursive_font_family_str, out int cursive_font_family_length, out IntPtr fantasy_font_family_str, out int fantasy_font_family_length, out int default_font_size, out int default_fixed_font_size, out int minimum_font_size, out int minimum_logical_font_size, out IntPtr default_encoding_str, out int default_encoding_length, out CfxState remote_fonts, out CfxState javascript, out CfxState javascript_open_windows, out CfxState javascript_close_windows, out CfxState javascript_access_clipboard, out CfxState javascript_dom_paste, out CfxState caret_browsing, out CfxState java, out CfxState plugins, out CfxState universal_access_from_file_urls, out CfxState file_access_from_file_urls, out CfxState web_security, out CfxState image_loading, out CfxState image_shrink_standalone_to_fit, out CfxState text_area_resize, out CfxState tab_to_links, out CfxState local_storage, out CfxState databases, out CfxState application_cache, out CfxState webgl, out CfxState accelerated_compositing, out uint background_color);
        public static cfx_browser_settings_copy_to_managed_delegate cfx_browser_settings_copy_to_managed;


        // CfxCallback

        // CFX_EXPORT void cfx_callback_cont(cef_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_callback_cont_delegate(IntPtr self);
        public static cfx_callback_cont_delegate cfx_callback_cont;

        // CFX_EXPORT void cfx_callback_cancel(cef_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_callback_cancel_delegate(IntPtr self);
        public static cfx_callback_cancel_delegate cfx_callback_cancel;


        // CfxClient

        // CFX_EXPORT cfx_client_t* cfx_client_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_client_ctor;
        public static cfx_get_gc_handle_delegate cfx_client_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_client_activate_callback;

        // get_context_menu_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_context_menu_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_context_menu_handler_delegate cfx_client_get_context_menu_handler;

        // get_dialog_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_dialog_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_dialog_handler_delegate cfx_client_get_dialog_handler;

        // get_display_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_display_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_display_handler_delegate cfx_client_get_display_handler;

        // get_download_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_download_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_download_handler_delegate cfx_client_get_download_handler;

        // get_drag_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_drag_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_drag_handler_delegate cfx_client_get_drag_handler;

        // get_focus_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_focus_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_focus_handler_delegate cfx_client_get_focus_handler;

        // get_geolocation_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_geolocation_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_geolocation_handler_delegate cfx_client_get_geolocation_handler;

        // get_jsdialog_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_jsdialog_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_jsdialog_handler_delegate cfx_client_get_jsdialog_handler;

        // get_keyboard_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_keyboard_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_keyboard_handler_delegate cfx_client_get_keyboard_handler;

        // get_life_span_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_life_span_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_life_span_handler_delegate cfx_client_get_life_span_handler;

        // get_load_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_load_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_load_handler_delegate cfx_client_get_load_handler;

        // get_render_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_render_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_render_handler_delegate cfx_client_get_render_handler;

        // get_request_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_get_request_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_client_get_request_handler_delegate cfx_client_get_request_handler;

        // on_process_message_received
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_client_on_process_message_received_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxProcessId source_process, IntPtr message);
        public static cfx_client_on_process_message_received_delegate cfx_client_on_process_message_received;


        // CfxCommandLine

        // CEF_EXPORT cef_command_line_t* cef_command_line_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_create_delegate();
        public static cfx_command_line_create_delegate cfx_command_line_create;
        // CEF_EXPORT cef_command_line_t* cef_command_line_get_global();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_get_global_delegate();
        public static cfx_command_line_get_global_delegate cfx_command_line_get_global;

        // CFX_EXPORT int cfx_command_line_is_valid(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_command_line_is_valid_delegate(IntPtr self);
        public static cfx_command_line_is_valid_delegate cfx_command_line_is_valid;

        // CFX_EXPORT int cfx_command_line_is_read_only(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_command_line_is_read_only_delegate(IntPtr self);
        public static cfx_command_line_is_read_only_delegate cfx_command_line_is_read_only;

        // CFX_EXPORT cef_command_line_t* cfx_command_line_copy(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_copy_delegate(IntPtr self);
        public static cfx_command_line_copy_delegate cfx_command_line_copy;

        // CFX_EXPORT void cfx_command_line_init_from_argv(cef_command_line_t* self, int argc, const char* const* argv)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_init_from_argv_delegate(IntPtr self, int argc, IntPtr argv);
        public static cfx_command_line_init_from_argv_delegate cfx_command_line_init_from_argv;

        // CFX_EXPORT void cfx_command_line_init_from_string(cef_command_line_t* self, char16 *command_line_str, int command_line_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_init_from_string_delegate(IntPtr self, IntPtr command_line_str, int command_line_length);
        public static cfx_command_line_init_from_string_delegate cfx_command_line_init_from_string;

        // CFX_EXPORT void cfx_command_line_reset(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_reset_delegate(IntPtr self);
        public static cfx_command_line_reset_delegate cfx_command_line_reset;

        // CFX_EXPORT void cfx_command_line_get_argv(cef_command_line_t* self, cef_string_list_t argv)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_get_argv_delegate(IntPtr self, IntPtr argv);
        public static cfx_command_line_get_argv_delegate cfx_command_line_get_argv;

        // CFX_EXPORT cef_string_userfree_t cfx_command_line_get_command_line_string(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_get_command_line_string_delegate(IntPtr self);
        public static cfx_command_line_get_command_line_string_delegate cfx_command_line_get_command_line_string;

        // CFX_EXPORT cef_string_userfree_t cfx_command_line_get_program(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_get_program_delegate(IntPtr self);
        public static cfx_command_line_get_program_delegate cfx_command_line_get_program;

        // CFX_EXPORT void cfx_command_line_set_program(cef_command_line_t* self, char16 *program_str, int program_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_set_program_delegate(IntPtr self, IntPtr program_str, int program_length);
        public static cfx_command_line_set_program_delegate cfx_command_line_set_program;

        // CFX_EXPORT int cfx_command_line_has_switches(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_command_line_has_switches_delegate(IntPtr self);
        public static cfx_command_line_has_switches_delegate cfx_command_line_has_switches;

        // CFX_EXPORT int cfx_command_line_has_switch(cef_command_line_t* self, char16 *name_str, int name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_command_line_has_switch_delegate(IntPtr self, IntPtr name_str, int name_length);
        public static cfx_command_line_has_switch_delegate cfx_command_line_has_switch;

        // CFX_EXPORT cef_string_userfree_t cfx_command_line_get_switch_value(cef_command_line_t* self, char16 *name_str, int name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_command_line_get_switch_value_delegate(IntPtr self, IntPtr name_str, int name_length);
        public static cfx_command_line_get_switch_value_delegate cfx_command_line_get_switch_value;

        // CFX_EXPORT void cfx_command_line_get_switches(cef_command_line_t* self, cef_string_map_t switches)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_get_switches_delegate(IntPtr self, IntPtr switches);
        public static cfx_command_line_get_switches_delegate cfx_command_line_get_switches;

        // CFX_EXPORT void cfx_command_line_append_switch(cef_command_line_t* self, char16 *name_str, int name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_append_switch_delegate(IntPtr self, IntPtr name_str, int name_length);
        public static cfx_command_line_append_switch_delegate cfx_command_line_append_switch;

        // CFX_EXPORT void cfx_command_line_append_switch_with_value(cef_command_line_t* self, char16 *name_str, int name_length, char16 *value_str, int value_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_append_switch_with_value_delegate(IntPtr self, IntPtr name_str, int name_length, IntPtr value_str, int value_length);
        public static cfx_command_line_append_switch_with_value_delegate cfx_command_line_append_switch_with_value;

        // CFX_EXPORT int cfx_command_line_has_arguments(cef_command_line_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_command_line_has_arguments_delegate(IntPtr self);
        public static cfx_command_line_has_arguments_delegate cfx_command_line_has_arguments;

        // CFX_EXPORT void cfx_command_line_get_arguments(cef_command_line_t* self, cef_string_list_t arguments)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_get_arguments_delegate(IntPtr self, IntPtr arguments);
        public static cfx_command_line_get_arguments_delegate cfx_command_line_get_arguments;

        // CFX_EXPORT void cfx_command_line_append_argument(cef_command_line_t* self, char16 *argument_str, int argument_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_append_argument_delegate(IntPtr self, IntPtr argument_str, int argument_length);
        public static cfx_command_line_append_argument_delegate cfx_command_line_append_argument;

        // CFX_EXPORT void cfx_command_line_prepend_wrapper(cef_command_line_t* self, char16 *wrapper_str, int wrapper_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_command_line_prepend_wrapper_delegate(IntPtr self, IntPtr wrapper_str, int wrapper_length);
        public static cfx_command_line_prepend_wrapper_delegate cfx_command_line_prepend_wrapper;


        // CfxCompletionHandler

        // CFX_EXPORT cfx_completion_handler_t* cfx_completion_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_completion_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_completion_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_completion_handler_activate_callback;

        // on_complete
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_completion_handler_on_complete_delegate(IntPtr gcHandlePtr);
        public static cfx_completion_handler_on_complete_delegate cfx_completion_handler_on_complete;


        // CfxContextMenuHandler

        // CFX_EXPORT cfx_context_menu_handler_t* cfx_context_menu_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_context_menu_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_context_menu_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_context_menu_handler_activate_callback;

        // on_before_context_menu
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_context_menu_handler_on_before_context_menu_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr parameters, IntPtr model);
        public static cfx_context_menu_handler_on_before_context_menu_delegate cfx_context_menu_handler_on_before_context_menu;

        // on_context_menu_command
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_context_menu_handler_on_context_menu_command_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr parameters, int command_id, CfxEventFlags event_flags);
        public static cfx_context_menu_handler_on_context_menu_command_delegate cfx_context_menu_handler_on_context_menu_command;

        // on_context_menu_dismissed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_context_menu_handler_on_context_menu_dismissed_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame);
        public static cfx_context_menu_handler_on_context_menu_dismissed_delegate cfx_context_menu_handler_on_context_menu_dismissed;


        // CfxContextMenuParams

        // CFX_EXPORT int cfx_context_menu_params_get_xcoord(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_context_menu_params_get_xcoord_delegate(IntPtr self);
        public static cfx_context_menu_params_get_xcoord_delegate cfx_context_menu_params_get_xcoord;

        // CFX_EXPORT int cfx_context_menu_params_get_ycoord(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_context_menu_params_get_ycoord_delegate(IntPtr self);
        public static cfx_context_menu_params_get_ycoord_delegate cfx_context_menu_params_get_ycoord;

        // CFX_EXPORT cef_context_menu_type_flags_t cfx_context_menu_params_get_type_flags(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxContextMenuTypeFlags cfx_context_menu_params_get_type_flags_delegate(IntPtr self);
        public static cfx_context_menu_params_get_type_flags_delegate cfx_context_menu_params_get_type_flags;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_link_url(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_link_url_delegate(IntPtr self);
        public static cfx_context_menu_params_get_link_url_delegate cfx_context_menu_params_get_link_url;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_unfiltered_link_url(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_unfiltered_link_url_delegate(IntPtr self);
        public static cfx_context_menu_params_get_unfiltered_link_url_delegate cfx_context_menu_params_get_unfiltered_link_url;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_source_url(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_source_url_delegate(IntPtr self);
        public static cfx_context_menu_params_get_source_url_delegate cfx_context_menu_params_get_source_url;

        // CFX_EXPORT int cfx_context_menu_params_has_image_contents(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_context_menu_params_has_image_contents_delegate(IntPtr self);
        public static cfx_context_menu_params_has_image_contents_delegate cfx_context_menu_params_has_image_contents;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_page_url(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_page_url_delegate(IntPtr self);
        public static cfx_context_menu_params_get_page_url_delegate cfx_context_menu_params_get_page_url;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_frame_url(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_frame_url_delegate(IntPtr self);
        public static cfx_context_menu_params_get_frame_url_delegate cfx_context_menu_params_get_frame_url;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_frame_charset(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_frame_charset_delegate(IntPtr self);
        public static cfx_context_menu_params_get_frame_charset_delegate cfx_context_menu_params_get_frame_charset;

        // CFX_EXPORT cef_context_menu_media_type_t cfx_context_menu_params_get_media_type(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxContextMenuMediaType cfx_context_menu_params_get_media_type_delegate(IntPtr self);
        public static cfx_context_menu_params_get_media_type_delegate cfx_context_menu_params_get_media_type;

        // CFX_EXPORT cef_context_menu_media_state_flags_t cfx_context_menu_params_get_media_state_flags(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxContextMenuMediaStateFlags cfx_context_menu_params_get_media_state_flags_delegate(IntPtr self);
        public static cfx_context_menu_params_get_media_state_flags_delegate cfx_context_menu_params_get_media_state_flags;

        // CFX_EXPORT cef_string_userfree_t cfx_context_menu_params_get_selection_text(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_context_menu_params_get_selection_text_delegate(IntPtr self);
        public static cfx_context_menu_params_get_selection_text_delegate cfx_context_menu_params_get_selection_text;

        // CFX_EXPORT int cfx_context_menu_params_is_editable(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_context_menu_params_is_editable_delegate(IntPtr self);
        public static cfx_context_menu_params_is_editable_delegate cfx_context_menu_params_is_editable;

        // CFX_EXPORT int cfx_context_menu_params_is_speech_input_enabled(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_context_menu_params_is_speech_input_enabled_delegate(IntPtr self);
        public static cfx_context_menu_params_is_speech_input_enabled_delegate cfx_context_menu_params_is_speech_input_enabled;

        // CFX_EXPORT cef_context_menu_edit_state_flags_t cfx_context_menu_params_get_edit_state_flags(cef_context_menu_params_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxContextMenuEditStateFlags cfx_context_menu_params_get_edit_state_flags_delegate(IntPtr self);
        public static cfx_context_menu_params_get_edit_state_flags_delegate cfx_context_menu_params_get_edit_state_flags;


        // CfxCookie

        // CFX_EXPORT cef_cookie_t* cfx_cookie_ctor()
        public static cfx_ctor_delegate cfx_cookie_ctor;
        // CFX_EXPORT void cfx_cookie_dtor(cef_cookie_t* ptr)
        public static cfx_dtor_delegate cfx_cookie_dtor;

        // CFX_EXPORT void cfx_cookie_copy_to_native(cef_cookie_t* self, char16 *name_str, int name_length, char16 *value_str, int value_length, char16 *domain_str, int domain_length, char16 *path_str, int path_length, int secure, int httponly, cef_time_t* creation, cef_time_t* last_access, int has_expires, cef_time_t* expires)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_cookie_copy_to_native_delegate(IntPtr self, IntPtr name_str, int name_length, IntPtr value_str, int value_length, IntPtr domain_str, int domain_length, IntPtr path_str, int path_length, int secure, int httponly, IntPtr creation, IntPtr last_access, int has_expires, IntPtr expires);
        public static cfx_cookie_copy_to_native_delegate cfx_cookie_copy_to_native;
        // CFX_EXPORT void cfx_cookie_copy_to_managed(cef_cookie_t* self, char16 **name_str, int *name_length, char16 **value_str, int *value_length, char16 **domain_str, int *domain_length, char16 **path_str, int *path_length, int* secure, int* httponly, cef_time_t** creation, cef_time_t** last_access, int* has_expires, cef_time_t** expires)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_cookie_copy_to_managed_delegate(IntPtr self, out IntPtr name_str, out int name_length, out IntPtr value_str, out int value_length, out IntPtr domain_str, out int domain_length, out IntPtr path_str, out int path_length, out int secure, out int httponly, out IntPtr creation, out IntPtr last_access, out int has_expires, out IntPtr expires);
        public static cfx_cookie_copy_to_managed_delegate cfx_cookie_copy_to_managed;


        // CfxCookieManager

        // CEF_EXPORT cef_cookie_manager_t* cef_cookie_manager_get_global_manager();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_cookie_manager_get_global_manager_delegate();
        public static cfx_cookie_manager_get_global_manager_delegate cfx_cookie_manager_get_global_manager;
        // CEF_EXPORT cef_cookie_manager_t* cef_cookie_manager_create_manager(const cef_string_t* path, int persist_session_cookies);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_cookie_manager_create_manager_delegate(IntPtr path_str, int path_length, int persist_session_cookies);
        public static cfx_cookie_manager_create_manager_delegate cfx_cookie_manager_create_manager;

        // CFX_EXPORT void cfx_cookie_manager_set_supported_schemes(cef_cookie_manager_t* self, cef_string_list_t schemes)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_cookie_manager_set_supported_schemes_delegate(IntPtr self, IntPtr schemes);
        public static cfx_cookie_manager_set_supported_schemes_delegate cfx_cookie_manager_set_supported_schemes;

        // CFX_EXPORT int cfx_cookie_manager_visit_all_cookies(cef_cookie_manager_t* self, cef_cookie_visitor_t* visitor)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_visit_all_cookies_delegate(IntPtr self, IntPtr visitor);
        public static cfx_cookie_manager_visit_all_cookies_delegate cfx_cookie_manager_visit_all_cookies;

        // CFX_EXPORT int cfx_cookie_manager_visit_url_cookies(cef_cookie_manager_t* self, char16 *url_str, int url_length, int includeHttpOnly, cef_cookie_visitor_t* visitor)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_visit_url_cookies_delegate(IntPtr self, IntPtr url_str, int url_length, int includeHttpOnly, IntPtr visitor);
        public static cfx_cookie_manager_visit_url_cookies_delegate cfx_cookie_manager_visit_url_cookies;

        // CFX_EXPORT int cfx_cookie_manager_set_cookie(cef_cookie_manager_t* self, char16 *url_str, int url_length, const cef_cookie_t* cookie)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_set_cookie_delegate(IntPtr self, IntPtr url_str, int url_length, IntPtr cookie);
        public static cfx_cookie_manager_set_cookie_delegate cfx_cookie_manager_set_cookie;

        // CFX_EXPORT int cfx_cookie_manager_delete_cookies(cef_cookie_manager_t* self, char16 *url_str, int url_length, char16 *cookie_name_str, int cookie_name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_delete_cookies_delegate(IntPtr self, IntPtr url_str, int url_length, IntPtr cookie_name_str, int cookie_name_length);
        public static cfx_cookie_manager_delete_cookies_delegate cfx_cookie_manager_delete_cookies;

        // CFX_EXPORT int cfx_cookie_manager_set_storage_path(cef_cookie_manager_t* self, char16 *path_str, int path_length, int persist_session_cookies)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_set_storage_path_delegate(IntPtr self, IntPtr path_str, int path_length, int persist_session_cookies);
        public static cfx_cookie_manager_set_storage_path_delegate cfx_cookie_manager_set_storage_path;

        // CFX_EXPORT int cfx_cookie_manager_flush_store(cef_cookie_manager_t* self, cef_completion_handler_t* handler)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_cookie_manager_flush_store_delegate(IntPtr self, IntPtr handler);
        public static cfx_cookie_manager_flush_store_delegate cfx_cookie_manager_flush_store;


        // CfxCookieVisitor

        // CFX_EXPORT cfx_cookie_visitor_t* cfx_cookie_visitor_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_cookie_visitor_ctor;
        public static cfx_get_gc_handle_delegate cfx_cookie_visitor_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_cookie_visitor_activate_callback;

        // visit
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_cookie_visitor_visit_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr cookie, int count, int total, out int deleteCookie);
        public static cfx_cookie_visitor_visit_delegate cfx_cookie_visitor_visit;


        // CfxDialogHandler

        // CFX_EXPORT cfx_dialog_handler_t* cfx_dialog_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_dialog_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_dialog_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_dialog_handler_activate_callback;

        // on_file_dialog
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_dialog_handler_on_file_dialog_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxFileDialogMode mode, IntPtr title_str, int title_length, IntPtr default_file_name_str, int default_file_name_length, IntPtr accept_types, IntPtr callback);
        public static cfx_dialog_handler_on_file_dialog_delegate cfx_dialog_handler_on_file_dialog;


        // CfxDictionaryValue

        // CEF_EXPORT cef_dictionary_value_t* cef_dictionary_value_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_create_delegate();
        public static cfx_dictionary_value_create_delegate cfx_dictionary_value_create;

        // CFX_EXPORT int cfx_dictionary_value_is_valid(cef_dictionary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_is_valid_delegate(IntPtr self);
        public static cfx_dictionary_value_is_valid_delegate cfx_dictionary_value_is_valid;

        // CFX_EXPORT int cfx_dictionary_value_is_owned(cef_dictionary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_is_owned_delegate(IntPtr self);
        public static cfx_dictionary_value_is_owned_delegate cfx_dictionary_value_is_owned;

        // CFX_EXPORT int cfx_dictionary_value_is_read_only(cef_dictionary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_is_read_only_delegate(IntPtr self);
        public static cfx_dictionary_value_is_read_only_delegate cfx_dictionary_value_is_read_only;

        // CFX_EXPORT cef_dictionary_value_t* cfx_dictionary_value_copy(cef_dictionary_value_t* self, int exclude_empty_children)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_copy_delegate(IntPtr self, int exclude_empty_children);
        public static cfx_dictionary_value_copy_delegate cfx_dictionary_value_copy;

        // CFX_EXPORT int cfx_dictionary_value_get_size(cef_dictionary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_get_size_delegate(IntPtr self);
        public static cfx_dictionary_value_get_size_delegate cfx_dictionary_value_get_size;

        // CFX_EXPORT int cfx_dictionary_value_clear(cef_dictionary_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_clear_delegate(IntPtr self);
        public static cfx_dictionary_value_clear_delegate cfx_dictionary_value_clear;

        // CFX_EXPORT int cfx_dictionary_value_has_key(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_has_key_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_has_key_delegate cfx_dictionary_value_has_key;

        // CFX_EXPORT int cfx_dictionary_value_get_keys(cef_dictionary_value_t* self, cef_string_list_t keys)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_get_keys_delegate(IntPtr self, IntPtr keys);
        public static cfx_dictionary_value_get_keys_delegate cfx_dictionary_value_get_keys;

        // CFX_EXPORT int cfx_dictionary_value_remove(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_remove_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_remove_delegate cfx_dictionary_value_remove;

        // CFX_EXPORT cef_value_type_t cfx_dictionary_value_get_type(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxValueType cfx_dictionary_value_get_type_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_type_delegate cfx_dictionary_value_get_type;

        // CFX_EXPORT int cfx_dictionary_value_get_bool(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_get_bool_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_bool_delegate cfx_dictionary_value_get_bool;

        // CFX_EXPORT int cfx_dictionary_value_get_int(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_get_int_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_int_delegate cfx_dictionary_value_get_int;

        // CFX_EXPORT double cfx_dictionary_value_get_double(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate double cfx_dictionary_value_get_double_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_double_delegate cfx_dictionary_value_get_double;

        // CFX_EXPORT cef_string_userfree_t cfx_dictionary_value_get_string(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_get_string_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_string_delegate cfx_dictionary_value_get_string;

        // CFX_EXPORT cef_binary_value_t* cfx_dictionary_value_get_binary(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_get_binary_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_binary_delegate cfx_dictionary_value_get_binary;

        // CFX_EXPORT cef_dictionary_value_t* cfx_dictionary_value_get_dictionary(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_get_dictionary_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_dictionary_delegate cfx_dictionary_value_get_dictionary;

        // CFX_EXPORT cef_list_value_t* cfx_dictionary_value_get_list(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_dictionary_value_get_list_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_get_list_delegate cfx_dictionary_value_get_list;

        // CFX_EXPORT int cfx_dictionary_value_set_null(cef_dictionary_value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_null_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_dictionary_value_set_null_delegate cfx_dictionary_value_set_null;

        // CFX_EXPORT int cfx_dictionary_value_set_bool(cef_dictionary_value_t* self, char16 *key_str, int key_length, int value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_bool_delegate(IntPtr self, IntPtr key_str, int key_length, int value);
        public static cfx_dictionary_value_set_bool_delegate cfx_dictionary_value_set_bool;

        // CFX_EXPORT int cfx_dictionary_value_set_int(cef_dictionary_value_t* self, char16 *key_str, int key_length, int value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_int_delegate(IntPtr self, IntPtr key_str, int key_length, int value);
        public static cfx_dictionary_value_set_int_delegate cfx_dictionary_value_set_int;

        // CFX_EXPORT int cfx_dictionary_value_set_double(cef_dictionary_value_t* self, char16 *key_str, int key_length, double value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_double_delegate(IntPtr self, IntPtr key_str, int key_length, double value);
        public static cfx_dictionary_value_set_double_delegate cfx_dictionary_value_set_double;

        // CFX_EXPORT int cfx_dictionary_value_set_string(cef_dictionary_value_t* self, char16 *key_str, int key_length, char16 *value_str, int value_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_string_delegate(IntPtr self, IntPtr key_str, int key_length, IntPtr value_str, int value_length);
        public static cfx_dictionary_value_set_string_delegate cfx_dictionary_value_set_string;

        // CFX_EXPORT int cfx_dictionary_value_set_binary(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_binary_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_binary_delegate(IntPtr self, IntPtr key_str, int key_length, IntPtr value);
        public static cfx_dictionary_value_set_binary_delegate cfx_dictionary_value_set_binary;

        // CFX_EXPORT int cfx_dictionary_value_set_dictionary(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_dictionary_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_dictionary_delegate(IntPtr self, IntPtr key_str, int key_length, IntPtr value);
        public static cfx_dictionary_value_set_dictionary_delegate cfx_dictionary_value_set_dictionary;

        // CFX_EXPORT int cfx_dictionary_value_set_list(cef_dictionary_value_t* self, char16 *key_str, int key_length, cef_list_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_dictionary_value_set_list_delegate(IntPtr self, IntPtr key_str, int key_length, IntPtr value);
        public static cfx_dictionary_value_set_list_delegate cfx_dictionary_value_set_list;


        // CfxDisplayHandler

        // CFX_EXPORT cfx_display_handler_t* cfx_display_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_display_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_display_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_display_handler_activate_callback;

        // on_address_change
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_display_handler_on_address_change_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr url_str, int url_length);
        public static cfx_display_handler_on_address_change_delegate cfx_display_handler_on_address_change;

        // on_title_change
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_display_handler_on_title_change_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr title_str, int title_length);
        public static cfx_display_handler_on_title_change_delegate cfx_display_handler_on_title_change;

        // on_tooltip
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_display_handler_on_tooltip_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, ref IntPtr text_str, ref int text_length);
        public static cfx_display_handler_on_tooltip_delegate cfx_display_handler_on_tooltip;

        // on_status_message
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_display_handler_on_status_message_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr value_str, int value_length);
        public static cfx_display_handler_on_status_message_delegate cfx_display_handler_on_status_message;

        // on_console_message
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_display_handler_on_console_message_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr message_str, int message_length, IntPtr source_str, int source_length, int line);
        public static cfx_display_handler_on_console_message_delegate cfx_display_handler_on_console_message;


        // CfxDomDocument

        // CFX_EXPORT cef_dom_document_type_t cfx_domdocument_get_type(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxDomDocumentType cfx_domdocument_get_type_delegate(IntPtr self);
        public static cfx_domdocument_get_type_delegate cfx_domdocument_get_type;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_document(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_document_delegate(IntPtr self);
        public static cfx_domdocument_get_document_delegate cfx_domdocument_get_document;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_body(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_body_delegate(IntPtr self);
        public static cfx_domdocument_get_body_delegate cfx_domdocument_get_body;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_head(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_head_delegate(IntPtr self);
        public static cfx_domdocument_get_head_delegate cfx_domdocument_get_head;

        // CFX_EXPORT cef_string_userfree_t cfx_domdocument_get_title(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_title_delegate(IntPtr self);
        public static cfx_domdocument_get_title_delegate cfx_domdocument_get_title;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_element_by_id(cef_domdocument_t* self, char16 *id_str, int id_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_element_by_id_delegate(IntPtr self, IntPtr id_str, int id_length);
        public static cfx_domdocument_get_element_by_id_delegate cfx_domdocument_get_element_by_id;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_focused_node(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_focused_node_delegate(IntPtr self);
        public static cfx_domdocument_get_focused_node_delegate cfx_domdocument_get_focused_node;

        // CFX_EXPORT int cfx_domdocument_has_selection(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domdocument_has_selection_delegate(IntPtr self);
        public static cfx_domdocument_has_selection_delegate cfx_domdocument_has_selection;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_selection_start_node(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_selection_start_node_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_start_node_delegate cfx_domdocument_get_selection_start_node;

        // CFX_EXPORT int cfx_domdocument_get_selection_start_offset(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domdocument_get_selection_start_offset_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_start_offset_delegate cfx_domdocument_get_selection_start_offset;

        // CFX_EXPORT cef_domnode_t* cfx_domdocument_get_selection_end_node(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_selection_end_node_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_end_node_delegate cfx_domdocument_get_selection_end_node;

        // CFX_EXPORT int cfx_domdocument_get_selection_end_offset(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domdocument_get_selection_end_offset_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_end_offset_delegate cfx_domdocument_get_selection_end_offset;

        // CFX_EXPORT cef_string_userfree_t cfx_domdocument_get_selection_as_markup(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_selection_as_markup_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_as_markup_delegate cfx_domdocument_get_selection_as_markup;

        // CFX_EXPORT cef_string_userfree_t cfx_domdocument_get_selection_as_text(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_selection_as_text_delegate(IntPtr self);
        public static cfx_domdocument_get_selection_as_text_delegate cfx_domdocument_get_selection_as_text;

        // CFX_EXPORT cef_string_userfree_t cfx_domdocument_get_base_url(cef_domdocument_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_base_url_delegate(IntPtr self);
        public static cfx_domdocument_get_base_url_delegate cfx_domdocument_get_base_url;

        // CFX_EXPORT cef_string_userfree_t cfx_domdocument_get_complete_url(cef_domdocument_t* self, char16 *partialURL_str, int partialURL_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domdocument_get_complete_url_delegate(IntPtr self, IntPtr partialURL_str, int partialURL_length);
        public static cfx_domdocument_get_complete_url_delegate cfx_domdocument_get_complete_url;


        // CfxDomEvent

        // CFX_EXPORT cef_string_userfree_t cfx_domevent_get_type(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domevent_get_type_delegate(IntPtr self);
        public static cfx_domevent_get_type_delegate cfx_domevent_get_type;

        // CFX_EXPORT cef_dom_event_category_t cfx_domevent_get_category(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxDomEventCategory cfx_domevent_get_category_delegate(IntPtr self);
        public static cfx_domevent_get_category_delegate cfx_domevent_get_category;

        // CFX_EXPORT cef_dom_event_phase_t cfx_domevent_get_phase(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxDomEventPhase cfx_domevent_get_phase_delegate(IntPtr self);
        public static cfx_domevent_get_phase_delegate cfx_domevent_get_phase;

        // CFX_EXPORT int cfx_domevent_can_bubble(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domevent_can_bubble_delegate(IntPtr self);
        public static cfx_domevent_can_bubble_delegate cfx_domevent_can_bubble;

        // CFX_EXPORT int cfx_domevent_can_cancel(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domevent_can_cancel_delegate(IntPtr self);
        public static cfx_domevent_can_cancel_delegate cfx_domevent_can_cancel;

        // CFX_EXPORT cef_domdocument_t* cfx_domevent_get_document(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domevent_get_document_delegate(IntPtr self);
        public static cfx_domevent_get_document_delegate cfx_domevent_get_document;

        // CFX_EXPORT cef_domnode_t* cfx_domevent_get_target(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domevent_get_target_delegate(IntPtr self);
        public static cfx_domevent_get_target_delegate cfx_domevent_get_target;

        // CFX_EXPORT cef_domnode_t* cfx_domevent_get_current_target(cef_domevent_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domevent_get_current_target_delegate(IntPtr self);
        public static cfx_domevent_get_current_target_delegate cfx_domevent_get_current_target;


        // CfxDomEventListener

        // CFX_EXPORT cfx_domevent_listener_t* cfx_domevent_listener_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_domevent_listener_ctor;
        public static cfx_get_gc_handle_delegate cfx_domevent_listener_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_domevent_listener_activate_callback;

        // handle_event
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_domevent_listener_handle_event_delegate(IntPtr gcHandlePtr, IntPtr @event);
        public static cfx_domevent_listener_handle_event_delegate cfx_domevent_listener_handle_event;


        // CfxDomNode

        // CFX_EXPORT cef_dom_node_type_t cfx_domnode_get_type(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxDomNodeType cfx_domnode_get_type_delegate(IntPtr self);
        public static cfx_domnode_get_type_delegate cfx_domnode_get_type;

        // CFX_EXPORT int cfx_domnode_is_text(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_is_text_delegate(IntPtr self);
        public static cfx_domnode_is_text_delegate cfx_domnode_is_text;

        // CFX_EXPORT int cfx_domnode_is_element(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_is_element_delegate(IntPtr self);
        public static cfx_domnode_is_element_delegate cfx_domnode_is_element;

        // CFX_EXPORT int cfx_domnode_is_editable(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_is_editable_delegate(IntPtr self);
        public static cfx_domnode_is_editable_delegate cfx_domnode_is_editable;

        // CFX_EXPORT int cfx_domnode_is_form_control_element(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_is_form_control_element_delegate(IntPtr self);
        public static cfx_domnode_is_form_control_element_delegate cfx_domnode_is_form_control_element;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_form_control_element_type(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_form_control_element_type_delegate(IntPtr self);
        public static cfx_domnode_get_form_control_element_type_delegate cfx_domnode_get_form_control_element_type;

        // CFX_EXPORT int cfx_domnode_is_same(cef_domnode_t* self, cef_domnode_t* that)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_is_same_delegate(IntPtr self, IntPtr that);
        public static cfx_domnode_is_same_delegate cfx_domnode_is_same;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_name(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_name_delegate(IntPtr self);
        public static cfx_domnode_get_name_delegate cfx_domnode_get_name;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_value(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_value_delegate(IntPtr self);
        public static cfx_domnode_get_value_delegate cfx_domnode_get_value;

        // CFX_EXPORT int cfx_domnode_set_value(cef_domnode_t* self, char16 *value_str, int value_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_set_value_delegate(IntPtr self, IntPtr value_str, int value_length);
        public static cfx_domnode_set_value_delegate cfx_domnode_set_value;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_as_markup(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_as_markup_delegate(IntPtr self);
        public static cfx_domnode_get_as_markup_delegate cfx_domnode_get_as_markup;

        // CFX_EXPORT cef_domdocument_t* cfx_domnode_get_document(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_document_delegate(IntPtr self);
        public static cfx_domnode_get_document_delegate cfx_domnode_get_document;

        // CFX_EXPORT cef_domnode_t* cfx_domnode_get_parent(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_parent_delegate(IntPtr self);
        public static cfx_domnode_get_parent_delegate cfx_domnode_get_parent;

        // CFX_EXPORT cef_domnode_t* cfx_domnode_get_previous_sibling(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_previous_sibling_delegate(IntPtr self);
        public static cfx_domnode_get_previous_sibling_delegate cfx_domnode_get_previous_sibling;

        // CFX_EXPORT cef_domnode_t* cfx_domnode_get_next_sibling(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_next_sibling_delegate(IntPtr self);
        public static cfx_domnode_get_next_sibling_delegate cfx_domnode_get_next_sibling;

        // CFX_EXPORT int cfx_domnode_has_children(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_has_children_delegate(IntPtr self);
        public static cfx_domnode_has_children_delegate cfx_domnode_has_children;

        // CFX_EXPORT cef_domnode_t* cfx_domnode_get_first_child(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_first_child_delegate(IntPtr self);
        public static cfx_domnode_get_first_child_delegate cfx_domnode_get_first_child;

        // CFX_EXPORT cef_domnode_t* cfx_domnode_get_last_child(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_last_child_delegate(IntPtr self);
        public static cfx_domnode_get_last_child_delegate cfx_domnode_get_last_child;

        // CFX_EXPORT void cfx_domnode_add_event_listener(cef_domnode_t* self, char16 *eventType_str, int eventType_length, cef_domevent_listener_t* listener, int useCapture)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_domnode_add_event_listener_delegate(IntPtr self, IntPtr eventType_str, int eventType_length, IntPtr listener, int useCapture);
        public static cfx_domnode_add_event_listener_delegate cfx_domnode_add_event_listener;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_element_tag_name(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_element_tag_name_delegate(IntPtr self);
        public static cfx_domnode_get_element_tag_name_delegate cfx_domnode_get_element_tag_name;

        // CFX_EXPORT int cfx_domnode_has_element_attributes(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_has_element_attributes_delegate(IntPtr self);
        public static cfx_domnode_has_element_attributes_delegate cfx_domnode_has_element_attributes;

        // CFX_EXPORT int cfx_domnode_has_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_has_element_attribute_delegate(IntPtr self, IntPtr attrName_str, int attrName_length);
        public static cfx_domnode_has_element_attribute_delegate cfx_domnode_has_element_attribute;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_element_attribute_delegate(IntPtr self, IntPtr attrName_str, int attrName_length);
        public static cfx_domnode_get_element_attribute_delegate cfx_domnode_get_element_attribute;

        // CFX_EXPORT void cfx_domnode_get_element_attributes(cef_domnode_t* self, cef_string_map_t attrMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_domnode_get_element_attributes_delegate(IntPtr self, IntPtr attrMap);
        public static cfx_domnode_get_element_attributes_delegate cfx_domnode_get_element_attributes;

        // CFX_EXPORT int cfx_domnode_set_element_attribute(cef_domnode_t* self, char16 *attrName_str, int attrName_length, char16 *value_str, int value_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_domnode_set_element_attribute_delegate(IntPtr self, IntPtr attrName_str, int attrName_length, IntPtr value_str, int value_length);
        public static cfx_domnode_set_element_attribute_delegate cfx_domnode_set_element_attribute;

        // CFX_EXPORT cef_string_userfree_t cfx_domnode_get_element_inner_text(cef_domnode_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_domnode_get_element_inner_text_delegate(IntPtr self);
        public static cfx_domnode_get_element_inner_text_delegate cfx_domnode_get_element_inner_text;


        // CfxDomVisitor

        // CFX_EXPORT cfx_domvisitor_t* cfx_domvisitor_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_domvisitor_ctor;
        public static cfx_get_gc_handle_delegate cfx_domvisitor_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_domvisitor_activate_callback;

        // visit
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_domvisitor_visit_delegate(IntPtr gcHandlePtr, IntPtr document);
        public static cfx_domvisitor_visit_delegate cfx_domvisitor_visit;


        // CfxDownloadHandler

        // CFX_EXPORT cfx_download_handler_t* cfx_download_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_download_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_download_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_download_handler_activate_callback;

        // on_before_download
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_download_handler_on_before_download_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr download_item, IntPtr suggested_name_str, int suggested_name_length, IntPtr callback);
        public static cfx_download_handler_on_before_download_delegate cfx_download_handler_on_before_download;

        // on_download_updated
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_download_handler_on_download_updated_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr download_item, IntPtr callback);
        public static cfx_download_handler_on_download_updated_delegate cfx_download_handler_on_download_updated;


        // CfxDownloadItem

        // CFX_EXPORT int cfx_download_item_is_valid(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_download_item_is_valid_delegate(IntPtr self);
        public static cfx_download_item_is_valid_delegate cfx_download_item_is_valid;

        // CFX_EXPORT int cfx_download_item_is_in_progress(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_download_item_is_in_progress_delegate(IntPtr self);
        public static cfx_download_item_is_in_progress_delegate cfx_download_item_is_in_progress;

        // CFX_EXPORT int cfx_download_item_is_complete(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_download_item_is_complete_delegate(IntPtr self);
        public static cfx_download_item_is_complete_delegate cfx_download_item_is_complete;

        // CFX_EXPORT int cfx_download_item_is_canceled(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_download_item_is_canceled_delegate(IntPtr self);
        public static cfx_download_item_is_canceled_delegate cfx_download_item_is_canceled;

        // CFX_EXPORT int64 cfx_download_item_get_current_speed(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_download_item_get_current_speed_delegate(IntPtr self);
        public static cfx_download_item_get_current_speed_delegate cfx_download_item_get_current_speed;

        // CFX_EXPORT int cfx_download_item_get_percent_complete(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_download_item_get_percent_complete_delegate(IntPtr self);
        public static cfx_download_item_get_percent_complete_delegate cfx_download_item_get_percent_complete;

        // CFX_EXPORT int64 cfx_download_item_get_total_bytes(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_download_item_get_total_bytes_delegate(IntPtr self);
        public static cfx_download_item_get_total_bytes_delegate cfx_download_item_get_total_bytes;

        // CFX_EXPORT int64 cfx_download_item_get_received_bytes(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_download_item_get_received_bytes_delegate(IntPtr self);
        public static cfx_download_item_get_received_bytes_delegate cfx_download_item_get_received_bytes;

        // CFX_EXPORT cef_time_t* cfx_download_item_get_start_time(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_start_time_delegate(IntPtr self);
        public static cfx_download_item_get_start_time_delegate cfx_download_item_get_start_time;

        // CFX_EXPORT cef_time_t* cfx_download_item_get_end_time(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_end_time_delegate(IntPtr self);
        public static cfx_download_item_get_end_time_delegate cfx_download_item_get_end_time;

        // CFX_EXPORT cef_string_userfree_t cfx_download_item_get_full_path(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_full_path_delegate(IntPtr self);
        public static cfx_download_item_get_full_path_delegate cfx_download_item_get_full_path;

        // CFX_EXPORT uint32 cfx_download_item_get_id(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate uint cfx_download_item_get_id_delegate(IntPtr self);
        public static cfx_download_item_get_id_delegate cfx_download_item_get_id;

        // CFX_EXPORT cef_string_userfree_t cfx_download_item_get_url(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_url_delegate(IntPtr self);
        public static cfx_download_item_get_url_delegate cfx_download_item_get_url;

        // CFX_EXPORT cef_string_userfree_t cfx_download_item_get_suggested_file_name(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_suggested_file_name_delegate(IntPtr self);
        public static cfx_download_item_get_suggested_file_name_delegate cfx_download_item_get_suggested_file_name;

        // CFX_EXPORT cef_string_userfree_t cfx_download_item_get_content_disposition(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_content_disposition_delegate(IntPtr self);
        public static cfx_download_item_get_content_disposition_delegate cfx_download_item_get_content_disposition;

        // CFX_EXPORT cef_string_userfree_t cfx_download_item_get_mime_type(cef_download_item_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_download_item_get_mime_type_delegate(IntPtr self);
        public static cfx_download_item_get_mime_type_delegate cfx_download_item_get_mime_type;


        // CfxDownloadItemCallback

        // CFX_EXPORT void cfx_download_item_callback_cancel(cef_download_item_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_download_item_callback_cancel_delegate(IntPtr self);
        public static cfx_download_item_callback_cancel_delegate cfx_download_item_callback_cancel;


        // CfxDragData

        // CFX_EXPORT int cfx_drag_data_is_link(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_drag_data_is_link_delegate(IntPtr self);
        public static cfx_drag_data_is_link_delegate cfx_drag_data_is_link;

        // CFX_EXPORT int cfx_drag_data_is_fragment(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_drag_data_is_fragment_delegate(IntPtr self);
        public static cfx_drag_data_is_fragment_delegate cfx_drag_data_is_fragment;

        // CFX_EXPORT int cfx_drag_data_is_file(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_drag_data_is_file_delegate(IntPtr self);
        public static cfx_drag_data_is_file_delegate cfx_drag_data_is_file;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_link_url(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_link_url_delegate(IntPtr self);
        public static cfx_drag_data_get_link_url_delegate cfx_drag_data_get_link_url;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_link_title(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_link_title_delegate(IntPtr self);
        public static cfx_drag_data_get_link_title_delegate cfx_drag_data_get_link_title;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_link_metadata(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_link_metadata_delegate(IntPtr self);
        public static cfx_drag_data_get_link_metadata_delegate cfx_drag_data_get_link_metadata;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_fragment_text(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_fragment_text_delegate(IntPtr self);
        public static cfx_drag_data_get_fragment_text_delegate cfx_drag_data_get_fragment_text;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_fragment_html(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_fragment_html_delegate(IntPtr self);
        public static cfx_drag_data_get_fragment_html_delegate cfx_drag_data_get_fragment_html;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_fragment_base_url(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_fragment_base_url_delegate(IntPtr self);
        public static cfx_drag_data_get_fragment_base_url_delegate cfx_drag_data_get_fragment_base_url;

        // CFX_EXPORT cef_string_userfree_t cfx_drag_data_get_file_name(cef_drag_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_drag_data_get_file_name_delegate(IntPtr self);
        public static cfx_drag_data_get_file_name_delegate cfx_drag_data_get_file_name;

        // CFX_EXPORT int cfx_drag_data_get_file_names(cef_drag_data_t* self, cef_string_list_t names)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_drag_data_get_file_names_delegate(IntPtr self, IntPtr names);
        public static cfx_drag_data_get_file_names_delegate cfx_drag_data_get_file_names;


        // CfxDragHandler

        // CFX_EXPORT cfx_drag_handler_t* cfx_drag_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_drag_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_drag_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_drag_handler_activate_callback;

        // on_drag_enter
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_drag_handler_on_drag_enter_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr dragData, CfxDragOperationsMask mask);
        public static cfx_drag_handler_on_drag_enter_delegate cfx_drag_handler_on_drag_enter;


        // CfxEndTracingCallback

        // CFX_EXPORT void cfx_end_tracing_callback_on_end_tracing_complete(cef_end_tracing_callback_t* self, char16 *tracing_file_str, int tracing_file_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_end_tracing_callback_on_end_tracing_complete_delegate(IntPtr self, IntPtr tracing_file_str, int tracing_file_length);
        public static cfx_end_tracing_callback_on_end_tracing_complete_delegate cfx_end_tracing_callback_on_end_tracing_complete;


        // CfxFileDialogCallback

        // CFX_EXPORT void cfx_file_dialog_callback_cont(cef_file_dialog_callback_t* self, cef_string_list_t file_paths)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_file_dialog_callback_cont_delegate(IntPtr self, IntPtr file_paths);
        public static cfx_file_dialog_callback_cont_delegate cfx_file_dialog_callback_cont;

        // CFX_EXPORT void cfx_file_dialog_callback_cancel(cef_file_dialog_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_file_dialog_callback_cancel_delegate(IntPtr self);
        public static cfx_file_dialog_callback_cancel_delegate cfx_file_dialog_callback_cancel;


        // CfxFocusHandler

        // CFX_EXPORT cfx_focus_handler_t* cfx_focus_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_focus_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_focus_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_focus_handler_activate_callback;

        // on_take_focus
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_focus_handler_on_take_focus_delegate(IntPtr gcHandlePtr, IntPtr browser, int next);
        public static cfx_focus_handler_on_take_focus_delegate cfx_focus_handler_on_take_focus;

        // on_set_focus
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_focus_handler_on_set_focus_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxFocusSource source);
        public static cfx_focus_handler_on_set_focus_delegate cfx_focus_handler_on_set_focus;

        // on_got_focus
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_focus_handler_on_got_focus_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_focus_handler_on_got_focus_delegate cfx_focus_handler_on_got_focus;


        // CfxFrame

        // CFX_EXPORT int cfx_frame_is_valid(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_frame_is_valid_delegate(IntPtr self);
        public static cfx_frame_is_valid_delegate cfx_frame_is_valid;

        // CFX_EXPORT void cfx_frame_undo(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_undo_delegate(IntPtr self);
        public static cfx_frame_undo_delegate cfx_frame_undo;

        // CFX_EXPORT void cfx_frame_redo(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_redo_delegate(IntPtr self);
        public static cfx_frame_redo_delegate cfx_frame_redo;

        // CFX_EXPORT void cfx_frame_cut(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_cut_delegate(IntPtr self);
        public static cfx_frame_cut_delegate cfx_frame_cut;

        // CFX_EXPORT void cfx_frame_copy(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_copy_delegate(IntPtr self);
        public static cfx_frame_copy_delegate cfx_frame_copy;

        // CFX_EXPORT void cfx_frame_paste(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_paste_delegate(IntPtr self);
        public static cfx_frame_paste_delegate cfx_frame_paste;

        // CFX_EXPORT void cfx_frame_del(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_del_delegate(IntPtr self);
        public static cfx_frame_del_delegate cfx_frame_del;

        // CFX_EXPORT void cfx_frame_select_all(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_select_all_delegate(IntPtr self);
        public static cfx_frame_select_all_delegate cfx_frame_select_all;

        // CFX_EXPORT void cfx_frame_view_source(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_view_source_delegate(IntPtr self);
        public static cfx_frame_view_source_delegate cfx_frame_view_source;

        // CFX_EXPORT void cfx_frame_get_source(cef_frame_t* self, cef_string_visitor_t* visitor)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_get_source_delegate(IntPtr self, IntPtr visitor);
        public static cfx_frame_get_source_delegate cfx_frame_get_source;

        // CFX_EXPORT void cfx_frame_get_text(cef_frame_t* self, cef_string_visitor_t* visitor)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_get_text_delegate(IntPtr self, IntPtr visitor);
        public static cfx_frame_get_text_delegate cfx_frame_get_text;

        // CFX_EXPORT void cfx_frame_load_request(cef_frame_t* self, cef_request_t* request)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_load_request_delegate(IntPtr self, IntPtr request);
        public static cfx_frame_load_request_delegate cfx_frame_load_request;

        // CFX_EXPORT void cfx_frame_load_url(cef_frame_t* self, char16 *url_str, int url_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_load_url_delegate(IntPtr self, IntPtr url_str, int url_length);
        public static cfx_frame_load_url_delegate cfx_frame_load_url;

        // CFX_EXPORT void cfx_frame_load_string(cef_frame_t* self, char16 *string_val_str, int string_val_length, char16 *url_str, int url_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_load_string_delegate(IntPtr self, IntPtr string_val_str, int string_val_length, IntPtr url_str, int url_length);
        public static cfx_frame_load_string_delegate cfx_frame_load_string;

        // CFX_EXPORT void cfx_frame_execute_java_script(cef_frame_t* self, char16 *code_str, int code_length, char16 *script_url_str, int script_url_length, int start_line)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_execute_java_script_delegate(IntPtr self, IntPtr code_str, int code_length, IntPtr script_url_str, int script_url_length, int start_line);
        public static cfx_frame_execute_java_script_delegate cfx_frame_execute_java_script;

        // CFX_EXPORT int cfx_frame_is_main(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_frame_is_main_delegate(IntPtr self);
        public static cfx_frame_is_main_delegate cfx_frame_is_main;

        // CFX_EXPORT int cfx_frame_is_focused(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_frame_is_focused_delegate(IntPtr self);
        public static cfx_frame_is_focused_delegate cfx_frame_is_focused;

        // CFX_EXPORT cef_string_userfree_t cfx_frame_get_name(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_frame_get_name_delegate(IntPtr self);
        public static cfx_frame_get_name_delegate cfx_frame_get_name;

        // CFX_EXPORT int64 cfx_frame_get_identifier(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_frame_get_identifier_delegate(IntPtr self);
        public static cfx_frame_get_identifier_delegate cfx_frame_get_identifier;

        // CFX_EXPORT cef_frame_t* cfx_frame_get_parent(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_frame_get_parent_delegate(IntPtr self);
        public static cfx_frame_get_parent_delegate cfx_frame_get_parent;

        // CFX_EXPORT cef_string_userfree_t cfx_frame_get_url(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_frame_get_url_delegate(IntPtr self);
        public static cfx_frame_get_url_delegate cfx_frame_get_url;

        // CFX_EXPORT cef_browser_t* cfx_frame_get_browser(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_frame_get_browser_delegate(IntPtr self);
        public static cfx_frame_get_browser_delegate cfx_frame_get_browser;

        // CFX_EXPORT cef_v8context_t* cfx_frame_get_v8context(cef_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_frame_get_v8context_delegate(IntPtr self);
        public static cfx_frame_get_v8context_delegate cfx_frame_get_v8context;

        // CFX_EXPORT void cfx_frame_visit_dom(cef_frame_t* self, cef_domvisitor_t* visitor)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_frame_visit_dom_delegate(IntPtr self, IntPtr visitor);
        public static cfx_frame_visit_dom_delegate cfx_frame_visit_dom;


        // CfxGeolocationCallback

        // CFX_EXPORT void cfx_geolocation_callback_cont(cef_geolocation_callback_t* self, int allow)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_geolocation_callback_cont_delegate(IntPtr self, int allow);
        public static cfx_geolocation_callback_cont_delegate cfx_geolocation_callback_cont;


        // CfxGeolocationHandler

        // CFX_EXPORT cfx_geolocation_handler_t* cfx_geolocation_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_geolocation_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_geolocation_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_geolocation_handler_activate_callback;

        // on_request_geolocation_permission
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_geolocation_handler_on_request_geolocation_permission_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr requesting_url_str, int requesting_url_length, int request_id, IntPtr callback);
        public static cfx_geolocation_handler_on_request_geolocation_permission_delegate cfx_geolocation_handler_on_request_geolocation_permission;

        // on_cancel_geolocation_permission
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_geolocation_handler_on_cancel_geolocation_permission_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr requesting_url_str, int requesting_url_length, int request_id);
        public static cfx_geolocation_handler_on_cancel_geolocation_permission_delegate cfx_geolocation_handler_on_cancel_geolocation_permission;


        // CfxGeoposition

        // CFX_EXPORT cef_geoposition_t* cfx_geoposition_ctor()
        public static cfx_ctor_delegate cfx_geoposition_ctor;
        // CFX_EXPORT void cfx_geoposition_dtor(cef_geoposition_t* ptr)
        public static cfx_dtor_delegate cfx_geoposition_dtor;

        // CFX_EXPORT void cfx_geoposition_copy_to_native(cef_geoposition_t* self, double latitude, double longitude, double altitude, double accuracy, double altitude_accuracy, double heading, double speed, cef_time_t* timestamp, cef_geoposition_error_code_t error_code, char16 *error_message_str, int error_message_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_geoposition_copy_to_native_delegate(IntPtr self, double latitude, double longitude, double altitude, double accuracy, double altitude_accuracy, double heading, double speed, IntPtr timestamp, CfxGeopositionErrorCode error_code, IntPtr error_message_str, int error_message_length);
        public static cfx_geoposition_copy_to_native_delegate cfx_geoposition_copy_to_native;
        // CFX_EXPORT void cfx_geoposition_copy_to_managed(cef_geoposition_t* self, double* latitude, double* longitude, double* altitude, double* accuracy, double* altitude_accuracy, double* heading, double* speed, cef_time_t** timestamp, cef_geoposition_error_code_t* error_code, char16 **error_message_str, int *error_message_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_geoposition_copy_to_managed_delegate(IntPtr self, out double latitude, out double longitude, out double altitude, out double accuracy, out double altitude_accuracy, out double heading, out double speed, out IntPtr timestamp, out CfxGeopositionErrorCode error_code, out IntPtr error_message_str, out int error_message_length);
        public static cfx_geoposition_copy_to_managed_delegate cfx_geoposition_copy_to_managed;


        // CfxGetGeolocationCallback

        // CFX_EXPORT cfx_get_geolocation_callback_t* cfx_get_geolocation_callback_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_get_geolocation_callback_ctor;
        public static cfx_get_gc_handle_delegate cfx_get_geolocation_callback_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_get_geolocation_callback_activate_callback;

        // on_location_update
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_get_geolocation_callback_on_location_update_delegate(IntPtr gcHandlePtr, IntPtr position);
        public static cfx_get_geolocation_callback_on_location_update_delegate cfx_get_geolocation_callback_on_location_update;


        // CfxJsDialogCallback

        // CFX_EXPORT void cfx_jsdialog_callback_cont(cef_jsdialog_callback_t* self, int success, char16 *user_input_str, int user_input_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_jsdialog_callback_cont_delegate(IntPtr self, int success, IntPtr user_input_str, int user_input_length);
        public static cfx_jsdialog_callback_cont_delegate cfx_jsdialog_callback_cont;


        // CfxJsDialogHandler

        // CFX_EXPORT cfx_jsdialog_handler_t* cfx_jsdialog_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_jsdialog_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_jsdialog_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_jsdialog_handler_activate_callback;

        // on_jsdialog
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_jsdialog_handler_on_jsdialog_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr origin_url_str, int origin_url_length, IntPtr accept_lang_str, int accept_lang_length, CfxJsDialogType dialog_type, IntPtr message_text_str, int message_text_length, IntPtr default_prompt_text_str, int default_prompt_text_length, IntPtr callback, out int suppress_message);
        public static cfx_jsdialog_handler_on_jsdialog_delegate cfx_jsdialog_handler_on_jsdialog;

        // on_before_unload_dialog
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_jsdialog_handler_on_before_unload_dialog_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr message_text_str, int message_text_length, int is_reload, IntPtr callback);
        public static cfx_jsdialog_handler_on_before_unload_dialog_delegate cfx_jsdialog_handler_on_before_unload_dialog;

        // on_reset_dialog_state
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_jsdialog_handler_on_reset_dialog_state_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_jsdialog_handler_on_reset_dialog_state_delegate cfx_jsdialog_handler_on_reset_dialog_state;

        // on_dialog_closed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_jsdialog_handler_on_dialog_closed_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_jsdialog_handler_on_dialog_closed_delegate cfx_jsdialog_handler_on_dialog_closed;


        // CfxKeyEvent

        // CFX_EXPORT cef_key_event_t* cfx_key_event_ctor()
        public static cfx_ctor_delegate cfx_key_event_ctor;
        // CFX_EXPORT void cfx_key_event_dtor(cef_key_event_t* ptr)
        public static cfx_dtor_delegate cfx_key_event_dtor;

        // CFX_EXPORT void cfx_key_event_copy_to_native(cef_key_event_t* self, cef_key_event_type_t type, uint32 modifiers, int windows_key_code, int native_key_code, int is_system_key, char16 character, char16 unmodified_character, int focus_on_editable_field)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_key_event_copy_to_native_delegate(IntPtr self, CfxKeyEventType type, uint modifiers, int windows_key_code, int native_key_code, int is_system_key, short character, short unmodified_character, int focus_on_editable_field);
        public static cfx_key_event_copy_to_native_delegate cfx_key_event_copy_to_native;
        // CFX_EXPORT void cfx_key_event_copy_to_managed(cef_key_event_t* self, cef_key_event_type_t* type, uint32* modifiers, int* windows_key_code, int* native_key_code, int* is_system_key, char16* character, char16* unmodified_character, int* focus_on_editable_field)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_key_event_copy_to_managed_delegate(IntPtr self, out CfxKeyEventType type, out uint modifiers, out int windows_key_code, out int native_key_code, out int is_system_key, out short character, out short unmodified_character, out int focus_on_editable_field);
        public static cfx_key_event_copy_to_managed_delegate cfx_key_event_copy_to_managed;


        // CfxKeyboardHandler

        // CFX_EXPORT cfx_keyboard_handler_t* cfx_keyboard_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_keyboard_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_keyboard_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_keyboard_handler_activate_callback;

        // on_pre_key_event
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_keyboard_handler_on_pre_key_event_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr @event, IntPtr os_event, out int is_keyboard_shortcut);
        public static cfx_keyboard_handler_on_pre_key_event_delegate cfx_keyboard_handler_on_pre_key_event;

        // on_key_event
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_keyboard_handler_on_key_event_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr @event, IntPtr os_event);
        public static cfx_keyboard_handler_on_key_event_delegate cfx_keyboard_handler_on_key_event;


        // CfxLifeSpanHandler

        // CFX_EXPORT cfx_life_span_handler_t* cfx_life_span_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_life_span_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_life_span_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_life_span_handler_activate_callback;

        // on_before_popup
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_life_span_handler_on_before_popup_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr target_url_str, int target_url_length, IntPtr target_frame_name_str, int target_frame_name_length, IntPtr popupFeatures, IntPtr windowInfo, out IntPtr client, IntPtr settings, out int no_javascript_access);
        public static cfx_life_span_handler_on_before_popup_delegate cfx_life_span_handler_on_before_popup;

        // on_after_created
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_life_span_handler_on_after_created_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_life_span_handler_on_after_created_delegate cfx_life_span_handler_on_after_created;

        // run_modal
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_life_span_handler_run_modal_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser);
        public static cfx_life_span_handler_run_modal_delegate cfx_life_span_handler_run_modal;

        // do_close
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_life_span_handler_do_close_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser);
        public static cfx_life_span_handler_do_close_delegate cfx_life_span_handler_do_close;

        // on_before_close
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_life_span_handler_on_before_close_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_life_span_handler_on_before_close_delegate cfx_life_span_handler_on_before_close;


        // CfxListValue

        // CEF_EXPORT cef_list_value_t* cef_list_value_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_create_delegate();
        public static cfx_list_value_create_delegate cfx_list_value_create;

        // CFX_EXPORT int cfx_list_value_is_valid(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_is_valid_delegate(IntPtr self);
        public static cfx_list_value_is_valid_delegate cfx_list_value_is_valid;

        // CFX_EXPORT int cfx_list_value_is_owned(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_is_owned_delegate(IntPtr self);
        public static cfx_list_value_is_owned_delegate cfx_list_value_is_owned;

        // CFX_EXPORT int cfx_list_value_is_read_only(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_is_read_only_delegate(IntPtr self);
        public static cfx_list_value_is_read_only_delegate cfx_list_value_is_read_only;

        // CFX_EXPORT cef_list_value_t* cfx_list_value_copy(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_copy_delegate(IntPtr self);
        public static cfx_list_value_copy_delegate cfx_list_value_copy;

        // CFX_EXPORT int cfx_list_value_set_size(cef_list_value_t* self, int size)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_size_delegate(IntPtr self, int size);
        public static cfx_list_value_set_size_delegate cfx_list_value_set_size;

        // CFX_EXPORT int cfx_list_value_get_size(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_get_size_delegate(IntPtr self);
        public static cfx_list_value_get_size_delegate cfx_list_value_get_size;

        // CFX_EXPORT int cfx_list_value_clear(cef_list_value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_clear_delegate(IntPtr self);
        public static cfx_list_value_clear_delegate cfx_list_value_clear;

        // CFX_EXPORT int cfx_list_value_remove(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_remove_delegate(IntPtr self, int index);
        public static cfx_list_value_remove_delegate cfx_list_value_remove;

        // CFX_EXPORT cef_value_type_t cfx_list_value_get_type(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxValueType cfx_list_value_get_type_delegate(IntPtr self, int index);
        public static cfx_list_value_get_type_delegate cfx_list_value_get_type;

        // CFX_EXPORT int cfx_list_value_get_bool(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_get_bool_delegate(IntPtr self, int index);
        public static cfx_list_value_get_bool_delegate cfx_list_value_get_bool;

        // CFX_EXPORT int cfx_list_value_get_int(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_get_int_delegate(IntPtr self, int index);
        public static cfx_list_value_get_int_delegate cfx_list_value_get_int;

        // CFX_EXPORT double cfx_list_value_get_double(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate double cfx_list_value_get_double_delegate(IntPtr self, int index);
        public static cfx_list_value_get_double_delegate cfx_list_value_get_double;

        // CFX_EXPORT cef_string_userfree_t cfx_list_value_get_string(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_get_string_delegate(IntPtr self, int index);
        public static cfx_list_value_get_string_delegate cfx_list_value_get_string;

        // CFX_EXPORT cef_binary_value_t* cfx_list_value_get_binary(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_get_binary_delegate(IntPtr self, int index);
        public static cfx_list_value_get_binary_delegate cfx_list_value_get_binary;

        // CFX_EXPORT cef_dictionary_value_t* cfx_list_value_get_dictionary(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_get_dictionary_delegate(IntPtr self, int index);
        public static cfx_list_value_get_dictionary_delegate cfx_list_value_get_dictionary;

        // CFX_EXPORT cef_list_value_t* cfx_list_value_get_list(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_list_value_get_list_delegate(IntPtr self, int index);
        public static cfx_list_value_get_list_delegate cfx_list_value_get_list;

        // CFX_EXPORT int cfx_list_value_set_null(cef_list_value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_null_delegate(IntPtr self, int index);
        public static cfx_list_value_set_null_delegate cfx_list_value_set_null;

        // CFX_EXPORT int cfx_list_value_set_bool(cef_list_value_t* self, int index, int value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_bool_delegate(IntPtr self, int index, int value);
        public static cfx_list_value_set_bool_delegate cfx_list_value_set_bool;

        // CFX_EXPORT int cfx_list_value_set_int(cef_list_value_t* self, int index, int value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_int_delegate(IntPtr self, int index, int value);
        public static cfx_list_value_set_int_delegate cfx_list_value_set_int;

        // CFX_EXPORT int cfx_list_value_set_double(cef_list_value_t* self, int index, double value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_double_delegate(IntPtr self, int index, double value);
        public static cfx_list_value_set_double_delegate cfx_list_value_set_double;

        // CFX_EXPORT int cfx_list_value_set_string(cef_list_value_t* self, int index, char16 *value_str, int value_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_string_delegate(IntPtr self, int index, IntPtr value_str, int value_length);
        public static cfx_list_value_set_string_delegate cfx_list_value_set_string;

        // CFX_EXPORT int cfx_list_value_set_binary(cef_list_value_t* self, int index, cef_binary_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_binary_delegate(IntPtr self, int index, IntPtr value);
        public static cfx_list_value_set_binary_delegate cfx_list_value_set_binary;

        // CFX_EXPORT int cfx_list_value_set_dictionary(cef_list_value_t* self, int index, cef_dictionary_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_dictionary_delegate(IntPtr self, int index, IntPtr value);
        public static cfx_list_value_set_dictionary_delegate cfx_list_value_set_dictionary;

        // CFX_EXPORT int cfx_list_value_set_list(cef_list_value_t* self, int index, cef_list_value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_list_value_set_list_delegate(IntPtr self, int index, IntPtr value);
        public static cfx_list_value_set_list_delegate cfx_list_value_set_list;


        // CfxLoadHandler

        // CFX_EXPORT cfx_load_handler_t* cfx_load_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_load_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_load_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_load_handler_activate_callback;

        // on_loading_state_change
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_load_handler_on_loading_state_change_delegate(IntPtr gcHandlePtr, IntPtr browser, int isLoading, int canGoBack, int canGoForward);
        public static cfx_load_handler_on_loading_state_change_delegate cfx_load_handler_on_loading_state_change;

        // on_load_start
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_load_handler_on_load_start_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame);
        public static cfx_load_handler_on_load_start_delegate cfx_load_handler_on_load_start;

        // on_load_end
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_load_handler_on_load_end_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, int httpStatusCode);
        public static cfx_load_handler_on_load_end_delegate cfx_load_handler_on_load_end;

        // on_load_error
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_load_handler_on_load_error_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, CfxErrorCode errorCode, IntPtr errorText_str, int errorText_length, IntPtr failedUrl_str, int failedUrl_length);
        public static cfx_load_handler_on_load_error_delegate cfx_load_handler_on_load_error;


        // CfxMenuModel

        // CFX_EXPORT int cfx_menu_model_clear(cef_menu_model_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_clear_delegate(IntPtr self);
        public static cfx_menu_model_clear_delegate cfx_menu_model_clear;

        // CFX_EXPORT int cfx_menu_model_get_count(cef_menu_model_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_count_delegate(IntPtr self);
        public static cfx_menu_model_get_count_delegate cfx_menu_model_get_count;

        // CFX_EXPORT int cfx_menu_model_add_separator(cef_menu_model_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_add_separator_delegate(IntPtr self);
        public static cfx_menu_model_add_separator_delegate cfx_menu_model_add_separator;

        // CFX_EXPORT int cfx_menu_model_add_item(cef_menu_model_t* self, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_add_item_delegate(IntPtr self, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_add_item_delegate cfx_menu_model_add_item;

        // CFX_EXPORT int cfx_menu_model_add_check_item(cef_menu_model_t* self, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_add_check_item_delegate(IntPtr self, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_add_check_item_delegate cfx_menu_model_add_check_item;

        // CFX_EXPORT int cfx_menu_model_add_radio_item(cef_menu_model_t* self, int command_id, char16 *label_str, int label_length, int group_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_add_radio_item_delegate(IntPtr self, int command_id, IntPtr label_str, int label_length, int group_id);
        public static cfx_menu_model_add_radio_item_delegate cfx_menu_model_add_radio_item;

        // CFX_EXPORT cef_menu_model_t* cfx_menu_model_add_sub_menu(cef_menu_model_t* self, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_add_sub_menu_delegate(IntPtr self, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_add_sub_menu_delegate cfx_menu_model_add_sub_menu;

        // CFX_EXPORT int cfx_menu_model_insert_separator_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_insert_separator_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_insert_separator_at_delegate cfx_menu_model_insert_separator_at;

        // CFX_EXPORT int cfx_menu_model_insert_item_at(cef_menu_model_t* self, int index, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_insert_item_at_delegate(IntPtr self, int index, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_insert_item_at_delegate cfx_menu_model_insert_item_at;

        // CFX_EXPORT int cfx_menu_model_insert_check_item_at(cef_menu_model_t* self, int index, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_insert_check_item_at_delegate(IntPtr self, int index, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_insert_check_item_at_delegate cfx_menu_model_insert_check_item_at;

        // CFX_EXPORT int cfx_menu_model_insert_radio_item_at(cef_menu_model_t* self, int index, int command_id, char16 *label_str, int label_length, int group_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_insert_radio_item_at_delegate(IntPtr self, int index, int command_id, IntPtr label_str, int label_length, int group_id);
        public static cfx_menu_model_insert_radio_item_at_delegate cfx_menu_model_insert_radio_item_at;

        // CFX_EXPORT cef_menu_model_t* cfx_menu_model_insert_sub_menu_at(cef_menu_model_t* self, int index, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_insert_sub_menu_at_delegate(IntPtr self, int index, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_insert_sub_menu_at_delegate cfx_menu_model_insert_sub_menu_at;

        // CFX_EXPORT int cfx_menu_model_remove(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_remove_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_remove_delegate cfx_menu_model_remove;

        // CFX_EXPORT int cfx_menu_model_remove_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_remove_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_remove_at_delegate cfx_menu_model_remove_at;

        // CFX_EXPORT int cfx_menu_model_get_index_of(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_index_of_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_get_index_of_delegate cfx_menu_model_get_index_of;

        // CFX_EXPORT int cfx_menu_model_get_command_id_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_command_id_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_get_command_id_at_delegate cfx_menu_model_get_command_id_at;

        // CFX_EXPORT int cfx_menu_model_set_command_id_at(cef_menu_model_t* self, int index, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_command_id_at_delegate(IntPtr self, int index, int command_id);
        public static cfx_menu_model_set_command_id_at_delegate cfx_menu_model_set_command_id_at;

        // CFX_EXPORT cef_string_userfree_t cfx_menu_model_get_label(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_get_label_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_get_label_delegate cfx_menu_model_get_label;

        // CFX_EXPORT cef_string_userfree_t cfx_menu_model_get_label_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_get_label_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_get_label_at_delegate cfx_menu_model_get_label_at;

        // CFX_EXPORT int cfx_menu_model_set_label(cef_menu_model_t* self, int command_id, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_label_delegate(IntPtr self, int command_id, IntPtr label_str, int label_length);
        public static cfx_menu_model_set_label_delegate cfx_menu_model_set_label;

        // CFX_EXPORT int cfx_menu_model_set_label_at(cef_menu_model_t* self, int index, char16 *label_str, int label_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_label_at_delegate(IntPtr self, int index, IntPtr label_str, int label_length);
        public static cfx_menu_model_set_label_at_delegate cfx_menu_model_set_label_at;

        // CFX_EXPORT cef_menu_item_type_t cfx_menu_model_get_type(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxMenuItemType cfx_menu_model_get_type_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_get_type_delegate cfx_menu_model_get_type;

        // CFX_EXPORT cef_menu_item_type_t cfx_menu_model_get_type_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxMenuItemType cfx_menu_model_get_type_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_get_type_at_delegate cfx_menu_model_get_type_at;

        // CFX_EXPORT int cfx_menu_model_get_group_id(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_group_id_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_get_group_id_delegate cfx_menu_model_get_group_id;

        // CFX_EXPORT int cfx_menu_model_get_group_id_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_group_id_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_get_group_id_at_delegate cfx_menu_model_get_group_id_at;

        // CFX_EXPORT int cfx_menu_model_set_group_id(cef_menu_model_t* self, int command_id, int group_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_group_id_delegate(IntPtr self, int command_id, int group_id);
        public static cfx_menu_model_set_group_id_delegate cfx_menu_model_set_group_id;

        // CFX_EXPORT int cfx_menu_model_set_group_id_at(cef_menu_model_t* self, int index, int group_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_group_id_at_delegate(IntPtr self, int index, int group_id);
        public static cfx_menu_model_set_group_id_at_delegate cfx_menu_model_set_group_id_at;

        // CFX_EXPORT cef_menu_model_t* cfx_menu_model_get_sub_menu(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_get_sub_menu_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_get_sub_menu_delegate cfx_menu_model_get_sub_menu;

        // CFX_EXPORT cef_menu_model_t* cfx_menu_model_get_sub_menu_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_menu_model_get_sub_menu_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_get_sub_menu_at_delegate cfx_menu_model_get_sub_menu_at;

        // CFX_EXPORT int cfx_menu_model_is_visible(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_visible_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_is_visible_delegate cfx_menu_model_is_visible;

        // CFX_EXPORT int cfx_menu_model_is_visible_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_visible_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_is_visible_at_delegate cfx_menu_model_is_visible_at;

        // CFX_EXPORT int cfx_menu_model_set_visible(cef_menu_model_t* self, int command_id, int visible)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_visible_delegate(IntPtr self, int command_id, int visible);
        public static cfx_menu_model_set_visible_delegate cfx_menu_model_set_visible;

        // CFX_EXPORT int cfx_menu_model_set_visible_at(cef_menu_model_t* self, int index, int visible)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_visible_at_delegate(IntPtr self, int index, int visible);
        public static cfx_menu_model_set_visible_at_delegate cfx_menu_model_set_visible_at;

        // CFX_EXPORT int cfx_menu_model_is_enabled(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_enabled_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_is_enabled_delegate cfx_menu_model_is_enabled;

        // CFX_EXPORT int cfx_menu_model_is_enabled_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_enabled_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_is_enabled_at_delegate cfx_menu_model_is_enabled_at;

        // CFX_EXPORT int cfx_menu_model_set_enabled(cef_menu_model_t* self, int command_id, int enabled)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_enabled_delegate(IntPtr self, int command_id, int enabled);
        public static cfx_menu_model_set_enabled_delegate cfx_menu_model_set_enabled;

        // CFX_EXPORT int cfx_menu_model_set_enabled_at(cef_menu_model_t* self, int index, int enabled)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_enabled_at_delegate(IntPtr self, int index, int enabled);
        public static cfx_menu_model_set_enabled_at_delegate cfx_menu_model_set_enabled_at;

        // CFX_EXPORT int cfx_menu_model_is_checked(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_checked_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_is_checked_delegate cfx_menu_model_is_checked;

        // CFX_EXPORT int cfx_menu_model_is_checked_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_is_checked_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_is_checked_at_delegate cfx_menu_model_is_checked_at;

        // CFX_EXPORT int cfx_menu_model_set_checked(cef_menu_model_t* self, int command_id, int checked)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_checked_delegate(IntPtr self, int command_id, int @checked);
        public static cfx_menu_model_set_checked_delegate cfx_menu_model_set_checked;

        // CFX_EXPORT int cfx_menu_model_set_checked_at(cef_menu_model_t* self, int index, int checked)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_checked_at_delegate(IntPtr self, int index, int @checked);
        public static cfx_menu_model_set_checked_at_delegate cfx_menu_model_set_checked_at;

        // CFX_EXPORT int cfx_menu_model_has_accelerator(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_has_accelerator_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_has_accelerator_delegate cfx_menu_model_has_accelerator;

        // CFX_EXPORT int cfx_menu_model_has_accelerator_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_has_accelerator_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_has_accelerator_at_delegate cfx_menu_model_has_accelerator_at;

        // CFX_EXPORT int cfx_menu_model_set_accelerator(cef_menu_model_t* self, int command_id, int key_code, int shift_pressed, int ctrl_pressed, int alt_pressed)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_accelerator_delegate(IntPtr self, int command_id, int key_code, int shift_pressed, int ctrl_pressed, int alt_pressed);
        public static cfx_menu_model_set_accelerator_delegate cfx_menu_model_set_accelerator;

        // CFX_EXPORT int cfx_menu_model_set_accelerator_at(cef_menu_model_t* self, int index, int key_code, int shift_pressed, int ctrl_pressed, int alt_pressed)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_set_accelerator_at_delegate(IntPtr self, int index, int key_code, int shift_pressed, int ctrl_pressed, int alt_pressed);
        public static cfx_menu_model_set_accelerator_at_delegate cfx_menu_model_set_accelerator_at;

        // CFX_EXPORT int cfx_menu_model_remove_accelerator(cef_menu_model_t* self, int command_id)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_remove_accelerator_delegate(IntPtr self, int command_id);
        public static cfx_menu_model_remove_accelerator_delegate cfx_menu_model_remove_accelerator;

        // CFX_EXPORT int cfx_menu_model_remove_accelerator_at(cef_menu_model_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_remove_accelerator_at_delegate(IntPtr self, int index);
        public static cfx_menu_model_remove_accelerator_at_delegate cfx_menu_model_remove_accelerator_at;

        // CFX_EXPORT int cfx_menu_model_get_accelerator(cef_menu_model_t* self, int command_id, int* key_code, int* shift_pressed, int* ctrl_pressed, int* alt_pressed)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_accelerator_delegate(IntPtr self, int command_id, out int key_code, out int shift_pressed, out int ctrl_pressed, out int alt_pressed);
        public static cfx_menu_model_get_accelerator_delegate cfx_menu_model_get_accelerator;

        // CFX_EXPORT int cfx_menu_model_get_accelerator_at(cef_menu_model_t* self, int index, int* key_code, int* shift_pressed, int* ctrl_pressed, int* alt_pressed)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_menu_model_get_accelerator_at_delegate(IntPtr self, int index, out int key_code, out int shift_pressed, out int ctrl_pressed, out int alt_pressed);
        public static cfx_menu_model_get_accelerator_at_delegate cfx_menu_model_get_accelerator_at;


        // CfxMouseEvent

        // CFX_EXPORT cef_mouse_event_t* cfx_mouse_event_ctor()
        public static cfx_ctor_delegate cfx_mouse_event_ctor;
        // CFX_EXPORT void cfx_mouse_event_dtor(cef_mouse_event_t* ptr)
        public static cfx_dtor_delegate cfx_mouse_event_dtor;

        // CFX_EXPORT void cfx_mouse_event_copy_to_native(cef_mouse_event_t* self, int x, int y, uint32 modifiers)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_mouse_event_copy_to_native_delegate(IntPtr self, int x, int y, uint modifiers);
        public static cfx_mouse_event_copy_to_native_delegate cfx_mouse_event_copy_to_native;


        // CfxPopupFeatures

        // CFX_EXPORT cef_popup_features_t* cfx_popup_features_ctor()
        public static cfx_ctor_delegate cfx_popup_features_ctor;
        // CFX_EXPORT void cfx_popup_features_dtor(cef_popup_features_t* ptr)
        public static cfx_dtor_delegate cfx_popup_features_dtor;

        // CFX_EXPORT void cfx_popup_features_copy_to_native(cef_popup_features_t* self, int x, int xSet, int y, int ySet, int width, int widthSet, int height, int heightSet, int menuBarVisible, int statusBarVisible, int toolBarVisible, int locationBarVisible, int scrollbarsVisible, int resizable, int fullscreen, int dialog, cef_string_list_t additionalFeatures)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_popup_features_copy_to_native_delegate(IntPtr self, int x, int xSet, int y, int ySet, int width, int widthSet, int height, int heightSet, int menuBarVisible, int statusBarVisible, int toolBarVisible, int locationBarVisible, int scrollbarsVisible, int resizable, int fullscreen, int dialog, IntPtr additionalFeatures);
        public static cfx_popup_features_copy_to_native_delegate cfx_popup_features_copy_to_native;
        // CFX_EXPORT void cfx_popup_features_copy_to_managed(cef_popup_features_t* self, int* x, int* xSet, int* y, int* ySet, int* width, int* widthSet, int* height, int* heightSet, int* menuBarVisible, int* statusBarVisible, int* toolBarVisible, int* locationBarVisible, int* scrollbarsVisible, int* resizable, int* fullscreen, int* dialog, cef_string_list_t* additionalFeatures)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_popup_features_copy_to_managed_delegate(IntPtr self, out int x, out int xSet, out int y, out int ySet, out int width, out int widthSet, out int height, out int heightSet, out int menuBarVisible, out int statusBarVisible, out int toolBarVisible, out int locationBarVisible, out int scrollbarsVisible, out int resizable, out int fullscreen, out int dialog, out IntPtr additionalFeatures);
        public static cfx_popup_features_copy_to_managed_delegate cfx_popup_features_copy_to_managed;


        // CfxPostData

        // CEF_EXPORT cef_post_data_t* cef_post_data_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_post_data_create_delegate();
        public static cfx_post_data_create_delegate cfx_post_data_create;

        // CFX_EXPORT int cfx_post_data_is_read_only(cef_post_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_is_read_only_delegate(IntPtr self);
        public static cfx_post_data_is_read_only_delegate cfx_post_data_is_read_only;

        // CFX_EXPORT int cfx_post_data_get_element_count(cef_post_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_get_element_count_delegate(IntPtr self);
        public static cfx_post_data_get_element_count_delegate cfx_post_data_get_element_count;

        // CFX_EXPORT void cfx_post_data_get_elements(cef_post_data_t* self, int elementsCount, cef_post_data_element_t** elements)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_post_data_get_elements_delegate(IntPtr self, int elementsCount, IntPtr elements);
        public static cfx_post_data_get_elements_delegate cfx_post_data_get_elements;

        // CFX_EXPORT int cfx_post_data_remove_element(cef_post_data_t* self, cef_post_data_element_t* element)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_remove_element_delegate(IntPtr self, IntPtr element);
        public static cfx_post_data_remove_element_delegate cfx_post_data_remove_element;

        // CFX_EXPORT int cfx_post_data_add_element(cef_post_data_t* self, cef_post_data_element_t* element)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_add_element_delegate(IntPtr self, IntPtr element);
        public static cfx_post_data_add_element_delegate cfx_post_data_add_element;

        // CFX_EXPORT void cfx_post_data_remove_elements(cef_post_data_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_post_data_remove_elements_delegate(IntPtr self);
        public static cfx_post_data_remove_elements_delegate cfx_post_data_remove_elements;


        // CfxPostDataElement

        // CEF_EXPORT cef_post_data_element_t* cef_post_data_element_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_post_data_element_create_delegate();
        public static cfx_post_data_element_create_delegate cfx_post_data_element_create;

        // CFX_EXPORT int cfx_post_data_element_is_read_only(cef_post_data_element_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_element_is_read_only_delegate(IntPtr self);
        public static cfx_post_data_element_is_read_only_delegate cfx_post_data_element_is_read_only;

        // CFX_EXPORT void cfx_post_data_element_set_to_empty(cef_post_data_element_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_post_data_element_set_to_empty_delegate(IntPtr self);
        public static cfx_post_data_element_set_to_empty_delegate cfx_post_data_element_set_to_empty;

        // CFX_EXPORT void cfx_post_data_element_set_to_file(cef_post_data_element_t* self, char16 *fileName_str, int fileName_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_post_data_element_set_to_file_delegate(IntPtr self, IntPtr fileName_str, int fileName_length);
        public static cfx_post_data_element_set_to_file_delegate cfx_post_data_element_set_to_file;

        // CFX_EXPORT void cfx_post_data_element_set_to_bytes(cef_post_data_element_t* self, int size, const void* bytes)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_post_data_element_set_to_bytes_delegate(IntPtr self, int size, IntPtr bytes);
        public static cfx_post_data_element_set_to_bytes_delegate cfx_post_data_element_set_to_bytes;

        // CFX_EXPORT cef_postdataelement_type_t cfx_post_data_element_get_type(cef_post_data_element_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxPostdataElementType cfx_post_data_element_get_type_delegate(IntPtr self);
        public static cfx_post_data_element_get_type_delegate cfx_post_data_element_get_type;

        // CFX_EXPORT cef_string_userfree_t cfx_post_data_element_get_file(cef_post_data_element_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_post_data_element_get_file_delegate(IntPtr self);
        public static cfx_post_data_element_get_file_delegate cfx_post_data_element_get_file;

        // CFX_EXPORT int cfx_post_data_element_get_bytes_count(cef_post_data_element_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_element_get_bytes_count_delegate(IntPtr self);
        public static cfx_post_data_element_get_bytes_count_delegate cfx_post_data_element_get_bytes_count;

        // CFX_EXPORT int cfx_post_data_element_get_bytes(cef_post_data_element_t* self, int size, void* bytes)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_post_data_element_get_bytes_delegate(IntPtr self, int size, IntPtr bytes);
        public static cfx_post_data_element_get_bytes_delegate cfx_post_data_element_get_bytes;


        // CfxProcessMessage

        // CEF_EXPORT cef_process_message_t* cef_process_message_create(const cef_string_t* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_process_message_create_delegate(IntPtr name_str, int name_length);
        public static cfx_process_message_create_delegate cfx_process_message_create;

        // CFX_EXPORT int cfx_process_message_is_valid(cef_process_message_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_process_message_is_valid_delegate(IntPtr self);
        public static cfx_process_message_is_valid_delegate cfx_process_message_is_valid;

        // CFX_EXPORT int cfx_process_message_is_read_only(cef_process_message_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_process_message_is_read_only_delegate(IntPtr self);
        public static cfx_process_message_is_read_only_delegate cfx_process_message_is_read_only;

        // CFX_EXPORT cef_process_message_t* cfx_process_message_copy(cef_process_message_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_process_message_copy_delegate(IntPtr self);
        public static cfx_process_message_copy_delegate cfx_process_message_copy;

        // CFX_EXPORT cef_string_userfree_t cfx_process_message_get_name(cef_process_message_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_process_message_get_name_delegate(IntPtr self);
        public static cfx_process_message_get_name_delegate cfx_process_message_get_name;

        // CFX_EXPORT cef_list_value_t* cfx_process_message_get_argument_list(cef_process_message_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_process_message_get_argument_list_delegate(IntPtr self);
        public static cfx_process_message_get_argument_list_delegate cfx_process_message_get_argument_list;


        // CfxQuotaCallback

        // CFX_EXPORT void cfx_quota_callback_cont(cef_quota_callback_t* self, int allow)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_quota_callback_cont_delegate(IntPtr self, int allow);
        public static cfx_quota_callback_cont_delegate cfx_quota_callback_cont;

        // CFX_EXPORT void cfx_quota_callback_cancel(cef_quota_callback_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_quota_callback_cancel_delegate(IntPtr self);
        public static cfx_quota_callback_cancel_delegate cfx_quota_callback_cancel;


        // CfxReadHandler

        // CFX_EXPORT cfx_read_handler_t* cfx_read_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_read_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_read_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_read_handler_activate_callback;

        // read
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_read_handler_read_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr ptr, int size, int n);
        public static cfx_read_handler_read_delegate cfx_read_handler_read;

        // seek
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_read_handler_seek_delegate(IntPtr gcHandlePtr, out int __retval, long offset, int whence);
        public static cfx_read_handler_seek_delegate cfx_read_handler_seek;

        // tell
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_read_handler_tell_delegate(IntPtr gcHandlePtr, out long __retval);
        public static cfx_read_handler_tell_delegate cfx_read_handler_tell;

        // eof
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_read_handler_eof_delegate(IntPtr gcHandlePtr, out int __retval);
        public static cfx_read_handler_eof_delegate cfx_read_handler_eof;

        // may_block
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_read_handler_may_block_delegate(IntPtr gcHandlePtr, out int __retval);
        public static cfx_read_handler_may_block_delegate cfx_read_handler_may_block;


        // CfxRect

        // CFX_EXPORT cef_rect_t* cfx_rect_ctor()
        public static cfx_ctor_delegate cfx_rect_ctor;
        // CFX_EXPORT void cfx_rect_dtor(cef_rect_t* ptr)
        public static cfx_dtor_delegate cfx_rect_dtor;

        // CFX_EXPORT void cfx_rect_copy_to_native(cef_rect_t* self, int x, int y, int width, int height)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_rect_copy_to_native_delegate(IntPtr self, int x, int y, int width, int height);
        public static cfx_rect_copy_to_native_delegate cfx_rect_copy_to_native;
        // CFX_EXPORT void cfx_rect_copy_to_managed(cef_rect_t* self, int* x, int* y, int* width, int* height)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_rect_copy_to_managed_delegate(IntPtr self, out int x, out int y, out int width, out int height);
        public static cfx_rect_copy_to_managed_delegate cfx_rect_copy_to_managed;


        // CfxRenderHandler

        // CFX_EXPORT cfx_render_handler_t* cfx_render_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_render_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_render_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_render_handler_activate_callback;

        // get_root_screen_rect
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_get_root_screen_rect_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr rect);
        public static cfx_render_handler_get_root_screen_rect_delegate cfx_render_handler_get_root_screen_rect;

        // get_view_rect
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_get_view_rect_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr rect);
        public static cfx_render_handler_get_view_rect_delegate cfx_render_handler_get_view_rect;

        // get_screen_point
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_get_screen_point_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, int viewX, int viewY, out int screenX, out int screenY);
        public static cfx_render_handler_get_screen_point_delegate cfx_render_handler_get_screen_point;

        // get_screen_info
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_get_screen_info_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr screen_info);
        public static cfx_render_handler_get_screen_info_delegate cfx_render_handler_get_screen_info;

        // on_popup_show
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_on_popup_show_delegate(IntPtr gcHandlePtr, IntPtr browser, int show);
        public static cfx_render_handler_on_popup_show_delegate cfx_render_handler_on_popup_show;

        // on_popup_size
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_on_popup_size_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr rect);
        public static cfx_render_handler_on_popup_size_delegate cfx_render_handler_on_popup_size;

        // on_paint
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_on_paint_delegate(IntPtr gcHandlePtr, IntPtr browser, CfxPaintElementType type, int dirtyRectsCount, IntPtr dirtyRects, IntPtr buffer, int width, int height);
        public static cfx_render_handler_on_paint_delegate cfx_render_handler_on_paint;

        // on_cursor_change
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_on_cursor_change_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr cursor);
        public static cfx_render_handler_on_cursor_change_delegate cfx_render_handler_on_cursor_change;

        // on_scroll_offset_changed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_handler_on_scroll_offset_changed_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_render_handler_on_scroll_offset_changed_delegate cfx_render_handler_on_scroll_offset_changed;


        // CfxRenderProcessHandler

        // CFX_EXPORT cfx_render_process_handler_t* cfx_render_process_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_render_process_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_render_process_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_render_process_handler_activate_callback;

        // on_render_thread_created
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_render_thread_created_delegate(IntPtr gcHandlePtr, IntPtr extra_info);
        public static cfx_render_process_handler_on_render_thread_created_delegate cfx_render_process_handler_on_render_thread_created;

        // on_web_kit_initialized
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_web_kit_initialized_delegate(IntPtr gcHandlePtr);
        public static cfx_render_process_handler_on_web_kit_initialized_delegate cfx_render_process_handler_on_web_kit_initialized;

        // on_browser_created
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_browser_created_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_render_process_handler_on_browser_created_delegate cfx_render_process_handler_on_browser_created;

        // on_browser_destroyed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_browser_destroyed_delegate(IntPtr gcHandlePtr, IntPtr browser);
        public static cfx_render_process_handler_on_browser_destroyed_delegate cfx_render_process_handler_on_browser_destroyed;

        // get_load_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_get_load_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_render_process_handler_get_load_handler_delegate cfx_render_process_handler_get_load_handler;

        // on_before_navigation
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_before_navigation_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request, CfxNavigationType navigation_type, int is_redirect);
        public static cfx_render_process_handler_on_before_navigation_delegate cfx_render_process_handler_on_before_navigation;

        // on_context_created
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_context_created_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr context);
        public static cfx_render_process_handler_on_context_created_delegate cfx_render_process_handler_on_context_created;

        // on_context_released
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_context_released_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr context);
        public static cfx_render_process_handler_on_context_released_delegate cfx_render_process_handler_on_context_released;

        // on_uncaught_exception
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_uncaught_exception_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr context, IntPtr exception, IntPtr stackTrace);
        public static cfx_render_process_handler_on_uncaught_exception_delegate cfx_render_process_handler_on_uncaught_exception;

        // on_focused_node_changed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_focused_node_changed_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr node);
        public static cfx_render_process_handler_on_focused_node_changed_delegate cfx_render_process_handler_on_focused_node_changed;

        // on_process_message_received
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_render_process_handler_on_process_message_received_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, CfxProcessId source_process, IntPtr message);
        public static cfx_render_process_handler_on_process_message_received_delegate cfx_render_process_handler_on_process_message_received;


        // CfxRequest

        // CEF_EXPORT cef_request_t* cef_request_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_create_delegate();
        public static cfx_request_create_delegate cfx_request_create;

        // CFX_EXPORT int cfx_request_is_read_only(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_request_is_read_only_delegate(IntPtr self);
        public static cfx_request_is_read_only_delegate cfx_request_is_read_only;

        // CFX_EXPORT cef_string_userfree_t cfx_request_get_url(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_get_url_delegate(IntPtr self);
        public static cfx_request_get_url_delegate cfx_request_get_url;

        // CFX_EXPORT void cfx_request_set_url(cef_request_t* self, char16 *url_str, int url_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_url_delegate(IntPtr self, IntPtr url_str, int url_length);
        public static cfx_request_set_url_delegate cfx_request_set_url;

        // CFX_EXPORT cef_string_userfree_t cfx_request_get_method(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_get_method_delegate(IntPtr self);
        public static cfx_request_get_method_delegate cfx_request_get_method;

        // CFX_EXPORT void cfx_request_set_method(cef_request_t* self, char16 *method_str, int method_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_method_delegate(IntPtr self, IntPtr method_str, int method_length);
        public static cfx_request_set_method_delegate cfx_request_set_method;

        // CFX_EXPORT cef_post_data_t* cfx_request_get_post_data(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_get_post_data_delegate(IntPtr self);
        public static cfx_request_get_post_data_delegate cfx_request_get_post_data;

        // CFX_EXPORT void cfx_request_set_post_data(cef_request_t* self, cef_post_data_t* postData)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_post_data_delegate(IntPtr self, IntPtr postData);
        public static cfx_request_set_post_data_delegate cfx_request_set_post_data;

        // CFX_EXPORT void cfx_request_get_header_map(cef_request_t* self, cef_string_multimap_t headerMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_get_header_map_delegate(IntPtr self, IntPtr headerMap);
        public static cfx_request_get_header_map_delegate cfx_request_get_header_map;

        // CFX_EXPORT void cfx_request_set_header_map(cef_request_t* self, cef_string_multimap_t headerMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_header_map_delegate(IntPtr self, IntPtr headerMap);
        public static cfx_request_set_header_map_delegate cfx_request_set_header_map;

        // CFX_EXPORT void cfx_request_set(cef_request_t* self, char16 *url_str, int url_length, char16 *method_str, int method_length, cef_post_data_t* postData, cef_string_multimap_t headerMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_delegate(IntPtr self, IntPtr url_str, int url_length, IntPtr method_str, int method_length, IntPtr postData, IntPtr headerMap);
        public static cfx_request_set_delegate cfx_request_set;

        // CFX_EXPORT int cfx_request_get_flags(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_request_get_flags_delegate(IntPtr self);
        public static cfx_request_get_flags_delegate cfx_request_get_flags;

        // CFX_EXPORT void cfx_request_set_flags(cef_request_t* self, int flags)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_flags_delegate(IntPtr self, int flags);
        public static cfx_request_set_flags_delegate cfx_request_set_flags;

        // CFX_EXPORT cef_string_userfree_t cfx_request_get_first_party_for_cookies(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_get_first_party_for_cookies_delegate(IntPtr self);
        public static cfx_request_get_first_party_for_cookies_delegate cfx_request_get_first_party_for_cookies;

        // CFX_EXPORT void cfx_request_set_first_party_for_cookies(cef_request_t* self, char16 *url_str, int url_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_request_set_first_party_for_cookies_delegate(IntPtr self, IntPtr url_str, int url_length);
        public static cfx_request_set_first_party_for_cookies_delegate cfx_request_set_first_party_for_cookies;

        // CFX_EXPORT cef_resource_type_t cfx_request_get_resource_type(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxResourceType cfx_request_get_resource_type_delegate(IntPtr self);
        public static cfx_request_get_resource_type_delegate cfx_request_get_resource_type;

        // CFX_EXPORT cef_transition_type_t cfx_request_get_transition_type(cef_request_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxTransitionType cfx_request_get_transition_type_delegate(IntPtr self);
        public static cfx_request_get_transition_type_delegate cfx_request_get_transition_type;


        // CfxRequestContext

        // CEF_EXPORT cef_request_context_t* cef_request_context_get_global_context();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_context_get_global_context_delegate();
        public static cfx_request_context_get_global_context_delegate cfx_request_context_get_global_context;
        // CEF_EXPORT cef_request_context_t* cef_request_context_create_context(cef_request_context_handler_t* handler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_context_create_context_delegate(IntPtr handler);
        public static cfx_request_context_create_context_delegate cfx_request_context_create_context;

        // CFX_EXPORT int cfx_request_context_is_same(cef_request_context_t* self, cef_request_context_t* other)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_request_context_is_same_delegate(IntPtr self, IntPtr other);
        public static cfx_request_context_is_same_delegate cfx_request_context_is_same;

        // CFX_EXPORT int cfx_request_context_is_global(cef_request_context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_request_context_is_global_delegate(IntPtr self);
        public static cfx_request_context_is_global_delegate cfx_request_context_is_global;

        // CFX_EXPORT cef_request_context_handler_t* cfx_request_context_get_handler(cef_request_context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_request_context_get_handler_delegate(IntPtr self);
        public static cfx_request_context_get_handler_delegate cfx_request_context_get_handler;


        // CfxRequestContextHandler

        // CFX_EXPORT cfx_request_context_handler_t* cfx_request_context_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_request_context_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_request_context_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_request_context_handler_activate_callback;

        // get_cookie_manager
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_context_handler_get_cookie_manager_delegate(IntPtr gcHandlePtr, out IntPtr __retval);
        public static cfx_request_context_handler_get_cookie_manager_delegate cfx_request_context_handler_get_cookie_manager;


        // CfxRequestHandler

        // CFX_EXPORT cfx_request_handler_t* cfx_request_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_request_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_request_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_request_handler_activate_callback;

        // on_before_browse
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_before_browse_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request, int is_redirect);
        public static cfx_request_handler_on_before_browse_delegate cfx_request_handler_on_before_browse;

        // on_before_resource_load
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_before_resource_load_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, IntPtr request);
        public static cfx_request_handler_on_before_resource_load_delegate cfx_request_handler_on_before_resource_load;

        // get_resource_handler
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_get_resource_handler_delegate(IntPtr gcHandlePtr, out IntPtr __retval, IntPtr browser, IntPtr frame, IntPtr request);
        public static cfx_request_handler_get_resource_handler_delegate cfx_request_handler_get_resource_handler;

        // on_resource_redirect
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_resource_redirect_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr frame, IntPtr old_url_str, int old_url_length, ref IntPtr new_url_str, ref int new_url_length);
        public static cfx_request_handler_on_resource_redirect_delegate cfx_request_handler_on_resource_redirect;

        // get_auth_credentials
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_get_auth_credentials_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr frame, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback);
        public static cfx_request_handler_get_auth_credentials_delegate cfx_request_handler_get_auth_credentials;

        // on_quota_request
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_quota_request_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr origin_url_str, int origin_url_length, long new_size, IntPtr callback);
        public static cfx_request_handler_on_quota_request_delegate cfx_request_handler_on_quota_request;

        // on_protocol_execution
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_protocol_execution_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr url_str, int url_length, out int allow_os_execution);
        public static cfx_request_handler_on_protocol_execution_delegate cfx_request_handler_on_protocol_execution;

        // on_certificate_error
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_certificate_error_delegate(IntPtr gcHandlePtr, out int __retval, CfxErrorCode cert_error, IntPtr request_url_str, int request_url_length, IntPtr callback);
        public static cfx_request_handler_on_certificate_error_delegate cfx_request_handler_on_certificate_error;

        // on_before_plugin_load
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_before_plugin_load_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr url_str, int url_length, IntPtr policy_url_str, int policy_url_length, IntPtr info);
        public static cfx_request_handler_on_before_plugin_load_delegate cfx_request_handler_on_before_plugin_load;

        // on_plugin_crashed
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_plugin_crashed_delegate(IntPtr gcHandlePtr, IntPtr browser, IntPtr plugin_path_str, int plugin_path_length);
        public static cfx_request_handler_on_plugin_crashed_delegate cfx_request_handler_on_plugin_crashed;

        // on_render_process_terminated
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_request_handler_on_render_process_terminated_delegate(IntPtr gcHandlePtr, IntPtr browser, CfxTerminationStatus status);
        public static cfx_request_handler_on_render_process_terminated_delegate cfx_request_handler_on_render_process_terminated;


        // CfxResourceBundleHandler

        // CFX_EXPORT cfx_resource_bundle_handler_t* cfx_resource_bundle_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_resource_bundle_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_resource_bundle_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_resource_bundle_handler_activate_callback;

        // get_localized_string
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_bundle_handler_get_localized_string_delegate(IntPtr gcHandlePtr, out int __retval, int message_id, ref IntPtr string_str, ref int string_length);
        public static cfx_resource_bundle_handler_get_localized_string_delegate cfx_resource_bundle_handler_get_localized_string;

        // get_data_resource
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_bundle_handler_get_data_resource_delegate(IntPtr gcHandlePtr, out int __retval, int resource_id, IntPtr data, out int data_size);
        public static cfx_resource_bundle_handler_get_data_resource_delegate cfx_resource_bundle_handler_get_data_resource;


        // CfxResourceHandler

        // CFX_EXPORT cfx_resource_handler_t* cfx_resource_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_resource_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_resource_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_resource_handler_activate_callback;

        // process_request
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_process_request_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr request, IntPtr callback);
        public static cfx_resource_handler_process_request_delegate cfx_resource_handler_process_request;

        // get_response_headers
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_get_response_headers_delegate(IntPtr gcHandlePtr, IntPtr response, out long response_length, ref IntPtr redirectUrl_str, ref int redirectUrl_length);
        public static cfx_resource_handler_get_response_headers_delegate cfx_resource_handler_get_response_headers;

        // read_response
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_read_response_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr data_out, int bytes_to_read, out int bytes_read, IntPtr callback);
        public static cfx_resource_handler_read_response_delegate cfx_resource_handler_read_response;

        // can_get_cookie
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_can_get_cookie_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr cookie);
        public static cfx_resource_handler_can_get_cookie_delegate cfx_resource_handler_can_get_cookie;

        // can_set_cookie
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_can_set_cookie_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr cookie);
        public static cfx_resource_handler_can_set_cookie_delegate cfx_resource_handler_can_set_cookie;

        // cancel
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_resource_handler_cancel_delegate(IntPtr gcHandlePtr);
        public static cfx_resource_handler_cancel_delegate cfx_resource_handler_cancel;


        // CfxResponse

        // CEF_EXPORT cef_response_t* cef_response_create();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_response_create_delegate();
        public static cfx_response_create_delegate cfx_response_create;

        // CFX_EXPORT int cfx_response_is_read_only(cef_response_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_response_is_read_only_delegate(IntPtr self);
        public static cfx_response_is_read_only_delegate cfx_response_is_read_only;

        // CFX_EXPORT int cfx_response_get_status(cef_response_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_response_get_status_delegate(IntPtr self);
        public static cfx_response_get_status_delegate cfx_response_get_status;

        // CFX_EXPORT void cfx_response_set_status(cef_response_t* self, int status)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_response_set_status_delegate(IntPtr self, int status);
        public static cfx_response_set_status_delegate cfx_response_set_status;

        // CFX_EXPORT cef_string_userfree_t cfx_response_get_status_text(cef_response_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_response_get_status_text_delegate(IntPtr self);
        public static cfx_response_get_status_text_delegate cfx_response_get_status_text;

        // CFX_EXPORT void cfx_response_set_status_text(cef_response_t* self, char16 *statusText_str, int statusText_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_response_set_status_text_delegate(IntPtr self, IntPtr statusText_str, int statusText_length);
        public static cfx_response_set_status_text_delegate cfx_response_set_status_text;

        // CFX_EXPORT cef_string_userfree_t cfx_response_get_mime_type(cef_response_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_response_get_mime_type_delegate(IntPtr self);
        public static cfx_response_get_mime_type_delegate cfx_response_get_mime_type;

        // CFX_EXPORT void cfx_response_set_mime_type(cef_response_t* self, char16 *mimeType_str, int mimeType_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_response_set_mime_type_delegate(IntPtr self, IntPtr mimeType_str, int mimeType_length);
        public static cfx_response_set_mime_type_delegate cfx_response_set_mime_type;

        // CFX_EXPORT cef_string_userfree_t cfx_response_get_header(cef_response_t* self, char16 *name_str, int name_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_response_get_header_delegate(IntPtr self, IntPtr name_str, int name_length);
        public static cfx_response_get_header_delegate cfx_response_get_header;

        // CFX_EXPORT void cfx_response_get_header_map(cef_response_t* self, cef_string_multimap_t headerMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_response_get_header_map_delegate(IntPtr self, IntPtr headerMap);
        public static cfx_response_get_header_map_delegate cfx_response_get_header_map;

        // CFX_EXPORT void cfx_response_set_header_map(cef_response_t* self, cef_string_multimap_t headerMap)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_response_set_header_map_delegate(IntPtr self, IntPtr headerMap);
        public static cfx_response_set_header_map_delegate cfx_response_set_header_map;


        // CfxRunFileDialogCallback

        // CFX_EXPORT void cfx_run_file_dialog_callback_cont(cef_run_file_dialog_callback_t* self, cef_browser_host_t* browser_host, cef_string_list_t file_paths)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_run_file_dialog_callback_cont_delegate(IntPtr self, IntPtr browser_host, IntPtr file_paths);
        public static cfx_run_file_dialog_callback_cont_delegate cfx_run_file_dialog_callback_cont;


        // CfxSchemeHandlerFactory

        // CFX_EXPORT cef_resource_handler_t* cfx_scheme_handler_factory_create(cef_scheme_handler_factory_t* self, cef_browser_t* browser, cef_frame_t* frame, char16 *scheme_name_str, int scheme_name_length, cef_request_t* request)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_scheme_handler_factory_create_delegate(IntPtr self, IntPtr browser, IntPtr frame, IntPtr scheme_name_str, int scheme_name_length, IntPtr request);
        public static cfx_scheme_handler_factory_create_delegate cfx_scheme_handler_factory_create;


        // CfxSchemeRegistrar

        // CFX_EXPORT int cfx_scheme_registrar_add_custom_scheme(cef_scheme_registrar_t* self, char16 *scheme_name_str, int scheme_name_length, int is_standard, int is_local, int is_display_isolated)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_scheme_registrar_add_custom_scheme_delegate(IntPtr self, IntPtr scheme_name_str, int scheme_name_length, int is_standard, int is_local, int is_display_isolated);
        public static cfx_scheme_registrar_add_custom_scheme_delegate cfx_scheme_registrar_add_custom_scheme;


        // CfxScreenInfo

        // CFX_EXPORT cef_screen_info_t* cfx_screen_info_ctor()
        public static cfx_ctor_delegate cfx_screen_info_ctor;
        // CFX_EXPORT void cfx_screen_info_dtor(cef_screen_info_t* ptr)
        public static cfx_dtor_delegate cfx_screen_info_dtor;

        // CFX_EXPORT void cfx_screen_info_copy_to_native(cef_screen_info_t* self, float device_scale_factor, int depth, int depth_per_component, int is_monochrome, cef_rect_t* rect, cef_rect_t* available_rect)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_screen_info_copy_to_native_delegate(IntPtr self, float device_scale_factor, int depth, int depth_per_component, int is_monochrome, IntPtr rect, IntPtr available_rect);
        public static cfx_screen_info_copy_to_native_delegate cfx_screen_info_copy_to_native;
        // CFX_EXPORT void cfx_screen_info_copy_to_managed(cef_screen_info_t* self, float* device_scale_factor, int* depth, int* depth_per_component, int* is_monochrome, cef_rect_t** rect, cef_rect_t** available_rect)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_screen_info_copy_to_managed_delegate(IntPtr self, out float device_scale_factor, out int depth, out int depth_per_component, out int is_monochrome, out IntPtr rect, out IntPtr available_rect);
        public static cfx_screen_info_copy_to_managed_delegate cfx_screen_info_copy_to_managed;


        // CfxSettings

        // CFX_EXPORT cef_settings_t* cfx_settings_ctor()
        public static cfx_ctor_delegate cfx_settings_ctor;
        // CFX_EXPORT void cfx_settings_dtor(cef_settings_t* ptr)
        public static cfx_dtor_delegate cfx_settings_dtor;

        // CFX_EXPORT void cfx_settings_copy_to_native(cef_settings_t* self, int single_process, int no_sandbox, char16 *browser_subprocess_path_str, int browser_subprocess_path_length, int multi_threaded_message_loop, int command_line_args_disabled, char16 *cache_path_str, int cache_path_length, int persist_session_cookies, char16 *user_agent_str, int user_agent_length, char16 *product_version_str, int product_version_length, char16 *locale_str, int locale_length, char16 *log_file_str, int log_file_length, cef_log_severity_t log_severity, int release_dcheck_enabled, char16 *javascript_flags_str, int javascript_flags_length, char16 *resources_dir_path_str, int resources_dir_path_length, char16 *locales_dir_path_str, int locales_dir_path_length, int pack_loading_disabled, int remote_debugging_port, int uncaught_exception_stack_size, int context_safety_implementation, int ignore_certificate_errors, uint32 background_color)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_settings_copy_to_native_delegate(IntPtr self, int single_process, int no_sandbox, IntPtr browser_subprocess_path_str, int browser_subprocess_path_length, int multi_threaded_message_loop, int command_line_args_disabled, IntPtr cache_path_str, int cache_path_length, int persist_session_cookies, IntPtr user_agent_str, int user_agent_length, IntPtr product_version_str, int product_version_length, IntPtr locale_str, int locale_length, IntPtr log_file_str, int log_file_length, CfxLogSeverity log_severity, int release_dcheck_enabled, IntPtr javascript_flags_str, int javascript_flags_length, IntPtr resources_dir_path_str, int resources_dir_path_length, IntPtr locales_dir_path_str, int locales_dir_path_length, int pack_loading_disabled, int remote_debugging_port, int uncaught_exception_stack_size, int context_safety_implementation, int ignore_certificate_errors, uint background_color);
        public static cfx_settings_copy_to_native_delegate cfx_settings_copy_to_native;


        // CfxStreamReader

        // CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_file(const cef_string_t* fileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_stream_reader_create_for_file_delegate(IntPtr fileName_str, int fileName_length);
        public static cfx_stream_reader_create_for_file_delegate cfx_stream_reader_create_for_file;
        // CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_data(void* data, size_t size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_stream_reader_create_for_data_delegate(IntPtr data, int size);
        public static cfx_stream_reader_create_for_data_delegate cfx_stream_reader_create_for_data;
        // CEF_EXPORT cef_stream_reader_t* cef_stream_reader_create_for_handler(cef_read_handler_t* handler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_stream_reader_create_for_handler_delegate(IntPtr handler);
        public static cfx_stream_reader_create_for_handler_delegate cfx_stream_reader_create_for_handler;

        // CFX_EXPORT int cfx_stream_reader_read(cef_stream_reader_t* self, void* ptr, int size, int n)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_reader_read_delegate(IntPtr self, IntPtr ptr, int size, int n);
        public static cfx_stream_reader_read_delegate cfx_stream_reader_read;

        // CFX_EXPORT int cfx_stream_reader_seek(cef_stream_reader_t* self, int64 offset, int whence)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_reader_seek_delegate(IntPtr self, long offset, int whence);
        public static cfx_stream_reader_seek_delegate cfx_stream_reader_seek;

        // CFX_EXPORT int64 cfx_stream_reader_tell(cef_stream_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_stream_reader_tell_delegate(IntPtr self);
        public static cfx_stream_reader_tell_delegate cfx_stream_reader_tell;

        // CFX_EXPORT int cfx_stream_reader_eof(cef_stream_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_reader_eof_delegate(IntPtr self);
        public static cfx_stream_reader_eof_delegate cfx_stream_reader_eof;

        // CFX_EXPORT int cfx_stream_reader_may_block(cef_stream_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_reader_may_block_delegate(IntPtr self);
        public static cfx_stream_reader_may_block_delegate cfx_stream_reader_may_block;


        // CfxStreamWriter

        // CEF_EXPORT cef_stream_writer_t* cef_stream_writer_create_for_file(const cef_string_t* fileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_stream_writer_create_for_file_delegate(IntPtr fileName_str, int fileName_length);
        public static cfx_stream_writer_create_for_file_delegate cfx_stream_writer_create_for_file;
        // CEF_EXPORT cef_stream_writer_t* cef_stream_writer_create_for_handler(cef_write_handler_t* handler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_stream_writer_create_for_handler_delegate(IntPtr handler);
        public static cfx_stream_writer_create_for_handler_delegate cfx_stream_writer_create_for_handler;

        // CFX_EXPORT int cfx_stream_writer_write(cef_stream_writer_t* self, const void* ptr, int size, int n)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_writer_write_delegate(IntPtr self, IntPtr ptr, int size, int n);
        public static cfx_stream_writer_write_delegate cfx_stream_writer_write;

        // CFX_EXPORT int cfx_stream_writer_seek(cef_stream_writer_t* self, int64 offset, int whence)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_writer_seek_delegate(IntPtr self, long offset, int whence);
        public static cfx_stream_writer_seek_delegate cfx_stream_writer_seek;

        // CFX_EXPORT int64 cfx_stream_writer_tell(cef_stream_writer_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_stream_writer_tell_delegate(IntPtr self);
        public static cfx_stream_writer_tell_delegate cfx_stream_writer_tell;

        // CFX_EXPORT int cfx_stream_writer_flush(cef_stream_writer_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_writer_flush_delegate(IntPtr self);
        public static cfx_stream_writer_flush_delegate cfx_stream_writer_flush;

        // CFX_EXPORT int cfx_stream_writer_may_block(cef_stream_writer_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_stream_writer_may_block_delegate(IntPtr self);
        public static cfx_stream_writer_may_block_delegate cfx_stream_writer_may_block;


        // CfxStringVisitor

        // CFX_EXPORT cfx_string_visitor_t* cfx_string_visitor_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_string_visitor_ctor;
        public static cfx_get_gc_handle_delegate cfx_string_visitor_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_string_visitor_activate_callback;

        // visit
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_string_visitor_visit_delegate(IntPtr gcHandlePtr, IntPtr string_str, int string_length);
        public static cfx_string_visitor_visit_delegate cfx_string_visitor_visit;


        // CfxTask

        // CFX_EXPORT cfx_task_t* cfx_task_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_task_ctor;
        public static cfx_get_gc_handle_delegate cfx_task_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_task_activate_callback;

        // execute
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_task_execute_delegate(IntPtr gcHandlePtr);
        public static cfx_task_execute_delegate cfx_task_execute;


        // CfxTaskRunner

        // CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_current_thread();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_task_runner_get_for_current_thread_delegate();
        public static cfx_task_runner_get_for_current_thread_delegate cfx_task_runner_get_for_current_thread;
        // CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_thread(cef_thread_id_t threadId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_task_runner_get_for_thread_delegate(CfxThreadId threadId);
        public static cfx_task_runner_get_for_thread_delegate cfx_task_runner_get_for_thread;

        // CFX_EXPORT int cfx_task_runner_is_same(cef_task_runner_t* self, cef_task_runner_t* that)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_task_runner_is_same_delegate(IntPtr self, IntPtr that);
        public static cfx_task_runner_is_same_delegate cfx_task_runner_is_same;

        // CFX_EXPORT int cfx_task_runner_belongs_to_current_thread(cef_task_runner_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_task_runner_belongs_to_current_thread_delegate(IntPtr self);
        public static cfx_task_runner_belongs_to_current_thread_delegate cfx_task_runner_belongs_to_current_thread;

        // CFX_EXPORT int cfx_task_runner_belongs_to_thread(cef_task_runner_t* self, cef_thread_id_t threadId)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_task_runner_belongs_to_thread_delegate(IntPtr self, CfxThreadId threadId);
        public static cfx_task_runner_belongs_to_thread_delegate cfx_task_runner_belongs_to_thread;

        // CFX_EXPORT int cfx_task_runner_post_task(cef_task_runner_t* self, cef_task_t* task)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_task_runner_post_task_delegate(IntPtr self, IntPtr task);
        public static cfx_task_runner_post_task_delegate cfx_task_runner_post_task;

        // CFX_EXPORT int cfx_task_runner_post_delayed_task(cef_task_runner_t* self, cef_task_t* task, int64 delay_ms)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_task_runner_post_delayed_task_delegate(IntPtr self, IntPtr task, long delay_ms);
        public static cfx_task_runner_post_delayed_task_delegate cfx_task_runner_post_delayed_task;


        // CfxTime

        // CFX_EXPORT cef_time_t* cfx_time_ctor()
        public static cfx_ctor_delegate cfx_time_ctor;
        // CFX_EXPORT void cfx_time_dtor(cef_time_t* ptr)
        public static cfx_dtor_delegate cfx_time_dtor;

        // CFX_EXPORT void cfx_time_copy_to_native(cef_time_t* self, int year, int month, int day_of_week, int day_of_month, int hour, int minute, int second, int millisecond)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_time_copy_to_native_delegate(IntPtr self, int year, int month, int day_of_week, int day_of_month, int hour, int minute, int second, int millisecond);
        public static cfx_time_copy_to_native_delegate cfx_time_copy_to_native;
        // CFX_EXPORT void cfx_time_copy_to_managed(cef_time_t* self, int* year, int* month, int* day_of_week, int* day_of_month, int* hour, int* minute, int* second, int* millisecond)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_time_copy_to_managed_delegate(IntPtr self, out int year, out int month, out int day_of_week, out int day_of_month, out int hour, out int minute, out int second, out int millisecond);
        public static cfx_time_copy_to_managed_delegate cfx_time_copy_to_managed;


        // CfxUrlParts

        // CFX_EXPORT cef_urlparts_t* cfx_urlparts_ctor()
        public static cfx_ctor_delegate cfx_urlparts_ctor;
        // CFX_EXPORT void cfx_urlparts_dtor(cef_urlparts_t* ptr)
        public static cfx_dtor_delegate cfx_urlparts_dtor;

        // CFX_EXPORT void cfx_urlparts_copy_to_native(cef_urlparts_t* self, char16 *spec_str, int spec_length, char16 *scheme_str, int scheme_length, char16 *username_str, int username_length, char16 *password_str, int password_length, char16 *host_str, int host_length, char16 *port_str, int port_length, char16 *origin_str, int origin_length, char16 *path_str, int path_length, char16 *query_str, int query_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_urlparts_copy_to_native_delegate(IntPtr self, IntPtr spec_str, int spec_length, IntPtr scheme_str, int scheme_length, IntPtr username_str, int username_length, IntPtr password_str, int password_length, IntPtr host_str, int host_length, IntPtr port_str, int port_length, IntPtr origin_str, int origin_length, IntPtr path_str, int path_length, IntPtr query_str, int query_length);
        public static cfx_urlparts_copy_to_native_delegate cfx_urlparts_copy_to_native;


        // CfxUrlRequest

        // CEF_EXPORT cef_urlrequest_t* cef_urlrequest_create(cef_request_t* request, cef_urlrequest_client_t* client);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_urlrequest_create_delegate(IntPtr request, IntPtr client);
        public static cfx_urlrequest_create_delegate cfx_urlrequest_create;

        // CFX_EXPORT cef_request_t* cfx_urlrequest_get_request(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_urlrequest_get_request_delegate(IntPtr self);
        public static cfx_urlrequest_get_request_delegate cfx_urlrequest_get_request;

        // CFX_EXPORT cef_urlrequest_client_t* cfx_urlrequest_get_client(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_urlrequest_get_client_delegate(IntPtr self);
        public static cfx_urlrequest_get_client_delegate cfx_urlrequest_get_client;

        // CFX_EXPORT cef_urlrequest_status_t cfx_urlrequest_get_request_status(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxUrlRequestStatus cfx_urlrequest_get_request_status_delegate(IntPtr self);
        public static cfx_urlrequest_get_request_status_delegate cfx_urlrequest_get_request_status;

        // CFX_EXPORT cef_errorcode_t cfx_urlrequest_get_request_error(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxErrorCode cfx_urlrequest_get_request_error_delegate(IntPtr self);
        public static cfx_urlrequest_get_request_error_delegate cfx_urlrequest_get_request_error;

        // CFX_EXPORT cef_response_t* cfx_urlrequest_get_response(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_urlrequest_get_response_delegate(IntPtr self);
        public static cfx_urlrequest_get_response_delegate cfx_urlrequest_get_response;

        // CFX_EXPORT void cfx_urlrequest_cancel(cef_urlrequest_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_urlrequest_cancel_delegate(IntPtr self);
        public static cfx_urlrequest_cancel_delegate cfx_urlrequest_cancel;


        // CfxUrlRequestClient

        // CFX_EXPORT cfx_urlrequest_client_t* cfx_urlrequest_client_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_urlrequest_client_ctor;
        public static cfx_get_gc_handle_delegate cfx_urlrequest_client_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_urlrequest_client_activate_callback;

        // on_request_complete
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_urlrequest_client_on_request_complete_delegate(IntPtr gcHandlePtr, IntPtr request);
        public static cfx_urlrequest_client_on_request_complete_delegate cfx_urlrequest_client_on_request_complete;

        // on_upload_progress
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_urlrequest_client_on_upload_progress_delegate(IntPtr gcHandlePtr, IntPtr request, ulong current, ulong total);
        public static cfx_urlrequest_client_on_upload_progress_delegate cfx_urlrequest_client_on_upload_progress;

        // on_download_progress
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_urlrequest_client_on_download_progress_delegate(IntPtr gcHandlePtr, IntPtr request, ulong current, ulong total);
        public static cfx_urlrequest_client_on_download_progress_delegate cfx_urlrequest_client_on_download_progress;

        // on_download_data
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_urlrequest_client_on_download_data_delegate(IntPtr gcHandlePtr, IntPtr request, IntPtr data, int data_length);
        public static cfx_urlrequest_client_on_download_data_delegate cfx_urlrequest_client_on_download_data;

        // get_auth_credentials
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_urlrequest_client_get_auth_credentials_delegate(IntPtr gcHandlePtr, out int __retval, int isProxy, IntPtr host_str, int host_length, int port, IntPtr realm_str, int realm_length, IntPtr scheme_str, int scheme_length, IntPtr callback);
        public static cfx_urlrequest_client_get_auth_credentials_delegate cfx_urlrequest_client_get_auth_credentials;


        // CfxV8Accessor

        // CFX_EXPORT cfx_v8accessor_t* cfx_v8accessor_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_v8accessor_ctor;
        public static cfx_get_gc_handle_delegate cfx_v8accessor_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_v8accessor_activate_callback;

        // get
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_v8accessor_get_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, out IntPtr retval, ref IntPtr exception_str, ref int exception_length);
        public static cfx_v8accessor_get_delegate cfx_v8accessor_get;

        // set
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_v8accessor_set_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, IntPtr value, ref IntPtr exception_str, ref int exception_length);
        public static cfx_v8accessor_set_delegate cfx_v8accessor_set;


        // CfxV8Context

        // CEF_EXPORT cef_v8context_t* cef_v8context_get_current_context();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_current_context_delegate();
        public static cfx_v8context_get_current_context_delegate cfx_v8context_get_current_context;
        // CEF_EXPORT cef_v8context_t* cef_v8context_get_entered_context();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_entered_context_delegate();
        public static cfx_v8context_get_entered_context_delegate cfx_v8context_get_entered_context;
        // CEF_EXPORT int cef_v8context_in_context();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_in_context_delegate();
        public static cfx_v8context_in_context_delegate cfx_v8context_in_context;

        // CFX_EXPORT cef_task_runner_t* cfx_v8context_get_task_runner(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_task_runner_delegate(IntPtr self);
        public static cfx_v8context_get_task_runner_delegate cfx_v8context_get_task_runner;

        // CFX_EXPORT int cfx_v8context_is_valid(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_is_valid_delegate(IntPtr self);
        public static cfx_v8context_is_valid_delegate cfx_v8context_is_valid;

        // CFX_EXPORT cef_browser_t* cfx_v8context_get_browser(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_browser_delegate(IntPtr self);
        public static cfx_v8context_get_browser_delegate cfx_v8context_get_browser;

        // CFX_EXPORT cef_frame_t* cfx_v8context_get_frame(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_frame_delegate(IntPtr self);
        public static cfx_v8context_get_frame_delegate cfx_v8context_get_frame;

        // CFX_EXPORT cef_v8value_t* cfx_v8context_get_global(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8context_get_global_delegate(IntPtr self);
        public static cfx_v8context_get_global_delegate cfx_v8context_get_global;

        // CFX_EXPORT int cfx_v8context_enter(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_enter_delegate(IntPtr self);
        public static cfx_v8context_enter_delegate cfx_v8context_enter;

        // CFX_EXPORT int cfx_v8context_exit(cef_v8context_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_exit_delegate(IntPtr self);
        public static cfx_v8context_exit_delegate cfx_v8context_exit;

        // CFX_EXPORT int cfx_v8context_is_same(cef_v8context_t* self, cef_v8context_t* that)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_is_same_delegate(IntPtr self, IntPtr that);
        public static cfx_v8context_is_same_delegate cfx_v8context_is_same;

        // CFX_EXPORT int cfx_v8context_eval(cef_v8context_t* self, char16 *code_str, int code_length, cef_v8value_t** retval, cef_v8exception_t** exception)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8context_eval_delegate(IntPtr self, IntPtr code_str, int code_length, out IntPtr retval, out IntPtr exception);
        public static cfx_v8context_eval_delegate cfx_v8context_eval;


        // CfxV8Exception

        // CFX_EXPORT cef_string_userfree_t cfx_v8exception_get_message(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8exception_get_message_delegate(IntPtr self);
        public static cfx_v8exception_get_message_delegate cfx_v8exception_get_message;

        // CFX_EXPORT cef_string_userfree_t cfx_v8exception_get_source_line(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8exception_get_source_line_delegate(IntPtr self);
        public static cfx_v8exception_get_source_line_delegate cfx_v8exception_get_source_line;

        // CFX_EXPORT cef_string_userfree_t cfx_v8exception_get_script_resource_name(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8exception_get_script_resource_name_delegate(IntPtr self);
        public static cfx_v8exception_get_script_resource_name_delegate cfx_v8exception_get_script_resource_name;

        // CFX_EXPORT int cfx_v8exception_get_line_number(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8exception_get_line_number_delegate(IntPtr self);
        public static cfx_v8exception_get_line_number_delegate cfx_v8exception_get_line_number;

        // CFX_EXPORT int cfx_v8exception_get_start_position(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8exception_get_start_position_delegate(IntPtr self);
        public static cfx_v8exception_get_start_position_delegate cfx_v8exception_get_start_position;

        // CFX_EXPORT int cfx_v8exception_get_end_position(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8exception_get_end_position_delegate(IntPtr self);
        public static cfx_v8exception_get_end_position_delegate cfx_v8exception_get_end_position;

        // CFX_EXPORT int cfx_v8exception_get_start_column(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8exception_get_start_column_delegate(IntPtr self);
        public static cfx_v8exception_get_start_column_delegate cfx_v8exception_get_start_column;

        // CFX_EXPORT int cfx_v8exception_get_end_column(cef_v8exception_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8exception_get_end_column_delegate(IntPtr self);
        public static cfx_v8exception_get_end_column_delegate cfx_v8exception_get_end_column;


        // CfxV8Handler

        // CFX_EXPORT cfx_v8handler_t* cfx_v8handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_v8handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_v8handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_v8handler_activate_callback;

        // execute
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_v8handler_execute_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr name_str, int name_length, IntPtr @object, int argumentsCount, IntPtr arguments, out IntPtr retval, ref IntPtr exception_str, ref int exception_length);
        public static cfx_v8handler_execute_delegate cfx_v8handler_execute;


        // CfxV8StackFrame

        // CFX_EXPORT int cfx_v8stack_frame_is_valid(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_frame_is_valid_delegate(IntPtr self);
        public static cfx_v8stack_frame_is_valid_delegate cfx_v8stack_frame_is_valid;

        // CFX_EXPORT cef_string_userfree_t cfx_v8stack_frame_get_script_name(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8stack_frame_get_script_name_delegate(IntPtr self);
        public static cfx_v8stack_frame_get_script_name_delegate cfx_v8stack_frame_get_script_name;

        // CFX_EXPORT cef_string_userfree_t cfx_v8stack_frame_get_script_name_or_source_url(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8stack_frame_get_script_name_or_source_url_delegate(IntPtr self);
        public static cfx_v8stack_frame_get_script_name_or_source_url_delegate cfx_v8stack_frame_get_script_name_or_source_url;

        // CFX_EXPORT cef_string_userfree_t cfx_v8stack_frame_get_function_name(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8stack_frame_get_function_name_delegate(IntPtr self);
        public static cfx_v8stack_frame_get_function_name_delegate cfx_v8stack_frame_get_function_name;

        // CFX_EXPORT int cfx_v8stack_frame_get_line_number(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_frame_get_line_number_delegate(IntPtr self);
        public static cfx_v8stack_frame_get_line_number_delegate cfx_v8stack_frame_get_line_number;

        // CFX_EXPORT int cfx_v8stack_frame_get_column(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_frame_get_column_delegate(IntPtr self);
        public static cfx_v8stack_frame_get_column_delegate cfx_v8stack_frame_get_column;

        // CFX_EXPORT int cfx_v8stack_frame_is_eval(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_frame_is_eval_delegate(IntPtr self);
        public static cfx_v8stack_frame_is_eval_delegate cfx_v8stack_frame_is_eval;

        // CFX_EXPORT int cfx_v8stack_frame_is_constructor(cef_v8stack_frame_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_frame_is_constructor_delegate(IntPtr self);
        public static cfx_v8stack_frame_is_constructor_delegate cfx_v8stack_frame_is_constructor;


        // CfxV8StackTrace

        // CEF_EXPORT cef_v8stack_trace_t* cef_v8stack_trace_get_current(int frame_limit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8stack_trace_get_current_delegate(int frame_limit);
        public static cfx_v8stack_trace_get_current_delegate cfx_v8stack_trace_get_current;

        // CFX_EXPORT int cfx_v8stack_trace_is_valid(cef_v8stack_trace_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_trace_is_valid_delegate(IntPtr self);
        public static cfx_v8stack_trace_is_valid_delegate cfx_v8stack_trace_is_valid;

        // CFX_EXPORT int cfx_v8stack_trace_get_frame_count(cef_v8stack_trace_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8stack_trace_get_frame_count_delegate(IntPtr self);
        public static cfx_v8stack_trace_get_frame_count_delegate cfx_v8stack_trace_get_frame_count;

        // CFX_EXPORT cef_v8stack_frame_t* cfx_v8stack_trace_get_frame(cef_v8stack_trace_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8stack_trace_get_frame_delegate(IntPtr self, int index);
        public static cfx_v8stack_trace_get_frame_delegate cfx_v8stack_trace_get_frame;


        // CfxV8Value

        // CEF_EXPORT cef_v8value_t* cef_v8value_create_undefined();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_undefined_delegate();
        public static cfx_v8value_create_undefined_delegate cfx_v8value_create_undefined;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_null();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_null_delegate();
        public static cfx_v8value_create_null_delegate cfx_v8value_create_null;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_bool(int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_bool_delegate(int value);
        public static cfx_v8value_create_bool_delegate cfx_v8value_create_bool;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_int(int32 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_int_delegate(int value);
        public static cfx_v8value_create_int_delegate cfx_v8value_create_int;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_uint(uint32 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_uint_delegate(uint value);
        public static cfx_v8value_create_uint_delegate cfx_v8value_create_uint;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_double(double value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_double_delegate(double value);
        public static cfx_v8value_create_double_delegate cfx_v8value_create_double;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_date(const cef_time_t* date);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_date_delegate(IntPtr date);
        public static cfx_v8value_create_date_delegate cfx_v8value_create_date;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_string(const cef_string_t* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_string_delegate(IntPtr value_str, int value_length);
        public static cfx_v8value_create_string_delegate cfx_v8value_create_string;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_object(cef_v8accessor_t* accessor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_object_delegate(IntPtr accessor);
        public static cfx_v8value_create_object_delegate cfx_v8value_create_object;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_array(int length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_array_delegate(int length);
        public static cfx_v8value_create_array_delegate cfx_v8value_create_array;
        // CEF_EXPORT cef_v8value_t* cef_v8value_create_function(const cef_string_t* name, cef_v8handler_t* handler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_create_function_delegate(IntPtr name_str, int name_length, IntPtr handler);
        public static cfx_v8value_create_function_delegate cfx_v8value_create_function;

        // CFX_EXPORT int cfx_v8value_is_valid(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_valid_delegate(IntPtr self);
        public static cfx_v8value_is_valid_delegate cfx_v8value_is_valid;

        // CFX_EXPORT int cfx_v8value_is_undefined(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_undefined_delegate(IntPtr self);
        public static cfx_v8value_is_undefined_delegate cfx_v8value_is_undefined;

        // CFX_EXPORT int cfx_v8value_is_null(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_null_delegate(IntPtr self);
        public static cfx_v8value_is_null_delegate cfx_v8value_is_null;

        // CFX_EXPORT int cfx_v8value_is_bool(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_bool_delegate(IntPtr self);
        public static cfx_v8value_is_bool_delegate cfx_v8value_is_bool;

        // CFX_EXPORT int cfx_v8value_is_int(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_int_delegate(IntPtr self);
        public static cfx_v8value_is_int_delegate cfx_v8value_is_int;

        // CFX_EXPORT int cfx_v8value_is_uint(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_uint_delegate(IntPtr self);
        public static cfx_v8value_is_uint_delegate cfx_v8value_is_uint;

        // CFX_EXPORT int cfx_v8value_is_double(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_double_delegate(IntPtr self);
        public static cfx_v8value_is_double_delegate cfx_v8value_is_double;

        // CFX_EXPORT int cfx_v8value_is_date(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_date_delegate(IntPtr self);
        public static cfx_v8value_is_date_delegate cfx_v8value_is_date;

        // CFX_EXPORT int cfx_v8value_is_string(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_string_delegate(IntPtr self);
        public static cfx_v8value_is_string_delegate cfx_v8value_is_string;

        // CFX_EXPORT int cfx_v8value_is_object(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_object_delegate(IntPtr self);
        public static cfx_v8value_is_object_delegate cfx_v8value_is_object;

        // CFX_EXPORT int cfx_v8value_is_array(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_array_delegate(IntPtr self);
        public static cfx_v8value_is_array_delegate cfx_v8value_is_array;

        // CFX_EXPORT int cfx_v8value_is_function(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_function_delegate(IntPtr self);
        public static cfx_v8value_is_function_delegate cfx_v8value_is_function;

        // CFX_EXPORT int cfx_v8value_is_same(cef_v8value_t* self, cef_v8value_t* that)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_same_delegate(IntPtr self, IntPtr that);
        public static cfx_v8value_is_same_delegate cfx_v8value_is_same;

        // CFX_EXPORT int cfx_v8value_get_bool_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_get_bool_value_delegate(IntPtr self);
        public static cfx_v8value_get_bool_value_delegate cfx_v8value_get_bool_value;

        // CFX_EXPORT int32 cfx_v8value_get_int_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_get_int_value_delegate(IntPtr self);
        public static cfx_v8value_get_int_value_delegate cfx_v8value_get_int_value;

        // CFX_EXPORT uint32 cfx_v8value_get_uint_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate uint cfx_v8value_get_uint_value_delegate(IntPtr self);
        public static cfx_v8value_get_uint_value_delegate cfx_v8value_get_uint_value;

        // CFX_EXPORT double cfx_v8value_get_double_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate double cfx_v8value_get_double_value_delegate(IntPtr self);
        public static cfx_v8value_get_double_value_delegate cfx_v8value_get_double_value;

        // CFX_EXPORT cef_time_t* cfx_v8value_get_date_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_date_value_delegate(IntPtr self);
        public static cfx_v8value_get_date_value_delegate cfx_v8value_get_date_value;

        // CFX_EXPORT cef_string_userfree_t cfx_v8value_get_string_value(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_string_value_delegate(IntPtr self);
        public static cfx_v8value_get_string_value_delegate cfx_v8value_get_string_value;

        // CFX_EXPORT int cfx_v8value_is_user_created(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_is_user_created_delegate(IntPtr self);
        public static cfx_v8value_is_user_created_delegate cfx_v8value_is_user_created;

        // CFX_EXPORT int cfx_v8value_has_exception(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_has_exception_delegate(IntPtr self);
        public static cfx_v8value_has_exception_delegate cfx_v8value_has_exception;

        // CFX_EXPORT cef_v8exception_t* cfx_v8value_get_exception(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_exception_delegate(IntPtr self);
        public static cfx_v8value_get_exception_delegate cfx_v8value_get_exception;

        // CFX_EXPORT int cfx_v8value_clear_exception(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_clear_exception_delegate(IntPtr self);
        public static cfx_v8value_clear_exception_delegate cfx_v8value_clear_exception;

        // CFX_EXPORT int cfx_v8value_will_rethrow_exceptions(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_will_rethrow_exceptions_delegate(IntPtr self);
        public static cfx_v8value_will_rethrow_exceptions_delegate cfx_v8value_will_rethrow_exceptions;

        // CFX_EXPORT int cfx_v8value_set_rethrow_exceptions(cef_v8value_t* self, int rethrow)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_set_rethrow_exceptions_delegate(IntPtr self, int rethrow);
        public static cfx_v8value_set_rethrow_exceptions_delegate cfx_v8value_set_rethrow_exceptions;

        // CFX_EXPORT int cfx_v8value_has_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_has_value_bykey_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_v8value_has_value_bykey_delegate cfx_v8value_has_value_bykey;

        // CFX_EXPORT int cfx_v8value_has_value_byindex(cef_v8value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_has_value_byindex_delegate(IntPtr self, int index);
        public static cfx_v8value_has_value_byindex_delegate cfx_v8value_has_value_byindex;

        // CFX_EXPORT int cfx_v8value_delete_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_delete_value_bykey_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_v8value_delete_value_bykey_delegate cfx_v8value_delete_value_bykey;

        // CFX_EXPORT int cfx_v8value_delete_value_byindex(cef_v8value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_delete_value_byindex_delegate(IntPtr self, int index);
        public static cfx_v8value_delete_value_byindex_delegate cfx_v8value_delete_value_byindex;

        // CFX_EXPORT cef_v8value_t* cfx_v8value_get_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_value_bykey_delegate(IntPtr self, IntPtr key_str, int key_length);
        public static cfx_v8value_get_value_bykey_delegate cfx_v8value_get_value_bykey;

        // CFX_EXPORT cef_v8value_t* cfx_v8value_get_value_byindex(cef_v8value_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_value_byindex_delegate(IntPtr self, int index);
        public static cfx_v8value_get_value_byindex_delegate cfx_v8value_get_value_byindex;

        // CFX_EXPORT int cfx_v8value_set_value_bykey(cef_v8value_t* self, char16 *key_str, int key_length, cef_v8value_t* value, cef_v8_propertyattribute_t attribute)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_set_value_bykey_delegate(IntPtr self, IntPtr key_str, int key_length, IntPtr value, CfxV8PropertyAttribute attribute);
        public static cfx_v8value_set_value_bykey_delegate cfx_v8value_set_value_bykey;

        // CFX_EXPORT int cfx_v8value_set_value_byindex(cef_v8value_t* self, int index, cef_v8value_t* value)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_set_value_byindex_delegate(IntPtr self, int index, IntPtr value);
        public static cfx_v8value_set_value_byindex_delegate cfx_v8value_set_value_byindex;

        // CFX_EXPORT int cfx_v8value_set_value_byaccessor(cef_v8value_t* self, char16 *key_str, int key_length, cef_v8_accesscontrol_t settings, cef_v8_propertyattribute_t attribute)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_set_value_byaccessor_delegate(IntPtr self, IntPtr key_str, int key_length, CfxV8AccessControl settings, CfxV8PropertyAttribute attribute);
        public static cfx_v8value_set_value_byaccessor_delegate cfx_v8value_set_value_byaccessor;

        // CFX_EXPORT int cfx_v8value_get_keys(cef_v8value_t* self, cef_string_list_t keys)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_get_keys_delegate(IntPtr self, IntPtr keys);
        public static cfx_v8value_get_keys_delegate cfx_v8value_get_keys;

        // CFX_EXPORT int cfx_v8value_set_user_data(cef_v8value_t* self, struct _cef_base_t* user_data)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_set_user_data_delegate(IntPtr self, IntPtr user_data);
        public static cfx_v8value_set_user_data_delegate cfx_v8value_set_user_data;

        // CFX_EXPORT struct _cef_base_t* cfx_v8value_get_user_data(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_user_data_delegate(IntPtr self);
        public static cfx_v8value_get_user_data_delegate cfx_v8value_get_user_data;

        // CFX_EXPORT int cfx_v8value_get_externally_allocated_memory(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_get_externally_allocated_memory_delegate(IntPtr self);
        public static cfx_v8value_get_externally_allocated_memory_delegate cfx_v8value_get_externally_allocated_memory;

        // CFX_EXPORT int cfx_v8value_adjust_externally_allocated_memory(cef_v8value_t* self, int change_in_bytes)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_adjust_externally_allocated_memory_delegate(IntPtr self, int change_in_bytes);
        public static cfx_v8value_adjust_externally_allocated_memory_delegate cfx_v8value_adjust_externally_allocated_memory;

        // CFX_EXPORT int cfx_v8value_get_array_length(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_v8value_get_array_length_delegate(IntPtr self);
        public static cfx_v8value_get_array_length_delegate cfx_v8value_get_array_length;

        // CFX_EXPORT cef_string_userfree_t cfx_v8value_get_function_name(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_function_name_delegate(IntPtr self);
        public static cfx_v8value_get_function_name_delegate cfx_v8value_get_function_name;

        // CFX_EXPORT cef_v8handler_t* cfx_v8value_get_function_handler(cef_v8value_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_get_function_handler_delegate(IntPtr self);
        public static cfx_v8value_get_function_handler_delegate cfx_v8value_get_function_handler;

        // CFX_EXPORT cef_v8value_t* cfx_v8value_execute_function(cef_v8value_t* self, cef_v8value_t* object, int argumentsCount, cef_v8value_t* const* arguments)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_execute_function_delegate(IntPtr self, IntPtr @object, int argumentsCount, IntPtr arguments);
        public static cfx_v8value_execute_function_delegate cfx_v8value_execute_function;

        // CFX_EXPORT cef_v8value_t* cfx_v8value_execute_function_with_context(cef_v8value_t* self, cef_v8context_t* context, cef_v8value_t* object, int argumentsCount, cef_v8value_t* const* arguments)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_v8value_execute_function_with_context_delegate(IntPtr self, IntPtr context, IntPtr @object, int argumentsCount, IntPtr arguments);
        public static cfx_v8value_execute_function_with_context_delegate cfx_v8value_execute_function_with_context;


        // CfxWebPluginInfo

        // CFX_EXPORT cef_string_userfree_t cfx_web_plugin_info_get_name(cef_web_plugin_info_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_web_plugin_info_get_name_delegate(IntPtr self);
        public static cfx_web_plugin_info_get_name_delegate cfx_web_plugin_info_get_name;

        // CFX_EXPORT cef_string_userfree_t cfx_web_plugin_info_get_path(cef_web_plugin_info_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_web_plugin_info_get_path_delegate(IntPtr self);
        public static cfx_web_plugin_info_get_path_delegate cfx_web_plugin_info_get_path;

        // CFX_EXPORT cef_string_userfree_t cfx_web_plugin_info_get_version(cef_web_plugin_info_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_web_plugin_info_get_version_delegate(IntPtr self);
        public static cfx_web_plugin_info_get_version_delegate cfx_web_plugin_info_get_version;

        // CFX_EXPORT cef_string_userfree_t cfx_web_plugin_info_get_description(cef_web_plugin_info_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_web_plugin_info_get_description_delegate(IntPtr self);
        public static cfx_web_plugin_info_get_description_delegate cfx_web_plugin_info_get_description;


        // CfxWebPluginInfoVisitor

        // CFX_EXPORT cfx_web_plugin_info_visitor_t* cfx_web_plugin_info_visitor_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_web_plugin_info_visitor_ctor;
        public static cfx_get_gc_handle_delegate cfx_web_plugin_info_visitor_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_web_plugin_info_visitor_activate_callback;

        // visit
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_web_plugin_info_visitor_visit_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr info, int count, int total);
        public static cfx_web_plugin_info_visitor_visit_delegate cfx_web_plugin_info_visitor_visit;


        // CfxWebPluginUnstableCallback

        // CFX_EXPORT void cfx_web_plugin_unstable_callback_is_unstable(cef_web_plugin_unstable_callback_t* self, char16 *path_str, int path_length, int unstable)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_web_plugin_unstable_callback_is_unstable_delegate(IntPtr self, IntPtr path_str, int path_length, int unstable);
        public static cfx_web_plugin_unstable_callback_is_unstable_delegate cfx_web_plugin_unstable_callback_is_unstable;


        // CfxWindowInfo

        // CFX_EXPORT cef_window_info_t* cfx_window_info_ctor()
        public static cfx_ctor_delegate cfx_window_info_ctor;
        // CFX_EXPORT void cfx_window_info_dtor(cef_window_info_t* ptr)
        public static cfx_dtor_delegate cfx_window_info_dtor;

        // CFX_EXPORT void cfx_window_info_copy_to_native(cef_window_info_t* self, DWORD ex_style, char16 *window_name_str, int window_name_length, DWORD style, int x, int y, int width, int height, cef_window_handle_t parent_window, HMENU menu, int window_rendering_disabled, int transparent_painting, cef_window_handle_t window)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_window_info_copy_to_native_delegate(IntPtr self, int ex_style, IntPtr window_name_str, int window_name_length, int style, int x, int y, int width, int height, IntPtr parent_window, IntPtr menu, int window_rendering_disabled, int transparent_painting, IntPtr window);
        public static cfx_window_info_copy_to_native_delegate cfx_window_info_copy_to_native;
        // CFX_EXPORT void cfx_window_info_copy_to_managed(cef_window_info_t* self, DWORD* ex_style, char16 **window_name_str, int *window_name_length, DWORD* style, int* x, int* y, int* width, int* height, cef_window_handle_t* parent_window, HMENU* menu, int* window_rendering_disabled, int* transparent_painting, cef_window_handle_t* window)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate void cfx_window_info_copy_to_managed_delegate(IntPtr self, out int ex_style, out IntPtr window_name_str, out int window_name_length, out int style, out int x, out int y, out int width, out int height, out IntPtr parent_window, out IntPtr menu, out int window_rendering_disabled, out int transparent_painting, out IntPtr window);
        public static cfx_window_info_copy_to_managed_delegate cfx_window_info_copy_to_managed;


        // CfxWriteHandler

        // CFX_EXPORT cfx_write_handler_t* cfx_write_handler_ctor();
        public static cfx_ctor_with_gc_handle_delegate cfx_write_handler_ctor;
        public static cfx_get_gc_handle_delegate cfx_write_handler_get_gc_handle;
        public static cfx_activate_callback_delegate cfx_write_handler_activate_callback;

        // write
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_write_handler_write_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr ptr, int size, int n);
        public static cfx_write_handler_write_delegate cfx_write_handler_write;

        // seek
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_write_handler_seek_delegate(IntPtr gcHandlePtr, out int __retval, long offset, int whence);
        public static cfx_write_handler_seek_delegate cfx_write_handler_seek;

        // tell
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_write_handler_tell_delegate(IntPtr gcHandlePtr, out long __retval);
        public static cfx_write_handler_tell_delegate cfx_write_handler_tell;

        // flush
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_write_handler_flush_delegate(IntPtr gcHandlePtr, out int __retval);
        public static cfx_write_handler_flush_delegate cfx_write_handler_flush;

        // may_block
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = false)]
        public delegate void cfx_write_handler_may_block_delegate(IntPtr gcHandlePtr, out int __retval);
        public static cfx_write_handler_may_block_delegate cfx_write_handler_may_block;


        // CfxXmlReader

        // CEF_EXPORT cef_xml_reader_t* cef_xml_reader_create(cef_stream_reader_t* stream, cef_xml_encoding_type_t encodingType, const cef_string_t* URI);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_create_delegate(IntPtr stream, CfxXmlEncodingType encodingType, IntPtr URI_str, int URI_length);
        public static cfx_xml_reader_create_delegate cfx_xml_reader_create;

        // CFX_EXPORT int cfx_xml_reader_move_to_next_node(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_next_node_delegate(IntPtr self);
        public static cfx_xml_reader_move_to_next_node_delegate cfx_xml_reader_move_to_next_node;

        // CFX_EXPORT int cfx_xml_reader_close(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_close_delegate(IntPtr self);
        public static cfx_xml_reader_close_delegate cfx_xml_reader_close;

        // CFX_EXPORT int cfx_xml_reader_has_error(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_has_error_delegate(IntPtr self);
        public static cfx_xml_reader_has_error_delegate cfx_xml_reader_has_error;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_error(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_error_delegate(IntPtr self);
        public static cfx_xml_reader_get_error_delegate cfx_xml_reader_get_error;

        // CFX_EXPORT cef_xml_node_type_t cfx_xml_reader_get_type(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate CfxXmlNodeType cfx_xml_reader_get_type_delegate(IntPtr self);
        public static cfx_xml_reader_get_type_delegate cfx_xml_reader_get_type;

        // CFX_EXPORT int cfx_xml_reader_get_depth(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_get_depth_delegate(IntPtr self);
        public static cfx_xml_reader_get_depth_delegate cfx_xml_reader_get_depth;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_local_name(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_local_name_delegate(IntPtr self);
        public static cfx_xml_reader_get_local_name_delegate cfx_xml_reader_get_local_name;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_prefix(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_prefix_delegate(IntPtr self);
        public static cfx_xml_reader_get_prefix_delegate cfx_xml_reader_get_prefix;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_qualified_name(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_qualified_name_delegate(IntPtr self);
        public static cfx_xml_reader_get_qualified_name_delegate cfx_xml_reader_get_qualified_name;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_namespace_uri(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_namespace_uri_delegate(IntPtr self);
        public static cfx_xml_reader_get_namespace_uri_delegate cfx_xml_reader_get_namespace_uri;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_base_uri(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_base_uri_delegate(IntPtr self);
        public static cfx_xml_reader_get_base_uri_delegate cfx_xml_reader_get_base_uri;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_xml_lang(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_xml_lang_delegate(IntPtr self);
        public static cfx_xml_reader_get_xml_lang_delegate cfx_xml_reader_get_xml_lang;

        // CFX_EXPORT int cfx_xml_reader_is_empty_element(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_is_empty_element_delegate(IntPtr self);
        public static cfx_xml_reader_is_empty_element_delegate cfx_xml_reader_is_empty_element;

        // CFX_EXPORT int cfx_xml_reader_has_value(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_has_value_delegate(IntPtr self);
        public static cfx_xml_reader_has_value_delegate cfx_xml_reader_has_value;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_value(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_value_delegate(IntPtr self);
        public static cfx_xml_reader_get_value_delegate cfx_xml_reader_get_value;

        // CFX_EXPORT int cfx_xml_reader_has_attributes(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_has_attributes_delegate(IntPtr self);
        public static cfx_xml_reader_has_attributes_delegate cfx_xml_reader_has_attributes;

        // CFX_EXPORT int cfx_xml_reader_get_attribute_count(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_get_attribute_count_delegate(IntPtr self);
        public static cfx_xml_reader_get_attribute_count_delegate cfx_xml_reader_get_attribute_count;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_attribute_byindex(cef_xml_reader_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_attribute_byindex_delegate(IntPtr self, int index);
        public static cfx_xml_reader_get_attribute_byindex_delegate cfx_xml_reader_get_attribute_byindex;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_attribute_byqname(cef_xml_reader_t* self, char16 *qualifiedName_str, int qualifiedName_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_attribute_byqname_delegate(IntPtr self, IntPtr qualifiedName_str, int qualifiedName_length);
        public static cfx_xml_reader_get_attribute_byqname_delegate cfx_xml_reader_get_attribute_byqname;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_attribute_bylname(cef_xml_reader_t* self, char16 *localName_str, int localName_length, char16 *namespaceURI_str, int namespaceURI_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_attribute_bylname_delegate(IntPtr self, IntPtr localName_str, int localName_length, IntPtr namespaceURI_str, int namespaceURI_length);
        public static cfx_xml_reader_get_attribute_bylname_delegate cfx_xml_reader_get_attribute_bylname;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_inner_xml(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_inner_xml_delegate(IntPtr self);
        public static cfx_xml_reader_get_inner_xml_delegate cfx_xml_reader_get_inner_xml;

        // CFX_EXPORT cef_string_userfree_t cfx_xml_reader_get_outer_xml(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_xml_reader_get_outer_xml_delegate(IntPtr self);
        public static cfx_xml_reader_get_outer_xml_delegate cfx_xml_reader_get_outer_xml;

        // CFX_EXPORT int cfx_xml_reader_get_line_number(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_get_line_number_delegate(IntPtr self);
        public static cfx_xml_reader_get_line_number_delegate cfx_xml_reader_get_line_number;

        // CFX_EXPORT int cfx_xml_reader_move_to_attribute_byindex(cef_xml_reader_t* self, int index)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_attribute_byindex_delegate(IntPtr self, int index);
        public static cfx_xml_reader_move_to_attribute_byindex_delegate cfx_xml_reader_move_to_attribute_byindex;

        // CFX_EXPORT int cfx_xml_reader_move_to_attribute_byqname(cef_xml_reader_t* self, char16 *qualifiedName_str, int qualifiedName_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_attribute_byqname_delegate(IntPtr self, IntPtr qualifiedName_str, int qualifiedName_length);
        public static cfx_xml_reader_move_to_attribute_byqname_delegate cfx_xml_reader_move_to_attribute_byqname;

        // CFX_EXPORT int cfx_xml_reader_move_to_attribute_bylname(cef_xml_reader_t* self, char16 *localName_str, int localName_length, char16 *namespaceURI_str, int namespaceURI_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_attribute_bylname_delegate(IntPtr self, IntPtr localName_str, int localName_length, IntPtr namespaceURI_str, int namespaceURI_length);
        public static cfx_xml_reader_move_to_attribute_bylname_delegate cfx_xml_reader_move_to_attribute_bylname;

        // CFX_EXPORT int cfx_xml_reader_move_to_first_attribute(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_first_attribute_delegate(IntPtr self);
        public static cfx_xml_reader_move_to_first_attribute_delegate cfx_xml_reader_move_to_first_attribute;

        // CFX_EXPORT int cfx_xml_reader_move_to_next_attribute(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_next_attribute_delegate(IntPtr self);
        public static cfx_xml_reader_move_to_next_attribute_delegate cfx_xml_reader_move_to_next_attribute;

        // CFX_EXPORT int cfx_xml_reader_move_to_carrying_element(cef_xml_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_xml_reader_move_to_carrying_element_delegate(IntPtr self);
        public static cfx_xml_reader_move_to_carrying_element_delegate cfx_xml_reader_move_to_carrying_element;


        // CfxZipReader

        // CEF_EXPORT cef_zip_reader_t* cef_zip_reader_create(cef_stream_reader_t* stream);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_zip_reader_create_delegate(IntPtr stream);
        public static cfx_zip_reader_create_delegate cfx_zip_reader_create;

        // CFX_EXPORT int cfx_zip_reader_move_to_first_file(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_move_to_first_file_delegate(IntPtr self);
        public static cfx_zip_reader_move_to_first_file_delegate cfx_zip_reader_move_to_first_file;

        // CFX_EXPORT int cfx_zip_reader_move_to_next_file(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_move_to_next_file_delegate(IntPtr self);
        public static cfx_zip_reader_move_to_next_file_delegate cfx_zip_reader_move_to_next_file;

        // CFX_EXPORT int cfx_zip_reader_move_to_file(cef_zip_reader_t* self, char16 *fileName_str, int fileName_length, int caseSensitive)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_move_to_file_delegate(IntPtr self, IntPtr fileName_str, int fileName_length, int caseSensitive);
        public static cfx_zip_reader_move_to_file_delegate cfx_zip_reader_move_to_file;

        // CFX_EXPORT int cfx_zip_reader_close(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_close_delegate(IntPtr self);
        public static cfx_zip_reader_close_delegate cfx_zip_reader_close;

        // CFX_EXPORT cef_string_userfree_t cfx_zip_reader_get_file_name(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate IntPtr cfx_zip_reader_get_file_name_delegate(IntPtr self);
        public static cfx_zip_reader_get_file_name_delegate cfx_zip_reader_get_file_name;

        // CFX_EXPORT int64 cfx_zip_reader_get_file_size(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_zip_reader_get_file_size_delegate(IntPtr self);
        public static cfx_zip_reader_get_file_size_delegate cfx_zip_reader_get_file_size;

        // CFX_EXPORT int64 cfx_zip_reader_get_file_last_modified(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_zip_reader_get_file_last_modified_delegate(IntPtr self);
        public static cfx_zip_reader_get_file_last_modified_delegate cfx_zip_reader_get_file_last_modified;

        // CFX_EXPORT int cfx_zip_reader_open_file(cef_zip_reader_t* self, char16 *password_str, int password_length)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_open_file_delegate(IntPtr self, IntPtr password_str, int password_length);
        public static cfx_zip_reader_open_file_delegate cfx_zip_reader_open_file;

        // CFX_EXPORT int cfx_zip_reader_close_file(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_close_file_delegate(IntPtr self);
        public static cfx_zip_reader_close_file_delegate cfx_zip_reader_close_file;

        // CFX_EXPORT int cfx_zip_reader_read_file(cef_zip_reader_t* self, void* buffer, int bufferSize)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_read_file_delegate(IntPtr self, IntPtr buffer, int bufferSize);
        public static cfx_zip_reader_read_file_delegate cfx_zip_reader_read_file;

        // CFX_EXPORT int64 cfx_zip_reader_tell(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate long cfx_zip_reader_tell_delegate(IntPtr self);
        public static cfx_zip_reader_tell_delegate cfx_zip_reader_tell;

        // CFX_EXPORT int cfx_zip_reader_eof(cef_zip_reader_t* self)
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        public delegate int cfx_zip_reader_eof_delegate(IntPtr self);
        public static cfx_zip_reader_eof_delegate cfx_zip_reader_eof;


    }
}
