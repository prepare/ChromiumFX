// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_v8context

// CEF_EXPORT cef_v8context_t* cef_v8context_get_current_context();
static cef_v8context_t* cfx_v8context_get_current_context() {
    return cef_v8context_get_current_context();
}
// CEF_EXPORT cef_v8context_t* cef_v8context_get_entered_context();
static cef_v8context_t* cfx_v8context_get_entered_context() {
    return cef_v8context_get_entered_context();
}
// CEF_EXPORT int cef_v8context_in_context();
static int cfx_v8context_in_context() {
    return cef_v8context_in_context();
}
// get_task_runner
static cef_task_runner_t* cfx_v8context_get_task_runner(cef_v8context_t* self) {
    return self->get_task_runner(self);
}

// is_valid
static int cfx_v8context_is_valid(cef_v8context_t* self) {
    return self->is_valid(self);
}

// get_browser
static cef_browser_t* cfx_v8context_get_browser(cef_v8context_t* self) {
    return self->get_browser(self);
}

// get_frame
static cef_frame_t* cfx_v8context_get_frame(cef_v8context_t* self) {
    return self->get_frame(self);
}

// get_global
static cef_v8value_t* cfx_v8context_get_global(cef_v8context_t* self) {
    return self->get_global(self);
}

// enter
static int cfx_v8context_enter(cef_v8context_t* self) {
    return self->enter(self);
}

// exit
static int cfx_v8context_exit(cef_v8context_t* self) {
    return self->exit(self);
}

// is_same
static int cfx_v8context_is_same(cef_v8context_t* self, cef_v8context_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// eval
static int cfx_v8context_eval(cef_v8context_t* self, char16 *code_str, int code_length, char16 *script_url_str, int script_url_length, int start_line, cef_v8value_t** retval, cef_v8exception_t** exception) {
    cef_string_t code = { code_str, code_length, 0 };
    cef_string_t script_url = { script_url_str, script_url_length, 0 };
    return self->eval(self, &code, &script_url, start_line, retval, exception);
}


