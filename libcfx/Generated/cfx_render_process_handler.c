// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_render_process_handler

typedef struct _cfx_render_process_handler_t {
    cef_render_process_handler_t cef_render_process_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_render_thread_created)(gc_handle_t self, cef_list_value_t* extra_info, int *extra_info_release);
    void (CEF_CALLBACK *on_web_kit_initialized)(gc_handle_t self);
    void (CEF_CALLBACK *on_browser_created)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *on_browser_destroyed)(gc_handle_t self, cef_browser_t* browser, int *browser_release);
    void (CEF_CALLBACK *get_load_handler)(gc_handle_t self, cef_load_handler_t** __retval);
    void (CEF_CALLBACK *on_before_navigation)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_navigation_type_t navigation_type, int is_redirect);
    void (CEF_CALLBACK *on_context_created)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release);
    void (CEF_CALLBACK *on_context_released)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release);
    void (CEF_CALLBACK *on_uncaught_exception)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release, cef_v8exception_t* exception, int *exception_release, cef_v8stack_trace_t* stackTrace, int *stackTrace_release);
    void (CEF_CALLBACK *on_focused_node_changed)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_domnode_t* node, int *node_release);
    void (CEF_CALLBACK *on_process_message_received)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_process_id_t source_process, cef_process_message_t* message, int *message_release);
} cfx_render_process_handler_t;

void CEF_CALLBACK _cfx_render_process_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_render_process_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_render_process_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_render_process_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_render_process_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_switch(&((cfx_render_process_handler_t*)base)->gc_handle, GC_HANDLE_FREE);
        } else {
            cfx_gc_handle_switch(&((cfx_render_process_handler_t*)base)->gc_handle, GC_HANDLE_FREE | GC_HANDLE_REMOTE);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_render_process_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_render_process_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_render_process_handler_t* cfx_render_process_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_render_process_handler_t* ptr = (cfx_render_process_handler_t*)calloc(1, sizeof(cfx_render_process_handler_t));
    if(!ptr) return 0;
    ptr->cef_render_process_handler.base.size = sizeof(cef_render_process_handler_t);
    ptr->cef_render_process_handler.base.add_ref = _cfx_render_process_handler_add_ref;
    ptr->cef_render_process_handler.base.release = _cfx_render_process_handler_release;
    ptr->cef_render_process_handler.base.has_one_ref = _cfx_render_process_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_render_thread_created

void CEF_CALLBACK cfx_render_process_handler_on_render_thread_created(cef_render_process_handler_t* self, cef_list_value_t* extra_info) {
    int extra_info_release;
    ((cfx_render_process_handler_t*)self)->on_render_thread_created(((cfx_render_process_handler_t*)self)->gc_handle, extra_info, &extra_info_release);
    if(extra_info_release && extra_info) extra_info->base.release((cef_base_ref_counted_t*)extra_info);
}

// on_web_kit_initialized

void CEF_CALLBACK cfx_render_process_handler_on_web_kit_initialized(cef_render_process_handler_t* self) {
    ((cfx_render_process_handler_t*)self)->on_web_kit_initialized(((cfx_render_process_handler_t*)self)->gc_handle);
}

// on_browser_created

void CEF_CALLBACK cfx_render_process_handler_on_browser_created(cef_render_process_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_render_process_handler_t*)self)->on_browser_created(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
}

// on_browser_destroyed

