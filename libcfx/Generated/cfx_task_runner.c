// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_task_runner

// CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_current_thread();
static cef_task_runner_t* cfx_task_runner_get_for_current_thread() {
    return cef_task_runner_get_for_current_thread();
}
// CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_thread(cef_thread_id_t threadId);
static cef_task_runner_t* cfx_task_runner_get_for_thread(cef_thread_id_t threadId) {
    return cef_task_runner_get_for_thread(threadId);
}
// is_same
static int cfx_task_runner_is_same(cef_task_runner_t* self, cef_task_runner_t* that) {
    if(that) ((cef_base_ref_counted_t*)that)->add_ref((cef_base_ref_counted_t*)that);
    return self->is_same(self, that);
}

// belongs_to_current_thread
static int cfx_task_runner_belongs_to_current_thread(cef_task_runner_t* self) {
    return self->belongs_to_current_thread(self);
}

// belongs_to_thread
static int cfx_task_runner_belongs_to_thread(cef_task_runner_t* self, cef_thread_id_t threadId) {
    return self->belongs_to_thread(self, threadId);
}

// post_task
static int cfx_task_runner_post_task(cef_task_runner_t* self, cef_task_t* task) {
    if(task) ((cef_base_ref_counted_t*)task)->add_ref((cef_base_ref_counted_t*)task);
    return self->post_task(self, task);
}

// post_delayed_task
static int cfx_task_runner_post_delayed_task(cef_task_runner_t* self, cef_task_t* task, int64 delay_ms) {
    if(task) ((cef_base_ref_counted_t*)task)->add_ref((cef_base_ref_counted_t*)task);
    return self->post_delayed_task(self, task, delay_ms);
}


