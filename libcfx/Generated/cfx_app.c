// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_app

typedef struct _cfx_app_t {
    cef_app_t cef_app;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_before_command_line_processing)(gc_handle_t self, char16 *process_type_str, int process_type_length, cef_command_line_t* command_line, int *command_line_release);
    void (CEF_CALLBACK *on_register_custom_schemes)(gc_handle_t self, cef_scheme_registrar_t* registrar);
    void (CEF_CALLBACK *get_resource_bundle_handler)(gc_handle_t self, cef_resource_bundle_handler_t** __retval);
    void (CEF_CALLBACK *get_browser_process_handler)(gc_handle_t self, cef_browser_process_handler_t** __retval);
    void (CEF_CALLBACK *get_render_process_handler)(gc_handle_t self, cef_render_process_handler_t** __retval);
} cfx_app_t;

void CEF_CALLBACK _cfx_app_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_app_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_app_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_app_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_app_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_app_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_app_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_app_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_app_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_app_t* cfx_app_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_app_t* ptr = (cfx_app_t*)calloc(1, sizeof(cfx_app_t));
    if(!ptr) return 0;
    ptr->cef_app.base.size = sizeof(cef_app_t);
    ptr->cef_app.base.add_ref = _cfx_app_add_ref;
    ptr->cef_app.base.release = _cfx_app_release;
    ptr->cef_app.base.has_one_ref = _cfx_app_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

// on_before_command_line_processing

void CEF_CALLBACK cfx_app_on_before_command_line_processing(cef_app_t* self, const cef_string_t* process_type, cef_command_line_t* command_line) {
    int command_line_release;
    ((cfx_app_t*)self)->on_before_command_line_processing(((cfx_app_t*)self)->gc_handle, process_type ? process_type->str : 0, process_type ? (int)process_type->length : 0, command_line, &command_line_release);
    if(command_line_release) command_line->base.release((cef_base_ref_counted_t*)command_line);
}

// on_register_custom_schemes

void CEF_CALLBACK cfx_app_on_register_custom_schemes(cef_app_t* self, cef_scheme_registrar_t* registrar) {
    ((cfx_app_t*)self)->on_register_custom_schemes(((cfx_app_t*)self)->gc_handle, registrar);
}

// get_resource_bundle_handler

cef_resource_bundle_handler_t* CEF_CALLBACK cfx_app_get_resource_bundle_handler(cef_app_t* self) {
    cef_resource_bundle_handler_t* __retval;
    ((cfx_app_t*)self)->get_resource_bundle_handler(((cfx_app_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// get_browser_process_handler

cef_browser_process_handler_t* CEF_CALLBACK cfx_app_get_browser_process_handler(cef_app_t* self) {
    cef_browser_process_handler_t* __retval;
    ((cfx_app_t*)self)->get_browser_process_handler(((cfx_app_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

// get_render_process_handler

cef_render_process_handler_t* CEF_CALLBACK cfx_app_get_render_process_handler(cef_app_t* self) {
    cef_render_process_handler_t* __retval;
    ((cfx_app_t*)self)->get_render_process_handler(((cfx_app_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_ref_counted_t*)__retval)->add_ref((cef_base_ref_counted_t*)__retval);
    }
    return __retval;
}

static void cfx_app_set_callback(cef_app_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_app_t*)self)->on_before_command_line_processing = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *process_type_str, int process_type_length, cef_command_line_t* command_line, int *command_line_release))callback;
        self->on_before_command_line_processing = callback ? cfx_app_on_before_command_line_processing : 0;
        break;
    case 1:
        ((cfx_app_t*)self)->on_register_custom_schemes = (void (CEF_CALLBACK *)(gc_handle_t self, cef_scheme_registrar_t* registrar))callback;
        self->on_register_custom_schemes = callback ? cfx_app_on_register_custom_schemes : 0;
        break;
    case 2:
        ((cfx_app_t*)self)->get_resource_bundle_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_resource_bundle_handler_t** __retval))callback;
        self->get_resource_bundle_handler = callback ? cfx_app_get_resource_bundle_handler : 0;
        break;
    case 3:
        ((cfx_app_t*)self)->get_browser_process_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_process_handler_t** __retval))callback;
        self->get_browser_process_handler = callback ? cfx_app_get_browser_process_handler : 0;
        break;
    case 4:
        ((cfx_app_t*)self)->get_render_process_handler = (void (CEF_CALLBACK *)(gc_handle_t self, cef_render_process_handler_t** __retval))callback;
        self->get_render_process_handler = callback ? cfx_app_get_render_process_handler : 0;
        break;
    }
}

