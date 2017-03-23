// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


// cef_context_menu_handler

typedef struct _cfx_context_menu_handler_t {
    cef_context_menu_handler_t cef_context_menu_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    int wrapper_kind;
    // managed callbacks
    void (CEF_CALLBACK *on_before_context_menu)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, cef_menu_model_t* model, int *model_release);
    void (CEF_CALLBACK *run_context_menu)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, cef_menu_model_t* model, int *model_release, cef_run_context_menu_callback_t* callback, int *callback_release);
    void (CEF_CALLBACK *on_context_menu_command)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, int command_id, cef_event_flags_t event_flags);
    void (CEF_CALLBACK *on_context_menu_dismissed)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release);
} cfx_context_menu_handler_t;

void CEF_CALLBACK _cfx_context_menu_handler_add_ref(struct _cef_base_ref_counted_t* base) {
    InterlockedIncrement(&((cfx_context_menu_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_context_menu_handler_release(struct _cef_base_ref_counted_t* base) {
    int count = InterlockedDecrement(&((cfx_context_menu_handler_t*)base)->ref_count);
    if(count == 0) {
        if(((cfx_context_menu_handler_t*)base)->wrapper_kind == 0) {
            cfx_gc_handle_free(((cfx_context_menu_handler_t*)base)->gc_handle);
        } else {
            cfx_gc_handle_free_remote(((cfx_context_menu_handler_t*)base)->gc_handle);
        }
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_context_menu_handler_has_one_ref(struct _cef_base_ref_counted_t* base) {
    return ((cfx_context_menu_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_context_menu_handler_t* cfx_context_menu_handler_ctor(gc_handle_t gc_handle, int wrapper_kind) {
    cfx_context_menu_handler_t* ptr = (cfx_context_menu_handler_t*)calloc(1, sizeof(cfx_context_menu_handler_t));
    if(!ptr) return 0;
    ptr->cef_context_menu_handler.base.size = sizeof(cef_context_menu_handler_t);
    ptr->cef_context_menu_handler.base.add_ref = _cfx_context_menu_handler_add_ref;
    ptr->cef_context_menu_handler.base.release = _cfx_context_menu_handler_release;
    ptr->cef_context_menu_handler.base.has_one_ref = _cfx_context_menu_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    ptr->wrapper_kind = wrapper_kind;
    return ptr;
}

static gc_handle_t cfx_context_menu_handler_get_gc_handle(cfx_context_menu_handler_t* self) {
    return self->gc_handle;
}

// on_before_context_menu

void CEF_CALLBACK cfx_context_menu_handler_on_before_context_menu(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model) {
    int browser_release;
    int frame_release;
    int params_release;
    int model_release;
    ((cfx_context_menu_handler_t*)self)->on_before_context_menu(((cfx_context_menu_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release, params, &params_release, model, &model_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(params_release) params->base.release((cef_base_ref_counted_t*)params);
    if(model_release) model->base.release((cef_base_ref_counted_t*)model);
}

// run_context_menu

int CEF_CALLBACK cfx_context_menu_handler_run_context_menu(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback) {
    int __retval;
    int browser_release;
    int frame_release;
    int params_release;
    int model_release;
    int callback_release;
    ((cfx_context_menu_handler_t*)self)->run_context_menu(((cfx_context_menu_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, params, &params_release, model, &model_release, callback, &callback_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(params_release) params->base.release((cef_base_ref_counted_t*)params);
    if(model_release) model->base.release((cef_base_ref_counted_t*)model);
    if(callback_release) callback->base.release((cef_base_ref_counted_t*)callback);
    return __retval;
}

// on_context_menu_command

int CEF_CALLBACK cfx_context_menu_handler_on_context_menu_command(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags) {
    int __retval;
    int browser_release;
    int frame_release;
    int params_release;
    ((cfx_context_menu_handler_t*)self)->on_context_menu_command(((cfx_context_menu_handler_t*)self)->gc_handle, &__retval, browser, &browser_release, frame, &frame_release, params, &params_release, command_id, event_flags);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
    if(params_release) params->base.release((cef_base_ref_counted_t*)params);
    return __retval;
}

// on_context_menu_dismissed

void CEF_CALLBACK cfx_context_menu_handler_on_context_menu_dismissed(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame) {
    int browser_release;
    int frame_release;
    ((cfx_context_menu_handler_t*)self)->on_context_menu_dismissed(((cfx_context_menu_handler_t*)self)->gc_handle, browser, &browser_release, frame, &frame_release);
    if(browser_release) browser->base.release((cef_base_ref_counted_t*)browser);
    if(frame_release) frame->base.release((cef_base_ref_counted_t*)frame);
}

static void cfx_context_menu_handler_set_callback(cef_context_menu_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_context_menu_handler_t*)self)->on_before_context_menu = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, cef_menu_model_t* model, int *model_release))callback;
        self->on_before_context_menu = callback ? cfx_context_menu_handler_on_before_context_menu : 0;
        break;
    case 1:
        ((cfx_context_menu_handler_t*)self)->run_context_menu = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, cef_menu_model_t* model, int *model_release, cef_run_context_menu_callback_t* callback, int *callback_release))callback;
        self->run_context_menu = callback ? cfx_context_menu_handler_run_context_menu : 0;
        break;
    case 2:
        ((cfx_context_menu_handler_t*)self)->on_context_menu_command = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release, cef_context_menu_params_t* params, int *params_release, int command_id, cef_event_flags_t event_flags))callback;
        self->on_context_menu_command = callback ? cfx_context_menu_handler_on_context_menu_command : 0;
        break;
    case 3:
        ((cfx_context_menu_handler_t*)self)->on_context_menu_dismissed = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int *browser_release, cef_frame_t* frame, int *frame_release))callback;
        self->on_context_menu_dismissed = callback ? cfx_context_menu_handler_on_context_menu_dismissed : 0;
        break;
    }
}

