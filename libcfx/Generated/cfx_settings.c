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

static cef_settings_t* cfx_settings_ctor() {
    cef_settings_t* self = (cef_settings_t*)calloc(1, sizeof(cef_settings_t));
    if(!self) return 0;
    self->size = sizeof(cef_settings_t);
    return self;
}

static void cfx_settings_dtor(cef_settings_t* self) {
    if(self->browser_subprocess_path.dtor) self->browser_subprocess_path.dtor(self->browser_subprocess_path.str);
    if(self->cache_path.dtor) self->cache_path.dtor(self->cache_path.str);
    if(self->user_agent.dtor) self->user_agent.dtor(self->user_agent.str);
    if(self->product_version.dtor) self->product_version.dtor(self->product_version.str);
    if(self->locale.dtor) self->locale.dtor(self->locale.str);
    if(self->log_file.dtor) self->log_file.dtor(self->log_file.str);
    if(self->javascript_flags.dtor) self->javascript_flags.dtor(self->javascript_flags.str);
    if(self->resources_dir_path.dtor) self->resources_dir_path.dtor(self->resources_dir_path.str);
    if(self->locales_dir_path.dtor) self->locales_dir_path.dtor(self->locales_dir_path.str);
    free(self);
}

// cef_settings_t->single_process
static void cfx_settings_set_single_process(cef_settings_t *self, int single_process) {
    self->single_process = single_process;
}
static void cfx_settings_get_single_process(cef_settings_t *self, int* single_process) {
    *single_process = self->single_process;
}

// cef_settings_t->no_sandbox
static void cfx_settings_set_no_sandbox(cef_settings_t *self, int no_sandbox) {
    self->no_sandbox = no_sandbox;
}
static void cfx_settings_get_no_sandbox(cef_settings_t *self, int* no_sandbox) {
    *no_sandbox = self->no_sandbox;
}

// cef_settings_t->browser_subprocess_path
static void cfx_settings_set_browser_subprocess_path(cef_settings_t *self, char16 *browser_subprocess_path_str, int browser_subprocess_path_length) {
    cef_string_utf16_set(browser_subprocess_path_str, browser_subprocess_path_length, &(self->browser_subprocess_path), 1);
}
static void cfx_settings_get_browser_subprocess_path(cef_settings_t *self, char16 **browser_subprocess_path_str, int *browser_subprocess_path_length) {
    *browser_subprocess_path_str = self->browser_subprocess_path.str;
    *browser_subprocess_path_length = (int)self->browser_subprocess_path.length;
}

// cef_settings_t->multi_threaded_message_loop
static void cfx_settings_set_multi_threaded_message_loop(cef_settings_t *self, int multi_threaded_message_loop) {
    self->multi_threaded_message_loop = multi_threaded_message_loop;
}
static void cfx_settings_get_multi_threaded_message_loop(cef_settings_t *self, int* multi_threaded_message_loop) {
    *multi_threaded_message_loop = self->multi_threaded_message_loop;
}

// cef_settings_t->windowless_rendering_enabled
static void cfx_settings_set_windowless_rendering_enabled(cef_settings_t *self, int windowless_rendering_enabled) {
    self->windowless_rendering_enabled = windowless_rendering_enabled;
}
static void cfx_settings_get_windowless_rendering_enabled(cef_settings_t *self, int* windowless_rendering_enabled) {
    *windowless_rendering_enabled = self->windowless_rendering_enabled;
}

// cef_settings_t->command_line_args_disabled
static void cfx_settings_set_command_line_args_disabled(cef_settings_t *self, int command_line_args_disabled) {
    self->command_line_args_disabled = command_line_args_disabled;
}
static void cfx_settings_get_command_line_args_disabled(cef_settings_t *self, int* command_line_args_disabled) {
    *command_line_args_disabled = self->command_line_args_disabled;
}

// cef_settings_t->cache_path
static void cfx_settings_set_cache_path(cef_settings_t *self, char16 *cache_path_str, int cache_path_length) {
    cef_string_utf16_set(cache_path_str, cache_path_length, &(self->cache_path), 1);
}
static void cfx_settings_get_cache_path(cef_settings_t *self, char16 **cache_path_str, int *cache_path_length) {
    *cache_path_str = self->cache_path.str;
    *cache_path_length = (int)self->cache_path.length;
}

// cef_settings_t->persist_session_cookies
static void cfx_settings_set_persist_session_cookies(cef_settings_t *self, int persist_session_cookies) {
    self->persist_session_cookies = persist_session_cookies;
}
static void cfx_settings_get_persist_session_cookies(cef_settings_t *self, int* persist_session_cookies) {
    *persist_session_cookies = self->persist_session_cookies;
}

// cef_settings_t->user_agent
static void cfx_settings_set_user_agent(cef_settings_t *self, char16 *user_agent_str, int user_agent_length) {
    cef_string_utf16_set(user_agent_str, user_agent_length, &(self->user_agent), 1);
}
static void cfx_settings_get_user_agent(cef_settings_t *self, char16 **user_agent_str, int *user_agent_length) {
    *user_agent_str = self->user_agent.str;
    *user_agent_length = (int)self->user_agent.length;
}

// cef_settings_t->product_version
static void cfx_settings_set_product_version(cef_settings_t *self, char16 *product_version_str, int product_version_length) {
    cef_string_utf16_set(product_version_str, product_version_length, &(self->product_version), 1);
}
static void cfx_settings_get_product_version(cef_settings_t *self, char16 **product_version_str, int *product_version_length) {
    *product_version_str = self->product_version.str;
    *product_version_length = (int)self->product_version.length;
}

