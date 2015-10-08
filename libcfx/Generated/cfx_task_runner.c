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


// cef_task_runner

// CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_current_thread();
static cef_task_runner_t* cfx_task_runner_get_for_current_thread() {
    return cef_task_runner_get_for_current_thread();
}
// CEF_EXPORT cef_task_runner_t* cef_task_runner_get_for_thread(cef_thread_id_t threadId);
static cef_task_runner_t* cfx_task_runner_get_for_thread(cef_thread_id_t threadId) {
    return cef_task_runner_get_for_thread(threadId);
}
// cef_base_t base

// is_same
static int cfx_task_runner_is_same(cef_task_runner_t* self, cef_task_runner_t* that) {
    if(that) ((cef_base_t*)that)->add_ref((cef_base_t*)that);
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
    if(task) ((cef_base_t*)task)->add_ref((cef_base_t*)task);
    return self->post_task(self, task);
}

// post_delayed_task
static int cfx_task_runner_post_delayed_task(cef_task_runner_t* self, cef_task_t* task, int64 delay_ms) {
    if(task) ((cef_base_t*)task)->add_ref((cef_base_t*)task);
    return self->post_delayed_task(self, task, delay_ms);
}


