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


// cef_settings

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_settings_t* cfx_settings_ctor() {
    cef_settings_t* ptr = (cef_settings_t*)calloc(1, sizeof(cef_settings_t));
    if(!ptr) return 0;
    ptr->size = sizeof(cef_settings_t);
    return ptr;
}

CFX_EXPORT void cfx_settings_dtor(cef_settings_t* ptr) {
    if(ptr->browser_subprocess_path.dtor) ptr->browser_subprocess_path.dtor(ptr->browser_subprocess_path.str);
    if(ptr->cache_path.dtor) ptr->cache_path.dtor(ptr->cache_path.str);
    if(ptr->user_agent.dtor) ptr->user_agent.dtor(ptr->user_agent.str);
    if(ptr->product_version.dtor) ptr->product_version.dtor(ptr->product_version.str);
    if(ptr->locale.dtor) ptr->locale.dtor(ptr->locale.str);
    if(ptr->log_file.dtor) ptr->log_file.dtor(ptr->log_file.str);
    if(ptr->javascript_flags.dtor) ptr->javascript_flags.dtor(ptr->javascript_flags.str);
    if(ptr->resources_dir_path.dtor) ptr->resources_dir_path.dtor(ptr->resources_dir_path.str);
    if(ptr->locales_dir_path.dtor) ptr->locales_dir_path.dtor(ptr->locales_dir_path.str);
    free(ptr);
}

CFX_EXPORT void cfx_settings_copy_to_native(cef_settings_t* self, int single_process, int no_sandbox, char16 *browser_subprocess_path_str, int browser_subprocess_path_length, int multi_threaded_message_loop, int windowless_rendering_enabled, int command_line_args_disabled, char16 *cache_path_str, int cache_path_length, int persist_session_cookies, char16 *user_agent_str, int user_agent_length, char16 *product_version_str, int product_version_length, char16 *locale_str, int locale_length, char16 *log_file_str, int log_file_length, cef_log_severity_t log_severity, char16 *javascript_flags_str, int javascript_flags_length, char16 *resources_dir_path_str, int resources_dir_path_length, char16 *locales_dir_path_str, int locales_dir_path_length, int pack_loading_disabled, int remote_debugging_port, int uncaught_exception_stack_size, int context_safety_implementation, int ignore_certificate_errors, uint32 background_color) {
    self->single_process = single_process;
    self->no_sandbox = no_sandbox;
    cef_string_utf16_set(browser_subprocess_path_str, browser_subprocess_path_length, &(self->browser_subprocess_path), 1);
    self->multi_threaded_message_loop = multi_threaded_message_loop;
    self->windowless_rendering_enabled = windowless_rendering_enabled;
    self->command_line_args_disabled = command_line_args_disabled;
    cef_string_utf16_set(cache_path_str, cache_path_length, &(self->cache_path), 1);
    self->persist_session_cookies = persist_session_cookies;
    cef_string_utf16_set(user_agent_str, user_agent_length, &(self->user_agent), 1);
    cef_string_utf16_set(product_version_str, product_version_length, &(self->product_version), 1);
    cef_string_utf16_set(locale_str, locale_length, &(self->locale), 1);
    cef_string_utf16_set(log_file_str, log_file_length, &(self->log_file), 1);
    self->log_severity = log_severity;
    cef_string_utf16_set(javascript_flags_str, javascript_flags_length, &(self->javascript_flags), 1);
    cef_string_utf16_set(resources_dir_path_str, resources_dir_path_length, &(self->resources_dir_path), 1);
    cef_string_utf16_set(locales_dir_path_str, locales_dir_path_length, &(self->locales_dir_path), 1);
    self->pack_loading_disabled = pack_loading_disabled;
    self->remote_debugging_port = remote_debugging_port;
    self->uncaught_exception_stack_size = uncaught_exception_stack_size;
    self->context_safety_implementation = context_safety_implementation;
    self->ignore_certificate_errors = ignore_certificate_errors;
    self->background_color = background_color;
}


#ifdef __cplusplus
} // extern "C"
#endif