// cef_settings_t->locale
static void cfx_settings_set_locale(cef_settings_t *self, char16 *locale_str, int locale_length) {
    cef_string_utf16_set(locale_str, locale_length, &(self->locale), 1);
}
static void cfx_settings_get_locale(cef_settings_t *self, char16 **locale_str, int *locale_length) {
    *locale_str = self->locale.str;
    *locale_length = (int)self->locale.length;
}

// cef_settings_t->log_file
static void cfx_settings_set_log_file(cef_settings_t *self, char16 *log_file_str, int log_file_length) {
    cef_string_utf16_set(log_file_str, log_file_length, &(self->log_file), 1);
}
static void cfx_settings_get_log_file(cef_settings_t *self, char16 **log_file_str, int *log_file_length) {
    *log_file_str = self->log_file.str;
    *log_file_length = (int)self->log_file.length;
}

// cef_settings_t->log_severity
static void cfx_settings_set_log_severity(cef_settings_t *self, cef_log_severity_t log_severity) {
    self->log_severity = log_severity;
}
static void cfx_settings_get_log_severity(cef_settings_t *self, cef_log_severity_t* log_severity) {
    *log_severity = self->log_severity;
}

// cef_settings_t->javascript_flags
static void cfx_settings_set_javascript_flags(cef_settings_t *self, char16 *javascript_flags_str, int javascript_flags_length) {
    cef_string_utf16_set(javascript_flags_str, javascript_flags_length, &(self->javascript_flags), 1);
}
static void cfx_settings_get_javascript_flags(cef_settings_t *self, char16 **javascript_flags_str, int *javascript_flags_length) {
    *javascript_flags_str = self->javascript_flags.str;
    *javascript_flags_length = (int)self->javascript_flags.length;
}

// cef_settings_t->resources_dir_path
static void cfx_settings_set_resources_dir_path(cef_settings_t *self, char16 *resources_dir_path_str, int resources_dir_path_length) {
    cef_string_utf16_set(resources_dir_path_str, resources_dir_path_length, &(self->resources_dir_path), 1);
}
static void cfx_settings_get_resources_dir_path(cef_settings_t *self, char16 **resources_dir_path_str, int *resources_dir_path_length) {
    *resources_dir_path_str = self->resources_dir_path.str;
    *resources_dir_path_length = (int)self->resources_dir_path.length;
}

// cef_settings_t->locales_dir_path
static void cfx_settings_set_locales_dir_path(cef_settings_t *self, char16 *locales_dir_path_str, int locales_dir_path_length) {
    cef_string_utf16_set(locales_dir_path_str, locales_dir_path_length, &(self->locales_dir_path), 1);
}
static void cfx_settings_get_locales_dir_path(cef_settings_t *self, char16 **locales_dir_path_str, int *locales_dir_path_length) {
    *locales_dir_path_str = self->locales_dir_path.str;
    *locales_dir_path_length = (int)self->locales_dir_path.length;
}

// cef_settings_t->pack_loading_disabled
static void cfx_settings_set_pack_loading_disabled(cef_settings_t *self, int pack_loading_disabled) {
    self->pack_loading_disabled = pack_loading_disabled;
}
static void cfx_settings_get_pack_loading_disabled(cef_settings_t *self, int* pack_loading_disabled) {
    *pack_loading_disabled = self->pack_loading_disabled;
}

// cef_settings_t->remote_debugging_port
static void cfx_settings_set_remote_debugging_port(cef_settings_t *self, int remote_debugging_port) {
    self->remote_debugging_port = remote_debugging_port;
}
static void cfx_settings_get_remote_debugging_port(cef_settings_t *self, int* remote_debugging_port) {
    *remote_debugging_port = self->remote_debugging_port;
}

// cef_settings_t->uncaught_exception_stack_size
static void cfx_settings_set_uncaught_exception_stack_size(cef_settings_t *self, int uncaught_exception_stack_size) {
    self->uncaught_exception_stack_size = uncaught_exception_stack_size;
}
static void cfx_settings_get_uncaught_exception_stack_size(cef_settings_t *self, int* uncaught_exception_stack_size) {
    *uncaught_exception_stack_size = self->uncaught_exception_stack_size;
}

// cef_settings_t->context_safety_implementation
static void cfx_settings_set_context_safety_implementation(cef_settings_t *self, int context_safety_implementation) {
    self->context_safety_implementation = context_safety_implementation;
}
static void cfx_settings_get_context_safety_implementation(cef_settings_t *self, int* context_safety_implementation) {
    *context_safety_implementation = self->context_safety_implementation;
}

// cef_settings_t->ignore_certificate_errors
static void cfx_settings_set_ignore_certificate_errors(cef_settings_t *self, int ignore_certificate_errors) {
    self->ignore_certificate_errors = ignore_certificate_errors;
}
static void cfx_settings_get_ignore_certificate_errors(cef_settings_t *self, int* ignore_certificate_errors) {
    *ignore_certificate_errors = self->ignore_certificate_errors;
}

// cef_settings_t->background_color
static void cfx_settings_set_background_color(cef_settings_t *self, uint32 background_color) {
    self->background_color = background_color;
}
static void cfx_settings_get_background_color(cef_settings_t *self, uint32* background_color) {
    *background_color = self->background_color;
}


#ifdef __cplusplus
} // extern "C"
#endif

