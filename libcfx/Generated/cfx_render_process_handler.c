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

typedef struct _cfx_render_process_handler_t {
    cef_render_process_handler_t cef_render_process_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *on_render_thread_created)(gc_handle_t self, cef_list_value_t* extra_info, int *_release_extra_info);
    void (CEF_CALLBACK *on_web_kit_initialized)(gc_handle_t self);
    void (CEF_CALLBACK *on_browser_created)(gc_handle_t self, cef_browser_t* browser, int *_release_browser);
    void (CEF_CALLBACK *on_browser_destroyed)(gc_handle_t self, cef_browser_t* browser, int *_release_browser);
    void (CEF_CALLBACK *get_load_handler)(gc_handle_t self, cef_load_handler_t** __retval);
    void (CEF_CALLBACK *on_before_navigation)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_request_t* request, int *_release_request, cef_navigation_type_t navigation_type, int is_redirect);
    void (CEF_CALLBACK *on_context_created)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context);
    void (CEF_CALLBACK *on_context_released)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context);
    void (CEF_CALLBACK *on_uncaught_exception)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context, cef_v8exception_t* exception, int *_release_exception, cef_v8stack_trace_t* stackTrace, int *_release_stackTrace);
    void (CEF_CALLBACK *on_focused_node_changed)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_domnode_t* node, int *_release_node);
    void (CEF_CALLBACK *on_process_message_received)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, cef_process_id_t source_process, cef_process_message_t* message, int *_release_message);
} cfx_render_process_handler_t;

