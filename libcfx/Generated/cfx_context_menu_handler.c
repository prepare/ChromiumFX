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


// cef_context_menu_handler

typedef struct _cfx_context_menu_handler_t {
    cef_context_menu_handler_t cef_context_menu_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_context_menu_handler_t;

void CEF_CALLBACK _cfx_context_menu_handler_add_ref(struct _cef_base_t* base) {
    InterlockedIncrement(&((cfx_context_menu_handler_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_context_menu_handler_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_context_menu_handler_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_context_menu_handler_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_context_menu_handler_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_context_menu_handler_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_context_menu_handler_t* cfx_context_menu_handler_ctor(gc_handle_t gc_handle) {
    cfx_context_menu_handler_t* ptr = (cfx_context_menu_handler_t*)calloc(1, sizeof(cfx_context_menu_handler_t));
    if(!ptr) return 0;
    ptr->cef_context_menu_handler.base.size = sizeof(cef_context_menu_handler_t);
    ptr->cef_context_menu_handler.base.add_ref = _cfx_context_menu_handler_add_ref;
    ptr->cef_context_menu_handler.base.release = _cfx_context_menu_handler_release;
    ptr->cef_context_menu_handler.base.has_one_ref = _cfx_context_menu_handler_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_context_menu_handler_get_gc_handle(cfx_context_menu_handler_t* self) {
    return self->gc_handle;
}

// on_before_context_menu

void (CEF_CALLBACK *cfx_context_menu_handler_on_before_context_menu_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model);

void CEF_CALLBACK cfx_context_menu_handler_on_before_context_menu(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model) {
    cfx_context_menu_handler_on_before_context_menu_callback(((cfx_context_menu_handler_t*)self)->gc_handle, browser, frame, params, model);
}


// run_context_menu

void (CEF_CALLBACK *cfx_context_menu_handler_run_context_menu_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback);

int CEF_CALLBACK cfx_context_menu_handler_run_context_menu(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback) {
    int __retval;
    cfx_context_menu_handler_run_context_menu_callback(((cfx_context_menu_handler_t*)self)->gc_handle, &__retval, browser, frame, params, model, callback);
    return __retval;
}


// on_context_menu_command

void (CEF_CALLBACK *cfx_context_menu_handler_on_context_menu_command_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags);

int CEF_CALLBACK cfx_context_menu_handler_on_context_menu_command(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags) {
    int __retval;
    cfx_context_menu_handler_on_context_menu_command_callback(((cfx_context_menu_handler_t*)self)->gc_handle, &__retval, browser, frame, params, command_id, event_flags);
    return __retval;
}


// on_context_menu_dismissed

void (CEF_CALLBACK *cfx_context_menu_handler_on_context_menu_dismissed_callback)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame);

void CEF_CALLBACK cfx_context_menu_handler_on_context_menu_dismissed(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame) {
    cfx_context_menu_handler_on_context_menu_dismissed_callback(((cfx_context_menu_handler_t*)self)->gc_handle, browser, frame);
}


static void cfx_context_menu_handler_set_managed_callback(cef_context_menu_handler_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_context_menu_handler_on_before_context_menu_callback)
            cfx_context_menu_handler_on_before_context_menu_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model)) callback;
        self->on_before_context_menu = callback ? cfx_context_menu_handler_on_before_context_menu : 0;
        break;
    case 1:
        if(callback && !cfx_context_menu_handler_run_context_menu_callback)
            cfx_context_menu_handler_run_context_menu_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback)) callback;
        self->run_context_menu = callback ? cfx_context_menu_handler_run_context_menu : 0;
        break;
    case 2:
        if(callback && !cfx_context_menu_handler_on_context_menu_command_callback)
            cfx_context_menu_handler_on_context_menu_command_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags)) callback;
        self->on_context_menu_command = callback ? cfx_context_menu_handler_on_context_menu_command : 0;
        break;
    case 3:
        if(callback && !cfx_context_menu_handler_on_context_menu_dismissed_callback)
            cfx_context_menu_handler_on_context_menu_dismissed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_frame_t* frame)) callback;
        self->on_context_menu_dismissed = callback ? cfx_context_menu_handler_on_context_menu_dismissed : 0;
        break;
    }
}

