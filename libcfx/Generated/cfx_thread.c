// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_thread

// CEF_EXPORT cef_thread_t* cef_thread_create(const cef_string_t* display_name, cef_thread_priority_t priority, cef_message_loop_type_t message_loop_type, int stoppable, cef_com_init_mode_t com_init_mode);
static cef_thread_t* cfx_thread_create(char16 *display_name_str, int display_name_length, cef_thread_priority_t priority, cef_message_loop_type_t message_loop_type, int stoppable, cef_com_init_mode_t com_init_mode) {
    cef_string_t display_name = { display_name_str, display_name_length, 0 };
    return cef_thread_create(&display_name, priority, message_loop_type, stoppable, com_init_mode);
}
// get_task_runner
static cef_task_runner_t* cfx_thread_get_task_runner(cef_thread_t* self) {
    return self->get_task_runner(self);
}

// get_platform_thread_id
static cef_platform_thread_id_t cfx_thread_get_platform_thread_id(cef_thread_t* self) {
    return self->get_platform_thread_id(self);
}

// stop
static void cfx_thread_stop(cef_thread_t* self) {
    self->stop(self);
}

// is_running
static int cfx_thread_is_running(cef_thread_t* self) {
    return self->is_running(self);
}