void CEF_CALLBACK _cfx_render_process_handler_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_render_process_handler_t*)base)->ref_count);
    if(count == 2) {
        cfx_set_native_reference(((cfx_render_process_handler_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_render_process_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_render_process_handler_t*)base)->ref_count);
    if(count == 1) {
        cfx_set_native_reference(((cfx_render_process_handler_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_render_process_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_render_process_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_render_process_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_render_process_handler_t* cfx_render_process_handler_ctor(gc_handle_t gc_handle) {
    cfx_render_process_handler_t* ptr = (cfx_render_process_handler_t*)calloc(1, sizeof(cfx_render_process_handler_t));
    if(!ptr) return 0;
    ptr->cef_render_process_handler.base.size = sizeof(cef_render_process_handler_t);
    ptr->cef_render_process_handler.base.add_ref = _cfx_render_process_handler_add_ref;
    ptr->cef_render_process_handler.base.release = _cfx_render_process_handler_release;
    ptr->cef_render_process_handler.base.has_one_ref = _cfx_render_process_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_render_process_handler_get_gc_handle(cfx_render_process_handler_t* self) {
    return self->gc_handle;
}

// on_render_thread_created

void CEF_CALLBACK cfx_render_process_handler_on_render_thread_created(cef_render_process_handler_t* self, cef_list_value_t* extra_info) {
    int _release_extra_info;
    ((cfx_render_process_handler_t*)self)->on_render_thread_created(((cfx_render_process_handler_t*)self)->gc_handle, extra_info, &_release_extra_info);
    if(_release_extra_info) extra_info->base.release((cef_base_t*)extra_info);
}

// on_web_kit_initialized

void CEF_CALLBACK cfx_render_process_handler_on_web_kit_initialized(cef_render_process_handler_t* self) {
    ((cfx_render_process_handler_t*)self)->on_web_kit_initialized(((cfx_render_process_handler_t*)self)->gc_handle);
}

// on_browser_created

void CEF_CALLBACK cfx_render_process_handler_on_browser_created(cef_render_process_handler_t* self, cef_browser_t* browser) {
    int _release_browser;
    ((cfx_render_process_handler_t*)self)->on_browser_created(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
}

// on_browser_destroyed

void CEF_CALLBACK cfx_render_process_handler_on_browser_destroyed(cef_render_process_handler_t* self, cef_browser_t* browser) {
    int _release_browser;
    ((cfx_render_process_handler_t*)self)->on_browser_destroyed(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
}

// get_load_handler

cef_load_handler_t* CEF_CALLBACK cfx_render_process_handler_get_load_handler(cef_render_process_handler_t* self) {
    cef_load_handler_t* __retval;
    ((cfx_render_process_handler_t*)self)->get_load_handler(((cfx_render_process_handler_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// on_before_navigation

int CEF_CALLBACK cfx_render_process_handler_on_before_navigation(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, int is_redirect) {
    int __retval;
    int _release_browser;
    int _release_frame;
    int _release_request;
    ((cfx_render_process_handler_t*)self)->on_before_navigation(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, &_release_browser, frame, &_release_frame, request, &_release_request, navigation_type, is_redirect);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_frame) frame->base.release((cef_base_t*)frame);
    if(_release_request) request->base.release((cef_base_t*)request);
    return __retval;
}

// on_context_created

void CEF_CALLBACK cfx_render_process_handler_on_context_created(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    int _release_browser;
    int _release_frame;
    int _release_context;
    ((cfx_render_process_handler_t*)self)->on_context_created(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser, frame, &_release_frame, context, &_release_context);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_frame) frame->base.release((cef_base_t*)frame);
    if(_release_context) context->base.release((cef_base_t*)context);
}

// on_context_released

void CEF_CALLBACK cfx_render_process_handler_on_context_released(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    int _release_browser;
    int _release_frame;
    int _release_context;
    ((cfx_render_process_handler_t*)self)->on_context_released(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser, frame, &_release_frame, context, &_release_context);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_frame) frame->base.release((cef_base_t*)frame);
    if(_release_context) context->base.release((cef_base_t*)context);
}

// on_uncaught_exception

void CEF_CALLBACK cfx_render_process_handler_on_uncaught_exception(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace) {
    int _release_browser;
    int _release_frame;
    int _release_context;
    int _release_exception;
    int _release_stackTrace;
    ((cfx_render_process_handler_t*)self)->on_uncaught_exception(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser, frame, &_release_frame, context, &_release_context, exception, &_release_exception, stackTrace, &_release_stackTrace);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_frame) frame->base.release((cef_base_t*)frame);
    if(_release_context) context->base.release((cef_base_t*)context);
    if(_release_exception) exception->base.release((cef_base_t*)exception);
    if(_release_stackTrace) stackTrace->base.release((cef_base_t*)stackTrace);
}

// on_focused_node_changed

void CEF_CALLBACK cfx_render_process_handler_on_focused_node_changed(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node) {
    int _release_browser;
    int _release_frame;
    int _release_node;
    ((cfx_render_process_handler_t*)self)->on_focused_node_changed(((cfx_render_process_handler_t*)self)->gc_handle, browser, &_release_browser, frame, &_release_frame, node, &_release_node);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_frame) frame->base.release((cef_base_t*)frame);
    if(_release_node) node->base.release((cef_base_t*)node);
}

// on_process_message_received

int CEF_CALLBACK cfx_render_process_handler_on_process_message_received(cef_render_process_handler_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    int _release_browser;
    int _release_message;
    ((cfx_render_process_handler_t*)self)->on_process_message_received(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, &_release_browser, source_process, message, &_release_message);
    if(_release_browser) browser->base.release((cef_base_t*)browser);
    if(_release_message) message->base.release((cef_base_t*)message);
    return __retval;
}

static void cfx_render_process_handler_set_callback(cef_render_process_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_render_process_handler_t*)self)->on_render_thread_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_list_value_t* extra_info, int *_release_extra_info))callback;
        self->on_render_thread_created = callback ? cfx_render_process_handler_on_render_thread_created : 0;
        break;
    case 1:
        ((cfx_render_process_handler_t*)self)->on_web_kit_initialized = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->on_web_kit_initialized = callback ? cfx_render_process_handler_on_web_kit_initialized : 0;
        break;
    case 2:
        ((cfx_render_process_handler_t*)self)->on_browser_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser))callback;
        self->on_browser_created = callback ? cfx_render_process_handler_on_browser_created : 0;
        break;
    case 3:
        ((cfx_render_process_handler_t*)self)->on_browser_destroyed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser))callback;
        self->on_browser_destroyed = callback ? cfx_render_process_handler_on_browser_destroyed : 0;
        break;
    case 4:
        ((cfx_render_process_handler_t*)self)->get_load_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval))callback;
        self->get_load_handler = callback ? cfx_render_process_handler_get_load_handler : 0;
        break;
    case 5:
        ((cfx_render_process_handler_t*)self)->on_before_navigation = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_request_t* request, int *_release_request, cef_navigation_type_t navigation_type, int is_redirect))callback;
        self->on_before_navigation = callback ? cfx_render_process_handler_on_before_navigation : 0;
        break;
    case 6:
        ((cfx_render_process_handler_t*)self)->on_context_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context))callback;
        self->on_context_created = callback ? cfx_render_process_handler_on_context_created : 0;
        break;
    case 7:
        ((cfx_render_process_handler_t*)self)->on_context_released = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context))callback;
        self->on_context_released = callback ? cfx_render_process_handler_on_context_released : 0;
        break;
    case 8:
        ((cfx_render_process_handler_t*)self)->on_uncaught_exception = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_v8context_t* context, int *_release_context, cef_v8exception_t* exception, int *_release_exception, cef_v8stack_trace_t* stackTrace, int *_release_stackTrace))callback;
        self->on_uncaught_exception = callback ? cfx_render_process_handler_on_uncaught_exception : 0;
        break;
    case 9:
        ((cfx_render_process_handler_t*)self)->on_focused_node_changed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *_release_browser, cef_frame_t* frame, int *_release_frame, cef_domnode_t* node, int *_release_node))callback;
        self->on_focused_node_changed = callback ? cfx_render_process_handler_on_focused_node_changed : 0;
        break;
    case 10:
        ((cfx_render_process_handler_t*)self)->on_process_message_received = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *_release_browser, cef_process_id_t source_process, cef_process_message_t* message, int *_release_message))callback;
        self->on_process_message_received = callback ? cfx_render_process_handler_on_process_message_received : 0;
        break;
    }
}

