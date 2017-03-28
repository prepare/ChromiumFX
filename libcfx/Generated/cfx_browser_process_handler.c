// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_browser_process_handler

typedef struct _cfx_browser_process_handler_t {
    cef_browser_process_handler_t cef_browser_process_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_context_initialized)(gc_handle_t self);
    void (CEF_CALLBACK *on_before_child_process_launch)(gc_handle_t self, cef_command_line_t* command_line, int *command_line_release);
    void (CEF_CALLBACK *on_render_process_thread_created)(gc_handle_t self, cef_list_value_t* extra_info, int *extra_info_release);
    void (CEF_CALLBACK *get_print_handler)(gc_handle_t self, cef_print_handler_t** __retval);
    void (CEF_CALLBACK *on_schedule_message_pump_work)(gc_handle_t self, int64 delay_ms);
} cfx_browser_process_handler_t;

void CEF_CALLBACK _cfx_browser_process_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_browser_process_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_browser_process_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_browser_process_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_browser_process_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_browser_process_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_browser_process_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_browser_process_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_browser_process_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_browser_process_handler_t* cfx_browser_process_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_browser_process_handler_t* ptr = (cfx_browser_process_handler_t*)calloc(1, sizeof(cfx_browser_process_handler_t));
    if(!ptr) return 0;
    ptr->cef_browser_process_handler.base.size = sizeof(cef_browser_process_handler_t);
    ptr->cef_browser_process_handler.base.add_ref = _cfx_browser_process_handler_add_ref;
    ptr->cef_browser_process_handler.base.release = _cfx_browser_process_handler_release;
    ptr->cef_browser_process_handler.base.has_one_ref = _cfx_browser_process_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_context_initialized

void CEF_CALLBACK cfx_browser_process_handler_on_context_initialized(cef_browser_process_handler_t* self) {
    ((cfx_browser_process_handler_t*)self)->on_context_initialized(((cfx_browser_process_handler_t*)self)->gc_handle);
}

// on_before_child_process_launch

void CEF_CALLBACK cfx_browser_process_handler_on_before_child_process_launch(cef_browser_process_handler_t* self, cef_command_line_t* command_line) {
    int command_line_release;
    ((cfx_browser_process_handler_t*)self)->on_before_child_process_launch(((cfx_browser_process_handler_t*)self)->gc_handle, command_line, &command_line_release);
    if(command_line_release) command_line->base.release((cef_base_ref_counted_t*)command_line);
}

// on_render_process_thread_created

void CEF_CALLBACK cfx_browser_process_handler_on_render_process_thread_created(cef_browser_process_handler_t* self, cef_list_value_t* extra_info) {
    int extra_info_release;
    ((cfx_browser_process_handler_t*)self)->on_render_process_thread_created(((cfx_browser_process_handler_t*)self)->gc_handle, extra_info, &extra_info_release);
    if(extra_info_release) extra_info->base.release((cef_base_ref_counted_t*)extra_info);
}

// get_print_handler

cef_print_handler_t* CEF_CALLBACK cfx_browser_process_handler_get_print_handler(cef_browser_process_handler_t* self) {
    cef_print_handler_t* __retval;
    ((cfx_browser_process_handler_t*)self)->get_print_handler(((cfx_browser_process_handler_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// on_schedule_message_pump_work

void CEF_CALLBACK cfx_browser_process_handler_on_schedule_message_pump_work(cef_browser_process_handler_t* self, int64 delay_ms) {
    ((cfx_browser_process_handler_t*)self)->on_schedule_message_pump_work(((cfx_browser_process_handler_t*)self)->gc_handle, delay_ms);
}

static void cfx_browser_process_handler_set_callback(cef_browser_process_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_browser_process_handler_t*)self)->on_context_initialized = (void (CEF_CALLBACK *)(gc_handle_t self))callback;
        self->on_context_initialized = callback ? cfx_browser_process_handler_on_context_initialized : 0;
        break;
    case 1:
        ((cfx_browser_process_handler_t*)self)->on_before_child_process_launch = (void (CEF_CALLBACK *)(gc_handle_t self, cef_command_line_t* command_line, int *command_line_release))callback;
        self->on_before_child_process_launch = callback ? cfx_browser_process_handler_on_before_child_process_launch : 0;
        break;
    case 2:
        ((cfx_browser_process_handler_t*)self)->on_render_process_thread_created = (void (CEF_CALLBACK *)(gc_handle_t self, cef_list_value_t* extra_info, int *extra_info_release))callback;
        self->on_render_process_thread_created = callback ? cfx_browser_process_handler_on_render_process_thread_created : 0;
        break;
    case 3:
        ((cfx_browser_process_handler_t*)self)->get_print_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_print_handler_t** __retval))callback;
        self->get_print_handler = callback ? cfx_browser_process_handler_get_print_handler : 0;
        break;
    case 4:
        ((cfx_browser_process_handler_t*)self)->on_schedule_message_pump_work = (void (CEF_CALLBACK *)(gc_handle_t self, int64 delay_ms))callback;
        self->on_schedule_message_pump_work = callback ? cfx_browser_process_handler_on_schedule_message_pump_work : 0;
        break;
    }
}

