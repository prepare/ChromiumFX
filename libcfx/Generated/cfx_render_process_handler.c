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


// cef_render_process_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_render_process_handler_t {
    cef_render_process_handler_t cef_render_process_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_render_process_handler_t;

void CEF_CALLBACK _cfx_render_process_handler_add_ref(struct _cef_base_t* base) {
    cfx_render_process_handler_t* ptr = (cfx_render_process_handler_t*)base;
    InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_render_process_handler_release(struct _cef_base_t* base) {
    cfx_render_process_handler_t* ptr = (cfx_render_process_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_render_process_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_render_process_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}

CFX_EXPORT cfx_render_process_handler_t* cfx_render_process_handler_ctor(gc_handle_t gc_handle) {
    cfx_render_process_handler_t* ptr = (cfx_render_process_handler_t*)calloc(1, sizeof(cfx_render_process_handler_t));
    if(!ptr) return 0;
    ptr->cef_render_process_handler.base.size = sizeof(cef_render_process_handler_t);
    ptr->cef_render_process_handler.base.add_ref = _cfx_render_process_handler_add_ref;
    ptr->cef_render_process_handler.base.release = _cfx_render_process_handler_release;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_render_process_handler_get_gc_handle(cfx_render_process_handler_t* self) {
    return self->gc_handle;
}

// on_render_thread_created

void (CEF_CALLBACK *cfx_render_process_handler_on_render_thread_created_callback)(gc_handle_t self, cef_list_value_t* extra_info);

void CEF_CALLBACK cfx_render_process_handler_on_render_thread_created(cef_render_process_handler_t* self, cef_list_value_t* extra_info) {
    cfx_render_process_handler_on_render_thread_created_callback(((cfx_render_process_handler_t*)self)->gc_handle, extra_info);
}


// on_web_kit_initialized

void (CEF_CALLBACK *cfx_render_process_handler_on_web_kit_initialized_callback)(gc_handle_t self);

void CEF_CALLBACK cfx_render_process_handler_on_web_kit_initialized(cef_render_process_handler_t* self) {
    cfx_render_process_handler_on_web_kit_initialized_callback(((cfx_render_process_handler_t*)self)->gc_handle);
}


// on_browser_created

void (CEF_CALLBACK *cfx_render_process_handler_on_browser_created_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_render_process_handler_on_browser_created(cef_render_process_handler_t* self, cef_browser_t* browser) {
    cfx_render_process_handler_on_browser_created_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser);
}


// on_browser_destroyed

void (CEF_CALLBACK *cfx_render_process_handler_on_browser_destroyed_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_render_process_handler_on_browser_destroyed(cef_render_process_handler_t* self, cef_browser_t* browser) {
    cfx_render_process_handler_on_browser_destroyed_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser);
}


// get_load_handler

void (CEF_CALLBACK *cfx_render_process_handler_get_load_handler_callback)(gc_handle_t self, cef_load_handler_t** __retval);

cef_load_handler_t* CEF_CALLBACK cfx_render_process_handler_get_load_handler(cef_render_process_handler_t* self) {
    cef_load_handler_t* __retval;
    cfx_render_process_handler_get_load_handler_callback(((cfx_render_process_handler_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}


// on_before_navigation

void (CEF_CALLBACK *cfx_render_process_handler_on_before_navigation_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, int is_redirect);

int CEF_CALLBACK cfx_render_process_handler_on_before_navigation(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, int is_redirect) {
    int __retval;
    cfx_render_process_handler_on_before_navigation_callback(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, frame, request, navigation_type, is_redirect);
    return __retval;
}


// on_context_created

void (CEF_CALLBACK *cfx_render_process_handler_on_context_created_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context);

void CEF_CALLBACK cfx_render_process_handler_on_context_created(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    cfx_render_process_handler_on_context_created_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser, frame, context);
}


// on_context_released

void (CEF_CALLBACK *cfx_render_process_handler_on_context_released_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context);

void CEF_CALLBACK cfx_render_process_handler_on_context_released(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    cfx_render_process_handler_on_context_released_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser, frame, context);
}


// on_uncaught_exception

void (CEF_CALLBACK *cfx_render_process_handler_on_uncaught_exception_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace);

void CEF_CALLBACK cfx_render_process_handler_on_uncaught_exception(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace) {
    cfx_render_process_handler_on_uncaught_exception_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser, frame, context, exception, stackTrace);
}


// on_focused_node_changed

void (CEF_CALLBACK *cfx_render_process_handler_on_focused_node_changed_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node);

void CEF_CALLBACK cfx_render_process_handler_on_focused_node_changed(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node) {
    cfx_render_process_handler_on_focused_node_changed_callback(((cfx_render_process_handler_t*)self)->gc_handle, browser, frame, node);
}


// on_process_message_received

void (CEF_CALLBACK *cfx_render_process_handler_on_process_message_received_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message);

int CEF_CALLBACK cfx_render_process_handler_on_process_message_received(cef_render_process_handler_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    cfx_render_process_handler_on_process_message_received_callback(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, source_process, message);
    return __retval;
}


CFX_EXPORT void cfx_render_process_handler_activate_callback(cef_render_process_handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->on_render_thread_created = is_active ? cfx_render_process_handler_on_render_thread_created : 0;
        break;
    case 1:
        self->on_web_kit_initialized = is_active ? cfx_render_process_handler_on_web_kit_initialized : 0;
        break;
    case 2:
        self->on_browser_created = is_active ? cfx_render_process_handler_on_browser_created : 0;
        break;
    case 3:
        self->on_browser_destroyed = is_active ? cfx_render_process_handler_on_browser_destroyed : 0;
        break;
    case 4:
        self->get_load_handler = is_active ? cfx_render_process_handler_get_load_handler : 0;
        break;
    case 5:
        self->on_before_navigation = is_active ? cfx_render_process_handler_on_before_navigation : 0;
        break;
    case 6:
        self->on_context_created = is_active ? cfx_render_process_handler_on_context_created : 0;
        break;
    case 7:
        self->on_context_released = is_active ? cfx_render_process_handler_on_context_released : 0;
        break;
    case 8:
        self->on_uncaught_exception = is_active ? cfx_render_process_handler_on_uncaught_exception : 0;
        break;
    case 9:
        self->on_focused_node_changed = is_active ? cfx_render_process_handler_on_focused_node_changed : 0;
        break;
    case 10:
        self->on_process_message_received = is_active ? cfx_render_process_handler_on_process_message_received : 0;
        break;
    }
}
CFX_EXPORT void cfx_render_process_handler_set_callback_ptrs(void *cb_0, void *cb_1, void *cb_2, void *cb_3, void *cb_4, void *cb_5, void *cb_6, void *cb_7, void *cb_8, void *cb_9, void *cb_10) {
    cfx_render_process_handler_on_render_thread_created_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_list_value_t* extra_info)) cb_0;
    cfx_render_process_handler_on_web_kit_initialized_callback = (void (CEF_CALLBACK *)(gc_handle_t self)) cb_1;
    cfx_render_process_handler_on_browser_created_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) cb_2;
    cfx_render_process_handler_on_browser_destroyed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) cb_3;
    cfx_render_process_handler_get_load_handler_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval)) cb_4;
    cfx_render_process_handler_on_before_navigation_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, int is_redirect)) cb_5;
    cfx_render_process_handler_on_context_created_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)) cb_6;
    cfx_render_process_handler_on_context_released_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)) cb_7;
    cfx_render_process_handler_on_uncaught_exception_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)) cb_8;
    cfx_render_process_handler_on_focused_node_changed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)) cb_9;
    cfx_render_process_handler_on_process_message_received_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message)) cb_10;
}

#ifdef __cplusplus
} // extern "C"
#endif