void CEF_CALLBACK cfx_render_process_handler_on_browser_destroyed(cef_render_process_handler_t* self, cef_browser_t* browser) {
    int browser_release;
    ((cfx_render_process_handler_t*)self)->on_browser_destroyed(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
}

// get_load_handler

cef_load_handler_t* CEF_CALLBACK cfx_render_process_handler_get_load_handler(cef_render_process_handler_t* self) {
    cef_load_handler_t* __retval;
    ((cfx_render_process_handler_t*)self)->get_load_handler(((cfx_render_process_handler_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// on_before_navigation

int CEF_CALLBACK cfx_render_process_handler_on_before_navigation(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, int is_redirect) {
    int __retval;
    int browser_release;
    int frame_release;
    int request_release;
    ((cfx_render_process_handler_t*)self)->on_before_navigation(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, request, &request_release, navigation_type, is_redirect);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(request_release && request) request->base.release((cef_base_ref_counted_t*)request);
    return __retval;
}

// on_context_created

void CEF_CALLBACK cfx_render_process_handler_on_context_created(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    int browser_release;
    int frame_release;
    int context_release;
    ((cfx_render_process_handler_t*)self)->on_context_created(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, context, &context_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(context_release && context) context->base.release((cef_base_ref_counted_t*)context);
}

// on_context_released

void CEF_CALLBACK cfx_render_process_handler_on_context_released(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context) {
    int browser_release;
    int frame_release;
    int context_release;
    ((cfx_render_process_handler_t*)self)->on_context_released(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, context, &context_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(context_release && context) context->base.release((cef_base_ref_counted_t*)context);
}

// on_uncaught_exception

void CEF_CALLBACK cfx_render_process_handler_on_uncaught_exception(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace) {
    int browser_release;
    int frame_release;
    int context_release;
    int exception_release;
    int stackTrace_release;
    ((cfx_render_process_handler_t*)self)->on_uncaught_exception(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, context, &context_release, exception, &exception_release, stackTrace, &stackTrace_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(context_release && context) context->base.release((cef_base_ref_counted_t*)context);
    if(exception_release && exception) exception->base.release((cef_base_ref_counted_t*)exception);
    if(stackTrace_release && stackTrace) stackTrace->base.release((cef_base_ref_counted_t*)stackTrace);
}

// on_focused_node_changed

void CEF_CALLBACK cfx_render_process_handler_on_focused_node_changed(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node) {
    int browser_release;
    int frame_release;
    int node_release;
    ((cfx_render_process_handler_t*)self)->on_focused_node_changed(((cfx_render_process_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, node, &node_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release && frame) frame->base.release((cef_base_ref_counted_t*)frame);
    if(node_release && node) node->base.release((cef_base_ref_counted_t*)node);
}

// on_process_message_received

int CEF_CALLBACK cfx_render_process_handler_on_process_message_received(cef_render_process_handler_t* self, cef_browser_t* browser, cef_process_id_t source_process, cef_process_message_t* message) {
    int __retval;
    int browser_release;
    int message_release;
    ((cfx_render_process_handler_t*)self)->on_process_message_received(((cfx_render_process_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, source_process, message, &message_release);
    if(browser_release && browser) browser->base.release((cef_base_ref_counted_t*)browser);
    if(message_release && message) message->base.release((cef_base_ref_counted_t*)message);
    return __retval;
}

static void cfx_render_process_handler_set_callback(cef_render_process_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_render_process_handler_t*)self)->on_render_thread_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_list_value_t* extra_info, int *extra_info_release))callback;
        self->on_render_thread_created = callback ? cfx_render_process_handler_on_render_thread_created : 0;
        break;
    case 1:
        ((cfx_render_process_handler_t*)self)->on_web_kit_initialized = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->on_web_kit_initialized = callback ? cfx_render_process_handler_on_web_kit_initialized : 0;
        break;
    case 2:
        ((cfx_render_process_handler_t*)self)->on_browser_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_browser_created = callback ? cfx_render_process_handler_on_browser_created : 0;
        break;
    case 3:
        ((cfx_render_process_handler_t*)self)->on_browser_destroyed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release))callback;
        self->on_browser_destroyed = callback ? cfx_render_process_handler_on_browser_destroyed : 0;
        break;
    case 4:
        ((cfx_render_process_handler_t*)self)->get_load_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_load_handler_t** __retval))callback;
        self->get_load_handler = callback ? cfx_render_process_handler_get_load_handler : 0;
        break;
    case 5:
        ((cfx_render_process_handler_t*)self)->on_before_navigation = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_request_t* request, int *request_release, cef_navigation_type_t navigation_type, int is_redirect))callback;
        self->on_before_navigation = callback ? cfx_render_process_handler_on_before_navigation : 0;
        break;
    case 6:
        ((cfx_render_process_handler_t*)self)->on_context_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release))callback;
        self->on_context_created = callback ? cfx_render_process_handler_on_context_created : 0;
        break;
    case 7:
        ((cfx_render_process_handler_t*)self)->on_context_released = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release))callback;
        self->on_context_released = callback ? cfx_render_process_handler_on_context_released : 0;
        break;
    case 8:
        ((cfx_render_process_handler_t*)self)->on_uncaught_exception = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_v8context_t* context, int *context_release, cef_v8exception_t* exception, int *exception_release, cef_v8stack_trace_t* stackTrace, int *stackTrace_release))callback;
        self->on_uncaught_exception = callback ? cfx_render_process_handler_on_uncaught_exception : 0;
        break;
    case 9:
        ((cfx_render_process_handler_t*)self)->on_focused_node_changed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_domnode_t* node, int *node_release))callback;
        self->on_focused_node_changed = callback ? cfx_render_process_handler_on_focused_node_changed : 0;
        break;
    case 10:
        ((cfx_render_process_handler_t*)self)->on_process_message_received = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_process_id_t source_process, cef_process_message_t* message, int *message_release))callback;
        self->on_process_message_received = callback ? cfx_render_process_handler_on_process_message_received : 0;
        break;
    }
}

