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


// cef_app

typedef struct _cfx_app_t {
    cef_app_t cef_app;
    unsigned int ref_count;
    gc_handle_t gc_handle;
    // managed callbacks
    void (CEF_CALLBACK *on_before_command_line_processing)(gc_handle_t self, char16 *process_type_str, int process_type_length, cef_command_line_t* command_line);
    void (CEF_CALLBACK *on_register_custom_schemes)(gc_handle_t self, cef_scheme_registrar_t* registrar);
    void (CEF_CALLBACK *get_resource_bundle_handler)(gc_handle_t self, cef_resource_bundle_handler_t** __retval);
    void (CEF_CALLBACK *get_browser_process_handler)(gc_handle_t self, cef_browser_process_handler_t** __retval);
    void (CEF_CALLBACK *get_render_process_handler)(gc_handle_t self, cef_render_process_handler_t** __retval);
} cfx_app_t;

void CEF_CALLBACK _cfx_app_add_ref(struct _cef_base_t* base) {
    int count = InterlockedIncrement(&((cfx_app_t*)base)->ref_count);
    if(count == 2) {
        ((cfx_app_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_app_t*)base)->gc_handle, count);
    }
}
int CEF_CALLBACK _cfx_app_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_app_t*)base)->ref_count);
    if(count == 1) {
        ((cfx_app_t*)base)->gc_handle = cfx_gc_handle_switch(((cfx_app_t*)base)->gc_handle, count);
    } else if(!count) {
        cfx_gc_handle_free(((cfx_app_t*)base)->gc_handle);
        free(base);
        return 1;
    }
    return 0;
}
int CEF_CALLBACK _cfx_app_has_one_ref(struct _cef_base_t* base) {
    return ((cfx_app_t*)base)->ref_count == 1 ? 1 : 0;
}

static cfx_app_t* cfx_app_ctor(gc_handle_t gc_handle) {
    cfx_app_t* ptr = (cfx_app_t*)calloc(1, sizeof(cfx_app_t));
    if(!ptr) return 0;
    ptr->cef_app.base.size = sizeof(cef_app_t);
    ptr->cef_app.base.add_ref = _cfx_app_add_ref;
    ptr->cef_app.base.release = _cfx_app_release;
    ptr->cef_app.base.has_one_ref = _cfx_app_has_one_ref;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_app_get_gc_handle(cfx_app_t* self) {
    return self->gc_handle;
}

// on_before_command_line_processing

void CEF_CALLBACK cfx_app_on_before_command_line_processing(cef_app_t* self, const cef_string_t* process_type, cef_command_line_t* command_line) {
    ((cfx_app_t*)self)->on_before_command_line_processing(((cfx_app_t*)self)->gc_handle, process_type ? process_type->str : 0, process_type ? (int)process_type->length : 0, command_line);
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
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_browser_process_handler

cef_browser_process_handler_t* CEF_CALLBACK cfx_app_get_browser_process_handler(cef_app_t* self) {
    cef_browser_process_handler_t* __retval;
    ((cfx_app_t*)self)->get_browser_process_handler(((cfx_app_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

// get_render_process_handler

cef_render_process_handler_t* CEF_CALLBACK cfx_app_get_render_process_handler(cef_app_t* self) {
    cef_render_process_handler_t* __retval;
    ((cfx_app_t*)self)->get_render_process_handler(((cfx_app_t*)self)->gc_handle, &__retval);
    if(__retval) {
        ((cef_base_t*)__retval)->add_ref((cef_base_t*)__retval);
    }
    return __retval;
}

static void cfx_app_set_callback(cef_app_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        ((cfx_app_t*)self)->on_before_command_line_processing = (void (CEF_CALLBACK *)(gc_handle_t self, char16 *process_type_str, int process_type_length, cef_command_line_t* command_line))callback;
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

